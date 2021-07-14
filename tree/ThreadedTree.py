from Node import *


class thread (Trees):
    def createThread(self , root , key ):
        newnode = ThreadedNode(key)
        current = root
        while (True) :
            parent = current
            if ( root == None ):
                return ThreadedNode(key)

            if ( key ==  current.val ):
                return root
            if ( key < current.val ) :
                current = current.left
                if ( current == None ) :
                    newnode.right = parent
                    newnode.rightthread = True
                    parent.left = newnode
                    return root
            if ( key > current.val) :
                if current.rightthread == False :
                    current = current.right
                    if current == None :
                        parent.right = newnode
                        return root
                else :
                    current.rightthread=False
                    newnode.right = current.right
                    current.right = newnode
                    newnode.rightthread = True

                    return root

    def InorderThread(self, root):
        node = self.left(root)

        while node != None :
            print(node.val, end=' ')
            if node.rightthread :

                node = node.right
            else :
                node = self.left(node.right)





    def left(self , node ):
        if ( node == None ) :

            return None
        else :
            while node.left != None :
                node = node.left


            return node


    def display(self , root):
        self.InorderThread(root)

