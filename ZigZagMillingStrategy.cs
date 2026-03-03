using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class ZigZagMillingStrategy : Strategy
{
	private double _0023_003DzLbRaxX2mLpHah_00247GEzow_VJOtjDS;

	private double _0023_003Dzvp2R8BMskKpSnsBugQz6V4BKRt5Y;

	private double _0023_003DzdvJ_TB8z8sUz2EcHAFnRcr3vT5aefCk_w9PxVPI_003D;

	public double FeedCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (7 == 0)
			{
			}
			return _0023_003DzLbRaxX2mLpHah_00247GEzow_VJOtjDS;
		}
		[CompilerGenerated]
		set
		{
			if (3u != 0)
			{
				_0023_003DzLbRaxX2mLpHah_00247GEzow_VJOtjDS = value;
			}
		}
	}

	public double ReturnCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (2 == 0)
			{
			}
			return _0023_003Dzvp2R8BMskKpSnsBugQz6V4BKRt5Y;
		}
		[CompilerGenerated]
		set
		{
			if (3u != 0)
			{
				_0023_003Dzvp2R8BMskKpSnsBugQz6V4BKRt5Y = value;
			}
		}
	}

	public double AxialFinishCuttingDepth
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (2 == 0)
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

	public ZigZagMillingStrategy()
	{
		if (7u != 0)
		{
			FeedCuttingDepth = 0.0;
		}
		if (true)
		{
			ReturnCuttingDepth = 0.0;
		}
		if (uint.MaxValue != 0)
		{
			AxialFinishCuttingDepth = 0.0;
		}
	}

	public ZigZagMillingStrategy(double feedCuttingDepth, double returnCuttingDepth, double finishCuttingDepth)
	{
		if (8u != 0)
		{
			FeedCuttingDepth = feedCuttingDepth;
		}
		if (0 == 0)
		{
			ReturnCuttingDepth = returnCuttingDepth;
		}
		if (7u != 0)
		{
			AxialFinishCuttingDepth = finishCuttingDepth;
		}
	}
}
