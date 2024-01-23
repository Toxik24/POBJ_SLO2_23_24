#ifndef FormesGeometriques_h
#define FormesGeometriques_h


class FormesGeometriques {

 public:


    FormesGeometriques();

    FormesGeometriques(double x1, double x2);

    virtual double CalculerSurface(double x1, double x2);

    virtual double CalculerPerimetre(double x1, double x2);

    double GetSurface();

    double GetPerimetre();


 protected:
    double Surface;
    double Perimetre;

};

#endif // FormesGeometriques_h
