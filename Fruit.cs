using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_01_07_20
{
    abstract class Fruit
    {
        public string _name;
        public int _calories;
        //public bool _favorite;

        public abstract bool IsThisMyFavorite();
        
        

        public override string ToString()
        {
            return $"{base.ToString()} {_name} {_calories}";
        }
    }
}
