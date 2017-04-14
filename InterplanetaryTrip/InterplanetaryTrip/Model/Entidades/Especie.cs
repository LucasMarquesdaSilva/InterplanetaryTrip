using InterplanetaryTrip.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.classes
{
    class Especie : ICliente
    {
        private int _Id;
        private string _Nome;
        private string _Documento;
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
        public Especie(string Nome, string Documento, string Cor, int QtdBracos, int QtdPernas, int QtdCabeca, bool Respira)
        {
            this._Nome = Nome;
            this._Documento = Documento;
            this._Cor = Cor;
            this._QtdBracos = QtdBracos;
            this._QtdPernas = QtdPernas;
            this._QtdCabeca = QtdCabeca;
            this._Respira = Respira;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Nome: {1}, Documento: {2}, Cor: {3}, Quantidade de Braços: {4}, Quantidade de Pernas: {5}, Quantidade de Cabeca: {6}, Respira: {7}", this.Id, this.Nome, this.Documento, this.Cor, this.QtdBracos, this.QtdPernas, this.QtdCabeca, this.Respira);
        }
    }
}
