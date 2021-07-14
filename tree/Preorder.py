from Node import *

class preordertraversal :

    def pre_NoRecursuion (self , root ):
        self.stack = []
        current = root
        self.stack.append(current)
        print("\nPreorder Traversal : ")
        while len(self.stack) > 0:
            current = self.stack.pop()
            print(current.val, end=" ")

            if current.right != None:
                self.stack.append(current.right)
            if current.left != None:
                self.stack.append(current.left)

    def pre_Rec(self,root):
        if not root :
            return
        print(root.val)
        self.pre_Rec(root.left)
        self.pre_Rec(root.right)