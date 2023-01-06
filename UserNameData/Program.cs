using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ome eesnime
            //programm kuvab kasutaja eesnime pikkust
            //programm kuvab kasutja eesnime esimest tähte
            //programm kuvab kasutaja eesmine tagurpidi
            //main meetodis ei tohi olla rohkem, kui kolm rida koodi

            Console.WriteLine(" sisesta ome eesnime:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);

        }

        public static void GetUserNameData(string userInput)
        {
			Console.WriteLine($"Sinu nimi on {userInput.Length} sümboli pikk");
			Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for (int I = userInput.Length - 1; I >= 0; I--)
            {
				Console.WriteLine(userInput[I]);
            }
        }
    }
}
