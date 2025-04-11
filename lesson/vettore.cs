using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    /// <summary>
    /// Questa classe gestisce un vettore di interi e fornisce
    /// diversi metodi d'appoggio
    /// </summary>
    public class vettore
    {
        /// <summary>
        /// Il vettore di interi gestito
        /// </summary>
        public int[] vet;

        /// <summary>
        /// Crea un'istanza vuota dell'oggetto vettore
        /// </summary>
        public vettore()
        {
            //Metodo costruttore 1: vuoto
            vet = new int[0];
        }

        /// <summary>
        /// Crea un'istanza dell'oggetto vettore, 
        /// a partire dall'array specificato
        /// </summary>
        /// <param name="vettore"></param>
        public vettore(int[] vettore)
        {
            if (vettore == null)
            {
                throw new ArgumentNullException("Non è possibile inizializzare la classe con un vettore nullo");
            }
            this.vet = vettore;
            //_vet= vettore;
        }

        /// <summary>
        /// Calcola il valore medio di tutte le celle
        /// </summary>
        /// <returns>Il valore medio</returns>
        public float Media()
        {

            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può fare la media di un vettore vuoto");
            }

            float media = 0;
            int i = 0;
            for (i = 0; i < vet.Length; i++)
            {
                media += vet[i];
            }
            media /= i;
            return media;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return vet.Length == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ValoreMinimo()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può operare su un vettore vuoto");
            }

            int min = vet[0];
            foreach (int i in vet)
            {
                if (min > i) 
                {
                    min = i;
                }
            }

            return min;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ValoreMassimo()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può operare su un vettore vuoto");
            }

            int max = vet[0];
            foreach (int i in vet)
            {
                if (max < i)
                {
                    max = i;
                }
            }

            return max;

        }

        /// <summary>
        /// Famo na stringa
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "[ ";

            if (!isEmpty())
            {
                for (int i = 0; i < vet.Length - 1; i++)
                {
                    result += $"{vet[i]}, ";
                }

                result += $"{vet[vet.Length - 1]} ";
            }

            result += "]";

            return result;
        }


        public void printEvenNumber()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può operare su un vettore vuoto");
            }

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }

        }

        /// <summary>
        /// Ordina l'array con l'algoritmo di ordinamento per selezione
        /// </summary>
        public void Sort()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Non si può operare su un vettore vuoto");
            }

            int temp = 0;
            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = i; j < vet.Length - 1; j++)
                {
                    if (vet[i] < vet[j + 1])
                    {
                        temp = vet[i];
                        vet[i] = vet[j + 1];
                        vet[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Serializza l'oggetto sul file specificato
        /// </summary>
        /// <param name="path">Il percorso del file</param>
        public void Serialize(string path)
        {
            StreamWriter writer = new StreamWriter("mio-file.txt", false);
            writer.Write(vet.ToString());
            writer.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static vettore Deserialize(string path) 
        {
            throw new NotImplementedException();
        }


    }
}

