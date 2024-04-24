int tamanho = 3;
int qtdlinhas = tamanho;
int qtdcolunas = tamanho;
int[,] matriz = new int[qtdlinhas, qtdcolunas];
int [] resultadoLinha = new int[tamanho];

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz[linha, coluna] = new Random().Next(1, 10);
    }
}

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz[linha, coluna] + "| ");
    }
}

//Soma Linhas

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {

    resultadoLinha [linha] = matriz[linha,coluna] + matriz[linha, coluna];

    }  
}

Console.WriteLine();
for (int i = 0; i < tamanho; i++)

{
    Console.WriteLine(resultadoLinha[i] + i+1);
}

