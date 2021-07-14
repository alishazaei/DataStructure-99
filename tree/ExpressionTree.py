from Node import *




def ExpressionTree(Postfix):
    stack=[]

    for ch in Postfix :
        if  (ch != '+' and ch  != '-' and ch  != '*' and ch  != '/' and ch != '^') :
            sample = Node(ch)
            stack.append(sample)

        else :
            sample = Node(ch)
            a = stack.pop()
            b = stack.pop()
            sample.right=a
            sample.left=b
            stack.append(sample)

    return stack.pop()
