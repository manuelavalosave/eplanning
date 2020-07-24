using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Negocio
{
   public class BloqueMateria
    {


        public List<AgregarMateria> ConsultarBloques()
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    var lstBloques = contexto.Materia_t.Select(p => new AgregarMateria
                    {
                        Id_materia = p.Id_materia,
                        Nombre_materia = p.Nombre_materia,
                        Semestre = p.Semestre,
                        Grupo = p.Grupo

                    }).ToList();


                    return lstBloques;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
