using INSS.Aliquotas;
using INSS.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class AnoImplementado
    {
        public string Name { get; set; }
        public AnoImplementadoTypes Type { get; set; }

        public SalarioAliquotaAbstract GetSalarioAliquota()
        {
            return Type.SalarioAliquotaImplementado(Name);
        }

    }
}
