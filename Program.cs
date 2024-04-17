using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //csharp_typesystem_snacks 1

            //Console.WriteLine("Inserisci il primo numero");

            //int numero1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Inserisci il secondo numero");

            //int numero2 = Convert.ToInt32(Console.ReadLine());

            //int numMajor = 0;

            //if (numero1 > numero2)
            //{
            //    numMajor = numero1;
            //}
            //if (numero2 > numero1)
            //{
            //    numMajor = numero2;
            //}
            //else
            //{
            //    Console.WriteLine("Reinserisci un altro numero...i numeri sono pari ");
            //}

            //Console.WriteLine($"Il numero maggiore che hai inserito è: {numMajor} ");

            //Snacks 2 


            //Console.WriteLine("Inserisci la prima parola");

            //string word1 = Console.ReadLine();

            //Console.WriteLine("Inserisci la seconda parola");

            //string word2 = Console.ReadLine();

            //string straightword = "";
            //string longword = "";

            //if (word1.Length > word2.Length)
            //{
            //    straightword = word2;
            //    longword = word1;
            //}
            //else if (word2.Length > word1.Length)
            //{
            //    longword = word2;
            //    straightword = word1;
            //}
            //else
            //{
            //    Console.WriteLine("Le parole che hai inserito hanno la stessa lunghezza!");
            //}

            //Console.WriteLine($"Hai inserito le parole: {straightword} e {longword} ");


            //Snack3 

            //    Console.WriteLine("Inserisci un numero: ");

            //    int[] tenNumbers = new int[10];
            //    int index = 0;

            //    foreach (var number in tenNumbers)
            //    {
            //        Console.WriteLine("Inserisci un numero: ");
            //        tenNumbers[index] = int.Parse(Console.ReadLine());
            //        index++;
            //    }

            //    int somma = 0;

            //    foreach (var number in tenNumbers)
            //    {
            //        somma += number;
            //    }

            //    Console.WriteLine($"La somma dei numeri che hai inserito è: {somma} ");

            //}

            //Snack 4
            //Calcola la somma e la media dei numeri da 2 a 10.

            int[] numbersss = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int somma = 0;

            foreach (int number in numbersss) {
                somma += number;
            }

            decimal media = ((decimal)somma / numbersss.Length);


            Console.WriteLine($"La somma dei numeri è: {somma}");
            Console.WriteLine($"La media dei numeri è: {media}");
        }


        //Snack 5
        //Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
        //Snack 6
        //In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
        //    Snack 7
        //Crea un array vuoto.
        //Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
        //    Snack 8
        //Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
        //Snack 9
        //Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
        //Snack 10
        //Fai inserire un numero, che chiameremo N, all’utente.
        //Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
        //Ogni volta che ne crei uno, stampalo a schermo.
    }
    }
