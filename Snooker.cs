using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snooker
{
    class Snooker
    {

        static void Main(string[] args)
        {
            #region 2. feladat

            StreamReader sr = new StreamReader("snooker.txt", Encoding.Default);
            List<snookers> Snooker = new List<snookers>();
            string fejlec = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] tomb = sr.ReadLine().Split(';');
                Snooker.Add(new snookers(int.Parse(tomb[0]) ,tomb[1], tomb[2], int.Parse(tomb[3])));

            }
            sr.Close();

            #endregion

            #region 3. feladat

            Console.WriteLine($"3. feladat: A világ ranglistán {Snooker.Count} versenyző szerepel");

            #endregion

            #region 4. feladat

            double OsszNyer = 0;
            for (int i = 0; i < Snooker.Count; i++)
            {

                OsszNyer += Snooker[i].Nyeremeny; 

            }
            Console.WriteLine($"4. feladat: A versenyzők átlagosan {Math.Round((OsszNyer/Snooker.Count),2)} fontot kerestek");

            #endregion

            #region 5. feladat

            Console.WriteLine($"5. feldat: A legjobban kereső kínai versenyző:");
            int legjobbkinai = Snooker[0].Nyeremeny;
            for (int i = 0; i < Snooker.Count; i++)
            {

                if (Snooker[i].Orszag == "Kína" && Snooker[i].Nyeremeny > legjobbkinai)
                {

                    legjobbkinai = Snooker[i].Nyeremeny;

                }

            }
            for (int i = 0; i < Snooker.Count; i++)
            {

                if (Snooker[i].Nyeremeny == legjobbkinai)
                {

                    decimal formatum = Snooker[i].Nyeremeny * 380;
                    string s = formatum.ToString("C0");
                    Console.WriteLine($"\tHelyezés: {Snooker[i].Helyezes}");
                    Console.WriteLine($"\tNév: {Snooker[i].Nev}");
                    Console.WriteLine($"\tOrszág: {Snooker[i].Orszag}");
                    Console.WriteLine($"\tNyeremény összege: {s}");

                }


            }

            #endregion

            #region 6. feladat

            bool Norveg = false;
            for (int i = 0; i < Snooker.Count; i++)
            {

                if (Snooker[i].Orszag == "Norvégia")
                {

                    Norveg = true;

                }

            }
            if (Norveg == true)
            {

                Console.WriteLine($"6. feldat: A versenyzők között van norvég versenyző");

            }
            else
            {

                Console.WriteLine($"6. feldat: A versenyzők között nincsen norvég versenyző");

            }

            #endregion

            #region 7. feladat

            List<string> OrszagLista = new List<string>();
            for (int i = 0; i < Snooker.Count; i++)
            {

                bool Szerpel = false;
                for (int j = 0; j < OrszagLista.Count; j++)
                {

                    if (Snooker[i].Orszag == OrszagLista[j])
                    {

                        Szerpel = true;

                    }

                }
                if (Szerpel == false)
                {

                    OrszagLista.Add(Snooker[i].Orszag);

                }

            }

            int[] OrszagListaSeged = new int[OrszagLista.Count];
            for (int i = 0; i < Snooker.Count; i++)
            {

                for (int j = 0; j < OrszagLista.Count; j++)
                {

                    if (Snooker[i].Orszag == OrszagLista[j])
                    {

                        OrszagListaSeged[j]++;

                    }

                }

            }
            Console.WriteLine($"7. feladat: Statisztika");
            for (int i = 0; i < OrszagListaSeged.Length; i++)
            {

                if (OrszagListaSeged[i] > 4)
                {

                    Console.WriteLine($"\t{OrszagLista[i]} - {OrszagListaSeged[i]} fő");

                }

            }

            #endregion

            Console.WriteLine("\nProgram Vége!");
            Console.ReadLine();
        }
    }
}
