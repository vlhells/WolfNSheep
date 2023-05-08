namespace WolfNSheepWinForms
{
    public partial class FrmView : Form, IView
    {
        private static int[,] _field;
        private static string _direction;

        public event EventHandler<ViewGotSizesEventArgs> ViewGotSizes = delegate { };
        public event EventHandler<ViewUpdatedEventArgs> ViewUpdated = delegate { };

        public FrmView()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            _field = new int[int.Parse(TbxXSize.Text), int.Parse(TbxYSize.Text)];
            ViewGotSizes.Invoke(this, new ViewGotSizesEventArgs(_field));
            MessageBox.Show("Управление осуществляется кнопками AWSD.", "Уведомление", MessageBoxButtons.OK);
        }

        private void Update(object sender, PaintEventArgs e)
        {
            if (_field != null)
            {
                int scale_of_one = 20;

                Bitmap bmp = new Bitmap(_field.GetLength(0) * scale_of_one, _field.GetLength(1) * scale_of_one);
                PbxFieldDraw.Size = new Size(bmp.Width, bmp.Height);
                PbxFieldDraw.Image = bmp;
                Graphics g = Graphics.FromImage(PbxFieldDraw.Image);
                g.Clear(Color.White);

                //Graphics g = e.Graphics;

                SolidBrush sb = new SolidBrush(Color.Blue);
                Pen p = new Pen(Color.Black, 1.0f);

                int dx = 0;
                int dy = 0;

                for (int x = 0; x < _field.GetLength(0); x++)
                {
                    for (int y = 0; y < _field.GetLength(1); y++)
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

                        g.FillRectangle(sb, dx, dy, scale_of_one, scale_of_one);
                        g.DrawRectangle(p, dx, dy, scale_of_one, scale_of_one);
                        dx += scale_of_one;
                    }
                    dy += scale_of_one;
                    dx = 0;
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
            //DirectionSelected.Invoke(this, new EventArgs());
        }

    }
}