namespace ABM_Animais.Helpers;

using ABM_Animais.Base;
public static class AnimalHelper
{
    public static void ExibirResumo(Animal animal)
    {
        Console.WriteLine($"Resumo:");
        Console.WriteLine($"Nome: {animal.Nome}");
        Console.WriteLine($"Classe: {animal.GetType().Name}");
        Console.WriteLine($"Habitat: {animal.Habitat}");

        switch (animal)
        {
            case Mamifero:
                Console.WriteLine("Tipo: Mamífero");
                break;
            case Ave:
                Console.WriteLine("Tipo: Ave");
                break;
            default:
                Console.WriteLine("Tipo: Outro");
                break;
        }
    }
}