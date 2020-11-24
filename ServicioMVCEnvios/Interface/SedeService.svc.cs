using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios.Interface
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SedeService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Sede de prueba WCF para probar este servicio, seleccione SedeService.svc o SedeService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SedeService : ISedeService
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarSede(Sede Sede)
        {
            db.Sede.Add(Sede);
            db.SaveChanges();
        }

        public void EditarSede(Sede Sede)
        {
            db.Entry(Sede).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarSede(long id)
        {
            Sede Sede = db.Sede.Find(id);
            db.Sede.Remove(Sede);
            db.SaveChanges();
        }

        public List<Sede> ListarSedes()
        {
            return db.Sede.ToList();
        }
    }
}
