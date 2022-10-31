var nomealuno = prompt("Digite o nome do aluno");
recebe_nota();

function recebe_nota(){
    let nota = parseFloat(prompt("Digite a nota do aluno:"));
    validar_nota(nota);
}

function validar_nota(nota){
if(nota<=5)
{
    alert("O " + nomealuno + " está reprovado!");
}
else
if (nota<=7) {
    alert("o " + nomealuno + " está de recuperação!");
}
else
if(nota<=10) {
    alert("O " + nomealuno + " foi aprovado!");
}
else
{
    alert("Nota inválida!");
    location.reload();
}
}
