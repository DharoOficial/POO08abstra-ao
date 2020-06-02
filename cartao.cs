namespace aula08POO
{
    public class cartao : Pagamento
    {
        public string token { get; set; } = "9328131u82937123981e8y3";
        public string bandeira { get; set; }
        public int numero { get; set; }
        public int titular { get; set; }
        public int cvc { get; set; }
        public string ValidarToken(){
            return "cartao validado";
        }
    }
}