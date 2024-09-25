music_bands = ['Czerwone Gitary', 'Lady Pank', 'Perfect']
print(music_bands)

music_bands[0] = 'Wilki'
print(music_bands)

del music_bands[0]
print(music_bands)

music_bands.append('Wilki')
music_bands.append('Czerwone Gitary')

if 'Czerwone Gitary' in music_bands:
    print("'Czerwone Gitary' are on the list!")
else:
    print("'Czerwone Gitary' are not on the list!")

if 'Perfect' in music_bands:
    print("'Perfect' are on the list!")
else:
    print("'Perfect' are not on the list!")

music_bands.remove('Perfect')
print(music_bands)
