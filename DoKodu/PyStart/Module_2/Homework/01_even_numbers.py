number = int(input('Enter integer number: '))
if number <= 2:
    print('Number must be greater than 2')
    exit()

# for i in range(2, number + 1, 2):
#     print(i, end=', ')

result = ''
for i in range(2, number + 1):
    if i % 2 == 0:
        result += str(i) + ', '
result = result[:-2]
print(result)
