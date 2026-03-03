using System;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class NullOperation : NCFunction
{
	public double? X
	{
		get
		{
			try
			{
				double? x = (_projectInterface.Get(base.ReferenceKey) as Xn).X;
				if (6u != 0)
				{
					return x;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707827);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641) };
				object[] parameters;
				if (5u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double? result;
			return result;
		}
	}

	public double? Y
	{
		get
		{
			try
			{
				double? y = (_projectInterface.Get(base.ReferenceKey) as Xn).Y;
				if (2u != 0)
				{
					return y;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707827);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633) };
				object[] parameters;
				if (2u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double? result;
			return result;
		}
	}

	public double Speed
	{
		get
		{
			try
			{
				double speed = (_projectInterface.Get(base.ReferenceKey) as Xn).Speed;
				if (0 == 0)
				{
					return speed;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707827);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707785) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public bool SpindleEnabled
	{
		get
		{
			try
			{
				if ((_projectInterface.Get(base.ReferenceKey) as Xn).SpindleEnable == SpindleEnableType.On)
				{
					if (2u != 0)
					{
						return true;
					}
				}
				else if (2u != 0)
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707827);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708029) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public string Tool
	{
		get
		{
			try
			{
				string result = (_projectInterface.Get(base.ReferenceKey) as Xn).Tool.ToString();
				if (6u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707827);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010) };
				object[] parameters;
				if (uint.MaxValue != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			string result2;
			return result2;
		}
	}

	public bool IsGlobalReferenceActive
	{
		get
		{
			try
			{
				if ((_projectInterface.Get(base.ReferenceKey) as Xn).Reference == ReferenceType.Absolute)
				{
					if (3u != 0)
					{
						return true;
					}
				}
				else if (uint.MaxValue != 0)
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707827);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707997) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public override bool IsNullOperation => true;

	public override bool IsPark => false;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public NullOperation(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 0;
		if (false)
		{
		}
		_ = 2;
		if (-1 == 0)
		{
		}
		_ = 4;
		if (6 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public NullOperation(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (0 == 0)
		{
			base.Name = name;
		}
	}

	public void CreateNullOperation(ActiveProgramParameters activeParameters, ReferenceToolKey toolReference, double? X = null, double? Y = null, double? Q = null, double? speed = null, bool? spindleEnable = null)
	{
		Xn xn = new Xn();
		Executable executable;
		if (true)
		{
			executable = xn;
		}
		(executable as Xn).Name = base.Name;
		(executable as Xn).X = X;
		(executable as Xn).Y = Y;
		(executable as Xn).Reference = ((!Q.HasValue || Q.Value == 0.0) ? ReferenceType.Absolute : ReferenceType.Relative);
		(executable as Xn).Speed = (speed.HasValue ? speed.Value : 0.0);
		(executable as Xn).SpindleEnable = ((spindleEnable.HasValue && spindleEnable.Value) ? SpindleEnableType.On : SpindleEnableType.Off);
		(executable as Xn).Tool = toolReference;
		(executable as Xn).WorkpieceID = activeParameters.Workpiece.ReferenceKey;
		_projectInterface.AddExecutable(ref executable, _workplanID, this);
		ReferenceKey key = executable.Key;
		if (true)
		{
			base.ReferenceKey = key;
		}
	}
}
