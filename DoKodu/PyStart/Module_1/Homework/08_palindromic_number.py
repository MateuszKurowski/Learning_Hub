number = input('Enter a number: ')

if len(number) % 2 != 0 or number != number[::-1]:
    print(f'The number {number} is not a palindrome')
else:
    print(f'The number {number} is a palindrome')
