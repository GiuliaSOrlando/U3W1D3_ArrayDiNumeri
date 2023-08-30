using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3W1D3_ArrayDiNumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determino la lunghezza dell'array
            Console.WriteLine("Inserisci il numero di elementi da inserire nell'array: ");
            int NumeriInteri = int.Parse(Console.ReadLine());
            int[] ArrayDiNumeri = new int[NumeriInteri];

            //Assegno il valore agli elementi dell'array
            for(int num = 0; num < NumeriInteri; num++)
            {
                Console.WriteLine($"Inserisci il {num + 1}° numero: ");
                ArrayDiNumeri[num] = int.Parse(Console.ReadLine());
            }

            //Stampa l'array
            Console.WriteLine("Numeri inseriti nell'array:");
            string ArrayComeStringa = string.Join(", ", ArrayDiNumeri);
            Console.WriteLine(ArrayComeStringa);
        

            //Esegui (e stampa) la somma di tutti i numeri dell'array
            int somma = 0;
            foreach(int num in ArrayDiNumeri)
            {
                somma += num;
            }
            Console.WriteLine($"La somma di tutti i numeri è: {somma}");

            //Esegui (e stampa) la media aritmetica di tutti i numeri dell'array
            double media = 0;
            media =  somma / ArrayDiNumeri.Length;
            
            Console.WriteLine($"La media aritmetica di tutti i numeri è: {media}");
            Console.ReadLine();

        }
    }
}
