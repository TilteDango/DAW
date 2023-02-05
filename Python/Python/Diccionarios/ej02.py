"""
Ejercicio 02


Escribe un programa que contabilice cada mensaje de correo electrónico
por el día de la semana en que se envió. El proceso buscará líneas que
comiencen con "From " mirarán la tercera palabra de la línea y registrará
la cuenta para cada día de la semana. Al final del programa visualizar
los totales de cada día.
"""
try:
    handler = open('test2.txt')
except IOError:
    print("El fichero de texto no existe")
    exit()

dictionary = {}
for line in handler:  
    if line.startswith('From:'):
        print(line)
        words = line.split()
        if len(words) == 2:
            date = words[1]
            if date not in dictionary:
                dictionary[date] = 1
            else:
                dictionary[date] += 1


for date in dictionary:
    print(date)





if __name__ == '__main__':
    import doctest
    doctest.testmod()