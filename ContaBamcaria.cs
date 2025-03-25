using System;

namespace Models
{
    class ContaBancaria
    {
        public double saldo; //atributo; double  = float

        // Método para depositar um valor
        public void Depositar()
        {
            Console.WriteLine("Digite o valor para depósito: ");
            double valor = Convert.ToDouble(Console.ReadLine()); //  converte para double

            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Depósito de R$ " + valor + " realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        // Método para sacar um valor
        public void Sacar()
        {
            Console.WriteLine("Digite o valor para sacar: ");
            double valor = Convert.ToDouble(Console.ReadLine()); // converte para double

            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Saque de  " + valor + " realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente seu pobre .");
            }
        }

        
        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo atual: " + saldo);
        }
    }
}
