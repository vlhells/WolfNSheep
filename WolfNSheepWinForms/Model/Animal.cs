using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms.Model
{
    internal abstract class Animal
    {
        private protected static Random rnd = new Random();
        private protected int _x;
        private protected int _y;
        private protected virtual int Sprite { get; }

        private protected Animal(int[,] field)
        {
            Born(field);
        }

        private void Born(int[,] field)
        {
            do
            {
                _x = rnd.Next(0, field.GetLength(0));
                _y = rnd.Next(0, field.GetLength(1));
            }
            while (field[_x, _y] != 0);

            field[_x, _y] = Sprite;
        }

        private protected bool IsSomeoneThere(int[,] field, int x, int y)
        {
            if (x >= 0 && y >= 0 && x < field.GetLength(0) && y < field.GetLength(1) && field[x, y] == 0)
            {
                return false;
            }

            return true;
        }
    }
}
