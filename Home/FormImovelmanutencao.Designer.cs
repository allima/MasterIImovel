namespace Home
{
    partial class FormImovelmanutencao
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
            this.label1 = new System.Windows.Forms.Label();
            this.cobbox_tipo = new System.Windows.Forms.ComboBox();
            this.txtb_decricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mktxtb_valor = new System.Windows.Forms.MaskedTextBox();
            this.mktxtb_valoraluguel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpkdata = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // cobbox_tipo
            // 
            this.cobbox_tipo.FormattingEnabled = true;
            this.cobbox_tipo.Items.AddRange(new object[] {
            "Apartamento Padrão",
            "Casa de Condomínio",
            "Casa de Vila",
            "Casa Padrão",
            "Cobertura",
            "Flat",
            "Kitchenette/Conjugados",
            "Loft",
            "Loteamento/Condomínio",
            "Terreno Padrão"});
            this.cobbox_tipo.Location = new System.Drawing.Point(185, 219);
            this.cobbox_tipo.Name = "cobbox_tipo";
            this.cobbox_tipo.Size = new System.Drawing.Size(203, 21);
            this.cobbox_tipo.TabIndex = 1;
            // 
            // txtb_decricao
            // 
            this.txtb_decricao.Location = new System.Drawing.Point(185, 49);
            this.txtb_decricao.Name = "txtb_decricao";
            this.txtb_decricao.Size = new System.Drawing.Size(256, 20);
            this.txtb_decricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço";
            // 
            // txtb_endereco
            // 
            this.txtb_endereco.Location = new System.Drawing.Point(185, 82);
            this.txtb_endereco.Name = "txtb_endereco";
            this.txtb_endereco.Size = new System.Drawing.Size(256, 20);
            this.txtb_endereco.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Imovel Manutenção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // mktxtb_valor
            // 
            this.mktxtb_valor.Location = new System.Drawing.Point(185, 148);
            this.mktxtb_valor.Mask = "000000000000";
            this.mktxtb_valor.Name = "mktxtb_valor";
            this.mktxtb_valor.Size = new System.Drawing.Size(203, 20);
            this.mktxtb_valor.TabIndex = 11;
            // 
            // mktxtb_valoraluguel
            // 
            this.mktxtb_valoraluguel.Location = new System.Drawing.Point(185, 179);
            this.mktxtb_valoraluguel.Mask = "0000000000000";
            this.mktxtb_valoraluguel.Name = "mktxtb_valoraluguel";
            this.mktxtb_valoraluguel.Size = new System.Drawing.Size(203, 20);
            this.mktxtb_valoraluguel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor Aluguel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data Construção";
            // 
            // dtpkdata
            // 
            this.dtpkdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkdata.Location = new System.Drawing.Point(188, 114);
            this.dtpkdata.Name = "dtpkdata";
            this.dtpkdata.Size = new System.Drawing.Size(200, 20);
            this.dtpkdata.TabIndex = 16;
            // 
            // FormImovelmanutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 317);
            this.Controls.Add(this.dtpkdata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mktxtb_valoraluguel);
            this.Controls.Add(this.mktxtb_valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_decricao);
            this.Controls.Add(this.cobbox_tipo);
            this.Controls.Add(this.label1);
            this.Name = "FormImovelmanutencao";
            this.Text = "FormImovelmanutencao";
            this.Load += new System.EventHandler(this.FormImovelmanutencao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobbox_tipo;
        private System.Windows.Forms.TextBox txtb_decricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mktxtb_valor;
        private System.Windows.Forms.MaskedTextBox mktxtb_valoraluguel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkdata;
    }
}