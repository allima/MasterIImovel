namespace Home
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imovelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corretorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imovelToolStripMenuItem,
            this.corretorToolStripMenuItem,
            this.inquilinoToolStripMenuItem,
            this.proprietarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // imovelToolStripMenuItem
            // 
            this.imovelToolStripMenuItem.Name = "imovelToolStripMenuItem";
            this.imovelToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.imovelToolStripMenuItem.Text = "Imovel";
            this.imovelToolStripMenuItem.Click += new System.EventHandler(this.imovelToolStripMenuItem_Click);
            // 
            // corretorToolStripMenuItem
            // 
            this.corretorToolStripMenuItem.Name = "corretorToolStripMenuItem";
            this.corretorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.corretorToolStripMenuItem.Text = "Corretor";
            this.corretorToolStripMenuItem.Click += new System.EventHandler(this.corretorToolStripMenuItem_Click);
            // 
            // inquilinoToolStripMenuItem
            // 
            this.inquilinoToolStripMenuItem.Name = "inquilinoToolStripMenuItem";
            this.inquilinoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.inquilinoToolStripMenuItem.Text = "Inquilino";
            this.inquilinoToolStripMenuItem.Click += new System.EventHandler(this.inquilinoToolStripMenuItem_Click);
            // 
            // proprietarioToolStripMenuItem
            // 
            this.proprietarioToolStripMenuItem.Name = "proprietarioToolStripMenuItem";
            this.proprietarioToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.proprietarioToolStripMenuItem.Text = "Proprietario";
            this.proprietarioToolStripMenuItem.Click += new System.EventHandler(this.proprietarioToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 387);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Master Imovel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imovelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corretorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietarioToolStripMenuItem;
    }
}

