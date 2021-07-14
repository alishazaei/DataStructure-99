from Node import *
class AVLTree :
    def __init__(self):
        self.stack = []

    def insert (self , root , key ) :
        if root is None:
            return Node(key)
        else:
            if root.val == key:
                return root
            elif root.val < key:
                root.right = self.insert(root.right, key)
            else:
                root.left = self.insert(root.left, key)

        root.height = 1 + max(self.Getheight(root.left),self.Getheight(root.right))
        BF = self.BalanceFactor(root) #Balance Factor {-1,0,1}


        if BF > 1 and key < root.left.val :   #LL
            return self.RotateToRight(root)
        if BF < -1 and key > root.right.val: #RR
            return self.RotateToLeft(root)
        if BF > 1 and key > root.left.val :#LR
            root.left= self.RotateToLeft(root.left)
            return self.RotateToRight(root)
        if BF < -1 and key < root.right.val : #RL
            root.right = self.RotateToRight(root.right)
            return self.RotateToLeft(root)

        return root


    def RotateToRight(self , node):
        n1 = node
        n2 = node.left
        n3 = node.left.right
        n2.right=n1
        n1.left = n3
        n1.height =  1 + max(self.Getheight(n1.left),self.Getheight(n1.right))
        n2.height = 1 + max(self.Getheight(n2.left), self.Getheight(n2.right))
        return n2



    def RotateToLeft(self,node ):
        n1 = node
        n2 = node.right
        n3 = node.right.left
        n2.left = n1
        n1.right = n3
        n1.height = 1 + max(self.Getheight(n1.left), self.Getheight(n1.right))
        n2.height = 1 + max(self.Getheight(n2.left), self.Getheight(n2.right))
        return n2


    def Getheight(self,node):
        if not node :
            return  0
        return node.height


    def BalanceFactor(self , node):
        if not node :
            return  0
        return   self.Getheight(node.left) - self.Getheight(node.right)

    def inorer(self , root):
        print("\nInorder  Traversal : ")
        current = root
        while ( current != None or len(self.stack) > 0 ) :
            while (current != None) :
                self.stack.append(current)
                current=current.left
            current=self.stack.pop()
            print( current.val , end= " ")
            current = current.right

    def preorder(self,root):
        self.stack=[]
        current = root
        self.stack.append(current)
        print("\nPreorder Traversal : ")
        while len(self.stack) > 0 :
            current= self.stack.pop()
            print(current.val , end=" ")

            if current.right !=None :
                self.stack.append(current.right)
            if current.left!= None :
                self.stack.append(current.left)


