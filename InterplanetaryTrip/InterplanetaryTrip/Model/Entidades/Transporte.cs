using InterplanetaryTrip.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip.Model.Entidades
{
    class Transporte : ITranporte
    {
        private int _Id;
        private string _Nome;
        private string _Terreno;
        
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
        public Transporte()
        {

        }
        public Transporte(string Nome, string Terreno)
        {
            this._Nome = Nome;
            this._Terreno = Terreno;
        }

        public Transporte(int Id,  string Nome, string terreno)
        {
            this._Id = Id;
            this._Nome = Nome;
            this._Terreno = Terreno;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Nome do Transporte: {1}, Terreno: {2} ", this.Id, this.Nome, this.Terreno);
        }
    }
}
