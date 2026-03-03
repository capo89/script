using System.Runtime.CompilerServices;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;
using ScmGroup.XCam.ToolDataModel.Common;

namespace ScmGroup.XCam.Scripting;

public class WorkPieceProbing : NCFunction
{
	private bool _0023_003DzisYPgtyCU2DGwsw1xpCVRwU_003D;

	public bool ToMinQuote
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (6 == 0)
			{
			}
			return _0023_003DzisYPgtyCU2DGwsw1xpCVRwU_003D;
		}
	}

	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public WorkPieceProbing(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 0;
		if (false)
		{
		}
		_ = 4;
		if (2 == 0)
		{
		}
		_ = 2;
		if (2 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public WorkPieceProbing(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (5u != 0)
		{
			base.Name = name;
		}
	}

	public void CreateWorkPieceProbing(ActiveProgramParameters activeParameters, double x, double y, string tool, string head, int type = 0, int headReturnAfterProbing = 0)
	{
		CoreTool builderTool = GetBuilderTool(tool);
		CoreTool coreTool;
		if (8u != 0)
		{
			coreTool = builderTool;
		}
		ScmGroup.XCam.ConfigDataModel.Heads.Head configHead = GetConfigHead(head);
		ScmGroup.XCam.ConfigDataModel.Heads.Head head2;
		if (8u != 0)
		{
			head2 = configHead;
		}
		GetBuilderHead(head2);
		ReferenceToolKey toolKey;
		if (8u != 0)
		{
			toolKey = null;
		}
		if (coreTool != null)
		{
			ReferenceToolKey referenceToolKey = new ReferenceToolKey(coreTool.Key, coreTool.Name);
			if (0 == 0)
			{
				toolKey = referenceToolKey;
			}
		}
		ProbingType probingType = ProbingType.ProbingTypeAllFacesProbing;
		if (type == 1)
		{
			probingType = ProbingType.ProbingTypePointProbing;
		}
		HeadReturnAfterProbing headReturn = HeadReturnAfterProbing.HeadReturnAfterProbingMode0;
		switch (headReturnAfterProbing)
		{
		case 1:
			headReturn = HeadReturnAfterProbing.HeadReturnAfterProbingMode1;
			break;
		case 2:
			headReturn = HeadReturnAfterProbing.HeadReturnAfterProbingMode2;
			break;
		}
		ReferenceKey referenceKey = activeParameters.Workplane.ReferenceKey;
		ScmGroup.XCam.MachiningDataModel.WorkPieceProbing workPieceProbing = new ScmGroup.XCam.MachiningDataModel.WorkPieceProbing();
		GeomGeometry geomGeometry = new GeomCartesianPoint(0.0, 0.0, 0.0);
		geomGeometry.IsAbsolute = false;
		geomGeometry.Name = base.Name;
		double num = ConvertLengthToCurrentUnit(x);
		double num2 = ConvertLengthToCurrentUnit(y);
		POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
		WorkPieceProbingBuilder workPieceProbingBuilder = new WorkPieceProbingBuilder(context);
		WorkPieceProbingGeometryParameters workPieceProbingGeometryParameters = new WorkPieceProbingGeometryParameters(context, geomGeometry);
		WorkPieceProbingParameters workPieceProbingParameters = new WorkPieceProbingParameters(context, workPieceProbing);
		workPieceProbingBuilder.InitializeGeometry(workPieceProbingGeometryParameters);
		workPieceProbingBuilder.InitializeNcFunction(workPieceProbingParameters);
		workPieceProbingGeometryParameters.InitializeCoordinates(num, num2);
		workPieceProbingGeometryParameters.InitializePlane(referenceKey);
		workPieceProbingParameters.InitializeExecutionEnable(true);
		workPieceProbingParameters.InitializeHead(head2);
		workPieceProbingParameters.InitializeHeadReturn(headReturn);
		workPieceProbingParameters.InitializeName(base.Name);
		workPieceProbingParameters.InitializeProbingType(probingType);
		workPieceProbingParameters.InitializeTechnology(toolKey);
		workPieceProbingBuilder.Add(_workplanID, activeParameters.Workpiece.ReferenceKey, referenceKey, -1);
		base.ReferenceKey = workPieceProbingBuilder.NcFunction.Key;
	}

	internal void _0023_003Dzpb1NS0LplNbe(bool _0023_003Dz3keKASA_003D)
	{
		if (3u != 0)
		{
			_0023_003DzisYPgtyCU2DGwsw1xpCVRwU_003D = _0023_003Dz3keKASA_003D;
		}
	}
}
