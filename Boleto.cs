using System;

namespace Aula08POOAbstracao
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codDeBarras { get; set; }

        public string Registrar(){
            return "Boleto registrado com sucesso!";
        }
    }
}