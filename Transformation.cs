using OccExtension;
using ScmGroup.XCam.Common.Utility;

namespace ScmGroup.XCam.Scripting;

public class Transformation
{
	private string _0023_003DzxcGQZyTw7IH94fm2uhJjL2AUd80m;

	private gp_Pnt _0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D;

	private bool _0023_003DzDsr_IN8PtSbKcKdmXQ_003D_003D;

	private bool _0023_003DzCxft3RylGIBxf1NPBQ_003D_003D;

	private bool _0023_003DzTYoTg94QVpjuO96rVeIFXB0_003D;

	private double _0023_003DzM_SfDfoFCfwu;

	private gp_Pnt _0023_003DzHGA0eSr_Qj0a;

	public Transformation()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		string empty = string.Empty;
		if (8u != 0)
		{
			_0023_003DzxcGQZyTw7IH94fm2uhJjL2AUd80m = empty;
		}
		gp_Pnt val = new gp_Pnt(0.0, 0.0, 0.0);
		if (8u != 0)
		{
			_0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D = val;
		}
		gp_Pnt val2 = new gp_Pnt(0.0, 0.0, 0.0);
		if (3u != 0)
		{
			_0023_003DzHGA0eSr_Qj0a = val2;
		}
		base._002Ector();
	}

	public void SetRotation(double angle, double x, double y, double z)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (0 == 0)
		{
			_0023_003DzM_SfDfoFCfwu = angle;
		}
		gp_Pnt val = new gp_Pnt(x, y, z);
		if (3u != 0)
		{
			_0023_003DzHGA0eSr_Qj0a = val;
		}
	}

	public void SetTranslation(double x, double y, double z, string planeName)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		gp_Pnt val = new gp_Pnt(x, y, z);
		if (4u != 0)
		{
			_0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D = val;
		}
		if (MathUtility.IsEqual(x, 0.0) && MathUtility.IsEqual(y, 0.0) && MathUtility.IsEqual(z, 0.0))
		{
			string empty = string.Empty;
			if (true)
			{
				_0023_003DzxcGQZyTw7IH94fm2uhJjL2AUd80m = empty;
			}
		}
		else if (7u != 0)
		{
			_0023_003DzxcGQZyTw7IH94fm2uhJjL2AUd80m = planeName;
		}
	}

	public void SetMirror(bool mirrorX, bool mirrorY, bool arcInversion)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzDsr_IN8PtSbKcKdmXQ_003D_003D = mirrorX;
		}
		if (8u != 0)
		{
			_0023_003DzCxft3RylGIBxf1NPBQ_003D_003D = mirrorY;
		}
		if (8u != 0)
		{
			_0023_003DzTYoTg94QVpjuO96rVeIFXB0_003D = arcInversion;
		}
	}

	public void SetMirrorX(bool mirror, bool arcInversion)
	{
		if (true)
		{
			_0023_003DzDsr_IN8PtSbKcKdmXQ_003D_003D = mirror;
		}
		if (true)
		{
			_0023_003DzTYoTg94QVpjuO96rVeIFXB0_003D = arcInversion;
		}
	}

	public void SetMirrorY(bool mirror, bool arcInversion)
	{
		if (7u != 0)
		{
			_0023_003DzCxft3RylGIBxf1NPBQ_003D_003D = mirror;
		}
		if (0 == 0)
		{
			_0023_003DzTYoTg94QVpjuO96rVeIFXB0_003D = arcInversion;
		}
	}

	public bool HasRotation()
	{
		_ = 6;
		if (6 == 0)
		{
		}
		return !MathUtility.IsEqual(_0023_003DzM_SfDfoFCfwu, PrecisionExtension.Angular());
	}

	public bool HasTranslation(string planeName)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		if (MathUtility.IsEqual(_0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D.X(), 0.0))
		{
			_ = 7;
			if (2 == 0)
			{
			}
			if (MathUtility.IsEqual(_0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D.Y(), 0.0))
			{
				_ = 4;
				if (7 == 0)
				{
				}
				if (MathUtility.IsEqual(_0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D.Z(), 0.0))
				{
					return false;
				}
			}
		}
		if (!(_0023_003DzxcGQZyTw7IH94fm2uhJjL2AUd80m == string.Empty))
		{
			return _0023_003DzxcGQZyTw7IH94fm2uhJjL2AUd80m == planeName;
		}
		return true;
	}

	public bool HasMirror()
	{
		_ = 8;
		if (4 == 0)
		{
		}
		if (!_0023_003DzDsr_IN8PtSbKcKdmXQ_003D_003D)
		{
			_ = 3;
			if (1 == 0)
			{
			}
			return _0023_003DzCxft3RylGIBxf1NPBQ_003D_003D;
		}
		return true;
	}

	public bool HasMirrorX()
	{
		_ = 0;
		if (4 == 0)
		{
		}
		return _0023_003DzDsr_IN8PtSbKcKdmXQ_003D_003D;
	}

	public bool HasMirrorY()
	{
		_ = 0;
		if (4 == 0)
		{
		}
		return _0023_003DzCxft3RylGIBxf1NPBQ_003D_003D;
	}

	public void Rotate(ref double x, ref double y)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		if (HasRotation())
		{
			gp_Trsf val = new gp_Trsf();
			gp_Trsf val2;
			if (7u != 0)
			{
				val2 = val;
			}
			val2.SetRotation(new gp_Ax1(_0023_003DzHGA0eSr_Qj0a, new gp_Dir(0.0, 0.0, 1.0)), _0023_003DzM_SfDfoFCfwu);
			gp_Pnt val3 = new gp_Pnt(x, y, 0.0);
			gp_Pnt val4;
			if (8u != 0)
			{
				val4 = val3;
			}
			val4.Transform(val2);
			x = val4.X();
			y = val4.Y();
		}
	}

	public void Translate(ref double x, ref double y, string planeName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		if (HasTranslation(planeName))
		{
			gp_Trsf val = new gp_Trsf();
			gp_Trsf val2;
			if (uint.MaxValue != 0)
			{
				val2 = val;
			}
			val2.SetTranslation(new gp_Pnt(0.0, 0.0, 0.0), _0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D);
			gp_Pnt val3 = new gp_Pnt(x, y, 0.0);
			gp_Pnt val4;
			if (3u != 0)
			{
				val4 = val3;
			}
			val4.Transform(val2);
			x = val4.X();
			y = val4.Y();
		}
	}

	public void Translate(ref double z, string planeName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (HasTranslation(planeName))
		{
			gp_Trsf val = new gp_Trsf();
			gp_Trsf val2;
			if (8u != 0)
			{
				val2 = val;
			}
			val2.SetTranslation(new gp_Pnt(0.0, 0.0, 0.0), _0023_003DzrPSkzqXpX1ztbCqPMIUx6qg_003D);
			gp_Pnt val3 = new gp_Pnt(0.0, 0.0, z);
			gp_Pnt val4;
			if (true)
			{
				val4 = val3;
			}
			val4.Transform(val2);
			z = val4.Z();
		}
	}

	public bool HasArcInversion()
	{
		_ = 7;
		if (8 == 0)
		{
		}
		return _0023_003DzTYoTg94QVpjuO96rVeIFXB0_003D;
	}

	public void Mirror(ref double x, ref double y, double DX, double DY)
	{
		_ = 8;
		if (1 == 0)
		{
		}
		if (_0023_003DzDsr_IN8PtSbKcKdmXQ_003D_003D)
		{
			_ = -1;
			if (7 == 0)
			{
			}
			_ = 2;
			if (-1 == 0)
			{
			}
			x = DX - x;
		}
		if (_0023_003DzCxft3RylGIBxf1NPBQ_003D_003D)
		{
			y = DY - y;
		}
	}
}
