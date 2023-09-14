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

def char_to_outcome(char: str) -> Outcome: 
    match char.upper():
        case "A" | "X":
            return Outcome.Lose
        case "B" | "Y":
            return Outcome.Draw
        case "C" | "Z":
            return Outcome.Win
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

def match_move_to_outcome(move_a: Move, outcome: Outcome) -> Move:
    if outcome == Outcome.Draw:
        return move_a

    if outcome == Outcome.Win:
        return Move(move_a  % 3 + 1)

    return Move((move_a + 1) % 3 + 1)

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
    outcome = char_to_outcome(line[2])
    move_b = match_move_to_outcome(move_a, outcome)
    
    total += calc_score(move_a, move_b)

