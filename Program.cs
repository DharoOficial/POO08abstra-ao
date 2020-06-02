using System;

namespace aula08POO
{
    class Program
    {
        static void Main(string[] args)
        {
            cartaocredito visa = new cartaocredito();
            visa.ValidarToken();
            System.Console.WriteLine(visa.ValidarToken());
            System.Console.WriteLine(visa.token);

	visa.limite = 1200;
	visa.AumentarLimite(visa.limite, 300);
        }
    }
}
