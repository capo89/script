using System;
using System.Collections.Generic;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Segment : Geometry
{
	public override bool IsPoint => false;

	public override bool IsSegment => true;

	public override bool IsArc => false;

	public override bool IsPolyline => false;

	public override bool IsCircle => false;

	public override bool IsEllipse => false;

	public override bool IsArcOfEllipse => false;

	public override bool IsClockWise => false;

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
				double length = (_projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve).Length;
				if (8u != 0)
				{
					return length;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704633) };
				object[] parameters = default(object[]);
				if (0 == 0)
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
				if (true)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (7u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double startY = geomTrimmedCurve.StartY;
				if (true)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (7u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double startZ = geomTrimmedCurve.StartZ;
				if (3u != 0)
				{
					return startZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (5u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double startX = geomTrimmedCurve.StartX;
				if (7u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (2u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double startY = geomTrimmedCurve.StartY;
				if (7u != 0)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (4u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double startZ = geomTrimmedCurve.StartZ;
				if (uint.MaxValue != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (uint.MaxValue != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double middleX = geomTrimmedCurve.MiddleX;
				if (4u != 0)
				{
					return middleX;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				double middleY = geomTrimmedCurve.MiddleY;
				if (8u != 0)
				{
					return middleY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				GeomTrimmedCurve geomTrimmedCurve;
				if (uint.MaxValue != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double middleZ = geomTrimmedCurve.MiddleZ;
				if (4u != 0)
				{
					return middleZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (7u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double startX = geomTrimmedCurve.StartX;
				if (2u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				if (5u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double middleY = geomTrimmedCurve.MiddleY;
				if (2u != 0)
				{
					return middleY;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				if (true)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double middleZ = geomTrimmedCurve.MiddleZ;
				if (2u != 0)
				{
					return middleZ;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				if (4u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double endX = geomTrimmedCurve.EndX;
				if (4u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve = default(GeomTrimmedCurve);
				if (0 == 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double endY = geomTrimmedCurve.EndY;
				if (8u != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				GeomTrimmedCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomTrimmedCurve;
				GeomTrimmedCurve geomTrimmedCurve;
				if (2u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomTrimmedCurve);
				double endZ = geomTrimmedCurve.EndZ;
				if (true)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (6u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double endX = geomTrimmedCurve.EndX;
				if (6u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (4u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
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
				if (7u != 0)
				{
					geomTrimmedCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomTrimmedCurve);
				double endZ = geomTrimmedCurve.EndZ;
				if (2u != 0)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708976);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703032) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public Segment(ProjectInterface projectInterface)
	{
		if (2u != 0)
		{
			_projectInterface = projectInterface;
		}
	}

	public Segment(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (4u != 0)
		{
			base.Name = name;
		}
	}

	public Segment(ProjectInterface projectInterface, GeomTrimmedCurve geometry)
		: this(geometry.Name, projectInterface)
	{
		ReferenceKey key = geometry.Key;
		if (7u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public void CreateSegment(double startX, double startY, double endX, double endY, Workplane plane, int referencePosition)
	{
		try
		{
			GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(startX, startY, 0.0, endX, endY, 0.0);
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
			if (uint.MaxValue != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}
}
