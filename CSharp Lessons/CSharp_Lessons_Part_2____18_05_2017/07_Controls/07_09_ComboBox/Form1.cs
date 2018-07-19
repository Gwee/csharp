using System;					// ComboBox
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ComboBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ComboBox ComboBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button ButtonUpdate;
		private System.Windows.Forms.Button ButtonDelete;
		private System.Windows.Forms.Button ButtonAdd;

		int currIndex = 0;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		
			string[] arrStr= {"One", "Two", "Three", "Foure", "Five", "Six", "Seven", "Eight", "Nine", "Ten"};
			for ( int i = 0 ; i < arrStr.GetUpperBound(0) ; i ++ )
				ComboBox1.Items.Add(arrStr[i]);
			ComboBox1.SelectedIndex = 0;


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
			this.ButtonUpdate = new System.Windows.Forms.Button();
			this.ButtonDelete = new System.Windows.Forms.Button();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ButtonUpdate
			// 
			this.ButtonUpdate.Location = new System.Drawing.Point(312, 16);
			this.ButtonUpdate.Name = "ButtonUpdate";
			this.ButtonUpdate.Size = new System.Drawing.Size(64, 32);
			this.ButtonUpdate.TabIndex = 17;
			this.ButtonUpdate.Text = "Update";
			this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
			// 
			// ButtonDelete
			// 
			this.ButtonDelete.Location = new System.Drawing.Point(232, 16);
			this.ButtonDelete.Name = "ButtonDelete";
			this.ButtonDelete.Size = new System.Drawing.Size(64, 32);
			this.ButtonDelete.TabIndex = 16;
			this.ButtonDelete.Text = "Delete";
			this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Location = new System.Drawing.Point(160, 16);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(64, 32);
			this.ButtonAdd.TabIndex = 15;
			this.ButtonAdd.Text = "Add";
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// ComboBox1
			// 
			this.ComboBox1.Location = new System.Drawing.Point(8, 24);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(112, 21);
			this.ComboBox1.TabIndex = 14;
			this.ComboBox1.Text = "ComboBox1";
			this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 61);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.ButtonUpdate,
																		  this.ButtonDelete,
																		  this.ButtonAdd,
																		  this.ComboBox1});
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

		private void ListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			currIndex = ComboBox1.SelectedIndex;
		}

		private void ButtonAdd_Click(object sender, System.EventArgs e)
		{
			ComboBox1.Items.Add(ComboBox1.Text);
		}

		private void ButtonDelete_Click(object sender, System.EventArgs e)
		{
			ComboBox1.Items.Remove(ComboBox1.SelectedItem);
		}

		private void ButtonUpdate_Click(object sender, System.EventArgs e)
		{
			ComboBox1.Items.RemoveAt(currIndex);
			ComboBox1.Items.Insert(currIndex, ComboBox1.Text);
		}
	}
}
