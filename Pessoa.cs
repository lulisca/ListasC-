


namespace Models
{


    class Pessoa //clase é um molde para alguma coisa 
    {//atributos+ caracteríticas

        public int idade;

        public string nome;// com public qualquer pasta. cs vai ter acesso 


        // métodos= funções
        public Pessoa (){}//construtor
        
        public Int32 idadeMeses(){
            return idade * 12;

        }
        
        public void mensagem()// void = null 
        {
            Console.WriteLine("Olá " + nome + " você tem " + idade + " anos e " + idadeMeses()+ "meses");

        }

        







    }
}