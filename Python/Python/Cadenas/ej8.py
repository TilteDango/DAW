"""
Ejercicio 08

Escribir una función que reciba una cadena de unos y ceros (es decir, un número en representación binario) y devuelva el valor decimal correspondiente.

### TESTS

bin_to_dec("11000100")
196
"""

def bin_to_dec(bin):
    i = 0
    for number in bin:
        i *= 2
        if number == "1":
            i += 1
    return i

    




if __name__ == '__main__':
    import doctest
    doctest.testmod()