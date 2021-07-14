from Node import *

class inordertraversal :
    def __init__(self):
        self.stack=[]

    def inorder_Rec(self, root):
        if root is not None:
            self.inorder_Rec(root.left)
            print(root.val, end=" ")
            self.inorder_Rec(root.right)

    def inorer_NoRecursuion(self , root):
        current = root
        while ( current != None or len(self.stack) > 0 ) :
            while (current != None) :
                self.stack.append(current)
                current=current.left

            current=self.stack.pop()
            print(current.val , end= " ")

            current = current.right

