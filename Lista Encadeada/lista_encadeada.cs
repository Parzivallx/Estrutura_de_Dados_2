
Criação de nó !!

// Figura 6 - Classe que cria a estrutura de nó simples

public class Node
{
    private object item;
    private Node prox;

    public Node(object item)
    {
        this.item = item;
        prox = null;
    }

    // Getters e setters opcionais, se necessário

    public object Item
    {
        get { return item; }
        set { item = value; }
    }

    public Node Prox
    {
        get { return prox; }
        set { prox = value; }
    }
}




Inserir elementos em uma lista !!! 

// Figura 7 - Lista Simples, com os métodos insereInicio, insereFim, inserePosicao e contaNos

public class ListaSimples
{
    public object primeiro { get; private set; }
    public object ultimo { get; private set; }

    private Node primeiro, ultimo;
    private int qtdeNos;

    public ListaSimples()
    {
        primeiro.Prox = null;
        ultimo.Prox = null;
    }

    public void insereFim(Node novo)
    {
        novo.Prox = null;
        if (this.primeiro == null)
        {
            this.primeiro = novo;
        }
        if (this.ultimo != null)
        {
            this.ultimo.Prox = novo;
        }
        this.ultimo = novo;
    }

    public void insereInicio(Node novo)
    {
        if (this.primeiro != null)
        {
            novo.Prox = primeiro;
        }
        else
        {
            if (this.primeiro == null)
            {
                this.primeiro = novo;
            }
            this.ultimo = novo;
        }
        this.primeiro = novo;
    }

    public void inserePosicao(Node novo, int pos)
    {
        Node aux = primeiro;
        int qtde = contaNos();
        int pos_aux;

        if (pos == 0)
        {
            novo.Prox = primeiro;
            if (primeiro == ultimo)
            {
                ultimo = novo;
            }
            primeiro = novo;
        }
        else if (pos <= qtde)
        {
            pos_aux = 1;
            while (aux != null && pos > pos_aux)
            {
                aux = aux.Prox;
                pos_aux++;
            }
            novo.Prox = aux.Prox;
            aux.Prox = novo;
        }
        else if (pos > qtde)
        {
            ultimo.Prox = novo;
            ultimo = novo;
        }
    }

    public int contaNos()
    {
        int tam = 0;
        Node aux = primeiro;
        while (aux != null)
        {
            tam++;
            aux = aux.Prox;
        }
        return tam;
    }
}




Excluir elementos da lista !!

// Figura 9 - Método excluiNo da classe ListaSimples

public void excluiNo(object item)
{
    Node aux = primeiro;
    Node anterior = null;

    while (aux != null && aux.Item != item)
    {
        anterior = aux;
        aux = aux.Prox;
    }

    if (aux != null) // Verifica se o nó foi encontrado
    {
        if (anterior == null) // Se o nó a ser excluído é o primeiro
        {
            primeiro = aux.Prox;
            if (primeiro == null) // Se a lista ficou vazia
            {
                ultimo = null;
            }
        }
        else
        {
            anterior.Prox = aux.Prox;
            if (ultimo == aux) // Se o nó a ser excluído é o último
            {
                ultimo = anterior;
            }
        }
    }
}


Buscar elementos em uma lista !!!

// Figura 10 - Método buscaNo da classe ListaSimples

public Node buscaNo(object item)
{
    int i = 0;
    Node aux = primeiro;

    while (aux != null)
    {
        if (aux.Item.Equals(item)) // Usar Equals() para comparar objetos
        {
            return aux;
        }
        i++;
        aux = aux.Prox;
    }

    return null;
}

