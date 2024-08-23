/*---------------------------------------------------------------------
Questão 3: Loja de Poções
• Contextualização: Em uma loja de poções mágicas,
o jogador pode comprar poções que aumentam sua vida, mana ou resistência.
O preço das poções é fixo: Vida custa 10 moedas, Mana custa 15 moedas, 
e Resistência custa 20 moedas. Dependendo da classe do jogador, há um desconto aplicável.
• Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), 
o tipo de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. 
Calcule o preço total das poções, aplicando o desconto correspondente:
• Guerreiro recebe 10% de desconto na compra de poções de Vida.
• Mago recebe 15% de desconto na compra de poções de Mana.
• Paladino recebe 20% de desconto na compra de poções de Resistência.
• Exiba o preço total com e sem desconto.

@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo
@Data: 23/08/2024
---------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        string? classe, potion;
        int preço = 0;
        while(true){
            Console.Write(@"Qual e a sua classe?:
Guerreiro
Paladino
Mago

Escolha: ");
            classe = Console.ReadLine().ToLower();
            if(classe != "guerreiro" && classe != "mago" && classe != "paladino"){
                Console.Clear();
                Console.WriteLine(@"Escreva uma classe valida.");
            }
            else{
                break;
            }
        }
        Console.Clear();
        while(true){
            Console.Write(@"Qual o tipo da poção que deseja?:
Vida
Mana
Resistencia

Escolha: ");
            potion = Console.ReadLine().ToLower();
            if(potion != "vida"&& potion != "mana" && potion != "resistencia"){
                Console.Clear();
                Console.WriteLine(@"Escreva uma poção valida.");
            }
            else{
                break;
            }    
        }

        if(potion == "vida"){
            preço = 10;
        }
        if(potion == "mana"){
            preço = 15;
        }
        if(potion == "resistencia"){
            preço = 20;
        }
        
        
        if(classe == "guerreiro" && potion == "vida"){
            System.Console.WriteLine(@$"sua poção normalmente custaria {preço} moedas e ouro, mas ja que você e um
{classe} você vai ganhar 10% de desconto, então vai sair por 9 moedas de ouro.");
        }
        else if(classe == "mago" && potion == "mana"){
            System.Console.WriteLine(@$"sua poção normalmente custaria {preço} moedas e ouro, mas ja que você e um
{classe} você vai ganhar 15% de desconto, então vai sair por 12.75 moedas de ouro.");
        }
        else if(classe == "paladino" && potion == "resistencia"){
            System.Console.WriteLine(@$"sua poção normalmente custaria {preço} moedas e ouro, mas ja que você e um
{classe} você vai ganhar 20% de desconto, então vai sair por 16 moedas de ouro.");
        }
        else{
            System.Console.WriteLine(@$"Sua poção de {potion} senhor {classe}, vai sair por {preço} moedas de ouro.");
        }

        System.Console.WriteLine("Clique qualquer botão para continuar");
        Console.ReadKey();

    }
}