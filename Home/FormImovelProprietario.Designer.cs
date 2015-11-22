namespace Home
{
    partial class FormImovelProprietario
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imovelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterimovelDataSet = new Home.masterimovelDataSet();
            this.imovelTableAdapter = new Home.masterimovelDataSetTableAdapters.imovelTableAdapter();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Home.masterimovelDataSetTableAdapters.pessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.imovelBindingSource;
            this.comboBox1.DisplayMember = "decricao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
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
            // imovelTableAdapter
            // 
            this.imovelTableAdapter.ClearBeforeFill = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(84, 295);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imoveis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proprietario";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.pessoaBindingSource;
            this.comboBox2.DisplayMember = "nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "id";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.masterimovelDataSet;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // FormImovelProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 374);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormImovelProprietario";
            this.Text = "FormImovelProprietario";
            this.Load += new System.EventHandler(this.FormImovelProprietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imovelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterimovelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private masterimovelDataSet masterimovelDataSet;
        private System.Windows.Forms.BindingSource imovelBindingSource;
        private masterimovelDataSetTableAdapters.imovelTableAdapter imovelTableAdapter;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private masterimovelDataSetTableAdapters.pessoaTableAdapter pessoaTableAdapter;
    }
}