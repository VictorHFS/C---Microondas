using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Microondas;
using WindowsFormsApplication1.Programas;

namespace WindowsFormsApplication1.Service
{
    public class ProgramaService
    {
        ProgramasCadastrados programas;

        public ProgramaService(ProgramasCadastrados programas)
        {
            this.programas = programas;
        }

        public void salvar(Programa novo)
        {
            programas.cadastrar(novo);
        }
        public void remover(Programa programa)
        {
            programas.remover(programa.getNome());
        }
        public void editar(Programa novo)
        {
            foreach (Programa p in programas.buscarTodos())
            {
                if (p.getId() == novo.getId())
                {
                    programas.editar(novo);
                }
            }
        }
        public ProgramasCadastrados buscarProgramas()
        {
            return programas;
        }
        public Programa buscarPorNome(String nome)
        {
            //verifica se a entrada é compativel com algum programa cadastrado
            foreach (Programa programa in programas.buscarTodos())
            {
                if (programa.getNome().ToUpper() == nome.ToUpper())
                {
                    return programa;
                }
            }
            throw new Exception("Programa não encontrado!");
        }

        public Programa programaPadrao()
        {
            return new Programa("","",8,30,'.');
        }
    }
}
