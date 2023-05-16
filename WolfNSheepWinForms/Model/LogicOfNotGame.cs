using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfNSheepWinForms.View;

namespace WolfNSheepWinForms.Model
{
    internal class LogicOfNotGame : IModel
    {
        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated = delegate { };

        public event EventHandler<ModelMapIsNotFilledEnoughEventArgs> ModelIsNotFilledEnough = delegate { };

        private List<Sheep> _sheep;

        private List<Wolf> _wolves;

        int _minimal_amount_of_sheep;
        int _minimal_amount_of_wolves;

        private int[,] _field = null;

        public void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _field = e.Field;

            _sheep = new List<Sheep>();
            _wolves = new List<Wolf>();

            _minimal_amount_of_sheep = Convert.ToInt32(0.05 * _field.Length);
            _minimal_amount_of_wolves = Convert.ToInt32(0.015 * _field.Length);

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs { });
        }

        public void InitFieldStates()
        {
        }

        public void Update(object sender, ViewUpdatedEventArgs e)
        {
            string direction = e.Direction;

            if (direction != null)
            {
                //if (_w != null)
                //{
                //    _w.Move(_field, direction);
                //    direction = null;
                //    if (!_w.Eat(_field, _sheep))
                //    {
                //        _w = null;
                //    }
                //}
                foreach (var s in _sheep)
                {
                    s.Move(_field);
                }

            }

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs { });
        }
    }
}
