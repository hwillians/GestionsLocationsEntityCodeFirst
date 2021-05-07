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
            unityContainer.RegisterType<IClientRepository, ClientRepository>();
            unityContainer.RegisterType<ILocationRepository, LocationRepository>();

            var clientController = unityContainer.Resolve<ClientController>();
            var locationController = unityContainer.Resolve<LocationController>();

            Menu.Deployer(clientController, locationController);
        }
    }
}
