int qtdlinhas = 3, qtdcolunas = 4;

int[,] matriz1 = new int[qtdlinhas, qtdcolunas];
int[,] matriz2 = new int[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];



for (int linha = 0; linha < qtdlinhas; linha++) //Laço da linha
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //Laço da coluna
    {
        matriz1[linha, coluna] = new Random().Next(0, 10);
    }
}


for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();

    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz1[linha, coluna] + " ");
    }

}

Console.ReadLine()
    ;
for (int linha = 0; linha < qtdlinhas; linha++) //Laço da linha
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //Laço da coluna
    {
        matriz2[linha, coluna] = new Random().Next(1, 10);
    }

}



for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();

    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }

}

Console.ReadLine();
Console.WriteLine("\n\n-------------------------------------------------");
Console.WriteLine("Soma: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();

    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }

}

Console.WriteLine("\n\n-------------------------------------------------");
Console.WriteLine("Subtração: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();

    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }

}

Console.WriteLine("\n\n-------------------------------------------------");
Console.WriteLine("Multiplicação: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();

    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }

}

Console.WriteLine("\n\n-------------------------------------------------");
Console.WriteLine("Divisão: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
    }
}

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();

    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write("{0:0.00}| ", matriz3[linha, coluna]);
    }

}