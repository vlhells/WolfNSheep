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
        public (int needable_wolves, int needable_sheep) Needables { get; set; }

        public ModelMapIsNotFilledEnoughEventArgs((int needable_wolves, int needable_sheep) needables)
        {
            if (needables.needable_wolves < 0)
                needables.needable_wolves = 0;
            if (needables.needable_sheep < 0)
                needables.needable_sheep = 0;

            Needables = needables;
        }
    }

    public interface IModel
    {
        public void InitField(object sender, ViewGotSizesEventArgs e);
        public void Update(object sender, ViewUpdatedEventArgs e);
        public void InitFieldStates(object sender, ViewClickedCellEventArgs e);

        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated;
        public event EventHandler<ModelMapIsNotFilledEnoughEventArgs> ModelMapIsNotFilledEnough;
    }
}
