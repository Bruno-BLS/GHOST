using System;


namespace MyApp
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            //var data = new DateTime(2020, 10, 12, 8, 23, 14);
            var data = DateTime.Now;
            // Y = year M = mês d= dia  h= hora  s= segundo

            var formatada = string.Format("{0:dd/MM/yyyy  hh:mm:ss}", data);
            Console.WriteLine(formatada);

             
          





        }
    







}



}

 