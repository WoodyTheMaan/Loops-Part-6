namespace Loops_Part_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int theNumberGenerated, firstInput, lastInput, howManyScores, passScore = 0, numberPicked = 0;
            double answer1 = 0;
            string select, answer = "";

            Console.WriteLine("Please select an option");
            Console.WriteLine("============================");
            Console.WriteLine("1 ... PROMPTER");
            Console.WriteLine("2 ... PERCENT PASSING");
            Console.WriteLine("3 ... ODD SUM");
            Console.WriteLine("4 ... RANDOM NUMBERS");
            Console.WriteLine("5");
            select = Console.ReadLine();
            if (select == "1")
            {
                Console.WriteLine("Please pick a lowest and highest number");
                firstInput = Convert.ToInt32(Console.ReadLine());
                lastInput = Convert.ToInt32(Console.ReadLine());
                theNumberGenerated = generator.Next(firstInput, lastInput + 1);
                Console.WriteLine("Now please pick a number bewteen that range you made.");
                while (answer1 != theNumberGenerated && answer1 != 0.1)
                {
                    Console.WriteLine("Guess here......");
                    Console.WriteLine("Or click 0.1 to exit");
                    answer1 = Convert.ToDouble(Console.ReadLine());
                }

            }
            else if (select == "2")
            {

                Console.WriteLine("Please pick how many scores you would like to input.");
                howManyScores = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < howManyScores; i++)
                {
                    Console.WriteLine("Hello");
                    Console.WriteLine("Please enter a score");
                    if (Convert.ToInt32(Console.ReadLine()) >= 70)
                    {
                        passScore++;
                    }

                }

                Console.WriteLine($"{passScore * 100 / howManyScores}% passed");

            }
            else if (select == "3")
            {
                Console.WriteLine("Please enter a number! Any number!!");
                numberPicked = Convert.ToInt32(Console.ReadLine());
                int numbersBeforeZero = 0;
                for (int i = 1; i < numberPicked; i += 2)
                {
                    numbersBeforeZero += i;
                }
                Console.WriteLine($"There are {numbersBeforeZero} amount of odd numbers in the number");

            }
            else if (select == "4")
            {
                Console.WriteLine("Please select the range of numbers (max and min)");
                firstInput = Convert.ToInt32(Console.ReadLine());
                lastInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < 25; i++)
                {
                    Console.Write(generator.Next(firstInput, lastInput + 1) + " ");
                }


            }
            else if (select == "5")
            {
                
                double bankAccount = 100.00, bet;
                string userInputMenu = "";
                bool repeat = true, done = false;
               while (!done)
               {     
                
                    Console.WriteLine($"Hello, you have ${bankAccount} dollars what do you want to bet?");
                    Console.WriteLine("Do you wish to continue");
                    
                        if (bankAccount <= 0)
                        {
                            done = true;
                        }

                        Console.WriteLine("You can bet...");

                        Console.WriteLine("1 .. Doubles (win double what you bet)");
                        Console.WriteLine("2 .. Not double (win half your bet)");
                        Console.WriteLine("3 .. Even sum (win your bet, you bet 3 you get 3)");
                        Console.WriteLine("4 .. Odd sum (Same as even sum just odd)");
                        Console.WriteLine("Please type numbers not words.");
                        userInputMenu = Console.ReadLine();
                        if (userInputMenu == "1")
                        {
                            Console.WriteLine("You picked 1, please place a bet");
                            repeat = false;
                            bet = Convert.ToInt32(Console.ReadLine());
                            if (bet > bankAccount)
                            {
                                bet = bankAccount;
                            }
                            if (bet < 0)
                            {
                                bet = 0;
                            }

                            Console.ReadLine();
                            Die die1 = new Die();
                            Die die2 = new Die(3);

                            Console.WriteLine($"You rolled a {die1}");
                            die1.DrawDie();


                            die1.RollDie();
                            die1.DrawDie();
                            Console.WriteLine($"You rolled a {die1}");
                            if (die1.Roll == die2.Roll)
                            {
                                bankAccount = bankAccount + bet * 2;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                            }
                            else if (die1.Roll != die2.Roll)
                            {
                                if (bankAccount < bet * 2)
                                {
                                    bankAccount = 0;
                                }
                                else if (bankAccount > bet * 2)
                                {
                                    bankAccount = bankAccount - bet * 2;
                                }


                                Console.WriteLine("YOU LOST...");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                        }
                        else if (userInputMenu == "2")
                        {
                            Console.WriteLine("You picked 2, please place a bet");
                            repeat = false;
                            bet = Convert.ToInt32(Console.ReadLine());
                            if (bet > bankAccount)
                            {
                                bet = bankAccount;
                            }
                            if (bet < 0)
                            {
                                bet = 0;
                            }

                            Console.ReadLine();
                            Die die1 = new Die();
                            Die die2 = new Die(3);
                            Console.WriteLine($"You rolled a {die1}");
                            die1.DrawDie();


                            die1.RollDie();
                            die1.DrawDie();
                            Console.WriteLine($"You rolled a {die1}");

                            if (die1.Roll == die2.Roll)
                            {
                                bankAccount = bankAccount - bet / 2;


                                Console.WriteLine("YOU LOST...");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1 != die2)
                            {
                                bankAccount = bankAccount + bet / 2;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                        }
                        else if (userInputMenu == "3")
                        {
                            Console.WriteLine("You picked 3, please place a bet");
                            repeat = false;
                            bet = Convert.ToInt32(Console.ReadLine());
                            if (bet > bankAccount)
                            {
                                bet = bankAccount;
                            }
                            if (bet < 0)
                            {
                                bet = 0;
                            }
                            Console.ReadLine();
                            Die die1 = new Die();
                            Die die2 = new Die(3);
                            Console.WriteLine($"You rolled a {die1}");
                            die1.DrawDie();


                            die1.RollDie();
                            die1.DrawDie();
                            Console.WriteLine($"You rolled a {die1}");
                            if (die1.Roll + die2.Roll == 2)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 4)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 6)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 8)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 10)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 12)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("YOU LOST...");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }

                        }
                        else if (userInputMenu == "4")
                        {
                            Console.WriteLine("You picked 4, please place a bet");
                            repeat = false;
                            bet = Convert.ToInt32(Console.ReadLine());
                            if (bet > bankAccount)
                            {
                                bet = bankAccount;
                            }
                            if (bet < 0)
                            {
                                bet = 0;
                            }
                            Console.ReadLine();
                            Die die1 = new Die();
                            Die die2 = new Die(3);
                            Console.WriteLine($"You rolled a {die1}");
                            die1.DrawDie();


                            die1.RollDie();
                            die1.DrawDie();
                            Console.WriteLine($"You rolled a {die1}");
                            if (die1.Roll + die2.Roll == 1)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 3)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 5)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 7)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 9)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else if (die1.Roll + die2.Roll == 11)
                            {
                                bankAccount = bankAccount + bet;
                                Console.WriteLine("YOU WON!!");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("YOU LOST...");
                                Console.WriteLine($"You now have ${bankAccount}!");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.Clear();
                        }

                    }
                
            }
        }
    }
}