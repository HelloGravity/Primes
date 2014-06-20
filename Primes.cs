using System;
using System.Collections.Generic;


namespace Primes
{
    /// <summary>
    /// Get a list of primes, based on http://stackoverflow.com/questions/2068372/fastest-way-to-list-all-primes-below-n-in-python/3035188#3035188
    /// </summary>
    class Primes
    {
        /// <summary>
        /// If TrimOutput is set to true, the class will call TrimExcess before returning the HashSet or the List.
        /// </summary>
        public static bool TrimOutput = true;

        private static bool[] Sieve(int n)
        {
            bool[] sieve = new bool[n / 2];
            for (int i = 0; i < n / 2; i++)
                sieve[i] = true;
            int sqrt = (int)Math.Sqrt(n);
            for (int i = 3; i <= sqrt; i += 2)
                if (sieve[i / 2])
                    for (int j = i * i / 2; j < n / 2; j += i)
                        sieve[j] = false;
            return sieve;
        }

        private static bool[] Sieve(long n)
        {
            bool[] sieve = new bool[n / 2];
            for (long i = 0; i < n / 2; i++)
                sieve[i] = true;
            long sqrt = (long)Math.Sqrt(n);
            for (long i = 3; i <= sqrt; i += 2)
                if (sieve[i / 2])
                    for (long j = i * i / 2; j < n / 2; j += i)
                        sieve[j] = false;
            return sieve;
        }

        public static List<int> GetPrimesList(int n)
        {
            bool[] sieve = Sieve(n);
            List<int> lst = new List<int>();
            lst.Add(2);
            for (int i = 1; i < n / 2; i++)
                if (sieve[i])
                    lst.Add(2 * i + 1);
            if (TrimOutput)
                lst.TrimExcess();
            return lst;
        }

        public static List<long> GetPrimesList(long n)
        {
            bool[] sieve = Sieve(n);
            List<long> lst = new List<long>();
            lst.Add(2);
            for (long i = 1; i < n / 2; i++)
                if (sieve[i])
                    lst.Add(2 * i + 1);
            if (TrimOutput)
                lst.TrimExcess();
            return lst;
        }

        public static HashSet<int> GetPrimesHashSet(int n)
        {
            bool[] sieve = Sieve(n);
            
            HashSet<int> set = new HashSet<int>();
            set.Add(2);
            for (int i = 1; i < n / 2; i++)
                if (sieve[i])
                    set.Add(2 * i + 1);
            if (TrimOutput)
                set.TrimExcess();
            return set;
        }

        public static HashSet<long> GetPrimesHashSet(long n)
        {
            bool[] sieve = Sieve(n);

            HashSet<long> set = new HashSet<long>();
            set.Add(2);
            for (long i = 1; i < n / 2; i++)
                if (sieve[i])
                    set.Add(2 * i + 1);
            if (TrimOutput)
                set.TrimExcess();
            return set;
        }
    }
}
