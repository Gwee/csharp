using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ErrorProvider
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.TextBox TextBox3;
		private System.Windows.Forms.ErrorProvider ErrorProvider1;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox TextBox2;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.Label Label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		short A, B, C ;

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
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(200, 40);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(45, 30);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "OK";
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// TextBox3
			// 
			this.TextBox3.Location = new System.Drawing.Point(48, 72);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.ReadOnly = true;
			this.TextBox3.TabIndex = 12;
			this.TextBox3.Text = "0";
			// 
			// ErrorProvider1
			// 
			this.ErrorProvider1.BlinkRate = 100;
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(8, 80);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(35, 16);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "A + B";
			// 
			// TextBox2
			// 
			this.TextBox2.Location = new System.Drawing.Point(48, 40);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.TabIndex = 10;
			this.TextBox2.Text = "";
			this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(8, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(16, 16);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "B";
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(48, 16);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.TabIndex = 8;
			this.TextBox1.Text = "";
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(16, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "A";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 109);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.TextBox3,
																		  this.Label3,
																		  this.TextBox2,
																		  this.Label2,
																		  this.TextBox1,
																		  this.Label1,
																		  this.Button1});
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

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
			try 
			{
				A = Int16.Parse (TextBox1.Text);
				ErrorProvider1.SetError(TextBox1, "");
				TextBox2.ReadOnly = false;
			}
			catch(FormatException )
			{
				ErrorProvider1.SetIconPadding(TextBox1, 10);
				ErrorProvider1.SetError(TextBox1, "No number");
				TextBox2.ReadOnly = true;
			}
			catch(OverflowException )
			{
				ErrorProvider1.SetIconPadding(TextBox1, 10);
				ErrorProvider1.SetError(TextBox1, "Out of range");
				TextBox2.ReadOnly = true;
			}
		}

		private void TextBox2_TextChanged(object sender, System.EventArgs e)
		{
			try 
			{
				B = Int16.Parse (TextBox2.Text);
				ErrorProvider1.SetError(TextBox2, "");
				TextBox1.ReadOnly = false;
			}
			catch(FormatException )
			{
				ErrorProvider1.SetIconPadding(TextBox2, 10);
				ErrorProvider1.SetError(TextBox2, "No number");
				TextBox1.ReadOnly = true;
			}
			catch(OverflowException )
			{
				ErrorProvider1.SetIconPadding(TextBox2, 10);
				ErrorProvider1.SetError(TextBox2, "Out of range");
				TextBox1.ReadOnly = true;
			}
		}
	
		private void Button1_Click(object sender, System.EventArgs e)
		{
			try 
			{
				TextBox3.Text = (A + B).ToString();
				short temp = checked ((short)(A + B ));	
				ErrorProvider1.SetError(TextBox3, "");
			}
			catch( OverflowException )
			{
				ErrorProvider1.SetIconPadding(TextBox3, 10);
				ErrorProvider1.SetError(TextBox3, "Out of range");
			}
		}
	}
}
