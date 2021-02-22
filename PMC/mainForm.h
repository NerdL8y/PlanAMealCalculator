#pragma once

namespace PMC {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for mainForm
	/// </summary>
	public ref class mainForm : public System::Windows::Forms::Form
	{
	public:
		mainForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~mainForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ _btnFindRecipe;
	private: System::Windows::Forms::Button^ _btnAddRecipe;
	private: System::Windows::Forms::LinkLabel^ _lnkFindRecipe;
	protected:

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->_btnFindRecipe = (gcnew System::Windows::Forms::Button());
			this->_btnAddRecipe = (gcnew System::Windows::Forms::Button());
			this->_lnkFindRecipe = (gcnew System::Windows::Forms::LinkLabel());
			this->SuspendLayout();
			// 
			// _btnFindRecipe
			// 
			this->_btnFindRecipe->Location = System::Drawing::Point(107, 113);
			this->_btnFindRecipe->Name = L"_btnFindRecipe";
			this->_btnFindRecipe->Size = System::Drawing::Size(195, 69);
			this->_btnFindRecipe->TabIndex = 0;
			this->_btnFindRecipe->Text = L"Find a Recipe";
			this->_btnFindRecipe->UseVisualStyleBackColor = true;
			this->_btnFindRecipe->Click += gcnew System::EventHandler(this, &mainForm::button1_Click);
			// 
			// _btnAddRecipe
			// 
			this->_btnAddRecipe->Location = System::Drawing::Point(405, 113);
			this->_btnAddRecipe->Name = L"_btnAddRecipe";
			this->_btnAddRecipe->Size = System::Drawing::Size(195, 65);
			this->_btnAddRecipe->TabIndex = 1;
			this->_btnAddRecipe->Text = L"Add a Recipe";
			this->_btnAddRecipe->UseVisualStyleBackColor = true;
			// 
			// _lnkFindRecipe
			// 
			this->_lnkFindRecipe->ActiveLinkColor = System::Drawing::Color::Black;
			this->_lnkFindRecipe->AutoSize = true;
			this->_lnkFindRecipe->LinkColor = System::Drawing::Color::Black;
			this->_lnkFindRecipe->Location = System::Drawing::Point(102, 283);
			this->_lnkFindRecipe->Name = L"_lnkFindRecipe";
			this->_lnkFindRecipe->RightToLeft = System::Windows::Forms::RightToLeft::No;
			this->_lnkFindRecipe->Size = System::Drawing::Size(146, 26);
			this->_lnkFindRecipe->TabIndex = 2;
			this->_lnkFindRecipe->TabStop = true;
			this->_lnkFindRecipe->Text = L"Find a Recipe";
			this->_lnkFindRecipe->VisitedLinkColor = System::Drawing::Color::Black;
			// 
			// mainForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(803, 494);
			this->Controls->Add(this->_lnkFindRecipe);
			this->Controls->Add(this->_btnAddRecipe);
			this->Controls->Add(this->_btnFindRecipe);
			this->Name = L"mainForm";
			this->Text = L"mainForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
	}
	};
}
