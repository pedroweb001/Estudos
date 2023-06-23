#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <locale.h>
#include <time.h>

#define tamanho_palavra 20

void abertura();
void escolhepalavra();
void chuta();
void desenhaforca();
void adicionarpalavra();
int jachutou(char letra);
int ganhou();
int enforcou();
int letraexiste(char letra);
int chuteserrados();

char palavrasecreta[tamanho_palavra];
char chutes[30];
int chutesdados = 0;

int main(){
abertura();
escolhepalavra();
do{
desenhaforca();
chuta();
}while(!ganhou() && !enforcou());
if (ganhou()){
printf("\n\nParabéns, você ganhou!\n\n");
printf("       ___________      \n");
printf("      '._==_==_=_.'     \n");
printf("      .-\\:      /-.    \n");
printf("     | (|:.     |) |    \n");
printf("      '-|:.     |-'     \n");
printf("        \\::.    /      \n");
printf("         '::. .'        \n");
printf("           ) (          \n");
printf("         _.' '._        \n");
printf("        '-------'       \n\n");
}else{
printf("Você foi enforcado, bobão!");
printf("A palavra era:***%s***\n", palavrasecreta);
printf("    _______________         \n");
printf("   /               \\       \n"); 
printf("  /                 \\      \n");
printf("//                   \\/\\  \n");
printf("\\|   XXXX     XXXX   | /   \n");
printf(" |   XXXX     XXXX   |/     \n");
printf(" |   XXX       XXX   |      \n");
printf(" |                   |      \n");
printf(" \\__      XXX      __/     \n");
printf("   |\\     XXX     /|       \n");
printf("   | |           | |        \n");
printf("   | I I I I I I I |        \n");
printf("   |  I I I I I I  |        \n");
printf("   \\_             _/       \n");
printf("     \\_         _/         \n");printf("       \\_______/           \n");
}
adicionarpalavra();
return 0;
}

void abertura(){
printf("****************\n");
printf("*Bem-vindo!*");
}

void chuta(){
char chuta;
printf("Qual é a letra?");
scanf(" %c", &chuta);
if(letraexiste(chuta)) {
printf("Você acertou: a palavra tem a letra %c\n\n", chuta);
}else{
printf("\nVocê errou: a palavra NÃO tem a letra %c\n\n", chuta);
}
chutes[chutesdados] = chuta;
chutesdados++;
}

void desenhaforca(){
int erros = chuteserrados();
printf("  _______       \n");
printf(" |/      |      \n");
printf(" |      %c%c%c  \n", (erros>=1?'(':' '), (erros>=1?'_':' '), (erros>=1?')':' '));
printf(" |      %c%c%c  \n", (erros>=3?'\\':' '), (erros>=2?'|':' '), (erros>=3?'/': ' '));
printf(" |       %c     \n", (erros>=2?'|':' '));
printf(" |      %c %c   \n", (erros>=4?'/':' '), (erros>=4?'\\':' '));
printf(" |              \n");
printf("_|___           \n");
printf("\n\n");
printf("\n\n");
for (int i = 0; i<strlen(palavrasecreta); i++){
if(jachutou(palavrasecreta[i])) {
printf("%c ", palavrasecreta[i]);
} else {
printf("_ ");
}
}
}

void escolhepalavra(){
FILE* arquivo;
arquivo = fopen("palavras.txt", "r+");
if (arquivo == 0){
printf("Erro ao ler o banco de dados de palavras\n");
exit(1);
}
int quantidadepalavras;
fscanf(arquivo, "%d", &quantidadepalavras);
srand(time(0));
int randomico = rand()%quantidadepalavras;
for(int i = 0; i <= randomico; i++) {
fscanf(arquivo, "%s", palavrasecreta);
}
fclose(arquivo);
}

void adicionarpalavra() {
char quer;
printf("Você deseja adicionar uma nova palavra no jogo (S/N)?");scanf(" %c", &quer);
if(quer == 'S') {
char novapalavra[tamanho_palavra];
printf("Digite a nova palavra, em letras maiúsculas: ");
scanf("%s", novapalavra);
FILE* arquivo;
arquivo = fopen("palavras.txt", "r+");
if(arquivo == 0) {
printf("Banco de dados de palavras não disponível\n\n");
exit(1);
}
int qtd;
fscanf(arquivo, "%d", &qtd);
qtd++;
fseek(arquivo, 0, SEEK_SET);
fprintf(arquivo, "%d", qtd);
fseek(arquivo, 0, SEEK_END);
fprintf(arquivo, "\n%s", novapalavra);
fclose(arquivo);
}
}

int jachutou(char letra){
int achou = 0;
for (int j = 0; j<chutesdados; j++){
if(chutes[j] == letra) {
achou = 1;
break;
}
}
return achou;
}

int enforcou(){
return chuteserrados() >= 5;
}

int ganhou(){
for(int i = 0; i < strlen(palavrasecreta); i++) {
if(!jachutou(palavrasecreta[i])) {
return 0;
}
}
return 1;
}

int letraexiste(char letra){
for (int j = 0; j<chutesdados; j++){
if(chutes[j] == letra) {
return 1;
}
}
return 0;
}

int chuteserrados(){
int erros = 0;
for (int i = 0; i<chutesdados; i++){
if(!letraexiste(chutes[i])) {
erros++;
}
}
return erros;
}