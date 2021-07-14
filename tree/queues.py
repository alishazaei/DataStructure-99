from Node import Node
class queues:

    def __init__(self):
        self.queue = []

    def isEmpty(self) :
        return True if len(self.queue) == 0 else False

    def front(self) :
        return self.queue[-1]

    def rear(self) :
        return self.queue[0]

    def enqueue(self, x) -> None:
        self.x = x
        self.queue.insert(0, x)

    def dequeue(self) :
        return self.queue.pop()