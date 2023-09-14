from enum import IntEnum

file = open("2.txt")

class Move(IntEnum):
    Rock = 1,
    Paper = 2,
    Scissors = 3

class Outcome(IntEnum):
    Lose = 0,
    Draw = 3,
    Win = 6

def char_to_move(char: str) -> Move: 
    match char.upper():
        case "A" | "X":
            return Move.Rock
        case "B" | "Y":
            return Move.Paper
        case "C" | "Z":
            return Move.Scissors
        case _:
            exit(1)

def calc_outcome(move_a: Move, move_b: Move) -> Outcome:
    if move_a == move_b:
        return Outcome.Draw

    if move_a == Move.Scissors and move_b == Move.Rock:
        return Outcome.Win

    if move_a > move_b or (move_a == Move.Rock and move_b == Move.Scissors):
        return Outcome.Lose

    return Outcome.Win

def calc_score(move_a: Move, move_b: Move) -> int:
    outcome = calc_outcome(move_a, move_b)

    return move_b + outcome

total = 0

while True:
    line = file.readline()
    if (line == "DONE\n"):
        print(total)
        exit()
    
    move_a = char_to_move(line[0])
    move_b = char_to_move(line[2])
    
    total += calc_score(move_a, move_b)
