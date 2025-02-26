/*
Copyright 2025 Rise LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
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
			if (scode == specials.sd1)
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
		atv.Text = "Vertex 1.2 Activation";
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
			cpl.Text = "Vertex 1.2 Compiled Application";
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
			rtm.Text = 'Vertex 1.2 Runtime';
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
		Form rtm = new Form();
		rtm.Size = new Size(512,512);
		rtm.MinimizeBox = false;
		rtm.MaximizeBox = false;
		rtm.MinimumSize = new Size(512,512);
		rtm.MaximumSize = new Size(512,512);
		rtm.Text = "Vertex 1.2 Runtime";
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
		pb.Text = "Vertex 1.2 Examples";
		Button one = new Button();
		one.Size = new Size(256,32);
		one.Location = new Point(0,0);
		one.Font = bfont;
		one.Text = "#1";
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
		info.Size = new Size(288,512);
		info.MinimizeBox = false;
		info.MaximizeBox = false;
		info.MinimumSize = new Size(288,512);
		info.MaximumSize = new Size(288,512);
		info.Text = "Vertex 1.2 Informations";
		Label text = new Label();
		text.Size = new Size(256,512);
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
		Vertex 1.2
		Amount Of Objects Available: 10
		Conditions In Each Object: 10;
		Amount Of Events In Each Object: 10
		Price: $20
		Vertex 2.0
		Amount Of Objects Available: 10
		Amount Of Events In Each Object: 10
		Price $25
		Vertex 3.0
		Amount Of Objects Available: 10
		Amount Of Events In Each Object: 10
		Price $30
		Note: The 1.0 version had only basic functions to make games like Pong.
		Note: The 2.0 version will has advance functions to make games like Mario.
		Note: The 3.0 version will has the most amount of objects in the game to make games like FNAF.
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
		edt.Text = "Vertex 1.2 Taskbar";
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
		name.Size = new Size(80,16);
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
		cpl.Location = new Point(save.Location.X + 48);
		cpl.Font = bfont;
		cpl.Text = "Compile";
		cpl.TabStop = false;
		cpl.Click += (sender,args) =>
		{
			compile();
		};
		Form tbr = new Form();
		tbr.Size = new Size(256,320);
		tbr.MinimizeBox = false;
		tbr.MaximizeBox = false;
		tbr.MinimumSize = new Size(256,320);
		tbr.MaximumSize = new Size(256,320);
		tbr.Text = "Vertex 1.2 Toolbar";
		Form rtp = new Form();
		rtp.Size = new Size(256,320);
		rtp.MinimizeBox = false;
		rtp.MaximizeBox = false;
		rtp.MinimumSize = new Size(256,320);
		rtp.MaximumSize = new Size(256,320);
		rtp.Text = "Vertex 1.2 Runtime Properties";
		Form ppt = new Form();
		ppt.Size = new Size(256,320);
		ppt.MinimizeBox = false;
		ppt.MaximizeBox = false;
		ppt.MinimumSize = new Size(256,320);
		ppt.MaximumSize = new Size(256,320);
		ppt.Text = "Vertex 1.2 Properties";
		// functions
		edt.Controls.Add(run);
		edt.Controls.Add(name);
		edt.Controls.Add(save);
		edt.Controls.Add(cpl);
		edt.Show();
		tbr.Show();
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
		vt.Text = "Vertex 1.2";
		Label main = new Label();
		main.Size = new Size(256,48);
		main.Location = new Point(0,0);
		main.Font = hfont;
		main.Text = "Vertex 1.2\nCPatch: 1.2.0";
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
		vt.Controls.Add(open);
		vt.Controls.Add(examples);
		vt.Controls.Add(about);
		vt.Controls.Add(atv);
		Application.Run(vt);
	}
}
