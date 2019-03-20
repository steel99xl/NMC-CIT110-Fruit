using System;

namespace Fruit
{
    class MainClass
    {
        public enum TypeOfFruit
        {
            banana,
            strawberry,
            mango,
            apple,
            pineapple,
            pear,
            watermellon,
            orange
        }
        public static void Main(string[] args)
        {
            TypeOfFruit fruitList;
            string userResponce;
            string[] userFruit = new string[3];
            TypeOfFruit[] fruitOptions = new TypeOfFruit[8];

            fruitOptions[0] = TypeOfFruit.apple;
            fruitOptions[1] = TypeOfFruit.banana;
            fruitOptions[2] = TypeOfFruit.strawberry;
            fruitOptions[3] = TypeOfFruit.mango;
            fruitOptions[4] = TypeOfFruit.pineapple;
            fruitOptions[5] = TypeOfFruit.pear;
            fruitOptions[6] = TypeOfFruit.watermellon;
            fruitOptions[7] = TypeOfFruit.orange;

            Console.WriteLine("AVALIBLE FRUIT");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(fruitOptions[i]);
            }

            Console.WriteLine("*****************");


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.Write("What is your " + (i+1)+ " favorite fruit : ");
                userResponce = Console.ReadLine();

                if(Enum.TryParse(userResponce.ToLower(), out fruitList))
                {
                    userFruit[i] = userResponce;
                }
                else
                {
                    Console.WriteLine("Sorry we dont have that kind of fruit");
                    i -= 1;
                }
            }

            Console.WriteLine();

            Console.WriteLine("The fruit you selected is");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(userFruit[i]);

            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
