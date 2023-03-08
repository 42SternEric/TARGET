using System;
using Fibo.Models;

int num = 13; 

List<int> Lista = new List<int>(); 

for (int i = 0; i < num; i++) 
        {
        Console.WriteLine(Fibonacci.calc(i)); 
        if ((Fibonacci.calc(i))==(num)) 

        Lista.Add(num); 
        }

if (Lista.Contains(num))
    Console.WriteLine($"O valor atribuido {num} PERTENCE a sequência de Fibonacci");
else
    Console.WriteLine($"O valor atribuido {num} NÃO Pertence a sequência de Fibonacci");

//Eric Stern