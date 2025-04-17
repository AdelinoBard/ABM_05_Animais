namespace ABM_Animais.Base;

using ABM_Animais.Enums;

public abstract class Animal
{
    public string Nome { get; set; }
    public TipoHabitat Habitat { get; set; } // 👈 nova propriedade

    protected Animal(string nome, TipoHabitat habitat)
    {
        Nome = nome;
        Habitat = habitat;
    }

    public abstract void Mover();

    /// <summary>
    /// Método padrão de alimentação do animal.
    /// </summary>
    public virtual void Comer()
    {
        Console.WriteLine($"{Nome} está comendo.");
    }

    /// <summary>
    /// Método sobrecarregado para especificar o alimento.
    /// </summary>
    /// <param name="alimento">Nome do alimento consumido.</param>
    public void Comer(string alimento)
    {
        Console.WriteLine($"{Nome} está comendo {alimento}.");
    }

}
