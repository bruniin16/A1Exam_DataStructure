using System;

class game
{
    static void Main()
    {

        Console.Write("Quantas fases faceis existem no jogo? ");
        int fasesFaceis = Convert.ToInt32(Console.ReadLine());

        int fasesDificeis = 96 - fasesFaceis;

        int horasFaseFacil = fasesFaceis * 1;
        int horasFaseDificil = fasesDificeis * 2;
        int totalHoras = horasFaseFacil + horasFaseDificil;

        double valor = totalHoras * 5;

        Console.WriteLine("Quantidade de fases faceis: " + fasesFaceis);
        Console.WriteLine("Quantidade de fases dificeis: " + fasesDificeis);
        Console.WriteLine("Horas em fases faceis: " + horasFaseFacil);
        Console.WriteLine("Horas em fases dificeis: " + horasFaseDificil);
        Console.WriteLine("Total de horas gastas para finalizar: " + totalHoras);
        Console.WriteLine("Valor a ser pago em reais: R$" + valor.ToString("0.00"));
    }
}