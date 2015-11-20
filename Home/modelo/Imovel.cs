using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.modelo
{
    class Imovel
    {


        private int id;
        private string decricao;
        private string endereco;
        private double valor;
        private double valor_aluguel;
        private DateTime idade_imovel_dt;
        private string tipo_imovel;

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

        public string Decricao
        {
            get
            {
                return decricao;
            }

            set
            {
                decricao = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public double Valor_aluguel
        {
            get
            {
                return valor_aluguel;
            }

            set
            {
                valor_aluguel = value;
            }
        }

        public DateTime Idade_imovel_dt
        {
            get
            {
                return idade_imovel_dt;
            }

            set
            {
                idade_imovel_dt = value;
            }
        }

        public string Tipo_imovel
        {
            get
            {
                return tipo_imovel;
            }

            set
            {
                tipo_imovel = value;
            }
        }
    }
}
