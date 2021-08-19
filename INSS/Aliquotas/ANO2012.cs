using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Aliquotas
{
    public sealed class ANO2012 : SalarioAliquotaAbstract
    {
        protected override List<SalarioAliquotaModel> SalarioAliquota
        {
            get => new List<SalarioAliquotaModel>() {
                new SalarioAliquotaModel {
                    SalarioTeto = 1000,
                    Aliquota = 7
                },
                new SalarioAliquotaModel {
                    SalarioTeto = 1500,
                    Aliquota = 8
                },
                new SalarioAliquotaModel {
                    SalarioTeto = 3000,
                    Aliquota = 9
                },
                new SalarioAliquotaModel {
                    SalarioTeto = 4000,
                    Aliquota = 11
                }
            };
        }

        protected override decimal Teto { get => 500; }
    }
}
