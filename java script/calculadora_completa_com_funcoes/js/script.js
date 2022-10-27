menu();

function menu()
{
let opcao = parseInt(prompt("Escolha uma opção: 1). Somar. 2). Subtrair"));
if (opcao != 1 && opcao != 2&& opcao != 3&& opcao != 4 )
{
alert("Opção inválida");
menu();
}
let primeirovalor = parseInt(prompt("Digite o primeiro número:"));
let segundovalor = parseInt(prompt("Digite o segundo número:"));
        switch (opcao) {
            case 1:
                alert("O resultado da soma é: " + somar(primeirovalor, segundovalor));
                break;
                case 2:
                    alert("O resultado da subtração é: " + subtrair(primeirovalor, segundovalor));
                    break;
                    case 3:
                        alert("O resultado da multiplicação é: " + mult(primeirovalor, segundovalor));
                        break;
                        case 4:
                            alert("O resultado da divisão é: " + dividir(primeirovalor, segundovalor));
                            break;
        }
}

function somar(v1, v2){
return (v1+v2);
}

function subtrair(v1, v2){
 return (v1-v2);   
}

function mult(v1, v2){
    return (v1*v2);
}

function dividir(v1, v2){
    return(v1/v2);
}