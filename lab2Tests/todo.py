import copy
# Online Python - IDE, Editor, Compiler, Interpreter
def bubbleSort(array):
    M = 0
    C = 0
    for i in range(len(array)):
        for j in range(0, len(array) - i - 1):
            if array[j] > array[j + 1]:
                temp = array[j]
                array[j] = array[j+1]
                array[j+1] = temp
                M += 3
            C += 1
    print("Sort array:")
    print(array)
    print(f"M={M}, C={C}, M+C={M+C}")



def selectionSort(array, size):
    M = 0
    C = 0
    for step in range(size):
        min_idx = step
        for i in range(step + 1, size):
            if array[i] < array[min_idx]:
                min_idx = i
            C += 1
        (array[step], array[min_idx]) = (array[min_idx], array[step])
        M += 3
    print("Sort array:")
    print(array)
    print(f"M={M}, C={C}, M+C={M+C}")

def mergeSort(array, size):
    M = 0
    C = 0
    k = 0
    j = 0
    l = 0
    temp_array = [0] * size
    for i in range(0, size, 2):
        C += 1
        if (array[i+1] < array[i]):
            M += 3
            temp = array[i+1]
            array[i+1] = array[i]
            array[i] = temp
    for i in range(size):
        temp_array[i] = array[i]
    print(array)
    size_block = 2
    while (size_block < size):
        for b_it in range(0, size, size_block+size_block):
            a_array = [0] * size_block
            b_array = [0] * size_block
            for i in range(b_it, size_block+b_it, 1):
                p = 0
                a_array[p] = temp_array[i]
                p += 1
            for i in range(b_it + size_block, size_block+size_block+b_it, 1):
                p = 0
                b_array[p] = temp_array[i]
                p += 1
            while (k != size_block and j != size_block):
                C += 1
                if (a_array[k]<b_array[j]):
                    M += 1
                    temp_array[l] = a_array[k]
                    k += 1
                    l += 1
                else:
                    M += 1
                    temp_array[l] = b_array[j]
                    j += 1
                    l += 1
            if (k == size_block):
                for i in range(0, size, 1):
                    if ((i % (2 *size_block)) == 0 and i != 0):
                        print(temp_array[i], end=' ')
        size_block *= 2
        print("+")
    print(f"M={M}, C={C}, M+C={M+C}")
    
if __name__ == "__main__":
    N = int(input("N="))
    data = [0] * N
    for i in range(len(data)):
        data[i] = int(input(f"data[{i}]="))
    data_bubble = copy.copy(data)
    data_merge = copy.copy(data)
    print("Not sort:")
    print(data)
    print("Bubble Sort:")
    bubbleSort(data_bubble)
    print("Merge Sort:")
    mergeSort(data_merge, N)
