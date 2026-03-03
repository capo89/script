using System;
using ScmGroup.XCam.MachiningDataModel;

namespace ScmGroup.XCam.Scripting;

public class ScriptingProgramParameter : SubProgramParameter
{
	public object UpdatedValue;

	public int Line;

	public string AssignedValue;

	public ScriptingProgramParameter(string assignedValue, string name, object defaultValue, Type type, string description, ParameterType parameterType, bool isVisible, int line)
		: base(name, defaultValue, type, description, parameterType, isVisible, FisicalUnitType.UnitLess)
	{
		if (8u != 0)
		{
			AssignedValue = assignedValue;
		}
		if (3u != 0)
		{
			UpdatedValue = null;
		}
		if (5u != 0)
		{
			Line = line;
		}
	}

	public override string ToString()
	{
		string empty = string.Empty;
		string text;
		if (uint.MaxValue != 0)
		{
			text = empty;
		}
		if (UpdatedValue != null)
		{
			string result = string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708819), AssignedValue, UpdatedValue);
			if (uint.MaxValue != 0)
			{
				return result;
			}
		}
		else
		{
			string result2 = string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708804), AssignedValue, base.DefaultValue);
			if (3u != 0)
			{
				return result2;
			}
		}
		return text;
	}
}
