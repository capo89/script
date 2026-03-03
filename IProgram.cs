using System.Collections.Generic;

namespace ScmGroup.XCam.Scripting;

public interface IProgram : IScripting
{
	List<Workpiece> Workpieces { get; }

	List<Workplane> Workplanes { get; }

	List<Operation> Operations { get; }

	List<Geometry> Geometries { get; }

	List<Workplan> Workplans { get; }

	List<ToolPath> ToolPaths { get; }
}
