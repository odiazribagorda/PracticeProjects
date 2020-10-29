def sort_words(input):
    l = input.split()
    ## Bubble sorting the words
    for i in range(1,len(l)):
        aux = l[i]
        j = i-1
        while(j >= 0 and aux.lower()<l[j].lower()):
            l[j+1]=l[j]
            j = j-1
        l[j+1]=aux
    return ' '.join(l)

## Its more efficient to use list.sort() as the given answer.
        