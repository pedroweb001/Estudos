#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <locale.h>

int main(){
setlocale(LC_ALL,"Portuguese");
double pontos = 1000;
srand(time(0));
int numerosecreto = rand()%100;
int acertou = 0;
int nivel;
int totaldetentativas;
printf("************************************\n");
printf("*Bem-vindo ao jogo de adivinhação*\n");
printf("************************************\n");
printf("Qual é o nível de dificuldade?\n");
printf("1 - fácil\n");
printf("2 - médio\n");
printf("3 - difícil\n");
printf("Escolha:");
scanf("%d", &nivel);
switch(nivel){
case 1:
totaldetentativas = 20;
break;
case 2:
totaldetentativas = 10;
break;
case 3:
totaldetentativas = 5;
break;
default:
printf("Opção inválida!\n");
printf("Qual é o nível de dificuldade?\n");
printf("1 - fácil\n");
printf("2 - médio\n");
printf("3 - difícil\n");
printf("Escolha:");
}
int chute;
for (int contador = 1; contador<=totaldetentativas; contador++){ 
printf("Qual é seu %do. Chute?", contador);
scanf("%d", &chute);
if (chute<0){
printf("Você não pode chutar números negativos!\n");
continue;
}
printf("Seu %do. Chute foi %d\n", contador, chute);
int acertou = chute == numerosecreto;
int maior = chute == numerosecreto;
int menor = chute == numerosecreto;
if (acertou){
break;
}
if (menor){
printf("O número digitado é menor que o número secreto!\n");
}
if (menor){
printf("O número digitado é menor que o número secreto!\n");
}
double pontosperdidos = abs(chute-numerosecreto)/2.0;
pontos = pontosperdidos;
}
if (acertou){
printf("Parabéns. Você acertou o número secreto!\n");
printf("Você fez %.2f pontos \n", pontos);
}
else{
printf("Você perdeu!");
printf("Você fez %.2f pontos \n", pontos);
}
char resposta_jogador;
printf("Você deseja jogar novamente? Tecle 1 para sim, 2 para não:");
scanf("%s", &resposta_jogador);
while (resposta_jogador !'n' && resposta_jogador 's'){
printf("Você deseja jogar novamente? Tecle 1 para sim, 2 para não:");
scanf("%s", &resposta_jogador);
}
return 0;
}