using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Programas
{
    public class Programa
    {
        private String id;
        private String nome;
        private int potencia;
        private int tempo;
        private String instrucoes;
        private char caracterDeCarregamento;

        public Programa()
        {

        }
        public Programa(String nome, String instrucoes, int potencia, int tempo, char caracterDeCarregamento)
        {
            this.id = System.Guid.NewGuid().ToString();
            this.nome = nome;
            this.tempo = validaTempo(tempo);
            this.potencia = validaPotencia(potencia);
            this.instrucoes = instrucoes;
            this.caracterDeCarregamento = caracterDeCarregamento;
        }

        public String  getId(){
            return this.id;
        }
        public char getCaracter(){
            return caracterDeCarregamento;
        }
        public String getNome()
        {
            return this.nome;
        }
            
        public int getPotencia()
        {
            return this.potencia;
        }
        public int getTempo()
        {
            return this.tempo;
        }
        public String getInstrucoes(){
            return this.instrucoes;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setPotencia(int potencia)
        {
            this.potencia = validaPotencia(potencia);
        }
        public void setTempo(int tempo)
        {
            this.tempo = validaTempo(tempo);
        }
        public void setId(String id)
        {
            this.id = id;
        }
        public void setInstrucoes(String instrucoes)
        {
            this.instrucoes = instrucoes;
        }
        public void setCaracterDeCarregamento(char caracter)
        {
            this.caracterDeCarregamento = caracter;
        }
        private int validaTempo(int segundos){
            if(segundos== 0){
                throw new Exception("Favor solicitar o tempo de aquecimento!");
            }
            if (segundos < 120 || segundos > 0)
            {
                return segundos;
            }
            else
            {
                throw new Exception("Tempo solicitado excedo os limites do sistema!");
            }
        }
        private int validaPotencia(int potencia)
        {
                if (potencia >= 1 && potencia <= 10){
                    return potencia;
                }
                else
                {
                    throw new Exception("Potencia solicitada excede os limites do sistema!");
                }
            }
        }    
}
