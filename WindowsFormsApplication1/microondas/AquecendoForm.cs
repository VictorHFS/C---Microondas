using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Programas;

namespace WindowsFormsApplication1.Microondas
{
    public partial class AquecendoForm : Form
    {
        private Programa programa;
        private int quantidadeDeCaracterers;  
        private String caracterVPotencia;
        private string caminhoDoArquivo;
        public AquecendoForm(Programa programa)
        {
            InitializeComponent();
            this.programa = programa;            
            timer.Start();
            quantidadeDeCaracterers = programa.getTempo() * programa.getPotencia();            
            caracterVPotencia = charVezesPotencia();
        }

        public AquecendoForm(Programa programa, string caminhoDoArquivo)
        {
            InitializeComponent();
            timer.Start();
            this.programa = programa;
            this.caminhoDoArquivo = caminhoDoArquivo;
            quantidadeDeCaracterers = programa.getTempo() * programa.getPotencia();
            caracterVPotencia = charVezesPotencia();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(Carregamento.TextLength<quantidadeDeCaracterers){                
                Carregamento.Text += caracterVPotencia;
            }
            if(Carregamento.TextLength==quantidadeDeCaracterers){
                timer.Stop();
                if (caminhoDoArquivo != null)
                {
                    StreamWriter sw = new StreamWriter(@caminhoDoArquivo);
                    sw.WriteLine(Carregamento.Text);
                    sw.Close();
                }
                MessageBox.Show("Aquecido!");
            }
        }
        private String charVezesPotencia()
        {
            String resultado = "";
            for (int i = 0; i < programa.getPotencia();i++ )
            {
                resultado += programa.getCaracter();
            }
            return resultado;
        }

        private void pausarButton_Click(object sender, EventArgs e)
        {
            if(pausarButton.Text == "Pausar"){
                timer.Stop();
                pausarButton.Text = "Retomar";
            }
            else
            {
                if(pausarButton.Text!=""){
                    timer.Start();
                    pausarButton.Text = "Pausar";
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            pausarButton.Text = "";
        }

    }
}
