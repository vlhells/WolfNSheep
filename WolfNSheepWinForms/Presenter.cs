using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfNSheepWinForms.Model;
using WolfNSheepWinForms.View;

namespace WolfNSheepWinForms
{
    internal class Presenter
    {
        private IView _frmView = null;
        private IModel _model = null;
        
        internal Presenter(IView frmView, IModel model)
        {
            _frmView = frmView;
            _model = model;

            _frmView.ViewGotSizes += ModelInitField;
            _frmView.ViewCellClicked += ModelInitFieldStates;

            _model.ModelUpdated += ModelViewUpdate;
            _frmView.ViewUpdated += ViewModelUpdate;
        }

        private void ModelViewUpdate(object sender, ModelUpdatedEventArgs e)
        {
            _frmView.Update(sender, e);
        }

        private void ModelInitFieldStates(object sender, ViewClickedCellEventArgs e)
        {
            _model.InitFieldStates(this, e);
        }

        internal IView ShowView()
        {
            return _frmView;
        }

        private void ModelInitField(object sender, ViewGotSizesEventArgs e)
        {
            _model.InitField(this, e);
        }

        private void ViewModelUpdate(object sender, ViewUpdatedEventArgs e)
        {
            _model.Update(this, e);
        }
    }
}
