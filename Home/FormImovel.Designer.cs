namespace Home
{
    partial class FormImovel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_imovel = new System.Windows.Forms.DataGridView();
            this.imovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet = new Home.masterimovelDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.imovelTableAdapter = new Home.masterimovelDataSetTableAdapters.imovelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_assc_imo_pes = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorimovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoraluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeimoveldtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoimovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_imovel
            // 
            this.dgv_imovel.AutoGenerateColumns = false;
            this.dgv_imovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_imovel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.decricaoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.valorimovelDataGridViewTextBoxColumn,
            this.valoraluguelDataGridViewTextBoxColumn,
            this.idadeimoveldtDataGridViewTextBoxColumn,
            this.tipoimovelDataGridViewTextBoxColumn});
            this.dgv_imovel.DataSource = this.imovelBindingSource;
            this.dgv_imovel.Location = new System.Drawing.Point(33, 70);
            this.dgv_imovel.Name = "dgv_imovel";
            this.dgv_imovel.Size = new System.Drawing.Size(755, 219);
            this.dgv_imovel.TabIndex = 0;
            this.dgv_imovel.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // imovelBindingSource
            // 
            this.imovelBindingSource.DataMember = "imovel";
            this.imovelBindingSource.DataSource = this.masterimovelDataSet;
            // 
            // masterimovelDataSet
            // 
            this.masterimovelDataSet.DataSetName = "masterimovelDataSet";
            this.masterimovelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Imovies";
            // 
            // imovelTableAdapter
            // 
            this.imovelTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Novo Imovel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_assc_imo_pes
            // 
            this.btn_assc_imo_pes.Location = new System.Drawing.Point(180, 330);
            this.btn_assc_imo_pes.Name = "btn_assc_imo_pes";
            this.btn_assc_imo_pes.Size = new System.Drawing.Size(137, 23);
            this.btn_assc_imo_pes.TabIndex = 3;
            this.btn_assc_imo_pes.Text = "Cadastrar Proprietario";
            this.btn_assc_imo_pes.UseVisualStyleBackColor = true;
            this.btn_assc_imo_pes.Click += new System.EventHandler(this.btn_assc_imo_pes_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // decricaoDataGridViewTextBoxColumn
            // 
            this.decricaoDataGridViewTextBoxColumn.DataPropertyName = "decricao";
            this.decricaoDataGridViewTextBoxColumn.HeaderText = "Decricao";
            this.decricaoDataGridViewTextBoxColumn.Name = "decricaoDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // valorimovelDataGridViewTextBoxColumn
            // 
            this.valorimovelDataGridViewTextBoxColumn.DataPropertyName = "valor_imovel";
            this.valorimovelDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorimovelDataGridViewTextBoxColumn.Name = "valorimovelDataGridViewTextBoxColumn";
            // 
            // valoraluguelDataGridViewTextBoxColumn
            // 
            this.valoraluguelDataGridViewTextBoxColumn.DataPropertyName = "valor_aluguel";
            this.valoraluguelDataGridViewTextBoxColumn.HeaderText = "Valor do Aluguel";
            this.valoraluguelDataGridViewTextBoxColumn.Name = "valoraluguelDataGridViewTextBoxColumn";
            // 
            // idadeimoveldtDataGridViewTextBoxColumn
            // 
            this.idadeimoveldtDataGridViewTextBoxColumn.DataPropertyName = "idade_imovel_dt";
            this.idadeimoveldtDataGridViewTextBoxColumn.HeaderText = "Idade do imovel";
            this.idadeimoveldtDataGridViewTextBoxColumn.Name = "idadeimoveldtDataGridViewTextBoxColumn";
            // 
            // tipoimovelDataGridViewTextBoxColumn
            // 
            this.tipoimovelDataGridViewTextBoxColumn.DataPropertyName = "tipo_imovel";
            this.tipoimovelDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoimovelDataGridViewTextBoxColumn.Name = "tipoimovelDataGridViewTextBoxColumn";
            // 
            // FormImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 392);
            this.Controls.Add(this.btn_assc_imo_pes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_imovel);
            this.Name = "FormImovel";
            this.Text = "Imovel";
            this.Activated += new System.EventHandler(this.FormImovel_Activated);
            this.Load += new System.EventHandler(this.FormImovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_imovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_imovel;
        private System.Windows.Forms.Label label1;
        private masterimovelDataSet masterimovelDataSet;
        private System.Windows.Forms.BindingSource imovelBindingSource;
        private masterimovelDataSetTableAdapters.imovelTableAdapter imovelTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_assc_imo_pes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorimovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoraluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeimoveldtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoimovelDataGridViewTextBoxColumn;
    }
}