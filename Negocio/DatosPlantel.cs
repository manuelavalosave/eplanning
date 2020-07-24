using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;

namespace Negocio
{
    public static class DatosPlantel
    {

        public static List<Datos_PlantelModel> ConsultarPlanteles()
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    var lstBloques = contexto.Datos_Plantel.Select(p => new Datos_PlantelModel
                    {
                        Correo = p.Correo,
                        Departamento = p.Departamento,
                        Direccion = p.Direccion,
                        Id_Plantel = p.Id_Plantel,
                        Nombre_corto = p.Nombre_corto,
                        Nombre_plantel = p.Nombre_plantel,
                        Telefono = p.Telefono,
                    }).ToList();


                    return lstBloques;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static Datos_PlantelModel ConsultarPlantelPorId(int idPlantel)
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    var datosPlantel = contexto.Datos_Plantel.Where(s => s.Id_Plantel == idPlantel).Select(p => new Datos_PlantelModel
                    {
                        Correo = p.Correo,
                        Departamento = p.Departamento,
                        Direccion = p.Direccion,
                        Id_Plantel = p.Id_Plantel,
                        Nombre_corto = p.Nombre_corto,
                        Nombre_plantel = p.Nombre_plantel,
                        Telefono = p.Telefono,
                    }).FirstOrDefault();


                    return datosPlantel;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int GuardarEditar(Datos_PlantelModel datosGuardar)
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    if (datosGuardar.Id_Plantel == 0)
                    {
                        //registro nuevo guardar
                        var datosG = new Datos_Plantel
                        {
                            Correo = datosGuardar.Correo,
                            Departamento = datosGuardar.Departamento,
                            Direccion = datosGuardar.Direccion,
                            Nombre_corto = datosGuardar.Nombre_corto,
                            Nombre_plantel = datosGuardar.Nombre_plantel,
                            Telefono = datosGuardar.Telefono,
                        };

                        contexto.Datos_Plantel.Add(datosG);

                    }
                    else
                    {
                        //registro para modificar
                        var datosModificar = contexto.Datos_Plantel.Where(p => p.Id_Plantel == datosGuardar.Id_Plantel).FirstOrDefault();

                        datosModificar.Correo = datosGuardar.Correo;
                        datosModificar.Departamento = datosGuardar.Departamento;
                        datosModificar.Direccion = datosGuardar.Direccion;
                        datosModificar.Nombre_corto = datosGuardar.Nombre_corto;
                        datosModificar.Nombre_plantel = datosGuardar.Nombre_plantel;
                        datosModificar.Telefono = datosGuardar.Telefono;

                    }
                    contexto.SaveChanges();

                    return 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int EliminarPlantel(int idPlantel)
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    var datoEliminar = contexto.Datos_Plantel.Where(p => p.Id_Plantel == idPlantel).FirstOrDefault();

                    contexto.Datos_Plantel.Remove(datoEliminar);
                    contexto.SaveChanges();

                    return 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
