/*-------------------------------------------------------------------
• Contextualização: Em um jogo de RPG, cada classe de personagem 
(Guerreiro, Arqueiro, Mago) possui requisitos diferentes para a escolha
da armadura ideal. A armadura é considerada ideal se a defesa oferecida 
for alta o suficiente para a classe e se a penalidade de agilidade for aceitável.
• Comando: Crie um programa que receba a classe do personagem, o valor
de defesa da armadura e a penalidade de agilidade. O programa deve informar se 
a armadura é adequada ou não para a classe.
• Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
• Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
• Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.

@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo
@Data: 23/08/2024
---------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        int agidebuff, def, defideal = 0, debuffideal = 0;
        string? classe;
        while(true){
            Console.Write(@"Escolha entre essas classes:
Guerreiro
Arqueiro
Mago

Escolha: ");
            classe = Console.ReadLine();
            if(classe.ToLower() != "guerreiro" && classe != "mago" && classe != "arqueiro"){
                Console.Clear();
                Console.WriteLine(@"Escreva uma classe valida.");
            }
            else{
                break;
            }
        }
        System.Console.Write("Digite a defesa da sua armadura: ");
        int.TryParse(Console.ReadLine(), out def);

        System.Console.Write("Qual e a penalidade de agilidade da sua armadura: ");
        int.TryParse(Console.ReadLine(), out agidebuff);
        
        switch(classe){
            case "mago":
            defideal = 20;
            debuffideal = 40;
            break;
            case "guerreiro":
            debuffideal = 20;
            defideal = 50;
            break;
            case "arqueiro":
            defideal = 30;
            debuffideal = 10;
            break;
        }
        if(def > defideal && agidebuff < debuffideal){
            Console.WriteLine("Sua armadura e ideal!");
        }
        else{
            Console.WriteLine("Sua armadura NÃO e ideal!");
        }

        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}