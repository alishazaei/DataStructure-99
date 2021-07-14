import math
import Node


class PriorityQueue(Node.Trees) :
    def __init__(self):
        self.Heap = [math.inf] * 13
        self.size = -1


    def rightchild (self,i) :
        return 2*i+2

    def leftchild (self,i) :
        return 2*i+1


    def parent (self,index) :
        return self.Heap[(index)//2]


    def insert ( self,node ):
        self.size += 1
        self.Heap[self.size] = node
        self.MoveToUp(self.size)

    def MinExtraction (self) :
        # --- -voice Delay = 150 - 200 ms TOS = 6-    -Data- Router --- ->-  -voice Delay = 150 - 200 ms TOS = 6-
        global size
        minimum = self.Heap[0]
        self.Heap[0] = self.Heap[self.size]
        self.Heap[self.size]=math.inf
        self.MoveToDown(0)
        self.size-=1
        return minimum

    def MoveToDown(self,i) :
        minindex1 = i
        minindex2 = i
        l = self.leftchild(i)
        if (l< self.size):
                if self.Heap[l] < self.Heap[minindex2]:
                    self.swap(minindex2, l)
                    minindex2 =l
                    return self.MoveToDown(minindex2)


        r = self.rightchild(i)
        if (r< self.size) :
            if  self.Heap[r] < self.Heap[minindex1] :
                self.swap(minindex1 , r )
                minindex1 = r
                return self.MoveToDown(minindex1)



        if ( minindex1 == i and minindex2 == i ) :
           if minindex1 > minindex2 :
               return minindex1
           else :
               return minindex2


    def MoveToUp (self,index ) :
        while index>0 and self.parent(index) > self.Heap[index] :
            self.swap( (index)//2 , index)
            index = ((index)//2)


    def swap(self,i, j):
        temp = self.Heap[i]
        self.Heap[i] = self.Heap[j]
        self.Heap[j] = temp

    def display ( self,root ) :
        for index in range (4) :
            print(self.MinExtraction())
