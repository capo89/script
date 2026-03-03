using System;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Builders.ExecutableBuilders;

namespace ScmGroup.XCam.Scripting;

public class PrismaProbing : NCFunction
{
	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => true;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public PrismaProbing(OperationContext operationContext)
	{
		_ = 3;
		if (3 == 0)
		{
		}
		_ = 4;
		if (2 == 0)
		{
		}
		base._002Ector(operationContext, null);
	}

	public void CreatePrismaProbing(ActiveProgramParameters activeParameters, string name, object x, object y, string tool, object speed)
	{
		ReferenceKey referenceKey = activeParameters.Workplan.ReferenceKey;
		ReferenceKey mainWorkplanKey;
		if (uint.MaxValue != 0)
		{
			mainWorkplanKey = referenceKey;
		}
		ReferenceKey referenceKey2 = activeParameters.Workpiece.ReferenceKey;
		ReferenceKey workPieceKey;
		if (2u != 0)
		{
			workPieceKey = referenceKey2;
		}
		ReferenceKey referenceKey3 = activeParameters.Workplane.ReferenceKey;
		ReferenceKey planeKey = default(ReferenceKey);
		if (0 == 0)
		{
			planeKey = referenceKey3;
		}
		int headNumber = 0;
		ReferenceToolKey refToolKey = null;
		_toolInterface.GetToolHeadInfo(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672), tool, ref headNumber, ref refToolKey);
		ScmGroup.XCam.MachiningDataModel.PrismaProbing prismaProbing = new ScmGroup.XCam.MachiningDataModel.PrismaProbing();
		GeomCartesianPoint geometry = new GeomCartesianPoint();
		POMContext context = new POMContext(_projectInterface, _toolInterface, null, null);
		PrismaProbingBuilder prismaProbingBuilder = new PrismaProbingBuilder(context);
		PrismaProbingGeometryParameters prismaProbingGeometryParameters = new PrismaProbingGeometryParameters(context, geometry);
		PrismaProbingParameters prismaProbingParameters = new PrismaProbingParameters(context, prismaProbing);
		prismaProbingBuilder.InitializeGeometry(prismaProbingGeometryParameters);
		prismaProbingBuilder.InitializeNcFunction(prismaProbingParameters);
		if (x != null)
		{
			double length = Convert.ToDouble(x);
			x = ConvertLengthToCurrentUnit(length);
		}
		if (y != null)
		{
			double length2 = Convert.ToDouble(y);
			y = ConvertLengthToCurrentUnit(length2);
		}
		prismaProbingGeometryParameters.InitializeCoordinates(x, y);
		prismaProbingGeometryParameters.InitializePlane(planeKey);
		if (speed != null)
		{
			double speed2 = Convert.ToDouble(speed);
			speed = ConvertSpeedToCurrentUnit(speed2);
		}
		prismaProbingParameters.InitializeTechnology(refToolKey, speed);
		prismaProbingParameters.InitializeName(name);
		prismaProbingParameters.InitializeExecutionEnable(true);
		prismaProbingBuilder.Add(mainWorkplanKey, workPieceKey, planeKey, -1);
		base.ReferenceKey = prismaProbingBuilder.NcFunction.Key;
	}
}
