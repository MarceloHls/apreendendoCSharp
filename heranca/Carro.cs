namespace heranca.Carro{
    public class Carro : heranca.Veiculo.Veiculo{
       public string modelo;
       public int rodas;
        public Carro(int velMax,string modelo):base(true){
           
            this.velMax = velMax;
            this.rodas = 4;
            this.modelo = modelo;
            setLigado(false);
        }
    }
}