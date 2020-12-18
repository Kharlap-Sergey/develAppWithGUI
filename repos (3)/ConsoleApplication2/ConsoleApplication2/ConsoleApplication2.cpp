// ConsoleApplication2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <vector>
#include <iostream>
#include <fstream>

using namespace std;

struct Word {
	int wordIndex;
	string value;
};

vector <Word> validWords;
vector <string> dictionary;
char letter;

bool checkWordValid(string word, char letter) {
	if (word.front() == letter || word.back() == letter) {
		return false;
	}
	for (int i = 1; i < word.size() - 2; i++) {
		if (word[i] == letter) {
			return true;
		}
	}

	return false;
}

void addWord(string wordValue, int wordIndex) {
	Word word;
	word.wordIndex = wordIndex;
	word.value = wordValue;
	validWords.push_back(word);
}

void input() {
	ifstream in("input.txt");

	string rule;
	in >> rule;

	letter = char(tolower(rule[0]));

	while (!in.eof()) {
		string dirtyWord;
		in >> dirtyWord;
		
		dirtyWord.pop_back();
		dictionary.push_back(dirtyWord);
	}
}

void output() {
	ofstream out("output.txt");

	out << "Условие: ";

	for (int i = 0; i < dictionary.size(); i++) {
		out << dictionary[i] << ", ";
	}
	out << endl << endl << "Буква для поиска: " << letter << endl << endl;
	out << "Результат: " << endl;

	for (int i = 0; i < validWords.size(); i++) {
		out << validWords[i].wordIndex << " " << validWords[i].value << endl;
	}
}

void findValidWordList() {
	for (int i = 0; i < dictionary.size(); i++) {
		string wordValue = dictionary[i];
		if (checkWordValid(wordValue, letter)) {
			addWord(wordValue, i + 1);
		}
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");
	
	input();
	findValidWordList();
	output();

	return 0;
}


// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
