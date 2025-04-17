using ABM_Animais.Enums; // Ensure the namespace containing TipoHabitat is imported

namespace ABM_Animais.Base;
public abstract class Ave : Animal
{
    protected Ave(string nome, TipoHabitat habitat) : base(nome, habitat)
    {
    }

    public void BotarOvos()
    {
        Console.WriteLine($"{Nome} bota ovos.");
    }
}