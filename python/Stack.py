class Stack:
    __elems = []

    def pop(self):
        return self.__elems.pop()

    def append(self, value):
        self.__elems.append(value)

    def count(self):
        return len(self.__elems)

FILE_NAME = "task1.txt"

def read_file():
    stream = open(FILE_NAME, 'r')
    return stream.read()

def task():
    stack = Stack()
    for i in read_file():
        if i == '(':
            stack.append(i)
        elif i == ')':
            stack.pop()
    return True if stack.count() == 0 else False

if task():
    print('Дужки збалансовано')
else:
    print('Дужки не збалансовано')