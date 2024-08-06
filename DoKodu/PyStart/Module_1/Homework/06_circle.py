import math

x1 = float(input('Enter x1: '))
y1 = float(input('Enter y1: '))
x2 = float(input('Enter x2: '))
y2 = float(input('Enter y2: '))

center_x = (x1 + x2) / 2
center_y = (y1 + y2) / 2

d = math.sqrt(((x2 - x1) ** 2) + ((y2 - y1) ** 2))

r = d / 2

p = math.pi * r * r

print(f'Point 1: ({x1}, {y1})')
print(f'Point 2: ({x2}, {y2})')
print(f'Center: ({center_x}, {center_y})')

print(f'Diameter of the circle: {d:.2f}')
print(f'Radius of the circle: {r:.2f}')
print(f'Area of the circle: {p:.2f}')
