Listas ordenadas !!!


// Figura 11 - Método de inserção em uma lista ordenada encadeada


public void insereNoOrdenado(Node novo)
{
    Node aux;

    // Verificando se a lista está vazia
    if (primeiro == null || contaNos() == 0)
    {
        novo.Prox = primeiro;
        primeiro = novo;
    }
    else
    {
        aux = primeiro;
        int valorNovo = Convert.ToInt32(novo.Item); // Usar Item e converter corretamente
        int valorAux = Convert.ToInt32(aux.Item);   // Usar Item e converter corretamente

        // Lógica para encontrar o ponto de inserção
        if (valorNovo < valorAux)
        {
            novo.Prox = primeiro;
            primeiro = novo;
        }
        else
        {
            while (aux.Prox != null && Convert.ToInt32(aux.Prox.Item) < valorNovo)
            {
                aux = aux.Prox;
            }
            novo.Prox = aux.Prox;
            aux.Prox = novo;
        }
    }
}
