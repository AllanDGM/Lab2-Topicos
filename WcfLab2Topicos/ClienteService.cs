using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfLab2Topicos;

namespace WcfServices
{
    [ServiceBehavior]
    public class ClienteService : IClienteService

    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public List<Cliente> ObtenerClientesNombreCliente(string nombre)
        {
            return listaClientes;
        }

        public List<Cliente> ObtenerClientesNombrePais(string pais)
        {
            return listaClientes;
        }


    }


}
