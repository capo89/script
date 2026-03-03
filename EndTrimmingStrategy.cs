using System.Runtime.CompilerServices;
using ScmGroup.XCam.Common;

namespace ScmGroup.XCam.Scripting;

public class EndTrimmingStrategy : Strategy
{
	private CuttingMethod _0023_003Dz2p_KjEikUlXXFaNAuH1RCswgs_0024G5;

	private double _0023_003DzC9p9SgvIEk2I5ecUTEmnPSo_003D;

	private object _0023_003Dzhuqtzo9iG7K4VXMrfxIHAbgbt1Vm;

	private WorkSide _0023_003Dzf91oqG9P96T1iRFUOMq5m9w_003D;

	private UI00EndTrimmingOptions _0023_003DzjbOhMtqzJ53h;

	private UI00Options _0023_003DzgK1Mwoo_003D;

	public CuttingMethod CuttingMethod
	{
		[CompilerGenerated]
		get
		{
			_ = 7;
			if (8 == 0)
			{
			}
			return _0023_003Dz2p_KjEikUlXXFaNAuH1RCswgs_0024G5;
		}
		[CompilerGenerated]
		set
		{
			if (0 == 0)
			{
				_0023_003Dz2p_KjEikUlXXFaNAuH1RCswgs_0024G5 = value;
			}
		}
	}

	public double OverMaterial
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (-1 == 0)
			{
			}
			return _0023_003DzC9p9SgvIEk2I5ecUTEmnPSo_003D;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003DzC9p9SgvIEk2I5ecUTEmnPSo_003D = value;
			}
		}
	}

	public object OverCutLenght
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (7 == 0)
			{
			}
			return _0023_003Dzhuqtzo9iG7K4VXMrfxIHAbgbt1Vm;
		}
		[CompilerGenerated]
		set
		{
			if (4u != 0)
			{
				_0023_003Dzhuqtzo9iG7K4VXMrfxIHAbgbt1Vm = value;
			}
		}
	}

	public WorkSide WorkSide
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (6 == 0)
			{
			}
			return _0023_003Dzf91oqG9P96T1iRFUOMq5m9w_003D;
		}
		[CompilerGenerated]
		set
		{
			if (0 == 0)
			{
				_0023_003Dzf91oqG9P96T1iRFUOMq5m9w_003D = value;
			}
		}
	}

	public EndTrimmingStrategy()
	{
		if (2u != 0)
		{
			_0023_003DzBMBVczs_003D();
		}
	}

	public EndTrimmingStrategy(EndTrimmingStrategy copy)
	{
		if (copy != null)
		{
			CuttingMethod cuttingMethod = copy.CuttingMethod;
			if (0 == 0)
			{
				CuttingMethod = cuttingMethod;
			}
			double overMaterial = copy.OverMaterial;
			if (4u != 0)
			{
				OverMaterial = overMaterial;
			}
			object overCutLenght = copy.OverCutLenght;
			if (uint.MaxValue != 0)
			{
				OverCutLenght = overCutLenght;
			}
			WorkSide = copy.WorkSide;
		}
	}

	private void _0023_003DzBMBVczs_003D()
	{
		UI00EndTrimmingOptions endTrimmingOptions = AppInfo.CurrentOptions<UI00Options>().EndTrimmingOptions;
		if (uint.MaxValue != 0)
		{
			_0023_003DzjbOhMtqzJ53h = endTrimmingOptions;
		}
		UI00Options uI00Options = AppInfo.CurrentOptions<UI00Options>();
		if (7u != 0)
		{
			_0023_003DzgK1Mwoo_003D = uI00Options;
		}
		if (true)
		{
			CuttingMethod = CuttingMethod.CenterBlade;
		}
		OverCutLenght = _0023_003DzjbOhMtqzJ53h.OffSetBorderHeight;
		OverMaterial = 0.0;
		WorkSide = WorkSide.Start;
	}

	public void Clear()
	{
		if (8u != 0)
		{
			_0023_003DzBMBVczs_003D();
		}
	}

	internal void _0023_003DzLs1Gkio_003D(WorkSide _0023_003DzJn1O8ruoD8RmV904HQ_003D_003D, CuttingMethod _0023_003DzWcLCMZ4OnVsTpQLtZw_003D_003D, double _0023_003DzbDCdcxRsxdCG, object _0023_003DzMcxCUEVJ5zH8wP7TaQ_003D_003D)
	{
		if (3u != 0)
		{
			CuttingMethod = _0023_003DzWcLCMZ4OnVsTpQLtZw_003D_003D;
		}
		if (6u != 0)
		{
			OverMaterial = _0023_003DzbDCdcxRsxdCG;
		}
		if (OverCutLenght != null)
		{
			if (2u != 0)
			{
				OverCutLenght = _0023_003DzMcxCUEVJ5zH8wP7TaQ_003D_003D;
			}
		}
		WorkSide = _0023_003DzJn1O8ruoD8RmV904HQ_003D_003D;
	}
}
