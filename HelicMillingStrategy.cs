using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class HelicMillingStrategy : Strategy
{
	private double _0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D;

	private bool _0023_003DzKbKeS8ZW2BABZhC4I9qXdQPBBfl0;

	private double _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;

	public double AxialCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (1 == 0)
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

	public bool AllowsFinishCutting
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (6 == 0)
			{
			}
			return _0023_003DzKbKeS8ZW2BABZhC4I9qXdQPBBfl0;
		}
		[CompilerGenerated]
		set
		{
			if (7u != 0)
			{
				_0023_003DzKbKeS8ZW2BABZhC4I9qXdQPBBfl0 = value;
			}
		}
	}

	public double AxialFinishCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (6 == 0)
			{
			}
			return _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
			{
				_0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D = value;
			}
		}
	}

	public HelicMillingStrategy()
	{
		if (2u != 0)
		{
			AxialCuttingDepth = 0.0;
		}
		if (uint.MaxValue != 0)
		{
			AxialFinishCuttingDepth = 0.0;
		}
		if (uint.MaxValue != 0)
		{
			AllowsFinishCutting = false;
		}
	}

	public HelicMillingStrategy(double cuttingDepth, bool allowsFinishCutting, double finishCuttingDepth)
	{
		if (4u != 0)
		{
			AxialCuttingDepth = cuttingDepth;
		}
		if (true)
		{
			AllowsFinishCutting = allowsFinishCutting;
		}
		if (4u != 0)
		{
			AxialFinishCuttingDepth = finishCuttingDepth;
		}
	}
}
