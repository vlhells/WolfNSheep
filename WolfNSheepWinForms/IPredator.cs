using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms
{
    internal interface IPredator
    {
        public bool Eat(int[,] area, List<Sheep> sheep);
    }
}
