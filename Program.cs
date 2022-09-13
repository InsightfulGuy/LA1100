namespace LA_1100_NumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();

                bool playAgain = true;

                int min = 1;

                int max = 100;

                int guess;

                int number;



                String response;



                while (playAgain == true) 

                {

                    guess = 0;



                    response = "";

                    number = random.Next(min, max + 1);



                    while (guess != number)

                    {

                        Console.WriteLine("Errate eine Nummer zwischen " + min + " - " + max + " : ");

                        guess = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Deine Nummer: " + guess);



                        if (guess > number)

                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(guess + " deine Nummer ist zu hoch! ");

                        }

                        else if (guess < number)

                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(guess + " deine Nummer ist zu tief! ");

                        }



                    }


                    Console.WriteLine("Nummer: " + number);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du hast gewonnen! :) ");



                    Console.WriteLine("Willst du nochmals spielen? [Y/N]: ");

                    response = Console.ReadLine();

                    response = response.ToUpper();



                    if (response == "Y")

                    {

                        playAgain = true;

                    }

                    else

                    {

                        playAgain = false;

                    }

                }



                Console.ReadLine();
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Nur Zahlen sind erlaubt! ");
                    Environment.Exit(0);
            }
            
            

        }


    }
}
