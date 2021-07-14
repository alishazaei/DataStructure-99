from queues import *
def Traverse (root) :
    ex = queues()
    ex.enqueue(root)

    while ( ex.isEmpty() != True) :
        node = ex.dequeue()
        print(node.val , end=' ')
        if node.left != None :
            ex.enqueue(node.left)
        if node.right != None :
            ex.enqueue(node.right)

