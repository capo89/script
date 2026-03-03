using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ScmGroup.XCam.ConfigDataModel;
using ScmGroup.XCam.ConfigDataModel.Bars;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.ConfigDataModel.Enumerations;
using ScmGroup.XCam.ConfigDataModel.Geometry;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.ConfigDataModel.Supports;
using ScmGroup.XCam.ConfigDataModel.WorkingAreas;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.MachiningDataModel.WorkPlane;
using ScmGroup.XCam.ProjectObjectModel.PositionManager;
using ScmGroup.XCam.ProjectObjectModel.WorkPlane;

namespace ScmGroup.XCam.Scripting;

public class FixtureScripting : BaseScripting
{
	private sealed class _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D
	{
		public string _0023_003DzksC96uE_003D;

		public _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D()
		{
			_ = 0;
			if (5 == 0)
			{
			}
			base._002Ector();
		}
	}

	private sealed class _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D
	{
		public int _0023_003DzRzP028s_003D;

		public _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D()
		{
			_ = 0;
			if (6 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzjIkjA8EoNtQStQveKA_003D_003D(FixtureSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 0;
			if (6 == 0)
			{
			}
			if (_0023_003DzT2wOlf0_003D is LockingBarSetup)
			{
				_ = -1;
				if (3 == 0)
				{
				}
				int iDLogic = (_0023_003DzT2wOlf0_003D as LockingBarSetup).IDLogic;
				_ = 1;
				if (-1 == 0)
				{
				}
				return iDLogic == _0023_003DzRzP028s_003D;
			}
			return false;
		}
	}

	private sealed class _0023_003DzEXk0YpsPXJ_0024QP7P_0024B92T9ac_003D<_0023_003DzdVq9VFI_003D> where _0023_003DzdVq9VFI_003D : SupportSetup, new()
	{
		public int _0023_003DzBldMWdw_003D;

		public _0023_003DzEXk0YpsPXJ_0024QP7P_0024B92T9ac_003D()
		{
			_ = 1;
			if (7 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dz8K37JbnlNbrm_LPW_0024n_DyOI_003D(SupportSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 0;
			if (-1 == 0)
			{
			}
			int iDLogic = _0023_003DzT2wOlf0_003D.IDLogic;
			_ = 6;
			if (-1 == 0)
			{
			}
			return iDLogic == _0023_003DzBldMWdw_003D;
		}
	}

	[Serializable]
	private sealed class _0023_003DzJBaCSp8_003D
	{
		public static readonly _0023_003DzJBaCSp8_003D _0023_003DzK15DASY_003D;

		public static Func<FixtureSetup, bool> _0023_003DzSsjuyYRhFiG_0024Dp5KRw_003D_003D;

		static _0023_003DzJBaCSp8_003D()
		{
			_0023_003DzJBaCSp8_003D _0023_003DzJBaCSp8_003D = new _0023_003DzJBaCSp8_003D();
			if (5u != 0)
			{
				_0023_003DzK15DASY_003D = _0023_003DzJBaCSp8_003D;
			}
		}

		public _0023_003DzJBaCSp8_003D()
		{
			_ = -1;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzEyyx_GzgFY2l8Ya0fGluYUPYqOPC(FixtureSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 0;
			if (1 == 0)
			{
			}
			return _0023_003DzT2wOlf0_003D is MLTFPlaneSetup;
		}
	}

	private sealed class _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D
	{
		public int _0023_003DzRzP028s_003D;

		public _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D()
		{
			_ = 2;
			if (3 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzW2E_MqeZnpEGkvuLPVcrguw_003D(FixtureSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 6;
			if (3 == 0)
			{
			}
			if (_0023_003DzT2wOlf0_003D is ReferenceBarSetup)
			{
				_ = 4;
				if (3 == 0)
				{
				}
				int iDLogic = (_0023_003DzT2wOlf0_003D as ReferenceBarSetup).IDLogic;
				_ = 1;
				if (5 == 0)
				{
				}
				return iDLogic == _0023_003DzRzP028s_003D;
			}
			return false;
		}
	}

	private sealed class _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D
	{
		public int _0023_003DzAYo_7Mp8QREd;

		public _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D()
		{
			_ = 3;
			if (-1 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzQOUmDazbxmNiOyCLIS11NQ8_003D(SupportSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 8;
			if (8 == 0)
			{
			}
			int iDLogic = _0023_003DzT2wOlf0_003D.IDLogic;
			_ = 1;
			if (4 == 0)
			{
			}
			return iDLogic == _0023_003DzAYo_7Mp8QREd;
		}
	}

	private sealed class _0023_003DznQv1vnkCXLGEdQk0VJt4Z4Y_003D
	{
		public int _0023_003DzUSI2fZE_003D;

		public _0023_003DznQv1vnkCXLGEdQk0VJt4Z4Y_003D()
		{
			_ = 3;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzzbSFu_Uovg_0024GGJ_0024VuA_003D_003D(FixtureSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 6;
			if (8 == 0)
			{
			}
			if (_0023_003DzT2wOlf0_003D is LockingBarSetup)
			{
				_ = 4;
				if (1 == 0)
				{
				}
				int iDLogic = (_0023_003DzT2wOlf0_003D as LockingBarSetup).IDLogic;
				_ = 1;
				if (6 == 0)
				{
				}
				return iDLogic == _0023_003DzUSI2fZE_003D;
			}
			return false;
		}
	}

	private sealed class _0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D
	{
		public Type _0023_003DzjhZTcqnC6ras;

		public _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D _0023_003DqMPZ0bvIRJCZVdn1__0024A4dQvbClahH63MPrjv5giMpXz8_003D;

		public _0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D()
		{
			_ = 5;
			if (-1 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dz3SKnNaSC2TnRM6ITVBAiCnQ_003D(Support _0023_003DzohSKktI_003D)
		{
			_ = 1;
			if (4 == 0)
			{
			}
			Type type = _0023_003DzohSKktI_003D.GetType();
			_ = 5;
			if (5 == 0)
			{
			}
			if (type == _0023_003DzjhZTcqnC6ras)
			{
				_ = 3;
				if (2 == 0)
				{
				}
				return _0023_003DzohSKktI_003D.NameOfElementInLibrary == _0023_003DqMPZ0bvIRJCZVdn1__0024A4dQvbClahH63MPrjv5giMpXz8_003D._0023_003DzksC96uE_003D;
			}
			return false;
		}
	}

	private MainWorkplan _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D;

	private WorkPiece _0023_003DzNZ9AqsSCWOI9OAEdzw_003D_003D;

	private Machine _0023_003DzI1_0024UCcU_003D;

	private string _0023_003DzaExybUZpeYgb;

	private WorkingArea _0023_003DzN8ZZdLQ_003D;

	public FixtureScripting(ProjectInterface projectInterface, ConfigurationInterface configurationInterface, ConfigurationInterface supportInterface, MainWorkplan mainWorkplan, WorkPiece workpiece)
	{
		if (2u != 0)
		{
			_projectInterface = projectInterface;
		}
		if (6u != 0)
		{
			_configurationInterface = configurationInterface;
		}
		if (8u != 0)
		{
			_supportInterface = supportInterface;
		}
		_0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D = mainWorkplan;
		_0023_003DzNZ9AqsSCWOI9OAEdzw_003D_003D = workpiece;
		if (_projectInterface == null || _configurationInterface == null || _supportInterface == null || _0023_003DzNZ9AqsSCWOI9OAEdzw_003D_003D == null || _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D == null || _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup == null || _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.WorkpieceSetups == null || _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702475), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		}
		WorkPlaneModel workPlaneModel = new WorkPlaneModel(_projectInterface, _configurationInterface, _supportInterface);
		_0023_003DzI1_0024UCcU_003D = workPlaneModel.GetMachine();
		_0023_003DzaExybUZpeYgb = workPlaneModel.GetWorkingAreaName();
		_0023_003DzN8ZZdLQ_003D = workPlaneModel.GetWorkingArea(_0023_003DzI1_0024UCcU_003D, _0023_003DzaExybUZpeYgb);
	}

	public void SetBarPosition(int id, double xPosition)
	{
		_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D = new _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D();
		_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2;
		if (2u != 0)
		{
			_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2 = _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D;
		}
		if (2u != 0)
		{
			_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzRzP028s_003D = id;
		}
		LockingBarSetup obj = _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups.Find(_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzjIkjA8EoNtQStQveKA_003D_003D) as LockingBarSetup;
		LockingBarSetup lockingBarSetup;
		if (4u != 0)
		{
			lockingBarSetup = obj;
		}
		if (lockingBarSetup == null)
		{
			LockingPieceBar lockingPieceBar = _0023_003DzlQr9jxwbGmytKpVG7fyt0eI_003D(_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzRzP028s_003D);
			lockingBarSetup = new LockingBarSetup();
			lockingBarSetup.IDLogic = _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzRzP028s_003D;
			lockingBarSetup.TypeOfBar = lockingPieceBar.GetType().ToString();
			lockingBarSetup.NameOfBar = lockingPieceBar.NameOfElementInLibrary;
			_0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups.Add(lockingBarSetup);
		}
		double xPos = (lockingBarSetup.XPos = _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D().LocationX + xPosition);
		if (lockingBarSetup.SupportSetups == null)
		{
			return;
		}
		foreach (SupportSetup supportSetup in lockingBarSetup.SupportSetups)
		{
			supportSetup.XPos = xPos;
		}
	}

	public void SetMobileBarPosition(int id, int position)
	{
		_0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D = new _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D();
		_0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D2;
		if (3u != 0)
		{
			_0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D2 = _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D;
		}
		if (0 == 0)
		{
			_0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D2._0023_003DzRzP028s_003D = id;
		}
		MobileReferencePieceBar mobileReferencePieceBar = _0023_003Dz9CEj_0024FZNKbxVKHIZ_0024g_003D_003D(_0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D2._0023_003DzRzP028s_003D);
		MobileReferencePieceBar mobileReferencePieceBar2 = default(MobileReferencePieceBar);
		if (0 == 0)
		{
			mobileReferencePieceBar2 = mobileReferencePieceBar;
		}
		ReferenceBarSetup referenceBarSetup = _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups.Find(_0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D2._0023_003DzW2E_MqeZnpEGkvuLPVcrguw_003D) as ReferenceBarSetup;
		if (referenceBarSetup == null)
		{
			referenceBarSetup = new ReferenceBarSetup();
			referenceBarSetup.IDLogic = _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D2._0023_003DzRzP028s_003D;
			referenceBarSetup.TypeOfBar = mobileReferencePieceBar2.GetType().ToString();
			referenceBarSetup.NameOfBar = mobileReferencePieceBar2.NameOfElementInLibrary;
			_0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups.Add(referenceBarSetup);
		}
		Axis axis = mobileReferencePieceBar2.Axis;
		if (axis != null)
		{
			switch (position)
			{
			case -1:
				referenceBarSetup.XPos = axis.MinValue;
				break;
			case 0:
				referenceBarSetup.XPos = 0.0;
				break;
			case 1:
				referenceBarSetup.XPos = axis.MaxValue;
				break;
			default:
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702446), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, position, _0023_003DzgHd1jCJ5ipuoZRE_Pg_003D_003D2._0023_003DzRzP028s_003D);
			}
		}
	}

	public void SetSupportBasePosition(int barId, int supportBaseId, double yPosition)
	{
		_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D = new _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D();
		_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2;
		if (4u != 0)
		{
			_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2 = _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D;
		}
		if (7u != 0)
		{
			_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzAYo_7Mp8QREd = supportBaseId;
		}
		LockingBarSetup lockingBarSetup = _0023_003DzZUQRFuppmSlH(barId);
		LockingBarSetup lockingBarSetup2;
		if (8u != 0)
		{
			lockingBarSetup2 = lockingBarSetup;
		}
		SupportSetup supportSetup = lockingBarSetup2.SupportSetups.Find(_0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzQOUmDazbxmNiOyCLIS11NQ8_003D);
		if (supportSetup == null || !(supportSetup is SupportBaseSetup))
		{
			LockingPieceBar _0023_003DzS3OYCx0_003D = _0023_003DzlQr9jxwbGmytKpVG7fyt0eI_003D(barId);
			SupportBase supportBase = _0023_003Dz9qwY3GCoRNQP(_0023_003DzS3OYCx0_003D, barId, _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzAYo_7Mp8QREd);
			if (supportSetup != null)
			{
				lockingBarSetup2.SupportSetups.Remove(supportSetup);
			}
			supportSetup = new SupportBaseSetup();
			supportSetup.IDLogic = _0023_003DzmgyBDAH5jYtvhKTx6Q_003D_003D2._0023_003DzAYo_7Mp8QREd;
			supportSetup.TypeOfSupport = supportBase.GetType().ToString();
			supportSetup.NameOfSupport = supportBase.NameOfElementInLibrary;
			supportSetup.XPos = lockingBarSetup2.XPos;
			lockingBarSetup2.SupportSetups.Add(supportSetup);
		}
		double yPos = _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D().LocationY + yPosition;
		supportSetup.YPos = yPos;
	}

	public void SetClampPosition(int barId, int supportId, double yPosition, int status, string code)
	{
		string text = typeof(Clamp).ToString();
		string text2;
		if (8u != 0)
		{
			text2 = text;
		}
		LockingBarSetup lockingBarSetup = _0023_003DzZUQRFuppmSlH(barId);
		LockingBarSetup lockingBarSetup2;
		if (8u != 0)
		{
			lockingBarSetup2 = lockingBarSetup;
		}
		Clamp obj = _0023_003DzHHwiEqmzvtad(text2, code) as Clamp;
		Clamp clamp = default(Clamp);
		if (0 == 0)
		{
			clamp = obj;
		}
		if (clamp == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702650), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, code);
		}
		bool flag = _0023_003DzI1_0024UCcU_003D.HasSupportBasis();
		_0023_003Dzq5m5YvrYNwzp(barId, supportId, flag);
		_0023_003Dzhi0wBwgvGg75xHFJAw_003D_003D(clamp, WorkPlaneType.TV, flag, code);
		double yPos = _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D().LocationY + yPosition;
		ClampSetup clampSetup = _0023_003Dzwbi3ED86_hCM<ClampSetup>(supportId, code, text2, lockingBarSetup2) as ClampSetup;
		clampSetup.XPos = lockingBarSetup2.XPos;
		clampSetup.YPos = yPos;
		clampSetup.IDLogic = supportId;
		clampSetup.TypeOfSupport = text2;
		clampSetup.NameOfSupport = code;
		switch (status)
		{
		case 0:
			clampSetup.BlockingCondition = BlockingCondition.Close;
			return;
		case 1:
			clampSetup.BlockingCondition = BlockingCondition.Open;
			return;
		case 2:
			clampSetup.BlockingCondition = BlockingCondition.CloseOnPiece;
			return;
		}
		throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702600), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, status, supportId, barId);
	}

	public void SetHorizontalClampPosition(int barId, int supportId, double yPosition, int status, string code)
	{
		string text = typeof(HorizontalClamp).ToString();
		string text2;
		if (2u != 0)
		{
			text2 = text;
		}
		LockingBarSetup lockingBarSetup = _0023_003DzZUQRFuppmSlH(barId);
		LockingBarSetup lockingBarSetup2;
		if (7u != 0)
		{
			lockingBarSetup2 = lockingBarSetup;
		}
		HorizontalClamp obj = _0023_003DzHHwiEqmzvtad(text2, code) as HorizontalClamp;
		HorizontalClamp horizontalClamp = default(HorizontalClamp);
		if (0 == 0)
		{
			horizontalClamp = obj;
		}
		if (horizontalClamp == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702557), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, code);
		}
		bool flag = _0023_003DzI1_0024UCcU_003D.HasSupportBasis();
		_0023_003Dzq5m5YvrYNwzp(barId, supportId, flag);
		_0023_003Dzhi0wBwgvGg75xHFJAw_003D_003D(horizontalClamp, WorkPlaneType.TV, flag, code);
		double yPos = _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D().LocationY + yPosition;
		HorizontalClampSetup horizontalClampSetup = _0023_003Dzwbi3ED86_hCM<HorizontalClampSetup>(supportId, code, text2, lockingBarSetup2) as HorizontalClampSetup;
		horizontalClampSetup.XPos = lockingBarSetup2.XPos;
		horizontalClampSetup.YPos = yPos;
		horizontalClampSetup.IDLogic = supportId;
		horizontalClampSetup.TypeOfSupport = text2;
		horizontalClampSetup.NameOfSupport = code;
		switch (status)
		{
		case 0:
			horizontalClampSetup.BlockingCondition = BlockingCondition.Close;
			return;
		case 1:
			horizontalClampSetup.BlockingCondition = BlockingCondition.Open;
			return;
		case 2:
			horizontalClampSetup.BlockingCondition = BlockingCondition.CloseOnPiece;
			return;
		}
		throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702600), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, status, supportId, barId);
	}

	public void SetClampForJambPosition(int barId, int supportId, double yPosition, int status, string code)
	{
		string text = typeof(ClampForJamb).ToString();
		string text2;
		if (7u != 0)
		{
			text2 = text;
		}
		LockingBarSetup lockingBarSetup = _0023_003DzZUQRFuppmSlH(barId);
		LockingBarSetup lockingBarSetup2;
		if (3u != 0)
		{
			lockingBarSetup2 = lockingBarSetup;
		}
		ClampForJamb obj = _0023_003DzHHwiEqmzvtad(text2, code) as ClampForJamb;
		ClampForJamb clampForJamb;
		if (uint.MaxValue != 0)
		{
			clampForJamb = obj;
		}
		if (clampForJamb == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702241), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, code);
		}
		bool flag = _0023_003DzI1_0024UCcU_003D.HasSupportBasis();
		_0023_003Dzq5m5YvrYNwzp(barId, supportId, flag);
		_0023_003Dzhi0wBwgvGg75xHFJAw_003D_003D(clampForJamb, WorkPlaneType.TV, flag, code);
		double yPos = _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D().LocationY + yPosition;
		ClampForJambSetup clampForJambSetup = _0023_003Dzwbi3ED86_hCM<ClampForJambSetup>(supportId, code, text2, lockingBarSetup2) as ClampForJambSetup;
		clampForJambSetup.XPos = lockingBarSetup2.XPos;
		clampForJambSetup.YPos = yPos;
		clampForJambSetup.IDLogic = supportId;
		clampForJambSetup.TypeOfSupport = text2;
		clampForJambSetup.NameOfSupport = code;
		switch (status)
		{
		case 0:
			clampForJambSetup.BlockingCondition = BlockingCondition.Close;
			return;
		case 1:
			clampForJambSetup.BlockingCondition = BlockingCondition.Open;
			return;
		case 2:
			clampForJambSetup.BlockingCondition = BlockingCondition.CloseOnPiece;
			return;
		}
		throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702600), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, status, supportId, barId);
	}

	public void SetSuctionCupPosition(int barId, int supportId, double yPosition, double angle, string code)
	{
		string text = typeof(SuctionCup).ToString();
		string text2;
		if (6u != 0)
		{
			text2 = text;
		}
		LockingBarSetup lockingBarSetup = _0023_003DzZUQRFuppmSlH(barId);
		LockingBarSetup lockingBarSetup2;
		if (uint.MaxValue != 0)
		{
			lockingBarSetup2 = lockingBarSetup;
		}
		SuctionCup obj = _0023_003DzHHwiEqmzvtad(text2, code) as SuctionCup;
		SuctionCup suctionCup;
		if (true)
		{
			suctionCup = obj;
		}
		if (suctionCup == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702186), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, code);
		}
		bool flag = _0023_003DzI1_0024UCcU_003D.HasSupportBasis();
		_0023_003Dzq5m5YvrYNwzp(barId, supportId, flag);
		_0023_003Dzhi0wBwgvGg75xHFJAw_003D_003D(suctionCup, WorkPlaneType.TV, flag, code);
		double yPos = _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D().LocationY + yPosition;
		SuctionCupSetup suctionCupSetup = _0023_003Dzwbi3ED86_hCM<SuctionCupSetup>(supportId, code, text2, lockingBarSetup2) as SuctionCupSetup;
		suctionCupSetup.XPos = lockingBarSetup2.XPos;
		suctionCupSetup.YPos = yPos;
		suctionCupSetup.IDLogic = supportId;
		suctionCupSetup.TypeOfSupport = text2;
		suctionCupSetup.NameOfSupport = code;
		_0023_003DzFYhCJvQmjxbmnvhV0n_002411InWKl9TmIA9Zw_003D_003D(suctionCup, suctionCupSetup, angle);
	}

	public void SetMLTFSuctionCupPosition(double xPosition, double yPosition, double angle, string code)
	{
		string text = typeof(SuctionCup).ToString();
		string text2;
		if (uint.MaxValue != 0)
		{
			text2 = text;
		}
		MLTFPlaneSetup mLTFPlaneSetup = _0023_003DzwhNq8H2X1hzU();
		MLTFPlaneSetup mLTFPlaneSetup2;
		if (8u != 0)
		{
			mLTFPlaneSetup2 = mLTFPlaneSetup;
		}
		SuctionCup obj = _0023_003DzHHwiEqmzvtad(text2, code) as SuctionCup;
		SuctionCup suctionCup;
		if (2u != 0)
		{
			suctionCup = obj;
		}
		if (suctionCup == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702186), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, code);
		}
		_0023_003Dzhi0wBwgvGg75xHFJAw_003D_003D(suctionCup, WorkPlaneType.MLTF, _0023_003DzfUKYRlu6MHVn: false, code);
		GeomAxis2Placement geomAxis2Placement = _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D();
		double xQuote = geomAxis2Placement.LocationX + xPosition;
		double yQuote = geomAxis2Placement.LocationY + yPosition;
		new PositionManagerMLTF(_0023_003DzI1_0024UCcU_003D, _0023_003DzaExybUZpeYgb).CorrectSupportPosition(suctionCup, ref xQuote, ref yQuote);
		SuctionCupSetup suctionCupSetup = new SuctionCupSetup();
		suctionCupSetup.XPos = xQuote;
		suctionCupSetup.YPos = yQuote;
		suctionCupSetup.IDLogic = _0023_003DzykIYbzMbLTet(mLTFPlaneSetup2);
		suctionCupSetup.TypeOfSupport = text2;
		suctionCupSetup.NameOfSupport = code;
		_0023_003DzFYhCJvQmjxbmnvhV0n_002411InWKl9TmIA9Zw_003D_003D(suctionCup, suctionCupSetup, angle);
		mLTFPlaneSetup2.SupportSetups.Add(suctionCupSetup);
	}

	private SupportSetup _0023_003Dzwbi3ED86_hCM<T>(int _0023_003DzBldMWdw_003D, string _0023_003DzksC96uE_003D, string _0023_003Dz3JKs8Mw_003D, LockingBarSetup _0023_003Dznr8HtmHnyOC5) where T : SupportSetup, new()
	{
		_0023_003DzEXk0YpsPXJ_0024QP7P_0024B92T9ac_003D<T> _0023_003DzEXk0YpsPXJ_0024QP7P_0024B92T9ac_003D = new _0023_003DzEXk0YpsPXJ_0024QP7P_0024B92T9ac_003D<T>();
		_0023_003DzEXk0YpsPXJ_0024QP7P_0024B92T9ac_003D<T> CS_0024_003C_003E8__locals2;
		if (2u != 0)
		{
			CS_0024_003C_003E8__locals2 = _0023_003DzEXk0YpsPXJ_0024QP7P_0024B92T9ac_003D;
		}
		if (3u != 0)
		{
			CS_0024_003C_003E8__locals2._0023_003DzBldMWdw_003D = _0023_003DzBldMWdw_003D;
		}
		SupportSetup supportSetup = _0023_003Dznr8HtmHnyOC5.SupportSetups.Find(delegate(SupportSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 0;
			if (-1 == 0)
			{
			}
			int iDLogic = _0023_003DzT2wOlf0_003D.IDLogic;
			_ = 6;
			if (-1 == 0)
			{
			}
			return iDLogic == CS_0024_003C_003E8__locals2._0023_003DzBldMWdw_003D;
		});
		SupportSetup supportSetup2;
		if (7u != 0)
		{
			supportSetup2 = supportSetup;
		}
		bool flag = true;
		if (supportSetup2 != null && supportSetup2.NameOfSupport == _0023_003DzksC96uE_003D && supportSetup2.TypeOfSupport == _0023_003Dz3JKs8Mw_003D)
		{
			flag = false;
		}
		if (flag)
		{
			if (supportSetup2 != null)
			{
				_0023_003Dznr8HtmHnyOC5.SupportSetups.Remove(supportSetup2);
			}
			supportSetup2 = new T();
			_0023_003Dznr8HtmHnyOC5.SupportSetups.Add(supportSetup2);
		}
		return supportSetup2;
	}

	private void _0023_003Dzq5m5YvrYNwzp(int _0023_003DzUSI2fZE_003D, int _0023_003DzBldMWdw_003D, bool _0023_003DzGxeYdsC9ldeC3u3GVg_003D_003D)
	{
		if (_0023_003DzGxeYdsC9ldeC3u3GVg_003D_003D)
		{
			LockingPieceBar lockingPieceBar = _0023_003DzlQr9jxwbGmytKpVG7fyt0eI_003D(_0023_003DzUSI2fZE_003D);
			LockingPieceBar _0023_003DzS3OYCx0_003D;
			if (4u != 0)
			{
				_0023_003DzS3OYCx0_003D = lockingPieceBar;
			}
			_0023_003Dz9qwY3GCoRNQP(_0023_003DzS3OYCx0_003D, _0023_003DzUSI2fZE_003D, _0023_003DzBldMWdw_003D);
		}
	}

	private void _0023_003Dzhi0wBwgvGg75xHFJAw_003D_003D(Support _0023_003DzDBfTWcI_003D, WorkPlaneType _0023_003DzlK0S95u5XmyU, bool _0023_003DzfUKYRlu6MHVn, string _0023_003DzksC96uE_003D)
	{
		bool flag;
		if (2u != 0)
		{
			flag = false;
		}
		switch (_0023_003DzlK0S95u5XmyU)
		{
		case WorkPlaneType.TV:
			if (_0023_003DzDBfTWcI_003D.PlaneType == WorkPlaneType.MLTF || (_0023_003DzfUKYRlu6MHVn && _0023_003DzDBfTWcI_003D.MountOnSupportBase == Enabling.No) || (!_0023_003DzfUKYRlu6MHVn && _0023_003DzDBfTWcI_003D.MountOnSupportBase == Enabling.Yes))
			{
				if (3u != 0)
				{
					flag = true;
				}
			}
			break;
		case WorkPlaneType.MLTF:
			if (_0023_003DzDBfTWcI_003D.PlaneType == WorkPlaneType.TV)
			{
				if (2u != 0)
				{
					flag = true;
				}
			}
			break;
		}
		if (flag)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702385), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzksC96uE_003D);
		}
	}

	private int _0023_003DzykIYbzMbLTet(MLTFPlaneSetup _0023_003DzNDgdR9zL2hPO)
	{
		int result;
		if (2u != 0)
		{
			result = 1;
		}
		if (_0023_003DzNDgdR9zL2hPO != null && _0023_003DzNDgdR9zL2hPO.SupportSetups != null)
		{
			int num;
			if (true)
			{
				num = int.MinValue;
			}
			List<SupportSetup>.Enumerator enumerator = _0023_003DzNDgdR9zL2hPO.SupportSetups.GetEnumerator();
			List<SupportSetup>.Enumerator enumerator2;
			if (2u != 0)
			{
				enumerator2 = enumerator;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					SupportSetup current = enumerator2.Current;
					if (current.IDLogic > num)
					{
						num = current.IDLogic;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
			result = ((num == int.MinValue) ? 1 : (num + 1));
		}
		return result;
	}

	private void _0023_003DzFYhCJvQmjxbmnvhV0n_002411InWKl9TmIA9Zw_003D_003D(SuctionCup _0023_003Dz_0024jgm9BWVF_6l56tgSw_003D_003D, SuctionCupSetup _0023_003DzgcPPg554GFZx_0024o7InODFVas_003D, double _0023_003DzSkIaGjk_003D)
	{
		if (!(_0023_003DzgcPPg554GFZx_0024o7InODFVas_003D != null))
		{
			return;
		}
		if (_0023_003DzgcPPg554GFZx_0024o7InODFVas_003D.SupportRotations == null)
		{
			_0023_003DzgcPPg554GFZx_0024o7InODFVas_003D.SupportRotations = new List<SupportRotation>();
		}
		_0023_003DzgcPPg554GFZx_0024o7InODFVas_003D.SupportRotations.Clear();
		CircularAxis circularAxis = _0023_003Dz2_jnd4pOb8sD(_0023_003Dz_0024jgm9BWVF_6l56tgSw_003D_003D);
		CircularAxis circularAxis2;
		if (5u != 0)
		{
			circularAxis2 = circularAxis;
		}
		if (circularAxis2 != null)
		{
			double num = _0023_003DzSkIaGjk_003D * Math.PI / 180.0;
			if (2u != 0)
			{
				_0023_003DzSkIaGjk_003D = num;
			}
			double num2 = _0023_003DzSkIaGjk_003D + circularAxis2.DefaultValue;
			double num3 = default(double);
			if (0 == 0)
			{
				num3 = num2;
			}
			if (num3 < circularAxis2.MinValue || num3 > circularAxis2.MaxValue)
			{
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702340), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzSkIaGjk_003D, num3, circularAxis2.MinValue, circularAxis2.MaxValue);
			}
			SupportRotation item = new SupportRotation
			{
				Rotation = _0023_003DzSkIaGjk_003D
			};
			_0023_003DzgcPPg554GFZx_0024o7InODFVas_003D.SupportRotations.Add(item);
		}
	}

	private CircularAxis _0023_003Dz2_jnd4pOb8sD(MachineElement _0023_003DzN_0024X__0024TM_003D)
	{
		CircularAxis result;
		if (2u != 0)
		{
			result = null;
		}
		if (_0023_003DzN_0024X__0024TM_003D != null)
		{
			CircularAxis obj = _0023_003DzN_0024X__0024TM_003D.Axis as CircularAxis;
			CircularAxis circularAxis;
			if (3u != 0)
			{
				circularAxis = obj;
			}
			if (circularAxis != null)
			{
				CircularAxis circularAxis2 = circularAxis;
				if (0 == 0)
				{
					result = circularAxis2;
				}
			}
			else if (_0023_003DzN_0024X__0024TM_003D.ChildElements != null)
			{
				foreach (MachineElementBase childElement in _0023_003DzN_0024X__0024TM_003D.ChildElements)
				{
					circularAxis = _0023_003Dz2_jnd4pOb8sD(childElement as MachineElement);
					if (circularAxis != null)
					{
						result = circularAxis;
						break;
					}
				}
			}
		}
		return result;
	}

	private LockingBarSetup _0023_003DzZUQRFuppmSlH(int _0023_003DzUSI2fZE_003D)
	{
		_0023_003DznQv1vnkCXLGEdQk0VJt4Z4Y_003D _0023_003DznQv1vnkCXLGEdQk0VJt4Z4Y_003D = new _0023_003DznQv1vnkCXLGEdQk0VJt4Z4Y_003D();
		_0023_003DznQv1vnkCXLGEdQk0VJt4Z4Y_003D CS_0024_003C_003E8__locals3;
		if (4u != 0)
		{
			CS_0024_003C_003E8__locals3 = _0023_003DznQv1vnkCXLGEdQk0VJt4Z4Y_003D;
		}
		if (6u != 0)
		{
			CS_0024_003C_003E8__locals3._0023_003DzUSI2fZE_003D = _0023_003DzUSI2fZE_003D;
		}
		LockingBarSetup obj = _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups.Find(delegate(FixtureSetup _0023_003DzT2wOlf0_003D)
		{
			_ = 6;
			if (8 == 0)
			{
			}
			if (_0023_003DzT2wOlf0_003D is LockingBarSetup)
			{
				_ = 4;
				if (1 == 0)
				{
				}
				int iDLogic = (_0023_003DzT2wOlf0_003D as LockingBarSetup).IDLogic;
				_ = 1;
				if (6 == 0)
				{
				}
				return iDLogic == CS_0024_003C_003E8__locals3._0023_003DzUSI2fZE_003D;
			}
			return false;
		}) as LockingBarSetup;
		LockingBarSetup lockingBarSetup;
		if (4u != 0)
		{
			lockingBarSetup = obj;
		}
		if (lockingBarSetup == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702293), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, CS_0024_003C_003E8__locals3._0023_003DzUSI2fZE_003D);
		}
		return lockingBarSetup;
	}

	private MLTFPlaneSetup _0023_003DzwhNq8H2X1hzU()
	{
		List<FixtureSetup> fixtureSetups = _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups;
		Func<FixtureSetup, bool> func = _0023_003DzJBaCSp8_003D._0023_003DzSsjuyYRhFiG_0024Dp5KRw_003D_003D;
		if (func == null)
		{
			func = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzEyyx_GzgFY2l8Ya0fGluYUPYqOPC;
			Func<FixtureSetup, bool> _0023_003DzSsjuyYRhFiG_0024Dp5KRw_003D_003D = func;
			if (4u != 0)
			{
				_0023_003DzJBaCSp8_003D._0023_003DzSsjuyYRhFiG_0024Dp5KRw_003D_003D = _0023_003DzSsjuyYRhFiG_0024Dp5KRw_003D_003D;
			}
		}
		MLTFPlaneSetup obj = fixtureSetups.FirstOrDefault(func) as MLTFPlaneSetup;
		MLTFPlaneSetup mLTFPlaneSetup;
		if (5u != 0)
		{
			mLTFPlaneSetup = obj;
		}
		if (mLTFPlaneSetup == null)
		{
			MLTFPlaneSetup mLTFPlaneSetup2 = new MLTFPlaneSetup();
			if (4u != 0)
			{
				mLTFPlaneSetup = mLTFPlaneSetup2;
			}
			_0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.FixtureSetups.Add(mLTFPlaneSetup);
		}
		return mLTFPlaneSetup;
	}

	private LockingPieceBar _0023_003DzlQr9jxwbGmytKpVG7fyt0eI_003D(int _0023_003DzRzP028s_003D)
	{
		LockingPieceBar lockingPieceBar;
		if (3u != 0)
		{
			lockingPieceBar = null;
		}
		List<LockingPieceBar> logicLockingPieceBarsForWorkingArea = TVFixtureConfigurator.GetLogicLockingPieceBarsForWorkingArea(_0023_003DzaExybUZpeYgb, _0023_003DzI1_0024UCcU_003D);
		List<LockingPieceBar> list;
		if (true)
		{
			list = logicLockingPieceBarsForWorkingArea;
		}
		if (list != null && _0023_003DzRzP028s_003D > 0 && _0023_003DzRzP028s_003D <= list.Count)
		{
			LockingPieceBar lockingPieceBar2 = list[_0023_003DzRzP028s_003D - 1];
			if (7u != 0)
			{
				lockingPieceBar = lockingPieceBar2;
			}
		}
		if (lockingPieceBar == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700976), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzRzP028s_003D);
		}
		return lockingPieceBar;
	}

	private MobileReferencePieceBar _0023_003Dz9CEj_0024FZNKbxVKHIZ_0024g_003D_003D(int _0023_003DzRzP028s_003D)
	{
		MobileReferencePieceBar mobileReferencePieceBar;
		if (3u != 0)
		{
			mobileReferencePieceBar = null;
		}
		List<MobileReferencePieceBar> logicMobileReferencePieceBarForWorkingArea = TVFixtureConfigurator.GetLogicMobileReferencePieceBarForWorkingArea(_0023_003DzaExybUZpeYgb, _0023_003DzI1_0024UCcU_003D);
		List<MobileReferencePieceBar> list;
		if (3u != 0)
		{
			list = logicMobileReferencePieceBarForWorkingArea;
		}
		if (list != null && _0023_003DzRzP028s_003D > 0 && _0023_003DzRzP028s_003D <= list.Count)
		{
			MobileReferencePieceBar mobileReferencePieceBar2 = list[_0023_003DzRzP028s_003D - 1];
			if (8u != 0)
			{
				mobileReferencePieceBar = mobileReferencePieceBar2;
			}
		}
		if (mobileReferencePieceBar == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700933), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzRzP028s_003D);
		}
		return mobileReferencePieceBar;
	}

	private SupportBase _0023_003Dz9qwY3GCoRNQP(LockingPieceBar _0023_003DzS3OYCx0_003D, int _0023_003DzUSI2fZE_003D, int _0023_003DzAYo_7Mp8QREd)
	{
		SupportBase supportBase;
		if (3u != 0)
		{
			supportBase = null;
		}
		List<SupportBase> logicSupportsForLockingPieceBar = TVFixtureConfigurator.GetLogicSupportsForLockingPieceBar<SupportBase>(_0023_003DzN8ZZdLQ_003D, _0023_003DzS3OYCx0_003D);
		List<SupportBase> list;
		if (6u != 0)
		{
			list = logicSupportsForLockingPieceBar;
		}
		if (list != null && _0023_003DzAYo_7Mp8QREd > 0 && _0023_003DzAYo_7Mp8QREd <= list.Count)
		{
			SupportBase supportBase2 = list[_0023_003DzAYo_7Mp8QREd - 1];
			if (7u != 0)
			{
				supportBase = supportBase2;
			}
		}
		if (supportBase == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917700888), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, _0023_003DzAYo_7Mp8QREd, _0023_003DzUSI2fZE_003D);
		}
		return supportBase;
	}

	private Support _0023_003DzHHwiEqmzvtad(string _0023_003Dz3JKs8Mw_003D, string _0023_003DzksC96uE_003D)
	{
		_0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D = new _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D();
		_0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D2;
		if (7u != 0)
		{
			_0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D2 = _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D;
		}
		if (0 == 0)
		{
			_0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D2._0023_003DzksC96uE_003D = _0023_003DzksC96uE_003D;
		}
		Support result;
		if (8u != 0)
		{
			result = null;
		}
		if (_supportInterface != null)
		{
			Assembly assembly = Assembly.Load(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701093));
			if (assembly != null)
			{
				_0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D _0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D = new _0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D();
				_0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D._0023_003DqMPZ0bvIRJCZVdn1__0024A4dQvbClahH63MPrjv5giMpXz8_003D = _0023_003Dz3C5ANhQuCWGdx028NpJlQzk_003D2;
				_0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D._0023_003DzjhZTcqnC6ras = assembly.GetType(_0023_003Dz3JKs8Mw_003D);
				List<Support> list = _supportInterface.GetList<Support>();
				if (list != null)
				{
					Support support = list.Find(_0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D._0023_003Dz3SKnNaSC2TnRM6ITVBAiCnQ_003D);
					if (support != null)
					{
						ConstructorInfo constructor = _0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D._0023_003DzjhZTcqnC6ras.GetConstructor(new Type[2]
						{
							_0023_003DzyRSXQpiaFDwJ0sF4tQ7wBv0_003D._0023_003DzjhZTcqnC6ras,
							typeof(bool)
						});
						if (constructor != null)
						{
							result = (Support)constructor.Invoke(new object[2] { support, true });
						}
					}
				}
			}
		}
		return result;
	}

	private GeomAxis2Placement _0023_003DzLdufj2_0024QBecDz5XKx56_0024DZ0_003D()
	{
		GeomAxis2Placement geomAxis2Placement;
		if (6u != 0)
		{
			geomAxis2Placement = null;
		}
		WorkpieceSetup workpieceSetup = _0023_003Dzu16rUVxQh4vbjHU3bg_003D_003D.Setup.WorkpieceSetups.Find(_0023_003Dzliknwg4kJ5JP7qb4QHGLgFcd8Mz5J9NacA_003D_003D);
		WorkpieceSetup workpieceSetup2;
		if (4u != 0)
		{
			workpieceSetup2 = workpieceSetup;
		}
		if (workpieceSetup2 != null)
		{
			GeomAxis2Placement placement = workpieceSetup2.Placement;
			if (7u != 0)
			{
				geomAxis2Placement = placement;
			}
		}
		if (geomAxis2Placement == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917701057), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		}
		return geomAxis2Placement;
	}

	private bool _0023_003Dzliknwg4kJ5JP7qb4QHGLgFcd8Mz5J9NacA_003D_003D(WorkpieceSetup _0023_003DzT2wOlf0_003D)
	{
		_ = 2;
		if (6 == 0)
		{
		}
		ReferenceKey workpieceID = _0023_003DzT2wOlf0_003D.WorkpieceID;
		_ = 1;
		if (2 == 0)
		{
		}
		return workpieceID == _0023_003DzNZ9AqsSCWOI9OAEdzw_003D_003D.Key;
	}
}
