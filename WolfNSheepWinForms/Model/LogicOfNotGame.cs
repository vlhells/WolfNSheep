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

        public event EventHandler<ModelMapIsNotFilledEnoughEventArgs> ModelMapIsNotFilledEnough = delegate { };

        private List<Sheep> _sheep = null;

        private List<Wolf> _wolves = null;

        int _minimal_amount_of_sheep = 0;
        int _minimal_amount_of_wolves = 0;

        private int[,] _field = null;

        public void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _field = e.Field;

            _sheep = new List<Sheep>();
            _wolves = new List<Wolf>();

            _minimal_amount_of_sheep = Convert.ToInt32(0.05 * _field.Length);
            _minimal_amount_of_wolves = Convert.ToInt32(0.015 * _field.Length);
            if (_minimal_amount_of_wolves == 0)
                _minimal_amount_of_wolves = 1;
        }

        public void InitFieldStates(object sender, ViewClickedCellEventArgs e)
        {
            if (e.ClickedCell.x < _field.GetLength(0) &&
                e.ClickedCell.y < _field.GetLength(1) &&
                e.ClickedCell.x >= 0 && e.ClickedCell.y >= 0 &&
                _field[e.ClickedCell.x, e.ClickedCell.y] == 0)
            {
                switch (e.ClickedCell.mouseButton)
                {
                    case MouseButtons.Left:
                        _field[e.ClickedCell.x, e.ClickedCell.y] = 1;
                        _wolves.Add(new Wolf(e.ClickedCell.x, e.ClickedCell.y));
                        break;

                    case MouseButtons.Right:
                        _field[e.ClickedCell.x, e.ClickedCell.y] = 2;
                        _sheep.Add(new Sheep(e.ClickedCell.x, e.ClickedCell.y));
                        break;

                    case MouseButtons.Middle:
                        _field[e.ClickedCell.x, e.ClickedCell.y] = 0;
                        break;
                }
            }
        }

        public void Update(object sender, ViewUpdatedEventArgs e)
        {
            if (_wolves.Count < _minimal_amount_of_wolves ||
                _sheep.Count < _minimal_amount_of_sheep)
            {
                ModelMapIsNotFilledEnough.Invoke(sender, new ModelMapIsNotFilledEnoughEventArgs(
                    (_minimal_amount_of_wolves - _wolves.Count, _minimal_amount_of_sheep - _sheep.Count)));
                return;
            }
            else if (_wolves.Count > 0 && _sheep.Count > 0)
            {
                for (int w = 0; w < _wolves.Count; w++)
                {
                    _wolves[w].Move(_field);
                    if (!_wolves[w].Eat(_field, _sheep))
                    {
                        _wolves.Remove(_wolves[w]);
                    }
                }

                foreach (var s in _sheep)
                {
                    s.Move(_field);
                }

                ModelUpdated.Invoke(this, new ModelUpdatedEventArgs());
            }
        }
    }
}
