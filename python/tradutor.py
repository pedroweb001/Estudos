from googletrans import Translator

def main(texto_original):
    translator = Translator()
    resultado = translator.translate(texto_original, src='en', dest='pt')
    print("Texto traduzido para o português é:", resultado.text)

texto = input("Digite o texto a traduzir para o português:")
main(texto)