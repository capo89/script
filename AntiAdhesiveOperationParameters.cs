using ScmGroup.XCam.MachiningDataModel;

namespace ScmGroup.XCam.Scripting;

public class AntiAdhesiveOperationParameters
{
	private string _0023_003DzcEzC8I8_003D;

	private string _0023_003DzjA_SpKs_003D;

	private double _0023_003DzzfzVzOEzeQb1;

	private double _0023_003Dz_9tJPCBO2z3I;

	private double _0023_003DzADd4a707bdqr;

	private double _0023_003DzIR8qkCbu_Tw5;

	private double _0023_003DzyBUqf3j37CrRTzbe7w_003D_003D;

	private double _0023_003Dz5ezkZJVHoSJDWafrHQ_003D_003D;

	private double _0023_003DzV_hcZLZ6qut11GnpDw_003D_003D;

	private double _0023_003Dz8v2MFAm7G7WlgrwUcQ_003D_003D;

	private AntiAdhesiveType _0023_003Dz9mDCoYs3_I61a4kXC__t6bY_003D;

	public string Tool
	{
		get
		{
			_ = 7;
			if (4 == 0)
			{
			}
			return _0023_003DzcEzC8I8_003D;
		}
		set
		{
			if (6u != 0)
			{
				_0023_003DzcEzC8I8_003D = value;
			}
		}
	}

	public string Head
	{
		get
		{
			_ = 0;
			if (4 == 0)
			{
			}
			return _0023_003DzjA_SpKs_003D;
		}
		set
		{
			if (4u != 0)
			{
				_0023_003DzjA_SpKs_003D = value;
			}
		}
	}

	public double OverMaterial
	{
		get
		{
			_ = 5;
			if (6 == 0)
			{
			}
			return _0023_003DzzfzVzOEzeQb1;
		}
		set
		{
			if (7u != 0)
			{
				_0023_003DzzfzVzOEzeQb1 = value;
			}
		}
	}

	public double InputSpeed
	{
		get
		{
			_ = 3;
			if (-1 == 0)
			{
			}
			return _0023_003Dz_9tJPCBO2z3I;
		}
		set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003Dz_9tJPCBO2z3I = value;
			}
		}
	}

	public double Speed
	{
		get
		{
			_ = 1;
			if (8 == 0)
			{
			}
			return _0023_003DzADd4a707bdqr;
		}
		set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003DzADd4a707bdqr = value;
			}
		}
	}

	public double RotSpeed
	{
		get
		{
			_ = 8;
			if (3 == 0)
			{
			}
			return _0023_003DzIR8qkCbu_Tw5;
		}
		set
		{
			if (3u != 0)
			{
				_0023_003DzIR8qkCbu_Tw5 = value;
			}
		}
	}

	public double InfeedAdvance
	{
		get
		{
			_ = 5;
			if (7 == 0)
			{
			}
			return _0023_003DzyBUqf3j37CrRTzbe7w_003D_003D;
		}
		set
		{
			if (5u != 0)
			{
				_0023_003DzyBUqf3j37CrRTzbe7w_003D_003D = value;
			}
		}
	}

	public double OutfeedDelay
	{
		get
		{
			_ = 4;
			if (8 == 0)
			{
			}
			return _0023_003Dz5ezkZJVHoSJDWafrHQ_003D_003D;
		}
		set
		{
			if (6u != 0)
			{
				_0023_003Dz5ezkZJVHoSJDWafrHQ_003D_003D = value;
			}
		}
	}

	public double ApproachAngle
	{
		get
		{
			_ = 1;
			if (5 == 0)
			{
			}
			return _0023_003DzV_hcZLZ6qut11GnpDw_003D_003D;
		}
		set
		{
			if (2u != 0)
			{
				_0023_003DzV_hcZLZ6qut11GnpDw_003D_003D = value;
			}
		}
	}

	public double RetractAngle
	{
		get
		{
			_ = 8;
			if (5 == 0)
			{
			}
			return _0023_003Dz8v2MFAm7G7WlgrwUcQ_003D_003D;
		}
		set
		{
			if (0 == 0)
			{
				_0023_003Dz8v2MFAm7G7WlgrwUcQ_003D_003D = value;
			}
		}
	}

	public AntiAdhesiveType AntiAdhesiveType
	{
		get
		{
			_ = 6;
			if (5 == 0)
			{
			}
			return _0023_003Dz9mDCoYs3_I61a4kXC__t6bY_003D;
		}
		set
		{
			if (3u != 0)
			{
				_0023_003Dz9mDCoYs3_I61a4kXC__t6bY_003D = value;
			}
		}
	}

	public AntiAdhesiveOperationParameters(AntiAdhesiveType antiAdhesiveType, string tool, string head, double overMaterial, double approachAngle, double infeedAdvance, double outfeedDelay, double inputSpeed, double speed, double rotSpeed, double retractAngle)
	{
		if (5u != 0)
		{
			_0023_003Dz9mDCoYs3_I61a4kXC__t6bY_003D = antiAdhesiveType;
		}
		if (5u != 0)
		{
			_0023_003DzcEzC8I8_003D = tool;
		}
		if (8u != 0)
		{
			_0023_003DzjA_SpKs_003D = head;
		}
		_0023_003DzzfzVzOEzeQb1 = overMaterial;
		_0023_003DzV_hcZLZ6qut11GnpDw_003D_003D = approachAngle;
		_0023_003DzyBUqf3j37CrRTzbe7w_003D_003D = infeedAdvance;
		_0023_003Dz5ezkZJVHoSJDWafrHQ_003D_003D = outfeedDelay;
		_0023_003Dz8v2MFAm7G7WlgrwUcQ_003D_003D = retractAngle;
		_0023_003Dz_9tJPCBO2z3I = inputSpeed;
		_0023_003DzADd4a707bdqr = speed;
		_0023_003DzIR8qkCbu_Tw5 = rotSpeed;
	}
}
