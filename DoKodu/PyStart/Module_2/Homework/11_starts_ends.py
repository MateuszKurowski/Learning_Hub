sentence = input('Enter a sentence: ')

for word in sentence.split(' '):
    if word[0].lower() == word[-1].lower():
        print(word)
