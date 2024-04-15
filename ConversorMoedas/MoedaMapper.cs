namespace ConversorMoedas;

public class MoedaMapper : IMoedaMapper
{
    public Moeda Map(string moeda)
    {
        return moeda.ToUpper() switch
        {
            "DOLAR" => Moeda.Dolar,
            "EURO" => Moeda.Euro,
            "REAL" => Moeda.Real,
            _ => throw new ArgumentOutOfRangeException(nameof(moeda), "Moeda desconhecida")
        };
    }
}