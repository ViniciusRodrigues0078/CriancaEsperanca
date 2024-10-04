Console.WriteLine("Bem vindo ao criança esperança!");
Console.WriteLine("""
Tecle [1] para doar R$10,00
Tecle [2] para doar R$20,00
Tecle [3] para doar R$30,00
Tecle [4] para doar R$40,00
Tecle [5] para doar outro valor
Tecle [0] para cancelar.
""");
int doacao = int.Parse(Console.ReadLine());
switch (doacao) {
    case 1:
    Console.WriteLine("Parabéns! Você doou 10 reais.");
    break;
    case 2:
    Console.WriteLine("Parabéns! Você doou 20 reais.");
    break;
    case 3:
    Console.WriteLine("Parabéns! Você doou 30 reais.");
    break;
    case 4:
    Console.WriteLine("Parabéns! Você doou 40 reais.");
    break;
    case 5:
    Console.WriteLine("Digite o valor que deseja doar: ");
    int valor = int.Parse(Console.ReadLine());
    Console.WriteLine("Parabéns! Você doou " + valor + "reais.");
    break;
    case 0:
    Console.WriteLine("Doação cancelada.");
    break;
    case > 5:
    Console.WriteLine("Opção inválida");
    break;
}