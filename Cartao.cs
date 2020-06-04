namespace Aula08POOAbstracao
{
    public class Cartao : Pagamento
    {
        protected string token = "ksjdhffhçadifhyisaoi hfdisapofryt";
        public string titular { get; set; }
        public int numero { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }return false;
        }
    }
}