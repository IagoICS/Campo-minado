# Campo minado
Fazer um jogo do campo minado em português estruturado e em C#. <br>

## Estudo de caso
O jogo se trata de um tabuleiro com 10 colunas e 10 linhas no jogo. Um jogador tem de adivinhar todos os quadrados limpos em um campo cheio de até 10 minas sem que alguma bomba seja detonada.<br>
Os campos são gerados aleatoriamente não tendo uma posição fixa, fazendo com que o jogador não repita a mesma estrategia.<br>
O jogador escolhe a coluna e a linha de preferencia. Ao escolher, o jogador pode revelar tanto uma frase "Bombas por perto"(indica para o jogador se existe bombas ao redor da posição escolhida) ou uma área vazia.<br> 
O jogador ganha quando todos os quadrados sem minas são revelados.<br>
Assim que o jogador escolhe um campo com uma bomba, se mostra no prompt de comando: "Você explodiu" e assim se encerra o jogo. Também se encerra caso o jogador escolha 
uma posição acima de 10 ou 0.<br>
## Algoritimo VisualG
Var<br>
// Seção de Declarações das variáveis <br>
CampoMinado:vetor[1..10,1..10] de inteiro<br>
i, j, QTbombas1, QTbombas2:inteiro<br>
cont, Escolhido:inteiro<br>
Inicio<br>
para i de 1 ate 10 faca<br>
QTbombas1 :=randi(9)+1<br>
QTbombas2 := randi(9)+1<br>
CampoMinado[QTbombas1,QTbombas2] := 32<br>
fimpara<br>
<br>
para i de 1 ate 10 faca<br>
para j de 1 ate 10 faca<br>
se CampoMinado[i,j] <> 32 entao<br>
cont := 0<br>
se j < 10 entao<br>
se CampoMinado[i, j+1] = 32 entao<br>
cont := cont + 1<br>
fimse<br>
fimse<br>
se j > 1 entao<br>
se CampoMinado[i,j-1] = 32 entao<br>
cont := cont + 1<br>
fimse<br>
fimse<br>
se i > 1 entao<br>
se CampoMinado[i-1,j] = 32 entao<br>
cont := cont + 1<br>
fimse<br>
fimse<br>
se i < 10 entao<br>
se CampoMinado[i+1,j] = 32 entao<br>
cont := cont + 1<br>
fimse<br>
fimse<br>
CampoMinado[i,j] := cont<br>
fimse<br>
fimpara<br>
fimpara<br>
<br>
<br>
repita<br>
<br>
escreval ("Digite um número de 1 até 10 para LINHA ou digite 0 para Sair: ")<br>
leia(Escolhido)<br>
<br>
se (Escolhido>0) E (Escolhido <=10)entao<br>
i := Escolhido<br>
escreval ("Digite um número de 1 até 10 para COLUNA ou digite 0 para Sair: ")<br>
leia (Escolhido)<br>
se (Escolhido > 0) E (Escolhido <=10) entao<br>
j := Escolhido<br>
se CampoMinado[i,j] = 0 entao<br>
escreval("Espaço livre")<br>
fimse<br>
se (CampoMinado[i,j] >=1) e (CampoMinado[i,j]<=4) entao<br>
             escreval("Bombas por perto")<br>
           fimse<br>
 se CampoMinado[i,j] = 32 entao<br>
<br>
              escreval("Você explodiu")<br>
<br>
Escolhido := 0<br>
fimse<br>
fimse<br>
fimse<br>
ate Escolhido = 0<br>
<br>
Fimalgoritmo<br>
