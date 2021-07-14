import sample
from ExpressionTree import *
from BST import *
from ThreadedTree import *
from LevelTraversal import *
import PQ
from Inorder import *
from Preorder import *
from Heap import *
from  AVL import *
A = []
""" =================Sample & Level Order Traversal======================= """
a = sample.SampleTree().sample()
Traverse(a)
print("\nwe created a simple tree ")
""" ===================Expression & Inorder Traversal===================== """
inorderTraverse = inordertraversal()
postfix = "ab+ef*g*-"
Exptree = ExpressionTree(postfix)
print("this is an expression tree without Recursion  :")
inorderTraverse.inorer_NoRecursuion(Exptree) #without Recursion
print("\nthis is an expression tree with Recursion  :")
inorderTraverse.inorder_Rec(Exptree) #with Recursuion
# same Result
print("")
print("")
""" ================BST and Search======================== """
bst = BST()
pre = preordertraversal()
root = Node(50)
root = bst.insert(root, 30)
root = bst.insert(root, 20)
root = bst.insert(root, 40)
root = bst.insert(root, 90)
root = bst.insert(root, 10)
root = bst.insert(root, 80)
print( "The successor of 40 is", bst.succssor(root , 40).val)
print( "The Predessor of 40 is", bst.Predecessor(root , 40).val)
print("Do we have 42 in the tree ? " , bst.SearchBST(root , 42))
print("Do we have 40 in the tree ? " , bst.SearchBST(root , 40))
#pre.pre_NoRecursuion( root)

bst.DeleteNode(root , 10)
print("Key = 10 has been deleted from BST , Inorder Traversal will be like this : ")
inorderTraverse.inorder_Rec(root) #with Recursuion
bst.DeleteNode(root , 50)
print( "\nKey = 50 has been deleted from BST , Inorder Traversal will be like this : ")
inorderTraverse.inorer_NoRecursuion(root) #without Recursuion

""" ===============AVL Tree========================= """

avltree = AVLTree()
root = None
root = avltree.insert(root,10)
root = avltree.insert(root,20)
root = avltree.insert(root,30)
root = avltree.insert(root,40)
root = avltree.insert(root,50)
root = avltree.insert(root,25)
avltree.inorer(root)
avltree.preorder(root)
""" ===============Threaded Tree========================= """
a = thread()
root = None
root = a.createThread(root , 10 )
root = a.createThread(root , 20 )
root = a.createThread(root , 5 )
root = a.createThread(root , 15 )
root = a.createThread(root , 2 )
root = a.createThread(root, 50)
root = a.createThread(root, 3)
root = a.createThread(root, 73)
root = a.createThread(root, 25)
root = a.createThread(root, 20)
root = a.createThread(root , 6 )
root = a.createThread(root, 4)
root = a.createThread(root, 75)
root = a.createThread(root, 1)
root = a.createThread(root, 99)
root = a.createThread(root, 7)
print("")
""" ===============Heap========================= """
#Max Heap order = O(lgn)
heap = MaxHeap()
heap.insert(2)
heap.insert(9)
heap.insert(15)
heap.insert(5)
heap.insert(3)
heap.insert(13)
heap.insert(7)
heap.display()
myheap = heap.ExteractMax()
print("Maximum has been extracted : " , myheap)
print("is this a heap ? " , heap.IsMaxHeap(myheap))
print("Minheapify (index =1 ) : " ,heap.Minheapify(1 , myheap) )
""" ===============simple Max Heap Priority========================= """
pq = PQ.PriorityQueue()
pq.insert(9)
pq.insert(8)
pq.insert(4)
pq.insert(5)
A.append(pq)
A.append(a)

for j in range(2):
    A[j].display(root)
    print("")
# 9 8 18 4 63
# 4 8 9 18 63
