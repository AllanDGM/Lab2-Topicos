using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices
{
    [ServiceBehavior]
    public class ClienteService : IClienteService
    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public List<Cliente> ObtenerClientes()
        {
            return listaClientes;
        }

        public void InsertarCliente(Cliente c)
        {
            // Calculamos el ID del siguiente elemento
            if (listaClientes.Count == 0)
                c.IdCliente = 1;
            else
                c.IdCliente = listaClientes.Max(cliente => cliente.IdCliente) + 1;

            // Añadimos el cliente a la lista
            listaClientes.Add(c);
        }

        public void ModificarCliente(Cliente c)
        {
            // Recuperamos el cliente cuyo ID coincide con el pasado como parámetro
            Cliente clienteModif = listaClientes.Where(cliente => cliente.IdCliente == c.IdCliente).First();

            // Si el registro existe, se modifica
            if (clienteModif != null)
            {
                clienteModif.Nombre = c.Nombre;
                clienteModif.FechaNacimiento = c.FechaNacimiento;
            }

        }

        public void EliminarCliente(int id)
        {
            // Recuperamos el cliente cuyo ID coincide con el pasado como parámetro
            Cliente clienteEliminar = listaClientes.Where(cliente => cliente.IdCliente == id).First();

            // Si el registro existe, se elimina
            if (clienteEliminar != null)
            {
                listaClientes.Remove(clienteEliminar);
            }
        }
    }
}
