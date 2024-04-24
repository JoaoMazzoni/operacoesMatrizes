int qtdlinhas = 3, qtdcolunas = 4;

float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

void imprimirMatriz(float[,] matriz)
{
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        Console.WriteLine();

        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + "| ");
        }

    }
}


for (int linha = 0; linha < qtdlinhas; linha++) //Laço da linha
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //Laço da coluna
    {
        matriz1[linha, coluna] = new Random().Next(0, 10);
    }
}

imprimirMatriz(matriz1);


Console.ReadLine()
    ;
for (int linha = 0; linha < qtdlinhas; linha++) //Laço da linha
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //Laço da coluna
    {
        matriz2[linha, coluna] = new Random().Next(1, 10);
    }

}


imprimirMatriz(matriz2);


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

imprimirMatriz(matriz3);


Console.WriteLine("\n\n-------------------------------------------------");
Console.WriteLine("Subtração: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}

imprimirMatriz(matriz3);


Console.WriteLine("\n\n-------------------------------------------------");
Console.WriteLine("Multiplicação: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}

imprimirMatriz(matriz3);


Console.WriteLine("\n\n-------------------------------------------------");
Console.WriteLine("Divisão: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        if (matriz2[linha, coluna] != 0)
        {
            matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
        }
        else
        {
            matriz3[linha, coluna] = float.NaN;
        }
    }
}

imprimirMatriz(matriz3);

Console.ReadLine();