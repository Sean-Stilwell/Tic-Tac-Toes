# Sean Stilwell et Sekou Dabo
# 300053246 et 8534543
# ITI1520 - Automne 2018

def effaceTableau (tab):
    '''
    (list) -> None
    Cette fonction prepare le tableau de jeu (la matrice) 
    en mettant '-' dans tous les elements.
    Elle ne crée pas une nouvelle matrice
    Preconditions: tab est une reference a une matrice n x n qui contient '-', 'X' ou 'O'
    '''

    # On utilise deux boucles pour changer tous les valeurs a '-'
    for i in tab:
       n = 0
       while n <= 2:
          i[n] = '-'
          n += 1
    
    # retourne rien
    return tab # pour tester seulement

      
def verifieGagner(tab):  
    '''(list) ->  bool
    * Preconditions: tab est une reference a une matrice n x n qui contient '-', 'X' ou 'O'
    * Verifie s'il y a un gagnant.
    * Cherche pour 3 X's et O's dans une ligne, colonne, et diagonal.
    * Si on a trouvé, affiche le gagnant (le message "Joueur X a gagné!" 
    * ou "Joueur O a gagné!") et retourne True.
    * S'il y a un match nul (verifie ca avec la fonction testMatchNul),
    * affiche "Match nul" et retourne True.
    * Si le jeu n'est pas fini, retourne False.
    * La fonction appelle les fonctions testLignes, testCols, testDiags
    * pour verifier s'il y a un gagnant.
    * Ces fonctions retournent le gagnant 'X' ou 'O', ou '-' s'il n'y a pas de gagnant
    '''
    # on utilise 4 variables pour voir si il y a un gagnant
    Checker1 = testLignes(tab)
    Checker2 = testCols(tab)
    Checker3 = testDiags(tab)
    Checker4 = testMatchNul(tab)

    # on verifie chaque variable pour trouver un gagnant
    if (Checker1 == 'X') or (Checker2 == 'X') or (Checker3 == 'X'):
        print("Joueur X a gagné!")
        return True
    elif (Checker1 == 'O') or (Checker2 == 'O') or (Checker3 == 'O'):
        print("Joueur O a gagné!")
        return True
    elif Checker4 == True:
        print("Match nul")
        return True
   
    return False  # a changer

 
def testLignes(tab):
   ''' (list) ->  str
   * verifie s’il y a une ligne gagnante.
   * cherche trois 'X' ou trois 'O' dans une ligne.  
   * Si on trouve, le caractere 'X' ou 'O' et retourné, sinon '-' est retourné.
   * Preconditions: tab est une reference a une matrice n x n qui contient '-', 'X' ou 'O'
   '''

   # Le code pour verifier si une rangee contient trois X ou trois O
   # Si oui, on retourne le gagnant.
   for x in tab:
      if (x[0] == 'X' and x[1] == 'X' and x[2] == 'X'):
         return 'X'
      elif (x[0] == 'O' and x[1] == 'O' and x[2] == 'O'):
         return 'X'
  
   return '-' # a changer pour retourner le gagnant, ou '-' s'il n'y a pas de gagnant 

  
  
def testCols(tab):
   ''' (list) ->  str
   * verifie s’il y a une colonne gagnante.
   * cherche trois 'X' ou trois 'O' dans une colonne.  
   * Si on trouve, le caractere 'X' ou 'O' et retourné, sinon '-' est retourné.
   * Preconditions: tab est une reference a une matrice n x n qui contient '-', 'X' ou 'O'
   '''
    
   m = 0
   n = 0

   #Le code verifie si colonne a trois X ou trois O
   # Si oui, on retourne le gagnant
   while n <= 2:
      if (tab[m][n] == 'X') and (tab[m+1][n] == 'X') and (tab[m+2][n] == 'X'):
         return 'X'
      elif (tab[m][n] == 'O') and (tab[m+1][n] == 'O') and (tab[m+2][n] == 'O'):
         return 'O'
      n = n + 1
  
   return '-'   #a changer pour retourner le gagnant, ou '-' s'il n'y a pas de gagnant

   
def testDiags(tab):
   ''' (list) ->  str
   * cherche trois 'X' ou trois 'O' dans une diagonale.  
   * Si on trouve, le caractere 'X' ou 'O' et retourné
   * sinon '-' est retourné.
   * Preconditions: tab est une reference a une matrice n x n qui contient '-', 'X' ou 'O'
   '''
    # Ce code utilise simplement les conditions pour determiner si il y a un gagnant.
    # Il y a seulement deux lignes diagonales, alors il ne faut pas un boucle.
   if (tab[0][0] == 'X' and tab[1][1] == 'X' and tab[2][2] == 'X') or (tab[0][2] == 'X' and tab[1][1] == 'X' and tab[2][0] == 'X'):
       return 'X'
   elif (tab[0][0] == 'O' and tab[1][1] == 'O' and tab[2][2] == 'O') or (tab[0][2] == 'O' and tab[1][1] == 'O' and tab[2][0] == 'O'):
       return 'O'
   return '-'   # a changer pour retourner le gagnant, ou '-' s'il n'y a pas de gagnant

  
  
def testMatchNul(tab):
   ''' (list) ->  bool
   * verifie s’il y a un match nul
   * verifie si tous les elements de la matrice contiennent X ou O, pas '-'.  
   * Si on ne trouve pas de '-' dans la matrice, retourne True. 
   * S'il y a de '-', retourne false.
   * Preconditions: tab est une reference a une matrice n x n qui contient '-', 'X' ou 'O'
   '''
    
   # J'ai change le code original, on cherche si il y a un '-' dans le matrice, si oui
   # on retourne immediatement False
   for m in tab:
       for n in m:
           if n == '-':
               return False
  
   return True  # a changer

