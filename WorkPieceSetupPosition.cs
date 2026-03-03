using System;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class WorkPieceSetupPosition : BaseScripting
{
	private sealed class _0023_003DzbIRirHCLsj_RbilVKA_003D_003D
	{
		public ReferenceKey _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D;

		public _0023_003DzbIRirHCLsj_RbilVKA_003D_003D()
		{
			_ = -1;
			if (1 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzrE6DPJtmRepq5fNPRw_003D_003D(WorkpieceSetup _0023_003DzSJfYMT8_003D)
		{
			_ = 2;
			if (3 == 0)
			{
			}
			ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
			_ = 6;
			if (-1 == 0)
			{
			}
			return workpieceID == _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D;
		}
	}

	private WorkpieceSetup _0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D;

	public double LocationX
	{
		get
		{
			try
			{
				double num;
				if (true)
				{
					num = 0.0;
				}
				if (_0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D != null && _0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D.Placement != null)
				{
					double locationX = _0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D.Placement.LocationX;
					if (0 == 0)
					{
						num = locationX;
					}
				}
				double result = num;
				if (true)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716204);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701289) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double LocationY
	{
		get
		{
			try
			{
				double num;
				if (3u != 0)
				{
					num = 0.0;
				}
				if (_0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D != null && _0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D.Placement != null)
				{
					double locationY = _0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D.Placement.LocationY;
					if (true)
					{
						num = locationY;
					}
				}
				double result = num;
				if (3u != 0)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716204);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701273) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double LocationZ
	{
		get
		{
			try
			{
				double num;
				if (7u != 0)
				{
					num = 0.0;
				}
				if (_0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D != null && _0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D.Placement != null)
				{
					double locationZ = _0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D.Placement.LocationZ;
					if (2u != 0)
					{
						num = locationZ;
					}
				}
				double result = num;
				if (true)
				{
					return result;
				}
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716204);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701257) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public WorkPieceSetupPosition(ProjectInterface projectInterface, ReferenceKey workPieceKey, ReferenceKey mainWorkplanKey)
	{
		_0023_003DzbIRirHCLsj_RbilVKA_003D_003D _0023_003DzbIRirHCLsj_RbilVKA_003D_003D = new _0023_003DzbIRirHCLsj_RbilVKA_003D_003D();
		_0023_003DzbIRirHCLsj_RbilVKA_003D_003D _0023_003DzbIRirHCLsj_RbilVKA_003D_003D2;
		if (4u != 0)
		{
			_0023_003DzbIRirHCLsj_RbilVKA_003D_003D2 = _0023_003DzbIRirHCLsj_RbilVKA_003D_003D;
		}
		if (5u != 0)
		{
			_0023_003DzbIRirHCLsj_RbilVKA_003D_003D2._0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D = workPieceKey;
		}
		base._002Ector();
		if (uint.MaxValue != 0)
		{
			_projectInterface = projectInterface;
		}
		MainWorkplan mainWorkplan = null;
		WorkPlan workPlan = projectInterface.Get(mainWorkplanKey) as WorkPlan;
		if (workPlan is MainWorkplan)
		{
			mainWorkplan = workPlan as MainWorkplan;
		}
		else if (workPlan is SubProgram)
		{
			mainWorkplan = _projectInterface.GetExecutableWorkplan(workPlan.Key);
		}
		if (mainWorkplan == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711024), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		}
		_0023_003DzkJQ_0024C2VuyMPwHMOirA_003D_003D = mainWorkplan.Setup.WorkpieceSetups.Find(_0023_003DzbIRirHCLsj_RbilVKA_003D_003D2._0023_003DzrE6DPJtmRepq5fNPRw_003D_003D);
	}
}
