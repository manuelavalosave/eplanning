using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Alumno
    {
        public int GuardarAlumnos(List<AlumnoDTO> x)
        {
            try
            {
                var lstAlumnosNuevos = x.Where(o => o.NuevoEliminar == 1).Select(o => new AlumnoDTO
                {
                    Nombre = o.Nombre,
                    NumeroControl = o.NumeroControl
                }).ToList();

                // contexto.Alumnos.addRange(lstAlumnosNuevos);

                var lstEliminar = x.Where(o => o.NuevoEliminar == 2).Select(o => new AlumnoDTO
                {
                    Nombre = o.Nombre,
                    NumeroControl = o.NumeroControl
                }).ToList();

                // contexto.Alumnos.RemoveRange(lstEliminar);


                var lstModificar = x.Where(o => o.NuevoEliminar == 3).Select(o => new AlumnoDTO
                {
                    Nombre = o.Nombre,
                    NumeroControl = o.NumeroControl
                }).ToList();

                foreach (var item in lstModificar)
                {
                    //var datosmoficiar = contexto.Alumnos.where(o=>o.id==item.id).firtsordefault();
                   // datosmodificar.Nombre=item.nombre

                }
                


                //contexto.saveChange();

                return 1;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
