/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação em Batalha
• Contextualização: Em um jogo de RPG, o jogador ganha pontos após
derrotar inimigos em uma batalha. A pontuação máxima é de 100 pontos,
e é determinada pela quantidade de inimigos derrotados, a duração da
batalha e se o jogador sofreu danos crítico.
• Comando: Crie um programa que calcule a pontuação final do jogador. 
O programa deve receber o número de inimigos derrotados, 
a duração da batalha em minutos e se o jogador sofreu danos crítico (sim ou não). 
A pontuação é calculada da seguinte forma:
• 10 pontos para cada inimigo derrotado;
• Subtraia 10 pontos se a batalha durar mais de 5 minutos;
• Subtraia 10 pontos se o jogador sofreu dano crítico;

@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo Lima
@Data: 23/08/2024
---------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        int bixomorto, tempo, crit, temcri = 0;

        System.Console.Write("Inimigos derrotados: ");
        int.TryParse(Console.ReadLine(), out bixomorto);

        System.Console.Write("Tempo de batalha (em minutos): ");
        int.TryParse(Console.ReadLine(), out tempo);

        System.Console.Write("Tomou critico? 1 = sim, 2 = não ");
        int.TryParse(Console.ReadLine(), out crit);

        if(crit == 1){
            crit =- 10;
            temcri =+ crit;
        }
        if(tempo >= 5){
            tempo =- 10;
            temcri =+ tempo;
        }
        System.Console.WriteLine($"Sua pontuação total foi: {bixomorto * 10 + temcri}");

        System.Console.WriteLine("Pressione qualquer tecla para fechar o programa");
        Console.ReadKey();
    }
}