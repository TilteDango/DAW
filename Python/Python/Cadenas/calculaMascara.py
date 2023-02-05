"""
Ejercicio 02d
Escribir funciones que dada una cadena y un carácter:
d) Inserte el carácter cada 3 dígitos en la cadena.
Ej. 2552552550 y . debería devolver 255.255.255.0
### TESTS
>>> puntos("", ".")
''
>>> puntos("2", ".")
'2'
>>> puntos("25", ".")
'25'
>>> puntos("255", ".")
'255'
>>> puntos("2552552550", ".")
'255.255.255.0'
>>> puntos("25525525525", ".")
'255.255.255.25'
>>> puntos("255255255255", ".")
'255.255.255.255'

>>> puntos("", ".", 3)
''
>>> puntos("2", ".", 3)
'2'
>>> puntos("25", ".", 3)
'25'
>>> puntos("255", ".", 3)
'255'
>>> puntos("2552552550", ".", 3)
'255.255.255.0'
>>> puntos("25525525525", ".", 3)
'255.255.255.25'
>>> puntos("255255255255", ".", 3)
'255.255.255.255'
>>> puntos("", ".", 7)
''
>>> puntos("2", ".", 7)
'2'
>>> puntos("25", ".", 7)
'25'
>>> puntos("255", ".", 7)
'255'
>>> puntos("2552552550", ".", 7)
'255.255.255.0'
>>> puntos("25525525525", ".", 7)
'255.255.255.25'
>>> puntos("255255255255", ".", 7)
'255.255.255.255'

"""

def puntos(cadena, signo, maximo = float('inf')):

    i = 0
    time = 0
    cad = ""
    for letra in cadena : 
        
        if i == 3 and time < maximo :
            time += 1
            cad += signo
            i = 0
        i += 1
        cad += letra
        
    return cad

if __name__ == '__main__':
    import doctest
    doctest.testmod()




