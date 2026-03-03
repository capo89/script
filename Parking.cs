using System.Runtime.CompilerServices;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Parking : NCFunction
{
	private bool _0023_003DzisYPgtyCU2DGwsw1xpCVRwU_003D;

	private bool _0023_003DzDoqvKOyMUfY3Rx_0024_Zcc46SwVdX_5;

	public bool ToMinQuote
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (4 == 0)
			{
			}
			return _0023_003DzisYPgtyCU2DGwsw1xpCVRwU_003D;
		}
	}

	public bool ReleaseWorkpiece
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (1 == 0)
			{
			}
			return _0023_003DzDoqvKOyMUfY3Rx_0024_Zcc46SwVdX_5;
		}
	}

	public override bool IsNullOperation => false;

	public override bool IsPark => true;

	public override bool IsMsg => false;

	public override bool IsWorkPieceProbing => false;

	public override bool IsIso => false;

	public override bool IsCombiflexUnloadUnitClamp => false;

	public override bool IsPrismaProbing => false;

	public override bool IsWorkPieceTranslationRotationProbing => false;

	public Parking(OperationContext operationContext, ReferenceKey workplanID)
	{
		_ = 3;
		if (7 == 0)
		{
		}
		_ = 0;
		if (false)
		{
		}
		_ = 1;
		if (1 == 0)
		{
		}
		base._002Ector(operationContext, workplanID);
	}

	public Parking(OperationContext operationContext, string name, ReferenceKey workplanID)
		: this(operationContext, workplanID)
	{
		if (uint.MaxValue != 0)
		{
			base.Name = name;
		}
	}

	public void CreatePark(ActiveProgramParameters activeParameters, string stopType, bool? toMinQuote)
	{
		Park park = new Park();
		Executable executable;
		if (uint.MaxValue != 0)
		{
			executable = park;
		}
		(executable as Park).WorkpieceID = activeParameters.Workpiece.ReferenceKey;
		(executable as Park).Name = base.Name;
		if (stopType == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707967))
		{
			(executable as Park).Stop = StopType.Unlock;
		}
		else if (stopType == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707956))
		{
			(executable as Park).Stop = StopType.NoUnlock;
		}
		else if (stopType == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707939))
		{
			(executable as Park).Stop = StopType.Nothing;
		}
		if (toMinQuote.HasValue)
		{
			bool? flag = toMinQuote;
			bool? flag2;
			if (6u != 0)
			{
				flag2 = flag;
			}
			if (flag2 == true)
			{
				(executable as Park).Limit = LimitType.Minimum;
			}
			else
			{
				(executable as Park).Limit = LimitType.Maximum;
			}
		}
		_projectInterface.AddExecutable(ref executable, _workplanID, this);
		ReferenceKey key = executable.Key;
		if (4u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	internal void _0023_003Dzpb1NS0LplNbe(bool _0023_003Dz3keKASA_003D)
	{
		if (3u != 0)
		{
			_0023_003DzisYPgtyCU2DGwsw1xpCVRwU_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzX4T4e_lyXYb4AhKabCcV_00244w_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (4u != 0)
		{
			_0023_003DzDoqvKOyMUfY3Rx_0024_Zcc46SwVdX_5 = _0023_003Dz3keKASA_003D;
		}
	}
}
