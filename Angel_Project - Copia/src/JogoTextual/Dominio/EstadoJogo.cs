//Aqui ficam as variáveis do jogo
class EstadoJogo
{
    //Variáveis das rodadas no jogo
    public int round {get; set; } = 1;

    //Declarações de variáveis (jogador)
    public int vidaMaxJogador { get; set; } = 100; //Variável que será utilizada para os upgrades (EM ANDAMENTO)
    public int vida {get; set; } = 100;
    public int atk {get; set; } = 20;
    public int atk_especial {get; set; } = 35;
    public int cura {get; set; } = 20;

    //Declarações de variáveis (inimigo)
    public int vidaMaxInimigo { get; set; } = 60;
    public int vidaInimigo {get; set; } = 60;
    public int atkInimigo {get; set; } = 10;

    //Mantem o olho em ataques especiais realizados, para que o jogador não use infinitamente
    public int contador_atk_especial {get; set; } = 0;

    //Contador da pontuação da inteligência adquirida pelo jogador
    public double intel {get; set; } = 100; 
    //O jogador começa com uma volor = 100 (pode mudar no futuro por questões de balanceamento)
}

