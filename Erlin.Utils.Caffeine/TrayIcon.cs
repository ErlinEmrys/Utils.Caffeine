using Erlin.Lib.Common.Windows;
using Erlin.Utils.Caffeine.Properties;

namespace Erlin.Utils.Caffeine;

/// <summary>
/// Main tray icon
/// </summary>
public class TrayIcon : ApplicationContext
{
	private readonly ToolStripMenuItem _disableEnableMenu;
	private readonly Win10Loop _loop;
	private readonly NotifyIcon _trayIcon;

	/// <summary>
	/// Ctor
	/// </summary>
	public TrayIcon()
	{
		ContextMenuStrip menu = new();

		_disableEnableMenu = new ToolStripMenuItem( "Disable" );
		_disableEnableMenu.Click += DisableEnableMenu_Click;
		_ = menu.Items.Add( _disableEnableMenu );

		ToolStripMenuItem exitMenu = new( "Exit" );
		exitMenu.Click += ExitMenu_Click;
		_ = menu.Items.Add( exitMenu );

		// Initialize Tray Icon
		_trayIcon = new NotifyIcon { ContextMenuStrip = menu, Visible = true };

		_loop = new Win10Loop( false, false, false );

		SwitchState();
	}

	/// <summary>
	/// Releases the unmanaged resources used by the ApplicationContext and optionally releases the managed resources.
	/// </summary>
	/// <param name="disposing"><see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose( bool disposing )
	{
		base.Dispose( disposing );

		if( disposing )
		{
			_loop.Dispose();
		}
	}

	/// <summary>
	/// Menu Disable/Enable action
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="e">Event args</param>
	private void DisableEnableMenu_Click( object? sender, EventArgs e )
	{
		SwitchState();
	}

	/// <summary>
	/// Switch Disabled/Enabled state
	/// </summary>
	private void SwitchState()
	{
		if( _loop.KeepPcAwake )
		{
			_disableEnableMenu.Text = @"Enable";
			_trayIcon.Icon = Resources.Disabled;
			_trayIcon.Text = @"Caffeine is disabled!";
		}
		else
		{
			_disableEnableMenu.Text = @"Disable";
			_trayIcon.Icon = Resources.Enabled;
			_trayIcon.Text = @"Caffeine is enabled!";
		}

		_loop.KeepPcAwake = !_loop.KeepPcAwake;
		_loop.KeepMonitorAwake = !_loop.KeepMonitorAwake;
	}

	/// <summary>
	/// Menu Exit action
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="e">Event args</param>
	private void ExitMenu_Click( object? sender, EventArgs e )
	{
		// Hide tray icon, otherwise it will remain shown until user mouses over it
		_trayIcon.Visible = false;

		Application.Exit();
	}
}
