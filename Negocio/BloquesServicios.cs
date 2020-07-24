using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
namespace Negocio
{
    public class BloquesServicios
    {
        public int GuardarDatosBloque(BloquesModelo datos)
        {
            try
            {
                using (var contexto = new ProyectoEntities())
                {
                    //guardar  Idbloque=0
                    var nuevoBloque = new Bloque
                    {
                        Parcial = datos.Parcial,
                        Porcentaje = datos.Porcentaje,
                        Titulo = datos.TituloBloque,
                        BloqueCompetencia = datos.LstBloques.Select(p => new BloqueCompetencia
                        {
                            Descripcion = p.Descripcion,
                            Numero = p.Numero
                        }).ToList()
                    };

                    contexto.Bloque.Add(nuevoBloque);
                    contexto.SaveChanges();
                    return 1;

                    //editar Idbloque>0

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<BloquesModelo> ConsultarBloques()
        {
            using (var contexto = new ProyectoEntities())
            {

                var lstBloques = contexto.Bloque.Select(p => new BloquesModelo
                {
                    IdBloque = p.IdBloque,
                    Parcial = p.Parcial,
                    Porcentaje = p.Porcentaje,
                    TituloBloque = p.Titulo
                }).ToList();

              //var s = contexto.Bloque.Where(p => p.IdBloque == 1).FirstOrDefault();
              //  s.Parcial = 1;
              //  contexto.SaveChanges();

                return lstBloques;
            }
        }

        //consultar los datos del bloque (IdBloque)


    }
}
