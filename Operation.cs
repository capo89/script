using System;
using System.Collections.Generic;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ConfigDataModel;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.Hoods;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Heads;
using ScmGroup.XCam.ProjectObjectModel.WorkingStep;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Common;
using ScmGroup.XCam.ToolDataModel.Tool;

namespace ScmGroup.XCam.Scripting;

public abstract class Operation : BaseScripting
{
	protected ReferenceKey _workplanID;

	protected UI00Options _options;

	protected IScriptingReportServices _reportServices;

	protected string _errorString;

	public abstract uint ToolNumber { get; }

	public abstract int HeadNumber { get; }

	public abstract Geometry Geometry { get; }

	public abstract Polyline Toolpath { get; }

	public abstract double Feed { get; }

	public abstract double Depth { get; }

	public abstract double ToolDiameter { get; }

	public abstract double ToolOffset { get; }

	public abstract bool ActivateNCCompensation { get; }

	public abstract TypeOfProcess TypeOfProcess { get; }

	public abstract bool RetractPartial { get; }

	public abstract double StepLength { get; }

	public abstract double SafeRapidLevel { get; }

	public abstract double SpindleSpeed { get; }

	public abstract bool IsNCFunction { get; }

	public Operation(OperationContext operationContext, ReferenceKey workplanKey)
	{
		if (uint.MaxValue != 0)
		{
			_workplanID = workplanKey;
		}
		IScriptingReportServices reportServices = operationContext.ReportServices;
		if (2u != 0)
		{
			_reportServices = reportServices;
		}
		UI00Options options = operationContext.Options;
		if (5u != 0)
		{
			_options = options;
		}
		_projectInterface = operationContext.ProjectInterface;
		_toolInterface = operationContext.ToolInterface;
		_edgeInterface = operationContext.EdgeInterface;
		_configurationInterface = operationContext.ConfigurationInterface;
		_supportInterface = operationContext.SupportInterface;
	}

	protected void AddToErrorFile(string message)
	{
		_ = 5;
		if (2 == 0)
		{
		}
		IScriptingReportServices reportServices = _reportServices;
		if (reportServices == null)
		{
			if (8u != 0)
			{
			}
			return;
		}
		_ = 4;
		if (3 == 0)
		{
		}
		reportServices.AddMessage(message);
	}

	protected void CreateMachiningOperationSafetyDistances(UI00MachiningOptions machiningOptions, MachiningOperation machiningOperation, ReferenceKey planeKey, double? approachSecurityPlane, double? retractSecurityPlane)
	{
		WorkingStepObjectModel workingStepObjectModel = new WorkingStepObjectModel();
		Plane obj = _projectInterface.Get(planeKey) as Plane;
		Plane plane;
		if (true)
		{
			plane = obj;
		}
		double num = workingStepObjectModel.EvaluateSecurityDistance(machiningOptions, plane);
		double num2;
		if (8u != 0)
		{
			num2 = num;
		}
		double num3 = num2;
		double retractSecurityPlane2;
		if (true)
		{
			retractSecurityPlane2 = num3;
		}
		if (approachSecurityPlane.HasValue)
		{
			num2 = approachSecurityPlane.Value;
		}
		if (retractSecurityPlane.HasValue)
		{
			retractSecurityPlane2 = retractSecurityPlane.Value;
		}
		machiningOperation.ApproachSecurityPlane = num2;
		machiningOperation.RetractSecurityPlane = retractSecurityPlane2;
	}

	protected double CalculateHeadRotation(GeomGeometry geometry, ReferenceToolKey toolKey, ReferenceKey workPieceKey)
	{
		POMContext pOMContext = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
		POMContext context;
		if (7u != 0)
		{
			context = pOMContext;
		}
		return new WorkingStepObjectModel().CalculateRotationAngle(context, geometry, toolKey, workPieceKey);
	}

	protected double ConvertLengthToCurrentUnit(double length)
	{
		double result;
		if (uint.MaxValue != 0)
		{
			result = length;
		}
		bool isMM = _options.IsMM;
		bool flag;
		if (5u != 0)
		{
			flag = isMM;
		}
		if (!flag)
		{
			double num = MathUtility.ConvertLenghtToCurrentUnit(length, flag);
			if (true)
			{
				result = num;
			}
		}
		return result;
	}

	protected double ConvertSpeedToCurrentUnit(double speed)
	{
		double result = default(double);
		if (0 == 0)
		{
			result = speed;
		}
		bool isMM = _options.IsMM;
		bool flag;
		if (6u != 0)
		{
			flag = isMM;
		}
		if (!flag)
		{
			double num = MathUtility.ConvertSpeedToCurrentUnit(speed, flag);
			if (true)
			{
				result = num;
			}
		}
		return result;
	}

	protected object ConvertExpressionValueToCurrentFormat(object value)
	{
		object result;
		if (6u != 0)
		{
			result = null;
		}
		if (value != null)
		{
			string text = value.ToString();
			string text2;
			if (4u != 0)
			{
				text2 = text;
			}
			if (StringUtility.IsValid(text2))
			{
				string text3 = text2.ConvertToCurrentFormat();
				if (8u != 0)
				{
					result = text3;
				}
			}
		}
		return result;
	}

	protected ScmGroup.XCam.MachiningDataModel.Head ConvertConfigHeadToMachiningHead(ScmGroup.XCam.ConfigDataModel.Heads.Head configHead)
	{
		ScmGroup.XCam.MachiningDataModel.Head result = default(ScmGroup.XCam.MachiningDataModel.Head);
		if (0 == 0)
		{
			result = null;
		}
		try
		{
			if (configHead != null)
			{
				TypeOfHead headType;
				if (6u != 0)
				{
					headType = TypeOfHead.None;
				}
				int headNumber = configHead.HeadNumber;
				if (configHead is BrcBoringHead)
				{
					if (2u != 0)
					{
						headType = TypeOfHead.Brc;
					}
				}
				else if (configHead is EdgingHead)
				{
					headType = TypeOfHead.EdgeBanding;
				}
				else if (configHead is FiveAxisMillingHead)
				{
					headType = TypeOfHead.Prisma;
				}
				else if (configHead is FourAxisMillingHead)
				{
					headType = TypeOfHead.None;
				}
				else if (configHead is LabelingHead)
				{
					headType = TypeOfHead.Labeler;
				}
				else if (configHead is SawMillingHead)
				{
					headType = TypeOfHead.Blade;
				}
				else if (configHead is SCMNailingHead)
				{
					headType = TypeOfHead.Nailer;
				}
				else if (configHead is SencoNailingHead)
				{
					headType = TypeOfHead.Nailer;
				}
				else if (configHead is StandardBoringHead)
				{
					headType = TypeOfHead.AusiliaryDrilling;
				}
				else if (configHead is StandardDowelingHead)
				{
					headType = TypeOfHead.None;
				}
				else if (configHead is StandardProbingHead)
				{
					headType = TypeOfHead.Probe;
				}
				else if (configHead is ThreeAxisMillingHead)
				{
					headType = TypeOfHead.None;
				}
				else if (configHead is UniversalMillingHead)
				{
					headType = TypeOfHead.Universal;
				}
				else if (configHead is WorkPiecePressingHead)
				{
					headType = TypeOfHead.WorkPiecePresser;
				}
				else if (configHead is AirBlowerHead)
				{
					headType = TypeOfHead.AirBlower;
				}
				result = new ScmGroup.XCam.MachiningDataModel.Head(headNumber, headType);
			}
		}
		catch
		{
			throw;
		}
		return result;
	}

	protected ScmGroup.XCam.ConfigDataModel.Heads.Head GetConfigHead(int headNumber)
	{
		ScmGroup.XCam.ConfigDataModel.Heads.Head result;
		if (4u != 0)
		{
			result = null;
		}
		if (_configurationInterface != null)
		{
			ScmGroup.XCam.ConfigDataModel.Heads.Head head = _configurationInterface.GetHead(headNumber, clone: false);
			if (4u != 0)
			{
				result = head;
			}
		}
		return result;
	}

	protected ScmGroup.XCam.ConfigDataModel.Heads.Head GetConfigHead(string headNumberString)
	{
		ScmGroup.XCam.ConfigDataModel.Heads.Head result;
		if (2u != 0)
		{
			result = null;
		}
		if (StringUtility.IsValid(headNumberString))
		{
			int num = Convert.ToInt32(headNumberString);
			int headNumber = default(int);
			if (0 == 0)
			{
				headNumber = num;
			}
			ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(headNumber);
			if (true)
			{
				result = configHead;
			}
		}
		return result;
	}

	protected ScmGroup.XCam.MachiningDataModel.Head GetBuilderHead(ScmGroup.XCam.ConfigDataModel.Heads.Head configHead)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		_ = 1;
		if (7 == 0)
		{
		}
		return ConvertConfigHeadToMachiningHead(configHead);
	}

	protected ScmGroup.XCam.MachiningDataModel.Head GetBuilderHead(string headString, ScmGroup.XCam.ConfigDataModel.Heads.Head configHead, int machineId)
	{
		ScmGroup.XCam.MachiningDataModel.Head head = ConvertConfigHeadToMachiningHead(configHead);
		ScmGroup.XCam.MachiningDataModel.Head head2;
		if (5u != 0)
		{
			head2 = head;
		}
		int result;
		if (0 == 0)
		{
			result = 0;
		}
		int.TryParse(headString, out result);
		if (head2 == null && result > -1)
		{
			if (result <= 0)
			{
				if (true)
				{
					result = 3;
				}
			}
			head2 = new ScmGroup.XCam.MachiningDataModel.Head();
			head2.Number = result;
		}
		if (machineId > 0 && _configurationInterface != null)
		{
			Machine configurationMachine = _configurationInterface.GetConfigurationMachine(machineId - 1, clone: false);
			if (configurationMachine != null)
			{
				head2.MachineName = configurationMachine.Name;
				if (result >= 10000)
				{
					head2.HeadsGroupNumber = result / 1000 % 10;
					head2.HeadsGroupType = (TypeOfHeadsGroup)(result / 10000);
					head2.MachiningSpindle = result % 100;
					head2.Number = result / 100 % 10;
				}
			}
		}
		return head2;
	}

	protected double GetBuilderHeadRotation(GeomGeometry geometry, ReferenceToolKey toolKey, ReferenceKey workPieceKey)
	{
		_ = 8;
		if (4 == 0)
		{
		}
		_ = 5;
		if (3 == 0)
		{
		}
		_ = 1;
		if (6 == 0)
		{
		}
		return CalculateHeadRotation(geometry, toolKey, workPieceKey);
	}

	protected Tuple<double, double> GetBuilderSafetyDistances(UI00MachiningOptions machiningOptions, ReferenceKey planeKey, double? approachSecurityPlane, double? retractSecurityPlane)
	{
		WorkingStepObjectModel workingStepObjectModel = new WorkingStepObjectModel();
		Plane obj = _projectInterface.Get(planeKey) as Plane;
		Plane plane;
		if (uint.MaxValue != 0)
		{
			plane = obj;
		}
		double num = workingStepObjectModel.EvaluateSecurityDistance(machiningOptions, plane);
		double num2;
		if (5u != 0)
		{
			num2 = num;
		}
		double num3 = num2;
		double length;
		if (uint.MaxValue != 0)
		{
			length = num3;
		}
		if (approachSecurityPlane.HasValue)
		{
			num2 = approachSecurityPlane.Value;
		}
		if (retractSecurityPlane.HasValue)
		{
			length = retractSecurityPlane.Value;
		}
		num2 = ConvertLengthToCurrentUnit(num2);
		length = ConvertLengthToCurrentUnit(length);
		return Tuple.Create(num2, length);
	}

	protected Tuple<object, object> GetBuilderTechnologySpeeds(double rotationSpeed, double feedSpeed)
	{
		object item;
		if (3u != 0)
		{
			item = null;
		}
		object item2;
		if (4u != 0)
		{
			item2 = null;
		}
		if (rotationSpeed != -1.0)
		{
			object obj = rotationSpeed;
			if (uint.MaxValue != 0)
			{
				item = obj;
			}
		}
		if (feedSpeed != -1.0)
		{
			item2 = ConvertSpeedToCurrentUnit(feedSpeed);
		}
		return Tuple.Create(item, item2);
	}

	protected List<MachineFunction> CreateMachineFunctions(MachineFunctions machineFunctions, bool disableDustPan, ReferenceToolKey toolKey, ScmGroup.XCam.MachiningDataModel.Head machiningHead, ManufacturingFeature feature)
	{
		CoreTool coreTool = _toolInterface.Get(toolKey);
		CoreTool _0023_003DzqmiDBVY_003D;
		if (3u != 0)
		{
			_0023_003DzqmiDBVY_003D = coreTool;
		}
		Type obj = feature?.GetType();
		Type _0023_003Dzh339Jdw_003D;
		if (2u != 0)
		{
			_0023_003Dzh339Jdw_003D = obj;
		}
		return _0023_003DzfmGporkAd1UB(machineFunctions, disableDustPan, _0023_003DzqmiDBVY_003D, machiningHead, _0023_003Dzh339Jdw_003D);
	}

	protected List<MachineFunction> CreateMachineFunctions(MachineFunctions machineFunctions, bool disableDustPan, CoreTool tool, ScmGroup.XCam.MachiningDataModel.Head machiningHead, ManufacturingFeature feature)
	{
		Type obj = feature?.GetType();
		Type _0023_003Dzh339Jdw_003D;
		if (7u != 0)
		{
			_0023_003Dzh339Jdw_003D = obj;
		}
		return _0023_003DzfmGporkAd1UB(machineFunctions, disableDustPan, tool, machiningHead, _0023_003Dzh339Jdw_003D);
	}

	protected List<MachineFunction> CreateMachineFunctions(MachineFunctions machineFunctions, bool disableDustPan, ReferenceToolKey toolKey, ScmGroup.XCam.MachiningDataModel.Head machiningHead, Type featureType)
	{
		CoreTool coreTool = _toolInterface.Get(toolKey);
		CoreTool _0023_003DzqmiDBVY_003D;
		if (5u != 0)
		{
			_0023_003DzqmiDBVY_003D = coreTool;
		}
		return _0023_003DzfmGporkAd1UB(machineFunctions, disableDustPan, _0023_003DzqmiDBVY_003D, machiningHead, featureType);
	}

	private List<MachineFunction> _0023_003DzfmGporkAd1UB(MachineFunctions _0023_003DzKSI_KSQ1TnUd, bool _0023_003DzzrGZvIcJHVA0z55uVg_003D_003D, CoreTool _0023_003DzqmiDBVY_003D, ScmGroup.XCam.MachiningDataModel.Head _0023_003DzXfIV9W_snknhce5Lmw_003D_003D, Type _0023_003Dzh339Jdw_003D)
	{
		List<MachineFunction> list = new List<MachineFunction>();
		List<MachineFunction> list2;
		if (true)
		{
			list2 = list;
		}
		if (_0023_003DzKSI_KSQ1TnUd.DustpanEnabled && !_0023_003DzzrGZvIcJHVA0z55uVg_003D_003D)
		{
			list2.Add(new DustPan(_0023_003DzKSI_KSQ1TnUd.DustpanPosition, _0023_003DzKSI_KSQ1TnUd.DustpanOffset, _0023_003DzKSI_KSQ1TnUd.DustpanIsInOutEnable));
		}
		if (_0023_003DzKSI_KSQ1TnUd.MotorizedDustpanEnabled && !_0023_003DzzrGZvIcJHVA0z55uVg_003D_003D)
		{
			DustPan dustPan = new DustPan(_0023_003DzKSI_KSQ1TnUd.MotorizedDustpanPosition, _0023_003DzKSI_KSQ1TnUd.MotorizedDustpanOffset, _0023_003DzKSI_KSQ1TnUd.MotorizedDustpanIsInOutEnable);
			DustPan dustPan2;
			if (6u != 0)
			{
				dustPan2 = dustPan;
			}
			dustPan2.IsMotorized = true;
			dustPan2.IsMotorizedAutomatic = _0023_003DzKSI_KSQ1TnUd.MotorizedDustpanAutoEnabled;
			list2.Add(dustPan2);
		}
		if (_0023_003DzKSI_KSQ1TnUd.JerkEnabled)
		{
			list2.Add(new Jerk(_0023_003DzKSI_KSQ1TnUd.JerkGain));
		}
		if (_0023_003DzKSI_KSQ1TnUd.CNAutoSpeedEnabled)
		{
			list2.Add(new CNAutoSpeed());
		}
		if (_0023_003DzKSI_KSQ1TnUd.Jerk3DEnabled)
		{
			int num = (int)_0023_003DzKSI_KSQ1TnUd.Jerk3DCorrection;
			int num2;
			if (8u != 0)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 0:
				list2.Add(new Jerk3D(Jerk3DVertexCorrection.Disable));
				break;
			case 1:
				list2.Add(new Jerk3D(Jerk3DVertexCorrection.Rough));
				break;
			case 2:
				list2.Add(new Jerk3D(Jerk3DVertexCorrection.Middle));
				break;
			case 3:
				list2.Add(new Jerk3D(Jerk3DVertexCorrection.Finish));
				break;
			}
		}
		MachineFunction machineFunction = _0023_003DzE45XLRtdV62D(_0023_003DzKSI_KSQ1TnUd, _0023_003DzXfIV9W_snknhce5Lmw_003D_003D, _0023_003Dzh339Jdw_003D, _0023_003DzqmiDBVY_003D);
		MachineFunction machineFunction2;
		if (7u != 0)
		{
			machineFunction2 = machineFunction;
		}
		if (machineFunction2 != null)
		{
			list2.Add(machineFunction2);
		}
		if (_0023_003DzKSI_KSQ1TnUd.OppositeHoodEnabled)
		{
			list2.Add(new OppositePneumaticHood((PneumaticHoodPositions)_0023_003DzKSI_KSQ1TnUd.OppositeHoodPosition));
		}
		if (_0023_003DzKSI_KSQ1TnUd.HoodAuxiliaryEnabled)
		{
			list2.Add(new AuxiliaryHood((PneumaticHoodPositions)_0023_003DzKSI_KSQ1TnUd.HoodAuxiliaryPosition));
		}
		if (_0023_003DzKSI_KSQ1TnUd.CleaningModeEnabled)
		{
			list2.Add(new CleaningMode());
		}
		if (_0023_003DzKSI_KSQ1TnUd.UnrollHeadMode != 0)
		{
			double num3 = ((_0023_003DzKSI_KSQ1TnUd.UnrollHeadModeRadiusMultiplier == 0.0) ? 1.0 : _0023_003DzKSI_KSQ1TnUd.UnrollHeadModeRadiusMultiplier);
			double radiusMultiplier;
			if (6u != 0)
			{
				radiusMultiplier = num3;
			}
			list2.Add(new UnrollHead((UnrollHeadMode)_0023_003DzKSI_KSQ1TnUd.UnrollHeadMode, radiusMultiplier));
		}
		if (!string.IsNullOrEmpty(_0023_003DzKSI_KSQ1TnUd.ActiveBrakes))
		{
			list2.Add(new PneumaticBrake(_0023_003DzKSI_KSQ1TnUd.ActiveBrakes));
		}
		if (_0023_003DzKSI_KSQ1TnUd.IsToolBlowerEnabled)
		{
			int toolNumber;
			if (uint.MaxValue != 0)
			{
				toolNumber = -1;
			}
			bool flag;
			if (2u != 0)
			{
				flag = false;
			}
			if (_0023_003DzqmiDBVY_003D != null)
			{
				XilogToolKey xilogToolKey = ToolMethods.GetXilogToolKey(_0023_003DzqmiDBVY_003D);
				XilogToolKey xilogToolKey2;
				if (uint.MaxValue != 0)
				{
					xilogToolKey2 = xilogToolKey;
				}
				if (xilogToolKey2 != null)
				{
					toolNumber = Convert.ToInt32(xilogToolKey2.Key);
					if (xilogToolKey2.KindOfTool == XilogToolKey.KindOfOriginTool.XilogSpindleUnitTool)
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				int spindleNumber = 1;
				if (_0023_003DzXfIV9W_snknhce5Lmw_003D_003D != null)
				{
					spindleNumber = _0023_003DzXfIV9W_snknhce5Lmw_003D_003D.SpindleNumber;
				}
				ToolBlower item = new ToolBlower
				{
					SpindleNumber = spindleNumber,
					ToolNumber = toolNumber,
					BlowerMode = _0023_003DzKSI_KSQ1TnUd.ToolBlowerMode
				};
				list2.Add(item);
			}
		}
		if (_0023_003DzKSI_KSQ1TnUd.ElectronicZeroProberEnable)
		{
			ElectronicZeroProber item2 = new ElectronicZeroProber(_0023_003DzKSI_KSQ1TnUd.ElectronicZeroProberGain, _0023_003DzKSI_KSQ1TnUd.ElectronicZeroProberOffset, _0023_003DzKSI_KSQ1TnUd.ElectronicZeroProberCompression);
			list2.Add(item2);
		}
		MachineFunction machineFunction3 = _0023_003DzKDEqs2Z8D3IldToHa0t3IztL4kLbLs0ntg_003D_003D(_0023_003DzKSI_KSQ1TnUd);
		if (machineFunction3 != null)
		{
			list2.Add(machineFunction3);
		}
		MachineFunction machineFunction4 = _0023_003Dzts2GafOuZ02Iql0Rhd4pbOz1oa46(_0023_003DzKSI_KSQ1TnUd);
		if (machineFunction4 != null)
		{
			list2.Add(machineFunction4);
		}
		if (_0023_003DzKSI_KSQ1TnUd.RotationEnabled)
		{
			list2.Add(new ScmGroup.XCam.MachiningDataModel.Rotation(_0023_003DzKSI_KSQ1TnUd.RotationDirection));
		}
		if (_0023_003DzKSI_KSQ1TnUd.AutostartEnabled)
		{
			list2.Add(new AutoStart(_0023_003DzKSI_KSQ1TnUd.AutostartStatus));
		}
		if (_0023_003DzKSI_KSQ1TnUd.ChangeHiddenToolEnabled)
		{
			list2.Add(new ChangeHiddenTool(_0023_003DzKSI_KSQ1TnUd.ChangeHiddenToolStatus));
		}
		if (_0023_003DzKSI_KSQ1TnUd.DisableAdvanceEdgeChangeEnabled)
		{
			list2.Add(new DisableAdvanceEdgeChange(_0023_003DzKSI_KSQ1TnUd.DisableAdvanceEdgeChangeStatus));
		}
		return list2;
	}

	private MachineFunction _0023_003DzE45XLRtdV62D(MachineFunctions _0023_003DzKSI_KSQ1TnUd, ScmGroup.XCam.MachiningDataModel.Head _0023_003DzXfIV9W_snknhce5Lmw_003D_003D, Type _0023_003Dzh339Jdw_003D, CoreTool _0023_003DzqmiDBVY_003D)
	{
		MachineFunction result;
		if (2u != 0)
		{
			result = null;
		}
		if (_0023_003DzKSI_KSQ1TnUd.HoodEnabled && !_0023_003DzKSI_KSQ1TnUd.MotorizedHoodEnabled)
		{
			PneumaticHood pneumaticHood = new PneumaticHood((PneumaticHoodPositions)_0023_003DzKSI_KSQ1TnUd.HoodPosition, _0023_003DzKSI_KSQ1TnUd.HoodAutoEnabled);
			if (8u != 0)
			{
				result = pneumaticHood;
			}
		}
		else if (!_0023_003DzKSI_KSQ1TnUd.HoodEnabled && _0023_003DzKSI_KSQ1TnUd.MotorizedHoodEnabled)
		{
			PneumaticHood obj = new PneumaticHood
			{
				MotorizedPosition = _0023_003DzKSI_KSQ1TnUd.MotorizedHoodPosition,
				Automatic = _0023_003DzKSI_KSQ1TnUd.HoodAutoEnabled,
				IsMotorized = true
			};
			if (0 == 0)
			{
				result = obj;
			}
		}
		else if (_0023_003DzKSI_KSQ1TnUd.HoodEnabled && _0023_003DzKSI_KSQ1TnUd.MotorizedHoodEnabled)
		{
			ScmGroup.XCam.ConfigDataModel.Heads.Head head;
			if (uint.MaxValue != 0)
			{
				head = null;
			}
			if (_0023_003DzXfIV9W_snknhce5Lmw_003D_003D == null)
			{
				if (_0023_003DzqmiDBVY_003D != null)
				{
					AutomaticHeadResolver automaticHeadResolver = new AutomaticHeadResolver(new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface), _options);
					automaticHeadResolver.Initialize();
					ReferenceToolKey referenceToolKey = new ReferenceToolKey(_0023_003DzqmiDBVY_003D.Key, _0023_003DzqmiDBVY_003D.Name);
					ReferenceToolKey toolKey;
					if (3u != 0)
					{
						toolKey = referenceToolKey;
					}
					head = automaticHeadResolver.FindSuitableHead(_0023_003Dzh339Jdw_003D, toolKey);
				}
			}
			else
			{
				head = _configurationInterface?.GetHead(_0023_003DzXfIV9W_snknhce5Lmw_003D_003D.Number);
			}
			if (head != null)
			{
				List<Hood> list = head.GetList<Hood>(clone: false);
				if (list.Count > 0)
				{
					bool flag = false;
					bool flag2 = false;
					foreach (Hood item in list)
					{
						if (item is PrimaryPneumaticHood)
						{
							flag = true;
						}
						else if (item is PrimaryMotorizedHood)
						{
							flag2 = true;
						}
					}
					if (flag && !flag2)
					{
						result = new PneumaticHood((PneumaticHoodPositions)_0023_003DzKSI_KSQ1TnUd.HoodPosition, _0023_003DzKSI_KSQ1TnUd.HoodAutoEnabled);
					}
					else if (!flag && flag2)
					{
						result = new PneumaticHood
						{
							MotorizedPosition = _0023_003DzKSI_KSQ1TnUd.MotorizedHoodPosition,
							Automatic = _0023_003DzKSI_KSQ1TnUd.HoodAutoEnabled,
							IsMotorized = true
						};
					}
					else if (flag && flag2)
					{
						result = new PneumaticHood((PneumaticHoodPositions)_0023_003DzKSI_KSQ1TnUd.HoodPosition, _0023_003DzKSI_KSQ1TnUd.HoodAutoEnabled);
					}
				}
				else
				{
					result = new PneumaticHood((PneumaticHoodPositions)_0023_003DzKSI_KSQ1TnUd.HoodPosition, _0023_003DzKSI_KSQ1TnUd.HoodAutoEnabled);
				}
			}
			else
			{
				result = new PneumaticHood((PneumaticHoodPositions)_0023_003DzKSI_KSQ1TnUd.HoodPosition, _0023_003DzKSI_KSQ1TnUd.HoodAutoEnabled);
			}
		}
		return result;
	}

	private MachineFunction _0023_003DzKDEqs2Z8D3IldToHa0t3IztL4kLbLs0ntg_003D_003D(MachineFunctions _0023_003DzKSI_KSQ1TnUd)
	{
		MachineFunction result;
		if (true)
		{
			result = null;
		}
		if (_0023_003DzKSI_KSQ1TnUd.IsPressureRollersEnabled)
		{
			PrismaPressureRollers obj = new PrismaPressureRollers
			{
				Offset = _0023_003DzKSI_KSQ1TnUd.PressureRollersOffset
			};
			if (0 == 0)
			{
				result = obj;
			}
		}
		return result;
	}

	private MachineFunction _0023_003Dzts2GafOuZ02Iql0Rhd4pbOz1oa46(MachineFunctions _0023_003DzKSI_KSQ1TnUd)
	{
		MachineFunction result;
		if (true)
		{
			result = null;
		}
		if (_0023_003DzKSI_KSQ1TnUd.IsMechanicalPresserEnabled)
		{
			MechanicalPresser mechanicalPresser = new MechanicalPresser();
			if (true)
			{
				result = mechanicalPresser;
			}
		}
		return result;
	}

	protected List<MachineFunction> GetBuilderMachineFunctions(MachineFunctions machineFunctions, bool disableDustPan, CoreTool tool, ScmGroup.XCam.MachiningDataModel.Head machiningHead, ManufacturingFeature feature)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		_ = 1;
		if (-1 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		return CreateMachineFunctions(machineFunctions, disableDustPan, tool, machiningHead, feature);
	}

	public ReferenceKey GetWorkplanID()
	{
		_ = 3;
		if (4 == 0)
		{
		}
		return _workplanID;
	}
}
