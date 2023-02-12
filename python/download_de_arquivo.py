import requests
import os

def baixar_arquivo(url, endereco=None):
    if endereco is None:
        endereco = os.path.basename(url.split("?")[0])
    resposta = requests.get(url, stream=True) #AQUI
    if resposta.status_code == requests.codes.OK:
        with open(endereco, 'wb') as novo_arquivo:
                for parte in resposta.iter_content(chunk_size=256): #AQUI TBM
                    novo_arquivo.write(parte)
        print("Download concluído!")
        os.rename(endereco, "opera-setup.exe")
    else:
        resposta.raise_for_status()

baixar_arquivo("https://net.geo.opera.com/opera/stable/windows?utm_tryagain=yes&utm_source=google&utm_medium=pa&utm_campaign=OGX_BR_Search_PT_T4_Competitors_V2&&utm_id=CjwKCAiA85efBhBbEiwAD7oLQIHr--snGwlaTLX1ouUMoWWQPNaZ68GKgVCcs0kXUOhm4pasPem2-hoCE8oQAvD_BwE&http_referrer=https%3A%2F%2Fwww.google.com.br%2F&utm_site=opera_com&&utm_lastpage=opera.com/download&dl_token=53935988")
input()
