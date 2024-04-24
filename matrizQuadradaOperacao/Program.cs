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


Console.WriteLine();
//Soma Linhas

Console.WriteLine("\nResultado - Soma das Linhas: ");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    float resultado = 0;
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        if(linha < qtdlinhas)
        {
            resultado += matriz[linha, coluna];
            if (qtdcolunas - 1 == coluna)
            {
                Console.Write(resultado + " ");
            }
        }
       
    }  
}

Console.ReadLine();

//Soma Colunas
Console.WriteLine("\nResultado - Soma das Colunas: ");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    float resultado = 0;  
    for(int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        resultado += matriz[coluna, linha];
    }

    Console.WriteLine(resultado);
}

Console.ReadLine();



//Soma das Diagonais

Console.WriteLine("\nResultado - Soma das Diagonais: \n");



//Diagonal Principal
float diag = 0;
for (int linha = 0; linha < qtdlinhas; linha++)
{
    diag += matriz[linha, linha];

}
Console.WriteLine(diag);

//Diagonal Secundária
diag = 0;
int auxLinha = 0;
for (int coluna = qtdcolunas - 1; coluna >= 0; coluna--)
{
    diag += matriz[auxLinha, coluna];
    auxLinha++;
}
Console.WriteLine(diag);
