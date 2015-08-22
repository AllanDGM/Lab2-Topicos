using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Servicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Servicio.svc or Servicio.svc.cs at the Solution Explorer and start debugging.
    public class Servicio : IServicio
    {
        private BD_TOPICOSEntities topicos = new BD_TOPICOSEntities();

        public List<CustomerTerritory> ObtenerClientesNombreCliente(string nombre)
        {
            return topicos.CustomerTerritories.Where(p => p.Nombre == nombre).ToList();
        }

        public List<CustomerTerritory> ObtenerClientesNombrePais(string pais)
        {
            return topicos.CustomerTerritories.Where(p => p.Territorio == pais).ToList();
        }

        public List<CustomerTerritory> ObtenerClientes()
        {
            return topicos.CustomerTerritories.ToList();
        }

    }
        
}