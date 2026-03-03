using System;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;

namespace ScmGroup.XCam.Scripting;

public class WorkPieceTranslationRotationProbing : NCFunction
{
	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => true;

	public WorkPieceTranslationRotationProbing(OperationContext operationContext)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		_ = -1;
		if (1 == 0)
		{
		}
		base._002Ector(operationContext, null);
	}

	public void CreateWorkPieceTranslationRotationProbing(ActiveProgramParameters activeParameters, string name, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head)
	{
		ReferenceKey referenceKey = activeParameters.Workplan.ReferenceKey;
		ReferenceKey mainWorkplanKey;
		if (uint.MaxValue != 0)
		{
			mainWorkplanKey = referenceKey;
		}
		ReferenceKey referenceKey2 = activeParameters.Workpiece.ReferenceKey;
		ReferenceKey workPieceKey;
		if (8u != 0)
		{
			workPieceKey = referenceKey2;
		}
		ReferenceKey referenceKey3 = activeParameters.Workplane.ReferenceKey;
		ReferenceKey planeKey;
		if (uint.MaxValue != 0)
		{
			planeKey = referenceKey3;
		}
		int headNumber = 0;
		ReferenceToolKey refToolKey = null;
		_toolInterface.GetToolHeadInfo(head, tool, ref headNumber, ref refToolKey);
		ScmGroup.XCam.ConfigDataModel.Heads.Head head2 = _0023_003DzXCWdDsBQkVT0LczxyQ5pR7k_003D(headNumber);
		ScmGroup.XCam.MachiningDataModel.WorkPieceTranslationRotationProbing workPieceTranslationRotationProbing = new ScmGroup.XCam.MachiningDataModel.WorkPieceTranslationRotationProbing();
		POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
		WorkPieceTranslationRotationProbingBuilder workPieceTranslationRotationProbingBuilder = new WorkPieceTranslationRotationProbingBuilder(context);
		WorkPieceTranslationRotationProbingParameters workPieceTranslationRotationProbingParameters = new WorkPieceTranslationRotationProbingParameters(context, workPieceTranslationRotationProbing);
		workPieceTranslationRotationProbingBuilder.InitializeNcFunction(workPieceTranslationRotationProbingParameters);
		if (probingXFirstPointQuote != null)
		{
			double length = Convert.ToDouble(probingXFirstPointQuote);
			probingXFirstPointQuote = ConvertLengthToCurrentUnit(length);
		}
		if (probingXSecondPointQuote != null)
		{
			double length2 = Convert.ToDouble(probingXSecondPointQuote);
			probingXSecondPointQuote = ConvertLengthToCurrentUnit(length2);
		}
		if (probingZQuote != null)
		{
			double length3 = Convert.ToDouble(probingZQuote);
			probingZQuote = ConvertLengthToCurrentUnit(length3);
		}
		workPieceTranslationRotationProbingParameters.InitializeName(name);
		workPieceTranslationRotationProbingParameters.InitializeExecutionEnable(true);
		workPieceTranslationRotationProbingParameters.InitializeTechnology(refToolKey);
		workPieceTranslationRotationProbingParameters.InitializeProbingQuotes(probingXFirstPointQuote, probingXSecondPointQuote, probingYPointQuote, probingZQuote);
		workPieceTranslationRotationProbingParameters.InitializeTechnology(refToolKey);
		workPieceTranslationRotationProbingParameters.InitializeHead(head2);
		workPieceTranslationRotationProbingBuilder.Add(mainWorkplanKey, workPieceKey, planeKey, -1);
		base.ReferenceKey = workPieceTranslationRotationProbingBuilder.NcFunction.Key;
	}

	private ScmGroup.XCam.ConfigDataModel.Heads.Head _0023_003DzXCWdDsBQkVT0LczxyQ5pR7k_003D(int _0023_003Dznv8znP1vlgf_0024)
	{
		ScmGroup.XCam.ConfigDataModel.Heads.Head result = default(ScmGroup.XCam.ConfigDataModel.Heads.Head);
		if (0 == 0)
		{
			result = null;
		}
		try
		{
			ScmGroup.XCam.ConfigDataModel.Heads.Head head = _configurationInterface.GetHead(_0023_003Dznv8znP1vlgf_0024, clone: false);
			ScmGroup.XCam.ConfigDataModel.Heads.Head head2;
			if (6u != 0)
			{
				head2 = head;
			}
			if (head2 is FiveAxisMillingHead)
			{
				if (7u != 0)
				{
					result = head2;
				}
			}
			else if (head2 is FourAxisMillingHead)
			{
				result = head2;
			}
			else if (head2 is ThreeAxisMillingHead)
			{
				result = head2;
			}
			else if (head2 is ProbingHead)
			{
				result = head2;
			}
		}
		catch
		{
			throw;
		}
		return result;
	}
}
