import mysql.connector    
conexao = mysql.connector.Connect(host="localhost", user="root", password="root", database="prj_teste")
if (conexao.is_connected):
    info = conexao.get_server_info()
    print("Você está conectado ao My Sql versão:", info)
    conexao.close()
else:
    print("Não consegui conectar!")    
    exit()