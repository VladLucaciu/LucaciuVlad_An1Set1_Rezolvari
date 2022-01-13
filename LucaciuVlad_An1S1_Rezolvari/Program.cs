using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaciuVlad_An1S1_Rezolvari
{
    class Program

    {

        static void P1()
        {
            // Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            float a, b;  // declaram a si b
            Console.Write("Introduceti valoarea lui a: ");
            a = float.Parse(Console.ReadLine());  // se citeste de la tastatura valoarea lui a

            Console.Write("Introduceti valoarea lui b: ");
            b = float.Parse(Console.ReadLine());

            if (a != 0)  // se declara conditia
            {
                float x;
                x = -b / a;  // metoda de rezolvare a unei ecuatii de grad 1 cu o necunoscuta
                Console.WriteLine("Rezultatul este {0}", x); // folosim tokenul ca si afisare a rezultatului obtinut
            }
            else  // metode de atentionare in cazul unor necorespondente
                Console.WriteLine("Nu este ecuatie!");
            Console.WriteLine("Apasati orice tasta");
            Console.ReadLine();
        }
        static void P2()
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 

            double a, b, c;  // declaram a,b,c
            Console.WriteLine("Introduceti valoarea lui a");
            a = double.Parse(Console.ReadLine()); // se citeste de la tastatura valoarea lui a

            Console.WriteLine("Introduceti valoarea lui b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti valoarea lui c");
            c = double.Parse(Console.ReadLine());
            // conditii si exceptii:
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Nu este un caz de ecuatie");
                else
                    Console.WriteLine("Problema este ecuatie de gradul doi cu rezolvarea: {0}", -c / b); // Metoda de rezolvare a ecutatiei de gradul 2 cu 1 necunoscuta
            }
            else
            { // conform formulelor de calcul tratam cazul delta < 0 ; delta = 0
                double delta = b * b - (4 * a * c);
                if (delta < 0)
                    Console.WriteLine("Ecuatia nu are solutie reala");
                else if (delta == 0)
                    Console.WriteLine("Ecuatia are o singura solutie : {0}", -b / (2 * a));
                else
                    Console.WriteLine("Solutiile sunt: x1={0} si x2={1}", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
            }
        }
        static void P3()
        {
            // Determinati daca n se divide cu k, unde n si k sunt date de intrare.
            int a, b;  // declaram a si b si operatiile matematice
            Console.Write("Introduceti valoarea lui a \n : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea lui b \n : ");
            b = int.Parse(Console.ReadLine());

            // conditii cu verificare si mesaj informare. 
            if (a % b == 0)
            {
                Console.WriteLine("{0} se divide la {1}", a, b);
            }
            else
                Console.WriteLine("{0} nu se divide la {1}.. ", a , b );
            Console.WriteLine("Apasati orice tasta pentru a iesi din program.. ");
            Console.ReadLine();
            
        }
        static void P4()
        {
            //Determinati daca un an y este an bisect

            int y;  // determinam y 
            Console.Write("Introduceti anul \n : ");  // citim de la tastatura anul pe care il verificam
            y = int.Parse(Console.ReadLine());
            // Unele excepții de la această regulă simplă sunt necesare, de vreme ce durata unui an tropical
            // este ușor mai scurtă decât 365,25 zile. De-a lungul unei perioade de 4 secole
            // (400 ani), eroarea acumulată prin adăugarea zilei de 29 februarie la fiecare patru ani, a condus
            // la un cuantum de 3 zile în plus. De aceea, calendarul gregorian înlătură de la socoteală trei
            // zile bisecte la fiecare 400 de ani, lungimea unui ciclu bisect.
            if (y % 4 == 0)
            {
                if (y % 100 != 0)
                    Console.WriteLine("{0} este an bisect.", y);
                else
                {
                    if (y % 400 == 0)
                        Console.WriteLine("{0} este an bisect.", y);
                    else
                        Console.WriteLine("{0} nu este an bisect", y);
                }

            }
            else
                Console.WriteLine("{0} nu este an bisect", y);
            Console.ReadLine();
        }

        // p5 Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        static bool apartine(int k, int n)
        {
            int cifre = 0;
            while (n != 0)
            {
                n /= 10;
                cifre++;
            }
            if (cifre >= k)
                return true;
            return false;
        }
        static void p5()
        {
            int n, k;
            Console.Write("introduceti valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\n introduceti valoarea lui k: ");
            k = int.Parse(Console.ReadLine());

            if (apartine(k, n) == true)
            {
                int copie_k = k, copie_n = n;
                while (k != 1)
                {
                    n /= 10;
                    k--;
                }
                Console.WriteLine("A {0}-a cifra a numarului {1} este {2}", copie_k, copie_n, n % 10);
            }
            else
                Console.WriteLine("Numarul trebuie sa aiba cel putin {0} termeni ", k);
            Console.ReadLine();
        }
        // p7 (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
        // Se cere sa se inverseze valorile lor.
        static void SWAP(ref float a, ref float b)
        {
            float aux = a;
            a = b;
            b = aux;
        }

        static void p7()
        {
            int a, b;
            Console.WriteLine("Introduceti valoarea lui a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine(" \n Introduceti valoarea lui b: ");
            b = int.Parse(Console.ReadLine());

            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine("Valorile dupa inversare sunt {0} si {1} ", a, b);
            Console.ReadLine();
        }

        //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
        //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
        static void p8()
        {
            int a, b;
            Console.WriteLine("Introduceti valoarea lui a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Introduceti valoarea lui b: ");
            b = int.Parse(Console.ReadLine());


            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Valorile dupa inversare sunt {0} si {1} ", a, b);
            Console.ReadLine();
        }

        //Afisati toti divizorii numarului n.
        static void p9()
        {
            int n;
            Console.Write("Introduceti valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            int d = 2;
            Console.Write("Divizorii sunt: 1");
            if (n % d == 0)
                Console.Write(" {0}",d);
            d++;
            while (d <= n / 2)
            {
                if (n % d == 0)
                    Console.Write(" {0}",d);
                d++;
            }
            
            Console.ReadLine();
        }


        //Test de primalitate: determinati daca un numar n este prim.
        static void p10()
        {
            int n;
            Console.Write("Introduceti valoarea lui n: ");
            n = int.Parse(Console.ReadLine());
            bool prim = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    prim = false;
            
            if (prim == true)
                     Console.WriteLine("Numarul {0} este prim", n);
            else
                     Console.WriteLine("Numarul {0} nu este prim", n);
            
            Console.ReadLine();
        }

        //Afisati in ordine inversa cifrele unui numar n
        static void p11()
        {
            int n, x;
            Console.Write("Introduceti valoarea lui n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Cifrele numarului sunt: ");
            while (n != 0)
            {
                x = n % 10;
                Console.Write("{0} ", x);
                n /= 10;
                
            }
            Console.ReadLine();
        }

        // p21 Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

        static void p21()
        {
            Random sol = new Random();
            int solutie = sol.Next(1024);
            int n;
            Console.WriteLine("{0} ", solutie); // Daca elimin aceasta linie, nu vad numarul care trebuie ghicit. Il las pentru verificare
            do
            {
                Console.Write("Dati un numar intre 0 si 1024: ");
                n = int.Parse(Console.ReadLine());
                if (n < solutie)
                    Console.WriteLine("Numarul este prea mic!");
                else if (n == solutie)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bravo! Ai ghicit!");
                }
                else
                    Console.WriteLine("Numarul  prea mare!");
            }
            while (n != solutie);
            Console.ReadLine();

        }

        
static void Main(string[] args)
        {
            //                Set  1  
            //P1(); //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
            //P2(); //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
            //P3(); //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            //P4(); //Determinati daca un an y este an bisect.
            //p5(); //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            //p7(); //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
            //p8(); //Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
            //p9(); //Afisati toti divizorii numarului n. 
            //p10(); //Test de primalitate: determinati daca un numar n este prim.
            //p11(); //Afisati in ordine inversa cifrele unui numar n. 
            //p21(); //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

        }

    }
}


    