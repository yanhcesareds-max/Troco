class Program
{
    static void Main(string[] args)
    {
        // 1. Solicita e lê o valor da compra
        Console.Write("Digite o valor da compra: ");
        decimal valorCompra = Convert.ToDecimal(Console.ReadLine());

        // 2. Solicita e lê o valor pago
        Console.Write("Digite o valor pago: ");
        decimal valorPago = Convert.ToDecimal(Console.ReadLine());

        // 3. Calcular o troco 
        decimal troco = valorPago - valorCompra;

        // 4. Exibir o resultado
        Console.WriteLine($"\nO valor do troco é: {troco:C}");
    }
}