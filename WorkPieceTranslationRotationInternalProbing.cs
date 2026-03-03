using System;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;

namespace ScmGroup.XCam.Scripting;

public class WorkPieceTranslationRotationInternalProbing : NCFunction
{
	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => true;

	public WorkPieceTranslationRotationInternalProbing(OperationContext operationContext)
	{
		_ = 6;
		if (7 == 0)
		{
		}
		_ = 1;
		if (-1 == 0)
		{
		}
		base._002Ector(operationContext, null);
	}

	public void CreateWorkPieceTranslationRotationInternalProbing(ActiveProgramParameters activeParameters, string name, object probingXCoordinate, object probingYCoordinate, object probingRectWidth, object probingRectHeight, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head)
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
		if (4u != 0)
		{
			planeKey = referenceKey3;
		}
		int headNumber;
		if (8u != 0)
		{
			headNumber = 0;
		}
		ReferenceToolKey refToolKey = null;
		_toolInterface.GetToolHeadInfo(head, tool, ref headNumber, ref refToolKey);
		ScmGroup.XCam.ConfigDataModel.Heads.Head head2 = _0023_003DzXCWdDsBQkVT0LczxyQ5pR7k_003D(headNumber);
		ScmGroup.XCam.MachiningDataModel.WorkPieceTranslationRotationInternalProbing workPieceTranslationRotationInternalProbing = new ScmGroup.XCam.MachiningDataModel.WorkPieceTranslationRotationInternalProbing();
		POMContext context = new POMContext(_projectInterface, _toolInterface, null, _configurationInterface);
		WorkPieceTranslationRotationInternalProbingBuilder workPieceTranslationRotationInternalProbingBuilder = new WorkPieceTranslationRotationInternalProbingBuilder(context);
		WorkPieceTranslationRotationInternalProbingParameters workPieceTranslationRotationInternalProbingParameters = new WorkPieceTranslationRotationInternalProbingParameters(context, workPieceTranslationRotationInternalProbing);
		workPieceTranslationRotationInternalProbingBuilder.InitializeNcFunction(workPieceTranslationRotationInternalProbingParameters);
		if (probingXCoordinate != null)
		{
			double length = Convert.ToDouble(probingXCoordinate);
			probingXCoordinate = ConvertLengthToCurrentUnit(length);
		}
		if (probingYCoordinate != null)
		{
			double length2 = Convert.ToDouble(probingYCoordinate);
			probingYCoordinate = ConvertLengthToCurrentUnit(length2);
		}
		if (probingRectWidth != null)
		{
			double length3 = Convert.ToDouble(probingRectWidth);
			probingRectWidth = ConvertLengthToCurrentUnit(length3);
		}
		if (probingRectHeight != null)
		{
			double length4 = Convert.ToDouble(probingRectHeight);
			probingRectHeight = ConvertLengthToCurrentUnit(length4);
		}
		if (probingXFirstPointQuote != null)
		{
			double length5 = Convert.ToDouble(probingXFirstPointQuote);
			probingXFirstPointQuote = ConvertLengthToCurrentUnit(length5);
		}
		if (probingXSecondPointQuote != null)
		{
			double length6 = Convert.ToDouble(probingXSecondPointQuote);
			probingXSecondPointQuote = ConvertLengthToCurrentUnit(length6);
		}
		if (probingZQuote != null)
		{
			double length7 = Convert.ToDouble(probingZQuote);
			probingZQuote = ConvertLengthToCurrentUnit(length7);
		}
		workPieceTranslationRotationInternalProbingParameters.InitializeName(name);
		workPieceTranslationRotationInternalProbingParameters.InitializeExecutionEnable(true);
		workPieceTranslationRotationInternalProbingParameters.InitializeTechnology(refToolKey);
		workPieceTranslationRotationInternalProbingParameters.InitializeProbingQuotes(probingXCoordinate, probingYCoordinate, probingRectWidth, probingRectHeight, probingXFirstPointQuote, probingXSecondPointQuote, probingYPointQuote, probingZQuote);
		workPieceTranslationRotationInternalProbingParameters.InitializeTechnology(refToolKey);
		workPieceTranslationRotationInternalProbingParameters.InitializeHead(head2);
		workPieceTranslationRotationInternalProbingBuilder.Add(mainWorkplanKey, workPieceKey, planeKey, -1);
		base.ReferenceKey = workPieceTranslationRotationInternalProbingBuilder.NcFunction.Key;
	}

	private ScmGroup.XCam.ConfigDataModel.Heads.Head _0023_003DzXCWdDsBQkVT0LczxyQ5pR7k_003D(int _0023_003Dznv8znP1vlgf_0024)
	{
		ScmGroup.XCam.ConfigDataModel.Heads.Head result;
		if (6u != 0)
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
