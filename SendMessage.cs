using System;
using System.Runtime.CompilerServices;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class SendMessage : NCFunction
{
	private bool _0023_003Dz66mzPoWNCPNJb_3VYKFEY5Q_003D;

	private bool _0023_003DzDoqvKOyMUfY3Rx_0024_Zcc46SwVdX_5;

	public string Text
	{
		get
		{
			try
			{
				string text = (_projectInterface.Get(base.ReferenceKey) as Xmsg).Text;
				if (uint.MaxValue != 0)
				{
					return text;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708940);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709668) };
				object[] parameters;
				if (2u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			string result;
			return result;
		}
	}

	public bool WaitForUserInput
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (1 == 0)
			{
			}
			return _0023_003Dz66mzPoWNCPNJb_3VYKFEY5Q_003D;
		}
	}

	public bool ReleaseWorkpiece
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (5 == 0)
			{
			}
			return _0023_003DzDoqvKOyMUfY3Rx_0024_Zcc46SwVdX_5;
		}
	}

	public override bool IsNullOperation => false;

	public override bool IsPark => false;

	public override bool IsMsg => true;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public SendMessage(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 4;
		if (3 == 0)
		{
		}
		_ = 4;
		if (7 == 0)
		{
		}
		_ = 6;
		if (8 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public SendMessage(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (7u != 0)
		{
			base.Name = name;
		}
	}

	public void CreateMessage(ActiveProgramParameters activeParameters, string text, bool waitForUserInput, bool releaseWorkpiece)
	{
		Xmsg xmsg = new Xmsg();
		Executable executable;
		if (2u != 0)
		{
			executable = xmsg;
		}
		(executable as Xmsg).Text = text;
		(executable as Xmsg).Name = base.Name;
		(executable as Xmsg).WorkpieceID = activeParameters.Workpiece.ReferenceKey;
		if (!waitForUserInput)
		{
			(executable as Xmsg).Stop = StopType.Nothing;
		}
		else if (!releaseWorkpiece)
		{
			(executable as Xmsg).Stop = StopType.NoUnlock;
		}
		else
		{
			(executable as Xmsg).Stop = StopType.Unlock;
		}
		_projectInterface.AddExecutable(ref executable, _workplanID, this);
		ReferenceKey key = executable.Key;
		if (7u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	internal void _0023_003DzC5V4yOLfgn04TksGZA_003D_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003Dz66mzPoWNCPNJb_3VYKFEY5Q_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzX4T4e_lyXYb4AhKabCcV_00244w_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (2u != 0)
		{
			_0023_003DzDoqvKOyMUfY3Rx_0024_Zcc46SwVdX_5 = _0023_003Dz3keKASA_003D;
		}
	}
}
