formatacao_dinheiro();

function formatacao_dinheiro(){
    let dinheiro = 4.95;
    let dinheiroconvertido = String(dinheiro.toFixed(2));
    console.log(dinheiroconvertido.replace(".", ","));
}