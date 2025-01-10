using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.ConsoleApp.Modelos
{
    public class BaseModel
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{this.Id}";
        }
    }
}
