number1 = int(input('Enter the first integer: '))
number2 = int(input('Enter the second integer: '))
number3 = int(input('Enter the third integer: '))

if number1 >= number2 and number1 >= number3:
    print(f'The number {number1} is the largest!')
elif number2 >= number1 and number2 >= number3:
    print(f'The number {number2} is the largest!')
elif number3 >= number2 and number3 >= number1:
    print(f'The number {number3} is the largest!')

if number1 <= number2 and number1 <= number3:
    print(f'The number {number1} is the smallest!')
elif number2 <= number1 and number2 <= number3:
    print(f'The number {number2} is the smallest!')
elif number3 <= number2 and number3 <= number1:
    print(f'The number {number3} is the smallest!')
