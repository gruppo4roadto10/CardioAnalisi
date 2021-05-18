using System;
using System.IO;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string FrequenzaBattitiConsigliata(int eta)
        {

            int freq = 220 - eta;
            double max = (freq * 90) / 100;
            double min = (freq * 70) / 100;
            string risultato = ($"Il numero massimo di battiti è {max} , il numero minimo battiti è {min}");
            return risultato;


        }
        public static bool Bradicardiaco(int battiti)
        {
            Console.WriteLine("Inserisci un numero di battiti");

            if (battiti < 60)
            {
                Console.Write("Bradicardiaco");
                return true;
            }
            else return false;
        }
        public static bool Normale(int battiti)
        {

            if (battiti > 60 && battiti <= 100)
            {
                Console.Write("Normale");
                return true;
            }
            else return false;
        }
        public static bool Tachicardia(int battiti)
        {

            if (battiti > 100)
            {
                Console.Write("Tachicardia");
                return true;
            }
            else return false;
        }
        public static double CalorieUomo(double a, double p, double f, double t)
        {
            double calorieBruciate = ((a * 0.2017) + (p * 0.199) + (f * 0.6309) - 55.0969 * t / 4.184);
            return Math.Round(calorieBruciate, 2);


        }
        public static double CalorieDonna(double a, double p, double f, double t)
        {
            double calorieBruciate = ((a * 0.074) - (p * 0.126) + (f * 0.4472) - 20.4022 * t / 4.184);
            return Math.Round(calorieBruciate, 2);


        }
        public static double CalorieCorsa(double kmpercorsi, double pesocorporeo)
        {
            double spesaEnergetica = 0.9 * kmpercorsi * pesocorporeo;
            return spesaEnergetica;
        }
        public static double CalorieCamminata(double kmpercorsi, double pesocorporeo)
        {
            double spesaEnergetica = 0.50 * kmpercorsi * pesocorporeo;
            return spesaEnergetica;
        }

    }
}







