from math import ceil

walls_amount = int(input('How many walls are there to paint? '))
print("If you want to keep the previous height, press 'Enter'.")

surface_to_painted = 0.0
default_width = 3
default_height = 4
for wall_number in range(walls_amount):
    width = input(f'Enter the width of wall {wall_number + 1} (in meters): ')
    if width == '':
        width = default_width
    else:
        width = float(width)

    height = input(f'Enter the height of wall {wall_number + 1} (in meters): ')
    if height == '':
        height = default_height
    else:
        height = float(height)

    surface_to_painted += width * height

print(f'The surface to be painted is: {surface_to_painted:.2f} square meters.')

primer_layers = input('Number of primer layers: ')
if primer_layers == '':
    primer_layers = 1
else:
    primer_layers = int(primer_layers)

paint_layers = input('Number of paint layers: ')
if paint_layers == '':
    paint_layers = 1
else:
    paint_layers = int(paint_layers)

primer_amount = ceil(surface_to_painted / 5 * primer_layers)
paint_amount = ceil(surface_to_painted / 13 * paint_layers)

print(f'You need {primer_amount} liters of primer.')
print(f'You need {paint_amount} liters of paint.')
