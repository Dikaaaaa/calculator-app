using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            // int a = 10;
            // int b = 5;

            int Inpt;

            Console.WriteLine("Pilih Menu calculator!: ");
            Console.WriteLine();

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.Write("Input Nomor menu [1..4]: ");
            Inpt = int.Parse(Console.ReadLine());

            if (Inpt == 1)
            {
                Console.Write("Inputkan Nilai a: ");
                int a = int.Parse(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int

                Console.Write("Inputkan NIlai b: ");
                int b = Convert.ToInt32(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int
                Console.WriteLine();

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (Inpt == 2)
            {
                Console.Write("Inputkan Nilai a: ");
                int a = int.Parse(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int

                Console.Write("Inputkan NIlai b: ");
                int b = Convert.ToInt32(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int
                Console.WriteLine();

                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            }
            else if (Inpt == 3)
            {
                Console.Write("Inputkan Nilai a: ");
                int a = int.Parse(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int

                Console.Write("Inputkan NIlai b: ");
                int b = Convert.ToInt32(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int
                Console.WriteLine();

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (Inpt == 4)
            {
                Console.Write("Inputkan Nilai a: ");
                int a = int.Parse(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int

                Console.Write("Inputkan NIlai b: ");
                int b = Convert.ToInt32(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int
                Console.WriteLine();

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Maaf, menu yang anda pilih tydack tersedia!!!");
            }

            Console.WriteLine();


            /*

            Console.Write("Inputkan Nilai a: ");
            int a = int.Parse(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int

            Console.Write("Inputkan NIlai b: ");
            int b = Convert.ToInt32(Console.ReadLine()); //Proses casting, Yaitu merubah string menjadi int


            Console.WriteLine("Hasil Penambahan " + a + " + " +  b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            */

            Console.Write("Tekan Sembarang Untuk keluar!");
            Console.ReadKey();
            Console.ReadLine();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
