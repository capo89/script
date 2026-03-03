using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;

namespace ScmGroup.XCam.Scripting;

public class StartOnBlowHeater : NCFunction
{
	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public StartOnBlowHeater(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 4;
		if (3 == 0)
		{
		}
		_ = 2;
		if (7 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public StartOnBlowHeater(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (4u != 0)
		{
			base.Name = name;
		}
	}

	public void CreateStartOnBlowHeater(ActiveProgramParameters activeParameters)
	{
		ReferenceKey referenceKey = activeParameters.Workplane.ReferenceKey;
		ReferenceKey planeKey;
		if (uint.MaxValue != 0)
		{
			planeKey = referenceKey;
		}
		ScmGroup.XCam.MachiningDataModel.StartOnBlowHeater startOnBlowHeater = new ScmGroup.XCam.MachiningDataModel.StartOnBlowHeater();
		ScmGroup.XCam.MachiningDataModel.StartOnBlowHeater startOnBlowHeater2;
		if (true)
		{
			startOnBlowHeater2 = startOnBlowHeater;
		}
		POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
		StartOnBlowHeaterBuilder startOnBlowHeaterBuilder = new StartOnBlowHeaterBuilder(context);
		StartOnBlowHeaterBuilder startOnBlowHeaterBuilder2;
		if (7u != 0)
		{
			startOnBlowHeaterBuilder2 = startOnBlowHeaterBuilder;
		}
		StartOnBlowHeaterParameters startOnBlowHeaterParameters = new StartOnBlowHeaterParameters(context, startOnBlowHeater2);
		startOnBlowHeaterBuilder2.InitializeNcFunction(startOnBlowHeaterParameters);
		startOnBlowHeaterParameters.InitializeName(base.Name);
		startOnBlowHeaterParameters.InitializeExecutionEnable(true);
		startOnBlowHeaterBuilder2.Add(_workplanID, activeParameters.Workpiece.ReferenceKey, planeKey, -1);
		base.ReferenceKey = startOnBlowHeaterBuilder2.NcFunction.Key;
	}
}
