using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GuamanDavidP3.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
