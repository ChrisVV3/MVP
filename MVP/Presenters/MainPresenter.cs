using MVP.AppController;
using MVP.DomainModel;
using MVP.Views;

namespace MVP.Presenters
{
    public class MainPresenter : BasePresenter<IMainView,IModel>
    {
        public MainPresenter(IMainView view, IModel model, ApplicationController controller)
            : base(view, model, controller)
        {
            _view.SetData += Select;
            _view.Delete += () => Delete(_view.id);
            _view.Insert += Insert;
            _view.Change += Change;
        }
        private void Select()
        {
            _view.websites = _model.Select();
        }
        private void Delete(int id)
        {
            _model.Delete(id);
        }
        private void Insert()
        {
            _controller.Run<AddPresenter>();
        }
        private void Change()
        {
            _controller.Run<ChangePresenter>();
        }
    }
}
