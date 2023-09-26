import speech_recognition as sr

# Crie um objeto Recognizer
recognizer = sr.Recognizer()

# Capture o áudio do microfone em tempo real
with sr.Microphone() as source:
    print("Fale alguma coisa...")
    audio = recognizer.listen(source)

# Use o Google Web Speech API para transcrever o áudio em texto
try:
    texto_transcrito = recognizer.recognize_google(audio)
    print("Texto transcrito:", texto_transcrito)
except sr.UnknownValueError:
    print("Não foi possível reconhecer o áudio.")
except sr.RequestError as e:
    print(f"Erro na requisição ao Google Web Speech API: {e}")
input()