using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Microondas
{
    public partial class AquecendoForm : Form
    {
        public AquecendoForm()
        {
            InitializeComponent();
        }
        public void atualizaTexto(String entrada){
            //System.Threading.Thread.Sleep(100);
            Carregamento.Text = entrada;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
