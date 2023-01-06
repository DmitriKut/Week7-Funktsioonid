using System;

namespace UseNameDataTask
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada eesnime;
			//programm küsib kasutajal sisestada nubbrit 1-3;
			//kui kasutja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
			//kui kasutja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
			//kui kasutja valib 3, siis kuvatakse kasutaja eesnime pikkust

			Console.WriteLine("sisesta ome eesnime:");
			string userName = Console.ReadLine();
			

			Console.WriteLine("vali number (sisesta 1, 2 või 3)");
			char userNumber = Convert.ToChar(Console.ReadLine());

			switch (userNumber)
				{
				case '1':

					GetUserNameRevers(userName);
					break;
				case '2':
							Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
							break;

					
				case '3':
							Console.WriteLine($"Sinu nimi on {userName.Length} sümboli pikk");
							break;
				
				default:
					Console.WriteLine("Kena päeva!");
					break;
				}

		}

		public static void GetUserNameRevers(string userInput)
		{
			for (int I = userInput.Length - 1; I >= 0; I--)
			{
				Console.WriteLine(userInput[I]);
			}
		}
	}
	
}
