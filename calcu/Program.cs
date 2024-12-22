using System;

class Calculator
{
    // Méthode pour additionner deux nombres
    static double Addition(double num1, double num2)
    {
        return num1 + num2;
    }

    // Méthode pour soustraire deux nombres
    static double Soustraction(double num1, double num2)
    {
        return num1 - num2;
    }

    // Méthode pour multiplier deux nombres
    static double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    // Méthode pour diviser deux nombres
    static double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Erreur : Division par zéro impossible.");
        }
        return num1 / num2;
    }

    // Méthode pour exécuter l'opération demandée
    static double EffectuerOperation(double num1, double num2, string operation)
    {
        double resultat = 0;
        switch (operation)
        {
            case "+":
                resultat = Addition(num1, num2);
                break;
            case "-":
                resultat = Soustraction(num1, num2);
                break;
            case "*":
                resultat = Multiplication(num1, num2);
                break;
            case "/":
                try
                {
                    resultat = Division(num1, num2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return double.NaN; // Retourne NaN pour signaler une erreur
                }
                break;
            default:
                Console.WriteLine("Opération invalide.");
                return double.NaN;
        }
        return resultat;
    }

    // Méthode principale
    static void Main()
    {
        Console.WriteLine("                                             \u2554\u2550\u2550\u2550\u2550════════════════════════════\u2550\u2557");
        Console.WriteLine("                                             ║   Bienvenue dans la calculatrice\u2551");
        Console.WriteLine("                                             \u255A\u2550\u2550\u2550\u2550═════════════════════════════\u255D");
        Console.ForegroundColor = ConsoleColor.Green;

        while (true)
        {
            // Demander à l'utilisateur d'entrer la première valeur
            Console.Write("Entrez le premier nombre: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Veuillez entrer un nombre valide.");
                continue;
            }

            // Demander l'opération
            Console.Write("Entrez l'opération (+, -, *, /): ");
            string operation = Console.ReadLine();

            // Demander à l'utilisateur d'entrer la deuxième valeur
            Console.Write("Entrez le deuxième nombre: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Veuillez entrer un nombre valide.");
                continue;
            }

            // Effectuer l'opération et afficher le résultat
            double resultat = EffectuerOperation(num1, num2, operation);
            if (!double.IsNaN(resultat))
            {
                Console.WriteLine($"Résultat: {num1} {operation} {num2} = {resultat}");
            }

            // Demander si l'utilisateur souhaite continuer
            Console.Write("Voulez-vous effectuer un autre calcul ? (y/n): ");
            string reponse = Console.ReadLine().ToLower();
            if (reponse != "y")
            {
                break;
            }
        }

        Console.WriteLine("Merci d'avoir utilisé la calculatrice. À bientôt!");
    }
}


