using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LexiconProj1
{
    class FightInfo
    {
        public string name;
        public int strength;
        public int health;
        public int luck;
        public void GenerateStrengthHealthLuck()
        {
            Random rnd = new Random();
            
            this.strength = rnd.Next(0, 100);
            this.health = rnd.Next(0, 100);
            this.luck = rnd.Next(0, 100);
        }
        

    }
    class FirstProj
    {
        private void SetForegroundColor(ConsoleColor inputColor)
        {
            Console.ForegroundColor = inputColor;
        }
        private ConsoleColor GetForegroundColor()
        {
            return Console.ForegroundColor;
        }
        private void PrintArrayContent(Array arr)
        {
            foreach (int value in arr)
                Console.Write(value + "\t");
        }
        public void ShowMenu()
        {
            Boolean condition = true;
            string command;
            while (condition)
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine("please choose your function (1:16):");
                Console.WriteLine("1  HelloWorld");
                Console.WriteLine("2  GetPersonalInfo");
                Console.WriteLine("3  ChangeConsoleColor");
                Console.WriteLine("4  PrintTodayDate");
                Console.WriteLine("5  PrintBiggestVal");
                Console.WriteLine("6  GuessnumberGame");
                Console.WriteLine("7  WriteInFile");
                Console.WriteLine("8  ReadFromFile");
                Console.WriteLine("9  MathOnDecimal");
                Console.WriteLine("10 MultiplicationTable");
                Console.WriteLine("11 SortArrayAscending");
                Console.WriteLine("12 CheckIsPalindrome");
                Console.WriteLine("13 PrintNumbersInPeriod");
                Console.WriteLine("14 SortAndSeprateOddEvan");
                Console.WriteLine("15 SumArrayNumbers");
                Console.WriteLine("16 ShowFightInfo");
                
                command = Console.ReadLine();
                switch (Convert.ToInt16(command))
                {
                    case 0:
                        condition = false;
                        break;

                    case 1:
                        //Function 1
                        HelloWorld();
                        break;

                    case 2:
                        //Function 2
                        GetPersonalInfo();
                        break;

                    case 3:
                        //Function 3
                        ChangeConsoleColor();
                        break;

                    case 4:
                        //Function 4
                        PrintTodayDate();
                        break;

                    case 5:
                        //Function 5
                        PrintBiggestVal();
                        break;

                    case 6:
                        //Function 6
                        GuessnumberGame();
                        break;

                    case 7:
                        //Function 7
                        WriteInFile();
                        break;

                    case 8:
                        //Function 8
                        ReadFromFile();
                        break;

                    case 9:
                        //Function 9
                        MathOnDecimal();
                        break;

                    case 10:
                        //Function 10
                        MultiplicationTable();
                        break;

                    case 11:
                        //Function 11
                        SortArrayAscending();
                        break;

                    case 12:
                        //Function 12
                        CheckIsPalindrome();
                        break;

                    case 13:
                        //Function 13
                        PrintNumbersInPeriod();
                        break;

                    case 14:
                        //Function 14
                        SortAndSeprateOddEvan();
                        break;

                    case 15:
                        //Function 15
                        SumArrayNumbers();
                        break;

                    case 16:
                        //Function 16
                        ShowFightInfo();
                        break;

                    default:
                        Console.WriteLine("choosed function is not valid!");
                        break;
                }
            }
        }
        //Function 1
        private void HelloWorld()
        {
            //Funktion som skriver ut ”Hello World” i konsolen
            
            Console.WriteLine("Hello World");
        }
        
        //Function 2
        private void GetPersonalInfo()
        {
            //Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen

            string name, surname;
            int age;
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Surname:");
            surname = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            age = Convert.ToInt16( Console.ReadLine() );


            Console.WriteLine("Your Name is " + name);
            Console.WriteLine("Your Surname is " + surname);
            Console.WriteLine("Your Age is " + age);
        }
        
        //Function 3
        private void ChangeConsoleColor()
        {
            //Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen
            if (GetForegroundColor() != ConsoleColor.Gray)
            {
                SetForegroundColor(ConsoleColor.Gray);
            }
            else
            {
                SetForegroundColor(ConsoleColor.Green);
            }
        }
        
        //Function 4
        private void PrintTodayDate()
        {
            // Funktion för att skriva ut dagens datum
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
        }

        //Function 5
        private void PrintBiggestVal()
        {
            //Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.

            double firstVal, secondVal;

            Console.WriteLine("Please Enter the First Value: ");
            firstVal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter the Second Value: ");
            secondVal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("the Biggest Value is " + Math.Max(firstVal, secondVal));
        }

        //Function 6
        private void GuessnumberGame()
        {
            /*Funktion som genererar att slumpmässigt tal mellan 1 och 100.Användaren ska sedan gissa
            talet.Gissar användaren rätt så ska ett meddelande säga detta, samt hur många försök det
            tog.Gissar användaren fel ska ett meddelande visas som informerar ifall talet var för stort
            eller för litet*/

            int iter = 1;
            bool answer = false;
            int guess, randnumber;
            var rand = new Random();
            randnumber = rand.Next(0, 100);

            while(!answer)
            {
                Console.WriteLine("Guess Number: ");
                guess = Convert.ToInt16(Console.ReadLine());
                if (guess == randnumber)
                {
                    Console.WriteLine("Congratulation!!! You did it in " + iter + "th Try.");
                    answer = true;
                }
                    
                else if (guess > randnumber)
                    Console.WriteLine("Sorry, Your Number Was too Big!");
                else
                    Console.WriteLine("Sorry, Your Number Was too Small!");
                iter = iter + 1;
            }

        }

        //Function 7
        private void WriteInFile()
        {
            //Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken
            string str;
            string filename, folder, filepath;
            filename = "function7.txt";
            folder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\";
            filepath = folder + filename;
            Console.WriteLine("Enter Your Favorite String:");
            str = Console.ReadLine();
            
            System.IO.File.WriteAllText(filepath, str);

            Console.WriteLine("Your Data Saved in " + filepath);
        }

        //Function 8
        private void ReadFromFile()
        {
            //Funktion där en fil läses in från hårddisken (för enkelhetens skull kan man använda filen från uppgift 7)
            string filename, folder, filepath;
            string str;
            filename = "function7.txt";
            folder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\";
            filepath = folder + filename;
            if (File.Exists(filepath))
            {
                str = System.IO.File.ReadAllText(filepath);
                Console.WriteLine("Your Data in File is: " + str);
            }
            else
                Console.WriteLine("No File Exist!!!");

        }

        //Function 9
        private void MathOnDecimal()
        {
            //Funktion där användaren skickar in ett decimaltal och får tillbaka roten ur, upphöjt till 2 och upphöjt till 10
            decimal num;

            Console.WriteLine("Please Enter a Decimal Number:");
            num = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Root of " + num + " is: " + Math.Sqrt(Convert.ToDouble(num)));
            Console.WriteLine("Power 2 of " + num + " is: " + Math.Pow(Convert.ToDouble(num),2));
            Console.WriteLine("Power 10 of " + num + " is: " + Math.Pow(Convert.ToDouble(num),10));

        }

        //Function 10
        private void MultiplicationTable()
        {
            /*Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.En ”tab” ska läggas
            in efter varje nummer.Försöka att ställa upp det så det blir relativt läsbart.*/
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("");
                for (j = 1; j <= 10; j++)
                    Console.Write(i * j + "\t");
            }
            Console.WriteLine("");
        }

        //Function 11
        private void SortArrayAscending()
        {
            /*Funktion som skapar två arrayer.Den första fylls med slumpmässiga tal. Den andra fylls med
            talen från den första i stigande ordning.*/
            Random random = new Random();
            int[] randomArray = new int[10];
            for (int i = 0; i < 10; i++)
                randomArray[i] = random.Next(0, 100);
            int[] sortedArray = new int[10];
            Array.Copy(randomArray, 0, sortedArray, 0, 10);

            Array.Sort(sortedArray);

            Console.Write("Random Array:\t");
            PrintArrayContent(randomArray);
            Console.WriteLine("");

            Console.Write("Sorted Array:\t");
            PrintArrayContent(sortedArray);
            Console.WriteLine("");
        }

        //Function 12
        private void CheckIsPalindrome()
        {
            /*Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom(alltså
            samma ord från båda håll, såsom Anna eller radar.*/
            string str,revStr;
            Console.WriteLine("Please enter a string:");
            str = Console.ReadLine();

            char[] tmp = str.ToCharArray();
            Array.Reverse(tmp);

            revStr = new string(tmp);

            if (String.Compare(str.ToLower(), revStr.ToLower()) == 0)
                Console.WriteLine("String is Palindrom!");
            else
                Console.WriteLine("String is NOT Palindrom!");


        }

        //Function 13
        private void PrintNumbersInPeriod()
        {
            //Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.
            int startNum, stopNum;

            Console.WriteLine("Please Enter Start Input Number:");
            startNum = Convert.ToInt16( Console.ReadLine() );
            Console.WriteLine("Please Enter Stop Input Number:");
            stopNum = Convert.ToInt16( Console.ReadLine() );
            
            if(startNum<=stopNum)
            {
                Console.Write("Numbers Between " + startNum + " and " + stopNum + " Are: ");
                for (int val = startNum + 1; val < stopNum; val++)
                    Console.Write(val + " ");
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Stop Number Is Smaller Than Start Number!!!");
        }

        //Function 14
        private void SortAndSeprateOddEvan()
        {
            /*Funktion där användaren skickar in ett antal värden(komma - separerade siffror) som sedan
            sorteras och skrivs ut efter udda och jämna värden.*/
            string str;
            int[] numArray, evenArray, oddArray;


            Console.WriteLine("Please Enter Your Number Which Is Seperated by Comma:");
            str = Console.ReadLine();
            numArray = Array.ConvertAll(str.Split(','), int.Parse);
            Array.Sort(numArray);

            List<int> tmpEven = new List<int>();
            List<int> tmpOdd = new List<int>();

            foreach (int val in numArray)
                if (val % 2 == 0)
                    tmpEven.Add(val);
                else
                    tmpOdd.Add(val);
            evenArray = tmpEven.ToArray();
            oddArray = tmpOdd.ToArray();

            Console.Write("Sorted Even Numbers:\t");
            PrintArrayContent(evenArray);
            Console.WriteLine("");

            Console.Write("Sorted Odd Numbers:\t");
            PrintArrayContent(oddArray);
            Console.WriteLine("");
        }
        
        //Function 15
        private void SumArrayNumbers()
        {
            //Funktion där användaren skriver in ett antal värden(komma - separerade siffor) som sedan adderas och skrivs ut.
            string str;
            int[] numArray;
            int acc = 0;

            Console.WriteLine("Please Enter Your Number Which Is Seperated by Comma:");
            str = Console.ReadLine();
            numArray = Array.ConvertAll(str.Split(','), int.Parse);
            foreach (int val in numArray)
                acc = acc + val;
            Console.WriteLine("Sum of Inputs Are: " + acc);
        }

        //Function 16
        private void ShowFightInfo()
        {
            /*Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare.
            Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur, som
            sparas i en instans av en klass.*/

            FightInfo person1 = new FightInfo();
            FightInfo person2 = new FightInfo();


            Console.WriteLine("PLease Enter Your Name:");


            person1.name = Console.ReadLine();

            Console.WriteLine("PLease Enter Your Fighter Name:");
            person2.name = Console.ReadLine();

            person1.GenerateStrengthHealthLuck();
            person2.GenerateStrengthHealthLuck();

            Console.WriteLine(person1.name + "\tInformation:\tStrength: " + person1.strength + "\tHealth: " + person1.health + "\tLuck: " + person1.luck);
            Console.WriteLine(person2.name + "\tInformation:\tStrength: " + person2.strength + "\tHealth: " + person2.health + "\tLuck: " + person2.luck);


    }


    }
    class Program
    {

        static void Main(string[] args)
        {
            FirstProj myVal = new FirstProj();
            myVal.ShowMenu();            
        }
    }
}


