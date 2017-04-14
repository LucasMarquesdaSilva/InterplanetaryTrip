CREATE DATABASE InterplanetaryTrip
GO
USE InterplanetaryTrip;
GO
CREATE TABLE Planeta(
	Id				INT IDENTITY,
    Nome			VARCHAR(200)	NOT NULL,
	Descricao		VARCHAR(200)	NOT NULL,
    PossuiOxigenio	BIT				NOT NULL,
	PRIMARY KEY		(Id)
)

CREATE TABLE Cliente(
	Id				INT IDENTITY,
	Nome			VARCHAR(200)	NOT NULL,
	Documento		VARCHAR(200)	NOT NULL,
	Cor				VARCHAR(200)	NOT NULL,
	TipoEspecie		VARCHAR(200)	NOT NULL,
	QtdBracos		INT				NOT NULL,
	QtdPernas		INT				NOT NULL,
	QtdCabeca		INT				NOT NULL,
	Respira			BIT				NOT NULL,
	PRIMARY KEY		(Id)
)


CREATE TABLE Transporte(
	Id			INT IDENTITY,
	Nome		VARCHAR (200)	NOT NULL,
	Terreno		VARCHAR(200)	NOT NULL,
	PRIMARY KEY (Id)
)

CREATE TABLE Viagem(
	 Id					INT IDENTITY,
     IdPlanetaOrigem	INT				NOT NULL,
     IdPlanetaDestino	INT				NOT NULL,
     IdCliente			INT				NOT NULL,
	 IdTransporte		INT				NOT NULL,
     Valor				MONEY			NOT NULL,
     Tempo				VARCHAR(200)	NOT NULL,
	 PRIMARY KEY		(Id),
	 FOREIGN KEY		(IdPlanetaOrigem)	REFERENCES Planeta (Id),
	 FOREIGN KEY		(IdPlanetaDestino)	REFERENCES Planeta (Id),
	 FOREIGN KEY		(IdCliente)			REFERENCES Cliente (Id),
	 FOREIGN KEY		(IdTransporte)		REFERENCES Transporte (Id)
)



---------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE cliente_spi(
	@Nome			VARCHAR(200),
	@Documento		VARCHAR(200),
	@TipoEspecie	VARCHAR(200),
	@Cor			VARCHAR(200),
	@QtdBracos		INT,
	@QtdPernas		INT,
	@QtdCabeca		INT,
	@Respira		BIT
)

AS

BEGIN
	INSERT  
		INTO Cliente
	VALUES
		(@Nome, @Documento, @TipoEspecie, @Cor, @QtdBracos, @QtdPernas, @QtdCabeca, @Respira)

	SELECT 'Cadastro Realizado com sucesso!' AS [Mensagem]
END
GO
CREATE PROCEDURE cliente_spu(
	@Nome			VARCHAR(200),
	@Documento		VARCHAR(200),
	@TipoEspecie	VARCHAR(200),
	@Cor			VARCHAR(200),
	@QtdBracos		INT,
	@QtdPernas		INT,
	@QtdCabeca		INT,
	@Respira		BIT,
	@NomeParaTroca	VARCHAR(200)
)

AS
BEGIN
	UPDATE Cliente
	SET 
		Nome		=	@Nome, 
		Documento	=	@Documento,
		TipoEspecie =	@TipoEspecie,
		Cor			=	@Cor, 
		QtdBracos	=	@QtdBracos, 
		QtdPernas	=	@QtdPernas, 
		QtdCabeca	=	@QtdCabeca,
		Respira		=	@Respira
	WHERE 
		Nome = @NomeParaTroca
	SELECT 'Cliente ' + @Nome + 'atualizado com sucesso!' AS [Mensagem]
END
GO
CREATE PROCEDURE cliente_sps(
	@Nome VARCHAR(200)
)

AS

BEGIN
	SELECT * FROM Cliente WHERE(Nome LIKE '%' + @Nome + '%')
END
GO
CREATE PROCEDURE cliente_spd(
	@Id INT
)
AS

BEGIN
	DELETE FROM Cliente WHERE id = @Id
	SELECT 'Cliente  deletado com sucesso!' AS [Mensagem]

END

---------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE planeta_spi(
	@Nome		VARCHAR(200),
	@Descricao	VARCHAR(200),
	@PossuiOxigenio	BIT
)

AS
BEGIN
	INSERT  
		INTO Planeta
	VALUES
		(@Nome, @Descricao, @PossuiOxigenio)
	SELECT 'Cadastro Realizado com sucesso!' AS [Mensagem]
END

GO
CREATE PROCEDURE planeta_spu(
	@Id INT,
	@Nome VARCHAR(200),
	@Descricao VARCHAR(200),
	@PossuiOxigenio	BIT
)

AS

BEGIN
	UPDATE Planeta
	SET 
		Nome = @Nome, 
		Descricao = @Descricao, 
		PossuiOxigenio = @PossuiOxigenio
	WHERE 
		Id = @Id
	SELECT ('Planeta atualizado com sucesso!') AS [Mensagem]
END
GO
CREATE PROCEDURE planeta_sps(
@Nome VARCHAR(200)
)
AS
BEGIN
	SELECT * FROM Planeta WHERE(Nome LIKE '%' + @Nome + '%')
END

GO
CREATE PROCEDURE planeta_spd(
	@id INT
)

AS
BEGIN
	DELETE FROM Planeta WHERE Id = @id

	SELECT ('Planeta deletado com sucesso!') AS [Mensagem]

END

---------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE viagem_spi(
	@IdPlanetaOrigem	INT,
	@IdPlanetaDestino	INT,
	@IdCliente			INT,
	@IdTransporte		INT,
	@Valor				MONEY,
	@Tempo				VARCHAR(200)
)

AS
BEGIN
	INSERT  
		INTO Viagem
	VALUES
		(@IdPlanetaOrigem, @IdPlanetaDestino, @IdCliente, @IdTransporte, @Valor, @Tempo)

	SELECT 'Cadastro Realizado com sucesso!' AS [Mensagem]
END
GO
CREATE PROCEDURE viagem_spu(
	@IdPlanetaOrigem		INT,
	@IdPlanetaDestino		INT,
	@IdCliente				INT,
	@IdTransporte			INT,
	@Valor					MONEY,
	@Tempo					VARCHAR(200),
	@IdPlanetaParaTroca		INT
)

AS

BEGIN
	UPDATE Viagem
	SET 
		IdPlanetaOrigem		=	@IdPlanetaOrigem, 
		IdPlanetaDestino	=	@IdPlanetaDestino, 
		IdCliente			=	@IdCliente,
		IdTransporte		=	@IdTransporte,
		Valor				=	@Valor,
		Tempo				=	@Tempo
	WHERE 
		Id = @IdPlanetaParaTroca

	SELECT 'Viagem alterada com sucesso!' AS [Mensagem]
	
END
GO
CREATE PROCEDURE viagem_sps(
@Id INT
)

AS
BEGIN

SELECT 
		V.Id, C.Nome AS nomeCliente, C.Documento,
		C.Respira, PO.Nome as NomePlanetaOrigem,
		PD.Nome as NomePlanetaDestino,  
		V.Valor, V.Tempo, T.Nome  as TransporteNome, T.Terreno
	FROM
		Cliente C
		join Viagem V on V.IdCliente = C.Id
		join Transporte T on T.Id = V.IdTransporte
		join Planeta PO on PO.Id = V.IdPlanetaOrigem
		join Planeta PD on PD.Id = V.IdPlanetaDestino
	WHERE 
		V.Id =  @Id 
END
GO
CREATE PROCEDURE viagem_spd(
	@Id INT
)
AS

BEGIN
	DELETE FROM Viagem WHERE Id = @Id
END

---------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE transporte_spi(
	@Nome		VARCHAR(200),
	@Terreno	VARCHAR(200)
)

AS

BEGIN
	INSERT  
		INTO Transporte
	VALUES
		(@Nome, @Terreno)
	SELECT 'Viagem alterada com sucesso!' AS [Mensagem]

END

GO
CREATE PROCEDURE transporte_spu(
	@Nome						VARCHAR(200),
	@Terreno					VARCHAR(200),
	@NomeTransporteParaTroca	VARCHAR(200)
)

AS

BEGIN
	UPDATE Transporte
	SET 
		Nome		=	@Nome, 
		Terreno		=	@Terreno
	WHERE 
		Nome = @NomeTransporteParaTroca
END
GO
CREATE PROCEDURE transporte_sps(
	@Nome VARCHAR(200)
)

AS

BEGIN
	SELECT * FROM Transporte  WHERE(Nome LIKE '%' + @Nome + '%')
END

GO
CREATE PROCEDURE transporte_spd(
	@Nome VARCHAR(200)
)
AS

BEGIN
	DELETE FROM Transporte WHERE Nome = @Nome
END

