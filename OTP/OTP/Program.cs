using OTP.Repositories;
using OTP.Repositories.Implementations;
using Unity;
using Unity.Lifetime;
using OTP.Forms;

namespace OTP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<Form1>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IMaterialRepository, MaterialRepository>(new TransientLifetimeManager());
            container.RegisterType<IProductRepository, ProductRepository>(new TransientLifetimeManager());
            container.RegisterType<IWarehouseRepository, WarehouseRepository>(new TransientLifetimeManager());
            container.RegisterType<IProductionIssueRepository, ProductionIssueRepository>(new TransientLifetimeManager());
            container.RegisterType<IDefectReturnRepository, DefectReturnRepository>(new TransientLifetimeManager());
            container.RegisterType<IPurchaseRequestRepository, PurchaseRequestRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}