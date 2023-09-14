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

max_cal = 0

while True:
    inventory = parse_elf_inventory()
    cal = sum(inventory)
    if inventory == []:
        print(max_cal)
        exit(0)
    elif cal > max_cal:
        max_cal = cal
