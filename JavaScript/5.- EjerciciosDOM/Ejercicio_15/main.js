const links = Array.from(document.querySelectorAll('a'))
const paraghraps = Array.from(document.querySelectorAll('p'))


links.forEach(element => {
    element.href = element.href.replace('http', 'https') 
    let i = 0
    if (element.classList.contains('importante')) {
       attr = document.createAttribute('name')
       attr.value = 'importante' + i++
       element.setAttributeNode(attr)
    }
})

paraghraps.forEach(element => {
    if (element.classList.contains('importante')){
        element.classList.replace('importante', 'resaltado')
    }else{
        element.classList.add('normal')
    }
});

