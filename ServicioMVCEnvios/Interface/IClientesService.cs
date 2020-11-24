using ServicioMVCEnvios.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace ServicioMVCEnvios.Interface
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClientesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClientesService
    {
        [OperationContract]
        void AgregarCliente(Cliente cliente);
        [OperationContract]
        void EditarCliente(Cliente cliente);
        [OperationContract]
        void EliminarCliente(long id);
        [OperationContract]
        List<Cliente> ListarClientes();

    }
}
