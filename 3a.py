file = open("3.txt")

def n_to_priority(n: int) -> int:
    if n >= 97:
        return n - 96
    else:
        return n - 64 + 26

def calc_total_priority(sack: str) -> int:
    bytesack = bytearray(sack, encoding="utf8")
    
    cmp1 = set(map(n_to_priority, bytesack[0:len(bytesack) // 2] ))
    cmp2 = set(map(n_to_priority, bytesack[len(bytesack) // 2:len(bytesack)] ))
    
    res = cmp1.intersection(cmp2)
    sack_total = 0
    
    for el in res:
        sack_total += el
    
    return sack_total

total = 0

while True:
    line = file.readline()

    if line == "DONE\n":
        break;

    total += calc_total_priority(line)

print(total)
