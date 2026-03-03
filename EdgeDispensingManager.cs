using System.Runtime.CompilerServices;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.EdgeDataModel;

namespace ScmGroup.XCam.Scripting;

public class EdgeDispensingManager
{
	private EdgeDispensing _0023_003DzL6gmdkX7GVrtuWcKLPTbA5iwj3xfHAn78g_003D_003D;

	private EdgeDispensing _0023_003DzK2xK9_1eKtRkSdL0L3shEHpTfPyZAekA4g_003D_003D;

	private UI00EdgeBandingOptions _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D;

	public EdgeDispensing EdgeDispensing
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (false)
			{
			}
			return _0023_003DzL6gmdkX7GVrtuWcKLPTbA5iwj3xfHAn78g_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003DzL6gmdkX7GVrtuWcKLPTbA5iwj3xfHAn78g_003D_003D = value;
			}
		}
	}

	public EdgeDispensing EdgeSlotDispensing
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (2 == 0)
			{
			}
			return _0023_003DzK2xK9_1eKtRkSdL0L3shEHpTfPyZAekA4g_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003DzK2xK9_1eKtRkSdL0L3shEHpTfPyZAekA4g_003D_003D = value;
			}
		}
	}

	public EdgeDispensingManager()
	{
		UI00EdgeBandingOptions edgeBandingOptions = AppInfo.CurrentOptions<UI00Options>().EdgeBandingOptions;
		if (8u != 0)
		{
			_0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D = edgeBandingOptions;
		}
		if (4u != 0)
		{
			_0023_003DzBMBVczs_003D();
		}
	}

	private void _0023_003DzBMBVczs_003D()
	{
		EdgeDispensing edgeDispensing = new EdgeDispensing();
		if (7u != 0)
		{
			EdgeDispensing = edgeDispensing;
		}
		EdgeDispensing.StartOffSet = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingStartOffSet;
		EdgeDispensing.StartOffSetOnClosing = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingStartOffSet;
		EdgeDispensing.TotalOffSet = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingTotalOffSet;
		EdgeDispensing.TotalOffSetOnClosing = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingTotalOffSet;
		EdgeDispensing.SafeOffSet = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingSafeOffSet;
		EdgeDispensing.SharpExtraOffset = 0.0;
		EdgeDispensing.IsTheFirstMultiEdgeBanding = false;
		EdgeDispensing.MultiEdgeBandingEnabled = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.MultiEdgeBanding;
		EdgeDispensing edgeSlotDispensing = new EdgeDispensing();
		if (uint.MaxValue != 0)
		{
			EdgeSlotDispensing = edgeSlotDispensing;
		}
		EdgeSlotDispensing.StartOffSet = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingSlotStartOffSet;
		EdgeSlotDispensing.TotalOffSet = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingSlotTotalOffSet;
		EdgeSlotDispensing.SafeOffSet = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.DispensingSlotSafeOffSet;
		EdgeSlotDispensing.IsTheFirstMultiEdgeBanding = false;
		EdgeSlotDispensing.MultiEdgeBandingEnabled = _0023_003Dzam0x1VLzKFDfy1BwK_ESRe8_003D.MultiEdgeBanding;
	}

	public void Reset()
	{
		if (0 == 0)
		{
			_0023_003DzBMBVczs_003D();
		}
	}

	public void CreateEdgeDispensing(double startOffSet, double totalOffSet, double safeOffSet, bool isMultiEdgeBandingEnabled)
	{
		EdgeDispensing edgeDispensing = new EdgeDispensing();
		if (2u != 0)
		{
			EdgeDispensing = edgeDispensing;
		}
		EdgeDispensing.StartOffSetOnClosing = startOffSet;
		EdgeDispensing.TotalOffSetOnClosing = totalOffSet;
		EdgeDispensing.StartOffSet = startOffSet;
		EdgeDispensing.TotalOffSet = totalOffSet;
		EdgeDispensing.SafeOffSet = safeOffSet;
		EdgeDispensing.MultiEdgeBandingEnabled = isMultiEdgeBandingEnabled;
	}

	public void CreateEdgeSlotDispensing(double startOffSet, double totalOffSet, double safeOffSet, bool isMultiEdgeBandingEnabled)
	{
		EdgeDispensing edgeSlotDispensing = new EdgeDispensing();
		if (2u != 0)
		{
			EdgeSlotDispensing = edgeSlotDispensing;
		}
		EdgeSlotDispensing.StartOffSet = startOffSet;
		EdgeSlotDispensing.TotalOffSet = totalOffSet;
		EdgeSlotDispensing.SafeOffSet = safeOffSet;
		EdgeSlotDispensing.MultiEdgeBandingEnabled = isMultiEdgeBandingEnabled;
	}
}
