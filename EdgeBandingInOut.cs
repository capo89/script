using System;
using System.Runtime.CompilerServices;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.MachiningDataModel.Strategy;

namespace ScmGroup.XCam.Scripting;

public class EdgeBandingInOut : LeadInOut
{
	private EdgeBandingRetractStrategy _0023_003DzPWwhSvm5soQEY7HtfGJupyY_003D;

	private EdgeBandingApproachStrategy _0023_003Dz4xgfm9grtgSUBconGesQiUjByZwu;

	private UI00EdgeBandingOptions _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D;

	private UI00Options _0023_003DzgK1Mwoo_003D;

	public EdgeBandingRetractStrategy Retract
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (2 == 0)
			{
			}
			return _0023_003DzPWwhSvm5soQEY7HtfGJupyY_003D;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003DzPWwhSvm5soQEY7HtfGJupyY_003D = value;
			}
		}
	}

	public EdgeBandingApproachStrategy Approach
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (2 == 0)
			{
			}
			return _0023_003Dz4xgfm9grtgSUBconGesQiUjByZwu;
		}
		[CompilerGenerated]
		set
		{
			if (3u != 0)
			{
				_0023_003Dz4xgfm9grtgSUBconGesQiUjByZwu = value;
			}
		}
	}

	public EdgeBandingInOut()
	{
		UI00EdgeBandingOptions edgeBandingOptions = AppInfo.CurrentOptions<UI00Options>().EdgeBandingOptions;
		if (6u != 0)
		{
			_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D = edgeBandingOptions;
		}
		UI00Options uI00Options = AppInfo.CurrentOptions<UI00Options>();
		if (true)
		{
			_0023_003DzgK1Mwoo_003D = uI00Options;
		}
		if (0 == 0)
		{
			_0023_003Dz5rEh9iOZqhtHNNo29oS7Kv4_003D();
		}
	}

	private void _0023_003Dz5rEh9iOZqhtHNNo29oS7Kv4_003D()
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzEKF6VUU2AYQL3PWMpVhf1bw_003D();
		}
		if (5u != 0)
		{
			_0023_003Dzz6IJODyh1HxBsVaye5qLmqw_003D();
		}
	}

	private void _0023_003DzEKF6VUU2AYQL3PWMpVhf1bw_003D()
	{
		EdgeBandingApproachStrategy approach = new EdgeBandingApproachStrategy();
		if (2u != 0)
		{
			Approach = approach;
		}
		Approach.InterpolationSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachInterpolationSpeed;
		Approach.Speed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachSpeed;
		Approach.StartApproachSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachMagazineSpeed;
		Approach.EdgeDispensingApproachSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachEdgeDispensingSpeed;
		Approach.StopTime = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachStopTime;
		Approach.FirstPointStrategy = new EdgeBandingPoint();
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousAngle);
		double angle;
		if (8u != 0)
		{
			angle = num;
		}
		Approach.FirstPointStrategy.UpdatePolarCoordinates(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousDistance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousC);
		double num3;
		if (5u != 0)
		{
			num3 = num2;
		}
		Approach.FirstPointStrategy.Rotation = num3 + Math.PI / 2.0;
		Approach.LastPointStrategy = new EdgeBandingPoint();
		double angle2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DescentR);
		Approach.LastPointStrategy.UpdatePolarCoordinates(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DescentD, angle2);
		double num4 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DescentC);
		Approach.LastPointStrategy.Rotation = num4 + Math.PI / 2.0;
		Approach.Lamp = new EdgeLamp();
		Approach.Lamp.Status = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.IsLampOn;
		Approach.Lamp.Power = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.LampPowerValue;
	}

	private void _0023_003Dzz6IJODyh1HxBsVaye5qLmqw_003D()
	{
		EdgeBandingRetractStrategy retract = new EdgeBandingRetractStrategy();
		if (true)
		{
			Retract = retract;
		}
		Retract.StopTime = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RetractStopTime;
		Retract.InterpolationSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RetractInterpolationSpeed;
		Retract.Speed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RetractSpeed;
		Retract.FirstPointStrategy = new EdgeBandingPoint();
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointAngle);
		double angle;
		if (6u != 0)
		{
			angle = num;
		}
		Retract.FirstPointStrategy.UpdatePolarCoordinates(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointDistance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointC);
		double num3 = default(double);
		if (0 == 0)
		{
			num3 = num2;
		}
		Retract.FirstPointStrategy.Rotation = num3 + Math.PI / 2.0;
	}

	public void ResetEdgeBandingIn()
	{
		if (4u != 0)
		{
			_0023_003DzEKF6VUU2AYQL3PWMpVhf1bw_003D();
		}
	}

	public void ResetEdgeBandingOut()
	{
		if (4u != 0)
		{
			_0023_003Dzz6IJODyh1HxBsVaye5qLmqw_003D();
		}
	}

	public void CreateEdgeBandingIn(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null)
	{
		if (approachSpeed.HasValue)
		{
			Approach.Speed = approachSpeed.Value;
		}
		if (approachMagazineSpeed.HasValue)
		{
			Approach.StartApproachSpeed = approachMagazineSpeed.Value;
		}
		if (stopTime.HasValue)
		{
			Approach.StopTime = stopTime.Value;
		}
		if (stopTime.HasValue)
		{
			Approach.StopTime = stopTime.Value;
		}
		if (isLampOn.HasValue)
		{
			Approach.Lamp.Status = isLampOn.Value;
		}
		if (lampPower.HasValue)
		{
			Approach.Lamp.Power = lampPower.Value;
		}
		double rendezVousDistance = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousDistance;
		double distance = default(double);
		if (0 == 0)
		{
			distance = rendezVousDistance;
		}
		if (pointDistance.HasValue)
		{
			double value = pointDistance.Value;
			if (5u != 0)
			{
				distance = value;
			}
		}
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousAngle);
		double angle;
		if (5u != 0)
		{
			angle = num;
		}
		if (pointAngle.HasValue)
		{
			angle = MathUtility.DegreeToRad(pointAngle.Value);
		}
		Approach.FirstPointStrategy.UpdatePolarCoordinates(distance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousC);
		if (pointRotation.HasValue)
		{
			num2 = MathUtility.DegreeToRad(pointRotation.Value);
		}
		Approach.FirstPointStrategy.Rotation = num2 + Math.PI / 2.0;
	}

	public void CreateEdgeBandingOut(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null)
	{
		if (retractSpeed.HasValue)
		{
			Retract.Speed = retractSpeed.Value;
		}
		if (stopTime.HasValue)
		{
			Retract.StopTime = stopTime.Value;
		}
		if (stopTime.HasValue)
		{
			Approach.StopTime = stopTime.Value;
		}
		double outPointDistance = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointDistance;
		double distance;
		if (8u != 0)
		{
			distance = outPointDistance;
		}
		if (pointDistance.HasValue)
		{
			double value = pointDistance.Value;
			if (6u != 0)
			{
				distance = value;
			}
		}
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointAngle);
		double angle = default(double);
		if (0 == 0)
		{
			angle = num;
		}
		if (pointAngle.HasValue)
		{
			angle = MathUtility.DegreeToRad(pointAngle.Value);
		}
		Retract.FirstPointStrategy.UpdatePolarCoordinates(distance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointC);
		if (pointRotation.HasValue)
		{
			num2 = MathUtility.DegreeToRad(pointRotation.Value);
		}
		Retract.FirstPointStrategy.Rotation = num2 + Math.PI / 2.0;
	}
}
