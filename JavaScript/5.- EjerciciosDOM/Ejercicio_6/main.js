onload = changeBody;



function changeBody(){
    const third_paragraph = document.querySelector('p:nth-of-type(3)')
    const second_paragraph = document.querySelector('p:nth-of-type(2)')

    third_paragraph.innerHTML += '<a href="http://www.iesromerovargas.com/">+ info</a>'
    console.log(third_paragraph, second_paragraph)

    const  new_p =document.createElement('p')
    new_p.textContent = 'Lorem ipsum sit amet, y todo ese rollo'
    new_p.style.color = 'red'
    third_paragraph.appendChild(new_p)

    second_paragraph.textContent = ""
}