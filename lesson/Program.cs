
//using Insulti;
using System;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            int[] vet_sorgente = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            vettore vet= new vettore(vet_sorgente);
            Console.WriteLine($"Inizializzata classe vettore: {vet}");
            //Blame.Suca();
            //Insulti.Blame.Suca();

            try
            {
                vettore vettore = new vettore(vet_sorgente);

                Console.WriteLine($"Inizializzata classe Vettore: {vettore}");
                Console.WriteLine($"Valore medio: {vettore.Media()}");
                Console.WriteLine($"Valore minimo: {vettore.ValoreMinimo()}");
                Console.WriteLine($"Valore massimo: {vettore.ValoreMassimo()}");

                Console.WriteLine("I numeri pari sono i seguenti:");
                vettore.printEvenNumber();
            }
            catch
            {
                Console.WriteLine("Errore");
            }

            try 
            {
                vettore vetxt = new vettore();
                vetxt.Serialize("mio-file.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore");
            }

        }
    }
}
