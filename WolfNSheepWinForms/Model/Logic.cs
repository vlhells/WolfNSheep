using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfNSheepWinForms.View;

namespace WolfNSheepWinForms.Model
{
    internal class ModelUpdatedEventArgs
    {

    }

    internal class Logic
    {
        internal event EventHandler<ModelUpdatedEventArgs> ModelUpdated = delegate { };

        private static List<Sheep> _sheep = new List<Sheep>();

        private static Wolf _w;

        private int[,] _field;

        internal void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _field = e.Field;

            int amount_of_sheep = Convert.ToInt32(0.06 * _field.Length);

            for (int s = 0; s <= amount_of_sheep; s++)
            {
                _sheep.Add(new Sheep(_field));
            }
            _w = new Wolf(_field);

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs { });
        }

        internal void Update(string direction)
        {
            if (direction != null)
            {
                if (_w != null)
                {
                    _w.Move(_field, direction);
                    direction = null;
                    if (!_w.Eat(_field, _sheep))
                    {
                        _w = null;
                    }
                }
                foreach (var s in _sheep)
                {
                    s.Move(_field);
                }

            }

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs { });
        }
    }
}
