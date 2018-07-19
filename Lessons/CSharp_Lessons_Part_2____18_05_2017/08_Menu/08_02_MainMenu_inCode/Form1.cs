using System;				// MainMenu_inCode
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Menu_inCode
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private MainMenu myMainMenu;
		private MenuItem menuItemHelloWorld, menuItemGoodByeWorld, menuItemSize15, menuItemSize30, menuItemItalic, menuItemBold, menuItemUnderline;
		private Label myLabel;
		bool myFontItalic = false, myFontBold = false, myFontUnderline = false;
		int mySize = 15;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// First make the main menu.
			myMainMenu = new MainMenu();
			this.Menu = myMainMenu;
	
			MenuItem menuItem_Form = myMainMenu.MenuItems.Add("Form");          
			menuItem_Form.MenuItems.Add(new MenuItem("New Form", 
				new EventHandler(this.NewForm_Click), 
				Shortcut.Ctrl1));
			menuItem_Form.MenuItems.Add(new MenuItem("Exit", 
				new EventHandler(this.Exit_Click), 
				Shortcut.Ctrl2));

			MenuItem menuItem_Format = myMainMenu.MenuItems.Add("Format");          
			
			MenuItem menuItem_Text = menuItem_Format.MenuItems.Add("Text");
			menuItemHelloWorld = new MenuItem("Hello, world!", 
				new EventHandler(this.Hello_Click), Shortcut.Ctrl3);
			menuItem_Text.MenuItems.Add(menuItemHelloWorld);
			menuItemHelloWorld.Checked = true;
	
			menuItemGoodByeWorld = new MenuItem("Good bye, world!", 
				new EventHandler(this.Goodbye_Click), Shortcut.Ctrl4);
			menuItem_Text.MenuItems.Add(menuItemGoodByeWorld);
			menuItemGoodByeWorld.Checked = false;
	
			MenuItem menuItem_Separat1 = menuItem_Format.MenuItems.Add("-");
			MenuItem menuItem_Size = menuItem_Format.MenuItems.Add("Size");
			menuItemSize15 = new MenuItem("15", new EventHandler(this.menuItemSize15_Click), 
				Shortcut.Ctrl5);
			menuItem_Size.MenuItems.Add(menuItemSize15);
			menuItemSize15.Checked = true;
			menuItemSize15.RadioCheck = true;

			menuItemSize30 = new MenuItem("30", new EventHandler(this.menuItemSize30_Click), 
				Shortcut.Ctrl6);
			menuItem_Size.MenuItems.Add(menuItemSize30);
			menuItemSize30.Checked = false;
			menuItemSize30.RadioCheck = true;
			
			MenuItem menuItem_Separat2 = menuItem_Format.MenuItems.Add("-");
			MenuItem menuItem_Font = menuItem_Format.MenuItems.Add("Font");
			
			menuItemItalic = new MenuItem("Italic", 
				new EventHandler(this.Italic_Click), 
				Shortcut.Ctrl7);
			menuItem_Font.MenuItems.Add(menuItemItalic);

			menuItemBold = new MenuItem("Bold", 
				new EventHandler(this.Bold_Click), 
				Shortcut.Ctrl8);
			menuItem_Font.MenuItems.Add(menuItemBold);

			menuItemUnderline = new MenuItem("Underline", 
				new EventHandler(this.Underline_Click), 
				Shortcut.Ctrl9);
			menuItem_Font.MenuItems.Add(menuItemUnderline);
	
			myLabel = new Label();
			myLabel.Width = 325;
			myLabel.Height = 56;
			myLabel.Left = 8;
			myLabel.Top = 40;
			myLabel.Font = new Font("Arial", 15);
			myLabel.Text = "Hello, World!";
			this.Controls.Add(myLabel);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 273);
			this.Name = "Form1";
			this.Text = "Form1";

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void NewForm_Click(object sender, System.EventArgs e)
		{
			Form1 frmNew = new Form1();
			frmNew.Show();
		}

		private void Exit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Hello_Click(object sender, System.EventArgs e)
		{
			if (menuItemHelloWorld.Checked == true)
				return;
			menuItemHelloWorld.Checked = true;
			menuItemGoodByeWorld.Checked = false;
			myLabel.Text = "Hello, World!";
		}

		private void Goodbye_Click(object sender, System.EventArgs e)
		{
			menuItemHelloWorld.Checked = ! menuItemHelloWorld.Checked;
			menuItemGoodByeWorld.Checked = ! menuItemGoodByeWorld.Checked;
			if ( menuItemHelloWorld.Checked )
				myLabel.Text = "Hello, World!";
			else
				myLabel.Text = "Good bye, World!";
		}

		private void menuItemSize15_Click(object sender, System.EventArgs e)
		{
			if (menuItemSize15.Checked )
				return;
			menuItemSize15.Checked = true;
			menuItemSize30.Checked = false;
			mySize = 15;
			Font_Check();
		}
		private void menuItemSize30_Click(object sender, System.EventArgs e)
		{
			menuItemSize15.Checked = ! menuItemSize15.Checked;
			menuItemSize30.Checked = ! menuItemSize30.Checked;
			if ( menuItemSize30.Checked )
				mySize = 30;
			else
				mySize = 15;
			Font_Check();
		}

		private void Bold_Click(object sender, System.EventArgs e)
		{
			menuItemBold.Checked = ! menuItemBold.Checked;
			myFontBold = ! myFontBold;
	
			Font_Check();
		}

		private void Italic_Click(object sender, System.EventArgs e)
		{
			menuItemItalic.Checked = ! menuItemItalic.Checked;
			myFontItalic = ! myFontItalic;
			Font_Check();
		}

		private void Underline_Click(object sender, System.EventArgs e)
		{
			menuItemUnderline.Checked = ! menuItemUnderline.Checked;
			myFontUnderline = ! myFontUnderline;
			Font_Check();
		}

		private void Font_Check()
		{
			FontStyle myFontStyle;
			if ( myFontItalic )
				myFontStyle = FontStyle.Italic;
			else
				myFontStyle = FontStyle.Regular;
	
			if ( myFontBold )
				myFontStyle |= FontStyle.Bold;
			if ( myFontUnderline )
				myFontStyle |= FontStyle.Underline;
			myLabel.Font = new System.Drawing.Font("Ariel", mySize, myFontStyle );
		}
	}
}
