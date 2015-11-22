using System;
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
    public partial class FormImovelProprietario : Form
    {
        public FormImovelProprietario()
        {
            InitializeComponent();
        }

        private void FormImovelProprietario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.imovel' table. You can move, or remove it, as needed.
            // this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);
            this.imovelTableAdapter.FillByImovel(this.masterimovelDataSet.imovel);
        }

        private void fillByImovelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.imovelTableAdapter.FillByImovel(this.masterimovelDataSet.imovel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
