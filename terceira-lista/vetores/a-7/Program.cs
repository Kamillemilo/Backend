﻿// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.


int[] numeros = new int[15];

 for (var i = 0; i < 15; i++)
 {
    Console.WriteLine($"Digite o {i+1}º número:");
    numeros[i] = int.Parse(Console.ReadLine());

}
Array.Reverse(numeros);

foreach (var item in numeros)
{
    Console.WriteLine(item);
     
}
 

