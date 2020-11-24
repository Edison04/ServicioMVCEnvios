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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TrazabilidadService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione TrazabilidadService.svc o TrazabilidadService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TrazabilidadService : ITrazabilidadService
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarTrazabilidad(Trazabilidad Trazabilidad)
        {
            db.Trazabilidad.Add(Trazabilidad);
            db.SaveChanges();
        }

        public void EditarTrazabilidad(Trazabilidad Trazabilidad)
        {
            db.Entry(Trazabilidad).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarTrazabilidad(long id)
        {
            Trazabilidad Trazabilidad = db.Trazabilidad.Find(id);
            db.Trazabilidad.Remove(Trazabilidad);
            db.SaveChanges();
        }

        public List<Trazabilidad> ListarTrazabilidades()
        {
            return db.Trazabilidad.ToList();
        }
    }
}
