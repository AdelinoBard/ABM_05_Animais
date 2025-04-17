using ABM_Animais.Animais;
using ABM_Animais.Helpers;
using ABM_Animais.Base;
using ABM_Animais.Enums;

class Program
{
    static List<Animal> animais = new();

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        PopularAnimaisIniciais();

        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("\n🌿 MENU - ABM_Animais 🌿");
            Console.WriteLine("1. Listar animais");
            Console.WriteLine("2. Adicionar novo animal");
            Console.WriteLine("3. Interagir com animal");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ListarAnimais();
                    break;
                case "2":
                    AdicionarAnimal();
                    break;
                case "3":
                    InteragirComAnimal();
                    break;
                case "4":
                    sair = true;
                    Console.WriteLine("Saindo... Até logo!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void PopularAnimaisIniciais()
    {
        animais.Add(new Cachorro("AmyRoma"));
        animais.Add(new Morcego("Drácula"));
        animais.Add(new Ornitorrinco("Toto"));
        animais.Add(new Pato("Donald"));
        animais.Add(new Galinha("Carijó"));
    }

    static void ListarAnimais()
    {
        Console.WriteLine("\n📋 Lista de Animais:");
        for (int i = 0; i < animais.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {animais[i].Nome} ({animais[i].GetType().Name})");
        }
    }

    static void AdicionarAnimal()
    {
        Console.WriteLine("\n🆕 Adicionar Novo Animal");
        Console.WriteLine("Tipos disponíveis:");
        Console.WriteLine("1. Cachorro");
        Console.WriteLine("2. Morcego");
        Console.WriteLine("3. Ornitorrinco");
        Console.WriteLine("4. Pato");
        Console.WriteLine("5. Galinha");
        Console.Write("Escolha o tipo: ");
        string? tipo = Console.ReadLine();

        Console.Write("Digite o nome do animal: ");
        string? nome = Console.ReadLine();

        Animal? novoAnimal = tipo switch
        {
            "1" => new Cachorro(nome ?? "Sem Nome"),
            "2" => new Morcego(nome ?? "Sem Nome"),
            "3" => new Ornitorrinco(nome ?? "Sem Nome"),
            "4" => new Pato(nome ?? "Sem Nome"),
            "5" => new Galinha(nome ?? "Sem Nome"),
            _ => null
        };
        
        if (novoAnimal is not null)
        {
            animais.Add(novoAnimal);
            Console.WriteLine($"{novoAnimal.Nome} foi adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
        }
    }

    static void InteragirComAnimal()
    {
        if (animais.Count == 0)
        {
            Console.WriteLine("Nenhum animal para interagir.");
            return;
        }

        ListarAnimais();
        Console.Write("Escolha o número do animal: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= animais.Count)
        {
            var animal = animais[index - 1];
            Console.WriteLine($"\n🔎 Interagindo com {animal.Nome}:");
            AnimalHelper.ExibirResumo(animal);
            animal.Mover();
            animal.Comer();
            animal.Comer("ração");

            if (animal is Mamifero m) m.Amamentar();
            if (animal is Ave a) a.BotarOvos();
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }
}
