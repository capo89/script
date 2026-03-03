using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class CombiflexUnloadUnitClamp : NCFunction
{
	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => true;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public CombiflexUnloadUnitClamp(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		_ = 8;
		if (4 == 0)
		{
		}
		_ = 2;
		if (4 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public CombiflexUnloadUnitClamp(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (true)
		{
			base.Name = name;
		}
	}

	public void CreateCombiflexUnloadUnitClamp(ActiveProgramParameters activeParameters, double zQuote, double yOffset)
	{
		ScmGroup.XCam.MachiningDataModel.CombiflexUnloadUnitClamp combiflexUnloadUnitClamp = new ScmGroup.XCam.MachiningDataModel.CombiflexUnloadUnitClamp();
		Executable executable;
		if (uint.MaxValue != 0)
		{
			executable = combiflexUnloadUnitClamp;
		}
		(executable as ScmGroup.XCam.MachiningDataModel.CombiflexUnloadUnitClamp).Name = base.Name;
		(executable as ScmGroup.XCam.MachiningDataModel.CombiflexUnloadUnitClamp).ZQuote = zQuote;
		(executable as ScmGroup.XCam.MachiningDataModel.CombiflexUnloadUnitClamp).YOffset = yOffset;
		(executable as ScmGroup.XCam.MachiningDataModel.CombiflexUnloadUnitClamp).WorkpieceID = activeParameters.Workpiece.ReferenceKey;
		_projectInterface.AddExecutable(ref executable, _workplanID, this);
		ReferenceKey key = executable.Key;
		if (uint.MaxValue != 0)
		{
			base.ReferenceKey = key;
		}
	}
}
