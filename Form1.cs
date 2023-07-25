using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using WK.Libraries.BetterFolderBrowserNS;

namespace PokeSpriteOrganizer
{
	public partial class Form1 : Form
	{
		private string textures_location;
		private char[] separators = new char[] {
			'\\',
			'|',
			'-',
			'_',
			',',
			'/'
		};

		List<Folder> folders = new List<Folder>();
		List<Texture> textures = new List<Texture>();
		List<string> indexes = new List<string>();

		public Form1()
		{
			InitializeComponent();
		}

		private void btn_textures_Click(object sender, EventArgs e)
		{
			textureGrid.DataSource = null;
			textures.Clear();

			BetterFolderBrowser browser = new BetterFolderBrowser();
			browser.Title = "Select your textures folder...";
			browser.RootFolder = Application.StartupPath;
			browser.Multiselect = false;

			if (browser.ShowDialog() == DialogResult.OK)
			{
				textures_location = browser.SelectedFolder;

				string[] filePaths = Directory.GetFiles(textures_location);

				foreach (string file in filePaths)
				{

					string fileName = Path.GetFileNameWithoutExtension(file);
					string folderSelection = fileName.Split(separators)[1];

					indexes.Add(folderSelection);
				}

				indexes = indexes.Distinct().ToList();

				for (int i = 0; i < indexes.Count; i++)
				{
					textures.Add(new Texture()
					{
						Key = indexes[i],
						Remap = ""
					});
				}

				textureGrid.DataSource = textures;
			}
			else
			{
				MessageBox.Show("Error: No folder was selected. Please try again.");
			}
		}

		private void btn_folders_Click(object sender, EventArgs e)
		{
			dataGrid.DataSource = null;
			folders.Clear();

			if ( indexCombo.SelectedIndex == -1 )
			{
				MessageBox.Show("Please select an Index Type before selecting folders.");
				return;
			}

			BetterFolderBrowser browser = new BetterFolderBrowser();
			browser.Title = "Select your folders...";
			browser.RootFolder = Application.StartupPath;
			browser.Multiselect = true;

			if (browser.ShowDialog() == DialogResult.OK)
			{
				string[] folder_locations = browser.SelectedFolders;

				int index = indexCombo.SelectedIndex == 0 ? 0 : 1;

				foreach (string folder in folder_locations)
				{
					folders.Add(new Folder()
					{
						Name = folder.Split('\\').LastOrDefault(),
						Location = folder,
						Key = indexCombo.SelectedIndex == 2 ? "key" : index.ToString().PadLeft((int)indexPadding.Value, '0')
					});

					index++;
				}

				dataGrid.DataSource = folders;
			}
			else
			{
				MessageBox.Show("Error: No folders were selected. Please try again.");
			}
		}

		private void btn_organize_Click(object sender, EventArgs e)
		{

			string[] filePaths = Directory.GetFiles(textures_location);

			foreach (string file in filePaths)
			{
				string fileName = Path.GetFileName(file);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
				string folderSelection = fileName.Split(separators).FirstOrDefault();
				string key = fileNameWithoutExtension.Split(separators)[1];


				for (int i = 0; i < dataGrid.Rows.Count; i++)
				{
					Folder folder = dataGrid.Rows[i].DataBoundItem as Folder;

					if (folder.Key.Equals(folderSelection))
					{
						for (int j = 0; j < textures.Count; j++)
						{
							if (textures[j].Key != key)
							{
								continue;
							}

							File.Move(file, Path.Combine(folder.Location, textures[j].Remap + ".png"));
						}

						File.Delete(file);
					}
				}
			}
		}

		private void btn_remapper_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			dialog.Title = "Select your remapper file";
			dialog.InitialDirectory = Application.StartupPath;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				remapper_txtbx.Text = dialog.FileName;

				string[] remapped = File.ReadAllLines(dialog.FileName);

				for (int i = 0; i < textures.Count; i++)
				{
					textures[i].Remap = remapped[i];
				}
			}
			textureGrid.DataSource = null;
			textureGrid.DataSource = textures;
		}

		class Folder
		{
			public string Name { get; internal set; }
			public string Location { get; internal set; }
			public string Key { get; set; }
		}

		class Texture
		{
			public string Key { get; internal set; }
			public string Remap { get; set; }
		}
	}
}
