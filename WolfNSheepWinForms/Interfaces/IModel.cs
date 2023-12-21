using WolvesAndSheep.Views.View;

namespace WolvesAndSheep.Interfaces
{
    public class ModelUpdatedEventArgs
    {

    }

    public class ModelMapIsNotFilledEnoughEventArgs
    {
        public (int requiredWolvesCount, int requiredSheepCount) RequiredAnimalsCount { get; set; }

        public ModelMapIsNotFilledEnoughEventArgs((int requiredWolvesCount, int requiredSheepCount) requiredAnimalsCount)
        {
            if (requiredAnimalsCount.requiredWolvesCount < 0)
                requiredAnimalsCount.requiredWolvesCount = 0;
            if (requiredAnimalsCount.requiredSheepCount < 0)
                requiredAnimalsCount.requiredSheepCount = 0;

            RequiredAnimalsCount = requiredAnimalsCount;
        }
    }

    public interface IModel
    {
		public void InitField(object sender, ViewGotSizesEventArgs e);
        public void Update(object sender, ViewUpdatedEventArgs e);

		/// <summary>
		/// Initialize field with concrete objects.
		/// </summary>
		public void InitFieldStates(object sender, ViewClickedCellEventArgs e);

        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated;
        public event EventHandler<ModelMapIsNotFilledEnoughEventArgs> ModelMapIsNotFilledEnough;
    }
}
