"""
Ejercicio 05

a) La primera letra de cada palabra. Por ejemplo, si recibe Universal Serial Bus debe devolver USB

### TESTS

>>> acronim("Universal Serial Bus")
'USB'

>>> acronim("      Universal     Serial    Bus")
'USB'

>>> acronim("universal serial bus")
'USB'

b) Dicha cadena con la primera letra de cada palabra en mayúsculas. Por ejemplo, si recibe 'república argentina' debe devolver 'República Argentina'.

### TESTS

>>> first_letter_mayus('La confianza pública en ellos tendrá que ser destruida  completamente para acabar realmente con ellos')
'La Confianza Pública En Ellos Tendrá Que Ser Destruida Completamente Para Acabar Realmente Con Ellos'

c) Las palabras que comiencen con la letra A. Por ejemplo, si recibe "Antes de ayer" debe devolver "Antes ayer".

### TESTS

>>> detect_A("    Antes de fdff Antonio ayer     ")
'Antes Antonio ayer'

"""

def acronim(str):
    cad = ""
    words = str.split()
    for word in words:
        cad += word[0]
    return cad.upper()

def first_letter_mayus(str):
    cad = ""
    words = str.split()
    for word in words :
        cad += word[0].upper() + word[1:] + " "
    return cad[:-1]
    
def detect_A(str):
    cad = ""
    letter = "aAáÁäÄ"
    words = str.split()
    for word in words:
        if word[0] in letter:
            cad += word + " "

    return cad[:-1]
if __name__ == '__main__':
    import doctest
    doctest.testmod()