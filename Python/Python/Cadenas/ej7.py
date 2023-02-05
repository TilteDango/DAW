"""
Ejercicio 07

a) Indique si la segunda cadena es una subcadena de la primera. Por ejemplo, "cadena" es una subcadena de "subcadena".

### TESTS

>>> subString('subcadena', 'cadena')
True

>>> subString('subcalena', 'cadena')
False


b) Devuelva la que sea anterior en orden alfábetico. Por ejemplo si recibe "kde" y "gnome" debe devolver "gnome".


###TESTS

>>> first_sort("kde", "gnome")
'gnome'

>>> first_sort("Sole", "Fran")
'Fran'
"""


def subString(str, substr):
    return substr in str

def first_sort(str1, str2):
    if str1 > str2:
        return str2
    else:
        return str1





if __name__ == '__main__':
    import doctest
    doctest.testmod()