using System;
using System.Collections.Generic;
using System.Linq;
using OccExtension;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ConfigDataModel;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.ConfigDataModel.Enumerations;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.ConfigDataModel.Spindles;
using ScmGroup.XCam.ConfigDataModel.WorkingAreas;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.Localization;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Milling;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.MachiningDataModel.WorkPlane;
using ScmGroup.XCam.Scripting.ProjectModule;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Aggregate;
using ScmGroup.XCam.ToolDataModel.Common;
using ScmGroup.XCam.ToolDataModel.Tool;

namespace ScmGroup.XCam.Scripting;

public class XilogProgram : Program
{
	private sealed class _0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D
	{
		public int _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D;

		public _0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D()
		{
			_ = 2;
			if (false)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzOiiHB7QpdGEbeEso98yYwwaCgvbtjNyHxw_003D_003D(MachineElementBase _0023_003DzBj__0024aOE_003D)
		{
			_ = 6;
			if (3 == 0)
			{
			}
			int spindleNumber = (_0023_003DzBj__0024aOE_003D as Spindle).SpindleNumber;
			_ = -1;
			if (false)
			{
			}
			return spindleNumber == _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D;
		}
	}

	private sealed class _0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D
	{
		public int _0023_003Dz_z_7_0024qk_003D;

		public _0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D()
		{
			_ = 6;
			if (false)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzA0rW_KBni7QlTJ1L5w_003D_003D(StandardBoringHead _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D)
		{
			_ = 7;
			if (3 == 0)
			{
			}
			int headNumber = _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D.HeadNumber;
			_ = 4;
			if (-1 == 0)
			{
			}
			return headNumber == _0023_003Dz_z_7_0024qk_003D;
		}

		internal bool _0023_003Dz4ZWrfEJni2aZ1AQnyQ_003D_003D(BrcBoringHead _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D)
		{
			_ = 2;
			if (4 == 0)
			{
			}
			int headNumber = _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D.HeadNumber;
			_ = -1;
			if (5 == 0)
			{
			}
			return headNumber == _0023_003Dz_z_7_0024qk_003D;
		}
	}

	[Serializable]
	private sealed class _0023_003DzJBaCSp8_003D
	{
		public static readonly _0023_003DzJBaCSp8_003D _0023_003DzK15DASY_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzbbjOLY6Hp88WVXUMVg_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzfJiKAQfAfEgB3wA4Dg_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzIyDysVHVSU1AQo8bdw_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzK6GoxSsjmSg7w6b92w_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003Dz97dXx_XU1GBv1cW2rA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzTY70bDGyMu2kFmLpwg_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DznvDMS8kTGFilne97vA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzR2CTdXSnGPcNt01_0024_w_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzFObuk0ZdiF58EpHKlQ_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003DzOV4BKdSqqPcl636wNg_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003Dz_0024eDIpOXozDCznM4KRA_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003Dz91Ebl2AbE5wP74ID_w_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzCuNsxn6h1HkB66mPvQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzMrVAYy_0024GmTTIJVl8tg_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzharkCK_0024y8SheDtd_0024Zw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzlOuGKY_0024S2Y8HMBXVkQ_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzGMVdnmWq7wS_ndqizA_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003Dz8d_0024hUxmxdp2WCqCQ4g_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzkuiKQZiDLEVoPus9tg_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzGSiktISpQpfe1nox_0024w_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003Dzcg8t9cX_hIP9JOdBSw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzJVRy_0024AM6I7XWp93wdQ_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzFObuk0ZdiF6y9atI2Q_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003DzN6Py3XiJEl1_jOIJjw_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzgpSnLXreffkTwSixcA_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzgFm8e9q3QaIqU_00241vMw_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzBtKPo0tdNLAwQq2BCA_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003Dzgv_6TtfNSlcqkPpBJQ_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzGjP_0024vNZ8LgbRA_00247P4g_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzgFm8e9q3QaKRMOUNgA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzKr6K6HtRI1oovSESzw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzuKVuDc3GvlFMj2bdjQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzA4dnBWBLh13otypq0A_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzHZA77X5_K942NGf4EQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003Dzgl_0024yiJnA3CeSZGFolQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DziunbZWtKBeMajAiVWA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzTGVZvSGOQf6HilJFsA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzW_cENPY_0024v9ILA0yAAw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzwN_kWMi0nGZBNvv1nQ_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzlOuGKY_0024S2Y9lrUtipg_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzfXnfzr1qSSCeCahmzQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzH6DPUMW_0024f3r_sA7z3w_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzDOQG8HROYu_vNFslZQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzdhuyNURPQPaXBn_lmg_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzLgf1YlUY1r1a6dQR_w_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003Dzt38IK01FNZqpsd_9_0024w_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzO9wAxcdr68FeeH_0024fRA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzuKVuDc3GvlGOq_00247Ntg_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003Dzgl_0024yiJnA3Cfjj53omQ_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003DzFDXNiangM9XTFow7ZQ_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzXD5EVcppMwVkVxfF2g_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003DzNEdPWTHEzvG_0024hQiK4Q_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003Dzl0fNWxbsijq_0024hl8XsA_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzH3MNM7idhbYb4sNg4g_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzcNhC2nIe_tkC70XjAA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003Dzjamptatb_zR_0024hhO7qA_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzhfOPaAdOuIrJNB9CeQ_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003DzW_cENPY_0024v9L_AUzycw_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzRtycddyCyVif5zYbww_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzyTgZp8hsx0vlrrFwnw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzYdGeRs4edNS6znVFbw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzddWK3ymFPJv_pF91bg_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003Dz7TCVIOQgCzpMDXOrHQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzqGORxQkZ4t2OdbYVhQ_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003Dzo43bvC9Re_0024H7XNRVGw_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzBeyLXTmhDtOeYcuLbA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzFVwcL_YYVES49xcRkQ_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzEk2zUPJqUJUHkggQJA_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzFObuk0ZdiF6zK3Ks5w_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzXc95f2OwyhhR0T_0024OSA_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzXc95f2OwyhhvT_JFXg_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003DzM4wdE_0024VKs3vkmGSVbg_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzfXnfzr1qSSB20t4f0A_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003Dz8d_0024hUxmxdp1Zi61ogw_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzBtKPo0tdNLCOk1OsgA_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzNKMf_dqsBYmgrxMUVw_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003DzTBUwqIUBqY7OW1Y_UA_003D_003D;

		public static Func<KeyValuePair<string, string>, string> _0023_003Dz9QfQwArnw8wS6RlR0A_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003Dz7TCVIOQgCzpeZ_0024EwDw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003Dzgl_0024yiJnA3Ce_EBmQGw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, string> _0023_003DzfJiKAQfAfEh_LGNPyw_003D_003D;

		public static Func<KeyValuePair<string, NatureOfParameter>, NatureOfParameter> _0023_003DzH_jPaa8L_VudvcuxZg_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzEl3_0024xS2jQ5QPL8viVw_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003DzShbDzTWpPds3yWrdnw_003D_003D;

		public static Func<KeyValuePair<string, double>, string> _0023_003DzCmYc2hpr1Lmen5f8OQ_003D_003D;

		public static Func<KeyValuePair<string, double>, double> _0023_003Dz666CX22AYreom_VWJg_003D_003D;

		public static Predicate<Attribute> _0023_003DzfxVV8EcISkWZbuK4tg_003D_003D;

		public static Func<Attribute, double> _0023_003DzPYGdCCj9cOVJkgWh0A_003D_003D;

		public static Predicate<Attribute> _0023_003DzZmp4TCu4SyhvfuoRng_003D_003D;

		public static Predicate<Attribute> _0023_003DzIoCO3yuQmCYRMqeIuQ_003D_003D;

		public static Predicate<Attribute> _0023_003DzmpqLY2g7rFCVhP4J_0024w_003D_003D;

		public static Predicate<Attribute> _0023_003Dzk8ieNN_Gx4uYlD7egQ_003D_003D;

		public static Predicate<Attribute> _0023_003Dz8oBJUCgRYdfOw2382g_003D_003D;

		public static Predicate<Attribute> _0023_003DzdargcZzEV_D28afXHQ_003D_003D;

		public static Predicate<Attribute> _0023_003DzqKEIW7_0024HNtniblaN2w_003D_003D;

		public static Predicate<Attribute> _0023_003DzE2DfTsR9ez8z3CqMdg_003D_003D;

		public static Predicate<Attribute> _0023_003DzP8JXUOuSZskrgxFaAQ_003D_003D;

		public static Predicate<Attribute> _0023_003DzH1MO_0024rvrqEKr73yX7Q_003D_003D;

		public static Predicate<Attribute> _0023_003DzGo6eKEhm5jf9IchR4Q_003D_003D;

		public static Predicate<Attribute> _0023_003DzoYJWrO8cPe358WNbig_003D_003D;

		public static Predicate<Attribute> _0023_003DzUyAyOPappDsy1_0024f8lA_003D_003D;

		public static Predicate<Attribute> _0023_003Dz2B8Fhu_0024wcxjYAm3CnQ_003D_003D;

		public static Predicate<Attribute> _0023_003Dz6rLETOCrX9GjfVH7nQ_003D_003D;

		public static Predicate<Attribute> _0023_003DzsUOi3sTeNStHIiVNMw_003D_003D;

		public static Predicate<Attribute> _0023_003Dzxw3A73zsJgKhCy9lZw_003D_003D;

		public static Predicate<Attribute> _0023_003DzqtzmWeDa4zjp_muczQ_003D_003D;

		public static Predicate<Attribute> _0023_003DzG_0024GgnyFeTd9iqK1G5w_003D_003D;

		public static Func<Attribute, double> _0023_003DznrTIxxKj70LJS72O4Q_003D_003D;

		public static Predicate<Attribute> _0023_003DzV97ObCKXDeDt1BI3dA_003D_003D;

		public static Action<Attribute> _0023_003Dzkjnih8DK1mbSHrXGWg_003D_003D;

		public static Predicate<Attribute> _0023_003Dzkjnih8DK1mYDNHUwdg_003D_003D;

		public static Predicate<Attribute> _0023_003DzGqj4LvPil0SwNE3BRA_003D_003D;

		public static Predicate<Attribute> _0023_003DzWbWTF9dkwNJjVck_0024AA_003D_003D;

		public static Predicate<Attribute> _0023_003DzZcChKLtVJXFbLKZ74g_003D_003D;

		public static Predicate<Attribute> _0023_003Dzlgf5xxAx0SoqeuX2Lg_003D_003D;

		static _0023_003DzJBaCSp8_003D()
		{
			_0023_003DzJBaCSp8_003D _0023_003DzJBaCSp8_003D = new _0023_003DzJBaCSp8_003D();
			if (7u != 0)
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

		internal string _0023_003Dz7i4BnHi6274dB0We8dUmHPU_003D(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dz_00240zR_0024txVEn_0024P_0024XKcpGVk6W0_003D(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzmXbVi4ByxHmLQhfiuV2SgpQ_003D(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dzlk4_M4qpucXB30_0024BQRGFkT8_003D(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzLO0XwHJkxy803XJKonuYTS4_003D(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzDopkS_0024Dx_0024Y1Deluf4HiQhi4_003D(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzPi9UJpIIwn7hxsVQBtrbWUI_003D(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzndOMV55Kz7UzOnfR_WetPfs_003D(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dz8PJZARorEEJxSG_SiMtSNT8_003D(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzaX22V8aKV5sHDmQ8tVn0vR0_003D(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzlDb_6Zf34dVXvVMtYZQVx5ULjvWG(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzJK7vYwPUsu6vkUvcAbFA8_7BrvnX(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzHWYffBj2b2SRUoRNIDsiVRgr9vCA(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzBRXqhxYSekKFhZsnfoxJyO_0024jUm7t(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzvnPLBw2k6BfkYenepfMBMbnrRR7Q(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzDoI9OjcNs_0024dyf8wn72oL57shS7T9(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzQFyixF_AOcInuhRyN8NQl2PzmxiF(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzhBvMqSI7r6yUFaRTvAR40Py0CUiN(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzDoxLACUNE38G5zL18cOST5J0dLox(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzDfI_IX7JicI9TnvM4vX1GErMY1K4(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzdgoytgH4lytEphkacK1_0024nNCwetFE(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzR2lwstlZQQZWOUQ2jqanVVPMAF3I(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dz9pJ5OFovUUedRSpphL60u9NBMqOd(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzKSt28_0024BoYXVocHPygXotMVIVqYmU(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzxKg3TRQxCMJgBiUbqsD2ovIFZ6kx(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dzs_00245vzV69uwdrg14RLFhdEqsd7Jxt(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzGd3_0024xzc93SgWwFR2tZ_Zi29D_0024jvQ(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dz3AQy6GFkLkD4Lbed5rARqluQdtaG(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dz914oRtQhGB808VcF_Ov88xQD_0024S_0024c(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003Dzt8seMGRMleCO7NuaW739Br_xGmXI(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzrRmnTLSsA_0024sKpi_mSL_0024R7Dyo2tH9(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzFsIPGIBpL_QNyTlaCFoecjWfYQ1p(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzoKJRvCAfo4pNTkFKTJNOp8BCNG_U(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzGLhAVox_0024DHE7Z6ewuM9rsZhUvtIg(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzMdC_mgJh70mP9K_YSTWwe3wffodD(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dzn_9V9USS5vKe_0024YG8AO4ZOwwQKQCP(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dzt9GA1zh8p9KVEShPmntAEhcSVzwR(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzjauFdN2LCBai6Kcwr3BcADdVKrqd(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzEDALZiYt5Vs16eQKEQ25s3ufEtPq(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003Dz4YBcmedik7DORYUKHZOjE4_wkUnv(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzNZuKuukWnS8VOSnXRf3ijg3KpKH1(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzErNWCVMhKuAfcmzkxlqyzfkrLJnc(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzrTfunYI319bS7yU6N2TY04WlvKSh(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzQ1RizaDPbv2EccSnWyDI8Ad_0024J6wC(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzoUHY887RMAAiwUV2BENLKsQBCe6U(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003Dz55LRw9JZG9amCGOoO69Lb4VC_0024qpa(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzpuUA_Tn7Il_NCsrNJNPB_0024C4lCs1W(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzRV8RBHhAaMblI2ew9g4kK_QOzT0k(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dz_BvZQ2qIVkVDjDzXpH_7pymqYlQ6(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003Dz2WI7soGavTC_0024h4bZ5DQ4S9wEUNLI(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzSs9wWHjN6O5huY0mgCaTayB3NTWG(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzG7_0024ryGup6TvKnal0ayQottwfi5Wd(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzbV0yN_0024BCMQhX8A8I7_fyVLzj53bh(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dz8O_78YorwlIxMH4rSh_0024py9O_VtU3(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzHpTnO3YTEL05AcSPKPSSLbWOKukR(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzsxOyx1fWC7wMFK4t2D1eRu0_KTX7(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dzi_0024akCEneVFp_00246fIo_nCTUGQxTNMq(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzAw5E_0024EfDfD0Me2VCjoREqRrV1N6F(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dz_Ce35Vn6jLfNYrDnvNN0kIYdBSPZ(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzfP4MRNgrtlbq35xHBxXMm2mcyK_0024U(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzioozCZCg7ditDXp3uZD7K8mlutS_(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003Dz_MdbiDHyDoUP_0024TKCR6ytwjS9kFmZ(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzaYd524qaON_Npov3_0024c8W_QZGsaae(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzrKfteZ_00246JIqJmKvrF_W0NuuO3i6D(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dzb3w93asN_8znyn3WPwaBsBYbB4Md(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dz2RKijhjPCJp6lxcJTt2VWYCtmN_A(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dzj4ZhSdRHu7teOrFQ4hd2EqvAoYCU(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003Dzvb_0024_0024DkAEU6x3ez1ASOTN1E40s_0024ze(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzdHsBUrPWCxLaQoiNGVqNEhkCS5_0024t(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzncAAqr0K336Emj_00240lv3XxbaOfErN(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzRQpoGmDRr15liS3TxTeSWweInNc3(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzSgGTyhV6qiddkIYKEcuMgeD3gKFY(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DztMtebJAxxY5o4Qg8kR8dsa7towiU(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzYPydoETf_0024pCjQnf03QoVNkKTRuBx(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzKE8uWJkxtW_QroMLlMODLNX3C0Nz(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003Dzk3sHW04cfawFkhG8h53yQrNN1XrF(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzWJBLolmnvSq2jTkQP5lttmvQqvyr(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal string _0023_003DzyWxUVKZDqEgNceXEkrcIiXOdMaWr(KeyValuePair<string, string> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dzx_aq1q0hkFpq_0024JFXigposCVaySeG(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003Dzlmp8wyAm9fpxPQsb1vpG31wzmtwd(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dzmhm4eKDfIpYg3AFKXm8QE9hKWfz1(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal NatureOfParameter _0023_003DzzeI60VjfCoEOYtopU2a2XYhdW_0024AC(KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003DzCrRw9RaLsRan8EcBpKNvG5Adatj_(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003DzQP5MBhg6iCGIHJyyY7gV18L0Mcpk(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal string _0023_003Dz4_0024qEyBRKR27Gv5iB_0024e8z3tzM_E6y(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Key;
		}

		internal double _0023_003Dz57diJOtGtNF5lSMcGLDpOKerDbyN(KeyValuePair<string, double> _0023_003Dz_HHC00I_003D)
		{
			return _0023_003Dz_HHC00I_003D.Value;
		}

		internal bool _0023_003Dz7VPq56nMqI7FDcZGOVAL5N46Hnra(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 5;
			if (3 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.Value is DepthAttribute;
		}

		internal double _0023_003DzTkH28SzBVGWxwkDq9CjAhZBXFcmG(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 7;
			if (1 == 0)
			{
			}
			return (_0023_003Dz6pELRLc_003D.Value as DepthAttribute).Depth;
		}

		internal bool _0023_003DzlJ394wvD6vflYu0HmC_0024mTMT1ZxJ3(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = -1;
			if (2 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.Value is DepthAttribute;
		}

		internal bool _0023_003DztvlSM_dyurwjz4xvxJBQ1xAKpm7RMyzSJA_003D_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 6;
			if (2 == 0)
			{
			}
			if (_0023_003Dz6pELRLc_003D.Value is SpeedAttribute)
			{
				_ = 7;
				if (false)
				{
				}
				return _0023_003Dz6pELRLc_003D.Index < 1;
			}
			return false;
		}

		internal bool _0023_003Dz1H87FgjcSlF4S829ITjIERG9jcUA7WLcgQ_003D_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 3;
			if (7 == 0)
			{
			}
			if (_0023_003Dz6pELRLc_003D.Value is SpeedAttribute)
			{
				_ = 3;
				if (8 == 0)
				{
				}
				return _0023_003Dz6pELRLc_003D.Index < 1;
			}
			return false;
		}

		internal bool _0023_003DzC7j7tIqrLnXL8AmEn6gGzezoAtwFKOLtww_003D_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 5;
			if (7 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.Value is DepthAttribute;
		}

		internal bool _0023_003Dz9u97u6bfyfwbgPIvLX5L95kAhagnhFiXd9xy8ZU_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 0;
			if (3 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dz7TrU6eCzP1FbSTsQYxw_0024HA_9jdG0HzE8eMqeWyc_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 1;
			if (3 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003DzP24zraU9kMH1ZdPr8Bl0kFZ3cqNQub2eazUTuY0_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 0;
			if (8 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dz_w1sMazvSfd63pv9ADOIBpWfgN__0024BepzRS89H40_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 7;
			if (-1 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003DzUm7Ps_2MR_QKLwrOKxm1icnPzri4(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 4;
			if (4 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dz26ACCD1VKpZjB1js8fzjReD91THq(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 3;
			if (8 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003DzzBpkITTj_00244w8RzA3pXx2wXltHH7c(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 8;
			if (false)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dzf6cX_vcMxId2uicH2_5Wcs3o_0024qDL(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 8;
			if (6 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dzmewrslqasmb_0024dh9j8_0024LiLwutZNXe(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 3;
			if (-1 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dz3g6mwajNJ3beKDbawXHHRqivTTqG(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = -1;
			if (6 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dz53Gf6vTWH7nLTp6K3y2Pmk_SeLALyBRtNg_003D_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 5;
			if (5 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003DzxAbBhfSsmIDbp0yGbRqNmgSvKlpCntHSnQ_003D_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 3;
			if (-1 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003DzgWzwyGm7sNk3j6cE6A78ZS85Bf23xNHivw_003D_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 2;
			if (5 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003Dz0287C2qZPd96jhvzJd69IXoLzx8dVcDp0g_003D_003D(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = -1;
			if (3 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}

		internal bool _0023_003DzIVPT587Z527ZBbSzkK0WTN05pc5xzd5v0g_003D_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 0;
			if (8 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.Value is DepthAttribute;
		}

		internal double _0023_003DzMsF6svIwbsgakn7Pgz9_kbsU1IQX_0024VnhGw_003D_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 0;
			if (8 == 0)
			{
			}
			return (_0023_003Dz6pELRLc_003D.Value as DepthAttribute).Depth;
		}

		internal bool _0023_003DzLjANo07ROK_wUg_0024Id1eXxHutL8FspwDk7G4Y6IA_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 1;
			if (1 == 0)
			{
			}
			return _0023_003Dz6pELRLc_003D.Value is DepthAttribute;
		}

		internal void _0023_003Dz3ffEFzAhXEga5QqQ_4om0dNzp2UoMdx5v84KwFg_003D(Attribute _0023_003DzLmsUmIw_003D)
		{
			double depth = (_0023_003DzLmsUmIw_003D.Value as DepthAttribute).Depth;
			double val;
			if (5u != 0)
			{
				val = depth;
			}
			if (!MathUtility.IsEqual(0.0, val))
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716668);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = Array.Empty<object>();
				if (5u != 0)
				{
					ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
				}
			}
		}

		internal bool _0023_003DziyvXcfRxSvD4Fj06olH1yCLy1HV_00248B_Up7MVpW0_003D(Attribute _0023_003DzLDWhkEg_003D)
		{
			_ = -1;
			if (-1 == 0)
			{
			}
			return _0023_003DzLDWhkEg_003D.Value is HeightAttribute;
		}

		internal bool _0023_003DzrrLdAQSHZBYKzpA9pGXKnxeiByQxyaZmKf_kmDY_003D(Attribute _0023_003DzLDWhkEg_003D)
		{
			_ = 8;
			if (8 == 0)
			{
			}
			if (!(_0023_003DzLDWhkEg_003D.Value is HeightAttribute))
			{
				_ = 1;
				if (-1 == 0)
				{
				}
				if (!(_0023_003DzLDWhkEg_003D.Value is DepthAttribute))
				{
					_ = 2;
					if (4 == 0)
					{
					}
					return _0023_003DzLDWhkEg_003D.Value is RotXAttribute;
				}
			}
			return true;
		}

		internal bool _0023_003DzU0gd6j6ELyMVnSA4D73HjAu3QdDh94dmdw_003D_003D(Attribute _0023_003DzLDWhkEg_003D)
		{
			_ = 3;
			if (1 == 0)
			{
			}
			return _0023_003DzLDWhkEg_003D.Value.UPar == 0.0;
		}

		internal bool _0023_003DzTy4kUjV1Vxc4bzKP7EoLpmsAAejZ(Attribute _0023_003DzLDWhkEg_003D)
		{
			_ = 3;
			if (1 == 0)
			{
			}
			return _0023_003DzLDWhkEg_003D.Value is HeightAttribute;
		}

		internal bool _0023_003DzaFFrQ1qwk77zaL9MZ9Ncw_Dxmt_0024_0024(Attribute _0023_003DzLDWhkEg_003D)
		{
			_ = 2;
			if (false)
			{
			}
			return (_0023_003DzLDWhkEg_003D.Value as HeightAttribute).UPar == 0.0;
		}
	}

	private sealed class _0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D
	{
		public string _0023_003DzShOujVI_003D;

		public _0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D()
		{
			_ = 7;
			if (false)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dzphqi7KlXfMeIrQ7Ejw_003D_003D(XilogProfile _0023_003DzizMNQp8_003D)
		{
			_ = 4;
			if (false)
			{
			}
			string name = _0023_003DzizMNQp8_003D.Name;
			_ = 0;
			if (2 == 0)
			{
			}
			return name == _0023_003DzShOujVI_003D;
		}
	}

	private sealed class _0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D
	{
		public int _0023_003DzOiEjdhXyi_A_0024;

		public Predicate<MachineElementBase> _0023_003DzT2FUfmoqfxMd;

		public _0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D()
		{
			_ = 2;
			if (false)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzSRJxXmqRyStoJ4bCTfgaYYzGd345(MachineElementBase _0023_003DzDvBs8qelz2Xb)
		{
			_ = 7;
			if (-1 == 0)
			{
			}
			int spindleNumber = (_0023_003DzDvBs8qelz2Xb as Spindle).SpindleNumber;
			_ = 7;
			if (8 == 0)
			{
			}
			return spindleNumber == _0023_003DzOiEjdhXyi_A_0024;
		}
	}

	private sealed class _0023_003DzSVnn8GyiD5JOlVYW2hj0kiA_003D
	{
		public string _0023_003DzXxDWvs0pMGW2;

		public _0023_003DzSVnn8GyiD5JOlVYW2hj0kiA_003D()
		{
			_ = 3;
			if (4 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dzzhfz_0024_X4jpRb0NbPlvpyNisbHuUI8ZWv5VGMZj8_003D(Spindle _0023_003DzBj__0024aOE_003D)
		{
			_ = 0;
			if (3 == 0)
			{
			}
			int spindleNumber = _0023_003DzBj__0024aOE_003D.SpindleNumber;
			_ = 4;
			if (3 == 0)
			{
			}
			return spindleNumber == short.Parse(_0023_003DzXxDWvs0pMGW2);
		}
	}

	private sealed class _0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D
	{
		public int _0023_003DzWOoFuVE_003D;

		public _0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D()
		{
			_ = 8;
			if (3 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzhKY_bLbbJZLMMOvtshzWGzc_003D(Attribute _0023_003Dz6pELRLc_003D)
		{
			_ = 1;
			if (-1 == 0)
			{
			}
			int index = _0023_003Dz6pELRLc_003D.Index;
			_ = 0;
			if (false)
			{
			}
			return index < _0023_003DzWOoFuVE_003D;
		}
	}

	private sealed class _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D
	{
		public double _0023_003DzzZAy6Tk_003D;

		public Geometry _0023_003Dz5Je5VG8_003D;

		public XilogProgram _0023_003DzfOCoHG40Z_ED;

		public Action<Attribute> _0023_003DzELsrcycsX_0024f_;

		public _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D()
		{
			_ = 5;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		internal void _0023_003DzSF3qKOo3Kel_R4T9sEQd1_0DQa2B(Attribute _0023_003DzuOjZrP0_003D)
		{
			double height = (_0023_003DzuOjZrP0_003D.Value as HeightAttribute).Height;
			if (true)
			{
				_0023_003DzzZAy6Tk_003D = height;
			}
			_0023_003DzfOCoHG40Z_ED.AddSegmentToToolpath(_0023_003Dz5Je5VG8_003D.EndXGlobal, _0023_003Dz5Je5VG8_003D.EndYGlobal, _0023_003DzzZAy6Tk_003D);
		}
	}

	private sealed class _0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D
	{
		public int _0023_003Dz3cCeXbQ_003D;

		public _0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D()
		{
			_ = 7;
			if (7 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzIQufLlDvAhomc5sXEjnrLUcB9vpa(Attribute _0023_003DzLDWhkEg_003D)
		{
			_ = 1;
			if (3 == 0)
			{
			}
			int index = _0023_003DzLDWhkEg_003D.Index;
			_ = 5;
			if (8 == 0)
			{
			}
			if (index == _0023_003Dz3cCeXbQ_003D)
			{
				_ = 6;
				if (false)
				{
				}
				return _0023_003DzLDWhkEg_003D.Value.UPar == 1.0;
			}
			return false;
		}
	}

	private sealed class _0023_003DzjVm26_sXTvRLCw6B1lgLOzU_003D
	{
		public int _0023_003Dz_z_7_0024qk_003D;

		public _0023_003DzjVm26_sXTvRLCw6B1lgLOzU_003D()
		{
			_ = 4;
			if (7 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzFqOExXivgbMkP8_0024Wng9eTaW1xYSzpQ8NNw_003D_003D(StandardBoringHead _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D)
		{
			_ = 3;
			if (6 == 0)
			{
			}
			int headNumber = _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D.HeadNumber;
			_ = -1;
			if (8 == 0)
			{
			}
			return headNumber == _0023_003Dz_z_7_0024qk_003D;
		}

		internal bool _0023_003DzDM3_cpF0kTRFe3RLKb5oB6GC7I17XN1Ctg_003D_003D(BrcBoringHead _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D)
		{
			_ = 1;
			if (2 == 0)
			{
			}
			int headNumber = _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D.HeadNumber;
			_ = 7;
			if (-1 == 0)
			{
			}
			return headNumber == _0023_003Dz_z_7_0024qk_003D;
		}
	}

	private sealed class _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D
	{
		public double _0023_003DzX_0024LNB5PBcbRD;

		public double _0023_003DzAlJgo7FQaWc9;

		public double _0023_003Dz5iCIeOr_0024CF1u;

		public _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D()
		{
			_ = 6;
			if (6 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzdKICZPDjQ4QXP7itQg_003D_003D(Workplane _0023_003DzwwE3LYY_003D)
		{
			_ = 7;
			if (3 == 0)
			{
			}
			double originX = _0023_003DzwwE3LYY_003D.OriginX;
			_ = 1;
			if (3 == 0)
			{
			}
			if (originX == _0023_003DzX_0024LNB5PBcbRD)
			{
				_ = 8;
				if (7 == 0)
				{
				}
				if (_0023_003DzwwE3LYY_003D.OriginY == _0023_003DzAlJgo7FQaWc9)
				{
					return _0023_003DzwwE3LYY_003D.OriginZ == _0023_003Dz5iCIeOr_0024CF1u;
				}
			}
			return false;
		}
	}

	private sealed class _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D
	{
		public int _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D;

		public _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D()
		{
			_ = 4;
			if (5 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzA2pYLsxo736N_0024Ma_0024yL4Gn1u0LYLmbqZldP7n4Ec_003D(Spindle _0023_003DzBj__0024aOE_003D)
		{
			_ = 4;
			if (4 == 0)
			{
			}
			int spindleNumber = _0023_003DzBj__0024aOE_003D.SpindleNumber;
			_ = 8;
			if (6 == 0)
			{
			}
			return spindleNumber == _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D;
		}
	}

	public double ActiveBX;

	public double ActiveBY;

	public double ActiveBZ;

	public double ActiveHeaderBX;

	public double ActiveHeaderBY;

	public double ActiveHeaderBZ;

	public string ActiveTools;

	public string CurrentMaestroTool;

	public string CurrentMaestroHead;

	public double ActiveXTransformation;

	public double ActiveYTransformation;

	public double ActiveZTransformation;

	public double ActiveEROT;

	public double? ActiveLAMP;

	public double ActiveSTOP;

	public double ActiveLB;

	public bool IsSubProgramOriginSet;

	public Edge EdgeLoaded;

	public double ZMAC;

	public double OPROG;

	public double FLD;

	public double ActiveA;

	public double ActiveB;

	public int? ActiveAuxiliaryHoodPosition;

	public bool IsAuxiliaryHoodPositionModal;

	private int _0023_003DzI9mONB48i_0024Gw;

	private _0023_003Dz8aCtsOL3Lms_0024wcOalJ_EjerVLJqiepAMBUVwV5Q_003D _0023_003DzmNgNJnU_003D;

	private double[] _0023_003Dznrery1Y_003D;

	private XilogProfile _0023_003DzVsFfuwI_003D;

	private double _0023_003DzOiU6nPw_003D;

	private double _0023_003DzUUAAhCE_003D;

	private double _0023_003Dzpl6fb1o_003D;

	private bool _0023_003DzSQkjbRxUPIwq;

	private double _0023_003DzY7q55ibyTX_n;

	private static Dictionary<int, string> _0023_003DzDfV1Q2OnV_0024RM;

	private List<XilogProfile> _0023_003Dz6O8F0jNAY_0024c7;

	private long _0023_003DzFSKYAWY_003D;

	private int _0023_003DzA_BQx28_003D;

	private string _0023_003DzWnymPSD0JHj_0024;

	private bool _0023_003Dz2uDCrsHQoMigMdBBTA_003D_003D;

	private long _0023_003DzZfoKzRk_003D;

	private int _0023_003DzqJGQcT0_003D;

	private List<XilogGSetParams> _0023_003DzF5TXIn7g4cW5;

	private double _0023_003DzRy81lOpVNjEq;

	private double _0023_003Dz7AJiHJhGO7iA;

	private string _0023_003DzaepqoE8sVHIF;

	private List<StandardBoringHead> _0023_003DzPCtep8zMf_fPxc_yok0LD_I_003D;

	private static string _0023_003DzAZi_0024PtL9uOWi5dOW03moNZQ_003D;

	private List<BrcBoringHead> _0023_003DzXcsaA3EZZEeCUSgq0CDRd4DmLbTh;

	private double _0023_003DzLFGlmsZrI2xL;

	private Edge _0023_003DzG4_YXQjbwey_0024;

	private StaticOptions _0023_003DzHD5fHZnBd7Nm;

	private double? _0023_003Dz4T0tvr1Sohar;

	private TypeOfProcess _0023_003DzANMGQJiNz3Yo;

	private Dictionary<string, string> _0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5;

	private Dictionary<string, Dictionary<string, string>> _0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D;

	private Dictionary<string, Dictionary<string, NatureOfParameter>> _0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer;

	private Dictionary<string, Dictionary<string, double>> _0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D;

	private WorkPlaneCategory _0023_003Dz2z_U3NnO_6AmnCuicfpA010_003D;

	private MachineCategory _0023_003Dz5YM4N3AL4caK;

	private string _0023_003DzTJuyZiS0qOKz;

	private Dictionary<string, LeadInOut> _0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D;

	private bool _0023_003Dzmkh2mynWK8RD;

	public XilogProgram(IScriptingReportServices reportServices, ProjectInterface projectInterface, ToolInterface toolInterface, ConfigurationInterface configurationInterface, EdgeInterface edgeInterface, ReferenceKey workplanID, ReferenceKey workpieceID, ReferenceKey planeID, bool isSubprogram, int priority, StaticOptions staticOptions = null)
	{
		_0023_003Dz8aCtsOL3Lms_0024wcOalJ_EjerVLJqiepAMBUVwV5Q_003D _0023_003Dz8aCtsOL3Lms_0024wcOalJ_EjerVLJqiepAMBUVwV5Q_003D = new _0023_003Dz8aCtsOL3Lms_0024wcOalJ_EjerVLJqiepAMBUVwV5Q_003D();
		if (8u != 0)
		{
			_0023_003DzmNgNJnU_003D = _0023_003Dz8aCtsOL3Lms_0024wcOalJ_EjerVLJqiepAMBUVwV5Q_003D;
		}
		Dictionary<string, LeadInOut> dictionary = new Dictionary<string, LeadInOut>();
		if (2u != 0)
		{
			_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D = dictionary;
		}
		base._002Ector(reportServices, projectInterface, toolInterface, edgeInterface, configurationInterface, null, workplanID, workpieceID, planeID, isSubprogram, priority);
		WorkPlaneCategory activeWorkPlaneCategory = ConfigurationFixtureSetup.GetActiveWorkPlaneCategory(_configurationInterface.GetConfigurationMachine(clone: false), _projectInterface);
		if (3u != 0)
		{
			_0023_003Dz2z_U3NnO_6AmnCuicfpA010_003D = activeWorkPlaneCategory;
		}
		Machine configurationMachine = _configurationInterface.GetConfigurationMachine();
		Machine machine = default(Machine);
		if (0 == 0)
		{
			machine = configurationMachine;
		}
		if (machine != null)
		{
			_0023_003Dz5YM4N3AL4caK = machine.MachineCategory;
		}
		_0023_003DzFbeHwXDeRUWK();
		_0023_003DzRwum0tnzWhlH(configurationInterface);
		if (staticOptions != null)
		{
			_0023_003DzHD5fHZnBd7Nm = new StaticOptions(staticOptions);
		}
		_0023_003Dz6O8F0jNAY_0024c7 = new List<XilogProfile>();
		_0023_003DzF5TXIn7g4cW5 = new List<XilogGSetParams>();
		_0023_003DzPCtep8zMf_fPxc_yok0LD_I_003D = new List<StandardBoringHead>();
		_0023_003DzXcsaA3EZZEeCUSgq0CDRd4DmLbTh = new List<BrcBoringHead>();
		if (_configurationInterface != null)
		{
			_0023_003DzPCtep8zMf_fPxc_yok0LD_I_003D = _configurationInterface.GetList<StandardBoringHead>();
			_0023_003DzXcsaA3EZZEeCUSgq0CDRd4DmLbTh = _configurationInterface.GetList<BrcBoringHead>();
		}
		if (workpieceID != null && workpieceID.IsValid)
		{
			MachiningParameters machiningParameters = projectInterface.GetMachiningParameters();
			if (machiningParameters is XilogHeaderParameters)
			{
				XilogHeaderParameters xilogHeaderParameters = machiningParameters as XilogHeaderParameters;
				_0023_003DzA_BQx28_003D = xilogHeaderParameters.Repetitions;
			}
			int value = ((!AppInfo.CurrentOptions<UI00Options>().PostOptions.IsAreaScm) ? 1 : 0);
			int value2 = ((!AppInfo.CurrentOptions<UI00Options>().PostOptions.IsZetaScm) ? 1 : (-1));
			MODE(value, value2);
			_0023_003DzRy81lOpVNjEq = 0.0;
			_0023_003Dz7AJiHJhGO7iA = 0.0;
		}
		else
		{
			_0023_003Dznrery1Y_003D = new double[1024];
		}
	}

	static XilogProgram()
	{
		Dictionary<int, string> obj = new Dictionary<int, string>
		{
			{
				1,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611)
			},
			{
				2,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577)
			},
			{
				3,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590)
			},
			{
				4,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565)
			},
			{
				5,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553)
			},
			{
				6,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601)
			}
		};
		if (0 == 0)
		{
			_0023_003DzDfV1Q2OnV_0024RM = obj;
		}
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917716632);
		if (0 == 0)
		{
			_0023_003DzAZi_0024PtL9uOWi5dOW03moNZQ_003D = text;
		}
	}

	public void H(double DX, double DY, double DZ, string FLD, string TOOLS, double BX = 0.0, double BY = 0.0, double BZ = 0.0, long? V = null, long T = 0L, int R = 1, int C = 0, string UNIT = "MM", string ENVVAR = "")
	{
		int num = ((UNIT == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715324)) ? 1 : 0);
		if (8u != 0)
		{
			_0023_003Dz2uDCrsHQoMigMdBBTA_003D_003D = (byte)num != 0;
		}
		double num2 = _0023_003Dz9_0024sSLsNoyfJu(DX);
		if (2u != 0)
		{
			DX = num2;
		}
		double num3 = _0023_003Dz9_0024sSLsNoyfJu(DY);
		if (2u != 0)
		{
			DY = num3;
		}
		double num4 = _0023_003Dz9_0024sSLsNoyfJu(DZ);
		if (6u != 0)
		{
			DZ = num4;
		}
		double num5 = _0023_003Dz9_0024sSLsNoyfJu(BX);
		if (5u != 0)
		{
			BX = num5;
		}
		double num6 = _0023_003Dz9_0024sSLsNoyfJu(BY);
		if (uint.MaxValue != 0)
		{
			BY = num6;
		}
		BZ = _0023_003Dz9_0024sSLsNoyfJu(BZ);
		_0023_003DzaepqoE8sVHIF = string.Empty;
		int value = ((!AppInfo.CurrentOptions<UI00Options>().PostOptions.IsAreaScm) ? 1 : 0);
		int value2 = ((!AppInfo.CurrentOptions<UI00Options>().PostOptions.IsZetaScm) ? 1 : (-1));
		MODE(value, value2);
		_0023_003DzOiU6nPw_003D = DX;
		_0023_003DzUUAAhCE_003D = DY;
		_0023_003Dzpl6fb1o_003D = DZ;
		CreateFinishedWorkpieceBox(string.Empty, DX, DY, DZ);
		ActiveBX = BX;
		ActiveBY = BY;
		ActiveBZ = BZ;
		ActiveHeaderBX = BX;
		ActiveHeaderBY = BY;
		ActiveHeaderBZ = BZ;
		SetWorkpieceSetupPosition(BX, BY, BZ, 0.0);
		_0023_003DzFSKYAWY_003D = V ?? 0;
		_0023_003DzWnymPSD0JHj_0024 = FLD;
		_0023_003DzA_BQx28_003D = R;
		_0023_003DzZfoKzRk_003D = T;
		_0023_003DzqJGQcT0_003D = C;
		SetMachiningParameters(_0023_003DzWnymPSD0JHj_0024, _0023_003DzA_BQx28_003D, _0023_003DzFSKYAWY_003D, _0023_003DzZfoKzRk_003D, _0023_003DzqJGQcT0_003D == 1);
		_0023_003DzTJuyZiS0qOKz = (_0023_003DzWnymPSD0JHj_0024.Length.Equals(2) ? _0023_003DzWnymPSD0JHj_0024.Substring(0, 1).ToUpper() : _0023_003DzWnymPSD0JHj_0024.ToUpper());
		_0023_003DzRy81lOpVNjEq = 0.0;
		_0023_003Dz7AJiHJhGO7iA = 0.0;
		_0023_003DzLFGlmsZrI2xL = 20.0;
		ActiveXTransformation = 0.0;
		ActiveYTransformation = 0.0;
		ActiveZTransformation = 0.0;
		IsSubProgramOriginSet = false;
		_0023_003DzSQkjbRxUPIwq = false;
		ActiveAuxiliaryHoodPosition = null;
		IsAuxiliaryHoodPositionModal = false;
		if (!_0023_003Dzdk3_wRkuVl8n() && !_0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D() && !_0023_003Dzs854AHxGxXXFjErcriLOPtQ_003D())
		{
			_0023_003Dzf4KWv5G2dTxk();
		}
	}

	public void C(double C = 0.0, double S = 0.0)
	{
		if (4u != 0)
		{
			CommitPendingProfile();
		}
		double num = _0023_003Dz9_0024sSLsNoyfJu(S);
		if (6u != 0)
		{
			S = num;
		}
		if (_0023_003Dzdk3_wRkuVl8n() && C != 0.0 && _0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
		{
			double num2 = ((C == 2.0) ? 1 : 2);
			if (4u != 0)
			{
				C = num2;
			}
		}
		SetToolCorrection((int)C, S);
	}

	public void F(double F)
	{
		if (0 == 0)
		{
			CommitPendingProfile();
		}
		int num = _0023_003DzEDhq3rDH_ccPyG_xin2hj7Y_003D((int)F);
		int num2;
		if (4u != 0)
		{
			num2 = num;
		}
		if ((_0023_003Dzdk3_wRkuVl8n() || _0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D()) && _0023_003DzTJuyZiS0qOKz[0] == 'J')
		{
			switch (num2)
			{
			case 2:
				if (0 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				num2 = 2;
				break;
			}
		}
		SelectWorkplane(_0023_003DzDfV1Q2OnV_0024RM[num2]);
		_0023_003DzI9mONB48i_0024Gw = num2;
		ActiveXTransformation = 0.0;
		ActiveYTransformation = 0.0;
		ActiveZTransformation = 0.0;
	}

	public void F(double? F)
	{
		double f = (F.HasValue ? F.Value : 1.0);
		if (3u != 0)
		{
			this.F(f);
		}
	}

	public void _M(string N, string P)
	{
		_ = 7;
		if (7 == 0)
		{
		}
		string empty = string.Empty;
		_ = 7;
		if (-1 == 0)
		{
		}
		_ = 5;
		if (2 == 0)
		{
		}
		ExecMacro(empty, N, P);
	}

	public void M(string name, double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? I = null, double? J = null, double? V = null, double? S = null, string T = "", double? F = null, double? C = null, double? K = null, double? P = null, double? Q = null, double? R = null, double? x = null, double? y = null, double? a = null, double? B = null, double? r = null, double? D = null, double? s = null, double? l = null, double? G = null, double? L = null, string N = "")
	{
		try
		{
			if (0 == 0)
			{
				CommitPendingProfile();
			}
			if (!_0023_003Dzdk3_wRkuVl8n() && (name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715313)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715299)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715285)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715266)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715246)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715226)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715205)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715446)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715432)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715416)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715399)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715383)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715370)) || name.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715353))))
			{
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715339);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new object[1] { name };
				if (0 == 0)
				{
					ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
				}
			}
			bool num = _0023_003Dz3qO1jRSvTOjZq6Y8sg_003D_003D(name);
			SelectWorkplane(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611));
			if (4u != 0)
			{
				ActiveXTransformation = 0.0;
			}
			if (0 == 0)
			{
				ActiveYTransformation = 0.0;
			}
			if (3u != 0)
			{
				ActiveZTransformation = 0.0;
			}
			double? num2;
			if (6u != 0)
			{
				num2 = X;
			}
			double activeX = num2 ?? base.ActiveX;
			if (5u != 0)
			{
				base.ActiveX = activeX;
			}
			if (true)
			{
				num2 = Y;
			}
			double activeY = num2 ?? base.ActiveY;
			if (4u != 0)
			{
				base.ActiveY = activeY;
			}
			if (true)
			{
				num2 = Z;
			}
			base.ActiveZ = num2 ?? base.ActiveZ;
			double _0023_003Dzu68XiBs_003D = base.ActiveX;
			double _0023_003DzkCWBd1Y_003D = base.ActiveY;
			double _0023_003DzRvG13dw_003D = base.ActiveZ;
			_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
			if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
			{
				_0023_003DzRvG13dw_003D = 0.0;
			}
			else
			{
				_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
			}
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
			if (!string.IsNullOrEmpty(T))
			{
				_0023_003DzQuQblKN3oz6T(T);
			}
			object[] array = null;
			if (num)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), X);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), Y);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042), Z);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247), A);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034), H);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), E);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018), I);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010), J);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002), V);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432), S);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714994), T);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986), F);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), C);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970), K);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448), P);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962), Q);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714954), R);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946), x);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715194), y);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186), a);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680), B);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178), r);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170), D);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715162), s);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154), l);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), G);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440), L);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138), CurrentMaestroTool);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111), CurrentMaestroHead);
				dictionary.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715088), _0023_003Dzpl6fb1o_003D);
				dictionary = _0023_003DzD10_0024v_JbGaDcpDWgqL0BvT8_003D(name, dictionary);
				Dictionary<string, string> dictionary2 = _0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D[name];
				array = new object[dictionary2.Count];
				object value = null;
				string text = null;
				for (int i = 0; i < dictionary2.Count; i++)
				{
					text = dictionary2.ElementAt(i).Value;
					float result;
					bool result2;
					if (dictionary.TryGetValue(text, out value))
					{
						array[i] = ((value == null) ? ((object)0) : value);
					}
					else if (float.TryParse(text, out result))
					{
						array[i] = result;
					}
					else if (bool.TryParse(text, out result2))
					{
						array[i] = result2;
					}
					else
					{
						array[i] = 0;
					}
				}
			}
			else
			{
				SubProgramInfo info = new SubProgramInfo(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface, null, null, null, 0, null);
				SubProgram subProgram = new ScriptSubProgram(name, info);
				if (subProgram.Parameters.Count > 0)
				{
					array = new object[subProgram.Parameters.Count];
					if (x.HasValue || y.HasValue)
					{
						double _0023_003Dzu68XiBs_003D2 = x ?? double.MinValue;
						double _0023_003DzkCWBd1Y_003D2 = y ?? double.MinValue;
						_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
						x = (x.HasValue ? new double?(_0023_003Dzu68XiBs_003D2) : x);
						y = (y.HasValue ? new double?(_0023_003DzkCWBd1Y_003D2) : y);
					}
					bool flag = !G.HasValue || G.Value != 3.0;
					double? num3 = r;
					if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
					{
						flag = !flag;
						if (num3.HasValue)
						{
							if (num3.Value < 0.0)
							{
								num3 = ABS(num3.Value);
							}
							else
							{
								num3 *= -1.0;
							}
						}
					}
					for (int j = 0; j < subProgram.Parameters.Count; j++)
					{
						SubProgramParameter subProgramParameter = subProgram.Parameters[j];
						if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715078))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, X);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715835))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, Y);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715828))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, Z);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715817))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, A);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715810))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, H);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715799))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, E);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715792))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, I);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715781))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, J);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715774))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, V);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715763))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, S);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715756))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, T);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715745))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, F);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715738))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, C);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715727))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, K);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715720))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, P);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715965))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, Q);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715958))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, R);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715947))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, x);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715940))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, y);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715929))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, a);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715922))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, B);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715911))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, r);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715904))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, D);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715893))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, s);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715886))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, l);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715875))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, G);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715868))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, L);
						}
						else if (subProgramParameter.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715857))
						{
							array[j] = _0023_003Dzjg5H3u8_003D(subProgramParameter, N);
						}
						else
						{
							array[j] = null;
						}
					}
				}
			}
			string empty = string.Empty;
			string text2 = string.Empty;
			if (_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.ContainsKey(name))
			{
				text2 = _0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5[name];
			}
			empty = _projectInterface.GetUniqueName<ScriptSubProgram>(text2);
			CreateMacro(empty, text2, array);
		}
		catch (Exception innerException)
		{
			string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706621);
			string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters2 = new string[2]
			{
				string.Empty,
				name
			};
			ExceptionManager.Throw(localizationKey2, localizationModuleName2, ExceptionType.Exception, innerException, parameters2);
		}
	}

	public void GIN(double? G, double? R = null, double? Q = null, double? V = null)
	{
		if (!G.HasValue || (G.HasValue && G.Value != 1.0 && G.Value != 2.0))
		{
			return;
		}
		bool isQuote;
		if (2u != 0)
		{
			isQuote = true;
		}
		bool isLinear;
		if (6u != 0)
		{
			isLinear = true;
		}
		if (G.HasValue && G.Value == 2.0)
		{
			if (4u != 0)
			{
				isLinear = false;
			}
		}
		if (Q.HasValue && Q.Value == 1.0)
		{
			isQuote = false;
		}
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
		}
		SetApproachStrategy(isLinear, isQuote, R.Value, V);
	}

	public void GOUT(double? G, double? R = null, double? Q = null, double? L = null, double? V = null)
	{
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		if (!G.HasValue || (G.HasValue && G.Value != 1.0 && G.Value != 2.0))
		{
			return;
		}
		bool isQuote;
		if (8u != 0)
		{
			isQuote = true;
		}
		bool isLinear;
		if (4u != 0)
		{
			isLinear = true;
		}
		if (G.HasValue && G.Value == 2.0)
		{
			if (6u != 0)
			{
				isLinear = false;
			}
		}
		if (Q.HasValue && Q.Value == 1.0)
		{
			isQuote = false;
		}
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
		}
		SetRetractStrategy(isLinear, isQuote, R.Value, L.Value, V);
		CommitPendingProfile();
	}

	public void G0(double? X = null, double? Y = null, double? Z = null, string T = "", double? E = null, double? V = null, double? S = null, double? D = null, double? s = null, string N = "", bool skipTransformation = false)
	{
		if (4u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		if (s.HasValue)
		{
			s = _0023_003Dz9_0024sSLsNoyfJu(s.Value);
		}
		if (s.HasValue)
		{
			int correction = base.ActiveToolCorrection.Correction;
			double value = s.Value;
			if (0 == 0)
			{
				SetToolCorrection(correction, value);
			}
		}
		int num = _0023_003DzGXYQvSTndE5W0wzvLgDcN80_003D(base.ActiveToolCorrection.Correction);
		int correction2 = default(int);
		if (0 == 0)
		{
			correction2 = num;
		}
		double overMaterial = base.ActiveToolCorrection.OverMaterial;
		double overMaterial2;
		if (8u != 0)
		{
			overMaterial2 = overMaterial;
		}
		ToolCorrection toolCorrection = new ToolCorrection();
		ToolCorrection toolCorrection2;
		if (7u != 0)
		{
			toolCorrection2 = toolCorrection;
		}
		toolCorrection2.CreateToolCorrection(correction2, overMaterial2);
		double? num3;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num2 = X;
			if (true)
			{
				num3 = num2;
			}
			double activeX = base.ActiveX;
			double num4;
			if (7u != 0)
			{
				num4 = activeX;
			}
			X = num3 + num4;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num5 = Y;
			if (8u != 0)
			{
				num3 = num5;
			}
			double activeY = base.ActiveY;
			double num4;
			if (uint.MaxValue != 0)
			{
				num4 = activeY;
			}
			Y = num3 + num4;
		}
		double? num6 = X;
		if (8u != 0)
		{
			num3 = num6;
		}
		base.ActiveX = num3 ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		if (!skipTransformation)
		{
			_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
			_0023_003DzRvG13dw_003D = (((!(_0023_003DzRvG13dw_003D < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(_0023_003DzRvG13dw_003D > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(_0023_003DzRvG13dw_003D) : 0.0);
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		}
		string _0023_003DzHMoneas_003D = string.Empty;
		string _0023_003DzOiEjdhXyi_A_0024 = string.Empty;
		string _0023_003Dz5dh86BrVaX8U = string.Empty;
		if (_0023_003DzANMGQJiNz3Yo != TypeOfProcess.EdgeBanding)
		{
			CoreTool _0023_003DzyagUmhsbHglp;
			ScmGroup.XCam.MachiningDataModel.Head _0023_003Dz9ybYj_0024UhnI6V;
			if (T != string.Empty)
			{
				_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
				if (_0023_003DzyagUmhsbHglp == null)
				{
					string text = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
					ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, _0023_003DzOiEjdhXyi_A_0024);
				}
				else
				{
					_0023_003DzaepqoE8sVHIF = _toolInterface.GetToolFamily(_0023_003DzyagUmhsbHglp).KindOfToolFamily.ToString();
					if (T != _0023_003DzHMoneas_003D)
					{
						_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
						AddToErrorFile(_errorString);
					}
					ActiveTools = T;
				}
			}
			else
			{
				T = ActiveTools;
				_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
				if (_0023_003DzyagUmhsbHglp == null)
				{
					string text2 = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
					ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text2, _0023_003DzOiEjdhXyi_A_0024);
				}
				else
				{
					_0023_003DzaepqoE8sVHIF = _toolInterface.GetToolFamily(_0023_003DzyagUmhsbHglp).KindOfToolFamily.ToString();
					if (T != _0023_003DzHMoneas_003D)
					{
						_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
						AddToErrorFile(_errorString);
					}
					ActiveTools = T;
				}
			}
			if (_0023_003DzaepqoE8sVHIF != KindOfToolFamily.BladeCuttingTool.ToString() && _0023_003DzaepqoE8sVHIF != KindOfToolFamily.MillingCuttingTool.ToString())
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715487), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, ActiveTools);
			}
		}
		string uniqueName = _projectInterface.GetUniqueName<GeomCompositeCurve>(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715707));
		Polyline polyline = CreatePolyline(uniqueName, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D);
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
			if (base.ActiveLeadInOut == null)
			{
				SetApproachStrategy(isLinear: true, isQuote: true, 0.0, V);
				base.ActiveLeadInOut._0023_003Dz914o0CEhd7ZygAE5IA_003D_003D(_0023_003Dz3keKASA_003D: false);
			}
		}
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 0.0);
		}
		if (EdgeLoaded != null)
		{
			_0023_003DzG4_YXQjbwey_0024 = new Edge(EdgeLoaded);
			EdgeLoaded = null;
		}
		if (_0023_003DzANMGQJiNz3Yo == TypeOfProcess.EdgeBanding)
		{
			_0023_003DzaepqoE8sVHIF = string.Empty;
			_0023_003DzVsFfuwI_003D = new XilogEdgeProfile(polyline, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, V, N, _0023_003DzG4_YXQjbwey_0024);
			if (V.HasValue)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702931), base.ActiveSpeed, 0.0);
			}
		}
		else
		{
			_0023_003DzVsFfuwI_003D = new _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D(base.ActiveWorkplane, polyline, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, V, (int?)E, S, N, T, toolCorrection2, D);
		}
		SelectGeometry(_0023_003DzVsFfuwI_003D.GeometryPath.Name);
		_0023_003DzANMGQJiNz3Yo = TypeOfProcess.NotDefined;
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003Dzo3KHpP8_003D(new _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, (double)(-_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n()) * base.ActiveZ, base.ActiveSpeed));
		}
	}

	public void G1(double? X = null, double? Y = null, double? Z = null, double? V = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		double? num2;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (6u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (8u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (uint.MaxValue != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (2u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double activeZ = base.ActiveZ;
		double num5;
		if (8u != 0)
		{
			num5 = activeZ;
		}
		_ = base.ActiveSpeed;
		double? num6 = X;
		if (3u != 0)
		{
			num2 = num6;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (3u != 0)
		{
			base.ActiveX = activeX2;
		}
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D != null && (_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D) || _0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile)))
		{
			_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num5 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003Dzo3KHpP8_003D(new _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, (double)(-_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n()) * base.ActiveZ, base.ActiveSpeed));
		}
	}

	public void ATP(double? X = null, double? Y = null, double? Z = null, double? G = null, double? V = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		double? num2;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (4u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (5u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (4u != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (2u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double activeZ = base.ActiveZ;
		double num5;
		if (true)
		{
			num5 = activeZ;
		}
		_ = base.ActiveSpeed;
		double? num6 = X;
		if (3u != 0)
		{
			num2 = num6;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (2u != 0)
		{
			base.ActiveX = activeX2;
		}
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
		{
			return;
		}
		int num7 = (int)G.Value;
		if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			switch (num7)
			{
			case 2:
				num7 = 3;
				break;
			case 3:
				num7 = 2;
				break;
			}
		}
		_0023_003DzVsFfuwI_003D.GeometryPath = AddArcTanToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, num7, string.Empty);
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num5 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
	}

	public void G2(double? X = null, double? Y = null, double? Z = null, double? I = null, double? J = null, double? V = null, double? r = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (I.HasValue)
		{
			I = _0023_003Dz9_0024sSLsNoyfJu(I.Value);
		}
		if (J.HasValue)
		{
			J = _0023_003Dz9_0024sSLsNoyfJu(J.Value);
		}
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		double? num2 = default(double?);
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (8u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (5u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (0 == 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (2u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double activeZ = base.ActiveZ;
		double num5;
		if (2u != 0)
		{
			num5 = activeZ;
		}
		_ = base.ActiveSpeed;
		double activeX2 = base.ActiveX;
		double num6;
		if (uint.MaxValue != 0)
		{
			num6 = activeX2;
		}
		double activeY2 = base.ActiveY;
		double num7;
		if (uint.MaxValue != 0)
		{
			num7 = activeY2;
		}
		double? num8 = X;
		if (7u != 0)
		{
			num2 = num8;
		}
		double activeX3 = num2 ?? base.ActiveX;
		if (7u != 0)
		{
			base.ActiveX = activeX3;
		}
		double? num9 = Y;
		if (0 == 0)
		{
			num2 = num9;
		}
		base.ActiveY = num2 ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
		{
			return;
		}
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
		}
		bool flag = true;
		if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			flag = !flag;
		}
		if (I.HasValue && J.HasValue)
		{
			double _0023_003Dzu68XiBs_003D2 = I.Value;
			double _0023_003DzkCWBd1Y_003D2 = J.Value;
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
			if (base.ActiveX == num6 && base.ActiveY == num7)
			{
				double _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D = 0.0;
				double _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D = 0.0;
				_0023_003DzpKAjugZnGow0ycyMGw_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, ref _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, ref _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
			else
			{
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
		}
		else
		{
			double radius = abs(r.Value);
			bool isOver = _0023_003DzOq7VhIzeDL2_0024NM_0024F7jqR_3c_003D(r, _0023_003DzJWP5xwk_003D: true);
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointRadiusToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, radius, flag, isOver, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num5 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
	}

	public void G3(double? X = null, double? Y = null, double? Z = null, double? I = null, double? J = null, double? V = null, double? r = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (I.HasValue)
		{
			I = _0023_003Dz9_0024sSLsNoyfJu(I.Value);
		}
		if (J.HasValue)
		{
			J = _0023_003Dz9_0024sSLsNoyfJu(J.Value);
		}
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		double? num2 = default(double?);
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (4u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (true)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (5u != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (5u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double activeZ = base.ActiveZ;
		double num5;
		if (7u != 0)
		{
			num5 = activeZ;
		}
		_ = base.ActiveSpeed;
		double activeX2 = base.ActiveX;
		double num6 = default(double);
		if (0 == 0)
		{
			num6 = activeX2;
		}
		double activeY2 = base.ActiveY;
		double num7;
		if (4u != 0)
		{
			num7 = activeY2;
		}
		double? num8 = X;
		if (0 == 0)
		{
			num2 = num8;
		}
		double activeX3 = num2 ?? base.ActiveX;
		if (3u != 0)
		{
			base.ActiveX = activeX3;
		}
		double? num9 = Y;
		if (3u != 0)
		{
			num2 = num9;
		}
		base.ActiveY = num2 ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
		{
			return;
		}
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
		}
		bool flag = false;
		if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			flag = !flag;
		}
		if (I.HasValue && J.HasValue)
		{
			double _0023_003Dzu68XiBs_003D2 = I.Value;
			double _0023_003DzkCWBd1Y_003D2 = J.Value;
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
			if (base.ActiveX == num6 && base.ActiveY == num7)
			{
				double _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D = 0.0;
				double _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D = 0.0;
				_0023_003DzpKAjugZnGow0ycyMGw_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, ref _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, ref _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
			else
			{
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
		}
		else
		{
			double radius = abs(r.Value);
			bool isOver = _0023_003DzOq7VhIzeDL2_0024NM_0024F7jqR_3c_003D(r, _0023_003DzJWP5xwk_003D: false);
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointRadiusToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, radius, flag, isOver, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num5 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
	}

	public void IX(double E)
	{
		string axis = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641);
		bool enable = E == 1.0;
		if (uint.MaxValue != 0)
		{
			SetIncrementalInput(axis, enable);
		}
	}

	public void IY(double E)
	{
		string axis = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633);
		bool enable = E == 1.0;
		if (8u != 0)
		{
			SetIncrementalInput(axis, enable);
		}
	}

	public void PL(double? X = null, double? Y = null, double? Z = null, double? Q = null, double? R = null)
	{
		if (2u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (3u != 0)
		{
			SetMirror(mirrorX: false, mirrorY: false, arcInversion: false);
		}
		if (base.ActiveWorkplane.Name.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715691)))
		{
			SelectWorkplane(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611));
		}
		string uniqueName = _projectInterface.GetUniqueName<Plane>(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715674));
		string name;
		if (5u != 0)
		{
			name = uniqueName;
		}
		double _0023_003DzmdFwOB0_003D;
		if (5u != 0)
		{
			_0023_003DzmdFwOB0_003D = 0.0;
		}
		double _0023_003Dzhetey2Q_003D = 0.0;
		if (Q.HasValue || R.HasValue)
		{
			_0023_003DzmdFwOB0_003D = (Q.HasValue ? Q.Value : 0.0);
			_0023_003Dzhetey2Q_003D = (R.HasValue ? R.Value : 0.0);
			_0023_003DzHuSVQLXi_WHs(ref _0023_003DzmdFwOB0_003D, ref _0023_003Dzhetey2Q_003D);
		}
		double _0023_003Dzu68XiBs_003D = X ?? 0.0;
		double _0023_003DzkCWBd1Y_003D = Y ?? 0.0;
		double z = Z ?? 0.0;
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		CreateWorkplane(name, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, z, _0023_003DzmdFwOB0_003D, _0023_003Dzhetey2Q_003D);
	}

	public void MODE(int? O = null, int? Z = null)
	{
		int? num;
		if (7u != 0)
		{
			num = O;
		}
		int num2 = num ?? 0;
		int num3;
		if (2u != 0)
		{
			num3 = num2;
		}
		if (uint.MaxValue != 0)
		{
			num = Z;
		}
		int _0023_003Dzj1Hr4Ih2jAUJ = num ?? (-1);
		_0023_003DzmNgNJnU_003D = new _0023_003Dz8aCtsOL3Lms_0024wcOalJ_EjerVLJqiepAMBUVwV5Q_003D(num3 == 0, _0023_003Dzj1Hr4Ih2jAUJ);
	}

	public void REF(double? DX = null, double? DY = null, double? DZ = null, string FLD = "", double? BX = null, double? BY = null, double? BZ = null)
	{
		if (DX.HasValue)
		{
			DX = _0023_003Dz9_0024sSLsNoyfJu(DX.Value);
		}
		if (DY.HasValue)
		{
			DY = _0023_003Dz9_0024sSLsNoyfJu(DY.Value);
		}
		if (DZ.HasValue)
		{
			DZ = _0023_003Dz9_0024sSLsNoyfJu(DZ.Value);
		}
		if (BX.HasValue)
		{
			BX = _0023_003Dz9_0024sSLsNoyfJu(BX.Value);
		}
		if (BY.HasValue)
		{
			BY = _0023_003Dz9_0024sSLsNoyfJu(BY.Value);
		}
		if (BZ.HasValue)
		{
			BZ = _0023_003Dz9_0024sSLsNoyfJu(BZ.Value);
		}
		if (FLD != string.Empty && FLD != _0023_003DzWnymPSD0JHj_0024)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715653);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715617) };
			if (6u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		double num4 = default(double);
		if (DX.HasValue)
		{
			double? num = DX;
			double? num2;
			if (6u != 0)
			{
				num2 = num;
			}
			double num3 = _0023_003DzOiU6nPw_003D;
			if (4u != 0)
			{
				num4 = num3;
			}
			if (num2 != num4)
			{
				goto IL_01a4;
			}
		}
		if (DY.HasValue)
		{
			double? num5 = DY;
			double? num2;
			if (7u != 0)
			{
				num2 = num5;
			}
			double num6 = _0023_003DzUUAAhCE_003D;
			if (0 == 0)
			{
				num4 = num6;
			}
			if (num2 != num4)
			{
				goto IL_01a4;
			}
		}
		if (DZ.HasValue)
		{
			double? num7 = DZ;
			double? num2;
			if (8u != 0)
			{
				num2 = num7;
			}
			double num8 = _0023_003Dzpl6fb1o_003D;
			if (6u != 0)
			{
				num4 = num8;
			}
			if (num2 != num4)
			{
				goto IL_01a4;
			}
		}
		goto IL_01c4;
		IL_01a4:
		ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715607), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		goto IL_01c4;
		IL_01c4:
		if ((BX.HasValue && BX != ActiveBX) || (BY.HasValue && BY != ActiveBY) || (BZ.HasValue && BZ != ActiveBZ))
		{
			CommitPendingProfile();
			if (!_0023_003Dz1LMLQGeRFamVvQ_Do4BqIWY_003D())
			{
				CreateWorkplan(string.Empty);
			}
			double num9 = (BX.HasValue ? (ActiveHeaderBX + BX.Value) : ActiveBX);
			double num10 = (BY.HasValue ? (ActiveHeaderBY + BY.Value) : ActiveBY);
			double num11 = (BZ.HasValue ? (ActiveHeaderBZ + BZ.Value) : ActiveBZ);
			ActiveBX = num9;
			ActiveBY = num10;
			ActiveBZ = num11;
			SetWorkpieceSetupPosition(num9, num10, num11, 0.0);
		}
	}

	private bool _0023_003Dz1LMLQGeRFamVvQ_Do4BqIWY_003D()
	{
		bool result;
		if (uint.MaxValue != 0)
		{
			result = false;
		}
		if (base.Operations.FindAll(delegate(Operation _0023_003Dz_0024TgJHtw_003D)
		{
			_ = 2;
			if (2 == 0)
			{
			}
			ReferenceKey workplanID = _0023_003Dz_0024TgJHtw_003D.GetWorkplanID();
			_ = 3;
			if (1 == 0)
			{
			}
			return workplanID == base.ActiveWorkplan.ReferenceKey;
		}).Count == 0)
		{
			if (0 == 0)
			{
				result = true;
			}
		}
		return result;
	}

	public void SET(string NAME, double? VALUE = null)
	{
		if (NAME != _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714283))
		{
			if (uint.MaxValue != 0)
			{
				CommitPendingProfile();
			}
		}
		if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714274))
		{
			if (VALUE.HasValue)
			{
				VALUE = _0023_003Dz9_0024sSLsNoyfJu(VALUE.Value);
			}
			double? approachSecurityDistance = VALUE;
			if (8u != 0)
			{
				SetApproachSecurityDistance(approachSecurityDistance);
			}
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714262))
		{
			double jerk = VALUE.Value;
			if (5u != 0)
			{
				SetJerk(jerk);
			}
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714249))
		{
			double jerk3D = VALUE.Value;
			if (4u != 0)
			{
				SetJerk3D(jerk3D);
			}
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714238))
		{
			int? position = (int)VALUE.Value;
			if (8u != 0)
			{
				SetDustpanPosition(position);
			}
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714224))
		{
			double dustpanOffset = VALUE.Value;
			if (4u != 0)
			{
				SetDustpanOffset(dustpanOffset);
			}
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714204))
		{
			SetUnrollHeadMode((int)VALUE.Value);
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714185))
		{
			SetUnrollHeadRadiusMultiplier(VALUE.Value);
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714426))
		{
			_0023_003DzSQkjbRxUPIwq = VALUE.HasValue && VALUE.Value == 1.0;
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714414))
		{
			CreateIso(string.Empty, string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714400), NAME, VALUE.Value), string.Empty);
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714380) || NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714365) || NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714365))
		{
			if (VALUE.HasValue)
			{
				CreateIso(string.Empty, string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714400), NAME, VALUE.Value), string.Empty);
			}
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714354))
		{
			SetBrakes(VALUE.Value.ToString());
		}
		else if (NAME == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714283))
		{
			if (VALUE.HasValue)
			{
				VALUE = _0023_003Dz9_0024sSLsNoyfJu(VALUE.Value);
			}
			SetLateralShift(VALUE.Value);
		}
	}

	public void G5(double? X = null, double? Y = null, double? Z = null, double? V = null, double? G = null, double? L = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		double? num = L;
		double? num2;
		if (true)
		{
			num2 = num;
		}
		double num3 = num2 ?? 1.0;
		double length;
		if (5u != 0)
		{
			length = num3;
		}
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num4 = X;
			if (2u != 0)
			{
				num2 = num4;
			}
			double activeX = base.ActiveX;
			double num5;
			if (uint.MaxValue != 0)
			{
				num5 = activeX;
			}
			X = num2 + num5;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num6 = Y;
			if (uint.MaxValue != 0)
			{
				num2 = num6;
			}
			double activeY = base.ActiveY;
			double num5;
			if (uint.MaxValue != 0)
			{
				num5 = activeY;
			}
			Y = num2 + num5;
		}
		double activeZ = base.ActiveZ;
		double num7 = default(double);
		if (0 == 0)
		{
			num7 = activeZ;
		}
		_ = base.ActiveSpeed;
		double? num8 = X;
		if (true)
		{
			num2 = num8;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (5u != 0)
		{
			base.ActiveX = activeX2;
		}
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		int num9 = (int)G.Value;
		if (G.HasValue && (G.Value == 2.0 || G.Value == 3.0) && _0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			switch (num9)
			{
			case 2:
				num9 = 3;
				break;
			case 3:
				num9 = 2;
				break;
			}
		}
		if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
		{
			return;
		}
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
		}
		if (num9 == 2 || num9 == 3)
		{
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArcTanToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, num9, string.Empty);
		}
		else
		{
			_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentTanToPolyline(length, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num7 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
	}

	public void ROT(double? A = null, double? X = null, double? Y = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		double? num;
		if (true)
		{
			num = A;
		}
		double num2 = num ?? 0.0;
		double angle;
		if (4u != 0)
		{
			angle = num2;
		}
		double? num3 = X;
		if (true)
		{
			num = num3;
		}
		double x = num ?? 0.0;
		double y = Y ?? 0.0;
		SetRotation(angle, x, y, 0.0);
	}

	public void O(double? X = null, double? Y = null, double? Z = null, double? F = null)
	{
		if (_0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D())
		{
			return;
		}
		if (4u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		double? num = X;
		double? num2;
		if (2u != 0)
		{
			num2 = num;
		}
		double num3 = num2 ?? 0.0;
		double num4;
		if (true)
		{
			num4 = num3;
		}
		double? num5 = Y;
		if (0 == 0)
		{
			num2 = num5;
		}
		double num6 = num2 ?? 0.0;
		double num7 = Z ?? 0.0;
		if (!IsSubProgramOriginSet)
		{
			ActiveXTransformation = num4;
			ActiveYTransformation = num6;
			ActiveZTransformation = num7;
			if (F.HasValue)
			{
				int key = _0023_003DzEDhq3rDH_ccPyG_xin2hj7Y_003D((int)F.Value);
				SetTranslation(num4, num6, num7, _0023_003DzDfV1Q2OnV_0024RM[key]);
			}
			else
			{
				REF(null, null, null, string.Empty, X, Y, Z);
			}
		}
		else
		{
			num4 = ActiveXTransformation + num4;
			num6 = ActiveYTransformation + num6;
			num7 = ActiveZTransformation + num7;
			if (F.HasValue)
			{
				int key2 = _0023_003DzEDhq3rDH_ccPyG_xin2hj7Y_003D((int)F.Value);
				SetTranslation(num4, num6, num7, _0023_003DzDfV1Q2OnV_0024RM[key2]);
			}
			else
			{
				SetTranslation(num4, num6, num7, string.Empty);
			}
		}
	}

	public void SX(double? E = null, double? M = null)
	{
		bool num = E.HasValue && E.Value == 1.0;
		bool mirror;
		if (6u != 0)
		{
			mirror = num;
		}
		bool num2 = M.HasValue && M.Value == 1.0;
		bool arcInversion;
		if (true)
		{
			arcInversion = num2;
		}
		if (3u != 0)
		{
			SetMirrorX(mirror, arcInversion);
		}
	}

	public void SY(double? E = null, double? M = null)
	{
		bool num = E.HasValue && E.Value == 1.0;
		bool mirror;
		if (2u != 0)
		{
			mirror = num;
		}
		bool num2 = M.HasValue && M.Value == 1.0;
		bool arcInversion;
		if (5u != 0)
		{
			arcInversion = num2;
		}
		if (6u != 0)
		{
			SetMirrorY(mirror, arcInversion);
		}
	}

	public void ATPR(double? X = null, double? Y = null, double? Z = null, double? H = null, double? G = null, double? V = null, double? Q = null)
	{
		if (X.HasValue)
		{
			_ = 7;
			if (8 == 0)
			{
			}
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			_ = 2;
			if (5 == 0)
			{
			}
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			_ = 3;
			if (1 == 0)
			{
			}
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		throw new NotImplementedException();
	}

	public double NUMTOOLS(string value)
	{
		double result;
		if (3u != 0)
		{
			result = 0.0;
		}
		if (!string.IsNullOrEmpty(value))
		{
			double num = value.Replace('\t', ' ').Trim().Split(' ')
				.Length;
			if (true)
			{
				result = num;
			}
		}
		return result;
	}

	public string GETTOOL(string value, int index)
	{
		if (!string.IsNullOrEmpty(value))
		{
			string[] array = value.Replace('\t', ' ').Trim().Split(' ');
			string[] array2;
			if (true)
			{
				array2 = array;
			}
			if (index >= 0 && index < array2.Length)
			{
				return array2[index];
			}
		}
		return string.Empty;
	}

	public string GETTOOL(string value, double index)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		_ = 5;
		if (2 == 0)
		{
		}
		_ = 8;
		if (3 == 0)
		{
		}
		return GETTOOL(value, (int)index);
	}

	public double TOOLPAR(string tool, int index)
	{
		return 0.0;
	}

	public double TLRAD(string tool)
	{
		CoreTool coreTool = _0023_003Dzj3y9w9ywUQcu(tool);
		CoreTool coreTool2;
		if (7u != 0)
		{
			coreTool2 = coreTool;
		}
		if (!(coreTool2 != null))
		{
			return 0.0;
		}
		double? overallAssemblyDiameter = ToolMethods.GetOverallAssemblyDiameter(coreTool2);
		double? num;
		if (4u != 0)
		{
			num = overallAssemblyDiameter;
		}
		return num.Value / 2.0;
	}

	public double TLLEN(string tool)
	{
		CoreTool coreTool = _0023_003Dzj3y9w9ywUQcu(tool);
		CoreTool coreTool2;
		if (8u != 0)
		{
			coreTool2 = coreTool;
		}
		if (!(coreTool2 != null))
		{
			return 0.0;
		}
		double? overallAssemblyLength = ToolMethods.GetOverallAssemblyLength(coreTool2);
		double? num;
		if (true)
		{
			num = overallAssemblyLength;
		}
		return num.Value;
	}

	public double TLURAD(string tool)
	{
		CoreTool coreTool = _0023_003Dzj3y9w9ywUQcu(tool);
		CoreTool coreTool2;
		if (7u != 0)
		{
			coreTool2 = coreTool;
		}
		if (!(coreTool2 != null))
		{
			return 0.0;
		}
		double? diameter = ToolMethods.GetDiameter(coreTool2);
		double? num;
		if (2u != 0)
		{
			num = diameter;
		}
		return num.Value / 2.0;
	}

	public double TLULEN(string tool)
	{
		CoreTool coreTool = _0023_003Dzj3y9w9ywUQcu(tool);
		CoreTool coreTool2;
		if (2u != 0)
		{
			coreTool2 = coreTool;
		}
		if (!(coreTool2 != null))
		{
			return 0.0;
		}
		double? sinkingLength = ToolMethods.GetSinkingLength(coreTool2);
		double? num;
		if (3u != 0)
		{
			num = sinkingLength;
		}
		return num.Value;
	}

	private CoreTool _0023_003Dzj3y9w9ywUQcu(string _0023_003DzqmiDBVY_003D)
	{
		string empty = string.Empty;
		string Tfirst;
		if (7u != 0)
		{
			Tfirst = empty;
		}
		string empty2 = string.Empty;
		string ToolNum = default(string);
		if (0 == 0)
		{
			ToolNum = empty2;
		}
		string empty3 = string.Empty;
		string HeadNum;
		if (8u != 0)
		{
			HeadNum = empty3;
		}
		ToolInterface.GetTinfo(_0023_003DzqmiDBVY_003D, isExtendedNotation: false, ref Tfirst, ref ToolNum, ref HeadNum);
		return _toolInterface.GetToolInfo(ToolNum, _0023_003Dzilu43q8Cm59l(Tfirst));
	}

	public void PRINT(string message)
	{
	}

	public void PRINT(string message, params object[] par)
	{
	}

	public void TA(double? X = null, double? Y = null, double? G = null, double? Q = null, string T = "")
	{
		if (0 == 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		double? num2 = default(double?);
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (0 == 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (true)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (8u != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (6u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double? num5 = X;
		if (4u != 0)
		{
			num2 = num5;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (uint.MaxValue != 0)
		{
			base.ActiveX = activeX2;
		}
		double? num6 = Y;
		if (4u != 0)
		{
			num2 = num6;
		}
		base.ActiveY = num2 ?? base.ActiveY;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		string _0023_003DzHMoneas_003D = string.Empty;
		string _0023_003DzOiEjdhXyi_A_0024 = string.Empty;
		string _0023_003Dz5dh86BrVaX8U = string.Empty;
		CoreTool _0023_003DzyagUmhsbHglp;
		ScmGroup.XCam.MachiningDataModel.Head _0023_003Dz9ybYj_0024UhnI6V;
		if (T != string.Empty)
		{
			_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
			if (_0023_003DzyagUmhsbHglp == null)
			{
				string text = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, _0023_003DzOiEjdhXyi_A_0024);
			}
			else
			{
				if (T != _0023_003DzHMoneas_003D)
				{
					_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
					AddToErrorFile(_errorString);
				}
				ActiveTools = T;
			}
		}
		else
		{
			T = ActiveTools;
			_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
			if (_0023_003DzyagUmhsbHglp == null)
			{
				string text2 = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text2, _0023_003DzOiEjdhXyi_A_0024);
			}
			else
			{
				if (T != _0023_003DzHMoneas_003D)
				{
					_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
					AddToErrorFile(_errorString);
				}
				ActiveTools = T;
			}
		}
		string value = _toolInterface.GetToolPropertyValue(_0023_003DzyagUmhsbHglp.Key, KindOfToolProperty.Name).Value;
		CreateWorkPieceProbing(string.Empty, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, value, _0023_003Dz9ybYj_0024UhnI6V.Number.ToString(), G.HasValue ? ((int)G.Value) : 0, Q.HasValue ? ((int)Q.Value) : 0);
	}

	public void ISO(string I = "")
	{
		if (6u != 0)
		{
			CommitPendingProfile();
		}
		if (!string.IsNullOrEmpty(I))
		{
			CreateIso(string.Empty, I, string.Empty, isXiso: false);
		}
	}

	public void XT(double? G = null, string N = "")
	{
		if (4u != 0)
		{
			CommitPendingProfile();
		}
		if (N != string.Empty)
		{
			string errorString = LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714342), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990));
			if (3u != 0)
			{
				_errorString = errorString;
			}
			string errorString2 = _errorString;
			if (uint.MaxValue != 0)
			{
				AddToErrorFile(errorString2);
			}
		}
		else if (G.HasValue)
		{
			string _0023_003DzHMoneas_003D = string.Empty;
			string _0023_003DzOiEjdhXyi_A_0024 = string.Empty;
			string _0023_003Dz5dh86BrVaX8U = string.Empty;
			_0023_003DzsVv55tTke5wMx51iqw_003D_003D(G.ToString(), ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out var _0023_003DzyagUmhsbHglp, out var _);
			if (_0023_003DzyagUmhsbHglp == null)
			{
				string text = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, _0023_003DzOiEjdhXyi_A_0024);
				return;
			}
			if (G.ToString() != _0023_003DzHMoneas_003D)
			{
				_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
				AddToErrorFile(_errorString);
			}
			ActiveTools = G.ToString();
		}
		else
		{
			ActiveTools = string.Empty;
		}
	}

	public void XBRAKE(string N = "")
	{
		if (2u != 0)
		{
			CommitPendingProfile();
		}
		if (true)
		{
			SetBrakes(N);
		}
	}

	public void XBLOWER(int? E = null, string T = "")
	{
	}

	public void XSP(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? B = null, double? D = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (A.HasValue)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714023) };
			if (true)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
			return;
		}
		double activeX = base.ActiveX;
		double _0023_003Dzu68XiBs_003D;
		if (5u != 0)
		{
			_0023_003Dzu68XiBs_003D = activeX;
		}
		double activeY = base.ActiveY;
		double _0023_003DzkCWBd1Y_003D;
		if (3u != 0)
		{
			_0023_003DzkCWBd1Y_003D = activeY;
		}
		Workplane activeWorkplane = base.ActiveWorkplane;
		if (5u != 0)
		{
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, activeWorkplane);
		}
		_ = base.ActiveZ;
		_ = base.ActiveSpeed;
		double? num = X;
		double? num2;
		if (3u != 0)
		{
			num2 = num;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (true)
		{
			base.ActiveX = activeX2;
		}
		double? num3 = Y;
		if (6u != 0)
		{
			num2 = num3;
		}
		double activeY2 = num2 ?? base.ActiveY;
		if (5u != 0)
		{
			base.ActiveY = activeY2;
		}
		double? num4 = Z;
		if (5u != 0)
		{
			num2 = num4;
		}
		double activeZ = num2 ?? base.ActiveZ;
		if (uint.MaxValue != 0)
		{
			base.ActiveZ = activeZ;
		}
		double _0023_003Dzu68XiBs_003D2 = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D2 = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
		B = B ?? 0.0;
		D = D ?? 0.0;
		if (B >= 360.0 || B <= -360.0 || A >= 360.0 || A <= -360.0)
		{
			if (B >= 360.0 || B <= -360.0)
			{
				int num5 = (int)(B / 360.0).Value;
				double num6 = (B / 360.0).Value - (double)num5;
				B = 360.0 * num6;
			}
			if (A >= 360.0 || A <= -360.0)
			{
				int num5 = (int)(A / 360.0).Value;
				double num6 = (A / 360.0).Value - (double)num5;
				A = 360.0 * num6;
			}
		}
		double num7 = (B - 180.0).Value;
		double num8 = (B - 360.0).Value;
		double num9 = (B + 180.0).Value;
		double num10 = (B + 360.0).Value;
		if (D == B || D == num7 || D == num8 || D == num9 || D == num10)
		{
			_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(_0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, string.Empty);
			_0023_003DzBzxGAl03YF3F(V);
			if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
			{
				(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003Dzo3KHpP8_003D(new _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D(_0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, (double)(-_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n()) * base.ActiveZ, base.ActiveSpeed));
			}
			return;
		}
		if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			B = 0.0 - B;
			D = 0.0 - D;
		}
		double num11 = _0023_003Dzu68XiBs_003D;
		double num12 = _0023_003DzkCWBd1Y_003D;
		double num13 = double.MinValue;
		double num14 = _0023_003Dzu68XiBs_003D2;
		double num15 = _0023_003DzkCWBd1Y_003D2;
		double num16 = double.MinValue;
		double num17 = double.MinValue;
		double num18 = double.MinValue;
		num13 = Math.Tan(B.Value / (180.0 / Math.PI));
		num16 = Math.Tan(D.Value / (180.0 / Math.PI));
		if (B == 90.0 || B == -90.0 || B == 270.0 || B == -270.0)
		{
			num17 = _0023_003Dzu68XiBs_003D;
			num18 = num16 * (num17 - num14) + num15;
		}
		else if (D == 90.0 || D == -90.0 || D == 270.0 || D == -270.0)
		{
			num17 = num14;
			num18 = num13 * (num17 - num11) + num12;
		}
		else if (B != 90.0 && B != -90.0 && B != 270.0 && B != -270.0 && D != 90.0 && D != -90.0 && D != 270.0 && D != -270.0)
		{
			num17 = (num16 * num14 - num15 - num13 * num11 + num12) / (num16 - num13);
			num18 = num13 * (num17 - num11) + num12;
		}
		_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(num17, num18, string.Empty);
		_0023_003DzBzxGAl03YF3F(V);
		_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(num14, num15, string.Empty);
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003Dzo3KHpP8_003D(new _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D(num17, num18, (double)(-_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n()) * base.ActiveZ, base.ActiveSpeed));
		}
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003Dzo3KHpP8_003D(new _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D(num14, num15, (double)(-_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n()) * base.ActiveZ, base.ActiveSpeed));
		}
	}

	public void XN(double? X = null, double? Y = null, double? Q = null, double? speed = null, double? spindleEnable = null, double? tool = null)
	{
		if (2u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672);
		string tool2 = default(string);
		if (0 == 0)
		{
			tool2 = text;
		}
		if (tool.HasValue && tool.Value != 0.0)
		{
			string empty = string.Empty;
			string _0023_003DzgKk_6RWNW19R;
			if (3u != 0)
			{
				_0023_003DzgKk_6RWNW19R = empty;
			}
			string empty2 = string.Empty;
			string _0023_003DzXxDWvs0pMGW;
			if (5u != 0)
			{
				_0023_003DzXxDWvs0pMGW = empty2;
			}
			string _0023_003DzXmpvTagHx2Y = string.Empty;
			string text2 = Convert.ToString((int)tool.Value);
			_0023_003DzroT_0024CHIrHrV3(text2, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
			CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
			if (coreTool == null)
			{
				string text3 = (_0023_003DzXmpvTagHx2Y.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text3, _0023_003DzXxDWvs0pMGW);
			}
			else
			{
				if (text2 != _0023_003DzgKk_6RWNW19R)
				{
					_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzVsFfuwI_003D.Name);
					AddToErrorFile(_errorString);
				}
				tool2 = coreTool.Name;
			}
		}
		CreateNullOperation(string.Empty, X, Y, Q, speed, (spindleEnable.HasValue && spindleEnable != 0.0) ? true : false, tool2);
	}

	public void XL2P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? B = null, double? L = null, bool skipTransformation = false)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		if (A.HasValue)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714014) };
			if (4u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
			return;
		}
		if ((!X.HasValue || Y.HasValue || B.HasValue || L.HasValue) && (X.HasValue || !Y.HasValue || B.HasValue || L.HasValue) && (!X.HasValue || !Y.HasValue))
		{
			if (B.HasValue && (X.HasValue || Y.HasValue))
			{
				if (X.HasValue)
				{
					double? num = X;
					double? num2;
					if (3u != 0)
					{
						num2 = num;
					}
					double num3 = Math.Tan(B.Value / (180.0 / Math.PI));
					double num4;
					if (2u != 0)
					{
						num4 = num3;
					}
					double? obj = num2 * num4;
					if (true)
					{
						Y = obj;
					}
				}
				else
				{
					double? num5 = Y;
					double? num2;
					if (5u != 0)
					{
						num2 = num5;
					}
					double num6 = Math.Tan((90.0 - B.Value) / (180.0 / Math.PI));
					double num4 = default(double);
					if (0 == 0)
					{
						num4 = num6;
					}
					double? obj2 = num2 * num4;
					if (uint.MaxValue != 0)
					{
						X = obj2;
					}
				}
			}
			else if (B.HasValue && L.HasValue)
			{
				double? num7 = L;
				double? num2;
				if (5u != 0)
				{
					num2 = num7;
				}
				double num8 = Math.Cos(B.Value / (180.0 / Math.PI));
				double num4;
				if (true)
				{
					num4 = num8;
				}
				double? obj3 = num2 * num4;
				if (4u != 0)
				{
					X = obj3;
				}
				Y = L * Math.Sin(B.Value / (180.0 / Math.PI));
			}
		}
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			X += base.ActiveX;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			Y += base.ActiveY;
		}
		double activeZ = base.ActiveZ;
		_ = base.ActiveSpeed;
		base.ActiveX = X ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		if (!skipTransformation)
		{
			_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
			if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
			{
				_0023_003DzRvG13dw_003D = 0.0;
			}
			else
			{
				_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
			}
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		}
		if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
		{
			return;
		}
		_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, string.Empty);
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (activeZ != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003Dzo3KHpP8_003D(new _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, (double)(-_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n()) * base.ActiveZ, base.ActiveSpeed));
		}
	}

	public void XL2PP(double? X = null, double? Y = null, double? Z = null, double? D = null, double? S = null, double? L = null, double? V = null, double? s = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		if (S.HasValue)
		{
			S = _0023_003Dz9_0024sSLsNoyfJu(S.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		double activeX = base.ActiveX;
		double num;
		if (8u != 0)
		{
			num = activeX;
		}
		double activeY = base.ActiveY;
		double num2;
		if (uint.MaxValue != 0)
		{
			num2 = activeY;
		}
		double activeZ = base.ActiveZ;
		double num3;
		if (6u != 0)
		{
			num3 = activeZ;
		}
		double? x = X;
		double? y = Y;
		double? z = Z;
		double? l = L;
		if (8u != 0)
		{
			XL2P(x, y, z, null, V, null, l);
		}
		if (D.HasValue && S.HasValue && L.HasValue)
		{
			double _0023_003Dzkc3hMRhb09c = SQRT(POW(base.ActiveX - num, 2.0) + POW(base.ActiveY - num2, 2.0) + POW(base.ActiveZ - num3, 2.0));
			double value = D.Value;
			double value2 = S.Value;
			double value3 = L.Value;
			_0023_003DzvQuSaNXlxisu(_0023_003Dzkc3hMRhb09c, value, value2, value3);
		}
	}

	public void XARP(double? X = null, double? Y = null, double? Z = null, double? r = null, double? D = null, double? S = null, double? L = null, double? G = null, double? V = null, double? s = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		if (S.HasValue)
		{
			S = _0023_003Dz9_0024sSLsNoyfJu(S.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		double activeX = base.ActiveX;
		double num;
		if (7u != 0)
		{
			num = activeX;
		}
		double activeY = base.ActiveY;
		double num2;
		if (true)
		{
			num2 = activeY;
		}
		double activeZ = base.ActiveZ;
		double num3;
		if (5u != 0)
		{
			num3 = activeZ;
		}
		double? x = X;
		double? y = Y;
		double? z = Z;
		double? r2 = r;
		if (0 == 0)
		{
			XAR(x, y, z, null, V, r2, G);
		}
		if (D.HasValue && S.HasValue && L.HasValue)
		{
			double _0023_003Dzkc3hMRhb09c = SQRT(POW(base.ActiveX - num, 2.0) + POW(base.ActiveY - num2, 2.0) + POW(base.ActiveZ - num3, 2.0));
			double value = D.Value;
			double value2 = S.Value;
			double value3 = L.Value;
			_0023_003DzvQuSaNXlxisu(_0023_003Dzkc3hMRhb09c, value, value2, value3);
		}
	}

	public void LONG(double? X = null, double? Y = null, double? x = null, double? Z = null, double? a = null, double? s = null, double? I = null, double? G = null, double? E = null)
	{
		if (!_0023_003Dzdk3_wRkuVl8n())
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715339);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714001) };
			if (7u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (x.HasValue)
		{
			x = _0023_003Dz9_0024sSLsNoyfJu(x.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (s.HasValue)
		{
			s = _0023_003Dz9_0024sSLsNoyfJu(s.Value);
		}
		if (!X.HasValue)
		{
			X = -10.0;
		}
		if (!Y.HasValue)
		{
			Y = _0023_003DzUUAAhCE_003D - 10.0;
		}
		if (!x.HasValue)
		{
			x = _0023_003DzOiU6nPw_003D + 10.0;
		}
		if (!Z.HasValue)
		{
			Z = 0.0;
		}
		if (!I.HasValue)
		{
			I = 0.0;
		}
		if (!G.HasValue)
		{
			G = 1.0;
		}
		if (!a.HasValue)
		{
			a = 0.0;
		}
		if (!s.HasValue)
		{
			s = 500.0;
		}
		if (3u != 0)
		{
			CommitPendingProfile();
		}
		double? num = X;
		double? num2;
		if (true)
		{
			num2 = num;
		}
		double activeX = num2 ?? base.ActiveX;
		if (true)
		{
			base.ActiveX = activeX;
		}
		double? num3 = Y;
		if (true)
		{
			num2 = num3;
		}
		double activeY = num2 ?? base.ActiveY;
		if (8u != 0)
		{
			base.ActiveY = activeY;
		}
		double? num4 = Z;
		if (true)
		{
			num2 = num4;
		}
		double activeZ = num2 ?? base.ActiveZ;
		if (4u != 0)
		{
			base.ActiveZ = activeZ;
		}
		double activeX2 = base.ActiveX;
		double _0023_003Dzu68XiBs_003D;
		if (8u != 0)
		{
			_0023_003Dzu68XiBs_003D = activeX2;
		}
		double activeY2 = base.ActiveY;
		double _0023_003DzkCWBd1Y_003D;
		if (6u != 0)
		{
			_0023_003DzkCWBd1Y_003D = activeY2;
		}
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		_0023_003DzRvG13dw_003D = (((!(_0023_003DzRvG13dw_003D < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(_0023_003DzRvG13dw_003D > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(_0023_003DzRvG13dw_003D) : 0.0);
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		double _0023_003Dzu68XiBs_003D2 = x.Value;
		double _0023_003DzkCWBd1Y_003D2 = base.ActiveY;
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
		double num5 = ABS(_0023_003Dzu68XiBs_003D - _0023_003Dzu68XiBs_003D2);
		if (!(num5 > 0.0))
		{
			return;
		}
		List<MachiningTool> tools = _toolInterface.GetTools(KindOfToolFamily.BladeCuttingTool);
		if (tools.Count <= 0)
		{
			return;
		}
		string t = string.Empty;
		bool flag = false;
		foreach (MachiningTool item in tools)
		{
			XilogToolKey xilogToolKey = ToolMethods.GetXilogToolKey(item);
			flag = xilogToolKey.KindOfTool == XilogToolKey.KindOfOriginTool.XilogBoringUnitTool;
			if (flag)
			{
				t = xilogToolKey.Key.ToString();
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		if (G.Value == 1.0)
		{
			double num6 = _0023_003Dzu68XiBs_003D;
			_0023_003Dzu68XiBs_003D = _0023_003Dzu68XiBs_003D2;
			_0023_003Dzu68XiBs_003D2 = num6;
		}
		C(I.Value);
		bool skipTransformation = true;
		G0(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, t, null, null, null, null, null, null, skipTransformation);
		if (a.Value == 0.0 && s.Value > 0.0 && s.Value < num5)
		{
			int num7 = 1;
			while (true)
			{
				double? x2 = ((!(_0023_003Dzu68XiBs_003D < _0023_003Dzu68XiBs_003D2)) ? (_0023_003Dzu68XiBs_003D - s * (double)num7) : (_0023_003Dzu68XiBs_003D + s * (double)num7));
				if (!(s * (double)num7 < num5))
				{
					break;
				}
				XL2P(x2, null, null, null, null, null, null, skipTransformation);
				num7++;
			}
			XL2P(_0023_003Dzu68XiBs_003D2, null, null, null, null, null, null, skipTransformation);
		}
		else
		{
			XL2P(_0023_003Dzu68XiBs_003D2, null, null, null, null, null, null, skipTransformation);
		}
	}

	public void BLADE(double? X = null, double? Y = null, double? x = null, double? Z = null, double? J = null, double? E = null)
	{
		if (!_0023_003Dzdk3_wRkuVl8n())
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715339);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713992) };
			if (uint.MaxValue != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		if (2u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (x.HasValue)
		{
			x = _0023_003Dz9_0024sSLsNoyfJu(x.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (!X.HasValue)
		{
			X = -10.0;
		}
		if (!Y.HasValue)
		{
			Y = _0023_003DzUUAAhCE_003D - 10.0;
		}
		if (!x.HasValue)
		{
			x = _0023_003DzOiU6nPw_003D + 10.0;
		}
		if (!J.HasValue)
		{
			J = 5.0;
		}
		if (!x.HasValue)
		{
			return;
		}
		double? num = X;
		double? num2;
		if (3u != 0)
		{
			num2 = num;
		}
		double activeX = num2 ?? base.ActiveX;
		if (8u != 0)
		{
			base.ActiveX = activeX;
		}
		double? num3 = Y;
		if (uint.MaxValue != 0)
		{
			num2 = num3;
		}
		double activeY = num2 ?? base.ActiveY;
		if (8u != 0)
		{
			base.ActiveY = activeY;
		}
		double? num4 = Z;
		if (6u != 0)
		{
			num2 = num4;
		}
		double activeZ = num2 ?? base.ActiveZ;
		if (3u != 0)
		{
			base.ActiveZ = activeZ;
		}
		double activeX2 = base.ActiveX;
		double _0023_003Dzu68XiBs_003D;
		if (4u != 0)
		{
			_0023_003Dzu68XiBs_003D = activeX2;
		}
		double activeY2 = base.ActiveY;
		double _0023_003DzkCWBd1Y_003D = default(double);
		if (0 == 0)
		{
			_0023_003DzkCWBd1Y_003D = activeY2;
		}
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		_0023_003DzRvG13dw_003D = (((!(_0023_003DzRvG13dw_003D < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(_0023_003DzRvG13dw_003D > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(_0023_003DzRvG13dw_003D) : 0.0);
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		double _0023_003Dzu68XiBs_003D2 = x.Value;
		double _0023_003DzkCWBd1Y_003D2 = base.ActiveY;
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
		double num5 = ABS(_0023_003Dzu68XiBs_003D - _0023_003Dzu68XiBs_003D2);
		if (!(num5 > 0.0))
		{
			return;
		}
		List<MachiningTool> tools = _toolInterface.GetTools(KindOfToolFamily.BladeCuttingTool);
		if (tools.Count <= 0)
		{
			return;
		}
		string t = string.Empty;
		bool flag = false;
		foreach (MachiningTool item in tools)
		{
			XilogToolKey xilogToolKey = ToolMethods.GetXilogToolKey(item);
			flag = xilogToolKey.KindOfTool == XilogToolKey.KindOfOriginTool.XilogBoringUnitTool;
			if (flag)
			{
				t = xilogToolKey.Key.ToString();
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		bool skipTransformation = true;
		G0(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, t, null, null, null, null, null, null, skipTransformation);
		if (J.HasValue && J.Value > 1.0)
		{
			double num6 = num5 / J.Value;
			double num7 = ((_0023_003Dzu68XiBs_003D2 > _0023_003Dzu68XiBs_003D) ? 1 : (-1));
			for (int i = 1; (double)i <= J.Value; i++)
			{
				double? x2 = _0023_003Dzu68XiBs_003D + num6 * (double)i * num7;
				XL2P(x2, null, null, null, null, null, null, skipTransformation);
			}
		}
		else
		{
			XL2P(_0023_003Dzu68XiBs_003D2, null, null, null, null, null, null, skipTransformation);
		}
	}

	public void GSET(double? V = null, double? B = null, string T = "")
	{
		string empty = string.Empty;
		string _0023_003DzHMoneas_003D;
		if (7u != 0)
		{
			_0023_003DzHMoneas_003D = empty;
		}
		string empty2 = string.Empty;
		string _0023_003DzOiEjdhXyi_A_0024 = default(string);
		if (0 == 0)
		{
			_0023_003DzOiEjdhXyi_A_0024 = empty2;
		}
		string empty3 = string.Empty;
		string _0023_003Dz5dh86BrVaX8U = default(string);
		if (0 == 0)
		{
			_0023_003Dz5dh86BrVaX8U = empty3;
		}
		XilogGSetParams item = default(XilogGSetParams);
		if (7u != 0)
		{
			item.B = -1.0;
		}
		string empty4 = string.Empty;
		if (uint.MaxValue != 0)
		{
			item.T = empty4;
		}
		item.V = -1.0;
		if (V.HasValue)
		{
			item.V = V.Value;
		}
		if (B.HasValue)
		{
			item.B = B.Value;
		}
		CoreTool _0023_003DzyagUmhsbHglp;
		ScmGroup.XCam.MachiningDataModel.Head _0023_003Dz9ybYj_0024UhnI6V;
		if (T != string.Empty)
		{
			_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
			if (_0023_003DzyagUmhsbHglp == null)
			{
				string text = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, _0023_003DzOiEjdhXyi_A_0024);
			}
			else
			{
				if (T != _0023_003DzHMoneas_003D)
				{
					_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713980));
					AddToErrorFile(_errorString);
				}
				item.T = T;
			}
		}
		if (item.B != -1.0 && item.T == string.Empty && _0023_003DzF5TXIn7g4cW5.Count() != 0)
		{
			List<XilogGSetParams> list = new List<XilogGSetParams>();
			foreach (XilogGSetParams item2 in _0023_003DzF5TXIn7g4cW5)
			{
				if (!(item2.T != string.Empty) || item2.B != -1.0)
				{
					continue;
				}
				_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
				if (_0023_003DzyagUmhsbHglp is CuttingTool)
				{
					if ((_0023_003DzyagUmhsbHglp as CuttingTool).ToolBody is BladeToolBody && item.B == 1.0)
					{
						list.Add(item2);
					}
					if (!((_0023_003DzyagUmhsbHglp as CuttingTool).ToolBody is BladeToolBody) && item.B == 2.0)
					{
						list.Add(item2);
					}
				}
			}
			_0023_003DzF5TXIn7g4cW5.Clear();
			_0023_003DzF5TXIn7g4cW5 = list;
		}
		_0023_003DzF5TXIn7g4cW5.Add(item);
	}

	public void GREP(double? X = null, double? Y = null, double? Z = null, double? A = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? x = null, double? y = null, double? D = null, double? s = null, double? G = null, string N = "", string T = "")
	{
		_0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D _0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D = new _0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D();
		_0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D _0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D2;
		if (7u != 0)
		{
			_0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D2 = _0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D;
		}
		if (2u != 0)
		{
			_0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D2._0023_003DzShOujVI_003D = N;
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (x.HasValue)
		{
			x = _0023_003Dz9_0024sSLsNoyfJu(x.Value);
		}
		if (y.HasValue)
		{
			y = _0023_003Dz9_0024sSLsNoyfJu(y.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		if (s.HasValue)
		{
			s = _0023_003Dz9_0024sSLsNoyfJu(s.Value);
		}
		string empty = string.Empty;
		string _0023_003DzHMoneas_003D;
		if (4u != 0)
		{
			_0023_003DzHMoneas_003D = empty;
		}
		string empty2 = string.Empty;
		string _0023_003DzOiEjdhXyi_A_0024;
		if (6u != 0)
		{
			_0023_003DzOiEjdhXyi_A_0024 = empty2;
		}
		string empty3 = string.Empty;
		string _0023_003Dz5dh86BrVaX8U;
		if (2u != 0)
		{
			_0023_003Dz5dh86BrVaX8U = empty3;
		}
		if (A.HasValue)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714023) };
			if (true)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
			return;
		}
		if (0 == 0)
		{
			_0023_003DzA5qgTEkrFVSy(ref V, ref T);
		}
		if (4u != 0)
		{
			CommitPendingProfile();
		}
		XilogProfile xilogProfile = _0023_003Dz6O8F0jNAY_0024c7.Find(_0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D2._0023_003Dzphqi7KlXfMeIrQ7Ejw_003D_003D);
		XilogProfile xilogProfile2;
		if (5u != 0)
		{
			xilogProfile2 = xilogProfile;
		}
		if (xilogProfile2 != null)
		{
			if (_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D.TryGetValue(_0023_003DzOzrIclKbOahZl_0024ge1cuHkv0_003D2._0023_003DzShOujVI_003D, out var value))
			{
				LeadInOut _0023_003Dz3keKASA_003D = value;
				if (uint.MaxValue != 0)
				{
					_0023_003Dz8DhcByEE_0024hyBLHSgZg_003D_003D(_0023_003Dz3keKASA_003D);
				}
			}
			double activeZ = base.ActiveZ;
			if (D.HasValue)
			{
				xilogProfile2.OutSideWorkQuota = D.Value;
			}
			CoreTool _0023_003DzyagUmhsbHglp;
			ScmGroup.XCam.MachiningDataModel.Head _0023_003Dz9ybYj_0024UhnI6V;
			if (T != string.Empty)
			{
				_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
				if (_0023_003DzyagUmhsbHglp == null)
				{
					string text = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
					ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, _0023_003DzOiEjdhXyi_A_0024);
				}
				else
				{
					if (T != _0023_003DzHMoneas_003D)
					{
						_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
						AddToErrorFile(_errorString);
					}
					ActiveTools = T;
				}
			}
			else
			{
				T = xilogProfile2.Tool;
				ActiveTools = T;
				_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
				if (_0023_003DzyagUmhsbHglp == null)
				{
					string text2 = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
					ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text2, _0023_003DzOiEjdhXyi_A_0024);
				}
				else if (G.ToString() != _0023_003DzHMoneas_003D)
				{
					_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
					AddToErrorFile(_errorString);
				}
			}
			if (E.HasValue)
			{
				xilogProfile2.HoodPosition = (int?)E;
			}
			if (s.HasValue)
			{
				SetToolCorrection(base.ActiveToolCorrection.Correction, s.Value);
			}
			int correction = _0023_003DzGXYQvSTndE5W0wzvLgDcN80_003D(base.ActiveToolCorrection.Correction);
			double overMaterial = base.ActiveToolCorrection.OverMaterial;
			ToolCorrection toolCorrection = new ToolCorrection();
			toolCorrection.CreateToolCorrection(correction, overMaterial);
			if (V.HasValue)
			{
				V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
				xilogProfile2.Feed = V.Value;
				_0023_003DzZGra6ZgrZzgF(V.Value);
			}
			if (S.HasValue)
			{
				xilogProfile2.InputFeed = S.Value;
			}
			if (Q.HasValue && Q == 0.0)
			{
				double _0023_003Dzu68XiBs_003D = (X.HasValue ? X.Value : 0.0);
				double _0023_003DzkCWBd1Y_003D = (Y.HasValue ? Y.Value : 0.0);
				double num = (Z.HasValue ? Z.Value : 0.0);
				_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
				double x2 = _0023_003Dzu68XiBs_003D - xilogProfile2.GeometryPath.StartXLocal;
				double y2 = _0023_003DzkCWBd1Y_003D - xilogProfile2.GeometryPath.StartYLocal;
				double z = num - xilogProfile2.GeometryPath.StartZLocal;
				SetTranslation(x2, y2, z, string.Empty);
			}
			else if (!Q.HasValue || Q == 1.0)
			{
				double x3 = X ?? 0.0;
				double y3 = Y ?? 0.0;
				double z2 = Z ?? 0.0;
				SetTranslation(x3, y3, z2, string.Empty);
			}
			if (G.HasValue && G.Value == 1.0)
			{
				List<Geometry> elements = xilogProfile2.GeometryPath.Elements;
				elements.Reverse();
				double x4 = elements.First().EndXLocal;
				double y4 = elements.First().EndYLocal;
				double endZLocal = elements.First().EndZLocal;
				endZLocal = (((!(endZLocal < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(endZLocal > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(endZLocal) : 0.0);
				ActiveTransformation.Translate(ref x4, ref y4, base.ActiveWorkplane.Name);
				string uniqueName = _projectInterface.GetUniqueName<GeomCompositeCurve>(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715707));
				Polyline _0023_003DzqvJD5M4_003D = CreatePolyline(uniqueName, x4, y4);
				ToolCorrection activeToolCorrection = base.ActiveToolCorrection;
				if (activeToolCorrection.Correction.ToString().Contains('1'))
				{
					activeToolCorrection._0023_003DzZObhfuyMZ0vtPEBZ_0024cr9U8s_003D(Convert.ToInt16(activeToolCorrection.Correction.ToString().Replace('1', '2')));
				}
				else if (activeToolCorrection.Correction.ToString().Contains('2'))
				{
					activeToolCorrection._0023_003DzZObhfuyMZ0vtPEBZ_0024cr9U8s_003D(Convert.ToInt16(activeToolCorrection.Correction.ToString().Replace('2', '1')));
				}
				_0023_003DzVsFfuwI_003D = new _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D(_projectInterface.GetUniqueName<MachiningWorkingStep>(xilogProfile2.Name), base.ActiveWorkplane, _0023_003DzqvJD5M4_003D, x4, y4, (double?)endZLocal, xilogProfile2.InputFeed, xilogProfile2.HoodPosition, xilogProfile2.SpindleSpeed, xilogProfile2.Tool, toolCorrection, D);
				foreach (Geometry item in elements)
				{
					if (item.IsArc)
					{
						x4 = item.StartXLocal;
						y4 = item.StartYLocal;
						ActiveTransformation.Translate(ref x4, ref y4, base.ActiveWorkplane.Name);
						double x5 = item.CenterXLocal;
						double y5 = item.CenterYLocal;
						ActiveTransformation.Translate(ref x5, ref y5, base.ActiveWorkplane.Name);
						_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(x4, y4, x5, y5, !item.IsClockWise, string.Empty);
					}
					if (item.IsSegment)
					{
						x4 = item.StartXLocal;
						y4 = item.StartYLocal;
						ActiveTransformation.Translate(ref x4, ref y4, base.ActiveWorkplane.Name);
						_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(x4, y4, string.Empty);
					}
				}
			}
			else
			{
				double x6 = xilogProfile2.GeometryPath.Elements.First().StartXLocal;
				double y6 = xilogProfile2.GeometryPath.Elements.First().StartYLocal;
				double startZLocal = xilogProfile2.GeometryPath.Elements.First().StartZLocal;
				startZLocal = (((!(startZLocal < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(startZLocal > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(startZLocal) : 0.0);
				ActiveTransformation.Translate(ref x6, ref y6, base.ActiveWorkplane.Name);
				string uniqueName2 = _projectInterface.GetUniqueName<GeomCompositeCurve>(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715707));
				Polyline _0023_003DzqvJD5M4_003D2 = CreatePolyline(uniqueName2, x6, y6);
				string uniqueName3 = _projectInterface.GetUniqueName<MachiningWorkingStep>(xilogProfile2.Name);
				_0023_003DzVsFfuwI_003D = new _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D(base.ActiveWorkplane, _0023_003DzqvJD5M4_003D2, x6, y6, startZLocal, xilogProfile2.InputFeed, xilogProfile2.HoodPosition, xilogProfile2.SpindleSpeed, uniqueName3, xilogProfile2.Tool, toolCorrection, D);
				foreach (Geometry element in xilogProfile2.GeometryPath.Elements)
				{
					if (element.IsArc)
					{
						x6 = element.EndXLocal;
						y6 = element.EndYLocal;
						ActiveTransformation.Translate(ref x6, ref y6, base.ActiveWorkplane.Name);
						double x7 = element.CenterXLocal;
						double y7 = element.CenterYLocal;
						ActiveTransformation.Translate(ref x7, ref y7, base.ActiveWorkplane.Name);
						_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(x6, y6, x7, y7, element.IsClockWise, string.Empty);
					}
					if (element.IsSegment)
					{
						x6 = element.EndXLocal;
						y6 = element.EndYLocal;
						ActiveTransformation.Translate(ref x6, ref y6, base.ActiveWorkplane.Name);
						_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(x6, y6, string.Empty);
					}
				}
			}
			if (Z.HasValue)
			{
				base.ActiveZ = Z.Value;
				if (activeZ != base.ActiveZ)
				{
					SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
				}
			}
		}
		else
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713967), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		}
	}

	public void GFIL(double? V = null, double? r = null)
	{
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
		{
			return;
		}
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			double _0023_003Dz3keKASA_003D = V.Value;
			if (5u != 0)
			{
				_0023_003DzZGra6ZgrZzgF(_0023_003Dz3keKASA_003D);
			}
			if (_0023_003DzVsFfuwI_003D.GeometryPath.Count == 1)
			{
				_0023_003DzVsFfuwI_003D.Feed = V;
			}
		}
		double? num = r;
		double? num2;
		if (4u != 0)
		{
			num2 = num;
		}
		r = num2 ?? 0.0;
		XilogProfile xilogProfile = _0023_003DzVsFfuwI_003D;
		Polyline geometryPath = AddFilletToPolyline(r.Value, 0, string.Empty);
		if (4u != 0)
		{
			xilogProfile.GeometryPath = geometryPath;
		}
		if (V.HasValue)
		{
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702931), base.ActiveSpeed, 1.0);
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
	}

	public void GCHA(double? V = null, double? I = null, double? L = null)
	{
		if (_0023_003DzVsFfuwI_003D == null)
		{
			return;
		}
		if (I.HasValue)
		{
			I = _0023_003Dz9_0024sSLsNoyfJu(I.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		if (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile)))
		{
			return;
		}
		if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
		{
			(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
		}
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			double _0023_003Dz3keKASA_003D = V.Value;
			if (5u != 0)
			{
				_0023_003DzZGra6ZgrZzgF(_0023_003Dz3keKASA_003D);
			}
			if (_0023_003DzVsFfuwI_003D.GeometryPath.Count == 1)
			{
				_0023_003DzVsFfuwI_003D.Feed = V;
			}
		}
		double? num = I;
		double? num2;
		if (5u != 0)
		{
			num2 = num;
		}
		I = num2 ?? 0.0;
		double? num3 = L;
		if (6u != 0)
		{
			num2 = num3;
		}
		L = num2 ?? 0.0;
		_0023_003DzVsFfuwI_003D.GeometryPath = AddChamferToPolyline(I.Value, L.Value, 0, string.Empty);
		if (V.HasValue)
		{
			SetAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702931), base.ActiveSpeed);
		}
		_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
	}

	public void G5R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? Q = null, double? G = null, double? L = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		double num = _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA;
		double num2;
		if (5u != 0)
		{
			num2 = num;
		}
		if (A.HasValue)
		{
			double num3 = MathUtility.DegreeToRad(A.Value);
			if (4u != 0)
			{
				_0023_003DzRy81lOpVNjEq = num3;
			}
		}
		if (Q.HasValue)
		{
			double num4 = MathUtility.DegreeToRad(Q.Value);
			if (7u != 0)
			{
				_0023_003Dz7AJiHJhGO7iA = num4;
			}
		}
		double? num5 = L;
		double? num6;
		if (8u != 0)
		{
			num6 = num5;
		}
		double num7 = num6 ?? 1.0;
		double length;
		if (true)
		{
			length = num7;
		}
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num8 = X;
			if (4u != 0)
			{
				num6 = num8;
			}
			double activeX = base.ActiveX;
			double num9;
			if (5u != 0)
			{
				num9 = activeX;
			}
			X = num6 + num9;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num10 = Y;
			if (0 == 0)
			{
				num6 = num10;
			}
			double activeY = base.ActiveY;
			double num9;
			if (7u != 0)
			{
				num9 = activeY;
			}
			Y = num6 + num9;
		}
		double activeZ = base.ActiveZ;
		double num11;
		if (3u != 0)
		{
			num11 = activeZ;
		}
		_ = base.ActiveSpeed;
		base.ActiveX = X ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		int num12 = (int)G.Value;
		if (G.HasValue && (G.Value == 2.0 || G.Value == 3.0) && _0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			switch (num12)
			{
			case 2:
				num12 = 3;
				break;
			case 3:
				num12 = 2;
				break;
			}
		}
		if (_0023_003DzVsFfuwI_003D == null || !(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)))
		{
			return;
		}
		if (num12 == 2 || num12 == 3)
		{
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArcTanToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, num12, string.Empty);
		}
		else
		{
			_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentTanToPolyline(length, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num11 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		if (H.HasValue)
		{
			if (_0023_003DzY7q55ibyTX_n != H.Value)
			{
				_0023_003DzY7q55ibyTX_n = H.Value;
			}
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703114), _0023_003DzY7q55ibyTX_n, 1.0);
		}
		if (!MathUtility.IsEqual(num2, _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA, PrecisionExtension.Angular()))
		{
			SetAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703136), num2);
		}
	}

	public void XA2P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? I = null, double? J = null, double? V = null, double? B = null, double? G = null, double? L = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (I.HasValue)
		{
			I = _0023_003Dz9_0024sSLsNoyfJu(I.Value);
		}
		if (J.HasValue)
		{
			J = _0023_003Dz9_0024sSLsNoyfJu(J.Value);
		}
		if (A.HasValue)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713933) };
			if (7u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		else
		{
			if (_0023_003DzVsFfuwI_003D == null)
			{
				return;
			}
			double activeZ = base.ActiveZ;
			double num;
			if (6u != 0)
			{
				num = activeZ;
			}
			_ = base.ActiveSpeed;
			double activeX = base.ActiveX;
			double num2;
			if (uint.MaxValue != 0)
			{
				num2 = activeX;
			}
			double activeY = base.ActiveY;
			double num3;
			if (3u != 0)
			{
				num3 = activeY;
			}
			if (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile)))
			{
				return;
			}
			if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
			{
				(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
			}
			if (B.HasValue && !X.HasValue && !Y.HasValue && !L.HasValue)
			{
				double num4 = I.Value;
				double _0023_003Dzu68XiBs_003D;
				if (5u != 0)
				{
					_0023_003Dzu68XiBs_003D = num4;
				}
				double num5 = J.Value;
				double _0023_003DzkCWBd1Y_003D;
				if (2u != 0)
				{
					_0023_003DzkCWBd1Y_003D = num5;
				}
				Workplane activeWorkplane = base.ActiveWorkplane;
				if (true)
				{
					_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, activeWorkplane);
				}
				bool num6 = G.Value == 2.0;
				bool flag;
				if (8u != 0)
				{
					flag = num6;
				}
				if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
				{
					bool num7 = !flag;
					if (4u != 0)
					{
						flag = num7;
					}
				}
				if (flag)
				{
					double? num8 = B;
					double? num9;
					if (7u != 0)
					{
						num9 = num8;
					}
					B = 0.0 - num9;
				}
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArcCenterAngleToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, B.Value, string.Empty);
				string uniqueName = _projectInterface.GetUniqueName<GeomCompositeCurve>(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715707));
				Polyline polyline = new Polyline(uniqueName, _projectInterface);
				polyline.CreatePolylineStartPoint(base.ActiveX, base.ActiveY, base.ActiveWorkplane, 0);
				polyline.AddArcCenterAngle(uniqueName, I.Value, J.Value, MathUtility.DegreeToRad(B.Value));
				base.ActiveX = polyline.Geometry.EndX;
				base.ActiveY = polyline.Geometry.EndY;
			}
			else if ((X.HasValue && Y.HasValue && !B.HasValue && !L.HasValue) || (X.HasValue && !Y.HasValue && !B.HasValue && !L.HasValue) || (!X.HasValue && Y.HasValue && !B.HasValue && !L.HasValue))
			{
				sqrt(pow(base.ActiveX - I.Value, 2.0) + pow(base.ActiveY - J.Value, 2.0));
				bool flag2 = G.Value == 2.0;
				if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
				{
					flag2 = !flag2;
				}
				if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
				{
					X += base.ActiveX;
				}
				if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
				{
					Y += base.ActiveY;
				}
				base.ActiveX = X ?? base.ActiveX;
				base.ActiveY = Y ?? base.ActiveY;
				base.ActiveZ = Z ?? base.ActiveZ;
				double _0023_003Dzu68XiBs_003D2 = base.ActiveX;
				double _0023_003DzkCWBd1Y_003D2 = base.ActiveY;
				double _0023_003DzRvG13dw_003D = base.ActiveZ;
				_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
				if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
				{
					_0023_003DzRvG13dw_003D = 0.0;
				}
				else
				{
					_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
				}
				_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
				double _0023_003Dzu68XiBs_003D3 = I.Value;
				double _0023_003DzkCWBd1Y_003D3 = J.Value;
				_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D3, ref _0023_003DzkCWBd1Y_003D3, base.ActiveWorkplane);
				if (base.ActiveX == num2 && base.ActiveY == num3)
				{
					double _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D = 0.0;
					double _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D = 0.0;
					_0023_003DzpKAjugZnGow0ycyMGw_003D_003D(_0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, _0023_003Dzu68XiBs_003D3, _0023_003DzkCWBd1Y_003D3, ref _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, ref _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D);
					_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D, _0023_003Dzu68XiBs_003D3, _0023_003DzkCWBd1Y_003D3, flag2, string.Empty);
					_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, _0023_003Dzu68XiBs_003D3, _0023_003DzkCWBd1Y_003D3, flag2, string.Empty);
				}
				else
				{
					_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, _0023_003Dzu68XiBs_003D3, _0023_003DzkCWBd1Y_003D3, flag2, string.Empty);
				}
				_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
			}
			else if ((X.HasValue && !Y.HasValue && !B.HasValue && L.HasValue) || (!X.HasValue && Y.HasValue && !B.HasValue && L.HasValue))
			{
				bool flag3 = G.Value == 2.0;
				if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
				{
					flag3 = !flag3;
				}
				if (flag3)
				{
					B = 0.0 - B;
				}
				double x = sqrt(pow(base.ActiveX - I.Value, 2.0) + pow(base.ActiveY - J.Value, 2.0));
				double num10;
				double num11;
				double num12;
				double num13;
				if (X.HasValue)
				{
					num10 = X.Value;
					num11 = X.Value;
					num12 = (2.0 * J.Value + sqrt(4.0 * pow(J.Value, 2.0) - 4.0 * (pow(X.Value, 2.0) - 2.0 * (X.Value * I.Value) + pow(I.Value, 2.0) + pow(J.Value, 2.0) - pow(x, 2.0)))) / 2.0;
					num13 = (2.0 * J.Value - sqrt(4.0 * pow(J.Value, 2.0) - 4.0 * (pow(X.Value, 2.0) - 2.0 * (X.Value * I.Value) + pow(I.Value, 2.0) + pow(J.Value, 2.0) - pow(x, 2.0)))) / 2.0;
				}
				else
				{
					num10 = (2.0 * I.Value + sqrt(4.0 * pow(I.Value, 2.0) - 4.0 * (pow(Y.Value, 2.0) - 2.0 * (Y.Value * J.Value) + pow(J.Value, 2.0) + pow(I.Value, 2.0) - pow(x, 2.0)))) / 2.0;
					num11 = (2.0 * I.Value - sqrt(4.0 * pow(I.Value, 2.0) - 4.0 * (pow(Y.Value, 2.0) - 2.0 * (Y.Value * J.Value) + pow(J.Value, 2.0) + pow(I.Value, 2.0) - pow(x, 2.0)))) / 2.0;
					num12 = Y.Value;
					num13 = Y.Value;
				}
				GeomCompositeCurve geomCompositeCurve = new GeomCompositeCurve();
				geomCompositeCurve.AddFirstPoint(base.ActiveX, base.ActiveY, base.ActiveZ);
				geomCompositeCurve.AddArcCircleCenterP(I.Value, J.Value, 0.0, 0.0, 0.0, (!flag3) ? 1 : (-1), num10, num12, 0.0);
				double length = geomCompositeCurve.Length;
				GeomCompositeCurve geomCompositeCurve2 = new GeomCompositeCurve();
				geomCompositeCurve2.AddFirstPoint(base.ActiveX, base.ActiveY, base.ActiveZ);
				geomCompositeCurve2.AddArcCircleCenterP(I.Value, J.Value, 0.0, 0.0, 0.0, (!flag3) ? 1 : (-1), num11, num13, 0.0);
				double length2 = geomCompositeCurve2.Length;
				double value;
				double value2;
				if (L.Value == 1.0)
				{
					if (length < length2)
					{
						value = num10;
						value2 = num12;
					}
					else
					{
						value = num11;
						value2 = num13;
					}
				}
				else if (length > length2)
				{
					value = num10;
					value2 = num12;
				}
				else
				{
					value = num11;
					value2 = num13;
				}
				X = value;
				Y = value2;
				if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
				{
					X += base.ActiveX;
				}
				if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
				{
					Y += base.ActiveY;
				}
				base.ActiveX = X ?? base.ActiveX;
				base.ActiveY = Y ?? base.ActiveY;
				base.ActiveZ = Z ?? base.ActiveZ;
				double _0023_003Dzu68XiBs_003D4 = base.ActiveX;
				double _0023_003DzkCWBd1Y_003D4 = base.ActiveY;
				double _0023_003DzRvG13dw_003D2 = base.ActiveZ;
				_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D2, base.ActiveWorkplane);
				if ((_0023_003DzRvG13dw_003D2 < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D2 > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
				{
					_0023_003DzRvG13dw_003D2 = 0.0;
				}
				else
				{
					_0023_003DzRvG13dw_003D2 = abs(_0023_003DzRvG13dw_003D2);
				}
				_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D4, ref _0023_003DzkCWBd1Y_003D4, base.ActiveWorkplane);
				double _0023_003Dzu68XiBs_003D5 = I.Value;
				double _0023_003DzkCWBd1Y_003D5 = J.Value;
				_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D5, ref _0023_003DzkCWBd1Y_003D5, base.ActiveWorkplane);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D4, _0023_003DzkCWBd1Y_003D4, _0023_003Dzu68XiBs_003D5, _0023_003DzkCWBd1Y_003D5, flag3, string.Empty);
			}
			_0023_003DzBzxGAl03YF3F(V);
			if (Z.HasValue)
			{
				base.ActiveZ = Z.Value;
				if (num != base.ActiveZ)
				{
					SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
				}
			}
		}
	}

	public void PB(double? B = null, double? E = null, double? X = null, double? Y1 = null, double? S1 = null, double? Y2 = null, double? S2 = null, double? Y3 = null, double? S3 = null, double? Y4 = null, double? S4 = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y1.HasValue)
		{
			Y1 = _0023_003Dz9_0024sSLsNoyfJu(Y1.Value);
		}
		if (Y2.HasValue)
		{
			Y2 = _0023_003Dz9_0024sSLsNoyfJu(Y2.Value);
		}
		if (Y3.HasValue)
		{
			Y3 = _0023_003Dz9_0024sSLsNoyfJu(Y3.Value);
		}
		if (Y4.HasValue)
		{
			Y4 = _0023_003Dz9_0024sSLsNoyfJu(Y4.Value);
		}
		string errorString = LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713924), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990));
		if (0 == 0)
		{
			_errorString = errorString;
		}
		string errorString2 = _errorString;
		if (5u != 0)
		{
			AddToErrorFile(errorString2);
		}
	}

	public void SO(string N, string PARAMS = "", double? DX = null, double? DY = null, double? DZ = null, string FLD = "", double? BX = null, double? BY = null, double? BZ = null)
	{
		if (DX.HasValue)
		{
			_ = 7;
			if (false)
			{
			}
			DX = _0023_003Dz9_0024sSLsNoyfJu(DX.Value);
		}
		if (DY.HasValue)
		{
			_ = 4;
			if (4 == 0)
			{
			}
			DY = _0023_003Dz9_0024sSLsNoyfJu(DY.Value);
		}
		if (DZ.HasValue)
		{
			_ = 1;
			if (5 == 0)
			{
			}
			DZ = _0023_003Dz9_0024sSLsNoyfJu(DZ.Value);
		}
		if (BX.HasValue)
		{
			BX = _0023_003Dz9_0024sSLsNoyfJu(BX.Value);
		}
		if (BY.HasValue)
		{
			BY = _0023_003Dz9_0024sSLsNoyfJu(BY.Value);
		}
		if (BZ.HasValue)
		{
			BZ = _0023_003Dz9_0024sSLsNoyfJu(BZ.Value);
		}
		throw new NotImplementedException();
	}

	public void S(string N, string PARAMS = "", double? X = null, double? Y = null, double? Z = null, double? A = null)
	{
		if (X.HasValue)
		{
			_ = 5;
			if (false)
			{
			}
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			_ = 2;
			if (3 == 0)
			{
			}
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			_ = 2;
			if (false)
			{
			}
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		throw new NotImplementedException();
	}

	public void XA3P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? x = null, double? y = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (x.HasValue)
		{
			x = _0023_003Dz9_0024sSLsNoyfJu(x.Value);
		}
		if (y.HasValue)
		{
			y = _0023_003Dz9_0024sSLsNoyfJu(y.Value);
		}
		if (A.HasValue)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714143) };
			if (true)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		else
		{
			if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
			{
				return;
			}
			if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
			{
				(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
			}
			new GeomCompositeCurve();
			double? num2 = default(double?);
			double num3 = default(double);
			if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
			{
				double? num = X;
				if (2u != 0)
				{
					num2 = num;
				}
				double activeX = base.ActiveX;
				if (0 == 0)
				{
					num3 = activeX;
				}
				X = num2 + num3;
			}
			if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
			{
				double? num4 = Y;
				if (2u != 0)
				{
					num2 = num4;
				}
				double activeY = base.ActiveY;
				if (0 == 0)
				{
					num3 = activeY;
				}
				Y = num2 + num3;
			}
			double activeZ = base.ActiveZ;
			double num5;
			if (4u != 0)
			{
				num5 = activeZ;
			}
			_ = base.ActiveSpeed;
			double activeX2 = base.ActiveX;
			double _0023_003Dzu68XiBs_003D;
			if (6u != 0)
			{
				_0023_003Dzu68XiBs_003D = activeX2;
			}
			double activeY2 = base.ActiveY;
			double _0023_003DzkCWBd1Y_003D;
			if (2u != 0)
			{
				_0023_003DzkCWBd1Y_003D = activeY2;
			}
			Workplane activeWorkplane = base.ActiveWorkplane;
			if (6u != 0)
			{
				_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, activeWorkplane);
			}
			double? num6 = X;
			if (0 == 0)
			{
				num2 = num6;
			}
			base.ActiveX = num2 ?? base.ActiveX;
			base.ActiveY = Y ?? base.ActiveY;
			base.ActiveZ = Z ?? base.ActiveZ;
			double _0023_003Dzu68XiBs_003D2 = base.ActiveX;
			double _0023_003DzkCWBd1Y_003D2 = base.ActiveY;
			double activeZ2 = base.ActiveZ;
			if ((activeZ2 < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (activeZ2 > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
			{
				activeZ2 = 0.0;
			}
			else
			{
				activeZ2 = abs(activeZ2);
			}
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
			double _0023_003Dzu68XiBs_003D3 = x.Value;
			double _0023_003DzkCWBd1Y_003D3 = y.Value;
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D3, ref _0023_003DzkCWBd1Y_003D3, base.ActiveWorkplane);
			if (_0023_003DzKYT84fJWFcm65bUVOg_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D3, _0023_003DzkCWBd1Y_003D3, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2))
			{
				_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(_0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, string.Empty);
			}
			else
			{
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc3PointsToPolyline(_0023_003Dzu68XiBs_003D3, _0023_003DzkCWBd1Y_003D3, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, string.Empty);
			}
			_0023_003DzBzxGAl03YF3F(V);
			if (H.HasValue)
			{
				base.ActiveZ = H.Value;
				if (num5 != base.ActiveZ)
				{
					SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 0.5);
					num5 = base.ActiveZ;
				}
			}
			if (Z.HasValue)
			{
				base.ActiveZ = Z.Value;
				if (num5 != base.ActiveZ)
				{
					SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
				}
			}
			_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
		}
	}

	public void XAR(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? r = null, double? G = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		if (A.HasValue)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714134) };
			if (3u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		else
		{
			if (_0023_003DzVsFfuwI_003D == null || (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))))
			{
				return;
			}
			if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
			{
				(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
			}
			double num3 = default(double);
			double? num2;
			if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
			{
				double? num = X;
				if (8u != 0)
				{
					num2 = num;
				}
				double activeX = base.ActiveX;
				if (true)
				{
					num3 = activeX;
				}
				X = num2 + num3;
			}
			if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
			{
				double? num4 = Y;
				if (true)
				{
					num2 = num4;
				}
				double activeY = base.ActiveY;
				if (0 == 0)
				{
					num3 = activeY;
				}
				Y = num2 + num3;
			}
			double activeZ = base.ActiveZ;
			double num5;
			if (8u != 0)
			{
				num5 = activeZ;
			}
			_ = base.ActiveSpeed;
			double? num6 = X;
			if (uint.MaxValue != 0)
			{
				num2 = num6;
			}
			double activeX2 = num2 ?? base.ActiveX;
			if (6u != 0)
			{
				base.ActiveX = activeX2;
			}
			double? num7 = Y;
			if (0 == 0)
			{
				num2 = num7;
			}
			base.ActiveY = num2 ?? base.ActiveY;
			base.ActiveZ = Z ?? base.ActiveZ;
			double _0023_003Dzu68XiBs_003D = base.ActiveX;
			double _0023_003DzkCWBd1Y_003D = base.ActiveY;
			double _0023_003DzRvG13dw_003D = base.ActiveZ;
			_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
			if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
			{
				_0023_003DzRvG13dw_003D = 0.0;
			}
			else
			{
				_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
			}
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
			bool flag = G.Value == 2.0;
			if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
			{
				flag = !flag;
			}
			if (_0023_003Dzdk3_wRkuVl8n())
			{
				flag = !flag;
			}
			double radius = abs(r.Value);
			bool _0023_003DzJWP5xwk_003D = G.Value == 2.0;
			bool isOver = _0023_003DzOq7VhIzeDL2_0024NM_0024F7jqR_3c_003D(r, _0023_003DzJWP5xwk_003D);
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointRadiusToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, radius, flag, isOver, string.Empty);
			_0023_003DzBzxGAl03YF3F(V);
			if (Z.HasValue)
			{
				base.ActiveZ = Z.Value;
				if (num5 != base.ActiveZ)
				{
					SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
				}
			}
			_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
		}
	}

	public void XAR2(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? r = null, double? G = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		if (A.HasValue)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714134) };
			if (4u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		else
		{
			if (_0023_003DzVsFfuwI_003D == null)
			{
				return;
			}
			if (_0023_003DzVsFfuwI_003D is _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)
			{
				(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DztHTF7Yo_003D();
			}
			if (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)) && !(_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile)))
			{
				return;
			}
			double? num2 = default(double?);
			if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
			{
				double? num = X;
				if (4u != 0)
				{
					num2 = num;
				}
				double activeX = base.ActiveX;
				double num3;
				if (true)
				{
					num3 = activeX;
				}
				X = num2 + num3;
			}
			if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
			{
				double? num4 = Y;
				if (4u != 0)
				{
					num2 = num4;
				}
				double activeY = base.ActiveY;
				double num3;
				if (3u != 0)
				{
					num3 = activeY;
				}
				Y = num2 + num3;
			}
			double activeZ = base.ActiveZ;
			double num5;
			if (true)
			{
				num5 = activeZ;
			}
			_ = base.ActiveSpeed;
			double? num6 = X;
			if (0 == 0)
			{
				num2 = num6;
			}
			double activeX2 = num2 ?? base.ActiveX;
			if (3u != 0)
			{
				base.ActiveX = activeX2;
			}
			base.ActiveY = Y ?? base.ActiveY;
			base.ActiveZ = Z ?? base.ActiveZ;
			double _0023_003Dzu68XiBs_003D = base.ActiveX;
			double _0023_003DzkCWBd1Y_003D = base.ActiveY;
			double _0023_003DzRvG13dw_003D = base.ActiveZ;
			_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
			if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
			{
				_0023_003DzRvG13dw_003D = 0.0;
			}
			else
			{
				_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
			}
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
			bool flag = G.Value == 2.0;
			if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
			{
				flag = !flag;
			}
			double radius = abs(r.Value);
			bool isOver = _0023_003DzOq7VhIzeDL2_0024NM_0024F7jqR_3c_003D(r, _0023_003DzJWP5xwk_003D: false);
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointRadiusToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, radius, flag, isOver, string.Empty);
			_0023_003DzBzxGAl03YF3F(V);
			if (Z.HasValue)
			{
				base.ActiveZ = Z.Value;
				if (num5 != base.ActiveZ)
				{
					SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
				}
			}
			_0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D();
		}
	}

	public void B(double? X = null, double? Y = null, double? Z = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? x = null, double? y = null, double? a = null, double? G = null, double? D = null, string T = "")
	{
		if (4u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (x.HasValue)
		{
			x = _0023_003Dz9_0024sSLsNoyfJu(x.Value);
		}
		if (y.HasValue)
		{
			y = _0023_003Dz9_0024sSLsNoyfJu(y.Value);
		}
		if (a.HasValue)
		{
			a = _0023_003Dz9_0024sSLsNoyfJu(a.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		double? num2;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (2u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (5u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (4u != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (3u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double? num5 = X;
		if (true)
		{
			num2 = num5;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (6u != 0)
		{
			base.ActiveX = activeX2;
		}
		double? num6 = Y;
		if (4u != 0)
		{
			num2 = num6;
		}
		double activeY2 = num2 ?? base.ActiveY;
		if (2u != 0)
		{
			base.ActiveY = activeY2;
		}
		double? num7 = Z;
		if (3u != 0)
		{
			num2 = num7;
		}
		base.ActiveZ = num2 ?? base.ActiveZ;
		if (D.HasValue)
		{
			_0023_003DzLFGlmsZrI2xL = D.Value;
		}
		else
		{
			D = _0023_003DzLFGlmsZrI2xL;
		}
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
		}
		string _0023_003DzHMoneas_003D = string.Empty;
		string _0023_003DzOiEjdhXyi_A_0024 = string.Empty;
		string _0023_003Dz5dh86BrVaX8U = string.Empty;
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672);
		string kindOfHole = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672);
		double taperHeight = 0.0;
		if (T == string.Empty)
		{
			T = ActiveTools;
		}
		_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out var _0023_003DzyagUmhsbHglp, out var _0023_003Dz9ybYj_0024UhnI6V);
		bool flag = _0023_003DzbgBdFCN_0024ANguRGG9HMWCM1OSSB_0024L(_0023_003DzHMoneas_003D);
		if (_0023_003DzyagUmhsbHglp == null)
		{
			string text2 = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text2, _0023_003DzOiEjdhXyi_A_0024);
			return;
		}
		SetPneumaticHoodPosition((int?)E);
		List<PosId> list = new List<PosId>();
		PosId item = default(PosId);
		item.x = 0.0;
		item.y = 0.0;
		item.z = 0.0;
		item.id = short.Parse(_0023_003DzOiEjdhXyi_A_0024);
		list.Add(item);
		if (!string.IsNullOrEmpty(_0023_003Dz5dh86BrVaX8U) && flag)
		{
			if (_0023_003Dzdk3_wRkuVl8n())
			{
				AddToErrorFile(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714124), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
			}
			else if (_0023_003Dz2z_U3NnO_6AmnCuicfpA010_003D == WorkPlaneCategory.UNIFLEX_S || _0023_003Dz2z_U3NnO_6AmnCuicfpA010_003D == WorkPlaneCategory.UNIFLEX_HP)
			{
				AddToErrorFile(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714087), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
			}
			else
			{
				SpindleCollection spindleCollection = _0023_003DznGH5e16bcgiZCbKP0A_003D_003D(short.Parse(_0023_003DzOiEjdhXyi_A_0024));
				if (spindleCollection != null)
				{
					list.AddRange(_0023_003DzSHfpqA8_IBKRJkPqqzh_N2MLlPHQ(spindleCollection, short.Parse(_0023_003DzOiEjdhXyi_A_0024), 0.0));
				}
				if (T != _0023_003DzHMoneas_003D)
				{
					list.AddRange(_0023_003DzNd0GmcgjUGZrti7C8DYZ39RGMzqt(T, short.Parse(_0023_003DzOiEjdhXyi_A_0024), 0.0));
				}
			}
		}
		foreach (PosId item2 in list)
		{
			double _0023_003Dzu68XiBs_003D = base.ActiveX + item2.x;
			double _0023_003DzkCWBd1Y_003D = base.ActiveY + item2.y;
			double _0023_003DzRvG13dw_003D = base.ActiveZ + item2.z;
			_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
			_0023_003DzRvG13dw_003D = (((!(_0023_003DzRvG13dw_003D < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(_0023_003DzRvG13dw_003D > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(_0023_003DzRvG13dw_003D) : 0.0);
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
			int id = item2.id;
			_0023_003DzyagUmhsbHglp = _0023_003Dzr5pDEey_jV2G(id.ToString(), _0023_003Dzilu43q8Cm59l(_0023_003DzHMoneas_003D));
			string uniqueName = _projectInterface.GetUniqueName<MachiningWorkingStep>(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705887), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
			if (T != _0023_003DzHMoneas_003D && !flag)
			{
				_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), uniqueName);
				AddToErrorFile(_errorString);
			}
			double num8 = Convert.ToDouble(_toolInterface.GetToolPropertyValue(_0023_003DzyagUmhsbHglp.Key, KindOfToolProperty.Diameter).Value);
			_0023_003DzNFM7tSWfuJW0(x, y, (int?)R, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D);
			if (!flag)
			{
				text = _toolInterface.GetToolPropertyValue(_0023_003DzyagUmhsbHglp.Key, KindOfToolProperty.Name).Value;
			}
			else
			{
				_0023_003Dz9ybYj_0024UhnI6V.Number = -1;
				kindOfHole = _0023_003Dzm8J_0024kSNCTmcg(_toolInterface.GetToolType(_0023_003DzyagUmhsbHglp.Key).KindOfToolType);
				taperHeight = _0023_003Dz1ZkGY__0024q7UnYekYtmg_003D_003D(_0023_003DzyagUmhsbHglp);
			}
			int num9 = ((int?)G) ?? 0;
			double num10 = S ?? 0.0;
			double num11 = V ?? 0.0;
			CreateDrill(uniqueName, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, num8, string.Empty, TypeOfProcess.Drilling, text, _0023_003Dz9ybYj_0024UhnI6V.Number.ToString(), num9, num10, num11, kindOfHole, taperHeight, D);
			ActiveTools = T;
			if (Q.HasValue && Q != 0.0)
			{
				double _0023_003DzSV9c5lY_003D = 0.0;
				if (x.HasValue)
				{
					_0023_003DzSV9c5lY_003D = x.Value;
				}
				double _0023_003Dzi_Ktauk_003D = 0.0;
				if (y.HasValue)
				{
					_0023_003Dzi_Ktauk_003D = y.Value;
				}
				_0023_003DzjjquhpLP5JaMmJNBnQ_003D_003D((int)Q.Value, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, _0023_003DzSV9c5lY_003D, _0023_003Dzi_Ktauk_003D, num8, string.Empty, TypeOfProcess.Drilling, text, _0023_003Dz9ybYj_0024UhnI6V.Number.ToString(), num9, num10, num11);
			}
		}
		ResetPneumaticHood();
		ResetPattern();
		SetBrakes(string.Empty);
	}

	public void G2R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? I = null, double? J = null, double? V = null, double? Q = null, double? r = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (I.HasValue)
		{
			I = _0023_003Dz9_0024sSLsNoyfJu(I.Value);
		}
		if (J.HasValue)
		{
			J = _0023_003Dz9_0024sSLsNoyfJu(J.Value);
		}
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		double num = _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA;
		double val;
		if (4u != 0)
		{
			val = num;
		}
		if (A.HasValue)
		{
			double num2 = MathUtility.DegreeToRad(A.Value);
			if (8u != 0)
			{
				_0023_003DzRy81lOpVNjEq = num2;
			}
		}
		if (Q.HasValue)
		{
			double num3 = MathUtility.DegreeToRad(Q.Value);
			if (6u != 0)
			{
				_0023_003Dz7AJiHJhGO7iA = num3;
			}
		}
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num4 = X;
			double? num5;
			if (uint.MaxValue != 0)
			{
				num5 = num4;
			}
			double activeX = base.ActiveX;
			double num6;
			if (true)
			{
				num6 = activeX;
			}
			X = num5 + num6;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num7 = Y;
			double? num5;
			if (3u != 0)
			{
				num5 = num7;
			}
			double activeY = base.ActiveY;
			double num6;
			if (6u != 0)
			{
				num6 = activeY;
			}
			Y = num5 + num6;
		}
		double activeZ = base.ActiveZ;
		double num8;
		if (4u != 0)
		{
			num8 = activeZ;
		}
		_ = base.ActiveSpeed;
		double activeX2 = base.ActiveX;
		double num9;
		if (true)
		{
			num9 = activeX2;
		}
		double activeY2 = base.ActiveY;
		double num10;
		if (2u != 0)
		{
			num10 = activeY2;
		}
		base.ActiveX = X ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D == null || !(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)))
		{
			return;
		}
		bool flag = true;
		if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			flag = !flag;
		}
		if (I.HasValue && J.HasValue)
		{
			double _0023_003Dzu68XiBs_003D2 = I.Value;
			double _0023_003DzkCWBd1Y_003D2 = J.Value;
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
			if (base.ActiveX == num9 && base.ActiveY == num10)
			{
				double _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D = 0.0;
				double _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D = 0.0;
				_0023_003DzpKAjugZnGow0ycyMGw_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, ref _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, ref _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
			else
			{
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
		}
		else
		{
			double radius = abs(r.Value);
			bool isOver = _0023_003DzOq7VhIzeDL2_0024NM_0024F7jqR_3c_003D(r, _0023_003DzJWP5xwk_003D: true);
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointRadiusToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, radius, flag, isOver, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num8 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		if (H.HasValue)
		{
			if (_0023_003DzY7q55ibyTX_n != H.Value)
			{
				_0023_003DzY7q55ibyTX_n = H.Value;
			}
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703114), _0023_003DzY7q55ibyTX_n, 1.0);
		}
		if (!MathUtility.IsEqual(val, _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA, PrecisionExtension.Angular()))
		{
			SetAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703136), _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA);
		}
	}

	public void G3R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? I = null, double? J = null, double? V = null, double? Q = null, double? r = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (I.HasValue)
		{
			I = _0023_003Dz9_0024sSLsNoyfJu(I.Value);
		}
		if (J.HasValue)
		{
			J = _0023_003Dz9_0024sSLsNoyfJu(J.Value);
		}
		if (r.HasValue)
		{
			r = _0023_003Dz9_0024sSLsNoyfJu(r.Value);
		}
		double num = _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA;
		double val = default(double);
		if (0 == 0)
		{
			val = num;
		}
		if (A.HasValue)
		{
			double num2 = MathUtility.DegreeToRad(A.Value);
			if (5u != 0)
			{
				_0023_003DzRy81lOpVNjEq = num2;
			}
		}
		if (Q.HasValue)
		{
			double num3 = MathUtility.DegreeToRad(Q.Value);
			if (true)
			{
				_0023_003Dz7AJiHJhGO7iA = num3;
			}
		}
		double num6 = default(double);
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num4 = X;
			double? num5;
			if (8u != 0)
			{
				num5 = num4;
			}
			double activeX = base.ActiveX;
			if (6u != 0)
			{
				num6 = activeX;
			}
			X = num5 + num6;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num7 = Y;
			double? num5;
			if (6u != 0)
			{
				num5 = num7;
			}
			double activeY = base.ActiveY;
			if (0 == 0)
			{
				num6 = activeY;
			}
			Y = num5 + num6;
		}
		double activeZ = base.ActiveZ;
		double num8;
		if (true)
		{
			num8 = activeZ;
		}
		_ = base.ActiveSpeed;
		double activeX2 = base.ActiveX;
		double num9;
		if (5u != 0)
		{
			num9 = activeX2;
		}
		double activeY2 = base.ActiveY;
		double num10;
		if (7u != 0)
		{
			num10 = activeY2;
		}
		base.ActiveX = X ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D == null || !(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)))
		{
			return;
		}
		bool flag = false;
		if (_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM())
		{
			flag = !flag;
		}
		if (I.HasValue && J.HasValue)
		{
			double _0023_003Dzu68XiBs_003D2 = I.Value;
			double _0023_003DzkCWBd1Y_003D2 = J.Value;
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D2, ref _0023_003DzkCWBd1Y_003D2, base.ActiveWorkplane);
			if (base.ActiveX == num9 && base.ActiveY == num10)
			{
				double _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D = 0.0;
				double _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D = 0.0;
				_0023_003DzpKAjugZnGow0ycyMGw_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, ref _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, ref _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
			else
			{
				_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointCenterToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D2, _0023_003DzkCWBd1Y_003D2, flag, string.Empty);
			}
		}
		else
		{
			double radius = abs(r.Value);
			bool isOver = _0023_003DzOq7VhIzeDL2_0024NM_0024F7jqR_3c_003D(r, _0023_003DzJWP5xwk_003D: false);
			_0023_003DzVsFfuwI_003D.GeometryPath = AddArc2PointRadiusToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, radius, flag, isOver, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num8 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		if (H.HasValue)
		{
			if (_0023_003DzY7q55ibyTX_n != H.Value)
			{
				_0023_003DzY7q55ibyTX_n = H.Value;
			}
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703114), _0023_003DzY7q55ibyTX_n, 1.0);
		}
		if (!MathUtility.IsEqual(val, _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA, PrecisionExtension.Angular()))
		{
			SetAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703136), _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA);
		}
	}

	public void G1R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? Q = null, double? B = null, double? L = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		double val = _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA;
		if (A.HasValue)
		{
			double num = MathUtility.DegreeToRad(A.Value);
			if (0 == 0)
			{
				_0023_003DzRy81lOpVNjEq = num;
			}
		}
		if (Q.HasValue)
		{
			double num2 = MathUtility.DegreeToRad(Q.Value);
			if (7u != 0)
			{
				_0023_003Dz7AJiHJhGO7iA = num2;
			}
		}
		double? num4;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num3 = X;
			if (3u != 0)
			{
				num4 = num3;
			}
			double activeX = base.ActiveX;
			double num5;
			if (3u != 0)
			{
				num5 = activeX;
			}
			X = num4 + num5;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num6 = Y;
			if (8u != 0)
			{
				num4 = num6;
			}
			double activeY = base.ActiveY;
			double num5;
			if (uint.MaxValue != 0)
			{
				num5 = activeY;
			}
			Y = num4 + num5;
		}
		if (L.HasValue)
		{
			if (!Y.HasValue && !X.HasValue)
			{
				X = L.Value + base.ActiveY;
			}
			else if (X.HasValue && !Y.HasValue)
			{
				Y = Math.Sqrt(Math.Pow(L.Value, 2.0) - Math.Pow(X.Value - base.ActiveX, 2.0)) + base.ActiveY;
			}
			else
			{
				X = Math.Sqrt(Math.Pow(L.Value, 2.0) - Math.Pow(Y.Value - base.ActiveY, 2.0)) + base.ActiveX;
			}
		}
		double activeZ = base.ActiveZ;
		double num7;
		if (8u != 0)
		{
			num7 = activeZ;
		}
		_ = base.ActiveSpeed;
		double? num8 = X;
		if (3u != 0)
		{
			num4 = num8;
		}
		double activeX2 = num4 ?? base.ActiveX;
		if (6u != 0)
		{
			base.ActiveX = activeX2;
		}
		double? num9 = Y;
		if (5u != 0)
		{
			num4 = num9;
		}
		base.ActiveY = num4 ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		if ((_0023_003DzRvG13dw_003D < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (_0023_003DzRvG13dw_003D > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1))
		{
			_0023_003DzRvG13dw_003D = 0.0;
		}
		else
		{
			_0023_003DzRvG13dw_003D = abs(_0023_003DzRvG13dw_003D);
		}
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D != null && _0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D))
		{
			_0023_003DzVsFfuwI_003D.GeometryPath = AddSegmentToPolyline(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, string.Empty);
		}
		_0023_003DzBzxGAl03YF3F(V);
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			if (num7 != base.ActiveZ)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 1.0);
			}
		}
		if (H.HasValue && _0023_003DzY7q55ibyTX_n != H.Value)
		{
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703114), H.Value - _0023_003DzY7q55ibyTX_n, 1.0);
			_0023_003DzY7q55ibyTX_n = H.Value;
		}
		if (!MathUtility.IsEqual(val, _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA, PrecisionExtension.Angular()))
		{
			SetAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703136), _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA);
		}
	}

	public void G13D(double? X = null, double? Y = null, double? H = null, double? V = null, double? Q = null, double? R = null)
	{
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		double num3 = default(double);
		double? num2;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (8u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			if (3u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (6u != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			if (0 == 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		_ = base.ActiveSpeed;
		double? num5 = X;
		if (6u != 0)
		{
			num2 = num5;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (true)
		{
			base.ActiveX = activeX2;
		}
		double? num6 = Y;
		if (4u != 0)
		{
			num2 = num6;
		}
		double activeY2 = num2 ?? base.ActiveY;
		if (8u != 0)
		{
			base.ActiveY = activeY2;
		}
		double? num7 = H;
		if (8u != 0)
		{
			num2 = num7;
		}
		_0023_003DzY7q55ibyTX_n = num2 ?? _0023_003DzY7q55ibyTX_n;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double num8 = _0023_003DzY7q55ibyTX_n;
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		if (_0023_003DzVsFfuwI_003D == null || !(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)))
		{
			return;
		}
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
			if ((_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)._0023_003DzghtInQU_003D.Count == 0)
			{
				_0023_003DzVsFfuwI_003D.Feed = V;
			}
		}
		double value = Q ?? 0.0;
		double value2 = R ?? 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		double num11 = 0.0;
		int count = (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)._0023_003DzghtInQU_003D.Count;
		if (count > 0)
		{
			_0023_003DzmyBcQpGca4JiE8rKBhAoQrJBCYlk3QGbCk7hrZU_003D _0023_003DzmyBcQpGca4JiE8rKBhAoQrJBCYlk3QGbCk7hrZU_003D = (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)._0023_003DzghtInQU_003D[count - 1];
			num9 = _0023_003DzmyBcQpGca4JiE8rKBhAoQrJBCYlk3QGbCk7hrZU_003D._0023_003DziAO_TyQ_003D().Value;
			num10 = _0023_003DzmyBcQpGca4JiE8rKBhAoQrJBCYlk3QGbCk7hrZU_003D._0023_003DzQykhbpQ_003D().Value;
			num11 = _0023_003DzmyBcQpGca4JiE8rKBhAoQrJBCYlk3QGbCk7hrZU_003D._0023_003Dz2mrTZJQ_003D().Value;
		}
		else
		{
			num9 = (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D).StartX;
			num10 = (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D).StartY;
			num11 = (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D).StartZ.Value;
		}
		if ((num9 - _0023_003Dzu68XiBs_003D) * (num9 - _0023_003Dzu68XiBs_003D) + (num10 - _0023_003DzkCWBd1Y_003D) * (num10 - _0023_003DzkCWBd1Y_003D) + (num11 - num8) * (num11 - num8) < 2.0 * PrecisionExtension.Confusion())
		{
			num8 += 10.0 * PrecisionExtension.Confusion();
		}
		(_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)._0023_003DzghtInQU_003D.Add(new _0023_003DzmyBcQpGca4JiE8rKBhAoQrJBCYlk3QGbCk7hrZU_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, num8, V, value, value2));
	}

	public void G0R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? I = null, double? V = null, double? S = null, double? Q = null, double? B = null, double? D = null, string N = "", string T = "")
	{
		if (5u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		string empty = string.Empty;
		string _0023_003DzHMoneas_003D;
		if (6u != 0)
		{
			_0023_003DzHMoneas_003D = empty;
		}
		string empty2 = string.Empty;
		string _0023_003DzOiEjdhXyi_A_0024;
		if (8u != 0)
		{
			_0023_003DzOiEjdhXyi_A_0024 = empty2;
		}
		string empty3 = string.Empty;
		string _0023_003Dz5dh86BrVaX8U;
		if (6u != 0)
		{
			_0023_003Dz5dh86BrVaX8U = empty3;
		}
		double? num = A;
		double? num2 = default(double?);
		if (0 == 0)
		{
			num2 = num;
		}
		A = num2 ?? 0.0;
		double num3 = MathUtility.DegreeToRad(A.Value);
		if (0 == 0)
		{
			_0023_003DzRy81lOpVNjEq = num3;
		}
		double? num4 = Q;
		if (6u != 0)
		{
			num2 = num4;
		}
		Q = num2 ?? 0.0;
		double num5 = MathUtility.DegreeToRad(Q.Value);
		if (2u != 0)
		{
			_0023_003Dz7AJiHJhGO7iA = num5;
		}
		if (H.HasValue && H.Value != _0023_003Dzpl6fb1o_003D)
		{
			_0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D = new _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D();
			_0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2;
			if (7u != 0)
			{
				_0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2 = _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D;
			}
			if (2u != 0)
			{
				_0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2._0023_003DzX_0024LNB5PBcbRD = 0.0;
			}
			_0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2._0023_003DzAlJgo7FQaWc9 = 0.0;
			_0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2._0023_003Dz5iCIeOr_0024CF1u = H.Value;
			Workplane workplane = (workplane = base.Workplanes.Find(_0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2._0023_003DzdKICZPDjQ4QXP7itQg_003D_003D));
			if (base.Workplanes.Contains(workplane))
			{
				SelectWorkplane(workplane.Name);
			}
			else
			{
				string uniqueName = _projectInterface.GetUniqueName<Plane>(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715674));
				CreateWorkplane(uniqueName, _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2._0023_003DzX_0024LNB5PBcbRD, _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2._0023_003DzAlJgo7FQaWc9, _0023_003Dzmly14ugNk642rmbuc0SF9Uk_003D2._0023_003Dz5iCIeOr_0024CF1u, 0.0, 0.0);
			}
		}
		else
		{
			SelectWorkplane(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611));
		}
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			X += base.ActiveX;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			Y += base.ActiveY;
		}
		base.ActiveX = X ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		base.ActiveZ = Z ?? base.ActiveZ;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		_0023_003DzRvG13dw_003D = (((!(_0023_003DzRvG13dw_003D < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(_0023_003DzRvG13dw_003D > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(_0023_003DzRvG13dw_003D) : 0.0);
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		string uniqueName2 = _projectInterface.GetUniqueName<GeomCompositeCurve>(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715707));
		Polyline _0023_003DzqvJD5M4_003D = CreatePolyline(uniqueName2, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D);
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
			SetApproachStrategy(isLinear: true, isQuote: true, 0.0, V);
			base.ActiveLeadInOut._0023_003DzkT_bEnTQXtbfaDOtfp8tzGc_003D(0.0);
			base.ActiveLeadInOut._0023_003Dz914o0CEhd7ZygAE5IA_003D_003D(_0023_003Dz3keKASA_003D: false);
		}
		if (Z.HasValue)
		{
			base.ActiveZ = Z.Value;
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702922), (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() * (base.ActiveZ + ActiveZTransformation), 0.0);
		}
		if (H.HasValue)
		{
			_0023_003DzY7q55ibyTX_n = H.Value;
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703114), _0023_003DzY7q55ibyTX_n, 0.0);
		}
		if (A.HasValue)
		{
			SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703136), _0023_003DzRy81lOpVNjEq + _0023_003Dz7AJiHJhGO7iA, 0.0);
		}
		if (EdgeLoaded != null)
		{
			_0023_003DzG4_YXQjbwey_0024 = new Edge(EdgeLoaded);
			EdgeLoaded = null;
		}
		CoreTool _0023_003DzyagUmhsbHglp;
		ScmGroup.XCam.MachiningDataModel.Head _0023_003Dz9ybYj_0024UhnI6V;
		if (T != string.Empty)
		{
			_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
			if (_0023_003DzyagUmhsbHglp == null)
			{
				string text = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, _0023_003DzOiEjdhXyi_A_0024);
			}
			else
			{
				_0023_003DzaepqoE8sVHIF = _toolInterface.GetToolFamily(_0023_003DzyagUmhsbHglp).KindOfToolFamily.ToString();
				if (T != _0023_003DzHMoneas_003D)
				{
					_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
					AddToErrorFile(_errorString);
				}
				ActiveTools = T;
			}
		}
		else
		{
			T = ActiveTools;
			_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out _0023_003DzyagUmhsbHglp, out _0023_003Dz9ybYj_0024UhnI6V);
			if (_0023_003DzyagUmhsbHglp == null)
			{
				string text2 = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text2, _0023_003DzOiEjdhXyi_A_0024);
			}
			else
			{
				_0023_003DzaepqoE8sVHIF = _toolInterface.GetToolFamily(_0023_003DzyagUmhsbHglp).KindOfToolFamily.ToString();
				if (T != _0023_003DzHMoneas_003D)
				{
					_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715498));
					AddToErrorFile(_errorString);
				}
				ActiveTools = T;
			}
		}
		double _0023_003Dzzc8h9h0_003D = A ?? 0.0;
		double _0023_003Dzr9mC8No_003D = B ?? 0.0;
		TypeOfToolApproach _0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.ParallelXPositive;
		_0023_003DzXkaAIAHIaFaq0g95fA_003D_003D(I, ref _0023_003Dzr9mC8No_003D, ref _0023_003DzXlrGaU97yiX0F27zSA_003D_003D);
		int correction = _0023_003DzGXYQvSTndE5W0wzvLgDcN80_003D(base.ActiveToolCorrection.Correction);
		double overMaterial = base.ActiveToolCorrection.OverMaterial;
		ToolCorrection toolCorrection = new ToolCorrection();
		toolCorrection.CreateToolCorrection(correction, overMaterial);
		_0023_003DzVsFfuwI_003D = new _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D(_0023_003Dzzc8h9h0_003D, _0023_003Dzr9mC8No_003D, _0023_003DzXlrGaU97yiX0F27zSA_003D_003D, base.ActiveWorkplane, _0023_003DzqvJD5M4_003D, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, base.ActiveSpeed, base.ActiveMachineFunctions.HoodPosition, S, N, T, toolCorrection, D);
		SelectGeometry(_0023_003DzVsFfuwI_003D.GeometryPath.Name);
		_0023_003DzANMGQJiNz3Yo = TypeOfProcess.NotDefined;
	}

	public void G03D(double? X = null, double? Y = null, double? H = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? D = null, string N = "", string T = "")
	{
		if (6u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			double _0023_003Dz3keKASA_003D = V.Value;
			if (uint.MaxValue != 0)
			{
				_0023_003DzZGra6ZgrZzgF(_0023_003Dz3keKASA_003D);
			}
		}
		double? num2 = default(double?);
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (uint.MaxValue != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (5u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (0 == 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (true)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		base.ActiveX = X ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		_0023_003DzY7q55ibyTX_n = ((!H.HasValue) ? base.ActiveWorkpiece.Height : H.Value);
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double value = _0023_003DzY7q55ibyTX_n;
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		double value2 = Q ?? 0.0;
		double value3 = R ?? 0.0;
		_0023_003DzVsFfuwI_003D = new _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, value, V, value2, value3, (int?)E, S, N, T, D);
	}

	public void BO(double? X = null, double? Y = null, double? Z = null, double? V = null, double? R = null, double? x = null, double? y = null, double? D = null, double? L = null, double? G = null, string N = "")
	{
		if (2u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (x.HasValue)
		{
			x = _0023_003Dz9_0024sSLsNoyfJu(x.Value);
		}
		if (y.HasValue)
		{
			y = _0023_003Dz9_0024sSLsNoyfJu(y.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		if (x.HasValue)
		{
			x = _0023_003Dz9_0024sSLsNoyfJu(x.Value);
		}
		if (y.HasValue)
		{
			y = _0023_003Dz9_0024sSLsNoyfJu(y.Value);
		}
		double? num2;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (2u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (4u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (true)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (5u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double? num5 = X;
		if (2u != 0)
		{
			num2 = num5;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (true)
		{
			base.ActiveX = activeX2;
		}
		double? num6 = Y;
		if (2u != 0)
		{
			num2 = num6;
		}
		double activeY2 = num2 ?? base.ActiveY;
		if (7u != 0)
		{
			base.ActiveY = activeY2;
		}
		double? num7 = Z;
		if (4u != 0)
		{
			num2 = num7;
		}
		base.ActiveZ = num2 ?? base.ActiveZ;
		base.ActiveD = D ?? base.ActiveD;
		base.ActiveR = R ?? base.ActiveR;
		base.Activex = x ?? base.Activex;
		base.Activey = y ?? base.Activey;
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
		}
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		double _0023_003DzRvG13dw_003D = base.ActiveZ;
		double activeD = base.ActiveD;
		double activeR = base.ActiveR;
		double activex = base.Activex;
		double activey = base.Activey;
		_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
		_0023_003DzRvG13dw_003D = (((!(_0023_003DzRvG13dw_003D < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(_0023_003DzRvG13dw_003D > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(_0023_003DzRvG13dw_003D) : 0.0);
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		_0023_003DzNFM7tSWfuJW0(activex, activey, (int)activeR, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D);
		int dischargeSteps = ((int?)G) ?? 0;
		string uniqueName = _projectInterface.GetUniqueName<MachiningWorkingStep>(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705887), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
		double boringSpeed = V ?? 0.0;
		string kindOfHole = N ?? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448);
		double taperHeight = L ?? 0.0;
		if (_0023_003DznvXC_Qf6bz6i())
		{
			SetProbingReferenceReferencePoint(_0023_003DzJw91eKTxgLKYf1cniI_0024ZVJ3itRXYO6rhApDM54A_003D(_0023_003DzI9mONB48i_0024Gw));
		}
		CreateDrill(uniqueName, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, _0023_003DzRvG13dw_003D, activeD, string.Empty, TypeOfProcess.Drilling, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672), dischargeSteps, -1.0, boringSpeed, kindOfHole, taperHeight);
		ResetPattern();
	}

	public void DOWEL(double? X = null, double? Y = null, double? dowelDiameter = null, double? dowelLength = null, double? dowelOuterLength = null, double? glueThickness = null)
	{
		if (3u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (dowelDiameter.HasValue)
		{
			dowelDiameter = _0023_003Dz9_0024sSLsNoyfJu(dowelDiameter.Value);
		}
		if (dowelLength.HasValue)
		{
			dowelLength = _0023_003Dz9_0024sSLsNoyfJu(dowelLength.Value);
		}
		if (dowelOuterLength.HasValue)
		{
			dowelOuterLength = _0023_003Dz9_0024sSLsNoyfJu(dowelOuterLength.Value);
		}
		if (glueThickness.HasValue)
		{
			glueThickness = _0023_003Dz9_0024sSLsNoyfJu(glueThickness.Value);
		}
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			double? num2;
			if (8u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3 = default(double);
			if (0 == 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			double? num2;
			if (4u != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (true)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		base.ActiveX = X ?? base.ActiveX;
		base.ActiveY = Y ?? base.ActiveY;
		double _0023_003Dzu68XiBs_003D = base.ActiveX;
		double _0023_003DzkCWBd1Y_003D = base.ActiveY;
		_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		string uniqueName = _projectInterface.GetUniqueName<MachiningWorkingStep>(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706446), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
		if (_0023_003DznvXC_Qf6bz6i())
		{
			SetProbingReferenceReferencePoint(_0023_003DzJw91eKTxgLKYf1cniI_0024ZVJ3itRXYO6rhApDM54A_003D(_0023_003DzI9mONB48i_0024Gw));
		}
		CreateDowelOperation(uniqueName, _0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, dowelOuterLength, string.Empty, 0, -1, glueThickness, dowelDiameter, dowelLength, null, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
	}

	public void BR(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? B = null, double? D = null, double? G = null, string T = "")
	{
		if (6u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (H.HasValue)
		{
			H = _0023_003Dz9_0024sSLsNoyfJu(H.Value);
		}
		if (D.HasValue)
		{
			D = _0023_003Dz9_0024sSLsNoyfJu(D.Value);
		}
		double? num2;
		if (X.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
		{
			double? num = X;
			if (5u != 0)
			{
				num2 = num;
			}
			double activeX = base.ActiveX;
			double num3;
			if (8u != 0)
			{
				num3 = activeX;
			}
			X = num2 + num3;
		}
		if (Y.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
		{
			double? num4 = Y;
			if (uint.MaxValue != 0)
			{
				num2 = num4;
			}
			double activeY = base.ActiveY;
			double num3;
			if (4u != 0)
			{
				num3 = activeY;
			}
			Y = num2 + num3;
		}
		double? num5 = X;
		if (2u != 0)
		{
			num2 = num5;
		}
		double activeX2 = num2 ?? base.ActiveX;
		if (6u != 0)
		{
			base.ActiveX = activeX2;
		}
		double? num6 = Y;
		if (3u != 0)
		{
			num2 = num6;
		}
		double activeY2 = num2 ?? base.ActiveY;
		if (5u != 0)
		{
			base.ActiveY = activeY2;
		}
		double? num7 = Z;
		if (8u != 0)
		{
			num2 = num7;
		}
		base.ActiveZ = num2 ?? base.ActiveZ;
		if (V.HasValue)
		{
			V = _0023_003Dz6s5uDh6_0024tbw_0024(V.Value);
			_0023_003DzZGra6ZgrZzgF(V.Value);
		}
		Workplane activeWorkplane = base.ActiveWorkplane;
		string _0023_003DzHMoneas_003D = string.Empty;
		string _0023_003DzOiEjdhXyi_A_0024 = string.Empty;
		string _0023_003Dz5dh86BrVaX8U = string.Empty;
		string tool = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672);
		string kindOfHole = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672);
		double taperHeight = 0.0;
		if (T == string.Empty)
		{
			T = ActiveTools;
		}
		_0023_003DzsVv55tTke5wMx51iqw_003D_003D(T, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U, out var _0023_003DzyagUmhsbHglp, out var _0023_003Dz9ybYj_0024UhnI6V);
		bool flag = _0023_003DzbgBdFCN_0024ANguRGG9HMWCM1OSSB_0024L(_0023_003DzHMoneas_003D);
		if (_0023_003DzyagUmhsbHglp == null)
		{
			string text = (_0023_003Dz5dh86BrVaX8U.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, _0023_003DzOiEjdhXyi_A_0024);
			return;
		}
		SetPneumaticHoodPosition((int?)E);
		List<PosId> list = new List<PosId>();
		PosId item = default(PosId);
		item.x = 0.0;
		item.y = 0.0;
		item.z = 0.0;
		item.id = short.Parse(_0023_003DzOiEjdhXyi_A_0024);
		list.Add(item);
		if (!string.IsNullOrEmpty(_0023_003Dz5dh86BrVaX8U) && flag)
		{
			SpindleCollection spindleCollection = _0023_003DznGH5e16bcgiZCbKP0A_003D_003D(short.Parse(_0023_003DzOiEjdhXyi_A_0024));
			if (spindleCollection != null)
			{
				list.AddRange(_0023_003DzSHfpqA8_IBKRJkPqqzh_N2MLlPHQ(spindleCollection, short.Parse(_0023_003DzOiEjdhXyi_A_0024), A.HasValue ? A.Value : 0.0));
			}
			if (T != _0023_003DzHMoneas_003D)
			{
				list.AddRange(_0023_003DzNd0GmcgjUGZrti7C8DYZ39RGMzqt(T, short.Parse(_0023_003DzOiEjdhXyi_A_0024), A.HasValue ? A.Value : 0.0));
			}
		}
		foreach (PosId item2 in list)
		{
			double _0023_003Dzu68XiBs_003D = base.ActiveX + item2.x;
			double _0023_003DzkCWBd1Y_003D = base.ActiveY + item2.y;
			double _0023_003DzRvG13dw_003D = base.ActiveZ + item2.z;
			_0023_003DzLjiLCig_003D(ref _0023_003DzRvG13dw_003D, base.ActiveWorkplane);
			_0023_003DzRvG13dw_003D = (((!(_0023_003DzRvG13dw_003D < 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != 1) && (!(_0023_003DzRvG13dw_003D > 0.0) || _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() != -1)) ? abs(_0023_003DzRvG13dw_003D) : 0.0);
			_0023_003DzTspNS_o_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
			int id = item2.id;
			_0023_003DzyagUmhsbHglp = _0023_003Dzr5pDEey_jV2G(id.ToString(), _0023_003Dzilu43q8Cm59l(_0023_003DzHMoneas_003D));
			string uniqueName = _projectInterface.GetUniqueName<MachiningWorkingStep>(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705887), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
			if (T != _0023_003DzHMoneas_003D && !flag)
			{
				_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), uniqueName);
				AddToErrorFile(_errorString);
			}
			if (Q == 0.0)
			{
				AggregateComponent aggregateComponent = null;
				id = item2.id;
				aggregateComponent = (AggregateComponent)_0023_003DzXFnWHlj7DbiM(id.ToString());
				if (aggregateComponent != null)
				{
					double num8 = 0.0;
					if (aggregateComponent.AggregateBody is AdjustableAngleAggregateTool)
					{
						foreach (SpindleComponent spindleComponent in (aggregateComponent.AggregateBody as AdjustableAngleAggregateTool).AggregateToolsBody.SpindleComponents)
						{
							if (spindleComponent.Id == Convert.ToInt16(_0023_003DzOiEjdhXyi_A_0024))
							{
								num8 = spindleComponent.OriginPlacement.Rotation.AX;
								break;
							}
						}
					}
					A += num8;
				}
			}
			ActiveA = (A.HasValue ? A.Value : 0.0);
			ActiveB = (B.HasValue ? B.Value : 0.0);
			double? num9 = ActiveA;
			double? r = ActiveB;
			num9 -= 90.0;
			PL(_0023_003Dzu68XiBs_003D, _0023_003DzkCWBd1Y_003D, H ?? new double?(base.ActiveWorkpiece.Height), num9, r);
			double diameter = Convert.ToDouble(_toolInterface.GetToolPropertyValue(_0023_003DzyagUmhsbHglp.Key, KindOfToolProperty.Diameter).Value);
			if (!flag)
			{
				tool = _toolInterface.GetToolPropertyValue(_0023_003DzyagUmhsbHglp.Key, KindOfToolProperty.Name).Value;
			}
			else
			{
				_0023_003Dz9ybYj_0024UhnI6V.Number = -1;
				kindOfHole = _0023_003Dzm8J_0024kSNCTmcg(_toolInterface.GetToolType(_0023_003DzyagUmhsbHglp.Key).KindOfToolType);
				taperHeight = _0023_003Dz1ZkGY__0024q7UnYekYtmg_003D_003D(_0023_003DzyagUmhsbHglp);
			}
			int dischargeSteps = ((int?)G) ?? 0;
			double rotSpeed = S ?? 0.0;
			double boringSpeed = V ?? 0.0;
			CreateDrill(uniqueName, 0.0, 0.0, _0023_003DzRvG13dw_003D, diameter, string.Empty, TypeOfProcess.Drilling, tool, _0023_003Dz9ybYj_0024UhnI6V.Number.ToString(), dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight);
			ActiveTools = T;
		}
		ResetPneumaticHood();
		_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(activeWorkplane);
	}

	public void XEA(double? X = null, double? Y = null, double? Z = null, double? A = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? a = null, double? B = null, double? I = null, double? G = null, double? L = null, string T = "")
	{
		if (7u != 0)
		{
			CommitPendingProfile();
		}
		if (X.HasValue)
		{
			X = _0023_003Dz9_0024sSLsNoyfJu(X.Value);
		}
		if (Y.HasValue)
		{
			Y = _0023_003Dz9_0024sSLsNoyfJu(Y.Value);
		}
		if (Z.HasValue)
		{
			Z = _0023_003Dz9_0024sSLsNoyfJu(Z.Value);
		}
		if (I.HasValue)
		{
			I = _0023_003Dz9_0024sSLsNoyfJu(I.Value);
		}
		if (L.HasValue)
		{
			L = _0023_003Dz9_0024sSLsNoyfJu(L.Value);
		}
		throw new NotImplementedException();
	}

	public void PARK(double? S = null, double? Q = null)
	{
		if (true)
		{
			CommitPendingProfile();
		}
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707939);
		string stopType;
		if (5u != 0)
		{
			stopType = text;
		}
		double? num;
		if (8u != 0)
		{
			num = S;
		}
		if (num == 1.0)
		{
			stopType = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707939);
		}
		else if (S == 2.0)
		{
			stopType = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707956);
		}
		else if (S == 3.0)
		{
			stopType = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707967);
		}
		CreatePark(string.Empty, stopType, (Q == 1.0) ? true : false);
	}

	public double HeapGet(double index)
	{
		double result;
		if (8u != 0)
		{
			result = 0.0;
		}
		if (_0023_003Dznrery1Y_003D != null && index >= 0.0 && index < (double)_0023_003Dznrery1Y_003D.Length)
		{
			double num = _0023_003Dznrery1Y_003D[(int)index];
			if (8u != 0)
			{
				result = num;
			}
		}
		return result;
	}

	public double HeapPut(double index, double value)
	{
		_ = 2;
		if (4 == 0)
		{
		}
		if (_0023_003Dznrery1Y_003D != null)
		{
			_ = 0;
			if (8 == 0)
			{
			}
			if (index >= 0.0)
			{
				_ = 4;
				if (3 == 0)
				{
				}
				if (index < (double)_0023_003Dznrery1Y_003D.Length)
				{
					_0023_003Dznrery1Y_003D[(int)index] = value;
				}
			}
		}
		return value;
	}

	public void ESET(double a = 0.0, double r = 0.0, double s = 0.0, string N = null, double b = 0.0, double? c = null, long T = 0L, int manualEdgeLoading = 0, string rollerCode = null)
	{
		if (5u != 0)
		{
			CommitPendingProfile();
		}
	}

	public void EDGELinker(string name)
	{
		if (true)
		{
			EdgeLinker = name;
		}
	}

	public void EROT(double? A = null, double Q = 0.0)
	{
		if (A.HasValue)
		{
			double num = MathUtility.DegreeToRad(A.Value);
			double num2;
			if (2u != 0)
			{
				num2 = num;
			}
			double num3 = Math.PI / 2.0 + num2;
			if (7u != 0)
			{
				num2 = num3;
			}
			double activeEROT = num2;
			if (0 == 0)
			{
				ActiveEROT = activeEROT;
			}
		}
	}

	public void EOUT(double? Q = null, double? R = null, double? x = null, double? VOUT = null, double? TCSPI = null, double? BROT = null)
	{
		if (7u != 0)
		{
			CommitPendingProfile();
		}
	}

	public void ECLOSE(double? L = null)
	{
	}

	public void LB(double L = 0.0)
	{
		if (L != 0.0)
		{
			if (7u != 0)
			{
				ActiveLB = L;
			}
		}
	}

	public void LAMP(double Q = 0.0, double D = 0.0)
	{
		double? activeLAMP = Q;
		if (6u != 0)
		{
			ActiveLAMP = activeLAMP;
		}
	}

	public void STOP(string format)
	{
		double num = Convert.ToDouble(format.Remove(0, 4).Replace('.', ','));
		double activeSTOP;
		if (3u != 0)
		{
			activeSTOP = num;
		}
		if (5u != 0)
		{
			ActiveSTOP = activeSTOP;
		}
	}

	public void EIN(double? X = null, double? Y = null, double? A = null, double E = 0.0, double J = 0.0, double? startSpeed = null, double? R = null, double? B = null, double? D = null, double L = 0.0, int CUT = 0, int? ROT = null, int AUTOSTART = 1, double? TIN = null, double LAMP = 0.0, int? PHON = null, double? V_CAR = null)
	{
		if (0 == 0)
		{
			_0023_003DzANMGQJiNz3Yo = TypeOfProcess.EdgeBanding;
		}
	}

	public void ECUT(double? X = null, double? Y = null, string N = null, double? a = null, double? s = null, int Q = 1, int G = 1, string T = "", int? C = null)
	{
		if (true)
		{
			CommitPendingProfile();
		}
	}

	public void MSG(string Message, int? SBY = null)
	{
		if (2u != 0)
		{
			CommitPendingProfile();
		}
		bool releaseWorkpiece;
		if (6u != 0)
		{
			releaseWorkpiece = false;
		}
		bool waitForUserInput;
		if (2u != 0)
		{
			waitForUserInput = false;
		}
		if (SBY == 2 || SBY == 1)
		{
			waitForUserInput = true;
		}
		if (SBY == 2)
		{
			releaseWorkpiece = true;
		}
		CreateMessage(string.Empty, Message, waitForUserInput, releaseWorkpiece);
	}

	public void XHOODSUPP(int? Q, int? R, string N)
	{
		if (5u != 0)
		{
			CommitPendingProfile();
		}
		if (4u != 0)
		{
			SetAuxiliaryHoodPosition(Q);
		}
		if (6u != 0)
		{
			ActiveAuxiliaryHoodPosition = Q;
		}
		if (R.HasValue && R.Value == 1)
		{
			IsAuxiliaryHoodPositionModal = true;
		}
		else
		{
			IsAuxiliaryHoodPositionModal = false;
		}
	}

	public void PUSHOFF()
	{
		if (!_0023_003Dzdk3_wRkuVl8n())
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715339);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[1] { _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714051) };
			if (2u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		SetWorkPieceSidePresserDisabledOnStart(isWorkPieceSidePresserDisabledOnStart: true);
	}

	private Dictionary<string, object> _0023_003DzD10_0024v_JbGaDcpDWgqL0BvT8_003D(string _0023_003DzJ3hfjPs_003D, Dictionary<string, object> _0023_003DzrAVZPbjdfkkpqGlaxQ_003D_003D)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>(_0023_003DzrAVZPbjdfkkpqGlaxQ_003D_003D);
		Dictionary<string, object> dictionary2;
		if (6u != 0)
		{
			dictionary2 = dictionary;
		}
		Dictionary<string, NatureOfParameter> obj = (_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Keys.Contains(_0023_003DzJ3hfjPs_003D) ? _0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer[_0023_003DzJ3hfjPs_003D] : null);
		Dictionary<string, NatureOfParameter> dictionary3;
		if (true)
		{
			dictionary3 = obj;
		}
		Dictionary<string, double> obj2 = (_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Keys.Contains(_0023_003DzJ3hfjPs_003D) ? _0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D[_0023_003DzJ3hfjPs_003D] : null);
		Dictionary<string, double> dictionary4;
		if (uint.MaxValue != 0)
		{
			dictionary4 = obj2;
		}
		_0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM();
		object obj3 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026)];
		object value;
		if (2u != 0)
		{
			value = obj3;
		}
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026)] == null && dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026)))
		{
			object obj4 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026)];
			if (uint.MaxValue != 0)
			{
				value = obj4;
			}
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026)] = value;
		object obj5 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432)];
		object value2;
		if (7u != 0)
		{
			value2 = obj5;
		}
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432)] == null && dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432)))
		{
			object obj6 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432)];
			if (true)
			{
				value2 = obj6;
			}
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432)] = value2;
		object obj7 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170)];
		object value3;
		if (8u != 0)
		{
			value3 = obj7;
		}
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170)] == null && dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170)))
		{
			object obj8 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170)];
			if (true)
			{
				value3 = obj8;
			}
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170)] = value3;
		object obj9 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186)];
		object obj10;
		if (uint.MaxValue != 0)
		{
			obj10 = obj9;
		}
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186)))
			{
				obj10 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186)) && dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186)] == NatureOfParameter.Angle)
		{
			double num = (double)obj10;
			if (_0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
			{
				num = 0.0 - num;
			}
			obj10 = num;
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186)] = obj10;
		bool flag = false;
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] == null)
		{
			flag = dictionary4 == null || !dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)) || ((!(_0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))) ? (dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] != 3.0) : (dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] == 3.0));
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)) && dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] == NatureOfParameter.Verse)
		{
			if (_0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
			{
				if (_0023_003DzJ3hfjPs_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715313))
				{
					if ((double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] == 2.0)
					{
						flag = true;
					}
				}
				else if ((double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] == 3.0)
				{
					flag = true;
				}
			}
			else if (_0023_003DzJ3hfjPs_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715313))
			{
				if ((double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] == 3.0)
				{
					flag = true;
				}
			}
			else if ((double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] == 2.0)
			{
				flag = true;
			}
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)] = flag;
		object obj11 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178)];
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178)))
			{
				obj11 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178)) && dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178)] == NatureOfParameter.Radius && _0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
		{
			obj11 = (double)obj11 * -1.0;
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178)] = obj11;
		object obj12 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)];
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)))
			{
				obj12 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)))
		{
			if (dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)] == NatureOfParameter.Verse)
			{
				if (_0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					if ((double)obj12 == 1.0)
					{
						obj12 = 3;
					}
					else if ((double)obj12 == 3.0)
					{
						obj12 = 1;
					}
				}
			}
			else if (dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)] == NatureOfParameter.Corner && _0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
			{
				obj12 = Convert.ToDouble(string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714805), obj12).Replace('1', '5').Replace('2', '6')
					.Replace('3', '7')
					.Replace('4', '8')
					.Replace('5', '4')
					.Replace('6', '3')
					.Replace('7', '2')
					.Replace('8', '1'));
			}
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)] = obj12;
		object obj13 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)];
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)))
			{
				obj13 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)))
		{
			if (dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)] == NatureOfParameter.Correction)
			{
				if ((double)obj13 != 0.0 && _0023_003DzTJuyZiS0qOKz != _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
				{
					obj13 = (((double)obj13 != 1.0) ? 1 : 2);
				}
				int num2 = Convert.ToInt16(obj13);
				num2 = ((num2 != 1) ? 1 : 2);
				SetToolCorrection(num2);
			}
			else if (dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)] == NatureOfParameter.Boolean)
			{
				obj13 = (((double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)] != 0.0) ? ((object)false) : ((object)true));
			}
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)] = obj13;
		object obj14 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)];
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
			{
				obj14 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)) && dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)] == NatureOfParameter.Coordinate && _0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
		{
			obj14 = _0023_003DzOiU6nPw_003D - (double)obj14;
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)] = obj14;
		object obj15 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)];
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
			{
				obj15 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)) && dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)] == NatureOfParameter.Dimension && Convert.ToInt16(dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)]) == 2)
		{
			obj15 = (double)obj15 - 5.0;
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)] = obj15;
		object obj16 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946)];
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946)))
			{
				obj16 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946)) && dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946)] == NatureOfParameter.Coordinate && _0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
		{
			obj16 = ((!(_0023_003DzJ3hfjPs_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715446)) && !(_0023_003DzJ3hfjPs_003D == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715313))) ? ((object)(_0023_003DzOiU6nPw_003D - (double)obj16)) : ((object)(_0023_003DzOiU6nPw_003D - ((double)obj16 + (double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)]))));
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946)] = obj16;
		object obj17 = dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154)];
		if (dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154)] == null)
		{
			if (dictionary4 != null && dictionary4.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154)))
			{
				obj17 = dictionary4[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154)];
			}
		}
		else if (dictionary3 != null && dictionary3.Keys.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154)) && dictionary3[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154)] == NatureOfParameter.Coordinate && dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)] != null)
		{
			int num3 = Convert.ToInt16(dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962)]);
			double num4 = 0.0;
			if (_0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
			{
				switch (num3)
				{
				case 1:
				case 3:
					num4 += (double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)];
					num4 -= (double)obj17;
					num4 -= (double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010)];
					obj17 = num4;
					break;
				case 2:
					num4 += (double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)];
					num4 -= (double)obj17;
					num4 -= (double)dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010)];
					obj17 = num4;
					break;
				}
			}
		}
		dictionary2[_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154)] = obj17;
		return dictionary2;
	}

	private void _0023_003DzQuQblKN3oz6T(string _0023_003DzdVq9VFI_003D)
	{
		string empty = string.Empty;
		string _0023_003DzHMoneas_003D;
		if (6u != 0)
		{
			_0023_003DzHMoneas_003D = empty;
		}
		ref string currentMaestroTool = ref CurrentMaestroTool;
		ref string currentMaestroHead = ref CurrentMaestroHead;
		CoreTool _0023_003DzyagUmhsbHglp;
		if (true)
		{
			_0023_003DzsVv55tTke5wMx51iqw_003D_003D(_0023_003DzdVq9VFI_003D, ref _0023_003DzHMoneas_003D, ref currentMaestroTool, ref currentMaestroHead, out _0023_003DzyagUmhsbHglp, out var _);
		}
		if (_0023_003DzyagUmhsbHglp == null)
		{
			string obj = (CurrentMaestroHead.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
			string text;
			if (uint.MaxValue != 0)
			{
				text = obj;
			}
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null, text, CurrentMaestroTool);
		}
		else
		{
			CurrentMaestroHead = ((CurrentMaestroHead == string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714795) : Convert.ToString(Convert.ToInt16(CurrentMaestroHead) + 2));
			CurrentMaestroTool = _0023_003DzyagUmhsbHglp.Name;
			ActiveTools = _0023_003DzdVq9VFI_003D;
		}
	}

	private void _0023_003DzFbeHwXDeRUWK()
	{
		Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
		if (8u != 0)
		{
			_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D = dictionary;
		}
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		Dictionary<string, string> dictionary3;
		if (uint.MaxValue != 0)
		{
			dictionary3 = dictionary2;
		}
		Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
		if (2u != 0)
		{
			_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5 = dictionary4;
		}
		Dictionary<string, Dictionary<string, NatureOfParameter>> dictionary5 = new Dictionary<string, Dictionary<string, NatureOfParameter>>();
		if (6u != 0)
		{
			_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer = dictionary5;
		}
		Dictionary<string, Dictionary<string, double>> dictionary6 = new Dictionary<string, Dictionary<string, double>>();
		if (2u != 0)
		{
			_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D = dictionary6;
		}
		Dictionary<string, NatureOfParameter> dictionary7 = new Dictionary<string, NatureOfParameter>();
		Dictionary<string, NatureOfParameter> dictionary8;
		if (7u != 0)
		{
			dictionary8 = dictionary7;
		}
		Dictionary<string, double> dictionary9 = new Dictionary<string, double>();
		Dictionary<string, double> dictionary10;
		if (true)
		{
			dictionary10 = dictionary9;
		}
		if (!_0023_003Dzdk3_wRkuVl8n())
		{
			return;
		}
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715285);
		string text2 = default(string);
		if (0 == 0)
		{
			text2 = text;
		}
		string text3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715266);
		string key = default(string);
		if (0 == 0)
		{
			key = text3;
		}
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(text2, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714787));
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714787));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714768), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714757), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714750), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714739), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715194));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714954), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714932), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714921), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		Dictionary<string, Dictionary<string, string>> dictionary11 = _0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D;
		string key2 = text2;
		Func<KeyValuePair<string, string>, string> func = _0023_003DzJBaCSp8_003D._0023_003DzbbjOLY6Hp88WVXUMVg_003D_003D;
		if (func == null)
		{
			func = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz7i4BnHi6274dB0We8dUmHPU_003D;
			Func<KeyValuePair<string, string>, string> _0023_003DzbbjOLY6Hp88WVXUMVg_003D_003D = func;
			if (true)
			{
				_0023_003DzJBaCSp8_003D._0023_003DzbbjOLY6Hp88WVXUMVg_003D_003D = _0023_003DzbbjOLY6Hp88WVXUMVg_003D_003D;
			}
		}
		dictionary11.Add(key2, dictionary3.ToDictionary(func, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzmXbVi4ByxHmLQhfiuV2SgpQ_003D, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), NatureOfParameter.Verse);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178), NatureOfParameter.Radius);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), NatureOfParameter.Correction);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), NatureOfParameter.Coordinate);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946), NatureOfParameter.Coordinate);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(text2, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzLO0XwHJkxy803XJKonuYTS4_003D, (KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzPi9UJpIIwn7hxsVQBtrbWUI_003D, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzndOMV55Kz7UzOnfR_WetPfs_003D));
		dictionary10.Clear();
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), 2.0);
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(text2, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz8PJZARorEEJxSG_SiMtSNT8_003D, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzaX22V8aKV5sHDmQ8tVn0vR0_003D));
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzlDb_6Zf34dVXvVMtYZQVx5ULjvWG, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzJK7vYwPUsu6vkUvcAbFA8_7BrvnX));
		string key3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715205);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key3, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714891));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714876), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714863), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714854), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714841), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714832), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715194));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714819), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714553));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key3, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzHWYffBj2b2SRUoRNIDsiVRgr9vCA, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), NatureOfParameter.NotUsed);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), NatureOfParameter.Coordinate);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715186), NatureOfParameter.Angle);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key3, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzvnPLBw2k6BfkYenepfMBMbnrRR7Q, (KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary10.Clear();
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), 2.0);
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key3, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzQFyixF_AOcInuhRyN8NQl2PzmxiF, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzhBvMqSI7r6yUFaRTvAR40Py0CUiN));
		string key4 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715313);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key4, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714545));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714768), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714531), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714524), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714841), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714511), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714502), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714489), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714932), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714921), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key4, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzDoxLACUNE38G5zL18cOST5J0dLox, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzDfI_IX7JicI9TnvM4vX1GErMY1K4));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), NatureOfParameter.Verse);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962), NatureOfParameter.Verse);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), NatureOfParameter.Correction);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946), NatureOfParameter.Coordinate);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715154), NatureOfParameter.Coordinate);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), NatureOfParameter.Dimension);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key4, dictionary8.ToDictionary((KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzR2lwstlZQQZWOUQ2jqanVVPMAF3I));
		dictionary10.Clear();
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), 2.0);
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key4, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz9pJ5OFovUUedRSpphL60u9NBMqOd, (KeyValuePair<string, double> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		string key5 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715246);
		string key6 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715226);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key5, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714480));
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key6, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714480));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714768), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714757), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714750), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714739), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715194));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714932), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key5, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzxKg3TRQxCMJgBiUbqsD2ovIFZ6kx, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key6, dictionary3.ToDictionary((KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz3AQy6GFkLkD4Lbed5rARqluQdtaG));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), NatureOfParameter.Correction);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), NatureOfParameter.Coordinate);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946), NatureOfParameter.Coordinate);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key5, dictionary8.ToDictionary((KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dzt8seMGRMleCO7NuaW739Br_xGmXI));
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key6, dictionary8.ToDictionary((KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzFsIPGIBpL_QNyTlaCFoecjWfYQ1p));
		string key7 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714460);
		string key8 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714442);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key7, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714679));
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key8, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714679));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714768), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714757), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714932), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key7, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzoKJRvCAfo4pNTkFKTJNOp8BCNG_U, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key8, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzMdC_mgJh70mP9K_YSTWwe3wffodD, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), NatureOfParameter.Correction);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946), NatureOfParameter.Coordinate);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key7, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dzt9GA1zh8p9KVEShPmntAEhcSVzwR, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzjauFdN2LCBai6Kcwr3BcADdVKrqd));
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key8, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzEDALZiYt5Vs16eQKEQ25s3ufEtPq, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz4YBcmedik7DORYUKHZOjE4_wkUnv));
		string key9 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715370);
		string key10 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715353);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key9, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714661));
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key10, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714661));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714954), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714648));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714921), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714637), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714623), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key9, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzNZuKuukWnS8VOSnXRf3ijg3KpKH1, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzErNWCVMhKuAfcmzkxlqyzfkrLJnc));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key10, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzrTfunYI319bS7yU6N2TY04WlvKSh, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), NatureOfParameter.Verse);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962), NatureOfParameter.Corner);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), NatureOfParameter.Boolean);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key9, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzoUHY887RMAAiwUV2BENLKsQBCe6U, (KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key10, dictionary8.ToDictionary((KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzRV8RBHhAaMblI2ew9g4kK_QOzT0k));
		dictionary10.Clear();
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), 2.0);
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key9, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz_BvZQ2qIVkVDjDzXpH_7pymqYlQ6, (KeyValuePair<string, double> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key10, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzSs9wWHjN6O5huY0mgCaTayB3NTWG, (KeyValuePair<string, double> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		string key11 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715299);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key11, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714611));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714768), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714757), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714954), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714932), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714921), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key11, dictionary3.ToDictionary((KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), NatureOfParameter.Verse);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), NatureOfParameter.Correction);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), NatureOfParameter.Coordinate);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key11, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzHpTnO3YTEL05AcSPKPSSLbWOKukR, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzsxOyx1fWC7wMFK4t2D1eRu0_KTX7));
		dictionary10.Clear();
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), 1.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146), 2.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440), 5.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432), 5.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178), 1.0);
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key11, dictionary10.ToDictionary((KeyValuePair<string, double> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, (KeyValuePair<string, double> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		string key12 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715446);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key12, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714595));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714768), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714524), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714962));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714841), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714511), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714719), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714706), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714689), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714932), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key12, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz_Ce35Vn6jLfNYrDnvNN0kIYdBSPZ, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978), NatureOfParameter.Correction);
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714946), NatureOfParameter.Coordinate);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key12, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzioozCZCg7ditDXp3uZD7K8mlutS_, (KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		string key13 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715432);
		string key14 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715416);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key13, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714581));
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key14, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714581));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714876), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714863), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714572), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key13, dictionary3.ToDictionary((KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, (KeyValuePair<string, string> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key14, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dzb3w93asN_8znyn3WPwaBsBYbB4Md, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz2RKijhjPCJp6lxcJTt2VWYCtmN_A));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), NatureOfParameter.Coordinate);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key13, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dzj4ZhSdRHu7teOrFQ4hd2EqvAoYCU, (KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key14, dictionary8.ToDictionary((KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, (KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary10.Clear();
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), _0023_003DzOiU6nPw_003D / 2.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), _0023_003DzUUAAhCE_003D / 2.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170), 250.0);
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key13, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzRQpoGmDRr15liS3TxTeSWweInNc3, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzSgGTyhV6qiddkIYKEcuMgeD3gKFY));
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key14, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DztMtebJAxxY5o4Qg8kR8dsa7towiU, (KeyValuePair<string, double> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		string key15 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715399);
		string key16 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715383);
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key15, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713279));
		_0023_003DzcQFfk48J_00242W2S87U6CtnG_YpHjx5.Add(key16, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713279));
		dictionary3.Clear();
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714876), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714863), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714841), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714832), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714819), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715178));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714732), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715042));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714903), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715111));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708010), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715138));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713267), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713255));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714854), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715002));
		dictionary3.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key15, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzKE8uWJkxtW_QroMLlMODLNX3C0Nz, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dzk3sHW04cfawFkhG8h53yQrNN1XrF));
		_0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Add(key16, dictionary3.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzWJBLolmnvSq2jTkQP5lttmvQqvyr, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzyWxUVKZDqEgNceXEkrcIiXOdMaWr));
		dictionary8.Clear();
		dictionary8.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), NatureOfParameter.Coordinate);
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key15, dictionary8.ToDictionary((KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dzlmp8wyAm9fpxPQsb1vpG31wzmtwd));
		_0023_003Dz2KnG9Slge1jzKdQz4JgPAqCRJFer.Add(key16, dictionary8.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dzmhm4eKDfIpYg3AFKXm8QE9hKWfz1, (KeyValuePair<string, NatureOfParameter> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Value));
		dictionary10.Clear();
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), _0023_003DzOiU6nPw_003D / 2.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), _0023_003DzUUAAhCE_003D / 2.0);
		dictionary10.Add(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440), 300.0);
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key15, dictionary10.ToDictionary(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzCrRw9RaLsRan8EcBpKNvG5Adatj_, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzQP5MBhg6iCGIHJyyY7gV18L0Mcpk));
		_0023_003Dzm9PkfvyJ_kNUiBYPkAaRDs0_003D.Add(key16, dictionary10.ToDictionary((KeyValuePair<string, double> _0023_003Dz_HHC00I_003D) => _0023_003Dz_HHC00I_003D.Key, _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz57diJOtGtNF5lSMcGLDpOKerDbyN));
	}

	private bool _0023_003Dz3qO1jRSvTOjZq6Y8sg_003D_003D(string _0023_003DzJ3hfjPs_003D)
	{
		_ = 0;
		if (2 == 0)
		{
		}
		Dictionary<string, Dictionary<string, string>>.KeyCollection keys = _0023_003DzTV1wwM7vzbD1vkbWmay9_EI_003D.Keys;
		_ = 8;
		if (7 == 0)
		{
		}
		if (keys.Contains(_0023_003DzJ3hfjPs_003D))
		{
			return true;
		}
		return false;
	}

	private void _0023_003DzTspNS_o_003D(ref double _0023_003Dzu68XiBs_003D, ref double _0023_003DzkCWBd1Y_003D, Workplane _0023_003DzHn3qReygMhit)
	{
		double num;
		if (2u != 0)
		{
			num = double.MinValue;
		}
		double num2;
		if (8u != 0)
		{
			num2 = double.MinValue;
		}
		double num3 = _0023_003DzOiU6nPw_003D;
		double _0023_003DzLM0wz_0024tKgqjc;
		if (true)
		{
			_0023_003DzLM0wz_0024tKgqjc = num3;
		}
		double num4 = _0023_003DzUUAAhCE_003D;
		double _0023_003Dzfr7Tser4Y_0024iT;
		if (4u != 0)
		{
			_0023_003Dzfr7Tser4Y_0024iT = num4;
		}
		if (ActiveTransformation.HasRotation())
		{
			ActiveTransformation.Rotate(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D);
		}
		if (ActiveTransformation.HasTranslation(_0023_003DzHn3qReygMhit.Name))
		{
			ActiveTransformation.Translate(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, _0023_003DzHn3qReygMhit.Name);
		}
		if (ActiveTransformation.HasMirror())
		{
			if (5u != 0)
			{
				_0023_003DzfqlvaQlTPR3SHq3gygBOUdI_003D(ref _0023_003DzLM0wz_0024tKgqjc, ref _0023_003Dzfr7Tser4Y_0024iT, _0023_003DzHn3qReygMhit);
			}
			ActiveTransformation.Mirror(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, _0023_003DzLM0wz_0024tKgqjc, _0023_003Dzfr7Tser4Y_0024iT);
		}
		if (_0023_003DzHD5fHZnBd7Nm != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.ContainsKey(base.ActiveWorkplane.Name))
		{
			if (_0023_003DzHD5fHZnBd7Nm.PlanesWithInvertedAxis.Exists(_0023_003DzyjjJriNoVkOnVk90KA_003D_003D))
			{
				double num5 = _0023_003Dzu68XiBs_003D;
				if (3u != 0)
				{
					num = num5;
				}
				_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
				_0023_003DzkCWBd1Y_003D = num;
			}
			double xDimension = _0023_003DzHn3qReygMhit.XDimension;
			if (0 == 0)
			{
				_0023_003DzLM0wz_0024tKgqjc = xDimension;
			}
			double yDimension = _0023_003DzHn3qReygMhit.YDimension;
			if (6u != 0)
			{
				_0023_003Dzfr7Tser4Y_0024iT = yDimension;
			}
			_0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.TryGetValue(base.ActiveWorkplane.Name, out var value);
			switch (value)
			{
			case Specularity.SpecX:
				_0023_003Dzu68XiBs_003D = _0023_003DzLM0wz_0024tKgqjc - _0023_003Dzu68XiBs_003D;
				break;
			case Specularity.SpecY:
				_0023_003DzkCWBd1Y_003D = _0023_003Dzfr7Tser4Y_0024iT - _0023_003DzkCWBd1Y_003D;
				break;
			case Specularity.SpecXY:
				_0023_003Dzu68XiBs_003D = _0023_003DzLM0wz_0024tKgqjc - _0023_003Dzu68XiBs_003D;
				_0023_003DzkCWBd1Y_003D = _0023_003Dzfr7Tser4Y_0024iT - _0023_003DzkCWBd1Y_003D;
				break;
			case Specularity.None:
				break;
			}
			return;
		}
		bool num6 = _0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D();
		bool flag;
		if (4u != 0)
		{
			flag = num6;
		}
		if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				string text2;
				if (2u != 0)
				{
					text2 = text;
				}
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3356228888u)
				{
					if (num7 <= 3255563174u)
					{
						if (num7 != 3222007936u)
						{
							if (num7 != 3238785555u)
							{
								if (num7 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
								{
									goto IL_03bf;
								}
							}
							else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
							{
								goto IL_03af;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_03bf;
						}
					}
					else if (num7 != 3272340793u)
					{
						if (num7 != 3339451269u)
						{
							if (num7 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
							{
								goto IL_03bf;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_03af;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_03cf;
					}
				}
				else if (num7 <= 3406561745u)
				{
					if (num7 != 3373006507u)
					{
						if (num7 != 3389784126u)
						{
							if (num7 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
							{
								goto IL_03cf;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_03bf;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_03af;
					}
				}
				else if (num7 != 3440116983u)
				{
					if (num7 != 3473672221u)
					{
						if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_03cf;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_03af;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_03cf;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3373006507u)
				{
					if (num7 <= 3289118412u)
					{
						if (num7 != 3238785555u)
						{
							if (num7 != 3272340793u)
							{
								if (num7 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
								{
									goto IL_05cb;
								}
							}
							else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_05f6;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_05db;
						}
					}
					else if (num7 != 3322673650u)
					{
						if (num7 != 3339451269u)
						{
							if (num7 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
							{
								goto IL_05db;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_05db;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_05cb;
					}
				}
				else if (num7 <= 3440116983u)
				{
					if (num7 != 3406561745u)
					{
						if (num7 != 3423339364u)
						{
							if (num7 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
							{
								goto IL_05f6;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_05cb;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_05f6;
					}
				}
				else if (num7 != 3456894602u)
				{
					if (num7 != 3473672221u)
					{
						if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_05f6;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_05db;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_05cb;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3356228888u)
				{
					if (num7 <= 3272340793u)
					{
						if (num7 <= 3238785555u)
						{
							if (num7 != 3222007936u)
							{
								if (num7 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_08d6;
								}
							}
							else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_08e5;
							}
						}
						else if (num7 != 3255563174u)
						{
							if (num7 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_08e5;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_08e5;
						}
					}
					else if (num7 <= 3322673650u)
					{
						if (num7 != 3289118412u)
						{
							if (num7 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_08d6;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_08d6;
						}
					}
					else if (num7 != 3339451269u)
					{
						if (num7 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_08e5;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_08d6;
					}
				}
				else if (num7 <= 3423339364u)
				{
					if (num7 <= 3389784126u)
					{
						if (num7 != 3373006507u)
						{
							if (num7 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_08e5;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_08d6;
						}
					}
					else if (num7 != 3406561745u)
					{
						if (num7 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_08d6;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_08e5;
					}
				}
				else if (num7 <= 3456894602u)
				{
					if (num7 != 3440116983u)
					{
						if (num7 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_08d6;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_08e5;
					}
				}
				else if (num7 != 3473672221u)
				{
					if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_08e5;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_08d6;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3356228888u)
				{
					if (num7 <= 3272340793u)
					{
						if (num7 <= 3238785555u)
						{
							if (num7 != 3222007936u)
							{
								if (num7 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_0beb;
								}
							}
							else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_0c39;
							}
						}
						else if (num7 != 3255563174u)
						{
							if (num7 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0c39;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_0c39;
						}
					}
					else if (num7 <= 3322673650u)
					{
						if (num7 != 3289118412u)
						{
							if (num7 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_0beb;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_0beb;
						}
					}
					else if (num7 != 3339451269u)
					{
						if (num7 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_0c39;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0beb;
					}
				}
				else if (num7 <= 3423339364u)
				{
					if (num7 <= 3389784126u)
					{
						if (num7 != 3373006507u)
						{
							if (num7 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_0c39;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0beb;
						}
					}
					else if (num7 != 3406561745u)
					{
						if (num7 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_0beb;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0c39;
					}
				}
				else if (num7 <= 3456894602u)
				{
					if (num7 != 3440116983u)
					{
						if (num7 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_0beb;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_0c39;
					}
				}
				else if (num7 != 3473672221u)
				{
					if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0c39;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0beb;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3356228888u)
				{
					if (num7 <= 3272340793u)
					{
						if (num7 <= 3238785555u)
						{
							if (num7 != 3222007936u)
							{
								if (num7 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_0f21;
								}
							}
							else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_0f6f;
							}
						}
						else if (num7 != 3255563174u)
						{
							if (num7 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0f6f;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_0f6f;
						}
					}
					else if (num7 <= 3322673650u)
					{
						if (num7 != 3289118412u)
						{
							if (num7 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_0f21;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_0f21;
						}
					}
					else if (num7 != 3339451269u)
					{
						if (num7 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_0f6f;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0f21;
					}
				}
				else if (num7 <= 3423339364u)
				{
					if (num7 <= 3389784126u)
					{
						if (num7 != 3373006507u)
						{
							if (num7 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_0f6f;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0f21;
						}
					}
					else if (num7 != 3406561745u)
					{
						if (num7 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_0f21;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0f6f;
					}
				}
				else if (num7 <= 3456894602u)
				{
					if (num7 != 3440116983u)
					{
						if (num7 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_0f21;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_0f6f;
					}
				}
				else if (num7 != 3473672221u)
				{
					if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0f6f;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0f21;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3356228888u)
				{
					if (num7 <= 3272340793u)
					{
						if (num7 <= 3238785555u)
						{
							if (num7 != 3222007936u)
							{
								if (num7 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_122d;
								}
							}
							else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_123c;
							}
						}
						else if (num7 != 3255563174u)
						{
							if (num7 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_123c;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_123c;
						}
					}
					else if (num7 <= 3322673650u)
					{
						if (num7 != 3289118412u)
						{
							if (num7 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_122d;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_122d;
						}
					}
					else if (num7 != 3339451269u)
					{
						if (num7 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_123c;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_122d;
					}
				}
				else if (num7 <= 3423339364u)
				{
					if (num7 <= 3389784126u)
					{
						if (num7 != 3373006507u)
						{
							if (num7 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_123c;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_122d;
						}
					}
					else if (num7 != 3406561745u)
					{
						if (num7 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_122d;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_123c;
					}
				}
				else if (num7 <= 3456894602u)
				{
					if (num7 != 3440116983u)
					{
						if (num7 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_122d;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_123c;
					}
				}
				else if (num7 != 3473672221u)
				{
					if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_123c;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_122d;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3373006507u)
				{
					if (num7 <= 3272340793u)
					{
						if (num7 != 3238785555u)
						{
							if (num7 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_13f3;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_13f3;
						}
					}
					else if (num7 != 3339451269u)
					{
						if (num7 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_13f3;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_13f3;
					}
				}
				else if (num7 <= 3440116983u)
				{
					if (num7 != 3406561745u)
					{
						if (num7 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_13f3;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_13f3;
					}
				}
				else if (num7 != 3473672221u)
				{
					if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_13f3;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_13f3;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3373006507u)
				{
					if (num7 <= 3272340793u)
					{
						if (num7 != 3238785555u)
						{
							if (num7 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_154b;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_154b;
						}
					}
					else if (num7 != 3339451269u)
					{
						if (num7 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_154b;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_154b;
					}
				}
				else if (num7 <= 3440116983u)
				{
					if (num7 != 3406561745u)
					{
						if (num7 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_154b;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_154b;
					}
				}
				else if (num7 != 3473672221u)
				{
					if (num7 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_154b;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_154b;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3322673650u)
				{
					if (num7 <= 3255563174u)
					{
						if (num7 != 3222007936u)
						{
							if (num7 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_16c7;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_16c7;
						}
					}
					else if (num7 != 3289118412u)
					{
						if (num7 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_16c7;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_16c7;
					}
				}
				else if (num7 <= 3389784126u)
				{
					if (num7 != 3356228888u)
					{
						if (num7 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_16c7;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_16c7;
					}
				}
				else if (num7 != 3423339364u)
				{
					if (num7 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_16c7;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_16c7;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num7 <= 3322673650u)
				{
					if (num7 <= 3255563174u)
					{
						if (num7 != 3222007936u)
						{
							if (num7 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_181f;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_181f;
						}
					}
					else if (num7 != 3289118412u)
					{
						if (num7 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_181f;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_181f;
					}
				}
				else if (num7 <= 3389784126u)
				{
					if (num7 != 3356228888u)
					{
						if (num7 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_181f;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_181f;
					}
				}
				else if (num7 != 3423339364u)
				{
					if (num7 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_181f;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_181f;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601))
		{
			if (!flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
				}
			}
		}
		else if (!_0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D())
		{
			_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		}
		goto IL_187f;
		IL_13f3:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_187f;
		IL_05f6:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_187f;
		IL_0f6f:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		goto IL_187f;
		IL_122d:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		goto IL_187f;
		IL_08e5:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		goto IL_187f;
		IL_05cb:
		_0023_003DzkCWBd1Y_003D = _0023_003DzUUAAhCE_003D - _0023_003DzkCWBd1Y_003D;
		goto IL_187f;
		IL_16c7:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_187f;
		IL_08d6:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		goto IL_187f;
		IL_187f:
		_0023_003DzuaROiMG7Uoby(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, _0023_003DzTJuyZiS0qOKz);
		return;
		IL_0f21:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		goto IL_187f;
		IL_03af:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_187f;
		IL_0c39:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		goto IL_187f;
		IL_181f:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_187f;
		IL_154b:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_187f;
		IL_05db:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		_0023_003DzkCWBd1Y_003D = _0023_003DzUUAAhCE_003D - _0023_003DzkCWBd1Y_003D;
		goto IL_187f;
		IL_123c:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		goto IL_187f;
		IL_03bf:
		_0023_003DzkCWBd1Y_003D = _0023_003DzUUAAhCE_003D - _0023_003DzkCWBd1Y_003D;
		goto IL_187f;
		IL_0beb:
		num = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		num2 = _0023_003DzOiU6nPw_003D;
		_0023_003DzOiU6nPw_003D = _0023_003DzUUAAhCE_003D;
		_0023_003DzUUAAhCE_003D = num2;
		goto IL_187f;
		IL_03cf:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		_0023_003DzkCWBd1Y_003D = _0023_003DzUUAAhCE_003D - _0023_003DzkCWBd1Y_003D;
		goto IL_187f;
	}

	private void _0023_003DzuaROiMG7Uoby(ref double _0023_003Dzu68XiBs_003D, ref double _0023_003DzkCWBd1Y_003D, string _0023_003Dz25U2Th3DyD2d)
	{
		bool _0023_003Dz0ph406aCgMed;
		if (4u != 0)
		{
			_0023_003Dz0ph406aCgMed = false;
		}
		bool _0023_003DzlKR5uBnaRzxK;
		if (5u != 0)
		{
			_0023_003DzlKR5uBnaRzxK = false;
		}
		if (!_0023_003Dzpua6XFTbs4Qx(_0023_003Dz25U2Th3DyD2d, ref _0023_003Dz0ph406aCgMed, ref _0023_003DzlKR5uBnaRzxK) && base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
		{
			if (_0023_003Dz0ph406aCgMed)
			{
				_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
			}
			if (_0023_003DzlKR5uBnaRzxK)
			{
				_0023_003DzkCWBd1Y_003D = _0023_003DzUUAAhCE_003D - _0023_003DzkCWBd1Y_003D;
			}
		}
		if (_0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D())
		{
			if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
			{
				_0023_003DzkCWBd1Y_003D = _0023_003DzUUAAhCE_003D - _0023_003DzkCWBd1Y_003D;
			}
			else if (_0023_003Dz25U2Th3DyD2d[0] == 'J' && (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553) || base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565)))
			{
				_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
			}
			else if (_0023_003Dz25U2Th3DyD2d[0] == 'B' && base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601))
			{
				_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
			}
		}
	}

	private void _0023_003DzLjiLCig_003D(ref double _0023_003DzRvG13dw_003D, Workplane _0023_003DzHn3qReygMhit)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		Transformation activeTransformation = ActiveTransformation;
		_ = 7;
		if (-1 == 0)
		{
		}
		if (activeTransformation.HasTranslation(_0023_003DzHn3qReygMhit.Name))
		{
			_ = 8;
			if (5 == 0)
			{
			}
			ActiveTransformation.Translate(ref _0023_003DzRvG13dw_003D, _0023_003DzHn3qReygMhit.Name);
		}
	}

	private bool _0023_003Dzpua6XFTbs4Qx(string _0023_003Dz25U2Th3DyD2d, ref bool _0023_003Dz0ph406aCgMed, ref bool _0023_003DzlKR5uBnaRzxK)
	{
		bool result;
		if (3u != 0)
		{
			result = true;
		}
		Specularity specularity2;
		if (_configurationInterface != null && _configurationInterface.IsConfigurationInitialized && _configurationInterface.IsInitialized)
		{
			WorkingArea workingArea = _configurationInterface.GetWorkingArea(_0023_003Dz25U2Th3DyD2d);
			WorkingArea workingArea2;
			if (8u != 0)
			{
				workingArea2 = workingArea;
			}
			bool num = _0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D();
			bool flag;
			if (8u != 0)
			{
				flag = num;
			}
			if (workingArea2 != null && !_0023_003Dzs854AHxGxXXFjErcriLOPtQ_003D())
			{
				if (!_0023_003Dzdk3_wRkuVl8n() && !_0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D() && !_0023_003Dz_0024Sv7nzkwT1flKsIEPhVWIzM_003D(_0023_003Dz25U2Th3DyD2d, workingArea2.PiecesDispositionQuadrant))
				{
					string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713223);
					string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
					object[] parameters = Array.Empty<object>();
					if (0 == 0)
					{
						ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
					}
				}
				Specularity specularity = workingArea2.Specularity;
				if (6u != 0)
				{
					specularity2 = specularity;
				}
				if (flag)
				{
					uint num2 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(_0023_003Dz25U2Th3DyD2d);
					uint num3;
					if (6u != 0)
					{
						num3 = num2;
					}
					if (num3 <= 3356228888u)
					{
						if (num3 <= 3272340793u)
						{
							if (num3 <= 3238785555u)
							{
								if (num3 != 3222007936u)
								{
									if (num3 == 3238785555u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
									{
										goto IL_03e3;
									}
								}
								else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
								{
									goto IL_042d;
								}
							}
							else if (num3 != 3255563174u)
							{
								if (num3 == 3272340793u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
								{
									goto IL_0471;
								}
							}
							else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_042d;
							}
						}
						else if (num3 <= 3322673650u)
						{
							if (num3 != 3289118412u)
							{
								if (num3 == 3322673650u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
								{
									goto IL_038d;
								}
							}
							else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_038d;
							}
						}
						else if (num3 != 3339451269u)
						{
							if (num3 == 3356228888u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
							{
								goto IL_042d;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_03e3;
						}
					}
					else if (num3 <= 3423339364u)
					{
						if (num3 <= 3389784126u)
						{
							if (num3 != 3373006507u)
							{
								if (num3 == 3389784126u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
								{
									goto IL_042d;
								}
							}
							else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
							{
								goto IL_03e3;
							}
						}
						else if (num3 != 3406561745u)
						{
							if (num3 == 3423339364u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
							{
								goto IL_038d;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_0471;
						}
					}
					else if (num3 <= 3456894602u)
					{
						if (num3 != 3440116983u)
						{
							if (num3 == 3456894602u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
							{
								goto IL_038d;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_0471;
						}
					}
					else if (num3 != 3473672221u)
					{
						if (num3 == 3574337935u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_0471;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_03e3;
					}
				}
				else
				{
					uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(_0023_003Dz25U2Th3DyD2d);
					if (num3 <= 3356228888u)
					{
						if (num3 <= 3272340793u)
						{
							if (num3 <= 3238785555u)
							{
								if (num3 != 3222007936u)
								{
									if (num3 == 3238785555u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
									{
										goto IL_07ad;
									}
								}
								else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
								{
									goto IL_07f1;
								}
							}
							else if (num3 != 3255563174u)
							{
								if (num3 == 3272340793u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
								{
									goto IL_0829;
								}
							}
							else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_07f1;
							}
						}
						else if (num3 <= 3322673650u)
						{
							if (num3 != 3289118412u)
							{
								if (num3 == 3322673650u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
								{
									goto IL_0769;
								}
							}
							else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_0769;
							}
						}
						else if (num3 != 3339451269u)
						{
							if (num3 == 3356228888u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
							{
								goto IL_07f1;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_07ad;
						}
					}
					else if (num3 <= 3423339364u)
					{
						if (num3 <= 3389784126u)
						{
							if (num3 != 3373006507u)
							{
								if (num3 == 3389784126u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
								{
									goto IL_07f1;
								}
							}
							else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
							{
								goto IL_07ad;
							}
						}
						else if (num3 != 3406561745u)
						{
							if (num3 == 3423339364u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
							{
								goto IL_0769;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_0829;
						}
					}
					else if (num3 <= 3456894602u)
					{
						if (num3 != 3440116983u)
						{
							if (num3 == 3456894602u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
							{
								goto IL_0769;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_0829;
						}
					}
					else if (num3 != 3473672221u)
					{
						if (num3 == 3574337935u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_0829;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_07ad;
					}
				}
			}
		}
		goto IL_085c;
		IL_03e3:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			if (7u != 0)
			{
				result = false;
			}
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		}
		goto IL_085c;
		IL_0769:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			result = false;
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		}
		goto IL_085c;
		IL_0471:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			result = false;
			break;
		}
		goto IL_085c;
		IL_085c:
		return result;
		IL_07ad:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			result = false;
			break;
		}
		goto IL_085c;
		IL_0829:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			result = false;
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		}
		goto IL_085c;
		IL_042d:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			result = false;
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		}
		goto IL_085c;
		IL_07f1:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			result = false;
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			result = false;
			break;
		}
		goto IL_085c;
		IL_038d:
		switch (specularity2)
		{
		case Specularity.None:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = false;
			break;
		case Specularity.SpecX:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = false;
			if (uint.MaxValue != 0)
			{
				result = false;
			}
			break;
		case Specularity.SpecXY:
			_0023_003Dz0ph406aCgMed = true;
			_0023_003DzlKR5uBnaRzxK = true;
			if (uint.MaxValue != 0)
			{
				result = false;
			}
			break;
		case Specularity.SpecY:
			_0023_003Dz0ph406aCgMed = false;
			_0023_003DzlKR5uBnaRzxK = true;
			if (2u != 0)
			{
				result = false;
			}
			break;
		}
		goto IL_085c;
	}

	private bool _0023_003Dz_0024Sv7nzkwT1flKsIEPhVWIzM_003D(string _0023_003Dz25U2Th3DyD2d, int _0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D)
	{
		bool result;
		if (uint.MaxValue != 0)
		{
			result = true;
		}
		if (_0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D())
		{
			uint num = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(_0023_003Dz25U2Th3DyD2d);
			uint num2;
			if (3u != 0)
			{
				num2 = num;
			}
			if (num2 <= 3339451269u)
			{
				if (num2 <= 3255563174u)
				{
					if (num2 <= 3222007936u)
					{
						if (num2 != 890022063)
						{
							if (num2 == 3222007936u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_02f6;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770))
						{
							goto IL_02f6;
						}
					}
					else if (num2 != 3238785555u)
					{
						if (num2 == 3255563174u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_02f6;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
					{
						goto IL_02e3;
					}
				}
				else if (num2 <= 3289118412u)
				{
					if (num2 != 3272340793u)
					{
						if (num2 == 3289118412u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_02d0;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_0309;
					}
				}
				else if (num2 != 3322673650u)
				{
					if (num2 == 3339451269u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_02e3;
					}
				}
				else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
				{
					goto IL_02d0;
				}
			}
			else if (num2 <= 3423339364u)
			{
				if (num2 <= 3373006507u)
				{
					if (num2 != 3356228888u)
					{
						if (num2 == 3373006507u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_02e3;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_02f6;
					}
				}
				else if (num2 != 3406561745u)
				{
					if (num2 == 3423339364u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
					{
						goto IL_02d0;
					}
				}
				else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
				{
					goto IL_0309;
				}
			}
			else if (num2 <= 3456894602u)
			{
				if (num2 != 3440116983u)
				{
					if (num2 == 3456894602u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_02d0;
					}
				}
				else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_0309;
				}
			}
			else if (num2 != 3473672221u)
			{
				if (num2 == 3574337935u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
				{
					goto IL_0309;
				}
			}
			else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
			{
				goto IL_02e3;
			}
		}
		else
		{
			uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(_0023_003Dz25U2Th3DyD2d);
			uint num2;
			if (2u != 0)
			{
				num2 = num3;
			}
			if (num2 <= 3339451269u)
			{
				if (num2 <= 3255563174u)
				{
					if (num2 <= 3222007936u)
					{
						if (num2 != 890022063)
						{
							if (num2 == 3222007936u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_05ec;
							}
						}
						else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770))
						{
							goto IL_05ec;
						}
					}
					else if (num2 != 3238785555u)
					{
						if (num2 == 3255563174u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_05ec;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
					{
						goto IL_05dc;
					}
				}
				else if (num2 <= 3289118412u)
				{
					if (num2 != 3272340793u)
					{
						if (num2 == 3289118412u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_05cc;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_05fc;
					}
				}
				else if (num2 != 3322673650u)
				{
					if (num2 == 3339451269u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_05dc;
					}
				}
				else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
				{
					goto IL_05cc;
				}
			}
			else if (num2 <= 3423339364u)
			{
				if (num2 <= 3373006507u)
				{
					if (num2 != 3356228888u)
					{
						if (num2 == 3373006507u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_05dc;
						}
					}
					else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_05ec;
					}
				}
				else if (num2 != 3406561745u)
				{
					if (num2 == 3423339364u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
					{
						goto IL_05cc;
					}
				}
				else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
				{
					goto IL_05fc;
				}
			}
			else if (num2 <= 3456894602u)
			{
				if (num2 != 3440116983u)
				{
					if (num2 == 3456894602u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_05cc;
					}
				}
				else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_05fc;
				}
			}
			else if (num2 != 3473672221u)
			{
				if (num2 == 3574337935u && _0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
				{
					goto IL_05fc;
				}
			}
			else if (_0023_003Dz25U2Th3DyD2d == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
			{
				goto IL_05dc;
			}
		}
		goto IL_0604;
		IL_05dc:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 3)
		{
			if (2 == 0)
			{
				return result;
			}
			return false;
		}
		goto IL_0604;
		IL_0309:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 3)
		{
			if (6 == 0)
			{
				return result;
			}
			return false;
		}
		goto IL_0604;
		IL_02e3:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 2)
		{
			if (4 == 0)
			{
				return result;
			}
			return false;
		}
		goto IL_0604;
		IL_0604:
		return result;
		IL_05ec:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 1)
		{
			if (4 == 0)
			{
				return result;
			}
			return false;
		}
		goto IL_0604;
		IL_02f6:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 4)
		{
			if (0 == 0)
			{
				result = false;
			}
			return result;
		}
		goto IL_0604;
		IL_05fc:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 2)
		{
			return false;
		}
		goto IL_0604;
		IL_05cc:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 4)
		{
			if (3 == 0)
			{
				return result;
			}
			return false;
		}
		goto IL_0604;
		IL_02d0:
		if (_0023_003Dz7OmGu_0024T1ChTy_kC_0024HQ_003D_003D != 1)
		{
			if (3 == 0)
			{
				return result;
			}
			return false;
		}
		goto IL_0604;
	}

	private void _0023_003DzfqlvaQlTPR3SHq3gygBOUdI_003D(ref double _0023_003DzLM0wz_0024tKgqjc, ref double _0023_003Dzfr7Tser4Y_0024iT, Workplane _0023_003DzHn3qReygMhit)
	{
		string name = _0023_003DzHn3qReygMhit.Name;
		string text;
		if (4u != 0)
		{
			text = name;
		}
		if (!(text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577)) && !(text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590)))
		{
			if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565) || text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
			{
				_0023_003Dzfr7Tser4Y_0024iT = _0023_003Dzpl6fb1o_003D;
			}
		}
		else
		{
			_0023_003DzLM0wz_0024tKgqjc = _0023_003Dzpl6fb1o_003D;
		}
	}

	private void _0023_003Dzs4ADLWfern63s2JShVBkhiE_003D(ref double _0023_003Dzu68XiBs_003D, ref double _0023_003DzkCWBd1Y_003D, Workplane _0023_003DzHn3qReygMhit)
	{
		if (_0023_003DzHD5fHZnBd7Nm != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.ContainsKey(base.ActiveWorkplane.Name))
		{
			if (0 == 0)
			{
				double num = double.MinValue;
			}
			if (8u != 0)
			{
				double num2 = double.MinValue;
			}
			if (_0023_003DzHD5fHZnBd7Nm.PlanesWithInvertedAxis.Exists(delegate(string _0023_003Dzf54DH27vqdpn)
			{
				_ = -1;
				if (1 == 0)
				{
				}
				_ = 6;
				if (1 == 0)
				{
				}
				return _0023_003Dzf54DH27vqdpn == base.ActiveWorkplane.Name;
			}))
			{
				double num3 = _0023_003Dzu68XiBs_003D;
				double num;
				if (3u != 0)
				{
					num = num3;
				}
				_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
				_0023_003DzkCWBd1Y_003D = num;
				double num4 = _0023_003DzOiU6nPw_003D;
				double num2;
				if (3u != 0)
				{
					num2 = num4;
				}
				double num5 = _0023_003DzUUAAhCE_003D;
				if (true)
				{
					_0023_003DzOiU6nPw_003D = num5;
				}
				double num6 = num2;
				if (4u != 0)
				{
					_0023_003DzUUAAhCE_003D = num6;
				}
			}
			_0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.TryGetValue(base.ActiveWorkplane.Name, out var value);
			switch (value)
			{
			case Specularity.SpecX:
				_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
				break;
			case Specularity.SpecY:
				_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
				break;
			case Specularity.SpecXY:
				_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
				_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
				break;
			case Specularity.None:
				break;
			}
			return;
		}
		bool num7 = _0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D();
		bool flag;
		if (6u != 0)
		{
			flag = num7;
		}
		double num8;
		if (5u != 0)
		{
			num8 = double.MinValue;
		}
		WorkingArea workingArea = _configurationInterface.GetWorkingArea(_0023_003DzTJuyZiS0qOKz);
		WorkingArea workingArea2;
		if (8u != 0)
		{
			workingArea2 = workingArea;
		}
		if (workingArea2 != null)
		{
			Specularity specularity = workingArea2.Specularity;
			Specularity specularity2;
			if (4u != 0)
			{
				specularity2 = specularity;
			}
			if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
			{
				switch (specularity2)
				{
				case Specularity.SpecX:
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecY:
					_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
					break;
				case Specularity.SpecXY:
					_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				}
			}
			else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577))
			{
				switch (specularity2)
				{
				case Specularity.None:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					break;
				case Specularity.SpecX:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					break;
				case Specularity.SpecY:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecXY:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				}
			}
			else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590))
			{
				switch (specularity2)
				{
				case Specularity.None:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecX:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecY:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					break;
				case Specularity.SpecXY:
					num8 = _0023_003Dzu68XiBs_003D;
					_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
					_0023_003DzkCWBd1Y_003D = num8;
					break;
				}
			}
			else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565))
			{
				switch (specularity2)
				{
				case Specularity.SpecX:
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecY:
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecXY:
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				}
			}
			else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
			{
				switch (specularity2)
				{
				case Specularity.None:
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecY:
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				}
			}
			else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601))
			{
				switch (specularity2)
				{
				case Specularity.SpecX:
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				case Specularity.SpecY:
					_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
					break;
				case Specularity.SpecXY:
					_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
					_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
					break;
				}
			}
			else if (!_0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D())
			{
				_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3356228888u)
				{
					if (num9 <= 3255563174u)
					{
						if (num9 != 3222007936u)
						{
							if (num9 != 3238785555u)
							{
								if (num9 == 3255563174u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
								{
									goto IL_0596;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
							{
								goto IL_058c;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_0596;
						}
					}
					else if (num9 != 3272340793u)
					{
						if (num9 != 3339451269u)
						{
							if (num9 == 3356228888u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
							{
								goto IL_0596;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_058c;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_05a0;
					}
				}
				else if (num9 <= 3406561745u)
				{
					if (num9 != 3373006507u)
					{
						if (num9 != 3389784126u)
						{
							if (num9 == 3406561745u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
							{
								goto IL_05a0;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_0596;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_058c;
					}
				}
				else if (num9 != 3440116983u)
				{
					if (num9 != 3473672221u)
					{
						if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_05a0;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_058c;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_05a0;
				}
			}
			else
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3373006507u)
				{
					if (num9 <= 3289118412u)
					{
						if (num9 != 3238785555u)
						{
							if (num9 != 3272340793u)
							{
								if (num9 == 3289118412u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
								{
									goto IL_0790;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_07a9;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_079a;
						}
					}
					else if (num9 != 3322673650u)
					{
						if (num9 != 3339451269u)
						{
							if (num9 == 3373006507u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
							{
								goto IL_079a;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_079a;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_0790;
					}
				}
				else if (num9 <= 3440116983u)
				{
					if (num9 != 3406561745u)
					{
						if (num9 != 3423339364u)
						{
							if (num9 == 3440116983u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
							{
								goto IL_07a9;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_0790;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_07a9;
					}
				}
				else if (num9 != 3456894602u)
				{
					if (num9 != 3473672221u)
					{
						if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_07a9;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_079a;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_0790;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3356228888u)
				{
					if (num9 <= 3272340793u)
					{
						if (num9 <= 3238785555u)
						{
							if (num9 != 3222007936u)
							{
								if (num9 == 3238785555u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_0a86;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_0a95;
							}
						}
						else if (num9 != 3255563174u)
						{
							if (num9 == 3272340793u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0a95;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_0a95;
						}
					}
					else if (num9 <= 3322673650u)
					{
						if (num9 != 3289118412u)
						{
							if (num9 == 3322673650u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_0a86;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_0a86;
						}
					}
					else if (num9 != 3339451269u)
					{
						if (num9 == 3356228888u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_0a95;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0a86;
					}
				}
				else if (num9 <= 3423339364u)
				{
					if (num9 <= 3389784126u)
					{
						if (num9 != 3373006507u)
						{
							if (num9 == 3389784126u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_0a95;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0a86;
						}
					}
					else if (num9 != 3406561745u)
					{
						if (num9 == 3423339364u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_0a86;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0a95;
					}
				}
				else if (num9 <= 3456894602u)
				{
					if (num9 != 3440116983u)
					{
						if (num9 == 3456894602u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_0a86;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_0a95;
					}
				}
				else if (num9 != 3473672221u)
				{
					if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0a95;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0a86;
				}
			}
			else
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3356228888u)
				{
					if (num9 <= 3272340793u)
					{
						if (num9 <= 3238785555u)
						{
							if (num9 != 3222007936u)
							{
								if (num9 == 3238785555u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_0d5e;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_0d72;
							}
						}
						else if (num9 != 3255563174u)
						{
							if (num9 == 3272340793u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0d72;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_0d72;
						}
					}
					else if (num9 <= 3322673650u)
					{
						if (num9 != 3289118412u)
						{
							if (num9 == 3322673650u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_0d5e;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_0d5e;
						}
					}
					else if (num9 != 3339451269u)
					{
						if (num9 == 3356228888u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_0d72;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0d5e;
					}
				}
				else if (num9 <= 3423339364u)
				{
					if (num9 <= 3389784126u)
					{
						if (num9 != 3373006507u)
						{
							if (num9 == 3389784126u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_0d72;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0d5e;
						}
					}
					else if (num9 != 3406561745u)
					{
						if (num9 == 3423339364u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_0d5e;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0d72;
					}
				}
				else if (num9 <= 3456894602u)
				{
					if (num9 != 3440116983u)
					{
						if (num9 == 3456894602u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_0d5e;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_0d72;
					}
				}
				else if (num9 != 3473672221u)
				{
					if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0d72;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0d5e;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3356228888u)
				{
					if (num9 <= 3272340793u)
					{
						if (num9 <= 3238785555u)
						{
							if (num9 != 3222007936u)
							{
								if (num9 == 3238785555u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_1057;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_106b;
							}
						}
						else if (num9 != 3255563174u)
						{
							if (num9 == 3272340793u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_106b;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_106b;
						}
					}
					else if (num9 <= 3322673650u)
					{
						if (num9 != 3289118412u)
						{
							if (num9 == 3322673650u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_1057;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_1057;
						}
					}
					else if (num9 != 3339451269u)
					{
						if (num9 == 3356228888u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_106b;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_1057;
					}
				}
				else if (num9 <= 3423339364u)
				{
					if (num9 <= 3389784126u)
					{
						if (num9 != 3373006507u)
						{
							if (num9 == 3389784126u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_106b;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_1057;
						}
					}
					else if (num9 != 3406561745u)
					{
						if (num9 == 3423339364u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_1057;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_106b;
					}
				}
				else if (num9 <= 3456894602u)
				{
					if (num9 != 3440116983u)
					{
						if (num9 == 3456894602u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_1057;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_106b;
					}
				}
				else if (num9 != 3473672221u)
				{
					if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_106b;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_1057;
				}
			}
			else
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3356228888u)
				{
					if (num9 <= 3272340793u)
					{
						if (num9 <= 3238785555u)
						{
							if (num9 != 3222007936u)
							{
								if (num9 == 3238785555u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
								{
									goto IL_132c;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
							{
								goto IL_133b;
							}
						}
						else if (num9 != 3255563174u)
						{
							if (num9 == 3272340793u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_133b;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
						{
							goto IL_133b;
						}
					}
					else if (num9 <= 3322673650u)
					{
						if (num9 != 3289118412u)
						{
							if (num9 == 3322673650u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
							{
								goto IL_132c;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_132c;
						}
					}
					else if (num9 != 3339451269u)
					{
						if (num9 == 3356228888u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_133b;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_132c;
					}
				}
				else if (num9 <= 3423339364u)
				{
					if (num9 <= 3389784126u)
					{
						if (num9 != 3373006507u)
						{
							if (num9 == 3389784126u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
							{
								goto IL_133b;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_132c;
						}
					}
					else if (num9 != 3406561745u)
					{
						if (num9 == 3423339364u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_132c;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_133b;
					}
				}
				else if (num9 <= 3456894602u)
				{
					if (num9 != 3440116983u)
					{
						if (num9 == 3456894602u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
						{
							goto IL_132c;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_133b;
					}
				}
				else if (num9 != 3473672221u)
				{
					if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_133b;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_132c;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3373006507u)
				{
					if (num9 <= 3272340793u)
					{
						if (num9 != 3238785555u)
						{
							if (num9 == 3272340793u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_14b8;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_14b8;
						}
					}
					else if (num9 != 3339451269u)
					{
						if (num9 == 3373006507u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_14b8;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_14b8;
					}
				}
				else if (num9 <= 3440116983u)
				{
					if (num9 != 3406561745u)
					{
						if (num9 == 3440116983u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_14b8;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_14b8;
					}
				}
				else if (num9 != 3473672221u)
				{
					if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_14b8;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_14b8;
				}
			}
			else
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3373006507u)
				{
					if (num9 <= 3272340793u)
					{
						if (num9 != 3238785555u)
						{
							if (num9 == 3272340793u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_1610;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_1610;
						}
					}
					else if (num9 != 3339451269u)
					{
						if (num9 == 3373006507u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_1610;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_1610;
					}
				}
				else if (num9 <= 3440116983u)
				{
					if (num9 != 3406561745u)
					{
						if (num9 == 3440116983u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_1610;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_1610;
					}
				}
				else if (num9 != 3473672221u)
				{
					if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_1610;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_1610;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3322673650u)
				{
					if (num9 <= 3255563174u)
					{
						if (num9 != 3222007936u)
						{
							if (num9 == 3255563174u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_1789;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_1789;
						}
					}
					else if (num9 != 3289118412u)
					{
						if (num9 == 3322673650u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_1789;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_1789;
					}
				}
				else if (num9 <= 3389784126u)
				{
					if (num9 != 3356228888u)
					{
						if (num9 == 3389784126u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_1789;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_1789;
					}
				}
				else if (num9 != 3423339364u)
				{
					if (num9 == 3456894602u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_1789;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_1789;
				}
			}
			else
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3322673650u)
				{
					if (num9 <= 3255563174u)
					{
						if (num9 != 3222007936u)
						{
							if (num9 == 3255563174u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_18db;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_18db;
						}
					}
					else if (num9 != 3289118412u)
					{
						if (num9 == 3322673650u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_18db;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_18db;
					}
				}
				else if (num9 <= 3389784126u)
				{
					if (num9 != 3356228888u)
					{
						if (num9 == 3389784126u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_18db;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_18db;
					}
				}
				else if (num9 != 3423339364u)
				{
					if (num9 == 3456894602u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_18db;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_18db;
				}
			}
		}
		else if (_0023_003DzHn3qReygMhit.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3356228888u)
				{
					if (num9 <= 3255563174u)
					{
						if (num9 != 3222007936u)
						{
							if (num9 != 3238785555u)
							{
								if (num9 == 3255563174u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
								{
									goto IL_1af1;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
							{
								goto IL_1ae7;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_1af1;
						}
					}
					else if (num9 != 3272340793u)
					{
						if (num9 != 3339451269u)
						{
							if (num9 == 3356228888u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
							{
								goto IL_1af1;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_1ae7;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_1afb;
					}
				}
				else if (num9 <= 3406561745u)
				{
					if (num9 != 3373006507u)
					{
						if (num9 != 3389784126u)
						{
							if (num9 == 3406561745u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
							{
								goto IL_1afb;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_1af1;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_1ae7;
					}
				}
				else if (num9 != 3440116983u)
				{
					if (num9 != 3473672221u)
					{
						if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_1afb;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_1ae7;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_1afb;
				}
			}
			else
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				uint num9 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text);
				if (num9 <= 3373006507u)
				{
					if (num9 <= 3289118412u)
					{
						if (num9 != 3238785555u)
						{
							if (num9 != 3272340793u)
							{
								if (num9 == 3289118412u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
								{
									goto IL_1ce2;
								}
							}
							else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_1cf5;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_1ce9;
						}
					}
					else if (num9 != 3322673650u)
					{
						if (num9 != 3339451269u)
						{
							if (num9 == 3373006507u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
							{
								goto IL_1ce9;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_1ce9;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_1ce2;
					}
				}
				else if (num9 <= 3440116983u)
				{
					if (num9 != 3406561745u)
					{
						if (num9 != 3423339364u)
						{
							if (num9 == 3440116983u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
							{
								goto IL_1cf5;
							}
						}
						else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_1ce2;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_1cf5;
					}
				}
				else if (num9 != 3456894602u)
				{
					if (num9 != 3473672221u)
					{
						if (num9 == 3574337935u && text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
						{
							goto IL_1cf5;
						}
					}
					else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_1ce9;
					}
				}
				else if (text == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_1ce2;
				}
			}
		}
		else if (!_0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D())
		{
			_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		}
		goto IL_1d0e;
		IL_132c:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		goto IL_1d0e;
		IL_0a86:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		goto IL_1d0e;
		IL_0596:
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
		IL_1d0e:
		if (ActiveTransformation.HasMirrorX())
		{
			_0023_003Dzu68XiBs_003D = ((_0023_003Dzu68XiBs_003D != 0.0) ? (0.0 - _0023_003Dzu68XiBs_003D) : 0.0);
		}
		if (ActiveTransformation.HasMirrorY())
		{
			_0023_003DzkCWBd1Y_003D = ((_0023_003DzkCWBd1Y_003D != 0.0) ? (0.0 - _0023_003DzkCWBd1Y_003D) : 0.0);
		}
		return;
		IL_18db:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_07a9:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_1cf5:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_1ce2:
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
		IL_1af1:
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
		IL_0790:
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
		IL_05a0:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
		IL_1610:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_1057:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_133b:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_0a95:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_1afb:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
		IL_0d5e:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_0d72:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		goto IL_1d0e;
		IL_1789:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_106b:
		num8 = _0023_003Dzu68XiBs_003D;
		_0023_003Dzu68XiBs_003D = _0023_003DzkCWBd1Y_003D;
		_0023_003DzkCWBd1Y_003D = num8;
		goto IL_1d0e;
		IL_14b8:
		_0023_003Dzu68XiBs_003D = _0023_003DzOiU6nPw_003D - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_079a:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
		IL_058c:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_1ae7:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		goto IL_1d0e;
		IL_1ce9:
		_0023_003Dzu68XiBs_003D = 0.0 - _0023_003Dzu68XiBs_003D;
		_0023_003DzkCWBd1Y_003D = 0.0 - _0023_003DzkCWBd1Y_003D;
		goto IL_1d0e;
	}

	private void _0023_003DzHuSVQLXi_WHs(ref double _0023_003DzmdFwOB0_003D, ref double _0023_003Dzhetey2Q_003D)
	{
		if (_0023_003DzHD5fHZnBd7Nm != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.ContainsKey(base.ActiveWorkplane.Name))
		{
			_0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.TryGetValue(base.ActiveWorkplane.Name, out var value);
			switch (value)
			{
			case Specularity.SpecX:
				if (_0023_003DzmdFwOB0_003D != 0.0)
				{
					_0023_003DzmdFwOB0_003D = 0.0 - _0023_003DzmdFwOB0_003D;
				}
				break;
			case Specularity.SpecY:
				if (_0023_003DzmdFwOB0_003D != 0.0)
				{
					_0023_003DzmdFwOB0_003D = 0.0 - _0023_003DzmdFwOB0_003D;
				}
				break;
			case Specularity.SpecXY:
				if (_0023_003DzmdFwOB0_003D != 0.0)
				{
					_0023_003DzmdFwOB0_003D = 0.0 - _0023_003DzmdFwOB0_003D;
				}
				break;
			case Specularity.None:
				break;
			}
			return;
		}
		bool num = _0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D();
		_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n();
		if (num)
		{
			string text = _0023_003DzTJuyZiS0qOKz;
			string text2;
			if (2u != 0)
			{
				text2 = text;
			}
			uint num2 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
			uint num3;
			if (8u != 0)
			{
				num3 = num2;
			}
			if (num3 <= 3339451269u)
			{
				if (num3 <= 3238785555u)
				{
					if (num3 != 3222007936u)
					{
						if (num3 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_0221;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
					{
						goto IL_0242;
					}
				}
				else if (num3 != 3255563174u)
				{
					if (num3 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0221;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
				{
					goto IL_0242;
				}
			}
			else if (num3 <= 3373006507u)
			{
				if (num3 != 3356228888u)
				{
					if (num3 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_0221;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
				{
					goto IL_0242;
				}
			}
			else if (num3 != 3389784126u)
			{
				if (num3 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0221;
				}
			}
			else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
			{
				goto IL_0242;
			}
		}
		else
		{
			string text3 = _0023_003DzTJuyZiS0qOKz;
			string text2;
			if (6u != 0)
			{
				text2 = text3;
			}
			uint num4 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
			uint num3;
			if (uint.MaxValue != 0)
			{
				num3 = num4;
			}
			if (num3 <= 3356228888u)
			{
				if (num3 <= 3272340793u)
				{
					if (num3 <= 3238785555u)
					{
						if (num3 != 3222007936u)
						{
							if (num3 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
							{
								goto IL_050d;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_0519;
						}
					}
					else if (num3 != 3255563174u)
					{
						if (num3 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
						{
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
					{
						goto IL_0519;
					}
				}
				else if (num3 <= 3322673650u)
				{
					if (num3 != 3289118412u)
					{
						if (num3 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_0506;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_0506;
					}
				}
				else if (num3 != 3339451269u)
				{
					if (num3 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
				{
					goto IL_050d;
				}
			}
			else if (num3 <= 3423339364u)
			{
				if (num3 <= 3389784126u)
				{
					if (num3 != 3373006507u)
					{
						if (num3 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_050d;
					}
				}
				else if (num3 != 3406561745u)
				{
					if (num3 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
					{
						goto IL_0506;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
				{
					goto IL_0519;
				}
			}
			else if (num3 <= 3456894602u)
			{
				if (num3 != 3440116983u)
				{
					if (num3 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_0506;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
				}
			}
			else if (num3 != 3473672221u)
			{
				if (num3 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
				{
					goto IL_0519;
				}
			}
			else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
			{
				goto IL_050d;
			}
		}
		goto IL_051e;
		IL_050d:
		_0023_003DzmdFwOB0_003D = 0.0 - _0023_003DzmdFwOB0_003D;
		_0023_003Dzhetey2Q_003D = 0.0 - _0023_003Dzhetey2Q_003D;
		goto IL_051e;
		IL_0242:
		_0023_003DzmdFwOB0_003D = 180.0 - _0023_003DzmdFwOB0_003D;
		goto IL_051e;
		IL_0506:
		_0023_003DzmdFwOB0_003D = 0.0 - _0023_003DzmdFwOB0_003D;
		goto IL_051e;
		IL_051e:
		bool _0023_003Dz0ph406aCgMed;
		if (6u != 0)
		{
			_0023_003Dz0ph406aCgMed = false;
		}
		bool _0023_003DzlKR5uBnaRzxK = default(bool);
		if (0 == 0)
		{
			_0023_003DzlKR5uBnaRzxK = false;
		}
		if (!_0023_003Dzpua6XFTbs4Qx(_0023_003DzTJuyZiS0qOKz, ref _0023_003Dz0ph406aCgMed, ref _0023_003DzlKR5uBnaRzxK) && !(_0023_003Dz0ph406aCgMed && _0023_003DzlKR5uBnaRzxK))
		{
			if (_0023_003Dz0ph406aCgMed && !_0023_003DzlKR5uBnaRzxK)
			{
				_0023_003DzmdFwOB0_003D = 180.0 - _0023_003DzmdFwOB0_003D;
				_0023_003Dzhetey2Q_003D = 180.0 - _0023_003Dzhetey2Q_003D;
			}
			else if (!_0023_003Dz0ph406aCgMed && _0023_003DzlKR5uBnaRzxK)
			{
				_0023_003DzmdFwOB0_003D = 180.0 - _0023_003DzmdFwOB0_003D;
			}
		}
		return;
		IL_0221:
		_0023_003DzmdFwOB0_003D = 180.0 - _0023_003DzmdFwOB0_003D;
		_0023_003Dzhetey2Q_003D = 180.0 - _0023_003Dzhetey2Q_003D;
		goto IL_051e;
		IL_0519:
		_0023_003Dzhetey2Q_003D = 0.0 - _0023_003Dzhetey2Q_003D;
		goto IL_051e;
	}

	private void _0023_003DzNFM7tSWfuJW0(double? _0023_003DzzjWaAnQ_003D, double? _0023_003Dz_IOI7rM_003D, int? _0023_003DzKP20rXw_003D, double? _0023_003Dz_bmtVBE_003D, double? _0023_003DzEd8Mh7A_003D)
	{
		if (_0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D() && (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611) || base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590) || base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577)))
		{
			double? num = _0023_003Dz_IOI7rM_003D;
			double? num2;
			if (true)
			{
				num2 = num;
			}
			double num3 = -1.0;
			double num4;
			if (4u != 0)
			{
				num4 = num3;
			}
			_0023_003Dz_IOI7rM_003D = num2 * num4;
		}
		if (_0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D() && base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601) && _0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
		{
			double? num5 = _0023_003DzzjWaAnQ_003D;
			double? num2;
			if (5u != 0)
			{
				num2 = num5;
			}
			double num6 = -1.0;
			double num4;
			if (true)
			{
				num4 = num6;
			}
			_0023_003DzzjWaAnQ_003D = num2 * num4;
		}
		if (!_0023_003DzKP20rXw_003D.HasValue)
		{
			return;
		}
		int? num7 = _0023_003DzKP20rXw_003D;
		int? num8;
		if (2u != 0)
		{
			num8 = num7;
		}
		int num9;
		if (2u != 0)
		{
			num9 = 0;
		}
		if (num8 == num9)
		{
			return;
		}
		int? num10 = _0023_003DzKP20rXw_003D;
		if (6u != 0)
		{
			num8 = num10;
		}
		if (6u != 0)
		{
			num9 = 1;
		}
		if (num8 == num9)
		{
			return;
		}
		if (_0023_003DzzjWaAnQ_003D.HasValue)
		{
			double? num11 = _0023_003DzzjWaAnQ_003D;
			double? num2;
			if (7u != 0)
			{
				num2 = num11;
			}
			double num4;
			if (6u != 0)
			{
				num4 = 0.0;
			}
			if (num2 != num4)
			{
				goto IL_01d6;
			}
		}
		if (!_0023_003Dz_IOI7rM_003D.HasValue || _0023_003Dz_IOI7rM_003D == 0.0)
		{
			return;
		}
		goto IL_01d6;
		IL_01d6:
		double _0023_003Dzu68XiBs_003D = double.MinValue;
		double _0023_003DzkCWBd1Y_003D = double.MinValue;
		if ((!_0023_003DzzjWaAnQ_003D.HasValue || _0023_003DzzjWaAnQ_003D == 0.0) && _0023_003Dz_IOI7rM_003D.HasValue && _0023_003Dz_IOI7rM_003D != 0.0)
		{
			_0023_003Dzu68XiBs_003D = 0.0;
			_0023_003DzkCWBd1Y_003D = _0023_003Dz_IOI7rM_003D.Value;
			_0023_003Dzs4ADLWfern63s2JShVBkhiE_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		}
		if (_0023_003DzzjWaAnQ_003D.HasValue && _0023_003DzzjWaAnQ_003D != 0.0 && (!_0023_003Dz_IOI7rM_003D.HasValue || _0023_003Dz_IOI7rM_003D == 0.0))
		{
			_0023_003Dzu68XiBs_003D = _0023_003DzzjWaAnQ_003D.Value;
			_0023_003DzkCWBd1Y_003D = 0.0;
			_0023_003Dzs4ADLWfern63s2JShVBkhiE_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		}
		if (_0023_003DzzjWaAnQ_003D.HasValue && _0023_003DzzjWaAnQ_003D != 0.0 && _0023_003Dz_IOI7rM_003D.HasValue && _0023_003Dz_IOI7rM_003D != 0.0)
		{
			_0023_003Dzu68XiBs_003D = _0023_003DzzjWaAnQ_003D.Value;
			_0023_003DzkCWBd1Y_003D = _0023_003Dz_IOI7rM_003D.Value;
			_0023_003Dzs4ADLWfern63s2JShVBkhiE_003D(ref _0023_003Dzu68XiBs_003D, ref _0023_003DzkCWBd1Y_003D, base.ActiveWorkplane);
		}
		if (_0023_003Dzu68XiBs_003D == 0.0 && _0023_003DzkCWBd1Y_003D != 0.0)
		{
			CreatePattern(_0023_003DzKP20rXw_003D.Value, 1, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D, 0.0, 90.0);
			if (_0023_003DzEd8Mh7A_003D.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
			{
				base.ActiveY += _0023_003DzkCWBd1Y_003D * (double)(_0023_003DzKP20rXw_003D.Value - 1);
			}
		}
		if (_0023_003Dzu68XiBs_003D != 0.0 && _0023_003DzkCWBd1Y_003D == 0.0)
		{
			CreatePattern(1, _0023_003DzKP20rXw_003D.Value, _0023_003DzkCWBd1Y_003D, _0023_003Dzu68XiBs_003D, 0.0, 90.0);
			if (_0023_003Dz_bmtVBE_003D.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
			{
				base.ActiveX += _0023_003Dzu68XiBs_003D * (double)(_0023_003DzKP20rXw_003D.Value - 1);
			}
		}
		if (_0023_003Dzu68XiBs_003D != 0.0 && _0023_003DzkCWBd1Y_003D != 0.0)
		{
			double rotationAngle = Math.Atan(_0023_003DzkCWBd1Y_003D / _0023_003Dzu68XiBs_003D) / (Math.PI / 180.0) + 270.0;
			double num12 = SQRT(pow(_0023_003Dzu68XiBs_003D, 2.0) + pow(_0023_003DzkCWBd1Y_003D, 2.0));
			num12 = ((_0023_003Dzu68XiBs_003D < 0.0) ? (0.0 - num12) : num12);
			CreatePattern(_0023_003DzKP20rXw_003D.Value, 1, num12, 0.0, rotationAngle, 90.0);
			if (_0023_003Dz_bmtVBE_003D.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641)))
			{
				base.ActiveX += _0023_003Dzu68XiBs_003D * (double)(_0023_003DzKP20rXw_003D.Value - 1);
			}
			if (_0023_003DzEd8Mh7A_003D.HasValue && GetIncrementalInput(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633)))
			{
				base.ActiveY += _0023_003DzkCWBd1Y_003D * (double)(_0023_003DzKP20rXw_003D.Value - 1);
			}
		}
	}

	public void CommitPendingProfile()
	{
		if (_0023_003DzVsFfuwI_003D == null)
		{
			return;
		}
		if (_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D))
		{
			if (_0023_003DzVsFfuwI_003D.GeometryPath.Count == 0)
			{
				if (5u != 0)
				{
					_0023_003DzV7_0024n3MQBLXsXjVU4pwC_PyPcKlAe();
				}
			}
			if (3u != 0)
			{
				_0023_003DzGaAq2Du0L2kI();
			}
			if (0 == 0)
			{
				_0023_003DzVsFfuwI_003D = null;
			}
			_0023_003DzG4_YXQjbwey_0024 = null;
		}
		else if (_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D))
		{
			_0023_003DzpIWvQpnHGzBbhAaOjQ_003D_003D();
			_0023_003DzVsFfuwI_003D = null;
			_0023_003DzG4_YXQjbwey_0024 = null;
		}
		else if (_0023_003DzVsFfuwI_003D.GetType() == typeof(XilogEdgeProfile))
		{
			_0023_003DztSoiHWo83Qt_XrtNcA_003D_003D();
			_0023_003DzVsFfuwI_003D = null;
			_0023_003DzG4_YXQjbwey_0024 = null;
		}
		else
		{
			if (!(_0023_003DzVsFfuwI_003D.GetType() == typeof(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)))
			{
				throw new NotImplementedException();
			}
			_0023_003Dz0n8LLjfGZoB1T6pmGQ_003D_003D();
			_0023_003DzVsFfuwI_003D = null;
			_0023_003DzG4_YXQjbwey_0024 = null;
		}
	}

	public void ChangeWorkingArea()
	{
		if ((_0023_003Dzdk3_wRkuVl8n() || _0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D()) && _0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
		{
			string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010);
			if (5u != 0)
			{
				_0023_003DzTJuyZiS0qOKz = text;
			}
			SetMachiningParameters(_0023_003DzTJuyZiS0qOKz, _0023_003DzA_BQx28_003D, _0023_003DzFSKYAWY_003D, _0023_003DzZfoKzRk_003D, _0023_003DzqJGQcT0_003D == 1);
		}
	}

	private void _0023_003DzV7_0024n3MQBLXsXjVU4pwC_PyPcKlAe()
	{
		(_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D).StartZ = 0.0;
		double? z = base.ActiveZ;
		if (5u != 0)
		{
			G1(null, null, z);
		}
	}

	private void _0023_003DzGaAq2Du0L2kI()
	{
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		string empty = string.Empty;
		string _0023_003DzgKk_6RWNW19R;
		if (8u != 0)
		{
			_0023_003DzgKk_6RWNW19R = empty;
		}
		string empty2 = string.Empty;
		string _0023_003DzXxDWvs0pMGW;
		if (4u != 0)
		{
			_0023_003DzXxDWvs0pMGW = empty2;
		}
		string empty3 = string.Empty;
		string _0023_003DzXmpvTagHx2Y;
		if (uint.MaxValue != 0)
		{
			_0023_003DzXmpvTagHx2Y = empty3;
		}
		if (_0023_003DzSQkjbRxUPIwq)
		{
			return;
		}
		if (base.ActiveLeadInOut != null && !string.IsNullOrEmpty(_0023_003DzVsFfuwI_003D.Name) && !_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D.ContainsKey(_0023_003DzVsFfuwI_003D.Name))
		{
			_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D.Add(_0023_003DzVsFfuwI_003D.Name, new LeadInOut(base.ActiveLeadInOut));
		}
		string tool = _0023_003DzVsFfuwI_003D.Tool;
		if (uint.MaxValue != 0)
		{
			_0023_003DzroT_0024CHIrHrV3(tool, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
		}
		CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
		CoreTool coreTool2;
		if (3u != 0)
		{
			coreTool2 = coreTool;
		}
		if (_0023_003DzXmpvTagHx2Y == string.Empty)
		{
			string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714795);
			if (uint.MaxValue != 0)
			{
				_0023_003DzXmpvTagHx2Y = text;
			}
		}
		else if (_0023_003DzXmpvTagHx2Y == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770))
		{
			string text2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672);
			if (6u != 0)
			{
				_0023_003DzXmpvTagHx2Y = text2;
			}
		}
		else
		{
			string text3 = Convert.ToString(Convert.ToInt16(_0023_003DzXmpvTagHx2Y) + 2);
			if (6u != 0)
			{
				_0023_003DzXmpvTagHx2Y = text3;
			}
		}
		if (coreTool2 == null)
		{
			string obj = (_0023_003DzXmpvTagHx2Y.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
			string text4 = default(string);
			if (0 == 0)
			{
				text4 = obj;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[2] { text4, _0023_003DzXxDWvs0pMGW };
			if (7u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
			return;
		}
		if (_0023_003DzVsFfuwI_003D.Tool != _0023_003DzgKk_6RWNW19R)
		{
			_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzVsFfuwI_003D.Name);
			AddToErrorFile(_errorString);
		}
		_0023_003DzXxDWvs0pMGW = coreTool2.Name;
		bool flag = (_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003DzToF3h2nd1dA2() > 100;
		if (!flag)
		{
			List<Attribute> list = ActiveAttributes.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz7VPq56nMqI7FDcZGOVAL5N46Hnra);
			if (list != null && list.Count > 0)
			{
				_0023_003Dz4T0tvr1Sohar = ((IEnumerable<Attribute>)list).Max((Func<Attribute, double>)_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzTkH28SzBVGWxwkDq9CjAhZBXFcmG);
			}
			bool flag2 = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (flag2)
				{
					break;
				}
				if ((list[i].Value as DepthAttribute).Depth != _0023_003DzVsFfuwI_003D.StartZ.Value)
				{
					flag2 = true;
				}
			}
			if (!flag2)
			{
				ActiveAttributes.RemoveAll(delegate(Attribute _0023_003Dz6pELRLc_003D)
				{
					_ = -1;
					if (2 == 0)
					{
					}
					return _0023_003Dz6pELRLc_003D.Value is DepthAttribute;
				});
			}
			bool flag3 = _0023_003DzgOAH1YymtQ5A9Rboqw_003D_003D();
			if (!flag3)
			{
				flag3 = _0023_003DzLxZuBLCD9ZJFEII9Tuq1dgM_003D();
			}
			if (!flag3)
			{
				flag3 = _0023_003Dzg0zfbzNZ6bcXDOxPOQ_003D_003D();
			}
			if (!flag3)
			{
				flag3 = _0023_003DzV5GL6id6Y8_qG_BSbYbgG6g_003D();
			}
			if (!flag3)
			{
				flag3 = _0023_003DzCG_0024_0024U8FXg8_eauZRjQ_003D_003D();
			}
		}
		else
		{
			DeleteGeometry(base.ActiveGeometry.Name);
		}
		double num = _0023_003DzVsFfuwI_003D.StartZ.Value;
		int correction = _0023_003DzVsFfuwI_003D.ToolCorrection.Correction;
		double overMaterial = _0023_003DzVsFfuwI_003D.ToolCorrection.OverMaterial;
		double num2 = _0023_003DzVsFfuwI_003D.InputFeed ?? (-1.0);
		double speed = _0023_003DzVsFfuwI_003D.Feed ?? (-1.0);
		double rotSpeed = _0023_003DzVsFfuwI_003D.SpindleSpeed ?? (-1.0);
		ToolCorrection activeToolCorrection = base.ActiveToolCorrection;
		SetPneumaticHoodPosition((_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D).HoodPosition);
		if (IsAuxiliaryHoodPositionModal)
		{
			SetAuxiliaryHoodPosition(ActiveAuxiliaryHoodPosition);
		}
		if (string.Compare(_0023_003DzAZi_0024PtL9uOWi5dOW03moNZQ_003D, _0023_003DzVsFfuwI_003D.Name) == 0)
		{
			CreateContour(_0023_003DzVsFfuwI_003D.Name, num, 0, 0, string.Empty, TypeOfProcess.Countouring, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, correction, num2, rotSpeed, speed, overMaterial);
		}
		else if (flag)
		{
			CreatePlaneCutterLocationStrategy(0.0, 0.0);
			Create3DRoughFinish(_0023_003DzVsFfuwI_003D.Name, string.Empty, TypeOfProcess.GeneralRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, num2, rotSpeed, speed, 0.0, 0.0);
			double num3 = num2;
			Geom_CartesianPoint val = null;
			Geom_Axis2Placement axisPlacement = (_projectInterface.Get(base.ActiveWorkplane.ReferenceKey) as Plane).Placement.TypedGeometry();
			List<_0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D> list2 = (_0023_003DzVsFfuwI_003D as _0023_003DzWH_B153YwYNDin4PCEjGJWp5DBQCrOPAJw_003D_003D)._0023_003Dz9VgZhTNue1G0();
			val = Geom_CartesianPoint.DownCast((Standard_Transient)(object)OCGeomHelper.ToAbsolute((Geom_Geometry)new Geom_CartesianPoint(list2[0]._0023_003DziAO_TyQ_003D().Value, list2[0]._0023_003DzQykhbpQ_003D().Value, list2[0]._0023_003Dz2mrTZJQ_003D().Value), axisPlacement));
			CreateToolpath3D(string.Empty, ((Geom_Point)val).X(), ((Geom_Point)val).Y(), ((Geom_Point)val).Z());
			for (int num4 = 1; num4 < list2.Count; num4++)
			{
				_0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D = list2[num4];
				val = Geom_CartesianPoint.DownCast((Standard_Transient)(object)OCGeomHelper.ToAbsolute((Geom_Geometry)new Geom_CartesianPoint(_0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D._0023_003DziAO_TyQ_003D().Value, _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D._0023_003DzQykhbpQ_003D().Value, _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D._0023_003Dz2mrTZJQ_003D().Value), axisPlacement));
				AddSegmentToToolpath(((Geom_Point)val).X(), ((Geom_Point)val).Y(), ((Geom_Point)val).Z(), 0.0, 0.0);
				if (_0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D._0023_003Dz9KzFds0_003D().HasValue && num3 != _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D._0023_003Dz9KzFds0_003D().Value)
				{
					num3 = _0023_003Dz8z3OLvU2JWVcqg49sYt_0024jZhVVGQErilX4Q_003D_003D._0023_003Dz9KzFds0_003D().Value;
					SetToolpathAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702931), num3);
				}
			}
		}
		else if (_0023_003DzaepqoE8sVHIF == KindOfToolFamily.BladeCuttingTool.ToString())
		{
			double num5 = num;
			bool flag4 = true;
			if (ActiveAttributes != null && ActiveAttributes.Count > 0)
			{
				for (int num6 = 0; num6 < ActiveAttributes.Count; num6++)
				{
					if (ActiveAttributes.ElementAt(num6).Value is DepthAttribute)
					{
						if (flag4)
						{
							num = (ActiveAttributes.ElementAt(num6).Value as DepthAttribute).Depth;
						}
						num5 = (ActiveAttributes.ElementAt(num6).Value as DepthAttribute).Depth;
						flag4 = false;
					}
				}
			}
			double num7 = num * (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n();
			double num8 = num5 * (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n();
			if (((num7 < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (num7 > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1)) && ((num8 < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (num8 > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1)))
			{
				_errorString = LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713175), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990));
				AddToErrorFile(_errorString);
				_activeStrategy = null;
				ActiveAttributes.Clear();
				DeleteGeometry(base.ActiveGeometry.Name);
				ResetApproachStrategy();
				ResetRetractStrategy();
			}
			else
			{
				double num9 = 0.0;
				bool _0023_003DzbdegC5Muapsu = false;
				num9 = _0023_003DzbjQVYKGlRMMA(ref _0023_003DzbdegC5Muapsu);
				if (_0023_003DzbdegC5Muapsu)
				{
					CreateBladeCut(string.Empty, string.Empty, TypeOfProcess.GeneralRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, 90.0, correction, num2, rotSpeed, speed, overMaterial, cutPositionUpper: true, materialPositionLeft: true, 0.0, num9);
				}
				else
				{
					CreateSlot(string.Empty, num, string.Empty, TypeOfProcess.SlotRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, correction, num2, rotSpeed, speed, overMaterial, 90.0, num5);
				}
			}
		}
		else
		{
			CreateRoughFinish(_0023_003DzVsFfuwI_003D.Name, num, string.Empty, TypeOfProcess.GeneralRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, correction, num2, rotSpeed, speed, overMaterial);
		}
		_0023_003Dzwlal3EX7MKh692I9_0024iXByDBTjDBx(activeToolCorrection);
		ResetPneumaticHood();
		ResetAuxiliaryHood();
		SetBrakes(string.Empty);
		ResetApproachStrategy();
		ResetRetractStrategy();
		_0023_003Dz6O8F0jNAY_0024c7.Add(_0023_003DzVsFfuwI_003D);
		_0023_003Dz4T0tvr1Sohar = null;
	}

	private double _0023_003DzbjQVYKGlRMMA(ref bool _0023_003DzbdegC5Muapsu)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d4: Expected O, but got Unknown
		//IL_01d4: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		double result;
		if (8u != 0)
		{
			result = 0.0;
		}
		_0023_003DzbdegC5Muapsu = false;
		if (_0023_003Dz4T0tvr1Sohar.HasValue)
		{
			GeomCompositeCurve geomCompositeCurve = new GeomCompositeCurve(_0023_003DzVsFfuwI_003D.GeometryPath.Geometry.Clone() as GeomCompositeCurve);
			GeomCompositeCurve geomCompositeCurve2;
			if (6u != 0)
			{
				geomCompositeCurve2 = geomCompositeCurve;
			}
			_projectInterface.ToAbsoluteGeometry(geomCompositeCurve2);
			gp_Pnt val = new gp_Pnt(geomCompositeCurve2.StartX, geomCompositeCurve2.StartY, geomCompositeCurve2.StartZ);
			gp_Pnt val2;
			if (5u != 0)
			{
				val2 = val;
			}
			ReferenceKey referenceKey = base.ActiveWorkplane.ReferenceKey;
			ReferenceKey key;
			if (true)
			{
				key = referenceKey;
			}
			Plane obj = _projectInterface.Get(key) as Plane;
			gp_Dir val3 = new gp_Dir(new gp_Vec(geomCompositeCurve2.GetStartPoint(), new gp_Pnt(geomCompositeCurve2.Elements[0].EndX, geomCompositeCurve2.Elements[0].EndY, geomCompositeCurve2.Elements[0].EndZ)));
			gp_Dir val4;
			if (true)
			{
				val4 = val3;
			}
			gp_Dir val5 = new gp_Dir(((Geom_AxisPlacement)obj.Placement.TypedGeometry()).Direction().XYZ());
			gp_Dir val6;
			if (2u != 0)
			{
				val6 = val5;
			}
			double num = 0.0;
			if (_0023_003DzVsFfuwI_003D is _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)
			{
				num = MathUtility.ConvertToRadians(90.0 - (_0023_003DzVsFfuwI_003D as _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)._0023_003Dz1gEynnxvwUDQ());
				val6.Rotate(new gp_Ax1(val2, val4), num);
			}
			val6.Reverse();
			((Geom_AxisPlacement)new Geom_Axis2Placement(new gp_Pnt(0.0, 0.0, 0.0), new gp_Dir(0.0, 0.0, 1.0), new gp_Dir(1.0, 0.0, 0.0))).Direction();
			gp_Dir val7 = ((Geom_AxisPlacement)obj.Placement.TypedGeometry()).Direction();
			Geom_Axis2Placement planePlacement = obj.Placement.TypedGeometry();
			bool flag = false;
			for (int i = 1; i <= _0023_003DzDfV1Q2OnV_0024RM.Count; i++)
			{
				Workplane workplane = Exist(_0023_003DzDfV1Q2OnV_0024RM[i], exist: true) as Workplane;
				Plane plane = _projectInterface.Get(workplane.ReferenceKey) as Plane;
				if (((Geom_AxisPlacement)plane.Placement.CastedGeometry).Direction().IsOpposite(val7, PrecisionExtension.Confusion() * 10.0))
				{
					planePlacement = plane.Placement.CastedGeometry;
					flag = true;
					break;
				}
			}
			if (flag)
			{
				gp_Pnt val8 = Intersection.ProjectPointOnPlane(val2, val6, planePlacement);
				if (val8 != null)
				{
					double num2 = val8.Distance(val2);
					if (_0023_003Dz4T0tvr1Sohar > num2)
					{
						result = _0023_003Dz4T0tvr1Sohar.Value - num2;
						_0023_003DzbdegC5Muapsu = true;
					}
				}
			}
		}
		return result;
	}

	private bool _0023_003DzCG_0024_0024U8FXg8_eauZRjQ_003D_003D()
	{
		bool result;
		if (7u != 0)
		{
			result = false;
		}
		bool _0023_003DzbdegC5Muapsu;
		if (true)
		{
			_0023_003DzbdegC5Muapsu = false;
		}
		ReferenceKey referenceKey = base.ActiveWorkplane.ReferenceKey;
		ReferenceKey key;
		if (5u != 0)
		{
			key = referenceKey;
		}
		Plane obj = _projectInterface.Get(key) as Plane;
		Plane plane;
		if (4u != 0)
		{
			plane = obj;
		}
		_0023_003DzbjQVYKGlRMMA(ref _0023_003DzbdegC5Muapsu);
		string text = _0023_003DzaepqoE8sVHIF;
		KindOfToolFamily kindOfToolFamily;
		if (6u != 0)
		{
			kindOfToolFamily = KindOfToolFamily.BladeCuttingTool;
		}
		bool num = text == kindOfToolFamily.ToString();
		string text2 = _0023_003DzaepqoE8sVHIF;
		if (2u != 0)
		{
			kindOfToolFamily = KindOfToolFamily.MillingCuttingTool;
		}
		bool num2 = text2 == kindOfToolFamily.ToString();
		bool flag;
		if (8u != 0)
		{
			flag = num2;
		}
		if (num)
		{
			if (!_0023_003DzbdegC5Muapsu || plane.Type != PlaneType.Top)
			{
				if (_0023_003DzVsFfuwI_003D == null || _0023_003DzVsFfuwI_003D.GeometryPath == null || _0023_003DzVsFfuwI_003D.GeometryPath.Geometry == null)
				{
					return result;
				}
				GeomGeometry geometry = _0023_003DzVsFfuwI_003D.GeometryPath.Geometry;
				_projectInterface.ToLocalGeometry(geometry);
				_0023_003DzieXHbqC2vLRCTUo9xg_003D_003D(1);
				DeleteGeometry(base.ActiveGeometry.Name);
				double startX = (geometry as GeomCompositeCurve).Elements[0].StartX;
				double startY = (geometry as GeomCompositeCurve).Elements[0].StartY;
				double endX = (geometry as GeomCompositeCurve).Elements[(geometry as GeomCompositeCurve).Elements.Count - 1].EndX;
				double endY = (geometry as GeomCompositeCurve).Elements[(geometry as GeomCompositeCurve).Elements.Count - 1].EndY;
				if (startX == endX && startY == endY)
				{
					endX = (geometry as GeomCompositeCurve).Elements[0].EndX;
					endY = (geometry as GeomCompositeCurve).Elements[0].EndY;
				}
				CreateSegment(string.Empty, startX, startY, endX, endY);
				result = true;
			}
		}
		else if (flag)
		{
			if (_0023_003DzVsFfuwI_003D == null || _0023_003DzVsFfuwI_003D.GeometryPath == null || _0023_003DzVsFfuwI_003D.GeometryPath.Geometry == null)
			{
				return result;
			}
			GeomCompositeCurve geometry2 = _0023_003DzVsFfuwI_003D.GeometryPath.Geometry;
			if (geometry2.Elements.Count == 1 && geometry2.Elements[0].IsSegment)
			{
				_projectInterface.ToLocalGeometry(geometry2);
				_0023_003DzieXHbqC2vLRCTUo9xg_003D_003D(1);
				DeleteGeometry(base.ActiveGeometry.Name);
				double startX2 = geometry2.Elements[0].StartX;
				double startY2 = geometry2.Elements[0].StartY;
				double endX2 = geometry2.Elements[geometry2.Elements.Count - 1].EndX;
				double endY2 = geometry2.Elements[geometry2.Elements.Count - 1].EndY;
				if (startX2 == endX2 && startY2 == endY2)
				{
					endX2 = geometry2.Elements[0].EndX;
					endY2 = geometry2.Elements[0].EndY;
				}
				CreateSegment(string.Empty, startX2, startY2, endX2, endY2);
				result = true;
			}
		}
		return result;
	}

	private void _0023_003DzieXHbqC2vLRCTUo9xg_003D_003D(int _0023_003DzWOoFuVE_003D)
	{
		_0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D _0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D = new _0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D();
		_0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D _0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D2;
		if (uint.MaxValue != 0)
		{
			_0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D2 = _0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D;
		}
		if (uint.MaxValue != 0)
		{
			_0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D2._0023_003DzWOoFuVE_003D = _0023_003DzWOoFuVE_003D;
		}
		List<Attribute> list = ActiveAttributes.FindAll(_0023_003DzT3PbGpVGPSYNXAJFvKVK1f8_003D2._0023_003DzhKY_bLbbJZLMMOvtshzWGzc_003D);
		ActiveAttributes.Clear();
		List<Attribute>.Enumerator enumerator = list.GetEnumerator();
		List<Attribute>.Enumerator enumerator2;
		if (8u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				Attribute current = enumerator2.Current;
				Attribute attribute;
				if (2u != 0)
				{
					attribute = current;
				}
				if (attribute.Value is SpeedAttribute)
				{
					int index = attribute.Index;
					string feed = Attribute.Feed;
					double speed = (attribute.Value as SpeedAttribute).Speed;
					double uPar = attribute.Value.UPar;
					if (true)
					{
						SetAttribute(index, feed, speed, uPar);
					}
				}
				else if (attribute.Value is DepthAttribute)
				{
					int index2 = attribute.Index;
					string depth = Attribute.Depth;
					double depth2 = (attribute.Value as DepthAttribute).Depth;
					double uPar2 = attribute.Value.UPar;
					if (true)
					{
						SetAttribute(index2, depth, depth2, uPar2);
					}
				}
				else if (attribute.Value is HeightAttribute)
				{
					SetAttribute(attribute.Index, Attribute.Height, (attribute.Value as HeightAttribute).Height, attribute.Value.UPar);
				}
				else if (attribute.Value is RotationAttribute)
				{
					SetAttribute(attribute.Index, Attribute.Rot, (attribute.Value as RotationAttribute).Angle, attribute.Value.UPar);
				}
				else if (attribute.Value is RotXAttribute)
				{
					SetAttribute(attribute.Index, Attribute.RotX, (attribute.Value as RotXAttribute).RotX, attribute.Value.UPar);
				}
				else if (attribute.Value is RotZAttribute)
				{
					SetAttribute(attribute.Index, Attribute.RotZ, (attribute.Value as RotZAttribute).RotZ, attribute.Value.UPar);
				}
				else if (attribute.Value is TabAttribute)
				{
					SetAttribute(attribute.Index, Attribute.Tab, (attribute.Value as TabAttribute).Thickness, attribute.Value.UPar);
				}
				else if (attribute.Value is EdgeSupplyAttribute)
				{
					SetAttribute(attribute.Index, Attribute.Dispensing, (attribute.Value as EdgeSupplyAttribute).EdgeLenght, attribute.Value.UPar);
				}
				else if (attribute.Value is LampAttribute)
				{
					SetAttribute(attribute.Index, Attribute.Lamp, (attribute.Value as LampAttribute).Power, attribute.Value.UPar);
				}
				else if (attribute.Value is RollStopAttribute)
				{
					SetAttribute(attribute.Index, Attribute.STOP, (attribute.Value as RollStopAttribute).Time, attribute.Value.UPar);
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
	}

	private bool _0023_003DzV5GL6id6Y8_qG_BSbYbgG6g_003D()
	{
		bool result;
		if (true)
		{
			result = false;
		}
		bool flag;
		if (8u != 0)
		{
			flag = true;
		}
		bool _0023_003DzbdegC5Muapsu = default(bool);
		if (0 == 0)
		{
			_0023_003DzbdegC5Muapsu = false;
		}
		ReferenceKey referenceKey = base.ActiveWorkplane.ReferenceKey;
		ReferenceKey key;
		if (7u != 0)
		{
			key = referenceKey;
		}
		Plane obj = _projectInterface.Get(key) as Plane;
		Plane plane;
		if (5u != 0)
		{
			plane = obj;
		}
		_0023_003DzbjQVYKGlRMMA(ref _0023_003DzbdegC5Muapsu);
		string text = _0023_003DzaepqoE8sVHIF;
		KindOfToolFamily kindOfToolFamily;
		if (2u != 0)
		{
			kindOfToolFamily = KindOfToolFamily.BladeCuttingTool;
		}
		if (text == kindOfToolFamily.ToString() && _0023_003DzbdegC5Muapsu && plane.Type == PlaneType.Top)
		{
			if (_0023_003DzVsFfuwI_003D == null || _0023_003DzVsFfuwI_003D.GeometryPath == null || _0023_003DzVsFfuwI_003D.GeometryPath.Geometry == null)
			{
				return result;
			}
			GeomCompositeCurve geometry = _0023_003DzVsFfuwI_003D.GeometryPath.Geometry;
			GeomGeometry geomGeometry;
			if (6u != 0)
			{
				geomGeometry = geometry;
			}
			_projectInterface.ToLocalGeometry(geomGeometry);
			_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D = new _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D(geomGeometry as GeomCompositeCurve, ActiveAttributes);
			_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2;
			if (3u != 0)
			{
				_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D;
			}
			if (_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2 == null || _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D == null || _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D.Count <= 1)
			{
				if (true)
				{
					flag = false;
				}
			}
			if ((geomGeometry as GeomCompositeCurve).Elements[0].StartX != (geomGeometry as GeomCompositeCurve).Elements[(geomGeometry as GeomCompositeCurve).Elements.Count - 1].EndX || (geomGeometry as GeomCompositeCurve).Elements[0].StartY != (geomGeometry as GeomCompositeCurve).Elements[(geomGeometry as GeomCompositeCurve).Elements.Count - 1].EndY)
			{
				flag = false;
			}
			if (ActiveAttributes.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DztvlSM_dyurwjz4xvxJBQ1xAKpm7RMyzSJA_003D_003D).Count > 0)
			{
				Attribute attribute = ActiveAttributes.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz1H87FgjcSlF4S829ITjIERG9jcUA7WLcgQ_003D_003D).First();
				ActiveAttributes.Clear();
				SetAttribute(attribute.Index, Attribute.Feed, (attribute.Value as SpeedAttribute).Speed, attribute.Value.UPar);
			}
			else
			{
				ActiveAttributes.Clear();
			}
			DeleteGeometry(base.ActiveGeometry.Name);
			if (flag)
			{
				double firstCutDepth = _0023_003DzVsFfuwI_003D.StartZ.Value;
				List<Attribute> list = ActiveAttributes.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzC7j7tIqrLnXL8AmEn6gGzezoAtwFKOLtww_003D_003D);
				if (list.Count > 0)
				{
					firstCutDepth = (list.First().Value as DepthAttribute).Depth;
				}
				CreateSegment(string.Empty, (geomGeometry as GeomCompositeCurve).Elements[0].StartX, (geomGeometry as GeomCompositeCurve).Elements[0].StartY, (geomGeometry as GeomCompositeCurve).Elements[0].EndX, (geomGeometry as GeomCompositeCurve).Elements[0].EndY);
				CreateSectioningMillingStrategy(firstCutDepth, 0.0, base.ActiveMachineFunctions.LateralShift ?? 0.0);
				result = true;
			}
			else
			{
				CreateSegment(string.Empty, (geomGeometry as GeomCompositeCurve).Elements[0].StartX, (geomGeometry as GeomCompositeCurve).Elements[0].StartY, (geomGeometry as GeomCompositeCurve).Elements[(geomGeometry as GeomCompositeCurve).Elements.Count - 1].EndX, (geomGeometry as GeomCompositeCurve).Elements[(geomGeometry as GeomCompositeCurve).Elements.Count - 1].EndY);
			}
		}
		return result;
	}

	private bool _0023_003DzLxZuBLCD9ZJFEII9Tuq1dgM_003D()
	{
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		double num;
		if (3u != 0)
		{
			num = 0.0;
		}
		double num2;
		if (7u != 0)
		{
			num2 = 0.0;
		}
		double num3;
		if (true)
		{
			num3 = 0.0;
		}
		double num4;
		if (4u != 0)
		{
			num4 = 0.0;
		}
		double num5;
		if (8u != 0)
		{
			num5 = 0.0;
		}
		Geom_Circle val = default(Geom_Circle);
		if (0 == 0)
		{
			val = null;
		}
		if (4u != 0)
		{
			Geom_Circle val2 = null;
		}
		gp_Pnt val3;
		if (2u != 0)
		{
			val3 = null;
		}
		if (ActiveAttributes.Count == 0)
		{
			return false;
		}
		GeomCompositeCurve geometry = _0023_003DzVsFfuwI_003D.GeometryPath.Geometry;
		GeomGeometry geomGeometry;
		if (uint.MaxValue != 0)
		{
			geomGeometry = geometry;
		}
		if (!(geomGeometry is GeomCompositeCurve))
		{
			return false;
		}
		_projectInterface.ToLocalGeometry(geomGeometry);
		_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D = new _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D(geomGeometry as GeomCompositeCurve, ActiveAttributes);
		_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2;
		if (8u != 0)
		{
			_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D;
		}
		int num6 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzPen3gQDMkeFQ[typeof(DepthAttribute)];
		if (num6 == 0)
		{
			return false;
		}
		if (_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003Dzed0_XMs_003D <= 1 || _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzxBttghk_003D > 0)
		{
			return false;
		}
		if (_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D != null && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D != null && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D.Count() > 0 && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz9u97u6bfyfwbgPIvLX5L95kAhagnhFiXd9xy8ZU_003D) != null && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D.FindAll(delegate(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 1;
			if (3 == 0)
			{
			}
			return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
		}).Count() > 0)
		{
			Attribute attribute = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzP24zraU9kMH1ZdPr8Bl0kFZ3cqNQub2eazUTuY0_003D).First();
			if (num6 == 1 && attribute != null && (attribute.Value as DepthAttribute).UPar == 0.0)
			{
				return false;
			}
		}
		bool flag = true;
		List<double> list = new List<double>();
		List<_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D> _0023_003DzghtInQU_003D = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D;
		for (int num7 = 0; num7 < _0023_003DzghtInQU_003D.Count; num7++)
		{
			if (!flag)
			{
				break;
			}
			_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D _0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D = _0023_003DzghtInQU_003D[num7];
			if (num7 == 0)
			{
				val = Geom_Circle.DownCast((Standard_Transient)(object)_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003DzXwx7_cI_003D.BasisCurve());
				val3 = ((Geom_BoundedCurve)_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003DzXwx7_cI_003D).StartPoint();
			}
			else
			{
				Geom_Circle val2 = Geom_Circle.DownCast((Standard_Transient)(object)_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003DzXwx7_cI_003D.BasisCurve());
				if (!((Geom_Conic)val2).Location().IsEqual(((Geom_Conic)val).Location(), PrecisionExtension.Technology()) || !MathUtility.IsEqual(val2.Radius(), val.Radius(), PrecisionExtension.Technology()))
				{
					flag = false;
					break;
				}
				if (!((Geom_Conic)val2).Axis().Direction().IsEqual(((Geom_Conic)val).Axis().Direction(), PrecisionExtension.Angular()))
				{
					flag = false;
					break;
				}
			}
			Attribute attribute2 = _0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003DzalosG58_003D.Find(delegate(Attribute _0023_003DzdO6rEgA_003D)
			{
				_ = 7;
				if (-1 == 0)
				{
				}
				return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
			});
			if (attribute2 != null)
			{
				double depth = (attribute2.Value as DepthAttribute).Depth;
				if (MathUtility.IsLower(depth, num, PrecisionExtension.Confusion()))
				{
					flag = false;
					break;
				}
				num4 = depth - num3;
				if (num < depth)
				{
					num = depth;
				}
			}
			num2 += _0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003Dz3RLkNwU_003D;
			num5 += _0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003Dz3RLkNwU_003D;
			if (MathUtility.IsGreater(num5, Math.PI * 2.0 - PrecisionExtension.Angular(), PrecisionExtension.Angular()))
			{
				num3 = num4 * (Math.PI * 2.0 / num5);
				list.Add(num3);
				num4 *= 1.0 - Math.PI * 2.0 / num5;
				num5 -= Math.PI * 2.0;
			}
		}
		if (flag && list.Count > 0)
		{
			ActiveAttributes.Clear();
			_0023_003DzVsFfuwI_003D.StartZ = num;
			if (!_projectInterface.HasGeometryFeatures(base.ActiveGeometry.ReferenceKey))
			{
				DeleteGeometry(base.ActiveGeometry.Name);
			}
			bool isClockwise = ((Geom_Conic)val).Axis().Direction().IsEqual(new gp_Dir(0.0, 0.0, -1.0), PrecisionExtension.Angular());
			CreateCircleCenterPoint(string.Empty, ((Geom_Conic)val).Location().X(), ((Geom_Conic)val).Location().Y(), val3.X(), val3.Y(), isClockwise);
			double num8 = 0.0;
			double num9 = 0.0;
			bool allowsFinishCutting = false;
			if (list.Count > 1)
			{
				if (Math.Abs(list[list.Count - 1] - list[list.Count - 2]) > PrecisionExtension.Technology())
				{
					allowsFinishCutting = true;
					num9 = list[list.Count - 1];
				}
				num8 = Math.Max((num - num9) / (double)(list.Count - 1), 0.0);
			}
			else
			{
				num8 = Math.Max(num / (double)list.Count, 0.0);
			}
			CreateHelicMillingStrategy(num8, allowsFinishCutting, num9);
		}
		return flag;
	}

	private bool _0023_003DzgOAH1YymtQ5A9Rboqw_003D_003D()
	{
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		double num;
		if (4u != 0)
		{
			num = 0.0;
		}
		double num2;
		if (uint.MaxValue != 0)
		{
			num2 = 0.0;
		}
		if (ActiveAttributes.Count == 0)
		{
			return false;
		}
		GeomCompositeCurve geometry = _0023_003DzVsFfuwI_003D.GeometryPath.Geometry;
		GeomGeometry geomGeometry;
		if (2u != 0)
		{
			geomGeometry = geometry;
		}
		if (!(geomGeometry is GeomCompositeCurve))
		{
			return false;
		}
		_projectInterface.ToLocalGeometry(geomGeometry);
		_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D = new _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D(geomGeometry as GeomCompositeCurve, ActiveAttributes);
		_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2;
		if (2u != 0)
		{
			_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D;
		}
		int num3 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzPen3gQDMkeFQ[typeof(DepthAttribute)];
		int num4;
		if (7u != 0)
		{
			num4 = num3;
		}
		if (num4 == 0)
		{
			return false;
		}
		if (_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D != null && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D != null && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D.Count() > 0)
		{
			List<Attribute> _0023_003DzalosG58_003D = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D;
			Predicate<Attribute> predicate = _0023_003DzJBaCSp8_003D._0023_003DzP8JXUOuSZskrgxFaAQ_003D_003D;
			if (predicate == null)
			{
				predicate = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzUm7Ps_2MR_QKLwrOKxm1icnPzri4;
				Predicate<Attribute> _0023_003DzP8JXUOuSZskrgxFaAQ_003D_003D = predicate;
				if (8u != 0)
				{
					_0023_003DzJBaCSp8_003D._0023_003DzP8JXUOuSZskrgxFaAQ_003D_003D = _0023_003DzP8JXUOuSZskrgxFaAQ_003D_003D;
				}
			}
			if (_0023_003DzalosG58_003D.FindAll(predicate) != null)
			{
				List<Attribute> _0023_003DzalosG58_003D2 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D;
				Predicate<Attribute> predicate2 = _0023_003DzJBaCSp8_003D._0023_003DzH1MO_0024rvrqEKr73yX7Q_003D_003D;
				if (predicate2 == null)
				{
					predicate2 = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz26ACCD1VKpZjB1js8fzjReD91THq;
					Predicate<Attribute> _0023_003DzH1MO_0024rvrqEKr73yX7Q_003D_003D = predicate2;
					if (4u != 0)
					{
						_0023_003DzJBaCSp8_003D._0023_003DzH1MO_0024rvrqEKr73yX7Q_003D_003D = _0023_003DzH1MO_0024rvrqEKr73yX7Q_003D_003D;
					}
				}
				if (_0023_003DzalosG58_003D2.FindAll(predicate2).Count() > 0)
				{
					List<Attribute> _0023_003DzalosG58_003D3 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D;
					object obj = _0023_003DzJBaCSp8_003D._0023_003DzGo6eKEhm5jf9IchR4Q_003D_003D;
					if (obj == null)
					{
						obj = (Predicate<Attribute>)delegate(Attribute _0023_003DzdO6rEgA_003D)
						{
							_ = 8;
							if (false)
							{
							}
							return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
						};
						object _0023_003DzGo6eKEhm5jf9IchR4Q_003D_003D = obj;
						if (4u != 0)
						{
							_0023_003DzJBaCSp8_003D._0023_003DzGo6eKEhm5jf9IchR4Q_003D_003D = (Predicate<Attribute>)_0023_003DzGo6eKEhm5jf9IchR4Q_003D_003D;
						}
					}
					Attribute attribute = _0023_003DzalosG58_003D3.FindAll((Predicate<Attribute>)obj).First();
					Attribute attribute2;
					if (4u != 0)
					{
						attribute2 = attribute;
					}
					if (num4 == 1 && attribute2 != null && (attribute2.Value as DepthAttribute).UPar == 0.0)
					{
						return false;
					}
				}
			}
		}
		Geom_CompositeCurve periodCurve;
		if (true)
		{
			periodCurve = null;
		}
		Geom_Axis2Placement castedGeometry = (_projectInterface.Get(base.ActiveWorkplane.ReferenceKey) as Plane).Placement.CastedGeometry;
		List<_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D> _0023_003DzghtInQU_003D = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D;
		bool[] array = new bool[_0023_003DzghtInQU_003D.Count];
		for (int num5 = 1; num5 < _0023_003DzghtInQU_003D.Count; num5++)
		{
			if (_0023_003DzghtInQU_003D[num5]._0023_003DzalosG58_003D != null)
			{
				array[num5] = _0023_003DzghtInQU_003D[num5]._0023_003DzalosG58_003D.Count > 0;
			}
		}
		if (!OCGeomHelper.IsPeriodicCurve(geomGeometry.Geometry as Geom_CompositeCurve, castedGeometry, array, ref periodCurve))
		{
			return false;
		}
		bool flag = true;
		List<double> list = new List<double>();
		int count = periodCurve.Segments.Count;
		int num6 = 0;
		for (int num7 = 0; num7 < _0023_003DzghtInQU_003D.Count; num7++)
		{
			if (!flag)
			{
				break;
			}
			num6++;
			_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D _0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D = _0023_003DzghtInQU_003D[num7];
			if (num6 == count + 1)
			{
				Attribute attribute3 = _0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003DzalosG58_003D.Find(delegate(Attribute _0023_003DzdO6rEgA_003D)
				{
					_ = 8;
					if (6 == 0)
					{
					}
					return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
				});
				if (attribute3 != null)
				{
					double depth = (attribute3.Value as DepthAttribute).Depth;
					if (MathUtility.IsLower(depth, num, PrecisionExtension.Confusion()))
					{
						flag = false;
						break;
					}
					if (num < depth)
					{
						num = depth;
					}
					list.Add(depth - num2);
					num2 = depth;
				}
				num6 = 0;
			}
			else if (num7 == 0)
			{
				Attribute attribute4 = _0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003DzalosG58_003D.Find(delegate(Attribute _0023_003DzdO6rEgA_003D)
				{
					_ = 3;
					if (-1 == 0)
					{
					}
					return _0023_003DzdO6rEgA_003D.Value.GetType() == typeof(DepthAttribute);
				});
				if (attribute4 != null)
				{
					double depth2 = (attribute4.Value as DepthAttribute).Depth;
					if (MathUtility.IsLower(depth2, num, PrecisionExtension.Confusion()))
					{
						flag = false;
						break;
					}
					if (num < depth2)
					{
						num = depth2;
					}
					list.Add(depth2);
					num2 = depth2;
				}
			}
			else if (_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D._0023_003DzalosG58_003D.Find(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz3g6mwajNJ3beKDbawXHHRqivTTqG) != null)
			{
				flag = false;
				break;
			}
		}
		if (flag && list.Count > 0)
		{
			ActiveAttributes.Clear();
			_0023_003DzVsFfuwI_003D.StartZ = num;
			if (!_projectInterface.HasGeometryFeatures(base.ActiveGeometry.ReferenceKey))
			{
				DeleteGeometry(base.ActiveGeometry.Name);
			}
			CreatePolyline(string.Empty, periodCurve.Segments[0].StartX, periodCurve.Segments[0].StartY);
			for (int num8 = 0; num8 < periodCurve.Segments.Count; num8++)
			{
				if (periodCurve.Segments[num8].IsArc)
				{
					Geom_CompositeCurveSegment geom_CompositeCurveSegment = periodCurve.Segments[num8];
					AddArc2PointCenterToPolyline(geom_CompositeCurveSegment.EndX, geom_CompositeCurveSegment.EndY, geom_CompositeCurveSegment.CenterX, geom_CompositeCurveSegment.CenterY, geom_CompositeCurveSegment.IsClockwise(new gp_Dir(0.0, 0.0, 1.0)), string.Empty);
				}
				else
				{
					AddSegmentToPolyline(periodCurve.Segments[num8].EndX, periodCurve.Segments[num8].EndY, string.Empty);
				}
			}
			double num9 = 0.0;
			double num10 = 0.0;
			if (list.Count > 1)
			{
				num10 = list[list.Count - 1];
				num9 = Math.Max((num - num10) / (double)(list.Count - 1), 0.0);
			}
			else
			{
				num9 = Math.Max(num / (double)list.Count, 0.0);
			}
			CreateUnidirectionalMillingStrategy(allowMultiplePasses: true, num9, num10, 0);
		}
		return flag;
	}

	private bool _0023_003Dzg0zfbzNZ6bcXDOxPOQ_003D_003D()
	{
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		double num;
		if (2u != 0)
		{
			num = 0.0;
		}
		double num2;
		if (true)
		{
			num2 = 0.0;
		}
		double num3;
		if (6u != 0)
		{
			num3 = 0.0;
		}
		if (ActiveAttributes.Count == 0)
		{
			return false;
		}
		GeomCompositeCurve geometry = _0023_003DzVsFfuwI_003D.GeometryPath.Geometry;
		GeomGeometry geomGeometry;
		if (3u != 0)
		{
			geomGeometry = geometry;
		}
		if (!(geomGeometry is GeomCompositeCurve))
		{
			return false;
		}
		_projectInterface.ToLocalGeometry(geomGeometry);
		_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D = new _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D(geomGeometry as GeomCompositeCurve, ActiveAttributes);
		_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2;
		if (4u != 0)
		{
			_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D;
		}
		int num4 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzPen3gQDMkeFQ[typeof(DepthAttribute)];
		int num5;
		if (6u != 0)
		{
			num5 = num4;
		}
		if (num5 == 0)
		{
			return false;
		}
		if (_0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D != null && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D != null && _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D.Count() > 0)
		{
			List<Attribute> _0023_003DzalosG58_003D = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D;
			Predicate<Attribute> predicate = _0023_003DzJBaCSp8_003D._0023_003Dz6rLETOCrX9GjfVH7nQ_003D_003D;
			if (predicate == null)
			{
				predicate = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz53Gf6vTWH7nLTp6K3y2Pmk_SeLALyBRtNg_003D_003D;
				Predicate<Attribute> _0023_003Dz6rLETOCrX9GjfVH7nQ_003D_003D = predicate;
				if (3u != 0)
				{
					_0023_003DzJBaCSp8_003D._0023_003Dz6rLETOCrX9GjfVH7nQ_003D_003D = _0023_003Dz6rLETOCrX9GjfVH7nQ_003D_003D;
				}
			}
			if (_0023_003DzalosG58_003D.FindAll(predicate) != null)
			{
				List<Attribute> _0023_003DzalosG58_003D2 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D;
				Predicate<Attribute> predicate2 = _0023_003DzJBaCSp8_003D._0023_003DzsUOi3sTeNStHIiVNMw_003D_003D;
				if (predicate2 == null)
				{
					predicate2 = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzxAbBhfSsmIDbp0yGbRqNmgSvKlpCntHSnQ_003D_003D;
					Predicate<Attribute> _0023_003DzsUOi3sTeNStHIiVNMw_003D_003D = predicate2;
					if (0 == 0)
					{
						_0023_003DzJBaCSp8_003D._0023_003DzsUOi3sTeNStHIiVNMw_003D_003D = _0023_003DzsUOi3sTeNStHIiVNMw_003D_003D;
					}
				}
				if (_0023_003DzalosG58_003D2.FindAll(predicate2).Count() > 0)
				{
					List<Attribute> _0023_003DzalosG58_003D3 = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D[0]._0023_003DzalosG58_003D;
					Predicate<Attribute> predicate3 = _0023_003DzJBaCSp8_003D._0023_003Dzxw3A73zsJgKhCy9lZw_003D_003D;
					if (predicate3 == null)
					{
						predicate3 = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzgWzwyGm7sNk3j6cE6A78ZS85Bf23xNHivw_003D_003D;
						Predicate<Attribute> _0023_003Dzxw3A73zsJgKhCy9lZw_003D_003D = predicate3;
						if (true)
						{
							_0023_003DzJBaCSp8_003D._0023_003Dzxw3A73zsJgKhCy9lZw_003D_003D = _0023_003Dzxw3A73zsJgKhCy9lZw_003D_003D;
						}
					}
					Attribute attribute = _0023_003DzalosG58_003D3.FindAll(predicate3).First();
					Attribute attribute2 = default(Attribute);
					if (0 == 0)
					{
						attribute2 = attribute;
					}
					if (num5 == 1 && attribute2 != null && (attribute2.Value as DepthAttribute).UPar == 0.0)
					{
						return false;
					}
				}
			}
		}
		Geom_CompositeCurve periodCurve = null;
		Geom_Axis2Placement placement = (_projectInterface.Get(base.ActiveWorkplane.ReferenceKey) as Plane).Placement.TypedGeometry();
		if (!OCGeomHelper.IsPeriodicCurve(geomGeometry.Geometry as Geom_CompositeCurve, placement, null, ref periodCurve))
		{
			return false;
		}
		bool flag = true;
		List<double> list = new List<double>();
		int count = periodCurve.Segments.Count;
		List<_0023_003Dz_0024LciYniBgT_vL0xrL9MfWMcYrUSWMlDWvw_003D_003D> _0023_003DzghtInQU_003D = _0023_003Dze2OSnD16ZdarYXDqYD_0024PVEPzGfKKuSgi_0024w_003D_003D2._0023_003DzghtInQU_003D;
		int num6 = 0;
		for (int i = 0; i < _0023_003DzghtInQU_003D.Count; i++)
		{
			if (!flag)
			{
				break;
			}
			num6++;
			Attribute attribute3 = _0023_003DzghtInQU_003D[i]._0023_003DzalosG58_003D.Find(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz0287C2qZPd96jhvzJd69IXoLzx8dVcDp0g_003D_003D);
			if (attribute3 != null)
			{
				double depth = (attribute3.Value as DepthAttribute).Depth;
				if (MathUtility.IsLower(depth, num, PrecisionExtension.Confusion()))
				{
					flag = false;
					break;
				}
				num3 = depth - num2;
				if (num < depth)
				{
					num = depth;
				}
			}
			if (num6 == count)
			{
				num2 = num3;
				list.Add(num2);
				num6 = 0;
				num3 = 0.0;
			}
		}
		if (flag && list.Count > 0)
		{
			ActiveAttributes.Clear();
			_0023_003DzVsFfuwI_003D.StartZ = num;
			if (!_projectInterface.HasGeometryFeatures(base.ActiveGeometry.ReferenceKey))
			{
				DeleteGeometry(base.ActiveGeometry.Name);
			}
			CreatePolyline(string.Empty, periodCurve.Segments[0].StartX, periodCurve.Segments[0].StartY);
			for (int j = 0; j < periodCurve.Segments.Count; j++)
			{
				if (periodCurve.Segments[j].IsArc)
				{
					Geom_CompositeCurveSegment geom_CompositeCurveSegment = periodCurve.Segments[j];
					AddArc2PointCenterToPolyline(geom_CompositeCurveSegment.EndX, geom_CompositeCurveSegment.EndY, geom_CompositeCurveSegment.CenterX, geom_CompositeCurveSegment.CenterY, geom_CompositeCurveSegment.IsClockwise(new gp_Dir(0.0, 0.0, 1.0)), string.Empty);
				}
				else
				{
					AddSegmentToPolyline(periodCurve.Segments[j].EndX, periodCurve.Segments[j].EndY, string.Empty);
				}
			}
			double num7 = 0.0;
			double num8 = 0.0;
			if (list.Count > 1 && Math.Abs(list[list.Count - 1] - list[list.Count - 2]) > PrecisionExtension.Technology())
			{
				num8 = list[list.Count - 1];
			}
			int num9 = 0;
			num9 = ((num8 != 0.0) ? list.Count : (list.Count - 1));
			num7 = Math.Max(num / (double)num9, 0.0);
			CreateHelicMillingStrategy(num7, allowsFinishCutting: true, 0.0);
		}
		return flag;
	}

	private void _0023_003DzpIWvQpnHGzBbhAaOjQ_003D_003D()
	{
		if (_0023_003DzSQkjbRxUPIwq)
		{
			return;
		}
		string empty = string.Empty;
		string _0023_003DzgKk_6RWNW19R;
		if (8u != 0)
		{
			_0023_003DzgKk_6RWNW19R = empty;
		}
		string empty2 = string.Empty;
		string _0023_003DzXxDWvs0pMGW;
		if (7u != 0)
		{
			_0023_003DzXxDWvs0pMGW = empty2;
		}
		string empty3 = string.Empty;
		string _0023_003DzXmpvTagHx2Y;
		if (2u != 0)
		{
			_0023_003DzXmpvTagHx2Y = empty3;
		}
		string tool = _0023_003DzVsFfuwI_003D.Tool;
		if (0 == 0)
		{
			_0023_003DzroT_0024CHIrHrV3(tool, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
		}
		CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
		CoreTool coreTool2;
		if (4u != 0)
		{
			coreTool2 = coreTool;
		}
		string obj = ((_0023_003DzXmpvTagHx2Y == string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714795) : Convert.ToString(Convert.ToInt16(_0023_003DzXmpvTagHx2Y) + 2));
		if (uint.MaxValue != 0)
		{
			_0023_003DzXmpvTagHx2Y = obj;
		}
		if (coreTool2 == null)
		{
			string obj2 = (_0023_003DzXmpvTagHx2Y.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
			string text;
			if (uint.MaxValue != 0)
			{
				text = obj2;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713396);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new object[2] { text, _0023_003DzXxDWvs0pMGW };
			if (7u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
			return;
		}
		if (_0023_003DzVsFfuwI_003D.Tool != _0023_003DzgKk_6RWNW19R)
		{
			_errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzVsFfuwI_003D.Name);
			AddToErrorFile(_errorString);
		}
		_0023_003DzXxDWvs0pMGW = coreTool2.Name;
		double num = _0023_003DzVsFfuwI_003D.InputFeed ?? (-1.0);
		double speed = _0023_003DzVsFfuwI_003D.Feed ?? (-1.0);
		double rotSpeed = _0023_003DzVsFfuwI_003D.SpindleSpeed ?? (-1.0);
		SetPneumaticHoodPosition((_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D).HoodPosition);
		if (IsAuxiliaryHoodPositionModal)
		{
			SetAuxiliaryHoodPosition(ActiveAuxiliaryHoodPosition);
		}
		Create3DRoughFinish(_0023_003DzVsFfuwI_003D.Name, string.Empty, TypeOfProcess.GeneralRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, num, rotSpeed, speed, (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)._0023_003Dz4_00246rGsuVlM0F(), (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)._0023_003Dzdk0EeYGR8Wrc());
		ResetPneumaticHood();
		ResetAuxiliaryHood();
		SetBrakes(string.Empty);
		CreateToolpath3D(string.Empty, _0023_003DzVsFfuwI_003D.StartX, _0023_003DzVsFfuwI_003D.StartY, _0023_003DzVsFfuwI_003D.StartZ ?? 0.0);
		double num2 = num;
		foreach (_0023_003DzmyBcQpGca4JiE8rKBhAoQrJBCYlk3QGbCk7hrZU_003D item in (_0023_003DzVsFfuwI_003D as _0023_003DzKXNfIhiQtfJ6y3BhORGzBeTtyJaSBnw2_0024Q_003D_003D)._0023_003DzghtInQU_003D)
		{
			AddSegmentToToolpath(item._0023_003DziAO_TyQ_003D().Value, item._0023_003DzQykhbpQ_003D().Value, item._0023_003Dz2mrTZJQ_003D().Value, item._0023_003DzizFrTHZa3LZJ(), item._0023_003DzU7eWKUm9uoir());
			if (item._0023_003Dz9KzFds0_003D().HasValue && num2 != item._0023_003Dz9KzFds0_003D().Value)
			{
				num2 = item._0023_003Dz9KzFds0_003D().Value;
				SetToolpathAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702931), num2);
			}
		}
		_0023_003Dz6O8F0jNAY_0024c7.Add(_0023_003DzVsFfuwI_003D);
	}

	private void _0023_003DztSoiHWo83Qt_XrtNcA_003D_003D()
	{
	}

	private void _0023_003Dz0n8LLjfGZoB1T6pmGQ_003D_003D()
	{
		if (_0023_003DzSQkjbRxUPIwq)
		{
			return;
		}
		if (_0023_003DzBuZoGmk4jEdm())
		{
			if (3u != 0)
			{
				_0023_003Dz4_pxzK48xRBPzYBDsw_003D_003D();
			}
		}
		else if (0 == 0)
		{
			_0023_003DzQ1V0e1u7F_f8kN1q4E1OslCH7VOe();
		}
	}

	private void _0023_003Dz4_pxzK48xRBPzYBDsw_003D_003D()
	{
		try
		{
			if (base.ActiveLeadInOut != null && !string.IsNullOrEmpty(_0023_003DzVsFfuwI_003D.Name) && !_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D.ContainsKey(_0023_003DzVsFfuwI_003D.Name))
			{
				_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D.Add(_0023_003DzVsFfuwI_003D.Name, new LeadInOut(base.ActiveLeadInOut));
			}
			string empty = string.Empty;
			string _0023_003DzgKk_6RWNW19R;
			if (8u != 0)
			{
				_0023_003DzgKk_6RWNW19R = empty;
			}
			string empty2 = string.Empty;
			string _0023_003DzXxDWvs0pMGW;
			if (8u != 0)
			{
				_0023_003DzXxDWvs0pMGW = empty2;
			}
			string empty3 = string.Empty;
			string _0023_003DzXmpvTagHx2Y;
			if (4u != 0)
			{
				_0023_003DzXmpvTagHx2Y = empty3;
			}
			string tool = _0023_003DzVsFfuwI_003D.Tool;
			if (7u != 0)
			{
				_0023_003DzroT_0024CHIrHrV3(tool, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
			}
			CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
			CoreTool coreTool2;
			if (2u != 0)
			{
				coreTool2 = coreTool;
			}
			string obj = ((_0023_003DzXmpvTagHx2Y == string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714795) : Convert.ToString(Convert.ToInt16(_0023_003DzXmpvTagHx2Y) + 2));
			if (5u != 0)
			{
				_0023_003DzXmpvTagHx2Y = obj;
			}
			if (coreTool2 == null)
			{
				string obj2 = (_0023_003DzXmpvTagHx2Y.Equals(string.Empty) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				string text;
				if (5u != 0)
				{
					text = obj2;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new object[2] { text, _0023_003DzXxDWvs0pMGW };
				if (0 == 0)
				{
					ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
				}
				return;
			}
			if (_0023_003DzVsFfuwI_003D.Tool != _0023_003DzgKk_6RWNW19R)
			{
				string errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzVsFfuwI_003D.Name);
				if (8u != 0)
				{
					_errorString = errorString;
				}
				string errorString2 = _errorString;
				if (6u != 0)
				{
					AddToErrorFile(errorString2);
				}
			}
			_0023_003DzXxDWvs0pMGW = coreTool2.Name;
			List<Attribute> list = ActiveAttributes.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzIVPT587Z527ZBbSzkK0WTN05pc5xzd5v0g_003D_003D);
			if (list != null && list.Count > 0)
			{
				_0023_003Dz4T0tvr1Sohar = list.Max(delegate(Attribute _0023_003Dz6pELRLc_003D)
				{
					_ = 0;
					if (8 == 0)
					{
					}
					return (_0023_003Dz6pELRLc_003D.Value as DepthAttribute).Depth;
				});
			}
			_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D = _0023_003DzVsFfuwI_003D as _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D;
			double _0023_003Dzr9mC8No_003D = _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003Dz1gEynnxvwUDQ();
			TypeOfToolApproach _0023_003DzXlrGaU97yiX0F27zSA_003D_003D = _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzAwbkfjACnGW0Ph58XyeDUyM_003D();
			ToolTypeInfo _0023_003Dz2RDQ6_0024uiPzQu;
			bool flag = _0023_003DzWIQYmkYg8_vy2BTK36gpWqlrikWaJWMyrA_003D_003D(coreTool2, out _0023_003Dz2RDQ6_0024uiPzQu);
			_0023_003DzrqKeWwSMDDDBHGeoig_003D_003D(flag, ref _0023_003Dzr9mC8No_003D, ref _0023_003DzXlrGaU97yiX0F27zSA_003D_003D);
			_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzH38BfMmhvee9(_0023_003Dzr9mC8No_003D);
			_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzfCW7s3CjvltSEYI6xHm7ZXM_003D(_0023_003DzXlrGaU97yiX0F27zSA_003D_003D);
			bool flag2 = _0023_003DzLxZuBLCD9ZJFEII9Tuq1dgM_003D();
			if (!flag2)
			{
				flag2 = _0023_003DzV5GL6id6Y8_qG_BSbYbgG6g_003D();
			}
			if (!flag2)
			{
				flag2 = _0023_003DzCG_0024_0024U8FXg8_eauZRjQ_003D_003D();
			}
			double num = _0023_003DzVsFfuwI_003D.StartZ.Value;
			double overMaterial = _0023_003DzVsFfuwI_003D.ToolCorrection.OverMaterial;
			double inputSpeed = _0023_003DzVsFfuwI_003D.InputFeed ?? (-1.0);
			double speed = _0023_003DzVsFfuwI_003D.Feed ?? (-1.0);
			double rotSpeed = _0023_003DzVsFfuwI_003D.SpindleSpeed ?? (-1.0);
			SetPneumaticHoodPosition((_0023_003DzVsFfuwI_003D as _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D).HoodPosition);
			if (IsAuxiliaryHoodPositionModal)
			{
				SetAuxiliaryHoodPosition(ActiveAuxiliaryHoodPosition);
			}
			if (_0023_003DzaepqoE8sVHIF == KindOfToolFamily.BladeCuttingTool.ToString() || (_0023_003DzaepqoE8sVHIF == KindOfToolFamily.MillingCuttingTool.ToString() && base.ActiveGeometry is Segment && !flag))
			{
				double num2 = num;
				bool flag3 = true;
				if (ActiveAttributes != null && ActiveAttributes.Count > 0)
				{
					for (int num3 = 0; num3 < ActiveAttributes.Count; num3++)
					{
						if (ActiveAttributes.ElementAt(num3).Value is DepthAttribute)
						{
							if (flag3)
							{
								num = (ActiveAttributes.ElementAt(num3).Value as DepthAttribute).Depth;
							}
							num2 = (ActiveAttributes.ElementAt(num3).Value as DepthAttribute).Depth;
							flag3 = false;
						}
					}
				}
				double num4 = num * (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n();
				double num5 = num2 * (double)_0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n();
				if (((num4 < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (num4 > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1)) && ((num5 < 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == 1) || (num5 > 0.0 && _0023_003DzmNgNJnU_003D._0023_003DzUyskgYNQbz5n() == -1)))
				{
					_errorString = LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713175), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990));
					AddToErrorFile(_errorString);
					_activeStrategy = null;
					ActiveAttributes.Clear();
					DeleteGeometry(base.ActiveGeometry.Name);
					ResetApproachStrategy();
					ResetRetractStrategy();
				}
				else
				{
					double num6 = 0.0;
					bool _0023_003DzbdegC5Muapsu = false;
					num6 = _0023_003DzbjQVYKGlRMMA(ref _0023_003DzbdegC5Muapsu);
					bool flag4 = false;
					if (_0023_003DzbdegC5Muapsu && base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
					{
						flag4 = true;
					}
					if (flag4)
					{
						CreateBladeCut(string.Empty, string.Empty, TypeOfProcess.GeneralRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, _0023_003Dzr9mC8No_003D, _0023_003DzVsFfuwI_003D.ToolCorrection.Correction, inputSpeed, rotSpeed, speed, overMaterial, cutPositionUpper: true, materialPositionLeft: true, 0.0, num6);
					}
					else
					{
						CreateSlot(string.Empty, num, string.Empty, TypeOfProcess.SlotRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, _0023_003DzVsFfuwI_003D.ToolCorrection.Correction, inputSpeed, rotSpeed, speed, overMaterial, _0023_003Dzr9mC8No_003D, num2);
					}
				}
			}
			else if (_0023_003Dz2RDQ6_0024uiPzQu != null)
			{
				if (_0023_003Dz2RDQ6_0024uiPzQu.KindOfToolType == KindOfToolType.TrimmerMill)
				{
					CreateTrimming(_0023_003DzVsFfuwI_003D.Name, (int)(_0023_003DzVsFfuwI_003D as _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)._0023_003DzAwbkfjACnGW0Ph58XyeDUyM_003D(), num, string.Empty, TypeOfProcess.Trimming, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, _0023_003DzVsFfuwI_003D.ToolCorrection.Correction, inputSpeed, rotSpeed, speed, overMaterial);
				}
				else if (_0023_003Dz2RDQ6_0024uiPzQu.KindOfToolType == KindOfToolType.EdgeScraperMill)
				{
					CreateEdgeScraping(_0023_003DzVsFfuwI_003D.Name, (int)(_0023_003DzVsFfuwI_003D as _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)._0023_003DzAwbkfjACnGW0Ph58XyeDUyM_003D(), num, string.Empty, TypeOfProcess.EdgeScraping, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, _0023_003DzVsFfuwI_003D.ToolCorrection.Correction, inputSpeed, rotSpeed, speed, overMaterial);
				}
				else if (_0023_003Dz2RDQ6_0024uiPzQu.KindOfToolType == KindOfToolType.GlueScraperMill)
				{
					CreateGlueScraping(_0023_003DzVsFfuwI_003D.Name, (int)(_0023_003DzVsFfuwI_003D as _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D)._0023_003DzAwbkfjACnGW0Ph58XyeDUyM_003D(), num, string.Empty, TypeOfProcess.GlueScraping, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, _0023_003DzVsFfuwI_003D.ToolCorrection.Correction, inputSpeed, rotSpeed, speed, overMaterial);
				}
				else
				{
					CreateSlantedRoughFinish(_0023_003DzVsFfuwI_003D.Name, _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzWd5YLELs2rAg(), _0023_003Dzr9mC8No_003D, (int)_0023_003DzXlrGaU97yiX0F27zSA_003D_003D, num, string.Empty, TypeOfProcess.GeneralRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, inputSpeed, rotSpeed, speed, overMaterial);
				}
			}
			ResetPneumaticHood();
			ResetAuxiliaryHood();
			SetBrakes(string.Empty);
			ResetApproachStrategy();
			ResetRetractStrategy();
			_0023_003Dz6O8F0jNAY_0024c7.Add(_0023_003DzVsFfuwI_003D);
			_0023_003Dz4T0tvr1Sohar = null;
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713368), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private bool _0023_003DzWIQYmkYg8_vy2BTK36gpWqlrikWaJWMyrA_003D_003D(CoreTool _0023_003DzyagUmhsbHglp, out ToolTypeInfo _0023_003Dz2RDQ6_0024uiPzQu)
	{
		bool result;
		if (7u != 0)
		{
			result = false;
		}
		_0023_003Dz2RDQ6_0024uiPzQu = _toolInterface.GetToolType(_0023_003DzyagUmhsbHglp);
		if (_0023_003Dz2RDQ6_0024uiPzQu != null && (_0023_003Dz2RDQ6_0024uiPzQu.KindOfToolType == KindOfToolType.TrimmerMill || _0023_003Dz2RDQ6_0024uiPzQu.KindOfToolType == KindOfToolType.EdgeScraperMill || _0023_003Dz2RDQ6_0024uiPzQu.KindOfToolType == KindOfToolType.GlueScraperMill))
		{
			if (8u != 0)
			{
				result = true;
			}
		}
		return result;
	}

	private void _0023_003DzQ1V0e1u7F_f8kN1q4E1OslCH7VOe()
	{
		try
		{
			if (base.ActiveLeadInOut != null && !string.IsNullOrEmpty(_0023_003DzVsFfuwI_003D.Name) && !_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D.ContainsKey(_0023_003DzVsFfuwI_003D.Name))
			{
				_0023_003DzGhctG9_0024PxoobgafHZQ_003D_003D.Add(_0023_003DzVsFfuwI_003D.Name, new LeadInOut(base.ActiveLeadInOut));
			}
			string empty = string.Empty;
			string _0023_003DzgKk_6RWNW19R;
			if (7u != 0)
			{
				_0023_003DzgKk_6RWNW19R = empty;
			}
			string empty2 = string.Empty;
			string _0023_003DzXxDWvs0pMGW;
			if (6u != 0)
			{
				_0023_003DzXxDWvs0pMGW = empty2;
			}
			string empty3 = string.Empty;
			string _0023_003DzXmpvTagHx2Y;
			if (uint.MaxValue != 0)
			{
				_0023_003DzXmpvTagHx2Y = empty3;
			}
			string tool = _0023_003DzVsFfuwI_003D.Tool;
			if (2u != 0)
			{
				_0023_003DzroT_0024CHIrHrV3(tool, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
			}
			CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
			CoreTool coreTool2;
			if (8u != 0)
			{
				coreTool2 = coreTool;
			}
			string obj = ((!StringUtility.IsValid(_0023_003DzXmpvTagHx2Y)) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714795) : Convert.ToString(Convert.ToInt16(_0023_003DzXmpvTagHx2Y) + 2));
			if (6u != 0)
			{
				_0023_003DzXmpvTagHx2Y = obj;
			}
			if (coreTool2 == null)
			{
				string obj2 = ((!StringUtility.IsValid(_0023_003DzXmpvTagHx2Y)) ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715577) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715850));
				string text = default(string);
				if (0 == 0)
				{
					text = obj2;
				}
				string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715561);
				string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new object[2] { text, _0023_003DzXxDWvs0pMGW };
				if (0 == 0)
				{
					ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
				}
				return;
			}
			if (_0023_003DzVsFfuwI_003D.Tool != _0023_003DzgKk_6RWNW19R)
			{
				string errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715532), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003DzVsFfuwI_003D.Name);
				if (3u != 0)
				{
					_errorString = errorString;
				}
				AddToErrorFile(_errorString);
			}
			_0023_003DzXxDWvs0pMGW = coreTool2.Name;
			_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D = _0023_003DzVsFfuwI_003D as _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D;
			_0023_003Dz4T0tvr1Sohar = 0.0;
			ActiveAttributes.FindAll(delegate(Attribute _0023_003Dz6pELRLc_003D)
			{
				_ = 1;
				if (1 == 0)
				{
				}
				return _0023_003Dz6pELRLc_003D.Value is DepthAttribute;
			}).ForEach(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003Dz3ffEFzAhXEga5QqQ_4om0dNzp2UoMdx5v84KwFg_003D);
			if (_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzAwbkfjACnGW0Ph58XyeDUyM_003D() != TypeOfToolApproach.ParallelXPositive)
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713315), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			double _0023_003Dzr9mC8No_003D = _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003Dz1gEynnxvwUDQ();
			TypeOfToolApproach _0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.ParallelXPositive;
			_0023_003DzrqKeWwSMDDDBHGeoig_003D_003D(_0023_003DzaxlMF4ZHowAp_0024qQJAOdcLAg_003D: false, ref _0023_003Dzr9mC8No_003D, ref _0023_003DzXlrGaU97yiX0F27zSA_003D_003D);
			_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzH38BfMmhvee9(_0023_003Dzr9mC8No_003D);
			_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzfCW7s3CjvltSEYI6xHm7ZXM_003D(TypeOfToolApproach.ParallelXPositive);
			double depth = 0.0;
			double overMaterial = 0.0;
			double inputSpeed = _0023_003DzVsFfuwI_003D.InputFeed ?? (-1.0);
			double speed = _0023_003DzVsFfuwI_003D.Feed ?? (-1.0);
			double rotSpeed = _0023_003DzVsFfuwI_003D.SpindleSpeed ?? (-1.0);
			SetPneumaticHoodPosition(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D.HoodPosition);
			if (IsAuxiliaryHoodPositionModal)
			{
				SetAuxiliaryHoodPosition(ActiveAuxiliaryHoodPosition);
			}
			if (_0023_003DzaepqoE8sVHIF == KindOfToolFamily.MillingCuttingTool.ToString())
			{
				List<Attribute> _0023_003DzQO5Jkpeaxo_0024O = ActiveAttributes.FindAll(delegate(Attribute _0023_003DzLDWhkEg_003D)
				{
					_ = -1;
					if (-1 == 0)
					{
					}
					return _0023_003DzLDWhkEg_003D.Value is HeightAttribute;
				}).Clone();
				ActiveAttributes.RemoveAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzrrLdAQSHZBYKzpA9pGXKnxeiByQxyaZmKf_kmDY_003D);
				Operation _0023_003DzIDjFPYA_003D = CreateSlantedRoughFinish(_0023_003DzVsFfuwI_003D.Name, _0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D._0023_003DzWd5YLELs2rAg(), _0023_003Dzr9mC8No_003D, (int)_0023_003DzXlrGaU97yiX0F27zSA_003D_003D, depth, string.Empty, TypeOfProcess.GeneralRouting, _0023_003DzXxDWvs0pMGW, _0023_003DzXmpvTagHx2Y, inputSpeed, rotSpeed, speed, overMaterial);
				_0023_003Dz0sJOfl1bltMkr3Zd9asMnmw_003D(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D, _0023_003DzQO5Jkpeaxo_0024O, _0023_003DzIDjFPYA_003D);
				ResetPneumaticHood();
				ResetAuxiliaryHood();
				SetBrakes(string.Empty);
				ResetApproachStrategy();
				ResetRetractStrategy();
				_0023_003Dz6O8F0jNAY_0024c7.Add(_0023_003DzVsFfuwI_003D);
				_0023_003Dz4T0tvr1Sohar = null;
			}
			else
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713018), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712977), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private void _0023_003Dz0sJOfl1bltMkr3Zd9asMnmw_003D(_0023_003DzXKUI0khjuT_pyQQI4Uul8FDZywgWqzUSdw_003D_003D _0023_003Dzw501pQVTgonNCAv7UA_003D_003D, List<Attribute> _0023_003DzQO5Jkpeaxo_0024O, Operation _0023_003DzIDjFPYA_003D)
	{
		try
		{
			_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D = new _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D();
			_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2;
			if (5u != 0)
			{
				_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2 = _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D;
			}
			if (0 == 0)
			{
				_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003DzfOCoHG40Z_ED = this;
			}
			double originZ = base.ActiveWorkplane.OriginZ;
			double num = default(double);
			if (0 == 0)
			{
				num = originZ;
			}
			_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003DzzZAy6Tk_003D = 0.0;
			Polyline geometryPath = _0023_003Dzw501pQVTgonNCAv7UA_003D_003D.GeometryPath;
			_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003Dz5Je5VG8_003D = geometryPath.Elements[0];
			Attribute attribute = _0023_003DzQO5Jkpeaxo_0024O.Find(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzU0gd6j6ELyMVnSA4D73HjAu3QdDh94dmdw_003D_003D);
			if (attribute != null)
			{
				_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003DzzZAy6Tk_003D = (attribute.Value as HeightAttribute).Height - num;
			}
			string name = _0023_003DzIDjFPYA_003D.Name + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705221);
			CreateToolpath(name, _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003Dz5Je5VG8_003D.StartXGlobal, _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003Dz5Je5VG8_003D.StartYGlobal, _0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003DzzZAy6Tk_003D);
			_0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D _0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D = new _0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D();
			_0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D._0023_003Dz3cCeXbQ_003D = 0;
			while (_0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D._0023_003Dz3cCeXbQ_003D < geometryPath.Elements.Count)
			{
				_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003Dz5Je5VG8_003D = geometryPath.Elements[_0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D._0023_003Dz3cCeXbQ_003D];
				_0023_003DzQO5Jkpeaxo_0024O.FindAll(_0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D._0023_003DzIQufLlDvAhomc5sXEjnrLUcB9vpa).ForEach(_0023_003DzfpTctmIBhTukGx5unUrVvt4_003D2._0023_003DzSF3qKOo3Kel_R4T9sEQd1_0DQa2B);
				_0023_003DzghVqTmAO4EV8rrDq2fEFIRQ_003D._0023_003Dz3cCeXbQ_003D++;
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712928), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	private bool _0023_003DzBuZoGmk4jEdm()
	{
		bool result;
		if (6u != 0)
		{
			result = true;
		}
		try
		{
			string text = _0023_003DzaepqoE8sVHIF;
			KindOfToolFamily kindOfToolFamily = default(KindOfToolFamily);
			if (0 == 0)
			{
				kindOfToolFamily = KindOfToolFamily.MillingCuttingTool;
			}
			if (text == kindOfToolFamily.ToString())
			{
				string empty = string.Empty;
				string _0023_003DzgKk_6RWNW19R;
				if (true)
				{
					_0023_003DzgKk_6RWNW19R = empty;
				}
				string empty2 = string.Empty;
				string _0023_003DzXxDWvs0pMGW;
				if (8u != 0)
				{
					_0023_003DzXxDWvs0pMGW = empty2;
				}
				string _0023_003DzXmpvTagHx2Y = string.Empty;
				_0023_003DzroT_0024CHIrHrV3(_0023_003DzVsFfuwI_003D.Tool, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
				CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
				ToolTypeInfo toolType = _toolInterface.GetToolType(coreTool);
				if (toolType != null && (toolType.KindOfToolType == KindOfToolType.BallEndmill || toolType.KindOfToolType == KindOfToolType.BullnoseEndmill || toolType.KindOfToolType == KindOfToolType.ConicalEndmill || toolType.KindOfToolType == KindOfToolType.DovetailEndMill || toolType.KindOfToolType == KindOfToolType.ShapedMill || toolType.KindOfToolType == KindOfToolType.FlatBandMill || toolType.KindOfToolType == KindOfToolType.Endmill))
				{
					List<Attribute> list = ActiveAttributes.FindAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzTy4kUjV1Vxc4bzKP7EoLpmsAAejZ);
					if (list.Count > 0)
					{
						double height = _0023_003Dzpl6fb1o_003D;
						Attribute attribute = list.Find(delegate(Attribute _0023_003DzLDWhkEg_003D)
						{
							_ = 2;
							if (false)
							{
							}
							return (_0023_003DzLDWhkEg_003D.Value as HeightAttribute).UPar == 0.0;
						});
						if (attribute != null)
						{
							height = (attribute.Value as HeightAttribute).Height;
						}
						for (int num = 0; num < list.Count; num++)
						{
							if (!MathUtility.IsEqual((list[num].Value as HeightAttribute).Height, height))
							{
								result = false;
								break;
							}
						}
					}
				}
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713140), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		return result;
	}

	private double _0023_003Dz6s5uDh6_0024tbw_0024(double _0023_003DzlNZ7pvY_003D)
	{
		double num;
		if (4u != 0)
		{
			num = _0023_003DzlNZ7pvY_003D;
		}
		if (MathUtility.IsGreater(num, 100.0))
		{
			double num2 = num / 1000.0;
			if (uint.MaxValue != 0)
			{
				num = num2;
			}
		}
		return num;
	}

	private double _0023_003Dz9_0024sSLsNoyfJu(double _0023_003Dz3keKASA_003D)
	{
		_ = 0;
		if (4 == 0)
		{
		}
		if (_0023_003Dz2uDCrsHQoMigMdBBTA_003D_003D)
		{
			_ = 0;
			if (8 == 0)
			{
			}
			return _0023_003Dz3keKASA_003D * 25.4;
		}
		_ = 7;
		if (5 == 0)
		{
		}
		return _0023_003Dz3keKASA_003D;
	}

	private int _0023_003DzEDhq3rDH_ccPyG_xin2hj7Y_003D(int _0023_003Dz4n1LAA8_003D)
	{
		if (_0023_003DzHD5fHZnBd7Nm == null || (_0023_003DzHD5fHZnBd7Nm != null && !_0023_003DzHD5fHZnBd7Nm.DontChangePlanesWithArea))
		{
			string text = _0023_003DzTJuyZiS0qOKz;
			string text2;
			if (2u != 0)
			{
				text2 = text;
			}
			uint num = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
			uint num2;
			if (8u != 0)
			{
				num2 = num;
			}
			if (num2 <= 3356228888u)
			{
				if (num2 <= 3255563174u)
				{
					if (num2 != 3222007936u)
					{
						if (num2 != 3238785555u)
						{
							if (num2 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_0248;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_021e;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
					{
						goto IL_0248;
					}
				}
				else if (num2 != 3272340793u)
				{
					if (num2 != 3339451269u)
					{
						if (num2 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_0248;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_021e;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
				{
					goto IL_0266;
				}
			}
			else if (num2 <= 3406561745u)
			{
				if (num2 != 3373006507u)
				{
					if (num2 != 3389784126u)
					{
						if (num2 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_0266;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
					{
						goto IL_0248;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
				{
					goto IL_021e;
				}
			}
			else if (num2 != 3440116983u)
			{
				if (num2 != 3473672221u)
				{
					if (num2 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0266;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_021e;
				}
			}
			else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
			{
				goto IL_0266;
			}
		}
		goto IL_029a;
		IL_021e:
		switch (_0023_003Dz4n1LAA8_003D)
		{
		case 2:
			if (4u != 0)
			{
				_0023_003Dz4n1LAA8_003D = 3;
			}
			break;
		case 3:
			if (0 == 0)
			{
				_0023_003Dz4n1LAA8_003D = 2;
			}
			break;
		}
		goto IL_029a;
		IL_029a:
		return _0023_003Dz4n1LAA8_003D;
		IL_0266:
		switch (_0023_003Dz4n1LAA8_003D)
		{
		case 2:
			_0023_003Dz4n1LAA8_003D = 3;
			break;
		case 3:
			_0023_003Dz4n1LAA8_003D = 2;
			break;
		case 4:
			_0023_003Dz4n1LAA8_003D = 5;
			break;
		case 5:
			_0023_003Dz4n1LAA8_003D = 4;
			break;
		}
		goto IL_029a;
		IL_0248:
		switch (_0023_003Dz4n1LAA8_003D)
		{
		case 4:
			if (2u != 0)
			{
				_0023_003Dz4n1LAA8_003D = 5;
			}
			break;
		case 5:
			_0023_003Dz4n1LAA8_003D = 4;
			break;
		}
		goto IL_029a;
	}

	private int _0023_003DzGXYQvSTndE5W0wzvLgDcN80_003D(int _0023_003DzKxEJvaat1ZOvnQ18pfY7CshmGsgd)
	{
		int num;
		if (2u != 0)
		{
			num = _0023_003DzKxEJvaat1ZOvnQ18pfY7CshmGsgd;
		}
		if (_0023_003DzHD5fHZnBd7Nm != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.ContainsKey(base.ActiveWorkplane.Name))
		{
			_0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.TryGetValue(base.ActiveWorkplane.Name, out var value);
			switch (value)
			{
			case Specularity.SpecX:
			{
				int num3 = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
				if (6u != 0)
				{
					num = num3;
				}
				break;
			}
			case Specularity.SpecY:
			{
				int num2 = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
				if (8u != 0)
				{
					num = num2;
				}
				break;
			}
			}
		}
		bool num4 = _0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D();
		bool flag;
		if (5u != 0)
		{
			flag = num4;
		}
		if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
		{
			if (flag)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				string text2;
				if (3u != 0)
				{
					text2 = text;
				}
				uint num5 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				uint num6;
				if (8u != 0)
				{
					num6 = num5;
				}
				if (num6 <= 3406561745u)
				{
					if (num6 <= 3289118412u)
					{
						if (num6 != 3272340793u)
						{
							if (num6 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_0226;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
						{
							goto IL_0226;
						}
					}
					else if (num6 != 3322673650u)
					{
						if (num6 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_0226;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_0226;
					}
				}
				else if (num6 <= 3440116983u)
				{
					if (num6 != 3423339364u)
					{
						if (num6 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_0226;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
					{
						goto IL_0226;
					}
				}
				else if (num6 != 3456894602u)
				{
					if (num6 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0226;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_0226;
				}
			}
			else
			{
				string text3 = _0023_003DzTJuyZiS0qOKz;
				string text2;
				if (6u != 0)
				{
					text2 = text3;
				}
				uint num7 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				uint num6;
				if (6u != 0)
				{
					num6 = num7;
				}
				if (num6 <= 3406561745u)
				{
					if (num6 <= 3289118412u)
					{
						if (num6 != 3272340793u)
						{
							if (num6 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_038e;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
						{
							goto IL_038e;
						}
					}
					else if (num6 != 3322673650u)
					{
						if (num6 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_038e;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_038e;
					}
				}
				else if (num6 <= 3440116983u)
				{
					if (num6 != 3423339364u)
					{
						if (num6 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_038e;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
					{
						goto IL_038e;
					}
				}
				else if (num6 != 3456894602u)
				{
					if (num6 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_038e;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_038e;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3356228888u)
				{
					if (num6 <= 3255563174u)
					{
						if (num6 != 3222007936u)
						{
							if (num6 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_050d;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_050d;
						}
					}
					else if (num6 != 3272340793u)
					{
						if (num6 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_050d;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_050d;
					}
				}
				else if (num6 <= 3406561745u)
				{
					if (num6 != 3389784126u)
					{
						if (num6 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_050d;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
					{
						goto IL_050d;
					}
				}
				else if (num6 != 3440116983u)
				{
					if (num6 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_050d;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_050d;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3356228888u)
				{
					if (num6 <= 3255563174u)
					{
						if (num6 != 3222007936u)
						{
							if (num6 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_0661;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_0661;
						}
					}
					else if (num6 != 3272340793u)
					{
						if (num6 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_0661;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_0661;
					}
				}
				else if (num6 <= 3406561745u)
				{
					if (num6 != 3389784126u)
					{
						if (num6 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_0661;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
					{
						goto IL_0661;
					}
				}
				else if (num6 != 3440116983u)
				{
					if (num6 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0661;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_0661;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3339451269u)
				{
					if (num6 <= 3289118412u)
					{
						if (num6 != 3238785555u)
						{
							if (num6 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_07dd;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_07dd;
						}
					}
					else if (num6 != 3322673650u)
					{
						if (num6 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_07dd;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_07dd;
					}
				}
				else if (num6 <= 3423339364u)
				{
					if (num6 != 3373006507u)
					{
						if (num6 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_07dd;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_07dd;
					}
				}
				else if (num6 != 3456894602u)
				{
					if (num6 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_07dd;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_07dd;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3339451269u)
				{
					if (num6 <= 3289118412u)
					{
						if (num6 != 3238785555u)
						{
							if (num6 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_0934;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_0934;
						}
					}
					else if (num6 != 3322673650u)
					{
						if (num6 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_0934;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_0934;
					}
				}
				else if (num6 <= 3423339364u)
				{
					if (num6 != 3373006507u)
					{
						if (num6 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_0934;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_0934;
					}
				}
				else if (num6 != 3456894602u)
				{
					if (num6 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_0934;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_0934;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3322673650u)
				{
					if (num6 <= 3255563174u)
					{
						if (num6 != 3222007936u)
						{
							if (num6 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_0aad;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_0aad;
						}
					}
					else if (num6 != 3289118412u)
					{
						if (num6 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_0aad;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_0aad;
					}
				}
				else if (num6 <= 3389784126u)
				{
					if (num6 != 3356228888u)
					{
						if (num6 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_0aad;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_0aad;
					}
				}
				else if (num6 != 3423339364u)
				{
					if (num6 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_0aad;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_0aad;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3373006507u)
				{
					if (num6 <= 3272340793u)
					{
						if (num6 != 3238785555u)
						{
							if (num6 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0c01;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_0c01;
						}
					}
					else if (num6 != 3339451269u)
					{
						if (num6 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0c01;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0c01;
					}
				}
				else if (num6 <= 3440116983u)
				{
					if (num6 != 3406561745u)
					{
						if (num6 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_0c01;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0c01;
					}
				}
				else if (num6 != 3473672221u)
				{
					if (num6 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0c01;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0c01;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
		{
			if (flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3373006507u)
				{
					if (num6 <= 3272340793u)
					{
						if (num6 != 3238785555u)
						{
							if (num6 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0d7a;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_0d7a;
						}
					}
					else if (num6 != 3339451269u)
					{
						if (num6 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0d7a;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0d7a;
					}
				}
				else if (num6 <= 3440116983u)
				{
					if (num6 != 3406561745u)
					{
						if (num6 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_0d7a;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0d7a;
					}
				}
				else if (num6 != 3473672221u)
				{
					if (num6 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0d7a;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0d7a;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num6 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num6 <= 3322673650u)
				{
					if (num6 <= 3255563174u)
					{
						if (num6 != 3222007936u)
						{
							if (num6 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_0ecb;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_0ecb;
						}
					}
					else if (num6 != 3289118412u)
					{
						if (num6 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_0ecb;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_0ecb;
					}
				}
				else if (num6 <= 3389784126u)
				{
					if (num6 != 3356228888u)
					{
						if (num6 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_0ecb;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_0ecb;
					}
				}
				else if (num6 != 3423339364u)
				{
					if (num6 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_0ecb;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_0ecb;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601))
		{
			if (!flag)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680) || text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
				}
			}
		}
		else
		{
			num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		}
		goto IL_0f2e;
		IL_0ecb:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
		IL_038e:
		int num8 = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		if (6u != 0)
		{
			num = num8;
		}
		goto IL_0f2e;
		IL_07dd:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
		IL_0661:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
		IL_0c01:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
		IL_0226:
		int num9 = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		if (8u != 0)
		{
			num = num9;
		}
		goto IL_0f2e;
		IL_050d:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
		IL_0f2e:
		return num;
		IL_0d7a:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
		IL_0aad:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
		IL_0934:
		num = _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num);
		goto IL_0f2e;
	}

	private static int _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(int _0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6)
	{
		switch (_0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6)
		{
		case 1:
			if (0 == 0)
			{
				_0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6 = 2;
			}
			break;
		case 2:
			if (uint.MaxValue != 0)
			{
				_0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6 = 1;
			}
			break;
		case 3:
			if (2u != 0)
			{
				_0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6 = 3;
			}
			break;
		case 13:
			_0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6 = 23;
			break;
		case 23:
			_0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6 = 13;
			break;
		}
		return _0023_003DzFZjLkmwW7aMy7CgfN_4sT8n5xhV6;
	}

	private void _0023_003DzroT_0024CHIrHrV3(string _0023_003DzdVq9VFI_003D, ref string _0023_003DzgKk_6RWNW19R, ref string _0023_003DzXxDWvs0pMGW2, ref string _0023_003DzXmpvTagHx2Y1)
	{
		int num = _0023_003DzdVq9VFI_003D.IndexOf(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710511));
		int length;
		if (8u != 0)
		{
			length = num;
		}
		int num2 = (_0023_003Dzmkh2mynWK8RD ? 3 : 2);
		int num3 = default(int);
		if (0 == 0)
		{
			num3 = num2;
		}
		if (!length.Equals(-1))
		{
			_0023_003DzgKk_6RWNW19R = _0023_003DzdVq9VFI_003D.Substring(0, length);
		}
		else
		{
			_0023_003DzgKk_6RWNW19R = _0023_003DzdVq9VFI_003D;
		}
		_0023_003DzXxDWvs0pMGW2 = ((_0023_003DzgKk_6RWNW19R.Length > num3) ? _0023_003DzgKk_6RWNW19R.Substring(_0023_003DzgKk_6RWNW19R.Length - num3) : _0023_003DzgKk_6RWNW19R);
		_0023_003DzXxDWvs0pMGW2 = _0023_003DzKyFzC29DdXWF8NbHXg_003D_003D(_0023_003DzXxDWvs0pMGW2);
		_0023_003DzXmpvTagHx2Y1 = ((_0023_003DzgKk_6RWNW19R.Length > num3) ? _0023_003DzgKk_6RWNW19R.Substring(0, _0023_003DzgKk_6RWNW19R.Length - num3) : string.Empty);
	}

	private bool _0023_003Dzilu43q8Cm59l(string _0023_003DzgKk_6RWNW19R)
	{
		_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D _0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D = new _0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D();
		_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D _0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D2;
		if (3u != 0)
		{
			_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D2 = _0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D;
		}
		bool result = default(bool);
		if (0 == 0)
		{
			result = false;
		}
		int num = (_0023_003Dzmkh2mynWK8RD ? 3 : 2);
		int num2;
		if (6u != 0)
		{
			num2 = num;
		}
		string text = ((_0023_003DzgKk_6RWNW19R.Length > num2) ? _0023_003DzgKk_6RWNW19R.Substring(0, _0023_003DzgKk_6RWNW19R.Length - num2) : string.Empty);
		_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D2._0023_003Dz_z_7_0024qk_003D = -1;
		if (StringUtility.IsValid(text))
		{
			int num3 = Convert.ToInt32(text);
			if (num3 > 0)
			{
				_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D2._0023_003Dz_z_7_0024qk_003D = num3 + 2;
			}
		}
		if (_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D2._0023_003Dz_z_7_0024qk_003D <= 0)
		{
			result = true;
		}
		else if ((_0023_003DzPCtep8zMf_fPxc_yok0LD_I_003D.Count > 0 || _0023_003DzXcsaA3EZZEeCUSgq0CDRd4DmLbTh.Count > 0) && (_0023_003DzPCtep8zMf_fPxc_yok0LD_I_003D.Find(_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D2._0023_003DzA0rW_KBni7QlTJ1L5w_003D_003D) != null || _0023_003DzXcsaA3EZZEeCUSgq0CDRd4DmLbTh.Find(_0023_003DzFoU5003zHEWQzsnRP9Bi_C4_003D2._0023_003Dz4ZWrfEJni2aZ1AQnyQ_003D_003D) != null))
		{
			result = true;
		}
		return result;
	}

	private bool _0023_003DzbgBdFCN_0024ANguRGG9HMWCM1OSSB_0024L(string _0023_003DzgKk_6RWNW19R)
	{
		_0023_003DzjVm26_sXTvRLCw6B1lgLOzU_003D _0023_003DzjVm26_sXTvRLCw6B1lgLOzU_003D = new _0023_003DzjVm26_sXTvRLCw6B1lgLOzU_003D();
		_0023_003DzjVm26_sXTvRLCw6B1lgLOzU_003D CS_0024_003C_003E8__locals5;
		if (2u != 0)
		{
			CS_0024_003C_003E8__locals5 = _0023_003DzjVm26_sXTvRLCw6B1lgLOzU_003D;
		}
		bool result;
		if (uint.MaxValue != 0)
		{
			result = false;
		}
		int num = (_0023_003Dzmkh2mynWK8RD ? 3 : 2);
		int num2;
		if (8u != 0)
		{
			num2 = num;
		}
		string value = ((_0023_003DzgKk_6RWNW19R.Length > num2) ? _0023_003DzgKk_6RWNW19R.Substring(0, _0023_003DzgKk_6RWNW19R.Length - num2) : string.Empty);
		CS_0024_003C_003E8__locals5._0023_003Dz_z_7_0024qk_003D = -1;
		if (!string.IsNullOrEmpty(value))
		{
			CS_0024_003C_003E8__locals5._0023_003Dz_z_7_0024qk_003D = Convert.ToInt16(value) + 2;
		}
		if ((_0023_003DzPCtep8zMf_fPxc_yok0LD_I_003D.Count > 0 || _0023_003DzXcsaA3EZZEeCUSgq0CDRd4DmLbTh.Count > 0) && CS_0024_003C_003E8__locals5._0023_003Dz_z_7_0024qk_003D != -1 && (_0023_003DzPCtep8zMf_fPxc_yok0LD_I_003D.Find(delegate(StandardBoringHead _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D)
		{
			_ = 3;
			if (6 == 0)
			{
			}
			int headNumber = _0023_003DzD3QH7YWk_7Q3_0024cvj6Q_003D_003D.HeadNumber;
			_ = -1;
			if (8 == 0)
			{
			}
			return headNumber == CS_0024_003C_003E8__locals5._0023_003Dz_z_7_0024qk_003D;
		}) != null || _0023_003DzXcsaA3EZZEeCUSgq0CDRd4DmLbTh.Find(CS_0024_003C_003E8__locals5._0023_003DzDM3_cpF0kTRFe3RLKb5oB6GC7I17XN1Ctg_003D_003D) != null))
		{
			result = true;
		}
		return result;
	}

	private static string _0023_003DzKyFzC29DdXWF8NbHXg_003D_003D(string _0023_003DzXxDWvs0pMGW2)
	{
		int num;
		if (4u != 0)
		{
			num = 0;
		}
		while (num < _0023_003DzXxDWvs0pMGW2.Length)
		{
			if (_0023_003DzXxDWvs0pMGW2.ElementAt(num) != '0')
			{
				string text = _0023_003DzXxDWvs0pMGW2.Substring(num);
				if (4u != 0)
				{
					_0023_003DzXxDWvs0pMGW2 = text;
				}
				break;
			}
			int num2 = num + 1;
			if (2u != 0)
			{
				num = num2;
			}
		}
		return _0023_003DzXxDWvs0pMGW2;
	}

	private CoreTool _0023_003Dzr5pDEey_jV2G(string _0023_003DzOiEjdhXyi_A_0024, bool _0023_003Dzilu43q8Cm59l)
	{
		CoreTool result;
		if (5u != 0)
		{
			result = null;
		}
		List<CoreTool> list = _toolInterface.GetList();
		if (6u != 0)
		{
			XilogToolKey.KindOfOriginTool kindOfOriginTool = XilogToolKey.KindOfOriginTool.XilogBoringUnitTool;
		}
		List<CoreTool>.Enumerator enumerator = list.GetEnumerator();
		List<CoreTool>.Enumerator enumerator2;
		if (7u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				CoreTool current = enumerator2.Current;
				if (current is AggregateComponent)
				{
					continue;
				}
				XilogToolKey xilogToolKey = ToolMethods.GetXilogToolKey(current);
				if (!(xilogToolKey != null))
				{
					continue;
				}
				XilogToolKey.KindOfOriginTool kindOfOriginTool = xilogToolKey.KindOfTool;
				if (ToolInterface.CreateXilogToolNum(xilogToolKey).ToString().Equals(_0023_003DzOiEjdhXyi_A_0024))
				{
					if (kindOfOriginTool == XilogToolKey.KindOfOriginTool.XilogBoringUnitTool && _0023_003Dzilu43q8Cm59l)
					{
						result = current;
						break;
					}
					if (kindOfOriginTool == XilogToolKey.KindOfOriginTool.XilogSpindleUnitTool && !_0023_003Dzilu43q8Cm59l)
					{
						result = current;
						break;
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
		return result;
	}

	private CoreTool _0023_003DzXFnWHlj7DbiM(string _0023_003DzOiEjdhXyi_A_0024)
	{
		CoreTool result;
		if (2u != 0)
		{
			result = null;
		}
		List<CoreTool>.Enumerator enumerator = _toolInterface.GetList().GetEnumerator();
		List<CoreTool>.Enumerator enumerator2 = default(List<CoreTool>.Enumerator);
		if (0 == 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			CoreTool coreTool = default(CoreTool);
			while (enumerator2.MoveNext())
			{
				CoreTool current = enumerator2.Current;
				if (0 == 0)
				{
					coreTool = current;
				}
				if (coreTool is AggregateComponent)
				{
					XilogAggregateKey xilogAggregateKey = ToolMethods.GetXilogAggregateKey(coreTool);
					if (xilogAggregateKey != null && ToolInterface.CreateXilogToolNum(xilogAggregateKey).ToString().Equals(_0023_003DzOiEjdhXyi_A_0024))
					{
						result = coreTool;
						break;
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
		return result;
	}

	private void _0023_003DzA5qgTEkrFVSy(ref double? _0023_003DzlNZ7pvY_003D, ref string _0023_003DzdVq9VFI_003D)
	{
		if (_0023_003DzF5TXIn7g4cW5.Count == 0)
		{
			return;
		}
		XilogGSetParams xilogGSetParams = _0023_003DzF5TXIn7g4cW5.First();
		string t = xilogGSetParams.T;
		string text;
		if (4u != 0)
		{
			text = t;
		}
		double v = xilogGSetParams.V;
		double num;
		if (uint.MaxValue != 0)
		{
			num = v;
		}
		double b = xilogGSetParams.B;
		double num2;
		if (7u != 0)
		{
			num2 = b;
		}
		if (_0023_003DzdVq9VFI_003D != string.Empty && text != string.Empty && _0023_003DzdVq9VFI_003D != text && num2 == -1.0)
		{
			return;
		}
		if (num2 != -1.0 && _0023_003DzdVq9VFI_003D != string.Empty)
		{
			string _0023_003DzgKk_6RWNW19R = string.Empty;
			string _0023_003DzXxDWvs0pMGW = string.Empty;
			string _0023_003DzXmpvTagHx2Y = string.Empty;
			_0023_003DzroT_0024CHIrHrV3(_0023_003DzdVq9VFI_003D, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
			CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
			new ScmGroup.XCam.MachiningDataModel.Head().Number = ((_0023_003DzXmpvTagHx2Y == string.Empty) ? 1 : (Convert.ToInt16(_0023_003DzXmpvTagHx2Y) + 2));
			if (coreTool != null && coreTool is CuttingTool && (((coreTool as CuttingTool).ToolBody is BladeToolBody && num2 == 1.0) || (!((coreTool as CuttingTool).ToolBody is BladeToolBody) && num2 == 2.0)))
			{
				return;
			}
		}
		if (text != string.Empty)
		{
			_0023_003DzdVq9VFI_003D = text;
		}
		if (num != -1.0)
		{
			_0023_003DzlNZ7pvY_003D = num;
		}
		_0023_003DzF5TXIn7g4cW5.RemoveAt(0);
	}

	private bool _0023_003DzvlhgKpjhLkJ_00247J3Ko_Nn8x8Qz7vM()
	{
		if (_0023_003DzHD5fHZnBd7Nm != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity != null && _0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.ContainsKey(base.ActiveWorkplane.Name))
		{
			bool flag;
			if (7u != 0)
			{
				flag = false;
			}
			_0023_003DzHD5fHZnBd7Nm.PlanesWithFixedSpecularity.TryGetValue(base.ActiveWorkplane.Name, out var value);
			switch (value)
			{
			case Specularity.SpecX:
				if (5u != 0)
				{
					flag = true;
				}
				break;
			case Specularity.SpecY:
				if (2u != 0)
				{
					flag = true;
				}
				break;
			}
			if (!_0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D())
			{
				flag = !flag;
			}
			return flag;
		}
		bool flag2;
		if (true)
		{
			flag2 = false;
		}
		bool num = _0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D();
		bool flag3;
		if (8u != 0)
		{
			flag3 = num;
		}
		if (_0023_003Dzdk3_wRkuVl8n() || _0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D())
		{
			if (_0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
			{
				if (3u != 0)
				{
					flag2 = true;
				}
			}
			else if (_0023_003DzTJuyZiS0qOKz == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680) && _0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D() && base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
			{
				if (4u != 0)
				{
					flag2 = true;
				}
			}
			goto IL_0f7b;
		}
		if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
		{
			if (flag3)
			{
				string text = _0023_003DzTJuyZiS0qOKz;
				string text2;
				if (2u != 0)
				{
					text2 = text;
				}
				uint num2 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				uint num3;
				if (4u != 0)
				{
					num3 = num2;
				}
				if (num3 <= 3339451269u)
				{
					if (num3 <= 3238785555u)
					{
						if (num3 != 3222007936u)
						{
							if (num3 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
							{
								goto IL_02c8;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_02c8;
						}
					}
					else if (num3 != 3255563174u)
					{
						if (num3 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_02c8;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
					{
						goto IL_02c8;
					}
				}
				else if (num3 <= 3373006507u)
				{
					if (num3 != 3356228888u)
					{
						if (num3 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_02c8;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_02c8;
					}
				}
				else if (num3 != 3389784126u)
				{
					if (num3 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_02c8;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
				{
					goto IL_02c8;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3339451269u)
				{
					if (num3 <= 3238785555u)
					{
						if (num3 != 3222007936u)
						{
							if (num3 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
							{
								goto IL_041d;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_041d;
						}
					}
					else if (num3 != 3255563174u)
					{
						if (num3 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_041d;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
					{
						goto IL_041d;
					}
				}
				else if (num3 <= 3373006507u)
				{
					if (num3 != 3356228888u)
					{
						if (num3 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_041d;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_041d;
					}
				}
				else if (num3 != 3389784126u)
				{
					if (num3 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_041d;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
				{
					goto IL_041d;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577))
		{
			if (flag3)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3339451269u)
				{
					if (num3 <= 3289118412u)
					{
						if (num3 != 3238785555u)
						{
							if (num3 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_0595;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_0595;
						}
					}
					else if (num3 != 3322673650u)
					{
						if (num3 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_0595;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_0595;
					}
				}
				else if (num3 <= 3423339364u)
				{
					if (num3 != 3373006507u)
					{
						if (num3 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_0595;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_0595;
					}
				}
				else if (num3 != 3456894602u)
				{
					if (num3 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_0595;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_0595;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3339451269u)
				{
					if (num3 <= 3289118412u)
					{
						if (num3 != 3238785555u)
						{
							if (num3 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
							{
								goto IL_06e7;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_06e7;
						}
					}
					else if (num3 != 3322673650u)
					{
						if (num3 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
						{
							goto IL_06e7;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
					{
						goto IL_06e7;
					}
				}
				else if (num3 <= 3423339364u)
				{
					if (num3 != 3373006507u)
					{
						if (num3 == 3423339364u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
						{
							goto IL_06e7;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_06e7;
					}
				}
				else if (num3 != 3456894602u)
				{
					if (num3 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
					{
						goto IL_06e7;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
				{
					goto IL_06e7;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590))
		{
			if (flag3)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3356228888u)
				{
					if (num3 <= 3255563174u)
					{
						if (num3 != 3222007936u)
						{
							if (num3 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_085c;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_085c;
						}
					}
					else if (num3 != 3272340793u)
					{
						if (num3 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_085c;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_085c;
					}
				}
				else if (num3 <= 3406561745u)
				{
					if (num3 != 3389784126u)
					{
						if (num3 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_085c;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
					{
						goto IL_085c;
					}
				}
				else if (num3 != 3440116983u)
				{
					if (num3 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_085c;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_085c;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3356228888u)
				{
					if (num3 <= 3255563174u)
					{
						if (num3 != 3222007936u)
						{
							if (num3 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_09ab;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_09ab;
						}
					}
					else if (num3 != 3272340793u)
					{
						if (num3 == 3356228888u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
						{
							goto IL_09ab;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_09ab;
					}
				}
				else if (num3 <= 3406561745u)
				{
					if (num3 != 3389784126u)
					{
						if (num3 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
						{
							goto IL_09ab;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
					{
						goto IL_09ab;
					}
				}
				else if (num3 != 3440116983u)
				{
					if (num3 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_09ab;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
				{
					goto IL_09ab;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565))
		{
			if (flag3)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3373006507u)
				{
					if (num3 <= 3272340793u)
					{
						if (num3 != 3238785555u)
						{
							if (num3 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0b20;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_0b20;
						}
					}
					else if (num3 != 3339451269u)
					{
						if (num3 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0b20;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0b20;
					}
				}
				else if (num3 <= 3440116983u)
				{
					if (num3 != 3406561745u)
					{
						if (num3 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_0b20;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0b20;
					}
				}
				else if (num3 != 3473672221u)
				{
					if (num3 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0b20;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0b20;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3322673650u)
				{
					if (num3 <= 3255563174u)
					{
						if (num3 != 3222007936u)
						{
							if (num3 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_0c6f;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_0c6f;
						}
					}
					else if (num3 != 3289118412u)
					{
						if (num3 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_0c6f;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_0c6f;
					}
				}
				else if (num3 <= 3389784126u)
				{
					if (num3 != 3356228888u)
					{
						if (num3 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_0c6f;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_0c6f;
					}
				}
				else if (num3 != 3423339364u)
				{
					if (num3 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_0c6f;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_0c6f;
				}
			}
		}
		else if (base.ActiveWorkplane.Name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
		{
			if (flag3)
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3322673650u)
				{
					if (num3 <= 3255563174u)
					{
						if (num3 != 3222007936u)
						{
							if (num3 == 3255563174u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
							{
								goto IL_0de4;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
						{
							goto IL_0de4;
						}
					}
					else if (num3 != 3289118412u)
					{
						if (num3 == 3322673650u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
						{
							goto IL_0de4;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
					{
						goto IL_0de4;
					}
				}
				else if (num3 <= 3389784126u)
				{
					if (num3 != 3356228888u)
					{
						if (num3 == 3389784126u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
						{
							goto IL_0de4;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
					{
						goto IL_0de4;
					}
				}
				else if (num3 != 3423339364u)
				{
					if (num3 == 3456894602u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
					{
						goto IL_0de4;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_0de4;
				}
			}
			else
			{
				string text2 = _0023_003DzTJuyZiS0qOKz;
				uint num3 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
				if (num3 <= 3373006507u)
				{
					if (num3 <= 3272340793u)
					{
						if (num3 != 3238785555u)
						{
							if (num3 == 3272340793u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
							{
								goto IL_0f24;
							}
						}
						else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_0f24;
						}
					}
					else if (num3 != 3339451269u)
					{
						if (num3 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
						{
							goto IL_0f24;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_0f24;
					}
				}
				else if (num3 <= 3440116983u)
				{
					if (num3 != 3406561745u)
					{
						if (num3 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
						{
							goto IL_0f24;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_0f24;
					}
				}
				else if (num3 != 3473672221u)
				{
					if (num3 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
					{
						goto IL_0f24;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_0f24;
				}
			}
		}
		else
		{
			_ = base.ActiveWorkplane.Name;
		}
		goto IL_0f34;
		IL_0f24:
		flag2 = true;
		goto IL_0f34;
		IL_0c6f:
		flag2 = true;
		goto IL_0f34;
		IL_06e7:
		flag2 = true;
		goto IL_0f34;
		IL_0de4:
		flag2 = true;
		goto IL_0f34;
		IL_0595:
		flag2 = true;
		goto IL_0f34;
		IL_0f7b:
		return flag2;
		IL_041d:
		flag2 = true;
		goto IL_0f34;
		IL_0f34:
		if (ActiveTransformation.HasArcInversion())
		{
			flag2 = !flag2;
		}
		bool _0023_003Dz0ph406aCgMed = false;
		bool _0023_003DzlKR5uBnaRzxK = false;
		if (!_0023_003Dzpua6XFTbs4Qx(_0023_003DzTJuyZiS0qOKz, ref _0023_003Dz0ph406aCgMed, ref _0023_003DzlKR5uBnaRzxK) && ((_0023_003Dz0ph406aCgMed && !_0023_003DzlKR5uBnaRzxK) || (!_0023_003Dz0ph406aCgMed && _0023_003DzlKR5uBnaRzxK)))
		{
			flag2 = !flag2;
		}
		goto IL_0f7b;
		IL_0b20:
		flag2 = true;
		goto IL_0f34;
		IL_02c8:
		if (4u != 0)
		{
			flag2 = true;
		}
		goto IL_0f34;
		IL_09ab:
		flag2 = true;
		goto IL_0f34;
		IL_085c:
		flag2 = true;
		goto IL_0f34;
	}

	private void _0023_003Dz3XgYnhny8QnjHsTlIafUlDM_003D()
	{
		if (_0023_003DzVsFfuwI_003D.GetType() != typeof(XilogEdgeProfile))
		{
			return;
		}
		if (ActiveEROT != 0.0)
		{
			string name = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703156);
			double activeEROT = ActiveEROT;
			if (uint.MaxValue != 0)
			{
				SetAttribute(name, activeEROT);
			}
			if (4u != 0)
			{
				ActiveEROT = 0.0;
			}
		}
		if (ActiveLB != 0.0)
		{
			string name2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703143);
			double activeLB = ActiveLB;
			if (6u != 0)
			{
				SetAttribute(name2, activeLB);
			}
			ActiveLB = 0.0;
		}
		if (ActiveLAMP.HasValue)
		{
			_0023_003DzwocnWGCX9dhyfrBYoQ_003D_003D(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703089), ActiveLAMP.Value);
			ActiveLAMP = null;
		}
		if (ActiveSTOP != 0.0)
		{
			_0023_003DzwocnWGCX9dhyfrBYoQ_003D_003D(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703080), ActiveSTOP);
			ActiveSTOP = 0.0;
		}
	}

	private void _0023_003DzwocnWGCX9dhyfrBYoQ_003D_003D(string _0023_003Dz3JKs8Mw_003D, double _0023_003Dz3keKASA_003D)
	{
		int elementIndex;
		if (5u != 0)
		{
			elementIndex = 0;
		}
		if (base.ActiveGeometry == null)
		{
			return;
		}
		if (base.ActiveGeometry.IsPolyline)
		{
			Polyline obj = base.ActiveGeometry as Polyline;
			Polyline polyline;
			if (true)
			{
				polyline = obj;
			}
			int num = polyline.Count - 1;
			int val;
			if (6u != 0)
			{
				val = num;
			}
			if (polyline.Count >= 2)
			{
				val = polyline.Count - 2;
			}
			elementIndex = Math.Max(val, 0);
		}
		SetAttribute(elementIndex, _0023_003Dz3JKs8Mw_003D, _0023_003Dz3keKASA_003D);
	}

	private object _0023_003Dzjg5H3u8_003D(SubProgramParameter _0023_003Dz3fz9vcg_003D, double? _0023_003Dz3keKASA_003D)
	{
		if (_0023_003Dz3keKASA_003D.HasValue)
		{
			return _0023_003Dz3keKASA_003D.Value;
		}
		return null;
	}

	private object _0023_003Dzjg5H3u8_003D(SubProgramParameter _0023_003Dz3fz9vcg_003D, string _0023_003Dz3keKASA_003D)
	{
		_ = 4;
		if (5 == 0)
		{
		}
		return _0023_003Dz3keKASA_003D;
	}

	private void _0023_003DzsVv55tTke5wMx51iqw_003D_003D(string _0023_003DzdVq9VFI_003D, ref string _0023_003DzHMoneas_003D, ref string _0023_003DzOiEjdhXyi_A_0024, ref string _0023_003Dz5dh86BrVaX8U, out CoreTool _0023_003DzyagUmhsbHglp, out ScmGroup.XCam.MachiningDataModel.Head _0023_003Dz9ybYj_0024UhnI6V)
	{
		if (6u != 0)
		{
			_0023_003DzroT_0024CHIrHrV3(_0023_003DzdVq9VFI_003D, ref _0023_003DzHMoneas_003D, ref _0023_003DzOiEjdhXyi_A_0024, ref _0023_003Dz5dh86BrVaX8U);
		}
		int number;
		if (true)
		{
			number = 1;
		}
		if (StringUtility.IsValid(_0023_003Dz5dh86BrVaX8U))
		{
			int num = Convert.ToInt32(_0023_003Dz5dh86BrVaX8U);
			if (3u != 0)
			{
				number = num;
			}
			number = ((number == 0) ? 1 : (number + 2));
		}
		_0023_003DzyagUmhsbHglp = _0023_003Dzr5pDEey_jV2G(_0023_003DzOiEjdhXyi_A_0024, _0023_003Dzilu43q8Cm59l(_0023_003DzHMoneas_003D));
		_0023_003Dz9ybYj_0024UhnI6V = new ScmGroup.XCam.MachiningDataModel.Head();
		_0023_003Dz9ybYj_0024UhnI6V.Number = number;
	}

	private void _0023_003Dzf4KWv5G2dTxk()
	{
		if (_0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D())
		{
			if (!_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247)) && !_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978)) && !_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018)) && !_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970)))
			{
				string errorString = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713100), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713066), _0023_003DzTJuyZiS0qOKz, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713056));
				if (true)
				{
					_errorString = errorString;
				}
				string errorString2 = _errorString;
				if (0 == 0)
				{
					AddToErrorFile(errorString2);
				}
			}
		}
		else if (!_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026)) && !_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146)) && !_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247)) && !_0023_003DzTJuyZiS0qOKz.Equals(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239)))
		{
			string errorString3 = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713100), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713042), _0023_003DzTJuyZiS0qOKz, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713032));
			if (7u != 0)
			{
				_errorString = errorString3;
			}
			AddToErrorFile(_errorString);
		}
	}

	private SpindleCollection _0023_003DznGH5e16bcgiZCbKP0A_003D_003D(int _0023_003DzOiEjdhXyi_A_0024)
	{
		_0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D _0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D = new _0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D();
		_0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D _0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D2;
		if (true)
		{
			_0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D2 = _0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D;
		}
		if (5u != 0)
		{
			_0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D2._0023_003DzOiEjdhXyi_A_0024 = _0023_003DzOiEjdhXyi_A_0024;
		}
		List<SpindleCollection>.Enumerator enumerator = _configurationInterface.GetList<SpindleCollection>().GetEnumerator();
		List<SpindleCollection>.Enumerator enumerator2;
		if (5u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				MachineElementBase current = enumerator2.Current;
				if (current.ChildElements.Find(_0023_003DzQPM6WXKQvcG86KhkVfk2GLI_003D2._0023_003DzSRJxXmqRyStoJ4bCTfgaYYzGd345) != null)
				{
					return current as SpindleCollection;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
		return null;
	}

	private List<PosId> _0023_003DzSHfpqA8_IBKRJkPqqzh_N2MLlPHQ(SpindleCollection _0023_003DzjinMgsG4sSXjlPr3dA_003D_003D, int _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D, double _0023_003Dzzc8h9h0_003D)
	{
		_0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D _0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D = new _0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D();
		_0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D _0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D2;
		if (4u != 0)
		{
			_0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D2 = _0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D;
		}
		if (2u != 0)
		{
			_0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D2._0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D = _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D;
		}
		List<PosId> list = new List<PosId>();
		List<PosId> list2;
		if (6u != 0)
		{
			list2 = list;
		}
		PosId _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D = default(PosId);
		Spindle spindle = _0023_003DzjinMgsG4sSXjlPr3dA_003D_003D.ChildElements.Find(_0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D2._0023_003DzOiiHB7QpdGEbeEso98yYwwaCgvbtjNyHxw_003D_003D) as Spindle;
		PosId _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D = default(PosId);
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.x = spindle.OffsetX;
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.y = spindle.OffsetY;
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.z = spindle.OffsetZ;
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.id = spindle.SpindleNumber;
		foreach (MachineElementBase childElement in _0023_003DzjinMgsG4sSXjlPr3dA_003D_003D.ChildElements)
		{
			if ((childElement as Spindle).SpindleNumber != _0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D2._0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D)
			{
				_0023_003DzYXWmmUiW5injJ1DkTut5FMI_003D(_0023_003DzCrxxQrfOGP1Spmn7yAYWhuE_003D2._0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D, _0023_003Dzzc8h9h0_003D, ref _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D, ref _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D, childElement);
				_0023_003DzEDHlfzY9NhQevXsigkgZHH9cIkxTQv9y8BGj70o_003D(childElement as Spindle, ref _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D);
				list2.Add(_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D);
			}
		}
		return list2;
	}

	private void _0023_003DzYXWmmUiW5injJ1DkTut5FMI_003D(int _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D, double _0023_003Dzzc8h9h0_003D, ref PosId _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D, ref PosId _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D, MachineElementBase _0023_003DzBj__0024aOE_003D)
	{
		if (_0023_003Dzzc8h9h0_003D != 0.0)
		{
			double _0023_003DzSkIaGjk_003D;
			if (uint.MaxValue != 0)
			{
				_0023_003DzSkIaGjk_003D = 0.0;
			}
			double num;
			double num2;
			double num4;
			if (_0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D == 1)
			{
				double offsetX = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetX;
				if (uint.MaxValue != 0)
				{
					num = offsetX;
				}
				double offsetY = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetY;
				if (3u != 0)
				{
					num2 = offsetY;
				}
				double num3 = sqrt(Math.Pow(num, 2.0) + Math.Pow(num2, 2.0));
				if (2u != 0)
				{
					num4 = num3;
				}
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.z = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetZ;
			}
			else
			{
				num = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetX - _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.x;
				num2 = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetY - _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.y;
				num4 = sqrt(Math.Pow(num, 2.0) + Math.Pow(num2, 2.0));
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.z = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetZ - _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.z;
			}
			_0023_003DzNySSJILlsDMUXH9SrA_003D_003D(num, num2, ref _0023_003DzSkIaGjk_003D);
			double num5 = MathUtility.ConvertToRadians(_0023_003Dzzc8h9h0_003D + _0023_003DzSkIaGjk_003D);
			double x = num4 * Math.Cos(num5);
			double y = num4 * Math.Sin(num5);
			_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = x;
			_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = y;
			_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.id = (_0023_003DzBj__0024aOE_003D as Spindle).SpindleNumber;
		}
		else
		{
			if (_0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D == 1)
			{
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetX;
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetY;
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.z = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetZ;
			}
			else
			{
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetX - _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.x;
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetY - _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.y;
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.z = (_0023_003DzBj__0024aOE_003D as Spindle).OffsetZ - _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.z;
			}
			_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.id = (_0023_003DzBj__0024aOE_003D as Spindle).SpindleNumber;
		}
	}

	private void _0023_003DzNySSJILlsDMUXH9SrA_003D_003D(double _0023_003DzAHe1VGYmHENL, double _0023_003DzBzahZlz8g8vy, ref double _0023_003DzSkIaGjk_003D)
	{
		_ = 7;
		if (5 == 0)
		{
		}
		if (_0023_003DzAHe1VGYmHENL == 0.0)
		{
			_ = 4;
			if (5 == 0)
			{
			}
			if (_0023_003DzBzahZlz8g8vy > 0.0)
			{
				_ = 7;
				if (3 == 0)
				{
				}
				_0023_003DzSkIaGjk_003D = 90.0;
				return;
			}
		}
		if (_0023_003DzAHe1VGYmHENL == 0.0 && _0023_003DzBzahZlz8g8vy < 0.0)
		{
			_0023_003DzSkIaGjk_003D = 270.0;
			return;
		}
		_0023_003DzSkIaGjk_003D = Math.Atan(_0023_003DzBzahZlz8g8vy / _0023_003DzAHe1VGYmHENL);
		_0023_003DzSkIaGjk_003D = MathUtility.ConvertToDegree(_0023_003DzSkIaGjk_003D);
	}

	private void _0023_003DzEDHlfzY9NhQevXsigkgZHH9cIkxTQv9y8BGj70o_003D(Spindle _0023_003DzDvBs8qelz2Xb, ref PosId _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D)
	{
		string text = _0023_003DzQJ_daGfBEhoPFztPl6IFHZLu7_0024YR_00244aFFhIbHI0_003D(_0023_003DzDvBs8qelz2Xb);
		string text2 = default(string);
		if (0 == 0)
		{
			text2 = text;
		}
		if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611))
		{
			return;
		}
		string name = default(string);
		if (!(text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577)))
		{
			if (!(text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590)))
			{
				if (!(text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565)))
				{
					if (!(text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553)))
					{
						return;
					}
					name = base.ActiveWorkplane.Name;
					if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577)))
					{
						if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590)))
						{
							if (name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565))
							{
								_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x;
							}
						}
						else
						{
							_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x;
							_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = 0.0;
						}
					}
					else
					{
						_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x;
						_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = 0.0;
					}
					return;
				}
				name = base.ActiveWorkplane.Name;
				if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577)))
				{
					if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590)))
					{
						if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565)) && name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
						{
							_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x;
						}
					}
					else
					{
						_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x;
						_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = 0.0;
					}
				}
				else
				{
					_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x;
					_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = 0.0;
				}
				return;
			}
			name = base.ActiveWorkplane.Name;
			if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577)))
			{
				if (name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590))
				{
					return;
				}
				if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565)))
				{
					if (name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
					{
						_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y;
						_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = 0.0;
					}
				}
				else
				{
					_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y;
					_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = 0.0;
				}
			}
			else
			{
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y;
			}
			return;
		}
		string name2 = base.ActiveWorkplane.Name;
		if (0 == 0)
		{
			name = name2;
		}
		if (name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577))
		{
			return;
		}
		if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590)))
		{
			if (!(name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565)))
			{
				if (name == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553))
				{
					double x = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y;
					if (5u != 0)
					{
						_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = x;
					}
					_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = 0.0;
				}
			}
			else
			{
				double y = _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y;
				if (5u != 0)
				{
					_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.x = y;
				}
				if (uint.MaxValue != 0)
				{
					_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = 0.0;
				}
			}
		}
		else
		{
			double y2 = 0.0 - _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y;
			if (4u != 0)
			{
				_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D.y = y2;
			}
		}
	}

	private string _0023_003DzQJ_daGfBEhoPFztPl6IFHZLu7_0024YR_00244aFFhIbHI0_003D(Spindle _0023_003DzDvBs8qelz2Xb)
	{
		string text = _0023_003DzDfV1Q2OnV_0024RM[1];
		string result;
		if (3u != 0)
		{
			result = text;
		}
		if (_0023_003DzDvBs8qelz2Xb.AngleA != 0.0)
		{
			int num = (int)_0023_003DzDvBs8qelz2Xb.OffsetR;
			int num2;
			if (2u != 0)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 0:
			{
				string text2 = _0023_003DzDfV1Q2OnV_0024RM[3];
				if (3u != 0)
				{
					result = text2;
				}
				break;
			}
			case 90:
				result = _0023_003DzDfV1Q2OnV_0024RM[4];
				break;
			case 180:
				result = _0023_003DzDfV1Q2OnV_0024RM[2];
				break;
			case 270:
				result = _0023_003DzDfV1Q2OnV_0024RM[5];
				break;
			}
		}
		return result;
	}

	private List<PosId> _0023_003DzNd0GmcgjUGZrti7C8DYZ39RGMzqt(string _0023_003DzdVq9VFI_003D, int _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D, double _0023_003Dzzc8h9h0_003D)
	{
		_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D = new _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D();
		_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D2 = default(_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D);
		if (0 == 0)
		{
			_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D2 = _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D;
		}
		_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D3 = _0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D2;
		if (2u != 0)
		{
			_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D3._0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D = _0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D;
		}
		List<PosId> list = new List<PosId>();
		List<PosId> list2;
		if (7u != 0)
		{
			list2 = list;
		}
		PosId _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D = default(PosId);
		string[] array = _0023_003DzdVq9VFI_003D.Substring(_0023_003DzdVq9VFI_003D.IndexOf(' ') + 1).Split(' ');
		int num = (_0023_003Dzmkh2mynWK8RD ? 3 : 2);
		List<Spindle> list3 = _configurationInterface.GetList<Spindle>();
		Spindle spindle = list3.Find(_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D2._0023_003DzA2pYLsxo736N_0024Ma_0024yL4Gn1u0LYLmbqZldP7n4Ec_003D);
		PosId _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D = default(PosId);
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.x = spindle.OffsetX;
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.y = spindle.OffsetY;
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.z = spindle.OffsetZ;
		_0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D.id = spindle.SpindleNumber;
		for (int i = 0; i < array.Count(); i++)
		{
			_0023_003DzSVnn8GyiD5JOlVYW2hj0kiA_003D CS_0024_003C_003E8__locals4 = new _0023_003DzSVnn8GyiD5JOlVYW2hj0kiA_003D();
			CS_0024_003C_003E8__locals4._0023_003DzXxDWvs0pMGW2 = array[i].Substring(array[i].Length - num);
			CS_0024_003C_003E8__locals4._0023_003DzXxDWvs0pMGW2 = _0023_003DzKyFzC29DdXWF8NbHXg_003D_003D(CS_0024_003C_003E8__locals4._0023_003DzXxDWvs0pMGW2);
			array[i].Substring(0, array[i].Length - num);
			Spindle spindle2 = list3.Find(delegate(Spindle _0023_003DzBj__0024aOE_003D)
			{
				_ = 0;
				if (3 == 0)
				{
				}
				int spindleNumber = _0023_003DzBj__0024aOE_003D.SpindleNumber;
				_ = 4;
				if (3 == 0)
				{
				}
				return spindleNumber == short.Parse(CS_0024_003C_003E8__locals4._0023_003DzXxDWvs0pMGW2);
			});
			_0023_003DzYXWmmUiW5injJ1DkTut5FMI_003D(_0023_003Dzqpd_eZ0ZKkVaQudojCLiO78_003D2._0023_003Dzfo3pL8SzhsXYO1aJGw_003D_003D, _0023_003Dzzc8h9h0_003D, ref _0023_003DzBRw0a4PMl0v65_0024Sk3RkpwfI_003D, ref _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D, spindle2);
			_0023_003DzEDHlfzY9NhQevXsigkgZHH9cIkxTQv9y8BGj70o_003D(spindle2, ref _0023_003Dzrpi0prAY24jsJyu5eyifz24_003D);
			list2.Add(_0023_003Dzrpi0prAY24jsJyu5eyifz24_003D);
		}
		return list2;
	}

	private void _0023_003DzjjquhpLP5JaMmJNBnQ_003D_003D(int _0023_003DzGBSDkMk_003D, double _0023_003Dzq41ODsg_003D, double _0023_003DzGOzW0bI_003D, double _0023_003DzuhVVJoM_003D, double _0023_003DzSV9c5lY_003D, double _0023_003Dzi_Ktauk_003D, double _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D, string _0023_003DzrziU4i4_003D, TypeOfProcess _0023_003DzergJzGc_003D, string _0023_003DzqmiDBVY_003D, string _0023_003DzYEQjc18_003D, int _0023_003Dzr8iEI4WGW67nxtwbTA_003D_003D, double _0023_003DzVHemytquQzbF, double _0023_003Dz_cGaxh6Tx5JXRX9EAw_003D_003D)
	{
		double x = default(double);
		if (0 == 0)
		{
			x = double.MinValue;
		}
		double y;
		if (5u != 0)
		{
			y = double.MinValue;
		}
		Pattern pattern = new Pattern();
		Pattern pattern2;
		if (6u != 0)
		{
			pattern2 = pattern;
		}
		switch (_0023_003DzGBSDkMk_003D)
		{
		case 1:
		{
			double num2 = _0023_003DzOiU6nPw_003D - _0023_003Dzq41ODsg_003D;
			if (7u != 0)
			{
				x = num2;
			}
			if (6u != 0)
			{
				y = _0023_003DzGOzW0bI_003D;
			}
			if (base.ActivePattern == null)
			{
				break;
			}
			if (base.ActivePattern.NumberOfRows == 1 && base.ActivePattern.NumberOfColumns == 1)
			{
				Pattern activePattern = base.ActivePattern;
				if (4u != 0)
				{
					pattern2 = activePattern;
				}
				break;
			}
			if (base.ActivePattern.NumberOfRows > 1 && base.ActivePattern.RotationAngle == 0.0)
			{
				Pattern activePattern2 = base.ActivePattern;
				if (6u != 0)
				{
					pattern2 = activePattern2;
				}
			}
			if (base.ActivePattern.NumberOfRows > 1 && base.ActivePattern.RotationAngle != 0.0)
			{
				Pattern activePattern3 = base.ActivePattern;
				if (4u != 0)
				{
					pattern2 = activePattern3;
				}
				Workplane activeWorkplane = base.ActiveWorkplane;
				if (8u != 0)
				{
					_0023_003Dzs4ADLWfern63s2JShVBkhiE_003D(ref _0023_003DzSV9c5lY_003D, ref _0023_003Dzi_Ktauk_003D, activeWorkplane);
				}
				double num3 = 0.0 - _0023_003DzSV9c5lY_003D;
				if (2u != 0)
				{
					_0023_003DzSV9c5lY_003D = num3;
				}
				double rotationAngle2 = Math.Atan(_0023_003Dzi_Ktauk_003D / _0023_003DzSV9c5lY_003D) / (Math.PI / 180.0) + 270.0;
				double num4 = SQRT(pow(_0023_003DzSV9c5lY_003D, 2.0) + pow(_0023_003Dzi_Ktauk_003D, 2.0));
				num4 = ((_0023_003DzSV9c5lY_003D < 0.0) ? (0.0 - num4) : num4);
				pattern2.RotationAngle = rotationAngle2;
				pattern2._0023_003Dzmko6ItfWFPAr(num4);
			}
			if (base.ActivePattern.NumberOfRows == 1)
			{
				pattern2 = base.ActivePattern;
				pattern2._0023_003Dz52wj2gZUt_0024_y(0.0 - base.ActivePattern.ColumnDistance);
			}
			break;
		}
		case 2:
			x = _0023_003Dzq41ODsg_003D;
			y = _0023_003DzUUAAhCE_003D - _0023_003DzGOzW0bI_003D;
			if (base.ActivePattern == null)
			{
				break;
			}
			if (base.ActivePattern.NumberOfRows == 1 && base.ActivePattern.NumberOfColumns == 1)
			{
				pattern2 = base.ActivePattern;
				break;
			}
			if (base.ActivePattern.NumberOfRows > 1 && base.ActivePattern.RotationAngle == 0.0)
			{
				pattern2 = base.ActivePattern;
				pattern2._0023_003Dz52wj2gZUt_0024_y(0.0 - base.ActivePattern.ColumnDistance);
			}
			if (base.ActivePattern.NumberOfRows > 1 && base.ActivePattern.RotationAngle != 0.0)
			{
				pattern2 = base.ActivePattern;
				_0023_003Dzs4ADLWfern63s2JShVBkhiE_003D(ref _0023_003DzSV9c5lY_003D, ref _0023_003Dzi_Ktauk_003D, base.ActiveWorkplane);
				_0023_003Dzi_Ktauk_003D = 0.0 - _0023_003Dzi_Ktauk_003D;
				double rotationAngle = Math.Atan(_0023_003Dzi_Ktauk_003D / _0023_003DzSV9c5lY_003D) / (Math.PI / 180.0) + 270.0;
				double num = SQRT(pow(_0023_003DzSV9c5lY_003D, 2.0) + pow(_0023_003Dzi_Ktauk_003D, 2.0));
				num = ((_0023_003DzSV9c5lY_003D < 0.0) ? (0.0 - num) : num);
				pattern2.RotationAngle = rotationAngle;
				pattern2._0023_003Dzmko6ItfWFPAr(num);
			}
			if (base.ActivePattern.NumberOfRows == 1)
			{
				pattern2 = base.ActivePattern;
			}
			break;
		case 3:
			x = _0023_003DzOiU6nPw_003D - _0023_003Dzq41ODsg_003D;
			y = _0023_003DzUUAAhCE_003D - _0023_003DzGOzW0bI_003D;
			if (base.ActivePattern == null)
			{
				break;
			}
			if (base.ActivePattern.NumberOfRows == 1 && base.ActivePattern.NumberOfColumns == 1)
			{
				pattern2 = base.ActivePattern;
				break;
			}
			if (base.ActivePattern.NumberOfRows > 1 && base.ActivePattern.RotationAngle == 0.0)
			{
				pattern2 = base.ActivePattern;
				pattern2._0023_003Dzmko6ItfWFPAr(0.0 - base.ActivePattern.RowDistance);
			}
			if (base.ActivePattern.NumberOfRows > 1 && base.ActivePattern.RotationAngle != 0.0)
			{
				pattern2 = base.ActivePattern;
				pattern2.RotationAngle = base.ActivePattern.RotationAngle + 180.0;
			}
			if (base.ActivePattern.NumberOfRows == 1)
			{
				pattern2 = base.ActivePattern;
				pattern2._0023_003Dz52wj2gZUt_0024_y(0.0 - base.ActivePattern.ColumnDistance);
			}
			break;
		}
		CreatePattern(pattern2.NumberOfRows, pattern2.NumberOfColumns, pattern2.RowDistance, pattern2.ColumnDistance, pattern2.RotationAngle, pattern2.RowLayoutAngle);
		string uniqueName = _projectInterface.GetUniqueName<MachiningWorkingStep>(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705887), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
		CreateDrill(uniqueName, x, y, _0023_003DzuhVVJoM_003D, _0023_003DziDS5zxipeTeJ78d4Ag_003D_003D, string.Empty, TypeOfProcess.Drilling, _0023_003DzqmiDBVY_003D, _0023_003DzYEQjc18_003D, _0023_003Dzr8iEI4WGW67nxtwbTA_003D_003D, _0023_003DzVHemytquQzbF, _0023_003Dz_cGaxh6Tx5JXRX9EAw_003D_003D, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
	}

	private bool _0023_003DzOq7VhIzeDL2_0024NM_0024F7jqR_3c_003D(double? _0023_003DzjJTnmOc_003D, bool _0023_003DzJWP5xwk_003D)
	{
		bool flag;
		if (2u != 0)
		{
			flag = false;
		}
		if ((!ActiveTransformation.HasMirrorX() || ActiveTransformation.HasMirrorY()) && (ActiveTransformation.HasMirrorX() || !ActiveTransformation.HasMirrorY()))
		{
			flag = (_0023_003DzJWP5xwk_003D ? (_0023_003DzjJTnmOc_003D.Value > 0.0) : (!(_0023_003DzjJTnmOc_003D.Value > 0.0)));
		}
		else if (_0023_003DzjJTnmOc_003D.Value > 0.0)
		{
			if (3u != 0)
			{
				flag = false;
			}
		}
		else if (2u != 0)
		{
			flag = true;
		}
		if (ActiveTransformation.HasArcInversion())
		{
			flag = !flag;
		}
		return flag;
	}

	private void _0023_003DzrqKeWwSMDDDBHGeoig_003D_003D(bool _0023_003DzaxlMF4ZHowAp_0024qQJAOdcLAg_003D, ref double _0023_003Dzr9mC8No_003D, ref TypeOfToolApproach _0023_003DzXlrGaU97yiX0F27zSA_003D_003D)
	{
		string text = _0023_003DzaepqoE8sVHIF;
		KindOfToolFamily kindOfToolFamily;
		if (5u != 0)
		{
			kindOfToolFamily = KindOfToolFamily.BladeCuttingTool;
		}
		bool num = text == kindOfToolFamily.ToString();
		string text2 = _0023_003DzaepqoE8sVHIF;
		if (uint.MaxValue != 0)
		{
			kindOfToolFamily = KindOfToolFamily.MillingCuttingTool;
		}
		bool num2 = text2 == kindOfToolFamily.ToString();
		bool flag;
		if (6u != 0)
		{
			flag = num2;
		}
		bool flag2;
		if (2u != 0)
		{
			flag2 = false;
		}
		GeomCompositeCurve geometry = _0023_003DzVsFfuwI_003D.GeometryPath.Geometry;
		if (geometry != null && geometry.Elements.Count == 1 && geometry.Elements[0].IsSegment)
		{
			flag2 = true;
		}
		if ((num || (flag && flag2 && !_0023_003DzaxlMF4ZHowAp_0024qQJAOdcLAg_003D)) && !_0023_003Dzs_0024fkdj9J4JIpVP6r67204e0_003D())
		{
			_0023_003Dzr9mC8No_003D += 90.0;
		}
		if (!(_0023_003Dzr9mC8No_003D > 0.0) || !(_0023_003Dzr9mC8No_003D < 180.0))
		{
			long result = 0L;
			Math.DivRem((long)_0023_003Dzr9mC8No_003D, 360L, out result);
			if (result >= 180 && result <= 360)
			{
				_0023_003Dzr9mC8No_003D = Math.Abs(360 - result);
				_0023_003DzLmK3kzBA8VNrphs8A4W1lqs_003D(ref _0023_003DzXlrGaU97yiX0F27zSA_003D_003D);
			}
			else if (result >= -180 && result <= 0)
			{
				_0023_003Dzr9mC8No_003D = Math.Abs(result);
				_0023_003DzLmK3kzBA8VNrphs8A4W1lqs_003D(ref _0023_003DzXlrGaU97yiX0F27zSA_003D_003D);
			}
			else if (result > 0 && result < 180)
			{
				_0023_003Dzr9mC8No_003D = Math.Abs(result);
			}
			else if (result > -360 && result < -180)
			{
				_0023_003Dzr9mC8No_003D = Math.Abs(360 - result);
				_0023_003Dzr9mC8No_003D = Math.Abs(result);
			}
		}
	}

	private bool _0023_003Dzs_0024fkdj9J4JIpVP6r67204e0_003D()
	{
		bool result;
		if (3u != 0)
		{
			result = false;
		}
		WorkingArea workingArea = _configurationInterface.GetWorkingArea(_0023_003DzTJuyZiS0qOKz);
		WorkingArea workingArea2;
		if (5u != 0)
		{
			workingArea2 = workingArea;
		}
		bool num = _0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D();
		bool flag;
		if (2u != 0)
		{
			flag = num;
		}
		if (workingArea2 != null)
		{
			Specularity specularity = workingArea2.Specularity;
			Specularity specularity2;
			if (uint.MaxValue != 0)
			{
				specularity2 = specularity;
			}
			if (specularity2 == Specularity.SpecX || specularity2 == Specularity.SpecY)
			{
				if (0 == 0)
				{
					result = true;
				}
			}
		}
		else if (flag)
		{
			string text = _0023_003DzTJuyZiS0qOKz;
			string text2 = default(string);
			if (0 == 0)
			{
				text2 = text;
			}
			uint num2 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
			if (num2 <= 3339451269u)
			{
				if (num2 <= 3238785555u)
				{
					if (num2 != 3222007936u)
					{
						if (num2 == 3238785555u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715170))
						{
							goto IL_01bb;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715026))
					{
						goto IL_01bb;
					}
				}
				else if (num2 != 3255563174u)
				{
					if (num2 == 3339451269u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703680))
					{
						goto IL_01bb;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715146))
				{
					goto IL_01bb;
				}
			}
			else if (num2 <= 3373006507u)
			{
				if (num2 != 3356228888u)
				{
					if (num2 == 3373006507u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440))
					{
						goto IL_01bb;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713247))
				{
					goto IL_01bb;
				}
			}
			else if (num2 != 3389784126u)
			{
				if (num2 == 3473672221u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715010))
				{
					goto IL_01bb;
				}
			}
			else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713239))
			{
				goto IL_01bb;
			}
		}
		else
		{
			string text2 = _0023_003DzTJuyZiS0qOKz;
			uint num2 = _0023_003DzAV5_546dwDKSkEReJg_003D_003D._0023_003DzG47xjVPC2nNM(text2);
			if (num2 <= 3406561745u)
			{
				if (num2 <= 3289118412u)
				{
					if (num2 != 3272340793u)
					{
						if (num2 == 3289118412u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247))
						{
							goto IL_02f8;
						}
					}
					else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714986))
					{
						goto IL_02f8;
					}
				}
				else if (num2 != 3322673650u)
				{
					if (num2 == 3406561745u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917713231))
					{
						goto IL_02f8;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714978))
				{
					goto IL_02f8;
				}
			}
			else if (num2 <= 3440116983u)
			{
				if (num2 != 3423339364u)
				{
					if (num2 == 3440116983u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715034))
					{
						goto IL_02f8;
					}
				}
				else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917715018))
				{
					goto IL_02f8;
				}
			}
			else if (num2 != 3456894602u)
			{
				if (num2 == 3574337935u && text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448))
				{
					goto IL_02f8;
				}
			}
			else if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917714970))
			{
				goto IL_02f8;
			}
		}
		goto IL_02fa;
		IL_01bb:
		result = true;
		goto IL_02fa;
		IL_02f8:
		result = true;
		goto IL_02fa;
		IL_02fa:
		return result;
	}

	private void _0023_003DzLmK3kzBA8VNrphs8A4W1lqs_003D(ref TypeOfToolApproach _0023_003DzXlrGaU97yiX0F27zSA_003D_003D)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		if (_0023_003DzXlrGaU97yiX0F27zSA_003D_003D == TypeOfToolApproach.NormalRight)
		{
			_ = -1;
			if (2 == 0)
			{
			}
			_0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.NormalLeft;
			return;
		}
		_ = 1;
		if (false)
		{
		}
		if (_0023_003DzXlrGaU97yiX0F27zSA_003D_003D == TypeOfToolApproach.NormalLeft)
		{
			_0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.NormalRight;
		}
	}

	private void _0023_003DzXkaAIAHIaFaq0g95fA_003D_003D(double? _0023_003DzBUoVm7k_003D, ref double _0023_003Dzr9mC8No_003D, ref TypeOfToolApproach _0023_003DzXlrGaU97yiX0F27zSA_003D_003D)
	{
		int num = (_0023_003DzBUoVm7k_003D.HasValue ? ((int)_0023_003DzBUoVm7k_003D.Value) : 0);
		int num2;
		if (5u != 0)
		{
			num2 = num;
		}
		int num3 = (_0023_003DzmNgNJnU_003D._0023_003DzOEZCHp5k1HAX324qKw_003D_003D() ? num2 : _0023_003DzxXT2UQmk5Oq2bZ130DmCH0g_003D(num2));
		if (true)
		{
			num2 = num3;
		}
		switch (num2)
		{
		case 0:
			_0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.ParallelXPositive;
			break;
		case 1:
			_0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.NormalRight;
			break;
		case 2:
			_0023_003Dzr9mC8No_003D -= 90.0;
			_0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.NormalLeft;
			break;
		case 3:
			_0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.ParallelStartPoint;
			break;
		case 4:
			_0023_003DzXlrGaU97yiX0F27zSA_003D_003D = TypeOfToolApproach.ParallelCurrentPoint;
			break;
		}
	}

	private void _0023_003DzpKAjugZnGow0ycyMGw_003D_003D(double _0023_003DznoITTL0_003D, double _0023_003DzdDR8uno_003D, double _0023_003DzWwysZ9DTrT_5, double _0023_003DzJq4XZvuwXWXF, ref double _0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D, ref double _0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		gp_Pnt2d val = new gp_Pnt2d(_0023_003DznoITTL0_003D, _0023_003DzdDR8uno_003D);
		gp_Pnt2d val2;
		if (3u != 0)
		{
			val2 = val;
		}
		gp_Pnt2d val3 = new gp_Pnt2d(_0023_003DzWwysZ9DTrT_5, _0023_003DzJq4XZvuwXWXF);
		gp_Pnt2d val4;
		if (3u != 0)
		{
			val4 = val3;
		}
		gp_Vec2d val5 = new gp_Vec2d(val2, val4);
		gp_Vec2d val6;
		if (7u != 0)
		{
			val6 = val5;
		}
		val6.Multiply(2.0);
		val2.Translate(val6);
		_0023_003Dz_0024O7FJMm9KZmliCz7Xg_003D_003D = val2.X();
		_0023_003DzHr_0024tVns7wzrAg4NQ6Q_003D_003D = val2.Y();
	}

	private void _0023_003DzvQuSaNXlxisu(double _0023_003Dzkc3hMRhb09c2, double _0023_003Dzl_0024La4CJMMub_0024, double _0023_003Dzd2fmRpRSblrt, double _0023_003DzsG0HxUOziEWt)
	{
		string _0023_003DzgKk_6RWNW19R;
		if (uint.MaxValue != 0)
		{
			_0023_003DzgKk_6RWNW19R = null;
		}
		string _0023_003DzXxDWvs0pMGW;
		if (8u != 0)
		{
			_0023_003DzXxDWvs0pMGW = null;
		}
		string _0023_003DzXmpvTagHx2Y;
		if (2u != 0)
		{
			_0023_003DzXmpvTagHx2Y = null;
		}
		_0023_003DzroT_0024CHIrHrV3(_0023_003DzVsFfuwI_003D.Tool, ref _0023_003DzgKk_6RWNW19R, ref _0023_003DzXxDWvs0pMGW, ref _0023_003DzXmpvTagHx2Y);
		CoreTool coreTool = _0023_003Dzr5pDEey_jV2G(_0023_003DzXxDWvs0pMGW, _0023_003Dzilu43q8Cm59l(_0023_003DzgKk_6RWNW19R));
		if (coreTool != null && coreTool is CuttingTool)
		{
			CuttingTool cuttingTool = coreTool as CuttingTool;
			int num = 0;
			double num2 = 0.0;
			double num3 = 0.0;
			num3 = _0023_003DzsG0HxUOziEWt + cuttingTool.OverallAssemblyDiameter;
			num2 = _0023_003Dzl_0024La4CJMMub_0024 - cuttingTool.OverallAssemblyDiameter;
			num = ((!(_0023_003Dzkc3hMRhb09c2 < num2)) ? ((int)((_0023_003Dzkc3hMRhb09c2 - num2) / (num3 + num2) + 1.0)) : 0);
			num2 = (_0023_003Dzkc3hMRhb09c2 - num3 * (double)num) / (double)(num + 1);
			double num4 = 0.0;
			num4 = (0.0 - num3 / 2.0) / _0023_003Dzkc3hMRhb09c2;
			for (int num5 = num; num5 > 0; num5--)
			{
				num4 += (num3 + num2) / _0023_003Dzkc3hMRhb09c2;
				SetParametricAttribute2(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703099), _0023_003Dzd2fmRpRSblrt, _0023_003DzsG0HxUOziEWt, num4);
			}
		}
	}

	private void _0023_003DzBzxGAl03YF3F(double? _0023_003DzNoS39BiIauuZ)
	{
		if (_0023_003DzNoS39BiIauuZ.HasValue)
		{
			double activeSpeed = base.ActiveSpeed;
			double num;
			if (7u != 0)
			{
				num = activeSpeed;
			}
			_0023_003DzNoS39BiIauuZ = _0023_003Dz6s5uDh6_0024tbw_0024(_0023_003DzNoS39BiIauuZ.Value);
			double _0023_003Dz3keKASA_003D = _0023_003DzNoS39BiIauuZ.Value;
			if (true)
			{
				_0023_003DzZGra6ZgrZzgF(_0023_003Dz3keKASA_003D);
			}
			int count = _0023_003DzVsFfuwI_003D.GeometryPath.Count;
			int num2;
			if (7u != 0)
			{
				num2 = count;
			}
			if (num2 == 1)
			{
				_0023_003DzVsFfuwI_003D.Feed = base.ActiveSpeed;
			}
			else if (num2 > 1 && num != base.ActiveSpeed)
			{
				SetParametricAttribute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702931), base.ActiveSpeed, 0.0);
			}
		}
	}

	private double _0023_003Dz1ZkGY__0024q7UnYekYtmg_003D_003D(CoreTool _0023_003DzMgH6lrZKngR3)
	{
		double result;
		if (7u != 0)
		{
			result = 0.0;
		}
		KindOfToolType kindOfToolType = _toolInterface.GetToolType(_0023_003DzMgH6lrZKngR3.Key).KindOfToolType;
		KindOfToolType kindOfToolType2;
		if (7u != 0)
		{
			kindOfToolType2 = kindOfToolType;
		}
		switch (kindOfToolType2)
		{
		case KindOfToolType.CountersinkConicalDrill:
		{
			double countersinkSinkingLength = ((_0023_003DzMgH6lrZKngR3 as CuttingTool).ToolBody as CountersinkConicalDrill).CountersinkSinkingLength;
			if (uint.MaxValue != 0)
			{
				result = countersinkSinkingLength;
			}
			break;
		}
		case KindOfToolType.CountersinkFlatDrill:
			result = ((_0023_003DzMgH6lrZKngR3 as CuttingTool).ToolBody as CountersinkFlatDrill).CountersinkSinkingLength;
			break;
		}
		return result;
	}

	private string _0023_003Dzm8J_0024kSNCTmcg(KindOfToolType _0023_003DzDQO3YmpbOfQ7)
	{
		string text = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703448);
		string result;
		if (true)
		{
			result = text;
		}
		switch (_0023_003DzDQO3YmpbOfQ7)
		{
		case KindOfToolType.ConicalDrill:
		{
			string text3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703440);
			if (4u != 0)
			{
				result = text3;
			}
			break;
		}
		case KindOfToolType.CountersinkConicalDrill:
		{
			string text2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432);
			if (8u != 0)
			{
				result = text2;
			}
			break;
		}
		case KindOfToolType.CountersinkFlatDrill:
			result = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703432);
			break;
		}
		return result;
	}

	private void _0023_003DzD8a5kqOC3kb00YxXLg_003D_003D()
	{
		if (base.ActiveEdgeBandingInOut != null && _0023_003DzG4_YXQjbwey_0024 != null)
		{
			EdgeTechnology technology = _edgeInterface.GetTechnology(_0023_003DzG4_YXQjbwey_0024.TechnologyKey);
			EdgeTechnology edgeTechnology;
			if (5u != 0)
			{
				edgeTechnology = technology;
			}
			if (edgeTechnology != null)
			{
				base.ActiveEdgeBandingInOut.Approach.Lamp.Status = edgeTechnology.Lamp.Status;
				base.ActiveEdgeBandingInOut.Approach.Lamp.Power = edgeTechnology.Lamp.Power;
			}
		}
	}

	private void _0023_003DzwGTEwPV_3vz8frPXHGT91smhv0cz(double? _0023_003DzR4OJMJE_003D, double? _0023_003Dz5nT6Y_0024c_003D, int? _0023_003DzMwhcrSY_003D, ref double _0023_003Dz_0024tsmIEEq1Sja01L2Xw_003D_003D, ref double _0023_003DzZhsdXfdx1WAiuv_0024fGQ_003D_003D, ref double _0023_003DzSJe3DvI_003D)
	{
		if (!_0023_003DzMwhcrSY_003D.HasValue)
		{
			return;
		}
		_0023_003DzSJe3DvI_003D = _0023_003DzMwhcrSY_003D.Value;
		double num;
		if (6u != 0)
		{
			num = 0.0;
		}
		if (_0023_003Dz5nT6Y_0024c_003D.HasValue)
		{
			double value = _0023_003Dz5nT6Y_0024c_003D.Value;
			if (uint.MaxValue != 0)
			{
				num = value;
			}
		}
		int value2 = _0023_003DzMwhcrSY_003D.Value;
		double overMaterial = num;
		if (8u != 0)
		{
			SetToolCorrection(value2, overMaterial);
		}
		_0023_003Dz_0024tsmIEEq1Sja01L2Xw_003D_003D = 0.2;
		_0023_003DzZhsdXfdx1WAiuv_0024fGQ_003D_003D = 0.0;
	}

	private bool _0023_003Dzdk3_wRkuVl8n()
	{
		bool result;
		if (7u != 0)
		{
			result = false;
		}
		if (_0023_003Dz2z_U3NnO_6AmnCuicfpA010_003D == WorkPlaneCategory.CYFLEX_HP2 || _0023_003Dz2z_U3NnO_6AmnCuicfpA010_003D == WorkPlaneCategory.CYFLEX_F1300 || _0023_003Dz2z_U3NnO_6AmnCuicfpA010_003D == WorkPlaneCategory.CYFLEX_F900)
		{
			if (0 == 0)
			{
				result = true;
			}
		}
		else if (_0023_003Dz5YM4N3AL4caK == MachineCategory.CyflexHP || _0023_003Dz5YM4N3AL4caK == MachineCategory.CyflexS || _0023_003Dz5YM4N3AL4caK == MachineCategory.CyflexHP2)
		{
			if (true)
			{
				result = true;
			}
		}
		return result;
	}

	private bool _0023_003DzjKvVK7bxrdjhrqY2Zw_003D_003D()
	{
		_ = 8;
		if (4 == 0)
		{
		}
		if (_0023_003Dz5YM4N3AL4caK != MachineCategory.UniflexHP)
		{
			_ = 0;
			if (2 == 0)
			{
			}
			return _0023_003Dz5YM4N3AL4caK == MachineCategory.UniflexS;
		}
		return true;
	}

	private bool _0023_003DznvXC_Qf6bz6i()
	{
		_ = 5;
		if (2 == 0)
		{
		}
		return _0023_003Dz5YM4N3AL4caK == MachineCategory.PowerFlex;
	}

	private bool _0023_003Dzs854AHxGxXXFjErcriLOPtQ_003D()
	{
		_ = 2;
		if (1 == 0)
		{
		}
		return _0023_003Dz5YM4N3AL4caK == MachineCategory.StartechCNP;
	}

	private int _0023_003DzJw91eKTxgLKYf1cniI_0024ZVJ3itRXYO6rhApDM54A_003D(int _0023_003Dzo44s0zuyHmyz)
	{
		int result;
		if (5u != 0)
		{
			result = 0;
		}
		switch (_0023_003Dzo44s0zuyHmyz)
		{
		case 1:
			if (4u != 0)
			{
				result = 1;
			}
			break;
		case 2:
			if (6u != 0)
			{
				result = 4;
			}
			break;
		case 3:
			result = 2;
			break;
		case 4:
			result = 2;
			break;
		case 5:
			result = 4;
			break;
		case 6:
			result = 2;
			break;
		}
		return result;
	}

	private bool _0023_003DzKYT84fJWFcm65bUVOg_003D_003D(double _0023_003DzaepdRmo_003D, double _0023_003DzCz_rHXQ_003D, double _0023_003DzvBPnL2fni8v8, double _0023_003DzROrUB1ADgJfb, double _0023_003DzppTHfF4_003D, double _0023_003Dzg98T3NI_003D)
	{
		bool result;
		if (7u != 0)
		{
			result = false;
		}
		double num = (_0023_003DzROrUB1ADgJfb - _0023_003DzCz_rHXQ_003D) / (_0023_003DzvBPnL2fni8v8 - _0023_003DzaepdRmo_003D);
		double num2 = (_0023_003Dzg98T3NI_003D - _0023_003DzROrUB1ADgJfb) / (_0023_003DzppTHfF4_003D - _0023_003DzvBPnL2fni8v8);
		double num3;
		if (true)
		{
			num3 = num2;
		}
		if (object.Equals(num, num3))
		{
			if (true)
			{
				result = true;
			}
		}
		return result;
	}

	private void _0023_003DzRwum0tnzWhlH(ConfigurationInterface _0023_003Dz0ZRVQUpXa3bL)
	{
		bool num = _0023_003Dz0ZRVQUpXa3bL?.IsToolsNotationExtended(AppInfo.MachinePanelType, AppInfo.MachinePanelPath) ?? false;
		if (3u != 0)
		{
			_0023_003Dzmkh2mynWK8RD = num;
		}
	}

	private bool _0023_003Dz4sEJkWyhyJfi_WZtUyB_0024PnugGiuzUwv6sw_003D_003D(Operation _0023_003Dz_0024TgJHtw_003D)
	{
		_ = 2;
		if (2 == 0)
		{
		}
		ReferenceKey workplanID = _0023_003Dz_0024TgJHtw_003D.GetWorkplanID();
		_ = 3;
		if (1 == 0)
		{
		}
		return workplanID == base.ActiveWorkplan.ReferenceKey;
	}

	private bool _0023_003DzyjjJriNoVkOnVk90KA_003D_003D(string _0023_003Dzf54DH27vqdpn)
	{
		_ = 2;
		if (1 == 0)
		{
		}
		_ = -1;
		if (-1 == 0)
		{
		}
		return _0023_003Dzf54DH27vqdpn == base.ActiveWorkplane.Name;
	}

	private bool _0023_003Dz1O68erHnwg2_0024TNSLZZ0GADkG8p1C9P4msg_003D_003D(string _0023_003Dzf54DH27vqdpn)
	{
		_ = -1;
		if (1 == 0)
		{
		}
		_ = 6;
		if (1 == 0)
		{
		}
		return _0023_003Dzf54DH27vqdpn == base.ActiveWorkplane.Name;
	}
}
