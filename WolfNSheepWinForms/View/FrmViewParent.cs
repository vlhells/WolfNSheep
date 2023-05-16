using WolfNSheepWinForms.Model;
using WolfNSheepWinForms.View;

namespace WolfNSheepWinForms
{
    public partial class FrmViewParent : Form, IView
    {
        private protected int[,] _field = null;

        public virtual event EventHandler<ViewGotSizesEventArgs> ViewGotSizes = delegate { };
        public virtual event EventHandler<ViewUpdatedEventArgs> ViewUpdated = delegate { };

        internal FrmViewParent()
        {
            InitializeComponent();
        }

        public void Update(object sender, ModelUpdatedEventArgs e)
        {
            ///
            PbxFieldDraw.Refresh();
        }

        private protected virtual void BtnStart_Click(object sender, EventArgs e)
        {
            int x_size = 0;
            int y_size = 0;

            if (int.TryParse(TbxXSize.Text, out x_size) && int.TryParse(TbxYSize.Text, out y_size) && x_size > 0 && y_size > 0)
            {
                _field = new int[x_size, y_size];

                if (x_size > 300 || y_size > 150)
                {
                    MessageBox.Show("Размеры поля не могут превышать 300x150.", "Уведомление безопасности", MessageBoxButtons.OK);
                    return;
                }
                ViewGotSizes.Invoke(this, new ViewGotSizesEventArgs(_field));
            }
            else
            {
                MessageBox.Show("Введите адекватные размеры поля.", "Уведомление", MessageBoxButtons.OK);
            }
        }

        public void DrawField(object sender, PaintEventArgs e)
        {
            if (_field != null)
            {
                //PbxFieldDraw.Size = new Size(bmp.Width, bmp.Height);
                //Graphics g = Graphics.FromImage(PbxFieldDraw.Image);

                //Graphics g = e.Graphics;

                float scale_of_one_x = PbxFieldDraw.Size.Width / _field.GetLength(0);
                float scale_of_one_y = PbxFieldDraw.Size.Height / _field.GetLength(1);

                Bitmap bmp = new Bitmap(PbxFieldDraw.Width, PbxFieldDraw.Height);
                PbxFieldDraw.Image = bmp;
                Graphics g = Graphics.FromImage(PbxFieldDraw.Image);
                g.Clear(Color.White);

                SolidBrush sb = new SolidBrush(Color.Blue);
                Pen p = new Pen(Color.Black, 1.0f);

                float dx = 0;
                float dy = 0;

                for (int y = 0; y < _field.GetLength(1); y++)
                {
                    for (int x = 0; x < _field.GetLength(0); x++)
                    {
                        switch (_field[x, y])
                        {
                            case 0:
                                sb = new SolidBrush(Color.LightGreen);
                                break;

                            case 1:
                                sb = new SolidBrush(Color.Gray);
                                break;

                            case 2:
                                sb = new SolidBrush(Color.LightGray);
                                break;
                        }

                        g.FillRectangle(sb, dx, dy, scale_of_one_x, scale_of_one_y);
                        g.DrawRectangle(p, dx, dy, scale_of_one_x, scale_of_one_y);
                        dx += scale_of_one_x;
                    }
                    dx = 0;
                    dy += scale_of_one_y;
                }
                PbxFieldDraw.Refresh();
            }
        }
    }
}