#ifndef TriangleRectangle_h
#define TriangleRectangle_h

#include "FormesGeometriques.h"


class TriangleRectangle : public FormesGeometriques {

 public:

     TriangleRectangle();

     // Constructeur
    TriangleRectangle(double base, double hauteur);


    double CalculerSurface(double base, double hauteur);

    double CalculerPerimetre(double base, double hauteur);
};

#endif // TriangleRectangle_h
