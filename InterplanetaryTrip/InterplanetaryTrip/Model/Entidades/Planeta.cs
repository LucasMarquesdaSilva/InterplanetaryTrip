using InterplanetaryTrip.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Entidades
{
    class Planeta : IPlaneta
    {
        private int _Id;
        private string _Nome;
        private string _Descricao;
        private bool _PossuiOxigenio;

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

        public string Nome
        {
            get
            {
                return this._Nome;
            }

            set
            {
                this._Nome = value;
            }
        }

        public string Descricao
        {
            get
            {
                return this._Descricao;
            }

            set
            {
                this._Descricao = value;
            }
        }

        public bool PossuiOxigenio
        {
            get
            {
                return this._PossuiOxigenio;
            }

            set
            {
                this._PossuiOxigenio = value;
            }
        }
        public Planeta()
        {

        }

        public Planeta(string Nome, string Descricao, bool PossuiOxigenio)
        {
            this._Nome = Nome;
            this._Descricao = Descricao;
            this._PossuiOxigenio = PossuiOxigenio;
        }

        public Planeta(int Id, string Nome, string Descricao, bool PossuiOxigenio)
        {
            this._Id = Id;
            this._Nome = Nome;
            this._Descricao = Descricao;
            this._PossuiOxigenio = PossuiOxigenio;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Nome do Planeta: {1}, Descrição: {2}, Possui Oxigênio : {3}", 
                this.Id, this.Nome, this.Descricao, this.PossuiOxigenio == true ? "Sim" : "Não");
        }
    }
}
