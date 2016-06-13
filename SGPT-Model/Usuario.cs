using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPT_Model
{
    
   public class Usuarios
    {
        [Key]
        public Int16 idusuario { get; set; }
        
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
        public string sexo { get; set; }
        public DateTime fchnacio { get; set; }
        public Int16 estado { get; set; }
        public DateTime fchcreacion { get; set; }
        public DateTime fchmodifica { get; set; }
        public Int16 usrcreacion { get; set; }
        public Int16 usrmodifica { get; set; }
        public string ipcreacion { get; set; }
        public string ipmodifica { get; set; }


    }
}
