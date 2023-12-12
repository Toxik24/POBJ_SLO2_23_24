import java.lang.*;
import java.util.Scanner;

public class Ex1 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		// declaration
		
		//objet 
		Scanner monclavier = new Scanner(System.in);
		
		
		int ValA, ValB;
		// Variables pour test A et B
		String UserAnswer;
		short i;
		short ValB1;
		double ValB2;

		 System.out.println("Exercice 1 : Samuel pitton");
		 System.out.println("Solution en C a trandformer en JAVA");


		do
		{
			 System.out.println("Test A ou B, Q pour Quitter \n");
			 UserAnswer = monclavier.nextLine();

			switch (UserAnswer)
			{
				case "A":
				case "a":
					 System.out.println("TestA: entrez un nombre entre 1 et 9 \n");
					ValA =  System.in.read();

					if (ValA > 9)
					{
						ValA = 9;
						 System.out.println("TestA: ValA limitee a 9 \n");
					}
					if (ValA == 0)
					{
						ValA = 1;
						 System.out.println("TestA: ValA forcee a 1 \n");
					}
					if (ValA > 0)
					{
						 System.out.println(ValA);
						for (i = 0; i < ValA; i++)
						{
							System.out.print('*');	
						}
						 System.out.println(); // saut de ligne
					}
					else
					{
						 System.out.println("TestA: ValA est negatif !");
					}
					break;

				case "B":
				case "b":
					 System.out.println("TestB: entrez une valeur entre 0 et 9 \n");
					ValB = System.in.read();

					if (ValB >= 0 && ValB <= 9)
					{
						for (i = 0; i < ValB; i++)
						{
							ValB1 = (short)(100 + (10 * i));
							ValB2 = ValB1 / 10000.0;
							
							// peux pas afficher different type cheker sur internet
							System.out.println("TestB: i= %d ValB1 = %d ValB2 = %lf ", i, ValB1, ValB2);
						}
					}
					else
					{
						 System.out.println("TestB: ValB n'est pas entre 0 et 9 !");
					}
					break;

			} // end switch

		} while (!(UserAnswer == "Q" || UserAnswer == "q"));

		//System.Environment.Exit(0);	//voir comment quitter un programme en JAVA  
	}
}
