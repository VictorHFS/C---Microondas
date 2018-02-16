namespace WindowsFormsApplication1.Programas
{
    partial class ProgramaForm
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
            this.boxDeNome = new System.Windows.Forms.TextBox();
            this.boxDeTempo = new System.Windows.Forms.TextBox();
            this.boxDePotencia = new System.Windows.Forms.TextBox();
            this.boxDeInstrucoes = new System.Windows.Forms.RichTextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.potenciaLabel = new System.Windows.Forms.Label();
            this.intrucoesLabel = new System.Windows.Forms.Label();
            this.salvarButton = new System.Windows.Forms.Button();
            this.boxDeCaracter = new System.Windows.Forms.TextBox();
            this.caracterLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxDeNome
            // 
            this.boxDeNome.Location = new System.Drawing.Point(116, 29);
            this.boxDeNome.Name = "boxDeNome";
            this.boxDeNome.ReadOnly = true;
            this.boxDeNome.Size = new System.Drawing.Size(100, 20);
            this.boxDeNome.TabIndex = 0;
            this.boxDeNome.TextChanged += new System.EventHandler(this.boxeDeNome_TextChanged);
            // 
            // boxDeTempo
            // 
            this.boxDeTempo.Location = new System.Drawing.Point(116, 70);
            this.boxDeTempo.Name = "boxDeTempo";
            this.boxDeTempo.ReadOnly = true;
            this.boxDeTempo.Size = new System.Drawing.Size(100, 20);
            this.boxDeTempo.TabIndex = 1;
            // 
            // boxDePotencia
            // 
            this.boxDePotencia.Location = new System.Drawing.Point(301, 70);
            this.boxDePotencia.Name = "boxDePotencia";
            this.boxDePotencia.ReadOnly = true;
            this.boxDePotencia.Size = new System.Drawing.Size(100, 20);
            this.boxDePotencia.TabIndex = 2;
            // 
            // boxDeInstrucoes
            // 
            this.boxDeInstrucoes.Location = new System.Drawing.Point(116, 106);
            this.boxDeInstrucoes.Name = "boxDeInstrucoes";
            this.boxDeInstrucoes.ReadOnly = true;
            this.boxDeInstrucoes.Size = new System.Drawing.Size(285, 126);
            this.boxDeInstrucoes.TabIndex = 3;
            this.boxDeInstrucoes.Text = "";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(53, 36);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 4;
            this.nomeLabel.Text = "Nome:";
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(53, 70);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(43, 13);
            this.tempoLabel.TabIndex = 5;
            this.tempoLabel.Text = "Tempo:";
            // 
            // potenciaLabel
            // 
            this.potenciaLabel.AutoSize = true;
            this.potenciaLabel.Location = new System.Drawing.Point(233, 73);
            this.potenciaLabel.Name = "potenciaLabel";
            this.potenciaLabel.Size = new System.Drawing.Size(52, 13);
            this.potenciaLabel.TabIndex = 6;
            this.potenciaLabel.Text = "Potencia:";
            // 
            // intrucoesLabel
            // 
            this.intrucoesLabel.AutoSize = true;
            this.intrucoesLabel.Location = new System.Drawing.Point(53, 109);
            this.intrucoesLabel.Name = "intrucoesLabel";
            this.intrucoesLabel.Size = new System.Drawing.Size(59, 13);
            this.intrucoesLabel.TabIndex = 7;
            this.intrucoesLabel.Text = "Instruções:";
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(16, 248);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 8;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // boxDeCaracter
            // 
            this.boxDeCaracter.Location = new System.Drawing.Point(301, 29);
            this.boxDeCaracter.Name = "boxDeCaracter";
            this.boxDeCaracter.ReadOnly = true;
            this.boxDeCaracter.Size = new System.Drawing.Size(100, 20);
            this.boxDeCaracter.TabIndex = 9;
            // 
            // caracterLabel
            // 
            this.caracterLabel.AutoSize = true;
            this.caracterLabel.Location = new System.Drawing.Point(233, 29);
            this.caracterLabel.Name = "caracterLabel";
            this.caracterLabel.Size = new System.Drawing.Size(47, 13);
            this.caracterLabel.TabIndex = 10;
            this.caracterLabel.Text = "Caracter";
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(116, 248);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 11;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // ProgramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 294);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.caracterLabel);
            this.Controls.Add(this.boxDeCaracter);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.intrucoesLabel);
            this.Controls.Add(this.potenciaLabel);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.boxDeInstrucoes);
            this.Controls.Add(this.boxDePotencia);
            this.Controls.Add(this.boxDeTempo);
            this.Controls.Add(this.boxDeNome);
            this.Name = "ProgramaForm";
            this.Text = "InstrucoesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxDeNome;
        private System.Windows.Forms.TextBox boxDeTempo;
        private System.Windows.Forms.TextBox boxDePotencia;
        private System.Windows.Forms.RichTextBox boxDeInstrucoes;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.Label potenciaLabel;
        private System.Windows.Forms.Label intrucoesLabel;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.TextBox boxDeCaracter;
        private System.Windows.Forms.Label caracterLabel;
        private System.Windows.Forms.Button cancelarButton;


    }
}