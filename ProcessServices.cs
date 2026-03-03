using System;
using System.Collections.Generic;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Process;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class ProcessServices
{
	private ProjectInterface _0023_003DzFt4EzpvUYOLD;

	private bool _0023_003Dz70BlMyRaJxRm;

	private List<ReferenceKey> _0023_003DzzHSIsFkxqy_0024O;

	public ProcessServices(ProjectInterface projectInterface)
	{
		if (5u != 0)
		{
			_0023_003DzFt4EzpvUYOLD = projectInterface;
		}
		if (true)
		{
			_0023_003Dz70BlMyRaJxRm = false;
		}
		List<ReferenceKey> list = new List<ReferenceKey>();
		if (true)
		{
			_0023_003DzzHSIsFkxqy_0024O = list;
		}
	}

	public void Enable()
	{
		if (true)
		{
			_0023_003Dz70BlMyRaJxRm = true;
		}
	}

	public void Disable()
	{
		if (6u != 0)
		{
			_0023_003Dz70BlMyRaJxRm = false;
		}
		_0023_003DzzHSIsFkxqy_0024O.Clear();
	}

	public void Add(ReferenceKey executableKey)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		if (_0023_003Dz70BlMyRaJxRm)
		{
			_ = 4;
			if (-1 == 0)
			{
			}
			List<ReferenceKey> list = _0023_003DzzHSIsFkxqy_0024O;
			_ = 7;
			if (7 == 0)
			{
			}
			list.Add(executableKey);
		}
	}

	public bool CreateProcess()
	{
		bool result;
		if (uint.MaxValue != 0)
		{
			result = false;
		}
		if (_0023_003DzzHSIsFkxqy_0024O.Count > 0)
		{
			ProcessCreator processCreator = new ProcessCreator(_0023_003DzFt4EzpvUYOLD);
			ProcessCreator processCreator2;
			if (4u != 0)
			{
				processCreator2 = processCreator;
			}
			List<ReferenceKey>.Enumerator enumerator = _0023_003DzzHSIsFkxqy_0024O.GetEnumerator();
			List<ReferenceKey>.Enumerator enumerator2;
			if (uint.MaxValue != 0)
			{
				enumerator2 = enumerator;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					ReferenceKey current = enumerator2.Current;
					if (_0023_003DzFt4EzpvUYOLD.Get(current) is Executable executable)
					{
						processCreator2.Add(executable);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
			result = processCreator2.Create();
		}
		return result;
	}
}
