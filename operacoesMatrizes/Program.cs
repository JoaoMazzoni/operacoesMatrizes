while (true)
{
    int operacao = 0;
    int qtdlinhas = 0, qtdcolunas = 0;
    bool TrueFalse = true;


    void tamanhoMatriz()
    {
        Console.Write("Digite o número de linhas: ");
        qtdlinhas = int.Parse(Console.ReadLine());
        Console.Write("\nDigite o número de colunas: ");
        qtdcolunas = int.Parse(Console.ReadLine());
    }

    tamanhoMatriz();
    float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
    float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
    float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

    void sortearMatriz(float[,] matriz)
    {

        for (int linha = 0; linha < qtdlinhas; linha++) //Laço da linha
        {
            for (int coluna = 0; coluna < qtdcolunas; coluna++) //Laço da coluna
            {
                matriz[linha, coluna] = new Random().Next(0, 10);
            }
        }
        imprimirMatriz(matriz, "\n\nMatriz Gerada\n");
    }

    void imprimirMatriz(float[,] matriz, string titulo)
    {
        Console.WriteLine(titulo);

        for (int linha = 0; linha < qtdlinhas; linha++)
        {
            Console.WriteLine();

            for (int coluna = 0; coluna < qtdcolunas; coluna++)
            {
                Console.Write(matriz[linha, coluna] + "| ");
            }

        }
    }

    void somarMatriz(float[,] matriz1, float[,] matriz2)
    {
        for (int linha = 0; linha < qtdlinhas; linha++)
        {
            for (int coluna = 0; coluna < qtdcolunas; coluna++)
            {
                matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
            }
        }
        imprimirMatriz(matriz3, "\nMatriz de Soma\n");
    }
    void subtrairMatriz(float[,] matriz1, float[,] matriz2)
    {
        for (int linha = 0; linha < qtdlinhas; linha++)
        {
            for (int coluna = 0; coluna < qtdcolunas; coluna++)
            {
                matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
            }
        }
        imprimirMatriz(matriz3, "\n\nMatriz de Subtração\n");
    }
    void multiplicarMatriz(float[,] matriz1, float[,] matriz2)
    {
        for (int linha = 0; linha < qtdlinhas; linha++)
        {
            for (int coluna = 0; coluna < qtdcolunas; coluna++)
            {
                matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
            }
        }
        imprimirMatriz(matriz3, "\n\nMatriz de Multiplicação\n");
    }
    void dividirMatriz(float[,] matriz1, float[,] matriz2)
    {
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
        imprimirMatriz(matriz3, "\n\nMatriz de Divisão\n");
    }
    int menuSelecao()
    {
        Console.WriteLine("\n\n-------------------------------------------------------");
        Console.WriteLine("\n|1| Soma");
        Console.WriteLine("|2| Subtração");
        Console.WriteLine("|3| Multiplicação");
        Console.WriteLine("|4| Divisão\n\n");
        Console.Write("|Digite o número da operação matemática desejada: ");
        int escolha = int.Parse(Console.ReadLine());
        return escolha;
    }

    sortearMatriz(matriz1);
    sortearMatriz(matriz2);

    operacao = menuSelecao();
    switch (operacao)
    {
        case 1:
            somarMatriz(matriz1, matriz2);
        break;

        case 2:
            subtrairMatriz(matriz1, matriz2);
        break;

        case 3:
            multiplicarMatriz(matriz1, matriz2);
        break;

        case 4:
            dividirMatriz(matriz1, matriz2);
        break;

        default:
            Console.WriteLine("\n\n|Opção inválida|\n");
            TrueFalse = false;   
        break;
    }

    Console.ReadKey();
    Console.Clear();
}