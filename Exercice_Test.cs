using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceTest
{

    class ClasseChaine
    {
        String initiale;
        String iniName;
        String iniFistName;

        public String RetournerInitiale(String name, String firstName) {
            if (name.Length > 1 && firstName.Length > 1) {
                String iniName = name.Substring(0, 1);
                String iniFistName = firstName.Substring(0, 1);
                initiale = iniName + "." + iniFistName;
            }
            else
            {
                initiale = "Erreur, le Nom ou Prénom saisit ne permet pas d'obtenir les initiales.";
            }
            return initiale;
        }
        public String RetournerInitiale(String fullName)
        {
            if (fullName.Contains(" ")) {
                String[] nameFull = fullName.Split();
                if (nameFull[0].Length > 1 && nameFull[1].Length > 1) {
                    iniName = nameFull[0].Substring(0, 1);
                    iniFistName = nameFull[1].Substring(0, 1);
                    initiale = iniName + "." + iniFistName;
                } else {
                    initiale = "Erreur, le Nom ou Prénom saisit ne permet pas d'obtenir les initiales.";
                }
            } else {
                initiale = "Erreur, impossible de détecter le Nom Entier";
            }
            return initiale;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer votre Prénom : ");
            String firstName = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre Nom : ");
            String name = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre Nom puis votre Prénom : ");
            String fullName = Console.ReadLine();
            ClasseChaine test = new ClasseChaine();
            String initiale = test.RetournerInitiale(firstName, name);
            String initialeFullName = test.RetournerInitiale(fullName);
            Console.WriteLine("Vos initiales sont : " + initiale);
            Console.WriteLine("Vos initiales sont : " + initialeFullName);
            Console.ReadLine();
        }
    }
}
