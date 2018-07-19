using System;				// MainMenu_inForm
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Menu
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemForm;
		private System.Windows.Forms.MenuItem menuItemNew;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemFormat;
		private System.Windows.Forms.MenuItem menuItemText;
		private System.Windows.Forms.MenuItem menuItemSize;
		private System.Windows.Forms.MenuItem menuItemFont;
		private System.Windows.Forms.MenuItem menuItemHelloWorld;
		private System.Windows.Forms.MenuItem menuItemGoodByeWorld;
		private System.Windows.Forms.MenuItem menuItemSize15;
		private System.Windows.Forms.MenuItem menuItemSize30;
		private System.Windows.Forms.MenuItem menuItemItalic;
		private System.Windows.Forms.MenuItem menuItemBold;
		private System.Windows.Forms.MenuItem menuItemUnderline;

		bool myFontItalic = false, myFontBold = false, myFontUnderline = false;
		int mySize = 15;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItemForm = new System.Windows.Forms.MenuItem();
			this.menuItemNew = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemFormat = new System.Windows.Forms.MenuItem();
			this.menuItemText = new System.Windows.Forms.MenuItem();
			this.menuItemHelloWorld = new System.Windows.Forms.MenuItem();
			this.menuItemGoodByeWorld = new System.Windows.Forms.MenuItem();
			this.menuItemSize = new System.Windows.Forms.MenuItem();
			this.menuItemSize15 = new System.Windows.Forms.MenuItem();
			this.menuItemSize30 = new System.Windows.Forms.MenuItem();
			this.menuItemFont = new System.Windows.Forms.MenuItem();
			this.menuItemItalic = new System.Windows.Forms.MenuItem();
			this.menuItemBold = new System.Windows.Forms.MenuItem();
			this.menuItemUnderline = new System.Windows.Forms.MenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemForm,
																					  this.menuItemFormat});
			// 
			// menuItemForm
			// 
			this.menuItemForm.Index = 0;
			this.menuItemForm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemNew,
																						 this.menuItemExit});
			this.menuItemForm.Text = "Form";
			// 
			// menuItemNew
			// 
			this.menuItemNew.Index = 0;
			this.menuItemNew.OwnerDraw = true;
			this.menuItemNew.Shortcut = System.Windows.Forms.Shortcut.Ctrl1;
			this.menuItemNew.Text = "New Form   Ctrl+D1";
			this.menuItemNew.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menu_DrawItem);
			this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
			this.menuItemNew.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menu_MeasureItem);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 1;
			this.menuItemExit.OwnerDraw = true;
			this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.Ctrl2;
			this.menuItemExit.Text = "Exit             Ctrl+D2";
			this.menuItemExit.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menu_DrawItem);
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			this.menuItemExit.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menu_MeasureItem);
			// 
			// menuItemFormat
			// 
			this.menuItemFormat.Index = 1;
			this.menuItemFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItemText,
																						   this.menuItemSize,
																						   this.menuItemFont});
			this.menuItemFormat.Text = "Format";
			// 
			// menuItemText
			// 
			this.menuItemText.Index = 0;
			this.menuItemText.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemHelloWorld,
																						 this.menuItemGoodByeWorld});
			this.menuItemText.Text = "Text";
			// 
			// menuItemHelloWorld
			// 
			this.menuItemHelloWorld.Checked = true;
			this.menuItemHelloWorld.Index = 0;
			this.menuItemHelloWorld.Shortcut = System.Windows.Forms.Shortcut.Ctrl3;
			this.menuItemHelloWorld.Text = "Hello, World!";
			this.menuItemHelloWorld.Click += new System.EventHandler(this.menuItemHelloWorld_Click);
			// 
			// menuItemGoodByeWorld
			// 
			this.menuItemGoodByeWorld.Index = 1;
			this.menuItemGoodByeWorld.Shortcut = System.Windows.Forms.Shortcut.Ctrl4;
			this.menuItemGoodByeWorld.Text = "Good bye, World!";
			this.menuItemGoodByeWorld.Click += new System.EventHandler(this.menuItemGoodByeWorld_Click);
			// 
			// menuItemSize
			// 
			this.menuItemSize.Index = 1;
			this.menuItemSize.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemSize15,
																						 this.menuItemSize30});
			this.menuItemSize.Text = "Size";
			// 
			// menuItemSize15
			// 
			this.menuItemSize15.Checked = true;
			this.menuItemSize15.Index = 0;
			this.menuItemSize15.OwnerDraw = true;
			this.menuItemSize15.RadioCheck = true;
			this.menuItemSize15.Shortcut = System.Windows.Forms.Shortcut.Ctrl5;
			this.menuItemSize15.Text = "15    Ctrl+D5";
			this.menuItemSize15.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menu_DrawItem);
			this.menuItemSize15.Click += new System.EventHandler(this.menuItemSize15_Click);
			this.menuItemSize15.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menu_MeasureItem);
			// 
			// menuItemSize30
			// 
			this.menuItemSize30.Index = 1;
			this.menuItemSize30.OwnerDraw = true;
			this.menuItemSize30.RadioCheck = true;
			this.menuItemSize30.Shortcut = System.Windows.Forms.Shortcut.Ctrl6;
			this.menuItemSize30.Text = "30    Ctrl+D6";
			this.menuItemSize30.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menu_DrawItem);
			this.menuItemSize30.Click += new System.EventHandler(this.menuItemSize30_Click);
			this.menuItemSize30.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menu_MeasureItem);
			// 
			// menuItemFont
			// 
			this.menuItemFont.Index = 2;
			this.menuItemFont.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemItalic,
																						 this.menuItemBold,
																						 this.menuItemUnderline});
			this.menuItemFont.Text = "Font";
			// 
			// menuItemItalic
			// 
			this.menuItemItalic.Index = 0;
			this.menuItemItalic.Shortcut = System.Windows.Forms.Shortcut.Ctrl7;
			this.menuItemItalic.Text = "Italic";
			this.menuItemItalic.Click += new System.EventHandler(this.menuItemItalic_Click);
			// 
			// menuItemBold
			// 
			this.menuItemBold.Index = 1;
			this.menuItemBold.Shortcut = System.Windows.Forms.Shortcut.Ctrl8;
			this.menuItemBold.Text = "Bold";
			this.menuItemBold.Click += new System.EventHandler(this.menuItemBold_Click);
			// 
			// menuItemUnderline
			// 
			this.menuItemUnderline.Index = 2;
			this.menuItemUnderline.Shortcut = System.Windows.Forms.Shortcut.Ctrl9;
			this.menuItemUnderline.Text = "Underline";
			this.menuItemUnderline.Click += new System.EventHandler(this.menuItemUnderline_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.label1.Location = new System.Drawing.Point(16, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hello, World!";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 161);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

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

		private void menuItemNew_Click(object sender, System.EventArgs e)
		{
			Form1 frmNew = new Form1();
			frmNew.Show();
		}

		private void menuItemExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItemHelloWorld_Click(object sender, System.EventArgs e)
		{
			if (menuItemHelloWorld.Checked == true)
				return;
			menuItemHelloWorld.Checked = true;
			menuItemGoodByeWorld.Checked = false;
			label1.Text = "Hello, World!";
		}

		private void menuItemGoodByeWorld_Click(object sender, System.EventArgs e)
		{
			menuItemHelloWorld.Checked = ! menuItemHelloWorld.Checked;
			menuItemGoodByeWorld.Checked = ! menuItemGoodByeWorld.Checked;
			if ( menuItemHelloWorld.Checked )
				label1.Text = "Hello, World!";
			else
				label1.Text = "Good bye, World!";
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

		private void menuItemItalic_Click(object sender, System.EventArgs e)
		{
			menuItemItalic.Checked = ! menuItemItalic.Checked;
			myFontItalic = ! myFontItalic;
			Font_Check();
		}

		private void menuItemBold_Click(object sender, System.EventArgs e)
		{
			menuItemBold.Checked = ! menuItemBold.Checked;
			myFontBold = ! myFontBold;
	
			Font_Check();
		}

		private void menuItemUnderline_Click(object sender, System.EventArgs e)
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
			label1.Font = new System.Drawing.Font("Ariel", mySize, myFontStyle );
			}
	
		private void menu_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
		{
			MenuItem mnuItem = (MenuItem)sender;

			Font menuFont = new Font("Ariel", 10);
			e.ItemHeight = (int)e.Graphics.MeasureString(mnuItem.Text, menuFont).Height + 5;
			e.ItemWidth = (int)e.Graphics.MeasureString(mnuItem.Text, menuFont).Width ;
		}

		private void menu_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
		{
			MenuItem mnuItem = (MenuItem)sender;
			Image menuImage = null;

			switch (mnuItem.Text.ToString())
			{
				case "New Form   Ctrl+D1": menuImage = imageList1.Images[0];
					break;
				case "Exit             Ctrl+D2": menuImage = imageList1.Images[1];
					break;
				case "15    Ctrl+D5": menuImage = imageList1.Images[2];
					break;
				case "30    Ctrl+D6": menuImage = imageList1.Images[3];
					break;
			}
			e.Graphics.DrawImage(menuImage, e.Bounds.Left + 3, e.Bounds.Top + 2);
			e.Graphics.DrawString(mnuItem.Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + 25, e.Bounds.Top + 3);
		}
	}
}
