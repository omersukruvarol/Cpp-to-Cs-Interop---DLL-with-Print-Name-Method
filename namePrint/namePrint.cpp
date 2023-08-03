#include <iostream>
using namespace std;

extern "C"
{
	_declspec(dllexport) void namePrint()
	{

		cout << "Benim adim omer\n";

	}
}