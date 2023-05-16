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
using WolfNSheepWinForms.View;
using WolvesAndSheep.View;

namespace WolfNSheepWinForms
{
    public partial class FrmFirst : Form
    {
        Presenter p;

        public FrmFirst()
        {
            InitializeComponent();
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            LoadSelectedForm(new FrmViewGame(), new Game());
        }

        private void LoadSelectedForm(IView view, IModel model)
        {
            p = new Presenter(view, model);
            Form f = (Form)p.ShowView();
            f.Show();
        }

        private void BtnLoadModel_Click(object sender, EventArgs e)
        {
            LoadSelectedForm(new FrmViewModel(), new LogicOfNotGame());
        }
    }
}
