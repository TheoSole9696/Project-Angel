//Aqui é o local onde os menus do jogo são armazenados
static class InterfaceConsole //aqui é onde armazenamos os menus do jogo, como o menu de ações, o menu de status e o menu de upgrades
{
    public static void MostrarAbertura()
    {
        Console.WriteLine("\n \n==========ELECTRIC ANGEL=========="); //Introdução do jogo para o jogador
        Console.WriteLine("         by Matheo & Fucks             "); //O nome do cara é "Fucks" KKKKKKKK
        Console.WriteLine("\n \n \n \n \npress any key to continue...\n");
        Console.WriteLine("===============================================");
        Console.ReadKey();
    }
    public static void MostrarLobby()
    {
        //Aqui é o local onde o jogador irá decidir se ele quer iniciar uma nova partida ou melhorar seus status
        Console.WriteLine("Huh? You back! They really did a number on you huh? \n...");
        Console.ReadKey();
        Console.WriteLine("===============================================");
        Console.WriteLine("1 - Go to the store");
        Console.WriteLine("2 - Start the fight");
        Console.WriteLine("===============================================");
    }
    public static string MostrarLoja(EstadoJogo estado)
    {
        Console.WriteLine("========== STORE ==========");
        Console.WriteLine("\n---[1 - Upgrades]---");
        Console.WriteLine("\n---[2 - Exit]---");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine(" Intel: " + estado.intel + "");
        Console.WriteLine("-------------------------------------------");
        
        string escolhaLoja = Console.ReadLine()!;
        switch (escolhaLoja)
        {
            case "1":
                return "1";

            case "2":
                return "2";
            default:
                Console.WriteLine("Invalid option!");
                Console.ReadKey();
                return "0";
        }
    }
    public static void MostrarStatus(EstadoJogo estado)
    {
        Console.WriteLine($"\n_______________ROUND {estado.round}_____________"); //Exibição do round atual do jogo
        //Isso aqui representa os status de vida do jogador e de seus inimigos, para que o jogador possa ter uma noção de como está a batalha
        Console.WriteLine("===================================");
        Console.WriteLine("\nHealth: " + estado.vida + "");
        Console.WriteLine($"Intel: {estado.intel:F2}\n");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("\nEnemy's Health: " +estado.vidaInimigo + "\n");
        Console.WriteLine("===================================");
    }
    public static void MostrarAcoes()
    {
        Console.WriteLine("\n\nChoose your action:\n");
        //Aqui é o local onde o jogador irá decidir qual ação ele quer realizar
        Console.WriteLine("1 - Attack");
        Console.WriteLine("2 - Heal");
        Console.WriteLine("3 - Special Attack  ");
    }
}