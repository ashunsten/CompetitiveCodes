#Problem Statement:

#Given an array A of integers of size N. Find the size of the largest subset of the array in which every pair satisfy the condition: x2 + y2 + x*y ≡ B mod C, where x and y are two different elements of the subset and C is a prime number. Note: All elements in the array are different.

class Solution:
    # @param A : list of integers
    # @param B : integer
    # @param C : integer
    # @return an integer
    def solve(self, A, B, C):
        d={}
        maxx=0
        for x in A:
            temp=(x**3-B*x)%C
            if(not d.has_key(temp)):
                d[temp]=1
            else:
                d[temp]+=1
            if(d[temp]>maxx):
                maxx=d[temp]
        return maxx
        
#Editorial:
#(x^3 - y^3) = (x-y)(x^2 + y^2 + xy)
#(x^3-y^3)mod C = (xB-yB)mod C
#(x^3-xB)mod C = (y^3-yB)mod C
# Find all subsets with the same mod C and the Largest is the answer
