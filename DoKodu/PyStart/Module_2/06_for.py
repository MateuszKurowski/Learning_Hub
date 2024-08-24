# Task 1
numbers = tuple(range(0, 50))

for number in numbers:
    if number % 4 == 0:
        print(f'Number {number} is divisible by 4')
    if number % 5 == 0:
        print(f'Number {number} is divisible by 5')

# Task 2
names = 'Mateusz', 'Wojtek', 'Janek', 'Alan'

for name in names:
    if len(name) > 5:
        print(name)

# Task 3
amount = 4
for i in reversed(range(0, amount + 1)):
    for j in range(1, i + 1):
        print(j, end=' ')
    print()
