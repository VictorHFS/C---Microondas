namespace WindowsFormsApplication1.Microondas
{
    partial class MicroondasForm
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
            this.aquecimento = new System.Windows.Forms.Button();
            this.aquecimentoRapido = new System.Windows.Forms.Button();
            this.boxDeEntrada = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frangoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotaoConsultar = new System.Windows.Forms.Button();
            this.BoxDeConsulta = new System.Windows.Forms.TextBox();
            this.entradaLabel = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aquecimento
            // 
            this.aquecimento.Location = new System.Drawing.Point(103, 187);
            this.aquecimento.Name = "aquecimento";
            this.aquecimento.Size = new System.Drawing.Size(79, 54);
            this.aquecimento.TabIndex = 0;
            this.aquecimento.Text = "Aquecimento";
            this.aquecimento.UseVisualStyleBackColor = true;
            this.aquecimento.Click += new System.EventHandler(this.aquecimento_Click);
            // 
            // aquecimentoRapido
            // 
            this.aquecimentoRapido.Location = new System.Drawing.Point(188, 187);
            this.aquecimentoRapido.Name = "aquecimentoRapido";
            this.aquecimentoRapido.Size = new System.Drawing.Size(80, 54);
            this.aquecimentoRapido.TabIndex = 1;
            this.aquecimentoRapido.Text = "Aquecimento Rapido";
            this.aquecimentoRapido.UseVisualStyleBackColor = true;
            this.aquecimentoRapido.Click += new System.EventHandler(this.aquecimentoRapido_Click);
            // 
            // boxDeEntrada
            // 
            this.boxDeEntrada.Location = new System.Drawing.Point(103, 142);
            this.boxDeEntrada.Name = "boxDeEntrada";
            this.boxDeEntrada.Size = new System.Drawing.Size(165, 20);
            this.boxDeEntrada.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frangoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // frangoToolStripMenuItem
            // 
            this.frangoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.frangoToolStripMenuItem.Name = "frangoToolStripMenuItem";
            this.frangoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.frangoToolStripMenuItem.Text = "Programas";
            this.frangoToolStripMenuItem.Click += new System.EventHandler(this.frangoToolStripMenuItem_Click);
            // 
            // BotaoConsultar
            // 
            this.BotaoConsultar.Location = new System.Drawing.Point(12, 27);
            this.BotaoConsultar.Name = "BotaoConsultar";
            this.BotaoConsultar.Size = new System.Drawing.Size(75, 23);
            this.BotaoConsultar.TabIndex = 4;
            this.BotaoConsultar.Text = "Consultar";
            this.BotaoConsultar.UseVisualStyleBackColor = true;
            this.BotaoConsultar.Click += new System.EventHandler(this.BotaoConsultar_Click);
            // 
            // BoxDeConsulta
            // 
            this.BoxDeConsulta.Location = new System.Drawing.Point(103, 29);
            this.BoxDeConsulta.Name = "BoxDeConsulta";
            this.BoxDeConsulta.Size = new System.Drawing.Size(165, 20);
            this.BoxDeConsulta.TabIndex = 5;
            // 
            // entradaLabel
            // 
            this.entradaLabel.AutoSize = true;
            this.entradaLabel.Location = new System.Drawing.Point(43, 145);
            this.entradaLabel.Name = "entradaLabel";
            this.entradaLabel.Size = new System.Drawing.Size(44, 13);
            this.entradaLabel.TabIndex = 6;
            this.entradaLabel.Text = "Entrada";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem1.Text = "Cadastrar Novo Programa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MicroondasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 310);
            this.Controls.Add(this.entradaLabel);
            this.Controls.Add(this.BoxDeConsulta);
            this.Controls.Add(this.BotaoConsultar);
            this.Controls.Add(this.boxDeEntrada);
            this.Controls.Add(this.aquecimentoRapido);
            this.Controls.Add(this.aquecimento);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MicroondasForm";
            this.Text = "Microondas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aquecimento;
        private System.Windows.Forms.Button aquecimentoRapido;
        private System.Windows.Forms.TextBox boxDeEntrada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frangoToolStripMenuItem;
        private System.Windows.Forms.Button BotaoConsultar;
        private System.Windows.Forms.TextBox BoxDeConsulta;
        private System.Windows.Forms.Label entradaLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

