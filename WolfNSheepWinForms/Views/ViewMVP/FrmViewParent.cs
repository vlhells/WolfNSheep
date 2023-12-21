using WolvesAndSheep.Interfaces;
using WolvesAndSheep.Views.View;

namespace WolfNSheepWinForms
{
    public partial class FrmViewParent : Form, IView
    {
        private protected int[,] _field = null;

        public virtual event EventHandler<ViewGotSizesEventArgs> ViewGotSizes = delegate { };
        public virtual event EventHandler<ViewUpdatedEventArgs> ViewUpdated = delegate { };
        public virtual event EventHandler<ViewClickedCellEventArgs> ViewCellClicked = delegate { };

        internal FrmViewParent()
        {
            InitializeComponent();
        }

        public void SayThatMapIsNotFilledEnough(object sender, ModelMapIsNotFilledEnoughEventArgs e)
        {
            this.Hide();
            MessageBox.Show(this, 
                $"Карта заполнена недостаточно.\nНужно ещё:\n{e.RequiredAnimalsCount.requiredWolvesCount} волков\n{e.RequiredAnimalsCount.requiredSheepCount} овец", 
                "Уведомление",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Show();
        }

        public virtual void Update(object sender, ModelUpdatedEventArgs e)
        {
            PbxFieldDraw.Refresh();
        }

        private protected virtual void BtnInitField_Click(object sender, EventArgs e)
        {
            int xSize = 0;
            int ySize = 0;

            if (int.TryParse(TbxXSize.Text, out xSize) && int.TryParse(TbxYSize.Text, out ySize) && xSize > 0 && ySize > 0)
            {
                _field = new int[xSize, ySize];

                if (xSize > 300 || ySize > 150)
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
                float scaleOfOneX = PbxFieldDraw.Size.Width / _field.GetLength(0);
                float scaleOfOneY = PbxFieldDraw.Size.Height / _field.GetLength(1);

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

                        g.FillRectangle(sb, dx, dy, scaleOfOneX, scaleOfOneY);
                        g.DrawRectangle(p, dx, dy, scaleOfOneX, scaleOfOneY);
                        dx += scaleOfOneX;
                    }
                    dx = 0;
                    dy += scaleOfOneY;
                }
                PbxFieldDraw.Refresh();
            }
        }

		private protected virtual void BtnStart_Click(object sender, EventArgs e)
		{
			
		}
	}
}