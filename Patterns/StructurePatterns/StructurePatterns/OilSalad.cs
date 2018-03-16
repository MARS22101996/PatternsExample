using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePatterns
{
    public class OilSalad : SaladDecorator
    {
        public OilSalad(Salad salad) : base(salad.Name + "with oil ", salad)
        {
        }

        public override int GetCost()
        {
            return Salad.GetCost() + 5;
        }
    }
}
