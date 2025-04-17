namespace ABM_Animais.Animais;
using ABM_Animais.Base;
using ABM_Animais.Enums;
using ABM_Animais.Interfaces;
public class Pato : Ave, IAndar, INadar, IVoar
{
    public Pato(string nome) : base(nome, TipoHabitat.Anfibio) { }

    public override void Mover()
    {
        Andar();
        Nadar();
        Voar();
    }

    public void Andar()
    {
        Console.WriteLine($"{Nome} anda.");
    }

    public void Nadar()
    {
        Console.WriteLine($"{Nome} nada.");
    }

    public void Voar()
    {
        Console.WriteLine($"{Nome} voa.");
    }

    public override void Comer()
    {
        Console.WriteLine($"{Nome} bica grãos e plantas na água.");
    }
}
