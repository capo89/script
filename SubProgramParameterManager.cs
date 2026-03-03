using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.MachiningDataModel;

namespace ScmGroup.XCam.Scripting;

public class SubProgramParameterManager
{
	private sealed class _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D<_0023_003DzdVq9VFI_003D>
	{
		public string _0023_003DzaiLaOdA_003D;

		public _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D()
		{
			_ = 2;
			if (false)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dzp0iSWsr___0024_0024641AYIw_003D_003D(SubProgramParameter _0023_003Dz2Qvb_pQ_003D)
		{
			_ = 0;
			if (-1 == 0)
			{
			}
			string name = _0023_003Dz2Qvb_pQ_003D.Name;
			_ = -1;
			if (8 == 0)
			{
			}
			return name == _0023_003DzaiLaOdA_003D;
		}
	}

	private List<SubProgramParameter> _0023_003Dzqp_0024sVKw_003D;

	private CultureInfo _0023_003DzPk3rb6DgORCXP9K9yw_003D_003D;

	public SubProgramParameterManager()
	{
		List<SubProgramParameter> list = new List<SubProgramParameter>();
		if (true)
		{
			_0023_003Dzqp_0024sVKw_003D = list;
		}
		CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712661));
		if (6u != 0)
		{
			_0023_003DzPk3rb6DgORCXP9K9yw_003D_003D = cultureInfo;
		}
	}

	public void LoadDefaultValues(string macroDefaultValueFilePath)
	{
		if (!FileUtility.IsValidAndExisting(macroDefaultValueFilePath) || !(Path.GetExtension(macroDefaultValueFilePath).ToLower() == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709655)))
		{
			return;
		}
		List<string> list = new List<string>();
		List<string> list2;
		if (3u != 0)
		{
			list2 = list;
		}
		StreamReader streamReader = new StreamReader(macroDefaultValueFilePath);
		StreamReader streamReader2;
		if (true)
		{
			streamReader2 = streamReader;
		}
		try
		{
			string text;
			if (0 == 0)
			{
				text = null;
			}
			while ((text = streamReader2.ReadLine()) != null)
			{
				list2.Add(text);
			}
		}
		finally
		{
			((IDisposable)streamReader2).Dispose();
		}
		list2.ForEach(_0023_003Dzul0SzI3c1LjU1iDV5DOVrBE_003D);
	}

	private SubProgramParameter _0023_003Dz4Q3Cjr_v8TO0(string _0023_003Dz33la_0024Nc_003D)
	{
		SubProgramParameter result;
		if (4u != 0)
		{
			result = null;
		}
		try
		{
			string[] obj = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709643) };
			string[] separator;
			if (8u != 0)
			{
				separator = obj;
			}
			string[] obj2 = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635) };
			string[] separator2;
			if (4u != 0)
			{
				separator2 = obj2;
			}
			string[] obj3 = new string[2]
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709627),
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709619)
			};
			string[] separator3;
			if (4u != 0)
			{
				separator3 = obj3;
			}
			string[] array = _0023_003Dz33la_0024Nc_003D.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			string[] array2;
			if (4u != 0)
			{
				array2 = array;
			}
			if (array2 != null)
			{
				string text = null;
				string defaultValue = null;
				string description = null;
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(separator2, StringSplitOptions.RemoveEmptyEntries);
					if (array4 == null || array4.Length != 2)
					{
						continue;
					}
					string text2 = array4[0].Trim();
					string text3 = array4[1].Trim();
					if (!text2.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709627)) && !text2.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709619)))
					{
						continue;
					}
					string[] array5 = text2.Split(separator3, StringSplitOptions.RemoveEmptyEntries);
					if (array5 == null || array5.Length != 1)
					{
						continue;
					}
					string text4 = array5[0].Trim();
					if (text4 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709611))
					{
						text = text3;
					}
					else if (text4 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706514))
					{
						string text5 = text3.ConvertToCurrentFormat();
						if (text5 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709602))
						{
							text5 = null;
						}
						defaultValue = text5;
					}
					else if (text4 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707845))
					{
						description = text3;
					}
				}
				if (text != null)
				{
					result = new SubProgramParameter(text, defaultValue, null, description, ParameterType.UserDefined, isVisible: true, FisicalUnitType.UnitLess);
				}
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	public T GetParameterDefaultValue<T>(string parameterName, T defaultValue)
	{
		_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D<T> _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D = new _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D<T>();
		_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D<T> _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D2 = default(_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D<T>);
		if (0 == 0)
		{
			_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D2 = _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D;
		}
		_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D<T> _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D3 = _0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D2;
		if (uint.MaxValue != 0)
		{
			_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D3._0023_003DzaiLaOdA_003D = parameterName;
		}
		T result;
		if (uint.MaxValue != 0)
		{
			result = defaultValue;
		}
		if (StringUtility.IsValid(_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D2._0023_003DzaiLaOdA_003D))
		{
			SubProgramParameter subProgramParameter = _0023_003Dzqp_0024sVKw_003D.Find(_0023_003DzJfFvh2C5JWp3e70ixcvG5Gw_003D2._0023_003Dzp0iSWsr___0024_0024641AYIw_003D_003D);
			if (subProgramParameter != null)
			{
				object obj = null;
				obj = ((subProgramParameter.Value == null) ? ((object)default(T)) : Convert.ChangeType(subProgramParameter.Value.ToString().ConvertToEnUSFormat(), typeof(T), _0023_003DzPk3rb6DgORCXP9K9yw_003D_003D));
				result = (T)obj;
			}
		}
		return result;
	}

	private void _0023_003Dzul0SzI3c1LjU1iDV5DOVrBE_003D(string _0023_003Dz33la_0024Nc_003D)
	{
		SubProgramParameter subProgramParameter = _0023_003Dz4Q3Cjr_v8TO0(_0023_003Dz33la_0024Nc_003D);
		SubProgramParameter subProgramParameter2 = default(SubProgramParameter);
		if (0 == 0)
		{
			subProgramParameter2 = subProgramParameter;
		}
		if (subProgramParameter2 != null)
		{
			_0023_003Dzqp_0024sVKw_003D.Add(subProgramParameter2);
		}
	}
}
