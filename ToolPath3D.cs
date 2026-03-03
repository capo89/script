using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Strategy;

namespace ScmGroup.XCam.Scripting;

public class ToolPath3D : ToolPath
{
	private sealed class _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D
	{
		public OperationAttribute _0023_003DzLDWhkEg_003D;

		public _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D()
		{
			_ = -1;
			if (false)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dzvoat2ITsWKwmsIFgNw_003D_003D(OperationAttribute _0023_003DzdO6rEgA_003D)
		{
			_ = 7;
			if (1 == 0)
			{
			}
			Type type = _0023_003DzdO6rEgA_003D.GetType();
			_ = 1;
			if (false)
			{
			}
			return type == _0023_003DzLDWhkEg_003D.GetType();
		}
	}

	public ToolPath3D(ProjectInterface projectInterface)
	{
		_ = 2;
		if (false)
		{
		}
		_ = 2;
		if (false)
		{
		}
		base._002Ector(projectInterface);
	}

	public ToolPath3D(string name, ProjectInterface projectInterface)
	{
		_ = 8;
		if (8 == 0)
		{
		}
		_ = 7;
		if (3 == 0)
		{
		}
		_ = -1;
		if (8 == 0)
		{
		}
		base._002Ector(name, projectInterface);
	}

	public new void CreateToolpath(double startX, double startY, double startZ, Operation scriptOperation)
	{
		try
		{
			if (7u != 0)
			{
				_planeID = null;
			}
			MachiningWorkingStep obj = _projectInterface.Get(scriptOperation.ReferenceKey) as MachiningWorkingStep;
			MachiningWorkingStep machiningWorkingStep;
			if (true)
			{
				machiningWorkingStep = obj;
			}
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation = _projectInterface.Get(machiningWorkingStep.OperationID) as ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation;
			if (8u != 0)
			{
				_operation = operation;
			}
			base.ReferenceKey = _operation.Key;
			double rotationZ = 0.0;
			double rotationX = 0.0;
			if (_operation is MillingTypeOperation millingTypeOperation)
			{
				BaseApproach3DStrategy baseApproach3DStrategy = millingTypeOperation.Approach as BaseApproach3DStrategy;
				if (baseApproach3DStrategy != null)
				{
					ToolDirection toolDirection = baseApproach3DStrategy.ToolDirection;
					if (toolDirection != null)
					{
						rotationZ = toolDirection.ZRotation ?? 0.0;
						rotationX = toolDirection.XRotation ?? 0.0;
					}
				}
			}
			FiveAxisCutterLocationTrajectory item = new FiveAxisCutterLocationTrajectory
			{
				RotationX = rotationX,
				RotationZ = rotationZ,
				X = startX,
				Y = startY,
				Z = startZ,
				Type = ToolPathType.Approach
			};
			_toolPathList.Add(item);
			_startPnt = new GeomCartesianPoint(startX, startY, startZ);
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddSegmentToToolpath(double endX, double endY, double endZ, double? ZRotation = null, double? XRotation = null)
	{
		try
		{
			if (_startPnt != null)
			{
				double? num;
				if (8u != 0)
				{
					num = ZRotation;
				}
				double num2 = MathUtility.ConvertToRadians(num ?? 0.0);
				double rotationZ;
				if (4u != 0)
				{
					rotationZ = num2;
				}
				if (uint.MaxValue != 0)
				{
					num = XRotation;
				}
				double rotationX = MathUtility.ConvertToRadians(num ?? 0.0);
				FiveAxisCutterLocationTrajectory item = new FiveAxisCutterLocationTrajectory
				{
					RotationX = rotationX,
					RotationZ = rotationZ,
					X = endX,
					Y = endY,
					Z = endZ,
					Type = ToolPathType.TrajectoryPath
				};
				_toolPathList.Add(item);
				_startPnt = new GeomCartesianPoint(endX, endY, endZ);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709530), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public override void SetAttribute(string name, double value)
	{
		if (_toolPathList.Count > 0)
		{
			_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D = new _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D();
			_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D2 = default(_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D);
			if (0 == 0)
			{
				_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D2 = _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D;
			}
			_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D3 = _0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D2;
			OperationAttribute _0023_003DzLDWhkEg_003D = Attribute.Create(name, value);
			if (4u != 0)
			{
				_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D3._0023_003DzLDWhkEg_003D = _0023_003DzLDWhkEg_003D;
			}
			if (_toolPathList[_toolPathList.Count - 1].Attributes == null)
			{
				_toolPathList[_toolPathList.Count - 1].Attributes = new List<OperationAttribute>();
			}
			else
			{
				_toolPathList[_toolPathList.Count - 1].Attributes.RemoveAll(_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D2._0023_003Dzvoat2ITsWKwmsIFgNw_003D_003D);
			}
			_toolPathList[_toolPathList.Count - 1].Attributes.Add(_0023_003Dz410G8nelc4TSEW3S_0024w_003D_003D2._0023_003DzLDWhkEg_003D);
		}
	}

	internal override void _0023_003Dza07C_0024Lw_003D()
	{
		_ = 5;
		if (8 == 0)
		{
		}
		if (_operation == null)
		{
			return;
		}
		_ = 0;
		if (2 == 0)
		{
		}
		if (_toolPathList.Count > 0)
		{
			_ = 8;
			if (8 == 0)
			{
			}
			_operation.ActivateCNCCorrection = false;
			_operation.ToolpathList = _toolPathList;
			_operation.ToolpathPriority = false;
			_projectInterface.UpdateOperation(_operation, this);
		}
	}
}
