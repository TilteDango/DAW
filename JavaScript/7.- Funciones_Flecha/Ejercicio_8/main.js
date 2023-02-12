const formIsValid = {
    name : false,
    salary : false
}

const button = document.getElementById('res')
const workers = []
let k = 1

button.addEventListener('click', () => {
    const name = document.getElementById('name')
    const salary = document.getElementById('salary')
    const n = document.getElementById('worker')
    const correct = document.getElementById('correct')
    const salaryCorrect = document.getElementById('salaryCorrect')

    if(CheckName(name.value)){
        correct.innerHTML = ""
        formIsValid.name = true
    } 
    else { 
        correct.innerHTML = 'No has introducido un nombre válido <br>'
    }
    if(CheckSalary(salary.value)) {
        salaryCorrect.innerHTML = ""
        formIsValid.salary = true
    }
    else {    
        salaryCorrect.innerHTML = 'No has introducido un salario válido <br>'
    }

    if (formIsValid.name && formIsValid.salary) {
        formIsValid.name = false
        formIsValid.salary = false
        const works = new Worker(name.value, salary.value)
        workers.push(works)
        k++
        name.value = ""
        salary.value = ""
        name.focus()

        if (k <= 8) {
            if(k == 8){
                button.textContent = `¿Quién cobra más?`
            }
            n.textContent = `Por favor, introduzca los datos del empleado ${k}`
        } else {
            
            let wages = workers.map( workers => workers.salary)
            let maxSalary = Math.max(...wages)
            let maxWorkers = workers.filter(workers => workers.salary == maxSalary)
           
            const p = document.getElementById('p')
        
            if (maxWorkers.length > 1) {
                p.textContent = `Los trabajadores `
                for (let j = 0; j < maxWorkers.length; j++) {
                    if (j < maxWorkers.length -1) {
                        p.textContent += `${maxWorkers[j].name}, `
                    }else{
                        p.textContent += `${maxWorkers[j].name} cobran ${maxWorkers[j].salary} €`
                    }  
                }
            }else{
                p.textContent = `El trabajador que más cobra es ${maxWorkers[0].name} con un salario de ${maxWorkers[0].salary} €`
            } 
        }
    }   
})
   

function Worker(name, salary) {
    this.name = name
    this.salary = salary
}

function CheckName(name){
    let regEx =/^[a-zA-Z]{3,16}$/
    return regEx.test(name)
}

function CheckSalary(salary){
    let regEx = /\d+(,\d+)?/
    return regEx.test(salary)
}

