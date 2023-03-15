# Campo minado
Fazer um jogo do campo minado em português estruturado e em C#. <br>

## Estudo de caso
Estudo de caso: Um tabuleiro com X colunas e X linhas dependendo da versão do jogo. Um jogador tem de adivinhar todos os quadrados limpos em um campo cheio de minas sem que alguma bomba seja detonada.
Os quadrados do jogo são revelados quando um jogador clica nele. Ao clicar, o jogador pode revelar tanto um número (indica a quantidade de bombas perto) ou uma área vazia. 
O jogador ganha quando todos os quadrados sem minas são revelados.

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
