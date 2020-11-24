using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios.Interface
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISedeService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISedeService
    {
        [OperationContract]
        void AgregarSede(Sede Sede);
        [OperationContract]
        void EditarSede(Sede Sede);
        [OperationContract]
        void EliminarSede(long id);
        [OperationContract]
        List<Sede> ListarSedes();
    }
}
