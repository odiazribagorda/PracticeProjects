# In my solution I didn't use pickle as suggested on the video

prueba = {'España':'Madrid', 'UK':'Londres', 'Francia':'Paris'}
def save_dic(path,dic):
    file = open(path,'w')
    for item in dic:
        file.write(item + ' ' + dic[item] +'\n')
    file.close()

def read_dic(path):
    file = open(path,'r')
    dic = dict()
    for line in file:
        aux = line.split()
        dic[aux[0]] = aux[1]
    file.close()        
    return dic

# Solution with pickle
import pickle

def save_dic2(path, dic):
    file = open(path, 'wb')
    pickle.dump(dic, file)
    file.close()

def read_dic2(path):
    file = open(path, 'rb')
    dic = pickle.load(file)
    file.close()
    return dic
    