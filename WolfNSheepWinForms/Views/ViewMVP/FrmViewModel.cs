using WolvesAndSheep.Interfaces;
using WolvesAndSheep.Views.View;

namespace WolfNSheepWinForms.View
{
    public partial class FrmViewModel : FrmViewParent
    {
        public override event EventHandler<ViewClickedCellEventArgs> ViewCellClicked = delegate { };
        public override event EventHandler<ViewUpdatedEventArgs> ViewUpdated = delegate { };

        public FrmViewModel()
        {
            InitializeComponent();
        }

        public override void Update(object sender, ModelUpdatedEventArgs e)
        {
            base.Update(sender, e);
            this.ViewUpdated.Invoke(sender, new ViewUpdatedEventArgs("notRequired"));
        }

        private void PbxFieldDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (BtnStart.Enabled)
            {
                float scaleOfOneX = PbxFieldDraw.Size.Width / _field.GetLength(0);
                float scaleOfOneY = PbxFieldDraw.Size.Height / _field.GetLength(1);

                int x = e.X / (int)scaleOfOneX;
                int y = e.Y / (int)scaleOfOneY;

                ViewCellClicked.Invoke(this, new ViewClickedCellEventArgs((x, y, e.Button)));
                PbxFieldDraw.Refresh();
            }
        }

        private protected override void BtnStart_Click(object sender, EventArgs e)
        {
            if (_field != null)
                ViewUpdated.Invoke(this, new ViewUpdatedEventArgs("notRequired"));
        }
    }
}
