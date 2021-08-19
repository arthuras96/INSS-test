using INSS.Aliquotas;
using INSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculadorInss : ICalculadorInss
    {
        private AnoImplementado anoImplementado { get; set; }
        private SalarioAliquotaAbstract _salarioAliquota { get { return anoImplementado.GetSalarioAliquota(); } }
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            anoImplementado = new AnoImplementado { 
                Name = data.ToString("ANOyyyy")
            };
            return _salarioAliquota.CalcularInss(salario);
        }
    }
}
