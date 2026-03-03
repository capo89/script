using System;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Parametrics;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Workplane : BaseScripting
{
	public double OriginX
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (4u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.LocationX;
				}
			}
			throw new Exception();
		}
	}

	public double OriginY
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (8u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.LocationY;
				}
			}
			throw new Exception();
		}
	}

	public double OriginZ
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (5u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.LocationZ;
				}
			}
			throw new Exception();
		}
	}

	public double XAxisX
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (6u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.XDirectionX;
				}
			}
			throw new Exception();
		}
	}

	public double XAxisY
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (2u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.XDirectionY;
				}
			}
			throw new Exception();
		}
	}

	public double XAxisZ
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (4u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.XDirectionZ;
				}
			}
			throw new Exception();
		}
	}

	public double YAxisX
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (4u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.YDirectionX;
				}
			}
			throw new Exception();
		}
	}

	public double YAxisY
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (3u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.YDirectionY;
				}
			}
			throw new Exception();
		}
	}

	public double YAxisZ
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (5u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.YDirectionZ;
				}
			}
			throw new Exception();
		}
	}

	public double ZAxisX
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (true)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.DirectionX;
				}
			}
			throw new Exception();
		}
	}

	public double ZAxisY
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (8u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.DirectionY;
				}
			}
			throw new Exception();
		}
	}

	public double ZAxisZ
	{
		get
		{
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (4u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					return plane.Placement.DirectionZ;
				}
			}
			throw new Exception();
		}
	}

	public double XDimension
	{
		get
		{
			double result;
			if (8u != 0)
			{
				result = 0.0;
			}
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (7u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					double xDimension = plane.XDimension;
					if (4u != 0)
					{
						result = xDimension;
					}
				}
			}
			return result;
		}
	}

	public double YDimension
	{
		get
		{
			double result = default(double);
			if (0 == 0)
			{
				result = 0.0;
			}
			if (base.ReferenceKey != null && base.ReferenceKey.IsValid)
			{
				Plane obj = _projectInterface.Get(base.ReferenceKey) as Plane;
				Plane plane;
				if (8u != 0)
				{
					plane = obj;
				}
				if (plane != null)
				{
					double yDimension = plane.YDimension;
					if (6u != 0)
					{
						result = yDimension;
					}
				}
			}
			return result;
		}
	}

	public Workplane(ProjectInterface projectInterface)
	{
		if (uint.MaxValue != 0)
		{
			_projectInterface = projectInterface;
		}
	}

	public Workplane(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (2u != 0)
		{
			base.Name = name;
		}
	}

	public Workplane(ProjectInterface projectInterface, Plane plane)
		: this(plane.Name, projectInterface)
	{
		ReferenceKey key = plane.Key;
		if (4u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public Workplane(string name, ProjectInterface projectInterface, Plane plane)
		: this(name, projectInterface)
	{
		ReferenceKey key = plane.Key;
		if (true)
		{
			base.ReferenceKey = key;
		}
	}

	public void CreateWorkplane(PlaneType planeType, double p1X, double p1Y, double p1Z, double p2X, double p2Y, double p2Z, double p3X, double p3Y, double p3Z, Workpiece workpiece)
	{
		try
		{
			Plane plane = new Plane(planeType, p1X, p1Y, p1Z, p2X, p2Y, p2Z, p3X, p3Y, p3Z, 0.0, 0.0, new ReferenceKey(), workpiece.ReferenceKey);
			Plane plane2;
			if (uint.MaxValue != 0)
			{
				plane2 = plane;
			}
			plane2.Name = base.Name;
			_projectInterface.AddPlane(ref plane2, this);
			ReferenceKey key = plane2.Key;
			if (6u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (true)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716722), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateWorkplane(PlaneType planeType, double X0, double Y0, double Z0, double ZRotation, double XRotation, Workpiece workpiece)
	{
		try
		{
			Plane plane = new Plane(planeType, X0, Y0, Z0, ZRotation, XRotation, 0.0, 0.0, new ReferenceKey(), workpiece.ReferenceKey);
			Plane plane2;
			if (uint.MaxValue != 0)
			{
				plane2 = plane;
			}
			plane2.Name = base.Name;
			_projectInterface.AddPlane(ref plane2, this);
			ReferenceKey key = plane2.Key;
			if (5u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (6u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716722), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateWorkplane(PlaneType planeType, double offsetZ, Workplane workplane)
	{
		try
		{
			Plane obj = _projectInterface.Get(workplane.ReferenceKey) as Plane;
			Plane plane;
			if (5u != 0)
			{
				plane = obj;
			}
			Plane plane2 = new Plane(planeType, plane.Placement, offsetZ, 0.0, 0.0, new ReferenceKey(), plane.WorkpieceID);
			Plane plane3;
			if (uint.MaxValue != 0)
			{
				plane3 = plane2;
			}
			plane3.Name = base.Name;
			_projectInterface.AddPlane(ref plane3, this);
			ReferenceKey key = plane3.Key;
			if (5u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716722), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CheckExpression(string propertyName, object propertyValue)
	{
		if (!StringUtility.IsValid(propertyName))
		{
			return;
		}
		if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707694))
		{
			PropertyField propertyField = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707694));
			PropertyField property;
			if (5u != 0)
			{
				property = propertyField;
			}
			_projectInterface.CheckExpressions(base.ReferenceKey, property, propertyValue);
		}
		else if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707677))
		{
			PropertyField propertyField2 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707677));
			PropertyField property2;
			if (7u != 0)
			{
				property2 = propertyField2;
			}
			_projectInterface.CheckExpressions(base.ReferenceKey, property2, propertyValue);
		}
		else if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707664))
		{
			PropertyField propertyField3 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707664));
			PropertyField property3;
			if (4u != 0)
			{
				property3 = propertyField3;
			}
			_projectInterface.CheckExpressions(base.ReferenceKey, property3, propertyValue);
		}
		else if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707391))
		{
			PropertyField property4 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707391));
			_projectInterface.CheckExpressions(base.ReferenceKey, property4, propertyValue);
		}
		else if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707375))
		{
			PropertyField property5 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707375));
			_projectInterface.CheckExpressions(base.ReferenceKey, property5, propertyValue);
		}
	}
}
