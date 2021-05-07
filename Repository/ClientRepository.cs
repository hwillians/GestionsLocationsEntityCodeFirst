using Models;
using Repository.Contracts;
using System.Collections.Generic;

namespace Repository
{
    public class ClientRepository : IClientRepository
    {
        private static LocationEntitys context = new LocationEntitys();

        public Client CreateClient(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
            return client;
        }

        public Client GetClientById(int id)=> context.Clients.Find(id);

        public List<Client> GetClients()=> new List<Client>(context.Clients);
        
        public void UpdateClient(Client client)
        {
            Client clt = context.Clients.Find(client.Id);
            
            clt.Nom = client.Nom;
            clt.Prenom = client.Prenom;
            clt.DateNaissance = client.DateNaissance;
            clt.Adresse = client.Adresse;
            clt.CodePostal = client.CodePostal;
            clt.Ville = client.Ville;

           context.SaveChanges();
        }
    }
}
