using MVP.AppController;
using MVP.DomainModel;
using MVP.Views;

namespace MVP.Presenters
{
    public class ChangePresenter : BasePresenter<IChangeView, IModel>
    {
        public ChangePresenter(IChangeView view, IModel model, ApplicationController controller)
            : base(view, model, controller)
        {
            _view.Change += () => Change(_view.id, _view.site, _view.url, _view.gap);
        }
        private void Change(int id, string site, string url, int gap)
        {
            _model.Change(id, site, url, gap);
            _view.Close();
        }
    }
}
