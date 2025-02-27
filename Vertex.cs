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
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
class Vertex
{
	[DllImport("user32.dll")]
	static extern bool ShowWindow(IntPtr hWnd,int shw);
	public static string code;
	public class ActivationCodes
	{
		public static void validater(string scode)
		{
			if (scode == d1 || scode == d2 || scode == d3 || scode == d4 || scode == d5)
			{
				code = scode;
			}
			else if (scode == specials.sd1)
			{
				specials.validater(scode);
			}
			else
			{
				MessageBox.Show("Invalid Code");
			}
		}
		public static string d1 = "FVP4TU";
		public static string d2 = "E29TYH";
		public static string d3 = "UR380J";
		public static string d4 = "0MV2UU";
		public static string d5 = "J03UV5";
		public class specials
		{
			public static string sd1 = "CE25FB";
			public static int md1 = DateTime.Now.Year;
			public static void validater(string scode)
			{
				if (scode == "CE25FB")
				{
					if (md1 > 2024 && md1 < 2026)
					{
						code = scode;
					}
					else
					{
						MessageBox.Show("Invalid Code");
					}
				}
			}
		}
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
			public static bool database;
			public static bool date;
		}
		public class section
		{
			public class d1
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d2
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d3
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d4
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d5
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d6
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d7
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d8
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d9
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
			}
			public class d10
			{
				public static string type;
				public class Active
				{
					public static string name;
					public static Color color;
					public static Image image;
					public static Size size;
					public static Point location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Counter
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Size size;
					public static Point location;
					public static float number;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class String
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point location;
					public static string text;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class EditBox
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
					}
				}
				public class Button
				{
					public static string name;
					public static Color bgColor;
					public static Color color;
					public static Font font;
					public static Size size;
					public static Point Location;
					public static float transparency;
					public static bool visible;
					public static class events
					{
						public class d1
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d2
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d3
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d4
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d5
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d6
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d7
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d8
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d9
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
						public class d10
						{
							public class cdn
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
							public class exp
							{
								public static string sd1;
								public static string sd2;
								public static string sd3;
								public static string sd4;
								public static string sd5;
							}
						}
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
			//
		}
		static public void two()
		{
			//
		}
		static public void three()
		{
			//
		}
		static public void four()
		{
			//
		}
	}
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
		atv.Text = "Vertex 1.3 Activation";
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
	static public void compile()
	{
		if (code != null)
		{
			Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
			Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
			Form cpl = new Form();
			cpl.Size = new Size(512,512);
			cpl.MinimizeBox = false;
			cpl.MaximizeBox = false;
			cpl.MinimumSize = new Size(512,512);
			cpl.MaximumSize = new Size(512,512);
			cpl.Text = "Vertex 1.3 Compiled Application";
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
				rtm.Controls.Add(d1);";
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
				rtm.Controls.Add(d2);";
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
				rtm.Controls.Add(d3);";
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
				rtm.Controls.Add(d4);";
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
				rtm.Controls.Add(d5);";
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
				rtm.Controls.Add(d6);";
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
				rtm.Controls.Add(d7);";
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
				rtm.Controls.Add(d8);";
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
				rtm.Controls.Add(d9);";
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
				rtm.Controls.Add(d10);";
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
				rtm.Controls.Add(d1);";
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
				rtm.Controls.Add(d2);";
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
				rtm.Controls.Add(d3);";
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
				rtm.Controls.Add(d4);";
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
				rtm.Controls.Add(d5);";
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
				rtm.Controls.Add(d6);";
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
				rtm.Controls.Add(d7);";
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
				rtm.Controls.Add(d8);";
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
				rtm.Controls.Add(d9);";
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
				rtm.Controls.Add(d10);";
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
			rtm.Text = 'Vertex 1.3 Runtime';
			rtm.StartPosition = FormStartPosition.CenterScreen;"
			+ d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 +
			@"Application.Run(rtm);
			};";
			cpl.Controls.Add(result);
			cpl.Show();
		}
		else
		{
			MessageBox.Show("You didn't activated the software yet.");
		}
	}
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
		rtm.Text = "Vertex 1.3 Runtime";
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
		rtm.Show();
		if (AppData.properties.runtimeController)
		{
			rtc.Show();
		}
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
		pb.Text = "Vertex 1.3 Examples";
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
		two.Text = "#2";
		two.TabStop = false;
		two.Click += (sender,args) =>
		{
			Examples.two();
		};
		Button three = new Button();
		three.Size = new Size(256,32);
		three.Location = new Point(0,64);
		three.Font = bfont;
		three.Text = "#3";
		three.TabStop = false;
		three.Click += (sender,args) =>
		{
			Examples.three();
		};
		Button four = new Button();
		four.Size = new Size(256,32);
		four.Location = new Point(0,96);
		four.Font = bfont;
		four.Text = "#4";
		four.TabStop = false;
		four.Click += (sender,args) =>
		{
			Examples.four();
		};
		// functions
		pb.Controls.Add(one);
		pb.Controls.Add(two);
		pb.Controls.Add(three);
		pb.Controls.Add(four);
		pb.Show();
	}
	static public void info()
	{
		// adds
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		Form info = new Form();
		info.Size = new Size(320,640);
		info.MaximizeBox = false;
		info.MinimumSize = new Size(320,640);
		info.MaximumSize = new Size(320,640);
		info.Text = "Vertex 1.3 Informations";
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
		Vertex 1.3
		Amount Of Objects Available: 10
		Conditions In Each Object: 10;
		Amount Of Events In Each Object: 10
		Price: $20
		Vertex 2.0
		Amount Of Objects Available: 20
		Amount Of Events In Each Object: 10
		Price $25
		Vertex 3.0
		Amount Of Objects Available: 30
		Amount Of Events In Each Object: 10
		Price $30
		Q&A
		Q: Why is there no save button?
		A: Because Ry just learning the ropes.
		Q: Why isn't this open source?
		A: Because we don't have bank account for others to donate so we use itch.io to collect the money for me first
		Q: Why is it costs $15?
		A: Because of basic user interfaces ($5), runtime/compiler ($5) visual events editor ($1), runtime properties/runtime controller ($2) and properties/taskbar ($2).
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
		edt.Text = "Vertex 1.3 Taskbar";
		edt.Icon = new Icon("icon.ico");
		Button run = new Button();
		run.Size = new Size(48,16);
		run.Location = new Point(0,0);
		run.Font = bfont;
		run.Text = "Run";
		run.TabStop = false;
		run.Click += (sender,args) =>
		{
			runtime();
		};
		TextBox name = new TextBox();
		name.Size = new Size(208,16);
		name.Location = new Point(run.Location.X + 48);
		name.Font = bfont;
		name.Text = "Name";
		name.TabStop = false;
		Button save = new Button();
		save.Size = new Size(48,16);
		save.Location = new Point(name.Location.X + 80);
		save.Font = bfont;
		save.Text = "Save";
		save.TabStop = false;
		save.Click += (sender,args) =>
		{
			//
		};
		Button cpl = new Button();
		cpl.Size = new Size(64,16);
		//cpl.Location = new Point(save.Location.X + 48);
		cpl.Location = new Point(name.Location.X + 208);
		cpl.Font = bfont;
		cpl.Text = "Compile";
		cpl.TabStop = false;
		cpl.Click += (sender,args) =>
		{
			compile();
		};
		Form tbr = new Form();
		tbr.Size = new Size(352,80);
		tbr.MinimizeBox = false;
		tbr.MaximizeBox = false;
		tbr.MinimumSize = new Size(352,80);
		tbr.MaximumSize = new Size(352,80);
		tbr.Text = "Vertex 1.3 Toolbar";
		tbr.Icon = new Icon("icon.ico");
		int data = 0;
		Button atv = new Button();
		atv.Size = new Size(64,40);
		atv.Location = new Point(0,0);
		atv.Font = bfont;
		atv.Text = "Active";
		atv.TabStop = false;
		atv.Click += (sender,args) =>
		{
			if (data < 10) 
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Active";
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Active";
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Active";
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Active";
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Active";
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Active";
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Active";
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Active";
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Active";
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Active";
				}
			}
			else
			{
				MessageBox.Show("Cannot add more object");
			}
		};
		Button str = new Button();
		str.Size = new Size(64,40);
		str.Location = new Point(atv.Location.X + 64,0);
		str.Font = bfont;
		str.Text = "String";
		str.TabStop = false;
		str.Click += (sender,args) =>
		{
			if (data < 10) 
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "String";
				}
				if (data == 2)
				{
					AppData.section.d2.type = "String";
				}
				if (data == 3)
				{
					AppData.section.d3.type = "String";
				}
				if (data == 4)
				{
					AppData.section.d4.type = "String";
				}
				if (data == 5)
				{
					AppData.section.d5.type = "String";
				}
				if (data == 6)
				{
					AppData.section.d6.type = "String";
				}
				if (data == 7)
				{
					AppData.section.d7.type = "String";
				}
				if (data == 8)
				{
					AppData.section.d8.type = "String";
				}
				if (data == 9)
				{
					AppData.section.d9.type = "String";
				}
				if (data == 10)
				{
					AppData.section.d10.type = "String";
				}
			}
			else
			{
				MessageBox.Show("Cannot add more object");
			}
		};
		Button ctr = new Button();
		ctr.Size = new Size(64,40);
		ctr.Location = new Point(str.Location.X + 64,0);
		ctr.Font = bfont;
		ctr.Text = "Counter";
		ctr.TabStop = false;
		ctr.Click += (sender,args) =>
		{
			if (data < 10) 
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Counter";
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Counter";
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Counter";
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Counter";
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Counter";
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Counter";
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Counter";
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Counter";
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Counter";
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Counter";
				}
			}
			else
			{
				MessageBox.Show("Cannot add more object");
			}
		};
		Button btn = new Button();
		btn.Size = new Size(64,40);
		btn.Location = new Point(ctr.Location.X + 64,0);
		btn.Font = bfont;
		btn.Text = "Button";
		btn.TabStop = false;
		btn.Click += (sender,args) =>
		{
			if (data < 10) 
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Button";
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Button";
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Button";
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Button";
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Button";
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Button";
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Button";
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Button";
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Button";
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Button";
				}
			}
			else
			{
				MessageBox.Show("Cannot add more object");
			}
		};
		Button edb = new Button();
		edb.Size = new Size(64,40);
		edb.Location = new Point(btn.Location.X + 64,0);
		edb.Font = bfont;
		edb.Text = "Editbox";
		edb.TabStop = false;
		edb.Click += (sender,args) =>
		{
			if (data < 10) 
			{
				data++;
				if (data == 1)
				{
					AppData.section.d1.type = "Editbox";
				}
				if (data == 2)
				{
					AppData.section.d2.type = "Editbox";
				}
				if (data == 3)
				{
					AppData.section.d3.type = "Editbox";
				}
				if (data == 4)
				{
					AppData.section.d4.type = "Editbox";
				}
				if (data == 5)
				{
					AppData.section.d5.type = "Editbox";
				}
				if (data == 6)
				{
					AppData.section.d6.type = "Editbox";
				}
				if (data == 7)
				{
					AppData.section.d7.type = "Editbox";
				}
				if (data == 8)
				{
					AppData.section.d8.type = "Editbox";
				}
				if (data == 9)
				{
					AppData.section.d9.type = "Editbox";
				}
				if (data == 10)
				{
					AppData.section.d10.type = "Editbox";
				}
			}
			else
			{
				MessageBox.Show("Cannot add more object");
			}
		};
		Form rtp = new Form();
		rtp.Size = new Size(256,320);
		rtp.MinimizeBox = false;
		rtp.MaximizeBox = false;
		rtp.MinimumSize = new Size(256,320);
		rtp.MaximumSize = new Size(256,320);
		rtp.Text = "Vertex 1.3 Runtime Properties";
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
		rta.Size = new Size(256,240);
		rta.Location = new Point(0,120);
		rta.Font = bfont;
		rta.Text = "Append";
		rta.TabStop = false;
		rta.Click += (sender,args) =>
		{
			AppData.properties.name = nme.Text;
			AppData.properties.bgcolor = bgc.Text;
			AppData.properties.runtimeController = rtc.Checked;
			MessageBox.Show("Appended properties");
		};
		Form ppt = new Form();
		ppt.Size = new Size(256,320);
		ppt.MinimizeBox = false;
		ppt.MaximizeBox = false;
		ppt.MinimumSize = new Size(256,640);
		ppt.MaximumSize = new Size(256,640);
		ppt.Text = "Vertex 1.3 Properties";
		ppt.Icon = new Icon("icon.ico");
		Label bwd = new Label();
		bwd.Size = new Size(128,64);
		bwd.Location = new Point(0,0);
		bwd.Font = bfont;
		bwd.Text = "Width";
		TextBox wdt = new TextBox();
		wdt.Size = new Size(128,64);
		wdt.Location = new Point(128,0);
		wdt.Multiline = false;
		wdt.Font = bfont;
		wdt.TabStop = false;
		Label bhi = new Label();
		bhi.Size = new Size(128,64);
		bhi.Location = new Point(0,64);
		bhi.Font = bfont;
		bhi.Text = "Height";
		TextBox hit = new TextBox();
		hit.Size = new Size(128,64);
		hit.Location = new Point(128,64);
		hit.Multiline = false;
		hit.Font = bfont;
		hit.TabStop = false;
		// functions
		edt.Controls.Add(run);
		edt.Controls.Add(name);
		//edt.Controls.Add(save);
		edt.Controls.Add(cpl);
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
		edt.Show();
		tbr.Show();
		rtp.Show();
		ppt.Show();
	}
	static public void Main()
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
		vt.Text = "Vertex 1.3";
		vt.Icon = new Icon("icon.ico");
		Label main = new Label();
		main.Size = new Size(256,48);
		main.Location = new Point(0,0);
		main.Font = hfont;
		main.Text = "Vertex 1.3\nCPatch: 1.3.0";
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
		//examples.Location = new Point(0,open.Location.Y + 32);
		examples.Location = new Point(0,create.Location.Y + 32);
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
			editor();
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
			activate();
		};
		vt.Controls.Add(main);
		vt.Controls.Add(create);
		//vt.Controls.Add(open);
		vt.Controls.Add(examples);
		vt.Controls.Add(about);
		vt.Controls.Add(atv);
		Application.Run(vt);
	}
}
