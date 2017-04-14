using InterplanetaryTrip.Model.classes;
using InterplanetaryTrip.Model.Entidades;
using InterplanetaryTrip.Model.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            var RespostaUsuario = "";
            do
            {
                Console.WriteLine("Bem vindo ao Sistema de Viagens Interplanetárias!");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("\n\rMenu");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Consulta");
                Console.WriteLine("3 - Atualização");
                Console.WriteLine("4 - Remoção");
                Console.WriteLine("5 - Sair");
                RespostaUsuario = Console.ReadLine();

                if (RespostaUsuario == "1")
                {
                    navegarMenuCadastroGeral();
                }
                else if (RespostaUsuario == "2")
                {
                    navegarMenuConsultaGeral();
                }
                else if (RespostaUsuario == "3")
                {
                    navegarMenuAtualizacaoGeral();
                }
                else if (RespostaUsuario == "4")
                {
                    navegarMenuExclusaoGeral();
                }

            } while (RespostaUsuario != "5");
        }

        private static void navegarMenuExclusaoGeral()
        {
            var RespostaUsuarioExcluir = "";
            do
            {
                Console.WriteLine("Menu 4 - Excluir");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1 - Excluir Planeta");
                Console.WriteLine("2 - Excluir Cliente");
                Console.WriteLine("3 - Excluir Transporte");
                Console.WriteLine("4 - Excluir Viagem");
                Console.WriteLine("5 - Voltar");
                RespostaUsuarioExcluir = Console.ReadLine();
                if (RespostaUsuarioExcluir == "1")
                {
                    navegarRemocaoPlaneta();
                }
                else if (RespostaUsuarioExcluir == "2")
                {
                    try
                    {
                        Console.WriteLine("Digite o nome do cliente que voce deseja excluir:");
                        var nomeCliente = Console.ReadLine();
                        RepositorioCrud<Cliente> operacaoCliente = new RepositorioCrud<Cliente>();
                        var clientes = operacaoCliente.Consultar("cliente_sps", nomeCliente, "@Nome");
                        foreach (var cliente in clientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        Console.WriteLine("Informe o id do planeta para ser excluido: ");
                        var idCliente = Console.ReadLine();
                        operacaoCliente.Remover("cliente_spd", Convert.ToInt32(idCliente), "@id");
                    }
                    catch
                    {
                        Console.WriteLine("Ops parece que existem dependencias com esse Cliente");
                    }
                }
                else if (RespostaUsuarioExcluir == "3")
                {
                    try
                    {
                        Console.WriteLine("Digite o nome do transporte que voce deseja excluir:");
                        var nomeTransporte = Console.ReadLine();
                        RepositorioCrud<Transporte> operacaoTransporte = new RepositorioCrud<Transporte>();
                        var transportes = operacaoTransporte.Consultar("transporte_sps", nomeTransporte, "@Nome");
                        foreach (var transporte in transportes)
                        {
                            Console.WriteLine(transporte.ToString());
                        }
                        Console.WriteLine("Informe o id do transporte para ser excluido: ");
                        var idTransporte = Console.ReadLine();
                        operacaoTransporte.Remover("transporte_spd", Convert.ToInt32(idTransporte), "@Id");
                    }
                    catch
                    {
                        Console.WriteLine("Ops parece que existem dependencias desse transporte");
                    }

                }
                else if (RespostaUsuarioExcluir == "4")
                {
                    try
                    {
                        Console.WriteLine("Digite o id da viagem que voce deseja excluir:");
                        var idViagem = Convert.ToInt32(Console.ReadLine());
                        RepositorioCrud<Viagem> operacaoViagem = new RepositorioCrud<Viagem>();
                        var viagens = operacaoViagem.Consultar("viagemTabela_sps", idViagem, "@Id");
                        foreach (var viagem in viagens)
                        {
                            Console.WriteLine(viagem.ToString());
                        }
                        Console.WriteLine("Informe o id da viagem para confirmar a remoçao: ");
                        idViagem = Convert.ToInt32(Console.ReadLine());
                        operacaoViagem.Remover("viagem_spd", idViagem, "@Id");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ops: {0}", e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            } while (RespostaUsuarioExcluir != "5");
        }

        private static void navegarMenuAtualizacaoGeral()
        {
            var RespostaUsuarioAtualizacao = "";
            do
            {
                Console.WriteLine("Menu 3 - Atualizãção");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1 - Atualizar Planeta");
                Console.WriteLine("2 - Atualizar Cliente");
                Console.WriteLine("3 - Atualizar Transporte");
                Console.WriteLine("4 - Atualizar Viagem");
                Console.WriteLine("5 - Voltar");

                RespostaUsuarioAtualizacao = Console.ReadLine();
                if (RespostaUsuarioAtualizacao == "1")
                {
                    navegarAtualizacaoPlaneta();

                }
                else if (RespostaUsuarioAtualizacao == "2")
                {
                    navegarClienteAtualizacao();

                }
                else if (RespostaUsuarioAtualizacao == "3")
                {
                    navegarTranposteAtualizacao();
                }
                else if (RespostaUsuarioAtualizacao == "4")
                {
                    navegarViagemAtualizacao();
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            } while (RespostaUsuarioAtualizacao != "5");
        }

        private static void navegarTranposteAtualizacao()
        {
            Console.WriteLine("Digite o Nome do transporte para ser atualizado:");
            var nomeTransporte = Console.ReadLine();
            RepositorioCrud<Transporte> operacaoTransporte = new RepositorioCrud<Transporte>();
            var transportes = operacaoTransporte.Consultar("transporte_sps", nomeTransporte, "@Nome");
            foreach (var transporte in transportes)
            {
                Console.WriteLine(transporte.ToString());
            }
            Console.WriteLine("Digite o id do transporte para ser atualizado:");
            var idTransporte = Convert.ToInt32(Console.ReadLine());
            foreach (var transporte in transportes)
            {
                if (transporte.Id == idTransporte)
                {
                    Console.WriteLine("Nome Atual: {0}", transporte.Nome);
                    Console.WriteLine("Nome para atualizar:");
                    transporte.Nome = Console.ReadLine();
                    Console.WriteLine("Terreno: {0}", transporte.Terreno);
                    Console.WriteLine("Novo terreno:");
                    transporte.Terreno = Console.ReadLine();
                    operacaoTransporte.Alterar(transporte, "transporte_spu");
                }
                else
                {
                    Console.WriteLine("Não Existe transporte com esse nome!");
                }
            }
        }

        private static void navegarViagemAtualizacao()
        {
            Console.WriteLine("Digite o id da viagem para ser atualizada:");
            var idViagem = Convert.ToInt32(Console.ReadLine());
            RepositorioCrud<Viagem> operacaoViagem = new RepositorioCrud<Viagem>();
            var viagens = operacaoViagem.Consultar("viagemTabela_sps", idViagem, "@Id");
            foreach (var viagem in viagens)
            {
                Console.WriteLine(viagem.ToString());
            }
            Console.WriteLine("Digite o id da viagem para ser atualizada:");
            idViagem = Convert.ToInt32(Console.ReadLine());
            foreach (var viagem in viagens)
            {
                if (viagem.Id == idViagem)
                {
                    Console.WriteLine("Identificação do cliente atual: {0}", viagem.IdCliente);
                    Console.WriteLine("Novo valor da Identificação do cliente para atualizar:");
                    viagem.IdCliente = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Identificação do planeta de Origem: {0}", viagem.IdPlanetaOrigem);
                    Console.WriteLine("Identificação do novo planeta de origem:");
                    viagem.IdPlanetaOrigem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Identificação do planeta de Destino: {0}", viagem.IdPlanetaDestino);
                    Console.WriteLine("Identificação do novo planeta de Destino:");
                    viagem.IdPlanetaDestino = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Identificação do Transporte: {0}", viagem.IdTransporte);
                    Console.WriteLine("Identificação do novo Transporte:");
                    viagem.IdTransporte = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor da viagem atual: {0}", viagem.valor);
                    Console.WriteLine("Novo valor:");
                    viagem.valor = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Tempo de viagem atual: {0}", viagem.Tempo);
                    Console.WriteLine("Novo Tempo de duração da viagem:");
                    viagem.Tempo = Console.ReadLine();
                    operacaoViagem.Alterar(viagem, "viagem_spu");
                }
                else
                {
                    Console.WriteLine("Não Existe viagem com esse ID!");
                }
            }
        }

        private static void navegarClienteAtualizacao()
        {
            Console.WriteLine("Digite o Nome do Cliente para ser atualizado:");
            var nomeCliente = Console.ReadLine();
            RepositorioCrud<Cliente> operacaoCliente = new RepositorioCrud<Cliente>();
            var clientes = operacaoCliente.Consultar("planeta_sps", nomeCliente, "@Nome");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
            Console.WriteLine("Digite o id do Planeta para ser atualizado:");
            var idCliente = Convert.ToInt32(Console.ReadLine());
            foreach (var cliente in clientes)
            {
                if (cliente.Id == idCliente)
                {
                    Console.WriteLine("Nome Atual: {0}", cliente.Nome);
                    Console.WriteLine("Nome para atualizar:");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("Número de Documento Atual: {0}", cliente.Documento);
                    Console.WriteLine("Número de Documento para atualizar:");
                    cliente.Documento = Console.ReadLine();
                    Console.WriteLine("Quantidade de braços atualmente: {0}", cliente.QtdBracos);
                    Console.WriteLine("Quantidade de braços para atualizar:");
                    cliente.QtdBracos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Quantidade de pernas atualmente: {0}", cliente.QtdPernas);
                    Console.WriteLine("Quantidade de pernas para atualizar:");
                    cliente.QtdPernas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Quantidade de cabeça(s) atualmente: {0}", cliente.QtdCabeca);
                    Console.WriteLine("Quantidade de cabeça(s) para atualizar:");
                    cliente.QtdCabeca = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Respira: {0}", cliente.Respira);
                    Console.WriteLine("Ainda respira?");
                    cliente.Respira = Console.ReadLine().ToLower() == "sim" ? true : false;

                    operacaoCliente.Alterar(cliente, "cliente_spu");
                }
                else
                {
                    Console.WriteLine("Não Existe cliente com esse nome!");
                }
            }
        }

        private static void navegarAtualizacaoPlaneta()
        {
            Console.WriteLine("Digite o Nome do planeta para ser atualizado:");
            var nomePlaneta = Console.ReadLine();
            RepositorioCrud<Planeta> operacaoPlaneta = new RepositorioCrud<Planeta>();
            var planetas = operacaoPlaneta.Consultar("planeta_sps", nomePlaneta, "@Nome");
            foreach (var item in planetas)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Digite o id do Planeta para ser atualizado:");
            var idPlaneta = Convert.ToInt32(Console.ReadLine());
            foreach (var planeta in planetas)
            {
                if (planeta.Id == idPlaneta)
                {
                    Console.WriteLine("Nome Atual: {0}", planeta.Nome);
                    Console.WriteLine("Nome para atualizar:");
                    planeta.Nome = Console.ReadLine();
                    Console.WriteLine("Descrição Atual: {0}", planeta.Descricao);
                    Console.WriteLine("Descrição para atualizar:");
                    planeta.Descricao = Console.ReadLine();
                    Console.WriteLine("Possui Oxigênio: {0}", planeta.PossuiOxigenio);
                    Console.WriteLine("Ainda possuí oxigênio?");
                    planeta.PossuiOxigenio = Console.ReadLine().ToLower() == "sim" ? true : false;

                    operacaoPlaneta.Alterar(planeta, "planeta_spu");
                }
                else
                {
                    Console.WriteLine("Não Existe planeta com esse nome!");
                }
            }
        }

        private static void navegarRemocaoPlaneta()
        {
            try
            {
                Console.WriteLine("Digite o nome do planeta que voce deseja excluir:");
                var nomePlaneta = Console.ReadLine();
                RepositorioCrud<Planeta> operacaoPlaneta = new RepositorioCrud<Planeta>();
                var planetas = operacaoPlaneta.Consultar("planeta_sps", nomePlaneta, "@Nome");
                if (planetas.Count == 0)
                {
                    Console.WriteLine("Parece que não existe um planeta com esse nome: ");
                }
                else
                {
                    foreach (var item in planetas)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("Informe o id do planeta para ser excluido: ");
                    var idPlaneta = Console.ReadLine();
                    operacaoPlaneta.Remover("planeta_spd", Convert.ToInt32(idPlaneta), "@id");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0}", e.Message);
            }
        }

        private static void navegarMenuConsultaGeral()
        {
            var RespostaUsuarioConsulta = "";
            do
            {
                Console.WriteLine("Menu 2 - Consulta");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1 - Consultar Planeta");
                Console.WriteLine("2 - Consultar Cliente");
                Console.WriteLine("3 - Consultar Transporte");
                Console.WriteLine("4 - Consultar Viagem");
                Console.WriteLine("5 - Voltar");
                RespostaUsuarioConsulta = Console.ReadLine();
                if (RespostaUsuarioConsulta == "1")
                {
                    navegarConsultaPlaneta();
                }
                else if (RespostaUsuarioConsulta == "2")
                {
                    navegarConsultaCliente();
                }
                else if (RespostaUsuarioConsulta == "3")
                {
                    navegarConsultaTransporte();
                }
                else if (RespostaUsuarioConsulta == "4")
                {
                    navegarConsultaViagem();
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            } while (RespostaUsuarioConsulta != "5");
        }

        private static void navegarConsultaViagem()
        {
            try
            {
                Console.WriteLine("Qual o id da viagem que você deseja consultar?");
                var respostaConsultaViagem = Console.ReadLine();
                RepositorioCrud<ViagemConsulta> consultaCliente = new RepositorioCrud<ViagemConsulta>();
                var viagens = consultaCliente.Consultar("viagem_sps", Convert.ToInt32(respostaConsultaViagem), "@Id");
                foreach (var item in viagens)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0} ", e.Message);
            }
        }

        private static void navegarConsultaTransporte()
        {
            try
            {
                Console.WriteLine("Qual o nome do transporte que você deseja consultar?");
                var respostaConsultaTransporte = Console.ReadLine();
                RepositorioCrud<Transporte> consultaCliente = new RepositorioCrud<Transporte>();
                var transportes = consultaCliente.Consultar("transporte_sps", respostaConsultaTransporte, "@Nome");
                foreach (var item in transportes)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0} ", e.Message);
            }
        }

        private static void navegarConsultaCliente()
        {
            try
            {
                Console.WriteLine("Qual o nome do cliente que você deseja consultar?");
                var respostaConsultaCliente = Console.ReadLine();
                RepositorioCrud<Cliente> consultaCliente = new RepositorioCrud<Cliente>();
                var clientes = consultaCliente.Consultar("cliente_sps", respostaConsultaCliente, "@Nome");
                foreach (var item in clientes)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0} ", e.Message);
            }
        }

        private static void navegarConsultaPlaneta()
        {
            try
            {
                Console.WriteLine("Qual o nome do planeta voce deseja consultar?");
                var respostaConsultaPlaneta = Console.ReadLine();
                RepositorioCrud<Planeta> consultaPlaneta = new RepositorioCrud<Planeta>();
                var planetas = consultaPlaneta.Consultar("planeta_sps", respostaConsultaPlaneta, "@Nome");
                if (planetas.Count == 0)
                    Console.WriteLine("Não existe um planeta com o nome {0}", respostaConsultaPlaneta);
                foreach (var item in planetas)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0}", e.Message);
            }
        }

        private static void navegarMenuCadastroGeral()
        {
            var respostaUsuarioCadastro = "";
            do
            {
                Console.WriteLine("Menu 1 - Cadastro");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1 - Cadastrar Planeta");
                Console.WriteLine("2 - Cadastrar Cliente");
                Console.WriteLine("3 - Cadastrar Transporte");
                Console.WriteLine("4 - Cadastrar Viagem");
                Console.WriteLine("5 - Voltar");
                respostaUsuarioCadastro = Console.ReadLine();
                if (respostaUsuarioCadastro == "1")
                {
                    navegarCadastroPlaneta();

                }
                else if (respostaUsuarioCadastro == "2")
                {
                    navegarCadastroCliente();
                }
                else if (respostaUsuarioCadastro == "3")
                {
                    navegarCadastroTransporte();

                }
                else if (respostaUsuarioCadastro == "4")
                {
                    navegarCadastroViagem();

                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            } while (respostaUsuarioCadastro != "5");

        }

        private static void navegarCadastroViagem()
        {
            Console.WriteLine("Cadastro de Viagem");
            Console.WriteLine("---------------------");
            Console.WriteLine("Id Planeta origem:");
            var idPlanetaOrigem = Console.ReadLine();
            Console.WriteLine("Id Planeta destino:");
            var idPlanetaDestino = Console.ReadLine();
            Console.WriteLine("Id Cliente:");
            var idCliente = Console.ReadLine();
            Console.WriteLine("Id Transporte:");
            var idTransporte = Console.ReadLine();
            Console.WriteLine("Valor: R$");
            var valor = Console.ReadLine();
            Console.WriteLine("Tempo:");
            var tempo = Console.ReadLine();

            Viagem viagem = new Viagem(Convert.ToInt32(idPlanetaOrigem), Convert.ToInt32(idPlanetaDestino),
                Convert.ToInt32(idCliente), Convert.ToInt32(idTransporte), Convert.ToDecimal(valor), tempo);
            var repositorioViagem = new RepositorioCrud<Viagem>();
            repositorioViagem.Cadastrar(viagem, "viagem_spi");
        }

        private static void navegarCadastroTransporte()
        {
            Console.WriteLine("Cadastro de Transporte");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome do transporte:");
            var nomeTransporte = Console.ReadLine();
            Console.WriteLine("Terreno(AR/ TERRA/ MAR/ TELETRANSPORTE):");
            var terreno = Console.ReadLine();
            Transporte transporte = new Transporte(nomeTransporte, terreno);
            var repositorioTransporte = new RepositorioCrud<Transporte>();
            repositorioTransporte.Cadastrar(transporte, "transporte_spi");
        }

        private static void navegarCadastroCliente()
        {
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome Completo:");
            var Nome = Console.ReadLine();
            Console.WriteLine("Número do Documento:");
            var Documento = Console.ReadLine();
            Console.WriteLine("Tipo da éspecie:");
            var TipoEspecie = Console.ReadLine();
            Console.WriteLine("Cor:");
            var Cor = Console.ReadLine();
            Console.WriteLine("Quantidade de Braços:");
            var QtdBracos = Console.ReadLine();
            Console.WriteLine("Quantidade de Pernas:");
            var QtdPernas = Console.ReadLine();
            Console.WriteLine("Quantidade de Cabeça:");
            var QtdCabeca = Console.ReadLine();
            Console.WriteLine("Você respira?");
            var Respira = Console.ReadLine().ToLower();
            var RespostaRespira = true;

            if (Respira == "sim")
            {
                RespostaRespira = true;
            }
            else
            {
                RespostaRespira = false;
            }

            try
            {
                Cliente cliente = new Cliente(Nome, Documento, TipoEspecie, Cor, Convert.ToInt32(QtdBracos), Convert.ToInt32(QtdPernas), Convert.ToInt32(QtdCabeca), RespostaRespira);
                RepositorioCrud<Cliente> repositorioCliente = new RepositorioCrud<Cliente>();

                repositorioCliente.Cadastrar(cliente, "cliente_spi");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message: {0} ", ex.Message);
            }
        }

        private static void navegarCadastroPlaneta()
        {
            Console.WriteLine("Cadastro de Planeta");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome do Planeta:");
            var NomePlaneta = Console.ReadLine();
            Console.WriteLine("Descrição do Planeta:");
            var DescricaoPlaneta = Console.ReadLine();
            Console.WriteLine("Possui Oxigênio?");
            var RespostaPossuiOxigenio = Console.ReadLine().ToLower();
            var PossuiOxigenio = true;
            if (RespostaPossuiOxigenio == "Sim")
            {
                PossuiOxigenio = true;
            }
            else if (RespostaPossuiOxigenio == "não" || RespostaPossuiOxigenio == "nao")
            {
                PossuiOxigenio = false;
            }
            try
            {
                Planeta Planeta = new Planeta(NomePlaneta, DescricaoPlaneta, PossuiOxigenio);
                var RepositorioPlaneta = new RepositorioCrud<Planeta>();
                RepositorioPlaneta.Cadastrar(Planeta, "planeta_spi");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops! {0} ", e.Message);
            }
        }
    }
}
