using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_01_07_20
{
    class Apple : Fruit
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;
        public string _color;
        public override bool IsThisMyFavorite()
        {
            return true;
        }
    }
}
