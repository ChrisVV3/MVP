using LightInject;
using MVP.Presenters;

namespace MVP.AppController
{
    // Ioc container : LightInject
    // This class contains a container that can receive an object via an interface
    public class ApplicationController
    {
        private readonly ServiceContainer _container;
        public ApplicationController(ServiceContainer container)
        {
            _container = container;
            _container.RegisterInstance<ApplicationController>(this);
        }
        public void Run<TPresenter>()
            where TPresenter : class, IPresenter
        {
            if (!_container.CanGetInstance(typeof(TPresenter), string.Empty))
                _container.Register<TPresenter>();
            var presenter = _container.GetInstance<TPresenter>();
            presenter.Run();
        }
    }
}
