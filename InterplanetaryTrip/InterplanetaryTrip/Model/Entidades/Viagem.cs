using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Entidades
{
    class Viagem : IViagem
    {
        private int _Id;
        private int _IdPlanetaOrigem;
        private int _IdPlanetaDestino;
        private int _IdCliente;
        private int _IdTransporte;
        private decimal _Valor;
        private string _Tempo;

        public int Id
        {
            get
            {
                return this._Id;
            }

            set
            {
                this._Id = value;
            }
        }


        public int IdCliente
        {
            get
            {
                return this._IdCliente;
            }

            set
            {
                this._IdCliente = value;
            }
        }

        public int IdPlanetaDestino
        {
            get
            {
                return this._IdPlanetaDestino;
            }

            set
            {
                this._IdPlanetaDestino = value;
            }
        }

        public int IdPlanetaOrigem
        {
            get
            {
                return this._IdPlanetaOrigem;
            }

            set
            {
                this._IdPlanetaOrigem = value;
            }
        }
        public int IdTransporte
        {
            get
            {
                return this._IdTransporte;
                ;
            }

            set
            {
                this._IdTransporte = value;
            }
        }
        public decimal valor
        {
            get
            {
                return this._Valor;
            }

            set
            {
                this._Valor = value;
            }
        }
        public string Tempo
        {
            get
            {
                return this._Tempo;
            }

            set
            {
                this._Tempo = value;
            }
        }
        public Viagem()
        {

        }
        public Viagem(int IdPlanetaOrigem, int IdPlanetaDestino,
            int IdCliente, int IdTransporte, decimal Valor, string Tempo)
        {
            this._IdPlanetaOrigem = IdPlanetaOrigem;
            this._IdPlanetaDestino = IdPlanetaDestino;
            this._IdCliente = IdCliente;
            this._IdTransporte = IdTransporte;
            this._Valor = Valor;
            this._Tempo = Tempo;
        }
    }
}
