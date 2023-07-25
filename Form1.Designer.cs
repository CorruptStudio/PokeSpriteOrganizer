
namespace PokeSpriteOrganizer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btn_textures = new System.Windows.Forms.Button();
			this.btn_folders = new System.Windows.Forms.Button();
			this.indexCombo = new System.Windows.Forms.ComboBox();
			this.btn_organize = new System.Windows.Forms.Button();
			this.asdf = new System.Windows.Forms.GroupBox();
			this.textureGrid = new System.Windows.Forms.DataGridView();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.indexPadding = new System.Windows.Forms.NumericUpDown();
			this.remapper_txtbx = new System.Windows.Forms.TextBox();
			this.btn_remapper = new System.Windows.Forms.Button();
			this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.asdf.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textureGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.indexPadding)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_textures
			// 
			this.btn_textures.Location = new System.Drawing.Point(12, 12);
			this.btn_textures.Name = "btn_textures";
			this.btn_textures.Size = new System.Drawing.Size(150, 23);
			this.btn_textures.TabIndex = 0;
			this.btn_textures.Text = "Textures";
			this.btn_textures.UseVisualStyleBackColor = true;
			this.btn_textures.Click += new System.EventHandler(this.btn_textures_Click);
			// 
			// btn_folders
			// 
			this.btn_folders.Location = new System.Drawing.Point(12, 39);
			this.btn_folders.Name = "btn_folders";
			this.btn_folders.Size = new System.Drawing.Size(150, 23);
			this.btn_folders.TabIndex = 1;
			this.btn_folders.Text = "Folders";
			this.btn_folders.UseVisualStyleBackColor = true;
			this.btn_folders.Click += new System.EventHandler(this.btn_folders_Click);
			// 
			// indexCombo
			// 
			this.indexCombo.FormattingEnabled = true;
			this.indexCombo.Items.AddRange(new object[] {
            "Zero-Based",
            "One-Based",
            "Key-Based"});
			this.indexCombo.Location = new System.Drawing.Point(186, 39);
			this.indexCombo.Name = "indexCombo";
			this.indexCombo.Size = new System.Drawing.Size(180, 21);
			this.indexCombo.TabIndex = 2;
			this.indexCombo.Text = "Index Type";
			// 
			// btn_organize
			// 
			this.btn_organize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_organize.Location = new System.Drawing.Point(12, 426);
			this.btn_organize.Name = "btn_organize";
			this.btn_organize.Size = new System.Drawing.Size(150, 23);
			this.btn_organize.TabIndex = 3;
			this.btn_organize.Text = "Organize";
			this.btn_organize.UseVisualStyleBackColor = true;
			this.btn_organize.Click += new System.EventHandler(this.btn_organize_Click);
			// 
			// asdf
			// 
			this.asdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.asdf.AutoSize = true;
			this.asdf.Controls.Add(this.textureGrid);
			this.asdf.Controls.Add(this.dataGrid);
			this.asdf.Location = new System.Drawing.Point(12, 68);
			this.asdf.Name = "asdf";
			this.asdf.Size = new System.Drawing.Size(830, 352);
			this.asdf.TabIndex = 4;
			this.asdf.TabStop = false;
			// 
			// textureGrid
			// 
			this.textureGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.textureGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.textureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.textureGrid.Dock = System.Windows.Forms.DockStyle.Right;
			this.textureGrid.Location = new System.Drawing.Point(645, 16);
			this.textureGrid.Name = "textureGrid";
			this.textureGrid.Size = new System.Drawing.Size(182, 333);
			this.textureGrid.TabIndex = 1;
			// 
			// dataGrid
			// 
			this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGrid.Location = new System.Drawing.Point(3, 16);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGrid.Size = new System.Drawing.Size(636, 333);
			this.dataGrid.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(183, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Index Prefix";
			// 
			// indexPadding
			// 
			this.indexPadding.Location = new System.Drawing.Point(251, 13);
			this.indexPadding.Name = "indexPadding";
			this.indexPadding.Size = new System.Drawing.Size(115, 20);
			this.indexPadding.TabIndex = 7;
			this.indexPadding.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// remapper_txtbx
			// 
			this.remapper_txtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.remapper_txtbx.Location = new System.Drawing.Point(657, 39);
			this.remapper_txtbx.Name = "remapper_txtbx";
			this.remapper_txtbx.ReadOnly = true;
			this.remapper_txtbx.Size = new System.Drawing.Size(185, 20);
			this.remapper_txtbx.TabIndex = 8;
			this.remapper_txtbx.Text = "Texture Remapper";
			// 
			// btn_remapper
			// 
			this.btn_remapper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_remapper.Location = new System.Drawing.Point(624, 37);
			this.btn_remapper.Name = "btn_remapper";
			this.btn_remapper.Size = new System.Drawing.Size(27, 23);
			this.btn_remapper.TabIndex = 9;
			this.btn_remapper.Text = "...";
			this.btn_remapper.UseVisualStyleBackColor = true;
			this.btn_remapper.Click += new System.EventHandler(this.btn_remapper_Click);
			// 
			// form1BindingSource
			// 
			this.form1BindingSource.DataSource = typeof(PokeSpriteOrganizer.Form1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(854, 461);
			this.Controls.Add(this.btn_remapper);
			this.Controls.Add(this.remapper_txtbx);
			this.Controls.Add(this.indexPadding);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.asdf);
			this.Controls.Add(this.btn_organize);
			this.Controls.Add(this.indexCombo);
			this.Controls.Add(this.btn_folders);
			this.Controls.Add(this.btn_textures);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1920, 1080);
			this.MinimumSize = new System.Drawing.Size(870, 500);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Poke Sprite Organizer";
			this.asdf.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.textureGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.indexPadding)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_textures;
		private System.Windows.Forms.Button btn_folders;
		private System.Windows.Forms.ComboBox indexCombo;
		private System.Windows.Forms.Button btn_organize;
		private System.Windows.Forms.GroupBox asdf;
		private System.Windows.Forms.DataGridView textureGrid;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown indexPadding;
		private System.Windows.Forms.BindingSource form1BindingSource;
		private System.Windows.Forms.TextBox remapper_txtbx;
		private System.Windows.Forms.Button btn_remapper;
	}
}

