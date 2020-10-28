def get_prime_factors(num):
    can_try = [True for i in range(num)]
    sol = []
    i=2
    while(num > 1):
        while(can_try[i-1] and num%i==0):
            sol.append(i)
            num = num//i
        for j in range(i,num,i):
            can_try[j-1]=False
        i=i+1
    return sol
