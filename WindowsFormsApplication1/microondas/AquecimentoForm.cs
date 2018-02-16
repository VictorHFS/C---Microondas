using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Programas;

namespace WindowsFormsApplication1.Microondas
{
    public partial class AquecimentoForm : Form
    {
        MicroondasController microondasController;
        private string caminhoDoArquivo;
        public AquecimentoForm(MicroondasController microondasController)
        {
            InitializeComponent();
            this.microondasController = microondasController;
        }

        public AquecimentoForm(MicroondasController microondasController, string caminhoDoArquivo)
        {
            InitializeComponent();
            this.microondasController = microondasController;
            this.caminhoDoArquivo = caminhoDoArquivo;
        }

        private void AquecimentoForm_Load(object sender, EventArgs e)
        {

        }

        private void AquecerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int segundos = Int32.Parse(this.tempoBox.Text.Trim());
                int potencia = Int32.Parse(this.potenciaBox.Text.Trim());
                if(caminhoDoArquivo == null){
                    microondasController.aquecer(segundos,potencia);
                }
                else
                {
                    microondasController.aquecer(segundos, potencia, caminhoDoArquivo);
                }
            }catch(Exception exception){
                MessageBox.Show(exception.Message);                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
