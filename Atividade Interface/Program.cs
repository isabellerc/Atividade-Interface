//-implemente o exemplo do livro.
//- crie uma classe Cliente com nome e CPF
//- adicione o cliente na interface conta o Cliente, ou seja, toda conta precisa ter um cliente
//- crie uma classe Salario que representa uma conta salpario que implementa a interface IConta.
//-melhor a classe Programa criando um menu para manipular o cadatro de conta e os depoísitos e 
//retiradas, onde o usuário poderá escolhar o tipo da conta, etc.

using Atividade_Interface;
using System.ComponentModel;
using System.Globalization;

 
class Program { 
static void Main(string[] strings)
{

    IConta conta;
    Cliente cliente = new Cliente(); //verificar se é isso mesmo
    int tipo, escolha, novaOperacao;
    Console.WriteLine("Digite seu tipo de conta:");
    Console.WriteLine("1 - Conta corrente");
    Console.WriteLine("2 - Conta poupança");
    Console.WriteLine("3 - Conta salário");
    tipo = int.Parse(Console.ReadLine());
    
    while (tipo != 1 && tipo != 2 && tipo != 3)
    {
        Console.WriteLine("Tipo de conta incorreto, digite novamente.");
        tipo = int.Parse(Console.ReadLine());
    }

    if (tipo == 1)
    {
        conta = new Corrente();
            Console.Write("Digite o número de sua conta: ");
            conta.numero = Console.ReadLine();
            
        cliente = new Cliente();
            Console.Write("Digite o seu nome: ");
            cliente.nome = Console.ReadLine();
            Console.Write("Digite seu CPF: "); 
            cliente.cpf = Console.ReadLine();
        }

    else if (tipo == 2)
    {
        conta = new Poupanca();
            Console.Write("Digite o número de sua conta: ");
            conta.numero = Console.ReadLine();
        cliente = new Cliente();
            Console.Write("Digite o seu nome: ");
            cliente.nome = Console.ReadLine();
            Console.Write("Digite seu CPF: ");
            cliente.cpf = Console.ReadLine();
        }

    else
    {
        conta = new Salario();
            Console.Write("Digite o número de sua conta: ");
            conta.numero = Console.ReadLine();
        cliente = new Cliente();
            Console.Write("Digite o seu nome: ");
            cliente.nome = Console.ReadLine();
            Console.Write("Digite seu CPF: ");
            cliente.cpf = Console.ReadLine();
        }

        do
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Seu saldo é de: R$ {conta.CalcularSaldo()}");
            Console.Write("Digite 1 para SACAR e 2 para DEPOSITAR: ");
            escolha = int.Parse(Console.ReadLine());

            while (escolha != 1 && escolha != 2)
            {
                Console.Write("Valor inválido, digite novamente: ");
                escolha = int.Parse(Console.ReadLine());
            }

            if (escolha == 1)
            {
                Console.Write("Digite o valor que deseja sacar: ");
                decimal valor = decimal.Parse(Console.ReadLine()); //verificar esse valor que já estava "declarado"
                conta.Sacar(valor);
            }

            else
            {
                Console.Write("Digite o valor que deseja depositar: ");
                decimal valor = decimal.Parse(Console.ReadLine());
                conta.Depositar(valor);
            }

            Console.WriteLine();
            Console.WriteLine($"Seu saldo atual é de: R$ {conta.CalcularSaldo()}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deseja fazer outra operação?");
            Console.WriteLine("1 - SIM");
            Console.WriteLine("2 - NÃO");
            novaOperacao = int.Parse(Console.ReadLine());

        } while (novaOperacao == 1);

        Console.WriteLine("xxxxxx OPERAÇÃO FINALIZADA xxxxxx");
        Console.ReadKey();
}
}
