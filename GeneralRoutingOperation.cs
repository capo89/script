using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCAM.GeometryDataModel;
using ScmGroup.XCam.Localization;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Milling;
using ScmGroup.XCam.MachiningDataModel.Parametrics;
using ScmGroup.XCam.MachiningDataModel.Patterns;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Strategy;
using ScmGroup.XCam.MachiningDataModel.ToolpathGeneration;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.MachiningDataModel.WorkPlane;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Common;
using ScmGroup.XCam.ToolDataModel.Tool;

namespace ScmGroup.XCam.Scripting;

public class GeneralRoutingOperation : Operation
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
				if (6u != 0)
				{
					machiningWorkingStep = obj;
				}
				MachiningOperation obj2 = _projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation;
				MachiningOperation machiningOperation = default(MachiningOperation);
				if (0 == 0)
				{
					machiningOperation = obj2;
				}
				uint iD = (_projectInterface.Get(machiningOperation.ToolKey) as CoreTool).Key.ID;
				if (7u != 0)
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
				if (4u != 0)
				{
					machiningWorkingStep = obj;
				}
				int spindleNumber = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Head.SpindleNumber;
				if (2u != 0)
				{
					return spindleNumber;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
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
				if (7u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (6u != 0)
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
				MachiningWorkingStep machiningWorkingStep;
				if (3u != 0)
				{
					machiningWorkingStep = obj;
				}
				double feedrate = ((_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Technology as MillingTechnology).Feedrate;
				if (uint.MaxValue != 0)
				{
					return feedrate;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
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
				if (7u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (6u != 0)
				{
					manufacturingFeature = obj2;
				}
				if (!(manufacturingFeature is MachiningFeature))
				{
					return ((manufacturingFeature as ReplicateFeature).BaseFeature as MachiningFeature).Depth.StartDepth;
				}
				double startDepth = (manufacturingFeature as MachiningFeature).Depth.StartDepth;
				if (5u != 0)
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
				if (7u != 0)
				{
					machiningWorkingStep = obj;
				}
				MachiningOperation obj2 = _projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation;
				MachiningOperation machiningOperation;
				if (4u != 0)
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
				if (7u != 0)
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
				if (8u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (8u != 0)
				{
					manufacturingFeature = obj2;
				}
				if (!(manufacturingFeature is MillingMachiningFeature))
				{
					return ((manufacturingFeature as ReplicateFeature).BaseFeature as MillingMachiningFeature).SideOffset;
				}
				double sideOffset = (manufacturingFeature as MillingMachiningFeature).SideOffset;
				if (7u != 0)
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
				if (3u != 0)
				{
					machiningWorkingStep = obj;
				}
				bool activateCNCCorrection = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).ActivateCNCCorrection;
				if (7u != 0)
				{
					return activateCNCCorrection;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
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
				if (uint.MaxValue != 0)
				{
					machiningWorkingStep = obj;
				}
				double approachSecurityPlane = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).ApproachSecurityPlane;
				if (2u != 0)
				{
					return approachSecurityPlane;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703690) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
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
				if (uint.MaxValue != 0)
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
				if (2u != 0)
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

	public GeneralRoutingOperation(OperationContext operationContext, string name, ReferenceKey workplanID)
		: base(operationContext, workplanID)
	{
		if (3u != 0)
		{
			base.Name = name;
		}
		UI00MachiningOptions obj = ((_options != null) ? _options.MachiningOptions : null);
		if (uint.MaxValue != 0)
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
			if (6u != 0)
			{
				geomCompositeCurve = obj;
			}
			int num;
			if (8u != 0)
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

	public void CreateRoughFinish(ActiveProgramParameters activeParameters, double depth, string description, TypeOfProcess typeOfProcess, string tool, string head, int correction, double inputSpeed, double rotSpeed, double speed, double overMaterial)
	{
		try
		{
			BottomAndSideFinishMilling bottomAndSideFinishMilling = new BottomAndSideFinishMilling();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (7u != 0)
			{
				operation = bottomAndSideFinishMilling;
			}
			GeneralProfileFeature generalProfileFeature = new GeneralProfileFeature();
			ManufacturingFeature feature;
			if (7u != 0)
			{
				feature = generalProfileFeature;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (7u != 0)
			{
				workingStep = machiningWorkingStep;
			}
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry = default(GeomGeometry);
			if (0 == 0)
			{
				geomGeometry = obj;
			}
			CoreTool coreTool = _0023_003DzCP7__0024l7ucReU(tool);
			CoreTool coreTool2 = default(CoreTool);
			if (0 == 0)
			{
				coreTool2 = coreTool;
			}
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(head);
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead2;
			if (4u != 0)
			{
				configHead2 = configHead;
			}
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(head, configHead2, activeParameters.MachineID);
			ScmGroup.XCam.MachiningDataModel.Head head2;
			if (6u != 0)
			{
				head2 = builderHead;
			}
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D, activeParameters.Workplane.ReferenceKey, activeParameters.ApproachSecurityPlane, activeParameters.RetractSecurityPlane);
			Tuple<double, double> tuple;
			if (8u != 0)
			{
				tuple = builderSafetyDistances;
			}
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple2 = _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(activeParameters.LeadInOut, inputSpeed);
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple3;
			if (5u != 0)
			{
				tuple3 = tuple2;
			}
			Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(rotSpeed, speed);
			Tuple<object, object> tuple4;
			if (2u != 0)
			{
				tuple4 = builderTechnologySpeeds;
			}
			object obj2 = _0023_003Dzd_6vS81LHZfQ(depth);
			FeatureBottomCondition bottomCondition = new GeneralMillingBottom();
			bool isMachiningSameDirection = activeParameters.IsMachiningSameDirection;
			SideType sideOfFeature = _0023_003DzhpRU1EUKegRQ(correction);
			double num = _0023_003DzH1tQYnLqOUsq(overMaterial);
			bool flag = _0023_003DzoTeP2Cltnz2h(correction);
			bool flag2 = _0023_003DzaqRkLCrDhUFH(activeParameters.IsCncCompensation, activeParameters.WorkPlaneCategory);
			TypeOfExtremaMachiningAttributePosition startMachiningPosition = activeParameters.StartMachiningPosition;
			ReferenceToolKey referenceToolKey = null;
			if (coreTool2 != null)
			{
				referenceToolKey = new ReferenceToolKey(coreTool2.Key, coreTool2.Name);
			}
			if (referenceToolKey == null)
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704548), tool);
			}
			bool disableDustPan = false;
			if (ToolMethods.GetToolFamily(coreTool2) == KindOfToolFamily.BladeCuttingTool)
			{
				disableDustPan = true;
			}
			double builderHeadRotation = GetBuilderHeadRotation(geomGeometry, referenceToolKey, activeParameters.Workpiece.ReferenceKey);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan, coreTool2, head2, feature);
			bool flag3 = false;
			Two5DMillingStrategy two5DMillingStrategy = _0023_003DzG8Zotvn1K1ss53uTM0zGDBXnQ3ejqff7JA_003D_003D(activeParameters.Strategy);
			if (two5DMillingStrategy != null)
			{
				flag3 = true;
			}
			bool flag4 = false;
			if (!flag3)
			{
				if (geomGeometry is GeomCompositeCurve)
				{
					if ((geomGeometry as GeomCompositeCurve).Elements.Count > 0)
					{
						flag4 = true;
					}
				}
				else if (geomGeometry is GeomTrimmedCurve)
				{
					flag4 = true;
				}
			}
			if (flag4)
			{
				_0023_003Dz_hR6lSynO7nq(geomGeometry, operation, activeParameters.Attributes);
			}
			ReferenceKey workplanID = _workplanID;
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
			GeneralProfileFeatureGeometryParameters geometryParameters = new GeneralProfileFeatureGeometryParameters(context, geomGeometry);
			GeneralProfileFeatureFeatureParameters generalProfileFeatureFeatureParameters = new GeneralProfileFeatureFeatureParameters(context, feature);
			GeneralProfileFeatureOperationParameters generalProfileFeatureOperationParameters = new GeneralProfileFeatureOperationParameters(context, operation);
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			generalProfileFeatureFeatureParameters.InitializeDepth(obj2, obj2, bottomCondition);
			generalProfileFeatureFeatureParameters.InitializeProfile(isMachiningSameDirection);
			generalProfileFeatureFeatureParameters.InitializeToolCompensation(sideOfFeature, num, flag);
			generalProfileFeatureOperationParameters.InitializeApproach(tuple3.Item1);
			generalProfileFeatureOperationParameters.InitializeCNMode(flag2);
			generalProfileFeatureOperationParameters.InitializeHead(head2);
			generalProfileFeatureOperationParameters.InitializeHeadRotation(builderHeadRotation);
			generalProfileFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			generalProfileFeatureOperationParameters.InitializeRetract(tuple3.Item2);
			generalProfileFeatureOperationParameters.InitializeSafetyDistance(tuple.Item1, tuple.Item2);
			generalProfileFeatureOperationParameters.InitializeStrategy(two5DMillingStrategy);
			generalProfileFeatureOperationParameters.InitializeTechnology(referenceToolKey, tuple4.Item2, tuple4.Item1);
			generalProfileFeatureOperationParameters.InitializeStartMachiningPointPosition(startMachiningPosition);
			workingStepParameters.InitializeDescription(description);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			GeneralProfileFeatureBuilder generalProfileFeatureBuilder = new GeneralProfileFeatureBuilder(context);
			generalProfileFeatureBuilder.InitializeGeometry(geometryParameters);
			generalProfileFeatureBuilder.InitializeFeature(generalProfileFeatureFeatureParameters);
			generalProfileFeatureBuilder.InitializeOperation(generalProfileFeatureOperationParameters);
			generalProfileFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			generalProfileFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = generalProfileFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704037), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void Create3DRoughFinish(ActiveProgramParameters activeParameters, string description, TypeOfProcess typeOfProcess, string tool, string head, double inputSpeed, double rotSpeed, double speed, double? inputZRotation, double? inputXRotation)
	{
		int headNumber;
		if (true)
		{
			headNumber = 0;
		}
		ReferenceToolKey refToolKey;
		if (7u != 0)
		{
			refToolKey = null;
		}
		try
		{
			FreeformOperation freeformOperation = new FreeformOperation();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (3u != 0)
			{
				operation = freeformOperation;
			}
			ToolpathFeature toolpathFeature = new ToolpathFeature();
			ManufacturingFeature feature;
			if (true)
			{
				feature = toolpathFeature;
			}
			_toolInterface.GetToolHeadInfo(head, tool, ref headNumber, ref refToolKey);
			(operation as MachiningOperation).ToolKey = refToolKey;
			ScmGroup.XCam.MachiningDataModel.Head head2 = _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(operation as MachiningOperation, 0, head, headNumber);
			ScmGroup.XCam.MachiningDataModel.Head machiningHead;
			if (true)
			{
				machiningHead = head2;
			}
			UI00MachiningOptions machiningOptions = _0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D;
			MachiningOperation machiningOperation = operation as MachiningOperation;
			double? approachSecurityPlane = activeParameters.ApproachSecurityPlane;
			double? retractSecurityPlane = activeParameters.RetractSecurityPlane;
			if (true)
			{
				CreateMachiningOperationSafetyDistances(machiningOptions, machiningOperation, null, approachSecurityPlane, retractSecurityPlane);
			}
			Strategy strategy = activeParameters.Strategy;
			if (strategy != null && strategy is PlaneCutterLocationStrategy)
			{
				PlaneCutterLocationStrategy planeCutterLocationStrategy = strategy as PlaneCutterLocationStrategy;
				ScmGroup.XCam.MachiningDataModel.Strategy.PlaneCutterLocationStrategy planeCutterLocationStrategy2 = new ScmGroup.XCam.MachiningDataModel.Strategy.PlaneCutterLocationStrategy();
				planeCutterLocationStrategy2.Direction = new ToolDirection(MathUtility.ConvertToRadians(planeCutterLocationStrategy.ZRotation), MathUtility.ConvertToRadians(planeCutterLocationStrategy.XRotation));
				(operation as FreeformOperation).MachiningStrategy = planeCutterLocationStrategy2;
			}
			MillingTechnology millingTechnology = new MillingTechnology();
			millingTechnology.Spindle = ((rotSpeed != -1.0) ? rotSpeed : 0.0);
			millingTechnology.Feedrate = ((speed != -1.0) ? speed : 0.0);
			(operation as MachiningOperation).Technology = millingTechnology;
			(operation as MachiningOperation).MachineFunctions = CreateMachineFunctions(activeParameters.MachineFunctions, disableDustPan: true, refToolKey, machiningHead, feature);
			operation.ToolpathPriority = false;
			BaseApproach3DStrategy baseApproach3DStrategy = new BaseApproach3DStrategy();
			baseApproach3DStrategy.IsEnabled = true;
			baseApproach3DStrategy.Speed = inputSpeed;
			double? zRotation = MathUtility.ConvertToRadians(inputZRotation ?? 0.0);
			double? xRotation = MathUtility.ConvertToRadians(inputXRotation ?? 0.0);
			baseApproach3DStrategy.ToolDirection = new ToolDirection(zRotation, xRotation);
			(operation as MillingTypeOperation).Approach = baseApproach3DStrategy;
			_projectInterface.AddOperation(ref operation, this);
			_projectInterface.AddFeature(ref feature, null, activeParameters.Workpiece.ReferenceKey, operation.Key, this);
			MachiningWorkingStep workingStep = new MachiningWorkingStep(base.Name, feature.Key, operation.Key);
			workingStep.IsEnabled = true;
			workingStep.Description = description;
			workingStep.Priority = activeParameters.Priority;
			_projectInterface.AddWorkingStep(ref workingStep, _workplanID, this);
			base.ReferenceKey = workingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701007), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateSlantedRoughFinish(ActiveProgramParameters activeParameters, double angleA, double angleB, TypeOfToolApproach toolApproach, double depth, string description, TypeOfProcess typeOfProcess, string tool, string head, double inputSpeed, double rotSpeed, double speed, double overMaterial, int correction, bool isCnc)
	{
		try
		{
			BottomAndSideFinishMilling bottomAndSideFinishMilling = new BottomAndSideFinishMilling();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation = default(ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation);
			if (0 == 0)
			{
				operation = bottomAndSideFinishMilling;
			}
			SlantedProfileFeature slantedProfileFeature = new SlantedProfileFeature();
			ManufacturingFeature feature;
			if (7u != 0)
			{
				feature = slantedProfileFeature;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (8u != 0)
			{
				workingStep = machiningWorkingStep;
			}
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geometry;
			if (8u != 0)
			{
				geometry = obj;
			}
			CoreTool coreTool = _0023_003DzCP7__0024l7ucReU(tool);
			CoreTool coreTool2;
			if (8u != 0)
			{
				coreTool2 = coreTool;
			}
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(head);
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead2;
			if (8u != 0)
			{
				configHead2 = configHead;
			}
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(head, configHead2, activeParameters.MachineID);
			ScmGroup.XCam.MachiningDataModel.Head head2;
			if (5u != 0)
			{
				head2 = builderHead;
			}
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D, activeParameters.Workplane.ReferenceKey, activeParameters.ApproachSecurityPlane, activeParameters.RetractSecurityPlane);
			Tuple<double, double> tuple = default(Tuple<double, double>);
			if (0 == 0)
			{
				tuple = builderSafetyDistances;
			}
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple2 = _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(activeParameters.LeadInOut, inputSpeed);
			Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(rotSpeed, speed);
			object obj2 = _0023_003Dzd_6vS81LHZfQ(depth);
			FeatureBottomCondition bottomCondition = new GeneralMillingBottom();
			bool isMachiningSameDirection = activeParameters.IsMachiningSameDirection;
			SideType sideOfFeature = _0023_003DzhpRU1EUKegRQ(correction);
			double num = _0023_003DzH1tQYnLqOUsq(overMaterial);
			bool flag = isCnc;
			bool isRoundedCorner = false;
			ReferenceToolKey referenceToolKey = null;
			if (coreTool2 != null)
			{
				referenceToolKey = new ReferenceToolKey(coreTool2.Key, coreTool2.Name);
			}
			if (referenceToolKey == null)
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700702), tool);
			}
			bool disableDustPan = false;
			if (ToolMethods.GetToolFamily(coreTool2) == KindOfToolFamily.BladeCuttingTool)
			{
				disableDustPan = true;
			}
			double builderHeadRotation = GetBuilderHeadRotation(geometry, referenceToolKey, activeParameters.Workpiece.ReferenceKey);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan, coreTool2, head2, feature);
			ReferenceKey workplanID = _workplanID;
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
			SlantedProfileFeatureGeometryParameters geometryParameters = new SlantedProfileFeatureGeometryParameters(context, geometry);
			SlantedProfileFeatureFeatureParameters slantedProfileFeatureFeatureParameters = new SlantedProfileFeatureFeatureParameters(context, feature);
			SlantedProfileFeatureOperationParameters slantedProfileFeatureOperationParameters = new SlantedProfileFeatureOperationParameters(context, operation);
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			slantedProfileFeatureFeatureParameters.InitializeDepth(obj2, obj2, bottomCondition);
			slantedProfileFeatureFeatureParameters.InitializeProfile(isMachiningSameDirection);
			slantedProfileFeatureFeatureParameters.InitializeToolCompensation(sideOfFeature, num, null);
			slantedProfileFeatureFeatureParameters.InitializeAngles(angleA, angleB);
			slantedProfileFeatureFeatureParameters.InitializeToolApproach(toolApproach);
			slantedProfileFeatureFeatureParameters.InitializeCornerMode(isRoundedCorner);
			slantedProfileFeatureOperationParameters.InitializeApproach(tuple2.Item1);
			slantedProfileFeatureOperationParameters.InitializeCNMode(flag);
			slantedProfileFeatureOperationParameters.InitializeHead(head2);
			slantedProfileFeatureOperationParameters.InitializeHeadRotation(builderHeadRotation);
			slantedProfileFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			slantedProfileFeatureOperationParameters.InitializeRetract(tuple2.Item2);
			slantedProfileFeatureOperationParameters.InitializeSafetyDistance(tuple.Item1, tuple.Item2);
			slantedProfileFeatureOperationParameters.InitializeStrategy(null);
			slantedProfileFeatureOperationParameters.InitializeTechnology(referenceToolKey, builderTechnologySpeeds.Item2, builderTechnologySpeeds.Item1);
			workingStepParameters.InitializeDescription(description);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			SlantedProfileFeatureBuilder slantedProfileFeatureBuilder = new SlantedProfileFeatureBuilder(context);
			slantedProfileFeatureBuilder.InitializeGeometry(geometryParameters);
			slantedProfileFeatureBuilder.InitializeFeature(slantedProfileFeatureFeatureParameters);
			slantedProfileFeatureBuilder.InitializeOperation(slantedProfileFeatureOperationParameters);
			slantedProfileFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			slantedProfileFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = slantedProfileFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700669), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dz4yqdYK9mHp3S_FyDIYP8vPaAWS19kSex_0024Q_003D_003D(MillingTypeOperation _0023_003DzHuNk036Z5aIGkj0IIQ_003D_003D, LeadInOut _0023_003Dzui4D8_aBQtar, double _0023_003DzksrR6KQfs_Ff)
	{
		try
		{
			bool isEnabled = default(bool);
			if (0 == 0)
			{
				isEnabled = false;
			}
			double num;
			if (true)
			{
				num = _0023_003DzksrR6KQfs_Ff;
			}
			double radiusMultiplier;
			if (uint.MaxValue != 0)
			{
				radiusMultiplier = 1.0;
			}
			ModeOfApproach approachMode;
			if (4u != 0)
			{
				approachMode = ModeOfApproach.Down;
			}
			TypeOfApproachRetract approachType;
			if (3u != 0)
			{
				approachType = TypeOfApproachRetract.Line;
			}
			bool isEnabled2 = false;
			double speed = -1.0;
			double radiusMultiplier2 = 1.0;
			double overLap = 0.0;
			ModeOfRetract retractMode = ModeOfRetract.Up;
			TypeOfApproachRetract retractType = TypeOfApproachRetract.Line;
			if (_0023_003Dzui4D8_aBQtar != null)
			{
				isEnabled = _0023_003Dzui4D8_aBQtar.IsLeadInEnabled;
				radiusMultiplier = _0023_003Dzui4D8_aBQtar.ApproachDistance;
				double num2 = (_0023_003Dzui4D8_aBQtar.ApproachSpeed.HasValue ? _0023_003Dzui4D8_aBQtar.ApproachSpeed.Value : (-1.0));
				num = ((num2 != -1.0) ? num2 : num);
				approachMode = ((!_0023_003Dzui4D8_aBQtar.IsQuoteApproach) ? ModeOfApproach.Down : ModeOfApproach.Quote);
				approachType = ((!_0023_003Dzui4D8_aBQtar.IsLinearApproach) ? TypeOfApproachRetract.Arc : TypeOfApproachRetract.Line);
				isEnabled2 = _0023_003Dzui4D8_aBQtar.IsLeadOutEnabled;
				radiusMultiplier2 = _0023_003Dzui4D8_aBQtar.RetractDistance;
				overLap = _0023_003Dzui4D8_aBQtar.OverlapLength;
				speed = ((!_0023_003Dzui4D8_aBQtar.RetractSpeed.HasValue) ? (-1.0) : _0023_003Dzui4D8_aBQtar.RetractSpeed.Value);
				retractMode = ((!_0023_003Dzui4D8_aBQtar.IsQuoteRetract) ? ModeOfRetract.Up : ModeOfRetract.Quote);
				retractType = ((!_0023_003Dzui4D8_aBQtar.IsLinearRetract) ? TypeOfApproachRetract.Arc : TypeOfApproachRetract.Line);
			}
			BaseApproachStrategy baseApproachStrategy = new BaseApproachStrategy();
			baseApproachStrategy.ApproachMode = approachMode;
			baseApproachStrategy.ApproachType = approachType;
			baseApproachStrategy.IsEnabled = isEnabled;
			baseApproachStrategy.RadiusMultiplier = radiusMultiplier;
			baseApproachStrategy.Speed = num;
			BaseRetractStrategy baseRetractStrategy = new BaseRetractStrategy();
			baseRetractStrategy.IsEnabled = isEnabled2;
			baseRetractStrategy.RadiusMultiplier = radiusMultiplier2;
			baseRetractStrategy.OverLap = overLap;
			baseRetractStrategy.Speed = speed;
			baseRetractStrategy.RetractMode = retractMode;
			baseRetractStrategy.RetractType = retractType;
			_0023_003DzHuNk036Z5aIGkj0IIQ_003D_003D.Approach = baseApproachStrategy;
			_0023_003DzHuNk036Z5aIGkj0IIQ_003D_003D.Retract = baseRetractStrategy;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703974), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateChamfer(ActiveProgramParameters activeParameters, double chamferWidth, double chamferHeight, double overcutLength, ChamferToolPositionType toolPositionType, string description, TypeOfProcess typeOfProcess, string tool, string head, double inputSpeed, double rotSpeed, double speed, double overMaterial)
	{
		try
		{
			BottomAndSideFinishMilling bottomAndSideFinishMilling = new BottomAndSideFinishMilling();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (uint.MaxValue != 0)
			{
				operation = bottomAndSideFinishMilling;
			}
			int headNumber;
			if (6u != 0)
			{
				headNumber = 0;
			}
			ReferenceToolKey refToolKey;
			if (true)
			{
				refToolKey = null;
			}
			_toolInterface.GetToolHeadInfo(head, tool, ref headNumber, ref refToolKey);
			(operation as MachiningOperation).ToolKey = refToolKey;
			ScmGroup.XCam.MachiningDataModel.Head head2 = _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(operation as MachiningOperation, 0, head, headNumber);
			ScmGroup.XCam.MachiningDataModel.Head machiningHead;
			if (true)
			{
				machiningHead = head2;
			}
			operation.ActivateCNCCorrection = false;
			(operation as MillingMachiningOperation).OvercutLength = overcutLength;
			UI00MachiningOptions machiningOptions = _0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D;
			MachiningOperation machiningOperation = operation as MachiningOperation;
			ReferenceKey referenceKey = activeParameters.Workplane.ReferenceKey;
			double? approachSecurityPlane = activeParameters.ApproachSecurityPlane;
			double? retractSecurityPlane = activeParameters.RetractSecurityPlane;
			if (true)
			{
				CreateMachiningOperationSafetyDistances(machiningOptions, machiningOperation, referenceKey, approachSecurityPlane, retractSecurityPlane);
			}
			MillingTypeOperation _0023_003DzHuNk036Z5aIGkj0IIQ_003D_003D = operation as MillingTypeOperation;
			LeadInOut leadInOut = activeParameters.LeadInOut;
			if (4u != 0)
			{
				_0023_003Dz4yqdYK9mHp3S_FyDIYP8vPaAWS19kSex_0024Q_003D_003D(_0023_003DzHuNk036Z5aIGkj0IIQ_003D_003D, leadInOut, inputSpeed);
			}
			MillingTechnology millingTechnology = new MillingTechnology();
			MillingTechnology millingTechnology2;
			if (2u != 0)
			{
				millingTechnology2 = millingTechnology;
			}
			millingTechnology2.Spindle = ((rotSpeed != -1.0) ? rotSpeed : 0.0);
			millingTechnology2.Feedrate = ((speed != -1.0) ? speed : 0.0);
			(operation as MachiningOperation).Technology = millingTechnology2;
			ChamferFeature chamferFeature = new ChamferFeature();
			ManufacturingFeature feature;
			if (8u != 0)
			{
				feature = chamferFeature;
			}
			(feature as MillingMachiningFeature).SideOffset = overMaterial;
			if (_toolInterface != null && (operation as MachiningOperation).ToolKey != null && (operation as MachiningOperation).ToolKey.IsValid)
			{
				ToolFamilyInfo toolFamily = _toolInterface.GetToolFamily((operation as MachiningOperation).ToolKey);
				ToolFamilyInfo toolFamilyInfo;
				if (4u != 0)
				{
					toolFamilyInfo = toolFamily;
				}
				if (toolFamilyInfo != null)
				{
					(feature as ChamferFeature).ChamferWidth = chamferWidth;
					(feature as ChamferFeature).ChamferHeight = chamferHeight;
					(feature as ChamferFeature).ChamferToolPosition = toolPositionType;
					(feature as MachiningFeature).Depth = new DepthPlane(0.0, 0.0);
					if ((feature as ChamferFeature).ChamferToolPosition == ChamferToolPositionType.TopLeft || (feature as ChamferFeature).ChamferToolPosition == ChamferToolPositionType.BottomLeft)
					{
						(feature as ChamferFeature).SideOfFeature = SideType.Left;
					}
					else
					{
						(feature as ChamferFeature).SideOfFeature = SideType.Right;
					}
					if (toolFamilyInfo.KindOfToolFamily == KindOfToolFamily.DrillingCuttingTool || toolFamilyInfo.KindOfToolFamily == KindOfToolFamily.MillingCuttingTool)
					{
						double num = Convert.ToDouble(_toolInterface.GetToolPropertyValue((operation as MachiningOperation).ToolKey, KindOfToolProperty.Diameter).Value);
						double width;
						if (6u != 0)
						{
							width = num;
						}
						(feature as MillingMachiningFeature).EndConditions = new List<SlotEndType>();
						(feature as MillingMachiningFeature).EndConditions.Add(new RadiusedSlotEndType());
						(feature as MillingMachiningFeature).EndConditions.Add(new RadiusedSlotEndType());
						(feature as MillingMachiningFeature).SweptShape = new SquareUProfile(0.0, 0.0, 0.0, 0.0, width, new GeomAxis2Placement(0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0));
					}
				}
			}
			else
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700613), tool);
			}
			(operation as MachiningOperation).MachineFunctions = CreateMachineFunctions(activeParameters.MachineFunctions, disableDustPan: false, refToolKey, machiningHead, feature);
			Strategy strategy = activeParameters.Strategy;
			bool flag = false;
			if (strategy != null)
			{
				flag = true;
				if (operation != null && operation is Two5DMillingOperation)
				{
					Type type = strategy.GetType();
					if (type != null)
					{
						if (type == typeof(UnidirectionalMillingStrategy))
						{
							(operation as Two5DMillingOperation).MachiningStrategy = new UnidirectionalMilling();
							(operation as Two5DMillingOperation).MachiningStrategy.AllowMultiplePasses = (strategy as UnidirectionalMillingStrategy).AllowMultiplePasses;
							(operation as Two5DMillingOperation).MachiningStrategy.Overlap = 0.0;
							((operation as Two5DMillingOperation).MachiningStrategy as UnidirectionalMilling).AxialCuttingDepth = (strategy as UnidirectionalMillingStrategy).AxialCuttingDepth;
							((operation as Two5DMillingOperation).MachiningStrategy as UnidirectionalMilling).RadialCuttingDepth = 0.0;
							((operation as Two5DMillingOperation).MachiningStrategy as UnidirectionalMilling).AxialFinishCuttingDepth = (strategy as UnidirectionalMillingStrategy).AxialFinishCuttingDepth;
							((operation as Two5DMillingOperation).MachiningStrategy as UnidirectionalMilling).RadialFinishCuttingDepth = 0.0;
							((operation as Two5DMillingOperation).MachiningStrategy as UnidirectionalMilling).StrokeConnectionStrategy = StrokeConnectionStrategy.LiftShiftPlunge;
							((operation as Two5DMillingOperation).MachiningStrategy as UnidirectionalMilling).IsApproachRetractPassStrategy = (strategy as UnidirectionalMillingStrategy).IsApproachRetractPassStrategy;
						}
						else if (type == typeof(BidirectionalMillingStrategy))
						{
							(operation as Two5DMillingOperation).MachiningStrategy = new BidirectionalMilling();
							(operation as Two5DMillingOperation).MachiningStrategy.AllowMultiplePasses = (strategy as BidirectionalMillingStrategy).AllowMultiplePasses;
							(operation as Two5DMillingOperation).MachiningStrategy.Overlap = 0.0;
							((operation as Two5DMillingOperation).MachiningStrategy as BidirectionalMilling).AxialCuttingDepth = (strategy as BidirectionalMillingStrategy).AxialCuttingDepth;
							((operation as Two5DMillingOperation).MachiningStrategy as BidirectionalMilling).RadialCuttingDepth = 0.0;
							((operation as Two5DMillingOperation).MachiningStrategy as BidirectionalMilling).AxialFinishCuttingDepth = (strategy as BidirectionalMillingStrategy).AxialFinishCuttingDepth;
							((operation as Two5DMillingOperation).MachiningStrategy as BidirectionalMilling).StrokeConnectionStrategy = StrokeConnectionStrategy.Straghtline;
						}
						else if (type == typeof(SectioningMillingStrategy))
						{
							(operation as Two5DMillingOperation).MachiningStrategy = new SectioningMilling();
							(operation as Two5DMillingOperation).MachiningStrategy.AllowMultiplePasses = false;
							(operation as Two5DMillingOperation).MachiningStrategy.Overlap = 0.0;
							((operation as Two5DMillingOperation).MachiningStrategy as SectioningMilling).FirstCutDepth = (strategy as SectioningMillingStrategy).FirstCutDepth;
							((operation as Two5DMillingOperation).MachiningStrategy as SectioningMilling).SideMovingDistance = (strategy as SectioningMillingStrategy).SideMovingDistance;
							((operation as Two5DMillingOperation).MachiningStrategy as SectioningMilling).OutDistance = (strategy as SectioningMillingStrategy).OutDistance;
						}
					}
				}
			}
			MachiningWorkingStep workingStep = new MachiningWorkingStep();
			workingStep.Name = base.Name;
			workingStep.IsEnabled = true;
			workingStep.Description = description;
			GeomGeometry geometry = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			if (!flag && geometry is GeomCompositeCurve && (geometry as GeomCompositeCurve).Elements.Count != 0)
			{
				_0023_003Dz_hR6lSynO7nq(geometry, operation, activeParameters.Attributes);
			}
			workingStep.Priority = activeParameters.Priority;
			ReferenceKey referenceKey2 = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey3 = activeParameters.Workplane.ReferenceKey;
			_projectInterface.InsertAtWorkingStep(ref geometry, ref feature, ref operation, ref workingStep, referenceKey3, _workplanID, referenceKey2, -1, this);
			base.ReferenceKey = workingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700849), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateScrapingFeature(TypeOfToolApproach toolApproach, double depth, string description, string tool, TypeOfProcess typeOfProcess, double overMaterial, Geometry geometry, Attributes attributes, int correction, ref MachiningOperation machiningOperation, ref MachiningWorkingStep ws, int priority)
	{
		try
		{
			ManufacturingFeature feature;
			if (5u != 0)
			{
				feature = null;
			}
			switch (typeOfProcess)
			{
			case TypeOfProcess.EdgeScraping:
			{
				EdgeScrapingFeature edgeScrapingFeature = new EdgeScrapingFeature();
				if (true)
				{
					feature = edgeScrapingFeature;
				}
				break;
			}
			case TypeOfProcess.GlueScraping:
			{
				GlueScrapingFeature glueScrapingFeature = new GlueScrapingFeature();
				if (0 == 0)
				{
					feature = glueScrapingFeature;
				}
				break;
			}
			}
			(feature as MachiningFeature).Depth = new DepthPlane(depth, depth);
			switch (correction)
			{
			case 0:
				(feature as MillingMachiningFeature).SideOfFeature = SideType.Center;
				break;
			case 1:
			case 13:
				(feature as MillingMachiningFeature).SideOfFeature = SideType.Left;
				break;
			case 2:
			case 23:
				(feature as MillingMachiningFeature).SideOfFeature = SideType.Right;
				break;
			}
			(feature as MillingMachiningFeature).SideOffset = overMaterial;
			(feature as MillingMachiningFeature).IsPrecise = correction == 3 || correction == 13 || correction == 23;
			if (_toolInterface != null && machiningOperation.ToolKey != null && machiningOperation.ToolKey.IsValid)
			{
				if (_toolInterface.GetToolFamily(machiningOperation.ToolKey) != null)
				{
					(feature as ScrapingFeature).ToolApproach = toolApproach;
				}
			}
			else
			{
				string name = base.Name;
				string empty = string.Empty;
				string _0023_003DzTgF4RrM_003D = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700806);
				if (2u != 0)
				{
					_0023_003DzuJOUyAMySoAB(name, empty, _0023_003DzTgF4RrM_003D, tool);
				}
			}
			ws = new MachiningWorkingStep();
			ws.Name = base.Name;
			ws.IsEnabled = true;
			ws.Description = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700783);
			GeomGeometry obj = _projectInterface.Get(geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geometry2;
			if (2u != 0)
			{
				geometry2 = obj;
			}
			if (geometry2 is GeomCompositeCurve && (geometry2 as GeomCompositeCurve).Elements.Count != 0)
			{
				_0023_003Dz_hR6lSynO7nq(geometry2, machiningOperation, attributes);
			}
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation = machiningOperation;
			operation.ToolpathPriority = false;
			ws.Priority = priority;
			ReferenceKey workPieceID = geometry2.WorkPieceID;
			ReferenceKey planeID = geometry2.PlaneID;
			_projectInterface.InsertAtWorkingStep(ref geometry2, ref feature, ref operation, ref ws, planeID, _workplanID, workPieceID, -1, this);
			base.ReferenceKey = ws.Key;
			machiningOperation = operation as MachiningOperation;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700770), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation CreateEdgeScrapingOperation(string tool, string head, double rotSpeed, double speed, MachineFunctions machineFunctions)
	{
		int headNumber;
		if (5u != 0)
		{
			headNumber = 0;
		}
		ReferenceToolKey refToolKey;
		if (2u != 0)
		{
			refToolKey = null;
		}
		_toolInterface.GetToolHeadInfo(head, tool, ref headNumber, ref refToolKey);
		ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
		if (uint.MaxValue != 0)
		{
			operation = null;
		}
		Type featureType = null;
		CuttingTool cuttingTool = _toolInterface.Get(refToolKey) as CuttingTool;
		if (cuttingTool.ToolBody is EdgeScraperMill)
		{
			operation = new EdgeScrapingOperation();
			featureType = typeof(EdgeScrapingFeature);
		}
		else if (cuttingTool.ToolBody is GlueScraperMill)
		{
			operation = new GlueScrapingOperation();
			featureType = typeof(GlueScrapingFeature);
		}
		(operation as MachiningOperation).ToolKey = refToolKey;
		ScmGroup.XCam.MachiningDataModel.Head machiningHead = _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(operation as MachiningOperation, 0, head, headNumber);
		operation.ActivateCNCCorrection = false;
		ScraperMill obj = cuttingTool.ToolBody as ScraperMill;
		double horizontalCopying = obj.HorizontalCopying;
		double verticalCopying = obj.VerticalCopying;
		ScrapingApproachStrategy scrapingApproachStrategy = new ScrapingApproachStrategy();
		scrapingApproachStrategy.HorizontalCopying = horizontalCopying;
		scrapingApproachStrategy.VerticalCopying = verticalCopying;
		(operation as MillingTypeOperation).Approach = scrapingApproachStrategy;
		ScrapingRetractStrategy scrapingRetractStrategy = new ScrapingRetractStrategy();
		scrapingRetractStrategy.VerticalCopying = verticalCopying;
		(operation as MillingTypeOperation).Retract = scrapingRetractStrategy;
		MillingTechnology millingTechnology = new MillingTechnology();
		millingTechnology.Spindle = ((rotSpeed != -1.0) ? rotSpeed : 0.0);
		millingTechnology.Feedrate = ((speed != -1.0) ? speed : 0.0);
		(operation as MachiningOperation).Technology = millingTechnology;
		(operation as MachiningOperation).MachineFunctions = CreateMachineFunctions(machineFunctions, disableDustPan: false, refToolKey, machiningHead, featureType);
		return operation;
	}

	public ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation CreateScrapingOperation(string tool, string head, double rotSpeed, double speed, MachineFunctions machineFunctions, TypeOfProcess typeOfProcess)
	{
		ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
		if (7u != 0)
		{
			operation = null;
		}
		Type featureType;
		if (6u != 0)
		{
			featureType = null;
		}
		switch (typeOfProcess)
		{
		case TypeOfProcess.EdgeScraping:
		{
			EdgeScrapingOperation edgeScrapingOperation = new EdgeScrapingOperation();
			if (7u != 0)
			{
				operation = edgeScrapingOperation;
			}
			featureType = typeof(EdgeScrapingFeature);
			break;
		}
		case TypeOfProcess.GlueScraping:
			operation = new GlueScrapingOperation();
			featureType = typeof(GlueScrapingFeature);
			break;
		}
		operation.ActivateCNCCorrection = false;
		int headNumber = 0;
		ReferenceToolKey refToolKey = null;
		_toolInterface.GetToolHeadInfo(head, tool, ref headNumber, ref refToolKey);
		CuttingTool obj = _toolInterface.Get(refToolKey) as CuttingTool;
		(operation as MachiningOperation).ToolKey = refToolKey;
		ScmGroup.XCam.MachiningDataModel.Head machiningHead = _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(operation as MachiningOperation, 0, head, headNumber);
		ScraperMill obj2 = obj.ToolBody as ScraperMill;
		double horizontalCopying = obj2.HorizontalCopying;
		double verticalCopying = obj2.VerticalCopying;
		ScrapingApproachStrategy scrapingApproachStrategy = new ScrapingApproachStrategy();
		scrapingApproachStrategy.HorizontalCopying = horizontalCopying;
		scrapingApproachStrategy.VerticalCopying = verticalCopying;
		(operation as MillingTypeOperation).Approach = scrapingApproachStrategy;
		ScrapingRetractStrategy scrapingRetractStrategy = new ScrapingRetractStrategy();
		scrapingRetractStrategy.VerticalCopying = verticalCopying;
		(operation as MillingTypeOperation).Retract = scrapingRetractStrategy;
		MillingTechnology millingTechnology = new MillingTechnology();
		millingTechnology.Spindle = ((rotSpeed != -1.0) ? rotSpeed : 0.0);
		millingTechnology.Feedrate = ((speed != -1.0) ? speed : 0.0);
		(operation as MachiningOperation).Technology = millingTechnology;
		(operation as MachiningOperation).MachineFunctions = CreateMachineFunctions(machineFunctions, disableDustPan: false, refToolKey, machiningHead, featureType);
		return operation;
	}

	public void CreateBladeCut(ActiveProgramParameters activeParameters, string description, TypeOfProcess typeOfProcess, string tool, string head, double angle, int correction, double inputSpeed, double rotSpeed, double speed, double overMaterial, bool cutPositionUpper, double referenceOffset, bool materialPositionLeft, double extraDepth)
	{
		try
		{
			BottomAndSideFinishMilling bottomAndSideFinishMilling = new BottomAndSideFinishMilling();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (5u != 0)
			{
				operation = bottomAndSideFinishMilling;
			}
			SawCutFeature sawCutFeature = new SawCutFeature();
			ManufacturingFeature feature;
			if (3u != 0)
			{
				feature = sawCutFeature;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (uint.MaxValue != 0)
			{
				workingStep = machiningWorkingStep;
			}
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry;
			if (2u != 0)
			{
				geomGeometry = obj;
			}
			CoreTool coreTool = _0023_003DzCP7__0024l7ucReU(tool);
			CoreTool coreTool2;
			if (uint.MaxValue != 0)
			{
				coreTool2 = coreTool;
			}
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(head);
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead2 = default(ScmGroup.XCam.ConfigDataModel.Heads.Head);
			if (0 == 0)
			{
				configHead2 = configHead;
			}
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(head, configHead2, activeParameters.MachineID);
			ScmGroup.XCam.MachiningDataModel.Head head2;
			if (4u != 0)
			{
				head2 = builderHead;
			}
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D, activeParameters.Workplane.ReferenceKey, activeParameters.ApproachSecurityPlane, activeParameters.RetractSecurityPlane);
			Tuple<double, double> tuple;
			if (3u != 0)
			{
				tuple = builderSafetyDistances;
			}
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple2 = _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(activeParameters.LeadInOut, inputSpeed);
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple3;
			if (3u != 0)
			{
				tuple3 = tuple2;
			}
			Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(rotSpeed, speed);
			Tuple<object, object> tuple4;
			if (8u != 0)
			{
				tuple4 = builderTechnologySpeeds;
			}
			ReferencePositionType referencePosition = geomGeometry.ReferencePosition;
			Tuple<object, object, object, object> tuple5 = _0023_003Dzd2vQ0cEpacTskK1OUQ_003D_003D(geomGeometry);
			object item = tuple5.Item1;
			object item2 = tuple5.Item2;
			object item3 = tuple5.Item3;
			object item4 = tuple5.Item4;
			bool isMachiningSameDirection = activeParameters.IsMachiningSameDirection;
			SideType sideOfFeature = _0023_003DzhpRU1EUKegRQ(correction);
			_0023_003DzH1tQYnLqOUsq(overMaterial);
			bool flag = _0023_003DzoTeP2Cltnz2h(correction);
			bool flag2 = false;
			bool isSideToSide = false;
			double num = 0.0;
			double num2 = 0.0;
			SawCutReference cutPosition = ((!cutPositionUpper) ? SawCutReference.Lower : SawCutReference.Upper);
			WorkingMaterial materialPosition = ((!materialPositionLeft) ? WorkingMaterial.Right : WorkingMaterial.Left);
			ReferenceToolKey referenceToolKey = null;
			if (coreTool2 != null)
			{
				referenceToolKey = new ReferenceToolKey(coreTool2.Key, coreTool2.Name);
			}
			if (referenceToolKey == null)
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701483), tool);
			}
			bool disableDustPan = false;
			if (ToolMethods.GetToolFamily(coreTool2) == KindOfToolFamily.BladeCuttingTool)
			{
				disableDustPan = true;
			}
			double builderHeadRotation = GetBuilderHeadRotation(geomGeometry, referenceToolKey, activeParameters.Workpiece.ReferenceKey);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan, coreTool2, head2, feature);
			bool flag3 = false;
			Two5DMillingStrategy two5DMillingStrategy = _0023_003DzG8Zotvn1K1ss53uTM0zGDBXnQ3ejqff7JA_003D_003D(activeParameters.Strategy);
			if (two5DMillingStrategy != null)
			{
				flag3 = true;
			}
			bool flag4 = false;
			if (!flag3)
			{
				if (geomGeometry is GeomCompositeCurve)
				{
					if ((geomGeometry as GeomCompositeCurve).Elements.Count > 0)
					{
						flag4 = true;
					}
				}
				else if (geomGeometry is GeomTrimmedCurve)
				{
					flag4 = true;
				}
			}
			if (flag4)
			{
				_0023_003Dz_hR6lSynO7nq(geomGeometry, operation, activeParameters.Attributes);
			}
			ReferenceKey workplanID = _workplanID;
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
			SawCutFeatureGeometryParameters sawCutFeatureGeometryParameters = new SawCutFeatureGeometryParameters(context, geomGeometry);
			SawCutFeatureFeatureParameters sawCutFeatureFeatureParameters = new SawCutFeatureFeatureParameters(context, feature);
			SawCutFeatureOperationParameters sawCutFeatureOperationParameters = new SawCutFeatureOperationParameters(context, operation);
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			sawCutFeatureGeometryParameters.InitializeStartCoordinates(item, item2);
			sawCutFeatureGeometryParameters.InitializeEndCoordinates(item3, item4);
			sawCutFeatureGeometryParameters.InitializeReferencePosition(referencePosition);
			sawCutFeatureFeatureParameters.InitializeProfile(isMachiningSameDirection);
			sawCutFeatureFeatureParameters.InitializeToolCompensation(sideOfFeature, overMaterial, flag);
			sawCutFeatureFeatureParameters.InitializeAngle(angle);
			sawCutFeatureFeatureParameters.InitializeSideToSide(isSideToSide, num, num2);
			sawCutFeatureFeatureParameters.InitializeCutReference(cutPosition, referenceOffset);
			sawCutFeatureFeatureParameters.InitializeMaterialPosition(materialPosition);
			sawCutFeatureOperationParameters.InitializeApproach(tuple3.Item1);
			sawCutFeatureOperationParameters.InitializeCNMode(flag2);
			sawCutFeatureOperationParameters.InitializeHead(head2);
			sawCutFeatureOperationParameters.InitializeHeadRotation(builderHeadRotation);
			sawCutFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			sawCutFeatureOperationParameters.InitializeRetract(tuple3.Item2);
			sawCutFeatureOperationParameters.InitializeSafetyDistance(tuple.Item1, tuple.Item2);
			sawCutFeatureOperationParameters.InitializeStrategy(two5DMillingStrategy);
			sawCutFeatureOperationParameters.InitializeTechnology(referenceToolKey, tuple4.Item2, tuple4.Item1);
			sawCutFeatureOperationParameters.InitializeExtraDepth(extraDepth);
			workingStepParameters.InitializeDescription(description);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			SawCutFeatureBuilder sawCutFeatureBuilder = new SawCutFeatureBuilder(context);
			sawCutFeatureBuilder.InitializeGeometry(sawCutFeatureGeometryParameters);
			sawCutFeatureBuilder.InitializeFeature(sawCutFeatureFeatureParameters);
			sawCutFeatureBuilder.InitializeOperation(sawCutFeatureOperationParameters);
			sawCutFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			sawCutFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = sawCutFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701464), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateSlot(ActiveProgramParameters activeParameters, double depth, string description, TypeOfProcess typeOfProcess, string tool, string head, int correction, double inputSpeed, double rotSpeed, double speed, double overMaterial, double angle, double endDepth)
	{
		try
		{
			BottomAndSideFinishMilling bottomAndSideFinishMilling = new BottomAndSideFinishMilling();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation = default(ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation);
			if (0 == 0)
			{
				operation = bottomAndSideFinishMilling;
			}
			SlotSide slotSide = new SlotSide();
			ManufacturingFeature feature;
			if (4u != 0)
			{
				feature = slotSide;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (5u != 0)
			{
				workingStep = machiningWorkingStep;
			}
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry;
			if (6u != 0)
			{
				geomGeometry = obj;
			}
			CoreTool coreTool = _0023_003DzCP7__0024l7ucReU(tool);
			CoreTool coreTool2 = default(CoreTool);
			if (0 == 0)
			{
				coreTool2 = coreTool;
			}
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(head);
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead2;
			if (4u != 0)
			{
				configHead2 = configHead;
			}
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(head, configHead2, activeParameters.MachineID);
			ScmGroup.XCam.MachiningDataModel.Head head2;
			if (5u != 0)
			{
				head2 = builderHead;
			}
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D, activeParameters.Workplane.ReferenceKey, activeParameters.ApproachSecurityPlane, activeParameters.RetractSecurityPlane);
			Tuple<double, double> tuple = default(Tuple<double, double>);
			if (0 == 0)
			{
				tuple = builderSafetyDistances;
			}
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple2 = _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(activeParameters.LeadInOut, inputSpeed);
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple3;
			if (3u != 0)
			{
				tuple3 = tuple2;
			}
			Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(rotSpeed, speed);
			Tuple<object, object> tuple4;
			if (true)
			{
				tuple4 = builderTechnologySpeeds;
			}
			ReferencePositionType referencePosition = geomGeometry.ReferencePosition;
			Tuple<object, object, object, object> tuple5 = _0023_003Dzd2vQ0cEpacTskK1OUQ_003D_003D(geomGeometry);
			object item = tuple5.Item1;
			object item2 = tuple5.Item2;
			object item3 = tuple5.Item3;
			object item4 = tuple5.Item4;
			object startDepth = _0023_003Dzd_6vS81LHZfQ(depth);
			object endDepth2 = _0023_003Dzd_6vS81LHZfQ(endDepth);
			FeatureBottomCondition bottomCondition = new GeneralMillingBottom();
			bool isMachiningSameDirection = activeParameters.IsMachiningSameDirection;
			SideType sideOfFeature = _0023_003DzhpRU1EUKegRQ(correction);
			_0023_003DzH1tQYnLqOUsq(overMaterial);
			bool flag = _0023_003DzoTeP2Cltnz2h(correction);
			bool flag2 = _0023_003DzaqRkLCrDhUFH(activeParameters.IsCncCompensation, activeParameters.WorkPlaneCategory);
			bool isSideToSide = false;
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			ReferenceToolKey referenceToolKey = null;
			if (coreTool2 != null)
			{
				referenceToolKey = new ReferenceToolKey(coreTool2.Key, coreTool2.Name);
			}
			if (referenceToolKey == null)
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701422), tool);
			}
			bool flag3 = false;
			if (ToolMethods.GetToolFamily(coreTool2) == KindOfToolFamily.BladeCuttingTool)
			{
				flag3 = true;
			}
			bool flag4 = false;
			if (!MathUtility.IsEqual(angle, 90.0))
			{
				flag4 = true;
			}
			if (flag3 || flag4)
			{
				flag2 = false;
			}
			double builderHeadRotation = GetBuilderHeadRotation(geomGeometry, referenceToolKey, activeParameters.Workpiece.ReferenceKey);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, flag3, coreTool2, head2, feature);
			bool flag5 = false;
			Two5DMillingStrategy two5DMillingStrategy = _0023_003DzG8Zotvn1K1ss53uTM0zGDBXnQ3ejqff7JA_003D_003D(activeParameters.Strategy);
			if (two5DMillingStrategy != null)
			{
				flag5 = true;
			}
			bool flag6 = false;
			if (!flag5)
			{
				if (geomGeometry is GeomCompositeCurve)
				{
					if ((geomGeometry as GeomCompositeCurve).Elements.Count > 0)
					{
						flag6 = true;
					}
				}
				else if (geomGeometry is GeomTrimmedCurve)
				{
					flag6 = true;
				}
			}
			if (flag6)
			{
				_0023_003Dz_hR6lSynO7nq(geomGeometry, operation, activeParameters.Attributes);
			}
			ReferenceKey workplanID = _workplanID;
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
			SlotSideGeometryParameters slotSideGeometryParameters = new SlotSideGeometryParameters(context, geomGeometry);
			SlotSideFeatureParameters slotSideFeatureParameters = new SlotSideFeatureParameters(context, feature);
			SlotSideOperationParameters slotSideOperationParameters = new SlotSideOperationParameters(context, operation);
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			slotSideGeometryParameters.InitializeStartCoordinates(item, item2);
			slotSideGeometryParameters.InitializeEndCoordinates(item3, item4);
			slotSideGeometryParameters.InitializeReferencePosition(referencePosition);
			slotSideFeatureParameters.InitializeDepth(startDepth, endDepth2, bottomCondition);
			slotSideFeatureParameters.InitializeProfile(isMachiningSameDirection);
			slotSideFeatureParameters.InitializeToolCompensation(sideOfFeature, overMaterial, flag);
			slotSideFeatureParameters.InitializeAngle(angle);
			slotSideFeatureParameters.InitializeSideToSide(isSideToSide, num, num2);
			slotSideOperationParameters.InitializeApproach(tuple3.Item1);
			slotSideOperationParameters.InitializeCNMode(flag2);
			slotSideOperationParameters.InitializeHead(head2);
			slotSideOperationParameters.InitializeHeadRotation(builderHeadRotation);
			slotSideOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			slotSideOperationParameters.InitializeRetract(tuple3.Item2);
			slotSideOperationParameters.InitializeSafetyDistance(tuple.Item1, tuple.Item2);
			slotSideOperationParameters.InitializeStrategy(two5DMillingStrategy);
			slotSideOperationParameters.InitializeTechnology(referenceToolKey, tuple4.Item2, tuple4.Item1);
			slotSideOperationParameters.InitializeExtraDepth(num3);
			workingStepParameters.InitializeDescription(description);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			SlotSideBuilder slotSideBuilder = new SlotSideBuilder(context);
			slotSideBuilder.InitializeGeometry(slotSideGeometryParameters);
			slotSideBuilder.InitializeFeature(slotSideFeatureParameters);
			slotSideBuilder.InitializeOperation(slotSideOperationParameters);
			slotSideBuilder.InitializeWorkingStep(workingStepParameters);
			slotSideBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = slotSideBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701464), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateContourPocket(ActiveProgramParameters activeParameters, double depth, string description, TypeOfProcess typeOfProcess, string tool, string head, double inputSpeed, double rotSpeed, double speed, double overlap, bool finalPass, List<Geometry> bossList)
	{
		try
		{
			int headNumber;
			if (2u != 0)
			{
				headNumber = 0;
			}
			ReferenceToolKey refToolKey;
			if (2u != 0)
			{
				refToolKey = null;
			}
			BottomAndSideRoughMilling bottomAndSideRoughMilling = new BottomAndSideRoughMilling();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation = default(ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation);
			if (0 == 0)
			{
				operation = bottomAndSideRoughMilling;
			}
			BottomAndSideRoughMilling obj = operation as BottomAndSideRoughMilling;
			BottomAndSideRoughMilling bottomAndSideRoughMilling2;
			if (5u != 0)
			{
				bottomAndSideRoughMilling2 = obj;
			}
			_toolInterface.GetToolHeadInfo(head, tool, ref headNumber, ref refToolKey);
			bottomAndSideRoughMilling2.ToolKey = refToolKey;
			ScmGroup.XCam.MachiningDataModel.Head head2 = _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(bottomAndSideRoughMilling2, activeParameters.MachineID, head, headNumber);
			ScmGroup.XCam.MachiningDataModel.Head machiningHead;
			if (7u != 0)
			{
				machiningHead = head2;
			}
			bottomAndSideRoughMilling2.ActivateCNCCorrection = false;
			UI00MachiningOptions machiningOptions = _0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D;
			ReferenceKey referenceKey = activeParameters.Workplane.ReferenceKey;
			double? approachSecurityPlane = activeParameters.ApproachSecurityPlane;
			double? retractSecurityPlane = activeParameters.RetractSecurityPlane;
			if (5u != 0)
			{
				CreateMachiningOperationSafetyDistances(machiningOptions, bottomAndSideRoughMilling2, referenceKey, approachSecurityPlane, retractSecurityPlane);
			}
			Plane obj2 = _projectInterface.Get(activeParameters.Workplane.ReferenceKey) as Plane;
			Plane plane;
			if (true)
			{
				plane = obj2;
			}
			double radialCuttingDepth;
			if (4u != 0)
			{
				radialCuttingDepth = 0.0;
			}
			if (_toolInterface != null && bottomAndSideRoughMilling2.ToolKey != null && bottomAndSideRoughMilling2.ToolKey.IsValid)
			{
				ToolPropertyValue toolPropertyValue = _toolInterface.GetToolPropertyValue(refToolKey, KindOfToolProperty.Diameter);
				ToolPropertyValue toolPropertyValue2;
				if (5u != 0)
				{
					toolPropertyValue2 = toolPropertyValue;
				}
				if (toolPropertyValue2 != null)
				{
					double num = Convert.ToDouble(toolPropertyValue2.Value) / 2.0;
					if (true)
					{
						radialCuttingDepth = num;
					}
				}
				else
				{
					ToolPropertyValue toolPropertyValue3 = _toolInterface.GetToolPropertyValue(refToolKey, KindOfToolProperty.MortiserThickness);
					if (toolPropertyValue3 != null)
					{
						radialCuttingDepth = Convert.ToDouble(toolPropertyValue3.Value) / 2.0;
					}
				}
			}
			else
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701403), tool);
			}
			bottomAndSideRoughMilling2.MachiningStrategy = new ContourParallel();
			ContourParallel contourParallel = bottomAndSideRoughMilling2.MachiningStrategy as ContourParallel;
			contourParallel.RadialCuttingDepth = radialCuttingDepth;
			contourParallel.Overlap = overlap;
			contourParallel.AllowsFinishCutting = finalPass;
			bool flag = false;
			Strategy strategy = activeParameters.Strategy;
			double allowanceSide = 0.0;
			if (strategy != null)
			{
				flag = true;
				if (strategy is ContourParallelStrategy contourParallelStrategy)
				{
					contourParallel.AllowMultiplePasses = contourParallelStrategy.AllowMultiplePasses;
					contourParallel.AxialCuttingDepth = contourParallelStrategy.AxialCuttingDepth;
					contourParallel.AxialFinishCuttingDepth = contourParallelStrategy.AxialFinishCuttingDepth;
					contourParallel.InsideToOutSide = contourParallelStrategy.InsideToOutSide;
					contourParallel.RotationDirection = contourParallelStrategy.RotationDirection;
					contourParallel.StrokeConnectionStrategy = contourParallelStrategy.StrokeConnectionType;
					contourParallel.IsHelicStrategy = contourParallelStrategy.IsHelicStrategy;
					contourParallel.IsApproachRetractPassStrategy = contourParallelStrategy.IsApproachRetractPassStrategy;
					allowanceSide = contourParallelStrategy.AllowanceSide;
				}
			}
			bottomAndSideRoughMilling2.AllowanceSide = allowanceSide;
			List<GeomGeometry> list = new List<GeomGeometry>();
			GeomGeometry geometry = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry = geometry;
			if (geometry is GeomCircle)
			{
				geomGeometry = (geometry as GeomCircle).ToCompositeCurve();
			}
			else if (geometry is GeomEllipse)
			{
				geomGeometry = (geometry as GeomEllipse).ToCompositeCurve();
			}
			else if (geometry is GeomBSplineCurve)
			{
				geomGeometry = (geometry as GeomBSplineCurve).ToCompositeCurve(plane);
			}
			_projectInterface.ToAbsoluteGeometry(geomGeometry);
			list.Add(geomGeometry);
			if (bossList != null)
			{
				foreach (Geometry boss in bossList)
				{
					GeomGeometry geomGeometry2 = _projectInterface.Get(boss.ReferenceKey) as GeomGeometry;
					geomGeometry = geomGeometry2;
					if (geomGeometry2 is GeomCircle)
					{
						geomGeometry = (geomGeometry2 as GeomCircle).ToCompositeCurve();
					}
					else if (geomGeometry2 is GeomEllipse)
					{
						geomGeometry = (geomGeometry2 as GeomEllipse).ToCompositeCurve();
					}
					else if (geomGeometry2 is GeomBSplineCurve)
					{
						geomGeometry = (geomGeometry2 as GeomBSplineCurve).ToCompositeCurve(plane);
					}
					_projectInterface.ToAbsoluteGeometry(geomGeometry);
					list.Add(geomGeometry);
				}
			}
			List<PocketGeometries> list2 = PocketUtility.MakePocketGeometries(list, plane);
			_0023_003Dz4yqdYK9mHp3S_FyDIYP8vPaAWS19kSex_0024Q_003D_003D(operation as MillingTypeOperation, activeParameters.LeadInOut, inputSpeed);
			MillingTechnology millingTechnology = new MillingTechnology();
			millingTechnology.Spindle = ((rotSpeed != -1.0) ? rotSpeed : 0.0);
			millingTechnology.Feedrate = ((speed != -1.0) ? speed : 0.0);
			(operation as MachiningOperation).Technology = millingTechnology;
			ManufacturingFeature feature = new ClosedPocket();
			(feature as MachiningFeature).Depth = new DepthPlane(depth, depth);
			(feature as Two5DManufacturingFeature).BottomCondition = new PlanarPocketBottomCondition();
			if (list2[0].BossIDList != null)
			{
				(feature as Pocket).BossList = new List<Boss>();
				foreach (ReferenceKey bossID in list2[0].BossIDList)
				{
					Boss item = new Boss(bossID, new DepthPlane(depth, depth), 0.0, plane.WorkpieceID);
					(feature as Pocket).BossList.Add(item);
				}
			}
			if (list2[0].BoundaryList != null)
			{
				(feature as Pocket).BoundaryGeometryList = list2[0].BoundaryList.Clone();
			}
			if (list2[0].BossList != null)
			{
				(feature as Pocket).BossGeometryList = list2[0].BossList.Clone();
			}
			if (list2[0].ToolpathList != null)
			{
				if (operation.ToolpathList != null)
				{
					operation.ToolpathList.Clear();
				}
				else
				{
					operation.ToolpathList = new List<Toolpath>();
				}
				foreach (GeomCompositeCurve toolpath in list2[0].ToolpathList)
				{
					CutterLocationTrajectory cutterLocationTrajectory = new CutterLocationTrajectory();
					cutterLocationTrajectory.Type = ToolPathType.TrajectoryPath;
					cutterLocationTrajectory.BasicCurve = toolpath;
					cutterLocationTrajectory.ToolAxis = new ToolDirection();
					if (!operation.ToolpathList.Contains(cutterLocationTrajectory))
					{
						operation.ToolpathList.Add(cutterLocationTrajectory);
					}
				}
			}
			bottomAndSideRoughMilling2.HeadRotation = CalculateHeadRotation(geometry, refToolKey, activeParameters.Workpiece.ReferenceKey);
			(operation as MachiningOperation).MachineFunctions = CreateMachineFunctions(activeParameters.MachineFunctions, disableDustPan: false, refToolKey, machiningHead, feature);
			MachiningWorkingStep workingStep = new MachiningWorkingStep(feature.Key, operation.Key);
			workingStep.Name = base.Name;
			workingStep.IsEnabled = true;
			workingStep.Description = description;
			if (!flag)
			{
				_0023_003Dz_hR6lSynO7nq(geometry, operation, activeParameters.Attributes);
			}
			workingStep.Priority = activeParameters.Priority;
			ReferenceKey referenceKey2 = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey3 = activeParameters.Workplane.ReferenceKey;
			_projectInterface.InsertAtWorkingStep(ref geometry, ref feature, ref operation, ref workingStep, referenceKey3, _workplanID, referenceKey2, -1, this);
			base.ReferenceKey = workingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701377), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateContour(ActiveProgramParameters activeParameters, TypeOfContour typeOfContour, SideOfContour sideOfContour, double depth, string description, TypeOfProcess typeOfProcess, string tool, string head, int correction, double inputSpeed, double rotSpeed, double speed, double overMaterial)
	{
		try
		{
			BottomAndSideFinishMilling bottomAndSideFinishMilling = new BottomAndSideFinishMilling();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (3u != 0)
			{
				operation = bottomAndSideFinishMilling;
			}
			ContourFeature contourFeature = new ContourFeature();
			ManufacturingFeature feature = default(ManufacturingFeature);
			if (0 == 0)
			{
				feature = contourFeature;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (4u != 0)
			{
				workingStep = machiningWorkingStep;
			}
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = default(ReferenceKey);
			if (0 == 0)
			{
				referenceKey2 = referenceKey;
			}
			ReferenceKey referenceKey3 = activeParameters.Workplane.ReferenceKey;
			ReferenceKey referenceKey4;
			if (8u != 0)
			{
				referenceKey4 = referenceKey3;
			}
			if (2u != 0)
			{
				ReferenceKey referenceKey5 = null;
			}
			GeomGeometry geomGeometry;
			if (4u != 0)
			{
				geomGeometry = null;
			}
			switch (typeOfContour)
			{
			case TypeOfContour.Workpiece:
			{
				GeomCompositeCurve finishedBoundaryGeometry = (_projectInterface.Get(referenceKey2) as WorkPiece).GetFinishedBoundaryGeometry();
				GeomGeometry geometry;
				if (4u != 0)
				{
					geometry = finishedBoundaryGeometry;
				}
				_projectInterface.AddGeometry(ref geometry, referenceKey4, referenceKey2, this);
				GeomGeometry geomGeometry2 = geometry;
				if (0 == 0)
				{
					geomGeometry = geomGeometry2;
				}
				ReferenceKey key = geomGeometry.Key;
				if (uint.MaxValue != 0)
				{
					ReferenceKey referenceKey5 = key;
				}
				break;
			}
			case TypeOfContour.Geometry:
			{
				ReferenceKey referenceKey5 = activeParameters.Geometry.ReferenceKey;
				geomGeometry = _projectInterface.Get(referenceKey5) as GeomGeometry;
				referenceKey4 = geomGeometry.PlaneID;
				break;
			}
			}
			Plane plane = _projectInterface.Get(referenceKey4) as Plane;
			SideType sideType = SideType.Center;
			bool flag = Inversion.IsClockWise(geomGeometry, plane);
			sideType = (((sideOfContour != SideOfContour.Outside || !flag) && (sideOfContour != SideOfContour.Inside || flag)) ? SideType.Right : SideType.Left);
			CoreTool coreTool = _0023_003DzCP7__0024l7ucReU(tool);
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(head);
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(head, configHead, activeParameters.MachineID);
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D, activeParameters.Workplane.ReferenceKey, activeParameters.ApproachSecurityPlane, activeParameters.RetractSecurityPlane);
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple = _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(activeParameters.LeadInOut, inputSpeed);
			Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(rotSpeed, speed);
			object obj = _0023_003Dzd_6vS81LHZfQ(depth);
			FeatureBottomCondition bottomCondition = new GeneralMillingBottom();
			bool isMachiningSameDirection = activeParameters.IsMachiningSameDirection;
			_0023_003DzH1tQYnLqOUsq(overMaterial);
			bool flag2 = _0023_003DzoTeP2Cltnz2h(correction);
			bool flag3 = _0023_003DzaqRkLCrDhUFH(activeParameters.IsCncCompensation, activeParameters.WorkPlaneCategory);
			TypeOfExtremaMachiningAttributePosition startMachiningPosition = activeParameters.StartMachiningPosition;
			double num = 0.0;
			ReferenceToolKey referenceToolKey = null;
			if (coreTool != null)
			{
				referenceToolKey = new ReferenceToolKey(coreTool.Key, coreTool.Name);
			}
			if (referenceToolKey == null)
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701584), tool);
			}
			bool disableDustPan = false;
			if (ToolMethods.GetToolFamily(coreTool) == KindOfToolFamily.BladeCuttingTool)
			{
				disableDustPan = true;
			}
			double builderHeadRotation = GetBuilderHeadRotation(geomGeometry, referenceToolKey, activeParameters.Workpiece.ReferenceKey);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan, coreTool, builderHead, feature);
			bool flag4 = false;
			Two5DMillingStrategy two5DMillingStrategy = _0023_003DzG8Zotvn1K1ss53uTM0zGDBXnQ3ejqff7JA_003D_003D(activeParameters.Strategy);
			if (two5DMillingStrategy != null)
			{
				flag4 = true;
			}
			bool flag5 = false;
			if (!flag4)
			{
				if (geomGeometry is GeomCompositeCurve)
				{
					if ((geomGeometry as GeomCompositeCurve).Elements.Count > 0)
					{
						flag5 = true;
					}
				}
				else if (geomGeometry is GeomTrimmedCurve)
				{
					flag5 = true;
				}
			}
			if (flag5)
			{
				_0023_003Dz_hR6lSynO7nq(geomGeometry, operation, activeParameters.Attributes);
			}
			ReferenceKey workplanID = _workplanID;
			POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
			ContourFeatureGeometryParameters geometryParameters = new ContourFeatureGeometryParameters(context, geomGeometry);
			ContourFeatureFeatureParameters contourFeatureFeatureParameters = new ContourFeatureFeatureParameters(context, feature);
			ContourFeatureOperationParameters contourFeatureOperationParameters = new ContourFeatureOperationParameters(context, operation);
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			contourFeatureFeatureParameters.InitializeDepth(obj, obj, bottomCondition);
			contourFeatureFeatureParameters.InitializeProfile(isMachiningSameDirection);
			contourFeatureFeatureParameters.InitializeToolCompensation(sideType, overMaterial, flag2);
			contourFeatureFeatureParameters.InitializeContourType(typeOfContour);
			contourFeatureOperationParameters.InitializeApproach(tuple.Item1);
			contourFeatureOperationParameters.InitializeCNMode(flag3);
			contourFeatureOperationParameters.InitializeHead(builderHead);
			contourFeatureOperationParameters.InitializeHeadRotation(builderHeadRotation);
			contourFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			contourFeatureOperationParameters.InitializeRetract(tuple.Item2);
			contourFeatureOperationParameters.InitializeSafetyDistance(builderSafetyDistances.Item1, builderSafetyDistances.Item2);
			contourFeatureOperationParameters.InitializeStrategy(two5DMillingStrategy);
			contourFeatureOperationParameters.InitializeTechnology(referenceToolKey, builderTechnologySpeeds.Item2, builderTechnologySpeeds.Item1);
			contourFeatureOperationParameters.InitializeExtraDepth(num);
			contourFeatureOperationParameters.InitializeStartMachiningPointPosition(startMachiningPosition);
			workingStepParameters.InitializeDescription(description);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			ContourFeatureBuilder contourFeatureBuilder = new ContourFeatureBuilder(context);
			contourFeatureBuilder.InitializeGeometry(geometryParameters);
			contourFeatureBuilder.InitializeFeature(contourFeatureFeatureParameters);
			contourFeatureBuilder.InitializeOperation(contourFeatureOperationParameters);
			contourFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			contourFeatureBuilder.Add(workplanID, referenceKey2, referenceKey4, -1);
			base.ReferenceKey = contourFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701564), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003DzuJOUyAMySoAB(string _0023_003DzJ3hfjPs_003D, string _0023_003DzrziU4i4_003D, string _0023_003DzTgF4RrM_003D, string _0023_003DzqmiDBVY_003D)
	{
		string empty = string.Empty;
		string text;
		if (uint.MaxValue != 0)
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
			if (2u != 0)
			{
				text = text2;
			}
		}
		string errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703888), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzqmiDBVY_003D, _0023_003DzJ3hfjPs_003D, text, _0023_003DzTgF4RrM_003D);
		if (uint.MaxValue != 0)
		{
			_errorString = errorString;
		}
		AddToErrorFile(_errorString);
	}

	private ScmGroup.XCam.MachiningDataModel.Head _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(MachiningOperation _0023_003DzIDjFPYA_003D, int _0023_003Dzq_0024W2yCc_003D, string _0023_003DzYEQjc18_003D, int _0023_003Dznv8znP1vlgf_0024)
	{
		ScmGroup.XCam.MachiningDataModel.Head head;
		if (6u != 0)
		{
			head = null;
		}
		if (_0023_003Dznv8znP1vlgf_0024 >= 3)
		{
			ScmGroup.XCam.MachiningDataModel.Head head2 = new ScmGroup.XCam.MachiningDataModel.Head(_0023_003Dznv8znP1vlgf_0024, TypeOfHead.None);
			if (0 == 0)
			{
				head = head2;
			}
		}
		if (_0023_003Dzq_0024W2yCc_003D > 0 && _configurationInterface != null)
		{
			Machine configurationMachine = _configurationInterface.GetConfigurationMachine(_0023_003Dzq_0024W2yCc_003D - 1, clone: false);
			Machine machine;
			if (6u != 0)
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
		return head;
	}

	public void CheckExpression(string propertyName, object propertyValue)
	{
		if (!StringUtility.IsValid(propertyName))
		{
			return;
		}
		MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
		MachiningWorkingStep machiningWorkingStep;
		if (2u != 0)
		{
			machiningWorkingStep = obj;
		}
		if (machiningWorkingStep == null)
		{
			return;
		}
		object obj2 = ConvertExpressionValueToCurrentFormat(propertyValue);
		object actualValue;
		if (uint.MaxValue != 0)
		{
			actualValue = obj2;
		}
		if (!_0023_003DzjjcOfI3A_0024tft(propertyName))
		{
			return;
		}
		ManufacturingFeature obj3 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
		ManufacturingFeature manufacturingFeature;
		if (true)
		{
			manufacturingFeature = obj3;
		}
		if (manufacturingFeature != null)
		{
			ReferenceKey key = manufacturingFeature.Key;
			if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067))
			{
				PropertyField property = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703853));
				_projectInterface.CheckExpressions(key, property, actualValue);
				property = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703838));
				_projectInterface.CheckExpressions(key, property, actualValue);
			}
			else
			{
				PropertyField property2 = new PropertyField(propertyName);
				_projectInterface.CheckExpressions(key, property2, actualValue);
			}
		}
	}

	private bool _0023_003Dz5VyKIiv_0024IAdx(string _0023_003DzvMK8Nks_003D)
	{
		return false;
	}

	private bool _0023_003DzjjcOfI3A_0024tft(string _0023_003DzvMK8Nks_003D)
	{
		bool result;
		if (3u != 0)
		{
			result = false;
		}
		if (_0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703625) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703853) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703838) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703821) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704574) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704559))
		{
			if (3u != 0)
			{
				result = true;
			}
		}
		return result;
	}

	private bool _0023_003DzP1MEygfi1zha(string _0023_003DzvMK8Nks_003D)
	{
		bool result;
		if (6u != 0)
		{
			result = false;
		}
		if (_0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703661))
		{
			if (4u != 0)
			{
				result = true;
			}
		}
		return result;
	}

	private CoreTool _0023_003DzCP7__0024l7ucReU(string _0023_003DzlCSVU0o_003D)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		ToolInterface toolInterface = _toolInterface;
		_ = 3;
		if (4 == 0)
		{
		}
		return toolInterface.Get(_0023_003DzlCSVU0o_003D);
	}

	private Tuple<BaseApproachStrategy, BaseRetractStrategy> _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(LeadInOut _0023_003Dzui4D8_aBQtar, double _0023_003DzksrR6KQfs_Ff)
	{
		Tuple<BaseApproachStrategy, BaseRetractStrategy> result;
		if (4u != 0)
		{
			result = null;
		}
		try
		{
			bool isEnabled;
			if (2u != 0)
			{
				isEnabled = false;
			}
			double speed;
			if (2u != 0)
			{
				speed = _0023_003DzksrR6KQfs_Ff;
			}
			double radiusMultiplier;
			if (2u != 0)
			{
				radiusMultiplier = 1.0;
			}
			ModeOfApproach approachMode;
			if (6u != 0)
			{
				approachMode = ModeOfApproach.Down;
			}
			TypeOfApproachRetract approachType = TypeOfApproachRetract.Line;
			bool isEnabled2 = false;
			double speed2 = -1.0;
			double radiusMultiplier2 = 1.0;
			double length = 0.0;
			ModeOfRetract retractMode = ModeOfRetract.Up;
			TypeOfApproachRetract retractType = TypeOfApproachRetract.Line;
			if (_0023_003Dzui4D8_aBQtar != null)
			{
				isEnabled = _0023_003Dzui4D8_aBQtar.IsLeadInEnabled;
				radiusMultiplier = _0023_003Dzui4D8_aBQtar.ApproachDistance;
				double num = (_0023_003Dzui4D8_aBQtar.ApproachSpeed.HasValue ? _0023_003Dzui4D8_aBQtar.ApproachSpeed.Value : (-1.0));
				speed = ((num != -1.0) ? ConvertSpeedToCurrentUnit(num) : ConvertSpeedToCurrentUnit(speed));
				approachMode = ((!_0023_003Dzui4D8_aBQtar.IsQuoteApproach) ? ModeOfApproach.Down : ModeOfApproach.Quote);
				approachType = ((!_0023_003Dzui4D8_aBQtar.IsLinearApproach) ? TypeOfApproachRetract.Arc : TypeOfApproachRetract.Line);
				isEnabled2 = _0023_003Dzui4D8_aBQtar.IsLeadOutEnabled;
				radiusMultiplier2 = _0023_003Dzui4D8_aBQtar.RetractDistance;
				length = _0023_003Dzui4D8_aBQtar.OverlapLength;
				speed2 = ((!_0023_003Dzui4D8_aBQtar.RetractSpeed.HasValue) ? (-1.0) : ConvertSpeedToCurrentUnit(_0023_003Dzui4D8_aBQtar.RetractSpeed.Value));
				retractMode = ((!_0023_003Dzui4D8_aBQtar.IsQuoteRetract) ? ModeOfRetract.Up : ModeOfRetract.Quote);
				retractType = ((!_0023_003Dzui4D8_aBQtar.IsLinearRetract) ? TypeOfApproachRetract.Arc : TypeOfApproachRetract.Line);
			}
			result = Tuple.Create(new BaseApproachStrategy
			{
				ApproachMode = approachMode,
				ApproachType = approachType,
				IsEnabled = isEnabled,
				RadiusMultiplier = radiusMultiplier,
				Speed = speed
			}, new BaseRetractStrategy
			{
				IsEnabled = isEnabled2,
				RadiusMultiplier = radiusMultiplier2,
				OverLap = ConvertLengthToCurrentUnit(length),
				Speed = speed2,
				RetractMode = retractMode,
				RetractType = retractType
			});
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703974), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		return result;
	}

	private SideType _0023_003DzhpRU1EUKegRQ(int _0023_003DzGflSo6gx3M4rkp90RA_003D_003D)
	{
		SideType result;
		if (2u != 0)
		{
			result = SideType.Center;
		}
		switch (_0023_003DzGflSo6gx3M4rkp90RA_003D_003D)
		{
		case 0:
			if (true)
			{
				result = SideType.Center;
			}
			break;
		case 1:
		case 13:
			if (2u != 0)
			{
				result = SideType.Left;
			}
			break;
		case 2:
		case 23:
			result = SideType.Right;
			break;
		}
		return result;
	}

	private bool _0023_003DzoTeP2Cltnz2h(int _0023_003DzGflSo6gx3M4rkp90RA_003D_003D)
	{
		_ = 7;
		if (4 == 0)
		{
		}
		if (_0023_003DzGflSo6gx3M4rkp90RA_003D_003D != 3)
		{
			_ = 2;
			if (false)
			{
			}
			if (_0023_003DzGflSo6gx3M4rkp90RA_003D_003D != 13)
			{
				_ = 3;
				if (6 == 0)
				{
				}
				return _0023_003DzGflSo6gx3M4rkp90RA_003D_003D == 23;
			}
		}
		return true;
	}

	private Two5DMillingStrategy _0023_003DzG8Zotvn1K1ss53uTM0zGDBXnQ3ejqff7JA_003D_003D(Strategy _0023_003Dze06VVWU_003D)
	{
		Two5DMillingStrategy result;
		if (8u != 0)
		{
			result = null;
		}
		if (_0023_003Dze06VVWU_003D != null)
		{
			if (_0023_003Dze06VVWU_003D is BidirectionalMillingStrategy)
			{
				BidirectionalMillingStrategy obj = _0023_003Dze06VVWU_003D as BidirectionalMillingStrategy;
				BidirectionalMillingStrategy bidirectionalMillingStrategy;
				if (2u != 0)
				{
					bidirectionalMillingStrategy = obj;
				}
				BidirectionalMilling obj2 = new BidirectionalMilling
				{
					AllowMultiplePasses = bidirectionalMillingStrategy.AllowMultiplePasses,
					AxialCuttingDepth = bidirectionalMillingStrategy.AxialCuttingDepth,
					AxialFinishCuttingDepth = bidirectionalMillingStrategy.AxialFinishCuttingDepth,
					Overlap = 0.0,
					StrokeConnectionStrategy = StrokeConnectionStrategy.Straghtline
				};
				if (6u != 0)
				{
					result = obj2;
				}
			}
			else if (_0023_003Dze06VVWU_003D is UnidirectionalMillingStrategy)
			{
				UnidirectionalMillingStrategy obj3 = _0023_003Dze06VVWU_003D as UnidirectionalMillingStrategy;
				UnidirectionalMillingStrategy unidirectionalMillingStrategy;
				if (4u != 0)
				{
					unidirectionalMillingStrategy = obj3;
				}
				result = new UnidirectionalMilling
				{
					AllowMultiplePasses = unidirectionalMillingStrategy.AllowMultiplePasses,
					AxialCuttingDepth = unidirectionalMillingStrategy.AxialCuttingDepth,
					AxialFinishCuttingDepth = unidirectionalMillingStrategy.AxialFinishCuttingDepth,
					Overlap = 0.0,
					IsApproachRetractPassStrategy = unidirectionalMillingStrategy.IsApproachRetractPassStrategy
				};
			}
			else if (_0023_003Dze06VVWU_003D is HelicMillingStrategy)
			{
				HelicMillingStrategy helicMillingStrategy = _0023_003Dze06VVWU_003D as HelicMillingStrategy;
				result = new HelicMilling
				{
					AxialCuttingDepth = helicMillingStrategy.AxialCuttingDepth,
					Overlap = 0.0,
					AxialFinishCuttingDepth = helicMillingStrategy.AxialFinishCuttingDepth,
					AllowsFinishCutting = helicMillingStrategy.AllowsFinishCutting
				};
			}
			else if (_0023_003Dze06VVWU_003D is SectioningMillingStrategy)
			{
				SectioningMillingStrategy sectioningMillingStrategy = _0023_003Dze06VVWU_003D as SectioningMillingStrategy;
				result = new SectioningMilling
				{
					AllowMultiplePasses = false,
					Overlap = 0.0,
					FirstCutDepth = sectioningMillingStrategy.FirstCutDepth,
					OutDistance = sectioningMillingStrategy.OutDistance,
					SideMovingDistance = sectioningMillingStrategy.SideMovingDistance
				};
			}
			else if (_0023_003Dze06VVWU_003D is ZigZagMillingStrategy)
			{
				ZigZagMillingStrategy zigZagMillingStrategy = _0023_003Dze06VVWU_003D as ZigZagMillingStrategy;
				result = new ZigZagMilling
				{
					AllowMultiplePasses = false,
					Overlap = 0.0,
					FeedCuttingDepth = zigZagMillingStrategy.FeedCuttingDepth,
					ReturnCuttingDepth = zigZagMillingStrategy.ReturnCuttingDepth,
					AxialFinishCuttingDepth = zigZagMillingStrategy.AxialFinishCuttingDepth
				};
			}
		}
		return result;
	}

	private Two5DMillingStrategy _0023_003Dz5M3u1w_YhVifrZJENGUj32TC4Lb9UxbkvQ_003D_003D(Strategy _0023_003Dze06VVWU_003D, double _0023_003DznD2S_0024SiO9oMj, double _0023_003DzhZa1Lm_a8PSd, bool _0023_003Dz4hk0XPpSVo0_0024)
	{
		if (_0023_003Dze06VVWU_003D != null && _0023_003Dze06VVWU_003D is ContourParallelStrategy)
		{
			ContourParallelStrategy obj = _0023_003Dze06VVWU_003D as ContourParallelStrategy;
			ContourParallelStrategy contourParallelStrategy;
			if (4u != 0)
			{
				contourParallelStrategy = obj;
			}
			new ContourParallel
			{
				AllowMultiplePasses = contourParallelStrategy.AllowMultiplePasses,
				AxialCuttingDepth = contourParallelStrategy.AxialCuttingDepth,
				AllowsFinishCutting = _0023_003Dz4hk0XPpSVo0_0024,
				AxialFinishCuttingDepth = contourParallelStrategy.AxialFinishCuttingDepth,
				InsideToOutSide = contourParallelStrategy.InsideToOutSide,
				Overlap = _0023_003DzhZa1Lm_a8PSd,
				RadialCuttingDepth = _0023_003DznD2S_0024SiO9oMj,
				RotationDirection = contourParallelStrategy.RotationDirection,
				StrokeConnectionStrategy = contourParallelStrategy.StrokeConnectionType,
				IsHelicStrategy = contourParallelStrategy.IsHelicStrategy
			};
		}
		return null;
	}

	private double _0023_003Dzd_6vS81LHZfQ(double _0023_003DzX1WK4z0_003D)
	{
		_ = 4;
		if (2 == 0)
		{
		}
		_ = -1;
		if (4 == 0)
		{
		}
		return ConvertLengthToCurrentUnit(_0023_003DzX1WK4z0_003D);
	}

	private double _0023_003DzH1tQYnLqOUsq(double _0023_003DzbDCdcxRsxdCG)
	{
		_ = 6;
		if (6 == 0)
		{
		}
		_ = 7;
		if (false)
		{
		}
		return ConvertLengthToCurrentUnit(_0023_003DzbDCdcxRsxdCG);
	}

	private bool _0023_003DzaqRkLCrDhUFH(bool _0023_003DzqydnvRs20KT_0024, WorkPlaneCategory _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D)
	{
		bool result;
		if (6u != 0)
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

	private Tuple<object, object, object, object> _0023_003Dzd2vQ0cEpacTskK1OUQ_003D_003D(GeomGeometry _0023_003DzjDpg_oE_003D)
	{
		_projectInterface.ConvertGeometryToReferencePosition(_0023_003DzjDpg_oE_003D);
		gp_Pnt startPoint = _0023_003DzjDpg_oE_003D.GetStartPoint();
		gp_Pnt val;
		if (4u != 0)
		{
			val = startPoint;
		}
		gp_Pnt endPoint = _0023_003DzjDpg_oE_003D.GetEndPoint();
		gp_Pnt val2;
		if (true)
		{
			val2 = endPoint;
		}
		object item = ConvertLengthToCurrentUnit(val.X());
		object obj = ConvertLengthToCurrentUnit(val.Y());
		object item2 = default(object);
		if (0 == 0)
		{
			item2 = obj;
		}
		object item3 = ConvertLengthToCurrentUnit(val2.X());
		object item4 = ConvertLengthToCurrentUnit(val2.Y());
		_projectInterface.ConvertGeometryToReferencePosition(_0023_003DzjDpg_oE_003D);
		return Tuple.Create(item, item2, item3, item4);
	}
}
