public class Pizza {

    public int Id { get; set; }
    public string? Sabor { get; set; }
    public double? Valor { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Sabor: {Sabor}, Valor: {Valor}";
    }
