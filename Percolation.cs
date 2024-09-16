using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percolation
{
    public class Percolation
    {
        private readonly bool[,] _open;
        private readonly bool[,] _full;
        private readonly int _size;
        private bool _percolate;

        public Percolation(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), size, "Taille de la grille négative ou nulle.");
            }
            _open = new bool[size, size];
            _full = new bool[size, size];
            _size = size;
            bool[,] Grille = new bool[size,size];
            byte ligne, colonne;
      
            for (ligne = 0; ligne < size; ligne++)
            {
                for (colonne = 0; colonne < size; colonne++)
                { 
                    Grille[ligne,colonne] = false;
                    _open[ligne,colonne] = Grille[ligne,colonne];
                    _full[ligne,colonne] = _open[ligne,colonne];
                    Console.Write(Grille[ligne,colonne]);
                    if (colonne == size -1)
                    { 
                       Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }

        public bool IsOpen(int i, int j)
        { 
            if (_open[i,j]==true)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        public bool IsFull(int i, int j)
        {
            for (i=0; i < _size -1 ; i++)
            {
                for (j=0; j < _size ; j++)
                {
                    if (_open[0,j] == true)
                    {
                     //   _full[0,j] = true;
                        return true;
                    }
                    else if (_full[i-1,j] == true && i > 1 || _full[i,j-1] == true && j > 1 || _full[i,j+1] == true && j < _size - 1)
                    {
                     //   _full[i,j] == true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool Percolate()
        {
            for (int i = 0 ; i<_size -1; i++)
            {
                for (int j = 0 ; j < _size -1; j++)
                {
                    if (_full[_size - 1,j] == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

   /*     private List<KeyValuePair<int, int>> CloseNeighbors(int i, int j)
        {
             for (int i = 0 ; i < _size -1 ; i++)
             {
                 for (int j = 0 ; j < _size -1 ; j++)
                 {
                     if (i == 0 && j == 0)
                     {
                         // i+1 et j+1 = voisins
                         return;
                     }
                     if (i == _size - 1 && j == 0)
                     {
                         // i-1 et j+1 voisins
                         return;
                     }
                     if (i == 0 && j == _size -1)
                     {
                         // i+1 et j-1 voisins
                         return;
                     }
                     if (i == _size -1 && j == _size -1)
                     {
                         // i-1 et j-1 voisins
                         return ;
                     }
                     else
                     {
                        //i-1 i+1 j-1 et j-2 = voisins
                     }
                 }
             }
             return null;
        }*/

        public void Open(int i, int j)
        {

        }
    }
}
