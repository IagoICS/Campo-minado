# Campo minado

Nomes: Gabriel Trindade Dias & Iago Carvalho Santana - 3º Jogos Digitais

Fazer um jogo do campo minado em português estruturado e em C#. <br>

## Estudo de caso\Explicação
O jogo se trata de um tabuleiro com 10 colunas e 10 linhas no jogo. Um jogador tem de adivinhar todos os quadrados limpos em um campo cheio de até 10 minas sem que alguma bomba seja detonada.<br>
Os campos são gerados aleatoriamente não tendo uma posição fixa, fazendo com que o jogador não repita a mesma estrategia.<br>
O jogador escolhe a coluna e a linha de preferencia. Ao escolher, o jogador pode revelar tanto uma frase "Bombas por perto"(indica para o jogador se existe bombas ao redor da posição escolhida) ou uma área vazia.<br> 
O jogador ganha quando todos os quadrados sem minas são revelados.<br>
Assim que o jogador escolhe um campo com uma bomba, se mostra no prompt de comando: "Você explodiu" e assim se encerra o jogo. Também se encerra caso o jogador escolha 
uma posição acima de 10 ou 0.<br>

## Mapa

Dimensões: 10x10<br>
Não fizemos um mapa da área do campo minado, porque nossas bombas aparecem de forma aleatória na matriz. 

## Algoritimo VisualG

```
Algoritmo "CampoMinado"
Var
CampoMinado:vetor[1..10,1..10] de inteiro
i, j, QTbombas1, QTbombas2:inteiro
cont, Escolhido:inteiro

Inicio
para i de 1 ate 10 faca
QTbombas1 :=randi(9)+1
QTbombas2 := randi(9)+1
CampoMinado[QTbombas1,QTbombas2] := 32
fimpara
para i de 1 ate 10 faca
     para j de 1 ate 10 faca
          se CampoMinado[i,j] <> 32 entao
             cont := 0
             se j < 10 entao
                se CampoMinado[i, j+1] = 32 entao
                   cont := cont + 1
                fimse
             fimse
             se j > 1 entao
                   se CampoMinado[i,j-1] = 32 entao
                      cont := cont + 1
                   fimse
             fimse
             se i > 1 entao
                se CampoMinado[i-1,j] = 32 entao
                   cont := cont + 1
                fimse
             fimse
             se i < 10 entao
                se CampoMinado[i+1,j] = 32 entao
                   cont := cont + 1
                fimse
             fimse
          CampoMinado[i,j] := cont
          fimse
     fimpara
fimpara


repita

escreval("1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 - 10 - ")
                para i de 1 ate 10 faca
                    para j de 1 ate 10 faca
                        se ((CampoMinado[i, j] = 0) OU ((CampoMinado[i, j] > 0) E (CampoMinado[i, j] <=4)) OU (CampoMinado[i, j] = 32)) entao
                            escreva("X | ")
                        fimse
                        se (CampoMinado[i, j] = 72) entao
                            escreva("  | ")
                        fimse
                        se (CampoMinado[i, j] = 91) entao
                            escreva("1 | ")
                        fimse
                        se (CampoMinado[i, j] = 92) entao
                            escreva("2 | ")
                        fimse
                        se (CampoMinado[i, j] = 93) entao
                            escreva("3 | ")
                        fimse
                        se (CampoMinado[i, j] = 94) entao
                            escreva("4 | ")
                        fimse
                    fimpara
                    escreval(" ")
               fimpara
               escreval("1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 - 10 - ")
               escreval ("Digite um número de 1 até 10 para LINHA ou digite 0 para Sair: ")
               leia(Escolhido)
               se (Escolhido > 0) E (Escolhido <= 10)entao
                  i := Escolhido
                  escreval ("Digite um número de 1 até 10 para COLUNA ou digite 0 para Sair: ")
                  leia (Escolhido)
                  se (Escolhido > 0) E (Escolhido <= 10) entao
                     j := Escolhido
                       se CampoMinado[i,j] = 0 entao
                          escreval("Espaço livre")
                          CampoMinado[i, j] := 72
                       fimse
                       se (CampoMinado[i,j] > 0) e (CampoMinado[i,j]< 5) entao
                          escreval("Bombas por perto")
                          se (CampoMinado[i, j] = 1) entao
                             CampoMinado[i, j] := 91
                          fimse
                          se (CampoMinado[i, j] = 2) entao
                              CampoMinado[i, j] := 92
                          fimse
                          se (CampoMinado[i, j] = 3) entao
                              CampoMinado[i, j] := 93
                          fimse
                          se (CampoMinado[i, j] = 4) entao
                              CampoMinado[i, j] := 94
                          fimse
                       fimse
                       se CampoMinado[i,j] = 32 entao
                          escreval("Você explodiu")
                          para i de 1 ate 10 faca
                               para j de 1 ate 10 faca
                                    escreva(CampoMinado[i, j]," | ")
                               fimpara
                               escreval(" ")
                          fimpara
                          escreval("0 = Espaços livres, 1 ate 4 = quantidade de bombas ao redor, 32 = bombas, 72 = bomba que você explodiu")
                          Escolhido := 0
                       fimse
                  fimse
               fimse
ate Escolhido = 0
Fimalgoritmo
```
