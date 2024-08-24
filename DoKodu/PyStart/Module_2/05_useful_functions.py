grades = 1, 3, 5, 5, 5, 6, 4, 3, 4, 2, 5, 5, 6

print('Your grades: ', sorted(grades))

average = sum(grades) / len(grades)

print(f'Your average grade is: {average:.2f}')

if average >= 4.75:
    print('You will receive a certificate with a stripe.')
else:
    print('Your average is too low to receive a certificate with a stripe')