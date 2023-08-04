import pyttsx3

def fala_comigo(texto):
	engine = pyttsx3.init()
	engine.setProperty('rate', 800)
	engine.say(texto)
	engine.runAndWait()

while (True):
	texto = input()
	fala_comigo(texto)