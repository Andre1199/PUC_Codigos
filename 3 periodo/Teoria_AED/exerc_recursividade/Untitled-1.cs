static int Fibonacci(int n){
    if (n == 2 || n == 1) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static int Multiplicação(int n1, int n2){
    if (n1 == 0) return 0;
    else return n2 + Multiplicação(n1 - 1, n2);
}

static int Multiplicacao(int n1, int n2){
    if (n1 == 0) return 0;
    else return n2 + Multip(n1-1, n2);
}

static int Fatorial(int n){
    if (n == 1) return 1;
    else return n * Fatorial(n-1);
}

static int DiagonalP(int[,] vet, int linha, int coluna){
    int soma = 0;
    if (linha == -1 && coluna == -1) return 0;
    else return soma += vet[linha, coluna] + DiagonalP(vet, linha-1, coluna-1);
}

static int DiagonalS(int[,] vet, int linha, int coluna){
    int soma = 0;
    if (linha == vet.GetLength(0) && coluna == -1) return 0;
    else return soma += vet[linha, coluna] + DiagonalS(vet, linha +1, coluna - 1);
}

static string RemoveVogais(string frase, int pos){
    string novaFrase = string.Empty;
    if (pos == frase.Length) return novaFrase;
    else {
        switch (frase[pos]) {
            case 'a': break;
            case 'e': break;
            case 'i': break;
            case 'o': break;
            case 'u': break;

            default: novaFrase += frase[pos];
            break;
        }
        return novaFrase + RemoveVogais(frase, pos + 1); 
    }     
}

static int Serie(int n1){
    if(n1 == 0) return (1/2);
    else return Serie(n1 - 1) + (2*n1-1)/(2*n1);
}