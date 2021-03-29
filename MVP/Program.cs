using LightInject;
using MVP.AppController;
using MVP.DomainModel;
using MVP.Presenters;
using MVP.Views;
using System;
using System.Windows.Forms;

namespace MVP
{
    static class Program
    {
        public static readonly ApplicationContext context = new ApplicationContext();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceContainer container = new ServiceContainer();
            container.RegisterInstance<ApplicationContext>(context);
            container.Register<IModel, Model>();
            container.Register<IMainView, MainForm>();
            container.Register<IAddView, AddForm>();
            container.Register<IChangeView, ChangeForm>();
            
            ApplicationController controller = new ApplicationController(container);
            controller.Run<MainPresenter>();
        }
    }
}
