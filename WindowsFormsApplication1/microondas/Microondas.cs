using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Programas;
using WindowsFormsApplication1.Programas.PreCadastrados;

namespace WindowsFormsApplication1.Microondas
{
    public class Microondas
    {
        private String entrada;

        public String getEntrada()
        {
            return entrada;
        }

        public Microondas(String entrada)
        {
            this.entrada = entrada;
        }
        public void setEntrada(String entrada)
        {
            this.entrada = entrada;
        }
    }   
}
