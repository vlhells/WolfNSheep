using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfNSheepWinForms.Model;

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
            this.ViewUpdated.Invoke(sender, new ViewUpdatedEventArgs("aboba"));
        }

        private void PbxFieldDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (BtnStart.Enabled)
            {
                float scale_of_one_x = PbxFieldDraw.Size.Width / _field.GetLength(0);
                float scale_of_one_y = PbxFieldDraw.Size.Height / _field.GetLength(1);

                int x = e.X / (int)scale_of_one_x;
                int y = e.Y / (int)scale_of_one_y;

                ViewCellClicked.Invoke(this, new ViewClickedCellEventArgs((x, y, e.Button)));
                PbxFieldDraw.Refresh();
            }
        }

        private protected override void BtnStart_Click(object sender, EventArgs e)
        {
            if (_field != null)
                ViewUpdated.Invoke(this, new ViewUpdatedEventArgs("aboba"));
        }
    }
}
