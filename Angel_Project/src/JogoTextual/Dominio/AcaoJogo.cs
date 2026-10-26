//Aqui ficam as ações do jogador (combate, melhorias e mais algumas por vir)
public static class AcaoJogo
{
    public static void MostrarUpgrades() //Aqui é onde o jogador irá melhorar seus status
    {
        //EM ANDAMENTO
        //Também gostaria de mencionar que teremos dois tipos de upgrades: Status e Equipamentos, mais sobre isso no Itch.Io :)
    }
    public static bool MostrarMovimentos(dynamic estado) //Aqui é onde o jogador irá escolher seus movimentos durante o combate
    {
        switch (Console.ReadLine())
        {
        case "1":
            Console.WriteLine("You've dealt " + estado.atk + " damage to the enemy!");
            estado.vidaInimigo -= estado.atk;
            estado.contador_atk_especial++;

            if (estado.contador_atk_especial >= 3)
            {
                Console.WriteLine("Special atack ready for use!");
            }
            return true;

        case "2":
            Console.WriteLine("You've healed yourself for " + estado.cura + " health!");
            estado.vida += estado.cura;
            return true;

        case "3":
            if (estado.contador_atk_especial < 3)
            {
                Console.WriteLine("You need to use 3 normal attacks before using the special attack!");
                return false;
            }
            else
            {
                Console.WriteLine("You've dealt " + estado.atk_especial + " damage to the enemy!");
                estado.vidaInimigo -= estado.atk_especial;
                estado.contador_atk_especial = 0; //Faz o contador voltar a zero depois de utilizar o ataque especial
            }
            return true;

        default:
            return false;
        }
    }
}

