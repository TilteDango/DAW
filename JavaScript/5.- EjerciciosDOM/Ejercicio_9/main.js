const textarea = document.getElementById('comentarios')

const result = document.getElementById('resultado');

textarea.addEventListener('keydown', () => {
    const chars = textarea.value.length
    rest = 50 - chars
    result.textContent = rest
})