using MVP.AppController;
using MVP.DomainModel;
using MVP.Views;

namespace MVP.Presenters
{
    public abstract class BasePresenter<TView, TModel> : IPresenter
        where TView : IView
        where TModel : IModel
    {
        protected TView _view { get; private set; }
        protected TModel _model { get; private set; }
        protected ApplicationController _controller {get; private set;}
        public BasePresenter(TView view, TModel model, ApplicationController contoller)
        {
            _view = view;
            _model = model;
            _controller = contoller;
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
