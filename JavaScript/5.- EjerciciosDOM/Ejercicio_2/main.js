onload = ShowAlert;

const links = Array.from(document.querySelectorAll('a'))
const penultimate = links[links.length -2].href
const hrefs = links.map(function(link){
    return link.href
})
const third_paragraph = document.querySelector('p:nth-of-type(3n)')
const paragraph_links = Array.from(third_paragraph.querySelectorAll('a'))

let i = 0;
for (const href of hrefs) {
    if (href.startsWith('http://prueba')) {
        i++;
    }
}

function ShowAlert() {
    alert(`Número de enlaces de la página: ${links.length}
    Dirección a la que enlaza en el penúltimo enlace: ${penultimate}
    Número de enlaces que enlazan a "http://prueba: ${i}
    Número de enlaces del tercer párrafo: ${paragraph_links.length}`)
}




