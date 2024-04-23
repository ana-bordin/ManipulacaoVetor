/*
2. faça um programa que leia 10 números inteiros e imprima e faça os seguintes itens:
	a. imprima o vetor lido;
	b. imprima o vetor de trás pra frente;
	c. imprima até a metade do vetor;
	d. imprima os valores impares em um novo vetor, sem os valores zero;
	e. imprima os valores pares em um novo vetor, sem os valores zero;
*/

int tamanho = 10, contadorPar = 0, contadorImpar = 0;
int[] numeros = new int[tamanho];
int[] pares = new int[tamanho];
int[] impares = new int[tamanho];
int metade = Convert.ToInt32(tamanho / 2);

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número;");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Vetor:");
for (int i = 0; i < tamanho; i++)
{
    Console.Write($"{numeros[i]}; ");
}

Console.WriteLine("\nVetor ao contrário:");
for (int i = tamanho - 1; i >= 0; i--)
{
    Console.Write($"{numeros[i]}; ");
}

Console.WriteLine("\nVetor até a metade:");
for (int i = 0; i < metade; i++)
{
    Console.Write($"{numeros[i]}; ");
}

for (int i = 0;i < tamanho; i++)
{
	if (numeros[i] % 2 == 0)
	{
		pares[contadorPar] = numeros[i];
		contadorPar++;
	}
	else
    {
        impares[contadorImpar] = numeros[i];
        contadorImpar++;
    }
}

Console.WriteLine("\nVetor de pares:");
for (int i = 0; i < tamanho; i++)
{
	if (pares[i] != 0)
	{
		Console.Write($"{pares[i]}; ");
	}
}

Console.WriteLine("\nVetor de impares:");
for (int i = 0; i < tamanho; i++)
{
	if (impares[i] != 0)
	{
	    Console.Write($"{impares[i]}; ");
	}
}