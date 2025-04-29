---

# 🌳 Árvores !!

As estruturas apresentadas até aqui são chamadas de **lineares**. A importância dessas estruturas é inegável, porém, elas **não são adequadas para representar dados que devem ser dispostos de maneira hierárquica**. A estrutura que preenche essa lacuna é a **árvore**.

Uma **árvore** é uma estrutura **bidimensional, não linear**, que possui propriedades especiais e admite muitas operações de conjuntos dinâmicos, tais como:

- Consulta  
- Inserção  
- Remoção  
- Entre outros

> **Figura 15** - Representação de uma estrutura de dados árvore

```
        (Raiz)
          |
    +-----+-----+
    |           |
 (Filho)     (Filho)
    |           |
+---+---+     +---+
|       |     |   |
(Filho) (Filho) (Filho)
```
*Fonte: Adaptado de Ascencio (2010)*

---

## 🔹 Características de Árvores

- **Nó raiz**: nó no topo da árvore, do qual descendem os demais nós; é o primeiro nó da árvore;  
- **Nó interior**: nó do interior da árvore (que possui descendentes);  
- **Nó terminal**: nó que não possui descendentes;  
- **Trajetória**: número de nós que devem ser percorridos até o nó determinado;  
- **Grau do nó**: número de nós descendentes do nó, ou seja, o número de subárvores de um nó;  
- **Grau da árvore**: número máximo de subárvores de um nó;  
- **Altura da árvore**: número máximo de níveis dos seus nós.

> **Figura 16** - Elementos de uma árvore

```
        (A) <- Raiz
        / \
     (B) (C) <- Nós interiores
     / \
  (D) (E) <- Nós terminais (folhas)
```

---

Podemos utilizar **árvores binárias** para armazenamento temporário de conjuntos de elementos e podem ser implementadas com **armazenamento dinâmico**, através de **listas duplamente encadeadas**.

Com relação ao tipo, elas podem ser do tipo **listas generalizadas** ou **binárias**.  
Nas árvores binárias, cada nó possui, no máximo, dois filhos. Nesta Unidade, abordaremos apenas as **árvores binárias**.

---

# 🌿 Árvores Binárias !!

Uma **árvore binária** pode ser **nula** e, assim como qualquer árvore, possui um elemento denominado **raiz**, e os demais elementos são particionados em `T₁` e `T₂`, estruturas disjuntas de árvore binária.

- A **subárvore da esquerda** é denominada `T₁`;  
- A **subárvore da direita** é denominada `T₂`.

Nesse tipo de árvore também existe a particularidade quanto à **posição dos nós**:

- Os **nós da direita** sempre possuem **valor superior** aos do nó pai;  
- Os **nós da esquerda** sempre possuem **valor inferior** ao do nó pai.

> **Figura 17** - Exemplo de árvore binária de busca

```
        (8)
       /   \
     (3)   (10)
     / \      \
   (1) (6)    (14)
       / \    /
     (4) (7) (13)
```

---

Para a manipulação de árvore, existe uma grande similaridade com os nós criados para manipular listas. Por isso, utilizaremos os mesmos princípios.

Criaremos uma classe `BTreeNo`, a qual implementa o **nó da árvore** e contém os atributos:

- `item` do tipo `int`, possibilitando manipular números inteiros (para facilitar o entendimento da lógica, mas a árvore pode manipular qualquer tipo de dados);  
- `esq` e `dir` do tipo `TreeNo`.

A cada novo nó inserido na árvore, uma instância da classe `BTreeNo` será criada, ou seja, um novo **objeto nó**.

> **Figura 18** - Estrutura do nó da árvore

```python
class BTreeNo:
    def __init__(self, valor):
        self.item = valor
        self.esq = None
        self.dir = None
```

---

## ➕ Inserir nó em uma árvore !!

Após definir a estrutura do nó da árvore, o próximo passo é criar a **classe árvore**, que será instanciada toda vez que uma nova árvore for criada, contendo os métodos que possibilitem operações de **inserção e exclusão de nós**.

> **Figura 19** - Métodos de inserção

```python
class BTree:
    def __init__(self):
        self.raiz = None

    def inserirNo(self, valor):
        self.raiz = self.inserir(self.raiz, valor)

    def inserir(self, arvore, valor):
        if arvore is None:
            return BTreeNo(valor)
        elif valor < arvore.item:
            arvore.esq = self.inserir(arvore.esq, valor)
        else:
            arvore.dir = self.inserir(arvore.dir, valor)
        return arvore
```

### 🔍 Regras de Inserção:

- Quando a árvore está **vazia**: insere o novo elemento na **raiz**;
- Quando já há elementos:
  - Se o valor a ser inserido é **menor**, será inserido à **esquerda**;
  - Caso contrário, insere-se à **direita**;
- A **recursividade** é utilizada para percorrer os nós até encontrar um `null`.

---

## 📤 Exibir nós de uma árvore !!

A partir da operação para exibir os valores, apresentaremos **apenas o método correspondente**, lembrando que este e os demais foram desenvolvidos no escopo da classe `BTree`.

- Assim como o método `inserirNo`, os métodos `exibirNoEsq` e `exibirNoDir` **não recebem parâmetros**;
- Eles chamam os métodos `exibirEsquerdo` ou `exibirDireito`, passando como parâmetro o nó denominado **raiz**.

### 🧭 Métodos `exibirEsquerdo` e `exibirDireito`:

- Recebem como parâmetro um objeto do tipo `BTreeNo`;
- São chamados via `exibirNoEsq` ou `exibirNoDir`;
- Utilizam **recursão** para buscar os nós à esquerda ou à direita da árvore;
- O percurso termina ao encontrar um **nó nulo**;
- Isso garante a **impressão na ordem ascendente de valor**.

---

## ❌ Excluir nó de uma árvore !!

A exclusão de um nó da árvore requer uma **lógica mais complexa**, pois as **referências ao nó excluído e seus filhos precisam ser ajustadas**.

> Veja **Figura 22** para o processo visual.

**Figura 22 - Processo de Exclusão de Nó em Árvore Binária**

```
ANTES DA EXCLUSÃO:
        (8)
       /   \
     (3)   (10)
     / \      \
   (1) (6)    (14)
       / \    /
     (4) (7) (13)

EXCLUINDO O NÓ (10):
- Nó com apenas um filho (14).

DEPOIS DA EXCLUSÃO:
        (8)
       /   \
     (3)   (14)
     / \    /
   (1) (6) (13)
       / \
     (4) (7)
```

---

### 🔁 Casos Especiais:

- Se o **pai não for nulo**, o nó a ser excluído **não é a raiz**;
- Se o nó **não possuir filho à direita**, a referência do pai será trocada;
- O mesmo vale se **não possuir filho à esquerda**;
- Se possuir **filhos à esquerda e à direita**, aplica-se a **mesma lógica da exclusão da raiz**, mas ajustando as **referências do pai** do nó a ser excluído.

> Veja o exemplo na **Figura 23**.

**Figura 23 - Ajuste de Referência do Pai Após Exclusão**

```
ANTES:
        (8)
       /   \
     (3)   (14)
     / \    /
   (1) (6) (13)
       / \
     (4) (7)

EXCLUINDO O NÓ (6):
- Nó com dois filhos (4 e 7).

PASSOS:
- Encontrar o menor valor na subárvore direita (7);
- Substituir o 6 por 7.

DEPOIS:
        (8)
       /   \
     (3)   (14)
     / \    /
   (1) (7) (13)
    /
  (4)
```

---
