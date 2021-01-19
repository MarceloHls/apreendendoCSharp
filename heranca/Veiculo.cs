using System;

namespace heranca.Veiculo
{
    public class Veiculo
    {
        public bool terrestre;
        public int velMax;
        private bool ligado;

        public void setLigado(bool ligar)
        {
            ligado = ligar;
        }
        public bool getLigado()
        {
            return ligado;
        }

        public Veiculo(bool terrestre){
            this.terrestre= terrestre;
        }
    }

}
