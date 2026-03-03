using System;
using System.Collections.Generic;
using OccExtension;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCAM.GeometryDataModel.Utility;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.ProjectObjectModel.Builders.WorkpieceBuilders;

namespace ScmGroup.XCam.Scripting;

public class Workpiece : BaseScripting
{
	private sealed class _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D
	{
		public ReferenceKey _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D;

		public Predicate<WorkpieceSetup> _0023_003DzT2FUfmoqfxMd;

		public _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D()
		{
			_ = 5;
			if (6 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dzse5iTyBgcuYg_0024qj7_1b9RFpkvK95(WorkpieceSetup _0023_003DzSJfYMT8_003D)
		{
			_ = 8;
			if (-1 == 0)
			{
			}
			ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
			_ = 8;
			if (-1 == 0)
			{
			}
			return workpieceID == _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D;
		}
	}

	internal gp_Vec _0023_003Dz22bRUgtajyHzlQdchQ_003D_003D;

	public double Height
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
				WorkPiece obj = _projectInterface.Get(base.ReferenceKey) as WorkPiece;
				WorkPiece workPiece;
				if (uint.MaxValue != 0)
				{
					workPiece = obj;
				}
				if (workPiece != null)
				{
					double depth = workPiece.Depth;
					if (3u != 0)
					{
						result = depth;
					}
				}
				return result;
			}
			catch (Exception innerException)
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716204);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716516) };
				throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
			}
		}
	}

	public Workpiece(ProjectInterface projectInterface)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		if (4u != 0)
		{
			_projectInterface = projectInterface;
		}
		gp_Vec val = new gp_Vec(0.0, 0.0, 0.0);
		if (7u != 0)
		{
			_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D = val;
		}
	}

	public Workpiece(string name, ProjectInterface projectInterface)
		: this(projectInterface)
	{
		if (7u != 0)
		{
			base.Name = name;
		}
	}

	public Workpiece(ProjectInterface projectInterface, WorkPiece workpiece)
		: this(workpiece.Name, projectInterface)
	{
		ReferenceKey key = workpiece.Key;
		if (6u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public Workpiece(string name, ProjectInterface projectInterface, WorkPiece workpiece)
		: this(name, projectInterface)
	{
		ReferenceKey key = workpiece.Key;
		if (2u != 0)
		{
			base.ReferenceKey = key;
		}
	}

	public void CreateFinishedWorkpieceBox(object dx, object dy, object dz)
	{
		try
		{
			WorkpieceParameters workpieceParameters = new WorkpieceParameters(null);
			WorkpieceParameters workpieceParameters2;
			if (5u != 0)
			{
				workpieceParameters2 = workpieceParameters;
			}
			workpieceParameters2.InitializeWorkpieceName(base.Name);
			workpieceParameters2.InitializeWorkpieceBoxGeometry(dx, dy, dz);
			new WorkpieceBuilder(_projectInterface, workpieceParameters2).Add();
			ReferenceKey key = workpieceParameters2.Workpiece.Key;
			ReferenceKey referenceKey;
			if (6u != 0)
			{
				referenceKey = key;
			}
			if (true)
			{
				_0023_003Dz0LP9yNLo_0024xuG4AAaF_0024nyUI0_003D(referenceKey);
			}
			base.ReferenceKey = referenceKey;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716554), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dz0LP9yNLo_0024xuG4AAaF_0024nyUI0_003D(ReferenceKey _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D)
	{
		_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D = new _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D();
		_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D CS_0024_003C_003E8__locals3;
		if (5u != 0)
		{
			CS_0024_003C_003E8__locals3 = _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D;
		}
		if (0 == 0)
		{
			CS_0024_003C_003E8__locals3._0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D = _0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D;
		}
		List<MainWorkplan> list = _projectInterface.GetList<MainWorkplan>();
		List<MainWorkplan> list2;
		if (3u != 0)
		{
			list2 = list;
		}
		if (list2 == null)
		{
			return;
		}
		foreach (MainWorkplan item in list2)
		{
			WorkpieceSetup workpieceSetup = item.Setup.WorkpieceSetups.Find(delegate(WorkpieceSetup _0023_003DzSJfYMT8_003D)
			{
				_ = 8;
				if (-1 == 0)
				{
				}
				ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
				_ = 8;
				if (-1 == 0)
				{
				}
				return workpieceID == CS_0024_003C_003E8__locals3._0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D;
			});
			if (workpieceSetup == null)
			{
				workpieceSetup = new WorkpieceSetup();
				workpieceSetup.WorkpieceID = CS_0024_003C_003E8__locals3._0023_003DzgOWDESLmEbTwF_0024c7JQ_003D_003D;
				item.Setup.WorkpieceSetups.Add(workpieceSetup);
				_projectInterface.UpdateMainWorkplan(item, this, selectMainWorkplan: false);
			}
		}
	}

	public void AddRawWorkpieceBox(Workplan workplan, double dx, double dy, double dz, double bx, double by, double bz)
	{
		try
		{
			MainWorkplan obj = _projectInterface.Get(workplan.ReferenceKey) as MainWorkplan;
			MainWorkplan mainWorkplan;
			if (2u != 0)
			{
				mainWorkplan = obj;
			}
			WorkpieceSetup workpieceSetup = mainWorkplan.Setup.WorkpieceSetups.Find(_0023_003DzDxoin8SQiIxC1NDJtLshm2YNmbc9qvYlXg_003D_003D);
			WorkpieceSetup workpieceSetup2;
			if (true)
			{
				workpieceSetup2 = workpieceSetup;
			}
			if (workpieceSetup2 == null)
			{
				WorkpieceSetup workpieceSetup3 = new WorkpieceSetup();
				if (true)
				{
					workpieceSetup2 = workpieceSetup3;
				}
				workpieceSetup2.WorkpieceID = base.ReferenceKey;
				mainWorkplan.Setup.WorkpieceSetups.Add(workpieceSetup2);
			}
			WorkPiece workPiece = _projectInterface.Get(base.ReferenceKey) as WorkPiece;
			if (workPiece.RawGeometries == null)
			{
				workPiece.RawGeometries = new List<WorkpieceGeometry>();
			}
			WorkpieceGeometry workpieceGeometry = new WorkpieceBoxGeometry(dx, dy, dz, bx, by, bz);
			if (workpieceSetup2.RawGeometryIndex == -1)
			{
				workPiece.RawGeometries.Add(workpieceGeometry);
				workpieceSetup2.RawGeometryIndex = workPiece.RawGeometries.Count - 1;
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this);
			}
			else
			{
				workPiece.RawGeometries[workpieceSetup2.RawGeometryIndex] = workpieceGeometry;
			}
			_projectInterface.UpdateWorkPiece(workPiece, this);
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716554), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddRawWorkpiece(Workplan workplan, double bx1, double bx2, double by1, double by2, double bz1, double bz2)
	{
		try
		{
			MainWorkplan obj = _projectInterface.Get(workplan.ReferenceKey) as MainWorkplan;
			MainWorkplan mainWorkplan;
			if (7u != 0)
			{
				mainWorkplan = obj;
			}
			WorkpieceSetup workpieceSetup = mainWorkplan.Setup.WorkpieceSetups.Find(delegate(WorkpieceSetup _0023_003DzSJfYMT8_003D)
			{
				_ = 2;
				if (7 == 0)
				{
				}
				ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
				_ = -1;
				if (7 == 0)
				{
				}
				return workpieceID == base.ReferenceKey;
			});
			WorkpieceSetup workpieceSetup2;
			if (true)
			{
				workpieceSetup2 = workpieceSetup;
			}
			if (workpieceSetup2 == null)
			{
				WorkpieceSetup workpieceSetup3 = new WorkpieceSetup();
				if (2u != 0)
				{
					workpieceSetup2 = workpieceSetup3;
				}
				workpieceSetup2.WorkpieceID = base.ReferenceKey;
				mainWorkplan.Setup.WorkpieceSetups.Add(workpieceSetup2);
			}
			WorkPiece workPiece = _projectInterface.Get(base.ReferenceKey) as WorkPiece;
			if (workPiece.RawGeometries == null)
			{
				workPiece.RawGeometries = new List<WorkpieceGeometry>();
			}
			WorkpieceGeometry workpieceGeometry = new WorkpieceOvermaterialGeometry(bx1, bx2, by1, by2, bz1, bz2);
			if (workpieceSetup2.RawGeometryIndex == -1)
			{
				workPiece.RawGeometries.Add(workpieceGeometry);
				workpieceSetup2.RawGeometryIndex = workPiece.RawGeometries.Count - 1;
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this);
			}
			else
			{
				workPiece.RawGeometries[workpieceSetup2.RawGeometryIndex] = workpieceGeometry;
			}
			_projectInterface.UpdateWorkPiece(workPiece, this);
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716554), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void CreateFinishedWorkpieceFromExtrusion(Geometry workpieceGeometry, object dz, List<Geometry> holeGeometries)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		try
		{
			WorkpieceParameters workpieceParameters = new WorkpieceParameters(null);
			WorkpieceParameters workpieceParameters2;
			if (5u != 0)
			{
				workpieceParameters2 = workpieceParameters;
			}
			workpieceParameters2.InitializeWorkpieceName(base.Name);
			List<GeomGeometry> list = new List<GeomGeometry>();
			List<GeomGeometry> list2;
			if (2u != 0)
			{
				list2 = list;
			}
			List<GeomGeometry> list3 = new List<GeomGeometry>();
			List<GeomGeometry> openGeometries;
			if (3u != 0)
			{
				openGeometries = list3;
			}
			Geom_Axis2Placement _0023_003DzNTWRxrkFujp = new Geom_Axis2Placement(gp.Origin(), gp.DZ(), gp.DX());
			GeomGeometry geomGeometry = _projectInterface.Get(workpieceGeometry.ReferenceKey) as GeomGeometry;
			_0023_003DzoOcaehJpA9jve_0024SmSeEKAkI_003D(geomGeometry, _0023_003DzNTWRxrkFujp);
			list2.Add(geomGeometry);
			_0023_003Dzo9WtXsL29ij1(geomGeometry);
			if (holeGeometries != null)
			{
				foreach (Geometry holeGeometry in holeGeometries)
				{
					GeomGeometry geomGeometry2 = _projectInterface.Get(holeGeometry.ReferenceKey) as GeomGeometry;
					_0023_003DzoOcaehJpA9jve_0024SmSeEKAkI_003D(geomGeometry2, _0023_003DzNTWRxrkFujp);
					list2.Add(geomGeometry2);
				}
			}
			workpieceParameters2.InitializeWorkpieceExtrusionGeometry(list2, openGeometries, dz);
			new WorkpieceBuilder(_projectInterface, workpieceParameters2).Add();
			ReferenceKey key = workpieceParameters2.Workpiece.Key;
			_0023_003Dz0LP9yNLo_0024xuG4AAaF_0024nyUI0_003D(key);
			base.ReferenceKey = key;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716554), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void AddRawWorkpieceFromExtrusion(Workplan workplan, Geometry workpieceGeometry, double dz, double bx, double by, double bz, List<Geometry> holeList)
	{
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0277: Expected O, but got Unknown
		//IL_0277: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		try
		{
			MainWorkplan obj = _projectInterface.Get(workplan.ReferenceKey) as MainWorkplan;
			MainWorkplan mainWorkplan;
			if (2u != 0)
			{
				mainWorkplan = obj;
			}
			WorkpieceSetup workpieceSetup = mainWorkplan.Setup.WorkpieceSetups.Find(_0023_003DzthQN2zXTd5AGNE3OdV7CwTvKZw8PTMwNnUroUrRg5ycC);
			WorkpieceSetup workpieceSetup2;
			if (8u != 0)
			{
				workpieceSetup2 = workpieceSetup;
			}
			if (workpieceSetup2 == null)
			{
				WorkpieceSetup workpieceSetup3 = new WorkpieceSetup();
				if (uint.MaxValue != 0)
				{
					workpieceSetup2 = workpieceSetup3;
				}
				workpieceSetup2.WorkpieceID = base.ReferenceKey;
				mainWorkplan.Setup.WorkpieceSetups.Add(workpieceSetup2);
			}
			WorkPiece obj2 = _projectInterface.Get(base.ReferenceKey) as WorkPiece;
			WorkPiece workPiece;
			if (8u != 0)
			{
				workPiece = obj2;
			}
			List<GeomGeometry> list = new List<GeomGeometry>();
			List<GeomGeometry> list2;
			if (2u != 0)
			{
				list2 = list;
			}
			if (holeList != null)
			{
				List<Geometry>.Enumerator enumerator = holeList.GetEnumerator();
				List<Geometry>.Enumerator enumerator2;
				if (3u != 0)
				{
					enumerator2 = enumerator;
				}
				try
				{
					while (enumerator2.MoveNext())
					{
						Geometry current = enumerator2.Current;
						Geometry geometry;
						if (5u != 0)
						{
							geometry = current;
						}
						GeomGeometry geometry2 = _projectInterface.Get(geometry.ReferenceKey) as GeomGeometry;
						_projectInterface.ToLocalGeometry(geometry2);
						_projectInterface.SetGeometryPlane(ref geometry2, new ReferenceKey());
						list2.Add(geometry2);
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
			}
			GeomGeometry geometry3 = _projectInterface.Get(workpieceGeometry.ReferenceKey) as GeomGeometry;
			_projectInterface.ToLocalGeometry(geometry3);
			_projectInterface.SetGeometryPlane(ref geometry3, new ReferenceKey());
			if (_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D != null && _0023_003Dz22bRUgtajyHzlQdchQ_003D_003D.Magnitude() > 0.0)
			{
				if (geometry3 is GeomCompositeCurve)
				{
					(geometry3.Geometry as Geom_CompositeCurve).Translate(_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D);
				}
				else
				{
					geometry3.Geometry.Translate(_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D);
				}
				foreach (GeomGeometry item in list2)
				{
					if (item is GeomCompositeCurve)
					{
						(item.Geometry as Geom_CompositeCurve).Translate(_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D);
					}
					else
					{
						item.Geometry.Translate(_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D);
					}
				}
			}
			Plane plane = new Plane(new GeomAxis2Placement(new Geom_Axis2Placement(new gp_Pnt(0.0, 0.0, 0.0), new gp_Dir(0.0, 0.0, 1.0), new gp_Dir(1.0, 0.0, 0.0))));
			GeomCompositeCurve boundaryGeometry = Boundary.MakeCompositeCurve(geometry3, plane);
			List<GeomCompositeCurve> holeGeometryList = Boundary.MakeCompositeCurve(list2, plane);
			if (workPiece.RawGeometries == null)
			{
				workPiece.RawGeometries = new List<WorkpieceGeometry>();
			}
			WorkpieceGeometry workpieceGeometry2 = new WorkpieceExtrusionGeometry(boundaryGeometry, holeGeometryList, dz, bx, by, bz);
			if (workpieceSetup2.RawGeometryIndex == -1)
			{
				workPiece.RawGeometries.Add(workpieceGeometry2);
				workpieceSetup2.RawGeometryIndex = workPiece.RawGeometries.Count - 1;
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this);
			}
			else
			{
				workPiece.RawGeometries[workpieceSetup2.RawGeometryIndex] = workpieceGeometry2;
			}
			_projectInterface.UpdateWorkPiece(workPiece, this);
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716554), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dzo9WtXsL29ij1(GeomGeometry _0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		if (!(_0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D != null))
		{
			return;
		}
		GeomCompositeCurve compositeCurve;
		if (6u != 0)
		{
			compositeCurve = null;
		}
		if (_0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D is GeomCompositeCurve)
		{
			GeomCompositeCurve obj = _0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D as GeomCompositeCurve;
			if (7u != 0)
			{
				compositeCurve = obj;
			}
		}
		else if (_0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D is GeomCircle)
		{
			GeomCompositeCurve geomCompositeCurve = (_0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D as GeomCircle).ToCompositeCurve();
			if (5u != 0)
			{
				compositeCurve = geomCompositeCurve;
			}
		}
		else if (_0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D is GeomEllipse)
		{
			compositeCurve = (_0023_003DzQ2wQBQRnxsI9ZjzmZQ_003D_003D as GeomEllipse).ToCompositeCurve();
		}
		Boundary2D geometryBoundary = Boundary.GetGeometryBoundary(compositeCurve);
		if (geometryBoundary != null)
		{
			_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D = new gp_Vec(geometryBoundary.XMin, geometryBoundary.YMin, 0.0);
			_0023_003Dz22bRUgtajyHzlQdchQ_003D_003D.Reverse();
		}
	}

	private void _0023_003DzoOcaehJpA9jve_0024SmSeEKAkI_003D(GeomGeometry _0023_003Dzf8AR1wHifZKNDZwG4Q_003D_003D, Geom_Axis2Placement _0023_003DzNTWRxrkFujp2)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		if (_0023_003Dzf8AR1wHifZKNDZwG4Q_003D_003D != null)
		{
			_ = 6;
			if (4 == 0)
			{
			}
			ProjectInterface projectInterface = _projectInterface;
			_ = 6;
			if (1 == 0)
			{
			}
			projectInterface.ToLocalGeometry(_0023_003Dzf8AR1wHifZKNDZwG4Q_003D_003D);
			_0023_003Dzf8AR1wHifZKNDZwG4Q_003D_003D.Geometry = OCGeomHelper.ToAbsolute(_0023_003Dzf8AR1wHifZKNDZwG4Q_003D_003D.Geometry, _0023_003DzNTWRxrkFujp2);
			_0023_003Dzf8AR1wHifZKNDZwG4Q_003D_003D.IsAbsolute = true;
		}
	}

	private bool _0023_003DzDxoin8SQiIxC1NDJtLshm2YNmbc9qvYlXg_003D_003D(WorkpieceSetup _0023_003DzSJfYMT8_003D)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
		_ = 1;
		if (3 == 0)
		{
		}
		return workpieceID == base.ReferenceKey;
	}

	private bool _0023_003Dzw_0024_ZPkdpFmblPMnrltuB_00247C439dLBEwlyQ_003D_003D(WorkpieceSetup _0023_003DzSJfYMT8_003D)
	{
		_ = 2;
		if (7 == 0)
		{
		}
		ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
		_ = -1;
		if (7 == 0)
		{
		}
		return workpieceID == base.ReferenceKey;
	}

	private bool _0023_003DzthQN2zXTd5AGNE3OdV7CwTvKZw8PTMwNnUroUrRg5ycC(WorkpieceSetup _0023_003DzSJfYMT8_003D)
	{
		_ = 8;
		if (4 == 0)
		{
		}
		ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
		_ = 1;
		if (5 == 0)
		{
		}
		return workpieceID == base.ReferenceKey;
	}
}
