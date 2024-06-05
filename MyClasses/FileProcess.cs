using System.IO;

namespace MyClasses
{
    public class FileProcess
    {
        public bool FileExists(string fileName) //método para saber se arquivo existe
        {
            //se o parametro passado é vazio ou nulo
            if (string.IsNullOrEmpty(fileName))
            {
                throw new System.ArgumentNullException("fileName"); //throw é usado para sinalizar uma situação anormal
            }
            return File.Exists(fileName); //determina se o arquivo existe
        }
    }
}
