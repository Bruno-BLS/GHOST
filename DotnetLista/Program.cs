using System;
using System.Runtime.CompilerServices;


namespace DotnetLista
{



    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            try
            {

                //for (var index = 0; index < 10; index++)
                //{
                //System.IndexOutOfRangeException
                //  Console.WriteLine(arr[index]);
                //}
                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("não encontrei o índice na lista");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops algo deu errado!");
                // Console.WriteLine(ex.InnerException);
                // Console.WriteLine(ex.Message);
            }
            
        }
        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
               throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }



 }



}