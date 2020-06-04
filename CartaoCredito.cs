namespace Aula08POOAbstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        public void AumentarLimite( float acrescimo ){

            token = "hjzfgaaudhfduifi";
            limite = limite + acrescimo;
            
        }
    }
}