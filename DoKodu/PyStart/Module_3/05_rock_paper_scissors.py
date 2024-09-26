from random import choice

options = ('paper', 'rock', 'scissors')

print('Armory:')
print('1. Paper')
print('2. Rock')
print('3. Scissors')

player_input = input('Chose your weapon: ')
player_choice = ''

if (player_input.lower() == '1'
        or player_input.lower() == 'p'
        or player_input.lower() == 'paper'
        or player_input.lower() == 'papers'):
    player_choice = 'paper'
elif (player_input.lower() == '2'
      or player_input.lower() == 'r'
      or player_input.lower() == 'rock'
      or player_input.lower() == 'rocks'):
    player_choice = 'rock'
elif (player_input.lower() == '3'
      or player_input.lower() == 's'
      or player_input.lower() == 'scissors'
      or player_input.lower() == 'scissor'):
    player_choice = 'scissors'
else:
    print('You picked wrong option.')
    quit()


computer_choice = choice(options)
print(f'Computer choice {computer_choice}')
print(f'Your choice {player_choice}')
print()

if player_choice == computer_choice:
    print('Draw!')
elif (player_choice == 'paper' and computer_choice == 'rock') or \
    (player_choice == 'rock' and computer_choice == 'scissors') or \
    (player_choice == 'scissors' and computer_choice == 'paper'):
    print('Player win!')
else:
    print('Computer win!')
