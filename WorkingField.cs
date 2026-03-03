using System;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.ConfigDataModel.Enumerations;
using ScmGroup.XCam.ConfigDataModel.WorkingAreas;
using ScmGroup.XCam.ExceptionManagement;

namespace ScmGroup.XCam.Scripting;

public class WorkingField : BaseScripting
{
	private WorkingArea _0023_003DzDmr1BvJxWHpn;

	public bool SpecularityX
	{
		get
		{
			try
			{
				bool result;
				if (8u != 0)
				{
					result = false;
				}
				Specularity specularity = _0023_003DzDmr1BvJxWHpn.Specularity;
				Specularity specularity2;
				if (8u != 0)
				{
					specularity2 = specularity;
				}
				if (specularity2 == Specularity.SpecX || specularity2 == Specularity.SpecXY)
				{
					if (5u != 0)
					{
						result = true;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716126) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public bool SpecularityY
	{
		get
		{
			try
			{
				bool result = default(bool);
				if (0 == 0)
				{
					result = false;
				}
				Specularity specularity = _0023_003DzDmr1BvJxWHpn.Specularity;
				Specularity specularity2;
				if (uint.MaxValue != 0)
				{
					specularity2 = specularity;
				}
				if (specularity2 == Specularity.SpecY || specularity2 == Specularity.SpecXY)
				{
					if (4u != 0)
					{
						result = true;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716105) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public double OrigineX
	{
		get
		{
			try
			{
				double xOriginLocation = _0023_003DzDmr1BvJxWHpn.XOriginLocation;
				if (7u != 0)
				{
					return xOriginLocation;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (3u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716856) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double OrigineY
	{
		get
		{
			try
			{
				double yOriginLocation = _0023_003DzDmr1BvJxWHpn.YOriginLocation;
				if (uint.MaxValue != 0)
				{
					return yOriginLocation;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716839) };
				object[] parameters;
				if (7u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double OrigineZ
	{
		get
		{
			try
			{
				double zOriginLocation = _0023_003DzDmr1BvJxWHpn.ZOriginLocation;
				if (8u != 0)
				{
					return zOriginLocation;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716826) };
				object[] parameters;
				if (2u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double Length
	{
		get
		{
			try
			{
				double length = _0023_003DzDmr1BvJxWHpn.Length;
				if (uint.MaxValue != 0)
				{
					return length;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704633) };
				object[] parameters;
				if (8u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double Width
	{
		get
		{
			try
			{
				double width = _0023_003DzDmr1BvJxWHpn.Width;
				if (3u != 0)
				{
					return width;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716809) };
				object[] parameters;
				if (3u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double OrigineXOff
	{
		get
		{
			try
			{
				double xOriginLocationOff = _0023_003DzDmr1BvJxWHpn.XOriginLocationOff;
				if (6u != 0)
				{
					return xOriginLocationOff;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716797) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public double LengthOff
	{
		get
		{
			try
			{
				double lengthOff = _0023_003DzDmr1BvJxWHpn.LengthOff;
				if (0 == 0)
				{
					return lengthOff;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (8u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716779) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result = default(double);
			return result;
		}
	}

	public double OrigineXOffWithSideStopOff
	{
		get
		{
			try
			{
				double xOriginWithSideStopOff = _0023_003DzDmr1BvJxWHpn.XOriginWithSideStopOff;
				if (4u != 0)
				{
					return xOriginWithSideStopOff;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716763) };
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

	public double WidthWithSideStopOff
	{
		get
		{
			try
			{
				double widthWithSideStopOff = _0023_003DzDmr1BvJxWHpn.WidthWithSideStopOff;
				if (5u != 0)
				{
					return widthWithSideStopOff;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716988) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result;
			return result;
		}
	}

	public int FirstLockingBarNumber
	{
		get
		{
			try
			{
				int firstLockingBarNumber = _0023_003DzDmr1BvJxWHpn.FirstLockingBarNumber;
				if (uint.MaxValue != 0)
				{
					return firstLockingBarNumber;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716959) };
				object[] parameters;
				if (uint.MaxValue != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			int result;
			return result;
		}
	}

	public int LockingBarQuantity
	{
		get
		{
			try
			{
				int lockingBarQuantity = _0023_003DzDmr1BvJxWHpn.LockingBarQuantity;
				if (2u != 0)
				{
					return lockingBarQuantity;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716931) };
				object[] parameters;
				if (4u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			int result;
			return result;
		}
	}

	public int PiecesDispositionQuadrant
	{
		get
		{
			try
			{
				int piecesDispositionQuadrant = _0023_003DzDmr1BvJxWHpn.PiecesDispositionQuadrant;
				if (0 == 0)
				{
					return piecesDispositionQuadrant;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716908) };
				object[] parameters;
				if (8u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			int result = default(int);
			return result;
		}
	}

	public string ReferenceBarUniqueCode
	{
		get
		{
			try
			{
				string referenceBarUniqueCode = _0023_003DzDmr1BvJxWHpn.ReferenceBarUniqueCode;
				if (8u != 0)
				{
					return referenceBarUniqueCode;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716876) };
				object[] parameters;
				if (7u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			string result;
			return result;
		}
	}

	public int SideStopOffsetAutomaticControl
	{
		get
		{
			try
			{
				int result;
				if (8u != 0)
				{
					result = 0;
				}
				SideStopOffsetAutomaticControlType sideStopOffsetAutomaticControl = _0023_003DzDmr1BvJxWHpn.SideStopOffsetAutomaticControl;
				SideStopOffsetAutomaticControlType sideStopOffsetAutomaticControlType;
				if (6u != 0)
				{
					sideStopOffsetAutomaticControlType = sideStopOffsetAutomaticControl;
				}
				switch (sideStopOffsetAutomaticControlType)
				{
				case SideStopOffsetAutomaticControlType.No:
					if (0 == 0)
					{
						result = 0;
					}
					break;
				case SideStopOffsetAutomaticControlType.Header:
					result = 1;
					break;
				case SideStopOffsetAutomaticControlType.Automatic:
					result = 2;
					break;
				default:
					result = 0;
					break;
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716166);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716589) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public WorkingField(ConfigurationInterface configurationInterface)
	{
		if (3u != 0)
		{
			_configurationInterface = configurationInterface;
		}
		WorkingArea workingArea = new WorkingArea();
		if (4u != 0)
		{
			_0023_003DzDmr1BvJxWHpn = workingArea;
		}
	}

	public void CreateWorkingField(string field)
	{
		WorkingArea workingArea = _configurationInterface.GetWorkingArea(field);
		if (2u != 0)
		{
			_0023_003DzDmr1BvJxWHpn = workingArea;
		}
	}

	public bool IsValidWorkingField()
	{
		bool result;
		if (true)
		{
			result = false;
		}
		if (_0023_003DzDmr1BvJxWHpn != null)
		{
			if (8u != 0)
			{
				result = true;
			}
		}
		return result;
	}
}
