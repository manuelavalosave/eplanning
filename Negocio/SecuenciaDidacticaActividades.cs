using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public static class SecuenciaDidacticaActividades
    {
        public static int GuardarEditar(SecuenciaDidacticaModelo datosGuardar)
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    if (datosGuardar.Id_Acti == 0)
                    {
                        //registro nuevo guardar
                        var datosG = new Secuencia_Didactica
                        {
                         T_Activ = datosGuardar.T_Activ,
                          Parcial = datosGuardar.Parcial,
                          Materia = datosGuardar.Materia,
                          checador_act = datosGuardar.checador_act,
                          sesion = datosGuardar.sesion,
                          Tipo = datosGuardar.Tipo,
                        };

                        contexto.Secuencia_Didactica.Add(datosG);

                    }
                    else
                    {
                        //registro para modificar
                        var datosModificar = contexto.Secuencia_Didactica.Where(p => p.Id_Acti == datosGuardar.Id_Acti).FirstOrDefault();

                        datosModificar.T_Activ = datosGuardar.T_Activ;
                        datosModificar.Parcial = datosGuardar.Parcial;
                        datosModificar.Materia = datosGuardar.Materia;
                        datosModificar.checador_act = datosGuardar.checador_act;
                        datosModificar.sesion = datosGuardar.sesion;
                        datosModificar.Tipo = datosGuardar.Tipo;

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

        public static SecuenciaDidacticaModelo ConsultarPlantelPorId(int Parcial, string Materia_parcial)
        {

            try
            {
                using (var contexto = new ProyectoEntities())
                {

                    var datosPlantel = contexto.Secuencia_Didactica.Where(s => s.Materia == Materia_parcial && s.Parcial == Parcial).Select(p => new SecuenciaDidacticaModelo
                    {
                        T_Activ = p.T_Activ,
                        Parcial = p.Parcial,
                        Materia = p.Materia,
                        checador_act = p.checador_act,
                      
                        sesion = p.sesion,
                    Tipo = p.Tipo,
                        Id_Acti = p.Id_Acti,

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
