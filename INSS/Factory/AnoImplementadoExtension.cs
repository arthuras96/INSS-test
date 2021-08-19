using INSS.Aliquotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Factory
{
    public static class AnoImplementadoExtension
    {
        public static SalarioAliquotaAbstract SalarioAliquotaImplementado(this Enum anoImplementado, string Name)
        {
            var atributo = typeof(AnoImplementadoTypes).GetFields()
                .Where(f => f.Name == Name)
                .FirstOrDefault()
                ?.GetCustomAttributes(false).First() as AnoImplementadoAttribute;

            if (atributo != null)
                return atributo.CriarInstancia;

            throw new NotImplementedException();
        }
    }
}
