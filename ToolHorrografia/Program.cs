using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> Dicci = new Dictionary<char, string>();
            Dicci.Add('a', "AAAAA");
            Dicci.Add('b', "AAAAB");
            Dicci.Add('c', "AAABA");
            Dicci.Add('d', "AAABB");
            Dicci.Add('e', "AABAA");
            Dicci.Add('f', "AABAB");
            Dicci.Add('g', "AABBA");
            Dicci.Add('h', "AABBB");
            Dicci.Add('i', "ABAAA");
            Dicci.Add('j', "ABAAA");
            Dicci.Add('k', "ABAAB");
            Dicci.Add('l', "ABABA");
            Dicci.Add('m', "ABABB");
            Dicci.Add('n', "ABBAA");
            Dicci.Add('o', "ABBAB");
            Dicci.Add('p', "ABBBA");
            Dicci.Add('q', "ABBBB");
            Dicci.Add('r', "BAAAA");
            Dicci.Add('s', "BAAAB");
            Dicci.Add('t', "BAABA");
            Dicci.Add('u', "BAABB");
            Dicci.Add('v', "BAABB");
            Dicci.Add('w', "BABAA");
            Dicci.Add('x', "BABAB");
            Dicci.Add('y', "BABBA");
            Dicci.Add('Z', "BABBB");



            Console.WriteLine("Ingresa texto");

            String texto;
            texto = Console.ReadLine();


            char[] array = texto.ToLower().ToCharArray();

            string[] arrayOut = new string[(array.Length)];

            int i = 0;
            foreach (var item in array)
            {
                if (Dicci.ContainsKey(item))
                {
                    arrayOut[i] = Dicci[item];
                    i++;
                }

            }

            string result = string.Concat(arrayOut);


            String texto2 = "";
            while (texto2.Length != result.Length)
            {
                if (texto2.Length >0)
                {
                    Console.WriteLine("Faltaron " + (result.Length - texto2.Length).ToString() +  "caracteres.");
                }
                Console.WriteLine("Ingresa un texto con " + result.Length.ToString());

                texto2 = Console.ReadLine();
            }

            char[] arrayResult1 = result.ToCharArray();
            char[] arrayResult = texto2.ToCharArray();


            for (int ii = 0; ii < arrayResult1.Length; ii++)
            {

                string p = arrayResult1[ii] == 'A' ? arrayResult[ii].ToString().ToLower() : arrayResult[ii].ToString().ToUpper();
                arrayResult[ii] = p[0];

            }

            string resultUltimate = string.Concat(arrayResult);


            Console.WriteLine(resultUltimate.ToString());

            foreach (var item in arrayOut)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }

}
