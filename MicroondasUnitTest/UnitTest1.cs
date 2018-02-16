using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1.Microondas;
namespace MicroondasUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        MicroondasController controller;

        [TestMethod]
        public void TestarAquecimentoRapidoSemEntrada()
        {
            controller = new MicroondasController(new ProgramasCadastrados(), "");
            controller.aquecimentoRapido();            
        }

        [TestMethod]
        public void TestarAquecimentoRapidoComEntrada()
        {
            controller = new MicroondasController(new ProgramasCadastrados(), "Peixe");
            controller.aquecimentoRapido();

            controller = new MicroondasController(new ProgramasCadastrados(), "Nao Existe");
            controller.aquecimentoRapido();            
        }
    }
}
