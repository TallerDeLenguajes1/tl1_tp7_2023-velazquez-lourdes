using Espaciocalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var cal = new Calculadora();
        cal.Sumar(4);
        Console.WriteLine(cal.Resultado);
        cal.Multiplicar(2);
        Console.WriteLine(cal.Resultado);
    }
}