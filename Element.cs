using System;
using System.Collections.Generic;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Element : Geometry
{
	private int _0023_003Dz8NuR_gU_003D;

	public override bool IsPoint => false;

	public override bool IsSegment
	{
		get
		{
			try
			{
				bool result = !(_projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve).Elements[_0023_003Dz8NuR_gU_003D].IsArc;
				if (4u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701795) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

	public override bool IsArc
	{
		get
		{
			try
			{
				bool isArc = (_projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve).Elements[_0023_003Dz8NuR_gU_003D].IsArc;
				if (8u != 0)
				{
					return isArc;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701795) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public override bool IsPolyline => false;

	public override bool IsCircle => false;

	public override bool IsEllipse => false;

	public override bool IsArcOfEllipse => false;

	public override bool IsClockWise
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (6u != 0)
				{
					geomCompositeCurve = obj;
				}
				Plane obj2 = _projectInterface.Get(geomCompositeCurve.PlaneID) as Plane;
				Plane plane;
				if (7u != 0)
				{
					plane = obj2;
				}
				bool result = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].IsClockwise(((Geom_AxisPlacement)plane.Placement.TypedGeometry()).Direction());
				if (true)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704668) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

	public override bool IsClosed => false;

	public override List<Geometry> Elements
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double Length
	{
		get
		{
			try
			{
				double length = (_projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve).Elements[_0023_003Dz8NuR_gU_003D].Length;
				if (2u != 0)
				{
					return length;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704633) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double StartXLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (4u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double startX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].StartX;
				if (2u != 0)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704622) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double StartYLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve = default(GeomCompositeCurve);
				if (0 == 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double startY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].StartY;
				if (3u != 0)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704604) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double StartZLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (uint.MaxValue != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double startZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].StartZ;
				if (6u != 0)
				{
					return startZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704586) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double StartXGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (4u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double startX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].StartX;
				if (true)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704312) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double StartYGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve = default(GeomCompositeCurve);
				if (0 == 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double startY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].StartY;
				if (5u != 0)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704291) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double StartZGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (4u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double startZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].StartZ;
				if (true)
				{
					return startZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704274) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double CenterXLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (3u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				if (IsArc)
				{
					double centerX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].CenterX;
					if (6u != 0)
					{
						return centerX;
					}
				}
				else
				{
					double middleX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].MiddleX;
					if (4u != 0)
					{
						return middleX;
					}
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704253) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double CenterYLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (4u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				if (IsArc)
				{
					double centerY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].CenterY;
					if (2u != 0)
					{
						return centerY;
					}
				}
				else
				{
					double middleY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].MiddleY;
					if (0 == 0)
					{
						return middleY;
					}
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704236) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double CenterZLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve = default(GeomCompositeCurve);
				if (0 == 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				if (IsArc)
				{
					double centerZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].CenterZ;
					if (uint.MaxValue != 0)
					{
						return centerZ;
					}
				}
				else
				{
					double middleZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].MiddleZ;
					if (8u != 0)
					{
						return middleZ;
					}
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704215) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double CenterXGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (3u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				if (IsArc)
				{
					double centerX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].CenterX;
					if (8u != 0)
					{
						return centerX;
					}
				}
				else
				{
					double middleX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].MiddleX;
					if (6u != 0)
					{
						return middleX;
					}
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704198) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double CenterYGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (6u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				if (IsArc)
				{
					double centerY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].CenterY;
					if (8u != 0)
					{
						return centerY;
					}
				}
				else
				{
					double middleY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].MiddleY;
					if (3u != 0)
					{
						return middleY;
					}
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704434) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double CenterZGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (3u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				if (IsArc)
				{
					double centerZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].CenterZ;
					if (uint.MaxValue != 0)
					{
						return centerZ;
					}
				}
				else
				{
					double middleZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].MiddleZ;
					if (true)
					{
						return middleZ;
					}
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704414) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double EndXLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (3u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double endX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].EndX;
				if (0 == 0)
				{
					return endX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704394) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double EndYLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (true)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double endY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].EndY;
				if (uint.MaxValue != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704378) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double EndZLocal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (3u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double endZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].EndZ;
				if (4u != 0)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704362) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double EndXGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (8u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double endX = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].EndX;
				if (6u != 0)
				{
					return endX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704346) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double EndYGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve = default(GeomCompositeCurve);
				if (0 == 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double endY = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].EndY;
				if (2u != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704327) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double EndZGlobal
	{
		get
		{
			try
			{
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (7u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double endZ = geomCompositeCurve.Elements[_0023_003Dz8NuR_gU_003D].EndZ;
				if (true)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701831);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703032) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public Element(ProjectInterface projectInterface)
	{
		if (uint.MaxValue != 0)
		{
			_projectInterface = projectInterface;
		}
	}

	public Element(string name, ReferenceKey key, int index, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (true)
		{
			base.Name = name;
		}
		if (7u != 0)
		{
			base.ReferenceKey = key;
		}
		if (uint.MaxValue != 0)
		{
			_0023_003Dz8NuR_gU_003D = index;
		}
	}
}
