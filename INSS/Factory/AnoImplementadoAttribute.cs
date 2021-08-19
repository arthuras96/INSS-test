using INSS.Aliquotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Factory
{
    public class AnoImplementadoAttribute : Attribute
    {
        private Type _implementacao { get; }
        public SalarioAliquotaAbstract CriarInstancia => (SalarioAliquotaAbstract)Activator.CreateInstance(_implementacao);
        public AnoImplementadoAttribute(Type implementacao)
        {
            _implementacao = implementacao;
        }

    }
}
