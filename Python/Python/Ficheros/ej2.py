"""
Ejercicio 02

Escribe un programa que solicite un nombre de fichero, lo abra, lea y busque líneas de la forma:

X-DSPAM-Confidence: 0.8475

Contar estas líneas y extraer los valores en punto flotante de cada una de ellas para finalmente calcular la media de esos valores y generar un salida como la que se muestra a continuación. Media de correo basura: 0.750718518519. No utilizar la función sum() o una variable que se llame sum en la solución. Se puede descargar un fichero con los datos de prueba 
http://www.pythonlearn.com/code/mbox-short.txt.
"""


while True:
    try:
        file = input("Nombre del fichero: ")
        handler = open(file)
        break
    except IOError:
        print("El fichero no existe.")

i = 0
cad = 'X-DSPAM-Confidence:'

for line in handler:
    if line.startswith(cad):
        i += 1

print(i)



if __name__ == '__main__':
    import doctest
    doctest.testmod()