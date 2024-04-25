int tamanho = 0;
int qtdlinhas;
int qtdcolunas;

void definirTamanhoMatriz()
{
    Console.Write("Digite o tamanho da matriz: ");
    tamanho = int.Parse(Console.ReadLine());
    qtdlinhas = tamanho;
    qtdcolunas = tamanho;
}
definirTamanhoMatriz();
int[,] matriz = new int[qtdlinhas, qtdcolunas];

void sortearMatriz(int[,] matriz)
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
void imprimirMatriz(int[,] matriz, string titulo)
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
void somarLinhas(int[,] matriz)
{
    Console.WriteLine("\n\nResultado - Soma das Linhas: ");
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        Console.WriteLine();
        float resultado = 0;
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            if (linha < qtdlinhas)
            {
                resultado += matriz[linha, coluna];
                if (qtdcolunas - 1 == coluna)
                {
                    Console.Write(resultado + " ");
                }
            }

        }
    }
}
void somarColunas(int[,] matriz)
{
    Console.WriteLine("\n\nResultado - Soma das Colunas: \n");

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        float resultado = 0;
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            resultado += matriz[coluna, linha];
        }

        Console.WriteLine(resultado);
    }
}
void somarDiagonalPrincipal(int[,] matriz)
{


    Console.WriteLine("\nResultado - Soma das Diagonais: \n");

    //Diagonal Principal
    float diag = 0;
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        diag += matriz[linha, linha];

    }
    Console.WriteLine(diag);
}
void somarDiagonalSecundaria(int[,] matriz)
{
    float diag = 0;
    int auxLinha = 0;
    for (int coluna = qtdcolunas - 1; coluna >= 0; coluna--)
    {
        diag += matriz[auxLinha, coluna];
        auxLinha++;
    }
    Console.WriteLine(diag);
}


sortearMatriz(matriz);
somarLinhas(matriz);
somarColunas(matriz);
somarDiagonalPrincipal(matriz);
somarDiagonalSecundaria(matriz);
