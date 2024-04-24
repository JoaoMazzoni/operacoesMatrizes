    int qtdlinhas = 0, qtdcolunas = 0;
    bool trueFalse = true;

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


    void menuSelecao()
    {
        do
        {
            Console.WriteLine("\n\n-------------------------------------------------------");
            Console.WriteLine("\n|1| Soma");
            Console.WriteLine("|2| Subtração");
            Console.WriteLine("|3| Multiplicação");
            Console.WriteLine("|4| Divisão\n\n");
            Console.Write("|Digite o número da operação matemática desejada: ");
            int operacao = int.Parse(Console.ReadLine());
            

            switch (operacao)
            {
                case 1:
                    for (int linha = 0; linha < qtdlinhas; linha++)
                    {
                        for (int coluna = 0; coluna < qtdcolunas; coluna++)
                        {
                            matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                        }
                    }
                    imprimirMatriz(matriz3, "\nMatriz de Soma\n");
                    break;


                case 2:
                    for (int linha = 0; linha < qtdlinhas; linha++)
                    {
                        for (int coluna = 0; coluna < qtdcolunas; coluna++)
                        {
                            matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                        }
                    }
                    imprimirMatriz(matriz3, "\n\nMatriz de Subtração\n");
                    break;


                case 3:
                    for (int linha = 0; linha < qtdlinhas; linha++)
                    {
                        for (int coluna = 0; coluna < qtdcolunas; coluna++)
                        {
                            matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                        }
                    }
                    imprimirMatriz(matriz3, "\n\nMatriz de Multiplicação\n");
                    break;


                case 4:
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
                    break;

                default:
                    Console.WriteLine("\n\n|Opção inválida|\n");
                    trueFalse = false;
                    break;
            }
        } while (trueFalse == false);
    }

//==============================================================================================

    sortearMatriz(matriz1);
    imprimirMatriz(matriz1, "\nMatriz 1\n");

    sortearMatriz(matriz2);
    imprimirMatriz(matriz2, "\n\nMatriz 2");

    menuSelecao();

    Console.ReadKey();

