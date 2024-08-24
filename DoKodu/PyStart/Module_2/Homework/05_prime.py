number = int(input('Enter integer number: '))

if number <= 1:
    print('Prime number is greater than 2')
    exit()

for i in range(2, number):
    if number % i == 0:
        print(f'{number} is not a prime number')
        exit()

print(f'{number} is a prime number')