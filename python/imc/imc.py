import os
#encoding: utf-8
nome = input("Digite seu nome:")
idade = int(input("Digite sua idade:"))
peso = float(input("Digite seu peso:"))
altura = float(input("Digite sua altura:"))
imc = peso/altura**2
print("olá " + nome)
print()
print("Você tem: ", idade, " anos")
print()
print("Seu imc é: %.2f" %(imc))