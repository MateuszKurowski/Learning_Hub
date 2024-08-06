const btn = document.querySelector('.arrow')
const icon = document.querySelector('.fas')
const img = document.querySelector('.item1')

const toggleImageVisibility = () => {
	img.classList.toggle('hide')

	if (img.classList.contains('hide')) icon.style.transform = 'rotate(180deg)'
	else icon.style.transform = 'rotate(0)'
}

btn.addEventListener('click', toggleImageVisibility)
