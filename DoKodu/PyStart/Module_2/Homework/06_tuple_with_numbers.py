numbers = tuple(range(12, 1024 + 1, 6))

print(f'Count: {len(numbers)}')
print(f'First 3 digits: {numbers[:3]}')
print(f'Penultimate number: {numbers[-2]}')
print(f'Every 6 number after 4: {numbers[3::6]}')
print(f'Every 6 number after 4: {numbers[::-3]}')
print(f'Average of last 10 numbers: {sum(numbers[-10::]) / 10}')
