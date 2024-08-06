const btnIncrease = document.querySelector('.sizeUp')
const btnDecrease = document.querySelector('.sizeDown')
const btnColor = document.querySelector('.color')
const text = document.querySelector('.text').querySelector('p')
let textSize
const maxRange = 48
const minRange = 16

const GetFontSize = () => {
	textSize = window.getComputedStyle(text, null).getPropertyValue('font-size').replace(/\D/g, '')
}

const IncreaseSize = () => {
	GetFontSize()
	if (textSize >= maxRange) return
	text.style.fontSize = parseInt(textSize) + 3 + 'px'
}

const DecreaseSize = () => {
	GetFontSize()
	if (textSize <= minRange) return
	text.style.fontSize = parseInt(textSize) - 3 + 'px'
}

const ChangeColor = () => {
	const r = Math.floor(Math.random() * 255)
	const g = Math.floor(Math.random() * 255)
	const b = Math.floor(Math.random() * 255)
	text.style.color = `rgb(${r},${g},${b})`
}

btnIncrease.addEventListener('click', IncreaseSize)
btnDecrease.addEventListener('click', DecreaseSize)
btnColor.addEventListener('click', ChangeColor)
