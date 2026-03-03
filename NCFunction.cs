using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Common;

namespace ScmGroup.XCam.Scripting;

public abstract class NCFunction : Operation
{
	public abstract bool IsNullOperation { get; }

	public abstract bool IsPark { get; }

	public abstract bool IsMsg { get; }

	public abstract bool IsWorkPieceProbing { get; }

	public abstract bool IsIso { get; }

	public abstract bool IsCombiflexUnloadUnitClamp { get; }

	public abstract bool IsPrismaProbing { get; }

	public abstract bool IsWorkPieceTranslationRotationProbing { get; }

	public override uint ToolNumber => 0u;

	public override int HeadNumber => 0;

	public override Geometry Geometry => null;

	public override Polyline Toolpath => null;

	public override double Feed => 0.0;

	public override double Depth => 0.0;

	public override double ToolDiameter => 0.0;

	public override double ToolOffset => 0.0;

	public override bool ActivateNCCompensation => false;

	public override TypeOfProcess TypeOfProcess => TypeOfProcess.NotDefined;

	public override bool RetractPartial => false;

	public override double StepLength => 0.0;

	public override double SafeRapidLevel => 0.0;

	public override double SpindleSpeed => 0.0;

	public override bool IsNCFunction => true;

	public NCFunction(OperationContext operationContext, ReferenceKey workplanKey)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		_ = 6;
		if (4 == 0)
		{
		}
		_ = 8;
		if (2 == 0)
		{
		}
		base._002Ector(operationContext, workplanKey);
	}

	protected CoreTool GetBuilderTool(string toolName)
	{
		_ = 7;
		if (3 == 0)
		{
		}
		ToolInterface toolInterface = _toolInterface;
		_ = 5;
		if (5 == 0)
		{
		}
		return toolInterface.Get(toolName);
	}
}
