# Task 1
sentence = input('Enter a sentence: ')
words = sentence.split(' ')

print(f'Your sentences words amount: {len(words)}')
print(f'Your sentences signs amount: {len(sentence)}')

# Task 2
numbers = []
for i in range(5):
    numbers.append(int(input(f'Enter {i + 1} number: ')))

print(f'Min: {min(numbers)}')
print(f'Max: {max(numbers)}')
print(f'Avg: {sum(numbers) / len(numbers)}')

# Task 3

# names = input('Enter names, separated by commas')
names = 'Adam Mickiewicz, Adam Asnyk, Zbigniew Nienacki'
persons = names.split(', ')

list_of_names = []
for person in persons:
    first_name, last_name = person.split(' ')
    if first_name not in list_of_names:
        list_of_names.append(first_name)

list_of_names.sort(reverse=True)
print(list_of_names)
