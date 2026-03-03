using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class MultiStepDrillingStrategy : Strategy
{
	private int _0023_003DzO3Tg00Vh_9DsU1FqRaIhpIY_003D;

	private double _0023_003DzDrrhimU_0024Bn_0024YBGGH0TDhThE_003D;

	private bool _0023_003Dz4MMXvFFLb4mFSO0sil_9JSA_003D;

	public int StepNumber
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (4 == 0)
			{
			}
			return _0023_003DzO3Tg00Vh_9DsU1FqRaIhpIY_003D;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
			{
				_0023_003DzO3Tg00Vh_9DsU1FqRaIhpIY_003D = value;
			}
		}
	}

	public double StepDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (4 == 0)
			{
			}
			return _0023_003DzDrrhimU_0024Bn_0024YBGGH0TDhThE_003D;
		}
		[CompilerGenerated]
		set
		{
			if (4u != 0)
			{
				_0023_003DzDrrhimU_0024Bn_0024YBGGH0TDhThE_003D = value;
			}
		}
	}

	public bool IsStepDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (5 == 0)
			{
			}
			return _0023_003Dz4MMXvFFLb4mFSO0sil_9JSA_003D;
		}
		[CompilerGenerated]
		set
		{
			if (0 == 0)
			{
				_0023_003Dz4MMXvFFLb4mFSO0sil_9JSA_003D = value;
			}
		}
	}

	public MultiStepDrillingStrategy()
	{
		if (0 == 0)
		{
			StepNumber = 1;
		}
		if (3u != 0)
		{
			StepDepth = 0.0;
		}
		if (true)
		{
			IsStepDepth = false;
		}
	}

	public MultiStepDrillingStrategy(bool isStepDepth, int stepNumber = 1, double stepDepth = 0.0)
	{
		if (2u != 0)
		{
			IsStepDepth = isStepDepth;
		}
		if (5u != 0)
		{
			StepNumber = stepNumber;
		}
		if (5u != 0)
		{
			StepDepth = stepDepth;
		}
	}
}
