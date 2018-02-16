using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Service;
using WindowsFormsApplication1.Programas;

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

        public String aquecimentoRapido()
        {
            Programa programa;
            try
            {
                programa = programaService.buscarPorNome(microondas.getEntrada());
            }catch(Exception e){
                Console.Write(e.StackTrace);
                programa = programaService.programaPadrao();
            }
            String textoDoAquecimento = "";
            AquecendoForm aquecendo = new AquecendoForm();
            aquecendo.Visible = true;
            for (int i = programa.getTempo() * programa.getPotencia(); i >= 0; i--)
            {
                aquecendo.atualizaTexto(textoDoAquecimento);
                textoDoAquecimento = textoDoAquecimento + programa.getCaracter();
            }
            textoDoAquecimento = "";
            return "Aquecida!";
        }

        public String aquecer(int tempo, int potencia)
        {
            String textoDoAquecimento = "";
            Programa programa = new Programa("", "", potencia, tempo, '.');
            AquecendoForm aquecendo = new AquecendoForm();
            aquecendo.Visible = true;
            for (int i = programa.getTempo() * programa.getPotencia(); i >= 0; i--)
            {
                aquecendo.atualizaTexto(textoDoAquecimento);
                textoDoAquecimento = textoDoAquecimento + programa.getCaracter();
            }
            textoDoAquecimento = "";
           
            return "Aquecida!";
        }

        public void atualizaEntrada(String entrada)
        {
            microondas.setEntrada(entrada);
        }
    }
}
