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
                int scale = 20;

                Bitmap bmp = new Bitmap(1600, 400);
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
                                sb = new SolidBrush(Color.Gray);
                                break;

                            case 1:
                                sb = new SolidBrush(Color.Red);
                                break;

                            case 2:
                                sb = new SolidBrush(Color.Green);
                                break;
                        }

                        g.DrawRectangle(p, dx, dy, scale, scale);
                        dx += scale;
                    }
                    dy += scale;
                    dx = 0;
                }
                ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            _direction = "A";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
            //DirectionSelected.Invoke(this, new EventArgs());
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            _direction = "W";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            _direction = "S";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            _direction = "D";
            ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
        }
    }
}