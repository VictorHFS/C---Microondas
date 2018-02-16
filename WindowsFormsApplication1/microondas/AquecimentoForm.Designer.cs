namespace WindowsFormsApplication1.Microondas
{
    partial class AquecimentoForm
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
            this.tempoBox = new System.Windows.Forms.TextBox();
            this.potenciaBox = new System.Windows.Forms.TextBox();
            this.AquecerButton = new System.Windows.Forms.Button();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.potenciaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SegundosBox
            // 
            this.tempoBox.Location = new System.Drawing.Point(90, 73);
            this.tempoBox.Name = "SegundosBox";
            this.tempoBox.Size = new System.Drawing.Size(100, 20);
            this.tempoBox.TabIndex = 0;
            // 
            // PotenciaBox
            // 
            this.potenciaBox.Location = new System.Drawing.Point(90, 118);
            this.potenciaBox.Name = "PotenciaBox";
            this.potenciaBox.Size = new System.Drawing.Size(100, 20);
            this.potenciaBox.TabIndex = 1;
            // 
            // AquecerButton
            // 
            this.AquecerButton.Location = new System.Drawing.Point(105, 165);
            this.AquecerButton.Name = "AquecerButton";
            this.AquecerButton.Size = new System.Drawing.Size(75, 23);
            this.AquecerButton.TabIndex = 2;
            this.AquecerButton.Text = "Aquecer";
            this.AquecerButton.UseVisualStyleBackColor = true;
            this.AquecerButton.Click += new System.EventHandler(this.AquecerButton_Click);
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(40, 76);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(46, 13);
            this.tempoLabel.TabIndex = 3;
            this.tempoLabel.Text = "Tempo :";
            // 
            // potenciaLabel
            // 
            this.potenciaLabel.AutoSize = true;
            this.potenciaLabel.Location = new System.Drawing.Point(31, 118);
            this.potenciaLabel.Name = "potenciaLabel";
            this.potenciaLabel.Size = new System.Drawing.Size(55, 13);
            this.potenciaLabel.TabIndex = 4;
            this.potenciaLabel.Text = "Potencia :";
            this.potenciaLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // AquecimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.potenciaLabel);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.AquecerButton);
            this.Controls.Add(this.potenciaBox);
            this.Controls.Add(this.tempoBox);
            this.Name = "AquecimentoForm";
            this.Text = "AquecimentoForm";
            this.Load += new System.EventHandler(this.AquecimentoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempoBox;
        private System.Windows.Forms.TextBox potenciaBox;
        private System.Windows.Forms.Button AquecerButton;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.Label potenciaLabel;
    }
}