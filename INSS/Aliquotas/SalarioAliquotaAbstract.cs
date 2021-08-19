using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Aliquotas
{
    public abstract class SalarioAliquotaAbstract
    {
        protected abstract List<SalarioAliquotaModel> SalarioAliquota { get; }
        protected abstract decimal Teto { get; }
        public decimal CalcularInss(decimal salario) {
            foreach(SalarioAliquotaModel salarioAliquota in SalarioAliquota) {
                if (salario <= salarioAliquota.SalarioTeto)
                    return Math.Round(salario * (salarioAliquota.Aliquota / 100), 2);
            }
            return Teto;
        }
    }
}
