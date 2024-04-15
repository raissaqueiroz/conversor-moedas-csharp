namespace ConversorMoedas;

public class ConversorMoedas
{
    private readonly IMoedaMapper _moedaMapper;

    public ConversorMoedas(IMoedaMapper moedaMapper)
    {
        _moedaMapper = moedaMapper;
    }

    public void ConverterMoeda()
    {
        Moeda moedaOrigem, moedaDestino;

        // Solicitar moeda de origem
        Console.WriteLine("Escolha a moeda de origem:");
        MostrarOpcoesMoedas();
        moedaOrigem = _moedaMapper.Map(Console.ReadLine());

        // Solicitar moeda de destino
        Console.WriteLine("Escolha a moeda de destino:");
        MostrarOpcoesMoedas();
        moedaDestino = _moedaMapper.Map(Console.ReadLine());

        // Solicitar valor em moeda de origem
        Console.Write($"Digite o valor em {moedaOrigem}: ");
        decimal valorOrigem = LerDecimal();

        // Converter valor para moeda de destino
        decimal valorDestino = ConverterMoeda(valorOrigem, moedaOrigem, moedaDestino);

        // Exibir resultado da conversão
        Console.WriteLine($"Valor em {moedaDestino}: {valorDestino}");
    }

    private static void MostrarOpcoesMoedas()
    {
        Console.WriteLine(Moeda.Dolar);
        Console.WriteLine(Moeda.Euro);
        Console.WriteLine(Moeda.Real);
    }

    private static decimal LerDecimal()
    {
        decimal valor;
        if (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        {
            Console.WriteLine("Valor inválido. Digite um valor numérico maior que zero:");
        }

        return valor;
    }

    private static decimal ConverterMoeda(decimal valorOrigem, Moeda moedaOrigem, Moeda moedaDestino)
    {
        // Aqui seria implementada a lógica de conversão real
        // Por simplicidade, vamos apenas retornar o valor de origem
        return valorOrigem;
    }
}