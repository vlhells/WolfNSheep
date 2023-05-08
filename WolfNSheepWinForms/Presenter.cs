using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfNSheepWinForms
{
    internal class Presenter
    {
        private IView _frmView = null;
        private Model _model = null;
        
        public Presenter(IView frmView, Model model)
        {
            _frmView = frmView;
            _model = model;

            _frmView.ViewGotSizes += ModelInitField;
            //_model.ModelInitialized += ModelViewUpdate;
            _model.ModelUpdated += ModelViewUpdate;
            _frmView.ViewUpdated += ViewModelUpdate;
        }

        private void ModelViewUpdate(object sender, ModelUpdatedEventArgs e)
        {
            _frmView.Update();
        }

        public IView ShowView()
        {
            return _frmView;
        }

        private void ModelInitField(object sender, ViewGotSizesEventArgs e)
        {
            _model.InitField(this, e);
        }

        private void ViewModelUpdate(object sender, ViewUpdatedEventArgs e)
        {
            _model.Update(e.Direction);
        }
    }
}
