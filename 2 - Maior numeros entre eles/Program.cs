// Programa para medir qual numero é maior que o outro

Console.WriteLine($"Bem vindo, vamos começar. digite um numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite outro numero, naõ pode ser igual");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite outro numero, lmebramdo, não pode ser igual");
int num3 = int.Parse(Console.ReadLine());

if(num1 > num2 && num2 > num3)
{
    Console.WriteLine($" O numero {num1} é maior que o {num2} e o mesmo é maior que o numero {num3}. Logo entre eles, o {num1} é o maior");
}
else if ( num2 > num1 && num1 > num3)
{
    Console.WriteLine($"O numero {num2} é maior que o {num1} e o mesmo é maior que o numero {num3}. Logo entre eles, o {num2} é o maior");
}

else if( num3 > num1 && num1 > num2)
{
    Console.WriteLine($"O numero {num3} é maior que o {num1} e o mesmo é maior que o numero {num2}. Logo entre eles, o {num3} é o maior");
}

else if ( num1 > num3 && num3 > num2)
{
    Console.WriteLine($"O numero {num1} é maior que o {num3} e o mesmo é maior que o numero {num2}. Logo entre eles, o {num1} é o maior");
    
}
else if(num3 > num2 && num2 > num1)
{
    Console.WriteLine($"O numero {num3} é maior que o {num2} e o mesmo é maior que o numero {num1}. Logo entre eles, o {num3} é o maior");
    
}

else
{
    Console.WriteLine($"O numero {num2} é maior que o {num3} e o mesmo é maior que o numero {num1}. Logo entre eles, o {num1} é o maior");
    
}