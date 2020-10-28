def is_palindrome(w):
    ## We clean the string
    w.lower()
    w = ''.join(filter(lambda x: x.isalpha(),w))
    ## The string is reduced while start and end are equal.
    while(len(w) > 1 and w[0]==w[len(w)-1]):
        w=w[1:len(w)-1]
    ## Returns if the processed was finished with at most one letter.
    return len(w) <= 1
