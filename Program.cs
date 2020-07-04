using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_01_07_20
{
    class Program
    {
        static string appleColor(Apple a)
        {
            return a._color;
        }

        static int bananaSize(Banana b)
        {
            return b._size;
        }
        static int GetTotalCalories(FruitSalad c)
        {
            int sumOfCalories = 0;
            for (int i = 0; i < c.fruits.Length; i++)
            {
                sumOfCalories = sumOfCalories + c.fruits[i]._calories;
            }
            return sumOfCalories;

        }
        public static bool ContainMyFavoriteFruit(FruitSalad e)
        {
            for (int i = 0; i <  e.fruits.Length; i++)
            {
                if (e.fruits[i].IsThisMyFavorite())
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {

            Banana b = new Banana()
            {
                _calories = 100,
                _color = "Yellow",
                _name = "Banana",
                _pinkLady = true,
                _size = 2,
            };

            Apple a = new Apple()
            {
                _calories=200,
                _hasBlackSpots = false,
                _isGreen = true,
                _name = "Apple",
                _size = 5,
                _color = "Red",
                                            
            };
            

           
            Orange c = new Orange()
            {
                _calories = 300,
            _name = "Orange",
            _color = "Orange",
            };

            Grapes d = new Grapes()
            {
                _calories = 400,
                _name = "Orange",
                _color = "Orange",
            };
           

            Fruit[] x = { a, b, c, d };
            FruitSalad MIX = new FruitSalad();
            MIX.fruits = x;
            Console.WriteLine($"Total Calories In Salad: {MIX.GetTotalCalories()}");
            //Console.WriteLine($" Is Continas Favorite Fruite {MIX.ContainMyFavoriteFruit()}");
            Console.WriteLine($"The Apple Color Is: {appleColor(a)}");
            Console.WriteLine($"The Banana Size Is: {bananaSize(b)} Hinch");
            Console.WriteLine($"The Sum Of Friute Slald Calories is: {GetTotalCalories(MIX)}");
          // Console.WriteLine($" The Salad Contain My FaVorite Fruit? {ContainMyFavoriteFruit(MIX)})");

           if (ContainMyFavoriteFruit(MIX) == true)


             //   Console.WriteLine($"{The Salad Contain My Favorite Fruit}");
               Console.WriteLine("The salad contain ny favorite fruit");
           else

                // Console.WriteLine($"{The Salad Dosent Contain My Favorite Fruit}");
               Console.WriteLine("The Salad Dosen't Contain My Favorite Fruit");

            



        }

        
    }
}
