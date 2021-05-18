using System;
using System.Collections.Generic;
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
        public static void RiempiFile(List<int> battiti)
        {
            using(StreamWriter w = new StreamWriter("File1.txt"))
            {
                Random r = new Random();
                for(int i = 0; i < battiti.Count; i++)
                {
                    int temp = r.Next(10, 111);
                    w.WriteLine(temp);
                }
            }
        }
        public static double MediaBattiti(List<double> battiti)
        {
            double somma = 0;
            for(int i = 0; i < battiti.Count; i++)
            {
                somma = battiti[i] + somma;
            }
            double mediaBattiti = somma / battiti.Count;
            return mediaBattiti;
        }
        public static bool SeiaRiposo(List<double> battiti)
        {
            double mediaBattiti = MediaBattiti(battiti);
            if(mediaBattiti < 59||mediaBattiti > 101)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void Variabilità(List<int> battiti, List<int> orario)
        {
            int varOra = 0;
            int varBattiti = 0;
            for(int i = 0; i < orario.Count; i++)
            {
                varOra = orario[i] + 1 - orario[i];
                varBattiti = battiti[i] + 1 - battiti[i];
            }
            Console.WriteLine($"Variabilità ora: {varOra}\n Variabilità battiti:{varBattiti}");
        }

    }
}







