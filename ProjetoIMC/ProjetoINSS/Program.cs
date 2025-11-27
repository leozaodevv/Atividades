// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira seu salario: ");
double sal = Convert.ToDouble(Console.ReadLine());
double des = 0;
int fx = 0;
if(sal <= 1100)
{
    des = sal * 0.075;
    fx = 1;
}
else if(sal >= 1100.10 && sal <= 2203.48){
    des = sal * 0.09;   
    fx = 2;
}
else if (sal >= 2203.49 && sal <= 3305.22)
{
    des = sal * 0.12;
    fx = 3;
}
else if (sal >= 3305.23)
{
    des = sal * 0.14;
    fx = 4;
}
Console.WriteLine($"Salario: R${Math.Round(sal,2)} | Contribuição INSS: R${Math.Round(des, 2)} | Faixa: {fx}");


