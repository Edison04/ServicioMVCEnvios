using ServicioMVCEnvios.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServicioMVCEnvios.Interface
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClientesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClientesService.svc o ClientesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClientesService : IClientesService
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarCliente(Cliente cliente)
        {
            db.Cliente.Add(cliente);
            db.SaveChanges();
        }

        public void EditarCliente(Cliente cliente)
        {
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarCliente(long id)
        {
            Cliente cliente = db.Cliente.Find(id);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
        }

        public List<Cliente> ListarClientes()
        {
            return db.Cliente.ToList();
        }
    }
}
