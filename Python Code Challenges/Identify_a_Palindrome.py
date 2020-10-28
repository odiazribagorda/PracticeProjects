def is_palindrome(word):
    ## We clean the string
    word.lower()
    word = ''.join(filter(lambda x: x.isalpha(),word))
    
