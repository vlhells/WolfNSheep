using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms
{
    internal class Sheep : Animal
    {
        public int X => _x;
        public int Y => _y;

        private protected override int Sprite => 2;

        public Sheep(int[,] area) : base(area)
        {

        }

        private void PreMove(out int x, out int y)
        {
            x = _x;
            y = _y;

            int vector = rnd.Next(1, 5);
            switch (vector)
            {
                case 1:
                    x += 1;
                    break;

                case 2:
                    y += 1;
                    break;

                case 3:
                    x -= 1;
                    break;

                case 4:
                    y -= 1;
                    break;
            }
        }

        public void Move(int[,] area)
        {
            area[_x, _y] = 0;

            int x;
            int y;

            do
            {
                PreMove(out x, out y);
            }
            while (IsSomeoneThere(area, x, y));

            _x = x;
            _y = y;

            area[_x, _y] = Sprite;
        }
    }
}
