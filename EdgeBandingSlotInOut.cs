using System;
using System.Runtime.CompilerServices;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.MachiningDataModel.Strategy;

namespace ScmGroup.XCam.Scripting;

public class EdgeBandingSlotInOut : LeadInOut
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
			_ = 1;
			if (3 == 0)
			{
			}
			return _0023_003DzPWwhSvm5soQEY7HtfGJupyY_003D;
		}
		[CompilerGenerated]
		set
		{
			if (5u != 0)
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
			if (false)
			{
			}
			return _0023_003Dz4xgfm9grtgSUBconGesQiUjByZwu;
		}
		[CompilerGenerated]
		set
		{
			if (4u != 0)
			{
				_0023_003Dz4xgfm9grtgSUBconGesQiUjByZwu = value;
			}
		}
	}

	public EdgeBandingSlotInOut()
	{
		UI00EdgeBandingOptions edgeBandingOptions = AppInfo.CurrentOptions<UI00Options>().EdgeBandingOptions;
		if (7u != 0)
		{
			_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D = edgeBandingOptions;
		}
		UI00Options uI00Options = AppInfo.CurrentOptions<UI00Options>();
		if (3u != 0)
		{
			_0023_003DzgK1Mwoo_003D = uI00Options;
		}
		if (6u != 0)
		{
			_0023_003DzdgK5oIeXiVmGg4oR0clR98RWoYEZ();
		}
	}

	private void _0023_003DzdgK5oIeXiVmGg4oR0clR98RWoYEZ()
	{
		if (8u != 0)
		{
			_0023_003DzrcQc6w993Lp3zJJoQuHHaYw_003D();
		}
		if (true)
		{
			_0023_003Dzm2fCm7g2nRx7T37voUVpO_0024I_003D();
		}
	}

	private void _0023_003DzrcQc6w993Lp3zJJoQuHHaYw_003D()
	{
		EdgeBandingApproachStrategy approach = new EdgeBandingApproachStrategy();
		if (4u != 0)
		{
			Approach = approach;
		}
		Approach.InterpolationSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachInterpolationSlotSpeed;
		Approach.Speed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachSlotSpeed;
		Approach.StartApproachSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachMagazineSlotSpeed;
		Approach.EdgeDispensingApproachSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachEdgeDispensingSlotSpeed;
		Approach.StopTime = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.ApproachSlotStopTime;
		Approach.FirstPointStrategy = new EdgeBandingPoint();
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousSlotAngle);
		double angle;
		if (7u != 0)
		{
			angle = num;
		}
		Approach.FirstPointStrategy.UpdatePolarCoordinates(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousSlotDistance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousSlotC);
		double num3 = default(double);
		if (0 == 0)
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

	private void _0023_003Dzm2fCm7g2nRx7T37voUVpO_0024I_003D()
	{
		EdgeBandingRetractStrategy retract = new EdgeBandingRetractStrategy();
		if (7u != 0)
		{
			Retract = retract;
		}
		Retract.StopTime = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RetractSlotStopTime;
		Retract.InterpolationSpeed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RetractInterpolationSlotSpeed;
		Retract.Speed = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RetractSlotSpeed;
		Retract.FirstPointStrategy = new EdgeBandingPoint();
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointSlotAngle);
		double angle;
		if (7u != 0)
		{
			angle = num;
		}
		Retract.FirstPointStrategy.UpdatePolarCoordinates(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointSlotDistance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointSlotC);
		double num3;
		if (6u != 0)
		{
			num3 = num2;
		}
		Retract.FirstPointStrategy.Rotation = num3 + Math.PI / 2.0;
	}

	public void ResetEdgeBandingSlotIn()
	{
		if (2u != 0)
		{
			_0023_003DzrcQc6w993Lp3zJJoQuHHaYw_003D();
		}
	}

	public void ResetEdgeBandingSlotOut()
	{
		if (7u != 0)
		{
			_0023_003Dzm2fCm7g2nRx7T37voUVpO_0024I_003D();
		}
	}

	public void CreateEdgeBandingSlotIn(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null)
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
		if (isLampOn.HasValue)
		{
			Approach.Lamp.Status = isLampOn.Value;
		}
		if (lampPower.HasValue)
		{
			Approach.Lamp.Power = lampPower.Value;
		}
		double rendezVousSlotDistance = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousSlotDistance;
		double distance;
		if (5u != 0)
		{
			distance = rendezVousSlotDistance;
		}
		if (pointDistance.HasValue)
		{
			double value = pointDistance.Value;
			if (4u != 0)
			{
				distance = value;
			}
		}
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousSlotAngle);
		double angle;
		if (uint.MaxValue != 0)
		{
			angle = num;
		}
		if (pointAngle.HasValue)
		{
			angle = MathUtility.DegreeToRad(pointAngle.Value);
		}
		Approach.FirstPointStrategy.UpdatePolarCoordinates(distance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.RendezVousSlotC);
		if (pointRotation.HasValue)
		{
			num2 = MathUtility.DegreeToRad(pointRotation.Value);
		}
		Approach.FirstPointStrategy.Rotation = num2 + Math.PI / 2.0;
	}

	public void CreateEdgeBandingSlotOut(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null)
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
		double outPointSlotDistance = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointSlotDistance;
		double distance;
		if (5u != 0)
		{
			distance = outPointSlotDistance;
		}
		if (pointDistance.HasValue)
		{
			double value = pointDistance.Value;
			if (5u != 0)
			{
				distance = value;
			}
		}
		double num = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointSlotAngle);
		double angle;
		if (4u != 0)
		{
			angle = num;
		}
		if (pointAngle.HasValue)
		{
			angle = MathUtility.DegreeToRad(pointAngle.Value);
		}
		Retract.FirstPointStrategy.UpdatePolarCoordinates(distance, angle);
		double num2 = MathUtility.DegreeToRad(_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.OutPointSlotC);
		if (pointRotation.HasValue)
		{
			num2 = MathUtility.DegreeToRad(pointRotation.Value);
		}
		Retract.FirstPointStrategy.Rotation = num2 + Math.PI / 2.0;
	}
}
