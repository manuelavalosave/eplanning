using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public static class DocificacionCompetencia
    {
        public static int GuardarEditar(CompetenciaPorParcial datosGuardar)
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    if (datosGuardar.Id_planificacion == 0)
                    {
                        //registro nuevo guardar
                        var datosG = new Plani_por_parcial
                        {
                            Comp_Ger = datosGuardar.Comp_Ger,
                            Comp_Dici = datosGuardar.Comp_Dici,
                            Conflicto = datosGuardar.Conflicto,
                            Situacion = datosGuardar.Situacion,
                            Parcial = datosGuardar.Parcial,
                            nombre_materia = datosGuardar.nombre_materia,
                            Posicion_list = datosGuardar.Pocision_list,
                        };

                        contexto.Plani_por_parcial.Add(datosG);

                    }
                    else
                    {
                        //registro para modificar
                        var datosModificar = contexto.Plani_por_parcial.Where(p => p.Id_planificacion == datosGuardar.Id_planificacion).FirstOrDefault();

                        datosModificar.Comp_Ger = datosGuardar.Comp_Ger;
                        datosModificar.Comp_Dici = datosGuardar.Comp_Dici;
                        datosModificar.Conflicto = datosGuardar.Conflicto;
                        datosModificar.Situacion = datosGuardar.Situacion;
                        datosModificar.Parcial = datosGuardar.Parcial;
                        datosModificar.nombre_materia = datosGuardar.nombre_materia;
                        datosModificar.Posicion_list = datosGuardar.Pocision_list;

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

        
        public static CompetenciaPorParcial ConsultarPlantelPorId(int Parcial, string Materia_parcial)
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    var datosPlantel = contexto.Plani_por_parcial.Where(s => s.nombre_materia == Materia_parcial && s.Parcial == Parcial).Select(p => new CompetenciaPorParcial
                    {
                        Comp_Ger = p.Comp_Ger,
                        Comp_Dici = p.Comp_Dici,
                        Conflicto = p.Conflicto,
                        Situacion = p.Situacion,
                        Parcial = p.Parcial,
                        nombre_materia = p.nombre_materia,
                        Pocision_list = p.Posicion_list,
                        Id_planificacion = p.Id_planificacion,

                    }).FirstOrDefault();


                    return datosPlantel;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}

