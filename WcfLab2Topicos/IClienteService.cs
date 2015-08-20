using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfLab2Topicos;

namespace WcfServices
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        List<Cliente> ObtenerClientes();

        [OperationContract]
        void InsertarCliente(Cliente c);

        [OperationContract]
        void ModificarCliente(Cliente c);

        [OperationContract]
        void EliminarCliente(int id);
    }
}