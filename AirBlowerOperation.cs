using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Referentiable;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.Localization;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.AirBlowering;
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

namespace ScmGroup.XCam.Scripting;

public class AirBlowerOperation : Operation
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
				if (7u != 0)
				{
					machiningWorkingStep = obj;
				}
				MachiningOperation obj2 = _projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation;
				MachiningOperation machiningOperation;
				if (6u != 0)
				{
					machiningOperation = obj2;
				}
				uint iD = (_projectInterface.Get(machiningOperation.ToolKey) as CoreTool).Key.ID;
				if (4u != 0)
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
				if (2u != 0)
				{
					machiningWorkingStep = obj;
				}
				int spindleNumber = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Head.SpindleNumber;
				if (4u != 0)
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
				if (6u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (7u != 0)
				{
					manufacturingFeature = obj2;
				}
				GeomGeometry obj3 = _projectInterface.Get(manufacturingFeature.GeometryID) as GeomGeometry;
				GeomGeometry geomGeometry;
				if (5u != 0)
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
				if (7u != 0)
				{
					machiningWorkingStep = obj;
				}
				double feedrate = ((_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Technology as MillingTechnology).Feedrate;
				if (5u != 0)
				{
					return feedrate;
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
				if (6u != 0)
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
				if (true)
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
				if (4u != 0)
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
				if (5u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature = default(ManufacturingFeature);
				if (0 == 0)
				{
					manufacturingFeature = obj2;
				}
				if (!(manufacturingFeature is MillingMachiningFeature))
				{
					return ((manufacturingFeature as ReplicateFeature).BaseFeature as MillingMachiningFeature).SideOffset;
				}
				double sideOffset = (manufacturingFeature as MillingMachiningFeature).SideOffset;
				if (2u != 0)
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
				if (uint.MaxValue != 0)
				{
					return activateCNCCorrection;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
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
				if (6u != 0)
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
				if (2u != 0)
				{
					machiningWorkingStep = obj;
				}
				double spindle = ((_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Technology as MillingTechnology).Spindle;
				if (6u != 0)
				{
					return spindle;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
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

	public AirBlowerOperation(OperationContext operationContext, string name, ReferenceKey workPlanKey)
		: base(operationContext, workPlanKey)
	{
		if (3u != 0)
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
			if (true)
			{
				geomCompositeCurve = obj;
			}
			int num;
			if (5u != 0)
			{
				num = 0;
			}
			while (num < _0023_003Dz6oCO56s_003D.Count)
			{
				_0023_003Dz6oCO56s_003D[num].Value.ElementKey = geomCompositeCurve.Elements[_0023_003Dz6oCO56s_003D[num].Index].Key;
				_0023_003DzIDjFPYA_003D.Attributes.Add(_0023_003Dz6oCO56s_003D[num].Value);
				int num2 = num + 1;
				if (2u != 0)
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

	public void CreateAirBlower(AirBlowerOperationParameters airBlowerParameters, ActiveProgramParameters activeParameters, string description, string tool, string head, int toolCorrection, double inputSpeed, double speed, double? approachSecurityPlane, double? retractSecurityPlane, bool isMachiningSameDirection, bool isCncCompensation)
	{
		try
		{
			ScmGroup.XCam.MachiningDataModel.AirBlowering.AirBlowerOperation airBlowerOperation = new ScmGroup.XCam.MachiningDataModel.AirBlowering.AirBlowerOperation();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation = default(ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation);
			if (0 == 0)
			{
				operation = airBlowerOperation;
			}
			AirBlowerFeature airBlowerFeature = new AirBlowerFeature();
			ManufacturingFeature feature;
			if (8u != 0)
			{
				feature = airBlowerFeature;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep = default(MachiningWorkingStep);
			if (0 == 0)
			{
				workingStep = machiningWorkingStep;
			}
			GeomGeometry obj = _projectInterface.Get(airBlowerParameters.ActiveGeometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry;
			if (4u != 0)
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
			if (3u != 0)
			{
				configHead2 = configHead;
			}
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(configHead2);
			ScmGroup.XCam.MachiningDataModel.Head head2;
			if (uint.MaxValue != 0)
			{
				head2 = builderHead;
			}
			int machineID = activeParameters.MachineID;
			int num;
			if (4u != 0)
			{
				num = machineID;
			}
			if (num > 0 && _configurationInterface != null)
			{
				Machine configurationMachine = _configurationInterface.GetConfigurationMachine(num - 1, clone: false);
				Machine machine;
				if (5u != 0)
				{
					machine = configurationMachine;
				}
				if (machine != null)
				{
					if (head2 == null)
					{
						ScmGroup.XCam.MachiningDataModel.Head head3 = new ScmGroup.XCam.MachiningDataModel.Head();
						if (3u != 0)
						{
							head2 = head3;
						}
					}
					head2.MachineName = machine.Name;
					int result = 0;
					int.TryParse(head, out result);
					if (result >= 10000)
					{
						head2.HeadsGroupNumber = result / 1000 % 10;
						head2.HeadsGroupType = (TypeOfHeadsGroup)(result / 10000);
						head2.MachiningSpindle = result % 100;
						head2.Number = result / 100 % 10;
					}
				}
			}
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D, activeParameters.Workplane.ReferenceKey, approachSecurityPlane, retractSecurityPlane);
			Tuple<BaseApproachStrategy, BaseRetractStrategy> tuple = _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(activeParameters.LeadInOut, inputSpeed);
			Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(-1.0, speed);
			object airBlowerHeight = _0023_003Dzd_6vS81LHZfQ(airBlowerParameters.Height);
			object airBlowerDistanceFromProfile = _0023_003Dzd_6vS81LHZfQ(airBlowerParameters.DistanceFromProfile);
			bool flag = isMachiningSameDirection;
			SideType sideOfFeature = _0023_003DzhpRU1EUKegRQ(toolCorrection);
			bool flag2 = false;
			bool flag3 = _0023_003DzaqRkLCrDhUFH(isCncCompensation, activeParameters.WorkPlaneCategory);
			ReferenceToolKey referenceToolKey = null;
			if (coreTool2 != null)
			{
				referenceToolKey = new ReferenceToolKey(coreTool2.Key, coreTool2.Name);
			}
			if (referenceToolKey == null)
			{
				_0023_003DzuJOUyAMySoAB(base.Name, description, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704059), tool);
			}
			double builderHeadRotation = GetBuilderHeadRotation(geomGeometry, referenceToolKey, activeParameters.Workpiece.ReferenceKey);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan: false, coreTool2, head2, feature);
			bool flag4 = false;
			if (_0023_003DzG8Zotvn1K1ss53uTM0zGDBXnQ3ejqff7JA_003D_003D(activeParameters.Strategy) != null)
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
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
			AirBlowerFeatureGeometryParameters geometryParameters = new AirBlowerFeatureGeometryParameters(context, geomGeometry);
			List<Executable> geometryWorkingsteps = _projectInterface.GetGeometryWorkingsteps(geomGeometry.Key);
			List<MachiningWorkingStep> list = new List<MachiningWorkingStep>();
			foreach (Executable item in geometryWorkingsteps)
			{
				MachiningWorkingStep machiningWorkingStep2 = item as MachiningWorkingStep;
				if (_projectInterface.Get(machiningWorkingStep2.OperationID) is EdgeBandingProcessOperation)
				{
					list.Add(machiningWorkingStep2);
				}
			}
			AirBlowerFeatureFeatureParameters airBlowerFeatureFeatureParameters = new AirBlowerFeatureFeatureParameters(context, feature, airBlowerParameters.AirBlowerType);
			AirBlowerFeatureOperationParameters airBlowerFeatureOperationParameters = new AirBlowerFeatureOperationParameters(context, operation, list);
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			airBlowerFeatureFeatureParameters.InitizializeDistanceFromProfile(airBlowerDistanceFromProfile);
			airBlowerFeatureFeatureParameters.InitializeHeight(airBlowerHeight);
			airBlowerFeatureFeatureParameters.InitializeProfile(flag);
			if (airBlowerParameters.AirBlowerType != AirBlowerType.None)
			{
				sideOfFeature = SideType.Left;
			}
			airBlowerFeatureFeatureParameters.InitializeToolCompensation(sideOfFeature, 0, flag2);
			airBlowerFeatureOperationParameters.InitializeApproach(tuple.Item1);
			airBlowerFeatureOperationParameters.InitializeCNMode(flag3);
			airBlowerFeatureOperationParameters.InitializeHead(head2);
			airBlowerFeatureOperationParameters.InitializeHeadRotation(builderHeadRotation);
			airBlowerFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			airBlowerFeatureOperationParameters.InitializeRetract(tuple.Item2);
			airBlowerFeatureOperationParameters.InitializeSafetyDistance(builderSafetyDistances.Item1, builderSafetyDistances.Item2);
			airBlowerFeatureOperationParameters.InitializeTechnology(referenceToolKey, builderTechnologySpeeds.Item2, builderTechnologySpeeds.Item1);
			workingStepParameters.InitializeDescription(description);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			AirBlowerFeatureBuilder airBlowerFeatureBuilder = new AirBlowerFeatureBuilder(context);
			airBlowerFeatureBuilder.InitializeGeometry(geometryParameters);
			airBlowerFeatureBuilder.InitializeFeature(airBlowerFeatureFeatureParameters);
			airBlowerFeatureBuilder.InitializeOperation(airBlowerFeatureOperationParameters);
			airBlowerFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			airBlowerFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = airBlowerFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704037), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dz4yqdYK9mHp3S_FyDIYP8vPaAWS19kSex_0024Q_003D_003D(MillingTypeOperation _0023_003DzHuNk036Z5aIGkj0IIQ_003D_003D, LeadInOut _0023_003Dzui4D8_aBQtar, double _0023_003DzksrR6KQfs_Ff)
	{
		try
		{
			bool isEnabled;
			if (8u != 0)
			{
				isEnabled = false;
			}
			double num;
			if (uint.MaxValue != 0)
			{
				num = _0023_003DzksrR6KQfs_Ff;
			}
			double radiusMultiplier;
			if (8u != 0)
			{
				radiusMultiplier = 1.0;
			}
			ModeOfApproach approachMode;
			if (8u != 0)
			{
				approachMode = ModeOfApproach.Down;
			}
			TypeOfApproachRetract approachType;
			if (6u != 0)
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

	private void _0023_003DzuJOUyAMySoAB(string _0023_003DzJ3hfjPs_003D, string _0023_003DzrziU4i4_003D, string _0023_003DzTgF4RrM_003D, string _0023_003DzqmiDBVY_003D)
	{
		string empty = string.Empty;
		string text;
		if (8u != 0)
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
			if (3u != 0)
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

	public void CheckExpression(string propertyName, object propertyValue)
	{
		if (!StringUtility.IsValid(propertyName))
		{
			return;
		}
		MachiningWorkingStepData machiningWorkingStepData = _projectInterface.GetMachiningWorkingStepData(base.ReferenceKey);
		MachiningWorkingStepData machiningWorkingStepData2 = default(MachiningWorkingStepData);
		if (0 == 0)
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
				if (true)
				{
					key2 = key;
				}
				CompositeField compositeField = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703853));
				PropertyField property;
				if (4u != 0)
				{
					property = compositeField;
				}
				_projectInterface.CheckExpressions(key2, property, propertyValue);
				CompositeField compositeField2 = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703838));
				if (8u != 0)
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
		_ = 6;
		if (4 == 0)
		{
		}
		ToolInterface toolInterface = _toolInterface;
		_ = 2;
		if (1 == 0)
		{
		}
		return toolInterface.Get(_0023_003DzlCSVU0o_003D);
	}

	private Tuple<BaseApproachStrategy, BaseRetractStrategy> _0023_003DzrWbJ59ccKyojlw_0024YqRMHnUGJFmFE(LeadInOut _0023_003Dzui4D8_aBQtar, double _0023_003DzksrR6KQfs_Ff)
	{
		Tuple<BaseApproachStrategy, BaseRetractStrategy> result;
		if (true)
		{
			result = null;
		}
		try
		{
			bool isEnabled;
			if (6u != 0)
			{
				isEnabled = false;
			}
			double speed;
			if (5u != 0)
			{
				speed = _0023_003DzksrR6KQfs_Ff;
			}
			double radiusMultiplier;
			if (true)
			{
				radiusMultiplier = 1.0;
			}
			ModeOfApproach approachMode;
			if (5u != 0)
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
			if (2u != 0)
			{
				result = SideType.Center;
			}
			break;
		case 1:
		case 13:
			if (6u != 0)
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
		_ = 0;
		if (5 == 0)
		{
		}
		if (_0023_003DzGflSo6gx3M4rkp90RA_003D_003D != 3)
		{
			_ = 5;
			if (8 == 0)
			{
			}
			if (_0023_003DzGflSo6gx3M4rkp90RA_003D_003D != 13)
			{
				_ = 7;
				if (7 == 0)
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
		if (2u != 0)
		{
			result = null;
		}
		if (_0023_003Dze06VVWU_003D != null)
		{
			if (_0023_003Dze06VVWU_003D is BidirectionalMillingStrategy)
			{
				BidirectionalMillingStrategy obj = _0023_003Dze06VVWU_003D as BidirectionalMillingStrategy;
				BidirectionalMillingStrategy bidirectionalMillingStrategy;
				if (6u != 0)
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
				if (5u != 0)
				{
					result = obj2;
				}
			}
			else if (_0023_003Dze06VVWU_003D is UnidirectionalMillingStrategy)
			{
				UnidirectionalMillingStrategy unidirectionalMillingStrategy = _0023_003Dze06VVWU_003D as UnidirectionalMillingStrategy;
				result = new UnidirectionalMilling
				{
					AllowMultiplePasses = unidirectionalMillingStrategy.AllowMultiplePasses,
					AxialCuttingDepth = unidirectionalMillingStrategy.AxialCuttingDepth,
					AxialFinishCuttingDepth = unidirectionalMillingStrategy.AxialFinishCuttingDepth,
					Overlap = 0.0
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
		}
		return result;
	}

	private double _0023_003Dzd_6vS81LHZfQ(double _0023_003DzX1WK4z0_003D)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		_ = 4;
		if (-1 == 0)
		{
		}
		return ConvertLengthToCurrentUnit(_0023_003DzX1WK4z0_003D);
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
		if (4u != 0)
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
}
