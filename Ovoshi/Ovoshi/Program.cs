using System;
using System.Collections.Generic;
using System.Text;

namespace Ovoshi
{
    public class Program
    {
         static int randomnumber;
        
        static int Rnd()//метод для рандомного числа
        {
            Random random = new Random();
            return random.Next(7);
            
                    }
        static void Main(string[] args)
        {
            Hello(ref randomnumber);
        }

        public static void ListVegetable()
        {
            
        }
        public static void Hello (ref int randomnumber)
        {
            List<Vegetable> listVegetable = new List<Vegetable>();
            listVegetable.Add(new Vegetable());
            listVegetable[0].Name = Bulba.Name;
            listVegetable[0].Calories = Bulba.Calories;
            listVegetable[0].Color = Bulba.Color;
            listVegetable[0].Weight = Bulba.Weight;
            listVegetable.Add(new Vegetable());
            listVegetable[1].Name = Onion.Name;
            listVegetable[1].Calories = Onion.Calories;
            listVegetable[1].Color = Onion.Color;
            listVegetable[1].Weight = Onion.Weight;
            listVegetable.Add(new Vegetable());
            listVegetable[2].Name = Bellpepper.Name;
            listVegetable[2].Calories = Bellpepper.Calories;
            listVegetable[2].Color = Bellpepper.Color;
            listVegetable[2].Weight = Bellpepper.Weight;
            listVegetable.Add(new Vegetable());
            listVegetable[3].Name = Tomato.Name;
            listVegetable[3].Calories = Tomato.Calories;
            listVegetable[3].Color = Tomato.Color;
            listVegetable[3].Weight = Tomato.Weight;
            listVegetable.Add(new Vegetable());
            listVegetable[4].Name = Carrot.Name;
            listVegetable[4].Calories = Carrot.Calories;
            listVegetable[4].Color = Carrot.Color;
            listVegetable[4].Weight = Carrot.Weight;
            listVegetable.Add(new Vegetable());
            listVegetable[5].Name = Cabbage.Name;
            listVegetable[5].Calories = Cabbage.Calories;
            listVegetable[5].Color = Cabbage.Color;
            listVegetable[5].Weight = Cabbage.Weight;
            listVegetable.Add(new Vegetable());
            listVegetable[6].Name = Pea.Name;
            listVegetable[6].Calories = Pea.Calories;
            listVegetable[6].Color = Pea.Color;
            listVegetable[6].Weight = Pea.Weight;
            listVegetable.Add(new Vegetable());
            listVegetable[7].Name = Aubergine.Name;
            listVegetable[7].Calories = Aubergine.Calories;
            listVegetable[7].Color = Aubergine.Color;
            listVegetable[7].Weight = Aubergine.Weight;


            Console.WriteLine("Type the number of ingredients");
            string Nofingredients = Console.ReadLine();
            int NumberOfIngredients = int.Parse(Nofingredients);
            var salad = new List<Vegetable>();
            for (int n = 0; n < NumberOfIngredients; n++)
            {
                randomnumber = Rnd();
                salad.Add(listVegetable[randomnumber]);
            }
            Console.WriteLine("\nYour salad is:");
            for (int s = 0; s < salad.Count; s++)
            {
                Console.Write(salad[s].Name + ", ");
            }
            Console.WriteLine("\nSorting by weight");
            salad.Sort(new VegWeightCompare());
            for (int w = 0; w < salad.Count; w++)
            {
                Console.WriteLine("{0} {1}g", salad[w].Name, salad[w].Weight);
            }
            Console.WriteLine("\nSorting by name");
            salad.Sort();
            salad.ForEach(salad => Console.WriteLine(salad.Name));

            Console.WriteLine("\nSorting by color");
            salad.Sort(new VegColorCompare());
            for (int w = 0; w < salad.Count; w++)
            {
                Console.WriteLine("{0} is {1}", salad[w].Name, salad[w].Color);
            }
            Console.WriteLine("\nSorting by calories");
            salad.Sort(new VegCaloriesCompare());
            for (int w = 0; w < salad.Count; w++)
            {
                Console.WriteLine("{0} has {1} calories", salad[w].Name, salad[w].Calories);
            }
            Console.WriteLine("\nCounting calories in your salad");
            int caloriescount = 0;
            for (int w = 0; w < salad.Count; w++)
            {
                caloriescount = caloriescount + salad[w].Calories;
            }
            Console.WriteLine("\nThere are {0} calories in your salad", caloriescount);
            Console.WriteLine("\nType the minimal search value for calories");
            string minimalcaloriesstring = Console.ReadLine();
            int minimalcalories = int.Parse(minimalcaloriesstring);
            Console.WriteLine("\nType the maximum search value for calories");
            string maximumcaloriesstring = Console.ReadLine();
            int maximumcalories = int.Parse(maximumcaloriesstring);
            for (int m = 0; m < salad.Count; m++)
            {
                if (salad[m].Calories >= minimalcalories && salad[m].Calories <= maximumcalories)
                {
                    Console.Write ("\n{0} is {1} calories", salad[m].Name, salad[m].Calories);
                }
            }
            Console.WriteLine("\nPress any button to start again");
            Console.ReadKey();
            Hello(ref randomnumber);
        }
    }
}
