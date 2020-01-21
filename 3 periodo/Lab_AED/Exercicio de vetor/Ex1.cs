static int Multiplicação(int n1, int n2)
{
    if (n1 == 0) return 0;
    else return n2 + Multiplicação(n1 - 1, n2);
}

static bool VerificarFrase(string frase, char caracter, int pos)
{
    if (pos == frase.Length) return true;
    else if (frase[pos] == caracter) return false;
    else return VerificarFrase(frase, caracter, pos + 1);
}

static int VerificarVetor(int []vetor, int tamanho, int numero)
{
    if (vetor[tamanho] == numero) return tamanho;
    else if (tamanho == 0) return -1;
    else return VerificarVetor(vetor, tamanho-1, numero);
}

static int Divisao(int n1, int n2)
{
    if (n1 < n2) return 0;
    else return 1 + Divisao(n1 - n2, n2);
}