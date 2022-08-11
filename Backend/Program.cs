// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Text;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            /*console.WriteLine("Hello World");   //>>>>>>>>>>-Creating your first c# program
              Console.ReadLine();
            -----------------------------------*/

            /*int x;
              int y;

              x = 7;
              y = x + 3;
              Console.WriteLine(y);

              Console.WriteLine();
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");         //>>>>>>>>> Understanding Data Types and Variables
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;
            // Console.Write("Type your last name: ");
            // myLastName= Console.ReadLine();

            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();
          
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
            -------------------------------------------------*/


            /*tring message = "";                              

             if (userValue == "1")
             {
                 message = "you won a new car!";
             }
             else if(userValue == "2")
             {
                 message = "You won a new boat!";
             }                                                            //>>>>>>>>>>>The if Decision Statement
             else if (userValue == "3")
             {
                 message = "You won a new cat!";
             }
             else
             {
              message = "Sorry, we didnt understand.";
            //message = message + "You Lose";
             message += "You Lose. ";
             }

             Console.WriteLine(message);
             Console.ReadLine();

             Console.WriteLine("Bob' s Big Giveaway");
             Console.Write("Choose a door: 1, 2 or 3: ");
             string userValue = Console.ReadLine();

             string message = (userValue == "1") ? "boat" : "strand of lint";
             Console.WriteLine("You won a ");
             Console.Write(message);
             Console.Write(".");
             Console.ReadLine();
             -------------------------------------------------------------------*/

            /*

              
              for (int i = 0; i < 10; i++)
              {
                  if (i == 7)                                     // >>>>>>>>>> For iteration Statement
                   {
                      Console.WriteLine("Found seven!");
                      break;
                  }
              }
              for (int myValue = 0; myValue < 12; myValue++)
              {
                  Console.WriteLine(myValue);
              }
              Console.ReadLine();
            -------------------------------------------------------------*/

            /*t number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;
            if (number1 == 16)
            {
                                                                  //>>>>>>>>>> Understanding Arrays
            }
            else if(number2 == 16)
            {
                
            }
            else if(number3 == 16)
            {
            }
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();

            string[] names = new string[] { "Adhonys", "Jose", "Kandora", "Ean", "Carlos", "Cesar" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            string zig = "You can get what you want out of life" + " if you help enough other people get what they want.";
            char[] chararray = zig.ToCharArray();
            Array.Reverse(chararray);
            foreach (char c in chararray) { Console.WriteLine(c); }


            -----------------------------------------------------------------------------*/



            /* bool displayMenu = true;
               while (displayMenu)
               {
                   displayMenu = MainMenu();
               }
           }
           private static bool MainMenu()
           {
               Console.Clear();
               Console.WriteLine("Choose an option:");
               Console.WriteLine("1) print Numbers");
               Console.WriteLine("2) guessing Game");
               Console.WriteLine("3) Exit");
               string result = Console.ReadLine();
               if (result == "1")
               {
                   printNumbers();
                   return true;
               }
               else if(result == "2")
               {
                   GuessingGame();
                   return true;
               }
               else if (result == "3")
               {
                   return false;
               }
               else
               {
                   return true;
               }
           }
           private static void printNumbers()
           {
               Console.Clear();
               Console.WriteLine("print numbers");
               Console.Write("type a number ");
               int result = int.Parse(Console.ReadLine());
               int counter = 1;
               while (counter < result)
               {
                   Console.Write(counter);
                   Console.Write("-");
                   counter++;
               }
               Console.ReadLine();                                            //>>>>>>>>>>While iteration Statement

           }
           private static void GuessingGame()
           {
               Console.Clear();
               Console.WriteLine("Guessing game!");
               Random myRandom = new Random();
               int randomnumber = myRandom.Next(1, 11);

               int guesses = 0;
               bool incorrect = true;
               do
               {
                   Console.WriteLine("guess a number between 1 and 10: ");
                   string result = Console.ReadLine();
                   guesses++;
                   if (result == randomnumber.ToString())
                       incorrect = false;
                   else
                       Console.WriteLine("wrong");
               } while (incorrect);
               Console.WriteLine("correct! It took you {0} guesses.", guesses);
               Console.ReadLine();
            --------------------------------------------------*/

            /*Console.WriteLine("The Name Game");
            Console.Write("What ' s your First name?");
            string firstName = Console.ReadLine();

            Console.Write("Whast 's your last name?");
            string lastName = Console.ReadLine();

            Console.Write("In What city were you born?");
            string city = Console.ReadLine();                                 //>>>>>>>>>Defining and Calling Methods


            string reversedFirstName = ReversesString(firstName);
            string reversedLastName = ReversesString(lastName);
            string reversedCity = ReversesString(city);

            DisplayResult(ReversesString(firstName),
                ReversesString(lastName),
                ReversesString(city));
            Console.WriteLine();
            Console.WriteLine();

            DisplayResult(ReversesString(firstName) + " " +
                ReversesString(lastName) + " " +
                ReversesString(city));

            Console.ReadLine();
            ------------------------------------------------------------*/
            /*----------------------------------------------------------------------
            /*string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line?"
            //string myString = "Go to your c:\\drive";
            //string myString = @"Go to your c:\ drive"; 
            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = String.Format("{0:C}", 123.45);
            //string myString = String.Format("{0:N}", 1234567890);
            //string myString = String.Format("Percentage: {0:P}", .123);
            //string myString = String.Format("Phone Number{0:(###)###-####)}", 82958949226);
            //string myString = " That summer we took threes across the board ";*/

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /* myString = String.Format(" Length before: {0} -- Length after: {1}", 
            // myString.Length, 
             myString.Trim().Length);*/
            // string myString = "";
            /*for (int i = 0; i < 100; i++)                           //>>>>>>>>>>>> Working with Strings
              {
                  myString += "--" + i.ToString();
              }*/
            /* StringBuilder myString=new StringBuilder();
             for (int i = 0; i < 100; i++)
             {
                 myString.Append("--");
                 myString.Append(i);
             }

             Console.WriteLine(myString);
             Console.ReadLine();
            ------------------------------------------------------------------*/
           /* DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());     //>>>>>>>>>> Working With Dates and Times
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1996, 4, 22);
            //Console.WriteLine(myBirthday.ToShortDateString());
            DateTime myBirthday = DateTime.Parse("4/22/1996");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

             Console.ReadLine();
           -----------------------------------------------------------------------------------*/
           Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model, 
                myCar.Year, 
                myCar.Color);
            //decimal value = DetermineMarketValue(myCar); ;
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}",
            myCar.DetermineMarketValue());

            Console.ReadLine();

        }
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            
            return carValue;
        }
        /* private static string ReversesString(string message)
         {

             char[] messageArray = message.ToCharArray();
             Array.Reverse(messageArray);
             return string.Concat(messageArray);           //Defining and Calling Methods

         }
         private static void DisplayResult(
             string reversedFirstName,
             string reversedLastName,
             string reversedCity)
         {
             Console.Write("Result: ");
             Console.Write(String.Format("{0} {1} {2}",
                 reversedFirstName,
                 reversedLastName,
                 reversedCity));
         }
         private static void DisplayResult(
            string message)
         {
             Console.Write("Result: ");
             Console.Write(message);
         }
        ---------------------------------------------------------------*/

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }
    }
}
