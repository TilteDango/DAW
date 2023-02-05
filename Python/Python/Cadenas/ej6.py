"""
Ejercicio 06

a) Devuelva solamente las letras consonantes. Por ejemplo, si recibe 'Algoritmos o logaritmos' debe devolver 'lgtms lgrtms'

### TESTS

>>> consonants('Algoritmos o logaritmos')
'lgrtms  lgrtms'

b) Devuelva solamente las letras vocales. Por ejemplo, si recibe "sin consonantes" debe devolver "i ooae".

###TESTS

>>> vowels("Sin consonantes murciélago Guadalajara San Sebastián")
'i ooae uiéao uaaaaa a eaiá'

c) Reemplace cada vocal por su siguiente vocal. Por ejemplo, si recibe 'vestuario' debe devolver 'vistaerou'.

### TESTS

>>> revowel('vestuario')
'vistaerou'

>>> revowel('vestUariO')
'vistAeroU'

d) Indique si se tarta de un palíndromo. Por ejemplo, anita lava la tina es un palíndromo (se lee igual de izquierda a derecha que de derecha a izquierda).

###TESTS

>>> palindrome('el bar es iman o zona miserable')
True

>>> palindrome('antytalabva la tina')
False

>>> palindrome('anita la gorda lagartona no traga la droga latina')
True
"""

def consonants(str):
    cad = ""
    consonant ="qwrtypsdfghjklñzxcvbnmQWRTYPSDFGHJKLÑZXCVBNMb "

    for letter in str:
        if letter in consonant:
            cad += letter
    
    return cad
        
def vowels(str):
    cad = ""
    consonant ="qwrtypsdfghjklñzxcvbnmQWRTYPSDFGHJKLÑZXCVBNMb"

    for letter in str: 
        if letter not in consonant:
            cad += letter
    
    return cad

def revowel(str):
    cad = ""
    vowels = "aeiou"

    for letter in str:
        if letter in vowels or letter in vowels.upper():
            if letter in vowels.upper():
                n = vowels.upper().index(letter)
                if n == len(vowels) -1:
                    n = -1
                cad += vowels.upper()[n+1]
            else:
                n = vowels.index(letter)
                if n == len(vowels) -1:
                    n = -1
                cad += vowels[n+1]
        else:
            cad += letter

    return cad


def palindrome(str):

    cad = trim(str)
    rev = trim(str)[::-1]

    return cad == rev


def trim(str):
    cad = ""
    for letter in str:
        if letter != ' ':
            cad += letter

    return cad
if __name__ == '__main__':
    import doctest
    doctest.testmod()