using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Prime
{
    class Program
    {
        static public bool isPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        static public bool isCirclePrime(int n)
        {
            int len = Convert.ToString(n).Length - 1;
            int _n = n;
            for (int i = 0; i < len; i++)
            {
                _n = (int)((_n % 10) * Math.Pow(10, len) + (_n / 10));
                if (!isPrime(_n))
                    return false;
            }
            return true;
        }

        public static int Main(string[] args)
        {
            List<int> cirPrime = new List<int>();
            cirPrime.Add(1);
            cirPrime.Add(2);
            for (int n = 3; n < 10000000; n += 2)
                if (isPrime(n))
                    if (isCirclePrime(n))
                        cirPrime.Add(n);
            foreach (var x in cirPrime)
                Console.Write(x + " ");
            Console.WriteLine();
            Console.WriteLine(cirPrime.Count);
            Console.ReadLine();
            return cirPrime.Count();
        }
    }
}
