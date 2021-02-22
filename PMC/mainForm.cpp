#include "mainForm.h"
#include "inputCheck.h"
#include <iostream>

using namespace System;
using namespace System::Windows::Forms;

[STAThread]

void main(array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	PMC::mainForm form;
	Application::Run(% form);

	inputCheck::inputValid("This is valid Input", 1);

}
