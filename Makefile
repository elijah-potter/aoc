CC = g++ -Wall -Wextra -Werror

one.o:
	$(CC) -c -o one.o one.cpp

main.o:
	$(CC) -c -o main.o main.cpp

main: one.o main.o
	$(CC) -o main main.o one.o -lstdc++

clean:
	rm -r *.o || true
