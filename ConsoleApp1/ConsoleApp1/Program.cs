using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //  int x;
            /*  string t = "abcabcabcabc";
                x= contar(t);

              Console.WriteLine(x);*/

            Console.WriteLine(periodo("abcabcabcabcabc").ToString());
            Console.WriteLine(Hola("hhhhoooooooollllllllaaa"));
            
            Console.WriteLine(TodoenTodo("sequence", "subdfggsequence")?"YES":"NO");
        }
        public static int periodo(string cadena)
        {
    
            int length = cadena.Length;
            bool patterns;
            for (int i = 1; i <= length; i++)
            {
                if (length % i == 0)
                {
                    patterns = true;
                    for (int j = i; j < length; j++)
                    {
                        if (cadena[j] != cadena[j % i])
                        {
                            patterns = false;
                            break;
                        }
                    }
                    if (patterns)
                    {
                        return i;
                      
                    }
                }
            }
            return 0;
        }
        public static bool Hola(string s)
        {
            string[] saludo = { "h","o","l","a" };
            int pos = 0;
            string nextletter= "";
            for (int i = 0; i < s.Length; i++)
            {
                string letra = s.Substring(i, 1);

                if (letra.Equals(saludo[pos]))
                {
                    if ((i + 1) < s.Length)
                    {
                        nextletter = s.Substring((i + 1), 1);
                        if (!nextletter.Equals(letra))
                        {
                            if ((pos + 1)>3)
                            {
                                return true;
                            }
                            else
                            {
                                pos += 1;
                            }
                         
                        }
                    }
                }
                else
                {
                    return false;
                  
                }
            }
            return true;
        }

        public static bool TodoenTodo(string s, string t) {

            string palabra = "";
            string palabras = "";
            if (t.Contains(s))
            {
                return true;
            }
            else
            {
                palabra = t;
                for (int i = 0; i < s.Length; i++)
                {
                    string letter = s.Substring(i,1);
                    int j = 0;
                    while (j<palabra.Length)
                    {
                        string subletter = palabra.Substring(j, 1);

                        if (letter.Equals(subletter))
                        {

                            palabra.Remove(j);
                            palabras += letter;
                            break;
                        }
                        j++;

                    }
                 
                  

                }
                if (palabras.Equals(s)) {
                    return true;
                }
                else
                {
                    return false;
                }
                
               
            }

         
        }

        public static int contar(string palab)
        {
            //var count = 0;
            //string[] myArray = new string[palab.Length];
            string texto = "";
            string respuesta = "";
            int pos =1 ;
            int contador=0,min=100000;
            int posicion = 1;
            while (posicion < palab.Length)
            {
                texto = palab.Substring(0, posicion);
                Console.WriteLine(texto);

                pos = texto.Length-1;
                while ((pos + texto.Length) < palab.Length)
                {
                    if (texto.Equals(palab.Substring(pos, (pos + texto.Length))))
                    {
                        contador++;
                    }
                    pos += texto.Length;
                }
                if (contador<min&&contador!=0)
                {
                    min = contador;
                    respuesta = texto;

                   
                }
              
                contador = 0;
                posicion += 1;
            }
            return respuesta.Length;
       
        
        }
    }
}
