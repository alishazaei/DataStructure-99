#Developed by Ali Shazaei
import math
def SelectionSort (arr) :  # n^2
    for i in  range( len(arr)-1 , -1 , -1 ) :
        max = arr[i]
        for j in range(i):
            if (max < arr[j]):
                arr[i] = arr[j]
                arr[j] = max
                max = arr[i]
    return arr

def BubbleSort(arr): #n^2
    for i in range(len(arr)):
        max = arr[i]
        for j in range(len(arr)) :
            if (max < arr[j]):
                arr[i] = arr[j]
                arr[j] = max
                max = arr[i]

    return arr


def InsertionSort ( arr ) : #n^2
    if (len(arr) != 1 ):
        for i in range( 1 , len(arr) ):
            selected = arr[i]
            j = i-1
            while selected < arr[j] and j != -1 :
                save = arr[j+1]
                arr[j+1] = arr[j]
                arr[j] =save
                j = j -1

    return (arr)




arr=[]
n = input()
for i in range(int(n)) :
    ex = input()
     arr.append(int(ex))

print(InsertionSort(arr))


arr = [ 30 , 20 ,5 , 9 , 90 , 85 , 3 , 2 ,1  , 8 ,17 ]
print(MergeSort(arr))
print(SelectionSort(arr))
print(BubbleSort(arr))
print(InsertionSort(arr))