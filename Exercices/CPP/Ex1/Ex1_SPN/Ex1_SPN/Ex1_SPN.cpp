#include <iostream>
#include <iomanip> // manipulation du flux de donnée 
int main()
{
    char UserAnswer;
    int ValA, ValB;
    // Variables pour test A et B
    short i;
    short ValB1;
    double ValB2;

    std::cout << "Exercice 1 : Huber Christian" << std::endl;
    std::cout << "Solution en C++ à transformer" << std::endl;

    do
    {
        std::cout << "Test A ou B, Q pour Quitter" << std::endl;
        std::cin >> UserAnswer;

        switch (UserAnswer)
        {
        case 'A':
        case 'a':
            std::cout << "TestA: entrez un nombre entre 1 et 9" << std::endl;
            std::cin >> ValA;

            if (ValA > 9)
            {
                ValA = 9;
                std::cout << "TestA: ValA limitée à 9" << std::endl;
            }
            if (ValA == 0)
            {
                ValA = 1;
                std::cout << "TestA: ValA forcée à 1" << std::endl;
            }
            if (ValA > 0)
            {
                std::cout << ValA << " ";
                for (i = 0; i < ValA; i++)
                {
                    std::cout << "*";
                }
                std::cout << std::endl; // saut de ligne
            }
            else
            {
                std::cout << "TestA: ValA est négatif !" << std::endl;
            }
            break;

        case 'B':
        case 'b':
            std::cout << "TestB: entrez une valeur entre 0 et 9" << std::endl;
            std::cin >> ValB;

            if (ValB >= 0 && ValB <= 9)
            {
                for (i = 0; i < ValB; i++)
                {
                    ValB1 = 100 + (10 * i);
                    ValB2 = ValB1 / 10000.0;
                   // std::cout << "TestB: i= " << i << " ValB1 = " << ValB1 << " ValB2 = " << ValB2 << std::endl;
                    std::cout << "TestB: i= " << i << " ValB1 = " << ValB1 << " ValB2 = " << std::fixed << std::setprecision(6) << ValB2 << std::endl;//a tester

                }
            }
            else
            {
                std::cout << "TestB: ValB n'est pas entre 0 et 9 !" << std::endl;
            }
            break;
        } // end switch

    } while (!(UserAnswer == 'Q' || UserAnswer == 'q'));

    return 0;
}
