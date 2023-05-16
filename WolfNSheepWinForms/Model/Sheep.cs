using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms.Model
{
    internal class Sheep : Animal
    {
        internal int X => _x;
        internal int Y => _y;

        private protected override int Sprite => 2;

        internal Sheep(int[,] field) : base(field)
        {

        }

        internal Sheep(int x, int y): base(x, y)
        {

        }

        private void PreMove(out int x, out int y)
        {
            x = _x;
            y = _y;

            int vector = rnd.Next(0, 4);
            switch (vector)
            {
                case 0:
                    x += 1;
                    break;

                case 1:
                    y += 1;
                    break;

                case 2:
                    x -= 1;
                    break;

                case 3:
                    y -= 1;
                    break;
            }
        }

        internal void Move(int[,] field)
        {
            field[_x, _y] = 0;

            int x;
            int y;

            do
            {
                PreMove(out x, out y);
            }
            while (IsSomeoneThere(field, x, y));

            _x = x;
            _y = y;

            field[_x, _y] = Sprite;
        }
    }
}
