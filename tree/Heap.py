

class MaxHeap ():
    def __init__(self):
        self.heap = []

    def rightchild(self, i):
        return 2 * i + 2

    def leftchild(self, i):
        return 2 * i + 1

    def parent(self, i):
        return (i - 1) // 2


    def insert (self , key) :
        if len(self.heap) == 0  :
            self.heap.append(key)
            return self.heap

        self.heap.append(key)
        self.MoveToUp(len(self.heap)-1)


    def MoveToUp (self,index ) :
        while index>0 and self.heap[self.parent(index)] < self.heap[index] :
            self.swap( self.parent(index) , index)
            index = ((index-1)//2)

        return self.heap

    def swap(self,i, j):
        temp = self.heap[i]
        self.heap[i] = self.heap[j]
        self.heap[j] = temp

    def ExteractMax(self):
        result = self.heap[0]
        self.heap[0] = self.heap[len(self.heap)-1]
        self.MoveToDown(0 , self.heap)
        self.heap.pop()
        return self.heap

    def MoveToDown (self , i , Heap) :
        minindex1 = i
        minindex2 = i
        l = self.leftchild(i)
        if (l< len(Heap)-1 ):
                if Heap[l] > Heap[minindex2]:
                    self.swap(minindex2, l)
                    minindex2 =l
                    self.MoveToDown(minindex2, Heap)


        r = self.rightchild(i)
        if (r< len(Heap)-1) :
            if  Heap[r] > Heap[minindex1] :
                self.swap(minindex1 , r )
                minindex1 = r
                self.MoveToDown(minindex1, Heap)


        if (minindex1 == i and minindex2 == i):
            return Heap


    def IsMaxHeap(self,Heap): # checking if it is a max heap  -> O(n)
        for i in range(len(Heap)//2) :
            try:
                if Heap[i] < Heap[2*i+1] or   Heap[i] < Heap[2*i+2] :
                    return False
            except :
                break;
        return True

    def Minheapify (self , i , Heap ) :
        minindex1 = i
        minindex2 = i
        l = self.leftchild(i)
        if (l < len(Heap) - 1):
            if Heap[l] < Heap[minindex2]:
                self.swap(minindex2, l)
                minindex2 = l
                return self.Minheapify(minindex2, Heap)

        r = self.rightchild(i)
        if (r < len(Heap) - 1):
            if Heap[r] < Heap[minindex1]:
                self.swap(minindex1, r)
                minindex1 = r
                return self.Minheapify(minindex1, Heap)

        if (minindex1 == i and minindex2 == i):
            return Heap



    def display (self):
        print("This is the max heap : " ,self.heap)
