#include <iostream>
#include <list>

using namespace std;


struct Node{
	int Data;
	int Height;
	Node *Next;
};


class DisjointSet_Tree {
	
	
	public:
	Node* SetsArray;
	Node* thisNode;
	int n;
		
	DisjointSet_Tree(int n){
		SetsArray = new Node[n];
		this->n = n;
		MakeSet();
	}
	

	void MakeSet() {
		for (int i = 0; i < n; i++) {
			SetsArray[i].Data = i;
			SetsArray[i].Height = 0;
			SetsArray[i].Next =&(SetsArray[i]);
		}
	}

	int Find(int x) {
		list<int> TemplateNodes;

		thisNode = &(SetsArray[x]);
		

		if (thisNode->Next == thisNode) 
		{
			return x;
		}

		else
		{
			
			while (thisNode->Next != thisNode)
			{
				TemplateNodes.push_back(thisNode->Data);
				thisNode = thisNode->Next;

			}
			int j = 0;

			while (TemplateNodes.size() > j) {
				list<int>::iterator it = TemplateNodes.begin();
				advance(it, j);
				SetsArray[*it].Next = thisNode;
				j++;
			}
			return thisNode->Data;
		}

	}

	void Union(int x, int y) {
		int Xset = Find(x);
		int Yset = Find(y);
		
		if (Xset != Yset) {
			if (SetsArray[Xset].Height> SetsArray[Yset].Height) {
				SetsArray[Yset].Next = &(SetsArray[Xset]);
			}
			else if (SetsArray[Xset].Height < SetsArray[Yset].Height) {
				SetsArray[Xset].Next = &(SetsArray[Yset]);
			
			}
			else if (SetsArray[Xset].Height == SetsArray[Yset].Height)
			{
				SetsArray[Yset].Next = &(SetsArray[Xset]);
				SetsArray[Xset].Height++;
			}
		}
	}

};


