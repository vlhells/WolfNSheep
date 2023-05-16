using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms.Model
{
    internal interface IPredator
    {
        public bool Eat(int[,] field, List<Sheep> sheep);
    }
}
