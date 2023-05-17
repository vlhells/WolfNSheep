﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolfNSheepWinForms;
using WolfNSheepWinForms.View;

namespace WolvesAndSheep.View
{
    public partial class FrmViewGame : FrmViewParent
    {
        public override event EventHandler<ViewClickedCellEventArgs> ViewCellClicked = delegate { };

        public FrmViewGame()
        {
            InitializeComponent();
        }

        private string _direction;
        public override event EventHandler<ViewUpdatedEventArgs> ViewUpdated = delegate { };
        //public override event EventHandler<ViewGotSizesEventArgs> ViewGotSizes;

        private protected override void BtnStart_Click(object sender, EventArgs e)
        {
            if (_field != null)
                ViewCellClicked.Invoke(this, new ViewClickedCellEventArgs((-1, -1, new MouseButtons())));
            MessageBox.Show("Управление осуществляется кнопками AWSD.", "Уведомление", MessageBoxButtons.OK);
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            if (_field != null)
            {
                _direction = "W";
                this.ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
                _direction = null;
            }
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            if (_field != null)
            {
                _direction = "S";
                ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
                _direction = null;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            if (_field != null)
            {
                _direction = "D";
                ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
                _direction = null;
            }
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            if (_field != null)
            {
                _direction = "A";
                ViewUpdated.Invoke(this, new ViewUpdatedEventArgs(_direction));
                _direction = null;
            }
        }
    }
}
