primeiro = int(input("Digite o primeiro número"))
segundo = int(input("Digite o segundo número:"))
terceiro = int(input("Digite o terceiro número:"))

if (primeiro>segundo and primeiro>terceiro):
	maior = primeiro
if (segundo>primeiro and segundo>terceiro):
	maior = segundo
if (terceiro>segundo and terceiro>primeiro):
	maior = terceiro
if (primeiro<segundo and primeiro<terceiro):
	menor = primeiro
if (segundo<primeiro and segundo<terceiro):
	menor = segundo
if (terceiro<segundo and terceiro<primeiro):
	menor = terceiro
print("Omaior número é:", maior)
print("E o menor número é", menor)
input()