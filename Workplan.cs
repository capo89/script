using System;
using System.Collections.Generic;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;

namespace ScmGroup.XCam.Scripting;

public class Workplan : BaseScripting
{
	public Workplan(ProjectInterface projectInterface)
	{
		if (0 == 0)
		{
			_projectInterface = projectInterface;
		}
	}

	public Workplan(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (4u != 0)
		{
			base.Name = name;
		}
	}

	public Workplan(ProjectInterface projectInterface, MainWorkplan mainWorkplan)
		: this(mainWorkplan.Name, projectInterface)
	{
		ReferenceKey key = mainWorkplan.Key;
		if (4u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public Workplan(string name, ProjectInterface projectInterface, MainWorkplan mainWorkplan)
		: this(name, projectInterface)
	{
		ReferenceKey key = mainWorkplan.Key;
		if (3u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public Workplan(string name, ProjectInterface projectInterface, ReferenceKey mainWorkplanKey)
		: this(name, projectInterface)
	{
		if (8u != 0)
		{
			base.ReferenceKey = mainWorkplanKey;
		}
	}

	public void CreateWorkplan()
	{
		try
		{
			MainWorkplan mainWorkplan = new MainWorkplan();
			MainWorkplan workplan;
			if (5u != 0)
			{
				workplan = mainWorkplan;
			}
			workplan.Name = base.Name;
			List<WorkPiece> list = _projectInterface.GetList<WorkPiece>();
			List<WorkPiece> list2;
			if (7u != 0)
			{
				list2 = list;
			}
			if (list2 != null)
			{
				List<WorkPiece>.Enumerator enumerator = list2.GetEnumerator();
				List<WorkPiece>.Enumerator enumerator2;
				if (3u != 0)
				{
					enumerator2 = enumerator;
				}
				try
				{
					while (enumerator2.MoveNext())
					{
						WorkPiece current = enumerator2.Current;
						WorkpieceSetup workpieceSetup = new WorkpieceSetup();
						workpieceSetup.WorkpieceID = current.Key;
						workpieceSetup.RawGeometryIndex = ((current.RawGeometries != null && current.RawGeometries.Count != 0) ? (current.RawGeometries.Count - 1) : (-1));
						workplan.Setup.WorkpieceSetups.Add(workpieceSetup);
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
			}
			_projectInterface.AddMainWorkplan(ref workplan, this);
			base.ReferenceKey = workplan.Key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716501), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}
}
