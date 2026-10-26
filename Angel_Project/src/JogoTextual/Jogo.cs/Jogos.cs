class Jogo
{
    public void Executar()
    {
      InterfaceConsole.MostrarAbertura();  //Exibição da abertura do jogo
      EstadoJogo estado = new EstadoJogo(); //Controla as variáveis do jogador e dos inimigos
      //------Loop principal do jogo------
      bool rodada = false; bool lobby = true;
      
    while (lobby)//local onde o jogador ira melhorar seus equipamentos
    {
      InterfaceConsole.MostrarLobby();    //Exibição do lobby do jogo
      switch (Console.ReadLine())
      {
        case "1":
        {  
          bool lojaAberta = true;
          while (lojaAberta)
          {
            string escolhaLoja = InterfaceConsole.MostrarLoja(estado);    //Exibição da loja do jogo
            if (escolhaLoja == "2")
            {
              lojaAberta = false;
            }
          }
          break;
        }  
        case "2":
        {
          rodada = true;
          Dialogos.MostrarDialogo("");   //Exibição dos dialogos do jogo
          break;
        }
      }
      while (rodada)//onde o loop principal da gameplay acontece
      {
        if (estado.vida <= 0) //exibe a mensagem de derrota e reinicia o jogo
        {
          Console.WriteLine("-------------------------------------------");
          Console.WriteLine("death awaits us all, but your fight is not over yet. \n...");
          Console.WriteLine("Returning to lobby...");
          Console.WriteLine("-------------------------------------------");
          Console.ReadKey();

          estado.vida = estado.vidaMaxJogador; // Resetar os atributos do jogador
          estado.vidaMaxInimigo = 60; estado.vidaInimigo = 60; estado.atkInimigo = 10; // Resetar os atributos do inimigo
          estado.round = 1;  estado.contador_atk_especial = 0; // Reiniciar o round e o ataque especial
          rodada = false;
          break;
        }
        else
        {
          Console.WriteLine("An enemy appears!");
          InterfaceConsole.MostrarStatus(estado);     //Exibição do status do jogador e inimigo
          InterfaceConsole.MostrarAcoes();    //Exibição das ações do jogo
          if (estado.vidaInimigo <= 0)
          {
            Console.WriteLine("Enemy defeated!\n");

            estado.round++; // Aumenta os atributos do inimigo em 25%
            estado.vidaMaxInimigo = (int)(estado.vidaMaxInimigo * 1.25);
            estado.atkInimigo = (int)(estado.atkInimigo * 1.25);
            estado.vidaInimigo = estado.vidaMaxInimigo; // Prepara o próximo inimigo
            estado.vida = 100; // Recupera a vida do jogador
            estado.intel *= 1.25; //Multiplicador de inteligencia recebida por round

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Starting round {estado.round}!...");
            Console.WriteLine("-----------------------------------");
          }
          bool acao_valida = AcaoJogo.MostrarMovimentos(estado);    //Exibição das ações do jogo
          
          if (acao_valida && estado.vida > 0 && estado.vidaInimigo > 0)
          {
            estado.vida = AcaoInimigo(estado.vida, estado.atkInimigo);
          }
        }
      }
    }
  }
  static int AcaoInimigo(int vida, int atkInimigo)
  {
    //declaração de variáveis (inimigo)
      Console.WriteLine("\nEnemy's turn!");
      vida -= atkInimigo;
      Console.WriteLine("The enemy attacked you and dealt "
          + atkInimigo + " damage!");
      Console.WriteLine("Your health: " + vida);
      return vida;
  } 
} 
