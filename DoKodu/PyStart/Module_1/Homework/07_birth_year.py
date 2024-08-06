from datetime import datetime

current_year = datetime.now().year

birth_year = int(input("Enter the year you were born: "))

if current_year < birth_year:
    print("")
    exit()

age = current_year - birth_year
print(f"Your age is: {age}")

if (birth_year % 4 == 0 and birth_year % 100 == 0) or birth_year % 400 == 0:
    print(f"The year {birth_year} was a leap year")
else:
    print(f"The year {birth_year} was not a leap year")
