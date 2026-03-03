using System.Runtime.CompilerServices;
using ScmGroup.XCam.MachiningDataModel.Strategy;

namespace ScmGroup.XCam.Scripting;

public class LeadInOut
{
	private bool _0023_003Dz9LVNjPYOntcLhMgjPsNov7NKB6gh;

	private bool _0023_003Dz62KhdOBnuAMJ91a5HwT0__00240a3SyA;

	private bool _0023_003DzqTaR4dLRHeleF0zzV33I7hLulnUn;

	private bool _0023_003DzRX1DN_gX8FFYg0lBQIi5HP5iW3m_0024;

	private bool _0023_003Dz5P2oUkkqRmN59wNjNbXcYCcVcpa9;

	private bool _0023_003DzVLSd9pvTpoZQBBuByELqq_0024OuMZrU;

	private double _0023_003DzeIwaCnChh_KhOrcQ2HDi0x0rHPIl;

	private double _0023_003DzBxm0lxU_0024UMKCkJ_6W1_Z40Gp1nTL;

	private double _0023_003DzzaUDDWukJ3_00245fPJGugNBiAA_003D;

	private double? _0023_003Dztp8HzbDB1ULxeNneHIsZcd_0024UVsGw;

	private double? _0023_003DzeJCE31RL6hcr45PbhADhpUr_q_OA;

	public bool IsLeadInEnabled
	{
		[CompilerGenerated]
		get
		{
			_ = 7;
			if (6 == 0)
			{
			}
			return _0023_003Dz9LVNjPYOntcLhMgjPsNov7NKB6gh;
		}
	}

	public bool IsLeadOutEnabled
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (6 == 0)
			{
			}
			return _0023_003Dz62KhdOBnuAMJ91a5HwT0__00240a3SyA;
		}
	}

	public bool IsLinearApproach
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (7 == 0)
			{
			}
			return _0023_003DzqTaR4dLRHeleF0zzV33I7hLulnUn;
		}
	}

	public bool IsLinearRetract
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (8 == 0)
			{
			}
			return _0023_003DzRX1DN_gX8FFYg0lBQIi5HP5iW3m_0024;
		}
	}

	public bool IsQuoteApproach
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (8 == 0)
			{
			}
			return _0023_003Dz5P2oUkkqRmN59wNjNbXcYCcVcpa9;
		}
	}

	public bool IsQuoteRetract
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (5 == 0)
			{
			}
			return _0023_003DzVLSd9pvTpoZQBBuByELqq_0024OuMZrU;
		}
	}

	public double ApproachDistance
	{
		[CompilerGenerated]
		get
		{
			_ = 8;
			if (3 == 0)
			{
			}
			return _0023_003DzeIwaCnChh_KhOrcQ2HDi0x0rHPIl;
		}
	}

	public double RetractDistance
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (7 == 0)
			{
			}
			return _0023_003DzBxm0lxU_0024UMKCkJ_6W1_Z40Gp1nTL;
		}
	}

	public double OverlapLength
	{
		[CompilerGenerated]
		get
		{
			_ = 3;
			if (-1 == 0)
			{
			}
			return _0023_003DzzaUDDWukJ3_00245fPJGugNBiAA_003D;
		}
	}

	public double? ApproachSpeed
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (false)
			{
			}
			return _0023_003Dztp8HzbDB1ULxeNneHIsZcd_0024UVsGw;
		}
	}

	public double? RetractSpeed
	{
		[CompilerGenerated]
		get
		{
			_ = 8;
			if (5 == 0)
			{
			}
			return _0023_003DzeJCE31RL6hcr45PbhADhpUr_q_OA;
		}
	}

	public LeadInOut()
	{
		if (true)
		{
			_0023_003Dz914o0CEhd7ZygAE5IA_003D_003D(_0023_003Dz3keKASA_003D: false);
		}
		if (4u != 0)
		{
			_0023_003DzZjHAXJgCSdmzWXscUQ_003D_003D(_0023_003Dz3keKASA_003D: false);
		}
		if (4u != 0)
		{
			_0023_003DzNpn5ojFpFYLbVKCA_pUE2hs_003D(_0023_003Dz3keKASA_003D: false);
		}
		_0023_003DzL5vunV7U_0024TAwZfNNvccXtAM_003D(_0023_003Dz3keKASA_003D: false);
		_0023_003DzkT_bEnTQXtbfaDOtfp8tzGc_003D(BaseApproachStrategy.DefaultRadiusMultiplier);
		_0023_003Dz4yHst92309VSJ443aJc8eZE_003D(_0023_003Dz3keKASA_003D: false);
		_0023_003Dzg_0024i3ex_B48FCMDXAal_ry3E_003D(_0023_003Dz3keKASA_003D: false);
		_0023_003DzgA2lcny0LnFH5akKeQ_003D_003D(BaseRetractStrategy.DefaultRadiusMultiplier);
		_0023_003DzeOh_xodgTCYe(0.0);
		_0023_003DzIDXy_0024ZJJVJ06zqLRt_9c_wA_003D(null);
		_0023_003DzaR2JgGItT7tlkMKvhg_003D_003D(null);
	}

	public LeadInOut(LeadInOut leadinout)
	{
		bool isLeadInEnabled = leadinout.IsLeadInEnabled;
		if (uint.MaxValue != 0)
		{
			_0023_003Dz914o0CEhd7ZygAE5IA_003D_003D(isLeadInEnabled);
		}
		bool isLeadOutEnabled = leadinout.IsLeadOutEnabled;
		if (uint.MaxValue != 0)
		{
			_0023_003DzZjHAXJgCSdmzWXscUQ_003D_003D(isLeadOutEnabled);
		}
		bool isLinearApproach = leadinout.IsLinearApproach;
		if (true)
		{
			_0023_003DzNpn5ojFpFYLbVKCA_pUE2hs_003D(isLinearApproach);
		}
		_0023_003DzL5vunV7U_0024TAwZfNNvccXtAM_003D(leadinout.IsQuoteApproach);
		_0023_003DzkT_bEnTQXtbfaDOtfp8tzGc_003D(leadinout.ApproachDistance);
		_0023_003Dz4yHst92309VSJ443aJc8eZE_003D(leadinout.IsLinearRetract);
		_0023_003Dzg_0024i3ex_B48FCMDXAal_ry3E_003D(leadinout.IsQuoteRetract);
		_0023_003DzgA2lcny0LnFH5akKeQ_003D_003D(leadinout.RetractDistance);
		_0023_003DzeOh_xodgTCYe(leadinout.OverlapLength);
		_0023_003DzIDXy_0024ZJJVJ06zqLRt_9c_wA_003D(leadinout.ApproachSpeed);
		_0023_003DzaR2JgGItT7tlkMKvhg_003D_003D(leadinout.RetractSpeed);
	}

	internal void _0023_003Dz914o0CEhd7ZygAE5IA_003D_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (true)
		{
			_0023_003Dz9LVNjPYOntcLhMgjPsNov7NKB6gh = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzZjHAXJgCSdmzWXscUQ_003D_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (4u != 0)
		{
			_0023_003Dz62KhdOBnuAMJ91a5HwT0__00240a3SyA = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzNpn5ojFpFYLbVKCA_pUE2hs_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (6u != 0)
		{
			_0023_003DzqTaR4dLRHeleF0zzV33I7hLulnUn = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dz4yHst92309VSJ443aJc8eZE_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (0 == 0)
		{
			_0023_003DzRX1DN_gX8FFYg0lBQIi5HP5iW3m_0024 = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzL5vunV7U_0024TAwZfNNvccXtAM_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (0 == 0)
		{
			_0023_003Dz5P2oUkkqRmN59wNjNbXcYCcVcpa9 = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dzg_0024i3ex_B48FCMDXAal_ry3E_003D(bool _0023_003Dz3keKASA_003D)
	{
		if (0 == 0)
		{
			_0023_003DzVLSd9pvTpoZQBBuByELqq_0024OuMZrU = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzkT_bEnTQXtbfaDOtfp8tzGc_003D(double _0023_003Dz3keKASA_003D)
	{
		if (4u != 0)
		{
			_0023_003DzeIwaCnChh_KhOrcQ2HDi0x0rHPIl = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzgA2lcny0LnFH5akKeQ_003D_003D(double _0023_003Dz3keKASA_003D)
	{
		if (5u != 0)
		{
			_0023_003DzBxm0lxU_0024UMKCkJ_6W1_Z40Gp1nTL = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzeOh_xodgTCYe(double _0023_003Dz3keKASA_003D)
	{
		if (7u != 0)
		{
			_0023_003DzzaUDDWukJ3_00245fPJGugNBiAA_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzIDXy_0024ZJJVJ06zqLRt_9c_wA_003D(double? _0023_003Dz3keKASA_003D)
	{
		if (3u != 0)
		{
			_0023_003Dztp8HzbDB1ULxeNneHIsZcd_0024UVsGw = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzaR2JgGItT7tlkMKvhg_003D_003D(double? _0023_003Dz3keKASA_003D)
	{
		if (8u != 0)
		{
			_0023_003DzeJCE31RL6hcr45PbhADhpUr_q_OA = _0023_003Dz3keKASA_003D;
		}
	}

	public void CreateLeadIn(bool isLinear, bool isQuote, double distance, double? speed)
	{
		if (7u != 0)
		{
			_0023_003Dz914o0CEhd7ZygAE5IA_003D_003D(_0023_003Dz3keKASA_003D: true);
		}
		if (3u != 0)
		{
			_0023_003DzNpn5ojFpFYLbVKCA_pUE2hs_003D(isLinear);
		}
		if (true)
		{
			_0023_003DzL5vunV7U_0024TAwZfNNvccXtAM_003D(isQuote);
		}
		_0023_003DzkT_bEnTQXtbfaDOtfp8tzGc_003D((distance >= 0.0) ? distance : BaseApproachStrategy.DefaultRadiusMultiplier);
		_0023_003DzIDXy_0024ZJJVJ06zqLRt_9c_wA_003D(speed);
	}

	public void CreateLeadOut(bool isLinear, bool isQuote, double distance, double overlapLength, double? speed)
	{
		if (true)
		{
			_0023_003DzZjHAXJgCSdmzWXscUQ_003D_003D(_0023_003Dz3keKASA_003D: true);
		}
		if (2u != 0)
		{
			_0023_003Dz4yHst92309VSJ443aJc8eZE_003D(isLinear);
		}
		if (6u != 0)
		{
			_0023_003Dzg_0024i3ex_B48FCMDXAal_ry3E_003D(isQuote);
		}
		_0023_003DzgA2lcny0LnFH5akKeQ_003D_003D((distance >= 0.0) ? distance : BaseApproachStrategy.DefaultRadiusMultiplier);
		_0023_003DzeOh_xodgTCYe(overlapLength);
		_0023_003DzaR2JgGItT7tlkMKvhg_003D_003D(speed);
	}

	public void ResetLeadIn()
	{
		if (3u != 0)
		{
			_0023_003Dz914o0CEhd7ZygAE5IA_003D_003D(_0023_003Dz3keKASA_003D: false);
		}
		if (7u != 0)
		{
			_0023_003DzNpn5ojFpFYLbVKCA_pUE2hs_003D(_0023_003Dz3keKASA_003D: false);
		}
		if (0 == 0)
		{
			_0023_003DzL5vunV7U_0024TAwZfNNvccXtAM_003D(_0023_003Dz3keKASA_003D: false);
		}
		_0023_003DzkT_bEnTQXtbfaDOtfp8tzGc_003D(BaseApproachStrategy.DefaultRadiusMultiplier);
		_0023_003DzIDXy_0024ZJJVJ06zqLRt_9c_wA_003D(null);
	}

	public void ResetLeadOut()
	{
		if (2u != 0)
		{
			_0023_003DzZjHAXJgCSdmzWXscUQ_003D_003D(_0023_003Dz3keKASA_003D: false);
		}
		if (7u != 0)
		{
			_0023_003Dz4yHst92309VSJ443aJc8eZE_003D(_0023_003Dz3keKASA_003D: false);
		}
		if (2u != 0)
		{
			_0023_003Dzg_0024i3ex_B48FCMDXAal_ry3E_003D(_0023_003Dz3keKASA_003D: false);
		}
		_0023_003DzgA2lcny0LnFH5akKeQ_003D_003D(BaseRetractStrategy.DefaultRadiusMultiplier);
		_0023_003DzeOh_xodgTCYe(0.0);
		_0023_003DzaR2JgGItT7tlkMKvhg_003D_003D(null);
	}
}
