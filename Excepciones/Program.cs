using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Bioxor\Documents\x\pato.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText(@"C:\Users\Bioxor\Documents\x\pato2.txt");
                Console.WriteLine(content2);

                throw new Exception("Ocurrio algo raro");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Aquí me he ejecutado, pase lo que pase");
            }

            Console.WriteLine("Aqui se sigue ejecutando");
        }
    }
}
