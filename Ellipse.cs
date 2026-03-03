using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Ellipse : Geometry
{
	public override bool IsPoint => false;

	public override bool IsSegment => false;

	public override bool IsArc => false;

	public override bool IsPolyline => false;

	public override bool IsCircle => false;

	public override bool IsEllipse => true;

	public override bool IsArcOfEllipse => false;

	public override bool IsClockWise
	{
		get
		{
			try
			{
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (4u != 0)
				{
					geomEllipse = obj;
				}
				Plane obj2 = _projectInterface.Get(geomEllipse.PlaneID) as Plane;
				Plane plane;
				if (3u != 0)
				{
					plane = obj2;
				}
				bool result = geomEllipse.IsClockwise(plane);
				if (6u != 0)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704668) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

	public override bool IsClosed => true;

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
				double length = (_projectInterface.Get(base.ReferenceKey) as GeomEllipse).Length;
				if (6u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704633) };
				object[] parameters;
				if (4u != 0)
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (6u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double startX = geomEllipse.StartX;
				if (4u != 0)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (7u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double startY = geomEllipse.StartY;
				if (2u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (4u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double startZ = geomEllipse.StartZ;
				if (7u != 0)
				{
					return startZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (6u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double startX = geomEllipse.StartX;
				if (3u != 0)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (2u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double startY = geomEllipse.StartY;
				if (8u != 0)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (4u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double startZ = geomEllipse.StartZ;
				if (2u != 0)
				{
					return startZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (4u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double centerX = geomEllipse.CenterX;
				if (6u != 0)
				{
					return centerX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (7u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double centerY = geomEllipse.CenterY;
				if (uint.MaxValue != 0)
				{
					return centerY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (4u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double centerZ = geomEllipse.CenterZ;
				if (6u != 0)
				{
					return centerZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse = default(GeomEllipse);
				if (0 == 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double centerX = geomEllipse.CenterX;
				if (2u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (uint.MaxValue != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double centerY = geomEllipse.CenterY;
				if (8u != 0)
				{
					return centerY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (2u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double centerZ = geomEllipse.CenterZ;
				if (3u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (uint.MaxValue != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double endX = geomEllipse.EndX;
				if (2u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse = default(GeomEllipse);
				if (0 == 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double endY = geomEllipse.EndY;
				if (4u != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (4u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToLocalGeometry(geomEllipse);
				double endZ = geomEllipse.EndZ;
				if (7u != 0)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (true)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double endX = geomEllipse.EndX;
				if (3u != 0)
				{
					return endX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (4u != 0)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double endY = geomEllipse.EndY;
				if (7u != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
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
				GeomEllipse obj = _projectInterface.Get(base.ReferenceKey) as GeomEllipse;
				GeomEllipse geomEllipse;
				if (true)
				{
					geomEllipse = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomEllipse);
				double endZ = geomEllipse.EndZ;
				if (5u != 0)
				{
					return endZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702511);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703032) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public Ellipse(ProjectInterface projectInterface)
	{
		if (7u != 0)
		{
			_projectInterface = projectInterface;
		}
	}

	public Ellipse(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (uint.MaxValue != 0)
		{
			base.Name = name;
		}
	}

	public Ellipse(ProjectInterface projectInterface, GeomEllipse geometry)
		: this(geometry.Name, projectInterface)
	{
		ReferenceKey key = geometry.Key;
		if (7u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public void CreateEllipseCenterAxes(double centerX, double centerY, double majorRadius, double minorRadius, double angle, Workplane plane, int referencePosition)
	{
		try
		{
			double num = MathUtility.ConvertToRadians(angle);
			double num2;
			if (7u != 0)
			{
				num2 = num;
			}
			GeomEllipse geomEllipse = new GeomEllipse(centerX, centerY, 0.0, 0.0, 0.0, 1.0, majorRadius, minorRadius);
			GeomGeometry geometry = default(GeomGeometry);
			if (0 == 0)
			{
				geometry = geomEllipse;
			}
			geometry.Geometry.Rotate(((Geom_Conic)Geom_Ellipse.DownCast((Standard_Transient)(object)geometry.Geometry)).Axis(), num2);
			geometry.IsAbsolute = false;
			geometry.Name = base.Name;
			geometry.ReferencePosition = (ReferencePositionType)referencePosition;
			_projectInterface.SetGeometryPlane(ref geometry, plane.ReferenceKey);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			_projectInterface.AddGeometry(ref geometry, plane.ReferenceKey, isAbsolute: false, this);
			ReferenceKey key = geometry.Key;
			if (5u != 0)
			{
				base.ReferenceKey = key;
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701779), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}
}
