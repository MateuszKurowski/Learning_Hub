from math import sqrt, pi

x1 = float(input('Enter x1: '))
y1 = float(input('Enter y1: '))
x2 = float(input('Enter x2: '))
y2 = float(input('Enter y2: '))

center_x = (x1 + x2) / 2
center_y = (y1 + y2) / 2

d = sqrt(((x2 - x1) ** 2) + ((y2 - y1) ** 2))

r = d / 2

p = pi * r ** 2

length_rect_1 = sqrt(((x1-x2) ** 2) + ((y2-y2) ** 2))
length_rect_2 = sqrt(((x1-x1) ** 2) + ((y1-y2) ** 2))

print(f'Point 1: ({x1}, {y1})')
print(f'Point 2: ({x2}, {y2})')
print(f'Center: ({center_x}, {center_y})')

print(f'Diameter of the circle: {d:.2f}')
print(f'Radius of the circle: {r:.2f}')
print(f'Area of the circle: {p:.2f}')

print(f'The area of the rectangle is: {length_rect_1 * length_rect_2}')
print(f'The perimeter of the rectangle is: {length_rect_1 * 2 + length_rect_2 * 2}')
