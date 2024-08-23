/*
• Contextualização: Em uma missão de resgate em um jogo, o jogador deve decidir se continua
em frente para resgatar um aliado ou recua, considerando a vida restante, o número de
armadilhas conhecidas no caminho e a distância do aliado.
• Comando: Crie um programa que receba a porcentagem de vida do jogador, o número de
armadilhas conhecidas no caminho e a distância do aliado em metros. O programa deve decidir
se o jogador deve seguir em frente, tentar um resgate rápido, ou recuar, conforme as seguintes
condições:
• Se a vida for maior que 50% e as armadilhas forem menores que 3, seguir em frente.
• Se a vida for menor que 50%, as armadilhas forem menores que 2, e a distância do aliado for
menor que 10m, tentar resgate rápido.
• Caso contrário, recuar.

@Lista: 02 - Condicionais
@Autor: Mauricio Escobar Azevedo
@Data: 23/08/2024
*/
using System;
class Program{
    static void Main(string[] args){
        double vida, armadilha, distancia;

        System.Console.WriteLine("Quanto de vida voce tem?");
        double.TryParse(Console.ReadLine(), out vida);

        System.Console.WriteLine("Quantas armadilhas tem no caminho?");
        double.TryParse(Console.ReadLine(), out armadilha);

        System.Console.WriteLine("Qual e a distancia entre voce e seu aliado?");
        double.TryParse(Console.ReadLine(), out distancia);

        if(vida > 50 && armadilha < 3){
            System.Console.WriteLine("Seguir em frente");
        }
        else if(vida < 50 && armadilha < 2 && distancia < 10){
            System.Console.WriteLine("Tentar resgate rápido");
        }
        else{
            System.Console.WriteLine("Recuar");
        }
        System.Console.WriteLine("Clique qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}