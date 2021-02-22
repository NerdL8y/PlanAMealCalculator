/*
* This class checks a user input string to verify it only uses the following characters:
    Numeric:   0 - 9
    Uppercase Alpha: A - Z
    Lowercase Alpha: a - z
    Special Characters: null space ! # $ % & ( ) , - . _
*/
#include "inputCheck.h"

int inputCheck::inputValid(string ui, bool ns)
{
    int flag = 0; //set flag to false using 0
    int uiLength = ui.length();
    string outputString = "Input untested\n";

    for (int i = 0;i < uiLength;i++)
    {
        if ((ns == true) && (ui[i] == 32))
        {
            flag = 0;
            outputString = "Invalid Input\n";
            break;
        }
        
        if ((ui[i] == 0) ||
            (ui[i] >= 32 && ui[i] <= 33) ||
            (ui[i] >= 35 && ui[i] <= 38) ||
            (ui[i] >= 40 && ui[i] <= 41) ||
            (ui[i] >= 44 && ui[i] <= 46) ||
            (ui[i] >= 48 && ui[i] <= 57) ||
            (ui[i] >= 65 && ui[i] <= 90) ||
            (ui[i] >= 97 && ui[i] <= 122) ||
            (ui[i] == 95)
            )
        {
            flag = 1;
            outputString = "Valid Input\n";
            break;
        }
    }
    cout << outputString;
    return flag;
}