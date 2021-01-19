namespace Protected
{
    public class Empresa : Pessoa
    {
        public string fantasia;
        public string cnpj;

        public Empresa(string nome, int idade, string fantasia, string cnpj)
        : base(nome, idade)
        {
            this.fantasia = fantasia;
            this.cnpj = cnpj;
            //this.nome error
           
        }
    }
}