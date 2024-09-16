using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3(b) : dans le pire des cas, la méthode est effectuée jusqu'à ce que toutes les cases soient ouvertes par cette méthode, donc n*n fois
//3(c) : probabilité faible de devoir ouvrir toutes les cases avant
namespace Percolation
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("entrer une taille de grille :");
            string entrée = Console.ReadLine();
            bool entier = Int32.TryParse(entrée,out int output);
            if (entier == true)
            {
                int size = Int32.Parse(entrée);
                if (size >= 0)
                { 
                    Percolation perc = new Percolation(size);
     
                    for (int i = 0 ; i < size ; i++)
                    {
                        for (int j = 0 ; j < size ; j++)
                        {
                            perc.IsOpen(i,j);
                            if (perc.IsOpen(i,j) == false)
                            {
                                Console.WriteLine($"Ligne {i}, colonne {j} = case fermée");
                            }
                            else
                            { 
                                perc.IsFull(i,j);
                                if (perc.IsFull(i,j)==true)
                                {
                                     Console.WriteLine($"Ligne {i}, colonne {j} = case pleine");
                                }
                                else
                                {
                                     Console.WriteLine($"Ligne {i}, colonne {j} = case ouverte");
                                }
                            }
                        }
                    }
                    perc.Percolate();
                    if (perc.Percolate() == true)
                    {
                         Console.WriteLine("ça percolle");
                    }
                    else
                    {
                         Console.WriteLine("ça ne percolle pas");
                    }
                }
                else
                {
                      Console.WriteLine("Valeur non conforme, veuillez rentrer un chiffre positif.");
                }
            }
            else
            {
                Console.WriteLine("Valeur non conforme, veuillez rentrer un chiffre.");
            }
           
            
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
