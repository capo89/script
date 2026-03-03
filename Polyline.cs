using System;
using System.Collections.Generic;
using System.Linq;
using GeometryService;
using OccExtension;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Polyline : Geometry
{
	private sealed class _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D
	{
		public string _0023_003DzyqMIBlE_003D;

		public _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D()
		{
			_ = 0;
			if (4 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzQTzBREZWhvymnVp8nQ_003D_003D(KeyValuePair<int, string> _0023_003DzWFCyUcw_003D)
		{
			string value = _0023_003DzWFCyUcw_003D.Value;
			_ = 4;
			if (5 == 0)
			{
			}
			return value == _0023_003DzyqMIBlE_003D;
		}
	}

	private Dictionary<int, string> _0023_003DzZ_WCynaSAf3F;

	private GeomCompositeCurve _0023_003DzDPwSHz8_003D;

	private Workplane _0023_003DzeOP_EWGJ0yL_;

	private string _0023_003DzN7yzk84fqvfGKtFS4SovHzOG9WMz;

	private double _0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D;

	private double _0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D;

	private double _0023_003DzgndmRBibkutF9hvK9hlU9nE_003D;

	private FilletType _0023_003DzHdE_0024bwjV3hs2FQEI5Q_003D_003D;

	private ChamferType _0023_003DzTW4w_Wlsy4_0024afG4DOQ_003D_003D;

	public override bool IsPoint => false;

	public override bool IsSegment => false;

	public override bool IsArc => false;

	public override bool IsPolyline => true;

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
				if (7u != 0)
				{
					geomCompositeCurve = obj;
				}
				Plane obj2 = _projectInterface.Get(geomCompositeCurve.PlaneID) as Plane;
				Plane plane = default(Plane);
				if (0 == 0)
				{
					plane = obj2;
				}
				bool result = geomCompositeCurve.IsClockwise(plane);
				if (true)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				bool result = (_projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve).IsClosed();
				if (2u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704650) };
				object[] parameters;
				if (5u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

	public int Count
	{
		get
		{
			int count = _0023_003DzDPwSHz8_003D.Elements.Count;
			int num;
			if (5u != 0)
			{
				num = count;
			}
			if (!MathUtility.IsEqual(_0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D, 0.0) || !MathUtility.IsEqual(_0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D, 0.0) || !MathUtility.IsEqual(_0023_003DzgndmRBibkutF9hvK9hlU9nE_003D, 0.0))
			{
				int num2 = num + 1;
				if (8u != 0)
				{
					num = num2;
				}
			}
			return num;
		}
	}

	public override List<Geometry> Elements
	{
		get
		{
			try
			{
				List<Geometry> list = new List<Geometry>();
				List<Geometry> list2;
				if (uint.MaxValue != 0)
				{
					list2 = list;
				}
				int i;
				if (true)
				{
					i = 0;
				}
				for (; i < _0023_003DzDPwSHz8_003D.Elements.Count; i++)
				{
					string text = base.Name + i;
					string name;
					if (3u != 0)
					{
						name = text;
					}
					string value = string.Empty;
					if (_0023_003DzZ_WCynaSAf3F.TryGetValue(i, out value) && value != null && value != string.Empty)
					{
						name = value;
					}
					list2.Add(new Element(name, base.ReferenceKey, i, _projectInterface));
				}
				return list2;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702852) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public override double Length
	{
		get
		{
			try
			{
				double length = (_projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve).Length;
				if (5u != 0)
				{
					return length;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704633) };
				object[] parameters;
				if (8u != 0)
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
				if (6u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double startX = geomCompositeCurve.StartX;
				if (0 == 0)
				{
					return startX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704622) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
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
				GeomCompositeCurve geomCompositeCurve;
				if (4u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double startY = geomCompositeCurve.StartY;
				if (true)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				GeomCompositeCurve geomCompositeCurve = default(GeomCompositeCurve);
				if (0 == 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double startZ = geomCompositeCurve.StartZ;
				if (5u != 0)
				{
					return startZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				if (5u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double startX = geomCompositeCurve.StartX;
				if (2u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				GeomCompositeCurve geomCompositeCurve;
				if (4u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double startY = geomCompositeCurve.StartY;
				if (3u != 0)
				{
					return startY;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				if (true)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double startZ = geomCompositeCurve.StartZ;
				if (true)
				{
					return startZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
			throw new NotImplementedException();
		}
	}

	public override double CenterYLocal
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double CenterZLocal
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double CenterXGlobal
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double CenterYGlobal
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double CenterZGlobal
	{
		get
		{
			throw new NotImplementedException();
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
				if (6u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double endX = geomCompositeCurve.EndX;
				if (2u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				GeomCompositeCurve obj = _projectInterface.Get(base.ReferenceKey) as GeomCompositeCurve;
				GeomCompositeCurve geomCompositeCurve;
				if (2u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double endY = geomCompositeCurve.EndY;
				if (8u != 0)
				{
					return endY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				if (5u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToLocalGeometry(geomCompositeCurve);
				double endZ = geomCompositeCurve.EndZ;
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				if (uint.MaxValue != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double endX = geomCompositeCurve.EndX;
				if (3u != 0)
				{
					return endX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				GeomCompositeCurve geomCompositeCurve;
				if (true)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double endY = geomCompositeCurve.EndY;
				if (4u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
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
				if (3u != 0)
				{
					geomCompositeCurve = obj;
				}
				_projectInterface.ToAbsoluteGeometry(geomCompositeCurve);
				double endZ = geomCompositeCurve.EndZ;
				if (5u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703032) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public GeomCompositeCurve Geometry
	{
		get
		{
			try
			{
				GeomCompositeCurve result = _0023_003DzDPwSHz8_003D;
				if (0 == 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708625) };
				object[] parameters;
				if (7u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			GeomCompositeCurve result2 = default(GeomCompositeCurve);
			return result2;
		}
	}

	public Polyline(ProjectInterface projectInterface)
	{
		string empty = string.Empty;
		if (8u != 0)
		{
			_0023_003DzN7yzk84fqvfGKtFS4SovHzOG9WMz = empty;
		}
		base._002Ector();
		if (0 == 0)
		{
			_projectInterface = projectInterface;
		}
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		if (2u != 0)
		{
			_0023_003DzZ_WCynaSAf3F = dictionary;
		}
		_0023_003DzDPwSHz8_003D = new GeomCompositeCurve();
	}

	public Polyline(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (7u != 0)
		{
			base.Name = name;
		}
	}

	public Polyline(ProjectInterface projectInterface, GeomCompositeCurve geometry)
		: this(geometry.Name, projectInterface)
	{
		ReferenceKey key = geometry.Key;
		if (8u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public int ExistElement(string nameElement, bool exist)
	{
		_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D = new _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D();
		_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2;
		if (3u != 0)
		{
			_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2 = _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D;
		}
		if (true)
		{
			_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2._0023_003DzyqMIBlE_003D = nameElement;
		}
		if (_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2._0023_003DzyqMIBlE_003D != string.Empty)
		{
			if (exist && !_0023_003DzZ_WCynaSAf3F.ContainsValue(_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2._0023_003DzyqMIBlE_003D))
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702729);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2._0023_003DzyqMIBlE_003D };
				object[] parameters;
				if (uint.MaxValue != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
			if (!exist && _0023_003DzZ_WCynaSAf3F.ContainsValue(_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2._0023_003DzyqMIBlE_003D))
			{
				string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702698);
				string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2._0023_003DzyqMIBlE_003D };
				throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, null, parameters);
			}
			if (exist)
			{
				return _0023_003DzZ_WCynaSAf3F.First(_0023_003Dz8vHc3nVWUh7J6eKgtmQ_0024BgM_003D2._0023_003DzQTzBREZWhvymnVp8nQ_003D_003D).Key;
			}
		}
		return -1;
	}

	private void _0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		try
		{
			if (MathUtility.IsEqual(_0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D, 0.0) && MathUtility.IsEqual(_0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D, 0.0) && MathUtility.IsEqual(_0023_003DzgndmRBibkutF9hvK9hlU9nE_003D, 0.0))
			{
				return;
			}
			ExistElement(_0023_003DzN7yzk84fqvfGKtFS4SovHzOG9WMz, exist: false);
			if (_0023_003DzDPwSHz8_003D.Elements.Count < 2)
			{
				return;
			}
			Geom_Axis2Placement val = new Geom_Axis2Placement(gp.XOY());
			Geom_Axis2Placement axis2Placement;
			if (uint.MaxValue != 0)
			{
				axis2Placement = val;
			}
			Geom_TrimmedCurve parentCurve = _0023_003DzDPwSHz8_003D.Elements[_0023_003DzDPwSHz8_003D.Elements.Count - 2].ParentCurve;
			Geom_TrimmedCurve val2;
			if (3u != 0)
			{
				val2 = parentCurve;
			}
			Geom_TrimmedCurve parentCurve2 = _0023_003DzDPwSHz8_003D.Elements[_0023_003DzDPwSHz8_003D.Elements.Count - 1].ParentCurve;
			Geom_TrimmedCurve val3;
			if (6u != 0)
			{
				val3 = parentCurve2;
			}
			if (val2 == null || val3 == null)
			{
				return;
			}
			Geom_TrimmedCurve outGeomTrim;
			if (4u != 0)
			{
				outGeomTrim = null;
			}
			Geom_TrimmedCurve outGeomTrim2;
			if (5u != 0)
			{
				outGeomTrim2 = null;
			}
			Geom_TrimmedCurve val4 = default(Geom_TrimmedCurve);
			if (0 == 0)
			{
				val4 = null;
			}
			if (!MathUtility.IsEqual(_0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D, 0.0))
			{
				Geom_TrimmedCurve obj = FilletChamfer.Fillet(val2, val3, _0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D, axis2Placement, out outGeomTrim, out outGeomTrim2, _0023_003DzHdE_0024bwjV3hs2FQEI5Q_003D_003D);
				if (uint.MaxValue != 0)
				{
					val4 = obj;
				}
			}
			else if (!MathUtility.IsEqual(_0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D, 0.0) || !MathUtility.IsEqual(_0023_003DzgndmRBibkutF9hvK9hlU9nE_003D, 0.0))
			{
				val4 = FilletChamfer.Chamfer(val2, val3, _0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D, _0023_003DzgndmRBibkutF9hvK9hlU9nE_003D, axis2Placement, out outGeomTrim, out outGeomTrim2);
			}
			if (val4 != null && outGeomTrim != null && outGeomTrim2 != null)
			{
				_0023_003DzDPwSHz8_003D.Elements[_0023_003DzDPwSHz8_003D.Elements.Count - 2].ParentCurve = outGeomTrim;
				if (((Geom_BoundedCurve)val4).StartPoint().IsEqual(((Geom_BoundedCurve)outGeomTrim2).StartPoint(), PrecisionExtension.Confusion()))
				{
					((Geom_Curve)val4).Reverse();
				}
				_0023_003DzDPwSHz8_003D.Elements[_0023_003DzDPwSHz8_003D.Elements.Count - 1].ParentCurve = val4;
				_0023_003DzDPwSHz8_003D.Elements.Add(new Geom_CompositeCurveSegment(outGeomTrim2));
				string value = string.Empty;
				_0023_003DzZ_WCynaSAf3F.TryGetValue(_0023_003DzDPwSHz8_003D.Elements.Count - 2, out value);
				_0023_003DzZ_WCynaSAf3F.Remove(_0023_003DzDPwSHz8_003D.Elements.Count - 2);
				if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 2))
				{
					_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 2, _0023_003DzN7yzk84fqvfGKtFS4SovHzOG9WMz);
				}
				if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
				{
					_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, value);
				}
				_0023_003DzN7yzk84fqvfGKtFS4SovHzOG9WMz = string.Empty;
				_0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D = 0.0;
				_0023_003DzHdE_0024bwjV3hs2FQEI5Q_003D_003D = FilletType.Normal;
				_0023_003DzTW4w_Wlsy4_0024afG4DOQ_003D_003D = ChamferType.Normal;
				_0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D = 0.0;
				_0023_003DzgndmRBibkutF9hvK9hlU9nE_003D = 0.0;
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreatePolylineStartPoint(double startX, double startY, Workplane plane, int referencePosition)
	{
		try
		{
			_0023_003DzDPwSHz8_003D.IsAbsolute = false;
			_0023_003DzDPwSHz8_003D.Name = base.Name;
			if (3u != 0)
			{
				_0023_003DzeOP_EWGJ0yL_ = plane;
			}
			_0023_003DzDPwSHz8_003D.ReferencePosition = (ReferencePositionType)referencePosition;
			_0023_003DzDPwSHz8_003D.AddFirstPoint(startX, startY, 0.0);
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (3u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (6u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddSegment(string nameElement, double endX, double endY)
	{
		try
		{
			if (2u != 0)
			{
				_0023_003Dzz7S9pv7zqNHSDYPBQWnNChs_003D(ref endX, ref endY);
			}
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddSegment(endX, endY, 0.0);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (true)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dzz7S9pv7zqNHSDYPBQWnNChs_003D(ref double _0023_003DzppTHfF4_003D, ref double _0023_003Dzg98T3NI_003D)
	{
		double num = Math.Abs(_0023_003DzppTHfF4_003D - _0023_003DzDPwSHz8_003D.EndX);
		double num2 = Math.Abs(_0023_003Dzg98T3NI_003D - _0023_003DzDPwSHz8_003D.EndY);
		double num3;
		if (true)
		{
			num3 = num2;
		}
		if (!(Math.Sqrt(num * num + num3 * num3) < 1.5 * PrecisionExtension.Confusion()))
		{
			return;
		}
		double num4 = PrecisionExtension.Confusion() * 4.0;
		double num5;
		if (3u != 0)
		{
			num5 = num4;
		}
		if (_0023_003DzDPwSHz8_003D.Elements.Count > 0)
		{
			Geom_CompositeCurveSegment geom_CompositeCurveSegment = _0023_003DzDPwSHz8_003D.Elements.Last();
			Geom_CompositeCurveSegment geom_CompositeCurveSegment2;
			if (5u != 0)
			{
				geom_CompositeCurveSegment2 = geom_CompositeCurveSegment;
			}
			_ = _0023_003DzDPwSHz8_003D.Elements.Count;
			if (geom_CompositeCurveSegment2.IsSegment)
			{
				double startX = geom_CompositeCurveSegment2.StartX;
				double num6;
				if (7u != 0)
				{
					num6 = startX;
				}
				double startY = geom_CompositeCurveSegment2.StartY;
				double endX = geom_CompositeCurveSegment2.EndX;
				double endY = geom_CompositeCurveSegment2.EndY;
				if (Math.Abs(endX - num6) > 1.5 * PrecisionExtension.Confusion())
				{
					if (endX > num6)
					{
						_0023_003DzppTHfF4_003D += num5;
					}
					else
					{
						_0023_003DzppTHfF4_003D -= num5;
					}
				}
				if (Math.Abs(endY - startY) > 1.5 * PrecisionExtension.Confusion())
				{
					if (endY > startY)
					{
						_0023_003Dzg98T3NI_003D += num5;
					}
					else
					{
						_0023_003Dzg98T3NI_003D -= num5;
					}
				}
			}
			else
			{
				_0023_003DzppTHfF4_003D += num5;
				_0023_003Dzg98T3NI_003D += num5;
			}
		}
		else
		{
			_0023_003DzppTHfF4_003D += num5;
			_0023_003Dzg98T3NI_003D += num5;
		}
	}

	public void AddArc3Points(string nameElement, double p2X, double p2Y, double p3X, double p3Y)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddArcCircle2P(p2X, p2Y, 0.0, p3X, p3Y, 0.0);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (5u != 0)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (5u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddArc2PointRadius(string nameElement, double endX, double endY, double radius, bool isClockwise, bool isOver180)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddArcCircleRadiusP(radius, endX, endY, 0.0, 0.0, 0.0, (!isClockwise) ? 1 : (-1), !isOver180);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (8u != 0)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = default(Exception);
			if (0 == 0)
			{
				ex2 = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			Exception innerException = ex2;
			object[] parameters = Array.Empty<object>();
			if (3u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddArc2PointCenter(string nameElement, double endX, double endY, double centerX, double centerY, bool isClockwise)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddArcCircleCenterP(centerX, centerY, 0.0, 0.0, 0.0, (!isClockwise) ? 1 : (-1), endX, endY, 0.0);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (2u != 0)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (7u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddArcCenterAngle(string nameElement, double centerX, double centerY, double angle)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddArcCircleCenterAngle(centerX, centerY, 0.0, 0.0, 0.0, 1.0, angle);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (0 == 0)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (0 == 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddSegmentTan(string nameElement, double length)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddTanContinue(length);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (5u != 0)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (true)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (4u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddArcTan(string nameElement, double endX, double endY, int option)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddTanContinue(endX, endY, 0.0, option, 0.0, 0.0, 1.0);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (8u != 0)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (uint.MaxValue != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (uint.MaxValue != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void Close(string nameElement)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.CloseSegment();
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
			if (6u != 0)
			{
				_0023_003DzSekqXTJI3_0024SrUSvKwuIDqTOXqZbC();
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (7u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddFillet(string nameElement, double radius, FilletType option)
	{
		if (0 == 0)
		{
			_0023_003DzN7yzk84fqvfGKtFS4SovHzOG9WMz = nameElement;
		}
		if (uint.MaxValue != 0)
		{
			_0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D = radius;
		}
		if (6u != 0)
		{
			_0023_003DzHdE_0024bwjV3hs2FQEI5Q_003D_003D = option;
		}
		_0023_003DzTW4w_Wlsy4_0024afG4DOQ_003D_003D = ChamferType.Normal;
		_0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D = 0.0;
		_0023_003DzgndmRBibkutF9hvK9hlU9nE_003D = 0.0;
	}

	public void AddChamfer(string nameElement, double length1, double length2, ChamferType option)
	{
		if (4u != 0)
		{
			_0023_003DzN7yzk84fqvfGKtFS4SovHzOG9WMz = nameElement;
		}
		if (5u != 0)
		{
			_0023_003Dzaf2SNmZOYyfIqWYvRA_003D_003D = 0.0;
		}
		if (2u != 0)
		{
			_0023_003DzHdE_0024bwjV3hs2FQEI5Q_003D_003D = FilletType.Normal;
		}
		_0023_003DzTW4w_Wlsy4_0024afG4DOQ_003D_003D = option;
		_0023_003Dz4UqrtqcOxVfy5X5ejNprSSA_003D = length1;
		_0023_003DzgndmRBibkutF9hvK9hlU9nE_003D = length2;
	}

	internal override void _0023_003Dza07C_0024Lw_003D()
	{
		bool flag;
		if (2u != 0)
		{
			flag = false;
		}
		if (base.ReferenceKey != null)
		{
			bool isValid = base.ReferenceKey.IsValid;
			if (7u != 0)
			{
				flag = isValid;
			}
		}
		if (flag)
		{
			_projectInterface.UpdateGeometry(_0023_003DzDPwSHz8_003D, this);
			return;
		}
		GeomCompositeCurve geomCompositeCurve = _0023_003DzDPwSHz8_003D;
		GeomGeometry geometry;
		if (2u != 0)
		{
			geometry = geomCompositeCurve;
		}
		_projectInterface.SetGeometryPlane(ref geometry, _0023_003DzeOP_EWGJ0yL_.ReferenceKey);
		_projectInterface.ConvertGeometryToReferencePosition(geometry);
		_projectInterface.AddGeometry(ref geometry, _0023_003DzeOP_EWGJ0yL_.ReferenceKey, isAbsolute: false, this);
		_0023_003DzDPwSHz8_003D = geometry as GeomCompositeCurve;
		base.ReferenceKey = geometry.Key;
	}
}
