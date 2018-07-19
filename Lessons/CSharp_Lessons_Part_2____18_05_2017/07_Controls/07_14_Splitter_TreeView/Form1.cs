using System;				// Splitter_TreeView
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Splitter_TreeView
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button ButtonAddChild;
		private System.Windows.Forms.Button ButtonAddBrother;
		private System.Windows.Forms.Button ButtonDelete;
		private System.Windows.Forms.TreeView TreeView1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Splitter splitter1;
		int prevSplitter1Position;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			TreeNode tn = new TreeNode("Continents");
			TreeView1.Nodes.Add(tn);
			prevSplitter1Position = splitter1.SplitPosition;
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.TreeView1 = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.SuspendLayout();
			// 
			// ButtonDelete
			// 
			this.ButtonDelete.Location = new System.Drawing.Point(368, 40);
			this.ButtonDelete.Name = "ButtonDelete";
			this.ButtonDelete.Size = new System.Drawing.Size(64, 32);
			this.ButtonDelete.TabIndex = 14;
			this.ButtonDelete.Text = "Delete";
			this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// ButtonAddBrother
			// 
			this.ButtonAddBrother.Location = new System.Drawing.Point(288, 40);
			this.ButtonAddBrother.Name = "ButtonAddBrother";
			this.ButtonAddBrother.Size = new System.Drawing.Size(72, 32);
			this.ButtonAddBrother.TabIndex = 13;
			this.ButtonAddBrother.Text = "Add Brother";
			this.ButtonAddBrother.Click += new System.EventHandler(this.ButtonAddBrother_Click);
			// 
			// ButtonAddChild
			// 
			this.ButtonAddChild.Location = new System.Drawing.Point(216, 40);
			this.ButtonAddChild.Name = "ButtonAddChild";
			this.ButtonAddChild.Size = new System.Drawing.Size(64, 32);
			this.ButtonAddChild.TabIndex = 12;
			this.ButtonAddChild.Text = "Add Child";
			this.ButtonAddChild.Click += new System.EventHandler(this.ButtonAddChild_Click);
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(216, 8);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(144, 20);
			this.TextBox1.TabIndex = 11;
			this.TextBox1.Text = "";
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(216, 88);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(128, 173);
			this.listBox1.TabIndex = 16;
			// 
			// TreeView1
			// 
			this.TreeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.TreeView1.ForeColor = System.Drawing.Color.Blue;
			this.TreeView1.ImageIndex = -1;
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.SelectedImageIndex = -1;
			this.TreeView1.Size = new System.Drawing.Size(206, 273);
			this.TreeView1.TabIndex = 10;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(206, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 273);
			this.splitter1.TabIndex = 15;
			this.splitter1.TabStop = false;
			this.splitter1.SplitterMoving += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoving);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.splitter1,
																		  this.TextBox1,
																		  this.ButtonDelete,
																		  this.ButtonAddBrother,
																		  this.ButtonAddChild,
																		  this.TreeView1,
																		  this.listBox1});
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

			listBox1_Refresh();
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
		
			listBox1_Refresh();
		}

		private void ButtonDelete_Click(object sender, System.EventArgs e)
		{
			if (TreeView1.SelectedNode.Parent == null )
				return;
			TreeView1.SelectedNode.Remove();
			TreeView1.Refresh();
			
			listBox1_Refresh();
		}

		private void listBox1_Refresh()
		{
			TreeNodeCollection nodes = TreeView1.Nodes;
		
			listBox1.BeginUpdate();
			listBox1.Items.Clear();
			foreach (TreeNode n in nodes)
			{
				CallRecursive(n);
			}
			listBox1.EndUpdate();
		}

		private void CallRecursive(TreeNode treeNode)
		{
			listBox1.Items.Add(treeNode.Text);
			foreach (TreeNode tn in treeNode.Nodes)
			{
				CallRecursive(tn);
			}
		}

	
		private void splitter1_SplitterMoving(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			int deltaX = splitter1.SplitPosition - prevSplitter1Position; 
			this.Width += deltaX;
			TreeView1.Width += deltaX;
			TextBox1.Location = new System.Drawing.Point(TextBox1.Location.X + deltaX, TextBox1.Location.Y);
			ButtonAddChild.Location = new System.Drawing.Point(ButtonAddChild.Location.X + deltaX, ButtonAddChild.Location.Y);
			ButtonAddBrother.Location = new System.Drawing.Point(ButtonAddBrother.Location.X + deltaX, ButtonAddBrother.Location.Y);
			ButtonDelete.Location = new System.Drawing.Point(ButtonDelete.Location.X + deltaX, ButtonDelete.Location.Y);
			listBox1.Location = new System.Drawing.Point(listBox1.Location.X + deltaX, listBox1.Location.Y);
			prevSplitter1Position += deltaX;
		}
	}
}
