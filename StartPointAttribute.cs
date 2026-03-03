using ScmGroup.XCam.MachiningDataModel;

namespace ScmGroup.XCam.Scripting;

public class StartPointAttribute : Attribute
{
	public StartPointAttribute()
	{
		_ = -1;
		if (false)
		{
		}
		base._002Ector();
	}

	public StartPointAttribute(OperationAttribute value, int index = 0)
	{
		_ = 8;
		if (5 == 0)
		{
		}
		_ = 0;
		if (4 == 0)
		{
		}
		_ = 3;
		if (7 == 0)
		{
		}
		base._002Ector(value, index);
	}

	public StartPointAttribute(StartPointAttribute attribute)
	{
		OperationAttribute value = ((attribute.Value != null) ? (attribute.Value.Clone() as OperationAttribute) : null);
		if (4u != 0)
		{
			base.Value = value;
		}
		int index = attribute.Index;
		if (true)
		{
			base.Index = index;
		}
	}
}
