using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

class Vertex
{
	static public void savefile(string filepath,Stream inputstream,string filename)
	{
		DirectoryInfo info = new DirectoryInfo(filepath);
		if (!info.Exists)
		{
			info.Create();
		}
		string path = Path.Combine(filepath,filename);
		using (FileStream output = new FileStream(path,FileMode.Create))
		{
			inputstream.CopyTo(output);
		};
	}
	static public void runtime()
	{
		Form rtm = new Form();
		rtm.Size = new Size(512,512);
		rtm.MinimizeBox = false;
		rtm.MaximizeBox = false;
		rtm.MinimumSize = new Size(512,512);
		rtm.MaximumSize = new Size(512,512);
		rtm.Text = "Vertex 1.0 Runtime";
		rtm.Show();
	}

	static public void info()
	{
		Form info = new Form();
		info.Size = new Size(512,512);
		info.MinimizeBox = false;
		info.MaximizeBox = false;
		info.MinimumSize = new Size(512,512);
		info.MaximumSize = new Size(512,512); 
		info.Text = "About Vertex 1.0";
		Label text = new Label();
		text.Size = new Size(512,512);
		text.Text = "Copyrighted (C) Rise LLC 2025";
		info.Show();
	}
	
	static public void editor()
	{
		// adds
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		Form edt = new Form();
		edt.Size = new Size(256,512);
		edt.MinimizeBox = false;
		edt.MaximizeBox = false;
		edt.MinimumSize = new Size(256,512);
		edt.MaximumSize = new Size(256,512);
		edt.Text = "Vertex 1.0 Editor";
		Button run = new Button();
		run.Size = new Size(64,32);
		run.Location = new Point(0,0);
		run.Font = bfont;
		run.Text = "Run";
		run.TabStop = false;
		run.Click += (sender,args) =>
		{
			runtime();
		};
		TextBox name = new TextBox();
		name.Size = new Size(92,32);
		name.Location = new Point(run.Location.X + 64);
		name.Font = bfont;
		name.Text = "Name";
		name.TabStop = false;
		Button save = new Button();
		save.Size = new Size(64,32);
		save.Location = new Point(name.Location.X + 92);
		save.Font = bfont;
		save.Text = "Save";
		save.TabStop = false;
		save.Click += (sender,args) =>
		{
			//
		};
		// functions
		edt.Controls.Add(run);
		edt.Controls.Add(name);
		edt.Controls.Add(save);
		edt.Show();
	}

	static public void Main()
	{
		// adds
		Form vt = new Form();
		Font hfont = new Font(new Font("Courier New",16),FontStyle.Bold);
		Font bfont = new Font(new Font("Courier New",8),FontStyle.Bold);
		vt.Size = new Size(512,512);
		vt.MinimizeBox = false;
		vt.MaximizeBox = false;
		vt.MinimumSize = new Size(512,512);
		vt.MaximumSize = new Size(512,512);
		vt.StartPosition = FormStartPosition.CenterScreen;
		vt.Text = "Vertex 1.0";
		Label main = new Label();
		main.Size = new Size(256,48);
		main.Location = new Point(0,0);
		main.Font = hfont;
		main.Text = "Vertex 1.0\nCPatch: 1.0.0";
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
		about.Text = "About Me";
		about.TabStop = false;
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
			//exp.Show();
		};
		about.Click += (sender,args) =>
		{
			info();
		};
		vt.Controls.Add(main);
		vt.Controls.Add(create);
		vt.Controls.Add(open);
		vt.Controls.Add(examples);
		vt.Controls.Add(about);
		Application.Run(vt);
	}
}
