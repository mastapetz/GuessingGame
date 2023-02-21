
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace GuessingGame
{

    class Guess
    {
        private int tryNumber;    //verbleibende Versuche
        private int guessNumber;  //Eingabe
        private int secretNumber; //Ergebnis
        public int highScore;    //Highscore
        private int inputInt;
        private Random calcNumber = new Random();  //calcNumber = rnd


        public int getSecretNumber()      //=getErgebnis
        {
            return this.secretNumber;
        }

        public void randomizer()       //=wuerfeln
        {
            secretNumber = calcNumber.Next(1, 21);  //calcNumber == rnd
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Guess secretNum = new Guess(); // Guess == Wuerfel
            secretNum.randomizer();
            //testausgabe
            //Console.WriteLine("Ergebnis: " + secretNum.getSecretNumber());
            //--------------------------------------------

            int tryNumber = 20;
            //int highScore;




            //-------mediumform
            do
            {
                Console.WriteLine("Raten sie die Nummer (1-20)");
                string inputString = Console.ReadLine();
                int inputInt = Convert.ToInt32(inputString);


                if (inputInt != secretNum.getSecretNumber())
                {
                    tryNumber--;
                    if (inputInt > secretNum.getSecretNumber())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zu Hoch " + tryNumber + " Versuche übrig");
                        //Console.ReadKey();  //warted auf "any key" zum beenden
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Zu Niedrig " + tryNumber + " Versuche übrig");
                        //Console.ReadKey();
                    }

                }
                else if (inputInt == secretNum.getSecretNumber())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Richtig");
                    Console.WriteLine("Taste Drücken zum Beenden");
                    Console.ReadKey();
                    //highScore = tryNumber;
                    break;
                }

            } while (tryNumber > 0);
        }
    }
}

/* Von Hier an:
 * Funktions Kontrolle von codes anhand von anderen Beispielen,
 * extra Idee die entweder zu lang waren oder nicht funktional,
 * */


//public void gameStart()
//{
//    Console.WriteLine("Welche Zahl zwischen 1 und 20 ist es.");
//    string inputString= Console.ReadLine();
//    int inputInt = Convert.ToInt32(inputString);
//}

//public int getInputInt()
//{ 
//    return this.inputInt;
//}

//    class Wuerfel
//    { 
//    private int ergebnis;
//    private Random rnd = new Random(); 
//    public int getErgebnis() 
//    {
//        return this.ergebnis;
//    }
//    public void wuerfeln()
//    { 
//        ergebnis = rnd.Next(1, 7); 
//    }
//}

//static void Main(string[] args) 
//{ 
//    Wuerfel w = new Wuerfel();
//    for (int i = 0; i < 10; i++)
//    {
//        w.wuerfeln(); 
//        Console.WriteLine(“Ergebnis: “ +w.getErgebnis()); 
//    } 
//}

//-------------------langform
//if (tryNumber > 0)
//{
//    if (inputInt > secretNum.getSecretNumber())
//    {
//        Console.WriteLine("Zu hoch");
//        tryNumber--;
//    }
//    else if (inputInt < secretNum.getSecretNumber())
//    {
//        Console.WriteLine("Zu Niedrig");
//        tryNumber--;
//    }
//    else if (inputInt == secretNum.getSecretNumber())
//    {
//        Console.WriteLine("Richtig");
//        highScore = tryNumber;
//        //break;
//    }

//}
//else
//{
//    Console.WriteLine("Game Over");
//}
//-----------------kurzform ???

//if (inputInt == secretNum.getSecretNumber())
//{
//    highScore = tryNumber;
//    Console.WriteLine("Richtig!");
//}
//else if (inputInt != secretNum.getSecretNumber())
//{
//    bool x;
//    x = (inputInt > secretNum.getSecretNumber());
//    x ? {Console.WriteLine("Zu Hoch")} : {Console.WriteLine("Zu Niedrig")};
//}