using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Programas.PreCadastrados
{
    public class Frango : Programa
    {        
        public Frango()
        {
            setId(System.Guid.NewGuid().ToString());
            setNome("Frango");
            setTempo(600);
            setPotencia(3);
            setInstrucoes("Para se aquecer um frango digite 'Frango' na caixa de Entrada e clique em aquecimento rapido.");
            setCaracterDeCarregamento('f');
        }
    }
}
