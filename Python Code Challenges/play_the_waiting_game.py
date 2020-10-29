import random
import time
import os

def new_game():
    goal = random.randint(3,10)
    print(f'Goal {goal} seconds')
    print('Press ANY KEY to start timer...')
    input()
    start = time.perf_counter()
    print('Press ANY KEY to stop timer...')
    input()
    end = time.perf_counter()
    result = end-start
    print(f'TIME: {result}')
    if abs(goal-result) < goal*0.1:
        print('Well done, you were very close!')
    elif abs(goal-result) < goal*0.5:
        print('Not bad. Can do better next time!')
    else:
        print('What happened? You were far off!')
    print('Press any key to exit...')
    input()



def waiting_game():
    os.system('cls')
    print('Welcome to the waiting game!')
    exit = False
    while(not exit):
        new_game()
        os.system('cls')
        print('THE WAITING GAME')
        op = input('1-To play again\n0-To exit\n')
        exit = op==0
    