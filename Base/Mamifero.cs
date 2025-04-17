using ABM_Animais.Enums; // Ensure the namespace containing TipoHabitat is imported

namespace ABM_Animais.Base;
public abstract class Mamifero : Animal
{
    protected Mamifero(string nome, TipoHabitat habitat) : base(nome, habitat)
    {
    }

    public void Amamentar()
    {
        Console.WriteLine($"{Nome} amamenta seus filhotes.");
    }
}