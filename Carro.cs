namespace Models;

class Carro
{
    public string marca;
    public string modelo;
    public int ano;


    public Carro()//construtor
    {

    }
    public void dados()
    {
        Console.WriteLine("carro  " + marca + " modelo  " + modelo + " ano de fabricação " + ano);
    }
    public void ligar()
    {
        Console.WriteLine("Seu carro está ligado ");
    }
}

