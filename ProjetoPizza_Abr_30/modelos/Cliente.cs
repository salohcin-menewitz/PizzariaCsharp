public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? Endereco { get; set; }	
    
    // Relacionamento 1 para muitos
    public List<Pedido>? Pedidos { get; set; }
public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, CPF: {CPF}, Telefone: {Telefone}, Email: {Email}, Endereço: {Endereco}";
    }

}
