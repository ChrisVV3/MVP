using MVP.AppController;
using MVP.DomainModel;
using MVP.Views;

namespace MVP.Presenters
{
    public class AddPresenter : BasePresenter<IAddView, IModel>
    {
        public AddPresenter(IAddView view, IModel model, ApplicationController controller)
            : base(view, model, controller)
        {
            _view.Add += () => Add(_view.website);
        }
        private void Add(Website website)
        {
            _model.Insert(website);
            _view.Close();
        }
    }
}
