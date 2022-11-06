sumijn = {
    'a':('b', 'c', 'e'),
    'b':('a', 'e', 'd'), 
    'c':('a', 'e', 'f'),
    'd':('b', 'e', 'g'), 
    'e':('a', 'b', 'd', 'g', 'h', 'f', 'c'),
    'f':('c', 'e', 'f'), 
    'h':('f', 'e', 'g'),
    'g':('h','e','d')
    }
incd = {
    'a':('b', 'c', 'e'),
    'b':('e', 'd'), 
    'c':('e', 'f'),
    'd':('e'), 
    'e':('h'),
    'f':('e','f'), 
    'h':(),
    'g':('h','e','d')
}
rebra={
    1:('a', 'b'),
    2:('a', 'e'),
    3:('a', 'c'),
    4:('c', 'e'),   
    5:('b', 'd'),
    6:('b', 'e'),
    7:('d', 'e'),
    8:('c', 'f'),
    9:('f', 'e'),
    10:('f', 'h'),
    11:('e', 'h'),
    12:('g', 'h'),
    13:('g', 'e'),
    14:('g', 'd'),
}

print('Суміжності: ')
for key, value in sumijn.items():
    print(f"{key}: {value}")
    
print('Інцидентності: ')
for key, value in incd.items():
    print(f"{key}: {value}")

print('Ребрами: ')
for key, value in rebra.items():
    print(f"{key}: {value}")  