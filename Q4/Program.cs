/*-------------------------------------------------------------------------------------------------
Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
• Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
• Mana maior que 30.
• Vida do inimigo menor que 50%.
• Nível do jogador maior que 5.

@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo
@Data: 23/08/2024
-------------------------------------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        double mana, vidai, nivel;

        System.Console.WriteLine("Quando de mana voce possui?");
        double.TryParse(System.Console.ReadLine(), out mana);

        System.Console.WriteLine("Quando de vida seu inimigo tem? (Escreva em porcentagem)");
        double.TryParse(System.Console.ReadLine(), out vidai);

        System.Console.WriteLine("Quando de nivel voce possui?");
        double.TryParse(System.Console.ReadLine(), out nivel);

        if(mana > 30 && vidai < 50 && nivel > 5){
            System.Console.WriteLine("Ataque Especial realizado!");
        }
        else if(mana < 30 && vidai < 50 && nivel > 5){
            System.Console.WriteLine("Mana insuficiente");
        }
        else if(mana > 30 && vidai > 50 && nivel > 5){
            System.Console.WriteLine("Vida do inimigo muito alta");
        }
        else if(mana > 30 && vidai < 50 && nivel < 5){
            System.Console.WriteLine("Nível insuficiente");
        }
        else{
            System.Console.WriteLine("Falha geral");
        }
        System.Console.WriteLine("Clique qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}
