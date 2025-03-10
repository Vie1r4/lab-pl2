
# # # try:
            

# # #     numero1=int(input("Digite o primeiro numero: "))

# # #     numero2=int(input("Digite o segundo numero: "))

# # #     soma=numero1+numero2

# # #     print("A soma dos numeros resulta em: ",soma)

# # # except ValueError:

# # #     print("Digite apenas numeros interitos")


#     if numero1%2==0:
#         print("O numero sera par")
#     else:
#         print("O numero sera impar")

# except ValueError:
#     print("Digite apenas numeros interitos")


# try:
#     numero = int(input("Digite um numero para ver sua tabuada: "))

#     print(f"Tabuada de {numero}:")
    
#     # Loop para imprimir a tabuada de 1 a 10
#     for i in range(1, 11):
#         resultado = numero * i
#         print(f"{numero} x {i} = {resultado}")

# except ValueError:
#     print("Por favor, digite um numero valido.")
 # -*- coding: utf-8 -*-

try:
    numero = int(input("Digite um número para ver sua tabuada: "))

    print(f"Tabuada de {numero}:")

    # Loop para imprimir a tabuada de 1 a 10
    for i in range(1, 11):
        resultado = numero * i
        print(f"{numero} x {i} = {resultado}")

    print("Tabuada concluída com sucesso!")

except ValueError:
    print("Por favor, digite um número válido.")
