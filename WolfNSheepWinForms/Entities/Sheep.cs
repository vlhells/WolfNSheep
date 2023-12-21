namespace WolvesAndSheep.Entities
{
    internal class Sheep : Animal
    {
        internal int X => _x;
        internal int Y => _y;

        private protected override int Sprite => 2;

        internal Sheep(int[,] field) : base(field)
        {

        }

        internal Sheep(int x, int y) : base(x, y)
        {

        }

		/// <summary>
		/// Performs primary movement (can be canceled if new point is not free). Uses in Move method.
		/// </summary>
		private void PreMove(out int x, out int y)
        {
            x = _x;
            y = _y;

            int vector = _rnd.Next(0, 4);
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

		/// <summary>
		/// Move sheep in map (array).
		/// </summary>
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
