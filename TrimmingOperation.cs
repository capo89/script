using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Referentiable;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.Localization;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Milling;
using ScmGroup.XCam.MachiningDataModel.Parametrics;
using ScmGroup.XCam.MachiningDataModel.Patterns;
using ScmGroup.XCam.MachiningDataModel.ProjectData;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Strategy;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.MachiningDataModel.WorkPlane;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Common;
using ScmGroup.XCam.ToolDataModel.Tool;

namespace ScmGroup.XCam.Scripting;

public class TrimmingOperation : Operation
{
	private UI00MachiningOptions _0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D;

	public override uint ToolNumber
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (5u != 0)
				{
					machiningWorkingStep = obj;
				}
				MachiningOperation obj2 = _projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation;
				MachiningOperation machiningOperation;
				if (7u != 0)
				{
					machiningOperation = obj2;
				}
				uint iD = (_projectInterface.Get(machiningOperation.ToolKey) as CoreTool).Key.ID;
				if (5u != 0)
				{
					return iD;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704127) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			uint result;
			return result;
		}
	}

	public override int HeadNumber
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (3u != 0)
				{
					machiningWorkingStep = obj;
				}
				int spindleNumber = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Head.SpindleNumber;
				if (5u != 0)
				{
					return spindleNumber;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704112) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			int result;
			return result;
		}
	}

	public override Geometry Geometry
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (8u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (3u != 0)
				{
					manufacturingFeature = obj2;
				}
				GeomGeometry obj3 = _projectInterface.Get(manufacturingFeature.GeometryID) as GeomGeometry;
				GeomGeometry geomGeometry;
				if (8u != 0)
				{
					geomGeometry = obj3;
				}
				if (geomGeometry is GeomCartesianPoint)
				{
					return new Point(_projectInterface, geomGeometry as GeomCartesianPoint);
				}
				if (geomGeometry is GeomCircle)
				{
					return new Circle(_projectInterface, geomGeometry as GeomCircle);
				}
				if (geomGeometry is GeomEllipse)
				{
					return new Ellipse(_projectInterface, geomGeometry as GeomEllipse);
				}
				if (geomGeometry is GeomTrimmedCurve && (geomGeometry as GeomTrimmedCurve).IsArc)
				{
					return new Arc(_projectInterface, geomGeometry as GeomTrimmedCurve);
				}
				if (geomGeometry is GeomTrimmedCurve && (geomGeometry as GeomTrimmedCurve).IsSegment)
				{
					return new Segment(_projectInterface, geomGeometry as GeomTrimmedCurve);
				}
				if (geomGeometry is GeomTrimmedCurve && (geomGeometry as GeomTrimmedCurve).IsArcOfEllipse)
				{
					return new ArcOfEllipse(_projectInterface, geomGeometry as GeomTrimmedCurve);
				}
				if (geomGeometry is GeomCompositeCurve)
				{
					return new Polyline(_projectInterface, geomGeometry as GeomCompositeCurve);
				}
				return null;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704093) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public override Polyline Toolpath
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double Feed
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep = default(MachiningWorkingStep);
				if (0 == 0)
				{
					machiningWorkingStep = obj;
				}
				double feedrate = ((_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Technology as MillingTechnology).Feedrate;
				if (6u != 0)
				{
					return feedrate;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704080) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double Depth
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (8u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (5u != 0)
				{
					manufacturingFeature = obj2;
				}
				if (!(manufacturingFeature is MachiningFeature))
				{
					return ((manufacturingFeature as ReplicateFeature).BaseFeature as MachiningFeature).Depth.StartDepth;
				}
				double startDepth = (manufacturingFeature as MachiningFeature).Depth.StartDepth;
				if (7u != 0)
				{
					return startDepth;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double ToolDiameter
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (8u != 0)
				{
					machiningWorkingStep = obj;
				}
				MachiningOperation obj2 = _projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation;
				MachiningOperation machiningOperation;
				if (5u != 0)
				{
					machiningOperation = obj2;
				}
				if (!(machiningOperation.ToolKey != null))
				{
					ManufacturingFeature manufacturingFeature = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as MachiningFeature;
					if (manufacturingFeature is MillingMachiningFeature)
					{
						return ((manufacturingFeature as MillingMachiningFeature).SweptShape as SquareUProfile).Width;
					}
					return (((manufacturingFeature as ReplicateFeature).BaseFeature as MillingMachiningFeature).SweptShape as SquareUProfile).Width;
				}
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(machiningOperation.ToolKey, KindOfToolProperty.Diameter).Value);
				if (2u != 0)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703753) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public override double ToolOffset
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (4u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (3u != 0)
				{
					manufacturingFeature = obj2;
				}
				if (!(manufacturingFeature is MillingMachiningFeature))
				{
					return ((manufacturingFeature as ReplicateFeature).BaseFeature as MillingMachiningFeature).SideOffset;
				}
				double sideOffset = (manufacturingFeature as MillingMachiningFeature).SideOffset;
				if (4u != 0)
				{
					return sideOffset;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703736) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override bool ActivateNCCompensation
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (true)
				{
					machiningWorkingStep = obj;
				}
				bool activateCNCCorrection = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).ActivateCNCCorrection;
				if (uint.MaxValue != 0)
				{
					return activateCNCCorrection;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703717) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public override TypeOfProcess TypeOfProcess
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override bool RetractPartial
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double StepLength
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override double SafeRapidLevel
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (8u != 0)
				{
					machiningWorkingStep = obj;
				}
				double approachSecurityPlane = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).ApproachSecurityPlane;
				if (0 == 0)
				{
					return approachSecurityPlane;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703690) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public override double SpindleSpeed
	{
		get
		{
			try
			{
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep;
				if (3u != 0)
				{
					machiningWorkingStep = obj;
				}
				double spindle = ((_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Technology as MillingTechnology).Spindle;
				if (3u != 0)
				{
					return spindle;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703923) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override bool IsNCFunction => false;

	public TrimmingOperation(OperationContext operationContext, string name, ReferenceKey workplanID)
		: base(operationContext, workplanID)
	{
		if (4u != 0)
		{
			base.Name = name;
		}
		UI00MachiningOptions obj = ((_options != null) ? _options.MachiningOptions : null);
		if (3u != 0)
		{
			_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D = obj;
		}
	}

	private void _0023_003Dz_hR6lSynO7nq(GeomGeometry _0023_003DzIqguyi3APZ2P, ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation _0023_003DzIDjFPYA_003D, Attributes _0023_003Dz6oCO56s_003D)
	{
		if (_0023_003DzIDjFPYA_003D.Attributes == null)
		{
			_0023_003DzIDjFPYA_003D.Attributes = new List<OperationAttribute>();
		}
		else
		{
			_0023_003DzIDjFPYA_003D.Attributes.Clear();
		}
		if (_0023_003DzIqguyi3APZ2P is GeomCompositeCurve)
		{
			GeomCompositeCurve obj = _0023_003DzIqguyi3APZ2P as GeomCompositeCurve;
			GeomCompositeCurve geomCompositeCurve;
			if (4u != 0)
			{
				geomCompositeCurve = obj;
			}
			int num;
			if (6u != 0)
			{
				num = 0;
			}
			while (num < _0023_003Dz6oCO56s_003D.Count)
			{
				_0023_003Dz6oCO56s_003D[num].Value.ElementKey = geomCompositeCurve.Elements[_0023_003Dz6oCO56s_003D[num].Index].Key;
				_0023_003DzIDjFPYA_003D.Attributes.Add(_0023_003Dz6oCO56s_003D[num].Value);
				int num2 = num + 1;
				if (7u != 0)
				{
					num = num2;
				}
			}
			return;
		}
		for (int i = 0; i < _0023_003Dz6oCO56s_003D.Count; i++)
		{
			if (_0023_003Dz6oCO56s_003D[i].Index == 0)
			{
				_0023_003DzIDjFPYA_003D.Attributes.Add(_0023_003Dz6oCO56s_003D[i].Value);
			}
		}
	}

	private void _0023_003DzM5S__4mYUuJzozSCT_3HNgrWzHom(Attributes _0023_003Dz6oCO56s_003D)
	{
		int num;
		if (8u != 0)
		{
			num = 0;
		}
		while (num < _0023_003Dz6oCO56s_003D.Count)
		{
			OperationAttribute value = _0023_003Dz6oCO56s_003D[num].Value;
			OperationAttribute operationAttribute;
			if (uint.MaxValue != 0)
			{
				operationAttribute = value;
			}
			if (operationAttribute.GetType() == typeof(RotXAttribute))
			{
				(operationAttribute as RotXAttribute).RotX = 0.0 - (operationAttribute as RotXAttribute).RotX;
			}
			int num2 = num + 1;
			if (6u != 0)
			{
				num = num2;
			}
		}
	}

	public void CreateTrimmingOperation(ActiveProgramParameters activeParameters, TrimmingOperationParameters trimmingParameters, List<MachiningWorkingStep> edgeBandingsWS, string description, double? approachSecurityPlane, double? retractSecurityPlane)
	{
		try
		{
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry _0023_003DzWjXjhJmNSJ96FOW29Q_003D_003D;
			if (4u != 0)
			{
				_0023_003DzWjXjhJmNSJ96FOW29Q_003D_003D = obj;
			}
			if (5u != 0)
			{
				_0023_003Dz6XhlWYPcGFxR(activeParameters, trimmingParameters, edgeBandingsWS, description, approachSecurityPlane, retractSecurityPlane, _0023_003DzWjXjhJmNSJ96FOW29Q_003D_003D);
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (2u != 0)
			{
				innerException = ex;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709493), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dz6XhlWYPcGFxR(ActiveProgramParameters _0023_003DzlG_0024kGXwbOn7X, TrimmingOperationParameters _0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D, List<MachiningWorkingStep> _0023_003DzlTxyPyHDNbfIrnb8DYwL7I0_003D, string _0023_003DzrziU4i4_003D, double? _0023_003DzcBMrs66qS2hN60yeJE_0024SrWQ_003D, double? _0023_003Dzo_C3LN9FaDgFMe5ui2mr0rk_003D, GeomGeometry _0023_003DzWjXjhJmNSJ96FOW29Q_003D_003D)
	{
		ScmGroup.XCam.MachiningDataModel.TrimmingOperation trimmingOperation = new ScmGroup.XCam.MachiningDataModel.TrimmingOperation();
		ScmGroup.XCam.MachiningDataModel.TrimmingOperation trimmingOperation2;
		if (3u != 0)
		{
			trimmingOperation2 = trimmingOperation;
		}
		TrimmingFeature trimmingFeature = new TrimmingFeature();
		TrimmingFeature feature;
		if (3u != 0)
		{
			feature = trimmingFeature;
		}
		CoreTool coreTool = _0023_003DzCP7__0024l7ucReU(_0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.Tool);
		CoreTool coreTool2;
		if (7u != 0)
		{
			coreTool2 = coreTool;
		}
		TrimmerMill obj = (coreTool2 as CuttingTool).ToolBody as TrimmerMill;
		TrimmerMill _0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D;
		if (2u != 0)
		{
			_0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D = obj;
		}
		ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(_0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.Head);
		ScmGroup.XCam.ConfigDataModel.Heads.Head configHead2;
		if (2u != 0)
		{
			configHead2 = configHead;
		}
		ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(_0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.Head, configHead2, _0023_003DzlG_0024kGXwbOn7X.MachineID);
		ScmGroup.XCam.MachiningDataModel.Head head;
		if (8u != 0)
		{
			head = builderHead;
		}
		bool flag;
		if (true)
		{
			flag = false;
		}
		Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(_0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.RotSpeed, _0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.Speed);
		Tuple<object, object> tuple;
		if (8u != 0)
		{
			tuple = builderTechnologySpeeds;
		}
		ReferenceToolKey referenceToolKey = null;
		if (coreTool2 != null)
		{
			referenceToolKey = new ReferenceToolKey(coreTool2.Key, coreTool2.Name);
		}
		if (referenceToolKey == null)
		{
			_0023_003DzuJOUyAMySoAB(base.Name, _0023_003DzrziU4i4_003D, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704548), _0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.Tool);
		}
		bool disableDustPan = false;
		if (ToolMethods.GetToolFamily(coreTool2) == KindOfToolFamily.BladeCuttingTool)
		{
			disableDustPan = true;
		}
		GetBuilderMachineFunctions(_0023_003DzlG_0024kGXwbOn7X.MachineFunctions, disableDustPan, coreTool2, head, feature);
		GeomCompositeCurve geomCompositeCurve = _0023_003DzWjXjhJmNSJ96FOW29Q_003D_003D as GeomCompositeCurve;
		if (geomCompositeCurve != null && geomCompositeCurve.Elements.Count != 0)
		{
			_0023_003DzM5S__4mYUuJzozSCT_3HNgrWzHom(_0023_003DzlG_0024kGXwbOn7X.Attributes);
			_0023_003Dz_hR6lSynO7nq(_0023_003DzWjXjhJmNSJ96FOW29Q_003D_003D, trimmingOperation2, _0023_003DzlG_0024kGXwbOn7X.Attributes);
		}
		MachiningWorkingStep workingStep = new MachiningWorkingStep();
		POMContext context = new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface);
		WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
		workingStepParameters.InitializeName(base.Name);
		workingStepParameters.InitializeDescription(_0023_003DzrziU4i4_003D);
		workingStepParameters.InitializePriority(_0023_003DzlG_0024kGXwbOn7X.Priority);
		TrimmingFeatureFeatureParameters trimmingFeatureFeatureParameters = new TrimmingFeatureFeatureParameters(context, feature);
		trimmingFeatureFeatureParameters.InitializeDepth(0, 0, new ThroughMillingBottom());
		trimmingFeatureFeatureParameters.InitializeToolCompensation(SideType.Left, _0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.OverMaterial, false);
		trimmingFeatureFeatureParameters.InitializeToolApproach(TypeOfToolApproach.NormalLeft);
		trimmingFeatureFeatureParameters.InitizializeTrimmingType(_0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.TrimmingType);
		TrimmingFeatureOperationParameters trimmingFeatureOperationParameters = new TrimmingFeatureOperationParameters(context, trimmingOperation2, _0023_003DzlTxyPyHDNbfIrnb8DYwL7I0_003D);
		trimmingFeatureOperationParameters.InitializeCNMode(flag);
		trimmingFeatureOperationParameters.InitializeHead(head);
		trimmingFeatureOperationParameters.InitializeTechnology(referenceToolKey, tuple.Item2, tuple.Item1);
		double num = 0.0;
		if (_0023_003DzcBMrs66qS2hN60yeJE_0024SrWQ_003D.HasValue)
		{
			num = _0023_003DzcBMrs66qS2hN60yeJE_0024SrWQ_003D.Value;
		}
		double num2 = 0.0;
		if (_0023_003Dzo_C3LN9FaDgFMe5ui2mr0rk_003D.HasValue)
		{
			num2 = _0023_003Dzo_C3LN9FaDgFMe5ui2mr0rk_003D.Value;
		}
		trimmingFeatureOperationParameters.InitializeSafetyDistance(num, num2);
		trimmingFeatureOperationParameters.InitializeHead(trimmingOperation2.Head);
		trimmingFeatureOperationParameters.InitializeStrategy(null);
		trimmingFeatureOperationParameters.InitializeMachineFunctions(trimmingOperation2.MachineFunctions);
		TrimmingApproachStrategy trimmingApproachStrategy = new TrimmingApproachStrategy();
		TrimmingRetractStrategy trimmingRetractStrategy = new TrimmingRetractStrategy();
		_0023_003DzsnFpB7zgjTHfzR9cmiQH5S6r050J(trimmingApproachStrategy, trimmingRetractStrategy, _0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D);
		trimmingApproachStrategy.Angle = MathUtility.ConvertToRadians(_0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.ApproachAngle);
		trimmingApproachStrategy.InfeedSectionAdvance = _0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.InfeedAdvance;
		trimmingRetractStrategy.OutfeedSectionDelay = _0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.OutfeedDelay;
		trimmingRetractStrategy.Angle = _0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.RetractAngle;
		trimmingFeatureOperationParameters.InitializeApproach(trimmingApproachStrategy);
		trimmingFeatureOperationParameters.InitializeRetract(trimmingRetractStrategy);
		trimmingFeatureOperationParameters.InitializeExtraDepth(_0023_003DzC9JbgjTSh1bYxk_0024YLg_003D_003D.OverMaterial);
		TrimmingFeatureGeometryParameters geometryParameters = new TrimmingFeatureGeometryParameters(context, _0023_003DzWjXjhJmNSJ96FOW29Q_003D_003D);
		ReferenceKey workplanID = _workplanID;
		ReferenceKey referenceKey = _0023_003DzlG_0024kGXwbOn7X.Workpiece.ReferenceKey;
		ReferenceKey referenceKey2 = _0023_003DzlG_0024kGXwbOn7X.Workplane.ReferenceKey;
		TrimmingFeatureBuilder trimmingFeatureBuilder = new TrimmingFeatureBuilder(context);
		trimmingFeatureBuilder.InitializeFeature(trimmingFeatureFeatureParameters);
		trimmingFeatureBuilder.InitializeGeometry(geometryParameters);
		trimmingFeatureBuilder.InitializeOperation(trimmingFeatureOperationParameters);
		trimmingFeatureBuilder.InitializeWorkingStep(workingStepParameters);
		trimmingFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
		base.ReferenceKey = trimmingFeatureBuilder.WorkingStep.Key;
	}

	public void CreateTrimmingOperation(ActiveProgramParameters activeParameters, TrimmingOperationParameters trimmingParameters, string description, double? approachSecurityPlane, double? retractSecurityPlane)
	{
		try
		{
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry;
			if (4u != 0)
			{
				geomGeometry = obj;
			}
			List<Executable> geometryWorkingsteps = _projectInterface.GetGeometryWorkingsteps(geomGeometry.Key);
			List<MachiningWorkingStep> list = new List<MachiningWorkingStep>();
			List<MachiningWorkingStep> list2;
			if (2u != 0)
			{
				list2 = list;
			}
			List<Executable>.Enumerator enumerator = geometryWorkingsteps.GetEnumerator();
			List<Executable>.Enumerator enumerator2;
			if (uint.MaxValue != 0)
			{
				enumerator2 = enumerator;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					MachiningWorkingStep machiningWorkingStep = enumerator2.Current as MachiningWorkingStep;
					if (_projectInterface.Get(machiningWorkingStep.OperationID) is EdgeBandingProcessOperation)
					{
						list2.Add(machiningWorkingStep);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
			_0023_003Dz6XhlWYPcGFxR(activeParameters, trimmingParameters, list2, description, approachSecurityPlane, retractSecurityPlane, geomGeometry);
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709493), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003DzsnFpB7zgjTHfzR9cmiQH5S6r050J(TrimmingApproachStrategy _0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D, TrimmingRetractStrategy _0023_003DzVmargbixKugD, TrimmerMill _0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D)
	{
		if (_0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D != null)
		{
			double horizontalCopying = _0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D.HorizontalCopying;
			double horizontalCopying2;
			if (true)
			{
				horizontalCopying2 = horizontalCopying;
			}
			double verticalCopying = _0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D.VerticalCopying;
			double verticalCopying2;
			if (uint.MaxValue != 0)
			{
				verticalCopying2 = verticalCopying;
			}
			_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.HorizontalCopying = horizontalCopying2;
			_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.VerticalCopying = verticalCopying2;
			_0023_003DzVmargbixKugD.VerticalCopying = verticalCopying2;
			_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.Angle = _options.TrimmingOptions.ApproachAngle;
			_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.InfeedSectionAdvance = _options.TrimmingOptions.InfeedSectionAdvance;
			_0023_003DzVmargbixKugD.OutfeedSectionDelay = _options.TrimmingOptions.OutfeedSectionDelay;
			_0023_003DzVmargbixKugD.Angle = _options.TrimmingOptions.RetractAngle;
			if (_0023_003DzyIhAGvmjdRpxkdMM2w_003D_003D.CopyingType == KindOfCopier.Upper)
			{
				_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.RendezVousSecurityDistance = _options.TrimmingOptions.UpperTrimmingSecurityRVDistance;
				_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.XYDistanceFromEdge = _options.TrimmingOptions.UpperTrimmingXYDistanceFromEdge;
				_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.ZDistanceUnderEdge = _options.TrimmingOptions.UpperTrimmingZDistanceOverEdge;
				_0023_003DzVmargbixKugD.RendezVousSecurityDistance = _options.TrimmingOptions.UpperTrimmingSecurityRVDistance;
				_0023_003DzVmargbixKugD.XYDistanceFromEdge = _options.TrimmingOptions.UpperTrimmingXYDistanceFromEdge;
				_0023_003DzVmargbixKugD.ZDistanceUnderEdge = _options.TrimmingOptions.UpperTrimmingZDistanceOverEdge;
			}
		}
	}

	private void _0023_003DzuJOUyAMySoAB(string _0023_003DzJ3hfjPs_003D, string _0023_003DzrziU4i4_003D, string _0023_003DzTgF4RrM_003D, string _0023_003DzqmiDBVY_003D)
	{
		string empty = string.Empty;
		string text;
		if (7u != 0)
		{
			text = empty;
		}
		if (_projectInterface.Get(_workplanID) is ScriptSubProgram)
		{
			return;
		}
		if (!string.IsNullOrEmpty(_0023_003DzrziU4i4_003D))
		{
			string text2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703906) + _0023_003DzrziU4i4_003D + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703895);
			if (6u != 0)
			{
				text = text2;
			}
		}
		string errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703888), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzqmiDBVY_003D, _0023_003DzJ3hfjPs_003D, text, _0023_003DzTgF4RrM_003D);
		if (6u != 0)
		{
			_errorString = errorString;
		}
		AddToErrorFile(_errorString);
	}

	public void CheckExpression(string propertyName, object propertyValue)
	{
		if (!StringUtility.IsValid(propertyName))
		{
			return;
		}
		MachiningWorkingStepData machiningWorkingStepData = _projectInterface.GetMachiningWorkingStepData(base.ReferenceKey);
		MachiningWorkingStepData machiningWorkingStepData2;
		if (4u != 0)
		{
			machiningWorkingStepData2 = machiningWorkingStepData;
		}
		if (!(machiningWorkingStepData2 != null))
		{
			return;
		}
		if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067))
		{
			if (machiningWorkingStepData2.Feature.IsValid())
			{
				ReferenceKey key = machiningWorkingStepData2.Feature.Key;
				ReferenceKey key2;
				if (6u != 0)
				{
					key2 = key;
				}
				CompositeField compositeField = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703853));
				PropertyField property;
				if (2u != 0)
				{
					property = compositeField;
				}
				_projectInterface.CheckExpressions(key2, property, propertyValue);
				CompositeField compositeField2 = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703838));
				if (3u != 0)
				{
					property = compositeField2;
				}
				_projectInterface.CheckExpressions(key2, property, propertyValue);
			}
		}
		else if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703821))
		{
			if (machiningWorkingStepData2.Feature.IsValid())
			{
				ReferenceKey key3 = machiningWorkingStepData2.Feature.Key;
				PropertyField property2 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703821));
				_projectInterface.CheckExpressions(key3, property2, propertyValue);
			}
		}
		else if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704574))
		{
			if (machiningWorkingStepData2.Feature.IsValid())
			{
				ReferenceKey key4 = machiningWorkingStepData2.Feature.Key;
				PropertyField property3 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704574));
				_projectInterface.CheckExpressions(key4, property3, propertyValue);
			}
		}
		else if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704559) && machiningWorkingStepData2.Feature.IsValid())
		{
			ReferenceKey key5 = machiningWorkingStepData2.Feature.Key;
			PropertyField property4 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704559));
			_projectInterface.CheckExpressions(key5, property4, propertyValue);
		}
	}

	private CoreTool _0023_003DzCP7__0024l7ucReU(string _0023_003DzlCSVU0o_003D)
	{
		_ = 0;
		if (2 == 0)
		{
		}
		ToolInterface toolInterface = _toolInterface;
		_ = 3;
		if (false)
		{
		}
		return toolInterface.Get(_0023_003DzlCSVU0o_003D);
	}

	private double _0023_003Dzd_6vS81LHZfQ(double _0023_003DzX1WK4z0_003D)
	{
		_ = -1;
		if (5 == 0)
		{
		}
		_ = 2;
		if (1 == 0)
		{
		}
		return ConvertLengthToCurrentUnit(_0023_003DzX1WK4z0_003D);
	}

	private double _0023_003DzH1tQYnLqOUsq(double _0023_003DzbDCdcxRsxdCG)
	{
		_ = 6;
		if (5 == 0)
		{
		}
		_ = 0;
		if (7 == 0)
		{
		}
		return ConvertLengthToCurrentUnit(_0023_003DzbDCdcxRsxdCG);
	}

	private bool _0023_003DzaqRkLCrDhUFH(bool _0023_003DzqydnvRs20KT_0024, WorkPlaneCategory _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D)
	{
		bool result;
		if (8u != 0)
		{
			result = _0023_003DzqydnvRs20KT_0024;
		}
		bool num = _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.CYFLEX_HP2 || _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.CYFLEX_F1300 || _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.CYFLEX_F900;
		bool num2 = _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.UNIFLEX_HP || _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.UNIFLEX_S;
		bool flag;
		if (2u != 0)
		{
			flag = num2;
		}
		if (num || flag)
		{
			if (0 == 0)
			{
				result = false;
			}
		}
		return result;
	}

	private void _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(MachiningOperation _0023_003DzIDjFPYA_003D, int _0023_003Dzq_0024W2yCc_003D, string _0023_003DzYEQjc18_003D, int _0023_003Dznv8znP1vlgf_0024)
	{
		ScmGroup.XCam.MachiningDataModel.Head head;
		if (6u != 0)
		{
			head = null;
		}
		if (_0023_003Dznv8znP1vlgf_0024 >= 3)
		{
			ScmGroup.XCam.MachiningDataModel.Head head2 = new ScmGroup.XCam.MachiningDataModel.Head(_0023_003Dznv8znP1vlgf_0024, TypeOfHead.None);
			if (3u != 0)
			{
				head = head2;
			}
		}
		if (_0023_003Dzq_0024W2yCc_003D > 0 && _configurationInterface != null)
		{
			Machine configurationMachine = _configurationInterface.GetConfigurationMachine(_0023_003Dzq_0024W2yCc_003D - 1, clone: false);
			Machine machine;
			if (8u != 0)
			{
				machine = configurationMachine;
			}
			if (machine != null)
			{
				if (head == null)
				{
					head = new ScmGroup.XCam.MachiningDataModel.Head();
				}
				head.MachineName = machine.Name;
				if (_0023_003Dznv8znP1vlgf_0024 >= 10000)
				{
					head.HeadsGroupNumber = _0023_003Dznv8znP1vlgf_0024 / 1000 % 10;
					head.HeadsGroupType = (TypeOfHeadsGroup)(_0023_003Dznv8znP1vlgf_0024 / 10000);
					head.MachiningSpindle = _0023_003Dznv8znP1vlgf_0024 % 100;
					head.Number = _0023_003Dznv8znP1vlgf_0024 / 100 % 10;
				}
			}
		}
		_0023_003DzIDjFPYA_003D.Head = head;
	}
}
