using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Service;

namespace WindowsFormsApplication1.Programas
{
    public partial class ProgramaForm : Form
    {
        private bool editar;
        private Programa programa;
        ProgramaService programaService;
        //metodo usado para visualizar e editar programa
        public ProgramaForm(ProgramaService programaService,Programa programa,bool editar)
        {
            this.programa = programa;
            this.editar = editar;
            InitializeComponent();
            this.programaService = programaService;
            //se os boxes não são editaveis
            if(!editar){
                boxDeNome.ReadOnly = true;
                boxDePotencia.ReadOnly = true;
                boxDeTempo.ReadOnly = true;
                boxDeInstrucoes.ReadOnly = true;
            }
            //seta o valor dos boxes com o programa passado em parametro
            boxDeNome.Text = programa.getNome();
            boxDeTempo.Text =  programa.getTempo().ToString();
            boxDePotencia.Text = programa.getPotencia().ToString();
            boxDeInstrucoes.Text = programa.getInstrucoes();
        }
        //metodo usado para cadastrar novos programas
        public ProgramaForm()
        {
            InitializeComponent();
            //boxes são editaveis
            boxDeNome.ReadOnly = false;
            boxDePotencia.ReadOnly = false;
            boxDeTempo.ReadOnly = false;
            boxDeInstrucoes.ReadOnly = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxeDeNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                programaService.editar(programa);
            }
            else
            {
                programaService.salvar(
                    new Programa(boxDeNome.Text.Trim(),
                                boxDeInstrucoes.Text.Trim(),
                                Int32.Parse(boxDePotencia.Text.Trim()),
                                Int32.Parse(boxDeTempo.Text.Trim()),
                                boxDeCaracter.Text.First()));
            }
        }
    }
}
