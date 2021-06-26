using System;

class Pessoa 
{
public float altura;

public float peso;

public int imc;

public void mensagem(float n)
{
    if (n<18.5)
    {
        Console.WriteLine(n+". Abaixo do peso!");
    }
    else if(n>18.5 && n<25)
    {
        Console.WriteLine(n+". Peso normal!");
    }
    else if(n>25 && n<30)
    {
        Console.WriteLine(n+". Acima do peso!");
    }
    else if(n>30 && n<35)
    {
        Console.WriteLine(n+". Obesisdade I ");
    }
    else if(n>35 && n<40)
    {
        Console.WriteLine(n+". Obesisdade II ");
    }
    else if(n>=40)
    {
        Console.WriteLine(n+". Obesisdade III ");
    }


}




}
