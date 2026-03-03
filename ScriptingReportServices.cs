using System;
using System.IO;
using System.Text;
using ScmGroup.XCam.Common;

namespace ScmGroup.XCam.Scripting;

public class ScriptingReportServices : IScriptingReportServices
{
	private UI00Options _0023_003DzgK1Mwoo_003D;

	private string _0023_003DzwmvVymUFOdqP;

	private StringBuilder _0023_003Dz5V0H3FYeCY_0024t;

	private bool _0023_003DzCvQ4G51952A3;

	public ScriptingReportServices(UI00Options options, string reportFilePath)
	{
		if (0 == 0)
		{
			_0023_003DzgK1Mwoo_003D = options;
		}
		if (4u != 0)
		{
			_0023_003DzwmvVymUFOdqP = reportFilePath;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (7u != 0)
		{
			_0023_003Dz5V0H3FYeCY_0024t = stringBuilder;
		}
		_0023_003DzCvQ4G51952A3 = _0023_003DzgK1Mwoo_003D?.ImportOptions?.IsEnableErrorsLog ?? false;
	}

	public bool IsSuccess()
	{
		_ = 4;
		if (2 == 0)
		{
		}
		return _0023_003Dz5V0H3FYeCY_0024t.Length == 0;
	}

	public void AddMessage(string message)
	{
		if (!StringUtility.IsValid(message) || !_0023_003DzCvQ4G51952A3)
		{
			return;
		}
		_0023_003Dz5V0H3FYeCY_0024t.AppendLine(message);
		if (StringUtility.IsValid(_0023_003DzwmvVymUFOdqP))
		{
			string[] array = new string[6];
			DateTime now = DateTime.Now;
			DateTime dateTime;
			if (2u != 0)
			{
				dateTime = now;
			}
			int hour = dateTime.Hour;
			int num;
			if (2u != 0)
			{
				num = hour;
			}
			array[0] = num.ToString();
			array[1] = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709043);
			DateTime now2 = DateTime.Now;
			if (2u != 0)
			{
				dateTime = now2;
			}
			int minute = dateTime.Minute;
			if (7u != 0)
			{
				num = minute;
			}
			array[2] = num.ToString();
			array[3] = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709043);
			array[4] = DateTime.Now.Second.ToString();
			array[5] = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709035);
			string text = string.Concat(array);
			text = text + DateTime.Now.Day + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709025) + DateTime.Now.Month + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709025) + DateTime.Now.Year + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709035);
			string text2 = text + message;
			File.AppendAllText(_0023_003DzwmvVymUFOdqP, text2 + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709017));
		}
	}

	public string GetMessage()
	{
		_ = 2;
		if (3 == 0)
		{
		}
		return _0023_003Dz5V0H3FYeCY_0024t.ToString();
	}
}
