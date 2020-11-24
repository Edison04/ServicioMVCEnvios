using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios.Interface
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGuiaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGuiaService
    {
        [OperationContract]
        void AgregarGuia(Guia Guia);
        [OperationContract]
        void EditarGuia(Guia Guia);
        [OperationContract]
        void EliminarGuia(long id);
        [OperationContract]
        List<Guia> ListarGuias();
    }
}
