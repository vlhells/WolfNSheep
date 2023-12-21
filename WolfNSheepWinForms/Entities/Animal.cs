namespace WolvesAndSheep.Entities
{
    internal abstract class Animal
    {
        private protected Random _rnd = new Random();
        private protected int _x;
        private protected int _y;
        private protected virtual int Sprite { get; }

        private protected Animal(int[,] field)
        {
            Born(field);
        }

        private protected Animal(int x, int y)
        {
            _x = x;
            _y = y;
        }

		/// <summary>
		/// Generate coords and fill Sprite for create an instance of Animal.
		/// </summary>
		private void Born(int[,] field)
        {
            do
            {
                _x = _rnd.Next(0, field.GetLength(0));
                _y = _rnd.Next(0, field.GetLength(1));
            }
            while (field[_x, _y] != 0);

            field[_x, _y] = Sprite;
        }

		/// <summary>
		/// Checks if position in array (x;y) is free.
		/// </summary>
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
