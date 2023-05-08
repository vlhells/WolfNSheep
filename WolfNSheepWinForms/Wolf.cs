using System;
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

        public Wolf(int[,] area) : base(area)
        {

        }

        public bool Eat(int[,] area, List<Sheep> sheep)
        {
            unsuccessful_avada_kedavra = rnd.Next(0, 2);

            for (int i = _x - 1; i <= _x + 1; i++)
            {
                for (int j = _y - 1; j <= _y + 1; j++)
                {
                    if (i == _x && j == _y)
                        continue;

                    if (i >= 0 && j >= 0 && i < area.GetLength(0) && j < area.GetLength(1))
                    {
                        if (area[i, j] == 2)
                        {
                            if (unsuccessful_avada_kedavra == 1)
                            {
                                area[_x, _y] = 0;
                                return false;
                            }

                            for (int s = 0; s < sheep.Count; s++)
                            {
                                if (sheep[s].X == i && sheep[s].Y == j)
                                {
                                    sheep.RemoveAt(s);
                                    area[i, j] = 0;
                                }
                            }
                        }

                    }
                }
            }

            return true;
        }

        public void Move(int[,] area, string direction)
        {
            area[_x, _y] = 0;

            switch (direction)
            {
                case "W":
                    if (_x - 1 >= 0 && area[_x - 1, _y] == 0)
                        _x -= 1;
                    break;

                case "A":
                    if (_y - 1 >= 0 && area[_x, _y - 1] == 0)
                        _y -= 1;
                    break;

                case "S":
                    if (_x + 1 < area.GetLength(0) && area[_x + 1, _y] == 0)
                        _x += 1;
                    break;

                case "D":
                    if (_y + 1 < area.GetLength(0) && area[_x, _y - 1] == 0)
                        _y += 1;
                    break;
            }

            area[_x, _y] = Sprite;
        }
    }
}
