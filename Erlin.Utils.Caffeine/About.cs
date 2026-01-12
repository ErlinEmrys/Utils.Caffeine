using System.Reflection;

using Erlin.Utils.Caffeine.Properties;

using Markdig;

namespace Erlin.Utils.Caffeine;

/// <summary>
/// About form
/// </summary>
public partial class About : Form
{
	private Assembly CurrentAssemly { get; } = Assembly.GetExecutingAssembly();

	public About()
	{
		InitializeComponent();
		Icon = Resources.Caffeine;
		Text = "About " + CurrentAssemly.GetName().Name;
	}

	protected override void OnLoad( EventArgs e )
	{
		base.OnLoad( e );

		webBrowserLicense.DocumentText = GetEmbededFile( "Erlin.Utils.Caffeine.LICENSE.md" );
		webBrowserThirdParties.DocumentText = GetEmbededFile( "Erlin.Utils.Caffeine.LICENSE_THIRD_PARTIES.md" );
	}

	/// <summary>
	/// Loads embeded license file
	/// </summary>
	private string GetEmbededFile( string resourceName )
	{
		using Stream? stream = CurrentAssemly.GetManifestResourceStream( resourceName );
		if ( stream != null )
		{
			using StreamReader reader = new( stream );
			string content = reader.ReadToEnd();
			return Markdown.ToHtml( content );
		}

		return string.Empty;
	}
}
