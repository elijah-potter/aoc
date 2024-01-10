#include <cassert>
#include <cctype>
#include <cstdio>
#include <iostream>
#include <optional>
#include <string>

using namespace std;

optional<char> firstNum(const string *line) {
  for (size_t i = 0; i < line->length(); i++) {
    char c = line->at(i);

    if (isdigit(c)) {
      return optional(c);
    }
  }

  // I hate this syntax
  return {};
}

optional<char> lastNum(const string *line) {
  for (size_t i = line->length(); i > 0; i--) {
    char c = line->at(i - 1);

    if (isdigit(c)) {
      return optional(c);
    }
  }

  // I hate this syntax
  return {};
}

void one() {
  string data;

  size_t total = 0;

  while (!getline(cin, data).eof()) {
    assert(data.length() > 0);

    string strnum;

    strnum.push_back(firstNum(&data).value());
    strnum.push_back(lastNum(&data).value());

    int num = stoi(strnum);

    total += num;

    data.clear();
  }

  cout << total << endl;
}
