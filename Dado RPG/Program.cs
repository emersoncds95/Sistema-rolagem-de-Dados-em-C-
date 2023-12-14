void LogoTitulo()
{
    Console.WriteLine("Bem-vindo(a) ao:");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine(@"
██████╗░░█████╗░██████╗░░█████╗░  ██████╗░██████╗░░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔════╝░
██║░░██║███████║██║░░██║██║░░██║  ██████╔╝██████╔╝██║░░██╗░
██║░░██║██╔══██║██║░░██║██║░░██║  ██╔══██╗██╔═══╝░██║░░╚██╗
██████╔╝██║░░██║██████╔╝╚█████╔╝  ██║░░██║██║░░░░░╚██████╔╝
╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░  ╚═╝░░╚═╝╚═╝░░░░░░╚═════╝░");
    Console.WriteLine("-----------------------------------------------------------");
};

void MenuPrincipal()
{
    Console.Clear();
    LogoTitulo();
    Console.WriteLine("\nOpções de dados");
    Console.WriteLine("\n1 - Rolar d4");
    Console.WriteLine("2 - Rolar d6");
    Console.WriteLine("3 - Rolar d8");
    Console.WriteLine("4 - Rolar d10");
    Console.WriteLine("5 - Rolar d12");
    Console.WriteLine("6 - Rolar d20");

    Console.Write("\nEscolha a opção de Dado desejado:");
    string opcaoEscolhida = Console.ReadLine()!;
    int dadoEscolhido = int.Parse(opcaoEscolhida);

    switch (dadoEscolhido)
    {
        case 1: RolarD4();
            break;
        case 2:
            RolarD6();
            break;
        case 3:
            RolarD8();
            break;
        case 4:
            RolarD10();
            break;
        case 5:
            RolarD12();
            break;
        case 6:
            RolarD20();
            break;
    };

};

// -------------------------------------------------D4-------------------------------------------------------
void RolarD4()
{
    Console.Clear();

    Console.WriteLine("Opção escolhida: Rolar d4");
    Console.WriteLine("\nQuantos dados deseja jogar?");
    Console.WriteLine("\n1 - Rolar 1 dado");
    Console.WriteLine("2 - Rolar 2 dados");
    string quantidadeDados = Console.ReadLine()!;
    int quantidadeDadosEscolhido = int.Parse(quantidadeDados);


    switch (quantidadeDadosEscolhido)
    {
        case 1:
            Console.WriteLine("Rolando dado...");
            Thread.Sleep(2000);

            Random random = new Random();

            // Gera um número aleatório entre 1 e 4
            int numeroSorteado = random.Next(1, 5);

            // Exibe o número sorteado
            Console.Write("Valor do dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numeroSorteado);
            Console.ResetColor(); // Restaurar a cor padrão
            break;

        case 2:
            Console.WriteLine("Rolando dados...");
            Thread.Sleep(2000);
            Random random2 = new Random();
            Random random3 = new Random();

            // Gera números aleatórios entre 1 e 4
            int numeroSorteado2 = random2.Next(1, 5);
            int numeroSorteado3 = random3.Next(1, 5);

            Console.Write("\nPrimeiro dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{numeroSorteado2}");
            Console.ResetColor(); // Restaurar a cor padrão
            Console.Write(", Segundo dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{numeroSorteado3}");
            Console.ResetColor(); // Restaurar a cor padrão
            break;
    };

    Console.WriteLine("Precione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();


};

// -------------------------------------------------D6-------------------------------------------------------
void RolarD6()
{
    Console.Clear();
    Console.WriteLine("Opção escolhida: Rolar d6");
    Console.WriteLine("\nQuantos dados deseja jogar?");
    Console.WriteLine("\n1 - Rolar 1 dado");
    Console.WriteLine("2 - Rolar 2 dados");
    string quantidadeDados = Console.ReadLine()!;
    int quantidadeDadosEscolhido = int.Parse(quantidadeDados);

    switch (quantidadeDadosEscolhido)
    {
        case 1:
            Console.WriteLine("Rolando dado...");
            Thread.Sleep(2000);

            Random random = new Random();

            // Gera um número aleatório entre 1 e 4
            int numeroSorteado = random.Next(1, 7);

            // Exibe o número sorteado
            Console.Write("Valor do dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numeroSorteado);
            Console.ResetColor(); // Restaurar a cor padrão
            break;

        case 2:
            Console.WriteLine("Rolando dados...");
            Thread.Sleep(2000);
            Random random2 = new Random();
            Random random3 = new Random();

            // Gera números aleatórios entre 1 e 4
            int numeroSorteado2 = random2.Next(1, 7);
            int numeroSorteado3 = random3.Next(1, 7);

            Console.Write("\nPrimeiro dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{numeroSorteado2}");
            Console.ResetColor(); // Restaurar a cor padrão
            Console.Write(", Segundo dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{numeroSorteado3}");
            Console.ResetColor(); // Restaurar a cor padrão
            break;
    };
    Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();

};

// -------------------------------------------------D8-------------------------------------------------------
void RolarD8()
{
    Console.Clear();
    Console.WriteLine("Opção escolhida: Rolar d8");
    Console.WriteLine("\nQuantos dados deseja jogar?");
    Console.WriteLine("\n1 - Rolar 1 dado");
    Console.WriteLine("2 - Rolar 2 dados");
    string quantidadeDados = Console.ReadLine()!;
    int quantidadeDadosEscolhido = int.Parse(quantidadeDados);

    switch (quantidadeDadosEscolhido)
    {
        case 1:
            Console.WriteLine("Rolando dado...");
            Thread.Sleep(2000);

            Random random = new Random();

            // Gera um número aleatório entre 1 e 4
            int numeroSorteado = random.Next(1, 9);

            // Exibe o número sorteado
            Console.Write("Valor do dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numeroSorteado);
            Console.ResetColor(); // Restaurar a cor padrão
            break;

        case 2:
            Console.WriteLine("Rolando dados...");
            Thread.Sleep(2000);
            Random random2 = new Random();
            Random random3 = new Random();

            // Gera números aleatórios entre 1 e 4
            int numeroSorteado2 = random2.Next(1, 9);
            int numeroSorteado3 = random3.Next(1, 9);

            Console.Write("\nPrimeiro dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{numeroSorteado2}");
            Console.ResetColor(); // Restaurar a cor padrão
            Console.Write(", Segundo dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{numeroSorteado3}");
            Console.ResetColor(); // Restaurar a cor padrão
            break;
    };
    Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();

};

// -------------------------------------------------D10-------------------------------------------------------
void RolarD10()
{
    Console.Clear();
    Console.WriteLine("Opção escolhida: Rolar d10");
    Console.WriteLine("\nQuantos dados deseja jogar?");
    Console.WriteLine("\n1 - Rolar 1 dado");
    Console.WriteLine("2 - Rolar 2 dados");
    string quantidadeDados = Console.ReadLine()!;
    int quantidadeDadosEscolhido = int.Parse(quantidadeDados);

    switch (quantidadeDadosEscolhido)
    {
        case 1:
            Console.WriteLine("Rolando dado...");
            Thread.Sleep(2000);

            Random random = new Random();

            // Gera um número aleatório entre 1 e 4
            int numeroSorteado = random.Next(1, 11);

            // Exibe o número sorteado
            Console.Write("Valor do dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numeroSorteado);
            Console.ResetColor(); // Restaurar a cor padrão
            break;

        case 2:
            Console.WriteLine("Rolando dados...");
            Thread.Sleep(2000);
            Random random2 = new Random();
            Random random3 = new Random();

            // Gera números aleatórios entre 1 e 4
            int numeroSorteado2 = random2.Next(1, 11);
            int numeroSorteado3 = random3.Next(1, 11);

            Console.Write("\nPrimeiro dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{numeroSorteado2}");
            Console.ResetColor(); // Restaurar a cor padrão
            Console.Write(", Segundo dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{numeroSorteado3}");
            Console.ResetColor(); // Restaurar a cor padrão
            break;
    };
    Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();

};

// -------------------------------------------------D12-------------------------------------------------------
void RolarD12()
{
    Console.Clear();
    Console.WriteLine("Opção escolhida: Rolar d12");
    Console.WriteLine("\nQuantos dados deseja jogar?");
    Console.WriteLine("\n1 - Rolar 1 dado");
    Console.WriteLine("2 - Rolar 2 dados");
    string quantidadeDados = Console.ReadLine()!;
    int quantidadeDadosEscolhido = int.Parse(quantidadeDados);

    switch (quantidadeDadosEscolhido)
    {
        case 1:
            Console.WriteLine("Rolando dado...");
            Thread.Sleep(2000);

            Random random = new Random();

            // Gera um número aleatório entre 1 e 4
            int numeroSorteado = random.Next(1, 13);

            // Exibe o número sorteado
            Console.Write("Valor do dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numeroSorteado);
            Console.ResetColor(); // Restaurar a cor padrão
            break;

        case 2:
            Console.WriteLine("Rolando dados...");
            Thread.Sleep(2000);
            Random random2 = new Random();
            Random random3 = new Random();

            // Gera números aleatórios entre 1 e 4
            int numeroSorteado2 = random2.Next(1, 13);
            int numeroSorteado3 = random3.Next(1, 13);

            Console.Write("\nPrimeiro dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{numeroSorteado2}");
            Console.ResetColor(); // Restaurar a cor padrão
            Console.Write(", Segundo dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{numeroSorteado3}");
            Console.ResetColor(); // Restaurar a cor padrão
            break;
    };
    Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();

};
// -------------------------------------------------D20-------------------------------------------------------
void RolarD20()
{
    Console.Clear();
    Console.WriteLine("Opção escolhida: Rolar d20");
    Console.WriteLine("\nQuantos dados deseja jogar?");
    Console.WriteLine("\n1 - Rolar 1 dado");
    Console.WriteLine("2 - Rolar 2 dados");
    string quantidadeDados = Console.ReadLine()!;
    int quantidadeDadosEscolhido = int.Parse(quantidadeDados);

    switch (quantidadeDadosEscolhido)
    {
        case 1:
            Console.WriteLine("Rolando dado...");
            Thread.Sleep(2000);

            Random random = new Random();

            // Gera um número aleatório entre 1 e 4
            int numeroSorteado = random.Next(1, 21);

            // Exibe o número sorteado
            Console.Write("Valor do dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numeroSorteado);
            Console.ResetColor(); // Restaurar a cor padrão
            break;

        case 2:
            Console.WriteLine("Rolando dados...");
            Thread.Sleep(2000);
            Random random2 = new Random();
            Random random3 = new Random();

            // Gera números aleatórios entre 1 e 4
            int numeroSorteado2 = random2.Next(1, 21);
            int numeroSorteado3 = random3.Next(1, 21);

            Console.Write("\nPrimeiro dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{numeroSorteado2}");
            Console.ResetColor(); // Restaurar a cor padrão
            Console.Write(", Segundo dado: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{numeroSorteado3}");
            Console.ResetColor(); // Restaurar a cor padrão
            break;
    };
    Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();

};

LogoTitulo();
MenuPrincipal();
