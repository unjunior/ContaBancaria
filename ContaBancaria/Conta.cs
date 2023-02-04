using System.Globalization;

namespace ContaBancaria
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
           Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Dados da conta: \n" 
                + $"Conta: {Numero} \n"
                + $"Titular da conta: {Titular} \n"
                + "Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
