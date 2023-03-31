// Programa para validar datas de aniversários 

Console.WriteLine($"Bem Vindo. Digite o ano que você nasceu");
int ano = int.Parse(Console.ReadLine());

if(ano <= 2013 && ano >= 1930)
{
    Console.WriteLine($"Agora me fala o mês que nasceu");
    int mes = int.Parse(Console.ReadLine());

    if (mes <= 12 && mes > 0)
    {
        Console.WriteLine($"Agora me fala o dia que nasceu");
        int dia = int.Parse(Console.ReadLine());

        if (dia <= 31 && dia > 0)
        {
            int idade = 2013 - ano;

            Console.WriteLine($"Você nasceu no dia {dia}, mês {mes} no de {ano}. Logo você tem mais ou menos {idade} anos");
        }
        else
        {
            Console.WriteLine($"dia inválido");
        }
        
    }
    
    else
    {
        Console.WriteLine($"Mes inválido");  
    }
    
}
else
{
    Console.WriteLine($"Ano invalido. digite um ano válido");

}
