using System.Collections.Generic;

namespace ScmGroup.XCam.Scripting;

public abstract class Geometry : BaseScripting
{
	public abstract bool IsPoint { get; }

	public abstract bool IsSegment { get; }

	public abstract bool IsArc { get; }

	public abstract bool IsPolyline { get; }

	public abstract bool IsCircle { get; }

	public abstract bool IsEllipse { get; }

	public abstract bool IsArcOfEllipse { get; }

	public abstract bool IsClockWise { get; }

	public abstract bool IsClosed { get; }

	public abstract List<Geometry> Elements { get; }

	public abstract double Length { get; }

	public abstract double StartXLocal { get; }

	public abstract double StartYLocal { get; }

	public abstract double StartZLocal { get; }

	public abstract double StartXGlobal { get; }

	public abstract double StartYGlobal { get; }

	public abstract double StartZGlobal { get; }

	public abstract double CenterXLocal { get; }

	public abstract double CenterYLocal { get; }

	public abstract double CenterZLocal { get; }

	public abstract double CenterXGlobal { get; }

	public abstract double CenterYGlobal { get; }

	public abstract double CenterZGlobal { get; }

	public abstract double EndXLocal { get; }

	public abstract double EndYLocal { get; }

	public abstract double EndZLocal { get; }

	public abstract double EndXGlobal { get; }

	public abstract double EndYGlobal { get; }

	public abstract double EndZGlobal { get; }

	protected Geometry()
	{
		_ = 1;
		if (4 == 0)
		{
		}
		base._002Ector();
	}
}
