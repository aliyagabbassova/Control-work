﻿// See https://aka.ms/new-console-template for more information

string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
int maxlength = 3;
string[] ShortArray(string[] array)
	{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
		for (int i = 0; i < length; i++)
		{