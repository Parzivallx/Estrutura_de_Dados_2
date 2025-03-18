# Exemplos de Estruturas de Dados para Desenvolvimento de Jogos 


##  Estruturas de Dados Abordadas

* **Listas Encadeadas (ListaSimples)**
* **Listas Ordenadas (ListaSimples com insereNoOrdenado)**
* **Árvores Binárias (BTree)**
* **Filas (Queue)**
* **Pilhas (Stack)**
* **Dicionários (Dictionary)**

## ️ Exemplos de Uso

### 1. Listas Encadeadas (ListaSimples)

   Gerenciamento de inventário:
    * Uma lista encadeada pode ser usada para armazenar os itens que um personagem possui em seu inventário. Cada nó da lista representaria um item, com informações como nome, descrição, quantidade, etc.
    * A inserção e remoção de itens do inventário seriam operações eficientes em uma lista encadeada.
* **⏱️ Filas de eventos:**
    * Em jogos com muitos eventos ocorrendo simultaneamente, uma lista encadeada pode ser usada para criar uma fila de eventos.
    * Cada nó da lista representaria um evento, com informações como tipo de evento, tempo de ocorrência, etc.
    * O jogo processaria os eventos na ordem em que foram adicionados à fila.
* **↩️ Histórico de ações:**
    * Para implementar um sistema de "desfazer" ações, uma lista encadeada pode ser usada para armazenar o histórico de ações do jogador.
    * Cada nó da lista representaria uma ação, com informações como tipo de ação, posição do jogador, etc.
    * O jogador poderia "desfazer" ações percorrendo a lista em ordem inversa.

### 2. Listas Ordenadas (ListaSimples com insereNoOrdenado)

 * **Placares de líderes (Leaderboards):**
    * Listas ordenadas são ideais para armazenar placares de líderes em jogos.
    * Cada nó da lista representaria um jogador, com informações como nome, pontuação, etc.
    * A lista seria mantida ordenada pela pontuação, permitindo exibir os melhores jogadores de forma eficiente.
* ** Gerenciamento de entidades em um jogo:**
    * Em jogos com muitas entidades (inimigos, projéteis, etc.), uma lista ordenada pode ser usada para gerenciar essas entidades.
    * A lista poderia ser ordenada pela distância das entidades em relação ao jogador, permitindo renderizar as entidades mais próximas primeiro.
* **⚡ Filas de prioridade:**
    * Listas ordenadas podem ser usadas para implementar filas de prioridade, onde os elementos com maior prioridade são processados primeiro.
    * Isso pode ser útil em jogos com eventos com diferentes níveis de importância.

### 3. Árvores Binárias (BTree)

* ** Sistemas de busca:**
    * Árvores binárias podem ser usadas para implementar sistemas de busca eficientes em jogos.
    * Por exemplo, um jogo com um grande mapa poderia usar uma árvore binária para armazenar informações sobre os locais do mapa.
    * O jogador poderia buscar por locais específicos de forma rápida e eficiente.
    Inteligência artificial:
    * Árvores binárias são usadas em algoritmos de inteligência artificial, como árvores de decisão.
    * Em jogos, árvores de decisão podem ser usadas para controlar o comportamento de personagens não jogáveis (NPCs).
    Armazenamento de dados hierárquicos:
    * Árvores binárias são adequadas para armazenar dados hierárquicos, como a estrutura de um mundo de jogo.
    * Por exemplo, um jogo de estratégia poderia usar uma árvore binária para representar a hierarquia de unidades militares.

### 4. Filas (Queue)

    Processamento de eventos:
    * Filas são usadas para processar eventos em ordem de chegada.
    * Eventos são adicionados à fila com `Enqueue`.
    * Eventos são removidos e processados da fila com `Dequeue`.

### 5. Pilhas (Stack)

* **⏪ Histórico de ações:**
    * Pilhas são usadas para armazenar o histórico de ações, permitindo "desfazer" ações em ordem inversa.
    * Ações são adicionadas à pilha com `Push`.
    * Ações são removidas da pilha com `Pop`.

### 6. Dicionários (Dictionary)

* ** Gerenciamento de recursos**
    * Dicionários são usados para armazenar e acessar recursos do jogo de forma eficiente usando chaves.
    * Recursos são adicionados ao dicionário com `AdicionarRecurso`, usando um nome como chave.
    * Recursos são obtidos do dicionário com `ObterRecurso`, usando o nome como chave.

##  Exemplos de Código em C#

```csharp

// Exemplo de uso de lista encadeada para inventário
ListaSimples inventario = new ListaSimples();
inventario.insereFim(new Node("Poção de vida"));
inventario.insereFim(new Node("Espada de ferro"));

// Exemplo de uso de árvore binária para busca de locais
BTree mapa = new BTree();
mapa.inserirNo(10); // Adiciona um local com valor 10
mapa.inserirNo(5);
mapa.inserirNo(15);

// Exemplo de uso de fila para processamento de eventos
GerenciadorEventos gerenciador = new GerenciadorEventos();
gerenciador.AdicionarEvento(new Evento { Tipo = "Ataque", Tempo = 1.5f });
gerenciador.AdicionarEvento(new Evento { Tipo = "Movimento", Tempo = 2.0f });
gerenciador.ProcessarEventos();

// Exemplo de uso de pilha para histórico de ações
HistoricoAcoes historico = new HistoricoAcoes();
historico.AdicionarAcao(new Acao { Tipo = "Movimento" });
historico.AdicionarAcao(new Acao { Tipo = "Ataque" });
Acao acaoDesfeita = historico.DesfazerAcao();
Console.WriteLine($"Ação desfeita: {acaoDesfeita.Tipo}");

// Exemplo de uso de dicionário para gerenciamento de recursos
GerenciadorRecursos gerenciadorRecursos = new GerenciadorRecursos();
gerenciadorRecursos.AdicionarRecurso("textura_inimigo", new UnityEngine.Texture2D(10, 10)); // Usando UnityEngine.Texture2D como exemplo
object textura = gerenciadorRecursos.ObterRecurso("textura_inimigo");
