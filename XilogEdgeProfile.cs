using System.Runtime.CompilerServices;
using ScmGroup.XCam.EdgeDataModel;

namespace ScmGroup.XCam.Scripting;

public class XilogEdgeProfile : XilogProfile
{
	private Edge _0023_003DzuY0PfxV97hkdfQS7Vg_003D_003D;

	private double? _0023_003DzgSvQ5cK99re4_qH4aQ_003D_003D;

	public Edge EdgeCurrent
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (3 == 0)
			{
			}
			return _0023_003DzuY0PfxV97hkdfQS7Vg_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (0 == 0)
			{
				_0023_003DzuY0PfxV97hkdfQS7Vg_003D_003D = value;
			}
		}
	}

	public double? Rotation
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (5 == 0)
			{
			}
			return _0023_003DzgSvQ5cK99re4_qH4aQ_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (2u != 0)
			{
				_0023_003DzgSvQ5cK99re4_qH4aQ_003D_003D = value;
			}
		}
	}

	public XilogEdgeProfile(Polyline geometryPath, double startX, double startY, double? startZ, double? inputFeed, string name, Edge edgeCurrent)
	{
		if (8u != 0)
		{
			GeometryPath = geometryPath;
		}
		if (8u != 0)
		{
			base.StartX = startX;
		}
		if (5u != 0)
		{
			base.StartY = startY;
		}
		base.StartZ = startZ;
		base.Name = name;
		EdgeCurrent = edgeCurrent;
		base.InputFeed = inputFeed;
	}
}
