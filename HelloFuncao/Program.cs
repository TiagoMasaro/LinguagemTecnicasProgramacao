using System;

class Program
{
    static double notaFinalDisciplina(double notaReg, double notaProvaFinal)
    {
        double resultado;
        resultado = (notaProvaFinal * 2 + notaReg) / 3;
        return resultado;
    }// fim da funcao
static void Main()
    {
        double notaRegular, notaProvaFinal, mediaFinal;
        while (true)
        {
            Console.WriteLine("Entre com a nota regular e nota da prova final: ");
            notaRegular = double.Parse(Console.ReadLine());
            notaProvaFinal = double.Parse(Console.ReadLine());
            mediaFinal = notaFinalDisciplina(notaRegular, notaProvaFinal);
            Console.WriteLine($"A média final do aluno é : {mediaFinal:F2}");         
            }
    }
}
