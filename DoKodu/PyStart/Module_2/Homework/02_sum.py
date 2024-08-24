number = int(input('Enter integer number: '))
if number <= 2:
    print('Number must be greater than 2')
    exit()

numbers = tuple(range(2, number + 1, 2))
print(f'Sum: {sum(numbers)}')
print(f'Average: {sum(numbers) / len(numbers)}')

result = 1
for i in numbers:
    result *= i
print(f'Product: {result}')
