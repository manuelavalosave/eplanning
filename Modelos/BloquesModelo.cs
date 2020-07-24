using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class BloquesModelo
    {
        public long IdBloque { get; set; }
        public string TituloBloque { set; get; }
        public byte Parcial { set; get; }
        public double Porcentaje { set; get; }
        public string Grupos { set; get; }

        public string nombre_materia { set; get; }
        public string Pre_competencia { set; get; }

        public List<BloquesCompetenciasModel> LstBloques{ set; get; }


    }
}
