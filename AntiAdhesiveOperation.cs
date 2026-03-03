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

public class AntiAdhesiveOperation : Operation
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
				if (uint.MaxValue != 0)
				{
					machiningWorkingStep = obj;
				}
				MachiningOperation obj2 = _projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation;
				MachiningOperation machiningOperation;
				if (uint.MaxValue != 0)
				{
					machiningOperation = obj2;
				}
				uint iD = (_projectInterface.Get(machiningOperation.ToolKey) as GeneralPurposeTool).Key.ID;
				if (3u != 0)
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
				if (uint.MaxValue != 0)
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
				if (5u != 0)
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
				if (true)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (4u != 0)
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
				if (6u != 0)
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
				if (7u != 0)
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
				if (true)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (7u != 0)
				{
					manufacturingFeature = obj2;
				}
				if (!(manufacturingFeature is MachiningFeature))
				{
					return ((manufacturingFeature as ReplicateFeature).BaseFeature as MachiningFeature).Depth.StartDepth;
				}
				double startDepth = (manufacturingFeature as MachiningFeature).Depth.StartDepth;
				if (2u != 0)
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
				if (true)
				{
					machiningWorkingStep = obj;
				}
				MachiningOperation obj2 = _projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation;
				MachiningOperation machiningOperation;
				if (8u != 0)
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
				if (8u != 0)
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
				double result;
				if (6u != 0)
				{
					result = 0.0;
				}
				MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
				MachiningWorkingStep machiningWorkingStep = default(MachiningWorkingStep);
				if (0 == 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature = default(ManufacturingFeature);
				if (0 == 0)
				{
					manufacturingFeature = obj2;
				}
				if (manufacturingFeature is MillingMachiningFeature)
				{
					result = (manufacturingFeature as MillingMachiningFeature).SideOffset;
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704179);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703736) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
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
				if (8u != 0)
				{
					machiningWorkingStep = obj;
				}
				bool activateCNCCorrection = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).ActivateCNCCorrection;
				if (5u != 0)
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
				if (8u != 0)
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
				if (uint.MaxValue != 0)
				{
					machiningWorkingStep = obj;
				}
				double spindle = ((_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Technology as MillingTechnology).Spindle;
				if (true)
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

	public AntiAdhesiveOperation(OperationContext operationContext, string name, ReferenceKey workplanID)
		: base(operationContext, workplanID)
	{
		if (4u != 0)
		{
			base.Name = name;
		}
		UI00MachiningOptions obj = ((_options != null) ? _options.MachiningOptions : null);
		if (8u != 0)
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
			if (3u != 0)
			{
				num = 0;
			}
			while (num < _0023_003Dz6oCO56s_003D.Count)
			{
				_0023_003Dz6oCO56s_003D[num].Value.ElementKey = geomCompositeCurve.Elements[_0023_003Dz6oCO56s_003D[num].Index].Key;
				_0023_003DzIDjFPYA_003D.Attributes.Add(_0023_003Dz6oCO56s_003D[num].Value);
				int num2 = num + 1;
				if (5u != 0)
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

	public void CreateAntiAdhesiveOperation(ActiveProgramParameters activeParameters, AntiAdhesiveOperationParameters antiAdhesiveParameters, string description, double? approachSecurityPlane, double? retractSecurityPlane)
	{
		try
		{
			ScmGroup.XCam.MachiningDataModel.AntiAdhesiveOperation antiAdhesiveOperation = new ScmGroup.XCam.MachiningDataModel.AntiAdhesiveOperation();
			ScmGroup.XCam.MachiningDataModel.AntiAdhesiveOperation antiAdhesiveOperation2;
			if (2u != 0)
			{
				antiAdhesiveOperation2 = antiAdhesiveOperation;
			}
			AntiAdhesiveFeature antiAdhesiveFeature = new AntiAdhesiveFeature();
			AntiAdhesiveFeature feature;
			if (7u != 0)
			{
				feature = antiAdhesiveFeature;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (uint.MaxValue != 0)
			{
				workingStep = machiningWorkingStep;
			}
			CoreTool coreTool = _0023_003DzCP7__0024l7ucReU(antiAdhesiveParameters.Tool);
			CoreTool coreTool2;
			if (2u != 0)
			{
				coreTool2 = coreTool;
			}
			ReferenceToolKey referenceToolKey;
			if (true)
			{
				referenceToolKey = null;
			}
			if (coreTool2 != null)
			{
				ReferenceToolKey referenceToolKey2 = new ReferenceToolKey(coreTool2.Key, coreTool2.Name);
				if (uint.MaxValue != 0)
				{
					referenceToolKey = referenceToolKey2;
				}
			}
			if (referenceToolKey == null)
			{
				string name = base.Name;
				string _0023_003DzTgF4RrM_003D = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704548);
				string tool = antiAdhesiveParameters.Tool;
				if (5u != 0)
				{
					_0023_003DzuJOUyAMySoAB(name, description, _0023_003DzTgF4RrM_003D, tool);
				}
			}
			bool flag;
			if (6u != 0)
			{
				flag = false;
			}
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry = default(GeomGeometry);
			if (0 == 0)
			{
				geomGeometry = obj;
			}
			if (geomGeometry is GeomCompositeCurve)
			{
				if ((geomGeometry as GeomCompositeCurve).Elements.Count > 0)
				{
					flag = true;
				}
			}
			else if (geomGeometry is GeomTrimmedCurve)
			{
				flag = true;
			}
			if (flag)
			{
				_0023_003Dz_hR6lSynO7nq(geomGeometry, antiAdhesiveOperation2, activeParameters.Attributes);
			}
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
			AntiAdhesiveTool _0023_003DzWt60SS3MTAzGBDROBZZZvTU_003D = (_toolInterface.Get(referenceToolKey) as GeneralPurposeTool).ToolBody as AntiAdhesiveTool;
			Tuple<object, object> builderTechnologySpeeds = GetBuilderTechnologySpeeds(antiAdhesiveParameters.RotSpeed, antiAdhesiveParameters.Speed);
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(antiAdhesiveParameters.Head);
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(antiAdhesiveParameters.Head, configHead, activeParameters.MachineID);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan: false, coreTool2, builderHead, feature);
			double num = 0.0;
			if (approachSecurityPlane.HasValue)
			{
				num = approachSecurityPlane.Value;
			}
			double num2 = 0.0;
			if (retractSecurityPlane.HasValue)
			{
				num2 = retractSecurityPlane.Value;
			}
			POMContext context = new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface);
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializeDescription(description);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			AntiAdhesiveFeatureFeatureParameters antiAdhesiveFeatureFeatureParameters = new AntiAdhesiveFeatureFeatureParameters(context, feature);
			antiAdhesiveFeatureFeatureParameters.InitializeDepth(0, 0, new ThroughMillingBottom());
			antiAdhesiveFeatureFeatureParameters.InitializeToolCompensation(SideType.Left, antiAdhesiveParameters.OverMaterial, false);
			antiAdhesiveFeatureFeatureParameters.InitializeToolApproach(TypeOfToolApproach.NormalLeft);
			antiAdhesiveFeatureFeatureParameters.InitizializeAntiAdhesiveType(antiAdhesiveParameters.AntiAdhesiveType);
			AntiAdhesiveFeatureOperationParameters antiAdhesiveFeatureOperationParameters = new AntiAdhesiveFeatureOperationParameters(context, antiAdhesiveOperation2, list);
			antiAdhesiveFeatureOperationParameters.InitializeCNMode(false);
			antiAdhesiveFeatureOperationParameters.InitializeSafetyDistance(num, num2);
			antiAdhesiveFeatureOperationParameters.InitializeHead(builderHead);
			antiAdhesiveFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			antiAdhesiveFeatureOperationParameters.InitializeTechnology(referenceToolKey, builderTechnologySpeeds.Item2, builderTechnologySpeeds.Item1);
			AntiadhesiveApproachStrategy antiadhesiveApproachStrategy = new AntiadhesiveApproachStrategy
			{
				Angle = MathUtility.ConvertToRadians(antiAdhesiveParameters.ApproachAngle),
				InfeedSectionAdvance = antiAdhesiveParameters.InfeedAdvance
			};
			AntiadhesiveRetractStrategy antiadhesiveRetractStrategy = new AntiadhesiveRetractStrategy
			{
				OutfeedSectionDelay = antiAdhesiveParameters.OutfeedDelay,
				Angle = antiAdhesiveParameters.RetractAngle
			};
			_0023_003DzMe1s_0024L4Wcv5aTDz8Z9rcjZJ4sL8j0svNrT66c1pE0_0024D1(antiadhesiveApproachStrategy, antiadhesiveRetractStrategy, _0023_003DzWt60SS3MTAzGBDROBZZZvTU_003D);
			antiAdhesiveFeatureOperationParameters.InitializeApproach(antiadhesiveApproachStrategy);
			antiAdhesiveFeatureOperationParameters.InitializeRetract(antiadhesiveRetractStrategy);
			antiAdhesiveFeatureOperationParameters.InitializeExtraDepth(antiAdhesiveParameters.OverMaterial);
			AntiAdhesiveFeatureGeometryParameters geometryParameters = new AntiAdhesiveFeatureGeometryParameters(context, geomGeometry);
			AntiAdhesiveFeatureBuilder antiAdhesiveFeatureBuilder = new AntiAdhesiveFeatureBuilder(context);
			antiAdhesiveFeatureBuilder.InitializeFeature(antiAdhesiveFeatureFeatureParameters);
			antiAdhesiveFeatureBuilder.InitializeGeometry(geometryParameters);
			antiAdhesiveFeatureBuilder.InitializeOperation(antiAdhesiveFeatureOperationParameters);
			antiAdhesiveFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			antiAdhesiveFeatureBuilder.Add(_workplanID, activeParameters.Workpiece.ReferenceKey, activeParameters.Workplane.ReferenceKey, -1);
			base.ReferenceKey = antiAdhesiveFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704524), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003DzMe1s_0024L4Wcv5aTDz8Z9rcjZJ4sL8j0svNrT66c1pE0_0024D1(AntiadhesiveApproachStrategy _0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D, AntiadhesiveRetractStrategy _0023_003DzVmargbixKugD, AntiAdhesiveTool _0023_003DzWt60SS3MTAzGBDROBZZZvTU_003D)
	{
		if (_0023_003DzWt60SS3MTAzGBDROBZZZvTU_003D != null)
		{
			double verticalCopying = _0023_003DzWt60SS3MTAzGBDROBZZZvTU_003D.VerticalCopying;
			double verticalCopying2;
			if (8u != 0)
			{
				verticalCopying2 = verticalCopying;
			}
			_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.VerticalCopying = verticalCopying2;
			_0023_003DzVmargbixKugD.VerticalCopying = verticalCopying2;
			_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.Angle = _options.AntiAdhesiveOptions.AntiAdhesiveApproachAngle;
			_0023_003DzOM8_zIPyX0oR4_0024S8Xg_003D_003D.InfeedSectionAdvance = _options.AntiAdhesiveOptions.AntiAdhesiveInfeedSectionAdvance;
			_0023_003DzVmargbixKugD.OutfeedSectionDelay = _options.AntiAdhesiveOptions.AntiAdhesiveOutfeedSectionDelay;
			_0023_003DzVmargbixKugD.Angle = _options.AntiAdhesiveOptions.AntiAdhesiveRetractAngle;
		}
	}

	private void _0023_003DzuJOUyAMySoAB(string _0023_003DzJ3hfjPs_003D, string _0023_003DzrziU4i4_003D, string _0023_003DzTgF4RrM_003D, string _0023_003DzqmiDBVY_003D)
	{
		string empty = string.Empty;
		string text;
		if (6u != 0)
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
			if (true)
			{
				text = text2;
			}
		}
		string errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703888), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzqmiDBVY_003D, _0023_003DzJ3hfjPs_003D, text, _0023_003DzTgF4RrM_003D);
		if (true)
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
		if (3u != 0)
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
				if (uint.MaxValue != 0)
				{
					key2 = key;
				}
				CompositeField compositeField = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703853));
				PropertyField property;
				if (true)
				{
					property = compositeField;
				}
				_projectInterface.CheckExpressions(key2, property, propertyValue);
				CompositeField compositeField2 = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703838));
				if (uint.MaxValue != 0)
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
		_ = 4;
		if (false)
		{
		}
		ToolInterface toolInterface = _toolInterface;
		_ = 2;
		if (6 == 0)
		{
		}
		return toolInterface.Get(_0023_003DzlCSVU0o_003D);
	}

	private double _0023_003Dzd_6vS81LHZfQ(double _0023_003DzX1WK4z0_003D)
	{
		_ = 7;
		if (6 == 0)
		{
		}
		_ = 0;
		if (4 == 0)
		{
		}
		return ConvertLengthToCurrentUnit(_0023_003DzX1WK4z0_003D);
	}

	private double _0023_003DzH1tQYnLqOUsq(double _0023_003DzbDCdcxRsxdCG)
	{
		_ = 1;
		if (4 == 0)
		{
		}
		_ = 1;
		if (4 == 0)
		{
		}
		return ConvertLengthToCurrentUnit(_0023_003DzbDCdcxRsxdCG);
	}

	private bool _0023_003DzaqRkLCrDhUFH(bool _0023_003DzqydnvRs20KT_0024, WorkPlaneCategory _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D)
	{
		bool result;
		if (true)
		{
			result = _0023_003DzqydnvRs20KT_0024;
		}
		bool num = _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.CYFLEX_HP2 || _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.CYFLEX_F1300 || _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.CYFLEX_F900;
		bool num2 = _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.UNIFLEX_HP || _0023_003DzFCfyb9GkUXk_xXGFLg_003D_003D == WorkPlaneCategory.UNIFLEX_S;
		bool flag;
		if (8u != 0)
		{
			flag = num2;
		}
		if (num || flag)
		{
			if (7u != 0)
			{
				result = false;
			}
		}
		return result;
	}

	private void _0023_003Dz_0024zl8vUimxVkPXPvJgYbKbFE_003D(MachiningOperation _0023_003DzIDjFPYA_003D, int _0023_003Dzq_0024W2yCc_003D, string _0023_003DzYEQjc18_003D, int _0023_003Dznv8znP1vlgf_0024)
	{
		ScmGroup.XCam.MachiningDataModel.Head head;
		if (2u != 0)
		{
			head = null;
		}
		if (_0023_003Dznv8znP1vlgf_0024 >= 3)
		{
			ScmGroup.XCam.MachiningDataModel.Head head2 = new ScmGroup.XCam.MachiningDataModel.Head(_0023_003Dznv8znP1vlgf_0024, TypeOfHead.None);
			if (true)
			{
				head = head2;
			}
		}
		if (_0023_003Dzq_0024W2yCc_003D > 0 && _configurationInterface != null)
		{
			Machine configurationMachine = _configurationInterface.GetConfigurationMachine(_0023_003Dzq_0024W2yCc_003D - 1, clone: false);
			Machine machine;
			if (uint.MaxValue != 0)
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
