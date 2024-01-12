// Canevas Ex2 SL228_POBJ language C++ 
// Visual Studio 2015
// 11.11.2016 C. Huber

#include <iostream>
#include <iomanip>
using namespace std;


// Fonction Extract
unsigned short int Extract(long ValA)

{
	int heures, minutes, resteSecondes,Valorigine;

	Valorigine = ValA;

	heures = ValA / 3600; // 1 heure = 3600 secondes
	ValA %= 3600; // Calcul du reste de secondes après avoir calculé les heures

	minutes = ValA / 60; // 1 minute = 60 secondes
	resteSecondes = ValA % 60; // Calcul du reste de secondes après avoir calculé les minutes

	

	std::cout << "ValA = " << Valorigine << " NbrHeures = " << heures <<  " NbrMinutes = " << minutes <<  " NbrSecondes = " << resteSecondes << std::endl;

	return (resteSecondes);
}




// Fonction AfficheB


// Fonction CalculSurfaceRectangle


int main (void)
{
	char UserAnswer;
	int ValA, ValB;
	// Variables pour test A, B et C
	

	// a adapter
	cout << "Exercice 2 : Samuel Pitton" << endl;


	do {
		cout << "Test A, B ou C, Q pour Quitter" << endl;
		cin >> UserAnswer;
		
		switch (UserAnswer) {
			case 'A':
			case 'a':
				cout << "TestA: entrez un nombre de secondes" << endl;
				cin >> ValA;
				Extract(ValA);
				
			break;

			case 'B':
			case 'b':
				cout << "TestB: entrez un nombre " <<  endl;
				cin >> ValB; 
				
			break;

			case 'C':
			case 'c':
				cout << "TestC: calculs surface " <<  endl;

				// a)	Avec 2 paramètres int 25 et 45
				
				// b)	Avec 2 paramètres double 23.25 et 44.33'
				
				// c)	Avec 4 paramètres int 20,20, 60,40
				

			break;

		} // end switch
	
	} while (!(UserAnswer == 'Q' || UserAnswer == 'q'));

	return (0);
}