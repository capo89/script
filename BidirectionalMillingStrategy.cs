using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class BidirectionalMillingStrategy : Strategy
{
	private bool _0023_003DzOdmE9RlgomWeY279VHQuyNQ_003D;

	private double _0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D;

	private double _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;

	public bool AllowMultiplePasses
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (6 == 0)
			{
			}
			return _0023_003DzOdmE9RlgomWeY279VHQuyNQ_003D;
		}
		[CompilerGenerated]
		set
		{
			if (4u != 0)
			{
				_0023_003DzOdmE9RlgomWeY279VHQuyNQ_003D = value;
			}
		}
	}

	public double AxialCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (3 == 0)
			{
			}
			return _0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (4u != 0)
			{
				_0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D = value;
			}
		}
	}

	public double AxialFinishCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (8 == 0)
			{
			}
			return _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;
		}
		[CompilerGenerated]
		set
		{
			if (3u != 0)
			{
				_0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D = value;
			}
		}
	}

	public BidirectionalMillingStrategy()
	{
		if (5u != 0)
		{
			AllowMultiplePasses = false;
		}
		if (uint.MaxValue != 0)
		{
			AxialCuttingDepth = 0.0;
		}
		if (8u != 0)
		{
			AxialFinishCuttingDepth = 0.0;
		}
	}

	public BidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth)
	{
		if (true)
		{
			AllowMultiplePasses = allowMultiplePasses;
		}
		if (6u != 0)
		{
			AxialCuttingDepth = cuttingDepth;
		}
		if (5u != 0)
		{
			AxialFinishCuttingDepth = finishCuttingDepth;
		}
	}
}
