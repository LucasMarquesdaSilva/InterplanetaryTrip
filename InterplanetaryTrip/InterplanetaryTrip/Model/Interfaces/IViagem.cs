namespace InterplanetaryTrip.Model.Entidades
{
    internal interface IViagem
    {
        int Id { get; set; }
        int IdPlanetaOrigem { get; set; }
        int IdPlanetaDestino { get; set; }
        int IdCliente { get; set; }
        decimal valor { get; set; }
        string Tempo { get; set; }


    }
}