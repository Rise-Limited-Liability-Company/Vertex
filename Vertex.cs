/*
Copyright 2025 Rise LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
/*
What will I need to do if I change the version to 2.0 & 3.0
1. AppData only had 10 data objects
2. Editor only reconized 10 data objects
*/
#pragma warning disable
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Net;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
//[assembly:AsssemblyTitle("Vertex 1.5")]
[assembly:AssemblyDescription("2D Game Engine")]
[assembly:AssemblyCompany("Rise LLC")]
[assembly:AssemblyProduct("Vertex")]
[assembly:AssemblyCopyright("Copyright (C) 2025 Rise LLC")]
[assembly:AssemblyVersion("1.5.0")]
[assembly:AssemblyFileVersion("1.5.0")]
class Vertex
{
	[DllImport("user32.dll")]
	static extern bool ShowWindow(IntPtr hWnd,int shw);
	public static string code;
	public static string file;
	public class actives
	{
		public static PictureBox d1;
		public static PictureBox d2;
		public static PictureBox d3;
		public static PictureBox d4;
		public static PictureBox d5;
		public static PictureBox d6;
		public static PictureBox d7;
		public static PictureBox d8;
		public static PictureBox d9;
		public static PictureBox d10;
	}
	public class strings
	{
		public static Label d1;
		public static Label d2;
		public static Label d3;
		public static Label d4;
		public static Label d5;
		public static Label d6;
		public static Label d7;
		public static Label d8;
		public static Label d9;
		public static Label d10;
	}
	public class counters
	{
		public static Label d1;
		public static Label d2;
		public static Label d3;
		public static Label d4;
		public static Label d5;
		public static Label d6;
		public static Label d7;
		public static Label d8;
		public static Label d9;
		public static Label d10;
	}
	public class buttons
	{
		public static Button d1;
		public static Button d2;
		public static Button d3;
		public static Button d4;
		public static Button d5;
		public static Button d6;
		public static Button d7;
		public static Button d8;
		public static Button d9;
		public static Button d10;
	}
	public class editboxes
	{
		public static TextBox d1;
		public static TextBox d2;
		public static TextBox d3;
		public static TextBox d4;
		public static TextBox d5;
		public static TextBox d6;
		public static TextBox d7;
		public static TextBox d8;
		public static TextBox d9;
		public static TextBox d10;
	}
	///*
	public class AppData
	{
		public class properties
		{
			public static string name;
			public static string bgcolor;
			public static bool runtimeController;
		}
		public class extensions
		{
			public static bool variables;
			public static bool vtsd;
		}
		public class section
		{
			public class d1
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d2
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d3
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d4
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d5
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d6
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d7
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d8
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d9
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
			public class d10
			{
				public static string type;
				public static int width;
				public static int height;
				public static int x;
				public static int y;
				public class values
				{
					public static string str;
					public static string img;
					public static int val;
				}
				public static float transparency;
				public static bool visible;
				public static class events
				{
					public class d1
					{
						public static string cdn;
						public static string exp;
					}
					public class d2
					{
						public static string cdn;
						public static string exp;
					}
					public class d3
					{
						public static string cdn;
						public static string exp;
					}
					public class d4
					{
						public static string cdn;
						public static string exp;
					}
					public class d5
					{
						public static string cdn;
						public static string exp;
					}
					public class d6
					{
						public static string cdn;
						public static string exp;
					}
					public class d7
					{
						public static string cdn;
						public static string exp;
					}
					public class d8
					{
						public static string cdn;
						public static string exp;
					}
					public class d9
					{
						public static string cdn;
						public static string exp;
					}
					public class d10
					{
						public static string cdn;
						public static string exp;
					}
				}
			}
		}
    }
	//*/
	public class Examples
	{
		static public void one()
		{
			app("pong.vta");
		}
		static public void two()
		{
			app("mario.vta");
		}
		static public void three()
		{
			app("fnaf.vta");
		}
	}
	/*
	static public void activate()
	{
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		Form atv = new Form();
		atv.Size = new Size(256,128);
		atv.MinimizeBox = false;
		atv.MaximizeBox = false;
		atv.MinimumSize = new Size(256,128);
		atv.MaximumSize = new Size(256,128);
		atv.Text = "Vertex 1.5 Activation";
		atv.Icon = new Icon("icon.ico");
		TextBox acode = new TextBox();
		acode.Size = new Size(256,32);
		acode.Location = new Point(0,0);
		acode.Font = bfont;
		acode.Multiline = true;
		acode.Text = "Activation Code";
		Button abtn = new Button();
		abtn.Size = new Size(256,64);
		abtn.Location = new Point(0,32);
		abtn.Font = bfont;
		abtn.Text = "Activate";
		abtn.Click += (sender,args) =>
		{
			ActivationCodes.validater(acode.Text);
		};
		atv.Controls.Add(acode);
		atv.Controls.Add(abtn);
		atv.Show();
	}
	*/
	/*
	static public void compile()
	{
		if (code != null)
		{
			Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
			Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
			Form opn = new Form();
			opn.Size = new Size(512,512);
			opn.MinimizeBox = false;
			opn.MaximizeBox = false;
			opn.MinimumSize = new Size(512,512);
			opn.MaximumSize = new Size(512,512);
			opn.Text = "Vertex 1.5 Compiled Application";
			TextBox result = new TextBox();
			result.Size = new Size(512,512);
			result.Location = new Point(0,0);
			result.Font = bfont;
			result.Multiline = true;
			string d1 = "";
			string d2 = "";
			string d3 = "";
			string d4 = "";
			string d5 = "";
			string d6 = "";
			string d7 = "";
			string d8 = "";
			string d9 = "";
			string d10 = "";
			if (AppData.section.d1.type == "Active")
			{
				d1 = 
				@"PictureBox d1 = new PictureBox();
				d1.Size = " + AppData.section.d1.Active.size + @";
				d1.Location = " + AppData.section.d1.Active.location + @";
				d1.ImageLocation = Image.FromFile(" + AppData.section.d1.Active.image + @");
				d1.Color = " + AppData.section.d1.Active.color + @";
				d1.Opacity = " + AppData.section.d1.Active.transparency + @";
				rtm.Controls.Add(obj)(d1);";
			}
			if (AppData.section.d2.type == "Active")
			{
				d2 = 
				@"PictureBox d2 = new PictureBox();
				d2.Size = " + AppData.section.d2.Active.size + @";
				d2.Location = " + AppData.section.d2.Active.location + @";
				d2.ImageLocation = Image.FromFile(" + AppData.section.d2.Active.image + @");
				d2.Color = " + AppData.section.d2.Active.color + @";
				d2.Opacity = " + AppData.section.d2.Active.transparency + @";
				rtm.Controls.Add(obj)(d2);";
			}
			if (AppData.section.d3.type == "Active")
			{
				d3 = 
				@"PictureBox d3 = new PictureBox();
				d3.Size = " + AppData.section.d3.Active.size + @";
				d3.Location = " + AppData.section.d3.Active.location + @";
				d3.ImageLocation = Image.FromFile(" + AppData.section.d3.Active.image + @");
				d3.Color = " + AppData.section.d3.Active.color + @";
				d3.Opacity = " + AppData.section.d3.Active.transparency + @";
				rtm.Controls.Add(obj)(d3);";
			}
			if (AppData.section.d4.type == "Active")
			{
				d4 = 
				@"PictureBox d4 = new PictureBox();
				d4.Size = " + AppData.section.d4.Active.size + @";
				d4.Location = " + AppData.section.d4.Active.location + @";
				d4.ImageLocation = Image.FromFile(" + AppData.section.d4.Active.image + @");
				d4.Color = " + AppData.section.d4.Active.color + @";
				d4.Opacity = " + AppData.section.d4.Active.transparency + @";
				rtm.Controls.Add(obj)(d4);";
			}
			if (AppData.section.d5.type == "Active")
			{
				d5 = 
				@"PictureBox d5 = new PictureBox();
				d5.Size = " + AppData.section.d5.Active.size + @";
				d5.Location = " + AppData.section.d5.Active.location + @";
				d5.ImageLocation = Image.FromFile(" + AppData.section.d5.Active.image + @");
				d5.Color = " + AppData.section.d5.Active.color + @";
				d5.Opacity = " + AppData.section.d5.Active.transparency + @";
				rtm.Controls.Add(obj)(d5);";
			}
			if (AppData.section.d6.type == "Active")
			{
				d6 = 
				@"PictureBox d6 = new PictureBox();
				d6.Size = " + AppData.section.d6.Active.size + @";
				d6.Location = " + AppData.section.d6.Active.location + @";
				d6.ImageLocation = Image.FromFile(" + AppData.section.d6.Active.image + @");
				d6.Color = " + AppData.section.d6.Active.color + @";
				d6.Opacity = " + AppData.section.d6.Active.transparency + @";
				rtm.Controls.Add(obj)(d6);";
			}
			if (AppData.section.d7.type == "Active")
			{
				d7 = 
				@"PictureBox d7 = new PictureBox();
				d7.Size = " + AppData.section.d7.Active.size + @";
				d7.Location = " + AppData.section.d7.Active.location + @";
				d7.ImageLocation = Image.FromFile(" + AppData.section.d7.Active.image + @");
				d7.Color = " + AppData.section.d7.Active.color + @";
				d7.Opacity = " + AppData.section.d7.Active.transparency + @";
				rtm.Controls.Add(obj)(d7);";
			}
			if (AppData.section.d8.type == "Active")
			{
				d8 = 
				@"PictureBox d8 = new PictureBox();
				d8.Size = " + AppData.section.d8.Active.size + @";
				d8.Location = " + AppData.section.d8.Active.location + @";
				d8.ImageLocation = Image.FromFile(" + AppData.section.d8.Active.image + @");
				d8.Color = " + AppData.section.d8.Active.color + @";
				d8.Opacity = " + AppData.section.d8.Active.transparency + @";
				rtm.Controls.Add(obj)(d8);";
			}
			if (AppData.section.d9.type == "Active")
			{
				d9 = 
				@"PictureBox d9 = new PictureBox();
				d9.Size = " + AppData.section.d9.Active.size + @";
				d9.Location = " + AppData.section.d9.Active.location + @";
				d9.ImageLocation = Image.FromFile(" + AppData.section.d9.Active.image + @");
				d9.Color = " + AppData.section.d9.Active.color + @";
				d9.Opacity = " + AppData.section.d9.Active.transparency + @";
				rtm.Controls.Add(obj)(d9);";
			}
			if (AppData.section.d10.type == "Active")
			{
				d10 = 
				@"PictureBox d10 = new PictureBox();
				d10.Size = " + AppData.section.d10.Active.size + @";
				d10.Location = " + AppData.section.d10.Active.location + @";
				d10.ImageLocation = Image.FromFile(" + AppData.section.d10.Active.image + @");
				d10.Color = " + AppData.section.d10.Active.color + @";
				d10.Opacity = " + AppData.section.d10.Active.transparency + @";
				rtm.Controls.Add(obj)(d10);";
			}
			if (AppData.section.d1.type == "String")
			{
				d1 = 
				@"Label d1 = new Label();
				d1.Size = " + AppData.section.d1.String.size + @";
				d1.Location = " + AppData.section.d1.String.location + @";
				d1.Font = " + AppData.section.d1.String.font + @";
				d1.Text = " + AppData.section.d1.String.text + @";
				d1.Color = " + AppData.section.d1.String.color + @";
				d1.Opacity = " + AppData.section.d1.String.transparency + @";
				rtm.Controls.Add(obj)(d1);";
			}
			if (AppData.section.d2.type == "String")
			{
				d2 = 
				@"Label d2 = new Label();
				d2.Size = " + AppData.section.d2.String.size + @";
				d2.Location = " + AppData.section.d2.String.location + @";
				d2.Font = " + AppData.section.d2.String.font + @";
				d2.Text = " + AppData.section.d2.String.text + @";
				d2.Color = " + AppData.section.d2.String.color + @";
				d2.Opacity = " + AppData.section.d2.String.transparency + @";
				rtm.Controls.Add(obj)(d2);";
			}
			if (AppData.section.d3.type == "String")
			{
				d3 = 
				@"Label d3 = new Label();
				d3.Size = " + AppData.section.d3.String.size + @";
				d3.Location = " + AppData.section.d3.String.location + @";
				d3.Font = " + AppData.section.d3.String.font + @";
				d3.Text = " + AppData.section.d3.String.text + @";
				d3.Color = " + AppData.section.d3.String.color + @";
				d3.Opacity = " + AppData.section.d3.String.transparency + @";
				rtm.Controls.Add(obj)(d3);";
			}
			if (AppData.section.d4.type == "String")
			{
				d4 = 
				@"Label d4 = new Label();
				d4.Size = " + AppData.section.d4.String.size + @";
				d4.Location = " + AppData.section.d4.String.location + @";
				d4.Font = " + AppData.section.d4.String.font + @";
				d4.Text = " + AppData.section.d4.String.text + @";
				d4.Color = " + AppData.section.d4.String.color + @";
				d4.Opacity = " + AppData.section.d4.String.transparency + @";
				rtm.Controls.Add(obj)(d4);";
			}
			if (AppData.section.d5.type == "String")
			{
				d5 = 
				@"Label d5 = new Label();
				d5.Size = " + AppData.section.d5.String.size + @";
				d5.Location = " + AppData.section.d5.String.location + @";
				d5.Font = " + AppData.section.d5.String.font + @";
				d5.Text = " + AppData.section.d5.String.text + @";
				d5.Color = " + AppData.section.d5.String.color + @";
				d5.Opacity = " + AppData.section.d5.String.transparency + @";
				rtm.Controls.Add(obj)(d5);";
			}
			if (AppData.section.d6.type == "String")
			{
				d6 = 
				@"Label d6 = new Label();
				d6.Size = " + AppData.section.d6.String.size + @";
				d6.Location = " + AppData.section.d6.String.location + @";
				d6.Font = " + AppData.section.d6.String.font + @";
				d6.Text = " + AppData.section.d6.String.text + @";
				d6.Color = " + AppData.section.d6.String.color + @";
				d6.Opacity = " + AppData.section.d6.String.transparency + @";
				rtm.Controls.Add(obj)(d6);";
			}
			if (AppData.section.d7.type == "String")
			{
				d7 = 
				@"Label d7 = new Label();
				d7.Size = " + AppData.section.d7.String.size + @";
				d7.Location = " + AppData.section.d7.String.location + @";
				d7.Font = " + AppData.section.d7.String.font + @";
				d7.Text = " + AppData.section.d7.String.text + @";
				d7.Color = " + AppData.section.d7.String.color + @";
				d7.Opacity = " + AppData.section.d7.String.transparency + @";
				rtm.Controls.Add(obj)(d7);";
			}
			if (AppData.section.d8.type == "String")
			{
				d8 = 
				@"Label d8 = new Label();
				d8.Size = " + AppData.section.d8.String.size + @";
				d8.Location = " + AppData.section.d8.String.location + @";
				d8.Font = " + AppData.section.d8.String.font + @";
				d8.Text = " + AppData.section.d8.String.text + @";
				d8.Color = " + AppData.section.d8.String.color + @";
				d8.Opacity = " + AppData.section.d8.String.transparency + @";
				rtm.Controls.Add(obj)(d8);";
			}
			if (AppData.section.d9.type == "String")
			{
				d9 = 
				@"Label d9 = new Label();
				d9.Size = " + AppData.section.d9.String.size + @";
				d9.Location = " + AppData.section.d9.String.location + @";
				d9.Font = " + AppData.section.d9.String.font + @";
				d9.Text = " + AppData.section.d9.String.text + @";
				d9.Color = " + AppData.section.d9.String.color + @";
				d9.Opacity = " + AppData.section.d9.String.transparency + @";
				rtm.Controls.Add(obj)(d9);";
			}
			if (AppData.section.d10.type == "String")
			{
				d10 = 
				@"Label d10 = new Label();
				d10.Size = " + AppData.section.d10.String.size + @";
				d10.Location = " + AppData.section.d10.String.location + @";
				d10.Font = " + AppData.section.d10.String.font + @";
				d10.Text = " + AppData.section.d10.String.text + @";
				d10.Color = " + AppData.section.d10.String.color + @";
				d10.Opacity = " + AppData.section.d10.String.transparency + @";
				rtm.Controls.Add(obj)(d10);";
			}
			result.Text = 
			@"using System;
			using System.Text;
			using System.Drawing;
			using System.Windows.Forms;
			static public void Main() {
			Font hfont = new Font(new Font('Courier New',16),FontStyle.Bold);
			Font bfont = new Font(new Font('Courier New',8),FontStyle.Bold);
			Form rtm = new Form();
			rtm.Size = new Size(512,512);
			rtm.MinimizeBox = false;
			rtm.MaximumBox = false;
			rtm.MinimumSize = new Size(512,512);
			rtm.MaximumSize = new Size(512,512);
			rtm.Text = 'Vertex 1.5 Runtime';
			rtm.StartPosition = FormStartPosition.CenterScreen;"
			+ d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 +
			@"Application.Run(rtm);
			};";
			opn.Controls.Add(result);
			opn.Show();
		}
		else
		{
			MessageBox.Show("You didn't activated the software yet.");
		}
	}
	*/
	static public void runtime()
	{
		// adds
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		Form rtm = new Form();
		rtm.Size = new Size(512,512);
		rtm.MinimizeBox = false;
		rtm.MaximizeBox = false;
		rtm.MinimumSize = new Size(512,512);
		rtm.MaximumSize = new Size(512,512);
		rtm.Text = "Vertex 1.5 Runtime";
		rtm.Icon = new Icon("icon.ico");
		Form rtc = new Form();
		rtc.Size = new Size(480,480);
		rtc.MinimizeBox = false;
		rtc.MaximizeBox = false;
		rtc.MinimumSize = new Size(480,480);
		rtc.MaximumSize = new Size(480,480);
		rtc.Icon = new Icon("icon.ico");
		Button ext = new Button();
		ext.Size = new Size(64,64);
		ext.Location = new Point(0,0);
		ext.Font = bfont;
		ext.Text = "Exit";
		ext.TabStop = false;
		ext.Click += (sender,args) =>
		{
			rtm.Hide();
			rtc.Hide();
		};
		//create();
		// functions
		rtc.Controls.Add(ext);
		if (AppData.properties.runtimeController == true)
		{
			rtc.Show();
		}
		rtm.Show();
	}
	static public void preBuilt()
	{
		// adds
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		Form pb = new Form();
		pb.Size = new Size(256,160);
		pb.MinimizeBox = false;
		pb.MaximizeBox = false;
		pb.MinimumSize = new Size(256,160);
		pb.MaximumSize = new Size(256,160);
		pb.Text = "Vertex 1.5 Examples";
		pb.Icon = new Icon("icon.ico");
		Button one = new Button();
		one.Size = new Size(256,32);
		one.Location = new Point(0,0);
		one.Font = bfont;
		one.Text = "#1 (Pong)";
		one.TabStop = false;
		one.Click += (sender,args) =>
		{
			Examples.one();
		};
		Button two = new Button();
		two.Size = new Size(256,32);
		two.Location = new Point(0,32);
		two.Font = bfont;
		two.Text = "#2 (Mario)";
		two.TabStop = false;
		two.Click += (sender,args) =>
		{
			Examples.two();
		};
		Button three = new Button();
		three.Size = new Size(256,32);
		three.Location = new Point(0,64);
		three.Font = bfont;
		three.Text = "#3 (FNAF)";
		three.TabStop = false;
		three.Click += (sender,args) =>
		{
			Examples.three();
		};
		// functions
		pb.Controls.Add(one);
		pb.Controls.Add(two);
		pb.Controls.Add(three);
		pb.Show();
	}
	static public void info()
	{
		// adds
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		Form info = new Form();
		info.Size = new Size(320,640);
		info.MinimizeBox = false;
		info.MaximizeBox = false;
		info.MinimumSize = new Size(320,640);
		info.MaximumSize = new Size(320,640);
		info.Text = "Vertex 1.5 Informations";
		info.Icon = new Icon("icon.ico");
		Label text = new Label();
		text.Size = new Size(320,640);
		text.Location = new Point(0,0);
		text.Font = bfont;
		text.Text = 
		@"Rise LLC, 2025
		Made By
		Ry Chester > Programmer
		And
		Vice Twice > Tester
		License
		MIT License
		Vertex 1.5
		Amount Of Objects Available: 10
		Conditions In Each Object: 10;
		Amount Of Events In Each Object: 10
		Vertex 2.0
		Amount Of Objects Available: 20
		Amount Of Events In Each Object: 10
		Vertex 3.0
		Amount Of Objects Available: 30
		Amount Of Events In Each Object: 10
		Price $30
		Note:
		The 1.0 version had only basic functions to make games like Pong.
		The 2.0 version will has advance functions to make games like Mario.
		The 3.0 version will has the most amount of objects in the game to make games like FNAF.
		Special Thanks To
		You
		";
		// functions
		info.Controls.Add(text);
		info.Show();
	}
	static public void app(string file)
	{
		string line;
		StreamReader rdr = new StreamReader(file);
		line = rdr.ReadLine();
		while (line != null)
		{
			Form rtm = new Form();
			rtm.Size = new Size(512,512);
			Console.WriteLine(line);
			string[] tokens = line.Split(' ');
			string property = "";
			string[] properties =
			{
				"name:",
				"import:",
				"d1-type:",
				"d1-event-d1-cdn:",
				"d1-event-d1-exp:",
				"d1-event-d2-cdn:",
				"d1-event-d2-exp:",
				"d1-event-d3-cdn:",
				"d1-event-d3-exp:",
				"d1-event-d4-cdn:",
				"d1-event-d4-exp:",
				"d1-event-d5-cdn:",
				"d1-event-d5-exp:",
				"d1-event-d6-cdn:",
				"d1-event-d6-exp:",
				"d1-event-d7-cdn:",
				"d1-event-d7-exp:",
				"d1-event-d8-cdn:",
				"d1-event-d8-exp:",
				"d1-event-d9-cdn:",
				"d1-event-d9-exp:",
				"d1-event-d10-cdn:",
				"d1-event-d10-exp:",
				"d1-width:",
				"d1-height:",
				"d1-x:",
				"d1-y:",
				"d1-value:",
				"d1-transparency:",
				"d1-visible:",
				"d2-type:",
				"d2-event-d1-cdn:",
				"d2-event-d1-exp:",
				"d2-event-d2-cdn:",
				"d2-event-d2-exp:",
				"d2-event-d3-cdn:",
				"d2-event-d3-exp:",
				"d2-event-d4-cdn:",
				"d2-event-d4-exp:",
				"d2-event-d5-cdn:",
				"d2-event-d5-exp:",
				"d2-event-d6-cdn:",
				"d2-event-d6-exp:",
				"d2-event-d7-cdn:",
				"d2-event-d7-exp:",
				"d2-event-d8-cdn:",
				"d2-event-d8-exp:",
				"d2-event-d9-cdn:",
				"d2-event-d9-exp:",
				"d2-event-d10-cdn:",
				"d2-event-d10-exp:",
				"d2-width:",
				"d2-height:",
				"d2-x:",
				"d2-y:",
				"d2-value:",
				"d2-transparency:",
				"d2-visible:",
				"d3-type:",
				"d3-event-d1-cdn:",
				"d3-event-d1-exp:",
				"d3-event-d2-cdn:",
				"d3-event-d2-exp:",
				"d3-event-d3-cdn:",
				"d3-event-d3-exp:",
				"d3-event-d4-cdn:",
				"d3-event-d4-exp:",
				"d3-event-d5-cdn:",
				"d3-event-d5-exp:",
				"d3-event-d6-cdn:",
				"d3-event-d6-exp:",
				"d3-event-d7-cdn:",
				"d3-event-d7-exp:",
				"d3-event-d8-cdn:",
				"d3-event-d8-exp:",
				"d3-event-d9-cdn:",
				"d3-event-d9-exp:",
				"d3-event-d10-cdn:",
				"d3-event-d10-exp:",
				"d3-width:",
				"d3-height:",
				"d3-x:",
				"d3-y:",
				"d3-value:",
				"d3-transparency:",
				"d3-visible:",
				"d4-type:",
				"d4-event-d1-cdn:",
				"d4-event-d1-exp:",
				"d4-event-d2-cdn:",
				"d4-event-d2-exp:",
				"d4-event-d3-cdn:",
				"d4-event-d3-exp:",
				"d4-event-d4-cdn:",
				"d4-event-d4-exp:",
				"d4-event-d5-cdn:",
				"d4-event-d5-exp:",
				"d4-event-d6-cdn:",
				"d4-event-d6-exp:",
				"d4-event-d7-cdn:",
				"d4-event-d7-exp:",
				"d4-event-d8-cdn:",
				"d4-event-d8-exp:",
				"d4-event-d9-cdn:",
				"d4-event-d9-exp:",
				"d4-event-d10-cdn:",
				"d4-event-d10-exp:",
				"d4-width:",
				"d4-height:",
				"d4-x:",
				"d4-y:",
				"d4-value:",
				"d4-transparency:",
				"d4-visible:",
				"d5-type:",
				"d5-event-d1-cdn:",
				"d5-event-d1-exp:",
				"d5-event-d2-cdn:",
				"d5-event-d2-exp:",
				"d5-event-d3-cdn:",
				"d5-event-d3-exp:",
				"d5-event-d4-cdn:",
				"d5-event-d4-exp:",
				"d5-event-d5-cdn:",
				"d5-event-d5-exp:",
				"d5-event-d6-cdn:",
				"d5-event-d6-exp:",
				"d5-event-d7-cdn:",
				"d5-event-d7-exp:",
				"d5-event-d8-cdn:",
				"d5-event-d8-exp:",
				"d5-event-d9-cdn:",
				"d5-event-d9-exp:",
				"d5-event-d10-cdn:",
				"d5-event-d10-exp:",
				"d5-width:",
				"d5-height:",
				"d5-x:",
				"d5-y:",
				"d5-value:",
				"d5-transparency:",
				"d5-visible:",
				"d6-type:",
				"d6-event-d1-cdn:",
				"d6-event-d1-exp:",
				"d6-event-d2-cdn:",
				"d6-event-d2-exp:",
				"d6-event-d3-cdn:",
				"d6-event-d3-exp:",
				"d6-event-d4-cdn:",
				"d6-event-d4-exp:",
				"d6-event-d5-cdn:",
				"d6-event-d5-exp:",
				"d6-event-d6-cdn:",
				"d6-event-d6-exp:",
				"d6-event-d7-cdn:",
				"d6-event-d7-exp:",
				"d6-event-d8-cdn:",
				"d6-event-d8-exp:",
				"d6-event-d9-cdn:",
				"d6-event-d9-exp:",
				"d6-event-d10-cdn:",
				"d6-event-d10-exp:",
				"d6-width:",
				"d6-height:",
				"d6-x:",
				"d6-y:",
				"d6-value:",
				"d6-transparency:",
				"d6-visible:",
				"d7-type:",
				"d7-event-d1-cdn:",
				"d7-event-d1-exp:",
				"d7-event-d2-cdn:",
				"d7-event-d2-exp:",
				"d7-event-d3-cdn:",
				"d7-event-d3-exp:",
				"d7-event-d4-cdn:",
				"d7-event-d4-exp:",
				"d7-event-d5-cdn:",
				"d7-event-d5-exp:",
				"d7-event-d6-cdn:",
				"d7-event-d6-exp:",
				"d7-event-d7-cdn:",
				"d7-event-d7-exp:",
				"d7-event-d8-cdn:",
				"d7-event-d8-exp:",
				"d7-event-d9-cdn:",
				"d7-event-d9-exp:",
				"d7-event-d10-cdn:",
				"d7-event-d10-exp:",
				"d7-width:",
				"d7-height:",
				"d7-x:",
				"d7-y:",
				"d7-value:",
				"d7-transparency:",
				"d7-visible:",
				"d8-type:",
				"d8-event-d1-cdn:",
				"d8-event-d1-exp:",
				"d8-event-d2-cdn:",
				"d8-event-d2-exp:",
				"d8-event-d3-cdn:",
				"d8-event-d3-exp:",
				"d8-event-d4-cdn:",
				"d8-event-d4-exp:",
				"d8-event-d5-cdn:",
				"d8-event-d5-exp:",
				"d8-event-d6-cdn:",
				"d8-event-d6-exp:",
				"d8-event-d7-cdn:",
				"d8-event-d7-exp:",
				"d8-event-d8-cdn:",
				"d8-event-d8-exp:",
				"d8-event-d9-cdn:",
				"d8-event-d9-exp:",
				"d8-event-d10-cdn:",
				"d8-event-d10-exp:",
				"d8-width:",
				"d8-height:",
				"d8-x:",
				"d8-y:",
				"d8-value:",
				"d8-transparency:",
				"d8-visible:",
				"d9-type:",
				"d9-event-d1-cdn:",
				"d9-event-d1-exp:",
				"d9-event-d2-cdn:",
				"d9-event-d2-exp:",
				"d9-event-d3-cdn:",
				"d9-event-d3-exp:",
				"d9-event-d4-cdn:",
				"d9-event-d4-exp:",
				"d9-event-d5-cdn:",
				"d9-event-d5-exp:",
				"d9-event-d6-cdn:",
				"d9-event-d6-exp:",
				"d9-event-d7-cdn:",
				"d9-event-d7-exp:",
				"d9-event-d8-cdn:",
				"d9-event-d8-exp:",
				"d9-event-d9-cdn:",
				"d9-event-d9-exp:",
				"d9-event-d10-cdn:",
				"d9-event-d10-exp:",
				"d9-width:",
				"d9-height:",
				"d9-x:",
				"d9-y:",
				"d9-value:",
				"d9-transparency:",
				"d9-visible:",
				"d10-type:",
				"d10-event-d1-cdn:",
				"d10-event-d1-exp:",
				"d10-event-d2-cdn:",
				"d10-event-d2-exp:",
				"d10-event-d3-cdn:",
				"d10-event-d3-exp:",
				"d10-event-d4-cdn:",
				"d10-event-d4-exp:",
				"d10-event-d5-cdn:",
				"d10-event-d5-exp:",
				"d10-event-d6-cdn:",
				"d10-event-d6-exp:",
				"d10-event-d7-cdn:",
				"d10-event-d7-exp:",
				"d10-event-d8-cdn:",
				"d10-event-d8-exp:",
				"d10-event-d9-cdn:",
				"d10-event-d9-exp:",
				"d10-event-d10-cdn:",
				"d10-event-d10-exp:",
				"d10-width:",
				"d10-height:",
				"d10-x:",
				"d10-y:",
				"d10-value:",
				"d10-transparency:",
				"d10-visible:",
				"export:",
				"run:"
			};
			foreach (var token in tokens)
			{
				foreach (var ppt in properties)
				{
					if (token.Contains(ppt))
					{
						property = token;
					}
					else
					{
						if (property != " ")
						{
							string sToken = token.Replace(";","");
							sToken = sToken.Replace("[ns]"," ");
							sToken = sToken.Replace("[nl]","\n");
							if (property == "name:")
							{
								rtm.Text = sToken;
							}
							if (property == "import:")
							{
								if (sToken == "variables")
								{
									AppData.extensions.variables = true;
								}
								if (sToken == "vtsd")
								{
									AppData.extensions.vtsd = true;
								}
							}
							if (property == "export:")
							{
								if (sToken == "d1")
								{
									if (AppData.section.d1.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d1.width,AppData.section.d1.height);
										obj.Location = new Point(AppData.section.d1.x,AppData.section.d1.y);
										obj.ImageLocation = AppData.section.d1.values.img;
										rtm.Controls.Add(obj);
										actives.d1 = obj;
									}
									if (AppData.section.d1.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d1.width,AppData.section.d1.height);
										obj.Location = new Point(AppData.section.d1.x,AppData.section.d1.y);
										obj.Text = AppData.section.d1.values.str;
										rtm.Controls.Add(obj);
										strings.d1 = obj;
									}
									if (AppData.section.d1.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d1.width,AppData.section.d1.height);
										obj.Location = new Point(AppData.section.d1.x,AppData.section.d1.y);
										obj.Text = Convert.ToString(AppData.section.d1.values.val);
										rtm.Controls.Add(obj);
										counters.d1 = obj;
									}
									if (AppData.section.d1.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d1.width,AppData.section.d1.height);
										obj.Location = new Point(AppData.section.d1.x,AppData.section.d1.y);
										obj.Text = AppData.section.d1.values.str;
										rtm.Controls.Add(obj);
										buttons.d1 = obj;
									}
									if (AppData.section.d1.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d1.width,AppData.section.d1.height);
										obj.Location = new Point(AppData.section.d1.x,AppData.section.d1.y);
										obj.Text = AppData.section.d1.values.str;
										rtm.Controls.Add(obj);
										editboxes.d1 = obj;
									}
								}
								if (sToken == "d2")
								{
									if (AppData.section.d2.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d2.width,AppData.section.d2.height);
										obj.Location = new Point(AppData.section.d2.x,AppData.section.d2.y);
										obj.ImageLocation = AppData.section.d2.values.img;
										rtm.Controls.Add(obj);
										actives.d2 = obj;
									}
									if (AppData.section.d2.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d2.width,AppData.section.d2.height);
										obj.Location = new Point(AppData.section.d2.x,AppData.section.d2.y);
										obj.Text = AppData.section.d2.values.str;
										rtm.Controls.Add(obj);
										strings.d2 = obj;
									}
									if (AppData.section.d2.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d2.width,AppData.section.d2.height);
										obj.Location = new Point(AppData.section.d2.x,AppData.section.d2.y);
										obj.Text = Convert.ToString(AppData.section.d2.values.val);
										rtm.Controls.Add(obj);
										counters.d2 = obj;
									}
									if (AppData.section.d2.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d2.width,AppData.section.d2.height);
										obj.Location = new Point(AppData.section.d2.x,AppData.section.d2.y);
										obj.Text = AppData.section.d2.values.str;
										rtm.Controls.Add(obj);
										buttons.d2 = obj;
									}
									if (AppData.section.d2.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d2.width,AppData.section.d2.height);
										obj.Location = new Point(AppData.section.d2.x,AppData.section.d2.y);
										obj.Text = AppData.section.d2.values.str;
										rtm.Controls.Add(obj);
										editboxes.d2 = obj;
									}
								}
								if (sToken == "d3")
								{
									if (AppData.section.d3.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d3.width,AppData.section.d3.height);
										obj.Location = new Point(AppData.section.d3.x,AppData.section.d3.y);
										obj.ImageLocation = AppData.section.d3.values.img;
										rtm.Controls.Add(obj);
										actives.d3 = obj;
									}
									if (AppData.section.d3.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d3.width,AppData.section.d3.height);
										obj.Location = new Point(AppData.section.d3.x,AppData.section.d3.y);
										obj.Text = AppData.section.d3.values.str;
										rtm.Controls.Add(obj);
										strings.d3 = obj;
									}
									if (AppData.section.d3.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d3.width,AppData.section.d3.height);
										obj.Location = new Point(AppData.section.d3.x,AppData.section.d3.y);
										obj.Text = Convert.ToString(AppData.section.d3.values.val);
										rtm.Controls.Add(obj);
										counters.d3 = obj;
									}
									if (AppData.section.d3.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d3.width,AppData.section.d3.height);
										obj.Location = new Point(AppData.section.d3.x,AppData.section.d3.y);
										obj.Text = AppData.section.d3.values.str;
										rtm.Controls.Add(obj);
										buttons.d3 = obj;
									}
									if (AppData.section.d3.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d3.width,AppData.section.d3.height);
										obj.Location = new Point(AppData.section.d3.x,AppData.section.d3.y);
										obj.Text = AppData.section.d3.values.str;
										rtm.Controls.Add(obj);
										editboxes.d3 = obj;
									}
								}
								if (sToken == "d4")
								{
									if (AppData.section.d4.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d4.width,AppData.section.d4.height);
										obj.Location = new Point(AppData.section.d4.x,AppData.section.d4.y);
										obj.ImageLocation = AppData.section.d4.values.img;
										rtm.Controls.Add(obj);
										actives.d4 = obj;
									}
									if (AppData.section.d4.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d4.width,AppData.section.d4.height);
										obj.Location = new Point(AppData.section.d4.x,AppData.section.d4.y);
										obj.Text = AppData.section.d4.values.str;
										rtm.Controls.Add(obj);
										editboxes.d4 = obj;
									}
									if (AppData.section.d4.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d4.width,AppData.section.d4.height);
										obj.Location = new Point(AppData.section.d4.x,AppData.section.d4.y);
										obj.Text = Convert.ToString(AppData.section.d4.values.val);
										rtm.Controls.Add(obj);
										counters.d4 = obj;
									}
									if (AppData.section.d4.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d4.width,AppData.section.d4.height);
										obj.Location = new Point(AppData.section.d4.x,AppData.section.d4.y);
										obj.Text = AppData.section.d4.values.str;
										rtm.Controls.Add(obj);
										buttons.d4 = obj;
									}
									if (AppData.section.d4.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d4.width,AppData.section.d4.height);
										obj.Location = new Point(AppData.section.d4.x,AppData.section.d4.y);
										obj.Text = AppData.section.d4.values.str;
										rtm.Controls.Add(obj);
										editboxes.d4 = obj;
									}
								}
								if (sToken == "d5")
								{
									if (AppData.section.d5.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d5.width,AppData.section.d5.height);
										obj.Location = new Point(AppData.section.d5.x,AppData.section.d5.y);
										obj.ImageLocation = AppData.section.d5.values.img;
										rtm.Controls.Add(obj);
										actives.d5 = obj;
									}
									if (AppData.section.d5.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d5.width,AppData.section.d5.height);
										obj.Location = new Point(AppData.section.d5.x,AppData.section.d5.y);
										obj.Text = AppData.section.d5.values.str;
										rtm.Controls.Add(obj);
										strings.d5 = obj;
									}
									if (AppData.section.d5.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d5.width,AppData.section.d5.height);
										obj.Location = new Point(AppData.section.d5.x,AppData.section.d5.y);
										obj.Text = Convert.ToString(AppData.section.d5.values.val);
										rtm.Controls.Add(obj);
										counters.d5 = obj;
									}
									if (AppData.section.d5.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d5.width,AppData.section.d5.height);
										obj.Location = new Point(AppData.section.d5.x,AppData.section.d5.y);
										obj.Text = AppData.section.d5.values.str;
										rtm.Controls.Add(obj);
										buttons.d5 = obj;
									}
									if (AppData.section.d5.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d5.width,AppData.section.d5.height);
										obj.Location = new Point(AppData.section.d5.x,AppData.section.d5.y);
										obj.Text = AppData.section.d5.values.str;
										rtm.Controls.Add(obj);
										editboxes.d5 = obj;
									}
								}
								if (sToken == "d6")
								{
									if (AppData.section.d6.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d6.width,AppData.section.d6.height);
										obj.Location = new Point(AppData.section.d6.x,AppData.section.d6.y);
										obj.ImageLocation = AppData.section.d6.values.img;
										rtm.Controls.Add(obj);
										actives.d6 = obj;
									}
									if (AppData.section.d6.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d6.width,AppData.section.d6.height);
										obj.Location = new Point(AppData.section.d6.x,AppData.section.d6.y);
										obj.Text = AppData.section.d6.values.str;
										rtm.Controls.Add(obj);
										strings.d6 = obj;
									}
									if (AppData.section.d6.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d6.width,AppData.section.d6.height);
										obj.Location = new Point(AppData.section.d6.x,AppData.section.d6.y);
										obj.Text = Convert.ToString(AppData.section.d6.values.val);
										rtm.Controls.Add(obj);
										counters.d6 = obj;
									}
									if (AppData.section.d6.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d6.width,AppData.section.d6.height);
										obj.Location = new Point(AppData.section.d6.x,AppData.section.d6.y);
										obj.Text = AppData.section.d6.values.str;
										rtm.Controls.Add(obj);
										buttons.d6 = obj;
									}
									if (AppData.section.d6.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d6.width,AppData.section.d6.height);
										obj.Location = new Point(AppData.section.d6.x,AppData.section.d6.y);
										obj.Text = AppData.section.d6.values.str;
										rtm.Controls.Add(obj);
										editboxes.d6 = obj;
									}
								}
								if (sToken == "d7")
								{
									if (AppData.section.d7.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d7.width,AppData.section.d7.height);
										obj.Location = new Point(AppData.section.d7.x,AppData.section.d7.y);
										obj.ImageLocation = AppData.section.d7.values.img;
										rtm.Controls.Add(obj);
										actives.d7 = obj;
									}
									if (AppData.section.d7.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d7.width,AppData.section.d7.height);
										obj.Location = new Point(AppData.section.d7.x,AppData.section.d7.y);
										obj.Text = AppData.section.d7.values.str;
										rtm.Controls.Add(obj);
										strings.d7 = obj;
									}
									if (AppData.section.d7.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d7.width,AppData.section.d7.height);
										obj.Location = new Point(AppData.section.d7.x,AppData.section.d7.y);
										obj.Text = Convert.ToString(AppData.section.d7.values.val);
										rtm.Controls.Add(obj);
										counters.d7 = obj;
									}
									if (AppData.section.d7.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d7.width,AppData.section.d7.height);
										obj.Location = new Point(AppData.section.d7.x,AppData.section.d7.y);
										obj.Text = AppData.section.d7.values.str;
										rtm.Controls.Add(obj);
										buttons.d7 = obj;
									}
									if (AppData.section.d7.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d7.width,AppData.section.d7.height);
										obj.Location = new Point(AppData.section.d7.x,AppData.section.d7.y);
										obj.Text = AppData.section.d7.values.str;
										rtm.Controls.Add(obj);
										editboxes.d7 = obj;
									}
								}
								if (sToken == "d8")
								{
									if (AppData.section.d8.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d8.width,AppData.section.d8.height);
										obj.Location = new Point(AppData.section.d8.x,AppData.section.d8.y);
										obj.ImageLocation = AppData.section.d8.values.img;
										rtm.Controls.Add(obj);
										actives.d8 = obj;
									}
									if (AppData.section.d8.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d8.width,AppData.section.d8.height);
										obj.Location = new Point(AppData.section.d8.x,AppData.section.d8.y);
										obj.Text = AppData.section.d8.values.str;
										rtm.Controls.Add(obj);
										strings.d8 = obj;
									}
									if (AppData.section.d8.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d8.width,AppData.section.d8.height);
										obj.Location = new Point(AppData.section.d8.x,AppData.section.d8.y);
										obj.Text = Convert.ToString(AppData.section.d8.values.val);
										rtm.Controls.Add(obj);
										counters.d8 = obj;
									}
									if (AppData.section.d8.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d8.width,AppData.section.d8.height);
										obj.Location = new Point(AppData.section.d8.x,AppData.section.d8.y);
										obj.Text = AppData.section.d8.values.str;
										rtm.Controls.Add(obj);
										buttons.d8 = obj;
									}
									if (AppData.section.d8.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d8.width,AppData.section.d8.height);
										obj.Location = new Point(AppData.section.d8.x,AppData.section.d8.y);
										obj.Text = AppData.section.d8.values.str;
										rtm.Controls.Add(obj);
										editboxes.d8 = obj;
									}
								}
								if (sToken == "d9")
								{
									if (AppData.section.d9.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d9.width,AppData.section.d9.height);
										obj.Location = new Point(AppData.section.d9.x,AppData.section.d9.y);
										obj.ImageLocation = AppData.section.d9.values.img;
										rtm.Controls.Add(obj);
										actives.d9 = obj;
									}
									if (AppData.section.d9.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d9.width,AppData.section.d9.height);
										obj.Location = new Point(AppData.section.d9.x,AppData.section.d9.y);
										obj.Text = AppData.section.d9.values.str;
										rtm.Controls.Add(obj);
										strings.d9 = obj;
									}
									if (AppData.section.d9.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d9.width,AppData.section.d9.height);
										obj.Location = new Point(AppData.section.d9.x,AppData.section.d9.y);
										obj.Text = Convert.ToString(AppData.section.d9.values.val);
										rtm.Controls.Add(obj);
										counters.d9 = obj;
									}
									if (AppData.section.d9.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d9.width,AppData.section.d9.height);
										obj.Location = new Point(AppData.section.d9.x,AppData.section.d9.y);
										obj.Text = AppData.section.d9.values.str;
										rtm.Controls.Add(obj);
										buttons.d9 = obj;
									}
									if (AppData.section.d9.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d9.width,AppData.section.d9.height);
										obj.Location = new Point(AppData.section.d9.x,AppData.section.d9.y);
										obj.Text = AppData.section.d9.values.str;
										rtm.Controls.Add(obj);
										editboxes.d9 = obj;
									}
								}
								if (sToken == "d10")
								{
									if (AppData.section.d10.type == "Active")
									{
										var obj = new PictureBox();
										obj.Size = new Size(AppData.section.d10.width,AppData.section.d10.height);
										obj.Location = new Point(AppData.section.d10.x,AppData.section.d10.y);
										obj.ImageLocation = AppData.section.d10.values.img;
										rtm.Controls.Add(obj);
										actives.d10 = obj;
									}
									if (AppData.section.d10.type == "String")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d10.width,AppData.section.d10.height);
										obj.Location = new Point(AppData.section.d10.x,AppData.section.d10.y);
										obj.Text = AppData.section.d10.values.str;
										rtm.Controls.Add(obj);
										strings.d10 = obj;
									}
									if (AppData.section.d10.type == "Counter")
									{
										var obj = new Label();
										obj.Size = new Size(AppData.section.d10.width,AppData.section.d10.height);
										obj.Location = new Point(AppData.section.d10.x,AppData.section.d10.y);
										obj.Text = Convert.ToString(AppData.section.d10.values.val);
										rtm.Controls.Add(obj);
										counters.d10 = obj;
									}
									if (AppData.section.d10.type == "Button")
									{
										var obj = new Button();
										obj.Size = new Size(AppData.section.d10.width,AppData.section.d10.height);
										obj.Location = new Point(AppData.section.d10.x,AppData.section.d10.y);
										obj.Text = AppData.section.d10.values.str;
										rtm.Controls.Add(obj);
										buttons.d10 = obj;
									}
									if (AppData.section.d10.type == "Editbox")
									{
										var obj = new TextBox();
										obj.Size = new Size(AppData.section.d10.width,AppData.section.d10.height);
										obj.Location = new Point(AppData.section.d10.x,AppData.section.d10.y);
										obj.Text = AppData.section.d10.values.str;
										rtm.Controls.Add(obj);
										editboxes.d10 = obj;
									}
								}
							}
							if (property == "d1-type:")
							{
								AppData.section.d1.type = sToken;
							}
							if (property == "d1-width:")
							{
								AppData.section.d1.width = Convert.ToInt32(sToken);
							}
							if (property == "d1-height:")
							{
								AppData.section.d1.height = Convert.ToInt32(sToken);
							}
							if (property == "d1-x:")
							{
								AppData.section.d1.x = Convert.ToInt32(sToken);
							}
							if (property == "d1-y:")
							{
								AppData.section.d1.y = Convert.ToInt32(sToken);
							}
							if (property == "d1-value:")
							{
								if (AppData.section.d1.type == "Active")
								{
									AppData.section.d1.values.img = sToken;
								}
								if (AppData.section.d1.type == "String")
								{
									AppData.section.d1.values.str = sToken;
								}
								if (AppData.section.d1.type == "Counter")
								{
									AppData.section.d1.values.val = sToken;
								}
								if (AppData.section.d1.type == "Button")
								{
									AppData.section.d1.values.str = sToken;
								}
								if (AppData.section.d1.type == "Editbox")
								{
									AppData.section.d1.values.str = sToken;
								}
							}
							if (property == "d1-event-d1-cdn:")
							{
								AppData.section.d1.events.d1.cdn = sToken;
							}
							if (property == "d1-event-d1-exp:")
							{
								AppData.section.d1.events.d1.exp = sToken;
							}
							if (property == "d1-event-d2-cdn:")
							{
								AppData.section.d1.events.d2.cdn = sToken;
							}
							if (property == "d1-event-d2-exp:")
							{
								AppData.section.d1.events.d2.exp = sToken;
							}
							if (property == "d1-event-d3-cdn:")
							{
								AppData.section.d1.events.d3.cdn = sToken;
							}
							if (property == "d1-event-d3-exp:")
							{
								AppData.section.d1.events.d3.exp = sToken;
							}
							if (property == "d1-event-d4-cdn:")
							{
								AppData.section.d1.events.d4.cdn = sToken;
							}
							if (property == "d1-event-d4-exp:")
							{
								AppData.section.d1.events.d4.exp = sToken;
							}
							if (property == "d1-event-d5-cdn:")
							{
								AppData.section.d1.events.d5.cdn = sToken;
							}
							if (property == "d1-event-d5-exp:")
							{
								AppData.section.d1.events.d5.exp = sToken;
							}
							if (property == "d1-event-d6-cdn:")
							{
								AppData.section.d1.events.d6.cdn = sToken;
							}
							if (property == "d1-event-d6-exp:")
							{
								AppData.section.d1.events.d6.exp = sToken;
							}
							if (property == "d1-event-d7-cdn:")
							{
								AppData.section.d1.events.d7.cdn = sToken;
							}
							if (property == "d1-event-d7-exp:")
							{
								AppData.section.d1.events.d7.exp = sToken;
							}
							if (property == "d1-event-d8-cdn:")
							{
								AppData.section.d1.events.d8.cdn = sToken;
							}
							if (property == "d1-event-d8-exp:")
							{
								AppData.section.d1.events.d8.exp = sToken;
							}
							if (property == "d1-event-d9-cdn:")
							{
								AppData.section.d1.events.d9.cdn = sToken;
							}
							if (property == "d1-event-d9-exp:")
							{
								AppData.section.d1.events.d9.exp = sToken;
							}
							if (property == "d1-event-d10-cdn:")
							{
								AppData.section.d1.events.d10.cdn = sToken;
							}
							if (property == "d1-event-d10-exp:")
							{
								AppData.section.d1.events.d10.exp = sToken;
							}
							if (property == "run:" && sToken == "true")
							{
								Application.Run(rtm);
							}
						}
					}
				}
			}
			line = rdr.ReadLine();
		}
	}
	static public void editor()
	{
		// adds
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		Form edt = new Form();
		edt.Size = new Size(256,128);
		edt.MinimizeBox = false;
		edt.MaximizeBox = false;
		edt.MinimumSize = new Size(256,128);
		edt.MaximumSize = new Size(256,128);
		edt.Text = "Vertex 1.5 Taskbar";
		edt.Icon = new Icon("icon.ico");
		Form prv = new Form();
		prv.Size = new Size(512,512);
		prv.MinimizeBox = false;
		prv.MaximizeBox = false;
		prv.MinimumSize = new Size(512,512);
		prv.MaximumSize = new Size(512,512);
		prv.Text = "Vertex 1.5 Runtime Preview";
		prv.Icon = new Icon("icon.ico");
		Button run = new Button();
		run.Size = new Size(64,16);
		run.Location = new Point(0,0);
		run.Font = bfont;
		run.Text = "Run";
		run.TabStop = false;
		run.Click += (sender,args) =>
		{
			app(file);
		};
		TextBox name = new TextBox();
		name.Size = new Size(64,32);
		name.Location = new Point(run.Location.X + 64,0);
		name.Multiline = true;
		name.Font = bfont;
		name.Text = "Name";
		name.TabStop = false;
		Button save = new Button();
		save.Size = new Size(64,16);
		save.Location = new Point(name.Location.X + 64,0);
		save.Font = bfont;
		save.Text = "Save";
		save.TabStop = false;
		string ext1 = "";
		string ext2 = "";
		string ext3 = "";
		string ext4 = "";
		string ext5 = "";
		/*
		save.Click += (sender,args) =>
		{
			if (file != null || file != "")
			{
				StreamWriter wrt = new StreamWriter(file + ".vta");
				string? d1value = null;
				if (AppData.section.d1.values.str != null)
				{
					d1value = AppData.section.d1.values.str;
				}
				if (AppData.section.d1.values.img != null)
				{
					d1value = AppData.section.d1.values.img;
				}
				if (AppData.section.d1.values.val != null)
				{
					d1value = AppData.section.d1.values.val;
				}
				string? d2value = null;
				if (AppData.section.d2.values.str != null)
				{
					d2value = AppData.section.d2.values.str;
				}
				if (AppData.section.d2.values.img != null)
				{
					d2value = AppData.section.d2.values.img;
				}
				if (AppData.section.d2.values.val != null)
				{
					d2value = AppData.section.d2.values.val;
				}
				var d3value;
				if (AppData.section.d3.values.str != null)
				{
					d3value = AppData.section.d3.values.str;
				}
				if (AppData.section.d3.values.img != null)
				{
					d3value = AppData.section.d3.values.img;
				}
				if (AppData.section.d3.values.val != null)
				{
					d3value = AppData.section.d3.values.val;
				}
				var d4value;
				if (AppData.section.d4.values.str != null)
				{
					d4value = AppData.section.d4.values.str;
				}
				if (AppData.section.d4.values.img != null)
				{
					d4value = AppData.section.d4.values.img;
				}
				if (AppData.section.d4.values.val != null)
				{
					d4value = AppData.section.d4.values.val;
				}
				var d5value;
				if (AppData.section.d5.values.str != null)
				{
					d5value = AppData.section.d5.values.str;
				}
				if (AppData.section.d5.values.img != null)
				{
					d5value = AppData.section.d5.values.img;
				}
				if (AppData.section.d5.values.val != null)
				{
					d5value = AppData.section.d5.values.val;
				}
				var d6value;
				if (AppData.section.d6.values.str != null)
				{
					d6value = AppData.section.d6.values.str;
				}
				if (AppData.section.d6.values.img != null)
				{
					d6value = AppData.section.d6.values.img;
				}
				if (AppData.section.d6.values.val != null)
				{
					d6value = AppData.section.d6.values.val;
				}
				var d7value;
				if (AppData.section.d7.values.str != null)
				{
					d7value = AppData.section.d7.values.str;
				}
				if (AppData.section.d7.values.img != null)
				{
					d7value = AppData.section.d7.values.img;
				}
				if (AppData.section.d7.values.val != null)
				{
					d7value = AppData.section.d7.values.val;
				}
				var d8value;
				if (AppData.section.d8.values.str != null)
				{
					d8value = AppData.section.d8.values.str;
				}
				if (AppData.section.d8.values.img != null)
				{
					d8value = AppData.section.d8.values.img;
				}
				if (AppData.section.d8.values.val != null)
				{
					d8value = AppData.section.d8.values.val;
				}
				var d9value;
				if (AppData.section.d9.values.str != null)
				{
					d9value = AppData.section.d9.values.str;
				}
				if (AppData.section.d9.values.img != null)
				{
					d9value = AppData.section.d9.values.img;
				}
				if (AppData.section.d9.values.val != null)
				{
					d9value = AppData.section.d9.values.val;
				}
				var d10value;
				if (AppData.section.d10.values.str != null)
				{
					d10value = AppData.section.d10.values.str;
				}
				if (AppData.section.d10.values.img != null)
				{
					d10value = AppData.section.d10.values.img;
				}
				if (AppData.section.d10.values.val != null)
				{
					d10value = AppData.section.d10.values.val;
				}
				wrt.WriteLine
				(
					@"name: " + AppData.properties.name + @";
					" + ext1 + ext2 + ext3 + ext4 + ext5 +
					@"d1-type: " + AppData.section.d1.type + @";
					d1-event-d1-cdn: " + AppData.section.d1.events.d1.cdn.sd1 + " "
					+ AppData.section.d1.events.d1.cdn.sd2 + " "
					+ AppData.section.d1.events.d1.cdn.sd3 + " "
					+ AppData.section.d1.events.d1.cdn.sd4 + " "
					+ AppData.section.d1.events.d1.cdn.sd5 + @";
					d1-event-d1-exp: " + AppData.section.d1.events.d1.exp.sd1 + " "
					+ AppData.section.d1.events.d1.exp.sd2 + " "
					+ AppData.section.d1.events.d1.exp.sd3 + " "
					+ AppData.section.d1.events.d1.exp.sd4 + " "
					+ AppData.section.d1.events.d1.exp.sd5 + @";
					d1-event-d2-cdn: " + AppData.section.d1.events.d2.cdn.sd1 + " "
					+ AppData.section.d1.events.d2.cdn.sd2 + " "
					+ AppData.section.d1.events.d2.cdn.sd3 + " "
					+ AppData.section.d1.events.d2.cdn.sd4 + " "
					+ AppData.section.d1.events.d2.cdn.sd5 + @";
					d1-event-d2-exp: " + AppData.section.d1.events.d2.exp.sd1 + " "
					+ AppData.section.d1.events.d2.exp.sd2 + " "
					+ AppData.section.d1.events.d2.exp.sd3 + " "
					+ AppData.section.d1.events.d2.exp.sd4 + " "
					+ AppData.section.d1.events.d2.exp.sd5 + @";
					d1-event-d3-cdn: " + AppData.section.d1.events.d3.cdn.sd1 + " "
					+ AppData.section.d1.events.d3.cdn.sd2 + " "
					+ AppData.section.d1.events.d3.cdn.sd3 + " "
					+ AppData.section.d1.events.d3.cdn.sd4 + " "
					+ AppData.section.d1.events.d3.cdn.sd5 + @";
					d1-event-d3-exp: " + AppData.section.d1.events.d3.exp.sd1 + " "
					+ AppData.section.d1.events.d3.exp.sd2 + " "
					+ AppData.section.d1.events.d3.exp.sd3 + " "
					+ AppData.section.d1.events.d3.exp.sd4 + " "
					+ AppData.section.d1.events.d3.exp.sd5 + @";
					d1-event-d4-cdn: " + AppData.section.d1.events.d4.cdn.sd1 + " "
					+ AppData.section.d1.events.d4.cdn.sd2 + " "
					+ AppData.section.d1.events.d4.cdn.sd3 + " "
					+ AppData.section.d1.events.d4.cdn.sd4 + " "
					+ AppData.section.d1.events.d4.cdn.sd5 + @";
					d1-event-d4-exp: " + AppData.section.d1.events.d4.exp.sd1 + " "
					+ AppData.section.d1.events.d4.exp.sd2 + " "
					+ AppData.section.d1.events.d4.exp.sd3 + " "
					+ AppData.section.d1.events.d4.exp.sd4 + " "
					+ AppData.section.d1.events.d4.exp.sd5 + @";
					d1-event-d5-cdn: " + AppData.section.d1.events.d5.cdn.sd1 + " "
					+ AppData.section.d1.events.d5.cdn.sd2 + " "
					+ AppData.section.d1.events.d5.cdn.sd3 + " "
					+ AppData.section.d1.events.d5.cdn.sd4 + " "
					+ AppData.section.d1.events.d5.cdn.sd5 + @";
					d1-event-d5-exp: " + AppData.section.d1.events.d5.exp.sd1 + " "
					+ AppData.section.d1.events.d5.exp.sd2 + " "
					+ AppData.section.d1.events.d5.exp.sd3 + " "
					+ AppData.section.d1.events.d5.exp.sd4 + " "
					+ AppData.section.d1.events.d5.exp.sd5 + @";
					d1-event-d6-cdn: " + AppData.section.d1.events.d6.cdn.sd1 + " "
					+ AppData.section.d1.events.d6.cdn.sd2 + " "
					+ AppData.section.d1.events.d6.cdn.sd3 + " "
					+ AppData.section.d1.events.d6.cdn.sd4 + " "
					+ AppData.section.d1.events.d6.cdn.sd5 + @";
					d1-event-d6-exp: " + AppData.section.d1.events.d6.exp.sd1 + " "
					+ AppData.section.d1.events.d6.exp.sd2 + " "
					+ AppData.section.d1.events.d6.exp.sd3 + " "
					+ AppData.section.d1.events.d6.exp.sd4 + " "
					+ AppData.section.d1.events.d6.exp.sd5 + @";
					d1-event-d7-cdn: " + AppData.section.d1.events.d7.cdn.sd1 + " "
					+ AppData.section.d1.events.d7.cdn.sd2 + " "
					+ AppData.section.d1.events.d7.cdn.sd3 + " "
					+ AppData.section.d1.events.d7.cdn.sd4 + " "
					+ AppData.section.d1.events.d7.cdn.sd5 + @";
					d1-event-d7-exp: " + AppData.section.d1.events.d7.exp.sd1 + " "
					+ AppData.section.d1.events.d7.exp.sd2 + " "
					+ AppData.section.d1.events.d7.exp.sd3 + " "
					+ AppData.section.d1.events.d7.exp.sd4 + " "
					+ AppData.section.d1.events.d7.exp.sd5 + @";
					d1-event-d8-cdn: " + AppData.section.d1.events.d8.cdn.sd1 + " "
					+ AppData.section.d1.events.d8.cdn.sd2 + " "
					+ AppData.section.d1.events.d8.cdn.sd3 + " "
					+ AppData.section.d1.events.d8.cdn.sd4 + " "
					+ AppData.section.d1.events.d8.cdn.sd5 + @";
					d1-event-d8-exp: " + AppData.section.d1.events.d8.exp.sd1 + " "
					+ AppData.section.d1.events.d8.exp.sd2 + " "
					+ AppData.section.d1.events.d8.exp.sd3 + " "
					+ AppData.section.d1.events.d8.exp.sd4 + " "
					+ AppData.section.d1.events.d8.exp.sd5 + @";
					d1-event-d9-cdn: " + AppData.section.d1.events.d9.cdn.sd1 + " "
					+ AppData.section.d1.events.d9.cdn.sd2 + " "
					+ AppData.section.d1.events.d9.cdn.sd3 + " "
					+ AppData.section.d1.events.d9.cdn.sd4 + " "
					+ AppData.section.d1.events.d9.cdn.sd5 + @";
					d1-event-d9-exp: " + AppData.section.d1.events.d9.exp.sd1 + " "
					+ AppData.section.d1.events.d9.exp.sd2 + " "
					+ AppData.section.d1.events.d9.exp.sd3 + " "
					+ AppData.section.d1.events.d9.exp.sd4 + " "
					+ AppData.section.d1.events.d9.exp.sd5 + @";
					d1-event-d10-exp: " + AppData.section.d1.events.d9.exp.sd1 + " "
					+ AppData.section.d1.events.d9.exp.sd2 + " "
					+ AppData.section.d1.events.d9.exp.sd3 + " "
					+ AppData.section.d1.events.d9.exp.sd4 + " "
					+ AppData.section.d1.events.d9.exp.sd5 + @";
					d1-width: " + AppData.section.d1.width + @";
					d1-height: " + AppData.section.d1.height + @";
					d1-value: " + d1value + @";
					d1-x: " + AppData.section.d1.x + @";
					d1-y: " + AppData.section.d1.y + @";
					d1-transparency: " + AppData.section.d1.transparency + @";
					d1-visible: " + AppData.section.d1.visible +
					@"d2-type: " + AppData.section.d2.type + @";
					d2-event-d2-cdn: " + AppData.section.d2.events.d2.cdn.sd1 + " "
					+ AppData.section.d2.events.d2.cdn.sd2 + " "
					+ AppData.section.d2.events.d2.cdn.sd3 + " "
					+ AppData.section.d2.events.d2.cdn.sd4 + " "
					+ AppData.section.d2.events.d2.cdn.sd5 + @";
					d2-event-d2-exp: " + AppData.section.d2.events.d2.exp.sd1 + " "
					+ AppData.section.d2.events.d2.exp.sd2 + " "
					+ AppData.section.d2.events.d2.exp.sd3 + " "
					+ AppData.section.d2.events.d2.exp.sd4 + " "
					+ AppData.section.d2.events.d2.exp.sd5 + @";
					d2-event-d2-cdn: " + AppData.section.d2.events.d2.cdn.sd1 + " "
					+ AppData.section.d2.events.d2.cdn.sd2 + " "
					+ AppData.section.d2.events.d2.cdn.sd3 + " "
					+ AppData.section.d2.events.d2.cdn.sd4 + " "
					+ AppData.section.d2.events.d2.cdn.sd5 + @";
					d2-event-d2-exp: " + AppData.section.d2.events.d2.exp.sd1 + " "
					+ AppData.section.d2.events.d2.exp.sd2 + " "
					+ AppData.section.d2.events.d2.exp.sd3 + " "
					+ AppData.section.d2.events.d2.exp.sd4 + " "
					+ AppData.section.d2.events.d2.exp.sd5 + @";
					d2-event-d3-cdn: " + AppData.section.d2.events.d3.cdn.sd1 + " "
					+ AppData.section.d2.events.d3.cdn.sd2 + " "
					+ AppData.section.d2.events.d3.cdn.sd3 + " "
					+ AppData.section.d2.events.d3.cdn.sd4 + " "
					+ AppData.section.d2.events.d3.cdn.sd5 + @";
					d2-event-d3-exp: " + AppData.section.d2.events.d3.exp.sd1 + " "
					+ AppData.section.d2.events.d3.exp.sd2 + " "
					+ AppData.section.d2.events.d3.exp.sd3 + " "
					+ AppData.section.d2.events.d3.exp.sd4 + " "
					+ AppData.section.d2.events.d3.exp.sd5 + @";
					d2-event-d4-cdn: " + AppData.section.d2.events.d4.cdn.sd1 + " "
					+ AppData.section.d2.events.d4.cdn.sd2 + " "
					+ AppData.section.d2.events.d4.cdn.sd3 + " "
					+ AppData.section.d2.events.d4.cdn.sd4 + " "
					+ AppData.section.d2.events.d4.cdn.sd5 + @";
					d2-event-d4-exp: " + AppData.section.d2.events.d4.exp.sd1 + " "
					+ AppData.section.d2.events.d4.exp.sd2 + " "
					+ AppData.section.d2.events.d4.exp.sd3 + " "
					+ AppData.section.d2.events.d4.exp.sd4 + " "
					+ AppData.section.d2.events.d4.exp.sd5 + @";
					d2-event-d5-cdn: " + AppData.section.d2.events.d5.cdn.sd1 + " "
					+ AppData.section.d2.events.d5.cdn.sd2 + " "
					+ AppData.section.d2.events.d5.cdn.sd3 + " "
					+ AppData.section.d2.events.d5.cdn.sd4 + " "
					+ AppData.section.d2.events.d5.cdn.sd5 + @";
					d2-event-d5-exp: " + AppData.section.d2.events.d5.exp.sd1 + " "
					+ AppData.section.d2.events.d5.exp.sd2 + " "
					+ AppData.section.d2.events.d5.exp.sd3 + " "
					+ AppData.section.d2.events.d5.exp.sd4 + " "
					+ AppData.section.d2.events.d5.exp.sd5 + @";
					d2-event-d6-cdn: " + AppData.section.d2.events.d6.cdn.sd1 + " "
					+ AppData.section.d2.events.d6.cdn.sd2 + " "
					+ AppData.section.d2.events.d6.cdn.sd3 + " "
					+ AppData.section.d2.events.d6.cdn.sd4 + " "
					+ AppData.section.d2.events.d6.cdn.sd5 + @";
					d2-event-d6-exp: " + AppData.section.d2.events.d6.exp.sd1 + " "
					+ AppData.section.d2.events.d6.exp.sd2 + " "
					+ AppData.section.d2.events.d6.exp.sd3 + " "
					+ AppData.section.d2.events.d6.exp.sd4 + " "
					+ AppData.section.d2.events.d6.exp.sd5 + @";
					d2-event-d7-cdn: " + AppData.section.d2.events.d7.cdn.sd1 + " "
					+ AppData.section.d2.events.d7.cdn.sd2 + " "
					+ AppData.section.d2.events.d7.cdn.sd3 + " "
					+ AppData.section.d2.events.d7.cdn.sd4 + " "
					+ AppData.section.d2.events.d7.cdn.sd5 + @";
					d2-event-d7-exp: " + AppData.section.d2.events.d7.exp.sd1 + " "
					+ AppData.section.d2.events.d7.exp.sd2 + " "
					+ AppData.section.d2.events.d7.exp.sd3 + " "
					+ AppData.section.d2.events.d7.exp.sd4 + " "
					+ AppData.section.d2.events.d7.exp.sd5 + @";
					d2-event-d8-cdn: " + AppData.section.d2.events.d8.cdn.sd1 + " "
					+ AppData.section.d2.events.d8.cdn.sd2 + " "
					+ AppData.section.d2.events.d8.cdn.sd3 + " "
					+ AppData.section.d2.events.d8.cdn.sd4 + " "
					+ AppData.section.d2.events.d8.cdn.sd5 + @";
					d2-event-d8-exp: " + AppData.section.d2.events.d8.exp.sd1 + " "
					+ AppData.section.d2.events.d8.exp.sd2 + " "
					+ AppData.section.d2.events.d8.exp.sd3 + " "
					+ AppData.section.d2.events.d8.exp.sd4 + " "
					+ AppData.section.d2.events.d8.exp.sd5 + @";
					d2-event-d9-cdn: " + AppData.section.d2.events.d9.cdn.sd1 + " "
					+ AppData.section.d2.events.d9.cdn.sd2 + " "
					+ AppData.section.d2.events.d9.cdn.sd3 + " "
					+ AppData.section.d2.events.d9.cdn.sd4 + " "
					+ AppData.section.d2.events.d9.cdn.sd5 + @";
					d2-event-d9-exp: " + AppData.section.d2.events.d9.exp.sd1 + " "
					+ AppData.section.d2.events.d9.exp.sd2 + " "
					+ AppData.section.d2.events.d9.exp.sd3 + " "
					+ AppData.section.d2.events.d9.exp.sd4 + " "
					+ AppData.section.d2.events.d9.exp.sd5 + @";
					d2-event-d10-exp: " + AppData.section.d2.events.d9.exp.sd1 + " "
					+ AppData.section.d2.events.d9.exp.sd2 + " "
					+ AppData.section.d2.events.d9.exp.sd3 + " "
					+ AppData.section.d2.events.d9.exp.sd4 + " "
					+ AppData.section.d2.events.d9.exp.sd5 + @";
					d2-width: " + AppData.section.d2.width + @";
					d2-height: " + AppData.section.d2.height + @";
					d2-value: " + d2value + @";
					d2-x: " + AppData.section.d2.x + @";
					d2-y: " + AppData.section.d2.y + @";
					d2-transparency: " + AppData.section.d2.transparency + @";
					d2-visible: " + AppData.section.d2.visible +
					@"d3-type: " + AppData.section.d3.type + @";
					d3-event-d3-cdn: " + AppData.section.d3.events.d3.cdn.sd1 + " "
					+ AppData.section.d3.events.d3.cdn.sd2 + " "
					+ AppData.section.d3.events.d3.cdn.sd3 + " "
					+ AppData.section.d3.events.d3.cdn.sd4 + " "
					+ AppData.section.d3.events.d3.cdn.sd5 + @";
					d3-event-d3-exp: " + AppData.section.d3.events.d3.exp.sd1 + " "
					+ AppData.section.d3.events.d3.exp.sd2 + " "
					+ AppData.section.d3.events.d3.exp.sd3 + " "
					+ AppData.section.d3.events.d3.exp.sd4 + " "
					+ AppData.section.d3.events.d3.exp.sd5 + @";
					d3-event-d2-cdn: " + AppData.section.d3.events.d2.cdn.sd1 + " "
					+ AppData.section.d3.events.d2.cdn.sd2 + " "
					+ AppData.section.d3.events.d2.cdn.sd3 + " "
					+ AppData.section.d3.events.d2.cdn.sd4 + " "
					+ AppData.section.d3.events.d2.cdn.sd5 + @";
					d3-event-d2-exp: " + AppData.section.d3.events.d2.exp.sd1 + " "
					+ AppData.section.d3.events.d2.exp.sd2 + " "
					+ AppData.section.d3.events.d2.exp.sd3 + " "
					+ AppData.section.d3.events.d2.exp.sd4 + " "
					+ AppData.section.d3.events.d2.exp.sd5 + @";
					d3-event-d3-cdn: " + AppData.section.d3.events.d3.cdn.sd1 + " "
					+ AppData.section.d3.events.d3.cdn.sd2 + " "
					+ AppData.section.d3.events.d3.cdn.sd3 + " "
					+ AppData.section.d3.events.d3.cdn.sd4 + " "
					+ AppData.section.d3.events.d3.cdn.sd5 + @";
					d3-event-d3-exp: " + AppData.section.d3.events.d3.exp.sd1 + " "
					+ AppData.section.d3.events.d3.exp.sd2 + " "
					+ AppData.section.d3.events.d3.exp.sd3 + " "
					+ AppData.section.d3.events.d3.exp.sd4 + " "
					+ AppData.section.d3.events.d3.exp.sd5 + @";
					d3-event-d4-cdn: " + AppData.section.d3.events.d4.cdn.sd1 + " "
					+ AppData.section.d3.events.d4.cdn.sd2 + " "
					+ AppData.section.d3.events.d4.cdn.sd3 + " "
					+ AppData.section.d3.events.d4.cdn.sd4 + " "
					+ AppData.section.d3.events.d4.cdn.sd5 + @";
					d3-event-d4-exp: " + AppData.section.d3.events.d4.exp.sd1 + " "
					+ AppData.section.d3.events.d4.exp.sd2 + " "
					+ AppData.section.d3.events.d4.exp.sd3 + " "
					+ AppData.section.d3.events.d4.exp.sd4 + " "
					+ AppData.section.d3.events.d4.exp.sd5 + @";
					d3-event-d5-cdn: " + AppData.section.d3.events.d5.cdn.sd1 + " "
					+ AppData.section.d3.events.d5.cdn.sd2 + " "
					+ AppData.section.d3.events.d5.cdn.sd3 + " "
					+ AppData.section.d3.events.d5.cdn.sd4 + " "
					+ AppData.section.d3.events.d5.cdn.sd5 + @";
					d3-event-d5-exp: " + AppData.section.d3.events.d5.exp.sd1 + " "
					+ AppData.section.d3.events.d5.exp.sd2 + " "
					+ AppData.section.d3.events.d5.exp.sd3 + " "
					+ AppData.section.d3.events.d5.exp.sd4 + " "
					+ AppData.section.d3.events.d5.exp.sd5 + @";
					d3-event-d6-cdn: " + AppData.section.d3.events.d6.cdn.sd1 + " "
					+ AppData.section.d3.events.d6.cdn.sd2 + " "
					+ AppData.section.d3.events.d6.cdn.sd3 + " "
					+ AppData.section.d3.events.d6.cdn.sd4 + " "
					+ AppData.section.d3.events.d6.cdn.sd5 + @";
					d3-event-d6-exp: " + AppData.section.d3.events.d6.exp.sd1 + " "
					+ AppData.section.d3.events.d6.exp.sd2 + " "
					+ AppData.section.d3.events.d6.exp.sd3 + " "
					+ AppData.section.d3.events.d6.exp.sd4 + " "
					+ AppData.section.d3.events.d6.exp.sd5 + @";
					d3-event-d7-cdn: " + AppData.section.d3.events.d7.cdn.sd1 + " "
					+ AppData.section.d3.events.d7.cdn.sd2 + " "
					+ AppData.section.d3.events.d7.cdn.sd3 + " "
					+ AppData.section.d3.events.d7.cdn.sd4 + " "
					+ AppData.section.d3.events.d7.cdn.sd5 + @";
					d3-event-d7-exp: " + AppData.section.d3.events.d7.exp.sd1 + " "
					+ AppData.section.d3.events.d7.exp.sd2 + " "
					+ AppData.section.d3.events.d7.exp.sd3 + " "
					+ AppData.section.d3.events.d7.exp.sd4 + " "
					+ AppData.section.d3.events.d7.exp.sd5 + @";
					d3-event-d8-cdn: " + AppData.section.d3.events.d8.cdn.sd1 + " "
					+ AppData.section.d3.events.d8.cdn.sd2 + " "
					+ AppData.section.d3.events.d8.cdn.sd3 + " "
					+ AppData.section.d3.events.d8.cdn.sd4 + " "
					+ AppData.section.d3.events.d8.cdn.sd5 + @";
					d3-event-d8-exp: " + AppData.section.d3.events.d8.exp.sd1 + " "
					+ AppData.section.d3.events.d8.exp.sd2 + " "
					+ AppData.section.d3.events.d8.exp.sd3 + " "
					+ AppData.section.d3.events.d8.exp.sd4 + " "
					+ AppData.section.d3.events.d8.exp.sd5 + @";
					d3-event-d9-cdn: " + AppData.section.d3.events.d9.cdn.sd1 + " "
					+ AppData.section.d3.events.d9.cdn.sd2 + " "
					+ AppData.section.d3.events.d9.cdn.sd3 + " "
					+ AppData.section.d3.events.d9.cdn.sd4 + " "
					+ AppData.section.d3.events.d9.cdn.sd5 + @";
					d3-event-d9-exp: " + AppData.section.d3.events.d9.exp.sd1 + " "
					+ AppData.section.d3.events.d9.exp.sd2 + " "
					+ AppData.section.d3.events.d9.exp.sd3 + " "
					+ AppData.section.d3.events.d9.exp.sd4 + " "
					+ AppData.section.d3.events.d9.exp.sd5 + @";
					d3-event-d10-exp: " + AppData.section.d3.events.d9.exp.sd1 + " "
					+ AppData.section.d3.events.d9.exp.sd2 + " "
					+ AppData.section.d3.events.d9.exp.sd3 + " "
					+ AppData.section.d3.events.d9.exp.sd4 + " "
					+ AppData.section.d3.events.d9.exp.sd5 + @";
					d3-width: " + AppData.section.d3.width + @";
					d3-height: " + AppData.section.d3.height + @";
					d3-value: " + d3value + @";
					d3-x: " + AppData.section.d3.x + @";
					d3-y: " + AppData.section.d3.y + @";
					d3-transparency: " + AppData.section.d3.transparency + @";
					d3-visible: " + AppData.section.d3.visible +
					@"d4-type: " + AppData.section.d4.type + @";
					d4-event-d4-cdn: " + AppData.section.d4.events.d4.cdn.sd1 + " "
					+ AppData.section.d4.events.d4.cdn.sd2 + " "
					+ AppData.section.d4.events.d4.cdn.sd3 + " "
					+ AppData.section.d4.events.d4.cdn.sd4 + " "
					+ AppData.section.d4.events.d4.cdn.sd5 + @";
					d4-event-d4-exp: " + AppData.section.d4.events.d4.exp.sd1 + " "
					+ AppData.section.d4.events.d4.exp.sd2 + " "
					+ AppData.section.d4.events.d4.exp.sd3 + " "
					+ AppData.section.d4.events.d4.exp.sd4 + " "
					+ AppData.section.d4.events.d4.exp.sd5 + @";
					d4-event-d2-cdn: " + AppData.section.d4.events.d2.cdn.sd1 + " "
					+ AppData.section.d4.events.d2.cdn.sd2 + " "
					+ AppData.section.d4.events.d2.cdn.sd3 + " "
					+ AppData.section.d4.events.d2.cdn.sd4 + " "
					+ AppData.section.d4.events.d2.cdn.sd5 + @";
					d4-event-d2-exp: " + AppData.section.d4.events.d2.exp.sd1 + " "
					+ AppData.section.d4.events.d2.exp.sd2 + " "
					+ AppData.section.d4.events.d2.exp.sd3 + " "
					+ AppData.section.d4.events.d2.exp.sd4 + " "
					+ AppData.section.d4.events.d2.exp.sd5 + @";
					d4-event-d3-cdn: " + AppData.section.d4.events.d3.cdn.sd1 + " "
					+ AppData.section.d4.events.d3.cdn.sd2 + " "
					+ AppData.section.d4.events.d3.cdn.sd3 + " "
					+ AppData.section.d4.events.d3.cdn.sd4 + " "
					+ AppData.section.d4.events.d3.cdn.sd5 + @";
					d4-event-d3-exp: " + AppData.section.d4.events.d3.exp.sd1 + " "
					+ AppData.section.d4.events.d3.exp.sd2 + " "
					+ AppData.section.d4.events.d3.exp.sd3 + " "
					+ AppData.section.d4.events.d3.exp.sd4 + " "
					+ AppData.section.d4.events.d3.exp.sd5 + @";
					d4-event-d4-cdn: " + AppData.section.d4.events.d4.cdn.sd1 + " "
					+ AppData.section.d4.events.d4.cdn.sd2 + " "
					+ AppData.section.d4.events.d4.cdn.sd3 + " "
					+ AppData.section.d4.events.d4.cdn.sd4 + " "
					+ AppData.section.d4.events.d4.cdn.sd5 + @";
					d4-event-d4-exp: " + AppData.section.d4.events.d4.exp.sd1 + " "
					+ AppData.section.d4.events.d4.exp.sd2 + " "
					+ AppData.section.d4.events.d4.exp.sd3 + " "
					+ AppData.section.d4.events.d4.exp.sd4 + " "
					+ AppData.section.d4.events.d4.exp.sd5 + @";
					d4-event-d5-cdn: " + AppData.section.d4.events.d5.cdn.sd1 + " "
					+ AppData.section.d4.events.d5.cdn.sd2 + " "
					+ AppData.section.d4.events.d5.cdn.sd3 + " "
					+ AppData.section.d4.events.d5.cdn.sd4 + " "
					+ AppData.section.d4.events.d5.cdn.sd5 + @";
					d4-event-d5-exp: " + AppData.section.d4.events.d5.exp.sd1 + " "
					+ AppData.section.d4.events.d5.exp.sd2 + " "
					+ AppData.section.d4.events.d5.exp.sd3 + " "
					+ AppData.section.d4.events.d5.exp.sd4 + " "
					+ AppData.section.d4.events.d5.exp.sd5 + @";
					d4-event-d6-cdn: " + AppData.section.d4.events.d6.cdn.sd1 + " "
					+ AppData.section.d4.events.d6.cdn.sd2 + " "
					+ AppData.section.d4.events.d6.cdn.sd3 + " "
					+ AppData.section.d4.events.d6.cdn.sd4 + " "
					+ AppData.section.d4.events.d6.cdn.sd5 + @";
					d4-event-d6-exp: " + AppData.section.d4.events.d6.exp.sd1 + " "
					+ AppData.section.d4.events.d6.exp.sd2 + " "
					+ AppData.section.d4.events.d6.exp.sd3 + " "
					+ AppData.section.d4.events.d6.exp.sd4 + " "
					+ AppData.section.d4.events.d6.exp.sd5 + @";
					d4-event-d7-cdn: " + AppData.section.d4.events.d7.cdn.sd1 + " "
					+ AppData.section.d4.events.d7.cdn.sd2 + " "
					+ AppData.section.d4.events.d7.cdn.sd3 + " "
					+ AppData.section.d4.events.d7.cdn.sd4 + " "
					+ AppData.section.d4.events.d7.cdn.sd5 + @";
					d4-event-d7-exp: " + AppData.section.d4.events.d7.exp.sd1 + " "
					+ AppData.section.d4.events.d7.exp.sd2 + " "
					+ AppData.section.d4.events.d7.exp.sd3 + " "
					+ AppData.section.d4.events.d7.exp.sd4 + " "
					+ AppData.section.d4.events.d7.exp.sd5 + @";
					d4-event-d8-cdn: " + AppData.section.d4.events.d8.cdn.sd1 + " "
					+ AppData.section.d4.events.d8.cdn.sd2 + " "
					+ AppData.section.d4.events.d8.cdn.sd3 + " "
					+ AppData.section.d4.events.d8.cdn.sd4 + " "
					+ AppData.section.d4.events.d8.cdn.sd5 + @";
					d4-event-d8-exp: " + AppData.section.d4.events.d8.exp.sd1 + " "
					+ AppData.section.d4.events.d8.exp.sd2 + " "
					+ AppData.section.d4.events.d8.exp.sd3 + " "
					+ AppData.section.d4.events.d8.exp.sd4 + " "
					+ AppData.section.d4.events.d8.exp.sd5 + @";
					d4-event-d9-cdn: " + AppData.section.d4.events.d9.cdn.sd1 + " "
					+ AppData.section.d4.events.d9.cdn.sd2 + " "
					+ AppData.section.d4.events.d9.cdn.sd3 + " "
					+ AppData.section.d4.events.d9.cdn.sd4 + " "
					+ AppData.section.d4.events.d9.cdn.sd5 + @";
					d4-event-d9-exp: " + AppData.section.d4.events.d9.exp.sd1 + " "
					+ AppData.section.d4.events.d9.exp.sd2 + " "
					+ AppData.section.d4.events.d9.exp.sd3 + " "
					+ AppData.section.d4.events.d9.exp.sd4 + " "
					+ AppData.section.d4.events.d9.exp.sd5 + @";
					d4-event-d10-exp: " + AppData.section.d4.events.d9.exp.sd1 + " "
					+ AppData.section.d4.events.d9.exp.sd2 + " "
					+ AppData.section.d4.events.d9.exp.sd3 + " "
					+ AppData.section.d4.events.d9.exp.sd4 + " "
					+ AppData.section.d4.events.d9.exp.sd5 + @";
					d4-width: " + AppData.section.d4.width + @";
					d4-height: " + AppData.section.d4.height + @";
					d4-value: " + d4value + @";
					d4-x: " + AppData.section.d4.x + @";
					d4-y: " + AppData.section.d4.y + @";
					d4-transparency: " + AppData.section.d4.transparency + @";
					d4-visible: " + AppData.section.d4.visible +
					@"d5-type: " + AppData.section.d5.type + @";
					d5-event-d5-cdn: " + AppData.section.d5.events.d5.cdn.sd1 + " "
					+ AppData.section.d5.events.d5.cdn.sd2 + " "
					+ AppData.section.d5.events.d5.cdn.sd3 + " "
					+ AppData.section.d5.events.d5.cdn.sd4 + " "
					+ AppData.section.d5.events.d5.cdn.sd5 + @";
					d5-event-d5-exp: " + AppData.section.d5.events.d5.exp.sd1 + " "
					+ AppData.section.d5.events.d5.exp.sd2 + " "
					+ AppData.section.d5.events.d5.exp.sd3 + " "
					+ AppData.section.d5.events.d5.exp.sd4 + " "
					+ AppData.section.d5.events.d5.exp.sd5 + @";
					d5-event-d2-cdn: " + AppData.section.d5.events.d2.cdn.sd1 + " "
					+ AppData.section.d5.events.d2.cdn.sd2 + " "
					+ AppData.section.d5.events.d2.cdn.sd3 + " "
					+ AppData.section.d5.events.d2.cdn.sd4 + " "
					+ AppData.section.d5.events.d2.cdn.sd5 + @";
					d5-event-d2-exp: " + AppData.section.d5.events.d2.exp.sd1 + " "
					+ AppData.section.d5.events.d2.exp.sd2 + " "
					+ AppData.section.d5.events.d2.exp.sd3 + " "
					+ AppData.section.d5.events.d2.exp.sd4 + " "
					+ AppData.section.d5.events.d2.exp.sd5 + @";
					d5-event-d3-cdn: " + AppData.section.d5.events.d3.cdn.sd1 + " "
					+ AppData.section.d5.events.d3.cdn.sd2 + " "
					+ AppData.section.d5.events.d3.cdn.sd3 + " "
					+ AppData.section.d5.events.d3.cdn.sd4 + " "
					+ AppData.section.d5.events.d3.cdn.sd5 + @";
					d5-event-d3-exp: " + AppData.section.d5.events.d3.exp.sd1 + " "
					+ AppData.section.d5.events.d3.exp.sd2 + " "
					+ AppData.section.d5.events.d3.exp.sd3 + " "
					+ AppData.section.d5.events.d3.exp.sd4 + " "
					+ AppData.section.d5.events.d3.exp.sd5 + @";
					d5-event-d4-cdn: " + AppData.section.d5.events.d4.cdn.sd1 + " "
					+ AppData.section.d5.events.d4.cdn.sd2 + " "
					+ AppData.section.d5.events.d4.cdn.sd3 + " "
					+ AppData.section.d5.events.d4.cdn.sd4 + " "
					+ AppData.section.d5.events.d4.cdn.sd5 + @";
					d5-event-d4-exp: " + AppData.section.d5.events.d4.exp.sd1 + " "
					+ AppData.section.d5.events.d4.exp.sd2 + " "
					+ AppData.section.d5.events.d4.exp.sd3 + " "
					+ AppData.section.d5.events.d4.exp.sd4 + " "
					+ AppData.section.d5.events.d4.exp.sd5 + @";
					d5-event-d5-cdn: " + AppData.section.d5.events.d5.cdn.sd1 + " "
					+ AppData.section.d5.events.d5.cdn.sd2 + " "
					+ AppData.section.d5.events.d5.cdn.sd3 + " "
					+ AppData.section.d5.events.d5.cdn.sd4 + " "
					+ AppData.section.d5.events.d5.cdn.sd5 + @";
					d5-event-d5-exp: " + AppData.section.d5.events.d5.exp.sd1 + " "
					+ AppData.section.d5.events.d5.exp.sd2 + " "
					+ AppData.section.d5.events.d5.exp.sd3 + " "
					+ AppData.section.d5.events.d5.exp.sd4 + " "
					+ AppData.section.d5.events.d5.exp.sd5 + @";
					d5-event-d6-cdn: " + AppData.section.d5.events.d6.cdn.sd1 + " "
					+ AppData.section.d5.events.d6.cdn.sd2 + " "
					+ AppData.section.d5.events.d6.cdn.sd3 + " "
					+ AppData.section.d5.events.d6.cdn.sd4 + " "
					+ AppData.section.d5.events.d6.cdn.sd5 + @";
					d5-event-d6-exp: " + AppData.section.d5.events.d6.exp.sd1 + " "
					+ AppData.section.d5.events.d6.exp.sd2 + " "
					+ AppData.section.d5.events.d6.exp.sd3 + " "
					+ AppData.section.d5.events.d6.exp.sd4 + " "
					+ AppData.section.d5.events.d6.exp.sd5 + @";
					d5-event-d7-cdn: " + AppData.section.d5.events.d7.cdn.sd1 + " "
					+ AppData.section.d5.events.d7.cdn.sd2 + " "
					+ AppData.section.d5.events.d7.cdn.sd3 + " "
					+ AppData.section.d5.events.d7.cdn.sd4 + " "
					+ AppData.section.d5.events.d7.cdn.sd5 + @";
					d5-event-d7-exp: " + AppData.section.d5.events.d7.exp.sd1 + " "
					+ AppData.section.d5.events.d7.exp.sd2 + " "
					+ AppData.section.d5.events.d7.exp.sd3 + " "
					+ AppData.section.d5.events.d7.exp.sd4 + " "
					+ AppData.section.d5.events.d7.exp.sd5 + @";
					d5-event-d8-cdn: " + AppData.section.d5.events.d8.cdn.sd1 + " "
					+ AppData.section.d5.events.d8.cdn.sd2 + " "
					+ AppData.section.d5.events.d8.cdn.sd3 + " "
					+ AppData.section.d5.events.d8.cdn.sd4 + " "
					+ AppData.section.d5.events.d8.cdn.sd5 + @";
					d5-event-d8-exp: " + AppData.section.d5.events.d8.exp.sd1 + " "
					+ AppData.section.d5.events.d8.exp.sd2 + " "
					+ AppData.section.d5.events.d8.exp.sd3 + " "
					+ AppData.section.d5.events.d8.exp.sd4 + " "
					+ AppData.section.d5.events.d8.exp.sd5 + @";
					d5-event-d9-cdn: " + AppData.section.d5.events.d9.cdn.sd1 + " "
					+ AppData.section.d5.events.d9.cdn.sd2 + " "
					+ AppData.section.d5.events.d9.cdn.sd3 + " "
					+ AppData.section.d5.events.d9.cdn.sd4 + " "
					+ AppData.section.d5.events.d9.cdn.sd5 + @";
					d5-event-d9-exp: " + AppData.section.d5.events.d9.exp.sd1 + " "
					+ AppData.section.d5.events.d9.exp.sd2 + " "
					+ AppData.section.d5.events.d9.exp.sd3 + " "
					+ AppData.section.d5.events.d9.exp.sd4 + " "
					+ AppData.section.d5.events.d9.exp.sd5 + @";
					d5-event-d10-exp: " + AppData.section.d5.events.d9.exp.sd1 + " "
					+ AppData.section.d5.events.d9.exp.sd2 + " "
					+ AppData.section.d5.events.d9.exp.sd3 + " "
					+ AppData.section.d5.events.d9.exp.sd4 + " "
					+ AppData.section.d5.events.d9.exp.sd5 + @";
					d5-width: " + AppData.section.d5.width + @";
					d5-height: " + AppData.section.d5.height + @";
					d5-value: " + d1value + @";
					d5-x: " + AppData.section.d5.x + @";
					d5-y: " + AppData.section.d5.y + @";
					d5-transparency: " + AppData.section.d5.transparency + @";
					d5-visible: " + AppData.section.d1.visible
				);
			}
		};*/
		Button opn = new Button();
		opn.Size = new Size(64,32);
		opn.Location = new Point(save.Location.X + 64,0);
		opn.Font = bfont;
		opn.Text = "Compile";
		opn.TabStop = false;
		opn.Click += (sender,args) =>
		{
			/*using (FileStream fs = File.Open("",FileMode.Open,FileAccess.Read,FileShare.None))
			{
				Console.WriteLine(fs.Read());
			}*/
		};
		Button hlp = new Button();
		hlp.Size = new Size(64,32);
		hlp.Location = new Point(128,0);
		hlp.Font = bfont;
		hlp.Text = "Help";
		hlp.TabStop = false;
		hlp.Click += (sender,args) =>
		{
			Process.Start("hlp.cmd");
		};
		Button std = new Button();
		std.Size = new Size(64,32);
		std.Location = new Point(160,0);
		std.Font = bfont;
		std.TabStop = false;
		std.Click += (sender,args) =>
		{
			//
		};
		Form tbr = new Form();
		tbr.Size = new Size(352,80);
		tbr.MinimizeBox = false;
		tbr.MaximizeBox = false;
		tbr.MinimumSize = new Size(352,80);
		tbr.MaximumSize = new Size(352,80);
		tbr.Text = "Vertex 1.5 Toolbar";
		tbr.Icon = new Icon("icon.ico");
		int data = 0;
		Button atv = new Button();
		atv.Size = new Size(64,40);
		atv.Location = new Point(0,0);
		atv.Font = bfont;
		//atv.Text = "Active";
		atv.Image = Image.FromFile(@"assets\active.png");
		atv.TabStop = false;
		atv.Click += (sender,args) =>
		{
			if (data < 10)
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d1 = obj;
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d2 = obj;
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d3 = obj;
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d4 = obj;
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d5 = obj;
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d6 = obj;
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d7 = obj;
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d8 = obj;
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d9 = obj;
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Active";
					PictureBox obj = new PictureBox();
					obj.Size = new Size(32,32);
					obj.Location = new Point(0,0);
					obj.ImageLocation = @"assets\active.png";
					prv.Controls.Add(obj);
					actives.d10 = obj;
				}
			}
			else
			{
				MessageBox.Show("Cannot Add More Object");
			}
		};
		Button str = new Button();
		str.Size = new Size(64,40);
		str.Location = new Point(atv.Location.X + 64,0);
		str.Font = bfont;
		//str.Text = "String";
		str.Image = Image.FromFile(@"assets\string.png");
		str.TabStop = false;
		str.Click += (sender,args) =>
		{
			if (data < 10)
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d1";
					prv.Controls.Add(obj);
					strings.d1 = obj;
				}
				if (data == 2)
				{
					AppData.section.d2.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d2";
					prv.Controls.Add(obj);
					strings.d2 = obj;
				}
				if (data == 3)
				{
					AppData.section.d3.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d3";
					prv.Controls.Add(obj);
					strings.d3 = obj;
				}
				if (data == 4)
				{
					AppData.section.d4.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d4";
					prv.Controls.Add(obj);
					strings.d4 = obj;
				}
				if (data == 5)
				{
					AppData.section.d5.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d5";
					prv.Controls.Add(obj);
					strings.d5 = obj;
				}
				if (data == 6)
				{
					AppData.section.d6.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d6";
					prv.Controls.Add(obj);
					strings.d6 = obj;
				}
				if (data == 7)
				{
					AppData.section.d7.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d7";
					prv.Controls.Add(obj);
					strings.d7 = obj;
				}
				if (data == 8)
				{
					AppData.section.d8.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d8";
					prv.Controls.Add(obj);
					strings.d8 = obj;
				}
				if (data == 9)
				{
					AppData.section.d9.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d9";
					prv.Controls.Add(obj);
					strings.d9 = obj;
				}
				if (data == 10)
				{
					AppData.section.d10.type = "String";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d10";
					prv.Controls.Add(obj);
					strings.d10 = obj;
				}
			}
			else
			{
				MessageBox.Show("Cannot Add More Object");
			}
		};
		Button ctr = new Button();
		ctr.Size = new Size(64,40);
		ctr.Location = new Point(str.Location.X + 64,0);
		ctr.Font = bfont;
		//ctr.Text = "Counter";
		ctr.Image = Image.FromFile(@"assets\counter.png");
		ctr.TabStop = false;
		ctr.Click += (sender,args) =>
		{
			if (data < 10)
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "1";
					prv.Controls.Add(obj);
					counters.d1 = obj;
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "2";
					prv.Controls.Add(obj);
					counters.d2 = obj;
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "3";
					prv.Controls.Add(obj);
					counters.d3 = obj;
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "4";
					prv.Controls.Add(obj);
					counters.d4 = obj;
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "5";
					prv.Controls.Add(obj);
					counters.d5 = obj;
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "6";
					prv.Controls.Add(obj);
					counters.d6 = obj;
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "7";
					prv.Controls.Add(obj);
					counters.d7 = obj;
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "8";
					prv.Controls.Add(obj);
					counters.d8 = obj;
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "9";
					prv.Controls.Add(obj);
					counters.d9 = obj;
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Counter";
					Label obj = new Label();
					obj.Size = new Size(64,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "10";
					prv.Controls.Add(obj);
					counters.d10 = obj;
				}
			}
			else
			{
				MessageBox.Show("Cannot Add More Object");
			}
		};
		Button btn = new Button();
		btn.Size = new Size(64,40);
		btn.Location = new Point(ctr.Location.X + 64,0);
		btn.Font = bfont;
		//btn.Text = "Button";
		btn.Image = Image.FromFile(@"assets\button.png");
		btn.TabStop = false;
		btn.Click += (sender,args) =>
		{
			if (data < 10) 
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d1";
					prv.Controls.Add(obj);
					buttons.d1 = obj;
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d2";
					prv.Controls.Add(obj);
					buttons.d2 = obj;
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d3";
					prv.Controls.Add(obj);
					buttons.d3 = obj;
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d4";
					prv.Controls.Add(obj);
					buttons.d4 = obj;
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d5";
					prv.Controls.Add(obj);
					buttons.d5 = obj;
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d6";
					prv.Controls.Add(obj);
					buttons.d6 = obj;
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d7";
					prv.Controls.Add(obj);
					buttons.d7 = obj;
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d8";
					prv.Controls.Add(obj);
					buttons.d8 = obj;
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d9";
					prv.Controls.Add(obj);
					buttons.d9 = obj;
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Button";
					Button obj = new Button();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d10";
					prv.Controls.Add(obj);
					buttons.d10 = obj;
				}
			}
			else
			{
				MessageBox.Show("Cannot Add More Object");
			}
		};
		Button edb = new Button();
		edb.Size = new Size(64,40);
		edb.Location = new Point(btn.Location.X + 64,0);
		edb.Font = bfont;
		//edb.Text = "Editbox";
		edb.Image = Image.FromFile(@"assets\editbox.png");
		edb.TabStop = false;
		edb.Click += (sender,args) =>
		{
			if (data < 10) 
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d1";
					prv.Controls.Add(obj);
					editboxes.d1 = obj;
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d2";
					prv.Controls.Add(obj);
					editboxes.d2 = obj;
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d3";
					prv.Controls.Add(obj);
					editboxes.d3 = obj;
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d4";
					prv.Controls.Add(obj);
					editboxes.d4 = obj;
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d5";
					prv.Controls.Add(obj);
					editboxes.d5 = obj;
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d6";
					prv.Controls.Add(obj);
					editboxes.d6 = obj;
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d7";
					prv.Controls.Add(obj);
					editboxes.d7 = obj;
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d8";
					prv.Controls.Add(obj);
					editboxes.d8 = obj;
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d9";
					prv.Controls.Add(obj);
					editboxes.d9 = obj;
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Editbox";
					TextBox obj = new TextBox();
					obj.Size = new Size(96,32);
					obj.Location = new Point(0,0);
					obj.Font = bfont;
					obj.Text = "d10";
					prv.Controls.Add(obj);
					editboxes.d10 = obj;
				}
			}
			else
			{
				MessageBox.Show("Cannot Add More Object");
			}
		};
		Form rtp = new Form();
		rtp.Size = new Size(256,320);
		rtp.MinimizeBox = false;
		rtp.MaximizeBox = false;
		rtp.MinimumSize = new Size(256,320);
		rtp.MaximumSize = new Size(256,320);
		rtp.Text = "Vertex 1.5 Runtime Properties";
		rtp.Icon = new Icon("icon.ico");
		Label bpn = new Label();
		bpn.Size = new Size(128,40);
		bpn.Location = new Point(0,0);
		bpn.Font = bfont;
		bpn.Text = "Name";
		TextBox nme = new TextBox();
		nme.Size = new Size(128,40);
		nme.Location = new Point(128,0);
		nme.Font = bfont;
		nme.Multiline = true;
		nme.TabStop = false;
		Label bpc = new Label();
		bpc.Size = new Size(128,40);
		bpc.Location = new Point(0,40);
		bpc.Font = bfont;
		bpc.Text = "BGColor";
		TextBox bgc = new TextBox();
		bgc.Size = new Size(128,40);
		bgc.Location = new Point(128,40);
		bgc.Font = bfont;
		bgc.Multiline = true;
		bgc.TabStop = false;
		Label bpr = new Label();
		bpr.Size = new Size(128,40);
		bpr.Location = new Point(0,80);
		bpr.Font = bfont;
		bpr.Text = "Runtime Controller";
		CheckBox rtc = new CheckBox();
		rtc.Size = new Size(128,40);
		rtc.Location = new Point(128,80);
		rtc.AutoCheck = true;
		rtc.TabStop = false;
		Button rta = new Button();
		rta.Size = new Size(256,40);
		rta.Location = new Point(0,120);
		rta.Font = bfont;
		rta.Text = "Append";
		rta.TabStop = false;
		rta.Click += (sender,args) =>
		{
			AppData.properties.name = nme.Text;
			AppData.properties.bgcolor = bgc.Text;
			AppData.properties.runtimeController = rtc.Checked;
			MessageBox.Show("Appended Properties");
		};
		Form ppt = new Form();
		ppt.Size = new Size(288,320);
		ppt.MinimizeBox = false;
		ppt.MaximizeBox = false;
		ppt.MinimumSize = new Size(288,640);
		ppt.MaximumSize = new Size(288,640);
		ppt.Text = "Vertex 1.5 Properties";
		ppt.Icon = new Icon("icon.ico");
		Label bwd = new Label();
		bwd.Size = new Size(128,32);
		bwd.Location = new Point(0,0);
		bwd.Font = bfont;
		bwd.Text = "Width";
		NumericUpDown wdt = new NumericUpDown();
		wdt.Size = new Size(128,32);
		wdt.Location = new Point(128,0);
		wdt.Font = bfont;
		wdt.TabStop = false;
		wdt.Minimum = 1;
		wdt.Maximum = 512;
		Label bhi = new Label();
		bhi.Size = new Size(128,32);
		bhi.Location = new Point(0,32);
		bhi.Font = bfont;
		bhi.Text = "Height";
		NumericUpDown hit = new NumericUpDown();
		hit.Size = new Size(128,32);
		hit.Location = new Point(128,32);
		hit.Font = bfont;
		hit.TabStop = false;
		hit.Minimum = 1;
		hit.Maximum = 512;
		Label bxp = new Label();
		bxp.Size = new Size(128,32);
		bxp.Location = new Point(0,64);
		bxp.Font = bfont;
		bxp.Text = "X Position";
		NumericUpDown  xps = new NumericUpDown();
		xps.Size = new Size(128,32);
		xps.Location = new Point(128,64);
		xps.Font = bfont;
		xps.TabStop = false;
		xps.Minimum = 0;
		xps.Maximum = 512;
		Label byp = new Label();
		byp.Size = new Size(128,32);
		byp.Location = new Point(0,96);
		byp.Font = bfont;
		byp.Text = "Y Position";
		NumericUpDown  yps = new NumericUpDown();
		yps.Size = new Size(128,32);
		yps.Location = new Point(128,96);
		yps.Font = bfont;
		yps.TabStop = false;
		yps.Minimum = 0;
		yps.Maximum = 512;
		Label bnm = new Label();
		bnm.Size = new Size(128,32);
		bnm.Location = new Point(0,128);
		bnm.Font = bfont;
		bnm.Text = "Name";
		ComboBox nam = new ComboBox();
		nam.Size = new Size(128,32);
		nam.Location = new Point(128,128);
		nam.Font = bfont;
		nam.TabStop = false;
		nam.Items.AddRange(new object[]
		{
			"d1",
			"d2",
			"d3",
			"d4",
			"d5",
			"d6",
			"d7",
			"d8",
			"d9",
			"d10"
		});
		Button apd = new Button();
		apd.Size = new Size(256,32);
		apd.Location = new Point(0,160);
		apd.Font = bfont;
		apd.Text = "Append";
		apd.TabStop = false;
		apd.Click += (sender,args) =>
		{
			if (nam.Text == "d1")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d1 != null)
				{
					actives.d1.Size = sze;
					actives.d1.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d1 != null)
				{
					strings.d1.Size = sze;
					strings.d1.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d1 != null)
				{
					counters.d1.Size = sze;
					counters.d1.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d1 != null)
				{
					buttons.d1.Size = sze;
					buttons.d1.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d1 != null)
				{
					editboxes.d1.Size = sze;
					editboxes.d1.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d2")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d2 != null)
				{
					actives.d2.Size = sze;
					actives.d2.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d2 != null)
				{
					strings.d2.Size = sze;
					strings.d2.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d2 != null)
				{
					counters.d2.Size = sze;
					counters.d2.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d2 != null)
				{
					buttons.d2.Size = sze;
					buttons.d2.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d2 != null)
				{
					editboxes.d2.Size = sze;
					editboxes.d2.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d3")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d3 != null)
				{
					actives.d3.Size = sze;
					actives.d3.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d3 != null)
				{
					strings.d3.Size = sze;
					strings.d3.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d3 != null)
				{
					counters.d3.Size = sze;
					counters.d3.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d3 != null)
				{
					buttons.d3.Size = sze;
					buttons.d3.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d3 != null)
				{
					editboxes.d3.Size = sze;
					editboxes.d3.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d4")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d4 != null)
				{
					actives.d4.Size = sze;
					actives.d4.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d4 != null)
				{
					strings.d4.Size = sze;
					strings.d4.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d4 != null)
				{
					counters.d4.Size = sze;
					counters.d4.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d4 != null)
				{
					buttons.d4.Size = sze;
					buttons.d4.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d4 != null)
				{
					editboxes.d4.Size = sze;
					editboxes.d4.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d5")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d5 != null)
				{
					actives.d5.Size = sze;
					actives.d5.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d5 != null)
				{
					strings.d5.Size = sze;
					strings.d5.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d5 != null)
				{
					counters.d5.Size = sze;
					counters.d5.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d5 != null)
				{
					buttons.d5.Size = sze;
					buttons.d5.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d5 != null)
				{
					editboxes.d5.Size = sze;
					editboxes.d5.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d6")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d6 != null)
				{
					actives.d6.Size = sze;
					actives.d6.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d6 != null)
				{
					strings.d6.Size = sze;
					strings.d6.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d6 != null)
				{
					counters.d6.Size = sze;
					counters.d6.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d6 != null)
				{
					buttons.d6.Size = sze;
					buttons.d6.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d6 != null)
				{
					editboxes.d6.Size = sze;
					editboxes.d6.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d7")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d7 != null)
				{
					actives.d7.Size = sze;
					actives.d7.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d7 != null)
				{
					strings.d7.Size = sze;
					strings.d7.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d7 != null)
				{
					counters.d7.Size = sze;
					counters.d7.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d7 != null)
				{
					buttons.d7.Size = sze;
					buttons.d7.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d7 != null)
				{
					editboxes.d7.Size = sze;
					editboxes.d7.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d8")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d8 != null)
				{
					actives.d8.Size = sze;
					actives.d8.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d8 != null)
				{
					strings.d8.Size = sze;
					strings.d8.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d8 != null)
				{
					counters.d8.Size = sze;
					counters.d8.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d8 != null)
				{
					buttons.d8.Size = sze;
					buttons.d8.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d8 != null)
				{
					editboxes.d8.Size = sze;
					editboxes.d8.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d9")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d9 != null)
				{
					actives.d9.Size = sze;
					actives.d9.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d9 != null)
				{
					strings.d9.Size = sze;
					strings.d9.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d9 != null)
				{
					counters.d9.Size = sze;
					counters.d9.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d9 != null)
				{
					buttons.d9.Size = sze;
					buttons.d9.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d9 != null)
				{
					editboxes.d9.Size = sze;
					editboxes.d9.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
			if (nam.Text == "d1")
			{
				Point lct = new Point(Convert.ToInt32(xps.Value),Convert.ToInt32(yps.Value));
				Size sze = new Size(Convert.ToInt32(wdt.Value),Convert.ToInt32(hit.Value));
				if (actives.d10 != null)
				{
					actives.d10.Size = sze;
					actives.d10.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (strings.d10 != null)
				{
					strings.d10.Size = sze;
					strings.d10.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (counters.d10 != null)
				{
					counters.d10.Size = sze;
					counters.d10.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (buttons.d10 != null)
				{
					buttons.d10.Size = sze;
					buttons.d10.Location = lct;
					MessageBox.Show("Appended Properties");
				}
				if (editboxes.d10 != null)
				{
					editboxes.d10.Size = sze;
					editboxes.d10.Location = lct;
					MessageBox.Show("Appended Properties");
				}
			}
		};
		// functions
		//edt.Controls.Add(run);
		edt.Controls.Add(name);
		//edt.Controls.Add(save);
		edt.Controls.Add(opn);
		edt.Controls.Add(hlp);
		edt.Controls.Add(std);
		tbr.Controls.Add(atv);
		tbr.Controls.Add(str);
		tbr.Controls.Add(ctr);
		tbr.Controls.Add(btn);
		tbr.Controls.Add(edb);
		rtp.Controls.Add(bpn);
		rtp.Controls.Add(nme);
		rtp.Controls.Add(bpc);
		rtp.Controls.Add(bgc);
		rtp.Controls.Add(bpr);
		rtp.Controls.Add(rtc);
		ppt.Controls.Add(bwd);
		ppt.Controls.Add(wdt);
		ppt.Controls.Add(bhi);
		ppt.Controls.Add(hit);
		ppt.Controls.Add(bxp);
		ppt.Controls.Add(xps);
		ppt.Controls.Add(byp);
		ppt.Controls.Add(yps);
		ppt.Controls.Add(bnm);
		ppt.Controls.Add(nam);
		ppt.Controls.Add(apd);
		edt.Show();
		tbr.Show();
		rtp.Show();
		ppt.Show();
		prv.Show();
	}
	static public void InitializeComponent()
	{
		// adds
		IntPtr console = Process.GetCurrentProcess().MainWindowHandle;
		ShowWindow(console,0);
		Form vt = new Form();
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		vt.Size = new Size(256,288);
		vt.MinimizeBox = false;
		vt.MaximizeBox = false;
		vt.MinimumSize = new Size(256,288);
		vt.MaximumSize = new Size(256,288);
		vt.StartPosition = FormStartPosition.CenterScreen;
		vt.Text = "Vertex 1.5";
		vt.Icon = new Icon("icon.ico");
		Label main = new Label();
		main.Size = new Size(256,48);
		main.Location = new Point(0,0);
		main.Font = hfont;
		main.Text = "Vertex 1.5\nCPatch: 1.5.0";
		Button create = new Button();
		create.Size = new Size(175,32);
		create.Location = new Point(0,48);
		create.Font = bfont;
		create.Text = "Create Application";
		create.TabStop = false;
		Button open = new Button();
		open.Size = new Size(175,32);
		open.Location = new Point(0,create.Location.Y + 32);
		open.Font = bfont;
		open.Text = "Open Application";
		open.TabStop = false;
		Button examples = new Button();
		examples.Size = new Size(175,32);
		examples.Location = new Point(0,open.Location.Y + 32);
		//examples.Location = new Point(0,create.Location.Y + 32);
		examples.Font = bfont;
		examples.Text = "Open Examples";
		examples.TabStop = false;
		Button about = new Button();
		about.Size = new Size(175,32);
		about.Location = new Point(0,examples.Location.Y + 32);
		about.Font = bfont;
		about.Text = "Informations";
		about.TabStop = false;
		Button atv = new Button();
		atv.Size = new Size(175,32);
		atv.Location = new Point(0,about.Location.Y + 32);
		atv.Font = bfont;
		atv.Text = "Activate";
		atv.TabStop = false;
		// functions
		create.Click += (sender,args) =>
		{
			editor();
		};
		open.Click += (sender,args) =>
		{
			/*OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Open";*/
		};
		examples.Click += (sender,args) =>
		{
			preBuilt();
		};
		about.Click += (sender,args) =>
		{
			info();
		};
		atv.Click += (sender,args) =>
		{
			//activate();
		};
		vt.Controls.Add(main);
		vt.Controls.Add(create);
		vt.Controls.Add(open);
		vt.Controls.Add(examples);
		vt.Controls.Add(about);
		//vt.Controls.Add(atv);
		Application.Run(vt);
	}
	static public void Main(string[] args)
	{
		string csArg = "";
		if (args == null || args.Length == 0)
		{
			Console.Clear();
			Console.WriteLine("Vertex\nUsage: Vertex [options]\nOptions\n--v (Version)\n--l (License)\n--c (Credits)\n--r <file>.vta (Run)");
		}
		if (args != null || args.Length != 0)
		{
			try
			{
				foreach (var arg in args)
				{
					if (arg == "--r")
					{
						csArg = arg;
					}
					if (arg != null && csArg == "--r")
					{
						if (arg.EndsWith(".vta"))
						{
							Console.Clear();
							app(arg);
						}
					}
					if (arg == "--v")
					{
						Console.Clear();
						Console.WriteLine("Version 1.5.0");
					}
					if (arg == "--c")
					{
						Console.WriteLine("Credits\n- Ry (Programmer)\n- Dave (Artist)\n- Vice (Tester)");
					}
					if (arg == "--l")
					{
						Console.Clear();
						Console.WriteLine("Copyright 2025 Rise LLC\nPermission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:\nThe above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.\nTHE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.");
					}
				}
			}
			catch (System.Exception)
			{
				return;
			}
		}
	}
}
