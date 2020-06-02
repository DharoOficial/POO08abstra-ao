namespace aula08POO
{
    public class cartaodebito : cartao
    {
        public double saldo { get; set; }

        public string Transferir(float valor){
            return $"R$ {valor} valor transferido";
        }

        public string PagarTitulo(){
            return "titulo pago";
        }
    }
}