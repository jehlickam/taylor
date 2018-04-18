using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taylor
{
    class Program
    {
        public double pres = 0.001;
        public int counter = 10;
        public double x = 0;
        public double vysledek = 0;

        static void Main(string[] args)
        {
            int f = 0;
            
            fce p = new fce();
            Program prg = new Program();

            Console.Write("Vyberte funkci [1 -> SIN, 2 -> COS, 3 -> e^x, 4 -> tabulka]: ");
            f = Convert.ToInt32(Console.ReadLine());

            if (f == 4)
            {
                
            }
            else
            {
                Console.Write("Zadejte hodnotu úhlu [pro zobrazeni tabulky zadejte 666]: ");

                prg.x = Convert.ToDouble(Console.ReadLine());
                

                Console.Write("Zadejte přesost [např. 0,001]: ");
                prg.pres = Convert.ToDouble(Console.ReadLine());
            }

            p.pres = prg.pres;
            prg.x = p.DegToRad(prg.x);
            double result;
            double last = 0;
            double pred = 0;
            int i = 0;

            
            switch (f)
            {
                case 1:
                    result = prg.x;
                    last = result;
                    i = 2;
                    while (i != 0)
                    {
                        result = p.sine(prg.x, i, result);

                        if (result == 0)
                        {
                          break;

                        }

                        last = result;

                        i++;
                    }
                    pred = Math.Sin(prg.x);
                    break;

                case 2:
                    result = 1;
                    last = result;

                    i = 2;
                    while (i != 0)
                    {
                        result = p.cos(prg.x, i, result);

                        if (result == 0)
                        {
                            break;
                        }

                        last = result;

                        i++;
                    }
                    pred = Math.Cos(prg.x);
                    break;

                case 3:
                    result = 1;
                    i = 1;
                    last = result;

                    while (i != 0)
                    {
                        result = p.euler(prg.x, i, result);

                        if (result == 0)
                        {
                            break;
                        }

                        last = result;

                        i++;
                    }
                    pred = Math.Pow(Math.E,prg.x);
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Sinus");
                    Console.WriteLine("°\t" + "0.001" + "\t\t\t" + "0.00001" + "\t\t\t" + "SIN");
                    Console.WriteLine("--------------------------------------------------------------");
                    for (int c = 10; c < 70; c = c+ 10)
                    {
                       
                        prg.sinus(c);
                    }

                    Console.WriteLine();

                    Console.WriteLine("Cosinus");
                    Console.WriteLine("°\t" + "0.001" + "\t\t\t" + "0.00001" + "\t\t\t" + "COS");
                    Console.WriteLine("--------------------------------------------------------------");
                    for (int c = 10; c < 70; c = c + 10)
                    {

                        prg.cosinus(c);
                    }

                    Console.WriteLine();

                    Console.WriteLine("Eulerovo cislo");
                    Console.WriteLine("°\t" + "0.001" + "\t\t\t" + "0.00001" + "\t\t\t" + "COS");
                    Console.WriteLine("--------------------------------------------------------------");
                    for (int c = 1; c < 6; c = c + 1)
                    {

                        prg.cosinus(c);
                    }

                    break;

            }
            if (f != 4)
            {
                Console.Clear();
                Console.WriteLine("Predpokladany vysledek: {0}", pred);
                Console.WriteLine("Aproximovany vysledek: {0}", last);
                Console.WriteLine("Rozdíl: {0}", pred - last);
                //Console.WriteLine(Math.Sin(Convert.ToDouble(x)));
            }
            Console.ReadLine();
            Console.Clear();
            Main(null);
        }

        private void sinus(int c)
        {
            fce p = new fce();
            

            p.pres = pres;
            //double result;
            vysledek = 0;
            double last = 0;
            double pred = 0;
            int i = 0;


            double rad = c * (Math.PI / 180);

            vysledek = rad;
            last = vysledek;
            i = 2;
            while (i != 0)
            {
                vysledek = p.sine(rad, i, vysledek);

                if (vysledek == 0)
                {
                    break;
                }

                last = vysledek;

                i++;
            }

            p.pres = 0.00001;
            //double result;
            vysledek = rad;
            double last1 = vysledek;

            
            i = 2;

            while (i != 0)
            {
                vysledek = p.sine(rad, i, vysledek);

                if (vysledek == 0)
                {
                    break;
                }

                last1 = vysledek;

                i++;
            }
            pred = Math.Sin(rad);
            Console.WriteLine(c + "°\t" + last + "\t" + last1 + "\t" + pred);
            //Console.Write(last);
        }

        private void cosinus(int c)
        {
            fce p = new fce();


            p.pres = pres;
            //double result;
            vysledek = 0;
            double last = 0;
            double pred = 0;
            int i = 0;


            double rad = c * (Math.PI / 180);

            vysledek = 1;
            last = vysledek;
            i = 2;
            while (i != 0)
            {
                vysledek = p.cos(rad, i, vysledek);

                if (vysledek == 0)
                {
                    break;
                }

                last = vysledek;

                i++;
            }

            p.pres = 0.00001;
            //double result;
            vysledek = 1;
            double last1 = vysledek;


            i = 2;

            while (i != 0)
            {
                vysledek = p.cos(rad, i, vysledek);

                if (vysledek == 0)
                {
                    break;
                }

                last1 = vysledek;

                i++;
            }
            pred = Math.Cos(rad);
            Console.WriteLine(c + "°\t" + last + "\t" + last1 + "\t" + pred);
        }

        private void euler(int c)
        {
            fce p = new fce();


            p.pres = pres;
            //double result;
            vysledek = 0;
            double last = 0;
            double pred = 0;
            int i = 0;


            double rad = c * (Math.PI / 180);

            vysledek = 1;
            last = vysledek;
            i = 1;
            while (i != 0)
            {
                vysledek = p.euler(c, i, vysledek);

                if (vysledek == 0)
                {
                    break;
                }

                last = vysledek;

                i++;
            }

            p.pres = 0.00001;
            //double result;
            vysledek = 1;
            double last1 = vysledek;


            i = 1;

            while (i != 0)
            {
                vysledek = p.euler(c, i, vysledek);

                if (vysledek == 0)
                {
                    break;
                }

                last1 = vysledek;

                i++;
            }
            pred = Math.Pow(c, Math.E);
            Console.WriteLine(c + "°\t" + last + "\t" + last1 + "\t" + pred);
        }

    }
}
