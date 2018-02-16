using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Programas;
using WindowsFormsApplication1.Programas.PreCadastrados;

namespace WindowsFormsApplication1.Microondas
{
    public class ProgramasCadastrados
    {
        List<Programa> programas;

        public ProgramasCadastrados()
        {
            programas = new List<Programa>();
            programas.Add(new Peixe());
            programas.Add(new Carne());
            programas.Add(new Vegetais());
            programas.Add(new Lasanha());
            programas.Add(new Frango());
        }
        public void cadastrar(Programa novo)
        {
            if(buscar(novo.getNome().ToUpper()) == null){
               programas.Add(novo);
            }
            else
            {
                throw new Exception("Programa com esse nome ja existe.");
            }
        }
        public void remover(String nome)
        {
            foreach (Programa i in programas)
            {
                if (i.getNome() == nome)
                {
                    programas.Remove(i);
                }
            }
            throw new Exception("Programa não foi encontrado!");
        }
        public Programa buscar(String nome)
        {
            foreach(Programa i in programas){
                if(i.getNome() == nome){
                    return i;
                }
            }
            throw new Exception("Programa não foi encontrado!");
        }
        public List<Programa> buscarTodos(){
            return programas;
        }
        public void editar(Programa programa)
        {
            foreach(Programa p in programas){
                if(p.getId() == programa.getId()){
                    programas.Remove(p);
                    programas.Add(programa);
                }
            }
        }
    }
}
