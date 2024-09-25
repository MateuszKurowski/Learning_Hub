# Task 1
pl = {'Pies': 'Dog', 'Auto': 'Car', 'Torba': 'Bag', 'Jajko': 'Egg'}
en = {'Dog': 'Pies', 'Car': 'Auto', 'Bag': 'Torba', 'Egg': 'Jajko'}

your_dict = pl

language = input('Choose your language pl/en: ')

if language.lower() == 'en':
    your_dict = en

word = input('Enter your word for translate: ')
result = your_dict.get(word)

if result is None:
    print(f"I don't know translate for '{word}'")
else:
    print(result)

# Task 2
# sentence = input('Enter a sentence: ')
sentence = 'one one two three'

words = sentence.split()
word_counter = {}

for word in words:
    word_counter[word] = word_counter.get(word, 0) + 1

print(word_counter)
