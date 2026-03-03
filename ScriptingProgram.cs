using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CSScriptLibrary;
using Microsoft.CSharp.RuntimeBinder;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.AirBlowering;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.ProjectObjectModel.WorkPlane;
using ScmGroup.XCam.Scripting.ProjectModule;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.WorkPlaneManager.DynamicWorkingArea;

namespace ScmGroup.XCam.Scripting;

public abstract class ScriptingProgram : IScripting
{
	private static class _0023_003DzTijGx_2kRk07
	{
		public static CallSite<Action<CallSite, object, IScriptingReportServices, ProjectInterface, ToolInterface, EdgeInterface, ConfigurationInterface, ConfigurationInterface>> _0023_003DzJoVcKRhjZhrt;

		public static CallSite<Action<CallSite, object>> _0023_003Dz_yrw_0024bUKZK6r;

		public static CallSite<Action<CallSite, object>> _0023_003DzUr8VKe41Wxf_;
	}

	protected Program _program;

	public Workpiece ActiveWorkpiece
	{
		get
		{
			_ = 0;
			if (4 == 0)
			{
			}
			return _program.ActiveWorkpiece;
		}
	}

	public Workplane ActiveWorkplane
	{
		get
		{
			_ = 0;
			if (2 == 0)
			{
			}
			return _program.ActiveWorkplane;
		}
	}

	public Operation ActiveOperation
	{
		get
		{
			_ = 5;
			if (-1 == 0)
			{
			}
			return _program.ActiveOperation;
		}
	}

	public Geometry ActiveGeometry
	{
		get
		{
			_ = 7;
			if (5 == 0)
			{
			}
			return _program.ActiveGeometry;
		}
	}

	public LeadInOut ActiveLeadInOut
	{
		get
		{
			_ = 4;
			if (3 == 0)
			{
			}
			return _program.ActiveLeadInOut;
		}
	}

	public Pattern ActivePattern
	{
		get
		{
			_ = 0;
			if (7 == 0)
			{
			}
			return _program.ActivePattern;
		}
	}

	public MachineFunctions ActiveMachineFunctions
	{
		get
		{
			_ = 2;
			if (-1 == 0)
			{
			}
			return _program.ActiveMachineFunctions;
		}
	}

	public ToolPath ActiveToolpath
	{
		get
		{
			_ = 1;
			if (1 == 0)
			{
			}
			return _program.ActiveToolpath;
		}
	}

	public Workplan ActiveWorkplan
	{
		get
		{
			_ = 2;
			if (false)
			{
			}
			return _program.ActiveWorkplan;
		}
	}

	public ToolCorrection ActiveToolCorrection
	{
		get
		{
			_ = 2;
			if (4 == 0)
			{
			}
			return _program.ActiveToolCorrection;
		}
	}

	public double ActiveX
	{
		get
		{
			_ = 0;
			if (-1 == 0)
			{
			}
			return _program.ActiveX;
		}
	}

	public double ActiveY
	{
		get
		{
			_ = 3;
			if (7 == 0)
			{
			}
			return _program.ActiveY;
		}
	}

	public double ActiveZ
	{
		get
		{
			_ = 8;
			if (8 == 0)
			{
			}
			return _program.ActiveZ;
		}
	}

	public EdgeBandingInOut ActiveEdgeBandingInOut
	{
		get
		{
			_ = 1;
			if (5 == 0)
			{
			}
			return _program.ActiveEdgeBandingInOut;
		}
	}

	protected ScriptingProgram()
	{
		_ = 5;
		if (5 == 0)
		{
		}
		base._002Ector();
	}

	public static void Import(string filePath, IScriptingReportServices reportServices, ProjectInterface projectInterface, ToolInterface toolInterface, EdgeInterface edgeInterface, ConfigurationInterface configurationInterface, ConfigurationInterface supportsInterface)
	{
		try
		{
			string text = _0023_003DzTzlgwRpctalE(filePath);
			string _0023_003DzgnIcYLY_003D;
			if (true)
			{
				_0023_003DzgnIcYLY_003D = text;
			}
			if (8u != 0)
			{
				_0023_003Dz_ZSNYvW5Bzuf(reportServices, _0023_003DzgnIcYLY_003D, projectInterface, toolInterface, edgeInterface, configurationInterface, supportsInterface);
			}
			new WorkPlaneModel(projectInterface, configurationInterface, supportsInterface).FillMissingFixtureSetups();
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710448), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private static string _0023_003DzTzlgwRpctalE(string _0023_003Dzlxc3j7g_003D)
	{
		string result;
		if (3u != 0)
		{
			result = null;
		}
		if (FileUtility.IsXcs(_0023_003Dzlxc3j7g_003D))
		{
			StreamReader streamReader = File.OpenText(_0023_003Dzlxc3j7g_003D);
			StreamReader streamReader2;
			if (3u != 0)
			{
				streamReader2 = streamReader;
			}
			try
			{
				string text = File.ReadAllText(_0023_003Dzlxc3j7g_003D, Encoding.Default);
				if (true)
				{
					result = text;
				}
			}
			catch (Exception innerException)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710414), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
			}
			finally
			{
				((IDisposable)streamReader2)?.Dispose();
			}
		}
		return result;
	}

	private static void _0023_003DzplLpusbxheWA(List<string> _0023_003DzXXxLPdJTi16T)
	{
		List<ScriptingProgramParameter> list = new List<ScriptingProgramParameter>();
		List<ScriptingProgramParameter> list2;
		if (uint.MaxValue != 0)
		{
			list2 = list;
		}
		if (list2.Count <= 0)
		{
			return;
		}
		List<ScriptingProgramParameter>.Enumerator enumerator = list2.GetEnumerator();
		List<ScriptingProgramParameter>.Enumerator enumerator2;
		if (4u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				ScriptingProgramParameter current = enumerator2.Current;
				ScriptingProgramParameter scriptingProgramParameter;
				if (2u != 0)
				{
					scriptingProgramParameter = current;
				}
				_0023_003DzXXxLPdJTi16T[scriptingProgramParameter.Line - 1] = scriptingProgramParameter.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
	}

	private static void _0023_003Dz_ZSNYvW5Bzuf(IScriptingReportServices _0023_003DzNqD0D5q9iBKA, string _0023_003DzgnIcYLY_003D, ProjectInterface _0023_003Dz_0024HAEC0_0024lg24R, ToolInterface _0023_003DzyyCjvtbMAhyN, EdgeInterface _0023_003DzFgRtiDFXQcWP, ConfigurationInterface _0023_003Dz0ZRVQUpXa3bL, ConfigurationInterface _0023_003DzNa88K11TMei8)
	{
		try
		{
			AsmHelper asmHelper2;
			try
			{
				AsmHelper asmHelper = new AsmHelper(CSScript.LoadCode(BuildScriptClass(_0023_003DzgnIcYLY_003D)));
				if (5u != 0)
				{
					asmHelper2 = asmHelper;
				}
			}
			catch (Exception ex)
			{
				Exception innerException;
				if (5u != 0)
				{
					innerException = ex;
				}
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710382), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
			}
			ScriptingProgram obj = (ScriptingProgram)asmHelper2.CreateObject(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710348));
			object arg;
			if (5u != 0)
			{
				arg = obj;
			}
			asmHelper2.Dispose();
			if (5u != 0)
			{
				asmHelper2 = null;
			}
			if (_0023_003DzTijGx_2kRk07._0023_003DzJoVcKRhjZhrt == null)
			{
				_0023_003DzTijGx_2kRk07._0023_003DzJoVcKRhjZhrt = CallSite<Action<CallSite, object, IScriptingReportServices, ProjectInterface, ToolInterface, EdgeInterface, ConfigurationInterface, ConfigurationInterface>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710585), null, typeof(ScriptingProgram), new CSharpArgumentInfo[7]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			_0023_003DzTijGx_2kRk07._0023_003DzJoVcKRhjZhrt.Target(_0023_003DzTijGx_2kRk07._0023_003DzJoVcKRhjZhrt, arg, _0023_003DzNqD0D5q9iBKA, _0023_003Dz_0024HAEC0_0024lg24R, _0023_003DzyyCjvtbMAhyN, _0023_003DzFgRtiDFXQcWP, _0023_003Dz0ZRVQUpXa3bL, _0023_003DzNa88K11TMei8);
			if (_0023_003DzTijGx_2kRk07._0023_003Dz_yrw_0024bUKZK6r == null)
			{
				_0023_003DzTijGx_2kRk07._0023_003Dz_yrw_0024bUKZK6r = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710576), null, typeof(ScriptingProgram), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
			}
			_0023_003DzTijGx_2kRk07._0023_003Dz_yrw_0024bUKZK6r.Target(_0023_003DzTijGx_2kRk07._0023_003Dz_yrw_0024bUKZK6r, arg);
			if (_0023_003DzTijGx_2kRk07._0023_003DzUr8VKe41Wxf_ == null)
			{
				_0023_003DzTijGx_2kRk07._0023_003DzUr8VKe41Wxf_ = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710563), null, typeof(ScriptingProgram), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
			}
			_0023_003DzTijGx_2kRk07._0023_003DzUr8VKe41Wxf_.Target(_0023_003DzTijGx_2kRk07._0023_003DzUr8VKe41Wxf_, arg);
		}
		catch (Exception innerException2)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710448), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException2);
		}
	}

	public static List<ScriptingProgramParameter> GetParameters(string[] scriptFileLines)
	{
		bool flag;
		if (3u != 0)
		{
			flag = false;
		}
		List<ScriptingProgramParameter> list = new List<ScriptingProgramParameter>();
		List<ScriptingProgramParameter> list2 = default(List<ScriptingProgramParameter>);
		if (0 == 0)
		{
			list2 = list;
		}
		try
		{
			int i = default(int);
			if (0 == 0)
			{
				i = 0;
			}
			string text = default(string);
			for (; i < scriptFileLines.Length; i++)
			{
				string obj = scriptFileLines[i];
				if (0 == 0)
				{
					text = obj;
				}
				int num = text.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710554));
				int num2;
				if (7u != 0)
				{
					num2 = num;
				}
				if (num2 == -1)
				{
					if (flag)
					{
						string text2 = text.Replace('\t', ' ');
						if (5u != 0)
						{
							text = text2;
						}
						string text3 = text.Trim();
						if (8u != 0)
						{
							text = text3;
						}
						if (!string.IsNullOrEmpty(text) && text.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710533)) != 0)
						{
							break;
						}
					}
					continue;
				}
				int num3 = text.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710533));
				if (num3 != -1 && num3 < num2)
				{
					continue;
				}
				if (num3 >= 0)
				{
					text = text.Substring(num3 + 2);
				}
				text = text.Trim();
				text.Replace(' ', '\0');
				text.Replace('\t', '\0');
				int num4 = text.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708756));
				int num5 = text.LastIndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708748));
				if (num4 > 0 && num5 > num4)
				{
					text = text.Substring(num4 + 1, num5 - num4 - 1);
				}
				char[] separator = new char[1] { ',' };
				string[] array = text.Split(separator);
				if (array.Length == 6)
				{
					bool.TryParse(array[5], out var result);
					array[2] = array[2].Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710526), string.Empty);
					array[2] = array[2].Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708756), string.Empty);
					array[2] = array[2].Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708748), string.Empty);
					array[2] = array[2].Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710511), string.Empty);
					Type type = Type.GetType(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710503) + array[2], throwOnError: false, ignoreCase: true);
					array[4] = array[4].Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710489), string.Empty);
					array[4] = array[4].Replace(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710481), string.Empty);
					ParameterType parameterType = (ParameterType)Enum.Parse(typeof(ParameterType), array[4].Trim());
					string text4 = scriptFileLines[i].Substring(0, num2);
					if (!string.IsNullOrEmpty(text4))
					{
						ScriptingProgramParameter item = new ScriptingProgramParameter(text4, array[0], array[1], type, array[3], parameterType, result, i + 1);
						list2.Add(item);
						flag = true;
					}
				}
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710414), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		return list2;
	}

	protected double AddParameter(string name, double defaultValue, Type type, string description, ParameterType parameterType, bool isVisible)
	{
		_ = 7;
		if (2 == 0)
		{
		}
		return defaultValue;
	}

	protected string AddParameter(string name, string defaultValue, Type type, string description, ParameterType parameterType, bool isVisible)
	{
		_ = 1;
		if (4 == 0)
		{
		}
		return defaultValue;
	}

	protected static string BuildScriptClass(string scriptCode)
	{
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709181);
		string text2;
		if (uint.MaxValue != 0)
		{
			text2 = text;
		}
		string text3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709281);
		string text4;
		if (true)
		{
			text4 = text3;
		}
		string text5 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709230);
		string text6;
		if (8u != 0)
		{
			text6 = text5;
		}
		string text7 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709188);
		string text8;
		if (5u != 0)
		{
			text8 = text7;
		}
		string text9 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708913);
		string text10;
		if (7u != 0)
		{
			text10 = text9;
		}
		string text11 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708906);
		string text12 = string.Empty;
		int num = 5000;
		List<string> list = new List<string>();
		if (scriptCode.Length > num)
		{
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
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
				if (num2 >= num && num3 == 0)
				{
					list.Add(scriptCode.Substring(num4, i - num4 + 1));
					num2 = 0;
					num4 = i + 1;
				}
			}
			if (num2 > 0 && list.Count > 0)
			{
				list.Add(scriptCode.Substring(num4));
			}
		}
		if (list.Count > 0)
		{
			scriptCode = string.Empty;
			for (int j = 0; j < list.Count; j++)
			{
				string text13 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708888) + j + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708857);
				text12 = text12 + text13 + list[j] + text11;
				scriptCode = scriptCode + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708845) + j + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708829);
			}
		}
		return text2 + text4 + text12 + text6 + scriptCode + text8 + text10;
	}

	public abstract void Evaluate();

	protected virtual void PreEvaluateStep(IScriptingReportServices reportServices, ProjectInterface projectInterface, ToolInterface toolInterface, EdgeInterface edgeInterface, ConfigurationInterface configurationInterface, ConfigurationInterface supportsInterface, StaticOptions staticOptions = null)
	{
		Program program = new Program(reportServices, projectInterface, toolInterface, edgeInterface, configurationInterface, supportsInterface, null, null, null, isSubprogram: false, 0);
		if (true)
		{
			_program = program;
		}
	}

	protected virtual void PostEvaluateStep()
	{
		_ = 2;
		if (8 == 0)
		{
		}
		_program.Flush();
		_ = 3;
		if (6 == 0)
		{
		}
		_program.ReleaseResources();
	}

	internal void _0023_003Dz4iAY7jkIzcZI(double _0023_003Dz3keKASA_003D)
	{
		_ = 6;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (-1 == 0)
		{
		}
		program.ActiveX = _0023_003Dz3keKASA_003D;
	}

	internal void _0023_003Dz7q5mpq5g_0024iqy(double _0023_003Dz3keKASA_003D)
	{
		_ = 4;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (-1 == 0)
		{
		}
		program.ActiveY = _0023_003Dz3keKASA_003D;
	}

	internal void _0023_003DzQzvaM8QfTb9l(double _0023_003Dz3keKASA_003D)
	{
		_ = 2;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		program.ActiveZ = _0023_003Dz3keKASA_003D;
	}

	public Point CreatPoint(string name, double x, double y)
	{
		_ = 4;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (7 == 0)
		{
		}
		_ = 0;
		if (8 == 0)
		{
		}
		return program.CreatPoint(name, x, y);
	}

	public Segment CreateSegment(string name, double startX, double startY, double endX, double endY)
	{
		_ = 0;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (2 == 0)
		{
		}
		_ = 0;
		if (6 == 0)
		{
		}
		return program.CreateSegment(name, startX, startY, endX, endY);
	}

	public Arc CreateArc3Points(string name, double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
	{
		_ = 4;
		if (false)
		{
		}
		Program program = _program;
		_ = 8;
		if (3 == 0)
		{
		}
		_ = -1;
		if (-1 == 0)
		{
		}
		return program.CreateArc3Points(name, p1X, p1Y, p2X, p2Y, p3X, p3Y);
	}

	public Arc CreateArc2PointRadius(string name, double startX, double startY, double endX, double endY, double radius, bool isClockwise, bool isOver180)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (false)
		{
		}
		_ = 4;
		if (false)
		{
		}
		return program.CreateArc2PointRadius(name, startX, startY, endX, endY, radius, isClockwise, isOver180);
	}

	public Arc CreateArc2PointCenter(string name, double startX, double startY, double endX, double endY, double centerX, double centerY, bool isClockwise)
	{
		_ = 2;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (2 == 0)
		{
		}
		_ = 1;
		if (1 == 0)
		{
		}
		return program.CreateArc2PointCenter(name, startX, startY, endX, endY, centerX, centerY, isClockwise);
	}

	public Arc CreateArcCenterAngle(string name, double startX, double startY, double centerX, double centerY, double angle)
	{
		_ = 6;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (4 == 0)
		{
		}
		_ = 8;
		if (4 == 0)
		{
		}
		return program.CreateArcCenterAngle(name, startX, startY, centerX, centerY, angle);
	}

	public Circle CreateCircleCenterRadius(string name, double centerX, double centerY, double radius)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (2 == 0)
		{
		}
		_ = 4;
		if (1 == 0)
		{
		}
		return program.CreateCircleCenterRadius(name, centerX, centerY, radius);
	}

	public Circle CreateCircleCenterRadius(string name, double centerX, double centerY, double radius, bool isClockwise)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		_ = 0;
		if (4 == 0)
		{
		}
		return program.CreateCircleCenterRadius(name, centerX, centerY, radius, isClockwise);
	}

	public Circle CreateCircleCenterPoint(string name, double centerX, double centerY, double pointX, double pointY)
	{
		_ = 5;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (3 == 0)
		{
		}
		_ = 8;
		if (3 == 0)
		{
		}
		return program.CreateCircleCenterPoint(name, centerX, centerY, pointX, pointY);
	}

	public Circle CreateCircleCenterPoint(string name, double centerX, double centerY, double pointX, double pointY, bool isClockwise)
	{
		_ = 8;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (7 == 0)
		{
		}
		_ = 4;
		if (6 == 0)
		{
		}
		return program.CreateCircleCenterPoint(name, centerX, centerY, pointX, pointY, isClockwise);
	}

	public Ellipse CreateEllipseCenterAxes(string name, double centerX, double centerY, double majorRadius, double minorRadius, double angle)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (6 == 0)
		{
		}
		_ = 1;
		if (5 == 0)
		{
		}
		return program.CreateEllipseCenterAxes(name, centerX, centerY, majorRadius, minorRadius, angle);
	}

	public Polyline CreatePolyline(string name, double startX, double startY)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (8 == 0)
		{
		}
		_ = 4;
		if (6 == 0)
		{
		}
		return program.CreatePolyline(name, startX, startY);
	}

	public Polyline AddSegmentToPolyline(double endX, double endY, string nameElement = "")
	{
		_ = 2;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (6 == 0)
		{
		}
		_ = 0;
		if (-1 == 0)
		{
		}
		return program.AddSegmentToPolyline(endX, endY, nameElement);
	}

	public Polyline AddArc3PointsToPolyline(double p2X, double p2Y, double p3X, double p3Y, string nameElement = "")
	{
		_ = 3;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (7 == 0)
		{
		}
		_ = 3;
		if (false)
		{
		}
		return program.AddArc3PointsToPolyline(p2X, p2Y, p3X, p3Y, nameElement);
	}

	public Polyline AddArc2PointCenterToPolyline(double endX, double endY, double centerX, double centerY, bool isClockwise, string nameElement = "")
	{
		_ = 6;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (8 == 0)
		{
		}
		_ = 5;
		if (5 == 0)
		{
		}
		return program.AddArc2PointCenterToPolyline(endX, endY, centerX, centerY, isClockwise, nameElement);
	}

	public Polyline AddArc2PointRadiusToPolyline(double endX, double endY, double radius, bool isClockwise, bool isOver180, string nameElement = "")
	{
		_ = 2;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (7 == 0)
		{
		}
		_ = 8;
		if (false)
		{
		}
		return program.AddArc2PointRadiusToPolyline(endX, endY, radius, isClockwise, isOver180, nameElement);
	}

	public Polyline AddArcCenterAngleToPolyline(double centerX, double centerY, double angle, string nameElement = "")
	{
		_ = 7;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (7 == 0)
		{
		}
		_ = 1;
		if (8 == 0)
		{
		}
		return program.AddArcCenterAngleToPolyline(centerX, centerY, angle, nameElement);
	}

	public Polyline AddFilletToPolyline(double radius, int option = 0, string nameElement = "")
	{
		_ = 3;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (2 == 0)
		{
		}
		_ = 1;
		if (6 == 0)
		{
		}
		return program.AddFilletToPolyline(radius, option, nameElement);
	}

	public Polyline AddChamferToPolyline(double length1, double length2, int option = 0, string nameElement = "")
	{
		_ = 1;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (false)
		{
		}
		_ = 3;
		if (3 == 0)
		{
		}
		return program.AddChamferToPolyline(length1, length2, option, nameElement);
	}

	public Polyline ClosePolyline(string nameElement = "")
	{
		_ = -1;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (4 == 0)
		{
		}
		return program.ClosePolyline(nameElement);
	}

	public Geometry SelectGeometry(string name)
	{
		_ = 3;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (4 == 0)
		{
		}
		return program.SelectGeometry(name);
	}

	public Geometry SelectGeometry(int index)
	{
		_ = 8;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (7 == 0)
		{
		}
		return program.SelectGeometry(index);
	}

	public void DeleteGeometry(string name)
	{
		_ = 6;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (5 == 0)
		{
		}
		program.DeleteGeometry(name);
	}

	public void DeleteGeometry(int index)
	{
		_ = 8;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (8 == 0)
		{
		}
		program.DeleteGeometry(index);
	}

	public void SetReferencePosition(int referencePosition)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (1 == 0)
		{
		}
		program.SetReferencePosition(referencePosition);
	}

	public Workpiece CreateRawWorkpieceBox(string name, double dx, double dy, double dz, double bx = 0.0, double by = 0.0, double bz = 0.0)
	{
		_ = 2;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (6 == 0)
		{
		}
		_ = 1;
		if (false)
		{
		}
		return program.CreateRawWorkpieceBox(name, dx, dy, dz, bx, by, bz);
	}

	public Workpiece CreateRawWorkpieceFromExtrusion(string name, double dz, double bx = 0.0, double by = 0.0, double bz = 0.0, params string[] internalProfiles)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (1 == 0)
		{
		}
		_ = 0;
		if (5 == 0)
		{
		}
		return program.CreateRawWorkpieceFromExtrusion(name, dz, bx, by, bz, internalProfiles);
	}

	public Workpiece CreateFinishedWorkpieceBox(string name, double dx, double dy, double dz)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (1 == 0)
		{
		}
		_ = 5;
		if (-1 == 0)
		{
		}
		return program.CreateFinishedWorkpieceBox(name, dx, dy, dz);
	}

	public Workpiece CreateFinishedWorkpieceFromExtrusion(string name, double dz, params string[] internalProfiles)
	{
		_ = 6;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (8 == 0)
		{
		}
		_ = -1;
		if (3 == 0)
		{
		}
		return program.CreateFinishedWorkpieceFromExtrusion(name, dz, internalProfiles);
	}

	public Workpiece CreateRawWorkpiece(string name, double bx1, double bx2, double by1, double by2, double bz1 = 0.0, double bz2 = 0.0)
	{
		_ = 4;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (6 == 0)
		{
		}
		_ = 1;
		if (1 == 0)
		{
		}
		return program.CreateRawWorkpiece(name, bx1, bx2, by1, by2, bz1, bz2);
	}

	public Workpiece SelectWorkpiece(string name)
	{
		_ = 1;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		return program.SelectWorkpiece(name);
	}

	public Workpiece SelectWorkpiece(int index)
	{
		_ = 0;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (false)
		{
		}
		return program.SelectWorkpiece(index);
	}

	public void DeleteWorkpiece(string name)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (4 == 0)
		{
		}
		program.DeleteWorkpiece(name);
	}

	public void DeleteWorkpiece(int index)
	{
		_ = 3;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (7 == 0)
		{
		}
		program.DeleteWorkpiece(index);
	}

	public void SetWorkpieceSetupPosition(double x, double y, double z, double zRot)
	{
		_ = 5;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		_ = 7;
		if (2 == 0)
		{
		}
		program.SetWorkpieceSetupPosition(x, y, z, zRot);
	}

	public WorkPieceSetupPosition GetWorkPieceSetupPosition()
	{
		_ = 1;
		if (false)
		{
		}
		return _program.GetWorkPieceSetupPosition();
	}

	public BlockingProfile CreateBlockingProfile(string name, double startX, double startY, double offset = 0.0)
	{
		_ = 0;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (-1 == 0)
		{
		}
		_ = -1;
		if (2 == 0)
		{
		}
		return program.CreateBlockingProfile(name, startX, startY, offset);
	}

	public BlockingProfile AddSegmentToBlockingProfile(double endX, double endY, string nameElement = "")
	{
		_ = 0;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (2 == 0)
		{
		}
		_ = 3;
		if (6 == 0)
		{
		}
		return program.AddSegmentToBlockingProfile(endX, endY, nameElement);
	}

	public BlockingProfile AddArc3PointsToBlockingProfile(double p2X, double p2Y, double p3X, double p3Y, string nameElement = "")
	{
		_ = 3;
		if (false)
		{
		}
		Program program = _program;
		_ = 1;
		if (4 == 0)
		{
		}
		_ = 7;
		if (8 == 0)
		{
		}
		return program.AddArc3PointsToBlockingProfile(p2X, p2Y, p3X, p3Y, nameElement);
	}

	public BlockingProfile AddArc2PointCenterToBlockingProfile(double endX, double endY, double centerX, double centerY, bool isClockwise, string nameElement = "")
	{
		_ = 1;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (7 == 0)
		{
		}
		_ = 6;
		if (4 == 0)
		{
		}
		return program.AddArc2PointCenterToBlockingProfile(endX, endY, centerX, centerY, isClockwise, nameElement);
	}

	public BlockingProfile AddArc2PointRadiusToBlockingProfile(double endX, double endY, double radius, bool isClockwise, bool isOver180, string nameElement = "")
	{
		_ = 8;
		if (false)
		{
		}
		Program program = _program;
		_ = 3;
		if (3 == 0)
		{
		}
		_ = 0;
		if (-1 == 0)
		{
		}
		return program.AddArc2PointRadiusToBlockingProfile(endX, endY, radius, isClockwise, isOver180, nameElement);
	}

	public BlockingProfile AddArcCenterAngleToBlockingProfile(double centerX, double centerY, double angle, string nameElement = "")
	{
		_ = 5;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (5 == 0)
		{
		}
		_ = 1;
		if (4 == 0)
		{
		}
		return program.AddArcCenterAngleToBlockingProfile(centerX, centerY, angle, nameElement);
	}

	public BlockingProfile AddSegmentTanToBlockingProfile(double length, string nameElement = "")
	{
		_ = 3;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (-1 == 0)
		{
		}
		_ = 8;
		if (4 == 0)
		{
		}
		return program.AddSegmentTanToBlockingProfile(length, nameElement);
	}

	public BlockingProfile AddArcTanToBlockingProfile(double endX, double endY, int option, string nameElement = "")
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (5 == 0)
		{
		}
		_ = 6;
		if (4 == 0)
		{
		}
		return program.AddArcTanToBlockingProfile(endX, endY, option, nameElement);
	}

	public BlockingProfile CloseBlockingProfile(string nameElement = "")
	{
		_ = 0;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (-1 == 0)
		{
		}
		return program.CloseBlockingProfile(nameElement);
	}

	public Workplane CreateWorkplane(string name, double p1X, double p1Y, double p1Z, double p2X, double p2Y, double p2Z, double p3X, double p3Y, double p3Z)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (7 == 0)
		{
		}
		_ = 2;
		if (5 == 0)
		{
		}
		return program.CreateWorkplane(name, p1X, p1Y, p1Z, p2X, p2Y, p2Z, p3X, p3Y, p3Z);
	}

	public Workplane CreateWorkplane(string name, double X0, double Y0, double Z0, double ZRotation, double XRotation)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (5 == 0)
		{
		}
		_ = 3;
		if (3 == 0)
		{
		}
		return program.CreateWorkplane(name, X0, Y0, Z0, ZRotation, XRotation);
	}

	public Workplane CreateWorkplane(string name, object X0, object Y0, object Z0, object ZRotation, object XRotation)
	{
		_ = -1;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (-1 == 0)
		{
		}
		_ = 1;
		if (4 == 0)
		{
		}
		return program.CreateWorkplane(name, X0, Y0, Z0, ZRotation, XRotation);
	}

	public Workplane CreateWorkplane(string name, double offsetZ)
	{
		_ = 7;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (7 == 0)
		{
		}
		_ = -1;
		if (4 == 0)
		{
		}
		return program.CreateWorkplane(name, offsetZ);
	}

	public Workplane SelectWorkplane(string name)
	{
		_ = 4;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (3 == 0)
		{
		}
		return program.SelectWorkplane(name);
	}

	public Workplane SelectWorkplane(int index)
	{
		_ = 5;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (-1 == 0)
		{
		}
		return program.SelectWorkplane(index);
	}

	public void DeleteWorkplane(string name)
	{
		_ = 2;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (3 == 0)
		{
		}
		program.DeleteWorkplane(name);
	}

	public void DeleteWorkplane(int index)
	{
		_ = 5;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (1 == 0)
		{
		}
		program.DeleteWorkplane(index);
	}

	public Workplan CreateWorkplan(string name)
	{
		_ = 0;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (2 == 0)
		{
		}
		return program.CreateWorkplan(name);
	}

	public Workplan SelectWorkplan(string name)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (4 == 0)
		{
		}
		return program.SelectWorkplan(name);
	}

	public Workplan SelectWorkplan(int index)
	{
		_ = 3;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (3 == 0)
		{
		}
		return program.SelectWorkplan(index);
	}

	public void DeleteWorkplan(string name)
	{
		_ = 4;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (5 == 0)
		{
		}
		program.DeleteWorkplan(name);
	}

	public void DeleteWorkplan(int index)
	{
		_ = 8;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (7 == 0)
		{
		}
		program.DeleteWorkplan(index);
	}

	public Workplan RenameWorkplan(string name)
	{
		_ = 1;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (-1 == 0)
		{
		}
		return program.RenameWorkplan(name);
	}

	public Operation CreateRoughFinish(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 6;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (6 == 0)
		{
		}
		_ = 7;
		if (4 == 0)
		{
		}
		return program.CreateRoughFinish(name, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateEndTrimming(string name, string edgeBandingName, string tool = "-1", string head = "-1", object inputSpeed = null, object rotSpeed = null, object speed = null, bool setCurrentPos = false, bool useEndTrimmerAggregateCopier = false)
	{
		_ = 8;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (3 == 0)
		{
		}
		_ = 5;
		if (8 == 0)
		{
		}
		return program.CreateEndTrimming(name, edgeBandingName, tool, head, inputSpeed, rotSpeed, speed, setCurrentPos);
	}

	public Operation Create3DRoughFinish(string name, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double? inputZRotation = null, double? inputXRotation = null)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (-1 == 0)
		{
		}
		_ = 8;
		if (-1 == 0)
		{
		}
		return program.Create3DRoughFinish(name, description, typeOfProcess, tool, head, inputSpeed, rotSpeed, speed, inputZRotation, inputXRotation);
	}

	public Operation CreateSlantedRoughFinish(string name, double angleA, double angleB, int toolApproach, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (2 == 0)
		{
		}
		_ = 7;
		if (5 == 0)
		{
		}
		return program.CreateSlantedRoughFinish(name, angleA, angleB, toolApproach, depth, description, typeOfProcess, tool, head, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateSlantedRoughFinish(string name, double angleA, double angleB, int toolApproach, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 1;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (5 == 0)
		{
		}
		_ = 3;
		if (4 == 0)
		{
		}
		return program.CreateSlantedRoughFinish(name, angleA, angleB, toolApproach, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateSlantedRoughFinish(string name, object angleA, object angleB, int toolApproach, object depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, object inputSpeed = null, object rotSpeed = null, object speed = null, object overMaterial = null, bool isCnc = false)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (7 == 0)
		{
		}
		_ = -1;
		if (3 == 0)
		{
		}
		return program.CreateSlantedRoughFinish(name, angleA, angleB, toolApproach, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial, isCnc);
	}

	public Operation CreateChamfer(string name, double chamferWidth, double chamferHeight, double overcutLength, int toolPosition, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 4;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (4 == 0)
		{
		}
		_ = -1;
		if (-1 == 0)
		{
		}
		return program.CreateChamfer(name, chamferWidth, chamferHeight, overcutLength, toolPosition, description, typeOfProcess, tool, head, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateTrimming(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.Trimming, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (1 == 0)
		{
		}
		_ = 2;
		if (7 == 0)
		{
		}
		return program.CreateTrimming(name, toolApproach, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateTrimmingWorkingStep(string name, string description, TrimmingType trimmingType, string tool, string head = "-1", double approachAngle = 0.0, double infeedAdvance = 0.0, double outfeedDelay = 0.0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, double retractAngle = 0.0)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (6 == 0)
		{
		}
		_ = 6;
		if (-1 == 0)
		{
		}
		return program.CreateTrimmingWorkingStep(name, description, trimmingType, tool, head, approachAngle, infeedAdvance, outfeedDelay, inputSpeed, rotSpeed, speed, overMaterial, retractAngle);
	}

	public Operation CreateEdgeScraping(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.EdgeScraping, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 5;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (1 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		return program.CreateEdgeScraping(name, toolApproach, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateGlueScraping(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.GlueScraping, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (8 == 0)
		{
		}
		_ = 6;
		if (4 == 0)
		{
		}
		return program.CreateGlueScraping(name, toolApproach, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateAntiAdhesiveWorkingStep(string name, string description, AntiAdhesiveType antiAdhesiveType, string tool, string head = "-1", double approachAngle = 0.0, object infeedAdvance = null, object outfeedDelay = null, object inputSpeed = null, object rotSpeed = null, object speed = null, double overMaterial = 0.0, double retractAngle = 0.0)
	{
		_ = 5;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (-1 == 0)
		{
		}
		_ = 5;
		if (4 == 0)
		{
		}
		return program.CreateAntiAdhesiveWorkingStep(name, description, antiAdhesiveType, tool, head, approachAngle, infeedAdvance, outfeedDelay, inputSpeed, rotSpeed, speed, overMaterial, retractAngle);
	}

	public Operation CreateDrill(string name, double x, double y, double depth, double diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double holeTaperDiameter = 0.0)
	{
		_ = -1;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (1 == 0)
		{
		}
		_ = 3;
		if (8 == 0)
		{
		}
		return program.CreateDrill(name, x, y, depth, diameter, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, holeTaperDiameter);
	}

	public Operation CreateThroughDrill(string name, double x, double y, double diameter, double overcutLength, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double holeTaperDiameter = 0.0)
	{
		_ = -1;
		if (false)
		{
		}
		Program program = _program;
		_ = 3;
		if (2 == 0)
		{
		}
		_ = 7;
		if (1 == 0)
		{
		}
		return program.CreateThroughDrill(name, x, y, diameter, overcutLength, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, holeTaperDiameter);
	}

	public Operation CreateRoughFinish(string name, object depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, object inputSpeed = null, object rotSpeed = null, object speed = null, object overMaterial = null)
	{
		_ = 4;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (3 == 0)
		{
		}
		_ = -1;
		if (false)
		{
		}
		return program.CreateRoughFinish(name, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateAirBlower(string name, double height, double distanceFromProfile, BlowType blowType, AirBlowerType airBlowerType, string description = "", string tool = "-1", string head = "-1", double inputSpeed = -1.0, double speed = -1.0)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (6 == 0)
		{
		}
		_ = 8;
		if (4 == 0)
		{
		}
		return program.CreateAirBlower(name, height, distanceFromProfile, blowType, airBlowerType, description, tool, head, inputSpeed, speed);
	}

	public Operation CreateDrill(string name, object x, object y, object depth, object diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, string kindOfHole = "-1", object taperHeight = null, object securityQuote = null, object holeTaperDiameter = null)
	{
		_ = 8;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (-1 == 0)
		{
		}
		_ = 7;
		if (3 == 0)
		{
		}
		return program.CreateDrill(name, x, y, depth, diameter, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, holeTaperDiameter);
	}

	public Operation CreateThroughDrill(string name, object x, object y, object diameter, object overcutLength, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, string kindOfHole = "-1", object taperHeight = null, object securityQuote = null, object holeTaperDiameter = null)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		_ = 3;
		if (1 == 0)
		{
		}
		return program.CreateThroughDrill(name, x, y, diameter, overcutLength, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, holeTaperDiameter);
	}

	public Operation CreateSlantedDrill(string name, double x, double y, double z, double angleA, double angleB, double depth, double diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double holeTaperDiameter = 0.0)
	{
		_ = -1;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (1 == 0)
		{
		}
		_ = 0;
		if (4 == 0)
		{
		}
		return program.CreateSlantedDrill(name, x, y, z, angleA, angleB, depth, diameter, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, holeTaperDiameter);
	}

	public Operation CreateDowelDrillingOperation(string name, double x, double y, double dowelOuterLength, string description = "", string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, double? securityQuote = null, double glueThickness = 0.5, double? dowelDiameter = null, double? dowelLength = null)
	{
		_ = 1;
		if (false)
		{
		}
		Program program = _program;
		_ = 2;
		if (1 == 0)
		{
		}
		_ = 5;
		if (7 == 0)
		{
		}
		return program.CreateDowelDrillingOperation(name, x, y, dowelOuterLength, description, tool, head, dischargeSteps, rotSpeed, boringSpeed, securityQuote, glueThickness, dowelDiameter, dowelLength);
	}

	public Operation CreateDowelOperation(string name, double x, double y, double dowelOuterLength, string description = "", double retractDistance = 0.0, double dowelReleaseSpeed = -1.0, double glueThickness = 0.5, double? dowelDiameter = null, double? dowelLength = null, double? approachDistance = null, string head = "-1", double? dowelInsertionDistance = null)
	{
		_ = 1;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (7 == 0)
		{
		}
		_ = -1;
		if (2 == 0)
		{
		}
		return program.CreateDowelOperation(name, x, y, dowelOuterLength, description, retractDistance, dowelReleaseSpeed, glueThickness, dowelDiameter, dowelLength, approachDistance, head, dowelInsertionDistance);
	}

	public Operation CreateDowelDrillingOperation(string name, object x, object y, object dowelOuterLength, string description = "", string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, object securityQuote = null, object glueThickness = null, object dowelDiameter = null, object dowelLength = null)
	{
		_ = 5;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (2 == 0)
		{
		}
		_ = 6;
		if (-1 == 0)
		{
		}
		return program.CreateDowelDrillingOperation(name, x, y, dowelOuterLength, description, tool, head, dischargeSteps, rotSpeed, boringSpeed, securityQuote, glueThickness, dowelDiameter, dowelLength);
	}

	public Operation CreateDowelOperation(string name, object x, object y, object dowelOuterLength, string description = "", object retractDistance = null, object dowelReleaseSpeed = null, object glueThickness = null, object dowelDiameter = null, object dowelLength = null, object approachDistance = null, string head = "-1", object dowelInsertionDistance = null)
	{
		_ = 1;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (3 == 0)
		{
		}
		_ = 7;
		if (2 == 0)
		{
		}
		return program.CreateDowelOperation(name, x, y, dowelOuterLength, description, retractDistance, dowelReleaseSpeed, glueThickness, dowelDiameter, dowelLength, approachDistance, head, dowelInsertionDistance);
	}

	public Operation CreateWorkpiecePressureOperation(string name, double startX, double startY, double endX, double endY, double compression, string description = "", double approachSpeed = -1.0, double workingSpeed = -1.0)
	{
		_ = -1;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (3 == 0)
		{
		}
		_ = 1;
		if (4 == 0)
		{
		}
		return program.CreateWorkpiecePressureOperation(name, startX, startY, endX, endY, compression, description, approachSpeed, workingSpeed);
	}

	public object CreateMacro(string name, string macroName, params object[] macroParameters)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (6 == 0)
		{
		}
		_ = 0;
		if (false)
		{
		}
		return program.CreateMacro(name, macroName, macroParameters);
	}

	public object CreateMacro(string name, string macroName)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (3 == 0)
		{
		}
		_ = -1;
		if (6 == 0)
		{
		}
		return program.CreateMacro(name, macroName);
	}

	public object ExecMacro(string name, string macroName, params object[] macroParameters)
	{
		_ = 3;
		if (false)
		{
		}
		Program program = _program;
		_ = 0;
		if (3 == 0)
		{
		}
		_ = 6;
		if (-1 == 0)
		{
		}
		return program.ExecMacro(name, macroName, macroParameters);
	}

	public void SetMacroParam(string name, object value)
	{
		_ = 8;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		_ = 3;
		if (8 == 0)
		{
		}
		program.SetMacroParam(name, value);
	}

	public Operation CreateBladeCut(string name, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double angle = 90.0, int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, bool cutPositionUpper = true, bool materialPositionLeft = true, double referenceOffset = 0.0, double extraDepth = 0.0)
	{
		_ = -1;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (5 == 0)
		{
		}
		_ = 0;
		if (3 == 0)
		{
		}
		return program.CreateBladeCut(name, description, typeOfProcess, tool, head, angle, correction, inputSpeed, rotSpeed, speed, overMaterial, cutPositionUpper, materialPositionLeft, referenceOffset, extraDepth);
	}

	public Operation CreateContourPocket(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.ConcentricalPocket, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overlap = 50.0, bool finalPass = false, params string[] bossNames)
	{
		_ = 2;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (5 == 0)
		{
		}
		_ = 8;
		if (2 == 0)
		{
		}
		return program.CreateContourPocket(name, depth, description, typeOfProcess, tool, head, inputSpeed, rotSpeed, speed, overlap, finalPass, bossNames);
	}

	public Operation CreateContour(string name, double depth, int typeOfContour, int sideOfContour, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (5 == 0)
		{
		}
		_ = 8;
		if (4 == 0)
		{
		}
		return program.CreateContour(name, depth, typeOfContour, sideOfContour, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
	}

	public Operation CreateSlot(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, double angle = 90.0, double? endDepth = null)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (3 == 0)
		{
		}
		_ = 7;
		if (8 == 0)
		{
		}
		return program.CreateSlot(name, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial, angle, endDepth);
	}

	public Operation CreatePark(string name, string stopType, bool? toMinQuote)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (3 == 0)
		{
		}
		_ = 4;
		if (2 == 0)
		{
		}
		return program.CreatePark(name, stopType, toMinQuote);
	}

	public Operation CreateWorkPieceProbing(string name, double x, double y, string tool, string head, int type = 0, int headReturnAfterProbing = 0)
	{
		_ = 0;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (8 == 0)
		{
		}
		_ = 1;
		if (5 == 0)
		{
		}
		return program.CreateWorkPieceProbing(name, x, y, tool, head, type, headReturnAfterProbing);
	}

	public Operation CreatePrismaProbing(string name, object x, object y, string tool, object speed = null)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (1 == 0)
		{
		}
		_ = 4;
		if (5 == 0)
		{
		}
		return program.CreatePrismaProbing(name, x, y, tool, speed);
	}

	public Operation CreateWorkPieceTranslationRotationProbing(string name, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head)
	{
		_ = 2;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (5 == 0)
		{
		}
		_ = 1;
		if (4 == 0)
		{
		}
		return program.CreateWorkPieceTranslationRotationProbing(name, probingXFirstPointQuote, probingXSecondPointQuote, probingYPointQuote, probingZQuote, tool, head);
	}

	public Operation CreateWorkPieceTranslationRotationInternalProbing(string name, object probingXCoordinate, object probingYCoordinate, object probingRectWidth, object probingRectHeight, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head)
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (1 == 0)
		{
		}
		_ = -1;
		if (false)
		{
		}
		return program.CreateWorkPieceTranslationRotationInternalProbing(name, probingXCoordinate, probingYCoordinate, probingRectWidth, probingRectHeight, probingXFirstPointQuote, probingXSecondPointQuote, probingYPointQuote, probingZQuote, tool, head);
	}

	public Operation CreateMessage(string name, string text, bool waitForUserInput, bool releaseWorkpiece)
	{
		_ = 2;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (1 == 0)
		{
		}
		_ = 5;
		if (8 == 0)
		{
		}
		return program.CreateMessage(name, text, waitForUserInput, releaseWorkpiece);
	}

	public Operation CreateNullOperation(string name, double? X, double? Y, double? Q, double? speed = null, bool? spindleEnable = null, string tool = "-1")
	{
		_ = 4;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (2 == 0)
		{
		}
		_ = 1;
		if (7 == 0)
		{
		}
		return program.CreateNullOperation(name, X, Y, Q, speed, spindleEnable, tool);
	}

	public Operation CreateIso(string name, string instruction, string optionalParameters = "", bool isXiso = true)
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (6 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		return program.CreateIso(name, instruction, optionalParameters, isXiso);
	}

	public Operation CreateCombiflexUnloadUnitClamp(string name, double zQuote, double yOffset)
	{
		_ = 1;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (8 == 0)
		{
		}
		_ = 5;
		if (-1 == 0)
		{
		}
		return program.CreateCombiflexUnloadUnitClamp(name, zQuote, yOffset);
	}

	public Operation CreateWorkPieceWidthProbing(string name, double distance)
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (2 == 0)
		{
		}
		_ = 3;
		if (6 == 0)
		{
		}
		return program.CreateWorkPieceWidthProbing(name, distance);
	}

	public LeadInOut SetApproachStrategy(bool isLinear, bool isQuote, double distance, double? speed = null)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (3 == 0)
		{
		}
		_ = 6;
		if (-1 == 0)
		{
		}
		return program.SetApproachStrategy(isLinear, isQuote, distance, speed);
	}

	public LeadInOut SetRetractStrategy(bool isLinear, bool isQuote, double distance, double overlapLength, double? speed = null)
	{
		_ = 7;
		if (false)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		_ = 1;
		if (4 == 0)
		{
		}
		return program.SetRetractStrategy(isLinear, isQuote, distance, overlapLength, speed);
	}

	public void ResetApproachStrategy()
	{
		_ = 5;
		if (1 == 0)
		{
		}
		_program.ResetApproachStrategy();
	}

	public void ResetRetractStrategy()
	{
		_ = 8;
		if (5 == 0)
		{
		}
		_program.ResetRetractStrategy();
	}

	public Pattern CreatePattern(int numberOfRows, int numberOfColumns, double rowsDistance, double columnDistance, double rotationAngle, double rowLayoutAngle)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (4 == 0)
		{
		}
		_ = 0;
		if (4 == 0)
		{
		}
		return program.CreatePattern(numberOfRows, numberOfColumns, rowsDistance, columnDistance, rotationAngle, rowLayoutAngle);
	}

	public void ResetPattern()
	{
		_ = 3;
		if (-1 == 0)
		{
		}
		_program.ResetPattern();
	}

	public Operation SelectOperation(string name)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (6 == 0)
		{
		}
		return program.SelectOperation(name);
	}

	public Operation SelectOperation(int index)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (7 == 0)
		{
		}
		return program.SelectOperation(index);
	}

	public void DeleteOperation(string name)
	{
		_ = 6;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (8 == 0)
		{
		}
		program.DeleteOperation(name);
	}

	public void DeleteOperation(int index)
	{
		_ = 4;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (-1 == 0)
		{
		}
		program.DeleteOperation(index);
	}

	public void SetJerk(double gain)
	{
		_ = 6;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (2 == 0)
		{
		}
		program.SetJerk(gain);
	}

	public void ResetJerk()
	{
		_ = 3;
		if (4 == 0)
		{
		}
		_program.ResetJerk();
	}

	public void SetCNAutoSpeed()
	{
		_ = 7;
		if (4 == 0)
		{
		}
		_program.SetCNAutoSpeed();
	}

	public void ResetCNAutoSpeed()
	{
		_ = -1;
		if (5 == 0)
		{
		}
		_program.ResetCNAutoSpeed();
	}

	public void SetJerk3D(double gain)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (1 == 0)
		{
		}
		program.SetJerk3D(gain);
	}

	public void ResetJerk3D()
	{
		_ = 3;
		if (4 == 0)
		{
		}
		_program.ResetJerk3D();
	}

	public void SetPneumaticHoodPosition(int? position)
	{
		_ = 0;
		if (false)
		{
		}
		Program program = _program;
		_ = 4;
		if (6 == 0)
		{
		}
		program.SetPneumaticHoodPosition(position);
	}

	public void ResetPneumaticHood()
	{
		_ = 5;
		if (5 == 0)
		{
		}
		_program.ResetPneumaticHood();
	}

	public void SetMotorizedHoodPosition(double? position)
	{
		_ = 7;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (4 == 0)
		{
		}
		program.SetMotorizedHoodPosition(position);
	}

	public void ResetMotorizedHood()
	{
		_ = 3;
		if (false)
		{
		}
		_program.ResetMotorizedHood();
	}

	public void SetOppositePneumaticHoodPosition(int? position)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (-1 == 0)
		{
		}
		program.SetOppositePneumaticHoodPosition(position);
	}

	public void ResetOppositePneumaticHood()
	{
		_ = 3;
		if (false)
		{
		}
		_program.ResetOppositePneumaticHood();
	}

	public void SetAuxiliaryHoodPosition(int? position)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		program.SetAuxiliaryHoodPosition(position);
	}

	public void ResetAuxiliaryHood()
	{
		_ = -1;
		if (8 == 0)
		{
		}
		_program.ResetAuxiliaryHood();
	}

	public void SetCleaningMode()
	{
		_ = 1;
		if (7 == 0)
		{
		}
		_program.SetCleaningMode();
	}

	public void ResetCleaningMode()
	{
		_ = 3;
		if (3 == 0)
		{
		}
		_program.ResetCleaningMode();
	}

	public void SetDustpanOffset(double offset, int? position = null, bool? isInOutEnable = null)
	{
		_ = 1;
		if (false)
		{
		}
		Program program = _program;
		_ = 3;
		if (1 == 0)
		{
		}
		_ = 6;
		if (2 == 0)
		{
		}
		program.SetDustpanOffset(offset, position, isInOutEnable);
	}

	public void SetDustpanOffset(double offset)
	{
		_ = 7;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (8 == 0)
		{
		}
		program.SetDustpanOffset(offset);
	}

	public void SetDustpanPosition(int? position = null, bool? isInOutEnable = null)
	{
		_ = 7;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (-1 == 0)
		{
		}
		_ = 1;
		if (1 == 0)
		{
		}
		program.SetDustpanPosition(position, isInOutEnable);
	}

	public void ResetDustpan()
	{
		_ = 4;
		if (3 == 0)
		{
		}
		_program.ResetDustpan();
	}

	public void SetMotorizedDustpanPosition(double? position = null, bool? isInOutEnable = null)
	{
		_ = 4;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (-1 == 0)
		{
		}
		_ = 2;
		if (8 == 0)
		{
		}
		program.SetMotorizedDustpanPosition(position, isInOutEnable);
	}

	public void SetMotorizedDustpanOffset(double offset)
	{
		_ = 7;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (3 == 0)
		{
		}
		program.SetMotorizedDustpanOffset(offset);
	}

	public void ResetMotorizedDustpan()
	{
		_ = 6;
		if (3 == 0)
		{
		}
		_program.ResetMotorizedDustpan();
	}

	public void SetUnrollHeadMode(int mode = 0, double radiusMultiplier = 1.0)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (8 == 0)
		{
		}
		_ = 7;
		if (1 == 0)
		{
		}
		program.SetUnrollHeadMode(mode, radiusMultiplier);
	}

	public void SetUnrollHeadRadiusMultiplier(double radiusMultiplier = 1.0)
	{
		_ = 0;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (-1 == 0)
		{
		}
		program.SetUnrollHeadRadiusMultiplier(radiusMultiplier);
	}

	public void SetToolCorrection(int correction, double overMaterial = 0.0)
	{
		_ = 0;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (5 == 0)
		{
		}
		_ = 5;
		if (2 == 0)
		{
		}
		program.SetToolCorrection(correction, overMaterial);
	}

	public void SetBrakes(string activeBrakes)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (3 == 0)
		{
		}
		program.SetBrakes(activeBrakes);
	}

	public void SetToolBlower(int toolBlowerMode)
	{
		_ = 7;
		if (false)
		{
		}
		Program program = _program;
		_ = 2;
		if (false)
		{
		}
		program.SetToolBlower(toolBlowerMode);
	}

	public void ResetToolBlower()
	{
		_ = 6;
		if (8 == 0)
		{
		}
		_program.ResetToolBlower();
	}

	public void SetElectronicZeroProber(double gain, double offset, double compression)
	{
		_ = 6;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (4 == 0)
		{
		}
		_ = 1;
		if (7 == 0)
		{
		}
		program.SetElectronicZeroProber(gain, offset, compression);
	}

	public void ResetElectronicZeroProber()
	{
		_ = 4;
		if (3 == 0)
		{
		}
		_program.ResetElectronicZeroProber();
	}

	public void SetPressureRollers(double offset)
	{
		_ = 6;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (4 == 0)
		{
		}
		program.SetPressureRollers(offset);
	}

	public void ResetPressureRollers()
	{
		_ = 6;
		if (4 == 0)
		{
		}
		_program.ResetPressureRollers();
	}

	public void SetMechanicalPresser()
	{
		_ = 1;
		if (-1 == 0)
		{
		}
		_program.SetMechanicalPresser();
	}

	public void ResetMechanicalPresser()
	{
		_ = -1;
		if (3 == 0)
		{
		}
		_program.ResetMechanicalPresser();
	}

	public void SetPriority(int priority)
	{
		_ = 6;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (7 == 0)
		{
		}
		program.SetPriority(priority);
	}

	public void SetProjectLabel(string labelName)
	{
		_ = 5;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (2 == 0)
		{
		}
		program.SetProjectLabel(labelName);
	}

	public void SetWorkPieceLabel(double xStart, double yStart, double rotationDegree)
	{
		_ = 0;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (8 == 0)
		{
		}
		_ = 2;
		if (-1 == 0)
		{
		}
		program.SetWorkPieceLabel(xStart, yStart, rotationDegree);
	}

	public void AddLabelParams(params string[] labelParameters)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (3 == 0)
		{
		}
		program.AddLabelParams(labelParameters);
	}

	public void SetProbingReferenceReferencePoint(int referencePoint)
	{
		_ = 7;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (2 == 0)
		{
		}
		program.SetProbingReferenceReferencePoint(referencePoint);
	}

	public void SetMachine(int id)
	{
		_ = -1;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (false)
		{
		}
		program.SetMachine(id);
	}

	public void SetSpindles(params int[] spindles)
	{
		_ = 5;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (8 == 0)
		{
		}
		program.SetSpindles(spindles);
	}

	public EdgeBandingInOut SetEdgeBandingApproachStrategy(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null)
	{
		_ = 2;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (-1 == 0)
		{
		}
		_ = 2;
		if (4 == 0)
		{
		}
		return program.SetEdgeBandingApproachStrategy(approachSpeed, approachMagazineSpeed, pointDistance, pointAngle, pointRotation, stopTime, isLampOn, lampPower);
	}

	public EdgeBandingInOut SetEdgeBandingRetractStrategy(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null)
	{
		_ = 8;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 3;
		if (5 == 0)
		{
		}
		return program.SetEdgeBandingRetractStrategy(retractSpeed, stopTime, pointDistance, pointAngle, pointRotation);
	}

	public void ResetEdgeBandingApproachStrategy()
	{
		_ = 8;
		if (8 == 0)
		{
		}
		_program.ResetEdgeBandingApproachStrategy();
	}

	public void ResetEdgeBandingRetractStrategy()
	{
		_ = 8;
		if (5 == 0)
		{
		}
		_program.ResetEdgeBandingRetractStrategy();
	}

	public EdgeBandingSlotInOut SetEdgeBandingSlotApproachStrategy(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null)
	{
		_ = 0;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (8 == 0)
		{
		}
		_ = 3;
		if (-1 == 0)
		{
		}
		return program.SetEdgeBandingSlotApproachStrategy(approachSpeed, approachMagazineSpeed, pointDistance, pointAngle, pointRotation, stopTime, isLampOn, lampPower);
	}

	public EdgeBandingSlotInOut SetEdgeBandingSlotRetractStrategy(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null)
	{
		_ = 8;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (6 == 0)
		{
		}
		_ = 5;
		if (1 == 0)
		{
		}
		return program.SetEdgeBandingSlotRetractStrategy(retractSpeed, stopTime, pointDistance, pointAngle, pointRotation);
	}

	public void ResetEdgeBandingSlotApproachStrategy()
	{
		_ = 5;
		if (-1 == 0)
		{
		}
		_program.ResetEdgeBandingSlotApproachStrategy();
	}

	public void ResetEdgeBandingSlotRetractStrategy()
	{
		_ = 1;
		if (false)
		{
		}
		_program.ResetEdgeBandingSlotRetractStrategy();
	}

	public void ResetEdgeDispensing()
	{
		_ = 6;
		if (1 == 0)
		{
		}
		_program.ResetEdgeDispensing();
	}

	public void SetEdgeDispensing(object startOffSet = null, object totalOffSet = null, object safeOffSet = null, bool? isMultiEdgeBandingEnabled = null)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (5 == 0)
		{
		}
		_ = 2;
		if (false)
		{
		}
		program.SetEdgeDispensing(startOffSet, totalOffSet, safeOffSet, isMultiEdgeBandingEnabled);
	}

	public void ResetEdgeClosing()
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		_program.ResetEdgeClosing();
	}

	public void SetEdgeSlotDispensing(object startOffSet = null, object totalOffSet = null, object safeOffSet = null, bool? isMultiEdgeBandingEnabled = null)
	{
		_ = 1;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (-1 == 0)
		{
		}
		_ = 4;
		if (8 == 0)
		{
		}
		program.SetEdgeSlotDispensing(startOffSet, totalOffSet, safeOffSet, isMultiEdgeBandingEnabled);
	}

	public void ResetEdgeSlotDispensing()
	{
		_ = 4;
		if (7 == 0)
		{
		}
		_program.ResetEdgeSlotDispensing();
	}

	public void SetEdgeClosing(object endOffSet = null, bool? enableCutter = null)
	{
		_ = 5;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (1 == 0)
		{
		}
		_ = 2;
		if (3 == 0)
		{
		}
		program.SetEdgeClosing(endOffSet, enableCutter);
	}

	public Operation CreateEdgeBanding(string name, string edge, object depth, bool edgeManualLoading = false, string pressureTool = "-1", bool pressureToolManualLoading = false, object speed = null)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (2 == 0)
		{
		}
		_ = 5;
		if (6 == 0)
		{
		}
		return program.CreateEdgeBanding(name, edge, depth, edgeManualLoading, pressureTool, pressureToolManualLoading, speed);
	}

	public Operation CreateEdgeBandingSlotFeature(string name, string edge, object depth, object slotEdgeZ, object angle, bool edgeManualLoading = false, string pressureTool = "-1", bool pressureToolManualLoading = false, object speed = null)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (8 == 0)
		{
		}
		_ = 0;
		if (8 == 0)
		{
		}
		return program.CreateEdgeBandingSlotFeature(name, edge, depth, slotEdgeZ, angle, edgeManualLoading, pressureTool, pressureToolManualLoading, speed);
	}

	public void SetRotationDirection(int direction = 0)
	{
		_ = 1;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (8 == 0)
		{
		}
		program.SetRotationDirection(direction);
	}

	public void ResetRotationDirection()
	{
		_ = -1;
		if (4 == 0)
		{
		}
		_program.ResetRotationDirection();
	}

	public void SetAutostart(bool status = true)
	{
		_ = 3;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (7 == 0)
		{
		}
		program.SetAutostart(status);
	}

	public void ResetAutostart()
	{
		_ = 0;
		if (3 == 0)
		{
		}
		_program.ResetAutostart();
	}

	public void SetChangeHiddenTool(bool status = true)
	{
		_ = 8;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (5 == 0)
		{
		}
		program.SetChangeHiddenTool(status);
	}

	public void ResetChangeHiddenTool()
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		_program.ResetChangeHiddenTool();
	}

	public void SetDisableAdvanceEdgeChange(bool status = true)
	{
		_ = 8;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (false)
		{
		}
		program.SetDisableAdvanceEdgeChange(status);
	}

	public void ResetDisableAdvanceEdgeChange()
	{
		_ = 3;
		if (2 == 0)
		{
		}
		_program.ResetDisableAdvanceEdgeChange();
	}

	public void SetAttribute(string name, double value)
	{
		_ = 6;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (-1 == 0)
		{
		}
		_ = 0;
		if (5 == 0)
		{
		}
		program.SetAttribute(name, value);
	}

	public void SetParametricAttribute(string name, double value, double uPar)
	{
		_ = 2;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (4 == 0)
		{
		}
		_ = 4;
		if (7 == 0)
		{
		}
		program.SetParametricAttribute(name, value, uPar);
	}

	public void SetAttribute2(string name, double value1, double value2)
	{
		_ = -1;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (3 == 0)
		{
		}
		_ = 2;
		if (8 == 0)
		{
		}
		program.SetAttribute2(name, value1, value2);
	}

	public void SetStartPointAttribute(int elementIndex, double value)
	{
		_ = -1;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (3 == 0)
		{
		}
		_ = 8;
		if (8 == 0)
		{
		}
		program.SetStartPointAttribute(elementIndex, value);
	}

	public void SetEndPointAttribute(int elementIndex, double value)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (false)
		{
		}
		_ = 3;
		if (7 == 0)
		{
		}
		program.SetEndPointAttribute(elementIndex, value);
	}

	public void SetParametricAttribute2(string name, double value1, double value2, double uPar)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (1 == 0)
		{
		}
		_ = 1;
		if (6 == 0)
		{
		}
		program.SetParametricAttribute2(name, value1, value2, uPar);
	}

	public void SetToolpathAttribute(string name, double value)
	{
		_ = 7;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (4 == 0)
		{
		}
		_ = 5;
		if (-1 == 0)
		{
		}
		program.SetToolpathAttribute(name, value);
	}

	public ContourParallelStrategy CreateContourParallelStrategy(bool insideToOutSide = true, int rotationDirection = 1, bool allowMultiplePasses = false, double cuttingDepth = 0.0, double finishCuttingDepth = 0.0, int strokeConnectionType = 1, bool isHelicStrategy = false, bool isApproachRetractPassStrategy = false, double allowanceSide = 0.0)
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (1 == 0)
		{
		}
		_ = 8;
		if (5 == 0)
		{
		}
		return program.CreateContourParallelStrategy(insideToOutSide, rotationDirection, allowMultiplePasses, cuttingDepth, finishCuttingDepth, strokeConnectionType, isHelicStrategy, isApproachRetractPassStrategy, allowanceSide);
	}

	public SingleStepDrillingStrategy CreateSingleStepDrillingStrategy()
	{
		_ = 0;
		if (6 == 0)
		{
		}
		return _program.CreateSingleStepDrillingStrategy();
	}

	public BidirectionalMillingStrategy CreateBidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (5 == 0)
		{
		}
		_ = 8;
		if (2 == 0)
		{
		}
		return program.CreateBidirectionalMillingStrategy(allowMultiplePasses, cuttingDepth, finishCuttingDepth);
	}

	public UnidirectionalMillingStrategy CreateUnidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth, int strokeConnectionType = 1, bool isApproachRetractPassStrategy = false)
	{
		_ = 7;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (2 == 0)
		{
		}
		_ = 5;
		if (4 == 0)
		{
		}
		return program.CreateUnidirectionalMillingStrategy(allowMultiplePasses, cuttingDepth, finishCuttingDepth, strokeConnectionType, isApproachRetractPassStrategy);
	}

	public SectioningMillingStrategy CreateSectioningMillingStrategy(double firstCutDepth, double outDistance, double sideMovingDistance = 0.0)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (4 == 0)
		{
		}
		_ = 1;
		if (4 == 0)
		{
		}
		return program.CreateSectioningMillingStrategy(firstCutDepth, outDistance, sideMovingDistance);
	}

	public MultiStepDrillingStrategy CreateMultiStepDrillingStrategy(bool isStepDepth, int stepNumber = 1, double stepDepth = 0.0)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (1 == 0)
		{
		}
		_ = 6;
		if (6 == 0)
		{
		}
		return program.CreateMultiStepDrillingStrategy(isStepDepth, stepNumber, stepDepth);
	}

	public HelicMillingStrategy CreateHelicMillingStrategy(double cuttingDepth, bool allowsFinishCutting, double finishCuttingDepth)
	{
		_ = -1;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (false)
		{
		}
		_ = 5;
		if (false)
		{
		}
		return program.CreateHelicMillingStrategy(cuttingDepth, allowsFinishCutting, finishCuttingDepth);
	}

	public ZigZagMillingStrategy CreateZigZagMillingStrategy(double feedCuttingDepth, double returnCuttingDepth, double finishCuttingDepth)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (7 == 0)
		{
		}
		_ = 3;
		if (8 == 0)
		{
		}
		return program.CreateZigZagMillingStrategy(feedCuttingDepth, returnCuttingDepth, finishCuttingDepth);
	}

	public PlaneCutterLocationStrategy CreatePlaneCutterLocationStrategy(double zRotation, double xRotation)
	{
		_ = 7;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		_ = 8;
		if (3 == 0)
		{
		}
		return program.CreatePlaneCutterLocationStrategy(zRotation, xRotation);
	}

	public EndTrimmingStrategy CreateEndTrimmingStrategy(WorkSide workside, CuttingMethod cuttingMethod, double overMaterial, object overCutLenght = null)
	{
		_ = 1;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		_ = 4;
		if (-1 == 0)
		{
		}
		return program.CreateEndTrimmingStrategy(workside, cuttingMethod, overMaterial, overCutLenght);
	}

	public ToolPath CreateToolpath(string name, double startX, double startY, double startZ)
	{
		_ = 2;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (7 == 0)
		{
		}
		_ = 0;
		if (7 == 0)
		{
		}
		return program.CreateToolpath(name, startX, startY, startZ);
	}

	public ToolPath3D CreateToolpath3D(string name, double startX, double startY, double startZ)
	{
		_ = 0;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (false)
		{
		}
		_ = 1;
		if (3 == 0)
		{
		}
		return program.CreateToolpath3D(name, startX, startY, startZ);
	}

	public ToolPath AddSegmentToToolpath(double endX, double endY, double endZ)
	{
		_ = 2;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (3 == 0)
		{
		}
		_ = 5;
		if (6 == 0)
		{
		}
		return program.AddSegmentToToolpath(endX, endY, endZ);
	}

	public ToolPath3D AddSegmentToToolpath(double endX, double endY, double endZ, double? ZRotation = null, double? XRotation = null)
	{
		_ = 3;
		if (false)
		{
		}
		Program program = _program;
		_ = 3;
		if (1 == 0)
		{
		}
		_ = 3;
		if (4 == 0)
		{
		}
		return program.AddSegmentToToolpath(endX, endY, endZ, ZRotation, XRotation);
	}

	public ToolPath AddArc3PointsToToolpath(double p2X, double p2Y, double p3X, double p3Y, double p3Z)
	{
		_ = 2;
		if (false)
		{
		}
		Program program = _program;
		_ = 7;
		if (7 == 0)
		{
		}
		_ = -1;
		if (5 == 0)
		{
		}
		return program.AddArc3PointsToToolpath(p2X, p2Y, p3X, p3Y, p3Z);
	}

	public ToolPath AddArc2PointCenterToToolpath(double endX, double endY, double endZ, double centerX, double centerY, bool isClockwise)
	{
		_ = 4;
		if (false)
		{
		}
		Program program = _program;
		_ = 0;
		if (3 == 0)
		{
		}
		_ = 6;
		if (7 == 0)
		{
		}
		return program.AddArc2PointCenterToToolpath(endX, endY, endZ, centerX, centerY, isClockwise);
	}

	public ToolPath AddArc2PointRadiusToToolpath(double endX, double endY, double endZ, double radius, bool isClockwise, bool isOver180)
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (1 == 0)
		{
		}
		_ = 2;
		if (-1 == 0)
		{
		}
		return program.AddArc2PointRadiusToToolpath(endX, endY, endZ, radius, isClockwise, isOver180);
	}

	public ToolPath AddArcCenterAngleToToolpath(double centerX, double centerY, double endZ, double angle)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (8 == 0)
		{
		}
		_ = 0;
		if (5 == 0)
		{
		}
		return program.AddArcCenterAngleToToolpath(centerX, centerY, endZ, angle);
	}

	public ToolPath SelectToolpath(string name)
	{
		_ = 6;
		if (false)
		{
		}
		Program program = _program;
		_ = 2;
		if (8 == 0)
		{
		}
		return program.SelectToolpath(name);
	}

	public ToolPath SelectToolpath(int index)
	{
		_ = 8;
		if (false)
		{
		}
		Program program = _program;
		_ = 7;
		if (7 == 0)
		{
		}
		return program.SelectToolpath(index);
	}

	public void DeleteToolpath(string name)
	{
		_ = 8;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (2 == 0)
		{
		}
		program.DeleteToolpath(name);
	}

	public void DeleteToolpath(int index)
	{
		_ = 5;
		if (false)
		{
		}
		Program program = _program;
		_ = 4;
		if (1 == 0)
		{
		}
		program.DeleteToolpath(index);
	}

	public Tool GetTool(string tool)
	{
		_ = 6;
		if (false)
		{
		}
		Program program = _program;
		_ = 4;
		if (5 == 0)
		{
		}
		return program.GetTool(tool);
	}

	public void Mirror(string name, bool mirrorX, bool mirrorY, bool reverseOperation = false, bool createNewCopy = false)
	{
		_ = 8;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 5;
		if (8 == 0)
		{
		}
		program.Mirror(name, mirrorX, mirrorY, reverseOperation, createNewCopy);
	}

	public void Rotate(string name, double x, double y, double angle, bool createNewCopy = false)
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (7 == 0)
		{
		}
		_ = 1;
		if (3 == 0)
		{
		}
		program.Rotate(name, x, y, angle, createNewCopy);
	}

	public Arc CreateFillet(string geom1, string geom2, double radius, int option = 0)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (false)
		{
		}
		_ = -1;
		if (5 == 0)
		{
		}
		return program.CreateFillet(geom1, geom2, radius, option);
	}

	public Polyline CreateFillet(string geom, string element1, string element2, double radius, int option = 0)
	{
		_ = 4;
		if (false)
		{
		}
		Program program = _program;
		_ = 5;
		if (1 == 0)
		{
		}
		_ = 1;
		if (8 == 0)
		{
		}
		return program.CreateFillet(geom, element1, element2, radius, option);
	}

	public Polyline CreateFillet(string geom, int element1, int element2, double radius, int option = 0)
	{
		_ = 7;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (-1 == 0)
		{
		}
		_ = 3;
		if (2 == 0)
		{
		}
		return program.CreateFillet(geom, element1, element2, radius, option);
	}

	public Segment CreateChamfer(string geom1, string geom2, double length1, double length2, int option = 0)
	{
		_ = 5;
		if (false)
		{
		}
		Program program = _program;
		_ = 6;
		if (8 == 0)
		{
		}
		_ = 6;
		if (8 == 0)
		{
		}
		return program.CreateChamfer(geom1, geom2, length1, length2, option);
	}

	public Polyline CreateChamfer(string geom, string element1, string element2, double length1, double length2, int option = 0)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		_ = -1;
		if (-1 == 0)
		{
		}
		return program.CreateChamfer(geom, element1, element2, length1, length2, option);
	}

	public Polyline CreateChamfer(string geom, int element1, int element2, double length1, double length2, int option = 0)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (1 == 0)
		{
		}
		_ = 7;
		if (8 == 0)
		{
		}
		return program.CreateChamfer(geom, element1, element2, length1, length2, option);
	}

	public void SetIncrementalInput(string axis, bool enable)
	{
		_ = 5;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (5 == 0)
		{
		}
		_ = 0;
		if (false)
		{
		}
		program.SetIncrementalInput(axis, enable);
	}

	public bool GetIncrementalInput(string axis)
	{
		_ = 4;
		if (false)
		{
		}
		Program program = _program;
		_ = 0;
		if (false)
		{
		}
		return program.GetIncrementalInput(axis);
	}

	public void SetRotation(double angle, double x, double y, double z)
	{
		_ = -1;
		if (false)
		{
		}
		Program program = _program;
		_ = -1;
		if (2 == 0)
		{
		}
		_ = 0;
		if (3 == 0)
		{
		}
		program.SetRotation(angle, x, y, z);
	}

	public void SetTranslation(double x, double y, double z, string planeName)
	{
		_ = 5;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (5 == 0)
		{
		}
		_ = 1;
		if (8 == 0)
		{
		}
		program.SetTranslation(x, y, z, planeName);
	}

	public void SetMirror(bool mirrorX, bool mirrorY, bool arcInversion)
	{
		_ = 0;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (3 == 0)
		{
		}
		_ = 4;
		if (8 == 0)
		{
		}
		program.SetMirror(mirrorX, mirrorY, arcInversion);
	}

	public void SetMirrorX(bool mirror, bool arcInversion)
	{
		_ = 7;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (6 == 0)
		{
		}
		_ = 7;
		if (6 == 0)
		{
		}
		program.SetMirrorX(mirror, arcInversion);
	}

	public void SetMirrorY(bool mirror, bool arcInversion)
	{
		_ = 5;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (false)
		{
		}
		_ = 7;
		if (3 == 0)
		{
		}
		program.SetMirrorY(mirror, arcInversion);
	}

	public void SetApproachSecurityDistance(double? value = null)
	{
		_ = 6;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (false)
		{
		}
		program.SetApproachSecurityDistance(value);
	}

	public void SetRetractSecurityDistance(double? value = null)
	{
		_ = 0;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		program.SetRetractSecurityDistance(value);
	}

	public void SetMachiningDirection(bool sameDirection)
	{
		_ = 6;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (-1 == 0)
		{
		}
		program.SetMachiningDirection(sameDirection);
	}

	public MachineParameters SetMachiningParameters(string executionFields, int repetitions, long tableOptions, long mechanicalOptions, bool continuousCycle)
	{
		_ = 7;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (8 == 0)
		{
		}
		_ = 8;
		if (2 == 0)
		{
		}
		return program.SetMachiningParameters(executionFields, repetitions, tableOptions, mechanicalOptions, continuousCycle);
	}

	public MachineParameters GetMachiningParameters()
	{
		_ = 1;
		if (2 == 0)
		{
		}
		return _program.GetMachiningParameters();
	}

	public MachineParameters SetSideStopPositionY(double positionY)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (false)
		{
		}
		return program.SetSideStopPositionY(positionY);
	}

	public MachineParameters SetRelatedToOppositeSideStop(bool isRelatedToOppositeSideStop)
	{
		_ = 5;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (2 == 0)
		{
		}
		return program.SetRelatedToOppositeSideStop(isRelatedToOppositeSideStop);
	}

	public MachineParameters SetDefaultForTableOptions(bool useDefaultForTableOptions)
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (false)
		{
		}
		return program.SetDefaultForTableOptions(useDefaultForTableOptions);
	}

	public MachineParameters SetTechnologicalMirror(bool isTechnologicalMirror)
	{
		_ = 2;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (-1 == 0)
		{
		}
		return program.SetTechnologicalMirror(isTechnologicalMirror);
	}

	public MachineParameters SetAutoSetup(bool autoSetup)
	{
		_ = 0;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (2 == 0)
		{
		}
		return program.SetAutoSetup(autoSetup);
	}

	public MachineParameters SetOptimization(bool enableOptimization)
	{
		_ = 6;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (7 == 0)
		{
		}
		return program.SetOptimization(enableOptimization);
	}

	public MachineParameters SetWorkPieceSidePresserDisabledOnStart(bool isWorkPieceSidePresserDisabledOnStart)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (3 == 0)
		{
		}
		return program.SetWorkPieceSidePresserDisabledOnStart(isWorkPieceSidePresserDisabledOnStart);
	}

	public MachineParameters SetPreserveWorkingSequence(bool preserveWorkingSequence)
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		return program.SetPreserveWorkingSequence(preserveWorkingSequence);
	}

	public MachineParameters SetMultipleDrillingsCanChangeWorkingSequence(bool multipleDrillingsCanChangeWorkingSequence)
	{
		_ = 4;
		if (false)
		{
		}
		Program program = _program;
		_ = 4;
		if (-1 == 0)
		{
		}
		return program.SetMultipleDrillingsCanChangeWorkingSequence(multipleDrillingsCanChangeWorkingSequence);
	}

	public MachineParameters SetWorkPieceFallPrevention(bool useWorkPieceFallPrevention)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (2 == 0)
		{
		}
		return program.SetWorkPieceFallPrevention(useWorkPieceFallPrevention);
	}

	public MachineParameters SetToeKickWait(bool waitForLeftToeKick, bool waitForRightToeKick)
	{
		_ = 2;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (false)
		{
		}
		_ = 0;
		if (6 == 0)
		{
		}
		return program.SetToeKickWait(waitForLeftToeKick, waitForRightToeKick);
	}

	public MachineParameters SetComment(string comment)
	{
		_ = -1;
		if (false)
		{
		}
		Program program = _program;
		_ = 6;
		if (5 == 0)
		{
		}
		return program.SetComment(comment);
	}

	public MachineParameters SetDescription(string description)
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (2 == 0)
		{
		}
		return program.SetDescription(description);
	}

	public MachineParameters SetEdgeBandingOptimization(bool isRotationOptimizationEnabled, bool isAutostartOptimizationEnabled, bool isClosingOptimizationEnabled, bool isLampOptimizationEnabled, bool isApproachOptimizationEnabled, bool isRetractOptimizationEnabled, bool isRollStopOptimizationEnabled, bool isSpeedOptimizationEnabled, bool isTrimmingOptimizationEnabled)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (false)
		{
		}
		_ = 3;
		if (7 == 0)
		{
		}
		return program.SetEdgeBandingOptimization(isRotationOptimizationEnabled, isAutostartOptimizationEnabled, isClosingOptimizationEnabled, isLampOptimizationEnabled, isApproachOptimizationEnabled, isRetractOptimizationEnabled, isRollStopOptimizationEnabled, isSpeedOptimizationEnabled, isTrimmingOptimizationEnabled);
	}

	public MachineParameters SetEnableDynamicAreas(bool enableDynamicAreas)
	{
		_ = 7;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (5 == 0)
		{
		}
		return program.SetEnableDynamicAreas(enableDynamicAreas);
	}

	public void ApplyTechnology(string name)
	{
		_ = 2;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (4 == 0)
		{
		}
		program.ApplyTechnology(name);
	}

	public void SelectTechnology(string name, params string[] geometryNames)
	{
		_ = 0;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (false)
		{
		}
		_ = 5;
		if (false)
		{
		}
		program.SelectTechnology(name, geometryNames);
	}

	public void SelectGeometryTechnology(string name, int r, int g, int b)
	{
		_ = 6;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (8 == 0)
		{
		}
		_ = 8;
		if (8 == 0)
		{
		}
		program.SelectGeometryTechnology(name, r, g, b);
	}

	public void ApplyTechnology()
	{
		_ = 1;
		if (7 == 0)
		{
		}
		_program.ApplyTechnology();
	}

	public double abs(double value)
	{
		_ = 7;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (6 == 0)
		{
		}
		return program.abs(value);
	}

	public double ABS(double value)
	{
		_ = 0;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (3 == 0)
		{
		}
		return program.abs(value);
	}

	public double acos(double value)
	{
		_ = 5;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (6 == 0)
		{
		}
		return program.acos(value);
	}

	public double ACOS(double value)
	{
		_ = 4;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (-1 == 0)
		{
		}
		return program.acos(value);
	}

	public double asin(double value)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		return program.asin(value);
	}

	public double ASIN(double value)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (8 == 0)
		{
		}
		return program.asin(value);
	}

	public double atan(double value)
	{
		_ = 3;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (2 == 0)
		{
		}
		return program.atan(value);
	}

	public double ATAN(double value)
	{
		_ = 0;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (2 == 0)
		{
		}
		return program.atan(value);
	}

	public double sin(double value)
	{
		_ = 2;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (1 == 0)
		{
		}
		return program.sin(value);
	}

	public double SIN(double value)
	{
		_ = 2;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (4 == 0)
		{
		}
		return program.sin(value);
	}

	public double COS(double value)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (5 == 0)
		{
		}
		return program.cos(value);
	}

	public double cos(double value)
	{
		_ = 1;
		if (false)
		{
		}
		Program program = _program;
		_ = 2;
		if (6 == 0)
		{
		}
		return program.cos(value);
	}

	public double TAN(double value)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (1 == 0)
		{
		}
		return program.tan(value);
	}

	public double tan(double value)
	{
		_ = -1;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (-1 == 0)
		{
		}
		return program.tan(value);
	}

	public double ln(double value)
	{
		_ = 6;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (-1 == 0)
		{
		}
		return program.ln(value);
	}

	public double LN(double value)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (8 == 0)
		{
		}
		return program.ln(value);
	}

	public double log10(double value)
	{
		_ = 0;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (7 == 0)
		{
		}
		return program.log10(value);
	}

	public double LOG10(double value)
	{
		_ = 0;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (false)
		{
		}
		return program.log10(value);
	}

	public double exp(double value)
	{
		_ = 8;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (false)
		{
		}
		return program.exp(value);
	}

	public double EXP(double value)
	{
		_ = 8;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (8 == 0)
		{
		}
		return program.exp(value);
	}

	public double sqrt(double value)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (1 == 0)
		{
		}
		return program.sqrt(value);
	}

	public double SQRT(double value)
	{
		_ = 6;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (1 == 0)
		{
		}
		return program.sqrt(value);
	}

	public double pow(double x, double y)
	{
		_ = 5;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (5 == 0)
		{
		}
		_ = 1;
		if (5 == 0)
		{
		}
		return program.pow(x, y);
	}

	public double POW(double x, double y)
	{
		_ = 6;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (6 == 0)
		{
		}
		_ = 6;
		if (6 == 0)
		{
		}
		return program.pow(x, y);
	}

	public double rd(double value)
	{
		_ = 6;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (2 == 0)
		{
		}
		return program.rd(value);
	}

	public double RD(double value)
	{
		_ = 8;
		if (false)
		{
		}
		Program program = _program;
		_ = 8;
		if (3 == 0)
		{
		}
		return program.rd(value);
	}

	public double ru(double value)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (8 == 0)
		{
		}
		return program.ru(value);
	}

	public double RU(double value)
	{
		_ = 7;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (1 == 0)
		{
		}
		return program.ru(value);
	}

	public string GetVersion()
	{
		_ = 6;
		if (5 == 0)
		{
		}
		return _program.GetVersion();
	}

	public void Print(string message)
	{
		_ = 2;
		if (3 == 0)
		{
		}
		throw new Exception(message);
	}

	public static string GetString(string macroName, string key)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		_ = 6;
		if (4 == 0)
		{
		}
		return Program.GetString(macroName, key);
	}

	public bool NDEF(double? value)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		return program.NDEF(value);
	}

	public bool DEF(double? value)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (1 == 0)
		{
		}
		return program.DEF(value);
	}

	public bool NDEF(string value)
	{
		_ = 4;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 0;
		if (4 == 0)
		{
		}
		return program.NDEF(value);
	}

	public bool DEF(string value)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (7 == 0)
		{
		}
		return program.DEF(value);
	}

	public double V(double? par)
	{
		_ = 3;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (2 == 0)
		{
		}
		return program.V(par);
	}

	public double VALUE(double? par)
	{
		_ = 0;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 4;
		if (false)
		{
		}
		return program.V(par);
	}

	public int GetProgrammingOrigine()
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		return _program.GetProgrammingOrigine();
	}

	public void SetBarPosition(int id, double xPosition)
	{
		_ = 7;
		if (1 == 0)
		{
		}
		Program program = _program;
		_ = 5;
		if (4 == 0)
		{
		}
		_ = 3;
		if (8 == 0)
		{
		}
		program.SetBarPosition(id, xPosition);
	}

	public void SetMobileBarPosition(int id, int position)
	{
		_ = 1;
		if (false)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		_ = 2;
		if (6 == 0)
		{
		}
		program.SetMobileBarPosition(id, position);
	}

	public void SetSupportBasePosition(int id, double yPosition)
	{
		_ = 3;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (8 == 0)
		{
		}
		_ = 3;
		if (-1 == 0)
		{
		}
		program.SetSupportBasePosition(id, yPosition);
	}

	public void SetClampPosition(int supportId, double yPosition, int status, string code)
	{
		_ = 5;
		if (2 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (-1 == 0)
		{
		}
		_ = 3;
		if (8 == 0)
		{
		}
		program.SetClampPosition(supportId, yPosition, status, code);
	}

	public void SetHorizontalClampPosition(int supportId, double yPosition, int status, string code)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (5 == 0)
		{
		}
		_ = 7;
		if (5 == 0)
		{
		}
		program.SetHorizontalClampPosition(supportId, yPosition, status, code);
	}

	public void SetClampForJambPosition(int supportId, double yPosition, int status, string code)
	{
		_ = 7;
		if (7 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (8 == 0)
		{
		}
		_ = -1;
		if (3 == 0)
		{
		}
		program.SetClampForJambPosition(supportId, yPosition, status, code);
	}

	public void SetSuctionCupPosition(int supportId, double yPosition, double angle, string code)
	{
		_ = 1;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 7;
		if (6 == 0)
		{
		}
		_ = 3;
		if (false)
		{
		}
		program.SetSuctionCupPosition(supportId, yPosition, angle, code);
	}

	public void SetMLTFSuctionCupPosition(double xPosition, double yPosition, double angle, string code)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (1 == 0)
		{
		}
		_ = 0;
		if (6 == 0)
		{
		}
		program.SetMLTFSuctionCupPosition(xPosition, yPosition, angle, code);
	}

	public WorkingField GetWorkingField(string field)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		Program program = _program;
		_ = 3;
		if (6 == 0)
		{
		}
		return program.GetWorkingField(field);
	}

	public void SetCompensationMode(bool isCnc)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		Program program = _program;
		_ = -1;
		if (3 == 0)
		{
		}
		program.SetCompensationMode(isCnc);
	}

	public void SetStartMachiningPosition(int position)
	{
		_ = 8;
		if (3 == 0)
		{
		}
		Program program = _program;
		_ = 1;
		if (1 == 0)
		{
		}
		program.SetStartMachiningPosition(position);
	}

	public void SetFeedrateProfile(string feedrateProfileName)
	{
		_ = 5;
		if (6 == 0)
		{
		}
		Program program = _program;
		_ = 2;
		if (7 == 0)
		{
		}
		program.SetFeedrateProfile(feedrateProfileName);
	}

	public void ResetFeedrateProfile()
	{
		_ = 1;
		if (false)
		{
		}
		_program.ResetFeedrateProfile();
	}

	public void AddVariable(string name, object value, int type, int unitType, string description, bool isReadOnly, bool isExportable)
	{
		_ = 6;
		if (4 == 0)
		{
		}
		Program program = _program;
		_ = 8;
		if (1 == 0)
		{
		}
		_ = 5;
		if (-1 == 0)
		{
		}
		program.AddVariable(name, value, type, unitType, description, isReadOnly, isExportable);
	}

	public void InitializeComplexProcess()
	{
		_ = 3;
		if (3 == 0)
		{
		}
		_program.InitializeComplexProcess();
	}

	public void CreateComplexProcess()
	{
		_ = 1;
		if (3 == 0)
		{
		}
		_program.CreateComplexProcess();
	}

	public DynamicWorkingAreaUsageStatus SetDynamicAreaLength(double dynamicWorkingAreaLength)
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		Program program = _program;
		_ = 6;
		if (7 == 0)
		{
		}
		return program.SetDynamicAreaLength(dynamicWorkingAreaLength);
	}
}
