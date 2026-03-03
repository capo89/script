using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.AirBlowering;
using ScmGroup.XCam.WorkPlaneManager.DynamicWorkingArea;

namespace ScmGroup.XCam.Scripting;

public interface IScripting
{
	Workpiece ActiveWorkpiece { get; }

	Workplane ActiveWorkplane { get; }

	Operation ActiveOperation { get; }

	Geometry ActiveGeometry { get; }

	LeadInOut ActiveLeadInOut { get; }

	Pattern ActivePattern { get; }

	MachineFunctions ActiveMachineFunctions { get; }

	ToolPath ActiveToolpath { get; }

	Workplan ActiveWorkplan { get; }

	ToolCorrection ActiveToolCorrection { get; }

	double ActiveX { get; }

	double ActiveY { get; }

	double ActiveZ { get; }

	Point CreatPoint(string name, double x, double y);

	Segment CreateSegment(string name, double startX, double startY, double endX, double endY);

	Arc CreateArc3Points(string name, double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y);

	Arc CreateArc2PointRadius(string name, double startX, double startY, double endX, double endY, double radius, bool isClockwise, bool isOver180);

	Arc CreateArc2PointCenter(string name, double startX, double startY, double endX, double endY, double centerX, double centerY, bool isClockwise);

	Arc CreateArcCenterAngle(string name, double startX, double startY, double centerX, double centerY, double angle);

	Circle CreateCircleCenterRadius(string name, double centerX, double centerY, double radius);

	Circle CreateCircleCenterRadius(string name, double centerX, double centerY, double radius, bool isClockwise);

	Circle CreateCircleCenterPoint(string name, double centerX, double centerY, double pointX, double pointY);

	Circle CreateCircleCenterPoint(string name, double centerX, double centerY, double pointX, double pointY, bool isClockwise);

	Ellipse CreateEllipseCenterAxes(string name, double centerX, double centerY, double majorRadius, double minorRadius, double angle);

	Polyline CreatePolyline(string name, double startX, double startY);

	Polyline AddSegmentToPolyline(double endX, double endY, string nameElement = "");

	Polyline AddArc3PointsToPolyline(double p2X, double p2Y, double p3X, double p3Y, string nameElement = "");

	Polyline AddArc2PointCenterToPolyline(double endX, double endY, double centerX, double centerY, bool isClockwise, string nameElement = "");

	Polyline AddArc2PointRadiusToPolyline(double endX, double endY, double radius, bool isClockwise, bool isOver180, string nameElement = "");

	Polyline AddArcCenterAngleToPolyline(double centerX, double centerY, double angle, string nameElement = "");

	Polyline AddFilletToPolyline(double radius, int option = 0, string nameElement = "");

	Polyline AddChamferToPolyline(double length1, double length2, int option = 0, string nameElement = "");

	Polyline ClosePolyline(string nameElement = "");

	Geometry SelectGeometry(string name);

	Geometry SelectGeometry(int index);

	void DeleteGeometry(string name);

	void DeleteGeometry(int index);

	void SetReferencePosition(int referencePosition);

	Workpiece CreateRawWorkpieceBox(string name, double dx, double dy, double dz, double bx = 0.0, double by = 0.0, double bz = 0.0);

	Workpiece CreateRawWorkpieceFromExtrusion(string name, double dz, double bx = 0.0, double by = 0.0, double bz = 0.0, params string[] internalProfiles);

	Workpiece CreateFinishedWorkpieceBox(string name, double dx, double dy, double dz);

	Workpiece CreateFinishedWorkpieceFromExtrusion(string name, double dz, params string[] internalProfiles);

	Workpiece CreateRawWorkpiece(string name, double bx1, double bx2, double by1, double by2, double bz1 = 0.0, double bz2 = 0.0);

	Workpiece SelectWorkpiece(string name);

	Workpiece SelectWorkpiece(int index);

	void DeleteWorkpiece(string name);

	void DeleteWorkpiece(int index);

	void SetWorkpieceSetupPosition(double x, double y, double z, double zRot);

	WorkPieceSetupPosition GetWorkPieceSetupPosition();

	BlockingProfile CreateBlockingProfile(string name, double startX, double startY, double offset = 0.0);

	BlockingProfile AddSegmentToBlockingProfile(double endX, double endY, string nameElement = "");

	BlockingProfile AddArc3PointsToBlockingProfile(double p2X, double p2Y, double p3X, double p3Y, string nameElement = "");

	BlockingProfile AddArc2PointCenterToBlockingProfile(double endX, double endY, double centerX, double centerY, bool isClockwise, string nameElement = "");

	BlockingProfile AddArc2PointRadiusToBlockingProfile(double endX, double endY, double radius, bool isClockwise, bool isOver180, string nameElement = "");

	BlockingProfile AddArcCenterAngleToBlockingProfile(double centerX, double centerY, double angle, string nameElement = "");

	BlockingProfile AddSegmentTanToBlockingProfile(double length, string nameElement = "");

	BlockingProfile AddArcTanToBlockingProfile(double endX, double endY, int option, string nameElement = "");

	BlockingProfile CloseBlockingProfile(string nameElement = "");

	Workplane CreateWorkplane(string name, double p1X, double p1Y, double p1Z, double p2X, double p2Y, double p2Z, double p3X, double p3Y, double p3Z);

	Workplane CreateWorkplane(string name, double X0, double Y0, double Z0, double ZRotation, double XRotation);

	Workplane CreateWorkplane(string name, object X0, object Y0, object Z0, object ZRotation, object XRotation);

	Workplane CreateWorkplane(string name, double offsetZ);

	Workplane SelectWorkplane(string name);

	Workplane SelectWorkplane(int index);

	void DeleteWorkplane(string name);

	void DeleteWorkplane(int index);

	Workplan CreateWorkplan(string name);

	Workplan SelectWorkplan(string name);

	Workplan SelectWorkplan(int index);

	void DeleteWorkplan(string name);

	void DeleteWorkplan(int index);

	Workplan RenameWorkplan(string name);

	Operation CreateRoughFinish(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateAirBlower(string name, double height, double distanceFromProfile, BlowType blowType, AirBlowerType airBlowerType, string description = "", string tool = "-1", string head = "-1", double inputSpeed = -1.0, double speed = -1.0);

	Operation CreateRoughFinish(string name, object depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, object inputSpeed = null, object rotSpeed = null, object speed = null, object overMaterial = null);

	Operation CreateEndTrimming(string name, string edgeBandingName, string tool = "-1", string head = "-1", object inputSpeed = null, object rotSpeed = null, object speed = null, bool setCurrentPos = false, bool useEndTrimmerAggregateCopier = false);

	Operation Create3DRoughFinish(string name, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double? inputZRotation = null, double? inputXRotation = null);

	Operation CreateSlantedRoughFinish(string name, double angleA, double angleB, int toolApproach, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateSlantedRoughFinish(string name, double angleA, double angleB, int toolApproach, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateSlantedRoughFinish(string name, object angleA, object angleB, int toolApproach, object depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, object inputSpeed = null, object rotSpeed = null, object speed = null, object overMaterial = null, bool isCnc = false);

	Operation CreateChamfer(string name, double chamferWidth, double chamferHeight, double overcutLength, int toolPosition, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateTrimming(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.Trimming, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateTrimmingWorkingStep(string name, string description, TrimmingType trimmingType, string tool, string head = "-1", double approachAngle = 0.0, double infeedAdvance = 0.0, double outfeedDelay = 0.0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, double retractAngle = 0.0);

	Operation CreateEdgeScraping(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.EdgeScraping, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateGlueScraping(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.GlueScraping, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateAntiAdhesiveWorkingStep(string name, string description, AntiAdhesiveType antiAdhesiveType, string tool, string head = "-1", double approachAngle = 0.0, object infeedAdvance = null, object outfeedDelay = null, object inputSpeed = null, object rotSpeed = null, object speed = null, double overMaterial = 0.0, double retractAngle = 0.0);

	Operation CreateDrill(string name, double x, double y, double depth, double diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double holeTaperDiameter = 0.0);

	Operation CreateThroughDrill(string name, double x, double y, double diameter, double overcutLength, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double holeTaperDiameter = 0.0);

	Operation CreateDrill(string name, object x, object y, object depth, object diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, string kindOfHole = "-1", object taperHeight = null, object securityQuote = null, object holeTaperDiameter = null);

	Operation CreateThroughDrill(string name, object x, object y, object diameter, object overcutLength, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, string kindOfHole = "-1", object taperHeight = null, object securityQuote = null, object holeTaperDiameter = null);

	Operation CreateSlantedDrill(string name, double x, double y, double z, double angleA, double angleB, double depth, double diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double holeTaperDiameter = 0.0);

	object CreateMacro(string name, string macroName, params object[] macroParameters);

	object CreateMacro(string name, string macroName);

	object ExecMacro(string name, string macroName, params object[] macroParameters);

	void SetMacroParam(string name, object value);

	Operation CreateBladeCut(string name, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double angle = 90.0, int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, bool cutPositionUpper = true, bool materialPositionLeft = true, double referenceOffset = 0.0, double extraDepth = 0.0);

	Operation CreateContourPocket(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.ConcentricalPocket, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overlap = 50.0, bool finalPass = false, params string[] bossNames);

	Operation CreateContour(string name, double depth, int typeOfContour, int sideOfContour, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0);

	Operation CreateSlot(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, double angle = 90.0, double? endDepth = null);

	Operation CreateDowelDrillingOperation(string name, double x, double y, double dowelOuterLength, string description = "", string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, double? securityQuote = null, double glueThickness = 0.5, double? dowelDiameter = null, double? dowelLength = null);

	Operation CreateDowelOperation(string name, double x, double y, double dowelOuterLength, string description = "", double retractDistance = 0.0, double dowelReleaseSpeed = -1.0, double glueThickness = 0.5, double? dowelDiameter = null, double? dowelLength = null, double? approachDistance = null, string head = "-1", double? dowelInsertionDistance = null);

	Operation CreateDowelDrillingOperation(string name, object x, object y, object dowelOuterLength, string description = "", string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, object securityQuote = null, object glueThickness = null, object dowelDiameter = null, object dowelLength = null);

	Operation CreateDowelOperation(string name, object x, object y, object dowelOuterLength, string description = "", object retractDistance = null, object dowelReleaseSpeed = null, object glueThickness = null, object dowelDiameter = null, object dowelLength = null, object approachDistance = null, string head = "-1", object dowelInsertionDistance = null);

	Operation CreateWorkpiecePressureOperation(string name, double startX, double startY, double endX, double endY, double compression, string description = "", double approachSpeed = -1.0, double workingSpeed = -1.0);

	Operation CreatePark(string name, string stopType, bool? toMinQuote);

	Operation CreateWorkPieceProbing(string name, double x, double y, string tool, string head, int type = 0, int headReturnAfterProbing = 0);

	Operation CreatePrismaProbing(string name, object x, object y, string tool, object speed = null);

	Operation CreateWorkPieceTranslationRotationProbing(string name, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head);

	Operation CreateWorkPieceTranslationRotationInternalProbing(string name, object probingXCoordinate, object probingYCoordinate, object probingRectWidth, object probingRectHeight, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head);

	Operation CreateMessage(string name, string text, bool waitForUserInput, bool releaseWorkpiece);

	Operation CreateNullOperation(string name, double? X, double? Y, double? Q, double? speed = null, bool? spindleEnable = null, string tool = "-1");

	Operation CreateIso(string name, string instruction, string optionalParameters = "", bool isXiso = true);

	Operation CreateCombiflexUnloadUnitClamp(string name, double zQuote, double yOffset);

	Operation CreateWorkPieceWidthProbing(string name, double distance);

	LeadInOut SetApproachStrategy(bool isLinear, bool isQuote, double distance, double? speed = null);

	LeadInOut SetRetractStrategy(bool isLinear, bool isQuote, double distance, double overlapLength, double? speed = null);

	void ResetApproachStrategy();

	void ResetRetractStrategy();

	Pattern CreatePattern(int numberOfRows, int numberOfColumns, double rowsDistance, double columnDistance, double rotationAngle, double rowLayoutAngle);

	void ResetPattern();

	Operation SelectOperation(string name);

	Operation SelectOperation(int index);

	void DeleteOperation(string name);

	void DeleteOperation(int index);

	void SetJerk(double gain);

	void ResetJerk();

	void SetJerk3D(double gain);

	void ResetJerk3D();

	void SetCNAutoSpeed();

	void ResetCNAutoSpeed();

	void SetPneumaticHoodPosition(int? position);

	void ResetPneumaticHood();

	void SetMotorizedHoodPosition(double? position);

	void ResetMotorizedHood();

	void SetOppositePneumaticHoodPosition(int? position);

	void ResetOppositePneumaticHood();

	void SetAuxiliaryHoodPosition(int? position);

	void ResetAuxiliaryHood();

	void SetCleaningMode();

	void ResetCleaningMode();

	void SetDustpanOffset(double offset, int? position = null, bool? isInOutEnable = null);

	void SetDustpanOffset(double offset);

	void SetDustpanPosition(int? position = null, bool? isInOutEnable = null);

	void ResetDustpan();

	void SetMotorizedDustpanPosition(double? position = null, bool? isInOutEnable = null);

	void SetMotorizedDustpanOffset(double offset);

	void ResetMotorizedDustpan();

	void SetUnrollHeadMode(int mode = 0, double radiusMultiplier = 1.0);

	void SetUnrollHeadRadiusMultiplier(double radiusMultiplier = 1.0);

	void SetToolCorrection(int correction, double overMaterial = 0.0);

	void SetBrakes(string activeBrakes);

	void SetToolBlower(int toolBlowerMode);

	void ResetToolBlower();

	void SetElectronicZeroProber(double gain, double offset, double compression);

	void ResetElectronicZeroProber();

	void SetPressureRollers(double offset);

	void ResetPressureRollers();

	void SetMechanicalPresser();

	void ResetMechanicalPresser();

	void SetProbingReferenceReferencePoint(int referencePoint);

	void SetMachine(int id);

	void SetSpindles(params int[] spindles);

	void SetPriority(int priority);

	void SetProjectLabel(string labelName);

	void SetWorkPieceLabel(double xStart, double yStart, double rotationDegree);

	void AddLabelParams(params string[] labelParameters);

	EdgeBandingInOut SetEdgeBandingApproachStrategy(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null);

	EdgeBandingInOut SetEdgeBandingRetractStrategy(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null);

	void ResetEdgeBandingApproachStrategy();

	void ResetEdgeBandingRetractStrategy();

	void ResetEdgeDispensing();

	void SetEdgeDispensing(object startOffSet = null, object totalOffSet = null, object safeOffSet = null, bool? isMultiEdgeBandingEnabled = null);

	void SetEdgeSlotDispensing(object startOffSet = null, object totalOffSet = null, object safeOffSet = null, bool? isMultiEdgeBandingEnabled = null);

	void ResetEdgeSlotDispensing();

	void ResetEdgeClosing();

	void SetEdgeClosing(object endOffSet = null, bool? enableCutter = null);

	Operation CreateEdgeBanding(string name, string edge, object depth, bool edgeManualLoading = false, string pressureTool = "-1", bool pressureToolManualLoading = false, object speed = null);

	EdgeBandingSlotInOut SetEdgeBandingSlotApproachStrategy(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null);

	EdgeBandingSlotInOut SetEdgeBandingSlotRetractStrategy(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null);

	void ResetEdgeBandingSlotApproachStrategy();

	void ResetEdgeBandingSlotRetractStrategy();

	Operation CreateEdgeBandingSlotFeature(string name, string edge, object depth, object slotEdgeZ, object angle, bool edgeManualLoading = false, string pressureTool = "-1", bool pressureToolManualLoading = false, object speed = null);

	void ResetRotationDirection();

	void SetRotationDirection(int direction = 0);

	void ResetAutostart();

	void SetAutostart(bool status = true);

	void SetChangeHiddenTool(bool status = true);

	void ResetChangeHiddenTool();

	void SetDisableAdvanceEdgeChange(bool status = true);

	void ResetDisableAdvanceEdgeChange();

	void SetAttribute(string name, double value);

	void SetParametricAttribute(string name, double value, double uPar);

	void SetAttribute2(string name, double value1, double value2);

	void SetStartPointAttribute(int elementIndex, double value);

	void SetEndPointAttribute(int elementIndex, double value);

	void SetParametricAttribute2(string name, double value1, double value2, double uPar);

	void SetToolpathAttribute(string name, double value);

	ContourParallelStrategy CreateContourParallelStrategy(bool insideToOutSide = true, int rotationDirection = 1, bool allowMultiplePasses = false, double cuttingDepth = 0.0, double finishCuttingDepth = 0.0, int strokeConnectionType = 1, bool isHelicStrategy = false, bool isApproachRetractPassStrategy = false, double allowanceSide = 0.0);

	SingleStepDrillingStrategy CreateSingleStepDrillingStrategy();

	BidirectionalMillingStrategy CreateBidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth);

	UnidirectionalMillingStrategy CreateUnidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth, int strokeConnectionType = 1, bool isApproachRetractPassStrategy = false);

	SectioningMillingStrategy CreateSectioningMillingStrategy(double firstCutDepth, double outDistance, double sideMovingDistance = 0.0);

	MultiStepDrillingStrategy CreateMultiStepDrillingStrategy(bool isStepDepth, int stepNumber = 1, double stepDepth = 0.0);

	HelicMillingStrategy CreateHelicMillingStrategy(double cuttingDepth, bool allowsFinishCutting, double finishCuttingDepth);

	PlaneCutterLocationStrategy CreatePlaneCutterLocationStrategy(double zRotation, double xRotation);

	ZigZagMillingStrategy CreateZigZagMillingStrategy(double feedCuttingDepth, double returnCuttingDepth, double finishCuttingDepth);

	EndTrimmingStrategy CreateEndTrimmingStrategy(WorkSide workside, CuttingMethod cuttingMethod, double overMaterial, object overCutLenght = null);

	void SetCompensationMode(bool isCnc);

	void SetStartMachiningPosition(int position);

	void SetFeedrateProfile(string feedrateProfileName);

	void ResetFeedrateProfile();

	ToolPath CreateToolpath(string name, double startX, double startY, double startZ);

	ToolPath3D CreateToolpath3D(string name, double startX, double startY, double startZ);

	ToolPath AddSegmentToToolpath(double endX, double endY, double endZ);

	ToolPath3D AddSegmentToToolpath(double endX, double endY, double endZ, double? ZRotation = null, double? XRotation = null);

	ToolPath AddArc3PointsToToolpath(double p2X, double p2Y, double p3X, double p3Y, double p3Z);

	ToolPath AddArc2PointCenterToToolpath(double endX, double endY, double endZ, double centerX, double centerY, bool isClockwise);

	ToolPath AddArc2PointRadiusToToolpath(double endX, double endY, double endZ, double radius, bool isClockwise, bool isOver180);

	ToolPath AddArcCenterAngleToToolpath(double centerX, double centerY, double endZ, double angle);

	ToolPath SelectToolpath(string name);

	ToolPath SelectToolpath(int index);

	void DeleteToolpath(string name);

	void DeleteToolpath(int index);

	Tool GetTool(string tool);

	void Mirror(string name, bool mirrorX, bool mirrorY, bool reverseOperation = false, bool createNewCopy = false);

	void Rotate(string name, double x, double y, double angle, bool createNewCopy = false);

	Arc CreateFillet(string geom1, string geom2, double radius, int option = 0);

	Polyline CreateFillet(string geom, string element1, string element2, double radius, int option = 0);

	Polyline CreateFillet(string geom, int element1, int element2, double radius, int option = 0);

	Segment CreateChamfer(string geom1, string geom2, double length1, double length2, int option = 0);

	Polyline CreateChamfer(string geom, string element1, string element2, double length1, double length2, int option = 0);

	Polyline CreateChamfer(string geom, int element1, int element2, double length1, double length2, int option = 0);

	void SetIncrementalInput(string axis, bool enable);

	bool GetIncrementalInput(string axis);

	void SetRotation(double angle, double x, double y, double z);

	void SetTranslation(double x, double y, double z, string planeName);

	void SetMirror(bool mirrorX, bool mirrorY, bool arcInversion);

	void SetMirrorX(bool mirror, bool arcInversion);

	void SetMirrorY(bool mirror, bool arcInversion);

	void SetApproachSecurityDistance(double? value = null);

	void SetRetractSecurityDistance(double? value = null);

	void SetMachiningDirection(bool sameDirection);

	MachineParameters SetMachiningParameters(string executionFields, int repetitions, long tableOptions, long mechanicalOptions, bool continuousCycle);

	MachineParameters GetMachiningParameters();

	MachineParameters SetSideStopPositionY(double positionY);

	MachineParameters SetRelatedToOppositeSideStop(bool isRelatedToOppositeSideStop);

	MachineParameters SetDefaultForTableOptions(bool useDefaultForTableOptions);

	MachineParameters SetTechnologicalMirror(bool isTechnologicalMirror);

	MachineParameters SetAutoSetup(bool autoSetup);

	MachineParameters SetOptimization(bool enableOptimization);

	MachineParameters SetWorkPieceSidePresserDisabledOnStart(bool isWorkPieceSidePresserDisabledOnStart);

	MachineParameters SetPreserveWorkingSequence(bool preserveWorkingSequence);

	MachineParameters SetMultipleDrillingsCanChangeWorkingSequence(bool multipleDrillingsCanChangeWorkingSequence);

	MachineParameters SetWorkPieceFallPrevention(bool useWorkPieceFallPrevention);

	MachineParameters SetToeKickWait(bool waitForLeftToeKick, bool waitForRightToeKick);

	MachineParameters SetDescription(string description);

	MachineParameters SetComment(string comment);

	MachineParameters SetEdgeBandingOptimization(bool isRotationOptimizationEnabled, bool isAutostartOptimizationEnabled, bool isClosingOptimizationEnabled, bool isLampOptimizationEnabled, bool isApproachOptimizationEnabled, bool isRetractOptimizationEnabled, bool isRollStopOptimizationEnabled, bool isSpeedOptimizationEnabled, bool isTrimmingOptimizationEnabled);

	MachineParameters SetEnableDynamicAreas(bool enableDynamicAreas);

	void ApplyTechnology(string name);

	void SelectTechnology(string name, params string[] geometryNames);

	void SelectGeometryTechnology(string name, int r, int g, int b);

	void ApplyTechnology();

	double abs(double value);

	double ABS(double value);

	double acos(double value);

	double ACOS(double value);

	double asin(double value);

	double ASIN(double value);

	double atan(double value);

	double ATAN(double value);

	double sin(double value);

	double SIN(double value);

	double COS(double value);

	double cos(double value);

	double TAN(double value);

	double tan(double value);

	double ln(double value);

	double LN(double value);

	double log10(double value);

	double LOG10(double value);

	double exp(double value);

	double EXP(double value);

	double sqrt(double value);

	double SQRT(double value);

	double pow(double x, double y);

	double POW(double x, double y);

	double rd(double value);

	double RD(double value);

	double ru(double value);

	double RU(double value);

	string GetVersion();

	void Print(string message);

	bool NDEF(double? value);

	bool DEF(double? value);

	bool NDEF(string value);

	bool DEF(string value);

	double V(double? par);

	double VALUE(double? par);

	int GetProgrammingOrigine();

	void SetBarPosition(int id, double xPosition);

	void SetMobileBarPosition(int id, int position);

	void SetSupportBasePosition(int id, double yPosition);

	void SetClampPosition(int supportId, double yPosition, int status, string code);

	void SetHorizontalClampPosition(int supportId, double yPosition, int status, string code);

	void SetClampForJambPosition(int supportId, double yPosition, int status, string code);

	void SetSuctionCupPosition(int supportId, double yPosition, double angle, string code);

	void SetMLTFSuctionCupPosition(double xPosition, double yPosition, double angle, string code);

	WorkingField GetWorkingField(string field);

	void AddVariable(string name, object value, int type, int unitType, string description = "", bool isReadOnly = false, bool isExportable = true);

	void InitializeComplexProcess();

	void CreateComplexProcess();

	DynamicWorkingAreaUsageStatus SetDynamicAreaLength(double dynamicWorkingAreaLength);
}
