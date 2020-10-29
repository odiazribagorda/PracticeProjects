# Recursive function that returs the indices of all the
# instances of input in inputList.
def index_all(inputList, input):
    sol = []
    i = 0
    for item in inputList:
        if type(item) is list:
            sol += map(lambda x : [i]+x, index_all(item,input))
        elif item == input:
            sol.append([i])
            print(item)
        i = i+1
    return sol

example = [[[1,2,3],2,[1,3]],[1,2,3]]
example2 = [1,2,3]