// librairie
#include "Voiture.h"


// programme principe
void main()
{
	//déclaration 
	bool onOff; 
	
	Voiture voitureAntonio; //instanciation -> création objet 
	
	VoitureSport voitureDiogo; // instanciation -> création d'objet 
	
	Voiture *voitureCyrile = new Voiture();  	
	
	
	//-- méthode rouler --// 
	onOff = voitureAntonio.rouler(50); 
	
	voitureDiogo.rouler(20, 100); 
	
}







