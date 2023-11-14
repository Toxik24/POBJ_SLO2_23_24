#ifndef Voiture_h
#define Voiture_h

#include <java/lang/Object.h>


class voiture Sport ;
class moteur ;
class conducteur;

class Voiture {

 public:
	//-- constructeur + surcharge --// 
	Voiture(); 
	Voiture(int A, float B, char C, string MaChaine); 

	// -- méthode --// 
    virtual bool rouler (int gaz );
	

 public:
    char marque[];
    short couleur;
    int roue;
    String modele;
    java::lang::Object moteur ;

 public:

    /**
     * @element-type voiture Sport 
     */
    voiture Sport  *myvoiture Sport ;

    /**
     * @element-type voiture Sport 
     */
    voiture Sport  *myvoiture Sport ;


    /**
     * @element-type moteur 
     */
    moteur  *mymoteur ;

    /**
     * @element-type conducteur
     */
    conducteur *myconducteur;
};

#endif // Voiture_h
