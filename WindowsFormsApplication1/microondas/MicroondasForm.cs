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
using WindowsFormsApplication1.Programas.PreCadastrados;
using WindowsFormsApplication1.Service;

namespace WindowsFormsApplication1.Microondas
{
    public partial class MicroondasForm : Form
    {
        ProgramasCadastrados programas;        
        MicroondasController microondasController;
        ProgramaService programaService;
        //Instrucao instrucoes = new Instrucao();
        public MicroondasForm()
        {
            InitializeComponent();
            this.programas = new ProgramasCadastrados();            
            this.microondasController = new MicroondasController(programas, boxDeEntrada.Text);            
            this.programaService = new ProgramaService(programas);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aquecimento_Click(object sender, EventArgs e)
        {
            new AquecimentoForm(microondasController).Visible = true;
        }

        private void aquecimentoRapido_Click(object sender, EventArgs e)
        {
            microondasController.atualizaEntrada(boxDeEntrada.Text);
            MessageBox.Show(microondasController.aquecimentoRapido());                        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frangoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //new InstrucoesForm(instrucoes.).Visible = true ;
        }
        private void BotaoConsultar_Click(object sender, EventArgs e)
        {
            //verifica se existe um programa cadastrado com o nome igual ao pesquisado na consulta
            foreach(Programa programa in programas.buscarTodos()){
                if(programa.getNome().ToUpper() == BoxDeConsulta.Text.ToUpper()){
                    new ProgramaForm(programaService,programa,true).Visible = true;
                    break;
                }
            }
            
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ListaDeProgramasForm(programas).Visible = true;
        }

        private void frangoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
    }
}
