using System;
using System.Collections.Generic;
using System.Linq;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.SetupBuilders;

namespace ScmGroup.XCam.Scripting;

public class BlockingProfile : BaseScripting
{
	private sealed class _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D
	{
		public string _0023_003DzyqMIBlE_003D;

		public _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D()
		{
			_ = 1;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzQTzBREZWhvymnVp8nQ_003D_003D(KeyValuePair<int, string> _0023_003DzWFCyUcw_003D)
		{
			string value = _0023_003DzWFCyUcw_003D.Value;
			_ = -1;
			if (6 == 0)
			{
			}
			return value == _0023_003DzyqMIBlE_003D;
		}
	}

	private Dictionary<int, string> _0023_003DzZ_WCynaSAf3F;

	private GeomCompositeCurve _0023_003DzDPwSHz8_003D;

	private double _0023_003DzXEWdZHQ_003D;

	private Workplane _0023_003DzeOP_EWGJ0yL_;

	private Workpiece _0023_003DzlK8gegZdsBGxQee2pw_003D_003D;

	private Workplan _0023_003DznUCtjlDZQWqZ;

	public bool IsClockWise
	{
		get
		{
			try
			{
				Plane obj = _projectInterface.Get(_0023_003DzDPwSHz8_003D.PlaneID) as Plane;
				Plane plane = default(Plane);
				if (0 == 0)
				{
					plane = obj;
				}
				bool result = _0023_003DzDPwSHz8_003D.IsClockwise(plane);
				if (3u != 0)
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
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704668) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

	public bool IsClosed
	{
		get
		{
			try
			{
				bool result = _0023_003DzDPwSHz8_003D.IsClosed();
				if (4u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702887);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704650) };
				object[] parameters;
				if (true)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result2;
			return result2;
		}
	}

	public List<Geometry> Elements
	{
		get
		{
			try
			{
				List<Geometry> list = new List<Geometry>();
				List<Geometry> list2;
				if (4u != 0)
				{
					list2 = list;
				}
				int i;
				if (8u != 0)
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

	public double Length
	{
		get
		{
			try
			{
				double length = _0023_003DzDPwSHz8_003D.Length;
				if (3u != 0)
				{
					return length;
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
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704633) };
				object[] parameters;
				if (7u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public BlockingProfile(ProjectInterface projectInterface)
	{
		if (6u != 0)
		{
			_projectInterface = projectInterface;
		}
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		if (4u != 0)
		{
			_0023_003DzZ_WCynaSAf3F = dictionary;
		}
		GeomCompositeCurve geomCompositeCurve = new GeomCompositeCurve();
		if (7u != 0)
		{
			_0023_003DzDPwSHz8_003D = geomCompositeCurve;
		}
		_0023_003DzXEWdZHQ_003D = 0.0;
	}

	public BlockingProfile(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (0 == 0)
		{
			base.Name = name;
		}
	}

	public int ExistElement(string nameElement, bool exist)
	{
		_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D = new _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D();
		_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2;
		if (5u != 0)
		{
			_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2 = _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D;
		}
		if (2u != 0)
		{
			_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzyqMIBlE_003D = nameElement;
		}
		if (_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzyqMIBlE_003D != string.Empty)
		{
			if (exist && !_0023_003DzZ_WCynaSAf3F.ContainsValue(_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzyqMIBlE_003D))
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702729);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzyqMIBlE_003D };
				object[] parameters;
				if (2u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
			if (!exist && _0023_003DzZ_WCynaSAf3F.ContainsValue(_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzyqMIBlE_003D))
			{
				string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702698);
				string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzyqMIBlE_003D };
				throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, null, parameters);
			}
			if (exist)
			{
				return _0023_003DzZ_WCynaSAf3F.First(_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzQTzBREZWhvymnVp8nQ_003D_003D).Key;
			}
		}
		return -1;
	}

	internal void _0023_003Dzp3txSoKXD01u(double _0023_003Dz7suJGCc_003D, double _0023_003DzEhxZgjo_003D, double _0023_003DzQyvKn_0024c_003D, Workplane _0023_003Dzf54DH27vqdpn, Workpiece _0023_003Dzg7k33EXKxxyV, Workplan _0023_003DzxJ3Gc6wlmHM2)
	{
		try
		{
			_0023_003DzDPwSHz8_003D.IsAbsolute = false;
			_0023_003DzDPwSHz8_003D.Name = base.Name;
			if (3u != 0)
			{
				_0023_003DzeOP_EWGJ0yL_ = _0023_003Dzf54DH27vqdpn;
			}
			if (7u != 0)
			{
				_0023_003DzlK8gegZdsBGxQee2pw_003D_003D = _0023_003Dzg7k33EXKxxyV;
			}
			if (2u != 0)
			{
				_0023_003DznUCtjlDZQWqZ = _0023_003DzxJ3Gc6wlmHM2;
			}
			_0023_003DzDPwSHz8_003D.AddFirstPoint(_0023_003Dz7suJGCc_003D, _0023_003DzEhxZgjo_003D, 0.0);
			_0023_003DzXEWdZHQ_003D = _0023_003DzQyvKn_0024c_003D;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702668), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddSegment(string nameElement, double endX, double endY)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddSegment(endX, endY, 0.0);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
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
			if (4u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
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
			if (6u != 0)
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
			if (8u != 0)
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
			if (3u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddArcCenterAngleToPolyline(string nameElement, double centerX, double centerY, double angle)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddArcCircleCenterAngle(centerX, centerY, 0.0, 0.0, 0.0, 1.0, angle);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (6u != 0)
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

	public void AddSegmentTanToPolyline(string nameElement, double length)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddTanContinue(length);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
			}
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
			if (4u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public void AddArcTanToPolyline(string nameElement, double endX, double endY, int option)
	{
		try
		{
			ExistElement(nameElement, exist: false);
			_0023_003DzDPwSHz8_003D.AddTanContinue(endX, endY, 0.0, option, 0.0, 0.0, 1.0);
			if (!_0023_003DzZ_WCynaSAf3F.ContainsKey(_0023_003DzDPwSHz8_003D.Elements.Count - 1))
			{
				_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
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
			if (0 == 0)
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
			_0023_003DzZ_WCynaSAf3F.Add(_0023_003DzDPwSHz8_003D.Elements.Count - 1, nameElement);
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
			if (4u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	internal override void _0023_003Dza07C_0024Lw_003D()
	{
		GeomGeometry obj = _0023_003DzDPwSHz8_003D.Clone() as GeomGeometry;
		GeomGeometry geometry;
		if (5u != 0)
		{
			geometry = obj;
		}
		if (_0023_003DzlK8gegZdsBGxQee2pw_003D_003D._0023_003Dz22bRUgtajyHzlQdchQ_003D_003D != null && _0023_003DzlK8gegZdsBGxQee2pw_003D_003D._0023_003Dz22bRUgtajyHzlQdchQ_003D_003D.Magnitude() > 0.0)
		{
			geometry.Translate(_0023_003DzlK8gegZdsBGxQee2pw_003D_003D._0023_003Dz22bRUgtajyHzlQdchQ_003D_003D);
		}
		ReferenceKey key = geometry.Key;
		ReferenceKey referenceKey;
		if (true)
		{
			referenceKey = key;
		}
		if (referenceKey == null || !referenceKey.IsValid)
		{
			_projectInterface.AddGeometry(ref geometry, _0023_003DzeOP_EWGJ0yL_.ReferenceKey, _0023_003DzlK8gegZdsBGxQee2pw_003D_003D.ReferenceKey, this);
		}
		bool flag;
		if (true)
		{
			flag = false;
		}
		if (base.ReferenceKey != null)
		{
			flag = base.ReferenceKey.IsValid;
		}
		BlockingRule blockingRule = null;
		blockingRule = ((!flag) ? new ProfileBlockingRule() : (_projectInterface.Get(base.ReferenceKey) as BlockingRule));
		POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
		ProfileBlockingRuleParameters profileBlockingRuleParameters = new ProfileBlockingRuleParameters(context, blockingRule as ProfileBlockingRule);
		profileBlockingRuleParameters.InitializeName(base.Name);
		profileBlockingRuleParameters.InitializeOffset(_0023_003DzXEWdZHQ_003D);
		profileBlockingRuleParameters.InitializeProfile(geometry);
		ProfileBlockingRuleBuilder profileBlockingRuleBuilder = new ProfileBlockingRuleBuilder(context);
		profileBlockingRuleBuilder.InitializeBlockingRule(profileBlockingRuleParameters);
		if (flag)
		{
			profileBlockingRuleBuilder.Update();
			return;
		}
		profileBlockingRuleBuilder.Add(_0023_003DznUCtjlDZQWqZ.ReferenceKey);
		base.ReferenceKey = profileBlockingRuleBuilder.BlockingRule.Key;
	}
}
