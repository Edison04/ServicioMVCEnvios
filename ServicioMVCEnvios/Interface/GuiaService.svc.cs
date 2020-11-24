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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "GuiaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione GuiaService.svc o GuiaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class GuiaService : IGuiaService
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarGuia(Guia Guia)
        {
            db.Guia.Add(Guia);
            db.SaveChanges();
        }

        public void EditarGuia(Guia Guia)
        {
            db.Entry(Guia).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarGuia(long id)
        {
            Guia Guia = db.Guia.Find(id);
            db.Guia.Remove(Guia);
            db.SaveChanges();
        }

        public List<Guia> ListarGuias()
        {
            return db.Guia.ToList();
        }
    }
}
