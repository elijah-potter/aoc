file = open("3.txt")

def n_to_priority(n: int) -> int:
    if n >= 97:
        return n - 96
    else:
        return n - 64 + 26

def calc_total_priority(group: list[str]) -> int:
    if len(group) < 1:
        return 0

    bytesacks = map(lambda sack: bytearray(sack , encoding="utf8"), group)
    priorities = list(map(lambda bytesack: set(map(n_to_priority, bytesack)), bytesacks))

    cur = priorities[0]

    for x in priorities:
       cur = cur.intersection(x) 

    return sum(cur)

total = 0

while True:
    line1 = file.readline()

    if line1 == "DONE\n":
        break;

    line2 = file.readline()
    line3 = file.readline()

    group = [line1, line2, line3]

    total += calc_total_priority(group)

print(total)
