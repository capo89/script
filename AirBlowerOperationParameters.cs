using ScmGroup.XCam.MachiningDataModel.AirBlowering;

namespace ScmGroup.XCam.Scripting;

public class AirBlowerOperationParameters
{
	private Geometry _0023_003DzSx1eT_dj_QYa;

	private LeadInOut _0023_003DzzdTFhBCwcHEFNQH5fA_003D_003D;

	private Workpiece _0023_003DzLagNpYc9XxthP2794MJx3pk_003D;

	private MachineFunctions _0023_003DzjkyryUObWxzf;

	private Attributes _0023_003DzNHkRT1VF_0024U92;

	private Strategy _0023_003DzQNdSKyHgXgxw;

	private double _0023_003Dzlb_8yK0_003D;

	private double _0023_003DzZ2h_0024lrLKX06z;

	private BlowType _0023_003Dz9HCYhINVtTyG;

	private AirBlowerType _0023_003Dz9J5rsZWx3k0U0o_1Hg_003D_003D;

	public Geometry ActiveGeometry
	{
		get
		{
			_ = 1;
			if (1 == 0)
			{
			}
			return _0023_003DzSx1eT_dj_QYa;
		}
		set
		{
			if (4u != 0)
			{
				_0023_003DzSx1eT_dj_QYa = value;
			}
		}
	}

	public LeadInOut ActiveLeadInOut
	{
		get
		{
			_ = 6;
			if (1 == 0)
			{
			}
			return _0023_003DzzdTFhBCwcHEFNQH5fA_003D_003D;
		}
		set
		{
			if (0 == 0)
			{
				_0023_003DzzdTFhBCwcHEFNQH5fA_003D_003D = value;
			}
		}
	}

	public Workpiece ActiveWorkpiece
	{
		get
		{
			_ = 2;
			if (1 == 0)
			{
			}
			return _0023_003DzLagNpYc9XxthP2794MJx3pk_003D;
		}
		set
		{
			if (true)
			{
				_0023_003DzLagNpYc9XxthP2794MJx3pk_003D = value;
			}
		}
	}

	public MachineFunctions ActiveMachineFunctions
	{
		get
		{
			_ = 6;
			if (5 == 0)
			{
			}
			return _0023_003DzjkyryUObWxzf;
		}
		set
		{
			if (8u != 0)
			{
				_0023_003DzjkyryUObWxzf = value;
			}
		}
	}

	public Attributes ActiveAttributes
	{
		get
		{
			_ = 5;
			if (false)
			{
			}
			return _0023_003DzNHkRT1VF_0024U92;
		}
		set
		{
			if (true)
			{
				_0023_003DzNHkRT1VF_0024U92 = value;
			}
		}
	}

	public Strategy ActiveStrategy
	{
		get
		{
			_ = 8;
			if (3 == 0)
			{
			}
			return _0023_003DzQNdSKyHgXgxw;
		}
		set
		{
			if (true)
			{
				_0023_003DzQNdSKyHgXgxw = value;
			}
		}
	}

	public double Height
	{
		get
		{
			_ = 2;
			if (4 == 0)
			{
			}
			return _0023_003Dzlb_8yK0_003D;
		}
		set
		{
			if (true)
			{
				_0023_003Dzlb_8yK0_003D = value;
			}
		}
	}

	public double DistanceFromProfile
	{
		get
		{
			_ = 1;
			if (6 == 0)
			{
			}
			return _0023_003DzZ2h_0024lrLKX06z;
		}
		set
		{
			if (7u != 0)
			{
				_0023_003DzZ2h_0024lrLKX06z = value;
			}
		}
	}

	public BlowType BlowType
	{
		get
		{
			_ = 0;
			if (4 == 0)
			{
			}
			return _0023_003Dz9HCYhINVtTyG;
		}
		set
		{
			if (8u != 0)
			{
				_0023_003Dz9HCYhINVtTyG = value;
			}
		}
	}

	public AirBlowerType AirBlowerType
	{
		get
		{
			_ = -1;
			if (8 == 0)
			{
			}
			return _0023_003Dz9J5rsZWx3k0U0o_1Hg_003D_003D;
		}
		set
		{
			if (3u != 0)
			{
				_0023_003Dz9J5rsZWx3k0U0o_1Hg_003D_003D = value;
			}
		}
	}

	public AirBlowerOperationParameters(double height, double distanceFromProfile, BlowType blowType, AirBlowerType airBlowerType)
	{
		if (3u != 0)
		{
			_0023_003Dzlb_8yK0_003D = height;
		}
		if (5u != 0)
		{
			_0023_003DzZ2h_0024lrLKX06z = distanceFromProfile;
		}
		if (6u != 0)
		{
			_0023_003Dz9HCYhINVtTyG = blowType;
		}
		_0023_003Dz9J5rsZWx3k0U0o_1Hg_003D_003D = airBlowerType;
	}
}
