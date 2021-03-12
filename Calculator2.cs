using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1;
            int no2;
            string operasi_bilangan;
            float hasil;

            Console.Write(" Masukan Angka Pertama : ");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Masukan Operator : ");
            operasi_bilangan = Console.ReadLine();

            Console.Write(" Masukan Angka Kedua : ");
            no2 = Convert.ToInt32(Console.ReadLine());

            if (operasi_bilangan == "-")
            {
                hasil = no1 - no2;
            }
            else if (operasi_bilangan == "+")
            {
                hasil = no1 + no2;
            }
            else if (operasi_bilangan == "*")
            {
                hasil = no1 * no2;
            }
            else if (operasi_bilangan == "/")
            {
                hasil = no1 / no2;
            }
            else
            {
                hasil = 0;
            }

            Console.WriteLine(no1.ToString() + " " + operasi_bilangan + " " + no2.ToString() + " = " + hasil.ToString());
            Console.ReadLine();
        }
    }
}