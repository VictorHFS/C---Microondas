using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Programas.PreCadastrados
{
    class Lasanha: Programa
    {
        public Lasanha(){
            setId(System.Guid.NewGuid().ToString());
            setNome("Lasanha");
            setTempo(900);
            setPotencia(8);
            setInstrucoes("Para se aquecer uma Lasanha digite 'Carne' na caixa de Entrada e clique em aquecimento rapido.");
            setCaracterDeCarregamento('l');
        }
    }
}
