using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Atividade_Interface
{
    interface IConta
    {
        decimal saldo { get; set; }
        string numero { get; set; } 
        string nome { get; set; } //aqui eu devo implementar a classe cliente, nao?
        string cpf { get; set; } // aqui eu devo implementar a classe cliente, não?


        decimal CalcularSaldo();
        void Sacar(decimal valor);
        void Depositar(decimal valor);
    }
}
