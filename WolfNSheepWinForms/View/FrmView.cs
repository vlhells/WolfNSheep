using WolfNSheepWinForms.View;

namespace WolfNSheepWinForms
{
    public partial class FrmView : Form, IView
    {
        private static int[,] _field;
        private static string _direction;

        public event EventHandler<ViewGotSizesEventArgs> ViewGotSizes = delegate { };
        public event EventHandler<ViewUpdatedEventArgs> ViewUpdated = delegate { };

        internal FrmView()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            _field = new int[int.Parse(TbxXSize.Text), int.Parse(TbxYSize.Text)];
            if (_field.Length > 150 * 150 || _field.GetLength(0) < 1 || _field.GetLength(1) < 1)
            {
                MessageBox.Show("Размеры поля не могут превышать 150x150.", "Уведомление безопасности", MessageBoxButtons.OK);
                return;
                
            }
            ViewGotSizes.Invoke(this, new ViewGotSizesEventArgs(_field));
            MessageBox.Show("Управление осуществляется кнопками AWSD.", "Уведомление", MessageBoxButtons.OK);
        }

        private void Update(object sender, PaintEventArgs e)
        {
            if (_field != null)
            {
                float scale_of_one_x = PbxFieldDraw.Size.Width / _field.GetLength(0);
                float scale_of_one_y = PbxFieldDraw.Size.Height / _field.GetLength(1);

                Bitmap bmp = new Bitmap(PbxFieldDraw.Width, PbxFieldDraw.Height);
                //PbxFieldDraw.Size = new Size(bmp.Width, bmp.Height);
                PbxFieldDraw.Image = bmp;
                Graphics g = Graphics.FromImage(PbxFieldDraw.Image);
                g.Clear(Color.White);

                //Graphics g = e.Graphics;

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
                ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
            }
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            _direction = "W";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
            _direction = null;
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            _direction = "S";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
            _direction = null;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            _direction = "D";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
            _direction = null;
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            _direction = "A";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
            _direction = null;
        }

    }
}