using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSScriptLibrary;
using Microsoft.CSharp.RuntimeBinder;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.PgmConverter;
using ScmGroup.XCam.Scripting.ProjectModule;
using ScmGroup.XCam.ToolDataModel;

namespace ScmGroup.XCam.Scripting;

public abstract class XilogScriptingProgram : ScriptingProgram, _0023_003DzYMUTKCjGvGuFGJOCFLxE2znyK7T4diz2Ng_003D_003D
{
	private static class _0023_003Dzd_gJUX5ZhtI6
	{
		public static CallSite<Action<CallSite, object, IScriptingReportServices, ProjectInterface, ToolInterface, EdgeInterface, ConfigurationInterface, object, StaticOptions>> _0023_003DzJoVcKRhjZhrt;

		public static CallSite<Action<CallSite, object>> _0023_003Dz_yrw_0024bUKZK6r;

		public static CallSite<Action<CallSite, object>> _0023_003DzUr8VKe41Wxf_;
	}

	private static string _0023_003DzNwieXqorkKYvDHztfcGOIM4_003D;

	private static string _0023_003Dz5gxiNaUmhHd0;

	protected XilogProgram program
	{
		get
		{
			_ = 6;
			if (2 == 0)
			{
			}
			return _program as XilogProgram;
		}
	}

	public string ACTIVETOOLS
	{
		get
		{
			_ = -1;
			if (4 == 0)
			{
			}
			return (_program as XilogProgram).ActiveTools;
		}
		set
		{
			XilogProgram obj = _program as XilogProgram;
			if (2u != 0)
			{
				obj.ActiveTools = value;
			}
		}
	}

	public double ZMAC
	{
		get
		{
			_ = 0;
			if (8 == 0)
			{
			}
			return (_program as XilogProgram).ZMAC;
		}
	}

	public double OPROG
	{
		get
		{
			_ = 6;
			if (3 == 0)
			{
			}
			return (_program as XilogProgram).OPROG;
		}
	}

	public double FLD
	{
		get
		{
			_ = 6;
			if (5 == 0)
			{
			}
			return (_program as XilogProgram).FLD;
		}
	}

	protected XilogScriptingProgram()
	{
		_ = 4;
		if (5 == 0)
		{
		}
		base._002Ector();
	}

	public static void Import(string fileName, IScriptingReportServices reportServices, ProjectInterface currentProjectInterface, ToolInterface currentToolInterface, EdgeInterface edgeInterface, ConfigurationInterface currentConfigurationInterface, ConversionParams conversionParams, StaticOptions staticOptions = null)
	{
		try
		{
			string empty = string.Empty;
			if (8u != 0)
			{
				_0023_003DzNwieXqorkKYvDHztfcGOIM4_003D = empty;
			}
			AppDomain.CurrentDomain.GetAssemblies();
			StreamReader streamReader = File.OpenText(fileName);
			StreamReader streamReader2;
			if (3u != 0)
			{
				streamReader2 = streamReader;
			}
			try
			{
				string text = fileName.Substring(0, fileName.LastIndexOf('\\'));
				if (5u != 0)
				{
					_0023_003Dz5gxiNaUmhHd0 = text;
				}
				string empty2 = string.Empty;
				string _0023_003DzInAefu0_003D;
				if (4u != 0)
				{
					_0023_003DzInAefu0_003D = empty2;
				}
				try
				{
					string text2 = streamReader2.ReadToEnd();
					if (0 == 0)
					{
						_0023_003DzInAefu0_003D = text2;
					}
					streamReader2.Close();
				}
				catch (Exception ex)
				{
					Exception innerException;
					if (5u != 0)
					{
						innerException = ex;
					}
					throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710414), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
				}
				if (_0023_003DzkVVvy4y_0024xQaHSMzT_9g5DVA_003D(_0023_003DzInAefu0_003D))
				{
					_0023_003DzInAefu0_003D = _0023_003DzFL_qsuqXiu9o_KDrw_0024WBV_0024ar00aV(_0023_003DzInAefu0_003D, conversionParams);
				}
				AsmHelper asmHelper;
				try
				{
					_0023_003DzInAefu0_003D = _0023_003Dzx7QYBJsSw1Fmw_mMrA_003D_003D(_0023_003DzInAefu0_003D);
					asmHelper = new AsmHelper(CSScript.LoadCode(BuildScriptClass(_0023_003DzInAefu0_003D)));
				}
				catch (Exception innerException2)
				{
					throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710382), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException2);
				}
				object arg = (ScriptingProgram)asmHelper.CreateObject(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710348));
				if (_0023_003Dzd_gJUX5ZhtI6._0023_003DzJoVcKRhjZhrt == null)
				{
					_0023_003Dzd_gJUX5ZhtI6._0023_003DzJoVcKRhjZhrt = CallSite<Action<CallSite, object, IScriptingReportServices, ProjectInterface, ToolInterface, EdgeInterface, ConfigurationInterface, object, StaticOptions>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713786), null, typeof(XilogScriptingProgram), new CSharpArgumentInfo[8]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				_0023_003Dzd_gJUX5ZhtI6._0023_003DzJoVcKRhjZhrt.Target(_0023_003Dzd_gJUX5ZhtI6._0023_003DzJoVcKRhjZhrt, arg, reportServices, currentProjectInterface, currentToolInterface, edgeInterface, currentConfigurationInterface, null, staticOptions);
				if (_0023_003Dzd_gJUX5ZhtI6._0023_003Dz_yrw_0024bUKZK6r == null)
				{
					_0023_003Dzd_gJUX5ZhtI6._0023_003Dz_yrw_0024bUKZK6r = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713773), null, typeof(XilogScriptingProgram), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
				}
				_0023_003Dzd_gJUX5ZhtI6._0023_003Dz_yrw_0024bUKZK6r.Target(_0023_003Dzd_gJUX5ZhtI6._0023_003Dz_yrw_0024bUKZK6r, arg);
				if (_0023_003Dzd_gJUX5ZhtI6._0023_003DzUr8VKe41Wxf_ == null)
				{
					_0023_003Dzd_gJUX5ZhtI6._0023_003DzUr8VKe41Wxf_ = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713764), null, typeof(XilogScriptingProgram), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
				}
				_0023_003Dzd_gJUX5ZhtI6._0023_003DzUr8VKe41Wxf_.Target(_0023_003Dzd_gJUX5ZhtI6._0023_003DzUr8VKe41Wxf_, arg);
			}
			finally
			{
				((IDisposable)streamReader2)?.Dispose();
			}
		}
		catch (Exception innerException3)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710448), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException3);
		}
	}

	private static string _0023_003Dzx7QYBJsSw1Fmw_mMrA_003D_003D(string _0023_003DzInAefu0_003D)
	{
		string empty = string.Empty;
		string text;
		if (4u != 0)
		{
			text = empty;
		}
		string[] array = _0023_003DzInAefu0_003D.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
		string[] array2;
		if (5u != 0)
		{
			array2 = array;
		}
		string text2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713751);
		string text3;
		if (5u != 0)
		{
			text3 = text2;
		}
		string text4 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713734);
		string empty2 = string.Empty;
		bool flag = false;
		MethodInfo[] methods = typeof(XilogScriptingProgram).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
		for (int i = 0; i < array2.Length; i++)
		{
			flag = false;
			for (int j = 0; j < methods.Length; j++)
			{
				if (flag)
				{
					break;
				}
				if (array2[i].StartsWith(methods[j].Name + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708756)))
				{
					string pattern = text3.Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713713), methods[j].Name);
					empty2 = text4.Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713713), methods[j].Name);
					Regex regex = new Regex(pattern);
					text += regex.Replace(array2[i], empty2);
					text += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709017);
					flag = true;
				}
			}
			if (!flag)
			{
				text += array2[i];
				text += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709017);
			}
		}
		return text;
	}

	protected new static string BuildScriptClass(string scriptCode)
	{
		string empty = string.Empty;
		string text;
		if (2u != 0)
		{
			text = empty;
		}
		string text2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713702);
		string text3;
		if (true)
		{
			text3 = text2;
		}
		string text4 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713495);
		string text5;
		if (uint.MaxValue != 0)
		{
			text5 = text4;
		}
		string text6 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709230);
		string text7;
		if (8u != 0)
		{
			text7 = text6;
		}
		string text8 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709188);
		string text9;
		if (3u != 0)
		{
			text9 = text8;
		}
		string text10 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708913);
		string text11 = default(string);
		if (0 == 0)
		{
			text11 = text10;
		}
		string text12 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708906);
		string text13 = string.Empty;
		List<string> list = new List<string>();
		if (scriptCode.Length > 50000)
		{
			_0023_003DzHf91CLfoxjLfINDgayhLcb0_003D(ref scriptCode);
			int num = scriptCode.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713437));
			text13 = scriptCode.Substring(0, num - 1);
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < scriptCode.Length; i++)
			{
				if (scriptCode[i] == '{')
				{
					num3++;
				}
				if (scriptCode[i] == '}')
				{
					num3--;
				}
				if (scriptCode[i] == '\n')
				{
					num2++;
				}
				if (num2 >= 5000 && num3 == 0)
				{
					list.Add(scriptCode.Substring(num, i - num + 1));
					num2 = 0;
					num = i + 1;
				}
			}
			if (num2 > 0 && list.Count > 0)
			{
				list.Add(scriptCode.Substring(num));
			}
		}
		if (list.Count > 0)
		{
			scriptCode = string.Empty;
			for (int j = 0; j < list.Count; j++)
			{
				string text14 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708888) + j + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708857);
				text = text + text14 + list[j] + text12;
				scriptCode = scriptCode + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708845) + j + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708829);
			}
		}
		return text3 + text5 + text13 + text + text7 + scriptCode + text9 + text11;
	}

	private static void _0023_003DzHf91CLfoxjLfINDgayhLcb0_003D(ref string _0023_003DzgnIcYLY_003D)
	{
		int num = _0023_003DzgnIcYLY_003D.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713437));
		int num2;
		if (8u != 0)
		{
			num2 = num;
		}
		int num3 = _0023_003DzgnIcYLY_003D.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713423), num2);
		int num4;
		if (8u != 0)
		{
			num4 = num3;
		}
		string text = _0023_003DzgnIcYLY_003D.Substring(num2, num4 - num2 + 4);
		string value;
		if (true)
		{
			value = text;
		}
		_0023_003DzgnIcYLY_003D = _0023_003DzgnIcYLY_003D.Remove(num2, num4 - num2 + 4);
		int startIndex = _0023_003DzgnIcYLY_003D.LastIndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713416));
		int num5 = _0023_003DzgnIcYLY_003D.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709643), startIndex);
		_0023_003DzgnIcYLY_003D = _0023_003DzgnIcYLY_003D.Insert(num5 + 3, value);
	}

	private static bool _0023_003DzkVVvy4y_0024xQaHSMzT_9g5DVA_003D(string _0023_003DzInAefu0_003D)
	{
		_ = 1;
		if (-1 == 0)
		{
		}
		if (!_0023_003DzInAefu0_003D.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713658)))
		{
			_ = 7;
			if (2 == 0)
			{
			}
			if (!_0023_003DzInAefu0_003D.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713645)))
			{
				return false;
			}
		}
		return true;
	}

	private static string _0023_003DzFL_qsuqXiu9o_KDrw_0024WBV_0024ar00aV(string _0023_003DzInAefu0_003D, ConversionParams _0023_003DznE4hnU8Yqd_0024F)
	{
		int num;
		if (5u != 0)
		{
			num = -1;
		}
		int num2;
		if (true)
		{
			num2 = 1;
		}
		string empty = string.Empty;
		if (5u != 0)
		{
			string text = empty;
		}
		string empty2 = string.Empty;
		if (6u != 0)
		{
			string text2 = empty2;
		}
		string empty3 = string.Empty;
		if (2u != 0)
		{
			string text3 = empty3;
		}
		string empty4 = string.Empty;
		if (3u != 0)
		{
			string text4 = empty4;
		}
		string text5;
		if (5u != 0)
		{
			text5 = _0023_003DzInAefu0_003D;
		}
		string empty5 = string.Empty;
		string text6;
		if (true)
		{
			text6 = empty5;
		}
		string empty6 = string.Empty;
		string text7;
		if (7u != 0)
		{
			text7 = empty6;
		}
		string empty7 = string.Empty;
		string empty8 = string.Empty;
		string value = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713658);
		string text8 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713633);
		string empty9 = string.Empty;
		bool _0023_003DzPHX0CysCixsD = true;
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		text7 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713624);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713541);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720402);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720347);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720552);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720469);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720134);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720307);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720937);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917721055);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720661);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720579);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720789);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720762);
		text7 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720731);
		text6 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719422);
		text6 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719382);
		text6 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719333);
		text6 += _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719464);
		num = text5.IndexOf(value);
		while (num != -1)
		{
			string text9 = text5.Substring(0, num) + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709017);
			string text4 = text5.Substring(text5.IndexOf(text8, num) + text8.Length, text5.Length - text5.IndexOf(text8, num) - text8.Length);
			string text2 = text5.Substring(num + 4, text5.IndexOf(')', num) - (num + 4));
			list = _0023_003Dz37ow7GN86eV5UL7gsw_003D_003D(text2);
			string _0023_003DzfbviZU7l0clLtlkzrA_003D_003D = text2.Substring(text2.IndexOf('"') + 1, text2.IndexOf('"', text2.IndexOf('"') + 1) - (text2.IndexOf('"') + 1));
			empty7 = _0023_003Dz3IF5xHPcpS0Mw90Nng_003D_003D(_0023_003DzfbviZU7l0clLtlkzrA_003D_003D);
			if (empty7 == string.Empty)
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719093), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			empty8 = _0023_003Dz4wlS0oaHVt09umg0Gw_003D_003D(_0023_003DzfbviZU7l0clLtlkzrA_003D_003D);
			string text = string.Concat(str2: _0023_003DzE4D_00248tioxuAp4ZgI2w_003D_003D(text2), str0: empty8, str1: _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708756), str3: _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713633));
			empty9 = _0023_003Dz_FYV9PqwvdqA1IaNag_003D_003D(_0023_003DzPHX0CysCixsD, list);
			text5 = text9 + empty9 + text + text4;
			if (!list3.Contains(empty8))
			{
				list3.Add(empty8);
				list2 = ScmGroup.XCam.PgmConverter.PgmConverter.ConvertAndGetContent(empty7, _0023_003DznE4hnU8Yqd_0024F);
				string text3 = _0023_003DzxCJgUWvF5Vvm3TNdyw_003D_003D(_0023_003DzXvrHbOQm_0024nZsodIlmw_003D_003D(list2), list2);
				_0023_003DzNwieXqorkKYvDHztfcGOIM4_003D = _0023_003DzNwieXqorkKYvDHztfcGOIM4_003D + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719057) + empty8 + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719289) + text7 + text3 + text6 + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719932);
			}
			_0023_003DzPHX0CysCixsD = false;
			num = text5.IndexOf(value, num + 1);
			num2++;
		}
		return text5;
	}

	private static List<KeyValuePair<string, string>> _0023_003DzXvrHbOQm_0024nZsodIlmw_003D_003D(List<string> _0023_003DzoKE2Uk6vQc5W3BjXROtgMW7Mj_9m)
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		List<KeyValuePair<string, string>> list2;
		if (7u != 0)
		{
			list2 = list;
		}
		string empty = string.Empty;
		if (2u != 0)
		{
			string text = empty;
		}
		string empty2 = string.Empty;
		if (uint.MaxValue != 0)
		{
			string text2 = empty2;
		}
		List<string> list3 = new List<string>();
		List<string> list4;
		if (true)
		{
			list4 = list3;
		}
		list4.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719917));
		list4.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719910));
		list4.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719899));
		list4.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719892));
		list4.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719881));
		list4.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719874));
		List<string> list5 = new List<string>();
		foreach (string item in _0023_003DzoKE2Uk6vQc5W3BjXROtgMW7Mj_9m)
		{
			if (item.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635)) && list5.Contains(item.Substring(0, item.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635)) - 1)))
			{
				string text2 = item.Substring(0, item.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635)) - 1);
				string text = item.Substring(item.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635)) + 2, item.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709643)) - item.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635)) - 2);
				list2.Add(new KeyValuePair<string, string>(text2, text));
			}
			if (item.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719863)) && !list4.Contains(item.Substring(7, 2)) && !list5.Contains(item.Substring(7, item.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635)) - 8)))
			{
				list5.Add(item.Substring(7, item.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709635)) - 8));
			}
		}
		return list2;
	}

	private static string _0023_003Dz_FYV9PqwvdqA1IaNag_003D_003D(bool _0023_003DzPHX0CysCixsD, List<KeyValuePair<string, string>> _0023_003Dz8I7WaB5cnUm7ivl_ZLh5maY_003D)
	{
		string empty = string.Empty;
		string text;
		if (4u != 0)
		{
			text = empty;
		}
		if (_0023_003DzPHX0CysCixsD)
		{
			string text2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719852);
			if (7u != 0)
			{
				text = text2;
			}
		}
		else
		{
			string text3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917720009);
			if (8u != 0)
			{
				text = text3;
			}
		}
		if (_0023_003Dz8I7WaB5cnUm7ivl_ZLh5maY_003D.Count != 0)
		{
			foreach (KeyValuePair<string, string> item in _0023_003Dz8I7WaB5cnUm7ivl_ZLh5maY_003D)
			{
				text = text + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719984) + item.Key + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719674) + item.Value + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719664);
			}
		}
		return text;
	}

	private static string _0023_003Dz3IF5xHPcpS0Mw90Nng_003D_003D(string _0023_003DzfbviZU7l0clLtlkzrA_003D_003D)
	{
		string text2 = default(string);
		if (_0023_003DzfbviZU7l0clLtlkzrA_003D_003D.LastIndexOf('\\') != -1)
		{
			string text = _0023_003DzfbviZU7l0clLtlkzrA_003D_003D.Substring(_0023_003DzfbviZU7l0clLtlkzrA_003D_003D.LastIndexOf('\\') + 1, _0023_003DzfbviZU7l0clLtlkzrA_003D_003D.Length - _0023_003DzfbviZU7l0clLtlkzrA_003D_003D.LastIndexOf('\\') - 1);
			if (2u != 0)
			{
				text2 = text;
			}
		}
		else if (0 == 0)
		{
			text2 = _0023_003DzfbviZU7l0clLtlkzrA_003D_003D;
		}
		string text3 = text2.ToLower();
		string text4;
		if (8u != 0)
		{
			text4 = text3;
		}
		if (text4.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719649)))
		{
			string text5 = _0023_003Dz5gxiNaUmhHd0 + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712700) + text2;
			if (File.Exists(text5))
			{
				return text5;
			}
			return string.Empty;
		}
		FileInfo[] files = new DirectoryInfo(_0023_003Dz5gxiNaUmhHd0).GetFiles();
		for (int i = 0; i < files.Length; i++)
		{
			if (files[i].Name.ToLower().Equals(text4 + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719649)))
			{
				return _0023_003Dz5gxiNaUmhHd0 + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712700) + files[i].Name;
			}
		}
		return string.Empty;
	}

	private static string _0023_003Dz4wlS0oaHVt09umg0Gw_003D_003D(string _0023_003DzfbviZU7l0clLtlkzrA_003D_003D)
	{
		string empty = string.Empty;
		string text;
		if (6u != 0)
		{
			text = empty;
		}
		if (_0023_003DzfbviZU7l0clLtlkzrA_003D_003D.LastIndexOf('\\') != -1)
		{
			string text2 = _0023_003DzfbviZU7l0clLtlkzrA_003D_003D.Substring(_0023_003DzfbviZU7l0clLtlkzrA_003D_003D.LastIndexOf('\\') + 1, _0023_003DzfbviZU7l0clLtlkzrA_003D_003D.Length - _0023_003DzfbviZU7l0clLtlkzrA_003D_003D.LastIndexOf('\\') - 1);
			if (3u != 0)
			{
				text = text2;
			}
		}
		else if (4u != 0)
		{
			text = _0023_003DzfbviZU7l0clLtlkzrA_003D_003D;
		}
		text = text.Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719649), string.Empty);
		return text.Replace(' ', '_');
	}

	private static List<KeyValuePair<string, string>> _0023_003Dz37ow7GN86eV5UL7gsw_003D_003D(string _0023_003DzmjL89Ew_003D)
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		List<KeyValuePair<string, string>> list2;
		if (6u != 0)
		{
			list2 = list;
		}
		string empty = string.Empty;
		if (uint.MaxValue != 0)
		{
			string text = empty;
		}
		string empty2 = string.Empty;
		if (7u != 0)
		{
			string text2 = empty2;
		}
		string empty3 = string.Empty;
		int num = int.MinValue;
		int num2 = int.MinValue;
		empty3 = _0023_003DzmjL89Ew_003D.Substring(_0023_003DzmjL89Ew_003D.IndexOf(',') + 3);
		empty3 = empty3.Substring(0, empty3.LastIndexOf('"'));
		if (empty3 != _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719640))
		{
			for (int i = 0; i < empty3.Length; i++)
			{
				if (empty3.ElementAt(i) == '=')
				{
					num = ((empty3.Substring(0, i).LastIndexOf(',') != -1) ? (empty3.Substring(0, i).LastIndexOf(',') + 1) : 0);
					string text = empty3.Substring(num, i - num);
					num2 = ((empty3.IndexOf(',', i + 1) != -1) ? empty3.IndexOf(',', i + 1) : empty3.Length);
					string text2 = empty3.Substring(i + 1, num2 - (i + 1));
					list2.Add(new KeyValuePair<string, string>(text, text2));
				}
			}
		}
		return list2;
	}

	private static string _0023_003DzxCJgUWvF5Vvm3TNdyw_003D_003D(List<KeyValuePair<string, string>> _0023_003Dz1t2d2pOMnpV0FL8rGw_003D_003D, List<string> _0023_003Dzft_3a6_0024EpstLQfeELg_003D_003D)
	{
		string empty = string.Empty;
		string text;
		if (7u != 0)
		{
			text = empty;
		}
		string empty2 = string.Empty;
		string text2;
		if (3u != 0)
		{
			text2 = empty2;
		}
		string empty3 = string.Empty;
		if (4u != 0)
		{
			string text3 = empty3;
		}
		string empty4 = string.Empty;
		if (2u != 0)
		{
			string text4 = empty4;
		}
		string empty5 = string.Empty;
		if (0 == 0)
		{
			string text5 = empty5;
		}
		int num = int.MinValue;
		int num2 = int.MaxValue;
		foreach (string item in _0023_003Dzft_3a6_0024EpstLQfeELg_003D_003D)
		{
			if (!item.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719629)))
			{
				text2 = text2 + item + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709017);
			}
		}
		text = text2;
		foreach (KeyValuePair<string, string> item2 in _0023_003Dz1t2d2pOMnpV0FL8rGw_003D_003D)
		{
			num = text.IndexOf(item2.Key + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719622), text.IndexOf(item2.Key + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719622)) + 1);
			if (num != -1)
			{
				string text3 = text.Substring(0, num);
				string text4 = item2.Key + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719611) + item2.Key + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719561) + item2.Key + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719800) + item2.Key + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719725) + item2.Value + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917719690);
				num2 = text.IndexOf(';', num + 1);
				string text5 = text.Substring(num2 + 1, text.Length - (num2 + 1));
				text = text3 + text4 + text5;
			}
		}
		return text;
	}

	private static string _0023_003DzE4D_00248tioxuAp4ZgI2w_003D_003D(string _0023_003Dzdl1BEt5_0024tuL1djggJg_003D_003D)
	{
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917718400);
		_ = 0;
		if (5 == 0)
		{
		}
		_ = 4;
		if (7 == 0)
		{
		}
		string value = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917718381);
		_ = 4;
		if (false)
		{
		}
		return text + _0023_003Dzdl1BEt5_0024tuL1djggJg_003D_003D.Substring(_0023_003Dzdl1BEt5_0024tuL1djggJg_003D_003D.IndexOf(value, _0023_003Dzdl1BEt5_0024tuL1djggJg_003D_003D.IndexOf(',') + 1) + 2);
	}

	protected override void PreEvaluateStep(IScriptingReportServices reportServices, ProjectInterface currentProjectInterface, ToolInterface currentToolInterface, EdgeInterface edgeInterface, ConfigurationInterface currentConfigurationInterface, ConfigurationInterface currentSupportInterface, StaticOptions staticOptions = null)
	{
		XilogProgram xilogProgram = new XilogProgram(reportServices, currentProjectInterface, currentToolInterface, currentConfigurationInterface, edgeInterface, null, null, null, isSubprogram: false, 0, staticOptions);
		if (8u != 0)
		{
			_program = xilogProgram;
		}
	}

	protected override void PostEvaluateStep()
	{
		program.CommitPendingProfile();
		program.ChangeWorkingArea();
		if (2u != 0)
		{
			base.PostEvaluateStep();
		}
	}

	public void H(double DX, double DY, double DZ, string FLD, string TOOLS, double BX = 0.0, double BY = 0.0, double BZ = 0.0, long? V = null, long T = 0L, int R = 1, int C = 0, string UNIT = "MM", string ENVVAR = "")
	{
		_ = 6;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (3 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		xilogProgram.H(DX, DY, DZ, FLD, TOOLS, BX, BY, BZ, V, T, R, C, UNIT, ENVVAR);
	}

	public void C(double C = 0.0, double S = 0.0)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (7 == 0)
		{
		}
		double c = Convert.ToInt32(C);
		_ = 8;
		if (false)
		{
		}
		xilogProgram.C(c, S);
	}

	public void F(double F)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (1 == 0)
		{
		}
		xilogProgram.F(F);
	}

	public void F(double? F)
	{
		_ = 8;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (3 == 0)
		{
		}
		xilogProgram.F(F);
	}

	public void _M(string N, string P)
	{
		_ = 7;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (3 == 0)
		{
		}
		_ = 1;
		if (3 == 0)
		{
		}
		xilogProgram._M(N, P);
	}

	public void M(string name, double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? I = null, double? J = null, double? V = null, double? S = null, string T = "", double? F = null, double? C = null, double? K = null, double? P = null, double? Q = null, double? R = null, double? x = null, double? y = null, double? a = null, double? B = null, double? r = null, double? D = null, double? s = null, double? l = null, double? G = null, double? L = null, string N = "")
	{
		_ = 0;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (5 == 0)
		{
		}
		_ = 4;
		if (4 == 0)
		{
		}
		xilogProgram.M(name, X, Y, Z, A, H, E, I, J, V, S, T, F, C, K, P, Q, R, x, y, a, B, r, D, s, l, G, L, N);
	}

	public void GIN(double? G, double? R = null, double? Q = null, double? V = null)
	{
		_ = 6;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (4 == 0)
		{
		}
		_ = 5;
		if (3 == 0)
		{
		}
		xilogProgram.GIN(G, R, Q, V);
	}

	public void GOUT(double? G, double? R = null, double? Q = null, double? L = null, double? V = null)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (3 == 0)
		{
		}
		_ = 5;
		if (4 == 0)
		{
		}
		xilogProgram.GOUT(G, R, Q, L, V);
	}

	public void G0(double? X = null, double? Y = null, double? Z = null, string T = "", double? E = null, double? V = null, double? S = null, double? D = null, double? s = null, string N = "")
	{
		_ = 1;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (3 == 0)
		{
		}
		_ = 3;
		if (7 == 0)
		{
		}
		xilogProgram.G0(X, Y, Z, T, E, V, S, D, s, N);
	}

	public void G1(double? X = null, double? Y = null, double? Z = null, double? V = null)
	{
		_ = 1;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (-1 == 0)
		{
		}
		_ = -1;
		if (5 == 0)
		{
		}
		xilogProgram.G1(X, Y, Z, V);
	}

	public void ATP(double? X = null, double? Y = null, double? Z = null, double? G = null, double? V = null)
	{
		_ = 6;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (3 == 0)
		{
		}
		_ = 7;
		if (8 == 0)
		{
		}
		xilogProgram.ATP(X, Y, Z, G, V);
	}

	public void G2(double? X = null, double? Y = null, double? Z = null, double? I = null, double? J = null, double? V = null, double? r = null)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (4 == 0)
		{
		}
		_ = 2;
		if (4 == 0)
		{
		}
		xilogProgram.G2(X, Y, Z, I, J, V, r);
	}

	public void G3(double? X = null, double? Y = null, double? Z = null, double? I = null, double? J = null, double? V = null, double? r = null)
	{
		_ = 7;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (false)
		{
		}
		_ = 8;
		if (1 == 0)
		{
		}
		xilogProgram.G3(X, Y, Z, I, J, V, r);
	}

	public void IX(double E)
	{
		_ = 5;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (8 == 0)
		{
		}
		xilogProgram.IX(E);
	}

	public void IY(double E)
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (-1 == 0)
		{
		}
		xilogProgram.IY(E);
	}

	public void PL(double? X = null, double? Y = null, double? Z = null, double? Q = null, double? R = null)
	{
		_ = 7;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (1 == 0)
		{
		}
		_ = 8;
		if (false)
		{
		}
		xilogProgram.PL(X, Y, Z, Q, R);
	}

	public void MODE(int? O = null, int? Z = null)
	{
		_ = 6;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (4 == 0)
		{
		}
		_ = 3;
		if (6 == 0)
		{
		}
		xilogProgram.MODE(O, Z);
	}

	public void G5(double? X = null, double? Y = null, double? Z = null, double? V = null, double? G = null, double? L = null)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (false)
		{
		}
		_ = 4;
		if (4 == 0)
		{
		}
		xilogProgram.G5(X, Y, Z, V, G, L);
	}

	public void ROT(double? A = null, double? X = null, double? Y = null)
	{
		_ = 3;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (6 == 0)
		{
		}
		_ = 2;
		if (3 == 0)
		{
		}
		xilogProgram.ROT(A, X, Y);
	}

	public void O(double? X = null, double? Y = null, double? Z = null, double? F = null)
	{
		_ = 3;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (2 == 0)
		{
		}
		_ = 0;
		if (6 == 0)
		{
		}
		xilogProgram.O(X, Y, Z, F);
	}

	public void SX(double? E = null, double? M = null)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 7;
		if (1 == 0)
		{
		}
		xilogProgram.SX(E, M);
	}

	public void SY(double? E = null, double? M = null)
	{
		_ = 2;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (2 == 0)
		{
		}
		_ = 0;
		if (8 == 0)
		{
		}
		xilogProgram.SY(E, M);
	}

	public void ATPR(double? X = null, double? Y = null, double? Z = null, double? H = null, double? G = null, double? V = null, double? Q = null)
	{
		_ = 8;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (-1 == 0)
		{
		}
		_ = 1;
		if (1 == 0)
		{
		}
		xilogProgram.ATPR(X, Y, Z, H, G, V, Q);
	}

	public void TA(double? X = null, double? Y = null, double? G = null, double? Q = null, string T = "")
	{
		_ = 6;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (3 == 0)
		{
		}
		_ = 2;
		if (7 == 0)
		{
		}
		xilogProgram.TA(X, Y, G, Q, T);
	}

	public void XT(double? G = null, string N = "")
	{
		_ = 7;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (3 == 0)
		{
		}
		_ = 5;
		if (1 == 0)
		{
		}
		xilogProgram.XT(G, N);
	}

	public void ISO(string I = "")
	{
		_ = 4;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (7 == 0)
		{
		}
		xilogProgram.ISO(I);
	}

	public void XBRAKE(string N = "")
	{
		_ = 0;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (-1 == 0)
		{
		}
		xilogProgram.XBRAKE(N);
	}

	public void XBLOWER(int? E = null, string T = "")
	{
		_ = 6;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (4 == 0)
		{
		}
		_ = 2;
		if (8 == 0)
		{
		}
		xilogProgram.XBLOWER(E, T);
	}

	public void XSP(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? B = null, double? D = null)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (2 == 0)
		{
		}
		_ = 3;
		if (3 == 0)
		{
		}
		xilogProgram.XSP(X, Y, Z, A, V, B, D);
	}

	public void XN(double? X = null, double? Y = null, double? Q = null, double? speed = null, double? spindleEnable = null, double? tool = null)
	{
		_ = 4;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (6 == 0)
		{
		}
		_ = 7;
		if (1 == 0)
		{
		}
		xilogProgram.XN(X, Y, Q, speed, spindleEnable, tool);
	}

	public void XL2P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? B = null, double? L = null)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (1 == 0)
		{
		}
		_ = 5;
		if (8 == 0)
		{
		}
		xilogProgram.XL2P(X, Y, Z, A, V, B, L);
	}

	public void XL2PP(double? X = null, double? Y = null, double? Z = null, double? D = null, double? S = null, double? L = null, double? V = null, double? s = null)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (-1 == 0)
		{
		}
		_ = 3;
		if (5 == 0)
		{
		}
		xilogProgram.XL2PP(X, Y, Z, D, S, L, V, s);
	}

	public void XARP(double? X = null, double? Y = null, double? Z = null, double? r = null, double? D = null, double? S = null, double? L = null, double? G = null, double? V = null, double? s = null)
	{
		_ = 4;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (4 == 0)
		{
		}
		_ = 5;
		if (2 == 0)
		{
		}
		xilogProgram.XAR(X, Y, Z, null, V, r, G);
	}

	public void LONG(double? X = null, double? Y = null, double? x = null, double? Z = null, double? a = null, double? s = null, double? I = null, double? G = null, double? E = null)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (-1 == 0)
		{
		}
		_ = 2;
		if (false)
		{
		}
		xilogProgram.LONG(X, Y, x, Z, a, s, I, G, E);
	}

	public void BLADE(double? X = null, double? Y = null, double? x = null, double? Z = null, double? J = null, double? E = null)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (-1 == 0)
		{
		}
		_ = 8;
		if (8 == 0)
		{
		}
		xilogProgram.BLADE(X, Y, x, Z, J, E);
	}

	public void G5R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? Q = null, double? G = null, double? L = null)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (4 == 0)
		{
		}
		_ = -1;
		if (2 == 0)
		{
		}
		xilogProgram.G5R(X, Y, Z, A, H, V, Q, G, L);
	}

	public void GSET(double? V = null, double? B = null, string T = "")
	{
		_ = -1;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (5 == 0)
		{
		}
		_ = 1;
		if (5 == 0)
		{
		}
		xilogProgram.GSET(V, B, T);
	}

	public void GREP(double? X = null, double? Y = null, double? Z = null, double? A = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? x = null, double? y = null, double? D = null, double? s = null, double? G = null, string N = "", string T = "")
	{
		_ = 8;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (2 == 0)
		{
		}
		_ = 0;
		if (-1 == 0)
		{
		}
		xilogProgram.GREP(X, Y, Z, A, E, V, S, Q, x, y, D, s, G, N, T);
	}

	public void GFIL(double? V = null, double? r = null)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (5 == 0)
		{
		}
		_ = 1;
		if (5 == 0)
		{
		}
		xilogProgram.GFIL(V, r);
	}

	public void GCHA(double? V = null, double? I = null, double? L = null)
	{
		_ = 5;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (false)
		{
		}
		_ = 4;
		if (5 == 0)
		{
		}
		xilogProgram.GCHA(V, I, L);
	}

	public void XA2P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? I = null, double? J = null, double? V = null, double? B = null, double? G = null, double? L = null)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (8 == 0)
		{
		}
		_ = 8;
		if (7 == 0)
		{
		}
		xilogProgram.XA2P(X, Y, Z, A, I, J, V, B, G, L);
	}

	public void PB(double? B = null, double? E = null, double? X = null, double? Y1 = null, double? S1 = null, double? Y2 = null, double? S2 = null, double? Y3 = null, double? S3 = null, double? Y4 = null, double? S4 = null)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (1 == 0)
		{
		}
		_ = -1;
		if (4 == 0)
		{
		}
		xilogProgram.PB(B, E, X, Y1, S1, Y2, S2, Y3, S3, Y4, S4);
	}

	public void REF(double? DX = null, double? DY = null, double? DZ = null, string FLD = "", double? BX = null, double? BY = null, double? BZ = null)
	{
		_ = 4;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (5 == 0)
		{
		}
		_ = -1;
		if (1 == 0)
		{
		}
		xilogProgram.REF(DX, DY, DZ, FLD, BX, BY, BZ);
	}

	public void SET(string NAME, double? VALUE = null)
	{
		_ = -1;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (5 == 0)
		{
		}
		_ = 1;
		if (8 == 0)
		{
		}
		xilogProgram.SET(NAME, VALUE);
	}

	public void SO(string N, string PARAMS = "", double? DX = null, double? DY = null, double? DZ = null, string FLD = "", double? BX = null, double? BY = null, double? BZ = null)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (1 == 0)
		{
		}
		_ = 3;
		if (2 == 0)
		{
		}
		xilogProgram.SO(N, PARAMS, DX, DY, DZ, FLD, BX, BY, BZ);
	}

	public void S(string N, string PARAMS = "", double? X = null, double? Y = null, double? Z = null, double? A = null)
	{
		_ = -1;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (5 == 0)
		{
		}
		_ = 8;
		if (7 == 0)
		{
		}
		xilogProgram.S(N, PARAMS, X, Y, Z, A);
	}

	public void G2R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? I = null, double? J = null, double? V = null, double? Q = null, double? r = null)
	{
		_ = 7;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (4 == 0)
		{
		}
		_ = 1;
		if (8 == 0)
		{
		}
		xilogProgram.G2R(X, Y, Z, A, H, I, J, V, Q, r);
	}

	public void G3R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? I = null, double? J = null, double? V = null, double? Q = null, double? r = null)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (5 == 0)
		{
		}
		_ = 4;
		if (-1 == 0)
		{
		}
		xilogProgram.G3R(X, Y, Z, A, H, I, J, V, Q, r);
	}

	public void G1R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? Q = null, double? B = null, double? L = null)
	{
		_ = 3;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (false)
		{
		}
		_ = 4;
		if (false)
		{
		}
		xilogProgram.G1R(X, Y, Z, A, H, V, Q, B, L);
	}

	public void XA3P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? x = null, double? y = null)
	{
		_ = 3;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (-1 == 0)
		{
		}
		_ = 2;
		if (1 == 0)
		{
		}
		xilogProgram.XA3P(X, Y, Z, A, H, V, x, y);
	}

	public void G13D(double? X = null, double? Y = null, double? H = null, double? V = null, double? Q = null, double? R = null)
	{
		_ = 1;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (-1 == 0)
		{
		}
		_ = 4;
		if (8 == 0)
		{
		}
		xilogProgram.G13D(X, Y, H, V, Q, R);
	}

	public void G0R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? I = null, double? V = null, double? S = null, double? Q = null, double? B = null, double? D = null, string N = "", string T = "")
	{
		_ = 5;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (7 == 0)
		{
		}
		_ = 0;
		if (3 == 0)
		{
		}
		xilogProgram.G0R(X, Y, Z, A, H, E, I, V, S, Q, B, D, N, T);
	}

	public void G03D(double? X = null, double? Y = null, double? H = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? D = null, string N = "", string T = "")
	{
		_ = 7;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (4 == 0)
		{
		}
		_ = 0;
		if (-1 == 0)
		{
		}
		xilogProgram.G03D(X, Y, H, E, V, S, Q, R, D, N, T);
	}

	public void BO(double? X = null, double? Y = null, double? Z = null, double? V = null, double? R = null, double? x = null, double? y = null, double? D = null, double? L = null, double? G = null, string N = "")
	{
		_ = -1;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (5 == 0)
		{
		}
		_ = 7;
		if (2 == 0)
		{
		}
		xilogProgram.BO(X, Y, Z, V, R, x, y, D, L, G, N);
	}

	public void DOWEL(double? X = null, double? Y = null, double? dowelDiameter = null, double? dowelLength = null, double? dowelOuterLength = null, double? glueThickness = null)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (7 == 0)
		{
		}
		_ = 5;
		if (4 == 0)
		{
		}
		xilogProgram.DOWEL(X, Y, dowelDiameter, dowelLength, dowelOuterLength, glueThickness);
	}

	public void BR(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? B = null, double? D = null, double? G = null, string T = "")
	{
		_ = 1;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (false)
		{
		}
		_ = 0;
		if (2 == 0)
		{
		}
		xilogProgram.BR(X, Y, Z, A, H, E, V, S, Q, B, D, G, T);
	}

	public void XAR(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? r = null, double? G = null)
	{
		_ = -1;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (7 == 0)
		{
		}
		_ = 4;
		if (false)
		{
		}
		xilogProgram.XAR(X, Y, Z, A, V, r, G);
	}

	public void XAR2(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? r = null, double? G = null)
	{
		_ = -1;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (1 == 0)
		{
		}
		_ = 5;
		if (1 == 0)
		{
		}
		xilogProgram.XAR2(X, Y, Z, A, V, r, G);
	}

	public void B(double? X = null, double? Y = null, double? Z = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? x = null, double? y = null, double? a = null, double? G = null, double? D = null, string T = "")
	{
		_ = 1;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (-1 == 0)
		{
		}
		_ = 0;
		if (1 == 0)
		{
		}
		xilogProgram.B(X, Y, Z, E, V, S, Q, R, x, y, a, G, D, T);
	}

	public void XEA(double? X = null, double? Y = null, double? Z = null, double? A = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? a = null, double? B = null, double? I = null, double? G = null, double? L = null, string T = "")
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (8 == 0)
		{
		}
		_ = 5;
		if (2 == 0)
		{
		}
		xilogProgram.XEA(X, Y, Z, A, E, V, S, Q, R, a, B, I, G, L, T);
	}

	public double NUMTOOLS(string value)
	{
		_ = 8;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (8 == 0)
		{
		}
		return xilogProgram.NUMTOOLS(value);
	}

	public string GETTOOL(string value, int index)
	{
		_ = 1;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (7 == 0)
		{
		}
		_ = 6;
		if (-1 == 0)
		{
		}
		return xilogProgram.GETTOOL(value, index);
	}

	public string GETTOOL(string value, double index)
	{
		_ = 4;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (6 == 0)
		{
		}
		_ = 3;
		if (-1 == 0)
		{
		}
		return xilogProgram.GETTOOL(value, index);
	}

	public double TOOLPAR(string tool, int index)
	{
		_ = 2;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (3 == 0)
		{
		}
		_ = 2;
		if (4 == 0)
		{
		}
		return xilogProgram.TOOLPAR(tool, index);
	}

	public double TLRAD(string tool)
	{
		_ = 1;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (7 == 0)
		{
		}
		return xilogProgram.TLRAD(tool);
	}

	public double TLLEN(string tool)
	{
		_ = 7;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (3 == 0)
		{
		}
		return xilogProgram.TLLEN(tool);
	}

	public double TLURAD(string tool)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (6 == 0)
		{
		}
		return xilogProgram.TLURAD(tool);
	}

	public double TLULEN(string tool)
	{
		_ = 7;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (-1 == 0)
		{
		}
		return xilogProgram.TLULEN(tool);
	}

	public void PRINT(string message)
	{
		_ = 1;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (6 == 0)
		{
		}
		xilogProgram.PRINT(message);
	}

	public void PRINT(string message, params object[] par)
	{
		_ = 2;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (1 == 0)
		{
		}
		_ = 2;
		if (false)
		{
		}
		xilogProgram.PRINT(message, par);
	}

	public void PARK(double? S = null, double? Q = null)
	{
		_ = 6;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (8 == 0)
		{
		}
		_ = 5;
		if (1 == 0)
		{
		}
		xilogProgram.PARK(S, Q);
	}

	public double HeapGet(double index)
	{
		_ = 4;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (-1 == 0)
		{
		}
		return xilogProgram.HeapGet(index);
	}

	public double HeapPut(double index, double value)
	{
		_ = 8;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (3 == 0)
		{
		}
		_ = 1;
		if (-1 == 0)
		{
		}
		return xilogProgram.HeapPut(index, value);
	}

	public double abs(double? value)
	{
		_ = 0;
		if (5 == 0)
		{
		}
		return _program.abs(value.Value);
	}

	public double ABS(double? value)
	{
		_ = 3;
		if (2 == 0)
		{
		}
		return _program.abs(value.Value);
	}

	public double acos(double? value)
	{
		_ = 6;
		if (2 == 0)
		{
		}
		return _program.acos(value.Value);
	}

	public double ACOS(double? value)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		return _program.acos(value.Value);
	}

	public double asin(double? value)
	{
		_ = 7;
		if (4 == 0)
		{
		}
		return _program.asin(value.Value);
	}

	public double ASIN(double? value)
	{
		_ = 5;
		if (1 == 0)
		{
		}
		return _program.asin(value.Value);
	}

	public double atan(double? value)
	{
		_ = 8;
		if (false)
		{
		}
		return _program.atan(value.Value);
	}

	public double ATAN(double? value)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		return _program.atan(value.Value);
	}

	public double sin(double? value)
	{
		_ = 7;
		if (6 == 0)
		{
		}
		return _program.sin(value.Value);
	}

	public double SIN(double? value)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		return _program.sin(value.Value);
	}

	public double COS(double? value)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		return _program.cos(value.Value);
	}

	public double cos(double? value)
	{
		_ = 8;
		if (5 == 0)
		{
		}
		return _program.cos(value.Value);
	}

	public double TAN(double? value)
	{
		_ = 3;
		if (false)
		{
		}
		return _program.tan(value.Value);
	}

	public double tan(double? value)
	{
		_ = 8;
		if (4 == 0)
		{
		}
		return _program.tan(value.Value);
	}

	public double ln(double? value)
	{
		_ = 4;
		if (5 == 0)
		{
		}
		return _program.ln(value.Value);
	}

	public double LN(double? value)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		return _program.ln(value.Value);
	}

	public double log10(double? value)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		return _program.log10(value.Value);
	}

	public double LOG10(double? value)
	{
		_ = 8;
		if (7 == 0)
		{
		}
		return _program.log10(value.Value);
	}

	public double exp(double? value)
	{
		_ = -1;
		if (2 == 0)
		{
		}
		return _program.exp(value.Value);
	}

	public double EXP(double? value)
	{
		_ = 6;
		if (3 == 0)
		{
		}
		return _program.exp(value.Value);
	}

	public double sqrt(double? value)
	{
		_ = 8;
		if (3 == 0)
		{
		}
		return _program.sqrt(value.Value);
	}

	public double SQRT(double? value)
	{
		_ = 7;
		if (4 == 0)
		{
		}
		return _program.sqrt(value.Value);
	}

	public double pow(double? x, double? y)
	{
		_ = 0;
		if (1 == 0)
		{
		}
		return _program.pow(x.Value, y.Value);
	}

	public double POW(double? x, double? y)
	{
		_ = 1;
		if (6 == 0)
		{
		}
		return _program.pow(x.Value, y.Value);
	}

	public double rd(double? value)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		return _program.rd(value.Value);
	}

	public double RD(double? value)
	{
		_ = 2;
		if (1 == 0)
		{
		}
		return _program.rd(value.Value);
	}

	public double ru(double? value)
	{
		_ = 4;
		if (5 == 0)
		{
		}
		return _program.ru(value.Value);
	}

	public double RU(double? value)
	{
		_ = 4;
		if (1 == 0)
		{
		}
		return _program.ru(value.Value);
	}

	public void ESET(double a = 0.0, double r = 0.0, double s = 0.0, string N = null, double b = 0.0, double? c = null, long T = 0L, int manualEdgeLoading = 0, string rollerCode = null)
	{
		_ = 0;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (false)
		{
		}
		_ = 5;
		if (false)
		{
		}
		xilogProgram.ESET(a, r, s, N, b, c, T, manualEdgeLoading, rollerCode);
	}

	public void ECUT(double? X = null, double? Y = null, string N = null, double? a = null, double? s = null, int Q = 1, int G = 1, string T = "", int? C = null)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (6 == 0)
		{
		}
		_ = 8;
		if (1 == 0)
		{
		}
		xilogProgram.ECUT(X, Y, N, a, s, Q, G, T, C);
	}

	public void ECLOSE(double? L = null)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (5 == 0)
		{
		}
		xilogProgram.ECLOSE(L);
	}

	public void EIN(double? X = null, double? Y = null, double? A = null, double E = 0.0, double J = 0.0, double? V = null, double? R = null, double? B = null, double? D = null, double L = 0.0, int CUT = 0, int? ROT = null, int AUTOSTART = 1, double? TIN = null, double LAMP = 0.0, int? PHON = null, double? V_CAR = null)
	{
		_ = 6;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (1 == 0)
		{
		}
		_ = 8;
		if (false)
		{
		}
		xilogProgram.EIN(X, Y, A, E, J, V, R, B, D, L, CUT, ROT, AUTOSTART, TIN, LAMP, PHON, V_CAR);
	}

	public void EOUT(double? Q = null, double? R = null, double? x = null, double? VOUT = null, double? TCSPI = null, double? BROT = null)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (8 == 0)
		{
		}
		_ = 0;
		if (1 == 0)
		{
		}
		xilogProgram.EOUT(Q, R, x, VOUT, TCSPI, BROT);
	}

	public void EROT(double? A = null, double Q = 0.0)
	{
		_ = 2;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (3 == 0)
		{
		}
		_ = 0;
		if (1 == 0)
		{
		}
		xilogProgram.EROT(A, Q);
	}

	public void LB(double L = 0.0)
	{
		_ = 8;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (1 == 0)
		{
		}
		xilogProgram.LB(L);
	}

	public void LAMP(double Q = 0.0, double D = 0.0)
	{
		_ = 7;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (false)
		{
		}
		_ = 8;
		if (1 == 0)
		{
		}
		xilogProgram.LAMP(Q, D);
	}

	public void STOP(string format)
	{
		_ = 3;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (7 == 0)
		{
		}
		xilogProgram.STOP(format);
	}

	public void MSG(string Message, int? SBY = null)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (4 == 0)
		{
		}
		_ = 4;
		if (false)
		{
		}
		xilogProgram.MSG(Message, SBY);
	}

	public void XHOODSUPP(int? Q, int? R, string N)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (5 == 0)
		{
		}
		_ = 2;
		if (3 == 0)
		{
		}
		xilogProgram.XHOODSUPP(Q, R, N);
	}

	public void PUSHOFF()
	{
		_ = 2;
		if (1 == 0)
		{
		}
		program.PUSHOFF();
	}

	public void EDGELINKER(string name)
	{
		_ = 2;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (-1 == 0)
		{
		}
		xilogProgram.EDGELinker(name);
	}
}
