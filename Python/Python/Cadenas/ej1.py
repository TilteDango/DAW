"""
Ejercicio 01a

Escribir funciones que dada una cadena de caracteres:

a) Retorne los dos primeros caracteres.

### TEST 

>>> cad = "El día de hoy es un día especial"
>>> gives_first_two_characters(cad)
'El'

>>> cad = "$ Es un dia maravilloso"
>>> gives_first_two_characters(cad)
'$ '


b) Imprima los tres últimos caracteres.

### TEST

>>> cad = "El día de hoy es un día especial"
>>> gives_first_three_charactets(str)
'ial'

>>> cad = "$ Es un día maravilloso"
>>> gives_first_two_characters(str)
'oso'

c) Retorne dicha cadena cada dos caracteres. Ej.: "recta" imprime "rca"

### TEST

>>> cad = "El día de hoy es un día especial"
>>> every_two_characters(str)
'E í d hye u daepca'

>>> cad = "$ Es un día maravilloso"
>>> every_two_characters(str)
'$ E u damrvloo'

d) Retorne dicha cadena en serntido inverso.

### TEST

>>> cad = 'En un lugar de la Mancha de cuyo nombre no quiero acordarme' 
>>> invert(cad)
'emradroca oreiuq on erbmon oyuc ed ahcnaM al ed ragul nu nE'

>>> invert("¡Hola mundo!")
'!odnum aloH¡'

e) Imprima la cadena en un sentido y en el sentido inverso

### TEST

>>> cad = "En un lugar de la Mancha"
>>> string_and_inverted(cad)
'En un lugar de la ManchaahcnaM al ed ragul nu nE'

>>> string_and_inverted('reflejo')
'reflejoojelfer'

"""

def gives_first_two_characters(str):
    return str[:2] # Esto lo que hace es devolver dos carcateres, para ello esta el ":2".

def gives_first_three_charactets(str):
    return str[:-3] # También se puede coger las cadenas al reves.

def every_two_characters(phrase):
    print(phrase)
    str = ""
    for i in range(0, len(phrase), 2):
        str += phrase[i]
    return(str)

def invert(str):
    return ''.join(reversed(str))
    
def string_and_inverted(str):
    return str + invert(str)

if __name__ == '__main__':
    import doctest
    doctest.testmod()