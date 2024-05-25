using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal.Data.Models
{
    internal class model
    {
        public int id_consola {  get; set; }
        public string nombre_consola {  get; set; }
        public string compania { get; set; }
        public DateTime anio_lanzamiento { get; set; }
        public decimal generacion { get; set; }

        public model() { }

        //Constructor con parametros
        public model(int id,string Nombre_consola,string Compania, DateTime Anio_lanzamiento, decimal Generacion)
        {
            id_consola = id;
            nombre_consola = Nombre_consola;
            compania = Compania;
            anio_lanzamiento = Anio_lanzamiento;
            generacion = Generacion;
        }
    }
}
