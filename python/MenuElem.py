class MenuElem:
    def __init__(self, name, subElems):
        self.name = name
        self.subElems = subElems
    def __cmp__(self, other):
        return self.name < other.name
    def __eq__(self, other):
        return self.name == other.name and self.subElems == other.subElems
    def __str__(self):
        return f"{self.name, self.subElems}"
    def __lt__(self, other):
        if self.name != other.name:
            return self.name < other.name
        return self.subElems < other.subElems