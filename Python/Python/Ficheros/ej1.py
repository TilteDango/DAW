"""
Ejercicio 01

Escribe una función que reciba un nombre de fichero, lo abra, lo lea y visualice el ocntenido en mayúscular. Usar en fichero "words.txt" para crear la salida que se busca y el fichero "test.txt" para hacer los tests.

>>> file_cap('test.txt')
'ESTO ESTÁ EN MAYÚSCULAS\\nY ESTO TAMBIÉN'

>>> file_cap('Este fichero no existe')
-1
"""

def file_cap(file_name):
    try:
        file_handle = open(file_name, encoding='utf-8')
    except IOError:
        return -1
    text = ''

    for line in file_handle:
        text += line.upper()
    return text

if __name__ == '__main__':
    import doctest
    doctest.testmod()