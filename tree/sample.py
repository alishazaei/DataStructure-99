from Node import Node

class SampleTree :
    def sample(self):
        root  = Node("a")
        root.left = Node("b");
        root.right = Node("c");
        root.left.left = Node("d");
        return root


'''
           a
       /       \
      b          c
    /   \       /  \
   d   None  None  None
  /  \
None None'''