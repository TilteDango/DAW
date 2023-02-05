"""
Ejercicio 01

Descargar una copia del archivo "romeo.txt" desde http://www.pythonlearn.com/code3/romeo.txt. Escribir un programa para abrir el
fichero y leerlo línea a línea. Por cada línea separar las palabras en una
lista de palabras usando la función split. Las palabras no deben estar
repetidas en la lista. Cuando la lista esté completa, visualizar el resultado
en orden alfabético.
"""

try:
    handler = open('test.txt')
except IOError:
    print("El fichero no existe.")

for line in handler:
    words = line.split()
    words.sort()
    print (" ".join(words))




if __name__ == '__main__':
    import doctest
    doctest.testmod()