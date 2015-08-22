using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        List<CustomerTerritory> ObtenerClientesNombreCliente(String nombre);


        [OperationContract]
        List<CustomerTerritory> ObtenerClientesNombrePais(String pais);

        [OperationContract]
        List<CustomerTerritory> ObtenerClientes();
    }

    
}