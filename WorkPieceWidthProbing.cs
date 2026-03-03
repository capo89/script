using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;

namespace ScmGroup.XCam.Scripting;

public class WorkPieceWidthProbing : NCFunction
{
	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public WorkPieceWidthProbing(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 6;
		if (3 == 0)
		{
		}
		_ = 4;
		if (7 == 0)
		{
		}
		_ = 4;
		if (1 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public WorkPieceWidthProbing(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (7u != 0)
		{
			base.Name = name;
		}
	}

	public void CreateWorkPieceWidthProbing(ActiveProgramParameters activeParameters, double distance)
	{
		ReferenceKey referenceKey = activeParameters.Workplane.ReferenceKey;
		ReferenceKey planeKey;
		if (8u != 0)
		{
			planeKey = referenceKey;
		}
		ScmGroup.XCam.MachiningDataModel.WorkPieceWidthProbing workPieceWidthProbing = new ScmGroup.XCam.MachiningDataModel.WorkPieceWidthProbing();
		ScmGroup.XCam.MachiningDataModel.WorkPieceWidthProbing workPieceWidthProbing2;
		if (true)
		{
			workPieceWidthProbing2 = workPieceWidthProbing;
		}
		double num = ConvertLengthToCurrentUnit(distance);
		double num2;
		if (4u != 0)
		{
			num2 = num;
		}
		POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
		WorkPieceWidthProbingBuilder workPieceWidthProbingBuilder = new WorkPieceWidthProbingBuilder(context);
		WorkPieceWidthProbingParameters workPieceWidthProbingParameters = new WorkPieceWidthProbingParameters(context, workPieceWidthProbing2);
		workPieceWidthProbingBuilder.InitializeNcFunction(workPieceWidthProbingParameters);
		workPieceWidthProbingParameters.InitializeName(base.Name);
		workPieceWidthProbingParameters.InitializeExecutionEnable(true);
		workPieceWidthProbingParameters.InitializeDistance(num2);
		workPieceWidthProbingBuilder.Add(_workplanID, activeParameters.Workpiece.ReferenceKey, planeKey, -1);
		base.ReferenceKey = workPieceWidthProbingBuilder.NcFunction.Key;
	}
}
