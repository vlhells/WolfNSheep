using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfNSheepWinForms
{
    public class ModelUpdatedEventArgs
    {

    }

    //public class ModelInitializedEventArgs
    //{

    //}

    internal class Model
    {
        public event EventHandler<ModelUpdatedEventArgs> ModelUpdated = delegate { };

        //public event EventHandler<ModelInitializedEventArgs> ModelInitialized = delegate { };

        static List<Sheep> sheep = new List<Sheep>();

        static int _iteration = 0;

        static Wolf w;

        public int[,] _field;

        public void InitField(object sender, ViewGotSizesEventArgs e)
        {
            _field = e.Field;

            int amount_of_sheep = Convert.ToInt32((0.06 * _field.Length));

            for (int s = 0; s <= amount_of_sheep; s++)
            {
                sheep.Add(new Sheep(_field));
            }
            w = new Wolf(_field);
            //ModelInitialized.Invoke(this, new ModelInitializedEventArgs());
            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs { });
        }

        public void Update(string direction)
        {
            if (direction != null)
            {
                if (w != null)
                {
                    //ConsoleKey key;
                    //bool flag = false;
                    //do
                    //{
                    //    key = Console.ReadKey().Key;
                    //    if (key == ConsoleKey.A ||
                    //        key == ConsoleKey.W ||
                    //        key == ConsoleKey.S ||
                    //        key == ConsoleKey.D)
                    //        flag = true;
                    //    else
                    //        flag = false;
                    //} while (!flag);


                    w.Move(_field, direction);
                    if (!w.Eat(_field, sheep))
                    {
                        w = null;
                    }
                }
                foreach (var s in sheep)
                {
                    s.Move(_field);
                }
            }

            ModelUpdated.Invoke(this, new ModelUpdatedEventArgs { });
        }
    }
}
