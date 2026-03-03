using System.Runtime.CompilerServices;

namespace ScmGroup.XCam.Scripting;

public class EdgeBandingSlotOperationParameters : EdgeBandingOperationParameters
{
	private double _0023_003Dz3YOyiwD6UKhy4mb3HNPC0TM_003D;

	private double _0023_003DzNZVuF3cW9QLZ27fBAw_003D_003D;

	public double SlotEdgeZ
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (2 == 0)
			{
			}
			return _0023_003Dz3YOyiwD6UKhy4mb3HNPC0TM_003D;
		}
	}

	public double Angle
	{
		[CompilerGenerated]
		get
		{
			_ = 7;
			if (6 == 0)
			{
			}
			return _0023_003DzNZVuF3cW9QLZ27fBAw_003D_003D;
		}
	}

	public EdgeBandingSlotOperationParameters(string edgeCurrent, bool edgeManualLoading, string pressureTool, bool pressureToolManualLoading, double speed, double depth, double slotEdgeZ, double angle)
		: base(edgeCurrent, edgeManualLoading, pressureTool, pressureToolManualLoading, speed, depth)
	{
		if (7u != 0)
		{
			_0023_003Dz9NhGcgvq6Lxl(slotEdgeZ);
		}
		if (2u != 0)
		{
			_0023_003DzS9_coBoC5Dha(angle);
		}
	}

	internal void _0023_003Dz9NhGcgvq6Lxl(double _0023_003Dz3keKASA_003D)
	{
		if (2u != 0)
		{
			_0023_003Dz3YOyiwD6UKhy4mb3HNPC0TM_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzS9_coBoC5Dha(double _0023_003Dz3keKASA_003D)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzNZVuF3cW9QLZ27fBAw_003D_003D = _0023_003Dz3keKASA_003D;
		}
	}
}
