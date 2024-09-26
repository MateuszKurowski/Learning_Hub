from random import randint
from math import sqrt, pow, floor, ceil

number = randint(1, 100)
number_pow = pow(number, 2)
number_sqrt = sqrt(number)
number_sqrt_floor = ceil(sqrt(number))
number_sqrt_ceil = floor(sqrt(number))

print(f'Number: {number}')
print(f'Number power: {number_pow}')
print(f'Number sqrt: {number_sqrt}')
print(f'Number sqrt floor: {number_sqrt_floor}')
print(f'Number sqrt ceil: {number_sqrt_ceil}')


