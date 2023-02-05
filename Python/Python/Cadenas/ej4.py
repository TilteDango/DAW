"""
Ejercicio 04

Escribir una función que reciba una cadena que contiene un largo número entero y devuelva una cadena con el número y las separaciones de miles. Por ejemplo, si recibe 1234567890, debe devolver 1.234.567.890

### TESTS


>>> points("1234567890")
'1.234.567.890'
"""

def points(str):
    cad = ''.join(reversed(str))
    aux = ""
    i = 0
    for letter in cad:
        if i != 3:
            aux += letter
            i += 1
        else: 
            aux += '.' + letter
            i = 1

    return "".join(reversed(aux))
if __name__ == '__main__':
    import doctest
    doctest.testmod()