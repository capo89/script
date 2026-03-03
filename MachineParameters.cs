using System;
using ScmGroup.XCam.ConfigDataModel;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.ConfigDataModel.WorkingAreas;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;

namespace ScmGroup.XCam.Scripting;

public class MachineParameters : BaseScripting
{
	private XilogHeaderParameters _0023_003DzJLXwUEB_0024lmk7;

	public bool IsContinuousCycle
	{
		get
		{
			try
			{
				bool continuousCycle = _0023_003DzJLXwUEB_0024lmk7.ContinuousCycle;
				if (7u != 0)
				{
					return continuousCycle;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701152) };
				object[] parameters;
				if (true)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool IsProjectOptimized
	{
		get
		{
			try
			{
				bool isProjectOptimized = _0023_003DzJLXwUEB_0024lmk7.IsProjectOptimized;
				if (0 == 0)
				{
					return isProjectOptimized;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701152) };
				object[] parameters;
				if (8u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result = default(bool);
			return result;
		}
	}

	public string Field
	{
		get
		{
			try
			{
				string executionFields = _0023_003DzJLXwUEB_0024lmk7.ExecutionFields;
				if (3u != 0)
				{
					return executionFields;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701128) };
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

	public long MechanicalOptions
	{
		get
		{
			try
			{
				long mechanicalOptions = _0023_003DzJLXwUEB_0024lmk7.MechanicalOptions;
				if (7u != 0)
				{
					return mechanicalOptions;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701362) };
				object[] parameters;
				if (4u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			long result;
			return result;
		}
	}

	public long TableOptions
	{
		get
		{
			try
			{
				long tableOptions = _0023_003DzJLXwUEB_0024lmk7.TableOptions;
				if (0 == 0)
				{
					return tableOptions;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701338) };
				object[] parameters;
				if (4u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			long result = default(long);
			return result;
		}
	}

	public bool IsTechnologicalMirror
	{
		get
		{
			try
			{
				bool isTechnologicalMirror = _0023_003DzJLXwUEB_0024lmk7.IsTechnologicalMirror;
				if (6u != 0)
				{
					return isTechnologicalMirror;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701317) };
				object[] parameters;
				if (true)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public double LocationX
	{
		get
		{
			try
			{
				double workpieceOffsetX = _0023_003DzJLXwUEB_0024lmk7.WorkpieceOffsetX;
				if (7u != 0)
				{
					return workpieceOffsetX;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701289) };
				object[] parameters;
				if (uint.MaxValue != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double LocationY
	{
		get
		{
			try
			{
				double workpieceOffsetY = _0023_003DzJLXwUEB_0024lmk7.WorkpieceOffsetY;
				if (6u != 0)
				{
					return workpieceOffsetY;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701273) };
				object[] parameters;
				if (4u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double LocationZ
	{
		get
		{
			try
			{
				double workpieceOffsetZ = _0023_003DzJLXwUEB_0024lmk7.WorkpieceOffsetZ;
				if (0 == 0)
				{
					return workpieceOffsetZ;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701257) };
				object[] parameters;
				if (true)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public bool IsRelatedToOppositeSideStop
	{
		get
		{
			try
			{
				bool isRelatedToOppositeSideStop = _0023_003DzJLXwUEB_0024lmk7.IsRelatedToOppositeSideStop;
				if (5u != 0)
				{
					return isRelatedToOppositeSideStop;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708153) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool UseDefaultForTableOptions
	{
		get
		{
			try
			{
				bool useDefaultForTableOptions = _0023_003DzJLXwUEB_0024lmk7.UseDefaultForTableOptions;
				if (3u != 0)
				{
					return useDefaultForTableOptions;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708119) };
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

	public bool AutoSetup
	{
		get
		{
			try
			{
				bool autoSetup = _0023_003DzJLXwUEB_0024lmk7.AutoSetup;
				if (3u != 0)
				{
					return autoSetup;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (2u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708087) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool IsWorkPieceSidePresserDisabledOnStart
	{
		get
		{
			try
			{
				bool isWorkPieceSidePresserDisabledOnStart = _0023_003DzJLXwUEB_0024lmk7.IsWorkPieceSidePresserDisabledOnStart;
				if (true)
				{
					return isWorkPieceSidePresserDisabledOnStart;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708071) };
				object[] parameters;
				if (8u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool PreserveWorkingSequence
	{
		get
		{
			try
			{
				bool preserveWorkingSequence = _0023_003DzJLXwUEB_0024lmk7.PreserveWorkingSequence;
				if (true)
				{
					return preserveWorkingSequence;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708283) };
				object[] parameters;
				if (4u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool MultipleDrillingsCanChangeWorkingSequence
	{
		get
		{
			try
			{
				bool multipleDrillingsCanChangeWorkingSequence = _0023_003DzJLXwUEB_0024lmk7.MultipleDrillingsCanChangeWorkingSequence;
				if (true)
				{
					return multipleDrillingsCanChangeWorkingSequence;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708253) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool UseCyflexWorkPieceFallPrevention
	{
		get
		{
			try
			{
				bool useCyflexWorkPieceFallPrevention = _0023_003DzJLXwUEB_0024lmk7.UseCyflexWorkPieceFallPrevention;
				if (true)
				{
					return useCyflexWorkPieceFallPrevention;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708205) };
				object[] parameters;
				if (8u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool WaitForLeftToeKick
	{
		get
		{
			try
			{
				bool waitForLeftToeKick = _0023_003DzJLXwUEB_0024lmk7.WaitForLeftToeKick;
				if (2u != 0)
				{
					return waitForLeftToeKick;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708168) };
				object[] parameters;
				if (true)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			bool result;
			return result;
		}
	}

	public bool WaitForRightToeKick
	{
		get
		{
			try
			{
				bool waitForRightToeKick = _0023_003DzJLXwUEB_0024lmk7.WaitForRightToeKick;
				if (uint.MaxValue != 0)
				{
					return waitForRightToeKick;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707885) };
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

	public string Comment
	{
		get
		{
			try
			{
				string comment = _0023_003DzJLXwUEB_0024lmk7.Comment;
				if (4u != 0)
				{
					return comment;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707859) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			string result;
			return result;
		}
	}

	public string Description
	{
		get
		{
			try
			{
				string description = _0023_003DzJLXwUEB_0024lmk7.Description;
				if (8u != 0)
				{
					return description;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701200);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707845) };
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

	public MachineParameters(ProjectInterface projectInterface)
	{
		if (8u != 0)
		{
			_projectInterface = projectInterface;
		}
		XilogHeaderParameters obj = _projectInterface.GetMachiningParameters() as XilogHeaderParameters;
		if (4u != 0)
		{
			_0023_003DzJLXwUEB_0024lmk7 = obj;
		}
		if (_0023_003DzJLXwUEB_0024lmk7 == null)
		{
			XilogHeaderParameters xilogHeaderParameters = new XilogHeaderParameters();
			if (uint.MaxValue != 0)
			{
				_0023_003DzJLXwUEB_0024lmk7 = xilogHeaderParameters;
			}
		}
	}

	public void SetMachiningParameters(string executionFields, int repetitions, long tableOptions, long mechanicalOptions, bool continuousCycle)
	{
		_ = 8;
		if (7 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = -1;
		if (6 == 0)
		{
		}
		xilogHeaderParameters.ExecutionFields = executionFields;
		_ = 7;
		if (4 == 0)
		{
		}
		_0023_003DzJLXwUEB_0024lmk7.Repetitions = repetitions;
		_0023_003DzJLXwUEB_0024lmk7.TableOptions = tableOptions;
		_0023_003DzJLXwUEB_0024lmk7.MechanicalOptions = mechanicalOptions;
		_0023_003DzJLXwUEB_0024lmk7.ContinuousCycle = continuousCycle;
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetSideStopPositionY(double positionY)
	{
		_ = 8;
		if (7 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 0;
		if (1 == 0)
		{
		}
		xilogHeaderParameters.SideStopPositionY = positionY;
		_ = 7;
		if (4 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetRelatedToOppositeSideStop(bool isRelatedToOppositeSideStop)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 5;
		if (8 == 0)
		{
		}
		xilogHeaderParameters.IsRelatedToOppositeSideStop = isRelatedToOppositeSideStop;
		_ = -1;
		if (3 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetDefaultForTableOptions(bool useDefaultForTableOptions)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 5;
		if (1 == 0)
		{
		}
		xilogHeaderParameters.UseDefaultForTableOptions = useDefaultForTableOptions;
		_ = 0;
		if (1 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetTechnologicalMirror(bool isTechnologicalMirror)
	{
		_ = 2;
		if (5 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = -1;
		if (6 == 0)
		{
		}
		xilogHeaderParameters.IsTechnologicalMirror = isTechnologicalMirror;
		_ = 6;
		if (6 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetAutoSetup(bool autoSetup)
	{
		_ = 6;
		if (5 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 2;
		if (-1 == 0)
		{
		}
		xilogHeaderParameters.AutoSetup = autoSetup;
		_ = 1;
		if (2 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetWorkPieceSidePresserDisabledOnStart(bool isWorkPieceSidePresserDisabledOnStart)
	{
		_ = 1;
		if (-1 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 4;
		if (1 == 0)
		{
		}
		xilogHeaderParameters.IsWorkPieceSidePresserDisabledOnStart = isWorkPieceSidePresserDisabledOnStart;
		_ = 3;
		if (8 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetPreserveWorkingSequence(bool preserveWorkingSequence)
	{
		_ = 1;
		if (6 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 3;
		if (1 == 0)
		{
		}
		xilogHeaderParameters.PreserveWorkingSequence = preserveWorkingSequence;
		_ = 2;
		if (1 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetMultipleDrillingsCanChangeWorkingSequence(bool multipleDrillingsCanChangeWorkingSequence)
	{
		_ = 5;
		if (-1 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 4;
		if (1 == 0)
		{
		}
		xilogHeaderParameters.MultipleDrillingsCanChangeWorkingSequence = multipleDrillingsCanChangeWorkingSequence;
		_ = 5;
		if (3 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetWorkPieceFallPrevention(bool useWorkPieceFallPrevention)
	{
		_ = 8;
		if (4 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 4;
		if (6 == 0)
		{
		}
		xilogHeaderParameters.UseCyflexWorkPieceFallPrevention = useWorkPieceFallPrevention;
		_ = 2;
		if (2 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetToeKickWait(bool waitForLeftToeKick, bool waitForRightToeKick)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 5;
		if (7 == 0)
		{
		}
		xilogHeaderParameters.WaitForLeftToeKick = waitForLeftToeKick;
		_ = -1;
		if (3 == 0)
		{
		}
		_0023_003DzJLXwUEB_0024lmk7.WaitForRightToeKick = waitForRightToeKick;
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetOptimization(bool optimizationEnabled)
	{
		_ = 4;
		if (8 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 6;
		if (5 == 0)
		{
		}
		xilogHeaderParameters.OptimizationEnabled = optimizationEnabled;
		_ = 6;
		if (2 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetComment(string comment)
	{
		_ = 5;
		if (false)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 1;
		if (6 == 0)
		{
		}
		xilogHeaderParameters.Comment = comment;
		_ = 8;
		if (5 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetDescription(string description)
	{
		_ = 0;
		if (4 == 0)
		{
		}
		XilogHeaderParameters xilogHeaderParameters = _0023_003DzJLXwUEB_0024lmk7;
		_ = 0;
		if (-1 == 0)
		{
		}
		xilogHeaderParameters.Description = description;
		_ = 4;
		if (7 == 0)
		{
		}
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetEdgeBandingOptimization(bool isRotationOptimizationEnabled, bool isAutostartOptimizationEnabled, bool isClosingOptimizationEnabled, bool isLampOptimizationEnabled, bool isApproachOptimizationEnabled, bool isRetractOptimizationEnabled, bool isRollStopOptimizationEnabled, bool isSpeedOptimizationEnabled, bool isTrimmingOptimizationEnabled)
	{
		if (!(isRotationOptimizationEnabled || isAutostartOptimizationEnabled || isClosingOptimizationEnabled || isLampOptimizationEnabled || isApproachOptimizationEnabled || isRetractOptimizationEnabled || isRollStopOptimizationEnabled || isSpeedOptimizationEnabled || isTrimmingOptimizationEnabled))
		{
			return;
		}
		EdgeBandingMachiningParameters edgeBandingParameters = _0023_003DzJLXwUEB_0024lmk7.EdgeBandingParameters;
		EdgeBandingMachiningParameters edgeBandingMachiningParameters;
		if (5u != 0)
		{
			edgeBandingMachiningParameters = edgeBandingParameters;
		}
		if (edgeBandingMachiningParameters == null)
		{
			_0023_003DzJLXwUEB_0024lmk7.EdgeBandingParameters = new EdgeBandingMachiningParameters();
			EdgeBandingMachiningParameters edgeBandingParameters2 = _0023_003DzJLXwUEB_0024lmk7.EdgeBandingParameters;
			if (8u != 0)
			{
				edgeBandingMachiningParameters = edgeBandingParameters2;
			}
		}
		edgeBandingMachiningParameters.IsApproachOptimizationEnabled = isApproachOptimizationEnabled;
		edgeBandingMachiningParameters.IsAutostartOrParkOptimizationEnabled = isAutostartOptimizationEnabled;
		edgeBandingMachiningParameters.IsClosingOptimizationEnabled = isClosingOptimizationEnabled;
		edgeBandingMachiningParameters.IsLampOptimizationEnabled = isLampOptimizationEnabled;
		edgeBandingMachiningParameters.IsRetractOptimizationEnabled = isRetractOptimizationEnabled;
		edgeBandingMachiningParameters.IsRollStopOptimizationEnabled = isRollStopOptimizationEnabled;
		edgeBandingMachiningParameters.IsRotationOptimizationEnabled = isRotationOptimizationEnabled;
		edgeBandingMachiningParameters.IsSpeedOptimizationEnabled = isSpeedOptimizationEnabled;
		edgeBandingMachiningParameters.IsTrimmingOptimizationEnabled = isTrimmingOptimizationEnabled;
		_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
	}

	public void SetEnableDynamicAreas(ConfigurationInterface configurationInterface, bool enableDynamicAreas)
	{
		if (configurationInterface == null)
		{
			return;
		}
		Machine configurationMachine = configurationInterface.GetConfigurationMachine(clone: false);
		Machine machine;
		if (4u != 0)
		{
			machine = configurationMachine;
		}
		if (machine != null)
		{
			WorkingAreaCollection workingAreaCollection = machine.FirstOrDefault<WorkingAreaCollection>(clone: false);
			WorkingAreaCollection workingAreaCollection2;
			if (8u != 0)
			{
				workingAreaCollection2 = workingAreaCollection;
			}
			if (workingAreaCollection2 != null && workingAreaCollection2.IsDesignedToUseDynamicArea)
			{
				_0023_003DzJLXwUEB_0024lmk7.EnableDynamicAreas = enableDynamicAreas;
				_projectInterface.SetMachiningParameters(_0023_003DzJLXwUEB_0024lmk7, null);
			}
		}
	}
}
