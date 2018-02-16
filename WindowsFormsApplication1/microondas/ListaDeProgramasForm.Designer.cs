namespace WindowsFormsApplication1.Programas
{
    partial class ListaDeProgramasForm
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
            this.programasListView = new System.Windows.Forms.ListView();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programasListView
            // 
            this.programasListView.Location = new System.Drawing.Point(12, 12);
            this.programasListView.Name = "programasListView";
            this.programasListView.Size = new System.Drawing.Size(260, 183);
            this.programasListView.TabIndex = 0;
            this.programasListView.UseCompatibleStateImageBehavior = false;
            this.programasListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.programasListView.DoubleClick += new System.EventHandler(this.programasListView_DoubleClick);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(25, 216);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.cadastrarButton.TabIndex = 1;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // ListaDeProgramasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.programasListView);
            this.Name = "ListaDeProgramasForm";
            this.Text = "CadastroDeProgramasForm";
            this.Load += new System.EventHandler(this.CadastroDeProgramasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView programasListView;
        private System.Windows.Forms.Button cadastrarButton;
    }
}