namespace ABM_Animais.Animais;

using ABM_Animais.Base;
using ABM_Animais.Enums;
using ABM_Animais.Interfaces;
public class Ornitorrinco : Mamifero, IAndar, INadar
{
    public Ornitorrinco(string nome) : base(nome, TipoHabitat.Anfibio) { }

    public override void Mover()
    {
        Andar();
        Nadar();
    }

    public void Andar()
    {
        Console.WriteLine($"{Nome} anda.");
    }

    public void Nadar()
    {
        Console.WriteLine($"{Nome} nada.");
    }
}
