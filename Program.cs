// See https://aka.ms/new-console-template for more information
using Models;
class Program
{
    static void Main(string[] args)
    {
        Pessoa obj = new Pessoa();
        obj.nome = "Max";
        obj.idade = 27;
        obj.mensagem();


        Carro carro1 = new Carro();
        carro1.marca = "Toyota";
        carro1.modelo = "Supra";
        carro1.ano = 1999;
        carro1.dados();
        carro1.ligar();
        Carro carro2 = new Carro();
        carro2.marca = "audi ";
        carro2.modelo = "a3";
        carro2.ano = 2025;
        carro2.dados();
        carro2.ligar();
        
        
        ContaBancaria conta= new ContaBancaria();
        conta.ExibirSaldo();
        conta.Depositar();
        conta.ExibirSaldo();
        conta.Sacar();
        conta.ExibirSaldo(); 
    }
}




