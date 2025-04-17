namespace ABM_Animais.Interfaces;
public interface IAndar  // Declaração de uma interface chamada IAndar
{
    void Andar();  // Define um contrato que exige a implementação do método Andar()
}

/*
1. **Interface**:
   - `IAndar` é uma interface (indicado pelo prefixo `I` convencional em C#)
   - Interfaces definem contratos que classes devem implementar, mas não fornecem implementação

2. **Método Andar()**:
   - Qualquer classe que implementar `IAndar` deve fornecer uma implementação concreta deste método
   - O método não tem corpo/modificadores na interface - apenas estabelece a assinatura requerida

3. **Propósito**:
   - Permite polimorfismo - diferentes classes podem implementar `Andar()` de formas distintas
   - Cria um padrão que pode ser usado para type checking em tempo de compilação
   - Útil para desacoplar código (depender da interface, não de implementações concretas)

*/
