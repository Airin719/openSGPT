using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPT_Controlador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program");
            using (var db = new SGPTContextDB())
            {
                
                var usuarios = from a in db.TblUsuario select a;
                Console.WriteLine("init each");
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine(usuario.nombres);
                    
                }
                Console.WriteLine("end each");
            }
            
        }
    }
}
