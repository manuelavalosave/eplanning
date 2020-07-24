using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   
  public  class AgregarMateria
    {
        
        public int Id_materia { get; set; }
      
        public string Nombre_materia { get; set; }
        public string Semestre { get; set; }
        public string Grupo { get; set; }
    }
}
