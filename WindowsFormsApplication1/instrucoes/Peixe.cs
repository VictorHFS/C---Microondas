using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Programas.PreCadastrados
{
    class Peixe: Programa
    {
         public Peixe()
        {
            setId(System.Guid.NewGuid().ToString());
            setNome("Peixe");
            setTempo(300);
            setPotencia(6);
            setInstrucoes("Para se aquecer um Peixe digite 'Peixe' na caixa de Entrada e clique em aquecimento rapido.");
            setCaracterDeCarregamento('p');
        }
    }
}
