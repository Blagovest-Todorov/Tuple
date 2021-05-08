using System;

namespace TupleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string personFullName = $"{firstTokens[0]} {firstTokens[1]}";
            string personAddress = firstTokens[2];

            Tuple<string, string> personInfoTupleOne = new Tuple<string, string>(personFullName, personAddress);
            //Console.WriteLine(personInfoTupleOne);

            string[] secTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string personName = $"{secTokens[0]}";
            int beerData = int.Parse($"{secTokens[1]}");

            Tuple<string, int> personInfoTupleSec = new Tuple<string, int>(personName, beerData);

            string[] thirdTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numOne = int.Parse($"{thirdTokens[0]}");
            double numTwo = double.Parse($"{thirdTokens[1]}");

            Tuple<int, double> numsInfoTupleThird = new Tuple<int, double>(numOne, numTwo);

            Console.WriteLine(personInfoTupleOne);
            Console.WriteLine(personInfoTupleSec);
            Console.WriteLine(numsInfoTupleThird);
        }
    }
}
