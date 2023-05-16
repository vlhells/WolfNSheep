using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfNSheepWinForms.View;

namespace WolfNSheepWinForms.Model
{
    internal class Game : IModel
    {
        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated = delegate { };

        private List<Sheep> _sheep;

        private Wolf _w;

        private int[,] _field;

        public void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _sheep = new List<Sheep>();

            _field = e.Field;

            int amount_of_sheep = Convert.ToInt32(0.06 * _field.Length);

            for (int s = 0; s <= amount_of_sheep; s++)
            {
                _sheep.Add(new Sheep(_field));
            }
            _w = new Wolf(_field);

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs { });
        }

        public void Update(object sender, ViewUpdatedEventArgs e)
        {
            string direction = e.Direction;
            
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
