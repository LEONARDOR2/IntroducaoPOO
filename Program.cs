using System;


namespace MeuSuperBanco;

class Program
{

    static void Main(string[] args)
    {
        MeuSuperBanco.ContaBanco contaB = new ContaBanco("Leonardo", 10000);

        Console.WriteLine($"Aconta {contaB.Numero} de  {contaB.Dono} foi criada com {contaB.Saldo}");

        // contaB.Depositar(0, DateTime.Now, "recebi um pagamneto");
        // Console.WriteLine($"Aconta está com: {contaB.Saldo} ");

        contaB.Sacar(800, DateTime.Now, "fiz compras");
        Console.WriteLine($"Aconta está com: {contaB.Saldo} ");

        try
        {
            contaB.Sacar(10000, DateTime.Now, "recebi um pagamneto");
            Console.WriteLine($"Aconta está com: {contaB.Saldo} ");

        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Operação não realizada");
        }


        contaB.Sacar(1500, DateTime.Now, "Pagar o aluguel");
        Console.WriteLine($"Aconta está com: {contaB.Saldo} ");

        contaB.Sacar(2000, DateTime.Now, "Pagar a escola das crianças");
        Console.WriteLine($"Aconta está com: {contaB.Saldo} ");


        Console.WriteLine(contaB.PegarMovimentacao());


    }




}