# Task 1
height = float(input('Enter your height (cm): '))
weight = float(input('Enter your weight (kg): '))

height_in_meters = height / 100

bmi = weight / (height_in_meters ** 2)
print(f'Your BMI is: {bmi}')

# Task 2
VAT = 0.23 # 23%
net_price = float(input('Enter the net price: '))
gross_price = net_price + (net_price * VAT)

print(f'For a net price of: {net_price} and VAT of 23%, the gross price is: {gross_price}')

# Task 3
a = float(input('Enter a: '))
b = float(input('Enter b: '))
h = float(input('Enter h: '))
area = (a + b) * h / 2

print(f'The area of a trapezoid with dimensions a={a}, b={b}, and h={h} is: {area}')