xa = float(input('Enter "xa": '))
ya = float(input('Enter "ya": '))
xb = float(input('Enter "xb": '))
yb = float(input('Enter "yb": '))
xc = float(input('Enter "xc": '))
yc = float(input('Enter "yc": '))

area = abs(0.5 * (xb - xa) * (yc - ya) - (yb - ya) * (xc - xa))
print(f'The area of triangle is: {area:.2f}')
