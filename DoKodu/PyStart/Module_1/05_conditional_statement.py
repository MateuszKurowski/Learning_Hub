# Task 1
number = int(input('Enter an integer: '))
if number % 2 == 0:
    print(f'The number {number} is even')
else:
    print(f'The number {number} is NOT even')

# Task 2
value1 = int(input('Enter the 1st integer: '))
value2 = int(input('Enter the 2nd integer: '))

if value1 > value2:
    print(f'The first value is greater: {value1} > {value2}')
elif value2 > value1:
    print(f'The second value is greater: {value2} > {value1}')
else:
    print(f'The values are equal: {value1} = {value2}')

# Task 3
temperature = float(input('What is the temperature? '))

if temperature <= 10:
    print(f'{temperature} degrees is very cold! Better stay home')
elif temperature < 20:
    print(f'{temperature} degrees is chilly! Better take a jacket!')
else:
    print(f'{temperature} degrees is warm, have fun!')
