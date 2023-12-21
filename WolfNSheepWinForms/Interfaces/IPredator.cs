using WolvesAndSheep.Entities;

namespace WolvesAndSheep.Interfaces
{
    internal interface IPredator
    {
		/// <summary>
		/// Predator eats sheep. 
		/// </summary>
		public bool Eat(int[,] field, List<Sheep> sheep);
    }
}
