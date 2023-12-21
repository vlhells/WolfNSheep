using WolfNSheepWinForms.Model;
using WolfNSheepWinForms.View;
using WolvesAndSheep.Interfaces;
using WolvesAndSheep.View;
using WolvesAndSheep.Views.View;

namespace WolfNSheepWinForms
{
    public partial class FrmFirst : Form
    {
        Presenter p = null;

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
