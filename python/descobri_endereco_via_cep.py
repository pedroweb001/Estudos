import requests

def get_address_from_cep(cep):
    base_url = 'https://viacep.com.br/ws/{}/json/'.format(cep)
    response = requests.get(base_url)

    if response.status_code == 200:
        data = response.json()
        if 'erro' in data:
            return "CEP não encontrado"
        else:
            return f"Endereço: {data['logradouro']}, {data['bairro']}, {data['localidade']} - {data['uf']}"
    else:
        return "Erro ao consultar o CEP"

def main():
    cep = input("Digite o CEP: ")
    address = get_address_from_cep(cep)
    print(address)

if __name__ == '__main__':
    main()
