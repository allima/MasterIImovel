﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class FormImovel : Form
    {
        int codigo = 0;
        public FormImovel()
        {
            InitializeComponent();
        }

        private void FormImovel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.proprietario_imovel' table. You can move, or remove it, as needed.
          //  this.proprietario_imovelTableAdapter.Fill(this.masterimovelDataSet.proprietario_imovel);
            // TODO: This line of code loads data into the 'masterimovelDataSet.aluga_vende' table. You can move, or remove it, as needed.
           // this.aluga_vendeTableAdapter.Fill(this.masterimovelDataSet.aluga_vende);
            // TODO: This line of code loads data into the 'masterimovelDataSet.imovel' table. You can move, or remove it, as needed.
            // this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormImovelmanutencao formImovelmanutencao = new FormImovelmanutencao();
            formImovelmanutencao.ShowDialog(this);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Obtem o codigo do do gride da linha selecionad pelo duplo clique.
            try {
                codigo = Convert.ToInt32(dgv_imovel.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception) { }
            // Instancia a clesse FormeClasseManutencao enviando o codigo da classe como argumento
            FormImovelmanutencao FormImovelmanutencao = new FormImovelmanutencao(codigo);
            FormImovelmanutencao.ShowDialog(this);
        }

        private void FormImovel_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.imovel' table. You can move, or remove it, as needed.
            this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);
        }

        private void btn_assc_imo_pes_Click(object sender, EventArgs e)
        {
            FormImovelProprietario FormImovelProprietario = new FormImovelProprietario();
            FormImovelProprietario.ShowDialog(this);
        }
    }
}
