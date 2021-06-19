using System;
using System.Windows.Forms;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using SorguNet.Business.Abstract;
using SorguNet.Business.Concrete;
using SorguNet.DataAccess.Abstract;
using SorguNet.DataAccess.Concrete;
using SorguNet.Entities;

namespace SorguNet
{
    static class Program
    {
        public static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = Configure();

            Application.Run(container.GetInstance<LoginForm>());
        }

        static Container Configure()
        {
            container = new Container();

            container.Register<IUserRepository,UserRepository>();
            container.Register<IUserManager, UserManager>();
            container.Register<ICustomerManager, CustomerManager>();
            container.Register<ICustomerRepository, CustomerRepository>();
            container.Register<IBankManager, BankManager>();
            container.Register<IBankRepository, BankRepository>();
            container.Register<IIcraManager, IcraManager>();
            container.Register<IIcraRepository, IcraRepository>();

            AutoRegisterWindowsForms(container);
            container.Verify();

            return container;
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }
    }
}
