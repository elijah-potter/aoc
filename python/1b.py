file = open("../1.txt")

# Reads from the file line-by line, parsing numbers to evaluate elf inventories 
# Returns an empty list when "DONE" is encountered.
def parse_elf_inventory():
    out = []
    while True:
        line = file.readline()
        if line == "\n":
            return out
        elif line == "DONE\n":
            return []
        else:
            out.append(int(float(line)))

cals = []

while True:
    inventory = parse_elf_inventory()
    cal = sum(inventory)
    if cal > 0:
        cals.append(cal)
    else:
        break

cals.sort(reverse=True)

print(sum(cals[0:3]))
