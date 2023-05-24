using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Interface
{
    class Salario : IConta
    {
        public decimal saldo { get; set; }
        public string numero { get; set; }

        public string nome { get; set; } 
        public string cpf { get; set; }

        public decimal CalcularSaldo()
        {
            return saldo;
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }
    }
}
