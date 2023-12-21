using WolvesAndSheep.Interfaces;

namespace WolvesAndSheep.Views.View
{
    public class ViewClickedCellEventArgs : EventArgs
    {
        public (int x, int y, MouseButtons mouseButton) ClickedCell { get; set; }

        public ViewClickedCellEventArgs((int x, int y, MouseButtons mouseButton) clickedCell)
        {
            ClickedCell = clickedCell;
        }
    }

    public class ViewGotSizesEventArgs : EventArgs
    {
        public int[,] Field { get; set; }

        public ViewGotSizesEventArgs(int[,] field)
        {
            Field = field;
        }
    }

    public class ViewUpdatedEventArgs : EventArgs
    {
        public string Direction { get; set; }
        public ViewUpdatedEventArgs(string direction)
        {
            Direction = direction;
        }
    }

    public interface IView
    {
        public void DrawField(object sender, PaintEventArgs e);
        public void Update(object sender, ModelUpdatedEventArgs e);
        public void SayThatMapIsNotFilledEnough(object sender, ModelMapIsNotFilledEnoughEventArgs e);

        public event EventHandler<ViewGotSizesEventArgs> ViewGotSizes;

        public event EventHandler<ViewUpdatedEventArgs> ViewUpdated;

        public event EventHandler<ViewClickedCellEventArgs> ViewCellClicked;
    }
}
