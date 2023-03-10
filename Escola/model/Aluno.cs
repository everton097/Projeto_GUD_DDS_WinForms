using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola.model
{
    public class Aluno
    {
        //Atributos / Getter / Setter
        public int Id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
    }
}
