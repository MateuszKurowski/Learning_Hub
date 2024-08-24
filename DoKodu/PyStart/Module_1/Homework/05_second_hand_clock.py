time_in_seconds = int(input('Enter the current second: '))

time_in_minutes = time_in_seconds % 3600 / 60

time_in_hours = time_in_seconds // 3600

print(f'The current time is: {time_in_hours:02.0f}:{time_in_minutes:02.0f}')
