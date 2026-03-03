using System;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;

namespace ScmGroup.XCam.Scripting;

public class Attribute : BaseAttribute
{
	public static string Feed;

	public static string Depth;

	public static string Rot;

	public static string ERot;

	public static string Dispensing;

	public static string RotX;

	public static string RotZ;

	public static string Height;

	public static string Tab;

	public static string Lamp;

	public static string STOP;

	public static string SawMovement;

	public static string StartPoint;

	public static string EndPoint;

	public Attribute()
	{
		_ = 1;
		if (4 == 0)
		{
		}
		base._002Ector();
	}

	public Attribute(OperationAttribute value, int index = 0)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		_ = 5;
		if (4 == 0)
		{
		}
		_ = 3;
		if (false)
		{
		}
		base._002Ector(value, index);
	}

	public Attribute(Attribute attribute)
	{
		OperationAttribute value = ((attribute.Value != null) ? (attribute.Value.Clone() as OperationAttribute) : null);
		if (uint.MaxValue != 0)
		{
			base.Value = value;
		}
		int index = attribute.Index;
		if (6u != 0)
		{
			base.Index = index;
		}
	}

	static Attribute()
	{
		string feed = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702931);
		if (0 == 0)
		{
			Feed = feed;
		}
		string depth = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922);
		if (true)
		{
			Depth = depth;
		}
		string rot = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703166);
		if (7u != 0)
		{
			Rot = rot;
		}
		ERot = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703156);
		Dispensing = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703143);
		RotX = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703136);
		RotZ = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703123);
		Height = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703114);
		Tab = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703099);
		Lamp = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703089);
		STOP = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703080);
		SawMovement = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703067);
		StartPoint = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703049);
		EndPoint = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702778);
	}

	public static OperationAttribute Create(string name, double value, double value1 = 0.0, double uPar = 1.0)
	{
		OperationAttribute result;
		if (5u != 0)
		{
			result = null;
		}
		if (string.Compare(name, Feed, ignoreCase: true) == 0)
		{
			SpeedAttribute speedAttribute = new SpeedAttribute(0.0, isNormalized: true, value);
			if (0 == 0)
			{
				result = speedAttribute;
			}
		}
		else if (string.Compare(name, Depth, ignoreCase: true) == 0)
		{
			DepthAttribute depthAttribute = new DepthAttribute(uPar, isNormalized: true, value);
			if (7u != 0)
			{
				result = depthAttribute;
			}
		}
		else if (string.Compare(name, Rot, ignoreCase: true) == 0)
		{
			RotationAttribute rotationAttribute = new RotationAttribute(uPar, isNormalized: true, value);
			if (2u != 0)
			{
				result = rotationAttribute;
			}
		}
		else if (string.Compare(name, RotX, ignoreCase: true) == 0)
		{
			RotXAttribute rotXAttribute = new RotXAttribute(uPar, isNormalized: true, value);
			if (true)
			{
				result = rotXAttribute;
			}
		}
		else if (string.Compare(name, RotZ, ignoreCase: true) == 0)
		{
			RotZAttribute rotZAttribute = new RotZAttribute(uPar, isNormalized: true, value);
			if (7u != 0)
			{
				result = rotZAttribute;
			}
		}
		else if (string.Compare(name, Height, ignoreCase: true) == 0)
		{
			result = new HeightAttribute(uPar, isNormalized: true, value);
		}
		else if (string.Compare(name, Tab, ignoreCase: true) == 0)
		{
			result = new TabAttribute(uPar, isNormalized: true, value, value1);
		}
		else if (string.Compare(name, ERot, ignoreCase: true) == 0)
		{
			double angle = MathUtility.DegreeToRad(value) + Math.PI / 2.0;
			result = new RotationAttribute(uPar, isNormalized: true, angle);
		}
		else if (string.Compare(name, Dispensing, ignoreCase: true) == 0)
		{
			double edgeSupplyDistance = AppInfo.CurrentOptions<UI00Options>().EdgeBandingOptions.EdgeSupplyDistance;
			result = new EdgeSupplyAttribute(0.0, isNormalized: true, value, edgeSupplyDistance);
		}
		else if (string.Compare(name, Lamp, ignoreCase: true) == 0)
		{
			double power = 0.0;
			bool value2 = false;
			if (value != 0.0)
			{
				value2 = true;
				power = value;
			}
			result = new LampAttribute(1.0, isNormalized: true, value2, power);
		}
		else if (string.Compare(name, STOP, ignoreCase: true) == 0)
		{
			result = new RollStopAttribute(1.0, isNormalized: true, value);
		}
		else if (string.Compare(name, SawMovement, ignoreCase: true) == 0)
		{
			result = new SawMovementAttribute(uPar, isNormalized: true, value);
		}
		else if (string.Compare(name, StartPoint, ignoreCase: true) == 0)
		{
			result = new ExtremaMachiningAttribute();
		}
		else
		{
			if (string.Compare(name, EndPoint, ignoreCase: true) != 0)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702761), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			result = new ExtremaMachiningAttribute();
		}
		return result;
	}
}
