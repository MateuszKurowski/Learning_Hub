# Task 1
name = input('Enter your name: ')

if name.endswith('a'):
    print('Hello madam')
else:
    print('Hello sir')

# Task 2
password = input('Enter your password to upgrade: ')

new_password = password.replace('a', '@').replace('A', '@').replace('s', '$').replace('S', '$')
print(f'{password} -> {new_password}')

# Task 3

sentence = 'Pies to najlepszy przyjaciel człowieka, lecz nie każdy pies o tym wie'

amount = sentence.lower().count('pies')
print(f'The word "pies" appeared: {amount}')

# Task 4

sentence = '12 kilogramów jabłek, 10 kilogramów gruszek, 20 kilogramów śliwek'

sum = 0
for word in sentence.split(' '):
    if word.isnumeric():
        sum += float(word)

print(f'Buy: {amount} kg')
