using System.Reflection;

using Erlin.Utils.Caffeine.Properties;

using Markdig;

namespace Erlin.Utils.Caffeine;

/// <summary>
///    About form
/// </summary>
public partial class About : Form
{
	private Assembly CurrentAssemly { get; } = Assembly.GetExecutingAssembly();

	public About()
	{
		InitializeComponent();
	}

	/// <summary>
	///    Action on form load
	/// </summary>
	protected override void OnLoad( EventArgs e )
	{
		base.OnLoad( e );

		Icon = Resources.Caffeine;
		Text = @"About " + CurrentAssemly.GetName().Name;

		labelTitle.Text = CurrentAssemly.GetName().Name;
		labelVersion.Text = CurrentAssemly.GetName().Version?.ToString();

		webBrowserLicense.DocumentText = GetEmbededFile( "Erlin.Utils.Caffeine.LICENSE.md" );
		webBrowserThirdParties.DocumentText = GetEmbededFile( "Erlin.Utils.Caffeine.LICENSE_THIRD_PARTIES.md" );
	}

	/// <summary>
	///    Loads embeded license file
	/// </summary>
	private string GetEmbededFile( string resourceName )
	{
		using Stream? stream = CurrentAssemly.GetManifestResourceStream( resourceName );
		if( stream != null )
		{
			using StreamReader reader = new( stream );
			string content = reader.ReadToEnd();
			return About.EncapsulateHtml( Markdown.ToHtml( content ) );
		}

		return string.Empty;
	}

	/// <summary>
	///    Provides html and css encapsulation for html segment
	/// </summary>
	private static string EncapsulateHtml( string htmlBody )
	{
		return $$"""
				<!doctype html>
				<html lang="en">
					<head>
						<meta charset="utf-8" />
						<meta name="viewport" content="width=device-width, initial-scale=1" />
						<style>
							body {
								background-color: #222;
								color: white;
							}
							blockquote {
								background-color: #333;
								padding: 0.5em;
								border-radius: 0.5em;
								border: 1px solid #666;
								box-shadow: 0.25rem 0.25rem 0 #666;
							}
							blockquote blockquote {
								background-color: #444;
							}
							blockquote blockquote blockquote {
								background-color: #555;
							}
						</style>
					</head>
					<body>
						{{htmlBody}}
					</body>
				</html>
				""";
	}
}
