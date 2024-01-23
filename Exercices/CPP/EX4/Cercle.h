#ifndef Cercle_h
#define Cercle_h

#include "FormesGeometriques.h"


class Cercle : public FormesGeometriques {

 public:
    Cercle();

    Cercle(double diametre, double x2);

    double CalculerSurface(double diametre);

    double CalculerPerimetre(double diametre);
};

#endif // Cercle_h
