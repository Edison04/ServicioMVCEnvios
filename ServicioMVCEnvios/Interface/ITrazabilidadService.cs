using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios.Interface
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITrazabilidadService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITrazabilidadService
    {
        [OperationContract]
        void AgregarTrazabilidad(Trazabilidad Trazabilidad);
        [OperationContract]
        void EditarTrazabilidad(Trazabilidad Trazabilidad);
        [OperationContract]
        void EliminarTrazabilidad(long id);
        [OperationContract]
        List<Trazabilidad> ListarTrazabilidades();
    }
}
