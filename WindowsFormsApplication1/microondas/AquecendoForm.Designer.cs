namespace WindowsFormsApplication1.Microondas
{
    partial class AquecendoForm
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
            this.Carregamento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Carregamento
            // 
            this.Carregamento.Location = new System.Drawing.Point(23, 26);
            this.Carregamento.Name = "Carregamento";
            this.Carregamento.ReadOnly = true;
            this.Carregamento.Size = new System.Drawing.Size(260, 20);
            this.Carregamento.TabIndex = 0;
            this.Carregamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AquecendoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 71);
            this.Controls.Add(this.Carregamento);
            this.Name = "AquecendoForm";
            this.Text = "AquecendoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Carregamento;
    }
}