using System;


namespace Ex1_Csharp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			


			string UserAnswer;
			int ValA, ValB;
			// Variables pour test A et B
			short i;
			short ValB1;
			double ValB2;

			 Console.WriteLine("Exercice 1 : Huber Christian \n");
			 Console.WriteLine("Solution en C a trandformer en C++ \n");


			do
			{
				 Console.WriteLine("Test A ou B, Q pour Quitter \n");
				UserAnswer = Console.ReadLine();

				switch (UserAnswer)
				{
					case "A":
					case "a":
						 Console.WriteLine("TestA: entrez un nombre entre 1 et 9 \n");
						ValA = Console.Read();

						if (ValA > 9)
						{
							ValA = 9;
							 Console.WriteLine("TestA: ValA limitee a 9 \n");
						}
						if (ValA == 0)
						{
							ValA = 1;
							 Console.WriteLine("TestA: ValA forcee a 1 \n");
						}
						if (ValA > 0)
						{
							 Console.WriteLine(ValA);
							for (i = 0; i < ValA; i++)
							{
								 Console.Write("*");	
							}
							 Console.WriteLine(); // saut de ligne
						}
						else
						{
							 Console.WriteLine("TestA: ValA est negatif ! \n");
						}
						break;

					case "B":
					case "b":
						 Console.WriteLine("TestB: entrez une valeur entre 0 et 9 \n");
						ValB = Console.Read();;

						if (ValB >= 0 && ValB <= 9)
						{
							for (i = 0; i < ValB; i++)
							{
								ValB1 = (short)(100 + (10 * i));
								ValB2 = ValB1 / 10000.0;
								Console.WriteLine("TestB: i= %d ValB1 = %d ValB2 = %lf \n", i, ValB1, ValB2);
							}
						}
						else
						{
							 Console.WriteLine("TestB: ValB n'est pas entre 0 et 9 ! \n");
						}
						break;

				} // end switch

			} while (!(UserAnswer == "Q" || UserAnswer == "q"));

			System.Environment.Exit(0);
		}







	}
}
