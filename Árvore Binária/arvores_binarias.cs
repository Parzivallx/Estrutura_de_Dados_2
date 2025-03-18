Árvors binárias !!!


// Figura 18 - Classe que cria a estrutura de nó da árvore

public class BTreeNo
{
    private int valor;
    private BTreeNo esq;
    private BTreeNo dir;

    public BTreeNo(int valor)
    {
        this.valor = valor;
    }

    public int Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public BTreeNo Esq
    {
        get { return esq; }
        set { esq = value; }
    }

    public BTreeNo Dir
    {
        get { return dir; }
        set { dir = value; }
    }
}



Inserir nó em uma árvore !!


// Figura 19 - Classe que cria a estrutura de nó da árvore


public class BTree
{
    private BTreeNo raiz;

    private BTreeNo inserir(BTreeNo arvore, int novo)
    {
        BTreeNo aux = new BTreeNo(novo); // Cria um novo nó com o valor

        if (arvore == null)
        {
            return aux; // Se a árvore estiver vazia, retorna o novo nó como raiz
        }
        else if (novo < arvore.Valor)
        {
            arvore.Esq = inserir(arvore.Esq, novo); // Insere na subárvore esquerda
        }
        else
        {
            arvore.Dir = inserir(arvore.Dir, novo); // Insere na subárvore direita
        }

        return arvore; // Retorna a árvore modificada
    }

    public void inserirNo(int novo)
    {
        raiz = inserir(raiz, novo); // Chama o método recursivo para inserir o novo nó
    }
}




Exibir nós de uma árvore !!!


// Figura 20 - Métodos de exibição de nós na árvore binária


public void exibirEsquerdo(BTreeNo arv)
{
    if (arv != null)
    {
        exibirEsquerdo(arv.Esq); // Correção: arv.Esq em vez de arv.getEsq()
        Console.WriteLine(arv.Valor); // Correção: arv.Valor em vez de arv.getValor()
    }
}

public void exibirDireito(BTreeNo arv)
{
    if (arv != null)
    {
        exibirDireito(arv.Dir); // Correção: arv.Dir em vez de arv.getDir()
        Console.WriteLine(arv.Valor); // Correção: arv.Valor em vez de arv.getValor()
    }
}

public void ExibirRaiz()
{
    if (raiz != null)
    {
        Console.WriteLine("Raiz: " + raiz.Valor); // Correção: raiz.Valor em vez de raiz.getValor()
    }
    else
    {
        Console.WriteLine("Árvore vazia"); // Adicionado para lidar com árvore vazia
    }
}

public void exibirNoEsq()
{
    exibirEsquerdo(raiz);
}

public void exibirNoDir()
{
    exibirDireito(raiz);
}




Excluir nó de umq árvore !!


// Figura 21 - Métodos de exclusão de nó na árvore binária

public void exluirNo(int item)
{
    BTreeNo aux = raiz, pai = null, filho = raiz, temp;


    // Busca o nó a ser excluído e seu pai

    while (aux != null && aux.Valor != item) // Correção: aux.Valor em vez de aux.getValor()
    {
        pai = aux;
        if (item < aux.Valor) // Correção: aux.Valor em vez de aux.getValor()
        {
            aux = aux.Esq; // Correção: aux.Esq em vez de aux.getEsq()
        }
        else
        {
            aux = aux.Dir; // Correção: aux.Dir em vez de aux.getDir()
        }
    }

    if (aux == null)
    {
        Console.WriteLine("Valor não encontrado");
        return;
    }


    // Caso 1: Nó a ser excluído não tem filhos ou tem apenas um filho


    if (aux.Dir == null) // Correção: aux.Dir em vez de aux.getDir()
    {
        if (pai == null) // Nó a ser excluído é a raiz
        {
            raiz = aux.Esq; // Correção: aux.Esq em vez de aux.getEsq()
        }
        else if (pai.Esq == aux) // Correção: pai.Esq em vez de pai.getEsq()
        {
            pai.Esq = aux.Esq; // Correção: pai.Esq em vez de pai.getEsq() e aux.Esq em vez de aux.getEsq()
        }
        else
        {
            pai.Dir = aux.Esq; // Correção: pai.Dir em vez de pai.getDir() e aux.Esq em vez de aux.getEsq()
        }
    }
    else if (aux.Esq == null) // Correção: aux.Esq em vez de aux.getEsq()
    {
        if (pai == null) // Nó a ser excluído é a raiz
        {
            raiz = aux.Dir; // Correção: aux.Dir em vez de aux.getDir()
        }
        else if (pai.Esq == aux) // Correção: pai.Esq em vez de pai.getEsq()
        {
            pai.Esq = aux.Dir; // Correção: pai.Esq em vez de pai.getEsq() e aux.Dir em vez de aux.getDir()
        }
        else
        {
            pai.Dir = aux.Dir; // Correção: pai.Dir em vez de pai.getDir() e aux.Dir em vez de aux.getDir()
        }
    }


    // Caso 2: Nó a ser excluído tem dois filhos

    else
    {
        temp = aux;
        filho = aux.Esq; // Correção: aux.Esq em vez de aux.getEsq()

        while (filho.Dir != null) // Correção: filho.Dir em vez de filho.getDir()
        {
            temp = filho;
            filho = filho.Dir; // Correção: filho.Dir em vez de filho.getDir()
        }

        if (filho != aux.Esq) // Correção: aux.Esq em vez de aux.getEsq()
        {
            temp.Dir = filho.Esq; // Correção: temp.Dir em vez de temp.getDir() e filho.Esq em vez de filho.getEsq()
            filho.Esq = aux.Esq; // Correção: filho.Esq em vez de aux.getEsq()
        }

        filho.Dir = aux.Dir; // Correção: aux.Dir em vez de aux.getDir()

        if (pai == null) // Nó a ser excluído é a raiz
        {
            raiz = filho;
        }
        else if (pai.Esq == aux) // Correção: pai.Esq em vez de pai.getEsq()
        {
            pai.Esq = filho; // Correção: pai.Esq em vez de pai.getEsq()
        }
        else
        {
            pai.Dir = filho; // Correção: pai.Dir em vez de pai.getDir()
        }
    }
}
