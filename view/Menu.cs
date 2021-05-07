using Controllers;
using Models;
using System;
using static System.Console;
using static View.Tools;

namespace View
{
    public static class Menu
    {
        public static void Deployer(ClientController clientController, LocationController locationController, VehiculeController vehiculeController)
        {
            int choix = -1;

            WriteLine("*** Ménu Gestion des Locations ***");

            while (choix != 0)
            {
                choix = GetIntConsole("\nQuelle action voulez vouz effectuer : " +
                "\n1.- Ajouter un Client" +
                "\n2.- Afficher la liste des Clients" +
                "\n3.- Afficher un Client" +
                "\n4.- Modifier un Client" +
                "\n5.- Ajouter un Véhicule" +
                "\n6.- Afficher la liste des Véhicules" +
                "\n7.- Afficher un Véhicule" +
                "\n8.- Modifier un Véhicule" +
                "\n9.- Ajouter une Location" +
                "\n10.- Afficher la liste des Locations" +
                "\n11.- Afficher une location" +
                "\n12.- Modifier une location" +

                "\n0.- Sortir\n");

                switch (choix)
                {
                    case 1: OptionAddClient(clientController); break;

                    case 2: Write(string.Join("\n", clientController.GetClients())); break;

                    case 3: OptionGetClientById(clientController); break;

                    case 4: OptionUdpateClient(clientController); break;

                    case 5: OptionAddVehicule(vehiculeController); break;

                    case 6: Write(string.Join("\n", vehiculeController.GetVehicules())); break;

                    case 7: OptionGetVehiculeById(vehiculeController); break;

                    case 8: OptionUdpateVehicule(vehiculeController); break;

                    case 9: OptionAddLocation(locationController); break;

                    case 10: Write(string.Join("\n", locationController.GetLocations())); break;

                    case 11: OptionGetLocationById(locationController); break;

                    case 12: OptionUdpateLocation(locationController); break;

                    case 0: WriteLine("à bientôt..."); break;

                    default: WriteLine("Action non reconnue..."); break;
                }
            }
        }

        private static void OptionUdpateLocation(LocationController locationController)
        {
            int id = GetIntConsole("Tapez l'id du véhicule : ");
            var location = locationController.GetLocationById(id);

            if (location == null) WriteLine("L'id n'existe pas en base");
            else
            {
                String propModif = "";

                while (propModif != "i" && propModif != "mod" && propModif != "cou" && propModif != "mar" && propModif
                    != "czt" && propModif != "all")
                {
                    propModif = GetStringConsole("Choisissez l'élement à modifier " +
                      "\ni : Immatriculation, mod : Modele, cou : Couleur, mar : Marque, cat : Categorie, " +
                      "all : toute les éléments ");
                }

                switch (propModif)
                {
                    case "n": location.ClientID = GetIntConsole(location.ClientID + " : "); break;
                    case "p": location.VehiculeID = GetIntConsole(location.VehiculeID + " : "); break;
                    case "d": location.NbKm = GetIntConsole(location.NbKm + " : "); break;
                    case "a": location.DateDebut = GetDateConsole(location.DateDebut + " : "); break;
                    case "c": location.DateFin = GetDateConsole(location.DateFin + " : "); break;

                    case "all":
                        WriteLine(location);
                        location = new Location()
                        {
                            Id = location.Id,
                            ClientID = GetIntConsole("Id client : "),
                            VehiculeID = GetIntConsole("Id vehicule : "),
                            NbKm = GetIntConsole("Nombre de Kilometres : "),
                            DateDebut = GetDateConsole("Date de début : "),
                            DateFin = GetDateConsole("Date de fin : ")
                        }; break;
                    default: break;
                }
                locationController.UpdateLocation(location);
                WriteLine(locationController.GetLocationById(id));
            }
        }

        private static void OptionGetLocationById(LocationController locationController)
        {
            int id = GetIntConsole("Tapez l'id de la Location : ");
            var location = locationController.GetLocationById(id);

            if (location == null) WriteLine("L'id n'existe pas en base");
            else WriteLine(location);
        }

        private static void OptionUdpateVehicule(VehiculeController vehiculeController)
        {
            int id = GetIntConsole("Tapez l'id du véhicule : ");
            var vehicule = vehiculeController.GetVehiculeById(id);

            if (vehicule == null) WriteLine("L'id n'existe pas en base");
            else
            {
                String propModif = "";

                while (propModif != "i" && propModif != "mod" && propModif != "cou" && propModif != "mar" && propModif
                    != "czt" && propModif != "all")
                {
                    propModif = GetStringConsole("Choisissez l'élement à modifier " +
                      "\ni : Immatriculation, mod : Modele, cou : Couleur, mar : Marque, cat : Categorie, " +
                      "all : toute les éléments ");
                }

                switch (propModif)
                {
                    case "n": vehicule.Immatriculation = GetStringConsole(vehicule.Immatriculation + " : "); break;
                    case "p": vehicule.Modele = GetStringConsole(vehicule.Modele + " : "); break;
                    case "d": vehicule.Couleur = GetStringConsole(vehicule.Couleur + " : "); break;
                    case "a": vehicule.MarqueID = GetIntConsole(vehicule.MarqueID + " : "); break;
                    case "c": vehicule.CategorieID = GetIntConsole(vehicule.CategorieID + " : "); break;

                    case "all":
                        WriteLine(vehicule);
                        vehicule = new Vehicule()
                        {
                            Id = vehicule.Id,
                            Immatriculation = GetStringConsole("Immatriculation : "),
                            Modele = GetStringConsole("Modele : "),
                            Couleur = GetStringConsole("Couleur : "),
                            MarqueID = GetIntConsole("Id Marque : "),
                            CategorieID = GetIntConsole("Id Categorie : ")
                        }; break;
                    default: break;
                }
                vehiculeController.UpdateVehicule(vehicule);
                WriteLine(vehiculeController.GetVehiculeById(id));
            }
        }

        private static void OptionGetVehiculeById(VehiculeController vehiculeController)
        {
            int id = GetIntConsole("Tapez l'id du Vehicule : ");
            var vehicule = vehiculeController.GetVehiculeById(id);

            if (vehicule == null) WriteLine("L'id n'existe pas en base");
            else WriteLine(vehicule);
        }

        private static void OptionAddVehicule(VehiculeController vehiculeController)
        {
            var vehicule = new Vehicule()
            {
                Immatriculation = GetStringConsole("Immatriculation : "),
                Modele = GetStringConsole("Modele : "),
                Couleur = GetStringConsole("Couleur : "),
                MarqueID = GetIntConsole("Marque ID : "),
                CategorieID = GetIntConsole("Catégorie Id : ")
            };

            WriteLine(vehiculeController.CreateVehicule(vehicule));
        }

        private static void OptionAddLocation(LocationController locationController)
        {
            var location = new Location()
            {
                ClientID = GetIntConsole("Id client : "),
                VehiculeID = GetIntConsole("Id vehicule : "),
                NbKm = GetIntConsole("NbKm"),
                DateDebut = GetDateConsole("Date debut : "),
            };
            WriteLine(locationController.CreateLocation(location));
        }

        private static void OptionUdpateClient(ClientController clientController)
        {
            int id = GetIntConsole("Tapez l'id du client : ");
            var client = clientController.GetClientById(id);

            if (client == null) WriteLine("L'id n'existe pas en base");
            else
            {
                String propModif = "";

                while (propModif != "n" && propModif != "p" && propModif != "d" && propModif != "a" && propModif
                    != "c" && propModif != "v" && propModif != "all")
                {
                    propModif = GetStringConsole("Choisissez l'élement à modifier " +
                      "\nn : Nom, p : Prenom, d : Date de Naissance, a : Adresse, c : CodePostal, " +
                      "v : Ville, all : toute les éléments ");
                }

                switch (propModif)
                {
                    case "n": client.Nom = GetStringConsole(client.Nom + " : "); break;
                    case "p": client.Prenom = GetStringConsole(client.Prenom + " : "); break;
                    case "d": client.DateNaissance = GetDateConsole(client.DateNaissance.ToString("dd/MM/yy") + " : "); break;
                    case "a": client.Adresse = GetStringConsole(client.Adresse + " : "); break;
                    case "c": client.CodePostal = GetStringConsole(client.CodePostal + " : "); break;
                    case "v": client.Ville = GetStringConsole(client.Ville + " : "); break;
                    case "all":
                        WriteLine(client);
                        client = new Client()
                        {
                            Id = client.Id,
                            Nom = GetStringConsole("Nom : "),
                            Prenom = GetStringConsole("Prenom : "),
                            DateNaissance = GetDateConsole("Date Naissance : "),
                            Adresse = GetStringConsole("Adresse : "),
                            CodePostal = GetStringConsole("Code Postal : "),
                            Ville = GetStringConsole("Ville : "),
                        }; break;
                    default: break;
                }
                clientController.UpdateClient(client);
                WriteLine(clientController.GetClientById(id));
            }
        }
        private static void OptionGetClientById(ClientController clientController)
        {
            int id = GetIntConsole("Tapez l'id du client : ");
            var client = clientController.GetClientById(id);

            if (client == null) WriteLine("L'id n'existe pas en base");
            else WriteLine(client);
        }

        private static void OptionAddClient(ClientController clientController)
        {
            var client = new Client()
            {
                Nom = GetStringConsole("Tapez le Nom : "),
                Prenom = GetStringConsole("Tapez le Prenom : "),
                DateNaissance = GetDateConsole("Tapez la date de Naissance :"),
            };

            WriteLine(clientController.CreateClient(client));
        }
    }
}