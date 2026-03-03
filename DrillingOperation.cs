using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Drilling;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Parametrics;
using ScmGroup.XCam.MachiningDataModel.Patterns;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Common;
using ScmGroup.XCam.ToolDataModel.Tool;

namespace ScmGroup.XCam.Scripting;

public class DrillingOperation : Operation
{
	private UI00MachiningOptions _0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D;

	private ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation _0023_003DzGM5j0nPptPvF;

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
				MachiningOperation machiningOperation = default(MachiningOperation);
				if (0 == 0)
				{
					machiningOperation = obj2;
				}
				if (!machiningOperation.ToolKey.IsValid)
				{
					return 0u;
				}
				uint iD = (_projectInterface.Get(machiningOperation.ToolKey) as CoreTool).Key.ID;
				if (true)
				{
					return iD;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
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
				if (true)
				{
					machiningWorkingStep = obj;
				}
				int spindleNumber = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).Head.SpindleNumber;
				if (6u != 0)
				{
					return spindleNumber;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
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
				if (5u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (8u != 0)
				{
					manufacturingFeature = obj2;
				}
				GeomGeometry obj3 = _projectInterface.Get(manufacturingFeature.GeometryID) as GeomGeometry;
				GeomGeometry geomGeometry;
				if (3u != 0)
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
				return null;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
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
				if (true)
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
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
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
				MachiningWorkingStep machiningWorkingStep = default(MachiningWorkingStep);
				if (0 == 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (4u != 0)
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
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
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
				if (6u != 0)
				{
					machiningOperation = obj2;
				}
				if (!(machiningOperation.ToolKey != null))
				{
					ManufacturingFeature manufacturingFeature = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
					if (manufacturingFeature is RoundHole)
					{
						return (manufacturingFeature as RoundHole).Diameter;
					}
					return ((manufacturingFeature as ReplicateFeature).BaseFeature as RoundHole).Diameter;
				}
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(machiningOperation.ToolKey, KindOfToolProperty.Diameter).Value);
				if (3u != 0)
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

	public override double ToolOffset => 0.0;

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
				if (uint.MaxValue != 0)
				{
					return activateCNCCorrection;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
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
				if (6u != 0)
				{
					machiningWorkingStep = obj;
				}
				double approachSecurityPlane = (_projectInterface.Get(machiningWorkingStep.OperationID) as MachiningOperation).ApproachSecurityPlane;
				if (6u != 0)
				{
					return approachSecurityPlane;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
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
				if (uint.MaxValue != 0)
				{
					return spindle;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703799);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703923) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override bool IsNCFunction => false;

	public DrillingOperation(OperationContext operationContext, string name, ReferenceKey workplanID)
		: base(operationContext, workplanID)
	{
		if (0 == 0)
		{
			base.Name = name;
		}
		UI00MachiningOptions obj = ((_options != null) ? _options.MachiningOptions : null);
		if (7u != 0)
		{
			_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D = obj;
		}
		if (8u != 0)
		{
			_0023_003DzGM5j0nPptPvF = null;
		}
	}

	public void CreateDrill(ActiveProgramParameters activeParameters, double x, double y, double depth, double diameter, string description, TypeOfProcess typeOfProcess, string tool, string head, int dischargeSteps, double rotSpeed, double boringSpeed, string kindOfHole = "-1", double taperHeight = 0.0, double? approachSecurityPlane = null, double? retractSecurityPlane = null, double holeTaperDiameter = 0.0)
	{
		try
		{
			GeomCartesianPoint geomCartesianPoint = new GeomCartesianPoint(x, y, 0.0);
			GeomGeometry geometry;
			if (5u != 0)
			{
				geometry = geomCartesianPoint;
			}
			geometry.IsAbsolute = false;
			geometry.ReferencePosition = (ReferencePositionType)activeParameters.ReferencePosition;
			RoundHole roundHole = new RoundHole();
			ManufacturingFeature feature;
			if (2u != 0)
			{
				feature = roundHole;
			}
			ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation drillingOperation = new ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (6u != 0)
			{
				operation = drillingOperation;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (true)
			{
				workingStep = machiningWorkingStep;
			}
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2;
			if (8u != 0)
			{
				referenceKey2 = referenceKey;
			}
			ReferenceKey referenceKey3 = activeParameters.Workplane.ReferenceKey;
			WorkPiece _0023_003Dzg7k33EXKxxyV = _projectInterface.Get(referenceKey2) as WorkPiece;
			_projectInterface.SetGeometryPlane(ref geometry, referenceKey3);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			Pattern pattern = activeParameters.Pattern;
			if (pattern == null)
			{
				_0023_003Dz9i4ZP2c_003D(activeParameters, operation as ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation, feature, geometry, referenceKey2, head, tool, dischargeSteps, rotSpeed, boringSpeed, approachSecurityPlane, retractSecurityPlane, 0.0);
				_0023_003DzSQ9Y3bPQEBy2(feature as RoundHole, base.Name, diameter, depth, kindOfHole, taperHeight, holeTaperDiameter, (operation as MachiningOperation).ToolKey, referenceKey3, _0023_003Dzg7k33EXKxxyV);
				_0023_003DzFT5wwJr8rHer(workingStep, base.Name, description);
				workingStep.Priority = activeParameters.Priority;
				_projectInterface.InsertAtWorkingStep(ref geometry, ref feature, ref operation, ref workingStep, referenceKey3, _workplanID, referenceKey2, -1, this);
				base.ReferenceKey = workingStep.Key;
			}
			else
			{
				_0023_003Dz9i4ZP2c_003D(activeParameters, operation as ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation, feature, geometry, referenceKey2, head, tool, dischargeSteps, rotSpeed, boringSpeed, approachSecurityPlane, retractSecurityPlane, 0.0);
				_0023_003DzSQ9Y3bPQEBy2(feature as RoundHole, base.Name, diameter, depth, kindOfHole, taperHeight, holeTaperDiameter, (operation as MachiningOperation).ToolKey, referenceKey3, _0023_003Dzg7k33EXKxxyV);
				ManufacturingFeature feature2 = new ReplicateFeature();
				_0023_003Dz6Jm_7Lu2PevhAznYM208Y_0024w_003D(feature2 as ReplicateFeature, feature as RoundHole, pattern, geometry.ReferencePosition);
				_0023_003DzFT5wwJr8rHer(workingStep, base.Name, description);
				workingStep.Priority = activeParameters.Priority;
				_projectInterface.InsertAtWorkingStep(ref geometry, ref feature2, ref operation, ref workingStep, referenceKey3, _workplanID, referenceKey2, -1, this);
				base.ReferenceKey = workingStep.Key;
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703533), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateThroughDrill(ActiveProgramParameters activeParameters, double x, double y, double diameter, double overcutLength, string description, TypeOfProcess typeOfProcess, string tool, string head, int dischargeSteps, double rotSpeed, double boringSpeed, string kindOfHole = "-1", double taperHeight = 0.0, double? approachSecurityPlane = null, double? retractSecurityPlane = null, double holeTaperDiameter = 0.0)
	{
		try
		{
			GeomCartesianPoint geomCartesianPoint = new GeomCartesianPoint(x, y, 0.0);
			GeomGeometry geometry;
			if (2u != 0)
			{
				geometry = geomCartesianPoint;
			}
			geometry.IsAbsolute = false;
			geometry.ReferencePosition = (ReferencePositionType)activeParameters.ReferencePosition;
			RoundHole roundHole = new RoundHole();
			ManufacturingFeature feature;
			if (4u != 0)
			{
				feature = roundHole;
			}
			ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation drillingOperation = new ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (2u != 0)
			{
				operation = drillingOperation;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep = default(MachiningWorkingStep);
			if (0 == 0)
			{
				workingStep = machiningWorkingStep;
			}
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2;
			if (3u != 0)
			{
				referenceKey2 = referenceKey;
			}
			ReferenceKey referenceKey3 = activeParameters.Workplane.ReferenceKey;
			string text = _0023_003Dzg3WPFAiHoTsD(referenceKey2, referenceKey3);
			_projectInterface.SetGeometryPlane(ref geometry, referenceKey3);
			_projectInterface.ConvertGeometryToReferencePosition(geometry);
			Pattern pattern = activeParameters.Pattern;
			if (pattern == null)
			{
				_0023_003Dz9i4ZP2c_003D(activeParameters, operation as ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation, feature, geometry, referenceKey2, head, tool, dischargeSteps, rotSpeed, boringSpeed, approachSecurityPlane, retractSecurityPlane, overcutLength);
				_0023_003DziaickNpKko_P(feature as RoundHole, base.Name, diameter, kindOfHole, taperHeight, holeTaperDiameter, (operation as MachiningOperation).ToolKey, text);
				_0023_003DzFT5wwJr8rHer(workingStep, base.Name, description);
				workingStep.Priority = activeParameters.Priority;
				_projectInterface.InsertAtWorkingStep(ref geometry, ref feature, ref operation, ref workingStep, referenceKey3, _workplanID, referenceKey2, -1, this);
				base.ReferenceKey = workingStep.Key;
			}
			else
			{
				_0023_003Dz9i4ZP2c_003D(activeParameters, operation as ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation, feature, geometry, referenceKey2, head, tool, dischargeSteps, rotSpeed, boringSpeed, approachSecurityPlane, retractSecurityPlane, overcutLength);
				_0023_003DziaickNpKko_P(feature as RoundHole, base.Name, diameter, kindOfHole, taperHeight, holeTaperDiameter, (operation as MachiningOperation).ToolKey, text);
				ManufacturingFeature feature2 = new ReplicateFeature();
				_0023_003Dz6Jm_7Lu2PevhAznYM208Y_0024w_003D(feature2 as ReplicateFeature, feature as RoundHole, pattern, geometry.ReferencePosition);
				_0023_003DzFT5wwJr8rHer(workingStep, base.Name, description);
				workingStep.Priority = activeParameters.Priority;
				_projectInterface.InsertAtWorkingStep(ref geometry, ref feature2, ref operation, ref workingStep, referenceKey3, _workplanID, referenceKey2, -1, this);
				base.ReferenceKey = workingStep.Key;
			}
			CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), text);
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703533), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private string _0023_003Dzg3WPFAiHoTsD(ReferenceKey _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D, ReferenceKey _0023_003DzaUMBEK4UtVU_)
	{
		WorkPiece obj = _projectInterface.Get(_0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D) as WorkPiece;
		WorkPiece workPiece;
		if (5u != 0)
		{
			workPiece = obj;
		}
		Plane obj2 = _projectInterface.Get(_0023_003DzaUMBEK4UtVU_) as Plane;
		Plane plane;
		if (6u != 0)
		{
			plane = obj2;
		}
		if (!plane.IsStandard)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703492);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (5u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Error, null, parameters);
			}
		}
		string result = workPiece.DepthName;
		if (plane.IsStandard)
		{
			switch (plane.Type)
			{
			case PlaneType.Left:
			case PlaneType.Right:
				result = workPiece.LengthName;
				break;
			case PlaneType.Front:
			case PlaneType.Back:
				result = workPiece.WidthName;
				break;
			}
		}
		return result;
	}

	public void CreateSlantedDrill(ActiveProgramParameters activeParameters, double x, double y, double z, double angleA, double angleB, double depth, double diameter, string description, TypeOfProcess typeOfProcess, string tool, string head, int dischargeSteps, double rotSpeed, double boringSpeed, string kindOfHole = "-1", double taperHeight = 0.0, double? approachSecurityPlane = null, double? retractSecurityPlane = null, double holeTaperDiameter = 0.0)
	{
		try
		{
			GeomCartesianPoint geomCartesianPoint = new GeomCartesianPoint(x, y, z);
			GeomGeometry geometry;
			if (uint.MaxValue != 0)
			{
				geometry = geomCartesianPoint;
			}
			geometry.IsAbsolute = true;
			SlantedRoundHole slantedRoundHole = new SlantedRoundHole();
			ManufacturingFeature feature;
			if (4u != 0)
			{
				feature = slantedRoundHole;
			}
			ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation drillingOperation = new ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation();
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (2u != 0)
			{
				operation = drillingOperation;
			}
			MachiningWorkingStep workingStep = new MachiningWorkingStep();
			Workpiece workpiece = activeParameters.Workpiece;
			ReferenceKey referenceKey = workpiece.ReferenceKey;
			if (activeParameters.Pattern == null)
			{
				_0023_003Dz9i4ZP2c_003D(activeParameters, operation as ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation, feature, geometry, referenceKey, head, tool, dischargeSteps, rotSpeed, boringSpeed, approachSecurityPlane, retractSecurityPlane, 0.0);
				_0023_003DzBaHGwqIDP1EDZTclQi34xx0_003D(feature as SlantedRoundHole, base.Name, diameter, depth, kindOfHole, angleA, angleB, taperHeight, holeTaperDiameter, (operation as MachiningOperation).ToolKey);
				_0023_003DzFT5wwJr8rHer(workingStep, base.Name, description);
				workingStep.Priority = activeParameters.Priority;
				_projectInterface.InsertAtWorkingStep(ref geometry, ref feature, ref operation, ref workingStep, null, _workplanID, workpiece.ReferenceKey, -1, this);
				base.ReferenceKey = workingStep.Key;
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703533), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dz9i4ZP2c_003D(ActiveProgramParameters _0023_003DzlG_0024kGXwbOn7X, ScmGroup.XCam.MachiningDataModel.Drilling.DrillingOperation _0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D, ManufacturingFeature _0023_003Dza6VqrSU_003D, GeomGeometry _0023_003DzjDpg_oE_003D, ReferenceKey _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D, string _0023_003DzYEQjc18_003D, string _0023_003DzqmiDBVY_003D, int _0023_003Dzr8iEI4WGW67nxtwbTA_003D_003D, double _0023_003DzVHemytquQzbF, double _0023_003Dz_cGaxh6Tx5JXRX9EAw_003D_003D, double? _0023_003DzcBMrs66qS2hN60yeJE_0024SrWQ_003D, double? _0023_003Dzo_C3LN9FaDgFMe5ui2mr0rk_003D, double _0023_003Dzew61mfQaFVnRmlBRjw_003D_003D)
	{
		try
		{
			int headNumber;
			if (5u != 0)
			{
				headNumber = 0;
			}
			ReferenceToolKey refToolKey;
			if (7u != 0)
			{
				refToolKey = null;
			}
			_toolInterface.GetToolHeadInfo(_0023_003DzYEQjc18_003D, _0023_003DzqmiDBVY_003D, ref headNumber, ref refToolKey);
			_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.ToolKey = refToolKey;
			_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.ReferencePoint = (TypeOfReferencePoint)_0023_003DzlG_0024kGXwbOn7X.ProbingReferencePoint;
			ScmGroup.XCam.MachiningDataModel.Head machiningHead;
			if (6u != 0)
			{
				machiningHead = null;
			}
			CoreTool coreTool = _toolInterface.Get(refToolKey);
			CoreTool coreTool2;
			if (2u != 0)
			{
				coreTool2 = coreTool;
			}
			if (headNumber > -1)
			{
				ScmGroup.XCam.MachiningDataModel.Head head = _0023_003DztXbbpgz4jnZGKanYfkSMUsw_003D(_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D, coreTool2, headNumber);
				if (5u != 0)
				{
					machiningHead = head;
				}
			}
			int machineID = _0023_003DzlG_0024kGXwbOn7X.MachineID;
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
					if (_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head == null)
					{
						_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head = new ScmGroup.XCam.MachiningDataModel.Head();
					}
					_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head.MachineName = machine.Name;
				}
			}
			int[] spindles = _0023_003DzlG_0024kGXwbOn7X.Spindles;
			if (spindles != null && spindles.Length != 0)
			{
				if (_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head == null)
				{
					_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head = new ScmGroup.XCam.MachiningDataModel.Head();
				}
				_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head.MachiningSpindle = spindles[0];
				for (int i = 1; i < spindles.Length; i++)
				{
					if (_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head.AdditionalMachiningSpindles == null)
					{
						_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head.AdditionalMachiningSpindles = new List<int>();
					}
					_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Head.AdditionalMachiningSpindles.Add(spindles[i]);
				}
			}
			Strategy strategy = _0023_003DzlG_0024kGXwbOn7X.Strategy;
			if (_0023_003Dzr8iEI4WGW67nxtwbTA_003D_003D > 1)
			{
				_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.MachiningStrategy = new MultiStepDrilling();
				(_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.MachiningStrategy as MultiStepDrilling).IsStepDepth = false;
				(_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.MachiningStrategy as MultiStepDrilling).StepNumber = _0023_003Dzr8iEI4WGW67nxtwbTA_003D_003D;
			}
			else if (strategy != null)
			{
				if (strategy is SingleStepDrillingStrategy)
				{
					_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.MachiningStrategy = new SingleStepDrilling();
				}
				else if (strategy is MultiStepDrillingStrategy)
				{
					MultiStepDrilling multiStepDrilling = new MultiStepDrilling();
					multiStepDrilling.IsStepDepth = (strategy as MultiStepDrillingStrategy).IsStepDepth;
					multiStepDrilling.StepDepth = (strategy as MultiStepDrillingStrategy).StepDepth;
					multiStepDrilling.StepNumber = (strategy as MultiStepDrillingStrategy).StepNumber;
					_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.MachiningStrategy = multiStepDrilling;
				}
			}
			else
			{
				_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.MachiningStrategy = new SingleStepDrilling();
			}
			MillingTechnology millingTechnology = new MillingTechnology();
			millingTechnology.Spindle = ((_0023_003DzVHemytquQzbF != -1.0) ? _0023_003DzVHemytquQzbF : 0.0);
			millingTechnology.Feedrate = ((_0023_003Dz_cGaxh6Tx5JXRX9EAw_003D_003D != -1.0) ? _0023_003Dz_cGaxh6Tx5JXRX9EAw_003D_003D : 0.0);
			millingTechnology.FeedProfileName = _0023_003DzlG_0024kGXwbOn7X.FeedrateProfileName;
			_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.Technology = millingTechnology;
			_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.OvercutLength = _0023_003Dzew61mfQaFVnRmlBRjw_003D_003D;
			_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.MachineFunctions = CreateMachineFunctions(_0023_003DzlG_0024kGXwbOn7X.MachineFunctions, disableDustPan: false, coreTool2, machiningHead, _0023_003Dza6VqrSU_003D);
			CreateMachiningOperationSafetyDistances(_0023_003DzCYYtNNZUazgqnWHy6vhR7Ug_003D, _0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D, _0023_003DzlG_0024kGXwbOn7X.Workplane.ReferenceKey, _0023_003DzcBMrs66qS2hN60yeJE_0024SrWQ_003D, _0023_003Dzo_C3LN9FaDgFMe5ui2mr0rk_003D);
			_0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D.HeadRotation = CalculateHeadRotation(_0023_003DzjDpg_oE_003D, refToolKey, _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D);
			_0023_003DzGM5j0nPptPvF = _0023_003DzAiTyfUViXSaLZlhNjQ_003D_003D;
		}
		catch
		{
			throw;
		}
	}

	private void _0023_003DzSQ9Y3bPQEBy2(RoundHole _0023_003Dza6VqrSU_003D, string _0023_003DzJ3hfjPs_003D, double _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D, double _0023_003DzX1WK4z0_003D, string _0023_003Dz53v5rVQ3FWBs, double _0023_003DzAeBB7VmWS1x2, double _0023_003Dz6s_V7che4OzBddvLDg_003D_003D, ReferenceKey _0023_003Dzhuhy8D0_003D, ReferenceKey _0023_003DzaUMBEK4UtVU_, WorkPiece _0023_003Dzg7k33EXKxxyV)
	{
		try
		{
			_0023_003Dza6VqrSU_003D.Name = _0023_003DzJ3hfjPs_003D;
			_0023_003Dza6VqrSU_003D.Depth.StartDepth = _0023_003DzX1WK4z0_003D;
			_0023_003Dza6VqrSU_003D.Depth.EndDepth = _0023_003DzX1WK4z0_003D;
			FlatHoleBottom flatHoleBottom = new FlatHoleBottom();
			HoleBottom bottomCondition;
			if (4u != 0)
			{
				bottomCondition = flatHoleBottom;
			}
			if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
			{
				FlatHoleBottom flatHoleBottom2 = new FlatHoleBottom();
				if (uint.MaxValue != 0)
				{
					bottomCondition = flatHoleBottom2;
				}
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
			{
				ConicalHoleBottom conicalHoleBottom = new ConicalHoleBottom();
				if (uint.MaxValue != 0)
				{
					bottomCondition = conicalHoleBottom;
				}
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432))
			{
				double? num = _0023_003DzUJF5ujq4CdZbYdOe_0024w_003D_003D(_0023_003DzaUMBEK4UtVU_, _0023_003Dzg7k33EXKxxyV);
				double? num2;
				if (uint.MaxValue != 0)
				{
					num2 = num;
				}
				bottomCondition = ((!num2.HasValue) ? new FlatHoleBottom() : ((!(_0023_003DzX1WK4z0_003D >= num2.Value)) ? ((HoleBottom)new FlatHoleBottom()) : ((HoleBottom)new ConicalHoleBottom())));
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
			{
				bottomCondition = new FlatHoleBottom();
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672))
			{
				bottomCondition = new FlatHoleBottom();
			}
			_0023_003Dza6VqrSU_003D.BottomCondition = bottomCondition;
			double num3 = 0.0;
			if (_0023_003DzGM5j0nPptPvF != null)
			{
				num3 = _0023_003DzGM5j0nPptPvF.OvercutLength;
			}
			_0023_003Dza6VqrSU_003D.CountersinkHeight = ((_0023_003DzAeBB7VmWS1x2 > 0.0) ? (_0023_003DzX1WK4z0_003D + num3 - _0023_003DzAeBB7VmWS1x2) : 0.0);
			double diameter = _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D;
			double taperDiameter = _0023_003Dz6s_V7che4OzBddvLDg_003D_003D;
			if (_0023_003Dzhuhy8D0_003D != null && _0023_003Dzhuhy8D0_003D.IsValid)
			{
				CoreTool tool = _toolInterface.Get(_0023_003Dzhuhy8D0_003D);
				double? diameter2 = ToolMethods.GetDiameter(tool);
				if (diameter2.HasValue)
				{
					diameter = diameter2.Value;
				}
				double? num4 = null;
				if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432))
				{
					num4 = ToolMethods.GetCountersinkMaxDiameter(tool);
				}
				else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
				{
					num4 = ToolMethods.GetBlizMaxDiameter(tool);
				}
				if (num4.HasValue)
				{
					taperDiameter = num4.Value;
				}
			}
			_0023_003Dza6VqrSU_003D.Diameter = diameter;
			_0023_003Dza6VqrSU_003D.TaperDiameter = taperDiameter;
		}
		catch
		{
			throw;
		}
	}

	private void _0023_003DziaickNpKko_P(RoundHole _0023_003Dza6VqrSU_003D, string _0023_003DzJ3hfjPs_003D, double _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D, string _0023_003Dz53v5rVQ3FWBs, double _0023_003DzAeBB7VmWS1x2, double _0023_003Dz6s_V7che4OzBddvLDg_003D_003D, ReferenceKey _0023_003Dzhuhy8D0_003D, string _0023_003DznNsFY2Y_003D)
	{
		try
		{
			_0023_003Dza6VqrSU_003D.Name = _0023_003DzJ3hfjPs_003D;
			double num = _projectInterface.EvaluateExpression<double>(_0023_003DznNsFY2Y_003D, FisicalUnitType.Lenght);
			double num2;
			if (8u != 0)
			{
				num2 = num;
			}
			_0023_003Dza6VqrSU_003D.Depth.StartDepth = num2;
			_0023_003Dza6VqrSU_003D.Depth.EndDepth = num2;
			bool isFlat;
			if (3u != 0)
			{
				isFlat = false;
			}
			if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
			{
				if (true)
				{
					isFlat = true;
				}
			}
			HoleBottom bottomCondition = new ThroughHoleBottom(isFlat);
			_0023_003Dza6VqrSU_003D.BottomCondition = bottomCondition;
			double num3 = 0.0;
			if (_0023_003DzGM5j0nPptPvF != null)
			{
				num3 = _0023_003DzGM5j0nPptPvF.OvercutLength;
			}
			_0023_003Dza6VqrSU_003D.CountersinkHeight = ((_0023_003DzAeBB7VmWS1x2 > 0.0) ? (num2 + num3 - _0023_003DzAeBB7VmWS1x2) : 0.0);
			double diameter = _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D;
			if (_0023_003Dzhuhy8D0_003D != null && _0023_003Dzhuhy8D0_003D.IsValid)
			{
				CoreTool tool = _toolInterface.Get(_0023_003Dzhuhy8D0_003D);
				double? diameter2 = ToolMethods.GetDiameter(tool);
				if (diameter2.HasValue)
				{
					diameter = diameter2.Value;
				}
				double? num4 = null;
				if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432))
				{
					num4 = ToolMethods.GetCountersinkMaxDiameter(tool);
				}
				else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
				{
					num4 = ToolMethods.GetBlizMaxDiameter(tool);
				}
				if (num4.HasValue)
				{
					_ = num4.Value;
				}
			}
			_0023_003Dza6VqrSU_003D.Diameter = diameter;
			_0023_003Dza6VqrSU_003D.TaperDiameter = _0023_003Dz6s_V7che4OzBddvLDg_003D_003D;
		}
		catch
		{
			throw;
		}
	}

	private void _0023_003Dz6Jm_7Lu2PevhAznYM208Y_0024w_003D(ReplicateFeature _0023_003DzBRA497DOQOK_0024vxtPcw_003D_003D, RoundHole _0023_003DzhjbfTbpjUL8r, Pattern _0023_003DzMXGpHh0_003D, ReferencePositionType _0023_003DzDvfAHLByTesb)
	{
		try
		{
			RectangularPattern rectangularPattern = new RectangularPattern();
			RectangularPattern rectangularPattern2;
			if (true)
			{
				rectangularPattern2 = rectangularPattern;
			}
			rectangularPattern2.NumberOfColumns = _0023_003DzMXGpHh0_003D.NumberOfColumns;
			rectangularPattern2.NumberOfRows = _0023_003DzMXGpHh0_003D.NumberOfRows;
			rectangularPattern2.Spacing = _0023_003DzMXGpHh0_003D.ColumnDistance;
			rectangularPattern2.RowSpacing = _0023_003DzMXGpHh0_003D.RowDistance;
			rectangularPattern2.RotationAngle = _0023_003DzMXGpHh0_003D.RotationAngle;
			rectangularPattern2.RowLayoutAngle = _0023_003DzMXGpHh0_003D.RowLayoutAngle;
			_0023_003DzBRA497DOQOK_0024vxtPcw_003D_003D.BaseFeature = _0023_003DzhjbfTbpjUL8r;
			_0023_003DzBRA497DOQOK_0024vxtPcw_003D_003D.ReplicationPattern = rectangularPattern2;
			if (3u != 0)
			{
				_0023_003DzUPdVTFR8Lmvg7s4V0A_003D_003D(rectangularPattern2, _0023_003DzDvfAHLByTesb);
			}
		}
		catch
		{
			throw;
		}
	}

	private void _0023_003DzUPdVTFR8Lmvg7s4V0A_003D_003D(RectangularPattern _0023_003DzNVptW9TefGspp85sij81QDY_003D, ReferencePositionType _0023_003DzDvfAHLByTesb)
	{
		_ = 5;
		if (5 == 0)
		{
		}
		_ = 7;
		if (6 == 0)
		{
		}
		_0023_003DzNVptW9TefGspp85sij81QDY_003D.Update(_0023_003DzDvfAHLByTesb);
		if (4u != 0)
		{
		}
	}

	private void _0023_003DzBaHGwqIDP1EDZTclQi34xx0_003D(SlantedRoundHole _0023_003Dza6VqrSU_003D, string _0023_003DzJ3hfjPs_003D, double _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D, double _0023_003DzX1WK4z0_003D, string _0023_003Dz53v5rVQ3FWBs, double _0023_003Dzzc8h9h0_003D, double _0023_003DzjGhtUFg_003D, double _0023_003DzAeBB7VmWS1x2, double _0023_003Dz6s_V7che4OzBddvLDg_003D_003D, ReferenceKey _0023_003Dzhuhy8D0_003D)
	{
		try
		{
			_0023_003Dza6VqrSU_003D.Name = _0023_003DzJ3hfjPs_003D;
			_0023_003Dza6VqrSU_003D.Depth.StartDepth = _0023_003DzX1WK4z0_003D;
			_0023_003Dza6VqrSU_003D.Depth.EndDepth = _0023_003DzX1WK4z0_003D;
			_0023_003Dza6VqrSU_003D.AngleA = MathUtility.DegreeToRad(_0023_003Dzzc8h9h0_003D);
			_0023_003Dza6VqrSU_003D.AngleB = MathUtility.DegreeToRad(_0023_003DzjGhtUFg_003D);
			HoleBottom bottomCondition;
			if (3u != 0)
			{
				bottomCondition = null;
			}
			if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
			{
				FlatHoleBottom flatHoleBottom = new FlatHoleBottom();
				if (2u != 0)
				{
					bottomCondition = flatHoleBottom;
				}
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
			{
				ConicalHoleBottom conicalHoleBottom = new ConicalHoleBottom();
				if (5u != 0)
				{
					bottomCondition = conicalHoleBottom;
				}
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432))
			{
				ConicalHoleBottom conicalHoleBottom2 = new ConicalHoleBottom();
				if (4u != 0)
				{
					bottomCondition = conicalHoleBottom2;
				}
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
			{
				bottomCondition = new FlatHoleBottom();
			}
			else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672))
			{
				bottomCondition = new FlatHoleBottom();
			}
			_0023_003Dza6VqrSU_003D.BottomCondition = bottomCondition;
			double num = 0.0;
			if (_0023_003DzGM5j0nPptPvF != null)
			{
				num = _0023_003DzGM5j0nPptPvF.OvercutLength;
			}
			_0023_003Dza6VqrSU_003D.CountersinkHeight = ((_0023_003DzAeBB7VmWS1x2 > 0.0) ? (_0023_003DzX1WK4z0_003D + num - _0023_003DzAeBB7VmWS1x2) : 0.0);
			double diameter = _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D;
			if (_0023_003Dzhuhy8D0_003D != null && _0023_003Dzhuhy8D0_003D.IsValid)
			{
				CoreTool tool = _toolInterface.Get(_0023_003Dzhuhy8D0_003D);
				double? diameter2 = ToolMethods.GetDiameter(tool);
				if (diameter2.HasValue)
				{
					diameter = diameter2.Value;
				}
				double? num2 = null;
				if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432))
				{
					num2 = ToolMethods.GetCountersinkMaxDiameter(tool);
				}
				else if (_0023_003Dz53v5rVQ3FWBs == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
				{
					num2 = ToolMethods.GetBlizMaxDiameter(tool);
				}
				if (num2.HasValue)
				{
					_ = num2.Value;
				}
			}
			_0023_003Dza6VqrSU_003D.Diameter = diameter;
			_0023_003Dza6VqrSU_003D.TaperDiameter = _0023_003Dz6s_V7che4OzBddvLDg_003D_003D;
		}
		catch
		{
			throw;
		}
	}

	private void _0023_003DzFT5wwJr8rHer(MachiningWorkingStep _0023_003DzzC0hNtt1Av18, string _0023_003DzJ3hfjPs_003D, string _0023_003DzrziU4i4_003D)
	{
		try
		{
			_ = -1;
			if (5 == 0)
			{
			}
			_ = 2;
			if (1 == 0)
			{
			}
			_0023_003DzzC0hNtt1Av18.Name = _0023_003DzJ3hfjPs_003D;
			_ = 4;
			if (8 == 0)
			{
			}
			_0023_003DzzC0hNtt1Av18.IsEnabled = true;
			_0023_003DzzC0hNtt1Av18.Description = _0023_003DzrziU4i4_003D;
		}
		catch
		{
			throw;
		}
	}

	private ScmGroup.XCam.MachiningDataModel.Head _0023_003DztXbbpgz4jnZGKanYfkSMUsw_003D(MachiningOperation _0023_003DzIDjFPYA_003D, CoreTool _0023_003DzvjU8OKKeP9ZZS60vsA_003D_003D, int _0023_003Dznv8znP1vlgf_0024)
	{
		ScmGroup.XCam.MachiningDataModel.Head head;
		if (4u != 0)
		{
			head = null;
		}
		try
		{
			if (_0023_003DzvjU8OKKeP9ZZS60vsA_003D_003D != null)
			{
				XilogToolKey obj = _0023_003DzvjU8OKKeP9ZZS60vsA_003D_003D.GetToolKey() as XilogToolKey;
				XilogToolKey xilogToolKey;
				if (2u != 0)
				{
					xilogToolKey = obj;
				}
				if (xilogToolKey != null)
				{
					if (xilogToolKey.KindOfTool == XilogToolKey.KindOfOriginTool.XilogBoringUnitTool)
					{
						if (_configurationInterface == null)
						{
							if (_0023_003Dznv8znP1vlgf_0024 > 0 && _0023_003Dznv8znP1vlgf_0024 < 3)
							{
								ScmGroup.XCam.MachiningDataModel.Head head2 = new ScmGroup.XCam.MachiningDataModel.Head(_0023_003Dznv8znP1vlgf_0024, TypeOfHead.None);
								if (5u != 0)
								{
									head = head2;
								}
							}
						}
						else
						{
							BoringHead boringHead = _configurationInterface.GetHead(_0023_003Dznv8znP1vlgf_0024, clone: false) as BoringHead;
							if (boringHead == null)
							{
								if (_configurationInterface.BRCHeadExists())
								{
									boringHead = _configurationInterface.GetBRCBoringHead();
								}
								else if (_configurationInterface.BoringHeadExists())
								{
									boringHead = _configurationInterface.GetBoringHead();
								}
							}
							if (boringHead != null)
							{
								head = new ScmGroup.XCam.MachiningDataModel.Head(boringHead.HeadNumber, TypeOfHead.None);
							}
						}
					}
					else if (xilogToolKey.KindOfTool == XilogToolKey.KindOfOriginTool.XilogSpindleUnitTool && _0023_003Dznv8znP1vlgf_0024 >= 3)
					{
						head = new ScmGroup.XCam.MachiningDataModel.Head(_0023_003Dznv8znP1vlgf_0024, TypeOfHead.None);
					}
				}
			}
			else if (_0023_003Dznv8znP1vlgf_0024 >= 10000)
			{
				head = new ScmGroup.XCam.MachiningDataModel.Head();
				head.HeadsGroupNumber = _0023_003Dznv8znP1vlgf_0024 / 1000 % 10;
				head.HeadsGroupType = TpaUtility.GetTypeOfHeadsGroup(_0023_003Dznv8znP1vlgf_0024);
				head.MachiningSpindle = _0023_003Dznv8znP1vlgf_0024 % 100;
				head.Number = _0023_003Dznv8znP1vlgf_0024 / 100 % 10;
			}
			_0023_003DzIDjFPYA_003D.Head = head;
			return head;
		}
		catch
		{
			throw;
		}
	}

	private double? _0023_003DzUJF5ujq4CdZbYdOe_0024w_003D_003D(ReferenceKey _0023_003DzaUMBEK4UtVU_, WorkPiece _0023_003Dzg7k33EXKxxyV)
	{
		double? result = null;
		Plane obj = _projectInterface.Get(_0023_003DzaUMBEK4UtVU_) as Plane;
		Plane plane = default(Plane);
		if (0 == 0)
		{
			plane = obj;
		}
		if (plane != null)
		{
			PlaneType type = plane.Type;
			PlaneType planeType;
			if (uint.MaxValue != 0)
			{
				planeType = type;
			}
			switch (planeType)
			{
			case PlaneType.Top:
			case PlaneType.Bottom:
				result = _0023_003Dzg7k33EXKxxyV.Depth;
				break;
			case PlaneType.Left:
			case PlaneType.Right:
				result = _0023_003Dzg7k33EXKxxyV.Length;
				break;
			case PlaneType.Front:
			case PlaneType.Back:
				result = _0023_003Dzg7k33EXKxxyV.Width;
				break;
			default:
				result = null;
				break;
			}
		}
		return result;
	}

	public void CheckExpression(string propertyName, object propertyValue)
	{
		if (!StringUtility.IsValid(propertyName))
		{
			return;
		}
		MachiningWorkingStep obj = _projectInterface.Get(base.ReferenceKey) as MachiningWorkingStep;
		MachiningWorkingStep machiningWorkingStep;
		if (7u != 0)
		{
			machiningWorkingStep = obj;
		}
		if (machiningWorkingStep == null)
		{
			return;
		}
		object obj2 = ConvertExpressionValueToCurrentFormat(propertyValue);
		object actualValue;
		if (2u != 0)
		{
			actualValue = obj2;
		}
		if (_0023_003Dz5VyKIiv_0024IAdx(propertyName))
		{
			ManufacturingFeature obj3 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
			ManufacturingFeature manufacturingFeature;
			if (uint.MaxValue != 0)
			{
				manufacturingFeature = obj3;
			}
			if (!(manufacturingFeature != null))
			{
				return;
			}
			GeomGeometry obj4 = _projectInterface.Get(manufacturingFeature.GeometryID) as GeomGeometry;
			GeomGeometry geomGeometry;
			if (2u != 0)
			{
				geomGeometry = obj4;
			}
			if (geomGeometry != null)
			{
				ReferenceKey key = geomGeometry.Key;
				ReferenceKey key2;
				if (6u != 0)
				{
					key2 = key;
				}
				PropertyField property = new PropertyField(propertyName);
				_projectInterface.CheckExpressions(key2, property, actualValue);
			}
		}
		else if (_0023_003DzjjcOfI3A_0024tft(propertyName))
		{
			ManufacturingFeature manufacturingFeature2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
			if (manufacturingFeature2 != null)
			{
				ReferenceKey key3 = manufacturingFeature2.Key;
				if (propertyName == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067))
				{
					PropertyField property2 = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703853));
					_projectInterface.CheckExpressions(key3, property2, actualValue);
					property2 = new CompositeField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703838));
					_projectInterface.CheckExpressions(key3, property2, actualValue);
				}
				else
				{
					PropertyField property3 = new PropertyField(propertyName);
					_projectInterface.CheckExpressions(key3, property3, actualValue);
				}
			}
		}
		else if (_0023_003DzP1MEygfi1zha(propertyName) && _projectInterface.Get(machiningWorkingStep.OperationID) is ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation { Key: var key4 })
		{
			PropertyField property4 = new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703661));
			_projectInterface.CheckExpressions(key4, property4, actualValue);
		}
	}

	private bool _0023_003Dz5VyKIiv_0024IAdx(string _0023_003DzvMK8Nks_003D)
	{
		bool result;
		if (uint.MaxValue != 0)
		{
			result = false;
		}
		if (_0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633))
		{
			if (uint.MaxValue != 0)
			{
				result = true;
			}
		}
		return result;
	}

	private bool _0023_003DzjjcOfI3A_0024tft(string _0023_003DzvMK8Nks_003D)
	{
		bool result;
		if (true)
		{
			result = false;
		}
		if (_0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703625) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703853) || _0023_003DzvMK8Nks_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703838))
		{
			if (8u != 0)
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
			if (6u != 0)
			{
				result = true;
			}
		}
		return result;
	}
}
