using System;

// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?

namespace euler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 600851475143;
            var sqrtNum = Math.Floor(Math.Sqrt(num));
            var answer = 2;
            Func<long, bool> isPrime = input => {
                for (var i = 2; i * i <= input; i++){
                    if (input % i == 0) {
                        return false;
                    }
                }
                return true;
            };

            for (var factor = 2; factor < sqrtNum; factor++){
                if (num % factor == 0 && isPrime(factor) && factor > answer){
                    answer = factor;
                }
            }
            Console.WriteLine($"Answer: {answer}");
        }
    }
}
