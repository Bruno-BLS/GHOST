using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace EditorHTML
{

    public class View
    {

        public void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("--------------");
            Replace(text);
            Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex("@<s*strong[^>]*>");
            var words = text.Split('');

            for (var i = 0; i <= words.Length; i++)

            {
                if (strong.IsMatch(words[i])) ;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(
                    words[i].Substring(
                          words[i].IndexOf('>') + 1,(
                             words[i].LastIndexOf('<') - 1) -
                             words[i].LastIndexOf('>')
                            )
                                                    
                 )
                         

                
                
                
                
                
                
                
             }



            


        }


    }
}