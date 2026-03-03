using System.Runtime.CompilerServices;
using ScmGroup.XCam.MachiningDataModel.Strategy;

namespace ScmGroup.XCam.Scripting;

public class UnidirectionalMillingStrategy : Strategy
{
	private bool _0023_003DzOdmE9RlgomWeY279VHQuyNQ_003D;

	private double _0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D;

	private double _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;

	private StrokeConnectionStrategy _0023_003DzyGV0Nn1mfrqrtmfsJwGr6sU_003D;

	private bool _0023_003DzKmGRq4hOwJkqc6N7v5AStw1CiaDml2dhrzY7hgO3rA0b;

	public bool AllowMultiplePasses
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (2 == 0)
			{
			}
			return _0023_003DzOdmE9RlgomWeY279VHQuyNQ_003D;
		}
		[CompilerGenerated]
		set
		{
			if (7u != 0)
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
			_ = 3;
			if (4 == 0)
			{
			}
			return _0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (2u != 0)
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
			_ = 5;
			if (8 == 0)
			{
			}
			return _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;
		}
		[CompilerGenerated]
		set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D = value;
			}
		}
	}

	public StrokeConnectionStrategy StrokeConnectionStrategy
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (-1 == 0)
			{
			}
			return _0023_003DzyGV0Nn1mfrqrtmfsJwGr6sU_003D;
		}
		[CompilerGenerated]
		set
		{
			if (true)
			{
				_0023_003DzyGV0Nn1mfrqrtmfsJwGr6sU_003D = value;
			}
		}
	}

	public bool IsApproachRetractPassStrategy
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (2 == 0)
			{
			}
			return _0023_003DzKmGRq4hOwJkqc6N7v5AStw1CiaDml2dhrzY7hgO3rA0b;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
			{
				_0023_003DzKmGRq4hOwJkqc6N7v5AStw1CiaDml2dhrzY7hgO3rA0b = value;
			}
		}
	}

	public UnidirectionalMillingStrategy()
	{
		if (5u != 0)
		{
			AllowMultiplePasses = false;
		}
		if (6u != 0)
		{
			AxialCuttingDepth = 0.0;
		}
		if (6u != 0)
		{
			AxialFinishCuttingDepth = 0.0;
		}
		StrokeConnectionStrategy = StrokeConnectionStrategy.LiftShiftPlunge;
		IsApproachRetractPassStrategy = false;
	}

	public UnidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth, StrokeConnectionStrategy strokeConnectionStrategy, bool isApproachRetractPassStrategy)
	{
		if (uint.MaxValue != 0)
		{
			AllowMultiplePasses = allowMultiplePasses;
		}
		if (4u != 0)
		{
			AxialCuttingDepth = cuttingDepth;
		}
		if (2u != 0)
		{
			AxialFinishCuttingDepth = finishCuttingDepth;
		}
		StrokeConnectionStrategy = strokeConnectionStrategy;
		IsApproachRetractPassStrategy = StrokeConnectionStrategy == StrokeConnectionStrategy.LiftShiftPlunge && isApproachRetractPassStrategy;
	}
}
