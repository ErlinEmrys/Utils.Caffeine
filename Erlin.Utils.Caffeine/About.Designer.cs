using System.ComponentModel;

namespace Erlin.Utils.Caffeine;

partial class About
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose( bool disposing )
	{
		if( disposing && ( components != null ) )
		{
			components.Dispose();
		}

		webBrowserLicense.Dispose();
		webBrowserThirdParties.Dispose();
		base.Dispose( disposing );
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		webBrowserLicense = new System.Windows.Forms.WebBrowser();
		tabControl1 = new System.Windows.Forms.TabControl();
		tabPage3 = new System.Windows.Forms.TabPage();
		tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
		labelTitle = new System.Windows.Forms.Label();
		labelVersion = new System.Windows.Forms.Label();
		tabPage1 = new System.Windows.Forms.TabPage();
		tabPage2 = new System.Windows.Forms.TabPage();
		webBrowserThirdParties = new System.Windows.Forms.WebBrowser();
		tabControl1.SuspendLayout();
		tabPage3.SuspendLayout();
		tableLayoutPanel1.SuspendLayout();
		tableLayoutPanel2.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		SuspendLayout();
		// 
		// webBrowserLicense
		// 
		webBrowserLicense.Dock = System.Windows.Forms.DockStyle.Fill;
		webBrowserLicense.Location = new System.Drawing.Point( 3, 3 );
		webBrowserLicense.Name = "webBrowserLicense";
		webBrowserLicense.Size = new System.Drawing.Size( 786, 412 );
		webBrowserLicense.TabIndex = 0;
		// 
		// tabControl1
		// 
		tabControl1.Controls.Add( tabPage3 );
		tabControl1.Controls.Add( tabPage1 );
		tabControl1.Controls.Add( tabPage2 );
		tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		tabControl1.Location = new System.Drawing.Point( 0, 0 );
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size( 800, 450 );
		tabControl1.TabIndex = 1;
		// 
		// tabPage3
		// 
		tabPage3.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( byte )34 ) ), ( ( int )( ( byte )34 ) ), ( ( int )( ( byte )34 ) ) );
		tabPage3.Controls.Add( tableLayoutPanel1 );
		tabPage3.ForeColor = System.Drawing.Color.White;
		tabPage3.Location = new System.Drawing.Point( 4, 28 );
		tabPage3.Name = "tabPage3";
		tabPage3.Size = new System.Drawing.Size( 792, 418 );
		tabPage3.TabIndex = 2;
		tabPage3.Text = "About";
		// 
		// tableLayoutPanel1
		// 
		tableLayoutPanel1.ColumnCount = 1;
		tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
		tableLayoutPanel1.Controls.Add( tableLayoutPanel2, 0, 1 );
		tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
		tableLayoutPanel1.Name = "tableLayoutPanel1";
		tableLayoutPanel1.RowCount = 3;
		tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 33.333332F ) );
		tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 33.333332F ) );
		tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 33.333332F ) );
		tableLayoutPanel1.Size = new System.Drawing.Size( 792, 418 );
		tableLayoutPanel1.TabIndex = 0;
		// 
		// tableLayoutPanel2
		// 
		tableLayoutPanel2.ColumnCount = 1;
		tableLayoutPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
		tableLayoutPanel2.Controls.Add( labelTitle, 0, 0 );
		tableLayoutPanel2.Controls.Add( labelVersion, 0, 1 );
		tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
		tableLayoutPanel2.Location = new System.Drawing.Point( 3, 142 );
		tableLayoutPanel2.Name = "tableLayoutPanel2";
		tableLayoutPanel2.RowCount = 2;
		tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
		tableLayoutPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
		tableLayoutPanel2.Size = new System.Drawing.Size( 786, 133 );
		tableLayoutPanel2.TabIndex = 0;
		// 
		// labelTitle
		// 
		labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		labelTitle.Font = new System.Drawing.Font( "Segoe UI", 36.313046F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )0 ) );
		labelTitle.Location = new System.Drawing.Point( 3, 0 );
		labelTitle.Name = "labelTitle";
		labelTitle.Size = new System.Drawing.Size( 780, 66 );
		labelTitle.TabIndex = 0;
		labelTitle.Text = "label1";
		labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// labelVersion
		// 
		labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
		labelVersion.Font = new System.Drawing.Font( "Segoe UI", 18.156523F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )0 ) );
		labelVersion.Location = new System.Drawing.Point( 3, 66 );
		labelVersion.Name = "labelVersion";
		labelVersion.Size = new System.Drawing.Size( 780, 67 );
		labelVersion.TabIndex = 1;
		labelVersion.Text = "label2";
		labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// tabPage1
		// 
		tabPage1.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( byte )34 ) ), ( ( int )( ( byte )34 ) ), ( ( int )( ( byte )34 ) ) );
		tabPage1.Controls.Add( webBrowserLicense );
		tabPage1.Location = new System.Drawing.Point( 4, 28 );
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
		tabPage1.Size = new System.Drawing.Size( 792, 418 );
		tabPage1.TabIndex = 0;
		tabPage1.Text = "License";
		// 
		// tabPage2
		// 
		tabPage2.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( byte )34 ) ), ( ( int )( ( byte )34 ) ), ( ( int )( ( byte )34 ) ) );
		tabPage2.Controls.Add( webBrowserThirdParties );
		tabPage2.Location = new System.Drawing.Point( 4, 28 );
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
		tabPage2.Size = new System.Drawing.Size( 792, 418 );
		tabPage2.TabIndex = 1;
		tabPage2.Text = "Third parties licenses";
		// 
		// webBrowserThirdParties
		// 
		webBrowserThirdParties.Dock = System.Windows.Forms.DockStyle.Fill;
		webBrowserThirdParties.Location = new System.Drawing.Point( 3, 3 );
		webBrowserThirdParties.Name = "webBrowserThirdParties";
		webBrowserThirdParties.Size = new System.Drawing.Size( 786, 412 );
		webBrowserThirdParties.TabIndex = 1;
		// 
		// About
		// 
		AutoScaleDimensions = new System.Drawing.SizeF( 8F, 19F );
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size( 800, 450 );
		Controls.Add( tabControl1 );
		Text = "About";
		tabControl1.ResumeLayout( false );
		tabPage3.ResumeLayout( false );
		tableLayoutPanel1.ResumeLayout( false );
		tableLayoutPanel2.ResumeLayout( false );
		tabPage1.ResumeLayout( false );
		tabPage2.ResumeLayout( false );
		ResumeLayout( false );
	}

	private System.Windows.Forms.Label labelTitle;
	private System.Windows.Forms.Label labelVersion;

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

	private System.Windows.Forms.TabPage tabPage3;

	private System.Windows.Forms.WebBrowser webBrowserLicense;

	private System.Windows.Forms.TabControl tabControl1;
	private System.Windows.Forms.TabPage tabPage1;
	private System.Windows.Forms.TabPage tabPage2;

	private System.Windows.Forms.WebBrowser webBrowserThirdParties;

	#endregion
}
