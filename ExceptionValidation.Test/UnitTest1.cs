using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExceptionValidation.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                int[] arr = new int[] { 1, 2, 3 };
                int num = arr[3];
            }
            catch (Exception ex) 
            {
                Excecao.ListaExcecoes(ex);
                string erro = Excecao.Erro;
            }
        }
    }
}