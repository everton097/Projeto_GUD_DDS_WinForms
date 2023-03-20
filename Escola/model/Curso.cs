using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola.model
{
    internal class Curso
    {
        //Atributos / Getter / Setter
        public int Id { get; set; }
        public string nome_curso { get; set; }
        public int carga_horaria { get; set; }
        public string periodo { get; set; }
        public string nome_coordenador { get; set; }
        public string objetivo { get; set; }
        public string perfil_egresso { get; set; }
    }
}
