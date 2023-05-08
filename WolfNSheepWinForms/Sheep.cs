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

        public Sheep(int[,] field) : base(field)
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

        public void Move(int[,] field)
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
