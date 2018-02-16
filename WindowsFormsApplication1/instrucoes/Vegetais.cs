using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Programas.PreCadastrados
{
    class Vegetais: Programa
    {
        public Vegetais()
        {
            setId(System.Guid.NewGuid().ToString());
            setNome("Vegetais");
            setTempo(150);
            setPotencia(8);
            setInstrucoes("Para se aquecer os Vegetais digite 'Vegetais' na caixa de Entrada e clique em aquecimento rapido.");
            setCaracterDeCarregamento('v');
        }
    }
}
