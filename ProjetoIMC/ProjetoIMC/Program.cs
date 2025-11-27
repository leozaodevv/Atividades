// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira o peso: (em Kg | ex: 70)");
double pesoEmKg = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira a altura: (em Metros | ex: 1,70)");
double alturaEmMetros = Convert.ToDouble(Console.ReadLine());

if (alturaEmMetros == 0)
{
    Console.WriteLine("A altura deve ser maior que zero.");
    return;
}

double alturaAoQuadrado = alturaEmMetros * alturaEmMetros;
double imc = pesoEmKg / alturaAoQuadrado;
double imcFormatado = Math.Round(imc, 2);

string sit = "";

if (imcFormatado < 18.5)
{
    sit = "Abaixo do Peso";
}
else if (imcFormatado >= 18.5 && imcFormatado <= 24.9)
{
    sit = "Normal";
}
else if (imcFormatado >= 25 && imcFormatado <= 29.9)
{
    sit = "Sobre Peso";
}
else
{
    sit = "Obesidade";
}

Console.WriteLine($"O IMC calculado é: {imcFormatado} | Situação: {sit}.");

