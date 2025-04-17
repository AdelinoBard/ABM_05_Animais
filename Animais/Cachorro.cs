namespace ABM_Animais.Animais;

using ABM_Animais.Base;
using ABM_Animais.Enums;
using ABM_Animais.Interfaces;
public class Cachorro : Mamifero, IAndar
{
    public Cachorro(string nome) : base(nome, TipoHabitat.Terrestre) { }

    public override void Mover()
    {
        Andar();
    }

    public void Andar()
    {
        Console.WriteLine($"{Nome} anda.");
    }
}
