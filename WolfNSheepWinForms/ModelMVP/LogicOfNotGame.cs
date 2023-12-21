using WolvesAndSheep.Entities;
using WolvesAndSheep.Interfaces;
using WolvesAndSheep.Views.View;

namespace WolfNSheepWinForms.Model
{
    internal class LogicOfNotGame : IModel
    {
        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated = delegate { };

        public event EventHandler<ModelMapIsNotFilledEnoughEventArgs> ModelMapIsNotFilledEnough = delegate { };

        private List<Sheep> _sheep = null;

        private List<Wolf> _wolves = null;

        int _minimalAmountOfSheep = 0;
        int _minimalAmountOfWolves = 0;

        private int[,] _field = null;

        public void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _field = e.Field;

            _sheep = new List<Sheep>();
            _wolves = new List<Wolf>();

			_minimalAmountOfSheep = Convert.ToInt32(0.05 * _field.Length);
			_minimalAmountOfWolves = Convert.ToInt32(0.015 * _field.Length);
            if (_minimalAmountOfWolves == 0)
				_minimalAmountOfWolves = 1;
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
            if (_wolves.Count < _minimalAmountOfWolves ||
                _sheep.Count < _minimalAmountOfSheep)
            {
                ModelMapIsNotFilledEnough.Invoke(sender, new ModelMapIsNotFilledEnoughEventArgs(
                    (_minimalAmountOfWolves - _wolves.Count, _minimalAmountOfSheep - _sheep.Count)));
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
