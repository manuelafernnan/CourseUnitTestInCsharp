using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest

    /**O QUE É AAA??
     * Arrange (Iniciar variáveis)
     * Act (Invocar método para testar)
     * Assert (Verificar a ação)**/
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExists()
        {
            //ARRANGE: classe "FileProcess" criando variável "fp" com instancia já definida em FileProcess()
            FileProcess fp = new FileProcess();
            bool fromCall;

            //AÇÃO: bool recebe a variavel + metodo para verificar se documento passado existe
            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

            //ASSERT: verificar se fromCall retornou true
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExists()
        {

            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Regedit.exe");
       
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            //To do;
            Assert.Inconclusive();
        }
    }
}
