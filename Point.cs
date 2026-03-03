using System;
using System.Collections.Generic;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Point : Geometry
{
	public override bool IsPoint => true;

	public override bool IsSegment => false;

	public override bool IsArc => false;

	public override bool IsPolyline => false;

	public override bool IsCircle => false;

	public override bool IsClockWise => false;

	public override bool IsClosed => false;

	public override bool IsEllipse => false;

	public override bool IsArcOfEllipse => false;

	public override List<Geometry> Elements
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double Length => 0.0;

	public override double StartXLocal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (6u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double x = geomCartesianPoint.X;
				if (3u != 0)
				{
					return x;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (true)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double y = geomCartesianPoint.Y;
				if (2u != 0)
				{
					return y;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (6u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double z = geomCartesianPoint.Z;
				if (uint.MaxValue != 0)
				{
					return z;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (3u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double x = geomCartesianPoint.X;
				if (0 == 0)
				{
					return x;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704312) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double StartYGlobal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (6u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double y = geomCartesianPoint.Y;
				if (uint.MaxValue != 0)
				{
					return y;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (true)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double z = geomCartesianPoint.Z;
				if (true)
				{
					return z;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (3u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double x = geomCartesianPoint.X;
				if (0 == 0)
				{
					return x;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704253) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double CenterYLocal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (uint.MaxValue != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double y = geomCartesianPoint.Y;
				if (8u != 0)
				{
					return y;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704236) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double CenterZLocal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (uint.MaxValue != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double z = geomCartesianPoint.Z;
				if (7u != 0)
				{
					return z;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (3u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double x = geomCartesianPoint.X;
				if (0 == 0)
				{
					return x;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704198) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double CenterYGlobal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (4u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double y = geomCartesianPoint.Y;
				if (0 == 0)
				{
					return y;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704434) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double CenterZGlobal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (4u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double z = geomCartesianPoint.Z;
				if (6u != 0)
				{
					return z;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (4u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double x = geomCartesianPoint.X;
				if (8u != 0)
				{
					return x;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704394) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double EndYLocal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (6u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double y = geomCartesianPoint.Y;
				if (2u != 0)
				{
					return y;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (6u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToLocalGeometry(geomCartesianPoint);
				double z = geomCartesianPoint.Z;
				if (0 == 0)
				{
					return z;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704362) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double EndXGlobal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (uint.MaxValue != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double x = geomCartesianPoint.X;
				if (5u != 0)
				{
					return x;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
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
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (true)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double y = geomCartesianPoint.Y;
				if (0 == 0)
				{
					return y;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704327) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double EndZGlobal
	{
		get
		{
			try
			{
				GeomCartesianPoint obj = _projectInterface.Get(base.ReferenceKey) as GeomCartesianPoint;
				GeomCartesianPoint geomCartesianPoint;
				if (8u != 0)
				{
					geomCartesianPoint = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCartesianPoint);
				double z = geomCartesianPoint.Z;
				if (3u != 0)
				{
					return z;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708659);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703032) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public Point(ProjectInterface projectInterface)
	{
		if (true)
		{
			_projectInterface = projectInterface;
		}
	}

	public Point(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (8u != 0)
		{
			base.Name = name;
		}
	}

	public Point(ProjectInterface projectInterface, GeomPoint geometry)
		: this(geometry.Name, projectInterface)
	{
		ReferenceKey key = geometry.Key;
		if (6u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public void CreatePoint(double x, double y, Workplane plane, int referencePosition)
	{
		try
		{
			GeomCartesianPoint geomCartesianPoint = new GeomCartesianPoint(x, y, 0.0);
			GeomGeometry geometry;
			if (true)
			{
				geometry = geomCartesianPoint;
			}
			geometry.IsAbsolute = false;
			geometry.Name = base.Name;
			geometry.ReferencePosition = (ReferencePositionType)referencePosition;
			_projectInterface.SetGeometryPlane(ref geometry, plane.ReferenceKey);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			_projectInterface.AddGeometry(ref geometry, plane.ReferenceKey, isAbsolute: false, this);
			ReferenceKey key = geometry.Key;
			if (4u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707925), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}
}
