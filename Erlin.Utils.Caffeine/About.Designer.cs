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
		tabPage1 = new System.Windows.Forms.TabPage();
		tabPage2 = new System.Windows.Forms.TabPage();
		webBrowserThirdParties = new System.Windows.Forms.WebBrowser();
		tabControl1.SuspendLayout();
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
		tabControl1.Controls.Add( tabPage1 );
		tabControl1.Controls.Add( tabPage2 );
		tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		tabControl1.Location = new System.Drawing.Point( 0, 0 );
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size( 800, 450 );
		tabControl1.TabIndex = 1;
		// 
		// tabPage1
		// 
		tabPage1.Controls.Add( webBrowserLicense );
		tabPage1.Location = new System.Drawing.Point( 4, 28 );
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
		tabPage1.Size = new System.Drawing.Size( 792, 418 );
		tabPage1.TabIndex = 0;
		tabPage1.Text = "License";
		tabPage1.UseVisualStyleBackColor = true;
		// 
		// tabPage2
		// 
		tabPage2.Controls.Add( webBrowserThirdParties );
		tabPage2.Location = new System.Drawing.Point( 4, 28 );
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
		tabPage2.Size = new System.Drawing.Size( 280, 194 );
		tabPage2.TabIndex = 1;
		tabPage2.Text = "Third parties";
		tabPage2.UseVisualStyleBackColor = true;
		// 
		// webBrowserThirdParties
		// 
		webBrowserThirdParties.Dock = System.Windows.Forms.DockStyle.Fill;
		webBrowserThirdParties.Location = new System.Drawing.Point( 3, 3 );
		webBrowserThirdParties.Name = "webBrowserThirdParties";
		webBrowserThirdParties.Size = new System.Drawing.Size( 274, 188 );
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
		tabPage1.ResumeLayout( false );
		tabPage2.ResumeLayout( false );
		ResumeLayout( false );
	}

	private System.Windows.Forms.WebBrowser webBrowserLicense;

	private System.Windows.Forms.TabControl tabControl1;
	private System.Windows.Forms.TabPage tabPage1;
	private System.Windows.Forms.TabPage tabPage2;

	private System.Windows.Forms.WebBrowser webBrowserThirdParties;

	#endregion
}
