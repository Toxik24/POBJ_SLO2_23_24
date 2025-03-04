﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4_CS
{
    internal class Rectangle : FormesGeometriques
    {
        Rectangle(){}

        
        
        public Rectangle(double largeur, double hauteur)
        {
            Console.WriteLine( " constructeur de Rectangle  \n");
            largeur = 0;
            hauteur = 0;
        }


        public double CalculerSurface(double largeur, double hauteur)
        // don't delete the following line as it's needed to preserve source code of this autogenerated element
        // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D6A begin
        {
            Surface = largeur * hauteur;
            return (Surface);
        }
        // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D6A end
        // don't delete the previous line as it's needed to preserve source code of this autogenerated element

        public double CalculerPerimetre(double largeur, double hauteur)
        // don't delete the following line as it's needed to preserve source code of this autogenerated element
        // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D6C begin
        {
            Perimetre = 2 * (hauteur + largeur);
            return (Perimetre);
        }




    }
}
