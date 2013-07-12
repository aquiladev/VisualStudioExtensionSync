namespace ExtensionSync
{
	partial class OptionsUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.lblLogPath = new System.Windows.Forms.Label();
			this.btnBrowseLogFilePath = new System.Windows.Forms.Button();
			this.txtLogPath = new System.Windows.Forms.TextBox();
			this.cbxEnableLogging = new System.Windows.Forms.CheckBox();
			this.cbxAutoUpdateExtensions = new System.Windows.Forms.CheckBox();
			this.cbRepositoryTypes = new System.Windows.Forms.ComboBox();
			this.pFolder = new System.Windows.Forms.Panel();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.txtSettingsFilePath = new System.Windows.Forms.TextBox();
			this.btnBrowseSettingsFilePath = new System.Windows.Forms.Button();
			this.lblRepositoryType = new System.Windows.Forms.Label();
			this.pFolder.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLogPath
			// 
			this.lblLogPath.AutoSize = true;
			this.lblLogPath.Location = new System.Drawing.Point(5, 156);
			this.lblLogPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLogPath.Name = "lblLogPath";
			this.lblLogPath.Size = new System.Drawing.Size(91, 17);
			this.lblLogPath.TabIndex = 5;
			this.lblLogPath.Text = "Log File Path";
			// 
			// btnBrowseLogFilePath
			// 
			this.btnBrowseLogFilePath.Location = new System.Drawing.Point(410, 175);
			this.btnBrowseLogFilePath.Margin = new System.Windows.Forms.Padding(4);
			this.btnBrowseLogFilePath.Name = "btnBrowseLogFilePath";
			this.btnBrowseLogFilePath.Size = new System.Drawing.Size(109, 28);
			this.btnBrowseLogFilePath.TabIndex = 4;
			this.btnBrowseLogFilePath.Text = "Browse...";
			this.btnBrowseLogFilePath.UseVisualStyleBackColor = true;
			this.btnBrowseLogFilePath.Click += new System.EventHandler(this.BtnBrowseLogFilePathClick);
			// 
			// txtLogPath
			// 
			this.txtLogPath.Location = new System.Drawing.Point(4, 178);
			this.txtLogPath.Margin = new System.Windows.Forms.Padding(4);
			this.txtLogPath.Name = "txtLogPath";
			this.txtLogPath.ReadOnly = true;
			this.txtLogPath.Size = new System.Drawing.Size(398, 22);
			this.txtLogPath.TabIndex = 3;
			// 
			// cbxEnableLogging
			// 
			this.cbxEnableLogging.AutoSize = true;
			this.cbxEnableLogging.Location = new System.Drawing.Point(9, 134);
			this.cbxEnableLogging.Margin = new System.Windows.Forms.Padding(4);
			this.cbxEnableLogging.Name = "cbxEnableLogging";
			this.cbxEnableLogging.Size = new System.Drawing.Size(129, 21);
			this.cbxEnableLogging.TabIndex = 6;
			this.cbxEnableLogging.Text = "Enable Logging";
			this.cbxEnableLogging.UseVisualStyleBackColor = true;
			this.cbxEnableLogging.CheckedChanged += new System.EventHandler(this.CbxEnableLoggingCheckedChanged);
			// 
			// cbxAutoUpdateExtensions
			// 
			this.cbxAutoUpdateExtensions.AutoSize = true;
			this.cbxAutoUpdateExtensions.Location = new System.Drawing.Point(9, 238);
			this.cbxAutoUpdateExtensions.Margin = new System.Windows.Forms.Padding(4);
			this.cbxAutoUpdateExtensions.Name = "cbxAutoUpdateExtensions";
			this.cbxAutoUpdateExtensions.Size = new System.Drawing.Size(235, 21);
			this.cbxAutoUpdateExtensions.TabIndex = 7;
			this.cbxAutoUpdateExtensions.Text = "Automatically Update Extensions";
			this.cbxAutoUpdateExtensions.UseVisualStyleBackColor = true;
			this.cbxAutoUpdateExtensions.CheckedChanged += new System.EventHandler(this.CbxAutoUpdateExtensionsCheckedChanged);
			// 
			// cbRepositoryTypes
			// 
			this.cbRepositoryTypes.FormattingEnabled = true;
			this.cbRepositoryTypes.Location = new System.Drawing.Point(4, 33);
			this.cbRepositoryTypes.Name = "cbRepositoryTypes";
			this.cbRepositoryTypes.Size = new System.Drawing.Size(318, 24);
			this.cbRepositoryTypes.TabIndex = 8;
			this.cbRepositoryTypes.SelectedIndexChanged += new System.EventHandler(this.CbxRepositoryTypeTextChanged);
			// 
			// pFolder
			// 
			this.pFolder.Controls.Add(this.btnBrowseSettingsFilePath);
			this.pFolder.Controls.Add(this.txtSettingsFilePath);
			this.pFolder.Controls.Add(this.lblInstructions);
			this.pFolder.Location = new System.Drawing.Point(4, 63);
			this.pFolder.Name = "pFolder";
			this.pFolder.Size = new System.Drawing.Size(519, 64);
			this.pFolder.TabIndex = 9;
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Location = new System.Drawing.Point(4, 9);
			this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(317, 17);
			this.lblInstructions.TabIndex = 3;
			this.lblInstructions.Text = "Store My Extensions Settings file in this directory:";
			// 
			// txtSettingsFilePath
			// 
			this.txtSettingsFilePath.Location = new System.Drawing.Point(7, 30);
			this.txtSettingsFilePath.Margin = new System.Windows.Forms.Padding(4);
			this.txtSettingsFilePath.Name = "txtSettingsFilePath";
			this.txtSettingsFilePath.ReadOnly = true;
			this.txtSettingsFilePath.Size = new System.Drawing.Size(391, 22);
			this.txtSettingsFilePath.TabIndex = 4;
			// 
			// btnBrowseSettingsFilePath
			// 
			this.btnBrowseSettingsFilePath.Location = new System.Drawing.Point(406, 27);
			this.btnBrowseSettingsFilePath.Margin = new System.Windows.Forms.Padding(4);
			this.btnBrowseSettingsFilePath.Name = "btnBrowseSettingsFilePath";
			this.btnBrowseSettingsFilePath.Size = new System.Drawing.Size(109, 28);
			this.btnBrowseSettingsFilePath.TabIndex = 5;
			this.btnBrowseSettingsFilePath.Text = "Browse...";
			this.btnBrowseSettingsFilePath.UseVisualStyleBackColor = true;
			// 
			// lblRepositoryType
			// 
			this.lblRepositoryType.AutoSize = true;
			this.lblRepositoryType.Location = new System.Drawing.Point(4, 13);
			this.lblRepositoryType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRepositoryType.Name = "lblRepositoryType";
			this.lblRepositoryType.Size = new System.Drawing.Size(111, 17);
			this.lblRepositoryType.TabIndex = 10;
			this.lblRepositoryType.Text = "Repository type:";
			// 
			// OptionsUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblRepositoryType);
			this.Controls.Add(this.pFolder);
			this.Controls.Add(this.cbRepositoryTypes);
			this.Controls.Add(this.cbxAutoUpdateExtensions);
			this.Controls.Add(this.cbxEnableLogging);
			this.Controls.Add(this.lblLogPath);
			this.Controls.Add(this.btnBrowseLogFilePath);
			this.Controls.Add(this.txtLogPath);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "OptionsUserControl";
			this.Size = new System.Drawing.Size(528, 283);
			this.pFolder.ResumeLayout(false);
			this.pFolder.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Label lblLogPath;
		private System.Windows.Forms.Button btnBrowseLogFilePath;
		private System.Windows.Forms.TextBox txtLogPath;
		private System.Windows.Forms.CheckBox cbxEnableLogging;
		private System.Windows.Forms.CheckBox cbxAutoUpdateExtensions;
		private System.Windows.Forms.ComboBox cbRepositoryTypes;
		private System.Windows.Forms.Panel pFolder;
		private System.Windows.Forms.Button btnBrowseSettingsFilePath;
		private System.Windows.Forms.TextBox txtSettingsFilePath;
		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.Label lblRepositoryType;
	}
}
