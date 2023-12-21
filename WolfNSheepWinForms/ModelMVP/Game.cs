using WolvesAndSheep.Entities;
using WolvesAndSheep.Interfaces;
using WolvesAndSheep.Views.View;

namespace WolfNSheepWinForms.Model
{
    internal class Game : IModel
    {
        public event EventHandler ModelFieldInitialized = delegate { };
        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated = delegate { };
        public event EventHandler<ModelMapIsNotFilledEnoughEventArgs> ModelMapIsNotFilledEnough = delegate { };

        private List<Sheep> _sheep = null;

        private Wolf _w = null;

        private int[,] _field = null;

        public void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _field = e.Field;

            ModelFieldInitialized.Invoke(this, new EventArgs());
        }

        public void InitFieldStates(object sender, ViewClickedCellEventArgs e)
        {
            _sheep = new List<Sheep>();

            int amount_of_sheep = Convert.ToInt32(0.06 * _field.Length);

            for (int s = 0; s <= amount_of_sheep; s++)
            {
                _sheep.Add(new Sheep(_field));
            }
            _w = new Wolf(_field);

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs());
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
