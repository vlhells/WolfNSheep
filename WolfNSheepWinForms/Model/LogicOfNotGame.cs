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
        public event EventHandler ModelFieldInitialized = delegate { };

        private List<Sheep> _sheep;

        private List<Wolf> _wolves;

        int _minimal_amount_of_sheep;
        int _minimal_amount_of_wolves;

        private int[,] _field = null;

        public void Initialize(object sender, ViewGotSizesEventArgs e)
        {
            InitField(sender, e);

        }

        public void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _field = e.Field;

            _sheep = new List<Sheep>();
            _wolves = new List<Wolf>();

            _minimal_amount_of_sheep = Convert.ToInt32(0.05 * _field.Length);
            _minimal_amount_of_wolves = Convert.ToInt32(0.015 * _field.Length);

            ModelFieldInitialized.Invoke(this, new EventArgs());
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
                //ModelUpdated.Invoke(this, new ModelUpdatedEventArgs());
            }
        }

        public void Update(object sender, ViewUpdatedEventArgs e)
        {
            if (_wolves.Count != 0)
            {
                for (int w = 0; w < _wolves.Count; w++)
                {
                    _wolves[w].Move(_field);
                    if (!_wolves[w].Eat(_field, _sheep))
                    {
                        _wolves.Remove(_wolves[w]);
                    }
                }
            }

            if (_sheep.Count != 0)
            {
                foreach (var s in _sheep)
                {
                    s.Move(_field);
                }
            }

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs());
        }
    }
}
