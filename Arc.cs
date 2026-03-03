using System;
using System.Collections.Generic;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Arc : Geometry
{
	public override bool IsPoint => false;

	public override bool IsSegment => false;

	public override bool IsArc => true;

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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (2u != 0)
				{
					geomTrimmedCurve = obj;
				}
				Plane obj2 = _projectInterface.Get(geomTrimmedCurve.PlaneID) as Plane;
				Plane plane;
				if (2u != 0)
				{
					plane = obj2;
				}
				bool result = geomTrimmedCurve.IsClockwise(plane);
				if (true)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704668) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

	public override bool IsClosed
	{
		get
		{
			try
			{
				bool result = (_projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve).IsClosed();
				if (2u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704650) };
				object[] parameters;
				if (uint.MaxValue != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

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
				double length = (_projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve).Length;
				if (6u != 0)
				{
					return length;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704633) };
				object[] parameters;
				if (3u != 0)
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (2u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double startX = geomTrimmedCurve.StartX;
				if (5u != 0)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (8u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double startY = geomTrimmedCurve.StartY;
				if (uint.MaxValue != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (uint.MaxValue != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double startZ = geomTrimmedCurve.StartZ;
				if (5u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (3u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double startX = geomTrimmedCurve.StartX;
				if (5u != 0)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (4u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double startY = geomTrimmedCurve.StartY;
				if (3u != 0)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (7u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double startZ = geomTrimmedCurve.StartZ;
				if (3u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (true)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double centerX = geomTrimmedCurve.CenterX;
				if (6u != 0)
				{
					return centerX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (2u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double centerY = geomTrimmedCurve.CenterY;
				if (uint.MaxValue != 0)
				{
					return centerY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve = default(GeomTrimmedCurve);
				if (0 == 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double centerZ = geomTrimmedCurve.CenterZ;
				if (0 == 0)
				{
					return centerZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704215) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double CenterXGlobal
	{
		get
		{
			try
			{
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (8u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double centerX = geomTrimmedCurve.CenterX;
				if (true)
				{
					return centerX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (8u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double centerY = geomTrimmedCurve.CenterY;
				if (2u != 0)
				{
					return centerY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (6u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double centerZ = geomTrimmedCurve.CenterZ;
				if (5u != 0)
				{
					return centerZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (7u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double endX = geomTrimmedCurve.EndX;
				if (6u != 0)
				{
					return endX;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (uint.MaxValue != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double endY = geomTrimmedCurve.EndY;
				if (5u != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve = default(GeomTrimmedCurve);
				if (0 == 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double endZ = geomTrimmedCurve.EndZ;
				if (6u != 0)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (2u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double endX = geomTrimmedCurve.EndX;
				if (uint.MaxValue != 0)
				{
					return endX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (true)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double endY = geomTrimmedCurve.EndY;
				if (7u != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (5u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double endZ = geomTrimmedCurve.EndZ;
				if (8u != 0)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704700);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703032) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public Arc(ProjectInterface projectInterface)
	{
		if (0 == 0)
		{
			_projectInterface = projectInterface;
		}
	}

	public Arc(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (3u != 0)
		{
			base.Name = name;
		}
	}

	public Arc(ProjectInterface projectInterface, GeomTrimmedCurve geometry)
		: this(geometry.Name, projectInterface)
	{
		ReferenceKey key = geometry.Key;
		if (2u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public void CreateArc3Points(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y, Workplane plane, int referencePosition)
	{
		try
		{
			GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(p1X, p1Y, 0.0, p2X, p2Y, 0.0, p3X, p3Y, 0.0);
			GeomGeometry geometry;
			if (5u != 0)
			{
				geometry = geomTrimmedCurve;
			}
			geometry.IsAbsolute = false;
			geometry.Name = base.Name;
			geometry.ReferencePosition = (ReferencePositionType)referencePosition;
			_projectInterface.SetGeometryPlane(ref geometry, plane.ReferenceKey);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			_projectInterface.AddGeometry(ref geometry, plane.ReferenceKey, isAbsolute: false, this);
			ReferenceKey key = geometry.Key;
			if (2u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704476), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateArc2PointRadius(double startX, double startY, double endX, double endY, double radius, bool isClockwise, bool isOver180, Workplane plane, int referencePosition)
	{
		try
		{
			GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(startX, startY, 0.0, endX, endY, 0.0, 0.0, 0.0, (!isClockwise) ? 1 : (-1), radius, !isOver180);
			GeomGeometry geometry;
			if (3u != 0)
			{
				geometry = geomTrimmedCurve;
			}
			geometry.IsAbsolute = false;
			geometry.Name = base.Name;
			geometry.ReferencePosition = (ReferencePositionType)referencePosition;
			_projectInterface.SetGeometryPlane(ref geometry, plane.ReferenceKey);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			_projectInterface.AddGeometry(ref geometry, plane.ReferenceKey, isAbsolute: false, this);
			ReferenceKey key = geometry.Key;
			if (2u != 0)
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
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704476), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateArc2PointCenter(double startX, double startY, double endX, double endY, double centerX, double centerY, bool isClockwise, Workplane plane, int referencePosition)
	{
		try
		{
			GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(startX, startY, 0.0, endX, endY, 0.0, centerX, centerY, 0.0, 0.0, 0.0, (!isClockwise) ? 1 : (-1));
			GeomGeometry geometry;
			if (6u != 0)
			{
				geometry = geomTrimmedCurve;
			}
			geometry.IsAbsolute = false;
			geometry.Name = base.Name;
			geometry.ReferencePosition = (ReferencePositionType)referencePosition;
			_projectInterface.SetGeometryPlane(ref geometry, plane.ReferenceKey);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			_projectInterface.AddGeometry(ref geometry, plane.ReferenceKey, isAbsolute: false, this);
			ReferenceKey key = geometry.Key;
			if (6u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704476), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateArcCenterAngle(double startX, double startY, double centerX, double centerY, double angle, Workplane plane, int referencePosition)
	{
		try
		{
			GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(startX, startY, 0.0, centerX, centerY, 0.0, 0.0, 0.0, 1.0, angle);
			GeomGeometry geometry;
			if (3u != 0)
			{
				geometry = geomTrimmedCurve;
			}
			geometry.IsAbsolute = false;
			geometry.Name = base.Name;
			geometry.ReferencePosition = (ReferencePositionType)referencePosition;
			_projectInterface.SetGeometryPlane(ref geometry, plane.ReferenceKey);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			_projectInterface.AddGeometry(ref geometry, plane.ReferenceKey, isAbsolute: false, this);
			ReferenceKey key = geometry.Key;
			if (2u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704476), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}
}
