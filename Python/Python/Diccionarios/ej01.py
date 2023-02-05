"""
Ejercicio 01

Escribir un programa que lea las palabras de un fichero words.txt
(http://www.pythonlearn.com/code3/words.txt) y las almacene como claves en un
diccionario. No importan los valores.
Posteriormente leer palabras desde teclado y utilizar el operador in como una
forma rápida de comprobar si las palabras están dentro del diccionario o no.
"""

try:
    handler = open('words.txt')
except IOError:
    print('EL fichero no existe')
    exit()

text = handler.read()
handler.close()
word_list = text.split()
dictionary = dict()

for word in word_list:
    dictionary[word] = dictionary.get(word, 0) + 1

while True: 
    word = input("Introduzca una palabra (-1 para salir): ")
    if word != '-1':
        if word in dictionary:
            print("La palabra " + word + " está en el texto.")
        else:
            print("La palabra " + word + " no está en el texto")
    else:
        break


if __name__ == '__main__':
    import doctest
    doctest.testmod()