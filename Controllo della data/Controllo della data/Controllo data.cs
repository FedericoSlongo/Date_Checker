using System;

namespace Controllo_della_data
{
    class Program
    {
        static void Main(string[] args)
        {
            int giorno, anno, mese;
            do
            {
                Console.Write("Inserire giorno valido ");
                giorno = Convert.ToInt32(Console.ReadLine());
            } while (giorno > 31);
            do
            {
                Console.Write("Inserire mese ");
                mese = Convert.ToInt32(Console.ReadLine());
            } while (mese > 12); 
            Console.Write("Inserire anno ");
            anno = Convert.ToInt32(Console.ReadLine());

            if (mese == 2 && giorno > 28)
            {
                Console.WriteLine("Febbrario non ha più di 28 giorni");
            }
            else
            {
                if (anno < 0 || mese < 0 || giorno < 0)
                {
                    Console.WriteLine("Data inserita è sotto lo zero");
                }
                else if (anno % 4 == 0)
                {
                    if (anno % 100 == 0)
                    {
                        Console.WriteLine("L'anno non è bisestile");
                    }
                    else if (anno % 400 == 0)
                    {
                        Console.WriteLine("L'anno non è bisestile");
                    }
                    else
                    {
                        Console.WriteLine("L'anno è bisestile");
                    }
                }
            }
        }
    }
}
