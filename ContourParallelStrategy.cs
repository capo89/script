using System.Runtime.CompilerServices;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Strategy;

namespace ScmGroup.XCam.Scripting;

public class ContourParallelStrategy : Strategy
{
	private bool _0023_003DzOdmE9RlgomWeY279VHQuyNQ_003D;

	private RotDirection _0023_003DztTEEFJ6ccTfHkBgAKG8u7jo_003D;

	private double _0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D;

	private double _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;

	private StrokeConnectionStrategy _0023_003DzigPWnpIws5hSrciV28TK1Lk_003D;

	private bool _0023_003DzOZNAnEYBKZwqCD_0024Lm4z_0024xFo_003D;

	private bool _0023_003DzUxi2mpZ5hrRU2RpdjwnWnSvLvozQ;

	private bool _0023_003DzKmGRq4hOwJkqc6N7v5AStw1CiaDml2dhrzY7hgO3rA0b;

	private double _0023_003Dz2xeXuYEyjENnGMb2_YAWHMS1VCtu;

	public bool AllowMultiplePasses
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (false)
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

	public RotDirection RotationDirection
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (2 == 0)
			{
			}
			return _0023_003DztTEEFJ6ccTfHkBgAKG8u7jo_003D;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
			{
				_0023_003DztTEEFJ6ccTfHkBgAKG8u7jo_003D = value;
			}
		}
	}

	public double AxialCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (6 == 0)
			{
			}
			return _0023_003DzPG7SNsPLvcKT1s6U96gmgxvAn2cGNV4rHQ_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (uint.MaxValue != 0)
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
			if (0 == 0)
			{
				_0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D = value;
			}
		}
	}

	public StrokeConnectionStrategy StrokeConnectionType
	{
		[CompilerGenerated]
		get
		{
			_ = 3;
			if (4 == 0)
			{
			}
			return _0023_003DzigPWnpIws5hSrciV28TK1Lk_003D;
		}
		[CompilerGenerated]
		set
		{
			if (7u != 0)
			{
				_0023_003DzigPWnpIws5hSrciV28TK1Lk_003D = value;
			}
		}
	}

	public bool InsideToOutSide
	{
		[CompilerGenerated]
		get
		{
			_ = 7;
			if (false)
			{
			}
			return _0023_003DzOZNAnEYBKZwqCD_0024Lm4z_0024xFo_003D;
		}
		[CompilerGenerated]
		set
		{
			if (3u != 0)
			{
				_0023_003DzOZNAnEYBKZwqCD_0024Lm4z_0024xFo_003D = value;
			}
		}
	}

	public bool IsHelicStrategy
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (3 == 0)
			{
			}
			return _0023_003DzUxi2mpZ5hrRU2RpdjwnWnSvLvozQ;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003DzUxi2mpZ5hrRU2RpdjwnWnSvLvozQ = value;
			}
		}
	}

	public bool IsApproachRetractPassStrategy
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (3 == 0)
			{
			}
			return _0023_003DzKmGRq4hOwJkqc6N7v5AStw1CiaDml2dhrzY7hgO3rA0b;
		}
		[CompilerGenerated]
		set
		{
			if (0 == 0)
			{
				_0023_003DzKmGRq4hOwJkqc6N7v5AStw1CiaDml2dhrzY7hgO3rA0b = value;
			}
		}
	}

	public double AllowanceSide
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (false)
			{
			}
			return _0023_003Dz2xeXuYEyjENnGMb2_YAWHMS1VCtu;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003Dz2xeXuYEyjENnGMb2_YAWHMS1VCtu = value;
			}
		}
	}

	public ContourParallelStrategy()
	{
		if (7u != 0)
		{
			AllowMultiplePasses = false;
		}
		if (3u != 0)
		{
			RotationDirection = RotDirection.CounterClockwise;
		}
		if (3u != 0)
		{
			AxialCuttingDepth = 0.0;
		}
		AxialFinishCuttingDepth = 0.0;
		StrokeConnectionType = StrokeConnectionStrategy.LiftShiftPlunge;
		InsideToOutSide = true;
		IsHelicStrategy = false;
		IsApproachRetractPassStrategy = false;
		AllowanceSide = 0.0;
	}

	public ContourParallelStrategy(bool insideToOutSide, RotDirection rotationDirection, bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth, StrokeConnectionStrategy strokeConnectionStrategy, bool isHelicStrategy, bool isApproachRetractPassStrategy, double allowanceSide)
	{
		if (2u != 0)
		{
			InsideToOutSide = insideToOutSide;
		}
		if (8u != 0)
		{
			RotationDirection = rotationDirection;
		}
		if (7u != 0)
		{
			AllowMultiplePasses = allowMultiplePasses;
		}
		AxialCuttingDepth = cuttingDepth;
		AxialFinishCuttingDepth = finishCuttingDepth;
		StrokeConnectionType = strokeConnectionStrategy;
		IsHelicStrategy = isHelicStrategy;
		IsApproachRetractPassStrategy = StrokeConnectionType == StrokeConnectionStrategy.LiftShiftPlunge && isApproachRetractPassStrategy;
		AllowanceSide = allowanceSide;
	}
}
