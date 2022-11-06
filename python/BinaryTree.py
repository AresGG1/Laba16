from MenuElem import MenuElem


class Node:
    left = None
    right = None
    value = None
    parent = None

    def __init__(self, value, parent=None):
        self.value = value
        self.parent = parent

    def AddElem(self, value):
        if value <= self.value:
            if self.left:
                self.left.AddElem(value)
            else:
                self.left = Node(value, self)
                return
        elif value >= self.value:
            if self.right:
                self.right.AddElem(value)
            else:
                self.right = Node(value, self)
                return

    def Find(self, value):
        if self.value == value:
            print(str(self.value) + " is found")
        elif self.value > value:
            if self.left:
                self.left.Find(value)
            else:
                print(str(value) + "is not found")
        elif self.value < value:
            if self.right:
                self.right.Find(value)
            else:
                print(str(value) + " is not found")

    def PrintTree(self):
        if self != None:
            if self.left != None:
                self.left.PrintTree()
            print(self.value, end=" ")
            if self.right != None:
                self.right.PrintTree()

    def maxValueNode(self):
        max = None
        if self is not None:
            max = self
            if self.right is not None:
                max = self.right.maxValueNode()
        return max

    def minValueNode(self):
        min = None
        if self is not None:
            min = self
            if self.left is not None:
                min = self.left.minValueNode()
        return min

    def Successor(self):
        if self.right is not None:
            return self.right.minValueNode()
        return self.left

def deleteRoot(root):
    delt = root.Successor()
    deleteNode(root, delt.value)
    root.value = delt.value

def deleteNode(root, value):
    if root is None:
        return root
    if value < root.value:
        root.left = deleteNode(root.left, value)
    elif (value > root.value):
        root.right = deleteNode(root.right, value)
    else:
        if root.left is None:
            temp = root.right
            root = None
            return temp

        elif root.right is None:
            temp = root.left
            root = None
            return temp
        temp = root.right.minValueNode()
        root.value = temp.value
        root.right = deleteNode(root.right, temp.value)

    return root

if __name__ == "__main__":
    tree = Node(11)
    tree.AddElem(6)
    tree.AddElem(4)
    tree.AddElem(3)
    deleteRoot(tree)
    tree.PrintTree()
