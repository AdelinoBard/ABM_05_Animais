namespace ABM_Animais.Animais;

using ABM_Animais.Base;
using ABM_Animais.Enums;
using ABM_Animais.Interfaces;
public class Morcego : Mamifero, IVoar
{
    public Morcego(string nome) : base(nome, TipoHabitat.Aereo) { }

    public override void Mover()
    {
        Voar();
    }

    public void Voar()
    {
        Console.WriteLine($"{Nome} voa.");
    }

}
