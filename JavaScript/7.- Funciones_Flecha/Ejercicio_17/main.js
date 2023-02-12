const res = document.getElementById('res')
const isGenerated = []

const randomMinMax = (min, max) => Math.floor(Math.random() * (max - min)) + min

const create100Numbers = () =>{
    while (isGenerated.length <= 100) {
        let random =  randomMinMax(1, 1000)
     
        if (!isGenerated.includes(random)) {
             isGenerated.push(random)
        }
     }
     const fragment = document.createDocumentFragment()
     
     isGenerated.forEach(number => {
         const li = document.createElement('li')
         li.textContent = number
         fragment.appendChild(li)
     });
     
     res.appendChild(fragment)
}

create100Numbers()

















