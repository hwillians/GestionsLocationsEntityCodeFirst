using Controllers;
using Repository;
using Repository.Contracts;
using Unity;
using View;

namespace view
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<ClientController, ClientController>();
            unityContainer.RegisterType<LocationController, LocationController>();
            unityContainer.RegisterType<VehiculeController, VehiculeController>();
            unityContainer.RegisterType<IClientRepository, ClientRepository>();
            unityContainer.RegisterType<ILocationRepository, LocationRepository>();
            unityContainer.RegisterType<IVehiculeRepository, VehiculeRepository>();

            Menu.Deployer(unityContainer.Resolve<ClientController>(),
                unityContainer.Resolve<LocationController>(),
                unityContainer.Resolve<VehiculeController>());
        }
    }
}
