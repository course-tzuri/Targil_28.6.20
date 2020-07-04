using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_01_07_20
{
    class Banana : Fruit
    {
        public string _color;
        public bool _pinkLady;
        public int _size;

        //public string _name;
        //public int _calories;

        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_color} {_pinkLady}";
        }
    }
}
