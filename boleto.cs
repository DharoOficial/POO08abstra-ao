using System;
namespace aula08POO
{
    public class boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codigodeBarras { get; set; }
        public string RgistrarSistema(){
            return "Registrado";
        }
    }
}