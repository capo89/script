using System;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class ISO : NCFunction
{
	public bool IsXiso
	{
		get
		{
			try
			{
				bool isXiso = (_projectInterface.Get(base.ReferenceKey) as Iso).IsXiso;
				if (6u != 0)
				{
					return isXiso;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701517);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701229) };
				object[] parameters;
				if (2u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public string Instruction
	{
		get
		{
			try
			{
				string text = (_projectInterface.Get(base.ReferenceKey) as Iso).Text;
				if (6u != 0)
				{
					return text;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701517);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701218) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			string result;
			return result;
		}
	}

	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => true;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public ISO(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 0;
		if (7 == 0)
		{
		}
		_ = 0;
		if (1 == 0)
		{
		}
		_ = 0;
		if (5 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public ISO(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (4u != 0)
		{
			base.Name = name;
		}
	}

	public void CreateIso(ActiveProgramParameters activeParameters, string instruction, string optionalParameters = "", bool isXiso = true)
	{
		Iso iso = new Iso();
		Executable executable;
		if (true)
		{
			executable = iso;
		}
		(executable as Iso).Name = base.Name;
		(executable as Iso).Text = instruction;
		(executable as Iso).OptionParameters = optionalParameters;
		(executable as Iso).IsXiso = isXiso;
		(executable as Iso).WorkpieceID = activeParameters.Workpiece.ReferenceKey;
		_projectInterface.AddExecutable(ref executable, _workplanID, this);
		ReferenceKey key = executable.Key;
		if (4u != 0)
		{
			base.ReferenceKey = key;
		}
	}
}
