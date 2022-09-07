using IMC;

Console.WriteLine("Cálculo IMC!\n");

Calculo[] calculos = new Calculo[1];
calculos[0] = new Calculo();
double imc = 0;

for (int i = 0; i < calculos.Length; i++)
{
    Console.WriteLine("Informe sua altura em metros: ");
    calculos[i].Altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n");

    Console.WriteLine("Informe seu peso em kg: ");
    calculos[i].Peso = Convert.ToDouble(Console.ReadLine());

    imc = calculos[i].Peso / (calculos[i].Altura * calculos[i].Altura);
}
if (imc < 18.5)
{
    Console.WriteLine($"Seu IMC é de {imc}. Você está abaixo do peso");
}
else if (imc > 18.5 && imc <= 24.9)
{
    Console.WriteLine($"Seu IMC é de {imc}. Você está no peso normal");
}

else if (imc >= 25.5 && imc <= 29.9)
{
    Console.WriteLine($"Seu IMC é de {imc}. Você está acima do peso (sobrepeso)");
}
else if (imc >= 30 && imc <= 34.9)
{
    Console.WriteLine($"Seu IMC é de {imc}. Você está em estágio de obesidade I)");
}
else if (imc >= 35 && imc <= 39.9)
{
    Console.WriteLine($"Seu IMC é de {imc}. Você está em estágio de obesidade II)");
}
else if (imc > 40)
{
    Console.WriteLine($"Seu IMC é de {imc}. Você está em estágio de obesidade III)");
}
