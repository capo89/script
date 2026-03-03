using System.Runtime.CompilerServices;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.ToolDataModel;

namespace ScmGroup.XCam.Scripting;

public class OperationContext
{
	private UI00Options _0023_003DzlptUyaPsFjOO_0024kvUyw_003D_003D;

	private IScriptingReportServices _0023_003Dzs_0024LQUOjPiCXcdcQSvdo39G4_003D;

	private ProjectInterface _0023_003DzxVdxKd51PC85gWLCEQ_003D_003D;

	private ToolInterface _0023_003DzoRkSIgxkf8kpxX5vXTfeuf0_003D;

	private ConfigurationInterface _0023_003Dz6IWd6QuCIEzUNx_3ystopQU_003D;

	private ConfigurationInterface _0023_003DzpDeA_T0GQhTvEsqvyBPjoOE_003D;

	private EdgeInterface _0023_003DzUiuAMGlwri4_0024ZaavAXM_ZA8_003D;

	public UI00Options Options
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (6 == 0)
			{
			}
			return _0023_003DzlptUyaPsFjOO_0024kvUyw_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
			{
				_0023_003DzlptUyaPsFjOO_0024kvUyw_003D_003D = value;
			}
		}
	}

	public IScriptingReportServices ReportServices
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (3 == 0)
			{
			}
			return _0023_003Dzs_0024LQUOjPiCXcdcQSvdo39G4_003D;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003Dzs_0024LQUOjPiCXcdcQSvdo39G4_003D = value;
			}
		}
	}

	public ProjectInterface ProjectInterface
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (-1 == 0)
			{
			}
			return _0023_003DzxVdxKd51PC85gWLCEQ_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (3u != 0)
			{
				_0023_003DzxVdxKd51PC85gWLCEQ_003D_003D = value;
			}
		}
	}

	public ToolInterface ToolInterface
	{
		[CompilerGenerated]
		get
		{
			_ = 8;
			if (5 == 0)
			{
			}
			return _0023_003DzoRkSIgxkf8kpxX5vXTfeuf0_003D;
		}
		[CompilerGenerated]
		set
		{
			if (0 == 0)
			{
				_0023_003DzoRkSIgxkf8kpxX5vXTfeuf0_003D = value;
			}
		}
	}

	public ConfigurationInterface ConfigurationInterface
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (3 == 0)
			{
			}
			return _0023_003Dz6IWd6QuCIEzUNx_3ystopQU_003D;
		}
		[CompilerGenerated]
		set
		{
			if (true)
			{
				_0023_003Dz6IWd6QuCIEzUNx_3ystopQU_003D = value;
			}
		}
	}

	public ConfigurationInterface SupportInterface
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (2 == 0)
			{
			}
			return _0023_003DzpDeA_T0GQhTvEsqvyBPjoOE_003D;
		}
		[CompilerGenerated]
		set
		{
			if (true)
			{
				_0023_003DzpDeA_T0GQhTvEsqvyBPjoOE_003D = value;
			}
		}
	}

	public EdgeInterface EdgeInterface
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (3 == 0)
			{
			}
			return _0023_003DzUiuAMGlwri4_0024ZaavAXM_ZA8_003D;
		}
		[CompilerGenerated]
		set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003DzUiuAMGlwri4_0024ZaavAXM_ZA8_003D = value;
			}
		}
	}

	public OperationContext()
	{
		if (7u != 0)
		{
			Options = null;
		}
		if (0 == 0)
		{
			ReportServices = null;
		}
		if (8u != 0)
		{
			ProjectInterface = null;
		}
		ToolInterface = null;
		EdgeInterface = null;
		ConfigurationInterface = null;
		SupportInterface = null;
	}
}
