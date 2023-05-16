using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfNSheepWinForms.View;

namespace WolfNSheepWinForms.Model
{
    public class ModelUpdatedEventArgs
    {

    }

    public class ModelMapIsNotFilledEnoughEventArgs
    {

    }

    public interface IModel
    {
        public void InitField(object sender, ViewGotSizesEventArgs e);
        public void Update(object sender, ViewUpdatedEventArgs e);

        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated;
    }
}
