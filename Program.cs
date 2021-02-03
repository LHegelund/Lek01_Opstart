using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek01_Opstart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Øvelse 4
            Console.WriteLine("Hallo world!");
            
            string aFriend = "Bill";
            Console.WriteLine("Hallo " + aFriend);

            aFriend = "Maira";
            Console.WriteLine("Hallo " + aFriend);

            // String interpolation
            // {aFriend} = erstatter teksten med værdien af variablen 
            Console.WriteLine($"Hello {aFriend}");

            /* $ = Hvis det tilføjes før strengens indledende citat, 
             * kan man efterfølgende inkludere variabler, 
             * som aFriend, inde i strengen mellem {} */

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            // .lengt = property for en streng, der returnerer antallet af tegn i strengen
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            // Trim bruges hvis man ønsker at trimme mellemrum fra strenge
            // [] bruges blot til at demonstrere hvad metoden gør, altså hvilke mellemrum slettes
            string greeting = "     Hello world!      ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            /* Replace søger efter en substring og ersatter den med
             * anden tekst. Metoden tager 2 parametre. 
             * Første streng er teksten, der skal søges efter.
             * Anden streng er teksten, der skal erstattes med. */
            string sayHello = "Hello world!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            // Store og små bogstaver
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            /* Contains kan bruges til søgning.
             * Det fortæller om en streng indeholder en substring inde i den */
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine("Indeholder den goodbye? " + songLyrics.Contains("goodbye"));
            Console.WriteLine("Indeholder den greetings? " + songLyrics.Contains("greetings"));

            Console.WriteLine("Er det første ord? " + songLyrics.StartsWith("You"));
            Console.WriteLine("Er det første ord? " + songLyrics.StartsWith("goodbye"));
            Console.WriteLine("Er det sidste ord? " + songLyrics.EndsWith("hello"));
            Console.WriteLine("Er det sidste ord? " + songLyrics.EndsWith("goodbye"));

            Console.ReadKey();
        }
    }
}
