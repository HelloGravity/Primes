Primes class
=========

A simple C# class that provides prime numbers, in a List, and in a HashSet.
The reason I added the HashSet, is because it has O(1) time complexity for 
```C#
.Contains
```
, and it uses less space than a simple boolean sieve array. 

The algorithm was taken from - 
http://stackoverflow.com/questions/2068372/fastest-way-to-list-all-primes-below-n-in-python/3035188#3035188
and is ported to C#.


Sample usage : 
```C#
HashSet<int> set = Primes.GetPrimesHashSet(100000);
List<long> lst = Primes.GetPrimesList(1000000L);
Console.WriteLine("There are " + lst.Count + " primes < 100000");
Console.WriteLine("The sum of all primes < 100000 is " + lst.Sum());
Console.WriteLine("Is 99989 a prime ? " + set.Contains(99989));
Console.WriteLine("Is 99990 a prime ? " + set.Contains(99990));
Console.WriteLine("Is 99991 a prime ? " + set.Contains(99991));
Console.ReadKey();

/*
 * Output :
   ------

	There are 78498 primes < 100000
	The sum of all primes < 100000 is 37550402023
	Is 99989 a prime ? True
	Is 99990 a prime ? False
	Is 99991 a prime ? True
 */
 
```