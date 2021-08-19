using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Aliquotas
{
    public sealed class ANO2011 : SalarioAliquotaAbstract
    {
        protected override List<SalarioAliquotaModel> SalarioAliquota { 
            get => new List<SalarioAliquotaModel>() {
                new SalarioAliquotaModel {
                    SalarioTeto = 1106.9m,
                    Aliquota = 8
                },
                new SalarioAliquotaModel {
                    SalarioTeto = 1844.83m,
                    Aliquota = 9
                },
                new SalarioAliquotaModel {
                    SalarioTeto = 3689.66m,
                    Aliquota = 11
                }
            }; 
        }

        protected override decimal Teto { get => 405.86m; }
    }
}
