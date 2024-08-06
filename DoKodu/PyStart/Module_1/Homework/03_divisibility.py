number = float(input('Enter a number: '))

if number % 5 == 0 and number % 11 == 0:
    print(f'The number {number} is divisible by 5 and 11')
elif number % 5 == 0:
    print(f'The number {number} is divisible by 5')
elif number % 11 == 0:
    print(f'The number {number} is divisible by 11')
else:
    print(f'The number {number} is NOT divisible by 5 and 11')
