using System.Runtime.CompilerServices;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.EdgeDataModel;

namespace ScmGroup.XCam.Scripting;

public class EdgeClosingManager
{
	private EdgeClosing _0023_003DzJ6YqGwMEZk_0024KgHvPQBSjRgI_003D;

	private bool _0023_003DzJYxYcA9xAFUKFrcXxgc3B20_003D;

	private UI00EdgeBandingOptions _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D;

	public EdgeClosing EdgeClosing
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (7 == 0)
			{
			}
			return _0023_003DzJ6YqGwMEZk_0024KgHvPQBSjRgI_003D;
		}
		[CompilerGenerated]
		set
		{
			if (6u != 0)
			{
				_0023_003DzJ6YqGwMEZk_0024KgHvPQBSjRgI_003D = value;
			}
		}
	}

	public bool Cutter
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (false)
			{
			}
			return _0023_003DzJYxYcA9xAFUKFrcXxgc3B20_003D;
		}
		[CompilerGenerated]
		set
		{
			if (true)
			{
				_0023_003DzJYxYcA9xAFUKFrcXxgc3B20_003D = value;
			}
		}
	}

	public EdgeClosingManager()
	{
		UI00EdgeBandingOptions edgeBandingOptions = AppInfo.CurrentOptions<UI00Options>().EdgeBandingOptions;
		if (2u != 0)
		{
			_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D = edgeBandingOptions;
		}
		if (3u != 0)
		{
			_0023_003DzBMBVczs_003D();
		}
	}

	private void _0023_003DzBMBVczs_003D()
	{
		EdgeClosing edgeClosing = new EdgeClosing();
		if (6u != 0)
		{
			EdgeClosing = edgeClosing;
		}
		EdgeClosing.EndOffSet = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.EdgeClosingEndOffSet;
		bool cutter = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.Cutter;
		if (0 == 0)
		{
			Cutter = cutter;
		}
	}

	public void Reset()
	{
		if (3u != 0)
		{
			_0023_003DzBMBVczs_003D();
		}
	}

	public void CreateEdgeClosing(double endOffSet, bool enableCutter)
	{
		EdgeClosing.EndOffSet = endOffSet;
		if (4u != 0)
		{
			Cutter = enableCutter;
		}
	}
}
