using System;
using System.Collections.Generic;
using OccExtension;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class ToolPath : BaseScripting
{
	protected List<Toolpath> _toolPathList;

	protected GeomCartesianPoint _startPnt;

	protected GeomCompositeCurve _toolPathCurve;

	protected ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation _operation;

	protected ReferenceKey _planeID;

	protected Attributes _attributes;

	public ToolPath(ProjectInterface projectInterface)
	{
		List<Toolpath> toolPathList = new List<Toolpath>();
		if (8u != 0)
		{
			_toolPathList = toolPathList;
		}
		Attributes attributes = new Attributes();
		if (7u != 0)
		{
			_attributes = attributes;
		}
		base._002Ector();
		if (3u != 0)
		{
			_projectInterface = projectInterface;
		}
	}

	public ToolPath(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (uint.MaxValue != 0)
		{
			base.Name = name;
		}
	}

	public void CreateToolpath(double startX, double startY, double startZ, Operation scriptOperation)
	{
		try
		{
			MachiningWorkingStep obj = _projectInterface.Get(scriptOperation.ReferenceKey) as MachiningWorkingStep;
			MachiningWorkingStep machiningWorkingStep;
			if (true)
			{
				machiningWorkingStep = obj;
			}
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation = _projectInterface.Get(machiningWorkingStep.OperationID) as ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation;
			if (true)
			{
				_operation = operation;
			}
			ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
			ManufacturingFeature manufacturingFeature;
			if (8u != 0)
			{
				manufacturingFeature = obj2;
			}
			GeomGeometry geomGeometry = _projectInterface.Get(manufacturingFeature.GeometryID) as GeomGeometry;
			if (geomGeometry != null)
			{
				_planeID = geomGeometry.PlaneID;
			}
			else
			{
				_planeID = null;
			}
			base.ReferenceKey = _operation.Key;
			_startPnt = new GeomCartesianPoint(startX, startY, startZ);
			_toolPathCurve = new GeomCompositeCurve();
			_toolPathCurve.IsAbsolute = false;
			_toolPathCurve.PlaneID = _planeID;
			CutterLocationTrajectory cutterLocationTrajectory = new CutterLocationTrajectory(_toolPathCurve, new ToolDirection(), ToolPathType.TrajectoryPath);
			_toolPathCurve = cutterLocationTrajectory.BasicCurve as GeomCompositeCurve;
			_toolPathList.Add(cutterLocationTrajectory);
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddSegmentToToolpath(double endX, double endY, double endZ)
	{
		try
		{
			if (_startPnt != null && _toolPathCurve != null)
			{
				GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(_startPnt.X, _startPnt.Y, _startPnt.Z, endX, endY, endZ);
				GeomTrimmedCurve geomTrimmedCurve2;
				if (2u != 0)
				{
					geomTrimmedCurve2 = geomTrimmedCurve;
				}
				geomTrimmedCurve2.PlaneID = _planeID;
				geomTrimmedCurve2.IsAbsolute = false;
				_toolPathCurve.Elements.Add(new Geom_CompositeCurveSegment(geomTrimmedCurve2.TypedGeometry()));
				GeomCartesianPoint startPnt = new GeomCartesianPoint(endX, endY, endZ);
				if (uint.MaxValue != 0)
				{
					_startPnt = startPnt;
				}
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (2u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddArc3PointsToToolpath(double p2X, double p2Y, double p3X, double p3Y, double p3Z)
	{
		try
		{
			if (_startPnt != null && _toolPathCurve != null)
			{
				GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(_startPnt.X, _startPnt.Y, _startPnt.Z, p2X, p2Y, _startPnt.Z, p3X, p3Y, _startPnt.Z);
				GeomTrimmedCurve geomTrimmedCurve2;
				if (8u != 0)
				{
					geomTrimmedCurve2 = geomTrimmedCurve;
				}
				geomTrimmedCurve2.PlaneID = _planeID;
				geomTrimmedCurve2.IsAbsolute = false;
				geomTrimmedCurve2.ModifyQuoteZ(_startPnt.Z, p3Z);
				_toolPathCurve.Elements.Add(new Geom_CompositeCurveSegment(geomTrimmedCurve2.TypedGeometry()));
				GeomCartesianPoint startPnt = new GeomCartesianPoint(p3X, p3Y, p3Z);
				if (2u != 0)
				{
					_startPnt = startPnt;
				}
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (true)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddArc2PointCenterToToolpath(double endX, double endY, double endZ, double centerX, double centerY, bool isClockwise)
	{
		try
		{
			if (_startPnt != null && _toolPathCurve != null)
			{
				GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(_startPnt.X, _startPnt.Y, 0.0, endX, endY, 0.0, centerX, centerY, 0.0, 0.0, 0.0, (!isClockwise) ? 1 : (-1));
				GeomTrimmedCurve geomTrimmedCurve2;
				if (7u != 0)
				{
					geomTrimmedCurve2 = geomTrimmedCurve;
				}
				geomTrimmedCurve2.PlaneID = _planeID;
				geomTrimmedCurve2.IsAbsolute = false;
				geomTrimmedCurve2.ModifyQuoteZ(_startPnt.Z, endZ);
				_toolPathCurve.Elements.Add(new Geom_CompositeCurveSegment(geomTrimmedCurve2.TypedGeometry()));
				GeomCartesianPoint startPnt = new GeomCartesianPoint(endX, endY, endZ);
				if (3u != 0)
				{
					_startPnt = startPnt;
				}
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddArc2PointRadiusToToolpath(double endX, double endY, double endZ, double radius, bool isClockwise, bool isOver180)
	{
		try
		{
			if (_startPnt != null && _toolPathCurve != null)
			{
				GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(_startPnt.X, _startPnt.Y, 0.0, endX, endY, 0.0, 0.0, 0.0, (!isClockwise) ? 1 : (-1), radius, !isOver180);
				GeomTrimmedCurve geomTrimmedCurve2;
				if (6u != 0)
				{
					geomTrimmedCurve2 = geomTrimmedCurve;
				}
				geomTrimmedCurve2.PlaneID = _planeID;
				geomTrimmedCurve2.IsAbsolute = false;
				geomTrimmedCurve2.ModifyQuoteZ(_startPnt.Z, endZ);
				_toolPathCurve.Elements.Add(new Geom_CompositeCurveSegment(geomTrimmedCurve2.TypedGeometry()));
				GeomCartesianPoint startPnt = new GeomCartesianPoint(endX, endY, endZ);
				if (3u != 0)
				{
					_startPnt = startPnt;
				}
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddArcCenterAngleToToolpath(double centerX, double centerY, double endZ, double angle)
	{
		try
		{
			if (_startPnt != null && _toolPathCurve != null)
			{
				GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(_startPnt.X, _startPnt.Y, 0.0, centerX, centerY, 0.0, 0.0, 0.0, 1.0, angle);
				GeomTrimmedCurve geomTrimmedCurve2;
				if (4u != 0)
				{
					geomTrimmedCurve2 = geomTrimmedCurve;
				}
				geomTrimmedCurve2.PlaneID = _planeID;
				geomTrimmedCurve2.IsAbsolute = false;
				geomTrimmedCurve2.ModifyQuoteZ(_startPnt.Z, endZ);
				_toolPathCurve.Elements.Add(new Geom_CompositeCurveSegment(geomTrimmedCurve2.TypedGeometry()));
				GeomCartesianPoint startPnt = new GeomCartesianPoint(geomTrimmedCurve2.EndX, geomTrimmedCurve2.EndY, endZ);
				if (uint.MaxValue != 0)
				{
					_startPnt = startPnt;
				}
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public virtual void SetAttribute(string name, double value)
	{
		if (0 == 0)
		{
			int num = 0;
		}
		if (_toolPathList.Count > 0 && _toolPathCurve != null)
		{
			int num2 = Math.Max(_toolPathCurve.Elements.Count - 1, 0);
			int num;
			if (7u != 0)
			{
				num = num2;
			}
			OperationAttribute operationAttribute = Attribute.Create(name, value);
			OperationAttribute operationAttribute2;
			if (4u != 0)
			{
				operationAttribute2 = operationAttribute;
			}
			if (operationAttribute2 != null)
			{
				_attributes.Add(new Attribute(operationAttribute2, num));
			}
		}
	}

	internal override void _0023_003Dza07C_0024Lw_003D()
	{
		if (_operation == null || _toolPathList.Count <= 0)
		{
			return;
		}
		_operation.ActivateCNCCorrection = false;
		_operation.ToolpathList = _toolPathList;
		_operation.ToolpathPriority = false;
		if (_attributes.Count == 0)
		{
			_toolPathList[0].Attributes = null;
		}
		else
		{
			List<OperationAttribute> list = new List<OperationAttribute>();
			List<OperationAttribute> list2;
			if (4u != 0)
			{
				list2 = list;
			}
			int num;
			if (uint.MaxValue != 0)
			{
				num = 0;
			}
			while (num < _attributes.Count)
			{
				_attributes[num].Value.ElementKey = _toolPathCurve.Elements[_attributes[num].Index].Key;
				list2.Add(_attributes[num].Value);
				int num2 = num + 1;
				if (7u != 0)
				{
					num = num2;
				}
			}
			_toolPathList[0].Attributes = list2;
		}
		_projectInterface.UpdateOperation(_operation, this);
	}
}
