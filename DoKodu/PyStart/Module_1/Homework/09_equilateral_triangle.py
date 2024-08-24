from math import sqrt

a = float(input('Enter the side length of the equilateral triangle: '))

area = sqrt(3) / 4 * a ** 2
perimeter = 3 * a

print(f"The perimeter of the equilateral triangle is: {perimeter}")
print(f"The area of the equilateral triangle is: {area}")
