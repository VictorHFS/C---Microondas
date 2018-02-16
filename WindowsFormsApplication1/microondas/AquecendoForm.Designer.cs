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
            this.components = new System.ComponentModel.Container();
            this.Carregamento = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pausarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pausarButton
            // 
            this.pausarButton.Location = new System.Drawing.Point(23, 74);
            this.pausarButton.Name = "pausarButton";
            this.pausarButton.Size = new System.Drawing.Size(75, 23);
            this.pausarButton.TabIndex = 1;
            this.pausarButton.Text = "Pausar";
            this.pausarButton.UseVisualStyleBackColor = true;
            this.pausarButton.Click += new System.EventHandler(this.pausarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(189, 74);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // AquecendoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 109);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.pausarButton);
            this.Controls.Add(this.Carregamento);
            this.Name = "AquecendoForm";
            this.Text = "AquecendoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Carregamento;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button pausarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}