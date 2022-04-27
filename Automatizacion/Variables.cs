using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatizacion
{
    public class Variables
    {
        public string nombreVariable { get; set; }
        public string tipoVariable { get; set; }
        [Browsable(false)]
        public int nivelVariable { get; set; }
    }
}
