sentence = input('Enter a sentence: ')

for index, word in enumerate(sentence.split(' ')):
    if (index + 1) % 2 == 0:
        print(word.upper(), end=' ')
    else:
        print(word.lower(), end=' ')
