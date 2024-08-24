names = ('Mateusz', 'Marek')

new_name = input('Enter your name: ')

if new_name in names:
    print('Your name is already on list!')
else:
    names = names + (new_name,)
    print(f'{new_name} was added to list!')
    print(names)