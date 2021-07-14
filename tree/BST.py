from Node import *

class BST :
    def insert(self,root, key):
        if root is None:
            return Node(key)
        else:
            if root.val == key:
                return root
            elif root.val < key:
                root.right = self.insert(root.right, key)
            else:
                root.left = self.insert(root.left, key)
        return root

    def SearchBST ( self,root , key ) :  # o(lgn) returns true or false
        if ( root == None) :
            return False
        if ( root.val == key):
            return True


        elif root.val > key :
            return self.SearchBST(root.left , key)
        else :
            return self.SearchBST(root.right , key )

    def SearchForNode ( self,root , key ) :  # o(lgn) returns node
        if ( root.val == key) :
            return (root)
        elif root.val > key :
            return self.SearchForNode(root.left , key)
        else :
            return self.SearchForNode(root.right , key )


    def Min(self , root ):
        current = root
        #LeftMost Node is the min node
        while ( current.left != None) :
            current = current.left

        return current

    def Max (self , root ) :
        current = root
        # LeftMost Node is the min node
        while (current.right != None):
            current = current.right

        return current

    def succssor(self ,root , element ):
        node = self.SearchForNode(root , element)
        if ( node.right != None ) :
            current = node.right
            return self.Min(current)

        else :
            save = []
            current = root
            while (current != None ) :
                if ( current.val == element) :
                    break
                if current.val < element :
                    current = current.right

                if element < current.val :
                    save.append(current)
                    current = current.left

            return save[len(save)-1]


    def Predecessor(self ,root , element ):
        node = self.SearchForNode(root , element)
        if ( node.left != None ) :
            current = node.left
            return self.Max(current)

        else :
            save = []
            current = root
            while (current != None ) :
                if (current.val == element):
                    break
                if current.val < element :
                    save.append(current)
                    current = current.right
                if element < current.val :

                    current = current.left


            return save[len(save)-1]



    def DeleteNode(self , root , key ):
        current = root
        parent = None
        while (current != None) :
            if current == None :
                return root
            if key == current.val :

                if current.left == None and current.right==None :
                    if key < parent.val:
                        parent.left = None
                    if key > parent.val :
                        parent.right = None
                elif (current.left != None and  current.right == None ) :
                    if key < current.val:
                        parent.left = current.left
                    if key > current.val :
                        parent.right = current.left

                elif(current.left == None and  current.right != None ) :
                    if key < current.val:
                        parent.left = current.right
                    if key > current.val :
                        parent.right = current.right


                elif (current.left != None and current.right != None):
                    succnode =  self.succssor(root , key )
                    current.val = succnode.val
                    if succnode.right != None :
                        succnode = succnode.right
                    else :
                        succnode = None
                return root

            if key < current.val :
                parent = current
                current = current.left
            if key > current.val :
                parent = current
                current= current.right
