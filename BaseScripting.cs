using System.Runtime.CompilerServices;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ToolDataModel;

namespace ScmGroup.XCam.Scripting;

public class BaseScripting
{
	protected ProjectInterface _projectInterface;

	protected ToolInterface _toolInterface;

	protected ConfigurationInterface _configurationInterface;

	protected ConfigurationInterface _supportInterface;

	protected EdgeInterface _edgeInterface;

	private string _0023_003DzZBLgo1uqnWAk_0024u5PnQ_003D_003D;

	private ReferenceKey _0023_003DzRt4rrq8nuRzTw3HQ7w_003D_003D;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (-1 == 0)
			{
			}
			return _0023_003DzZBLgo1uqnWAk_0024u5PnQ_003D_003D;
		}
		[CompilerGenerated]
		protected set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003DzZBLgo1uqnWAk_0024u5PnQ_003D_003D = value;
			}
		}
	}

	public ReferenceKey ReferenceKey
	{
		[CompilerGenerated]
		get
		{
			_ = 7;
			if (5 == 0)
			{
			}
			return _0023_003DzRt4rrq8nuRzTw3HQ7w_003D_003D;
		}
		[CompilerGenerated]
		protected set
		{
			if (6u != 0)
			{
				_0023_003DzRt4rrq8nuRzTw3HQ7w_003D_003D = value;
			}
		}
	}

	public BaseScripting()
	{
		_ = 7;
		if (7 == 0)
		{
		}
		base._002Ector();
	}

	public BaseScripting(string name, ReferenceKey key)
	{
		if (true)
		{
			Name = name;
		}
		if (3u != 0)
		{
			ReferenceKey = key;
		}
	}

	internal virtual void _0023_003Dza07C_0024Lw_003D()
	{
	}
}
