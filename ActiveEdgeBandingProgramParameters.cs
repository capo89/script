using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class ActiveEdgeBandingProgramParameters : ActiveProgramParameters
{
	private EdgeBandingInOut _0023_003DzOtzX1QDVnqaHXdW_MINUIbQACu3h8E4enQ_003D_003D;

	private EdgeDispensingManager _0023_003DzIb3moP3suGHhs_dIrUl6aaM1lQSRo3_n1Q_003D_003D;

	private EdgeClosingManager _0023_003Dzpw08DJUXCIbyR9iHOaLGvR0_003D;

	public EdgeBandingInOut EdgeBandingInOut
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (8 == 0)
			{
			}
			return _0023_003DzOtzX1QDVnqaHXdW_MINUIbQACu3h8E4enQ_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
			{
				_0023_003DzOtzX1QDVnqaHXdW_MINUIbQACu3h8E4enQ_003D_003D = value;
			}
		}
	}

	public EdgeDispensingManager EdgeDispensingManager
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (6 == 0)
			{
			}
			return _0023_003DzIb3moP3suGHhs_dIrUl6aaM1lQSRo3_n1Q_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003DzIb3moP3suGHhs_dIrUl6aaM1lQSRo3_n1Q_003D_003D = value;
			}
		}
	}

	public EdgeClosingManager EdgeClosingManager
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (7 == 0)
			{
			}
			return _0023_003Dzpw08DJUXCIbyR9iHOaLGvR0_003D;
		}
		[CompilerGenerated]
		set
		{
			if (true)
			{
				_0023_003Dzpw08DJUXCIbyR9iHOaLGvR0_003D = value;
			}
		}
	}

	public ActiveEdgeBandingProgramParameters()
	{
		EdgeBandingInOut edgeBandingInOut = new EdgeBandingInOut();
		if (0 == 0)
		{
			EdgeBandingInOut = edgeBandingInOut;
		}
		EdgeDispensingManager edgeDispensingManager = new EdgeDispensingManager();
		if (8u != 0)
		{
			EdgeDispensingManager = edgeDispensingManager;
		}
		EdgeClosingManager edgeClosingManager = new EdgeClosingManager();
		if (6u != 0)
		{
			EdgeClosingManager = edgeClosingManager;
		}
	}
}
