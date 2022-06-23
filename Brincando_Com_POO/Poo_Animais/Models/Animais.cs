namespace Poo_Animais.Models
{
    public class Animais
    {
        private string? nomeDoAnimal;
        private byte tipoDeAnimal;

        public string? NomeDoAnimal
        {
            get { return nomeDoAnimal; }
            set { nomeDoAnimal = value; }
        }
        public byte TipoDeAnimal
        {
            get { return tipoDeAnimal; }
            set { tipoDeAnimal = value; }
        }



        public Animais()
        {

        }
        public Animais(string nomeDoAnimal, byte tipoDeAnimal)
        {
            this.NomeDoAnimal = nomeDoAnimal;
            this.TipoDeAnimal = tipoDeAnimal;
        }
    }
}