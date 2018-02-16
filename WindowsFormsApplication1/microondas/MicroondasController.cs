using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Service;
using WindowsFormsApplication1.Programas;
using System.Timers;

namespace WindowsFormsApplication1.Microondas
{
    public class MicroondasController
    {
        ProgramaService programaService;
        Microondas microondas;
        public MicroondasController(ProgramasCadastrados programas, String entrada)
        {
            programaService = new ProgramaService(programas);
            microondas = new Microondas(entrada);
        }       

        public void aquecimentoRapido()
        {           
            Programa programa;
            try
            {
                programa = programaService.buscarPorNome(microondas.getEntrada());
            }catch(Exception e){
                Console.Write(e.StackTrace);
                programa = programaService.programaPadrao();
            }
            
            AquecendoForm aquecendo = new AquecendoForm(programa);
            aquecendo.Show();  
        }
        public void aquecer(int tempo, int potencia)
        {            
            Programa programa = new Programa("", "", potencia, tempo, '.');
            AquecendoForm aquecendo = new AquecendoForm(programa);
            aquecendo.Show();  
        }

        public void atualizaEntrada(String entrada)
        {
            microondas.setEntrada(entrada);
        }

        public void aquecer(int segundos, int potencia, string caminhoDoArquivo)
        {
            Programa programa = new Programa("", "", potencia, segundos, '.');
            new AquecendoForm(programa, caminhoDoArquivo).Show();  
        }
    }
}
