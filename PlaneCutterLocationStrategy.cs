using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class PlaneCutterLocationStrategy : Strategy
{
	private double _0023_003Dz5o_cchxKOF_uWy1tAw_003D_003D;

	private double _0023_003Dz_2m7gnhtBexTXaCaOg_003D_003D;

	public double ZRotation
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (false)
			{
			}
			return _0023_003Dz5o_cchxKOF_uWy1tAw_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (6u != 0)
			{
				_0023_003Dz5o_cchxKOF_uWy1tAw_003D_003D = value;
			}
		}
	}

	public double XRotation
	{
		[CompilerGenerated]
		get
		{
			_ = 7;
			if (6 == 0)
			{
			}
			return _0023_003Dz_2m7gnhtBexTXaCaOg_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (6u != 0)
			{
				_0023_003Dz_2m7gnhtBexTXaCaOg_003D_003D = value;
			}
		}
	}

	public PlaneCutterLocationStrategy()
	{
		if (3u != 0)
		{
			ZRotation = 0.0;
		}
		if (0 == 0)
		{
			XRotation = 0.0;
		}
	}

	public PlaneCutterLocationStrategy(double zRotation, double xRotation)
	{
		if (true)
		{
			ZRotation = zRotation;
		}
		if (3u != 0)
		{
			XRotation = xRotation;
		}
	}
}
