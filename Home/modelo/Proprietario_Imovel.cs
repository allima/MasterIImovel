using Home.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.dao
{
    class Proprietario_Imovel
    {

        public Proprietario_Imovel()
        {
            this.imovel = new Imovel();
            this.proprietario = new Pessoa();

        }

        private int id;
        private Imovel imovel;
        private Pessoa proprietario;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        internal Imovel Imovel
        {
            get
            {
                return imovel;
            }

            set
            {
                imovel = value;
            }
        }

        internal Pessoa Proprietario
        {
            get
            {
                return proprietario;
            }

            set
            {
                proprietario = value;
            }
        }
    }
}
