﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms
{
    internal class Wolf : Animal, IPredator
    {
        private int unsuccessful_avada_kedavra = 0;

        private protected override int Sprite => 1;

        public Wolf(int[,] field) : base(field)
        {

        }

        public bool Eat(int[,] field, List<Sheep> sheep)
        {
            unsuccessful_avada_kedavra = rnd.Next(0, 2);

            for (int i = _x - 1; i <= _x + 1; i++)
            {
                for (int j = _y - 1; j <= _y + 1; j++)
                {
                    if (i == _x && j == _y)
                        continue;

                    if (i >= 0 && j >= 0 && i < field.GetLength(0) && j < field.GetLength(1))
                    {
                        if (field[i, j] == 2)
                        {
                            if (unsuccessful_avada_kedavra == 1)
                            {
                                field[_x, _y] = 0;
                                return false;
                            }

                            for (int s = 0; s < sheep.Count; s++)
                            {
                                if (sheep[s].X == i && sheep[s].Y == j)
                                {
                                    sheep.RemoveAt(s);
                                    field[i, j] = 0;
                                }
                            }
                        }

                    }
                }
            }

            return true;
        }

        public void Move(int[,] field, string direction)
        {
            field[_x, _y] = 0;

            switch (direction)
            {
                case "A":
                    if (_x - 1 >= 0 && field[_x - 1, _y] == 0)
                        _x -= 1;
                    break;

                case "W":
                    if (_y - 1 >= 0 && field[_x, _y - 1] == 0)
                        _y -= 1;
                    break;

                case "D":
                    if (_x + 1 < field.GetLength(0) && field[_x + 1, _y] == 0)
                        _x += 1;
                    break;

                case "S":
                    if (_y + 1 < field.GetLength(1) && field[_x, _y - 1] == 0)
                        _y += 1;
                    break;
            }

            field[_x, _y] = Sprite;
        }
    }
}
