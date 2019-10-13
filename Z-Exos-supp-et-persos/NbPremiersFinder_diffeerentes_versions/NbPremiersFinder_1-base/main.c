//Programme: permettant de trouver les nombres premiers en testant tous les nombres jusqu'à un maximum. si après toutes les divisions, nbinrun possede exactement 2 diviseurs, alors il est premier.
//Version: Base, test avec tous les nbs inférieurs au nbinrun.
//Samuel Roland
//Date: 24.08.2019

#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int nbinrun = 0;  //nb en cours de test
    int nbmax = 0;  //nombre max quon va tester, choisi par l'utilisateur.
    float result = 0;   //résultat de l'opération de division, pour savoir si il y a un reste.
    int nbdiviseurs;    //nombre de diviseurs pour le nombre en cours.
    int nbnbspremiers=0;    //nombre de nombres premiers trouvés.

    //intro + nbmax demander
    printf("\nProgramme pour les nbs aleatoires. donnez un max: ");
    scanf("%d", &nbmax);

    //time de début:
    time_t tstart=time(NULL);

    for (int i = 1; i <= nbmax; ++i) {
        nbinrun = i;
        nbdiviseurs = 0;
        //scan de tous les nbs en avant.
        for (int j = nbinrun; j > 0; j--) { //prend en compte lui-meme et 1.

            //division test
            result = nbinrun % j;

            if (result == 0) {
                //il n'y a pas de reste, c'est donc un diviseur, un rajoute donc un diviseur au compteur:
                nbdiviseurs++;
            }

            if (nbdiviseurs > 2) {
                //si il a plus de 2 diviseurs, il n'est pas premier, donc break.
                break;
            }
        }

        if (nbdiviseurs == 2) { //si vaut exactement 2 alors est premier.
            //imprimer le résultat.
            printf("\nNb premier: %d", nbinrun);
            nbnbspremiers++;
        }
    }

    //time de fin:
    time_t tend=time(NULL);
    int difftemps = tend-tstart;
    printf("\n\nTermine, %d nombres premiers trouves entre 1 et %d !\n", nbnbspremiers, nbmax);
    printf("\nTemps pour calculer ces %d nombres premiers: %d secondes...", nbnbspremiers, difftemps);
    system("pause");

    return 0;
}