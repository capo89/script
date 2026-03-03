using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common.Referentiable;
using ScmGroup.XCam.ConfigDataModel;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.PressureRollers;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.Localization;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Milling;
using ScmGroup.XCam.MachiningDataModel.ProjectData;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Strategy;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;
using ScmGroup.XCam.ProjectObjectModel.Heads;
using ScmGroup.XCam.ToolDataModel.Common;
using ScmGroup.XCam.ToolDataModel.Tool;

namespace ScmGroup.XCam.Scripting;

public class EdgeBandingProcessOperation : Operation
{
	[Serializable]
	private sealed class _0023_003DzJBaCSp8_003D
	{
		public static readonly _0023_003DzJBaCSp8_003D _0023_003DzK15DASY_003D;

		public static Predicate<Attribute> _0023_003DzVJ2H1xQUX9G1P0WR_0024A_003D_003D;

		public static Predicate<Attribute> _0023_003DzkgF14Z9zhmkDqIbzzg_003D_003D;

		public static Predicate<MachineElementBase> _0023_003DzDysFL0ypx2rBiU3Ihg_003D_003D;

		static _0023_003DzJBaCSp8_003D()
		{
			_0023_003DzJBaCSp8_003D _0023_003DzJBaCSp8_003D = new _0023_003DzJBaCSp8_003D();
			if (7u != 0)
			{
				_0023_003DzK15DASY_003D = _0023_003DzJBaCSp8_003D;
			}
		}

		public _0023_003DzJBaCSp8_003D()
		{
			_ = 6;
			if (5 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzLLMj73Ye0mwJms_0024xeM5ZocIBnCATeMiCgA_003D_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 2;
			if (8 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.GetType() == typeof(StartPointAttribute);
		}

		internal bool _0023_003DzyuNnQcj5BPTp_0024Cfn3orcn7ZPWVywYlvhJA_003D_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 5;
			if (4 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.GetType() == typeof(EndPointAttribute);
		}

		internal bool _0023_003DzjpaEkxTtqg8GMmCz7DFikG4fmjXn2VQDrP7I15JwQ8Z2(MachineElementBase _0023_003Dz5Je4CFo_003D)
		{
			_ = 1;
			if (8 == 0)
			{
			}
			return _0023_003Dz5Je4CFo_003D.GetType() == typeof(PressureRoller);
		}
	}

	private sealed class _0023_003DzJzNivaWxCTKITynkrym2cv8_003D
	{
		public List<MachiningWorkingStep> _0023_003DzxUKhfGBmFKYA;

		public EdgeBandingProcessOperation _0023_003DzfOCoHG40Z_ED;

		public string _0023_003DztWevlC__0024xwu6LT12yw_003D_003D;

		public _0023_003DzJzNivaWxCTKITynkrym2cv8_003D()
		{
			_ = 8;
			if (5 == 0)
			{
			}
			base._002Ector();
		}

		internal void _0023_003DzlEfHtIDpm0yZP3XtTsi3I2ZiawdwDlk8IA_003D_003D(EdgeBandingOperation _0023_003Dz_0024TgJHtw_003D)
		{
			_ = 4;
			if (2 == 0)
			{
			}
			List<MachiningWorkingStep> list = _0023_003DzxUKhfGBmFKYA;
			_ = 8;
			if (7 == 0)
			{
			}
			ProjectInterface projectInterface = _0023_003DzfOCoHG40Z_ED._projectInterface;
			_ = 3;
			if (4 == 0)
			{
			}
			list.Add(projectInterface.GetOperationWorkingStep(_0023_003Dz_0024TgJHtw_003D.Key));
		}

		internal bool _0023_003DzdHh5dkGJsK4wIWPV687kSF6SSlyZqacIBQ_003D_003D(MachiningWorkingStep _0023_003DzmpQNtW0_003D)
		{
			_ = 0;
			if (false)
			{
			}
			string name = _0023_003DzmpQNtW0_003D.Name;
			_ = 2;
			if (8 == 0)
			{
			}
			return name == _0023_003DztWevlC__0024xwu6LT12yw_003D_003D;
		}
	}

	private sealed class _0023_003DzwhxbXzbzYlMiEfZcxg_003D_003D
	{
		public Attributes _0023_003Dzt1uQjRN14tIk;

		public _0023_003DzwhxbXzbzYlMiEfZcxg_003D_003D()
		{
			_ = 5;
			if (false)
			{
			}
			base._002Ector();
		}

		internal void _0023_003DzEEXtcJRQ0jBVN7XamULWvsDiiWmZ(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 4;
			if (1 == 0)
			{
			}
			Attributes attributes = _0023_003Dzt1uQjRN14tIk;
			_ = 2;
			if (1 == 0)
			{
			}
			attributes.Remove(_0023_003Dz6pELRLc_003D);
		}

		internal void _0023_003Dz_0024R08ZNF_rKMLDtMj_00245QzqSQWLMuV(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 3;
			if (3 == 0)
			{
			}
			Attributes attributes = _0023_003Dzt1uQjRN14tIk;
			_ = 7;
			if (1 == 0)
			{
			}
			attributes.Remove(_0023_003Dz6pELRLc_003D);
		}
	}

	public override uint ToolNumber => 0u;

	public override int HeadNumber
	{
		get
		{
			throw new NotImplementedException();
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
				if (3u != 0)
				{
					machiningWorkingStep = obj;
				}
				ManufacturingFeature obj2 = _projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature;
				ManufacturingFeature manufacturingFeature;
				if (2u != 0)
				{
					manufacturingFeature = obj2;
				}
				GeomGeometry obj3 = _projectInterface.Get(manufacturingFeature.GeometryID) as GeomGeometry;
				GeomGeometry geomGeometry;
				if (4u != 0)
				{
					geomGeometry = obj3;
				}
				if (geomGeometry is GeomTrimmedCurve && (geomGeometry as GeomTrimmedCurve).IsArc)
				{
					return new Arc(_projectInterface, geomGeometry as GeomTrimmedCurve);
				}
				if (geomGeometry is GeomCompositeCurve)
				{
					return new Polyline(_projectInterface, geomGeometry as GeomCompositeCurve);
				}
				return null;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701882);
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

	public override bool RetractPartial
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
			throw new NotImplementedException();
		}
	}

	public override double SpindleSpeed
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

	public override double ToolDiameter
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
				if (3u != 0)
				{
					return feedrate;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701882);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
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
				double startDepth = ((_projectInterface.Get(machiningWorkingStep.ManufacturingFeatureID) as ManufacturingFeature) as MachiningFeature).Depth.StartDepth;
				if (uint.MaxValue != 0)
				{
					return startDepth;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701882);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public override double ToolOffset => 0.0;

	public override bool ActivateNCCompensation => false;

	public override TypeOfProcess TypeOfProcess => TypeOfProcess.EdgeBanding;

	public override bool IsNCFunction => false;

	public EdgeBandingProcessOperation(OperationContext operationContext, string name, ReferenceKey workplanID)
		: base(operationContext, workplanID)
	{
		if (true)
		{
			base.Name = name;
		}
	}

	public void CreateEdgeBanding(ActiveEdgeBandingProgramParameters activeParameters, EdgeBandingOperationParameters edgeBandingParameters)
	{
		try
		{
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry;
			if (uint.MaxValue != 0)
			{
				geomGeometry = obj;
			}
			EdgeBandingOperation edgeBandingOperation = new EdgeBandingOperation();
			EdgeBandingOperation edgeBandingOperation2;
			if (uint.MaxValue != 0)
			{
				edgeBandingOperation2 = edgeBandingOperation;
			}
			Attributes attributes = activeParameters.Attributes;
			bool isPolyline = activeParameters.Geometry.IsPolyline;
			if (true)
			{
				_0023_003Dzq0e3rbxq6AG5AYtb8IIuyVE_003D(edgeBandingOperation2, attributes, geomGeometry, isPolyline);
			}
			Attributes attributes2 = activeParameters.Attributes;
			if (uint.MaxValue != 0)
			{
				_0023_003Dz_hR6lSynO7nq(geomGeometry, edgeBandingOperation2, attributes2);
			}
			MachiningTool machiningTool = _0023_003DzFPkekG47xt6gqI745dEbkQZfluS8(edgeBandingParameters.PressureTool);
			MachiningTool _0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D;
			if (uint.MaxValue != 0)
			{
				_0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D = machiningTool;
			}
			ReferenceToolKey referenceToolKey = _0023_003DzNQVZDHP71GNY(_0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D);
			ReferenceToolKey referenceToolKey2 = default(ReferenceToolKey);
			if (0 == 0)
			{
				referenceToolKey2 = referenceToolKey;
			}
			POMContext context = new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface);
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (2u != 0)
			{
				workingStep = machiningWorkingStep;
			}
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			ManufacturingFeature feature = new EdgeBandingFeature();
			EdgeBandingFeatureFeatureParameters featureParameters = new EdgeBandingFeatureFeatureParameters(context, feature);
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_options.MachiningOptions, activeParameters.Workplane.ReferenceKey, activeParameters.ApproachSecurityPlane, activeParameters.RetractSecurityPlane);
			EdgeBandingFeatureOperationParameters edgeBandingFeatureOperationParameters = new EdgeBandingFeatureOperationParameters(context, edgeBandingOperation2);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan: false, null, null, feature);
			edgeBandingFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			edgeBandingFeatureOperationParameters.InitializeCNMode(false);
			edgeBandingFeatureOperationParameters.InitializeSafetyDistance(builderSafetyDistances.Item1, builderSafetyDistances.Item2);
			edgeBandingFeatureOperationParameters.EnableCut = new BoolPropertyParameter(activeParameters.EdgeClosingManager.Cutter, FisicalUnitType.UnitLess, _projectInterface);
			edgeBandingFeatureOperationParameters.ManualLoading = new BoolPropertyParameter(edgeBandingParameters.EdgeManualLoading, FisicalUnitType.UnitLess, _projectInterface);
			edgeBandingFeatureOperationParameters.InitializeExtraDepth(edgeBandingParameters.Depth);
			edgeBandingFeatureOperationParameters.InitializeToolKey(referenceToolKey2);
			edgeBandingFeatureOperationParameters.InitializeApproach(activeParameters.EdgeBandingInOut.Approach);
			edgeBandingFeatureOperationParameters.InitializeRetract(activeParameters.EdgeBandingInOut.Retract);
			edgeBandingFeatureOperationParameters.EdgeDispensingManager = activeParameters.EdgeDispensingManager.EdgeDispensing;
			edgeBandingFeatureOperationParameters.EdgeClosingManager = activeParameters.EdgeClosingManager.EdgeClosing;
			_0023_003DzDXmIxgbXcjpoRO7FupgYcm4_003D(edgeBandingFeatureOperationParameters, edgeBandingParameters.EdgeCurrent);
			SetEdgeBandingOperationTechnology(edgeBandingFeatureOperationParameters, referenceToolKey2, edgeBandingParameters.Speed, null);
			edgeBandingFeatureOperationParameters.PressureRollerManualLoading = new BoolPropertyParameter(edgeBandingParameters.PressureToolManualLoading, FisicalUnitType.UnitLess, _projectInterface);
			EdgeBandingFeatureGeometryParameters geometryParameters = new EdgeBandingFeatureGeometryParameters(context, geomGeometry);
			ReferenceKey workplanID = _workplanID;
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			EdgeBandingFeatureBuilder edgeBandingFeatureBuilder = new EdgeBandingFeatureBuilder(context);
			edgeBandingFeatureBuilder.InitializeFeature(featureParameters);
			edgeBandingFeatureBuilder.InitializeGeometry(geometryParameters);
			edgeBandingFeatureBuilder.InitializeOperation(edgeBandingFeatureOperationParameters);
			edgeBandingFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			edgeBandingFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = edgeBandingFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703612), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, base.Name);
		}
	}

	public void CreateEdgeBandingSlotFeature(ActiveEdgeBandingSlotFeatureProgramParameters activeParameters, EdgeBandingSlotOperationParameters edgeBandingParameters)
	{
		try
		{
			GeomGeometry obj = _projectInterface.Get(activeParameters.Geometry.ReferenceKey) as GeomGeometry;
			GeomGeometry geomGeometry = default(GeomGeometry);
			if (0 == 0)
			{
				geomGeometry = obj;
			}
			EdgeBandingOperation edgeBandingOperation = new EdgeBandingOperation();
			EdgeBandingOperation edgeBandingOperation2;
			if (8u != 0)
			{
				edgeBandingOperation2 = edgeBandingOperation;
			}
			Attributes attributes = activeParameters.Attributes;
			GeomGeometry _0023_003DzRspm3dFz1LUUd5aLdg_003D_003D = geomGeometry;
			bool isPolyline = activeParameters.Geometry.IsPolyline;
			if (2u != 0)
			{
				_0023_003Dzq0e3rbxq6AG5AYtb8IIuyVE_003D(edgeBandingOperation2, attributes, _0023_003DzRspm3dFz1LUUd5aLdg_003D_003D, isPolyline);
			}
			GeomGeometry _0023_003DzIqguyi3APZ2P = geomGeometry;
			Attributes attributes2 = activeParameters.Attributes;
			if (8u != 0)
			{
				_0023_003Dz_hR6lSynO7nq(_0023_003DzIqguyi3APZ2P, edgeBandingOperation2, attributes2);
			}
			MachiningTool machiningTool = _0023_003DzqvulLUZOE1qL_002416IXSghCs2Eq5KGHd6vtw_003D_003D(edgeBandingParameters.PressureTool);
			MachiningTool _0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D = default(MachiningTool);
			if (0 == 0)
			{
				_0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D = machiningTool;
			}
			ReferenceToolKey referenceToolKey = _0023_003DzNQVZDHP71GNY(_0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D);
			ReferenceToolKey referenceToolKey2;
			if (3u != 0)
			{
				referenceToolKey2 = referenceToolKey;
			}
			POMContext context = new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface);
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (8u != 0)
			{
				workingStep = machiningWorkingStep;
			}
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(context, workingStep);
			workingStepParameters.InitializeExecutionEnable(true);
			workingStepParameters.InitializeName(base.Name);
			workingStepParameters.InitializePriority(activeParameters.Priority);
			ManufacturingFeature feature = new EdgeBandingSlotFeature();
			EdgeBandingSlotFeatureFeatureParameters edgeBandingSlotFeatureFeatureParameters = new EdgeBandingSlotFeatureFeatureParameters(context, feature);
			edgeBandingSlotFeatureFeatureParameters.InitializeSlotEdgeZ(edgeBandingParameters.SlotEdgeZ);
			edgeBandingSlotFeatureFeatureParameters.InitializeAngle(edgeBandingParameters.Angle);
			Tuple<double, double> builderSafetyDistances = GetBuilderSafetyDistances(_options.MachiningOptions, activeParameters.Workplane.ReferenceKey, activeParameters.ApproachSecurityPlane, activeParameters.RetractSecurityPlane);
			EdgeBandingSlotFeatureOperationParameters edgeBandingSlotFeatureOperationParameters = new EdgeBandingSlotFeatureOperationParameters(context, edgeBandingOperation2);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan: false, null, null, feature);
			edgeBandingSlotFeatureOperationParameters.InitializeCNMode(false);
			edgeBandingSlotFeatureOperationParameters.InitializeSafetyDistance(builderSafetyDistances.Item1, builderSafetyDistances.Item2);
			edgeBandingSlotFeatureOperationParameters.ManualLoading = new BoolPropertyParameter(edgeBandingParameters.EdgeManualLoading, FisicalUnitType.UnitLess, _projectInterface);
			edgeBandingSlotFeatureOperationParameters.InitializeExtraDepth(edgeBandingParameters.Depth);
			edgeBandingSlotFeatureOperationParameters.InitializeToolKey(referenceToolKey2);
			edgeBandingSlotFeatureOperationParameters.InitializeApproach(activeParameters.EdgeBandingSlotInOut.Approach);
			edgeBandingSlotFeatureOperationParameters.InitializeRetract(activeParameters.EdgeBandingSlotInOut.Retract);
			edgeBandingSlotFeatureOperationParameters.EdgeDispensingManager = activeParameters.EdgeDispensingManager.EdgeDispensing;
			_0023_003DzDXmIxgbXcjpoRO7FupgYcm4_003D(edgeBandingSlotFeatureOperationParameters, edgeBandingParameters.EdgeCurrent);
			SetEdgeBandingOperationTechnology(edgeBandingSlotFeatureOperationParameters, referenceToolKey2, edgeBandingParameters.Speed, null);
			edgeBandingSlotFeatureOperationParameters.MachineFunctions.AddRange(builderMachineFunctions);
			edgeBandingSlotFeatureOperationParameters.PressureRollerManualLoading = new BoolPropertyParameter(edgeBandingParameters.PressureToolManualLoading, FisicalUnitType.UnitLess, _projectInterface);
			EdgeBandingSlotFeatureGeometryParameters geometryParameters = new EdgeBandingSlotFeatureGeometryParameters(context, geomGeometry);
			ReferenceKey workplanID = _workplanID;
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			EdgeBandingSlotFeatureBuilder edgeBandingSlotFeatureBuilder = new EdgeBandingSlotFeatureBuilder(context);
			edgeBandingSlotFeatureBuilder.InitializeFeature(edgeBandingSlotFeatureFeatureParameters);
			edgeBandingSlotFeatureBuilder.InitializeGeometry(geometryParameters);
			edgeBandingSlotFeatureBuilder.InitializeOperation(edgeBandingSlotFeatureOperationParameters);
			edgeBandingSlotFeatureBuilder.InitializeWorkingStep(workingStepParameters);
			edgeBandingSlotFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = edgeBandingSlotFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703574), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, base.Name);
		}
	}

	private static void _0023_003Dzq0e3rbxq6AG5AYtb8IIuyVE_003D(EdgeBandingOperation _0023_003Dzu8NknEB3yA8NDTJ_00245w_003D_003D, Attributes _0023_003Dzt1uQjRN14tIk, GeomGeometry _0023_003DzRspm3dFz1LUUd5aLdg_003D_003D, bool _0023_003DzH4R3RA8SPe_0024uCIOh7A_003D_003D)
	{
		_0023_003DzwhxbXzbzYlMiEfZcxg_003D_003D _0023_003DzwhxbXzbzYlMiEfZcxg_003D_003D = new _0023_003DzwhxbXzbzYlMiEfZcxg_003D_003D();
		_0023_003DzwhxbXzbzYlMiEfZcxg_003D_003D CS_0024_003C_003E8__locals5;
		if (8u != 0)
		{
			CS_0024_003C_003E8__locals5 = _0023_003DzwhxbXzbzYlMiEfZcxg_003D_003D;
		}
		if (uint.MaxValue != 0)
		{
			CS_0024_003C_003E8__locals5._0023_003Dzt1uQjRN14tIk = _0023_003Dzt1uQjRN14tIk;
		}
		Attributes _0023_003Dzt1uQjRN14tIk2 = CS_0024_003C_003E8__locals5._0023_003Dzt1uQjRN14tIk;
		object obj = _0023_003DzJBaCSp8_003D._0023_003DzVJ2H1xQUX9G1P0WR_0024A_003D_003D;
		if (obj == null)
		{
			obj = (Predicate<Attribute>)delegate(Attribute _0023_003Dz6pELRLc_003D)
			{
				_ = 2;
				if (8 == 0)
				{
				}
				return _0023_003Dz6pELRLc_003D.GetType() == typeof(StartPointAttribute);
			};
			object _0023_003DzVJ2H1xQUX9G1P0WR_0024A_003D_003D = obj;
			if (7u != 0)
			{
				_0023_003DzJBaCSp8_003D._0023_003DzVJ2H1xQUX9G1P0WR_0024A_003D_003D = (Predicate<Attribute>)_0023_003DzVJ2H1xQUX9G1P0WR_0024A_003D_003D;
			}
		}
		List<Attribute> list = _0023_003Dzt1uQjRN14tIk2.FindAll((Predicate<Attribute>)obj);
		List<Attribute> list2 = CS_0024_003C_003E8__locals5._0023_003Dzt1uQjRN14tIk.FindAll(delegate(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 5;
			if (4 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.GetType() == typeof(EndPointAttribute);
		});
		ExtremaMachiningAttribute extremaMachiningAttribute = null;
		if (list.Count != 0)
		{
			StartPointAttribute startPointAttribute = list[0] as StartPointAttribute;
			extremaMachiningAttribute = new ExtremaMachiningAttribute(startPointAttribute.Value as ExtremaMachiningAttribute);
			if (_0023_003DzH4R3RA8SPe_0024uCIOh7A_003D_003D)
			{
				extremaMachiningAttribute.ElementKey = (_0023_003DzRspm3dFz1LUUd5aLdg_003D_003D as GeomCompositeCurve).Elements[startPointAttribute.Index].Key;
			}
		}
		ExtremaMachiningAttribute extremaMachiningAttribute2 = null;
		if (list2.Count != 0)
		{
			EndPointAttribute endPointAttribute = list2[0] as EndPointAttribute;
			extremaMachiningAttribute2 = new ExtremaMachiningAttribute(endPointAttribute.Value as ExtremaMachiningAttribute);
			if (_0023_003DzH4R3RA8SPe_0024uCIOh7A_003D_003D)
			{
				extremaMachiningAttribute2.ElementKey = (_0023_003DzRspm3dFz1LUUd5aLdg_003D_003D as GeomCompositeCurve).Elements[endPointAttribute.Index].Key;
			}
		}
		list.ForEach(CS_0024_003C_003E8__locals5._0023_003DzEEXtcJRQ0jBVN7XamULWvsDiiWmZ);
		list2.ForEach(delegate(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 3;
			if (3 == 0)
			{
			}
			Attributes _0023_003Dzt1uQjRN14tIk3 = CS_0024_003C_003E8__locals5._0023_003Dzt1uQjRN14tIk;
			_ = 7;
			if (1 == 0)
			{
			}
			_0023_003Dzt1uQjRN14tIk3.Remove(_0023_003Dz6pELRLc_003D);
		});
		_0023_003Dzu8NknEB3yA8NDTJ_00245w_003D_003D.StartMachiningPoint = extremaMachiningAttribute;
		_0023_003Dzu8NknEB3yA8NDTJ_00245w_003D_003D.EndMachiningPoint = extremaMachiningAttribute2;
	}

	public void SetEdgeBandingOperationTechnology(EdgeBandingFeatureOperationParameters operationsParams, ReferenceToolKey toolKey, double feed, object spindle)
	{
		object obj = feed;
		object feedRate;
		if (7u != 0)
		{
			feedRate = obj;
		}
		if (feed == -1.0)
		{
			if (4u != 0)
			{
				feedRate = null;
			}
		}
		operationsParams.InitializeTechnology(toolKey, feedRate, spindle);
	}

	private void _0023_003DzDXmIxgbXcjpoRO7FupgYcm4_003D(EdgeBandingFeatureOperationParameters _0023_003DzMuLSHQYOOxB5, string _0023_003Dzi8w1RUw_003D)
	{
		if (string.IsNullOrEmpty(_0023_003Dzi8w1RUw_003D))
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703276);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (5u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		Edge edge = _edgeInterface.GetEdge(_0023_003Dzi8w1RUw_003D);
		Edge edge2;
		if (3u != 0)
		{
			edge2 = edge;
		}
		ReferenceEdgeKey edgeKey;
		if (true)
		{
			edgeKey = null;
		}
		if (edge2 != null && edge2.Key != null && edge2.Key.IsValid)
		{
			edgeKey = new ReferenceEdgeKey(edge2.Key, edge2.Name);
		}
		_0023_003DzMuLSHQYOOxB5.SetEdgeKey(edgeKey);
	}

	private ReferenceToolKey _0023_003DzNQVZDHP71GNY(CoreTool _0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D)
	{
		ReferenceToolKey result;
		if (6u != 0)
		{
			result = null;
		}
		if (_0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D == null)
		{
			if (!_0023_003DzkezNQHmZNBMsxJq9ysf8fixIkUeu_2EjnQ_003D_003D())
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703239), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
		}
		else
		{
			ReferenceToolKey referenceToolKey = new ReferenceToolKey(_0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D.Key, _0023_003DzS8EYBpSPVSrpJp7_0024uQ_003D_003D.Name);
			if (6u != 0)
			{
				result = referenceToolKey;
			}
		}
		return result;
	}

	private bool _0023_003DzkezNQHmZNBMsxJq9ysf8fixIkUeu_2EjnQ_003D_003D()
	{
		bool result;
		if (uint.MaxValue != 0)
		{
			result = true;
		}
		EdgingHead edgingHead = _configurationInterface.GetEdgingHead();
		EdgingHead edgingHead2;
		if (5u != 0)
		{
			edgingHead2 = edgingHead;
		}
		if (edgingHead2 == null)
		{
			if (5u != 0)
			{
				result = false;
			}
		}
		else if (edgingHead2.ChildElements.Find(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzjpaEkxTtqg8GMmCz7DFikG4fmjXn2VQDrP7I15JwQ8Z2) == null)
		{
			result = false;
		}
		return result;
	}

	private MachiningTool _0023_003DzFPkekG47xt6gqI745dEbkQZfluS8(string _0023_003DzlCSVU0o_003D)
	{
		MachiningTool result;
		if (5u != 0)
		{
			result = null;
		}
		if (!string.IsNullOrEmpty(_0023_003DzlCSVU0o_003D) && _0023_003DzlCSVU0o_003D != _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672))
		{
			CoreTool coreTool = _toolInterface.Get(_0023_003DzlCSVU0o_003D);
			CoreTool coreTool2;
			if (uint.MaxValue != 0)
			{
				coreTool2 = coreTool;
			}
			if (coreTool2 != null)
			{
				PressureRollerTool obj = (coreTool2 as TouchProbingTool).ToolBody as PressureRollerTool;
				PressureRollerTool pressureRollerTool;
				if (2u != 0)
				{
					pressureRollerTool = obj;
				}
				if (pressureRollerTool != null)
				{
					result = coreTool2 as MachiningTool;
					if (pressureRollerTool.ToolSharpEdge != null || pressureRollerTool.ToolSlotEdge != null || pressureRollerTool.ToolSoftForming != null)
					{
						throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703190), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzlCSVU0o_003D, base.Name);
					}
				}
			}
		}
		return result;
	}

	private MachiningTool _0023_003DzqvulLUZOE1qL_002416IXSghCs2Eq5KGHd6vtw_003D_003D(string _0023_003DzlCSVU0o_003D)
	{
		MachiningTool result;
		if (4u != 0)
		{
			result = null;
		}
		if (!string.IsNullOrEmpty(_0023_003DzlCSVU0o_003D) && _0023_003DzlCSVU0o_003D != _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672))
		{
			CoreTool coreTool = _toolInterface.Get(_0023_003DzlCSVU0o_003D);
			CoreTool coreTool2;
			if (4u != 0)
			{
				coreTool2 = coreTool;
			}
			if (coreTool2 != null)
			{
				PressureRollerTool obj = (coreTool2 as TouchProbingTool).ToolBody as PressureRollerTool;
				PressureRollerTool pressureRollerTool;
				if (uint.MaxValue != 0)
				{
					pressureRollerTool = obj;
				}
				if (pressureRollerTool != null)
				{
					result = coreTool2 as MachiningTool;
					if (pressureRollerTool.ToolSlotEdge == null)
					{
						throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703395), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzlCSVU0o_003D, base.Name);
					}
				}
			}
		}
		return result;
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
			if (7u != 0)
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
				if (4u != 0)
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

	public void CreateEndTrimming(ActiveProgramParameters activeParameters, string edgeBandingName, string tool, string head, object inputSpeed, object rotSpeed, object speed, bool keepsCurrentPosition, bool useEndTrimmerAggregateCopier)
	{
		try
		{
			EndTrimmingOperation endTrimmingOperation = new EndTrimmingOperation();
			EndTrimmingOperation operation;
			if (7u != 0)
			{
				operation = endTrimmingOperation;
			}
			EndTrimmingFeature endTrimmingFeature = new EndTrimmingFeature();
			EndTrimmingFeature endTrimmingFeature2;
			if (true)
			{
				endTrimmingFeature2 = endTrimmingFeature;
			}
			POMContext pOMContext = new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface);
			POMContext pOMContext2;
			if (8u != 0)
			{
				pOMContext2 = pOMContext;
			}
			MachiningWorkingStep machiningWorkingStep = new MachiningWorkingStep();
			MachiningWorkingStep workingStep;
			if (4u != 0)
			{
				workingStep = machiningWorkingStep;
			}
			WorkingStepParameters workingStepParameters = new WorkingStepParameters(pOMContext2, workingStep);
			WorkingStepParameters workingStepParameters2;
			if (8u != 0)
			{
				workingStepParameters2 = workingStepParameters;
			}
			workingStepParameters2.InitializeExecutionEnable(true);
			workingStepParameters2.InitializeName(base.Name);
			workingStepParameters2.InitializePriority(activeParameters.Priority);
			EndTrimmingStrategy obj = activeParameters.Strategy as EndTrimmingStrategy;
			EndTrimmingStrategy endTrimmingStrategy;
			if (3u != 0)
			{
				endTrimmingStrategy = obj;
			}
			if (endTrimmingStrategy == null)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703350), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, base.Name);
			}
			WorkSide workSide = endTrimmingStrategy.WorkSide;
			WorkSide _0023_003DzJn1O8ruoD8RmV904HQ_003D_003D;
			if (4u != 0)
			{
				_0023_003DzJn1O8ruoD8RmV904HQ_003D_003D = workSide;
			}
			CoreTool coreTool = _0023_003DzNrLFszc_003D(tool, _options.EndTrimmingOptions.EndTrimmingTool, TypeOfProcess.EndTrimming.ToString());
			ReferenceToolKey toolKey = new ReferenceToolKey(coreTool.Key, coreTool.Name);
			MachiningWorkingStepData machiningWorkingStepData = _0023_003DzjhxHzk3KRYIncE1xIJYwBL0_003D(edgeBandingName);
			EndTrimmingFeatureFeatureParameters featureParameters = _0023_003DzQGdCOlrSxSlWCMLmIA_003D_003D(endTrimmingFeature2, _0023_003DzJn1O8ruoD8RmV904HQ_003D_003D, pOMContext2, endTrimmingStrategy);
			EndTrimmingFeatureOperationParameters endTrimmingFeatureOperationParameters = new EndTrimmingFeatureOperationParameters(pOMContext2, operation);
			endTrimmingFeatureOperationParameters.InitializeEdgeBandingWS(machiningWorkingStepData.Executable as MachiningWorkingStep);
			string empty = string.Empty;
			empty = ((endTrimmingStrategy.OverCutLenght != null) ? endTrimmingStrategy.OverCutLenght.ToString() : _options.EndTrimmingOptions.OffSetBorderHeight.ToString());
			double num = _projectInterface.EvaluateExpression<double>(empty, FisicalUnitType.Lenght);
			endTrimmingFeatureOperationParameters.InitializeExtraDepth(num);
			endTrimmingFeatureOperationParameters.InitializeCNMode(false);
			endTrimmingFeatureOperationParameters.InitializeSafetyDistance(activeParameters.ApproachSecurityPlane, activeParameters.ApproachSecurityPlane);
			endTrimmingFeatureOperationParameters.InitializeTechnology(toolKey, speed, rotSpeed);
			endTrimmingFeatureOperationParameters.InitializeKeepsCurrentPosition(keepsCurrentPosition);
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = _0023_003DzvzV7gxk_003D(pOMContext2, activeParameters, head, _options.EndTrimmingOptions.EndTrimmingHead, TypeOfProcess.EndTrimming.ToString());
			ScmGroup.XCam.MachiningDataModel.Head builderHead = GetBuilderHead(head, configHead, activeParameters.MachineID);
			endTrimmingFeatureOperationParameters.InitializeHead(builderHead);
			ScmGroup.XCam.MachiningDataModel.Strategy.EndTrimmingStrategy endTrimmingStrategy2 = new ScmGroup.XCam.MachiningDataModel.Strategy.EndTrimmingStrategy();
			endTrimmingStrategy2.CuttingMethod = (ScmGroup.XCam.MachiningDataModel.Strategy.EndTrimmingStrategy.CutMethod)endTrimmingStrategy.CuttingMethod;
			endTrimmingFeatureOperationParameters.InitializeStrategy(endTrimmingStrategy2);
			List<MachineFunction> builderMachineFunctions = GetBuilderMachineFunctions(activeParameters.MachineFunctions, disableDustPan: false, coreTool, builderHead, endTrimmingFeature2);
			endTrimmingFeatureOperationParameters.InitializeMachineFunctions(builderMachineFunctions);
			GeomGeometry geometry = _0023_003DzrW_J8MXLocHdBif5qoUhf3bFSfip(machiningWorkingStepData);
			EndTrimmingFeatureGeometryParameters geometryParameters = new EndTrimmingFeatureGeometryParameters(pOMContext2, geometry);
			ReferenceKey workplanID = _workplanID;
			ReferenceKey referenceKey = activeParameters.Workpiece.ReferenceKey;
			ReferenceKey referenceKey2 = activeParameters.Workplane.ReferenceKey;
			EndTrimmingFeatureBuilder endTrimmingFeatureBuilder = new EndTrimmingFeatureBuilder(pOMContext2);
			endTrimmingFeatureBuilder.InitializeFeature(featureParameters);
			endTrimmingFeatureBuilder.InitializeGeometry(geometryParameters);
			endTrimmingFeatureBuilder.InitializeOperation(endTrimmingFeatureOperationParameters);
			endTrimmingFeatureBuilder.InitializeWorkingStep(workingStepParameters2);
			endTrimmingFeatureBuilder.Add(workplanID, referenceKey, referenceKey2, -1);
			base.ReferenceKey = endTrimmingFeatureBuilder.WorkingStep.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703302), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, base.Name);
		}
	}

	private ScmGroup.XCam.ConfigDataModel.Heads.Head _0023_003DzvzV7gxk_003D(POMContext _0023_003Dz7tGH79U_003D, ActiveProgramParameters _0023_003DzlG_0024kGXwbOn7X, string _0023_003DzOKErxW0_003D, string _0023_003DzYAopgc8d_TN0, string _0023_003DzergJzGc_003D)
	{
		ScmGroup.XCam.ConfigDataModel.Heads.Head value;
		if (3u != 0)
		{
			value = null;
		}
		if (_0023_003DzOKErxW0_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672))
		{
			if (string.IsNullOrEmpty(_0023_003DzYAopgc8d_TN0))
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701984), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzergJzGc_003D);
			}
			ConfigHeadsObjectModel configHeadsObjectModel = new ConfigHeadsObjectModel(_0023_003Dz7tGH79U_003D, _options);
			configHeadsObjectModel.InitializeMachine(_0023_003DzlG_0024kGXwbOn7X.Machine.Name);
			List<ScmGroup.XCam.ConfigDataModel.Heads.Head> list = configHeadsObjectModel.FindCompatibleHeads(typeof(EndTrimmingFeature));
			Dictionary<string, ScmGroup.XCam.ConfigDataModel.Heads.Head> dictionary = new Dictionary<string, ScmGroup.XCam.ConfigDataModel.Heads.Head>();
			Dictionary<string, ScmGroup.XCam.ConfigDataModel.Heads.Head> dictionary2;
			if (2u != 0)
			{
				dictionary2 = dictionary;
			}
			List<ScmGroup.XCam.ConfigDataModel.Heads.Head>.Enumerator enumerator = list.GetEnumerator();
			List<ScmGroup.XCam.ConfigDataModel.Heads.Head>.Enumerator enumerator2;
			if (4u != 0)
			{
				enumerator2 = enumerator;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					ScmGroup.XCam.ConfigDataModel.Heads.Head current = enumerator2.Current;
					string arg = LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701937), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990));
					int num = current.HeadNumber - 2;
					string key = string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701911), current.Name, arg, num);
					dictionary2.Add(key, current);
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
			dictionary2.TryGetValue(_0023_003DzYAopgc8d_TN0, out value);
			if (value == null)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701893), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzYAopgc8d_TN0);
			}
		}
		else
		{
			value = GetConfigHead(_0023_003DzOKErxW0_003D);
			if (value == null)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701893), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzYAopgc8d_TN0);
			}
		}
		return value;
	}

	private static GeomGeometry _0023_003DzrW_J8MXLocHdBif5qoUhf3bFSfip(MachiningWorkingStepData _0023_003DzSRBsOvpF_wZFJ8ptCQ_003D_003D)
	{
		GeomGeometry result = default(GeomGeometry);
		if (0 == 0)
		{
			result = null;
		}
		GeomGeometry geometry = _0023_003DzSRBsOvpF_wZFJ8ptCQ_003D_003D.Geometry;
		GeomGeometry geomGeometry = default(GeomGeometry);
		if (0 == 0)
		{
			geomGeometry = geometry;
		}
		if (geomGeometry is GeomTrimmedCurve)
		{
			GeomTrimmedCurve geomTrimmedCurve = new GeomTrimmedCurve(geomGeometry as GeomTrimmedCurve, generateReference: false);
			if (uint.MaxValue != 0)
			{
				result = geomTrimmedCurve;
			}
		}
		else if (geomGeometry is GeomCompositeCurve)
		{
			result = new GeomCompositeCurve(geomGeometry as GeomCompositeCurve, generateReference: false);
		}
		else if (geomGeometry is GeomCircle)
		{
			result = new GeomCircle(geomGeometry as GeomCircle, generateReference: false);
		}
		else if (geomGeometry is GeomEllipse)
		{
			result = new GeomEllipse(geomGeometry as GeomEllipse, generateReference: false);
		}
		else if (geomGeometry is GeomBSplineCurve)
		{
			result = new GeomBSplineCurve(geomGeometry as GeomBSplineCurve, generateReference: false);
		}
		return result;
	}

	private CoreTool _0023_003DzNrLFszc_003D(string _0023_003DzlCSVU0o_003D, string _0023_003DzCYCYxPs3naU5, string _0023_003DzergJzGc_003D)
	{
		CoreTool coreTool;
		if (5u != 0)
		{
			coreTool = null;
		}
		if (_0023_003DzlCSVU0o_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672))
		{
			if (string.IsNullOrEmpty(_0023_003DzCYCYxPs3naU5))
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702118), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzergJzGc_003D);
			}
			CoreTool coreTool2 = _toolInterface.Get(_0023_003DzCYCYxPs3naU5);
			if (3u != 0)
			{
				coreTool = coreTool2;
			}
			if (coreTool == null)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702071), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzCYCYxPs3naU5);
			}
		}
		else
		{
			CoreTool coreTool3 = _toolInterface.Get(_0023_003DzlCSVU0o_003D);
			if (5u != 0)
			{
				coreTool = coreTool3;
			}
			if (coreTool == null)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702071), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzlCSVU0o_003D);
			}
		}
		return coreTool;
	}

	private MachiningWorkingStepData _0023_003DzjhxHzk3KRYIncE1xIJYwBL0_003D(string _0023_003DztWevlC__0024xwu6LT12yw_003D_003D)
	{
		_0023_003DzJzNivaWxCTKITynkrym2cv8_003D _0023_003DzJzNivaWxCTKITynkrym2cv8_003D = new _0023_003DzJzNivaWxCTKITynkrym2cv8_003D();
		_0023_003DzJzNivaWxCTKITynkrym2cv8_003D _0023_003DzJzNivaWxCTKITynkrym2cv8_003D2;
		if (2u != 0)
		{
			_0023_003DzJzNivaWxCTKITynkrym2cv8_003D2 = _0023_003DzJzNivaWxCTKITynkrym2cv8_003D;
		}
		if (5u != 0)
		{
			_0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DzfOCoHG40Z_ED = this;
		}
		if (4u != 0)
		{
			_0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DztWevlC__0024xwu6LT12yw_003D_003D = _0023_003DztWevlC__0024xwu6LT12yw_003D_003D;
		}
		if (string.IsNullOrEmpty(_0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DztWevlC__0024xwu6LT12yw_003D_003D))
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702040), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, base.Name);
		}
		List<EdgeBandingOperation> list = _projectInterface.GetList<EdgeBandingOperation>();
		if (list.Count == 0)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701727), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, base.Name);
		}
		_0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DzxUKhfGBmFKYA = new List<MachiningWorkingStep>();
		list.ForEach(_0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DzlEfHtIDpm0yZP3XtTsi3I2ZiawdwDlk8IA_003D_003D);
		MachiningWorkingStep machiningWorkingStep = _0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DzxUKhfGBmFKYA.Find(_0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DzdHh5dkGJsK4wIWPV687kSF6SSlyZqacIBQ_003D_003D);
		if (machiningWorkingStep == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701675), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzJzNivaWxCTKITynkrym2cv8_003D2._0023_003DztWevlC__0024xwu6LT12yw_003D_003D);
		}
		return _projectInterface.GetMachiningWorkingStepData(machiningWorkingStep.Key);
	}

	private EndTrimmingFeatureFeatureParameters _0023_003DzQGdCOlrSxSlWCMLmIA_003D_003D(EndTrimmingFeature _0023_003Dza6VqrSU_003D, WorkSide _0023_003DzJn1O8ruoD8RmV904HQ_003D_003D, POMContext _0023_003Dz7tGH79U_003D, EndTrimmingStrategy _0023_003Dze06VVWU_003D)
	{
		bool flag;
		if (uint.MaxValue != 0)
		{
			flag = false;
		}
		bool flag2;
		if (true)
		{
			flag2 = true;
		}
		SideType sideOfFeature;
		if (7u != 0)
		{
			sideOfFeature = SideType.Center;
		}
		switch (_0023_003DzJn1O8ruoD8RmV904HQ_003D_003D)
		{
		case WorkSide.End:
			sideOfFeature = SideType.Left;
			break;
		case WorkSide.Start:
			sideOfFeature = SideType.Right;
			break;
		}
		if (_0023_003Dze06VVWU_003D.CuttingMethod == CuttingMethod.CenterBlade)
		{
			flag = false;
			flag2 = false;
		}
		else if (_0023_003Dze06VVWU_003D.CuttingMethod == CuttingMethod.Peripheral)
		{
			flag = true;
			flag2 = true;
		}
		EndTrimmingFeatureFeatureParameters endTrimmingFeatureFeatureParameters = new EndTrimmingFeatureFeatureParameters(_0023_003Dz7tGH79U_003D, _0023_003Dza6VqrSU_003D);
		endTrimmingFeatureFeatureParameters.InitializeToolCompensation(sideOfFeature, _0023_003Dze06VVWU_003D.OverMaterial, flag);
		endTrimmingFeatureFeatureParameters.InitializeProfile(flag2);
		return endTrimmingFeatureFeatureParameters;
	}
}
