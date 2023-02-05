"""
Ejercicio 02

a) Inserte el carácter entre cada letra de la cadena. Ej: separar y , debería devolver s,e,p,a,r,a,r

### TESTS

>>> cad = 'En un lugar de la Mancha'

>>> separate(cad)
'E,n, ,u,n, ,l,u,g,a,r, ,d,e, ,l,a, ,M,a,n,c,h,a'

>>> separate('separar',',',2)
's,e,parar'

b) Reemplace todos los espacios por el carácter. Ej: mi archivo de texto.txt y debería devolver mi_archivo_de_texto.txt

### TESTS

>>> cad = 'En un lugar de la Mancha'
>>> change(cad,'_')
'En_un_lugar_de_la_Mancha'

>>> change(cad, '_', 2)
'En_un_lugar de la Mancha'

c) Reemplace todos los dígitos en la cadena por el carácter "X".
    Ej: su clave es: 1540 y X debería volver su clave es: XXXX


### TESTS

>>> change_x("Su clave es: 1540")
'Su clave es: XXXX'

>>> change_x("Su clave es: 1540", 2)
'Su clave es: XX40'

d) Inserte el carácter cada 3 dígitos en la cadena
"""

def separate(str, separator = ',', maxSeparator = float('inf')):
   res = ''
   i = 0
   max = False
   for letter in str:
    if i < maxSeparator:
        res += letter + separator
        i += 1
    else:
        res += letter
        max = True
       
   if max:
    return res
   else :
    return res[:-1]

def change(str, separator = '_', maxSeparator = float('inf')):
    if maxSeparator != float('inf'):
            str = str.replace(' ', separator, maxSeparator)
    else:
        str = str.replace(' ', separator)

    return str

def change_x(str, maxChange = float('inf')):
    i = 0
    cad = ""
    for letter in str:
        if letter.isdigit() and i < maxChange :
            cad += 'X'
            i += 1
        else :
            cad += letter
    return cad



if __name__ == '__main__':
    import doctest
    doctest.testmod()