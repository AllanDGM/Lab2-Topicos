using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfLab2Topicos
{
    [DataContract]          
    public class Cliente
    {
        [DataMember]
        public int IdCliente;

        [DataMember]
        public string Nombre;

        [DataMember]
        public DateTime FechaNacimiento;
    }
}
