using System;

namespace ScmGroup.XCam.Scripting;

public abstract class XilogScript : UserScript, _0023_003DzYMUTKCjGvGuFGJOCFLxE2znyK7T4diz2Ng_003D_003D
{
	protected XilogProgram program
	{
		get
		{
			_ = 3;
			if (1 == 0)
			{
			}
			return _program as XilogProgram;
		}
	}

	public string ACTIVETOOLS
	{
		get
		{
			_ = 8;
			if (8 == 0)
			{
			}
			return (_program as XilogProgram).ActiveTools;
		}
		set
		{
			XilogProgram obj = _program as XilogProgram;
			if (4u != 0)
			{
				obj.ActiveTools = value;
			}
		}
	}

	public double ZMAC
	{
		get
		{
			_ = 0;
			if (5 == 0)
			{
			}
			return (_program as XilogProgram).ZMAC;
		}
	}

	public double OPROG
	{
		get
		{
			_ = 4;
			if (2 == 0)
			{
			}
			return (_program as XilogProgram).OPROG;
		}
	}

	public double FLD
	{
		get
		{
			_ = 3;
			if (4 == 0)
			{
			}
			return (_program as XilogProgram).FLD;
		}
	}

	protected XilogScript()
	{
		_ = 5;
		if (7 == 0)
		{
		}
		base._002Ector();
	}

	public override void Initialize()
	{
		XilogProgram xilogProgram = new XilogProgram(null, base.Info.ProjectInterface, base.Info.ToolInterface, base.Info.ConfigurationInterface, base.Info.EdgeInterface, base.Info.WorkPlanId, base.Info.WorkPieceId, base.Info.PlaneId, isSubprogram: true, base.Info.Priority);
		if (4u != 0)
		{
			_program = xilogProgram;
		}
	}

	public new static void Main()
	{
	}

	public void H(double DX, double DY, double DZ, string FLD, string TOOLS, double BX = 0.0, double BY = 0.0, double BZ = 0.0, long? V = null, long T = 0L, int R = 1, int C = 0, string UNIT = "MM", string ENVVAR = "")
	{
		_ = 4;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (6 == 0)
		{
		}
		_ = 0;
		if (-1 == 0)
		{
		}
		xilogProgram.H(DX, DY, DZ, FLD, TOOLS, BX, BY, BZ, V, T, R, C, UNIT, ENVVAR);
	}

	public void C(double C = 0.0, double S = 0.0)
	{
		_ = 7;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (8 == 0)
		{
		}
		double c = Convert.ToInt32(C);
		_ = 6;
		if (7 == 0)
		{
		}
		xilogProgram.C(c, S);
	}

	public void F(double F)
	{
		_ = 0;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (false)
		{
		}
		xilogProgram.F(F);
	}

	public void F(double? F)
	{
		_ = 8;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (2 == 0)
		{
		}
		xilogProgram.F(F);
	}

	public void _M(string N, string P)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (8 == 0)
		{
		}
		_ = 8;
		if (-1 == 0)
		{
		}
		xilogProgram._M(N, P);
	}

	public void M(string name, double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? I = null, double? J = null, double? V = null, double? S = null, string T = "", double? F = null, double? C = null, double? K = null, double? P = null, double? Q = null, double? R = null, double? x = null, double? y = null, double? a = null, double? B = null, double? r = null, double? D = null, double? s = null, double? l = null, double? G = null, double? L = null, string N = "")
	{
		_ = 5;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (4 == 0)
		{
		}
		_ = 0;
		if (1 == 0)
		{
		}
		xilogProgram.M(name, X, Y, Z, A, H, E, I, J, V, S, T, F, C, K, P, Q, R, x, y, a, B, r, D, s, l, G, L, N);
	}

	public void GIN(double? G, double? R = null, double? Q = null, double? V = null)
	{
		_ = 6;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (7 == 0)
		{
		}
		_ = 4;
		if (8 == 0)
		{
		}
		xilogProgram.GIN(G, R, Q, V);
	}

	public void GOUT(double? G, double? R = null, double? Q = null, double? L = null, double? V = null)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (7 == 0)
		{
		}
		_ = 0;
		if (1 == 0)
		{
		}
		xilogProgram.GOUT(G, R, Q, L, V);
	}

	public void G0(double? X = null, double? Y = null, double? Z = null, string T = "", double? E = null, double? V = null, double? S = null, double? D = null, double? s = null, string N = "")
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (6 == 0)
		{
		}
		_ = 0;
		if (3 == 0)
		{
		}
		xilogProgram.G0(X, Y, Z, T, E, V, S, D, s, N);
	}

	public void G1(double? X = null, double? Y = null, double? Z = null, double? V = null)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (6 == 0)
		{
		}
		_ = 3;
		if (1 == 0)
		{
		}
		xilogProgram.G1(X, Y, Z, V);
	}

	public void ATP(double? X = null, double? Y = null, double? Z = null, double? G = null, double? V = null)
	{
		_ = 6;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (8 == 0)
		{
		}
		_ = 8;
		if (1 == 0)
		{
		}
		xilogProgram.ATP(X, Y, Z, G, V);
	}

	public void G2(double? X = null, double? Y = null, double? Z = null, double? I = null, double? J = null, double? V = null, double? r = null)
	{
		_ = 3;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (8 == 0)
		{
		}
		_ = 1;
		if (1 == 0)
		{
		}
		xilogProgram.G2(X, Y, Z, I, J, V, r);
	}

	public void G3(double? X = null, double? Y = null, double? Z = null, double? I = null, double? J = null, double? V = null, double? r = null)
	{
		_ = 5;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (4 == 0)
		{
		}
		_ = 4;
		if (6 == 0)
		{
		}
		xilogProgram.G3(X, Y, Z, I, J, V, r);
	}

	public void IX(double E)
	{
		_ = 4;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (8 == 0)
		{
		}
		xilogProgram.IX(E);
	}

	public void IY(double E)
	{
		_ = -1;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (-1 == 0)
		{
		}
		xilogProgram.IY(E);
	}

	public void PL(double? X = null, double? Y = null, double? Z = null, double? Q = null, double? R = null)
	{
		_ = 1;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (4 == 0)
		{
		}
		_ = 8;
		if (4 == 0)
		{
		}
		xilogProgram.PL(X, Y, Z, Q, R);
	}

	public void MODE(int? O = null, int? Z = null)
	{
		_ = -1;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (5 == 0)
		{
		}
		_ = 4;
		if (8 == 0)
		{
		}
		xilogProgram.MODE(O, Z);
	}

	public void G5(double? X = null, double? Y = null, double? Z = null, double? V = null, double? G = null, double? L = null)
	{
		_ = 2;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (3 == 0)
		{
		}
		_ = -1;
		if (4 == 0)
		{
		}
		xilogProgram.G5(X, Y, Z, V, G, L);
	}

	public void ROT(double? A = null, double? X = null, double? Y = null)
	{
		_ = 2;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (5 == 0)
		{
		}
		_ = 0;
		if (7 == 0)
		{
		}
		xilogProgram.ROT(A, X, Y);
	}

	public void O(double? X = null, double? Y = null, double? Z = null, double? F = null)
	{
		_ = 1;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (8 == 0)
		{
		}
		_ = 2;
		if (6 == 0)
		{
		}
		xilogProgram.O(X, Y, Z, F);
	}

	public void SX(double? E = null, double? M = null)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (5 == 0)
		{
		}
		_ = -1;
		if (false)
		{
		}
		xilogProgram.SX(E, M);
	}

	public void SY(double? E = null, double? M = null)
	{
		_ = 2;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (-1 == 0)
		{
		}
		_ = 0;
		if (6 == 0)
		{
		}
		xilogProgram.SY(E, M);
	}

	public void ATPR(double? X = null, double? Y = null, double? Z = null, double? H = null, double? G = null, double? V = null, double? Q = null)
	{
		_ = 0;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (6 == 0)
		{
		}
		_ = 6;
		if (4 == 0)
		{
		}
		xilogProgram.ATPR(X, Y, Z, H, G, V, Q);
	}

	public void TA(double? X = null, double? Y = null, double? G = null, double? Q = null, string T = "")
	{
		_ = 0;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (2 == 0)
		{
		}
		_ = 3;
		if (2 == 0)
		{
		}
		xilogProgram.TA(X, Y, G, Q, T);
	}

	public void XT(double? G = null, string N = "")
	{
		_ = 1;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (1 == 0)
		{
		}
		_ = 8;
		if (6 == 0)
		{
		}
		xilogProgram.XT(G, N);
	}

	public void ISO(string I = "")
	{
		_ = 0;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (2 == 0)
		{
		}
		xilogProgram.ISO(I);
	}

	public void XBRAKE(string N = "")
	{
		_ = 6;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (2 == 0)
		{
		}
		xilogProgram.XBRAKE(N);
	}

	public void XBLOWER(int? E = null, string T = "")
	{
		_ = 0;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (1 == 0)
		{
		}
		_ = 0;
		if (8 == 0)
		{
		}
		xilogProgram.XBLOWER(E, T);
	}

	public void XSP(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? B = null, double? D = null)
	{
		_ = -1;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (-1 == 0)
		{
		}
		_ = 7;
		if (2 == 0)
		{
		}
		xilogProgram.XSP(X, Y, Z, A, V, B, D);
	}

	public void XN(double? X = null, double? Y = null, double? Q = null, double? speed = null, double? spindleEnable = null, double? tool = null)
	{
		_ = 5;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (5 == 0)
		{
		}
		_ = 2;
		if (8 == 0)
		{
		}
		xilogProgram.XN(X, Y, Q, speed, spindleEnable, tool);
	}

	public void XL2P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? B = null, double? L = null)
	{
		_ = 1;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (7 == 0)
		{
		}
		_ = 7;
		if (6 == 0)
		{
		}
		xilogProgram.XL2P(X, Y, Z, A, V, B, L);
	}

	public void XL2PP(double? X = null, double? Y = null, double? Z = null, double? D = null, double? S = null, double? L = null, double? V = null, double? s = null)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (5 == 0)
		{
		}
		_ = 5;
		if (2 == 0)
		{
		}
		xilogProgram.XL2PP(X, Y, Z, D, S, L, V, s);
	}

	public void XARP(double? X = null, double? Y = null, double? Z = null, double? r = null, double? D = null, double? S = null, double? L = null, double? G = null, double? V = null, double? s = null)
	{
		_ = 6;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (-1 == 0)
		{
		}
		_ = 7;
		if (6 == 0)
		{
		}
		xilogProgram.XAR(X, Y, Z, null, V, r, G);
	}

	public void LONG(double? X = null, double? Y = null, double? x = null, double? Z = null, double? a = null, double? s = null, double? I = null, double? G = null, double? E = null)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (6 == 0)
		{
		}
		_ = 1;
		if (6 == 0)
		{
		}
		xilogProgram.LONG(X, Y, x, Z, a, s, I, G, E);
	}

	public void BLADE(double? X = null, double? Y = null, double? x = null, double? Z = null, double? J = null, double? E = null)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (5 == 0)
		{
		}
		_ = 8;
		if (6 == 0)
		{
		}
		xilogProgram.BLADE(X, Y, x, Z, J, E);
	}

	public void G5R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? Q = null, double? G = null, double? L = null)
	{
		_ = 0;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (8 == 0)
		{
		}
		_ = 0;
		if (2 == 0)
		{
		}
		xilogProgram.G5R(X, Y, Z, A, H, V, Q, G, L);
	}

	public void GSET(double? V = null, double? B = null, string T = "")
	{
		_ = -1;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (1 == 0)
		{
		}
		_ = 5;
		if (3 == 0)
		{
		}
		xilogProgram.GSET(V, B, T);
	}

	public void GREP(double? X = null, double? Y = null, double? Z = null, double? A = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? x = null, double? y = null, double? D = null, double? s = null, double? G = null, string N = "", string T = "")
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (5 == 0)
		{
		}
		_ = -1;
		if (5 == 0)
		{
		}
		xilogProgram.GREP(X, Y, Z, A, E, V, S, Q, x, y, D, s, G, N, T);
	}

	public void GFIL(double? V = null, double? r = null)
	{
		_ = -1;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (3 == 0)
		{
		}
		_ = -1;
		if (3 == 0)
		{
		}
		xilogProgram.GFIL(V, r);
	}

	public void GCHA(double? V = null, double? I = null, double? L = null)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (8 == 0)
		{
		}
		_ = -1;
		if (3 == 0)
		{
		}
		xilogProgram.GCHA(V, I, L);
	}

	public void XA2P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? I = null, double? J = null, double? V = null, double? B = null, double? G = null, double? L = null)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (8 == 0)
		{
		}
		_ = 2;
		if (false)
		{
		}
		xilogProgram.XA2P(X, Y, Z, A, I, J, V, B, G, L);
	}

	public void PB(double? B = null, double? E = null, double? X = null, double? Y1 = null, double? S1 = null, double? Y2 = null, double? S2 = null, double? Y3 = null, double? S3 = null, double? Y4 = null, double? S4 = null)
	{
		_ = 6;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (-1 == 0)
		{
		}
		_ = 3;
		if (5 == 0)
		{
		}
		xilogProgram.PB(B, E, X, Y1, S1, Y2, S2, Y3, S3, Y4, S4);
	}

	public void REF(double? DX = null, double? DY = null, double? DZ = null, string FLD = "", double? BX = null, double? BY = null, double? BZ = null)
	{
		_ = 7;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (7 == 0)
		{
		}
		_ = 5;
		if (1 == 0)
		{
		}
		xilogProgram.REF(DX, DY, DZ, FLD, BX, BY, BZ);
	}

	public void SET(string NAME, double? VALUE = null)
	{
		_ = 8;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (7 == 0)
		{
		}
		_ = 6;
		if (6 == 0)
		{
		}
		xilogProgram.SET(NAME, VALUE);
	}

	public void SO(string N, string PARAMS = "", double? DX = null, double? DY = null, double? DZ = null, string FLD = "", double? BX = null, double? BY = null, double? BZ = null)
	{
		_ = 3;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (3 == 0)
		{
		}
		_ = 5;
		if (3 == 0)
		{
		}
		xilogProgram.SO(N, PARAMS, DX, DY, DZ, FLD, BX, BY, BZ);
	}

	public void S(string N, string PARAMS = "", double? X = null, double? Y = null, double? Z = null, double? A = null)
	{
		_ = 7;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (false)
		{
		}
		_ = 5;
		if (8 == 0)
		{
		}
		xilogProgram.S(N, PARAMS, X, Y, Z, A);
	}

	public void G2R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? I = null, double? J = null, double? V = null, double? Q = null, double? r = null)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 5;
		if (1 == 0)
		{
		}
		xilogProgram.G2R(X, Y, Z, A, H, I, J, V, Q, r);
	}

	public void G3R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? I = null, double? J = null, double? V = null, double? Q = null, double? r = null)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (4 == 0)
		{
		}
		_ = 1;
		if (5 == 0)
		{
		}
		xilogProgram.G3R(X, Y, Z, A, H, I, J, V, Q, r);
	}

	public void G1R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? Q = null, double? B = null, double? L = null)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (5 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		xilogProgram.G1R(X, Y, Z, A, H, V, Q, B, L);
	}

	public void XA3P(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? V = null, double? x = null, double? y = null)
	{
		_ = 5;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (4 == 0)
		{
		}
		_ = 2;
		if (8 == 0)
		{
		}
		xilogProgram.XA3P(X, Y, Z, A, H, V, x, y);
	}

	public void G13D(double? X = null, double? Y = null, double? H = null, double? V = null, double? Q = null, double? R = null)
	{
		_ = 2;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (5 == 0)
		{
		}
		_ = 8;
		if (4 == 0)
		{
		}
		xilogProgram.G13D(X, Y, H, V, Q, R);
	}

	public void G0R(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? I = null, double? V = null, double? S = null, double? Q = null, double? B = null, double? D = null, string N = "", string T = "")
	{
		_ = 0;
		if (6 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (3 == 0)
		{
		}
		_ = 2;
		if (2 == 0)
		{
		}
		xilogProgram.G0R(X, Y, Z, A, H, E, I, V, S, Q, B, D, N, T);
	}

	public void G03D(double? X = null, double? Y = null, double? H = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? D = null, string N = "", string T = "")
	{
		_ = 7;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (false)
		{
		}
		_ = 8;
		if (3 == 0)
		{
		}
		xilogProgram.G03D(X, Y, H, E, V, S, Q, R, D, N, T);
	}

	public void BO(double? X = null, double? Y = null, double? Z = null, double? V = null, double? R = null, double? x = null, double? y = null, double? D = null, double? L = null, double? G = null, string N = "")
	{
		_ = 5;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (-1 == 0)
		{
		}
		_ = -1;
		if (5 == 0)
		{
		}
		xilogProgram.BO(X, Y, Z, V, R, x, y, D, L, G, N);
	}

	public void DOWEL(double? X = null, double? Y = null, double? dowelDiameter = null, double? dowelLength = null, double? dowelOuterLength = null, double? glueThickness = null)
	{
		_ = 1;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (3 == 0)
		{
		}
		_ = 2;
		if (7 == 0)
		{
		}
		xilogProgram.DOWEL(X, Y, dowelDiameter, dowelLength, dowelOuterLength, glueThickness);
	}

	public void BR(double? X = null, double? Y = null, double? Z = null, double? A = null, double? H = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? B = null, double? D = null, double? G = null, string T = "")
	{
		_ = 4;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (2 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		xilogProgram.BR(X, Y, Z, A, H, E, V, S, Q, B, D, G, T);
	}

	public void XAR(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? r = null, double? G = null)
	{
		_ = 4;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (false)
		{
		}
		_ = 4;
		if (false)
		{
		}
		xilogProgram.XAR(X, Y, Z, A, V, r, G);
	}

	public void XAR2(double? X = null, double? Y = null, double? Z = null, double? A = null, double? V = null, double? r = null, double? G = null)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (2 == 0)
		{
		}
		_ = 1;
		if (7 == 0)
		{
		}
		xilogProgram.XAR2(X, Y, Z, A, V, r, G);
	}

	public void B(double? X = null, double? Y = null, double? Z = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? x = null, double? y = null, double? a = null, double? G = null, double? D = null, string T = "")
	{
		_ = 4;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 2;
		if (8 == 0)
		{
		}
		_ = -1;
		if (3 == 0)
		{
		}
		xilogProgram.B(X, Y, Z, E, V, S, Q, R, x, y, a, G, D, T);
	}

	public void XEA(double? X = null, double? Y = null, double? Z = null, double? A = null, double? E = null, double? V = null, double? S = null, double? Q = null, double? R = null, double? a = null, double? B = null, double? I = null, double? G = null, double? L = null, string T = "")
	{
		_ = 7;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (1 == 0)
		{
		}
		_ = 2;
		if (8 == 0)
		{
		}
		xilogProgram.XEA(X, Y, Z, A, E, V, S, Q, R, a, B, I, G, L, T);
	}

	public double NUMTOOLS(string value)
	{
		_ = -1;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (7 == 0)
		{
		}
		return xilogProgram.NUMTOOLS(value);
	}

	public string GETTOOL(string value, int index)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (false)
		{
		}
		_ = -1;
		if (6 == 0)
		{
		}
		return xilogProgram.GETTOOL(value, index);
	}

	public string GETTOOL(string value, double index)
	{
		_ = 3;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (8 == 0)
		{
		}
		_ = 0;
		if (2 == 0)
		{
		}
		return xilogProgram.GETTOOL(value, index);
	}

	public double TOOLPAR(string tool, int index)
	{
		_ = -1;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (1 == 0)
		{
		}
		_ = 1;
		if (false)
		{
		}
		return xilogProgram.TOOLPAR(tool, index);
	}

	public double TLRAD(string tool)
	{
		_ = 0;
		if (8 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (false)
		{
		}
		return xilogProgram.TLRAD(tool);
	}

	public double TLLEN(string tool)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (-1 == 0)
		{
		}
		return xilogProgram.TLLEN(tool);
	}

	public double TLURAD(string tool)
	{
		_ = 3;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = -1;
		if (6 == 0)
		{
		}
		return xilogProgram.TLURAD(tool);
	}

	public double TLULEN(string tool)
	{
		_ = 5;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (3 == 0)
		{
		}
		return xilogProgram.TLULEN(tool);
	}

	public void PRINT(string message)
	{
		_ = 3;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (6 == 0)
		{
		}
		xilogProgram.PRINT(message);
	}

	public void PRINT(string message, params object[] par)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (1 == 0)
		{
		}
		_ = 3;
		if (-1 == 0)
		{
		}
		xilogProgram.PRINT(message, par);
	}

	public void PARK(double? S = null, double? Q = null)
	{
		_ = 7;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (4 == 0)
		{
		}
		_ = 8;
		if (8 == 0)
		{
		}
		xilogProgram.PARK(S, Q);
	}

	public double HeapGet(double index)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 7;
		if (false)
		{
		}
		return xilogProgram.HeapGet(index);
	}

	public double HeapPut(double index, double value)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 1;
		if (3 == 0)
		{
		}
		_ = 7;
		if (8 == 0)
		{
		}
		return xilogProgram.HeapPut(index, value);
	}

	public double abs(double? value)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		return _program.abs(value.Value);
	}

	public double ABS(double? value)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		return _program.abs(value.Value);
	}

	public double acos(double? value)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		return _program.acos(value.Value);
	}

	public double ACOS(double? value)
	{
		_ = 8;
		if (false)
		{
		}
		return _program.acos(value.Value);
	}

	public double asin(double? value)
	{
		_ = 6;
		if (-1 == 0)
		{
		}
		return _program.asin(value.Value);
	}

	public double ASIN(double? value)
	{
		_ = 7;
		if (false)
		{
		}
		return _program.asin(value.Value);
	}

	public double atan(double? value)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		return _program.atan(value.Value);
	}

	public double ATAN(double? value)
	{
		_ = 4;
		if (-1 == 0)
		{
		}
		return _program.atan(value.Value);
	}

	public double sin(double? value)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		return _program.sin(value.Value);
	}

	public double SIN(double? value)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		return _program.sin(value.Value);
	}

	public double COS(double? value)
	{
		_ = 4;
		if (5 == 0)
		{
		}
		return _program.cos(value.Value);
	}

	public double cos(double? value)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		return _program.cos(value.Value);
	}

	public double TAN(double? value)
	{
		_ = 5;
		if (5 == 0)
		{
		}
		return _program.tan(value.Value);
	}

	public double tan(double? value)
	{
		_ = 1;
		if (8 == 0)
		{
		}
		return _program.tan(value.Value);
	}

	public double ln(double? value)
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		return _program.ln(value.Value);
	}

	public double LN(double? value)
	{
		_ = 4;
		if (6 == 0)
		{
		}
		return _program.ln(value.Value);
	}

	public double log10(double? value)
	{
		_ = 1;
		if (7 == 0)
		{
		}
		return _program.log10(value.Value);
	}

	public double LOG10(double? value)
	{
		_ = 2;
		if (1 == 0)
		{
		}
		return _program.log10(value.Value);
	}

	public double exp(double? value)
	{
		_ = -1;
		if (false)
		{
		}
		return _program.exp(value.Value);
	}

	public double EXP(double? value)
	{
		_ = 6;
		if (3 == 0)
		{
		}
		return _program.exp(value.Value);
	}

	public double sqrt(double? value)
	{
		_ = 1;
		if (5 == 0)
		{
		}
		return _program.sqrt(value.Value);
	}

	public double SQRT(double? value)
	{
		_ = -1;
		if (4 == 0)
		{
		}
		return _program.sqrt(value.Value);
	}

	public double pow(double? x, double? y)
	{
		_ = 6;
		if (2 == 0)
		{
		}
		return _program.pow(x.Value, y.Value);
	}

	public double POW(double? x, double? y)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		return _program.pow(x.Value, y.Value);
	}

	public double rd(double? value)
	{
		_ = -1;
		if (3 == 0)
		{
		}
		return _program.rd(value.Value);
	}

	public double RD(double? value)
	{
		_ = 8;
		if (false)
		{
		}
		return _program.rd(value.Value);
	}

	public double ru(double? value)
	{
		_ = 4;
		if (6 == 0)
		{
		}
		return _program.ru(value.Value);
	}

	public double RU(double? value)
	{
		_ = 4;
		if (1 == 0)
		{
		}
		return _program.ru(value.Value);
	}

	public void ESET(double a = 0.0, double r = 0.0, double s = 0.0, string N = null, double b = 0.0, double? c = null, long T = 0L, int manualEdgeLoading = 0, string rollerCode = null)
	{
		_ = 4;
		if (false)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (7 == 0)
		{
		}
		_ = 1;
		if (1 == 0)
		{
		}
		xilogProgram.ESET(a, r, s, N, b, c, T, manualEdgeLoading, rollerCode);
	}

	public void ECUT(double? X = null, double? Y = null, string N = null, double? a = null, double? s = null, int Q = 1, int G = 1, string T = "", int? C = null)
	{
		_ = 3;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (5 == 0)
		{
		}
		_ = 6;
		if (8 == 0)
		{
		}
		xilogProgram.ECUT(X, Y, N, a, s, Q, G, T, C);
	}

	public void ECLOSE(double? L = null)
	{
		_ = 8;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 3;
		if (false)
		{
		}
		xilogProgram.ECLOSE(L);
	}

	public void EIN(double? X = null, double? Y = null, double? A = null, double E = 0.0, double J = 0.0, double? V = null, double? R = null, double? B = null, double? D = null, double L = 0.0, int CUT = 0, int? ROT = null, int AUTOSTART = 1, double? TIN = null, double LAMP = 0.0, int? PHON = null, double? V_CAR = null)
	{
		_ = 5;
		if (5 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 8;
		if (2 == 0)
		{
		}
		_ = 2;
		if (false)
		{
		}
		xilogProgram.EIN(X, Y, A, E, J, V, R, B, D, L, CUT, ROT, AUTOSTART, TIN, LAMP, PHON, V_CAR);
	}

	public void EROT(double? A = null, double Q = 0.0)
	{
		_ = 3;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (5 == 0)
		{
		}
		_ = 3;
		if (false)
		{
		}
		xilogProgram.EROT(A, Q);
	}

	public void EOUT(double? Q = null, double? R = null, double? x = null, double? VOUT = null, double? TCSPI = null, double? BROT = null)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (1 == 0)
		{
		}
		_ = 8;
		if (3 == 0)
		{
		}
		xilogProgram.EOUT(Q, R, x, VOUT, TCSPI, BROT);
	}

	public void LB(double L = 0.0)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 0;
		if (4 == 0)
		{
		}
		xilogProgram.LB(L);
	}

	public void LAMP(double Q = 0.0, double D = 0.0)
	{
		_ = 3;
		if (2 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 6;
		if (2 == 0)
		{
		}
		xilogProgram.LAMP(Q, D);
	}

	public void STOP(string format)
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 5;
		if (8 == 0)
		{
		}
		xilogProgram.STOP(format);
	}

	public void EDGELINKER(string name)
	{
		_ = 4;
		if (1 == 0)
		{
		}
		XilogProgram xilogProgram = program;
		_ = 6;
		if (false)
		{
		}
		xilogProgram.EDGELinker(name);
	}
}
