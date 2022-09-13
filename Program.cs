using System.Media;

namespace RandomNumberGuesser
{
    internal class Program
    {
        private static int eingabeUser;

        static void Main(string[] args)
        {
            int anzahlVersuche = 0;
            bool fehler = false;

            SoundPlayer intro = new SoundPlayer(@"C:\Users\filip\Documents\sounds\intro.wav");
            intro.Play();

            while (anzahlVersuche <= 9)
            {
                var meinProgramm = ("Du kannst dich für einen Zahlenbereich entscheiden. Zum Beispiel kannst du zwischen 1-10'000 oder zwischen 1-100 raten. Die gewünschte Zahl darf nicht <= 1 sein\n");
                foreach (var character in meinProgramm)
                {
                    Console.Write(character);
                    Thread.Sleep(10);
                }
                try
                {
                    int zahlenbereich = Convert.ToInt32(Console.ReadLine());

                    if (zahlenbereich < 1)
                    {
                        fehler = true;
                        throw new System.FormatException("Der Zahlenbereich muss über 0 sein!");
                    }
                    else
                    {
                        fehler = false;
                        Console.WriteLine("Der Zahlenbereich 1-" + zahlenbereich + " wurde erfolgreich gewählt!");
                        Console.WriteLine("Texte werden erkannt also mach kei faxe. Du hast 10 Versuche! Viel Glück!\n");
                    }

                    Random rnd = new Random();
                    int randomNumber = rnd.Next(1, zahlenbereich);

                    while (anzahlVersuche <= 9)
                    {
                        Console.WriteLine("Geben Sie eine zufällige Zahl ein: ");
                        try
                        {
                            SoundPlayer victory = new SoundPlayer(@"C:\Users\filip\Documents\sounds\victory.wav");
                            SoundPlayer shutdown = new SoundPlayer(@"C:\Users\filip\Documents\sounds\shutdown.wav");
                            SoundPlayer error = new SoundPlayer(@"C:\Users\filip\Documents\sounds\error.wav");
                            
                            int eingabeUser = Convert.ToInt32(Console.ReadLine());
                            if (eingabeUser == randomNumber)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                victory.Play();
                                Console.WriteLine("Sie haben die Zahl erraten! Dafür haben Sie " + anzahlVersuche + " Versuche gebraucht.");
                                Console.ResetColor();
                                Thread.Sleep(1000);
                                Console.WriteLine("Möchten Sie noch einmal spielen? (ja/nein): ");
                                String repeatWin = Console.ReadLine();
                                if (repeatWin == "ja")
                                {
                                    anzahlVersuche = 0;
                                    break;
                                }
                                else if (repeatWin == "nein")
                                {
                                    shutdown.Play();
                                    Thread.Sleep(3000);
                                    System.Environment.Exit(0);
                                }

                                else
                                {
                                    shutdown.Play();
                                    Thread.Sleep(3000);
                                    System.Environment.Exit(0);
                                }


                            } else if (eingabeUser > zahlenbereich || eingabeUser < 1)
                            {
                                error.Play();
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Es sind nur Zahlen von 1-" + zahlenbereich + " erlaubt!");
                                Console.ResetColor();
                                Thread.Sleep(2000);
                            } else if (eingabeUser < randomNumber)
                            {
                                error.Play();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ihre Zahl ist zu niedrig!");
                                Console.ResetColor();
                                anzahlVersuche++;
                                Thread.Sleep(1000);
                            } else if (eingabeUser > randomNumber)
                            {
                                error.Play();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ihre Zahl ist zu hoch!");
                                Console.ResetColor();
                                anzahlVersuche++;
                                Thread.Sleep(1000);
                            }
                            if (anzahlVersuche > 9)
                            {
                                error.Play();
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Sie haben verloren!");
                                Console.ResetColor();
                                Thread.Sleep(1000);
                                Console.WriteLine("Möchten Sie noch einmal spielen? (ja/nein): ");
                                String repeatLose = Console.ReadLine();

                                if (repeatLose == "ja")
                                {
                                    anzahlVersuche = 0;
                                    break;
                                }
                                else if (repeatLose == "nein")
                                {
                                    shutdown.Play();
                                    Thread.Sleep(2000);
                                    System.Environment.Exit(0);
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Es sind nur Zahlen erlaubt!");
                            Console.ResetColor();
                            Thread.Sleep(2000);
                        }
                    }
                }catch (System.FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    if (fehler == true)
                    {
                        Console.WriteLine("Der Zahlenbereich muss über 0 sein");
                    }
                    else
                    {
                        Console.WriteLine("Es sind nur Zahlen erlaubt!");
                    }
                    
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
            }
        }
    }
}