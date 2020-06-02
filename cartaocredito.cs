namespace aula08POO
{
    public class cartaocredito : cartao
    {
        public float limite { get; set; }
        public float AumentarLimite(float limite, float acrecsimo){
            return limite;
        }
            
        

        public bool BloquearCartao(){
            return true;
        }
    }
}