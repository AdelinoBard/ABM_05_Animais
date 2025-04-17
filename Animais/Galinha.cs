namespace ABM_Animais.Animais;

using ABM_Animais.Base;
using ABM_Animais.Enums;
using ABM_Animais.Interfaces;
public class Galinha : Ave, IAndar, IVoar
{
    public Galinha(string nome) : base(nome, TipoHabitat.Terrestre) { }

    public override void Mover()
    {
        Andar();
        Voar();
    }

    public void Andar()
    {
        Console.WriteLine($"{Nome} anda.");
    }

    public void Voar()
    {
        VoarCurto();
    }

    protected void VoarCurto()
    {
        Console.WriteLine($"{Nome} voa apenas uma curta distância.");
    }
}
