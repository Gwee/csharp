using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TreeView
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.TreeView TreeView1;
		private System.Windows.Forms.Button ButtonDelete;
		private System.Windows.Forms.Button ButtonAddBrother;
		private System.Windows.Forms.Button ButtonAddChild;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			TreeNode tn = new TreeNode("Continents");
			TreeView1.Nodes.Add(tn);
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
			this.ButtonDelete = new System.Windows.Forms.Button();
			this.ButtonAddBrother = new System.Windows.Forms.Button();
			this.ButtonAddChild = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TreeView1 = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// ButtonDelete
			// 
			this.ButtonDelete.Location = new System.Drawing.Point(210, 232);
			this.ButtonDelete.Name = "ButtonDelete";
			this.ButtonDelete.Size = new System.Drawing.Size(64, 32);
			this.ButtonDelete.TabIndex = 9;
			this.ButtonDelete.Text = "Delete";
			this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// ButtonAddBrother
			// 
			this.ButtonAddBrother.Location = new System.Drawing.Point(106, 232);
			this.ButtonAddBrother.Name = "ButtonAddBrother";
			this.ButtonAddBrother.Size = new System.Drawing.Size(72, 32);
			this.ButtonAddBrother.TabIndex = 8;
			this.ButtonAddBrother.Text = "Add Brother";
			this.ButtonAddBrother.Click += new System.EventHandler(this.ButtonAddBrother_Click);
			// 
			// ButtonAddChild
			// 
			this.ButtonAddChild.Location = new System.Drawing.Point(18, 232);
			this.ButtonAddChild.Name = "ButtonAddChild";
			this.ButtonAddChild.Size = new System.Drawing.Size(64, 32);
			this.ButtonAddChild.TabIndex = 7;
			this.ButtonAddChild.Text = "Add Child";
			this.ButtonAddChild.Click += new System.EventHandler(this.ButtonAddChild_Click);
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(82, 192);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(144, 20);
			this.TextBox1.TabIndex = 6;
			this.TextBox1.Text = "";
			// 
			// TreeView1
			// 
			this.TreeView1.ForeColor = System.Drawing.Color.Blue;
			this.TreeView1.ImageIndex = -1;
			this.TreeView1.Location = new System.Drawing.Point(10, 8);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.SelectedImageIndex = -1;
			this.TreeView1.Size = new System.Drawing.Size(272, 176);
			this.TreeView1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.ButtonDelete,
																		  this.ButtonAddBrother,
																		  this.ButtonAddChild,
																		  this.TextBox1,
																		  this.TreeView1});
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

		private void ButtonAddChild_Click(object sender, System.EventArgs e)
		{
			if ( TextBox1.Text == "") 
				return;
			TreeNode tn = new TreeNode(TextBox1.Text);
			TreeView1.SelectedNode.Nodes.Add(tn);
			TreeView1.SelectedNode.Expand();
		}

		private void ButtonAddBrother_Click(object sender, System.EventArgs e)
		{
			if ( TextBox1.Text == "") 
				return;
			if (TreeView1.SelectedNode.Parent == null )
				return;
			TreeNode tn = new TreeNode(TextBox1.Text);
			TreeView1.SelectedNode.Parent.Nodes.Add(tn);
			TreeView1.SelectedNode.Parent.Expand();
		}

		private void ButtonDelete_Click(object sender, System.EventArgs e)
		{
			if (TreeView1.SelectedNode.Parent == null )
				return;
			TreeView1.SelectedNode.Remove();
			TreeView1.Refresh();
		}
	}
}
