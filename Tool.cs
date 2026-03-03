using System;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Common;

namespace ScmGroup.XCam.Scripting;

public class Tool : BaseScripting
{
	public string Description
	{
		get
		{
			try
			{
				string value = _toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.Description).Value;
				if (2u != 0)
				{
					return value;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707845) };
				object[] parameters;
				if (uint.MaxValue != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			string result;
			return result;
		}
	}

	public double TotalLength
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.OverallAssemblyLength).Value);
				if (uint.MaxValue != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709814) };
				object[] parameters;
				if (6u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double PilotLength
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.PilotLength).Value);
				if (4u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709796) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double CutterLength
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.SinkingLength).Value);
				if (3u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = default(Exception);
				if (0 == 0)
				{
					ex2 = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				Exception innerException = ex2;
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709778) };
				object[] parameters;
				if (2u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double TotalDiameter
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.OverallAssemblyDiameter).Value);
				if (uint.MaxValue != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (4u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709757) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double CuttingDiameter
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.OverallCuttingDiameter).Value);
				if (uint.MaxValue != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (true)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709737) };
				object[] parameters;
				if (3u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double Radius
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.Diameter).Value) / 2.0;
				if (2u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (uint.MaxValue != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709710) };
				object[] parameters;
				if (7u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double BladeThickness
	{
		get
		{
			try
			{
				double result;
				if (6u != 0)
				{
					result = 0.0;
				}
				ToolPropertyValue toolPropertyValue = _toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.BladeThickness);
				ToolPropertyValue toolPropertyValue2;
				if (8u != 0)
				{
					toolPropertyValue2 = toolPropertyValue;
				}
				if (toolPropertyValue2 != null)
				{
					double num = Convert.ToDouble(toolPropertyValue2.Value);
					if (true)
					{
						result = num;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709439) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public double MortiserWidth
	{
		get
		{
			try
			{
				double result;
				if (5u != 0)
				{
					result = 0.0;
				}
				ToolPropertyValue toolPropertyValue = _toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.MortiserWidth);
				ToolPropertyValue toolPropertyValue2;
				if (true)
				{
					toolPropertyValue2 = toolPropertyValue;
				}
				if (toolPropertyValue2 != null)
				{
					double num = Convert.ToDouble(toolPropertyValue2.Value);
					if (3u != 0)
					{
						result = num;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709420) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public double MortiserThickness
	{
		get
		{
			try
			{
				double result;
				if (2u != 0)
				{
					result = 0.0;
				}
				ToolPropertyValue toolPropertyValue = _toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.MortiserThickness);
				ToolPropertyValue toolPropertyValue2;
				if (5u != 0)
				{
					toolPropertyValue2 = toolPropertyValue;
				}
				if (toolPropertyValue2 != null)
				{
					double num = Convert.ToDouble(toolPropertyValue2.Value);
					if (0 == 0)
					{
						result = num;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709400) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public double MortiserRoundLength
	{
		get
		{
			try
			{
				double result;
				if (7u != 0)
				{
					result = 0.0;
				}
				ToolPropertyValue toolPropertyValue = _toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.MortiserRoundLength);
				ToolPropertyValue toolPropertyValue2;
				if (8u != 0)
				{
					toolPropertyValue2 = toolPropertyValue;
				}
				if (toolPropertyValue2 != null)
				{
					double num = Convert.ToDouble(toolPropertyValue2.Value);
					if (4u != 0)
					{
						result = num;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709376) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public double Angle
	{
		get
		{
			try
			{
				if (true)
				{
					return 0.0;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709350) };
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

	public double MaxSpindleSpeed
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.MaximimSpindleSpeed).Value);
				if (3u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (6u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709338) };
				object[] parameters = default(object[]);
				if (0 == 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double MaxFeedSpeed
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.MaximimFeedRate).Value);
				if (7u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709316) };
				object[] parameters;
				if (7u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public double StandardFeedSpeed
	{
		get
		{
			try
			{
				double result = Convert.ToDouble(_toolInterface.GetToolPropertyValue(base.ReferenceKey, KindOfToolProperty.StandardFeedRate).Value);
				if (5u != 0)
				{
					return result;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (7u != 0)
				{
					innerException = ex;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709551) };
				object[] parameters;
				if (7u != 0)
				{
					parameters = obj;
				}
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
			double result2;
			return result2;
		}
	}

	public int ToolFamily
	{
		get
		{
			try
			{
				int result = default(int);
				if (0 == 0)
				{
					result = 0;
				}
				ToolFamilyInfo toolFamily = _toolInterface.GetToolFamily(base.ReferenceKey);
				ToolFamilyInfo toolFamilyInfo = default(ToolFamilyInfo);
				if (0 == 0)
				{
					toolFamilyInfo = toolFamily;
				}
				if (toolFamilyInfo != null)
				{
					KindOfToolFamily kindOfToolFamily = toolFamilyInfo.KindOfToolFamily;
					if (4u != 0)
					{
						result = (int)kindOfToolFamily;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709589);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709551) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public Tool(ToolInterface toolinterface)
	{
		if (4u != 0)
		{
			_toolInterface = toolinterface;
		}
	}

	public Tool(ToolInterface toolinterface, ReferenceKey key)
		: this(toolinterface)
	{
		if (true)
		{
			base.ReferenceKey = key;
		}
	}

	public void CreateTool(string tool)
	{
		int headNumber;
		if (true)
		{
			headNumber = 0;
		}
		ReferenceToolKey refToolKey;
		if (8u != 0)
		{
			refToolKey = null;
		}
		_toolInterface.GetToolHeadInfo(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672), tool, ref headNumber, ref refToolKey);
		ReferenceToolKey referenceKey = refToolKey;
		if (0 == 0)
		{
			base.ReferenceKey = referenceKey;
		}
		base.Name = _toolInterface.Get(refToolKey).Name;
	}
}
