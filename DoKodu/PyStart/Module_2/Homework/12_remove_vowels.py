sentence = input('Enter a sentence: ')

vowels = ('a', 'e', 'i', 'o', 'u', 'y', 'ą', 'ę')
for i in sentence:
    if i not in vowels:
        print(i, end='')
