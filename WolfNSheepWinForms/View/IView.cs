using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms.View
{
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

    internal interface IView
    {
        public abstract void Update();

        public event EventHandler<ViewGotSizesEventArgs> ViewGotSizes;

        public event EventHandler<ViewUpdatedEventArgs> ViewUpdated;
    }
}
