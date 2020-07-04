using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_01_07_20
{
    class FruitSalad 
    {
       public Fruit[] fruits;
        //public FruitSalad(Fruit[] fruitarry)
        //{
        //    fruits = fruitarry;
        //}
        public int GetTotalCalories()
        {
            int sumOfCalories = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                sumOfCalories = sumOfCalories + fruits[i]._calories;
            }
            return sumOfCalories;
            
        }
        public bool ContainMyFavoriteFruit()
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                if  (fruits[i].IsThisMyFavorite())
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
