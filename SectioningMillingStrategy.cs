using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class SectioningMillingStrategy : Strategy
{
	private double _0023_003DztVCQoqh_RcANB2zh0NGLJic_003D;

	private double _0023_003DzPEcV9I8KlAq7KOORs5uErLY_003D;

	private double _0023_003DzsY9QOXRyNite8AiZpAuuTeI_003D;

	public double FirstCutDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 8;
			if (-1 == 0)
			{
			}
			return _0023_003DztVCQoqh_RcANB2zh0NGLJic_003D;
		}
		[CompilerGenerated]
		set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003DztVCQoqh_RcANB2zh0NGLJic_003D = value;
			}
		}
	}

	public double OutDistance
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (3 == 0)
			{
			}
			return _0023_003DzPEcV9I8KlAq7KOORs5uErLY_003D;
		}
		[CompilerGenerated]
		set
		{
			if (2u != 0)
			{
				_0023_003DzPEcV9I8KlAq7KOORs5uErLY_003D = value;
			}
		}
	}

	public double SideMovingDistance
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (8 == 0)
			{
			}
			return _0023_003DzsY9QOXRyNite8AiZpAuuTeI_003D;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
			{
				_0023_003DzsY9QOXRyNite8AiZpAuuTeI_003D = value;
			}
		}
	}

	public SectioningMillingStrategy()
	{
		if (true)
		{
			FirstCutDepth = 0.0;
		}
		if (6u != 0)
		{
			OutDistance = 0.0;
		}
		if (6u != 0)
		{
			SideMovingDistance = 0.0;
		}
	}

	public SectioningMillingStrategy(double firstCutDepth, double outDistance, double sideMovingDistance = 0.0)
	{
		if (uint.MaxValue != 0)
		{
			FirstCutDepth = firstCutDepth;
		}
		if (4u != 0)
		{
			OutDistance = outDistance;
		}
		if (2u != 0)
		{
			SideMovingDistance = sideMovingDistance;
		}
	}
}
