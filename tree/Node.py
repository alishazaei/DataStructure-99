from abc import ABC, abstractmethod
class Node:
    def __init__(self,key):
        self.left = None
        self.right = None
        if key==None :
            self.val = 0
        else :
             self.val = key
        self.height =1


class ThreadedNode:
    def __init__(self,key):
        self.left = None
        self.right = None
        self.val = key
        self.rightthread= False


class Trees(ABC):
    @abstractmethod
    def display(self , root):
        pass