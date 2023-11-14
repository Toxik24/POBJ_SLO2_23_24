#ifndef vehicule_h
#define vehicule_h

class Voiture;

class vehicule {

 public:
    int feux_vert;

 private:
    int feux_rouge;

 public:

    /**
     * @element-type Voiture
     */
    Voiture *myVoiture;
};

#endif // vehicule_h
