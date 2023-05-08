using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms
{
    internal abstract class Animal
    {
        private protected static Random rnd = new Random();
        private protected int _x;
        private protected int _y;
        private protected virtual int Sprite { get; }

        public Animal(int[,] area)
        {
            Born(area);
        }

        public void Born(int[,] area)
        {
            do
            {
                _x = rnd.Next(0, area.GetLength(0));
                _y = rnd.Next(0, area.GetLength(1));
            }
            while (area[_x, _y] != 0);

            area[_x, _y] = Sprite;
        }

        private protected bool IsSomeoneThere(int[,] area, int x, int y)
        {
            if (x >= 0 && y >= 0 && x < area.GetLength(0) && y < area.GetLength(1) && area[x, y] == 0)
            {
                return false;
            }

            return true;
        }
    }
}
