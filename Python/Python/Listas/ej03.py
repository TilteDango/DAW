"""
Ejercicio 03

Reescribir el programa que solicita al usuario una lista de número y muestra
el valor máximo y mínimo de entre ellos y acaba con la palabra "done". Hacerlo
ahora almacenando los números en una lista y hacer uso de la funciones max() y
min().
"""

numbers = []
while True:
    n = input("Escriba un número(done para finalizar):")
    if n != 'done':
        numbers.append(n)
    else:
        break

print ("El máximo es: " + max(numbers))
print("El minimo es: " + min(numbers))





if __name__ == '__main__':
    import doctest
    doctest.testmod()