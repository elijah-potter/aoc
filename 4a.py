file = open("4.txt")

def process_line(line: str) -> bool:
    elves_raw = line.split(",")
    elves_t = list(map(lambda el: list(map(int, el.split("-"))), elves_raw))

    return (elves_t[0][0] <= elves_t[1][0] and elves_t[0][ 1] >= elves_t[1][ 1]) or (elves_t[1][0] <= elves_t[0][0] and elves_t[1][ 1] >= elves_t[0][ 1])

total = 0

while True:
    line = file.readline() 

    if line == "DONE\n":
        break;

    if process_line(line):
        total += 1;

print(total)
