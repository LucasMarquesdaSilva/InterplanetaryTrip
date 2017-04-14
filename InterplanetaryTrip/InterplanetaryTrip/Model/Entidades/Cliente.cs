using InterplanetaryTrip.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InterplanetaryTrip.Model.DB;

namespace InterplanetaryTrip.Model.classes
{
    class Cliente
    {
        private int _Id;
        private string _Nome;
        private string _Documento;
        private string _TipoEspecie;
        private string _Cor;
        private int _QtdBracos;
        private int _QtdPernas;
        private int _QtdCabeca;
        private bool _Respira;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                this._Id = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                this._Nome = value;
            }
        }
        public string Documento
        {
            get
            {
                return _Documento;
            }

            set
            {
                this._Documento = value;
            }
        }
        public string TipoEspecie
        {
            get
            {
                return _TipoEspecie;
            }
            set
            {
                this._TipoEspecie = value;
            }
        }
        public string Cor
        {
            get
            {
                return this._Cor;
            }
            set
            {
                this._Cor = value;
            }
        }
        public int QtdBracos
        {
            get
            {
                return _QtdBracos;
            }
            set
            {
                this._QtdBracos = value;
            }
        }
        public int QtdPernas
        {
            get
            {
                return _QtdPernas;
            }
            set
            {
                this._QtdPernas = value;
            }
        }
        public int QtdCabeca
        {
            get
            {
                return _QtdCabeca;
            }
            set
            {
                this._QtdCabeca = value;
            }
        }
        public bool Respira
        {
            get
            {
                return _Respira;
            }
            set
            {
                this._Respira = value;
            }
        }
        public Cliente()
        {

        }
        public Cliente(string Nome, string Documento, string TipoEspecie, string Cor, int QtdBracos, int QtdPernas, int QtdCabeca, bool Respira)
        {
            this._Nome = Nome;
            this._Documento = Documento;
            this._TipoEspecie = TipoEspecie;
            this._Cor = Cor;
            this._QtdBracos = QtdBracos;
            this._QtdPernas = QtdPernas;
            this._QtdCabeca = QtdCabeca;
            this._Respira = Respira;
        }

        public Cliente(int Id, string Nome, string Documento, string TipoEspecie, string Cor, int QtdBracos, int QtdPernas, int QtdCabeca, bool Respira)
        {
            this._Id = Id;
            this._Nome = Nome;
            this._Documento = Documento;
            this._TipoEspecie = TipoEspecie;
            this._Cor = Cor;
            this._QtdBracos = QtdBracos;
            this._QtdPernas = QtdPernas;
            this._QtdCabeca = QtdCabeca;
            this._Respira = Respira;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Nome: {1}, Documento: {2}, Tipo Especie: {3} Cor: {4}, Quantidade de Braços: {5}, Quantidade de Pernas: {6},"
                + " Quantidade de Cabeca: {7}, Respira: {8}", this.Id, this.Nome, this.Documento, this.TipoEspecie, this.Cor, this.QtdBracos, this.QtdPernas, this.QtdCabeca, this.Respira);
        }
    }
}