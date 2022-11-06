class Dequeue:
    __elements = []

    def count(self):
        return len(self.__elements)

    def push_back(self, value):
        self.__elements.append(value)

    def pop_back(self):
        return self.__elements.pop()

    def back(self):
        res = self.__elements.pop()
        self.__elements.append(res)
        return res

    def pop_front(self):
        return self.__elements.pop(0)

    def front(self):
        return self.__elements[0]

    def push_front(self, value):
        self.__elements.insert(0, value)
