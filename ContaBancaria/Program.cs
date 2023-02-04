using ContaBancaria;
using System.Globalization;

Console.Write("Entre com o número da conta: ");
int conta = int.Parse(Console.ReadLine());
Console.Write("Entre com o nome do titular da conta: ");
string nomeTitular = Console.ReadLine();

Console.Write("Haverá deposito inicial (s/n)? ");
char escolha = char.Parse(Console.ReadLine());

if (escolha == 's' || escolha == 'S')
{
    Console.Write("Entre com o valor do deposito inicial: ");
    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Conta c1 = new Conta(conta, nomeTitular, valor);
    Console.WriteLine();
    Console.WriteLine(c1);
    Console.WriteLine("******************************************************************");
    Console.WriteLine();
    Console.Write("Entre com o valor pra deposito: ");
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c1.Deposito(valor);
    Console.WriteLine();
    Console.WriteLine("Dados atualizados");
    Console.WriteLine(c1);

    Console.WriteLine("******************************************************************");
    Console.WriteLine();
    Console.Write("Entre com o valor pra saque: ");
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c1.Saque(valor);
    Console.WriteLine("Dados atualizados");
    Console.WriteLine(c1);
}
else if (escolha == 'n' || escolha == 'N')
{
    Conta c2 = new Conta(conta, nomeTitular);
    Console.WriteLine("Dados da conta:");
    Console.WriteLine(c2);
    Console.WriteLine();
    Console.WriteLine("*************************************************************");
    Console.Write("Deposito: ");
    double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c2.Deposito(val);
    Console.WriteLine("Dados da conta atualizados: ");
    Console.WriteLine(c2);
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Saque: ");
    val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c2.Saque(val);

    Console.WriteLine("Dados atualizados: ");
    Console.WriteLine(c2);

}




