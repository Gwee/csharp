using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ToolTip_NotifyIcon
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.NotifyIcon notifyIconRotate;
		private System.ComponentModel.IContainer components;

		private Icon[] rotateIcons = new Icon [ 12 ];
		private int index = 0;
		private bool flag = true;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			notifyIcon1.Text = "My program works";
			notifyIcon1.Icon = new Icon("../../My_Icon.ico");
			
			notifyIconRotate.Text = "My notifyIcon rotates";
	
			for ( int i = 0; i < 12; i ++ ) 
				rotateIcons[i] = new Icon ("../../i" + i.ToString()+ ".ico");

			toolTip1.SetToolTip(this.label1, "Show Label1");
			toolTip1.SetToolTip(this.button1, "Show Button1");
			toolTip1.SetToolTip(this.button2, "Show Button2");
	
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.notifyIconRotate = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 80);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 80);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// notifyIconRotate
			// 
			this.notifyIconRotate.Text = "notifyIcon2";
			this.notifyIconRotate.Visible = true;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.button1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			if( flag )
				toolTip1.SetToolTip(this.button1, "");
			else
				toolTip1.SetToolTip(this.button1, "Show Button1");
			flag = ! flag;
		}
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			index = (index + 1)%12;
			notifyIconRotate.Icon = rotateIcons[index];
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			notifyIcon1.Dispose();
			notifyIconRotate.Dispose();
		}


	}
}
