using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Programas.PreCadastrados
{
    class Carne: Programa
    {
        public Carne()
        {
            setId(System.Guid.NewGuid().ToString());
            setNome("Carne");
            setTempo(900);
            setPotencia(5);
            setInstrucoes("Para se aquecer uma Carne digite 'Carne' na caixa de Entrada e clique em aquecimento rapido.");
            setCaracterDeCarregamento('c');
        }
    }
}
