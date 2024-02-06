using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4_CS
{
    class Programe
    {
        static void Main(string[] args)
        {

            
            Utilisateur UserA = new Utilisateur();
            Utilisateur UserB = new Utilisateur();
            Utilisateur UserC = new Utilisateur();

            UserA.ChoisirForme(0);
            UserA.SaisirLesParametres();
            UserA.ExecuterLesCalculs();
            UserA.AfficherResultats();


            UserB.ChoisirForme(1);
            UserB.SaisirLesParametres();
            UserB.ExecuterLesCalculs();
            UserB.AfficherResultats();

            UserC.ChoisirForme(2);
            UserC.SaisirLesParametres();
            UserC.ExecuterLesCalculs();
            UserC.AfficherResultats();

        }
    }
}


