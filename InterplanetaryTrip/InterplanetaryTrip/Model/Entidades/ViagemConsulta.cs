using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Entidades
{
    class ViagemConsulta : Viagem
    {
        private int _Id;
        private string _nomeCliente;
        private string _documento;
        private bool _Respira;
        private string _NomePlanetaOrigem;
        private string _NomePlanetaDestino;
        private string _TransporteNome;
        private string _Terreno;
        private decimal _Valor;
        private string _Tempo;

        public new int Id
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
        public string nomeCliente
        {
            get
            {
                return this._nomeCliente;
            }
            set
            {
                this._nomeCliente = value;
            }
        }
        public string documento
        {
            get { return this._documento; }
            set { this._documento = value; }
        }
        public bool Respira
        {
            get
            {
                return this._Respira;
            }
            set
            {
                this._Respira = value;
            }
        }
        public string NomePlanetaOrigem
        {
            get
            {
                return this._NomePlanetaOrigem;
            }
            set
            {
                this._NomePlanetaOrigem = value;
            }
        }

        public string NomePlanetaDestino
        {
            get
            {
                return this._NomePlanetaDestino;
            }
            set
            {
                this._NomePlanetaDestino = value;
            }
        }
        public decimal Valor
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

        public string TransporteNome
        {
            get
            {
                return this._TransporteNome;
            }
            set
            {
                this._TransporteNome = value;
            }
        }


        public string Terreno
        {
            get
            {
                return this._Terreno;
            }
            set
            {
                this._Terreno = value;
            }
        }

        public ViagemConsulta(int Id, string nomeCliente, string documento, bool Respira, string nomePlanetaOrigem,
            decimal valor, string tempo, string transporteNome, string terreno)
        {
            this._Id = Id;
            this._nomeCliente = nomeCliente;
            this._documento = documento;
            this._Respira = Respira;
            this._NomePlanetaOrigem = nomePlanetaOrigem;
            this._NomePlanetaDestino = NomePlanetaDestino;
            this._Valor = Valor;
            this._Tempo = tempo;
            this._TransporteNome = transporteNome;
            this._Terreno = terreno;
        }
        public override string ToString()
        {
            return string.Format("Id: {0}, Nome do cliente: {1}, Documento: {2}, Respira: {3}. Nome do planeta de origem: {4}, "
                + "Nome do Planeta de Destino: {5}, valor: R$ {6}, Tempo: {7}, Nome do transporte: {8}, Tipo de terreno do transporte: {9}",
               this.Id, this.nomeCliente, this.documento, this.Respira, this.NomePlanetaOrigem, this.NomePlanetaDestino,
               this.valor, this.Tempo, this.TransporteNome, this.Terreno);
        }
    }
}
