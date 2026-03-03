using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;
using GeometryService;
using Ionic.Zip;
using ScmGroup.XCam.Common;
using ScmGroup.XCam.Common.EventBroker;
using ScmGroup.XCam.Common.Utility;
using ScmGroup.XCam.ConfigDataModel;
using ScmGroup.XCam.ConfigDataModel.ConfigInterface;
using ScmGroup.XCam.ConfigDataModel.Heads;
using ScmGroup.XCam.ConfigDataModel.Machines;
using ScmGroup.XCam.EdgeDataModel;
using ScmGroup.XCam.ExceptionManagement;
using ScmGroup.XCam.Localization;
using ScmGroup.XCam.MachiningDataModel;
using ScmGroup.XCam.MachiningDataModel.AirBlowering;
using ScmGroup.XCam.MachiningDataModel.Geometry;
using ScmGroup.XCam.MachiningDataModel.Labeling;
using ScmGroup.XCam.MachiningDataModel.Milling;
using ScmGroup.XCam.MachiningDataModel.Parametrics;
using ScmGroup.XCam.MachiningDataModel.ProjectInterface;
using ScmGroup.XCam.MachiningDataModel.ProjectModule;
using ScmGroup.XCam.MachiningDataModel.Strategy;
using ScmGroup.XCam.MachiningDataModel.Technology;
using ScmGroup.XCam.MachiningDataModel.Utility;
using ScmGroup.XCam.MachiningDataModel.WorkPlane;
using ScmGroup.XCam.ProjectObjectModel;
using ScmGroup.XCam.ProjectObjectModel.Project;
using ScmGroup.XCam.ProjectObjectModel.Technology;
using ScmGroup.XCam.ProjectObjectModel.WorkingStep;
using ScmGroup.XCam.ProjectObjectModel.Workpiece;
using ScmGroup.XCam.Scripting.ProjectModule;
using ScmGroup.XCam.ToolDataModel;
using ScmGroup.XCam.ToolDataModel.Aggregate;
using ScmGroup.XCam.ToolDataModel.Common;
using ScmGroup.XCam.ToolDataModel.Tool;
using ScmGroup.XCam.WorkPlaneManager.DynamicWorkingArea;
using ScmGroup.XCam.WorkPlaneManager.SizeComputing;

namespace ScmGroup.XCam.Scripting;

public class Program : IProgram, IScripting
{
	private sealed class _0023_003Dz5d4CWihhmrSbAY4_0024S3xjdas_003D
	{
		public BaseScripting _0023_003DzEdU8_0024mdgfCA_0024;

		public _0023_003Dz5d4CWihhmrSbAY4_0024S3xjdas_003D()
		{
			_ = 6;
			if (4 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dz5DQ0t_0024pghvgYKgjBZw_003D_003D(BaseScripting _0023_003DzT2wOlf0_003D)
		{
			_ = 2;
			if (1 == 0)
			{
			}
			_ = 6;
			if (6 == 0)
			{
			}
			return _0023_003DzT2wOlf0_003D == _0023_003DzEdU8_0024mdgfCA_0024;
		}
	}

	private sealed class _0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D
	{
		public Geometry _0023_003Dzfqxf7hIPL6sd;

		public _0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D()
		{
			_ = 7;
			if (4 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzIOmPczO8tqLUaFm_Zw_003D_003D(BaseScripting _0023_003Dz3cCeXbQ_003D)
		{
			_ = -1;
			if (8 == 0)
			{
			}
			_ = 6;
			if (1 == 0)
			{
			}
			return _0023_003Dz3cCeXbQ_003D == _0023_003Dzfqxf7hIPL6sd;
		}
	}

	[Serializable]
	private sealed class _0023_003DzJBaCSp8_003D
	{
		public static readonly _0023_003DzJBaCSp8_003D _0023_003DzK15DASY_003D;

		public static Predicate<SubProgramParameter> _0023_003Dz6PzZ8hhllD1tGjV2Ow_003D_003D;

		public static Predicate<CoreTool> _0023_003DzP6WHDQm8zo9nSDAkbw_003D_003D;

		static _0023_003DzJBaCSp8_003D()
		{
			_0023_003DzJBaCSp8_003D _0023_003DzJBaCSp8_003D = new _0023_003DzJBaCSp8_003D();
			if (4u != 0)
			{
				_0023_003DzK15DASY_003D = _0023_003DzJBaCSp8_003D;
			}
		}

		public _0023_003DzJBaCSp8_003D()
		{
			_ = 0;
			if (8 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzvATyibxP_cJkGg5PRi9d4ZQ_003D(SubProgramParameter _0023_003DzxkjD83Y_003D)
		{
			_ = 0;
			if (7 == 0)
			{
			}
			if (_0023_003DzxkjD83Y_003D.ParameterType != ParameterType.WorkpieceHeight)
			{
				_ = 6;
				if (-1 == 0)
				{
				}
				if (_0023_003DzxkjD83Y_003D.ParameterType != ParameterType.WorkpieceLength)
				{
					_ = 1;
					if (false)
					{
					}
					return _0023_003DzxkjD83Y_003D.ParameterType == ParameterType.WorkpieceWidth;
				}
			}
			return true;
		}

		internal bool _0023_003DzQSrlccopQqzupCEdBGbAIj4_003D(CoreTool _0023_003Dz11KjQwU_003D)
		{
			_ = 2;
			if (4 == 0)
			{
			}
			return !(_0023_003Dz11KjQwU_003D is AggregateComponent);
		}
	}

	private sealed class _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D
	{
		public string _0023_003DzJ3hfjPs_003D;

		public _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D()
		{
			_ = -1;
			if (4 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dz9MVr2mTS0sC_0024lJVpVg_003D_003D(Variable _0023_003Dz4R1ZTHk_003D)
		{
			_ = -1;
			if (-1 == 0)
			{
			}
			string name = _0023_003Dz4R1ZTHk_003D.Name;
			_ = 8;
			if (1 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}
	}

	private sealed class _0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D
	{
		public MainWorkplan _0023_003Dzj2E8O1eM93x4dJmf2w_003D_003D;

		public _0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D()
		{
			_ = 8;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzrE6DPJtmRepq5fNPRw_003D_003D(Workplan _0023_003DzC3YKTyc_003D)
		{
			_ = 0;
			if (1 == 0)
			{
			}
			ReferenceKey referenceKey = _0023_003DzC3YKTyc_003D.ReferenceKey;
			_ = 3;
			if (8 == 0)
			{
			}
			return referenceKey == _0023_003Dzj2E8O1eM93x4dJmf2w_003D_003D.Key;
		}
	}

	private sealed class _0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D
	{
		public string _0023_003Dz9Wcl7CE_003D;

		public _0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D()
		{
			_ = 5;
			if (1 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dz61ZcLrJP4UhZyo4q2DEDK4E_003D(SubProgramParameterValue _0023_003DzSSTZMDo_003D)
		{
			_ = 3;
			if (false)
			{
			}
			string text = _0023_003DzSSTZMDo_003D.Value.ToString();
			_ = 4;
			if (5 == 0)
			{
			}
			return text == _0023_003Dz9Wcl7CE_003D;
		}
	}

	private sealed class _0023_003DzbumIB86Ykd9r_q2wW14f6ig_003D
	{
		public string _0023_003DzaiLaOdA_003D;

		public _0023_003DzbumIB86Ykd9r_q2wW14f6ig_003D()
		{
			_ = 2;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DziFrzmdKYEDq5OGWjtg_003D_003D(SubProgramParameter _0023_003DzWgwZZx_0024KEGArxfjDZg_003D_003D)
		{
			_ = -1;
			if (4 == 0)
			{
			}
			string name = _0023_003DzWgwZZx_0024KEGArxfjDZg_003D_003D.Name;
			_ = 4;
			if (7 == 0)
			{
			}
			return name == _0023_003DzaiLaOdA_003D;
		}
	}

	private sealed class _0023_003DzcsFxVaWoKx040xiIiBrabW4_003D
	{
		public string _0023_003DzJ3hfjPs_003D;

		public _0023_003DzcsFxVaWoKx040xiIiBrabW4_003D()
		{
			_ = 6;
			if (8 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzRtdbgly3tKXNdlKxNA_003D_003D(Workplane _0023_003DzXufAk8k_003D)
		{
			_ = 6;
			if (3 == 0)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 6;
			if (3 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}

		internal bool _0023_003DzarOZGDrIPCPsNiiMZA_003D_003D(Workpiece _0023_003DzXufAk8k_003D)
		{
			_ = 0;
			if (-1 == 0)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 5;
			if (5 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}

		internal bool _0023_003DzX1SvabqyaNGbgF_0024Vzw_003D_003D(Workplan _0023_003DzXufAk8k_003D)
		{
			_ = 4;
			if (2 == 0)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 2;
			if (2 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}

		internal bool _0023_003DzvWQJwNOw4aYA_0024KCP2w_003D_003D(Operation _0023_003DzXufAk8k_003D)
		{
			_ = 5;
			if (7 == 0)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 1;
			if (1 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}

		internal bool _0023_003DzYSTMmGCXB5Lo3Zl_Pw_003D_003D(Geometry _0023_003DzXufAk8k_003D)
		{
			_ = 0;
			if (8 == 0)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 6;
			if (false)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}

		internal bool _0023_003DzD0N0kMFuFA7oauirIw_003D_003D(ToolPath _0023_003DzXufAk8k_003D)
		{
			_ = 6;
			if (8 == 0)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 3;
			if (7 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}

		internal bool _0023_003DzAnqoHnk_9swNCtdbOw_003D_003D(BlockingProfile _0023_003DzXufAk8k_003D)
		{
			_ = 8;
			if (false)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 2;
			if (6 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}

		internal bool _0023_003DzS3o4HEtfqm_ggITYzQ_003D_003D(BaseScripting _0023_003DzXufAk8k_003D)
		{
			_ = 7;
			if (2 == 0)
			{
			}
			string name = _0023_003DzXufAk8k_003D.Name;
			_ = 1;
			if (3 == 0)
			{
			}
			return name == _0023_003DzJ3hfjPs_003D;
		}
	}

	private sealed class _0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D
	{
		public Geometry _0023_003Dzfqxf7hIPL6sd;

		public _0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D()
		{
			_ = 2;
			if (1 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003DzIOmPczO8tqLUaFm_Zw_003D_003D(BaseScripting _0023_003Dz3cCeXbQ_003D)
		{
			_ = 5;
			if (-1 == 0)
			{
			}
			_ = 8;
			if (6 == 0)
			{
			}
			return _0023_003Dz3cCeXbQ_003D == _0023_003Dzfqxf7hIPL6sd;
		}
	}

	private sealed class _0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D
	{
		public Plane _0023_003Dzf54DH27vqdpn;

		public _0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D()
		{
			_ = 0;
			if (-1 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dzf7ZVBCcUNjaJfFHa5Q_003D_003D(Workplane _0023_003DzuphY4HU_003D)
		{
			_ = 0;
			if (-1 == 0)
			{
			}
			ReferenceKey referenceKey = _0023_003DzuphY4HU_003D.ReferenceKey;
			_ = 4;
			if (3 == 0)
			{
			}
			return referenceKey == _0023_003Dzf54DH27vqdpn.Key;
		}
	}

	protected ProjectInterface _projectInterface;

	protected ToolInterface _toolInterface;

	protected EdgeInterface _edgeInterface;

	protected ConfigurationInterface _configurationInterface;

	protected ConfigurationInterface _supportInterface;

	protected IScriptingReportServices _reportServices;

	protected UI00Options _options;

	protected bool _isMillimeter;

	private bool _0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D;

	private Workplane _0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D;

	private List<BaseScripting> _0023_003DzZa6VxMFfph7N;

	private Dictionary<string, PlaneType> _0023_003DzcdN7paV29v7STct_Vw_003D_003D;

	protected Strategy _activeStrategy;

	protected int _activePriority;

	protected int _activeProbingReferencePoint;

	protected int _activeReferecePosition;

	private Dictionary<string, bool> _0023_003DzGQlGvX_qgE_0024b;

	private List<BaseScripting> _0023_003DzTX7wzNM0R89M;

	protected string _errorString;

	protected double? _retractSecurityPlane;

	protected double? _approachSecurityPlane;

	protected Attributes ActiveAttributes;

	protected string EdgeLinker;

	protected bool MultiEdgeBandingActive;

	protected bool IsTheFirstMultiEdgeBandingActive;

	protected bool ManualEdgeLoading;

	protected bool ManualPressureRollerLoading;

	private int _0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D;

	private bool _0023_003DzpDEAL9o818dC;

	private bool _0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D;

	private Dictionary<string, ProjectInterface> _0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D;

	private Dictionary<string, ReferenceKey> _0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D;

	private List<TechnologyTargetEntity> _0023_003DzULPFoR3ylpZ_0024GhXQfxwoABs_003D;

	private List<TechnologyExecutableInfo> _0023_003Dzag4iMeQOAldNe80NovqNVZU_003D;

	private string _0023_003DzZOWKgSslqFdz2EEA8WcrVnA_003D;

	private Dictionary<string, object> _0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D;

	private bool _0023_003DzYuaGHaZ5av3_0024E_00243Rf_U6U2c_003D;

	private bool _0023_003DznYqeEHrk04Im;

	private TypeOfExtremaMachiningAttributePosition _0023_003Dza01J2_0024_eD1UHFNzD7GMZCIgS2IAk;

	private string _0023_003Dz5iq5gpuO12MFlZruNlpTZI0_003D;

	private Machine _0023_003DzRE0vH8WCFzM6;

	private WorkPlaneCategory _0023_003DzYX5LSNnkrXcH9fDAZbJxBRo_003D;

	private int _0023_003DztQZAXa1gd26n;

	private int[] _0023_003DzobjG82GyRO6N0HSR2g_003D_003D;

	private ProcessServices _0023_003DzwXhwAQVfEqz9;

	private ReferenceKey _0023_003Dz5cyKnAzBg05q;

	private List<Workpiece> _0023_003DzFJLQ_loL_gvsEE3VJw4d7ikh5fhX;

	private List<Workplane> _0023_003Dz3DLnYG4Ffrdmjsix87DesemEaGZq;

	private List<Operation> _0023_003DzDAbp_0024VHHPqpLTMRJnw_003D_003D;

	private List<Geometry> _0023_003DztN7K0TSc9eZhyIPb1A_003D_003D;

	private List<Workplan> _0023_003DzWLTXG623cvUF_oapSSUJXshLKfvF;

	private List<ToolPath> _0023_003DzZzJjL2dHgjEueKUoGQqoQgA_003D;

	private List<BlockingProfile> _0023_003DzG5spAiR81S8uR0Uo__nSKCg_003D;

	private Workpiece _0023_003DzAi6YVcSv6ZvAfHo453ZinHhWfY_F;

	private Workplane _0023_003DzP9cJtouHnBtXuAEvl6ZKh5rDQtuV;

	private Operation _0023_003Dz14K804T49ob5EgjqyqPZHeU_003D;

	private Geometry _0023_003DzRdLWy0lhE7FZWSQSf4Yf_cI_003D;

	private LeadInOut _0023_003DzrDBDqOvuNV0EFdWN_lJJqtFR7_0024yN;

	private MachineFunctions _0023_003Dzel3fcE5QEW2cODbmcZ1EkQI_003D;

	private Pattern _0023_003Dz0YScmPKi99RxiRJLrX4WjkI_003D;

	private ToolPath _0023_003DzS2XyoyIr47Nb9riV0049Nw1t7Nx5;

	private Workplan _0023_003Dz3VQi5hf2oSkL0K_0024DYyYAuRfcaKcx;

	private ToolCorrection _0023_003DzZntYNzIKqKc4_0024GlSwyCQoAfKYgWxx_0024CZNw_003D_003D;

	private double _0023_003DzEXWqYRPLfYfUMv2kDg_003D_003D;

	private double _0023_003Dz7QyDs0iL_00240P149lrtA_003D_003D;

	private double _0023_003Dz0yVcrzJeW0lrRSgCnw_003D_003D;

	private double _0023_003DzzRWVizg_0024ISwIeTEVkw_003D_003D;

	private double _0023_003DzfTHyVD73LKGwMX_NJA_003D_003D;

	private double _0023_003DzKOYTQVs7Rm_fQrR0cOEa2ks_003D;

	private double _0023_003DzvYj1PLo18_0024kyTbDsH6H0UuE_003D;

	private BlockingProfile _0023_003DzI3_0024oKNsyBTIVlBRVquNuRPw_003D;

	private double _0023_003DzOJzpR9HXrof0aWJUf1NvA3k_003D;

	public Transformation ActiveTransformation;

	private EdgeBandingSlotInOut _0023_003DzsZjJJ2el2a6kh3BuxokefTIDJYiP7PbzpTWmxrQ_003D;

	private EdgeBandingInOut _0023_003Dz3hGoGj1lQBnmSo672FaVgOCR0lh0hHWR7A_003D_003D;

	private EdgeDispensingManager _0023_003DzQt5tHPu_0024m5PCV4XqhbPq2UoWKfq_00247hsfPw_003D_003D;

	private EdgeClosingManager _0023_003DzlEoT01eghG1y1MmRdmH2bGw_003D;

	public List<Workpiece> Workpieces
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (6 == 0)
			{
			}
			return _0023_003DzFJLQ_loL_gvsEE3VJw4d7ikh5fhX;
		}
	}

	public List<Workplane> Workplanes
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (2 == 0)
			{
			}
			return _0023_003Dz3DLnYG4Ffrdmjsix87DesemEaGZq;
		}
	}

	public List<Operation> Operations
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (3 == 0)
			{
			}
			return _0023_003DzDAbp_0024VHHPqpLTMRJnw_003D_003D;
		}
	}

	public List<Geometry> Geometries
	{
		[CompilerGenerated]
		get
		{
			_ = 8;
			if (7 == 0)
			{
			}
			return _0023_003DztN7K0TSc9eZhyIPb1A_003D_003D;
		}
	}

	public List<Workplan> Workplans
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (2 == 0)
			{
			}
			return _0023_003DzWLTXG623cvUF_oapSSUJXshLKfvF;
		}
	}

	public List<ToolPath> ToolPaths
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (1 == 0)
			{
			}
			return _0023_003DzZzJjL2dHgjEueKUoGQqoQgA_003D;
		}
	}

	public List<BlockingProfile> BlockingProfiles
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (3 == 0)
			{
			}
			return _0023_003DzG5spAiR81S8uR0Uo__nSKCg_003D;
		}
	}

	public Workpiece ActiveWorkpiece
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (2 == 0)
			{
			}
			return _0023_003DzAi6YVcSv6ZvAfHo453ZinHhWfY_F;
		}
	}

	public Workplane ActiveWorkplane
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (4 == 0)
			{
			}
			return _0023_003DzP9cJtouHnBtXuAEvl6ZKh5rDQtuV;
		}
	}

	public Operation ActiveOperation
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (8 == 0)
			{
			}
			return _0023_003Dz14K804T49ob5EgjqyqPZHeU_003D;
		}
	}

	public Geometry ActiveGeometry
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (7 == 0)
			{
			}
			return _0023_003DzRdLWy0lhE7FZWSQSf4Yf_cI_003D;
		}
	}

	public LeadInOut ActiveLeadInOut
	{
		[CompilerGenerated]
		get
		{
			_ = 3;
			if (5 == 0)
			{
			}
			return _0023_003DzrDBDqOvuNV0EFdWN_lJJqtFR7_0024yN;
		}
	}

	public MachineFunctions ActiveMachineFunctions
	{
		[CompilerGenerated]
		get
		{
			_ = 0;
			if (false)
			{
			}
			return _0023_003Dzel3fcE5QEW2cODbmcZ1EkQI_003D;
		}
	}

	public Pattern ActivePattern
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (false)
			{
			}
			return _0023_003Dz0YScmPKi99RxiRJLrX4WjkI_003D;
		}
	}

	public ToolPath ActiveToolpath
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (7 == 0)
			{
			}
			return _0023_003DzS2XyoyIr47Nb9riV0049Nw1t7Nx5;
		}
	}

	public Workplan ActiveWorkplan
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (2 == 0)
			{
			}
			return _0023_003Dz3VQi5hf2oSkL0K_0024DYyYAuRfcaKcx;
		}
	}

	public ToolCorrection ActiveToolCorrection
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (2 == 0)
			{
			}
			return _0023_003DzZntYNzIKqKc4_0024GlSwyCQoAfKYgWxx_0024CZNw_003D_003D;
		}
	}

	public double ActiveX
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (7 == 0)
			{
			}
			return _0023_003DzEXWqYRPLfYfUMv2kDg_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (7u != 0)
			{
				_0023_003DzEXWqYRPLfYfUMv2kDg_003D_003D = value;
			}
		}
	}

	public double ActiveY
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (1 == 0)
			{
			}
			return _0023_003Dz7QyDs0iL_00240P149lrtA_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (6u != 0)
			{
				_0023_003Dz7QyDs0iL_00240P149lrtA_003D_003D = value;
			}
		}
	}

	public double ActiveZ
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (2 == 0)
			{
			}
			return _0023_003Dz0yVcrzJeW0lrRSgCnw_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (uint.MaxValue != 0)
			{
				_0023_003Dz0yVcrzJeW0lrRSgCnw_003D_003D = value;
			}
		}
	}

	public double ActiveD
	{
		[CompilerGenerated]
		get
		{
			_ = -1;
			if (6 == 0)
			{
			}
			return _0023_003DzzRWVizg_0024ISwIeTEVkw_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (true)
			{
				_0023_003DzzRWVizg_0024ISwIeTEVkw_003D_003D = value;
			}
		}
	}

	public double ActiveR
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (1 == 0)
			{
			}
			return _0023_003DzfTHyVD73LKGwMX_NJA_003D_003D;
		}
		[CompilerGenerated]
		set
		{
			if (8u != 0)
			{
				_0023_003DzfTHyVD73LKGwMX_NJA_003D_003D = value;
			}
		}
	}

	public double Activex
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (3 == 0)
			{
			}
			return _0023_003DzKOYTQVs7Rm_fQrR0cOEa2ks_003D;
		}
		[CompilerGenerated]
		set
		{
			if (2u != 0)
			{
				_0023_003DzKOYTQVs7Rm_fQrR0cOEa2ks_003D = value;
			}
		}
	}

	public double Activey
	{
		[CompilerGenerated]
		get
		{
			_ = 2;
			if (6 == 0)
			{
			}
			return _0023_003DzvYj1PLo18_0024kyTbDsH6H0UuE_003D;
		}
		[CompilerGenerated]
		set
		{
			if (6u != 0)
			{
				_0023_003DzvYj1PLo18_0024kyTbDsH6H0UuE_003D = value;
			}
		}
	}

	public BlockingProfile ActiveBlockingProfile
	{
		[CompilerGenerated]
		get
		{
			_ = 3;
			if (2 == 0)
			{
			}
			return _0023_003DzI3_0024oKNsyBTIVlBRVquNuRPw_003D;
		}
	}

	public double ActiveSpeed
	{
		[CompilerGenerated]
		get
		{
			_ = 5;
			if (6 == 0)
			{
			}
			return _0023_003DzOJzpR9HXrof0aWJUf1NvA3k_003D;
		}
	}

	public EdgeBandingSlotInOut ActiveEdgeBandingSlotInOut
	{
		[CompilerGenerated]
		get
		{
			_ = 4;
			if (4 == 0)
			{
			}
			return _0023_003DzsZjJJ2el2a6kh3BuxokefTIDJYiP7PbzpTWmxrQ_003D;
		}
	}

	public EdgeBandingInOut ActiveEdgeBandingInOut
	{
		[CompilerGenerated]
		get
		{
			_ = 6;
			if (2 == 0)
			{
			}
			return _0023_003Dz3hGoGj1lQBnmSo672FaVgOCR0lh0hHWR7A_003D_003D;
		}
	}

	public EdgeDispensingManager ActiveEdgeDispensing
	{
		[CompilerGenerated]
		get
		{
			_ = 8;
			if (4 == 0)
			{
			}
			return _0023_003DzQt5tHPu_0024m5PCV4XqhbPq2UoWKfq_00247hsfPw_003D_003D;
		}
	}

	public EdgeClosingManager ActiveEdgeClosing
	{
		[CompilerGenerated]
		get
		{
			_ = 1;
			if (5 == 0)
			{
			}
			return _0023_003DzlEoT01eghG1y1MmRdmH2bGw_003D;
		}
	}

	public Program(IScriptingReportServices reportServices, ProjectInterface projectInterface, ToolInterface toolInterface, EdgeInterface edgeInterface, ConfigurationInterface configurationInterface, ConfigurationInterface supportInterface, ReferenceKey workplanID, ReferenceKey workpieceID, ReferenceKey planeID, bool isSubprogram, int priority)
	{
		Dictionary<string, PlaneType> obj = new Dictionary<string, PlaneType>
		{
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611),
				PlaneType.Top
			},
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708601),
				PlaneType.Bottom
			},
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708590),
				PlaneType.Left
			},
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708577),
				PlaneType.Right
			},
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708565),
				PlaneType.Front
			},
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708553),
				PlaneType.Back
			}
		};
		if (3u != 0)
		{
			_0023_003DzcdN7paV29v7STct_Vw_003D_003D = obj;
		}
		Dictionary<string, bool> obj2 = new Dictionary<string, bool>
		{
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641),
				false
			},
			{
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633),
				false
			}
		};
		if (true)
		{
			_0023_003DzGQlGvX_qgE_0024b = obj2;
		}
		List<BaseScripting> list = new List<BaseScripting>();
		if (8u != 0)
		{
			_0023_003DzTX7wzNM0R89M = list;
		}
		Attributes activeAttributes = new Attributes();
		if (uint.MaxValue != 0)
		{
			ActiveAttributes = activeAttributes;
		}
		string empty = string.Empty;
		if (3u != 0)
		{
			EdgeLinker = empty;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (7u != 0)
		{
			_0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D = dictionary;
		}
		Transformation activeTransformation = new Transformation();
		if (3u != 0)
		{
			ActiveTransformation = activeTransformation;
		}
		base._002Ector();
		List<Workpiece> _0023_003Dz3keKASA_003D = new List<Workpiece>();
		if (8u != 0)
		{
			_0023_003Dzb8DIS5dY6ERFKdwZTxz_G_w_003D(_0023_003Dz3keKASA_003D);
		}
		List<Workplane> _0023_003Dz3keKASA_003D2 = new List<Workplane>();
		if (7u != 0)
		{
			_0023_003DzmdNzvs_pjc_EfYI2Vqz5dpk_003D(_0023_003Dz3keKASA_003D2);
		}
		List<Operation> _0023_003Dz3keKASA_003D3 = new List<Operation>();
		if (2u != 0)
		{
			_0023_003DziP3kKTEMTPDQ(_0023_003Dz3keKASA_003D3);
		}
		_0023_003Dz5aC_0024KwroZXnE(new List<Geometry>());
		_0023_003DzV5LO1d1UCpxC_00246_MZg_003D_003D(new List<Workplan>());
		_0023_003DzA2Von5vdmKtQ(new List<ToolPath>());
		_0023_003Dz1n3RtTKfcMEn(new List<BlockingProfile>());
		_0023_003DzoGSA_YFmfEpl(new MachineFunctions());
		_0023_003DzZa6VxMFfph7N = new List<BaseScripting>();
		_projectInterface = projectInterface;
		_toolInterface = toolInterface;
		_edgeInterface = edgeInterface;
		_configurationInterface = configurationInterface;
		_supportInterface = supportInterface;
		_options = AppInfo.CurrentOptions<UI00Options>();
		_reportServices = reportServices;
		_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D = isSubprogram;
		ActiveX = 0.0;
		ActiveY = 0.0;
		ActiveZ = 0.0;
		_0023_003Dzwlal3EX7MKh692I9_0024iXByDBTjDBx(new ToolCorrection());
		_0023_003DzZGra6ZgrZzgF(0.0);
		_activePriority = priority;
		_errorString = string.Empty;
		_isMillimeter = true;
		_0023_003DzwXhwAQVfEqz9 = new ProcessServices(_projectInterface);
		if (_projectInterface != null)
		{
			_isMillimeter = _projectInterface.IsMM;
			foreach (MainWorkplan item in _projectInterface.GetList<MainWorkplan>())
			{
				Workplan workplan = new Workplan(_projectInterface, item);
				Workplans.Add(workplan);
				if (item.Key == workplanID)
				{
					_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(workplan);
				}
			}
			if (ActiveWorkplan == null)
			{
				Workplan workplan2 = null;
				if (workplanID != null && workplanID.IsValid)
				{
					workplan2 = new Workplan(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708800), _projectInterface, workplanID);
					Workplans.Add(workplan2);
				}
				else
				{
					_0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D _0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D = new _0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D
					{
						_0023_003Dzj2E8O1eM93x4dJmf2w_003D_003D = (_projectInterface.GetWorkplan() as MainWorkplan)
					};
					if (_0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D._0023_003Dzj2E8O1eM93x4dJmf2w_003D_003D == null)
					{
						_0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D._0023_003Dzj2E8O1eM93x4dJmf2w_003D_003D = new MainWorkplan(new MainWorkplan
						{
							Name = LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708777), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990))
						});
						_projectInterface.AddMainWorkplan(ref _0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D._0023_003Dzj2E8O1eM93x4dJmf2w_003D_003D, this);
						workplan2 = new Workplan(_projectInterface, _0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D._0023_003Dzj2E8O1eM93x4dJmf2w_003D_003D);
						Workplans.Add(workplan2);
					}
					else
					{
						workplan2 = Workplans.Find(_0023_003DzP_RRWjqskF2tegdl7QfHxLg_003D._0023_003DzrE6DPJtmRepq5fNPRw_003D_003D);
					}
				}
				_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(workplan2);
			}
			foreach (WorkPiece item2 in _projectInterface.GetList<WorkPiece>())
			{
				Workpiece workpiece = new Workpiece(_projectInterface, item2);
				Workpieces.Add(workpiece);
				if (item2.Key == workpieceID)
				{
					_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(workpiece);
				}
			}
			if (ActiveWorkpiece == null && Workpieces.Count > 0)
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(Workpieces.Last());
			}
			foreach (Plane item3 in _projectInterface.GetList<Plane>())
			{
				Workplane workplane = new Workplane(_projectInterface, item3);
				Workplanes.Add(workplane);
				if (planeID != null && planeID.IsValid && planeID == item3.Key)
				{
					_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(workplane);
				}
			}
			if (ActiveWorkplane == null)
			{
				_0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D _0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D = new _0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D
				{
					_0023_003Dzf54DH27vqdpn = null
				};
				if (ActiveWorkpiece != null)
				{
					_0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D._0023_003Dzf54DH27vqdpn = _projectInterface.Find(delegate(Plane _0023_003DzuphY4HU_003D)
					{
						_ = 3;
						if (5 == 0)
						{
						}
						if (_0023_003DzuphY4HU_003D.Type == PlaneType.Top)
						{
							_ = 0;
							if (7 == 0)
							{
							}
							ReferenceKey workpieceID2 = _0023_003DzuphY4HU_003D.WorkpieceID;
							_ = 6;
							if (4 == 0)
							{
							}
							return workpieceID2 == ActiveWorkpiece.ReferenceKey;
						}
						return false;
					});
					if (_0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D._0023_003Dzf54DH27vqdpn != null)
					{
						_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(Workplanes.Find(_0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D._0023_003Dzf7ZVBCcUNjaJfFHa5Q_003D_003D));
					}
				}
				if (ActiveWorkplane == null)
				{
					_0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D._0023_003Dzf54DH27vqdpn = new Plane(PlaneType.NotDefined, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, new ReferenceKey(), new ReferenceKey());
					_0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D._0023_003Dzf54DH27vqdpn.Name = string.Empty;
					_projectInterface.AddPlane(ref _0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D._0023_003Dzf54DH27vqdpn, this);
					_0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D = new Workplane(string.Empty, _projectInterface, _0023_003DznpjrP7rsbqw3ovHUyO1VkXY_003D._0023_003Dzf54DH27vqdpn);
					_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(_0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D);
				}
			}
		}
		_0023_003DzobjG82GyRO6N0HSR2g_003D_003D = null;
		_0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D = 0;
		_0023_003DzYuaGHaZ5av3_0024E_00243Rf_U6U2c_003D = true;
		_0023_003DznYqeEHrk04Im = true;
		_0023_003Dza01J2_0024_eD1UHFNzD7GMZCIgS2IAk = TypeOfExtremaMachiningAttributePosition.None;
		_0023_003Dz5iq5gpuO12MFlZruNlpTZI0_003D = null;
		_0023_003DzVLzphqXIRk5e();
		_0023_003DzKarjU_hb9IpE();
		_0023_003Dzc_0024_Iatgd9V_i();
		_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D = new Dictionary<string, ProjectInterface>();
		_0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D = new Dictionary<string, ReferenceKey>();
		_0023_003DzULPFoR3ylpZ_0024GhXQfxwoABs_003D = new List<TechnologyTargetEntity>();
		_0023_003Dzag4iMeQOAldNe80NovqNVZU_003D = new List<TechnologyExecutableInfo>();
		_0023_003DzZOWKgSslqFdz2EEA8WcrVnA_003D = null;
	}

	internal void _0023_003Dzb8DIS5dY6ERFKdwZTxz_G_w_003D(List<Workpiece> _0023_003Dz3keKASA_003D)
	{
		if (5u != 0)
		{
			_0023_003DzFJLQ_loL_gvsEE3VJw4d7ikh5fhX = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzmdNzvs_pjc_EfYI2Vqz5dpk_003D(List<Workplane> _0023_003Dz3keKASA_003D)
	{
		if (7u != 0)
		{
			_0023_003Dz3DLnYG4Ffrdmjsix87DesemEaGZq = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DziP3kKTEMTPDQ(List<Operation> _0023_003Dz3keKASA_003D)
	{
		if (2u != 0)
		{
			_0023_003DzDAbp_0024VHHPqpLTMRJnw_003D_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dz5aC_0024KwroZXnE(List<Geometry> _0023_003Dz3keKASA_003D)
	{
		if (2u != 0)
		{
			_0023_003DztN7K0TSc9eZhyIPb1A_003D_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzV5LO1d1UCpxC_00246_MZg_003D_003D(List<Workplan> _0023_003Dz3keKASA_003D)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzWLTXG623cvUF_oapSSUJXshLKfvF = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzA2Von5vdmKtQ(List<ToolPath> _0023_003Dz3keKASA_003D)
	{
		if (6u != 0)
		{
			_0023_003DzZzJjL2dHgjEueKUoGQqoQgA_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dz1n3RtTKfcMEn(List<BlockingProfile> _0023_003Dz3keKASA_003D)
	{
		if (4u != 0)
		{
			_0023_003DzG5spAiR81S8uR0Uo__nSKCg_003D = _0023_003Dz3keKASA_003D;
		}
	}

	private void _0023_003DzVLzphqXIRk5e()
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzpDEAL9o818dC = false;
		}
		if (4u != 0)
		{
			_0023_003DzYX5LSNnkrXcH9fDAZbJxBRo_003D = WorkPlaneCategory.UNKNOWN;
		}
		if (_configurationInterface != null)
		{
			Machine configurationMachine = _configurationInterface.GetConfigurationMachine(clone: false);
			if (true)
			{
				_0023_003DzRE0vH8WCFzM6 = configurationMachine;
			}
			if (_0023_003DzRE0vH8WCFzM6 != null)
			{
				_0023_003DzpDEAL9o818dC = true;
				_0023_003DzYX5LSNnkrXcH9fDAZbJxBRo_003D = ConfigurationFixtureSetup.GetActiveWorkPlaneCategory(_0023_003DzRE0vH8WCFzM6, _projectInterface);
			}
		}
	}

	private void _0023_003DzKarjU_hb9IpE()
	{
		if (7u != 0)
		{
			_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D = false;
		}
		if (_supportInterface == null)
		{
			return;
		}
		List<MachineElementBase> list = _supportInterface.GetList();
		List<MachineElementBase> list2;
		if (7u != 0)
		{
			list2 = list;
		}
		if (list2 != null && list2.Count > 0)
		{
			if (4u != 0)
			{
				_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D = true;
			}
		}
	}

	private void _0023_003Dzc_0024_Iatgd9V_i()
	{
		_ = 1;
		if (8 == 0)
		{
		}
		ActiveMachineFunctions.HoodEnabled = true;
		_ = 6;
		if (1 == 0)
		{
		}
		ActiveMachineFunctions.MotorizedHoodEnabled = true;
	}

	private string _0023_003DzELuN7RPaBKEl<T>(string _0023_003Dzh041LGY_003D)
	{
		int num;
		if (uint.MaxValue != 0)
		{
			num = 0;
		}
		string text;
		if (true)
		{
			text = _0023_003Dzh041LGY_003D;
		}
		Type typeFromHandle = typeof(T);
		Type type;
		if (8u != 0)
		{
			type = typeFromHandle;
		}
		if (type != null && !string.IsNullOrEmpty(_0023_003Dzh041LGY_003D))
		{
			if (type == typeof(Workpiece))
			{
				num = Workpieces.Count + 1;
			}
			else if (type == typeof(Workplane))
			{
				num = Workplanes.Count + 1;
			}
			else if (type == typeof(Operation))
			{
				num = Operations.Count + 1;
			}
			else if (type == typeof(Geometry))
			{
				num = Geometries.Count + 1;
			}
			else if (type == typeof(Workplan))
			{
				num = Workplans.Count + 1;
			}
			else if (type == typeof(ToolPath))
			{
				num = ToolPaths.Count + 1;
			}
			if (type == typeof(BlockingProfile))
			{
				num = BlockingProfiles.Count + 1;
			}
			text = _0023_003Dzh041LGY_003D + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708756) + num + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708748);
			while (Exist(text, exist: true, throwException: false) != null)
			{
				num++;
				text = _0023_003Dzh041LGY_003D + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708756) + num + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708748);
			}
		}
		return text;
	}

	protected BaseScripting Exist(string name, bool exist, bool throwException = true)
	{
		_0023_003DzcsFxVaWoKx040xiIiBrabW4_003D _0023_003DzcsFxVaWoKx040xiIiBrabW4_003D = new _0023_003DzcsFxVaWoKx040xiIiBrabW4_003D();
		_0023_003DzcsFxVaWoKx040xiIiBrabW4_003D CS_0024_003C_003E8__locals14;
		if (8u != 0)
		{
			CS_0024_003C_003E8__locals14 = _0023_003DzcsFxVaWoKx040xiIiBrabW4_003D;
		}
		if (7u != 0)
		{
			CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D = name;
		}
		BaseScripting baseScripting;
		if (8u != 0)
		{
			baseScripting = null;
		}
		if (CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D == string.Empty && throwException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708740);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (7u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		if (_0023_003DzcdN7paV29v7STct_Vw_003D_003D.ContainsKey(CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D) && exist)
		{
			PlaneType value;
			if (0 == 0)
			{
				value = PlaneType.NotDefined;
			}
			if (_0023_003DzcdN7paV29v7STct_Vw_003D_003D.TryGetValue(CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D, out value))
			{
				List<Workplane>.Enumerator enumerator = Workplanes.GetEnumerator();
				List<Workplane>.Enumerator enumerator2;
				if (3u != 0)
				{
					enumerator2 = enumerator;
				}
				try
				{
					while (enumerator2.MoveNext())
					{
						Workplane current = enumerator2.Current;
						Plane plane = _projectInterface.Get(current.ReferenceKey) as Plane;
						if (plane.WorkpieceID == ActiveWorkpiece.ReferenceKey && plane.Type == value)
						{
							baseScripting = current;
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
				}
			}
		}
		if (baseScripting == null)
		{
			baseScripting = Workplanes.Find(CS_0024_003C_003E8__locals14._0023_003DzRtdbgly3tKXNdlKxNA_003D_003D);
			if (baseScripting != null && (_projectInterface.Get(baseScripting.ReferenceKey) as Plane).WorkpieceID != ActiveWorkpiece.ReferenceKey)
			{
				baseScripting = null;
			}
		}
		if (baseScripting == null)
		{
			baseScripting = Workpieces.Find(CS_0024_003C_003E8__locals14._0023_003DzarOZGDrIPCPsNiiMZA_003D_003D);
		}
		if (baseScripting == null)
		{
			baseScripting = Workplans.Find(delegate(Workplan _0023_003DzXufAk8k_003D)
			{
				_ = 4;
				if (2 == 0)
				{
				}
				string name2 = _0023_003DzXufAk8k_003D.Name;
				_ = 2;
				if (2 == 0)
				{
				}
				return name2 == CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D;
			});
		}
		if (baseScripting == null)
		{
			baseScripting = Operations.Find(delegate(Operation _0023_003DzXufAk8k_003D)
			{
				_ = 5;
				if (7 == 0)
				{
				}
				string name2 = _0023_003DzXufAk8k_003D.Name;
				_ = 1;
				if (1 == 0)
				{
				}
				return name2 == CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D;
			});
		}
		if (baseScripting == null)
		{
			baseScripting = Geometries.Find(CS_0024_003C_003E8__locals14._0023_003DzYSTMmGCXB5Lo3Zl_Pw_003D_003D);
		}
		if (baseScripting == null)
		{
			baseScripting = ToolPaths.Find(CS_0024_003C_003E8__locals14._0023_003DzD0N0kMFuFA7oauirIw_003D_003D);
		}
		if (baseScripting == null)
		{
			baseScripting = BlockingProfiles.Find(CS_0024_003C_003E8__locals14._0023_003DzAnqoHnk_9swNCtdbOw_003D_003D);
		}
		if (baseScripting == null)
		{
			baseScripting = _0023_003DzZa6VxMFfph7N.Find(CS_0024_003C_003E8__locals14._0023_003DzS3o4HEtfqm_ggITYzQ_003D_003D);
		}
		if (exist && baseScripting == null && throwException)
		{
			string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702729);
			string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters2 = new string[1] { CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D };
			throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, null, parameters2);
		}
		if (!exist && baseScripting != null && throwException)
		{
			string localizationKey3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702698);
			string localizationModuleName3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters2 = new string[1] { CS_0024_003C_003E8__locals14._0023_003DzJ3hfjPs_003D };
			throw ExceptionManager.CreateException(localizationKey3, localizationModuleName3, ExceptionType.Exception, null, parameters2);
		}
		return baseScripting;
	}

	private BaseScripting _0023_003DzCtl4R_E_003D(int _0023_003DzWOoFuVE_003D, Type _0023_003Dz3JKs8Mw_003D)
	{
		if (_0023_003DzWOoFuVE_003D < 0)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708709), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		}
		if (_0023_003Dz3JKs8Mw_003D != null)
		{
			BaseScripting baseScripting;
			if (8u != 0)
			{
				baseScripting = null;
			}
			if (_0023_003Dz3JKs8Mw_003D == typeof(Workpiece) || _0023_003Dz3JKs8Mw_003D.IsSubclassOf(typeof(Workpiece)))
			{
				if (_0023_003DzWOoFuVE_003D < Workpieces.Count)
				{
					Workpiece workpiece = Workpieces[_0023_003DzWOoFuVE_003D];
					if (true)
					{
						baseScripting = workpiece;
					}
				}
			}
			else if (_0023_003Dz3JKs8Mw_003D == typeof(Workplane) || _0023_003Dz3JKs8Mw_003D.IsSubclassOf(typeof(Workplane)))
			{
				if (_0023_003DzWOoFuVE_003D < Workplanes.Count)
				{
					Workplane workplane = Workplanes[_0023_003DzWOoFuVE_003D];
					if (8u != 0)
					{
						baseScripting = workplane;
					}
				}
			}
			else if (_0023_003Dz3JKs8Mw_003D == typeof(Operation) || _0023_003Dz3JKs8Mw_003D.IsSubclassOf(typeof(Operation)))
			{
				if (_0023_003DzWOoFuVE_003D < Operations.Count)
				{
					Operation operation = Operations[_0023_003DzWOoFuVE_003D];
					if (2u != 0)
					{
						baseScripting = operation;
					}
				}
			}
			else if (_0023_003Dz3JKs8Mw_003D == typeof(Geometry) || _0023_003Dz3JKs8Mw_003D.IsSubclassOf(typeof(Geometry)))
			{
				if (_0023_003DzWOoFuVE_003D < Geometries.Count)
				{
					Geometry geometry = Geometries[_0023_003DzWOoFuVE_003D];
					if (true)
					{
						baseScripting = geometry;
					}
				}
			}
			else if (_0023_003Dz3JKs8Mw_003D == typeof(ToolPath) || _0023_003Dz3JKs8Mw_003D.IsSubclassOf(typeof(ToolPath)))
			{
				if (_0023_003DzWOoFuVE_003D < ToolPaths.Count)
				{
					baseScripting = ToolPaths[_0023_003DzWOoFuVE_003D];
				}
			}
			else
			{
				if (!(_0023_003Dz3JKs8Mw_003D == typeof(BlockingProfile)) && !_0023_003Dz3JKs8Mw_003D.IsSubclassOf(typeof(BlockingProfile)))
				{
					string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708675);
					string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
					object[] parameters = new string[1] { _0023_003Dz3JKs8Mw_003D.Name };
					throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
				}
				if (_0023_003DzWOoFuVE_003D < BlockingProfiles.Count)
				{
					baseScripting = BlockingProfiles[_0023_003DzWOoFuVE_003D];
				}
			}
			if (baseScripting == null)
			{
				string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708387);
				string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
				object[] parameters = new string[2]
				{
					_0023_003DzWOoFuVE_003D.ToString(),
					_0023_003Dz3JKs8Mw_003D.Name
				};
				throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, null, parameters);
			}
			return baseScripting;
		}
		return null;
	}

	private void _0023_003DzbR_SDIIiZpoioby4m8AYjSM0K0qQkmUIyw_003D_003D(Workpiece _0023_003DzJ0pwS2B_euP_00243hCEWA_003D_003D)
	{
		List<Plane> workpiecePlanes = _projectInterface.GetWorkpiecePlanes(_0023_003DzJ0pwS2B_euP_00243hCEWA_003D_003D.ReferenceKey);
		List<Plane> list;
		if (8u != 0)
		{
			list = workpiecePlanes;
		}
		if (list == null)
		{
			return;
		}
		List<Plane>.Enumerator enumerator = list.GetEnumerator();
		List<Plane>.Enumerator enumerator2;
		if (3u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				Plane current = enumerator2.Current;
				Plane plane;
				if (true)
				{
					plane = current;
				}
				Workplane workplane = new Workplane(plane.Type.ToString(), _projectInterface, plane);
				Workplanes.Add(workplane);
				if (plane.Type == PlaneType.Top)
				{
					_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(workplane);
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
	}

	private void _0023_003Dz_0024IbzEN9jdWmF(Operation _0023_003DzIDjFPYA_003D)
	{
		if (_0023_003DzIDjFPYA_003D != null)
		{
			ReferenceKey referenceKey = _0023_003DzIDjFPYA_003D.ReferenceKey;
			ReferenceKey executableKey;
			if (3u != 0)
			{
				executableKey = referenceKey;
			}
			_0023_003DzwXhwAQVfEqz9.Add(executableKey);
		}
	}

	internal void _0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(Workpiece _0023_003Dz3keKASA_003D)
	{
		if (true)
		{
			_0023_003DzAi6YVcSv6ZvAfHo453ZinHhWfY_F = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(Workplane _0023_003Dz3keKASA_003D)
	{
		if (6u != 0)
		{
			_0023_003DzP9cJtouHnBtXuAEvl6ZKh5rDQtuV = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dzdzv73cHjrWgk(Operation _0023_003Dz3keKASA_003D)
	{
		if (0 == 0)
		{
			_0023_003Dz14K804T49ob5EgjqyqPZHeU_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzgGGOgZJ8OzTN(Geometry _0023_003Dz3keKASA_003D)
	{
		if (6u != 0)
		{
			_0023_003DzRdLWy0lhE7FZWSQSf4Yf_cI_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dz8DhcByEE_0024hyBLHSgZg_003D_003D(LeadInOut _0023_003Dz3keKASA_003D)
	{
		if (7u != 0)
		{
			_0023_003DzrDBDqOvuNV0EFdWN_lJJqtFR7_0024yN = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzoGSA_YFmfEpl(MachineFunctions _0023_003Dz3keKASA_003D)
	{
		if (6u != 0)
		{
			_0023_003Dzel3fcE5QEW2cODbmcZ1EkQI_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DziVcbCJGQSVJK(Pattern _0023_003Dz3keKASA_003D)
	{
		if (true)
		{
			_0023_003Dz0YScmPKi99RxiRJLrX4WjkI_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(ToolPath _0023_003Dz3keKASA_003D)
	{
		if (true)
		{
			_0023_003DzS2XyoyIr47Nb9riV0049Nw1t7Nx5 = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(Workplan _0023_003Dz3keKASA_003D)
	{
		if (8u != 0)
		{
			_0023_003Dz3VQi5hf2oSkL0K_0024DYyYAuRfcaKcx = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dzwlal3EX7MKh692I9_0024iXByDBTjDBx(ToolCorrection _0023_003Dz3keKASA_003D)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzZntYNzIKqKc4_0024GlSwyCQoAfKYgWxx_0024CZNw_003D_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzGqmSgWSZ_0024qJEUO_unQ_003D_003D(BlockingProfile _0023_003Dz3keKASA_003D)
	{
		if (7u != 0)
		{
			_0023_003DzI3_0024oKNsyBTIVlBRVquNuRPw_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzZGra6ZgrZzgF(double _0023_003Dz3keKASA_003D)
	{
		if (4u != 0)
		{
			_0023_003DzOJzpR9HXrof0aWJUf1NvA3k_003D = _0023_003Dz3keKASA_003D;
		}
	}

	public Point CreatPoint(string name, double x, double y)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomCartesianPoint>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708351));
			if (0 == 0)
			{
				name = text;
			}
			Point point = new Point(name, _projectInterface);
			Point point2;
			if (4u != 0)
			{
				point2 = point;
			}
			point2.CreatePoint(x, y, ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(point2);
			_0023_003DzgGGOgZJ8OzTN(point2);
			ResetReferencePosition();
			return point2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708541)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Segment CreateSegment(string name, double startX, double startY, double endX, double endY)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomTrimmedCurve>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708529));
			if (0 == 0)
			{
				name = text;
			}
			Segment segment = new Segment(name, _projectInterface);
			Segment segment2;
			if (true)
			{
				segment2 = segment;
			}
			segment2.CreateSegment(startX, startY, endX, endY, ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(segment2);
			_0023_003DzgGGOgZJ8OzTN(segment2);
			ResetReferencePosition();
			return segment2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708514)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Arc CreateArc3Points(string name, double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomTrimmedCurve>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708500));
			if (4u != 0)
			{
				name = text;
			}
			Arc arc = new Arc(name, _projectInterface);
			Arc arc2;
			if (2u != 0)
			{
				arc2 = arc;
			}
			arc2.CreateArc3Points(p1X, p1Y, p2X, p2Y, p3X, p3Y, ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(arc2);
			_0023_003DzgGGOgZJ8OzTN(arc2);
			ResetReferencePosition();
			return arc2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708476)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Arc CreateArc2PointRadius(string name, double startX, double startY, double endX, double endY, double radius, bool isClockwise, bool isOver180)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomTrimmedCurve>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708500));
			if (uint.MaxValue != 0)
			{
				name = text;
			}
			Arc arc = new Arc(name, _projectInterface);
			Arc arc2;
			if (5u != 0)
			{
				arc2 = arc;
			}
			arc2.CreateArc2PointRadius(startX, startY, endX, endY, radius, isClockwise, isOver180, ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(arc2);
			_0023_003DzgGGOgZJ8OzTN(arc2);
			ResetReferencePosition();
			return arc2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708476)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Arc CreateArc2PointCenter(string name, double startX, double startY, double endX, double endY, double centerX, double centerY, bool isClockwise)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomTrimmedCurve>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708500));
			if (2u != 0)
			{
				name = text;
			}
			Arc arc = new Arc(name, _projectInterface);
			Arc arc2;
			if (7u != 0)
			{
				arc2 = arc;
			}
			arc2.CreateArc2PointCenter(startX, startY, endX, endY, centerX, centerY, isClockwise, ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(arc2);
			_0023_003DzgGGOgZJ8OzTN(arc2);
			ResetReferencePosition();
			return arc2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708476)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Arc CreateArcCenterAngle(string name, double startX, double startY, double centerX, double centerY, double angle)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomTrimmedCurve>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708500));
			if (5u != 0)
			{
				name = text;
			}
			Arc arc = new Arc(name, _projectInterface);
			Arc arc2;
			if (8u != 0)
			{
				arc2 = arc;
			}
			arc2.CreateArcCenterAngle(startX, startY, centerX, centerY, MathUtility.DegreeToRad(angle), ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(arc2);
			_0023_003DzgGGOgZJ8OzTN(arc2);
			ResetReferencePosition();
			return arc2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708476)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Circle CreateCircleCenterRadius(string name, double centerX, double centerY, double radius, bool isClockwise)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomCircle>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708466));
			if (uint.MaxValue != 0)
			{
				name = text;
			}
			Circle circle = new Circle(name, _projectInterface);
			Circle circle2;
			if (uint.MaxValue != 0)
			{
				circle2 = circle;
			}
			circle2.CreateCircleCenterRadius(centerX, centerY, radius, ActiveWorkplane, isClockwise, _activeReferecePosition);
			Geometries.Add(circle2);
			_0023_003DzgGGOgZJ8OzTN(circle2);
			ResetReferencePosition();
			return circle2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708445)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Circle CreateCircleCenterRadius(string name, double centerX, double centerY, double radius)
	{
		_ = 1;
		if (2 == 0)
		{
		}
		_ = -1;
		if (2 == 0)
		{
		}
		_ = 6;
		if (8 == 0)
		{
		}
		return CreateCircleCenterRadius(name, centerX, centerY, radius, isClockwise: false);
	}

	public Circle CreateCircleCenterPoint(string name, double centerX, double centerY, double pointX, double pointY, bool isClockwise)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomCircle>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708466));
			if (4u != 0)
			{
				name = text;
			}
			Circle circle = new Circle(name, _projectInterface);
			Circle circle2;
			if (6u != 0)
			{
				circle2 = circle;
			}
			circle2.CreateCircleCenterPoint(centerX, centerY, pointX, pointY, ActiveWorkplane, isClockwise, _activeReferecePosition);
			Geometries.Add(circle2);
			_0023_003DzgGGOgZJ8OzTN(circle2);
			ResetReferencePosition();
			return circle2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708445)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Circle CreateCircleCenterPoint(string name, double centerX, double centerY, double pointX, double pointY)
	{
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 4;
		if (6 == 0)
		{
		}
		_ = 5;
		if (5 == 0)
		{
		}
		return CreateCircleCenterPoint(name, centerX, centerY, pointX, pointY, isClockwise: false);
	}

	public Ellipse CreateEllipseCenterAxes(string name, double centerX, double centerY, double majorRadius, double minorRadius, double angle)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomEllipse>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708434));
			if (3u != 0)
			{
				name = text;
			}
			Ellipse ellipse = new Ellipse(name, _projectInterface);
			Ellipse ellipse2;
			if (3u != 0)
			{
				ellipse2 = ellipse;
			}
			ellipse2.CreateEllipseCenterAxes(centerX, centerY, majorRadius, minorRadius, angle, ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(ellipse2);
			_0023_003DzgGGOgZJ8OzTN(ellipse2);
			ResetReferencePosition();
			return ellipse2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707134)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Polyline CreatePolyline(string name, double startX, double startY)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomCompositeCurve>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707120));
			if (7u != 0)
			{
				name = text;
			}
			Polyline polyline = new Polyline(name, _projectInterface);
			Polyline polyline2;
			if (uint.MaxValue != 0)
			{
				polyline2 = polyline;
			}
			polyline2.CreatePolylineStartPoint(startX, startY, ActiveWorkplane, _activeReferecePosition);
			Geometries.Add(polyline2);
			_0023_003DzgGGOgZJ8OzTN(polyline2);
			ResetReferencePosition();
			RegisterForFlush(ActiveGeometry);
			return polyline2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Polyline AddSegmentToPolyline(double endX, double endY, string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).AddSegment(nameElement, endX, endY);
			Geometry activeGeometry = ActiveGeometry;
			if (uint.MaxValue != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (3u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddArc3PointsToPolyline(double p2X, double p2Y, double p3X, double p3Y, string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).AddArc3Points(nameElement, p2X, p2Y, p3X, p3Y);
			Geometry activeGeometry = ActiveGeometry;
			if (0 == 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (4u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddArc2PointCenterToPolyline(double endX, double endY, double centerX, double centerY, bool isClockwise, string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).AddArc2PointCenter(nameElement, endX, endY, centerX, centerY, isClockwise);
			Geometry activeGeometry = ActiveGeometry;
			if (6u != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (true)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (2u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddArc2PointRadiusToPolyline(double endX, double endY, double radius, bool isClockwise, bool isOver180, string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).AddArc2PointRadius(nameElement, endX, endY, radius, isClockwise, isOver180);
			Geometry activeGeometry = ActiveGeometry;
			if (4u != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (6u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (3u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddArcCenterAngleToPolyline(double centerX, double centerY, double angle, string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).AddArcCenterAngle(nameElement, centerX, centerY, MathUtility.DegreeToRad(angle));
			Geometry activeGeometry = ActiveGeometry;
			if (uint.MaxValue != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (3u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (2u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddSegmentTanToPolyline(double length, string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).AddSegmentTan(nameElement, length);
			Geometry activeGeometry = ActiveGeometry;
			if (4u != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (true)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddArcTanToPolyline(double endX, double endY, int option, string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).AddArcTan(nameElement, endX, endY, option);
			Geometry activeGeometry = ActiveGeometry;
			if (uint.MaxValue != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (8u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddFilletToPolyline(double radius, int option, string nameElement)
	{
		try
		{
			FilletType num = _0023_003DzsWJ3VRWpMkR_8_0024RvzQ_003D_003D(option);
			FilletType option2 = default(FilletType);
			if (0 == 0)
			{
				option2 = num;
			}
			(ActiveGeometry as Polyline).AddFillet(nameElement, radius, option2);
			Geometry activeGeometry = ActiveGeometry;
			if (8u != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (2u != 0)
			{
				return result;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707078);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[3]
			{
				(ActiveGeometry as Polyline).Count.ToString(),
				((ActiveGeometry as Polyline).Count + 1).ToString(),
				ActiveGeometry.Name
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline AddChamferToPolyline(double length1, double length2, int option, string nameElement)
	{
		try
		{
			ChamferType num = _0023_003DzMCzNT_00243X5n1ZW73_nw_003D_003D(option);
			ChamferType option2;
			if (4u != 0)
			{
				option2 = num;
			}
			(ActiveGeometry as Polyline).AddChamfer(nameElement, length1, length2, option2);
			Geometry activeGeometry = ActiveGeometry;
			if (2u != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (true)
			{
				return result;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707036);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[3]
			{
				(ActiveGeometry as Polyline).Count.ToString(),
				((ActiveGeometry as Polyline).Count + 1).ToString(),
				ActiveGeometry.Name
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Polyline ClosePolyline(string nameElement)
	{
		try
		{
			(ActiveGeometry as Polyline).Close(nameElement);
			Geometry activeGeometry = ActiveGeometry;
			if (4u != 0)
			{
				RegisterForFlush(activeGeometry);
			}
			Polyline result = ActiveGeometry as Polyline;
			if (3u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Polyline result2;
		return result2;
	}

	public Geometry SelectGeometry(string name)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			Geometry _0023_003Dz3keKASA_003D = Exist(name, exist: true) as Geometry;
			if (true)
			{
				_0023_003DzgGGOgZJ8OzTN(_0023_003Dz3keKASA_003D);
			}
			ReferenceKey referenceKey = ActiveGeometry.ReferenceKey;
			if (uint.MaxValue != 0)
			{
				_0023_003DzWnkwJiirM6X_0024yetmrQ_003D_003D(referenceKey);
			}
			return ActiveGeometry;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707247);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Geometry SelectGeometry(int index)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			Geometry _0023_003Dz3keKASA_003D = _0023_003DzCtl4R_E_003D(index, typeof(Geometry)) as Geometry;
			if (4u != 0)
			{
				_0023_003DzgGGOgZJ8OzTN(_0023_003Dz3keKASA_003D);
			}
			ReferenceKey referenceKey = ActiveGeometry.ReferenceKey;
			if (true)
			{
				_0023_003DzWnkwJiirM6X_0024yetmrQ_003D_003D(referenceKey);
			}
			return ActiveGeometry;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707201);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	private void _0023_003DzWnkwJiirM6X_0024yetmrQ_003D_003D(ReferenceKey _0023_003Dz2bCKbrM_003D)
	{
		GeomGeometry obj = _projectInterface.Get(_0023_003Dz2bCKbrM_003D) as GeomGeometry;
		GeomGeometry geomGeometry;
		if (5u != 0)
		{
			geomGeometry = obj;
		}
		Plane obj2 = _projectInterface.Get(geomGeometry.PlaneID) as Plane;
		Plane plane;
		if (6u != 0)
		{
			plane = obj2;
		}
		if (plane != null)
		{
			string text;
			if (3u != 0)
			{
				text = null;
			}
			text = ((!plane.IsStandard) ? plane.Name : plane.Type.ToString());
			SelectWorkplane(text);
		}
	}

	public void DeleteGeometry(string name)
	{
		try
		{
			_0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D _0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D = new _0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D();
			_0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D _0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D2;
			if (5u != 0)
			{
				_0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D2 = _0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D;
			}
			Geometry _0023_003Dzfqxf7hIPL6sd = Exist(name, exist: true) as Geometry;
			if (0 == 0)
			{
				_0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D2._0023_003Dzfqxf7hIPL6sd = _0023_003Dzfqxf7hIPL6sd;
			}
			_0023_003DzTX7wzNM0R89M.RemoveAll(_0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D2._0023_003DzIOmPczO8tqLUaFm_Zw_003D_003D);
			if (7u != 0)
			{
				Flush();
			}
			GeomGeometry geometry = _projectInterface.Get(_0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D2._0023_003Dzfqxf7hIPL6sd.ReferenceKey) as GeomGeometry;
			_projectInterface.DeleteGeometry(geometry, forceDelete: true, this);
			Geometries.Remove(_0023_003Dz9V_0024m0xehUZ8_x_00246I2bakTB0_003D2._0023_003Dzfqxf7hIPL6sd);
			if (Geometries.Count > 0)
			{
				_0023_003DzgGGOgZJ8OzTN(Geometries[Geometries.Count - 1]);
			}
			else
			{
				_0023_003DzgGGOgZJ8OzTN(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707156);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteGeometry(int index)
	{
		try
		{
			_0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D _0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D = new _0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D();
			_0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D _0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D2;
			if (5u != 0)
			{
				_0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D2 = _0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D;
			}
			Geometry _0023_003Dzfqxf7hIPL6sd = _0023_003DzCtl4R_E_003D(index, typeof(Geometry)) as Geometry;
			if (4u != 0)
			{
				_0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D2._0023_003Dzfqxf7hIPL6sd = _0023_003Dzfqxf7hIPL6sd;
			}
			_0023_003DzTX7wzNM0R89M.RemoveAll(_0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D2._0023_003DzIOmPczO8tqLUaFm_Zw_003D_003D);
			if (4u != 0)
			{
				Flush();
			}
			GeomGeometry geometry = _projectInterface.Get(_0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D2._0023_003Dzfqxf7hIPL6sd.ReferenceKey) as GeomGeometry;
			_projectInterface.DeleteGeometry(geometry, forceDelete: true, this);
			Geometries.Remove(_0023_003DzfoLgW3qw3TIzRrIZeoAKn3k_003D2._0023_003Dzfqxf7hIPL6sd);
			if (Geometries.Count > 0)
			{
				_0023_003DzgGGOgZJ8OzTN(Geometries[Geometries.Count - 1]);
			}
			else
			{
				_0023_003DzgGGOgZJ8OzTN(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706854);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	private void _0023_003DzBJYL2ljkevk4RP5NZV5Jyu8_003D(string _0023_003DzJ3hfjPs_003D, string[] _0023_003DzO3bwHbMJTL_00249)
	{
		if (uint.MaxValue != 0)
		{
			Flush();
		}
		if (7u != 0)
		{
			DeleteGeometry(_0023_003DzJ3hfjPs_003D);
		}
		string[] array;
		if (5u != 0)
		{
			array = _0023_003DzO3bwHbMJTL_00249;
		}
		foreach (string name in array)
		{
			DeleteGeometry(name);
		}
	}

	private void _0023_003Dzfm_0024Yzjh9kop4KfDdTjJUg_0_003D()
	{
		if (6u != 0)
		{
			Flush();
		}
		if (_0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D != null && _0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D.ReferenceKey != null && _0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D.ReferenceKey.IsValid)
		{
			Plane obj = _projectInterface.Get(_0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D.ReferenceKey) as Plane;
			Plane plane;
			if (6u != 0)
			{
				plane = obj;
			}
			_projectInterface.DeletePlane(plane, this);
			if (5u != 0)
			{
				_0023_003DzyIRzvF5GHet1trwyxXj9i_0024U_003D = null;
			}
		}
	}

	public Workpiece CreateFinishedWorkpieceBox(string name, double dx, double dy, double dz)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003DzrezAJ_Ob_pAQpKTl_0024A_003D_003D(name);
			if (7u != 0)
			{
				name = text;
			}
			object obj = ConvertExpressionValueToCurrentUnit(dx, FisicalUnitType.Lenght, null);
			object dx2;
			if (2u != 0)
			{
				dx2 = obj;
			}
			object dy2 = ConvertExpressionValueToCurrentUnit(dy, FisicalUnitType.Lenght, null);
			object dz2 = ConvertExpressionValueToCurrentUnit(dz, FisicalUnitType.Lenght, null);
			Workpiece workpiece = new Workpiece(name, _projectInterface);
			workpiece.CreateFinishedWorkpieceBox(dx2, dy2, dz2);
			Workpieces.Add(workpiece);
			_0023_003DzbR_SDIIiZpoioby4m8AYjSM0K0qQkmUIyw_003D_003D(workpiece);
			_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(workpiece);
			_0023_003Dzfm_0024Yzjh9kop4KfDdTjJUg_0_003D();
			return workpiece;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706805);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706765)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workpiece CreateFinishedWorkpieceFromExtrusion(string name, double dz, params string[] internalProfiles)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003DzrezAJ_Ob_pAQpKTl_0024A_003D_003D(name);
			if (8u != 0)
			{
				name = text;
			}
			List<Geometry> list = new List<Geometry>();
			List<Geometry> list2;
			if (7u != 0)
			{
				list2 = list;
			}
			foreach (string name2 in internalProfiles)
			{
				list2.Add(Exist(name2, exist: true) as Geometry);
			}
			object dz2 = ConvertExpressionValueToCurrentUnit(dz, FisicalUnitType.Lenght, null);
			Workpiece workpiece = new Workpiece(name, _projectInterface);
			workpiece.CreateFinishedWorkpieceFromExtrusion(ActiveGeometry, dz2, list2);
			Workpieces.Add(workpiece);
			_0023_003DzbR_SDIIiZpoioby4m8AYjSM0K0qQkmUIyw_003D_003D(workpiece);
			_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(workpiece);
			_0023_003DzBJYL2ljkevk4RP5NZV5Jyu8_003D(ActiveGeometry.Name, internalProfiles);
			_0023_003Dzfm_0024Yzjh9kop4KfDdTjJUg_0_003D();
			return workpiece;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706805);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706755)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workpiece CreateRawWorkpieceBox(string name, double dx, double dy, double dz, double bx = 0.0, double by = 0.0, double bz = 0.0)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			Workpiece obj = Exist(name, exist: true) as Workpiece;
			Workpiece workpiece;
			if (8u != 0)
			{
				workpiece = obj;
			}
			workpiece.AddRawWorkpieceBox(ActiveWorkplan, dx, dy, dz, bx, by, bz);
			if (uint.MaxValue != 0)
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(workpiece);
			}
			return workpiece;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706805);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706765)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workpiece CreateRawWorkpieceFromExtrusion(string name, double dz, double bx = 0.0, double by = 0.0, double bz = 0.0, params string[] internalProfiles)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			Workpiece obj = Exist(name, exist: true) as Workpiece;
			Workpiece workpiece;
			if (2u != 0)
			{
				workpiece = obj;
			}
			List<Geometry> list = new List<Geometry>();
			List<Geometry> list2;
			if (true)
			{
				list2 = list;
			}
			foreach (string name2 in internalProfiles)
			{
				list2.Add(Exist(name2, exist: true) as Geometry);
			}
			workpiece.AddRawWorkpieceFromExtrusion(ActiveWorkplan, ActiveGeometry, dz, bx, by, bz, list2);
			_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(workpiece);
			_0023_003DzBJYL2ljkevk4RP5NZV5Jyu8_003D(ActiveGeometry.Name, internalProfiles);
			_0023_003Dzfm_0024Yzjh9kop4KfDdTjJUg_0_003D();
			return workpiece;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706805);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706755)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workpiece CreateRawWorkpiece(string name, double bx1, double bx2, double by1, double by2, double bz1 = 0.0, double bz2 = 0.0)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			Workpiece obj = Exist(name, exist: true) as Workpiece;
			Workpiece workpiece;
			if (7u != 0)
			{
				workpiece = obj;
			}
			workpiece.AddRawWorkpiece(ActiveWorkplan, bx1, bx2, by1, by2, bz1, bz2);
			if (7u != 0)
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(workpiece);
			}
			return workpiece;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706805);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706765)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workpiece SelectWorkpiece(string name)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			Workpiece _0023_003Dz3keKASA_003D = Exist(name, exist: true) as Workpiece;
			if (0 == 0)
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(_0023_003Dz3keKASA_003D);
			}
			Workplane _0023_003Dz3keKASA_003D2 = Exist(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611), exist: true) as Workplane;
			if (5u != 0)
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(_0023_003Dz3keKASA_003D2);
			}
			_projectInterface.SetCurrentPlane(ActiveWorkpiece.ReferenceKey, ActiveWorkplane.ReferenceKey, this);
			return ActiveWorkpiece;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706995);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workpiece SelectWorkpiece(int index)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			Workpiece _0023_003Dz3keKASA_003D = _0023_003DzCtl4R_E_003D(index, typeof(Workpiece)) as Workpiece;
			if (2u != 0)
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(_0023_003Dz3keKASA_003D);
			}
			Workplane _0023_003Dz3keKASA_003D2 = Exist(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611), exist: true) as Workplane;
			if (2u != 0)
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(_0023_003Dz3keKASA_003D2);
			}
			_projectInterface.SetCurrentPlane(ActiveWorkpiece.ReferenceKey, ActiveWorkplane.ReferenceKey, this);
			return ActiveWorkpiece;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706950);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteWorkpiece(string name)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			Workpiece obj = Exist(name, exist: true) as Workpiece;
			Workpiece workpiece;
			if (uint.MaxValue != 0)
			{
				workpiece = obj;
			}
			WorkPiece obj2 = _projectInterface.Get(workpiece.ReferenceKey) as WorkPiece;
			WorkPiece workPiece;
			if (7u != 0)
			{
				workPiece = obj2;
			}
			_projectInterface.DeleteWorkPiece(workPiece, this);
			Workpieces.Remove(workpiece);
			if (Workpieces.Count > 0)
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(Workpieces[Workpieces.Count - 1]);
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(Exist(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611), exist: true) as Workplane);
			}
			else
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(null);
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706902);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteWorkpiece(int index)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			Workpiece obj = _0023_003DzCtl4R_E_003D(index, typeof(Workpiece)) as Workpiece;
			Workpiece workpiece;
			if (2u != 0)
			{
				workpiece = obj;
			}
			WorkPiece obj2 = _projectInterface.Get(workpiece.ReferenceKey) as WorkPiece;
			WorkPiece workPiece;
			if (6u != 0)
			{
				workPiece = obj2;
			}
			_projectInterface.DeleteWorkPiece(workPiece, this);
			Workpieces.Remove(workpiece);
			if (Workpieces.Count > 0)
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(Workpieces[Workpieces.Count - 1]);
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(Exist(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708611), exist: true) as Workplane);
			}
			else
			{
				_0023_003Dz0Nt_0024Ynl7yiwPq0RLUQfp3WY_003D(null);
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707621);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void SetWorkpieceSetupPosition(double x, double y, double z, double zRot)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0055: Expected O, but got Unknown
		//IL_0055: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0092: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			gp_Ax2 val = new gp_Ax2(new gp_Pnt(x, y, z), new gp_Dir(0.0, 0.0, 1.0), new gp_Dir(1.0, 0.0, 0.0));
			val.Rotate(new gp_Ax1(val.Location(), new gp_Dir(0.0, 0.0, 1.0)), MathUtility.DegreeToRad(zRot));
			Geom_Axis2Placement val2 = new Geom_Axis2Placement(val);
			Geom_Axis2Placement placement;
			if (true)
			{
				placement = val2;
			}
			MainWorkplan obj = _projectInterface.Get(ActiveWorkplan.ReferenceKey) as MainWorkplan;
			MainWorkplan mainWorkplan;
			if (5u != 0)
			{
				mainWorkplan = obj;
			}
			WorkpieceSetup workpieceSetup = mainWorkplan.Setup.WorkpieceSetups.Find(_0023_003Dz2K5PmgB4CvHR61nrIbOVEBjDEJds67jhzg_003D_003D);
			if (workpieceSetup == null)
			{
				workpieceSetup = new WorkpieceSetup();
				workpieceSetup.WorkpieceID = ActiveWorkpiece.ReferenceKey;
				mainWorkplan.Setup.WorkpieceSetups.Add(workpieceSetup);
			}
			workpieceSetup.Placement = new GeomAxis2Placement(placement);
			_projectInterface.UpdateMainWorkplan(mainWorkplan, this);
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707573);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				(ActiveWorkpiece != null) ? ActiveWorkpiece.Name : string.Empty,
				(ActiveWorkplan != null) ? ActiveWorkplan.Name : string.Empty
			};
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public WorkPieceSetupPosition GetWorkPieceSetupPosition()
	{
		try
		{
			WorkPieceSetupPosition result = new WorkPieceSetupPosition(_projectInterface, ActiveWorkpiece.ReferenceKey, ActiveWorkplan.ReferenceKey);
			if (7u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (true)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707573);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			string[] obj = new string[2]
			{
				(ActiveWorkpiece != null) ? ActiveWorkpiece.Name : string.Empty,
				(ActiveWorkplan != null) ? ActiveWorkplan.Name : string.Empty
			};
			object[] parameters;
			if (4u != 0)
			{
				parameters = obj;
			}
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		WorkPieceSetupPosition result2;
		return result2;
	}

	public BlockingProfile CreateBlockingProfile(string name, double startX, double startY, double offset)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzJsN2wfwoTZJn<GeomCompositeCurve>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707120));
			if (5u != 0)
			{
				name = text;
			}
			BlockingProfile blockingProfile = new BlockingProfile(name, _projectInterface);
			BlockingProfile blockingProfile2;
			if (7u != 0)
			{
				blockingProfile2 = blockingProfile;
			}
			Workplan _0023_003DzxJ3Gc6wlmHM = ActiveWorkplan;
			IReferentiable referentiable = _projectInterface.Get(ActiveWorkplan.ReferenceKey);
			if (referentiable.GetType() != typeof(MainWorkplan))
			{
				IReferentiable referentiable2 = referentiable;
				for (IReferentiable referentiable3 = _projectInterface.FindExecutableParent(referentiable2.Key); referentiable3 != null; referentiable3 = _projectInterface.FindExecutableParent(referentiable2.Key))
				{
					referentiable2 = referentiable3;
				}
				if (referentiable2 is MainWorkplan)
				{
					MainWorkplan mainWorkplan = referentiable2 as MainWorkplan;
					_0023_003DzxJ3Gc6wlmHM = new Workplan(mainWorkplan.Name, _projectInterface, mainWorkplan);
				}
			}
			blockingProfile2._0023_003Dzp3txSoKXD01u(startX, startY, offset, ActiveWorkplane, ActiveWorkpiece, _0023_003DzxJ3Gc6wlmHM);
			BlockingProfiles.Add(blockingProfile2);
			_0023_003DzGqmSgWSZ_0024qJEUO_unQ_003D_003D(blockingProfile2);
			RegisterForFlush(ActiveBlockingProfile);
			return blockingProfile2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public BlockingProfile AddSegmentToBlockingProfile(double endX, double endY, string nameElement)
	{
		try
		{
			ActiveBlockingProfile.AddSegment(nameElement, endX, endY);
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (7u != 0)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (2u != 0)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (true)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public BlockingProfile AddArc3PointsToBlockingProfile(double p2X, double p2Y, double p3X, double p3Y, string nameElement)
	{
		try
		{
			ActiveBlockingProfile.AddArc3Points(nameElement, p2X, p2Y, p3X, p3Y);
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (0 == 0)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (3u != 0)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public BlockingProfile AddArc2PointCenterToBlockingProfile(double endX, double endY, double centerX, double centerY, bool isClockwise, string nameElement)
	{
		try
		{
			ActiveBlockingProfile.AddArc2PointCenter(nameElement, endX, endY, centerX, centerY, isClockwise);
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (true)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (5u != 0)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public BlockingProfile AddArc2PointRadiusToBlockingProfile(double endX, double endY, double radius, bool isClockwise, bool isOver180, string nameElement)
	{
		try
		{
			ActiveBlockingProfile.AddArc2PointRadius(nameElement, endX, endY, radius, isClockwise, isOver180);
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (6u != 0)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (5u != 0)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public BlockingProfile AddArcCenterAngleToBlockingProfile(double centerX, double centerY, double angle, string nameElement)
	{
		try
		{
			ActiveBlockingProfile.AddArcCenterAngleToPolyline(nameElement, centerX, centerY, MathUtility.DegreeToRad(angle));
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (2u != 0)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (4u != 0)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public BlockingProfile AddSegmentTanToBlockingProfile(double length, string nameElement)
	{
		try
		{
			ActiveBlockingProfile.AddSegmentTanToPolyline(nameElement, length);
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (true)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (true)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public BlockingProfile AddArcTanToBlockingProfile(double endX, double endY, int option, string nameElement)
	{
		try
		{
			ActiveBlockingProfile.AddArcTanToPolyline(nameElement, endX, endY, option);
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (3u != 0)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (6u != 0)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public BlockingProfile CloseBlockingProfile(string nameElement)
	{
		try
		{
			ActiveBlockingProfile.Close(nameElement);
			BlockingProfile activeBlockingProfile = ActiveBlockingProfile;
			if (3u != 0)
			{
				RegisterForFlush(activeBlockingProfile);
			}
			BlockingProfile activeBlockingProfile2 = ActiveBlockingProfile;
			if (6u != 0)
			{
				return activeBlockingProfile2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (2u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917708326);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		BlockingProfile result;
		return result;
	}

	public Workplane CreateWorkplane(string name, double p1X, double p1Y, double p1Z, double p2X, double p2Y, double p2Z, double p3X, double p3Y, double p3Z)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003DzS_zNcwk3g_C3(name);
			if (4u != 0)
			{
				name = text;
			}
			Workplane workplane = new Workplane(name, _projectInterface);
			Workplane workplane2;
			if (uint.MaxValue != 0)
			{
				workplane2 = workplane;
			}
			workplane2.CreateWorkplane(_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D ? PlaneType.SubprogramGenerated : PlaneType.UserDefined, p1X, p1Y, p1Z, p2X, p2Y, p2Z, p3X, p3Y, p3Z, ActiveWorkpiece);
			Workplanes.Add(workplane2);
			_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(workplane2);
			return workplane2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707522);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707720) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707738)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplane CreateWorkplane(string name, double X0, double Y0, double Z0, double ZRotation, double XRotation)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzS_zNcwk3g_C3(name);
			if (0 == 0)
			{
				name = text;
			}
			Workplane workplane = new Workplane(name, _projectInterface);
			Workplane workplane2;
			if (5u != 0)
			{
				workplane2 = workplane;
			}
			workplane2.CreateWorkplane(_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D ? PlaneType.SubprogramGenerated : PlaneType.UserDefined, X0, Y0, Z0, MathUtility.DegreeToRad(ZRotation), MathUtility.DegreeToRad(XRotation), ActiveWorkpiece);
			Workplanes.Add(workplane2);
			_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(workplane2);
			return workplane2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707522);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707720) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707738)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplane CreateWorkplane(string name, object X0, object Y0, object Z0, object ZRotation, object XRotation)
	{
		try
		{
			double num = _0023_003Dzdn45LMQ_003D<double>(X0, FisicalUnitType.Lenght);
			double x;
			if (5u != 0)
			{
				x = num;
			}
			double num2 = _0023_003Dzdn45LMQ_003D<double>(Y0, FisicalUnitType.Lenght);
			double y;
			if (uint.MaxValue != 0)
			{
				y = num2;
			}
			double num3 = _0023_003Dzdn45LMQ_003D<double>(Z0, FisicalUnitType.Lenght);
			double z = default(double);
			if (0 == 0)
			{
				z = num3;
			}
			double zRotation = _0023_003Dzdn45LMQ_003D<double>(ZRotation, FisicalUnitType.UnitLess);
			double xRotation = _0023_003Dzdn45LMQ_003D<double>(XRotation, FisicalUnitType.UnitLess);
			Workplane workplane = CreateWorkplane(name, x, y, z, zRotation, xRotation);
			workplane.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707694), X0);
			workplane.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707677), Y0);
			workplane.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707664), Z0);
			workplane.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707391), ZRotation);
			workplane.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707375), XRotation);
			return workplane;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707522);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707720) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707738)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplane CreateWorkplane(string name, double offsetZ)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzS_zNcwk3g_C3(name);
			if (7u != 0)
			{
				name = text;
			}
			Workplane workplane = new Workplane(name, _projectInterface);
			Workplane workplane2;
			if (5u != 0)
			{
				workplane2 = workplane;
			}
			workplane2.CreateWorkplane(_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D ? PlaneType.SubprogramGenerated : PlaneType.UserDefined, offsetZ, ActiveWorkplane);
			Workplanes.Add(workplane2);
			_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(workplane2);
			return workplane2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707522);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dz3KLSFnTBC0NrxwEFxBLUvPc_003D ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707720) : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707738)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplane SelectWorkplane(string name)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			Workplane _0023_003Dz3keKASA_003D = Exist(name, exist: true) as Workplane;
			if (uint.MaxValue != 0)
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(_0023_003Dz3keKASA_003D);
			}
			_projectInterface.SetCurrentPlane(ActiveWorkpiece.ReferenceKey, ActiveWorkplane.ReferenceKey, this);
			Workplane activeWorkplane = ActiveWorkplane;
			if (3u != 0)
			{
				return activeWorkplane;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707359);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Workplane result;
		return result;
	}

	public Workplane SelectWorkplane(int index)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			Workplane _0023_003Dz3keKASA_003D = _0023_003DzCtl4R_E_003D(index, typeof(Workplane)) as Workplane;
			if (true)
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(_0023_003Dz3keKASA_003D);
			}
			_projectInterface.SetCurrentPlane(ActiveWorkpiece.ReferenceKey, ActiveWorkplane.ReferenceKey, this);
			Workplane activeWorkplane = ActiveWorkplane;
			if (3u != 0)
			{
				return activeWorkplane;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Workplane result;
		return result;
	}

	public void DeleteWorkplane(string name)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			Workplane obj = Exist(name, exist: true) as Workplane;
			Workplane workplane;
			if (6u != 0)
			{
				workplane = obj;
			}
			Plane obj2 = _projectInterface.Get(workplane.ReferenceKey) as Plane;
			Plane plane;
			if (uint.MaxValue != 0)
			{
				plane = obj2;
			}
			_projectInterface.DeletePlane(plane, this);
			Workplanes.Remove(workplane);
			if (Workplanes.Count > 0)
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(Workplanes[Workplanes.Count - 1]);
			}
			else
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707266);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteWorkplane(int index)
	{
		try
		{
			if (2u != 0)
			{
				Flush();
			}
			Workplane obj = _0023_003DzCtl4R_E_003D(index, typeof(Workplane)) as Workplane;
			Workplane workplane;
			if (true)
			{
				workplane = obj;
			}
			Plane obj2 = _projectInterface.Get(workplane.ReferenceKey) as Plane;
			Plane plane;
			if (7u != 0)
			{
				plane = obj2;
			}
			_projectInterface.DeletePlane(plane, this);
			Workplanes.Remove(workplane);
			if (Workplanes.Count > 0)
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(Workplanes[Workplanes.Count - 1]);
			}
			else
			{
				_0023_003Dzqydyu7tJI5bKTwPKgGpMNRk_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707473);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplan CreateWorkplan(string name)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			if (true)
			{
				ResetPriority();
			}
			if (4u != 0)
			{
				ResetProbingReferencePoint();
			}
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			if (string.IsNullOrEmpty(name))
			{
				name = _projectInterface.GetUniqueName<MainWorkplan>(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707425), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
			}
			Workplan workplan = Exist(name, exist: false, throwException: false) as Workplan;
			if (workplan != null)
			{
				SelectWorkplan(name);
			}
			else
			{
				workplan = new Workplan(name, _projectInterface);
				workplan.CreateWorkplan();
				Workplans.Add(workplan);
				_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(workplan);
			}
			return workplan;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707398);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplan SelectWorkplan(string name)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			if (2u != 0)
			{
				ResetPriority();
			}
			if (0 == 0)
			{
				ResetProbingReferencePoint();
			}
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(Exist(name, exist: true) as Workplan);
			MainWorkplan arg = _projectInterface.Get(ActiveWorkplan.ReferenceKey) as MainWorkplan;
			EventBroker.Execute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706077), this, new GenericEventArgs<MainWorkplan>(arg));
			return ActiveWorkplan;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706044);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplan SelectWorkplan(int index)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			if (7u != 0)
			{
				ResetPriority();
			}
			if (4u != 0)
			{
				ResetProbingReferencePoint();
			}
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(_0023_003DzCtl4R_E_003D(index, typeof(Workplan)) as Workplan);
			MainWorkplan arg = _projectInterface.Get(ActiveWorkplan.ReferenceKey) as MainWorkplan;
			EventBroker.Execute(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706077), this, new GenericEventArgs<MainWorkplan>(arg));
			return ActiveWorkplan;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707314);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteWorkplan(string name)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			if (6u != 0)
			{
				ResetPriority();
			}
			if (5u != 0)
			{
				ResetProbingReferencePoint();
			}
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			Workplan workplan = Exist(name, exist: true) as Workplan;
			MainWorkplan workplan2 = _projectInterface.Get(workplan.ReferenceKey) as MainWorkplan;
			_projectInterface.DeleteMainWorkplan(workplan2, this);
			Workplans.Remove(workplan);
			if (Workplans.Count > 0)
			{
				_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(Workplans[Workplans.Count - 1]);
			}
			else
			{
				_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705998);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteWorkplan(int index)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			if (7u != 0)
			{
				ResetPriority();
			}
			if (2u != 0)
			{
				ResetProbingReferencePoint();
			}
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			Workplan workplan = _0023_003DzCtl4R_E_003D(index, typeof(Workplan)) as Workplan;
			MainWorkplan workplan2 = _projectInterface.Get(workplan.ReferenceKey) as MainWorkplan;
			_projectInterface.DeleteMainWorkplan(workplan2, this);
			Workplans.Remove(workplan);
			if (Workplans.Count > 0)
			{
				_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(Workplans[Workplans.Count - 1]);
			}
			else
			{
				_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706208);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Workplan RenameWorkplan(string name)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			MainWorkplan obj = _projectInterface.Get(ActiveWorkplan.ReferenceKey) as MainWorkplan;
			MainWorkplan mainWorkplan = default(MainWorkplan);
			if (0 == 0)
			{
				mainWorkplan = obj;
			}
			mainWorkplan.Name = name;
			_projectInterface.UpdateMainWorkplan(mainWorkplan, this);
			Workplan _0023_003Dz3keKASA_003D = new Workplan(name, _projectInterface, ActiveWorkplan.ReferenceKey);
			if (3u != 0)
			{
				_0023_003DzWlXA7NwhU2Wmau_YLMNdjtQ_003D(_0023_003Dz3keKASA_003D);
			}
			Workplans[Workplans.FindIndex(_0023_003Dz9xOEEgYdFZTykffy3egI_0TVVa7gh1idqQ_003D_003D)] = ActiveWorkplan;
			return ActiveWorkplan;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706159);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void SetPriority(int priority)
	{
		if (uint.MaxValue != 0)
		{
			_activePriority = priority;
		}
	}

	public void ResetPriority()
	{
		if (6u != 0)
		{
			_activePriority = 0;
		}
	}

	public void SetProjectLabel(string labelName)
	{
		_ = 8;
		if (false)
		{
		}
		ProjectInterface projectInterface = _projectInterface;
		_ = 2;
		if (false)
		{
		}
		projectInterface.AddLabelName(labelName);
		if (3u != 0)
		{
		}
	}

	public void SetWorkPieceLabel(double xStart, double yStart, double rotationDegree)
	{
		WorkPiece obj = _projectInterface.Get(ActiveWorkpiece.ReferenceKey) as WorkPiece;
		WorkPiece workPiece = default(WorkPiece);
		if (0 == 0)
		{
			workPiece = obj;
		}
		ProjectPartInfo obj2 = new ProjectPartInfo
		{
			Length = workPiece.Length,
			Width = workPiece.Width,
			PartName = workPiece.Name,
			PartType = ProjectPartInfoType.Part
		};
		ProjectPartInfo projectPartInfo;
		if (true)
		{
			projectPartInfo = obj2;
		}
		GeomCompositeCurve finishedBoundaryGeometry = workPiece.GetFinishedBoundaryGeometry();
		GeomGeometry geometry = default(GeomGeometry);
		if (0 == 0)
		{
			geometry = finishedBoundaryGeometry;
		}
		_projectInterface.AddGeometry(ref geometry, ActiveWorkplane.ReferenceKey, workPiece.Key, this);
		projectPartInfo.HoleGeometryKeys.Clear();
		Plane obj3 = _projectInterface.Get(ActiveWorkplane.ReferenceKey) as Plane;
		Plane plane;
		if (3u != 0)
		{
			plane = obj3;
		}
		List<GeomCompositeCurve> finishedHoleBoundaryGeometries = workPiece.GetFinishedHoleBoundaryGeometries(plane);
		List<GeomCompositeCurve> list = new List<GeomCompositeCurve>();
		List<GeomCompositeCurve> list2;
		if (8u != 0)
		{
			list2 = list;
		}
		foreach (GeomCompositeCurve item in finishedHoleBoundaryGeometries)
		{
			GeomGeometry geometry2 = item;
			_projectInterface.AddGeometry(ref geometry2, ActiveWorkplane.ReferenceKey, workPiece.Key, this);
			projectPartInfo.HoleGeometryKeys.Add(geometry2.Key);
			list2.Add(geometry2 as GeomCompositeCurve);
		}
		WorkpieceGeometry geometry3 = workPiece.Geometry;
		if (geometry3 is WorkpieceExtrusionGeometry)
		{
			WorkpieceExtrusionGeometry workpieceExtrusionGeometry = geometry3 as WorkpieceExtrusionGeometry;
			geometry.IsAbsolute = true;
			workpieceExtrusionGeometry.BoundaryGeometry = geometry as GeomCompositeCurve;
			workpieceExtrusionGeometry.HoleGeometryList.Clear();
			foreach (GeomCompositeCurve item2 in list2)
			{
				item2.IsAbsolute = true;
				workpieceExtrusionGeometry.HoleGeometryList.Add(item2);
			}
			workPiece.Geometry = workpieceExtrusionGeometry;
			_projectInterface.UpdateWorkPiece(workPiece, this);
		}
		_projectInterface.AddProjectPartInfo(ref projectPartInfo, geometry.Key, this);
		_0023_003Dz5cyKnAzBg05q = projectPartInfo.Key;
		Label label = new Label();
		label.PartInfoKey = _0023_003Dz5cyKnAzBg05q;
		label.Name = _projectInterface.GetLabelName();
		label.PositionX = xStart;
		label.PositionY = yStart;
		label.RotationAngle = MathUtility.ConvertToRadians(rotationDegree);
		_projectInterface.AddLabel(ref label, ActiveWorkpiece.ReferenceKey, this);
	}

	public void AddLabelParams(params string[] labelParameters)
	{
		ProjectPartInfo obj = _projectInterface.Get(_0023_003Dz5cyKnAzBg05q) as ProjectPartInfo;
		ProjectPartInfo projectPartInfo;
		if (7u != 0)
		{
			projectPartInfo = obj;
		}
		int i;
		if (4u != 0)
		{
			i = 0;
		}
		for (; i < labelParameters.Length; i++)
		{
			LabelField obj2 = new LabelField
			{
				Value = labelParameters[i]
			};
			LabelField item;
			if (4u != 0)
			{
				item = obj2;
			}
			projectPartInfo.Fields.Add(item);
		}
		_projectInterface.UpdateProjectPartInfo(projectPartInfo, this);
	}

	public void SetProbingReferenceReferencePoint(int referencePoint)
	{
		if (8u != 0)
		{
			_activeProbingReferencePoint = referencePoint;
		}
	}

	public void ResetProbingReferencePoint()
	{
		if (2u != 0)
		{
			_activeProbingReferencePoint = 0;
		}
	}

	public void SetReferencePosition(int referencePosition)
	{
		if (5u != 0)
		{
			_activeReferecePosition = referencePosition;
		}
	}

	public void ResetReferencePosition()
	{
		if (true)
		{
			_activeReferecePosition = 0;
		}
	}

	public void SetMachine(int id)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DztQZAXa1gd26n = id;
		}
	}

	public void ResetMachine()
	{
		if (3u != 0)
		{
			_0023_003DztQZAXa1gd26n = 0;
		}
	}

	public void SetSpindles(params int[] spindles)
	{
		if (4u != 0)
		{
			_0023_003DzobjG82GyRO6N0HSR2g_003D_003D = null;
		}
		if (spindles != null && spindles.Length != 0)
		{
			int[] array = new int[spindles.Length];
			if (2u != 0)
			{
				_0023_003DzobjG82GyRO6N0HSR2g_003D_003D = array;
			}
			int[] destinationArray = _0023_003DzobjG82GyRO6N0HSR2g_003D_003D;
			int length = spindles.Length;
			if (2u != 0)
			{
				Array.Copy(spindles, destinationArray, length);
			}
		}
	}

	public void ResetSpindles()
	{
		if (8u != 0)
		{
			_0023_003DzobjG82GyRO6N0HSR2g_003D_003D = null;
		}
	}

	public Operation CreateRoughFinish(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706113));
			if (4u != 0)
			{
				name = text;
			}
			if (5u != 0)
			{
				SetToolCorrection(correction, overMaterial);
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.CreateRoughFinish(activeParameters, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			SetCompensationMode(isCnc: true);
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateRoughFinish(string name, object depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, object inputSpeed = null, object rotSpeed = null, object speed = null, object overMaterial = null)
	{
		try
		{
			object obj = ConvertExpressionValueToCurrentUnit(depth, FisicalUnitType.Lenght, null);
			object obj2;
			if (4u != 0)
			{
				obj2 = obj;
			}
			object obj3 = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.UnitLess, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D;
			if (8u != 0)
			{
				_0023_003Dz3keKASA_003D = obj3;
			}
			object obj4 = ConvertExpressionValueToCurrentUnit(inputSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D2;
			if (true)
			{
				_0023_003Dz3keKASA_003D2 = obj4;
			}
			object _0023_003Dz3keKASA_003D3 = ConvertExpressionValueToCurrentUnit(speed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object obj5 = ConvertExpressionValueToCurrentUnit(overMaterial, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			double depth2 = _0023_003Dzdn45LMQ_003D<double>(obj2, FisicalUnitType.Lenght);
			double inputSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			double rotSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, -1.0, FisicalUnitType.UnitLess);
			double speed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D3, -1.0, FisicalUnitType.Speed);
			double overMaterial2 = _0023_003Dzz65du2JhGB1t(obj5, 0.0, FisicalUnitType.Lenght);
			GeneralRoutingOperation obj6 = CreateRoughFinish(name, depth2, description, typeOfProcess, tool, head, correction, inputSpeed2, rotSpeed2, speed2, overMaterial2) as GeneralRoutingOperation;
			obj6.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), obj2);
			obj6.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703821), obj5);
			return obj6;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	private void _0023_003DzjCn23HJ12WVoL_Qbjl_yMpQ_003D(ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation _0023_003DzIDjFPYA_003D)
	{
		_ = 6;
		if (6 == 0)
		{
		}
		_0023_003DzIDjFPYA_003D.ToolpathPriority = true;
		_ = 8;
		if (5 == 0)
		{
		}
		ProjectInterface projectInterface = _projectInterface;
		_ = 5;
		if (8 == 0)
		{
		}
		projectInterface.UpdateOperation(_0023_003DzIDjFPYA_003D, this);
	}

	public Operation Create3DRoughFinish(string name, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double? inputZRotation = null, double? inputXRotation = null)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706113));
			if (3u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (8u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.Create3DRoughFinish(activeParameters, description, typeOfProcess, tool, head, inputSpeed, rotSpeed, speed, inputZRotation, inputXRotation);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateSlantedRoughFinish(string name, double angleA, double angleB, int toolApproach, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 0;
		if (6 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		_ = 0;
		if (6 == 0)
		{
		}
		return _0023_003DzN7gkLlGsN_0024uwFliugFdULck_003D(name, angleA, angleB, toolApproach, depth, description, typeOfProcess, tool, head, 0, inputSpeed, rotSpeed, speed, overMaterial, _0023_003DziN8EKhWgVeoJ: false);
	}

	public Operation CreateSlantedRoughFinish(string name, double angleA, double angleB, int toolApproach, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		_ = 7;
		if (3 == 0)
		{
		}
		_ = 2;
		if (7 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		return _0023_003DzN7gkLlGsN_0024uwFliugFdULck_003D(name, angleA, angleB, toolApproach, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial, _0023_003DziN8EKhWgVeoJ: false);
	}

	private Operation _0023_003DzN7gkLlGsN_0024uwFliugFdULck_003D(string _0023_003DzJ3hfjPs_003D, double _0023_003Dzzc8h9h0_003D, double _0023_003DzjGhtUFg_003D, int _0023_003DzXlrGaU97yiX0F27zSA_003D_003D, double _0023_003DzX1WK4z0_003D, string _0023_003DzrziU4i4_003D, TypeOfProcess _0023_003DzergJzGc_003D, string _0023_003DzqmiDBVY_003D, string _0023_003DzYEQjc18_003D, int _0023_003DzGflSo6gx3M4rkp90RA_003D_003D, double _0023_003DzksrR6KQfs_Ff, double _0023_003DzVHemytquQzbF, double _0023_003DzEu292TXn1ZRI, double _0023_003DzbDCdcxRsxdCG, bool _0023_003DziN8EKhWgVeoJ)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(_0023_003DzJ3hfjPs_003D, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705762));
			if (0 == 0)
			{
				_0023_003DzJ3hfjPs_003D = text;
			}
			if (7u != 0)
			{
				SetToolCorrection(_0023_003DzGflSo6gx3M4rkp90RA_003D_003D, _0023_003DzbDCdcxRsxdCG);
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), _0023_003DzJ3hfjPs_003D, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.CreateSlantedRoughFinish(activeParameters, _0023_003Dzzc8h9h0_003D, _0023_003DzjGhtUFg_003D, (TypeOfToolApproach)_0023_003DzXlrGaU97yiX0F27zSA_003D_003D, _0023_003DzX1WK4z0_003D, _0023_003DzrziU4i4_003D, _0023_003DzergJzGc_003D, _0023_003DzqmiDBVY_003D, _0023_003DzYEQjc18_003D, _0023_003DzksrR6KQfs_Ff, _0023_003DzVHemytquQzbF, _0023_003DzEu292TXn1ZRI, _0023_003DzbDCdcxRsxdCG, _0023_003DzGflSo6gx3M4rkp90RA_003D_003D, _0023_003DziN8EKhWgVeoJ);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				_0023_003DzJ3hfjPs_003D,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateSlantedRoughFinish(string name, object angleA, object angleB, int toolApproach, object depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, object inputSpeed = null, object rotSpeed = null, object speed = null, object overMaterial = null, bool isCnc = false)
	{
		try
		{
			object obj = ConvertExpressionValueToCurrentUnit(depth, FisicalUnitType.Lenght, null);
			object obj2;
			if (2u != 0)
			{
				obj2 = obj;
			}
			object obj3 = ConvertExpressionValueToCurrentUnit(angleA, FisicalUnitType.UnitLess, null);
			object obj4;
			if (true)
			{
				obj4 = obj3;
			}
			object obj5 = ConvertExpressionValueToCurrentUnit(angleB, FisicalUnitType.UnitLess, null);
			object obj6;
			if (7u != 0)
			{
				obj6 = obj5;
			}
			object obj7 = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.UnitLess, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D;
			if (3u != 0)
			{
				_0023_003Dz3keKASA_003D = obj7;
			}
			object _0023_003Dz3keKASA_003D2 = ConvertExpressionValueToCurrentUnit(inputSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D3 = ConvertExpressionValueToCurrentUnit(speed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object obj8 = ConvertExpressionValueToCurrentUnit(overMaterial, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			double _0023_003DzX1WK4z0_003D = _0023_003Dzdn45LMQ_003D<double>(obj2, FisicalUnitType.Lenght);
			double _0023_003Dzzc8h9h0_003D = _0023_003Dzdn45LMQ_003D<double>(obj4, FisicalUnitType.UnitLess);
			double _0023_003DzjGhtUFg_003D = _0023_003Dzdn45LMQ_003D<double>(obj6, FisicalUnitType.UnitLess);
			double _0023_003DzksrR6KQfs_Ff = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			double _0023_003DzVHemytquQzbF = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, -1.0, FisicalUnitType.UnitLess);
			double _0023_003DzEu292TXn1ZRI = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D3, -1.0, FisicalUnitType.Speed);
			double _0023_003DzbDCdcxRsxdCG = _0023_003Dzz65du2JhGB1t(obj8, 0.0, FisicalUnitType.Lenght);
			GeneralRoutingOperation obj9 = _0023_003DzN7gkLlGsN_0024uwFliugFdULck_003D(name, _0023_003Dzzc8h9h0_003D, _0023_003DzjGhtUFg_003D, toolApproach, _0023_003DzX1WK4z0_003D, description, typeOfProcess, tool, head, correction, _0023_003DzksrR6KQfs_Ff, _0023_003DzVHemytquQzbF, _0023_003DzEu292TXn1ZRI, _0023_003DzbDCdcxRsxdCG, _0023_003DziN8EKhWgVeoJ: true) as GeneralRoutingOperation;
			obj9.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), obj2);
			obj9.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703821), obj8);
			obj9.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704574), obj4);
			obj9.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704559), obj6);
			return obj9;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateChamfer(string name, double chamferWidth, double chamferHeight, double overcutLength, int toolPositionType, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706113));
			if (0 == 0)
			{
				name = text;
			}
			if (2u != 0)
			{
				SetToolCorrection(0, overMaterial);
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.CreateChamfer(activeParameters, chamferWidth, chamferHeight, overcutLength, (ChamferToolPositionType)toolPositionType, description, typeOfProcess, tool, head, inputSpeed, rotSpeed, speed, overMaterial);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateTrimming(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.Trimming, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705729));
			if (3u != 0)
			{
				name = text;
			}
			if (true)
			{
				return null;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Operation result;
		return result;
	}

	public Operation CreateTrimmingWorkingStep(string name, string description, TrimmingType trimmingType, string tool, string head = "-1", double approachAngle = 0.0, double infeedAdvance = 0.0, double outfeedDelay = 0.0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, double retractAngle = 0.0)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705729));
			if (5u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (5u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			OperationContext operationContext = _0023_003Dzv171kDksmsdD();
			TrimmingOperationParameters trimmingParameters = new TrimmingOperationParameters(trimmingType, tool, head, overMaterial, approachAngle, infeedAdvance, outfeedDelay, inputSpeed, speed, rotSpeed, retractAngle);
			TrimmingOperation trimmingOperation = new TrimmingOperation(operationContext, name, ActiveWorkplan.ReferenceKey);
			trimmingOperation.CreateTrimmingOperation(activeParameters, trimmingParameters, description, _approachSecurityPlane, _retractSecurityPlane);
			Operations.Add(trimmingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(trimmingOperation);
			_0023_003Dzdzv73cHjrWgk(trimmingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return trimmingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateEdgeScraping(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.EdgeScraping, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705962));
			if (uint.MaxValue != 0)
			{
				name = text;
			}
			if (4u != 0)
			{
				SetToolCorrection(correction, overMaterial);
			}
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			MachiningOperation machiningOperation = generalRoutingOperation.CreateScrapingOperation(tool, head, rotSpeed, speed, ActiveMachineFunctions, TypeOfProcess.EdgeScraping) as MachiningOperation;
			MachiningWorkingStep ws = null;
			generalRoutingOperation.CreateScrapingFeature((TypeOfToolApproach)toolApproach, depth, description, tool, typeOfProcess, overMaterial, ActiveGeometry, ActiveAttributes, correction, ref machiningOperation, ref ws, _activePriority);
			_0023_003DzjCn23HJ12WVoL_Qbjl_yMpQ_003D(machiningOperation);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateGlueScraping(string name, int toolApproach, double depth, string description, TypeOfProcess typeOfProcess = TypeOfProcess.GlueScraping, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705962));
			if (7u != 0)
			{
				name = text;
			}
			if (uint.MaxValue != 0)
			{
				SetToolCorrection(correction, overMaterial);
			}
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			MachiningOperation machiningOperation = generalRoutingOperation.CreateScrapingOperation(tool, head, rotSpeed, speed, ActiveMachineFunctions, TypeOfProcess.GlueScraping) as MachiningOperation;
			MachiningWorkingStep ws = null;
			generalRoutingOperation.CreateScrapingFeature((TypeOfToolApproach)toolApproach, depth, description, tool, typeOfProcess, overMaterial, ActiveGeometry, ActiveAttributes, correction, ref machiningOperation, ref ws, _activePriority);
			_0023_003DzjCn23HJ12WVoL_Qbjl_yMpQ_003D(machiningOperation);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateAntiAdhesiveWorkingStep(string name, string description, ScmGroup.XCam.MachiningDataModel.AntiAdhesiveType antiAdhesiveType, string tool, string head = "-1", double approachAngle = 0.0, object infeedAdvance = null, object outfeedDelay = null, object inputSpeed = null, object rotSpeed = null, object speed = null, double overMaterial = 0.0, double retractAngle = 0.0)
	{
		try
		{
			object obj = ConvertExpressionValueToCurrentUnit(infeedAdvance, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object _0023_003Dz3keKASA_003D;
			if (uint.MaxValue != 0)
			{
				_0023_003Dz3keKASA_003D = obj;
			}
			object obj2 = ConvertExpressionValueToCurrentUnit(inputSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D2;
			if (6u != 0)
			{
				_0023_003Dz3keKASA_003D2 = obj2;
			}
			object obj3 = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D3;
			if (6u != 0)
			{
				_0023_003Dz3keKASA_003D3 = obj3;
			}
			object _0023_003Dz3keKASA_003D4 = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D5 = ConvertExpressionValueToCurrentUnit(outfeedDelay, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			double inputSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			double rotSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D3, -1.0, FisicalUnitType.UnitLess);
			double speed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D4, -1.0, FisicalUnitType.Speed);
			double infeedAdvance2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, 0.0, FisicalUnitType.Lenght);
			double outfeedDelay2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D5, 0.0, FisicalUnitType.Lenght);
			return CreateAntiAdhesiveWorkingStep(name, description, antiAdhesiveType, tool, head, approachAngle, infeedAdvance2, outfeedDelay2, inputSpeed2, rotSpeed2, speed2, overMaterial, retractAngle) as AntiAdhesiveOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705935)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateAntiAdhesiveWorkingStep(string name, string description, ScmGroup.XCam.MachiningDataModel.AntiAdhesiveType antiAdhesiveType, string tool, string head = "-1", double approachAngle = 0.0, double infeedAdvance = -1.0, double outfeedDelay = 0.0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, double retractAngle = 0.0)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705918));
			if (4u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (7u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			OperationContext operationContext = _0023_003Dzv171kDksmsdD();
			AntiAdhesiveOperationParameters antiAdhesiveParameters = new AntiAdhesiveOperationParameters(antiAdhesiveType, tool, head, overMaterial, approachAngle, infeedAdvance, outfeedDelay, inputSpeed, speed, rotSpeed, retractAngle);
			AntiAdhesiveOperation antiAdhesiveOperation = new AntiAdhesiveOperation(operationContext, name, ActiveWorkplan.ReferenceKey);
			antiAdhesiveOperation.CreateAntiAdhesiveOperation(activeParameters, antiAdhesiveParameters, description, _approachSecurityPlane, _retractSecurityPlane);
			Operations.Add(antiAdhesiveOperation);
			_0023_003Dz_0024IbzEN9jdWmF(antiAdhesiveOperation);
			_0023_003Dzdzv73cHjrWgk(antiAdhesiveOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return antiAdhesiveOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateDrill(string name, double x, double y, double depth, double diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double taperDiameter = 0.0)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705887));
			if (7u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (5u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			DrillingOperation drillingOperation = new DrillingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			drillingOperation.CreateDrill(activeParameters, x, y, depth, diameter, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, securityQuote, taperDiameter);
			Operations.Add(drillingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(drillingOperation);
			_0023_003Dzdzv73cHjrWgk(drillingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return drillingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705865)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateThroughDrill(string name, double x, double y, double diameter, double overcutLength, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double taperDiameter = 0.0)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705887));
			if (3u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (8u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			DrillingOperation drillingOperation = new DrillingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			drillingOperation.CreateThroughDrill(activeParameters, x, y, diameter, overcutLength, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, securityQuote, taperDiameter);
			Operations.Add(drillingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(drillingOperation);
			_0023_003Dzdzv73cHjrWgk(drillingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return drillingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705865)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateDrill(string name, object x, object y, object depth, object diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, string kindOfHole = "-1", object taperHeight = null, object securityQuote = null, object taperDiameter = null)
	{
		try
		{
			object obj = ConvertExpressionValueToCurrentUnit(x, FisicalUnitType.Lenght, null);
			object obj2;
			if (7u != 0)
			{
				obj2 = obj;
			}
			object obj3 = ConvertExpressionValueToCurrentUnit(y, FisicalUnitType.Lenght, null);
			object obj4;
			if (5u != 0)
			{
				obj4 = obj3;
			}
			object obj5 = ConvertExpressionValueToCurrentUnit(depth, FisicalUnitType.Lenght, null);
			object obj6;
			if (3u != 0)
			{
				obj6 = obj5;
			}
			object obj7 = ConvertExpressionValueToCurrentUnit(diameter, FisicalUnitType.Lenght, null);
			object obj8;
			if (7u != 0)
			{
				obj8 = obj7;
			}
			object obj9 = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.UnitLess, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D;
			if (3u != 0)
			{
				_0023_003Dz3keKASA_003D = obj9;
			}
			object _0023_003Dz3keKASA_003D2 = ConvertExpressionValueToCurrentUnit(boringSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D3 = ConvertExpressionValueToCurrentUnit(securityQuote, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object _0023_003Dz3keKASA_003D4 = ConvertExpressionValueToCurrentUnit(taperHeight, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object _0023_003Dz3keKASA_003D5 = ConvertExpressionValueToCurrentUnit(taperDiameter, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			double x2 = _0023_003Dzdn45LMQ_003D<double>(obj2, FisicalUnitType.Lenght);
			double y2 = _0023_003Dzdn45LMQ_003D<double>(obj4, FisicalUnitType.Lenght);
			double depth2 = _0023_003Dzdn45LMQ_003D<double>(obj6, FisicalUnitType.Lenght);
			double diameter2 = _0023_003Dzdn45LMQ_003D<double>(obj8, FisicalUnitType.Lenght);
			int dischargeSteps2 = _0023_003Dzz65du2JhGB1t(dischargeSteps, 0, FisicalUnitType.UnitLess);
			double rotSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, -1.0, FisicalUnitType.UnitLess);
			double boringSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			double taperHeight2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D4, 0.0, FisicalUnitType.Lenght);
			double taperDiameter2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D5, 0.0, FisicalUnitType.Lenght);
			double? securityQuote2 = _0023_003Dzz65du2JhGB1t<double?>(_0023_003Dz3keKASA_003D3, null, FisicalUnitType.Lenght);
			DrillingOperation obj10 = CreateDrill(name, x2, y2, depth2, diameter2, description, typeOfProcess, tool, head, dischargeSteps2, rotSpeed2, boringSpeed2, kindOfHole, taperHeight2, securityQuote2, taperDiameter2) as DrillingOperation;
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), obj2);
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), obj4);
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704067), obj6);
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703625), obj8);
			return obj10;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705865)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateThroughDrill(string name, object x, object y, object diameter, object overcutLength, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, string kindOfHole = "-1", object taperHeight = null, object securityQuote = null, object taperDiameter = null)
	{
		try
		{
			object obj = ConvertExpressionValueToCurrentUnit(x, FisicalUnitType.Lenght, null);
			object obj2;
			if (7u != 0)
			{
				obj2 = obj;
			}
			object obj3 = ConvertExpressionValueToCurrentUnit(y, FisicalUnitType.Lenght, null);
			object obj4;
			if (2u != 0)
			{
				obj4 = obj3;
			}
			object obj5 = ConvertExpressionValueToCurrentUnit(diameter, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object obj6;
			if (2u != 0)
			{
				obj6 = obj5;
			}
			object obj7 = ConvertExpressionValueToCurrentUnit(overcutLength, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object obj8;
			if (6u != 0)
			{
				obj8 = obj7;
			}
			object obj9 = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.UnitLess, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D;
			if (3u != 0)
			{
				_0023_003Dz3keKASA_003D = obj9;
			}
			object _0023_003Dz3keKASA_003D2 = ConvertExpressionValueToCurrentUnit(boringSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D3 = ConvertExpressionValueToCurrentUnit(securityQuote, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object _0023_003Dz3keKASA_003D4 = ConvertExpressionValueToCurrentUnit(taperHeight, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object _0023_003Dz3keKASA_003D5 = ConvertExpressionValueToCurrentUnit(taperDiameter, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			double x2 = _0023_003Dzdn45LMQ_003D<double>(obj2, FisicalUnitType.Lenght);
			double y2 = _0023_003Dzdn45LMQ_003D<double>(obj4, FisicalUnitType.Lenght);
			double diameter2 = _0023_003Dzdn45LMQ_003D<double>(obj6, FisicalUnitType.Lenght);
			double overcutLength2 = _0023_003Dzdn45LMQ_003D<double>(obj8, FisicalUnitType.Lenght);
			int dischargeSteps2 = _0023_003Dzz65du2JhGB1t(dischargeSteps, 0, FisicalUnitType.UnitLess);
			double rotSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, -1.0, FisicalUnitType.UnitLess);
			double boringSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			double taperHeight2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D4, 0.0, FisicalUnitType.Lenght);
			double taperDiameter2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D5, 0.0, FisicalUnitType.Lenght);
			double? securityQuote2 = _0023_003Dzz65du2JhGB1t<double?>(_0023_003Dz3keKASA_003D3, null, FisicalUnitType.Lenght);
			DrillingOperation obj10 = CreateThroughDrill(name, x2, y2, diameter2, overcutLength2, description, typeOfProcess, tool, head, dischargeSteps2, rotSpeed2, boringSpeed2, kindOfHole, taperHeight2, securityQuote2, taperDiameter2) as DrillingOperation;
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), obj2);
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), obj4);
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703625), obj6);
			obj10.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703661), obj8);
			return obj10;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705865)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateSlantedDrill(string name, double x, double y, double z, double angleA, double angleB, double depth, double diameter, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.Drilling, string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, string kindOfHole = "-1", double taperHeight = 0.0, double? securityQuote = null, double taperDiameter = 0.0)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705887));
			if (3u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (6u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			DrillingOperation drillingOperation = new DrillingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			drillingOperation.CreateSlantedDrill(activeParameters, x, y, z, angleA, angleB, depth, diameter, description, typeOfProcess, tool, head, dischargeSteps, rotSpeed, boringSpeed, kindOfHole, taperHeight, securityQuote, securityQuote, taperDiameter);
			Operations.Add(drillingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(drillingOperation);
			_0023_003Dzdzv73cHjrWgk(drillingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return drillingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705865)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public object CreateMacro(string name, string macroName, string macroParameters)
	{
		try
		{
			object[] array;
			if (uint.MaxValue != 0)
			{
				array = null;
			}
			_0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D.Clear();
			SubProgramInfo subProgramInfo = new SubProgramInfo(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface, null, null, null, _activePriority, null);
			SubProgramInfo info;
			if (7u != 0)
			{
				info = subProgramInfo;
			}
			ScriptSubProgram scriptSubProgram = ScriptSubProgram.TryCreate(macroName, info);
			SubProgram subProgram;
			if (4u != 0)
			{
				subProgram = scriptSubProgram;
			}
			if (subProgram == null)
			{
				VisualSubProgram visualSubProgram = new VisualSubProgram(macroName, info);
				if (true)
				{
					subProgram = visualSubProgram;
				}
			}
			if (subProgram.Parameters.Count > 0)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				array = new object[subProgram.Parameters.Count];
				string[] array2 = macroParameters.Split(',');
				for (int i = 0; i < array2.Length; i++)
				{
					string[] array3 = array2[i].Split('=');
					if (array3.Length == 2)
					{
						dictionary.Add(array3[0], array3[1]);
					}
				}
				for (int j = 0; j < subProgram.Parameters.Count; j++)
				{
					SubProgramParameter subProgramParameter = subProgram.Parameters[j];
					if (dictionary.ContainsKey(subProgramParameter.Name))
					{
						array[j] = dictionary[subProgramParameter.Name];
					}
					else
					{
						array[j] = subProgramParameter.DefaultValue;
					}
				}
			}
			return CreateMacro(name, macroName, array);
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706621);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2] { name, macroName };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public object CreateMacro(string name, string macroName, params object[] macroParameters)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			_0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D.Clear();
			string text = _0023_003DzBzveABk_003D<ScriptSubProgram>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706585));
			if (2u != 0)
			{
				name = text;
			}
			ReferenceKey referenceKey = ActiveWorkpiece.ReferenceKey;
			ReferenceKey workPieceKey;
			if (7u != 0)
			{
				workPieceKey = referenceKey;
			}
			ReferenceKey referenceKey2 = ActiveWorkplane.ReferenceKey;
			ReferenceKey planeKey;
			if (6u != 0)
			{
				planeKey = referenceKey2;
			}
			SubProgramEvaluator subProgramEvaluator = new SubProgramEvaluator(new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface), _options);
			ISubProgramEvaluator subProgramEvaluator2;
			if (4u != 0)
			{
				subProgramEvaluator2 = subProgramEvaluator;
			}
			SubProgramInfo subProgramInfo = new SubProgramInfo(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface, workPieceKey, ActiveWorkplan.ReferenceKey, planeKey, _activePriority, subProgramEvaluator2);
			SubProgramInfo info;
			if (true)
			{
				info = subProgramInfo;
			}
			ScriptSubProgram scriptSubProgram = ScriptSubProgram.TryCreate(macroName, info);
			SubProgram subProgram;
			if (6u != 0)
			{
				subProgram = scriptSubProgram;
			}
			if (subProgram == null)
			{
				VisualSubProgram visualSubProgram = new VisualSubProgram(macroName, info);
				if (7u != 0)
				{
					subProgram = visualSubProgram;
				}
			}
			subProgram.Name = name;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			Dictionary<string, object> dictionary2;
			if (5u != 0)
			{
				dictionary2 = dictionary;
			}
			WorkPiece obj = _projectInterface.Get(ActiveWorkpiece.ReferenceKey) as WorkPiece;
			WorkPiece workPiece;
			if (8u != 0)
			{
				workPiece = obj;
			}
			int num = 0;
			int num2 = ((macroParameters != null) ? macroParameters.Length : 0);
			foreach (SubProgramParameter parameter in subProgram.Parameters)
			{
				ParameterType parameterType = parameter.ParameterType;
				Type type = parameter.Type;
				FisicalUnitType fisicalUnitType = parameter.FisicalUnitType;
				switch (parameterType)
				{
				case ParameterType.UserDefined:
					if (num < num2)
					{
						object obj2 = macroParameters[num];
						parameter.Value = _0023_003Dz2i6Pkc77XYejARFi6Q_003D_003D(obj2, type, fisicalUnitType);
						if (type != typeof(string))
						{
							dictionary2.Add(parameter.Name, obj2);
						}
					}
					else
					{
						parameter.Value = parameter.DefaultValue;
					}
					num++;
					break;
				case ParameterType.Tool:
				case ParameterType.Head:
				case ParameterType.Plane:
				case ParameterType.FeedrateProfile:
				case ParameterType.ReferencePosition:
					if (num < num2)
					{
						parameter.Value = macroParameters[num];
					}
					else
					{
						parameter.Value = parameter.DefaultValue;
					}
					num++;
					break;
				case ParameterType.WorkpieceLength:
					parameter.Value = _0023_003Dz2i6Pkc77XYejARFi6Q_003D_003D(workPiece.Length, type, fisicalUnitType);
					break;
				case ParameterType.WorkpieceWidth:
					parameter.Value = _0023_003Dz2i6Pkc77XYejARFi6Q_003D_003D(workPiece.Width, type, fisicalUnitType);
					break;
				case ParameterType.WorkpieceHeight:
					parameter.Value = _0023_003Dz2i6Pkc77XYejARFi6Q_003D_003D(workPiece.Depth, type, fisicalUnitType);
					break;
				}
				switch (parameterType)
				{
				case ParameterType.Tool:
				{
					object value = parameter.Value;
					CoreTool coreTool = null;
					if (value != null)
					{
						string toolName = value.ToString();
						coreTool = _toolInterface.Get(toolName);
					}
					if (coreTool == null && !parameter.IsNullable)
					{
						string message = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706569), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), parameter.Value.ToString(), macroName, name);
						AddToErrorFile(message);
					}
					break;
				}
				case ParameterType.UserDefined:
					_0023_003Dz9a49T1fCdNY7iSj5gw_003D_003D(parameter);
					break;
				}
			}
			object result = _projectInterface.AddSubProgram(ref subProgram, this);
			foreach (KeyValuePair<string, object> item in dictionary2)
			{
				_0023_003DzbumIB86Ykd9r_q2wW14f6ig_003D _0023_003DzbumIB86Ykd9r_q2wW14f6ig_003D = new _0023_003DzbumIB86Ykd9r_q2wW14f6ig_003D();
				_0023_003DzbumIB86Ykd9r_q2wW14f6ig_003D._0023_003DzaiLaOdA_003D = item.Key;
				object value2 = item.Value;
				int num3 = subProgram.Parameters.FindIndex(_0023_003DzbumIB86Ykd9r_q2wW14f6ig_003D._0023_003DziFrzmdKYEDq5OGWjtg_003D_003D);
				if (num3 > -1)
				{
					CompositeField property = new CompositeField(new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706542)), new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706523), num3), new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706514)));
					_projectInterface.CheckExpressions(subProgram.Key, property, value2);
				}
			}
			_0023_003DzZa6VxMFfph7N.Add(new BaseScripting(name, subProgram.Key));
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return result;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706621);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2] { name, macroName };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	private object _0023_003Dz2i6Pkc77XYejARFi6Q_003D_003D(object _0023_003DzrFOLNUw_003D, Type _0023_003DzwfW9sVI_003D, FisicalUnitType _0023_003DzgAGUqSOZhwt7BoPrqw_003D_003D)
	{
		object result;
		if (uint.MaxValue != 0)
		{
			result = _0023_003DzrFOLNUw_003D;
		}
		if ((_0023_003DzwfW9sVI_003D == typeof(double) || _0023_003DzwfW9sVI_003D == typeof(int)) && _0023_003DzrFOLNUw_003D != null)
		{
			string text = _0023_003DzrFOLNUw_003D.ToString().ConvertToCurrentFormat();
			string text2;
			if (8u != 0)
			{
				text2 = text;
			}
			if (StringUtility.IsValid(text2))
			{
				switch (_0023_003DzgAGUqSOZhwt7BoPrqw_003D_003D)
				{
				case FisicalUnitType.Lenght:
				{
					object obj = ProjectInterface.ConvertValueToCurrentUnit(_projectInterface.EvaluateExpression(text2));
					if (5u != 0)
					{
						result = obj;
					}
					break;
				}
				case FisicalUnitType.Speed:
					result = ProjectInterface.ConvertSpeedToCurrentUnit(_projectInterface.EvaluateExpression(text2));
					break;
				}
			}
		}
		return result;
	}

	private void _0023_003Dz9a49T1fCdNY7iSj5gw_003D_003D(SubProgramParameter _0023_003Dz7kp2DDP0cwv_0024)
	{
		try
		{
			if (_0023_003Dz7kp2DDP0cwv_0024.IsMultipleValue && _0023_003Dz7kp2DDP0cwv_0024.Value != null)
			{
				_0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D _0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D = new _0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D();
				_0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D _0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D2;
				if (4u != 0)
				{
					_0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D2 = _0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D;
				}
				object value = _0023_003Dz7kp2DDP0cwv_0024.Value;
				object obj;
				if (5u != 0)
				{
					obj = value;
				}
				string _0023_003Dz9Wcl7CE_003D = obj.ToString();
				if (2u != 0)
				{
					_0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D2._0023_003Dz9Wcl7CE_003D = _0023_003Dz9Wcl7CE_003D;
				}
				SubProgramParameterValue subProgramParameterValue = _0023_003Dz7kp2DDP0cwv_0024.MultipleValues.Find(_0023_003DzWhCq0T2itwL_00241vjz7GZiXEw_003D2._0023_003Dz61ZcLrJP4UhZyo4q2DEDK4E_003D);
				if (subProgramParameterValue != null)
				{
					_0023_003Dz7kp2DDP0cwv_0024.SetDefaultParameterValue(subProgramParameterValue.Name);
				}
			}
		}
		catch
		{
			throw;
		}
	}

	public object ExecMacro(string name, string macroName, params object[] macroParameters)
	{
		_ = -1;
		if (-1 == 0)
		{
		}
		_ = 2;
		if (6 == 0)
		{
		}
		_ = 3;
		if (-1 == 0)
		{
		}
		return CreateMacro(name, macroName, macroParameters);
	}

	public object CreateMacro(string name, string macroName)
	{
		try
		{
			object[] array = default(object[]);
			if (0 == 0)
			{
				array = null;
			}
			SubProgramInfo subProgramInfo = new SubProgramInfo(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface, null, null, null, _activePriority, null);
			SubProgramInfo info;
			if (7u != 0)
			{
				info = subProgramInfo;
			}
			ScriptSubProgram scriptSubProgram = ScriptSubProgram.TryCreate(macroName, info);
			SubProgram subProgram;
			if (3u != 0)
			{
				subProgram = scriptSubProgram;
			}
			if (subProgram == null)
			{
				VisualSubProgram visualSubProgram = new VisualSubProgram(macroName, info);
				if (5u != 0)
				{
					subProgram = visualSubProgram;
				}
			}
			if (subProgram.Parameters.Count > 0)
			{
				subProgram.Parameters.RemoveAll(_0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzvATyibxP_cJkGg5PRi9d4ZQ_003D);
				array = new object[subProgram.Parameters.Count];
				for (int i = 0; i < subProgram.Parameters.Count; i++)
				{
					SubProgramParameter subProgramParameter = subProgram.Parameters[i];
					bool flag = false;
					if (_0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D.TryGetValue(subProgramParameter.Name, out var value))
					{
						flag = true;
					}
					if (subProgramParameter.Type == typeof(bool) && value != null && value.GetType() == typeof(int))
					{
						value = ((Convert.ToInt32(value) != 0) ? true : false);
					}
					array[i] = (flag ? value : subProgramParameter.DefaultValue);
				}
			}
			return CreateMacro(name, macroName, array);
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706621);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2] { name, macroName };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		finally
		{
			_0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D.Clear();
		}
	}

	public object ExecMacro(string name, string macroName, string macroParameters)
	{
		_ = 4;
		if (3 == 0)
		{
		}
		_ = 0;
		if (8 == 0)
		{
		}
		_ = 6;
		if (3 == 0)
		{
		}
		return CreateMacro(name, macroName, macroParameters);
	}

	public object ExecMacro(string name, string macroName)
	{
		_ = -1;
		if (4 == 0)
		{
		}
		_ = 4;
		if (4 == 0)
		{
		}
		_ = 2;
		if (4 == 0)
		{
		}
		return CreateMacro(name, macroName);
	}

	public void SetMacroParam(string name, object value)
	{
		_ = 5;
		if (3 == 0)
		{
		}
		Dictionary<string, object> dictionary = _0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D;
		_ = 3;
		if (-1 == 0)
		{
		}
		if (dictionary.TryGetValue(name, out var _))
		{
			_ = 0;
			if (6 == 0)
			{
			}
			_0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D.Remove(name);
		}
		_0023_003Dz0Im84Z1ao7y1Iagwng_003D_003D.Add(name, value);
	}

	public Operation CreateBladeCut(string name, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", double angle = 90.0, int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, bool cutPositionUpper = true, bool materialPositionLeft = true, double referenceOffset = 0.0, double extraDepth = 0.0)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706502));
			if (uint.MaxValue != 0)
			{
				name = text;
			}
			if (true)
			{
				SetToolCorrection(correction, overMaterial);
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.CreateBladeCut(activeParameters, description, typeOfProcess, tool, head, angle, correction, inputSpeed, rotSpeed, speed, overMaterial, cutPositionUpper, referenceOffset, materialPositionLeft, extraDepth);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706733)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateContourPocket(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.ConcentricalPocket, string tool = "-1", string head = "-1", double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overlap = 50.0, bool finalPass = false, params string[] bossNames)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706720));
			if (5u != 0)
			{
				name = text;
			}
			List<Geometry> list = new List<Geometry>();
			List<Geometry> list2;
			if (5u != 0)
			{
				list2 = list;
			}
			foreach (string name2 in bossNames)
			{
				list2.Add(Exist(name2, exist: true) as Geometry);
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.CreateContourPocket(activeParameters, depth, description, typeOfProcess, tool, head, inputSpeed, rotSpeed, speed, overlap / 100.0, finalPass, list2);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706687)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateContour(string name, double depth, int typeOfContour, int sideOfContour, string operationDescription = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706720));
			if (7u != 0)
			{
				name = text;
			}
			if (0 == 0)
			{
				SetToolCorrection(correction, overMaterial);
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.CreateContour(activeParameters, (TypeOfContour)typeOfContour, (SideOfContour)sideOfContour, depth, operationDescription, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			SetCompensationMode(isCnc: true);
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705788)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateSlot(string name, double depth, string description = "", TypeOfProcess typeOfProcess = TypeOfProcess.GeneralRouting, string tool = "-1", string head = "-1", int correction = 0, double inputSpeed = -1.0, double rotSpeed = -1.0, double speed = -1.0, double overMaterial = 0.0, double angle = 90.0, double? endDepth = null)
	{
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706667));
			if (2u != 0)
			{
				name = text;
			}
			if (8u != 0)
			{
				SetToolCorrection(correction, overMaterial);
			}
			double endDepth2 = (endDepth.HasValue ? endDepth.Value : depth);
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			GeneralRoutingOperation generalRoutingOperation = new GeneralRoutingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			generalRoutingOperation.CreateSlot(activeParameters, depth, description, typeOfProcess, tool, head, correction, inputSpeed, rotSpeed, speed, overMaterial, angle, endDepth2);
			Operations.Add(generalRoutingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(generalRoutingOperation);
			_0023_003Dzdzv73cHjrWgk(generalRoutingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			SetCompensationMode(isCnc: true);
			return generalRoutingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706648)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateDowelDrillingOperation(string name, double x, double y, double dowelOuterLength, string description = "", string tool = "-1", string head = "-1", int dischargeSteps = 0, double rotSpeed = -1.0, double boringSpeed = -1.0, double? securityQuote = null, double glueThickness = 0.5, double? dowelDiameter = null, double? dowelLength = null)
	{
		try
		{
			bool flag;
			if (2u != 0)
			{
				flag = false;
			}
			ScmGroup.XCam.ConfigDataModel.Heads.Head head2;
			if (8u != 0)
			{
				head2 = null;
			}
			int count = _configurationInterface.GetConfigurationMachines(clone: false).Count;
			int num;
			if (5u != 0)
			{
				num = count;
			}
			int i;
			if (uint.MaxValue != 0)
			{
				i = 0;
			}
			for (; i < num; i++)
			{
				bool num2 = _configurationInterface.IsDowelingAllowed(i);
				if (uint.MaxValue != 0)
				{
					flag = num2;
				}
				if (flag)
				{
					head2 = _configurationInterface.GetStandardDowelingHead(i);
					break;
				}
			}
			if (!flag)
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706635), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			double num3 = _0023_003DzmOKN4BadLdZXESQKNA_003D_003D(head2 as StandardDowelingHead, dowelDiameter);
			double num4 = _0023_003DzNWXRh4c0ObjuAcsYZw_003D_003D(head2 as StandardDowelingHead, dowelLength);
			GeomCartesianPoint dowelGeometry = new GeomCartesianPoint(x, y, 0.0)
			{
				IsAbsolute = false
			};
			if (!new DowelObjectModel(new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface), _options).IsDowelInsertable(head2, dowelGeometry, null, ActiveWorkplane.ReferenceKey))
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706327), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			if (!new DowelingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey, num3).IsValidDrillingDowelTool(tool, head))
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706274), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			double depth = num4 - dowelOuterLength + glueThickness;
			double diameter = num3;
			return CreateDrill(name, x, y, depth, diameter, description, TypeOfProcess.Drilling, tool, head, dischargeSteps, rotSpeed, boringSpeed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672), 0.0, securityQuote);
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706483)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateDowelDrillingOperation(string name, object x, object y, object dowelOuterLength, string description = "", string tool = "-1", string head = "-1", object dischargeSteps = null, object rotSpeed = null, object boringSpeed = null, object securityQuote = null, object glueThickness = null, object dowelDiameter = null, object dowelLength = null)
	{
		try
		{
			object obj = ConvertExpressionValueToCurrentUnit(x, FisicalUnitType.Lenght, null);
			object obj2;
			if (6u != 0)
			{
				obj2 = obj;
			}
			object obj3 = ConvertExpressionValueToCurrentUnit(y, FisicalUnitType.Lenght, null);
			object obj4;
			if (true)
			{
				obj4 = obj3;
			}
			ConvertExpressionValueToCurrentUnit(dowelOuterLength, FisicalUnitType.Lenght, null);
			object obj5 = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.UnitLess, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D;
			if (2u != 0)
			{
				_0023_003Dz3keKASA_003D = obj5;
			}
			object obj6 = ConvertExpressionValueToCurrentUnit(boringSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D2;
			if (7u != 0)
			{
				_0023_003Dz3keKASA_003D2 = obj6;
			}
			object obj7 = ConvertExpressionValueToCurrentUnit(securityQuote, FisicalUnitType.Lenght, null);
			object _0023_003Dz3keKASA_003D3;
			if (uint.MaxValue != 0)
			{
				_0023_003Dz3keKASA_003D3 = obj7;
			}
			object _0023_003Dz3keKASA_003D4 = ConvertExpressionValueToCurrentUnit(glueThickness, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706456));
			object _0023_003Dz3keKASA_003D5 = ConvertExpressionValueToCurrentUnit(dowelDiameter, FisicalUnitType.Lenght, null);
			object _0023_003Dz3keKASA_003D6 = ConvertExpressionValueToCurrentUnit(dowelLength, FisicalUnitType.Lenght, null);
			double x2 = _0023_003Dzdn45LMQ_003D<double>(obj2, FisicalUnitType.Lenght);
			double y2 = _0023_003Dzdn45LMQ_003D<double>(obj4, FisicalUnitType.Lenght);
			double dowelOuterLength2 = _0023_003Dzdn45LMQ_003D<double>(dowelOuterLength, FisicalUnitType.Lenght);
			int dischargeSteps2 = _0023_003Dzz65du2JhGB1t(dischargeSteps, 0, FisicalUnitType.UnitLess);
			double rotSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, -1.0, FisicalUnitType.UnitLess);
			double boringSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			double? securityQuote2 = _0023_003Dzz65du2JhGB1t<double?>(_0023_003Dz3keKASA_003D3, null, FisicalUnitType.Lenght);
			double glueThickness2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D4, 0.5, FisicalUnitType.Lenght);
			double? dowelDiameter2 = _0023_003Dzz65du2JhGB1t<double?>(_0023_003Dz3keKASA_003D5, null, FisicalUnitType.Lenght);
			double? dowelLength2 = _0023_003Dzz65du2JhGB1t<double?>(_0023_003Dz3keKASA_003D6, null, FisicalUnitType.Lenght);
			DrillingOperation obj8 = CreateDowelDrillingOperation(name, x2, y2, dowelOuterLength2, description, tool, head, dischargeSteps2, rotSpeed2, boringSpeed2, securityQuote2, glueThickness2, dowelDiameter2, dowelLength2) as DrillingOperation;
			obj8.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), obj2);
			obj8.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), obj4);
			return obj8;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706483)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	private double _0023_003DzmOKN4BadLdZXESQKNA_003D_003D(StandardDowelingHead _0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D, double? _0023_003DzfeEnK_ePLBbN)
	{
		double result = default(double);
		if (0 == 0)
		{
			result = 0.0;
		}
		if (_0023_003DzfeEnK_ePLBbN.HasValue)
		{
			double value = _0023_003DzfeEnK_ePLBbN.Value;
			if (5u != 0)
			{
				result = value;
			}
		}
		else if (_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D != null)
		{
			double dowelDiameter = _0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D.DowelDiameter;
			if (0 == 0)
			{
				result = dowelDiameter;
			}
		}
		else
		{
			result = 8.0;
		}
		return result;
	}

	private double _0023_003DzNWXRh4c0ObjuAcsYZw_003D_003D(StandardDowelingHead _0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D, double? _0023_003Dzb2d4CqtzChY3)
	{
		double num;
		if (2u != 0)
		{
			num = 0.0;
		}
		if (_0023_003Dzb2d4CqtzChY3.HasValue)
		{
			double value = _0023_003Dzb2d4CqtzChY3.Value;
			if (5u != 0)
			{
				return value;
			}
		}
		else
		{
			if (_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D == null)
			{
				return 30.0;
			}
			double dowelLength = _0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D.DowelLength;
			if (5u != 0)
			{
				return dowelLength;
			}
		}
		return num;
	}

	private double _0023_003Dz2tTUx14glRKDzDxwiyCG7Ms_003D(StandardDowelingHead _0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D, double? _0023_003DzbUfuBDdaxNW6x5Y3bw_003D_003D)
	{
		double num;
		if (uint.MaxValue != 0)
		{
			num = 0.0;
		}
		if (_0023_003DzbUfuBDdaxNW6x5Y3bw_003D_003D.HasValue)
		{
			double value = _0023_003DzbUfuBDdaxNW6x5Y3bw_003D_003D.Value;
			if (uint.MaxValue != 0)
			{
				return value;
			}
		}
		else
		{
			if (_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D == null)
			{
				return 20.0;
			}
			double result = _0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D.GlueLength / 2.0;
			if (true)
			{
				return result;
			}
		}
		return num;
	}

	public Operation CreateDowelOperation(string name, double x, double y, double dowelOuterLength, string description = "", double retractDistance = 0.0, double dowelReleaseSpeed = -1.0, double glueThickness = 0.5, double? dowelDiameter = null, double? dowelLength = null, double? approachDistance = null, string head = "-1", double? dowelInsertionDistance = null)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706446));
			if (true)
			{
				name = text;
			}
			bool flag;
			if (8u != 0)
			{
				flag = false;
			}
			StandardDowelingHead _0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D;
			if (8u != 0)
			{
				_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D = null;
			}
			int count = _configurationInterface.GetConfigurationMachines(clone: false).Count;
			int num;
			if (3u != 0)
			{
				num = count;
			}
			for (int i = 0; i < num; i++)
			{
				flag = _configurationInterface.IsDowelingAllowed(i);
				if (flag)
				{
					_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D = _configurationInterface.GetStandardDowelingHead(i);
					break;
				}
			}
			if (!flag)
			{
				ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706635), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			double dowelDiameter2 = _0023_003DzmOKN4BadLdZXESQKNA_003D_003D(_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D, dowelDiameter);
			double dowelLength2 = _0023_003DzNWXRh4c0ObjuAcsYZw_003D_003D(_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D, dowelLength);
			double approachDistance2 = _0023_003Dz2tTUx14glRKDzDxwiyCG7Ms_003D(_0023_003DzH1XvMG9akwSMwHnQlGVXQxs_003D, approachDistance);
			double dowelInsertionDistance2 = 0.0;
			if (dowelInsertionDistance.HasValue)
			{
				dowelInsertionDistance2 = dowelInsertionDistance.Value;
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			DowelingOperation dowelingOperation = new DowelingOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			dowelingOperation.CreateDowelOperation(activeParameters, x, y, description, dowelDiameter2, dowelLength2, dowelOuterLength, approachDistance2, retractDistance, dowelReleaseSpeed, glueThickness, head, dowelInsertionDistance2);
			Operations.Add(dowelingOperation);
			_0023_003Dz_0024IbzEN9jdWmF(dowelingOperation);
			_0023_003Dzdzv73cHjrWgk(dowelingOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return dowelingOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706413)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateDowelOperation(string name, object x, object y, object dowelOuterLength, string description = "", object retractDistance = null, object dowelReleaseSpeed = null, object glueThickness = null, object dowelDiameter = null, object dowelLength = null, object approachDistance = null, string head = "-1", object dowelInsertionDistance = null)
	{
		try
		{
			object obj = ConvertExpressionValueToCurrentUnit(x, FisicalUnitType.Lenght, null);
			object obj2;
			if (4u != 0)
			{
				obj2 = obj;
			}
			object obj3 = ConvertExpressionValueToCurrentUnit(y, FisicalUnitType.Lenght, null);
			object obj4;
			if (8u != 0)
			{
				obj4 = obj3;
			}
			object obj5 = ConvertExpressionValueToCurrentUnit(dowelOuterLength, FisicalUnitType.Lenght, null);
			object propertyValue;
			if (4u != 0)
			{
				propertyValue = obj5;
			}
			object obj6 = ConvertExpressionValueToCurrentUnit(retractDistance, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705770));
			object _0023_003Dz3keKASA_003D;
			if (4u != 0)
			{
				_0023_003Dz3keKASA_003D = obj6;
			}
			object obj7 = ConvertExpressionValueToCurrentUnit(dowelReleaseSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D2;
			if (4u != 0)
			{
				_0023_003Dz3keKASA_003D2 = obj7;
			}
			object obj8 = ConvertExpressionValueToCurrentUnit(glueThickness, FisicalUnitType.Lenght, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706456));
			object obj9;
			if (true)
			{
				obj9 = obj8;
			}
			object obj10 = ConvertExpressionValueToCurrentUnit(dowelDiameter, FisicalUnitType.Lenght, null);
			object obj11 = ConvertExpressionValueToCurrentUnit(dowelLength, FisicalUnitType.Lenght, null);
			object _0023_003Dz3keKASA_003D3 = ConvertExpressionValueToCurrentUnit(approachDistance, FisicalUnitType.Lenght, null);
			object _0023_003Dz3keKASA_003D4 = ConvertExpressionValueToCurrentUnit(dowelInsertionDistance, FisicalUnitType.Lenght, null);
			double x2 = _0023_003Dzdn45LMQ_003D<double>(obj2, FisicalUnitType.Lenght);
			double y2 = _0023_003Dzdn45LMQ_003D<double>(obj4, FisicalUnitType.Lenght);
			double dowelOuterLength2 = _0023_003Dzdn45LMQ_003D<double>(dowelOuterLength, FisicalUnitType.Lenght);
			double retractDistance2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, 0.0, FisicalUnitType.Lenght);
			double dowelReleaseSpeed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			double glueThickness2 = _0023_003Dzz65du2JhGB1t(obj9, 0.5, FisicalUnitType.Lenght);
			double? dowelDiameter2 = _0023_003Dzz65du2JhGB1t<double?>(obj10, null, FisicalUnitType.Lenght);
			double? dowelLength2 = _0023_003Dzz65du2JhGB1t<double?>(obj11, null, FisicalUnitType.Lenght);
			double? approachDistance2 = _0023_003Dzz65du2JhGB1t<double?>(_0023_003Dz3keKASA_003D3, null, FisicalUnitType.Lenght);
			double? dowelInsertionDistance2 = _0023_003Dzz65du2JhGB1t<double?>(_0023_003Dz3keKASA_003D4, null, FisicalUnitType.Lenght);
			DowelingOperation obj12 = CreateDowelOperation(name, x2, y2, dowelOuterLength2, description, retractDistance2, dowelReleaseSpeed2, glueThickness2, dowelDiameter2, dowelLength2, approachDistance2, head, dowelInsertionDistance2) as DowelingOperation;
			obj12.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703641), obj2);
			obj12.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703633), obj4);
			obj12.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706394), propertyValue);
			obj12.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706369), obj9);
			obj12.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705069), obj10);
			obj12.CheckExpression(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705049), obj11);
			return obj12;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706413)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateWorkpiecePressureOperation(string name, double startX, double startY, double endX, double endY, double compression, string description = "", double approachSpeed = -1.0, double workingSpeed = -1.0)
	{
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705031));
			if (4u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (3u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			WorkpiecePressureOperation workpiecePressureOperation = new WorkpiecePressureOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			workpiecePressureOperation.CreateWorkpiecePressureOperation(activeParameters, description, startX, startY, endX, endY, compression, approachSpeed, workingSpeed);
			Operations.Add(workpiecePressureOperation);
			_0023_003Dz_0024IbzEN9jdWmF(workpiecePressureOperation);
			_0023_003Dzdzv73cHjrWgk(workpiecePressureOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return workpiecePressureOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704990)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreatePark(string name, string stopType, bool? toMinQuote)
	{
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<Park>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705211));
			if (7u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (7u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			Parking parking = new Parking(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			parking.CreatePark(activeParameters, stopType, toMinQuote);
			Operations.Add(parking);
			_0023_003Dz_0024IbzEN9jdWmF(parking);
			_0023_003Dzdzv73cHjrWgk(parking);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return parking;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705183)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateWorkPieceProbing(string name, double x, double y, string tool, string head, int type = 0, int headReturnAfterProbing = 0)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<ScmGroup.XCam.MachiningDataModel.WorkPieceProbing>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705169));
			if (2u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (5u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			WorkPieceProbing workPieceProbing = new WorkPieceProbing(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			workPieceProbing.CreateWorkPieceProbing(activeParameters, x, y, tool, head, type, headReturnAfterProbing);
			Operations.Add(workPieceProbing);
			_0023_003Dz_0024IbzEN9jdWmF(workPieceProbing);
			_0023_003Dzdzv73cHjrWgk(workPieceProbing);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return workPieceProbing;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705129)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreatePrismaProbing(string name, object x, object y, string tool, object speed = null)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<ScmGroup.XCam.MachiningDataModel.PrismaProbing>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705108));
			if (4u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters = default(ActiveProgramParameters);
			if (0 == 0)
			{
				activeParameters = activeProgramParameters;
			}
			PrismaProbing prismaProbing = new PrismaProbing(_0023_003Dzv171kDksmsdD());
			prismaProbing.CreatePrismaProbing(activeParameters, name, x, y, tool, speed);
			Operations.Add(prismaProbing);
			_0023_003Dz_0024IbzEN9jdWmF(prismaProbing);
			_0023_003Dzdzv73cHjrWgk(prismaProbing);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return prismaProbing;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705129)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateWorkPieceTranslationRotationProbing(string name, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<ScmGroup.XCam.MachiningDataModel.WorkPieceTranslationRotationProbing>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704813));
			if (4u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (6u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			WorkPieceTranslationRotationProbing workPieceTranslationRotationProbing = new WorkPieceTranslationRotationProbing(_0023_003Dzv171kDksmsdD());
			workPieceTranslationRotationProbing.CreateWorkPieceTranslationRotationProbing(activeParameters, name, probingXFirstPointQuote, probingXSecondPointQuote, probingYPointQuote, probingZQuote, tool, head);
			Operations.Add(workPieceTranslationRotationProbing);
			_0023_003Dz_0024IbzEN9jdWmF(workPieceTranslationRotationProbing);
			_0023_003Dzdzv73cHjrWgk(workPieceTranslationRotationProbing);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return workPieceTranslationRotationProbing;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705129)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateWorkPieceTranslationRotationInternalProbing(string name, object probingXCoordinate, object probingYCoordinate, object probingRectWidth, object probingRectHeight, object probingXFirstPointQuote, object probingXSecondPointQuote, object probingYPointQuote, object probingZQuote, string tool, string head)
	{
		try
		{
			if (2u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<ScmGroup.XCam.MachiningDataModel.WorkPieceTranslationRotationInternalProbing>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704813));
			if (2u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (4u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			WorkPieceTranslationRotationInternalProbing workPieceTranslationRotationInternalProbing = new WorkPieceTranslationRotationInternalProbing(_0023_003Dzv171kDksmsdD());
			workPieceTranslationRotationInternalProbing.CreateWorkPieceTranslationRotationInternalProbing(activeParameters, name, probingXCoordinate, probingYCoordinate, probingRectWidth, probingRectHeight, probingXFirstPointQuote, probingXSecondPointQuote, probingYPointQuote, probingZQuote, tool, head);
			Operations.Add(workPieceTranslationRotationInternalProbing);
			_0023_003Dz_0024IbzEN9jdWmF(workPieceTranslationRotationInternalProbing);
			_0023_003Dzdzv73cHjrWgk(workPieceTranslationRotationInternalProbing);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return workPieceTranslationRotationInternalProbing;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704768)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateMessage(string name, string text, bool waitForUserInput, bool releaseWorkpiece)
	{
		try
		{
			if (2u != 0)
			{
				Flush();
			}
			string text2 = _0023_003Dz9VAJQVxbExpH<Xmsg>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704735));
			if (4u != 0)
			{
				name = text2;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (uint.MaxValue != 0)
			{
				activeParameters = activeProgramParameters;
			}
			SendMessage sendMessage = new SendMessage(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			sendMessage.CreateMessage(activeParameters, text, waitForUserInput, releaseWorkpiece);
			Operations.Add(sendMessage);
			_0023_003Dz_0024IbzEN9jdWmF(sendMessage);
			_0023_003Dzdzv73cHjrWgk(sendMessage);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return sendMessage;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704707)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateNullOperation(string name, double? X, double? Y, double? Q, double? speed, bool? spindleEnable, string tool = "-1")
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<Xn>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704945));
			if (3u != 0)
			{
				name = text;
			}
			NullOperation nullOperation = new NullOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			NullOperation nullOperation2;
			if (6u != 0)
			{
				nullOperation2 = nullOperation;
			}
			ReferenceToolKey toolReference;
			if (tool != _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672))
			{
				List<CoreTool> list = _toolInterface.GetList();
				Predicate<CoreTool> predicate = _0023_003DzJBaCSp8_003D._0023_003DzP6WHDQm8zo9nSDAkbw_003D_003D;
				if (predicate == null)
				{
					predicate = _0023_003DzJBaCSp8_003D._0023_003DzK15DASY_003D._0023_003DzQSrlccopQqzupCEdBGbAIj4_003D;
					Predicate<CoreTool> _0023_003DzP6WHDQm8zo9nSDAkbw_003D_003D = predicate;
					if (uint.MaxValue != 0)
					{
						_0023_003DzJBaCSp8_003D._0023_003DzP6WHDQm8zo9nSDAkbw_003D_003D = _0023_003DzP6WHDQm8zo9nSDAkbw_003D_003D;
					}
				}
				List<CoreTool> list2 = list.FindAll(predicate);
				CoreTool coreTool;
				if (true)
				{
					coreTool = null;
				}
				XilogToolKey.KindOfOriginTool kindOfOriginTool = XilogToolKey.KindOfOriginTool.XilogBoringUnitTool;
				foreach (CoreTool item in list2)
				{
					kindOfOriginTool = ((item as MachiningTool).GetToolKey() as XilogToolKey).KindOfTool;
					if ((item as MachiningTool).Name.Equals(tool))
					{
						switch (kindOfOriginTool)
						{
						case XilogToolKey.KindOfOriginTool.XilogBoringUnitTool:
							coreTool = item;
							goto end_IL_00ee;
						case XilogToolKey.KindOfOriginTool.XilogSpindleUnitTool:
							coreTool = item;
							goto end_IL_00ee;
						}
					}
					continue;
					end_IL_00ee:
					break;
				}
				toolReference = ((!(coreTool != null)) ? new ReferenceToolKey() : new ReferenceToolKey(coreTool.Key, tool));
			}
			else
			{
				toolReference = new ReferenceToolKey();
			}
			if (X.HasValue)
			{
				ActiveX = X.Value;
			}
			if (Y.HasValue)
			{
				ActiveY = Y.Value;
			}
			if (speed.HasValue)
			{
				_0023_003DzZGra6ZgrZzgF(speed.Value);
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			nullOperation2.CreateNullOperation(activeParameters, toolReference, X, Y, Q, speed, spindleEnable);
			Operations.Add(nullOperation2);
			_0023_003Dz_0024IbzEN9jdWmF(nullOperation2);
			_0023_003Dzdzv73cHjrWgk(nullOperation2);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return nullOperation2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704919)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateIso(string name, string instruction, string optionalParameters = "", bool isXiso = true)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<Iso>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704899));
			if (3u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (7u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			ISO iSO = new ISO(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			iSO.CreateIso(activeParameters, instruction, optionalParameters, isXiso);
			Operations.Add(iSO);
			_0023_003Dz_0024IbzEN9jdWmF(iSO);
			_0023_003Dzdzv73cHjrWgk(iSO);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return iSO;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704874)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateCombiflexUnloadUnitClamp(string name, double zQuote, double yOffset)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<ScmGroup.XCam.MachiningDataModel.CombiflexUnloadUnitClamp>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917704864));
			if (6u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (8u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			CombiflexUnloadUnitClamp combiflexUnloadUnitClamp = new CombiflexUnloadUnitClamp(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			combiflexUnloadUnitClamp.CreateCombiflexUnloadUnitClamp(activeParameters, zQuote, yOffset);
			Operations.Add(combiflexUnloadUnitClamp);
			_0023_003Dz_0024IbzEN9jdWmF(combiflexUnloadUnitClamp);
			_0023_003Dzdzv73cHjrWgk(combiflexUnloadUnitClamp);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return combiflexUnloadUnitClamp;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705584)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateWorkPieceWidthProbing(string name, double distance)
	{
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<ScmGroup.XCam.MachiningDataModel.WorkPieceWidthProbing>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705551));
			if (7u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (6u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			WorkPieceWidthProbing workPieceWidthProbing = new WorkPieceWidthProbing(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			workPieceWidthProbing.CreateWorkPieceWidthProbing(activeParameters, distance);
			Operations.Add(workPieceWidthProbing);
			_0023_003Dz_0024IbzEN9jdWmF(workPieceWidthProbing);
			_0023_003Dzdzv73cHjrWgk(workPieceWidthProbing);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return workPieceWidthProbing;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705520)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateStartOnBlowHeater(string name)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003Dz9VAJQVxbExpH<ScmGroup.XCam.MachiningDataModel.StartOnBlowHeater>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705492));
			if (2u != 0)
			{
				name = text;
			}
			ActiveProgramParameters activeProgramParameters = _0023_003DzxAdcAaq1Zrbq();
			ActiveProgramParameters activeParameters;
			if (3u != 0)
			{
				activeParameters = activeProgramParameters;
			}
			StartOnBlowHeater startOnBlowHeater = new StartOnBlowHeater(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			startOnBlowHeater.CreateStartOnBlowHeater(activeParameters);
			Operations.Add(startOnBlowHeater);
			_0023_003Dz_0024IbzEN9jdWmF(startOnBlowHeater);
			_0023_003Dzdzv73cHjrWgk(startOnBlowHeater);
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return startOnBlowHeater;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705717)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public LeadInOut SetApproachStrategy(bool isLinear, bool isQuote, double distance, double? speed = null)
	{
		if (0 == 0)
		{
			Flush();
		}
		if (ActiveLeadInOut == null)
		{
			LeadInOut _0023_003Dz3keKASA_003D = new LeadInOut();
			if (0 == 0)
			{
				_0023_003Dz8DhcByEE_0024hyBLHSgZg_003D_003D(_0023_003Dz3keKASA_003D);
			}
		}
		ActiveLeadInOut.CreateLeadIn(isLinear, isQuote, distance, speed);
		return ActiveLeadInOut;
	}

	public LeadInOut SetRetractStrategy(bool isLinear, bool isQuote, double distance, double overlapLength, double? speed = null)
	{
		if (5u != 0)
		{
			Flush();
		}
		if (ActiveLeadInOut == null)
		{
			LeadInOut _0023_003Dz3keKASA_003D = new LeadInOut();
			if (6u != 0)
			{
				_0023_003Dz8DhcByEE_0024hyBLHSgZg_003D_003D(_0023_003Dz3keKASA_003D);
			}
		}
		ActiveLeadInOut.CreateLeadOut(isLinear, isQuote, distance, overlapLength, speed);
		return ActiveLeadInOut;
	}

	public void ResetApproachStrategy()
	{
		if (true)
		{
			Flush();
		}
		if (ActiveLeadInOut != null)
		{
			ActiveLeadInOut.ResetLeadIn();
		}
	}

	public void ResetRetractStrategy()
	{
		if (4u != 0)
		{
			Flush();
		}
		if (ActiveLeadInOut != null)
		{
			ActiveLeadInOut.ResetLeadOut();
		}
	}

	public Pattern CreatePattern(int numberOfRows, int numberOfColumns, double rowsDistance, double columnDistance, double rotationAngle, double rowLayoutAngle)
	{
		if (uint.MaxValue != 0)
		{
			Flush();
		}
		Pattern pattern = new Pattern();
		Pattern pattern2;
		if (4u != 0)
		{
			pattern2 = pattern;
		}
		pattern2._0023_003DzRbOo_0024DjITOpe(numberOfRows);
		pattern2._0023_003DzykQlgckFtn7c(numberOfColumns);
		pattern2._0023_003Dzmko6ItfWFPAr(rowsDistance);
		pattern2._0023_003Dz52wj2gZUt_0024_y(columnDistance);
		pattern2.RotationAngle = rotationAngle;
		pattern2.RowLayoutAngle = rowLayoutAngle;
		if (7u != 0)
		{
			_0023_003DziVcbCJGQSVJK(pattern2);
		}
		return pattern2;
	}

	public void ResetPattern()
	{
		if (7u != 0)
		{
			Flush();
		}
		if (8u != 0)
		{
			_0023_003DziVcbCJGQSVJK(null);
		}
	}

	public Operation SelectOperation(string name)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			Operation _0023_003Dz3keKASA_003D = Exist(name, exist: true) as Operation;
			if (4u != 0)
			{
				_0023_003Dzdzv73cHjrWgk(_0023_003Dz3keKASA_003D);
			}
			Operation activeOperation = ActiveOperation;
			if (5u != 0)
			{
				return activeOperation;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705693);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Operation result;
		return result;
	}

	public Operation SelectOperation(int index)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			Operation _0023_003Dz3keKASA_003D = _0023_003DzCtl4R_E_003D(index, typeof(Operation)) as Operation;
			if (0 == 0)
			{
				_0023_003Dzdzv73cHjrWgk(_0023_003Dz3keKASA_003D);
			}
			Operation activeOperation = ActiveOperation;
			if (3u != 0)
			{
				return activeOperation;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705648);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		Operation result;
		return result;
	}

	public void DeleteOperation(string name)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			Operation obj = Exist(name, exist: true) as Operation;
			Operation operation;
			if (uint.MaxValue != 0)
			{
				operation = obj;
			}
			MachiningOperation obj2 = _projectInterface.Get(operation.ReferenceKey) as MachiningOperation;
			MachiningOperation operation2;
			if (3u != 0)
			{
				operation2 = obj2;
			}
			_projectInterface.DeleteOperation(operation2, this);
			Operations.Remove(operation);
			if (Operations.Count > 0)
			{
				_0023_003Dzdzv73cHjrWgk(Operations[Operations.Count - 1]);
			}
			else
			{
				_0023_003Dzdzv73cHjrWgk(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705344);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteOperation(int index)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			Operation obj = _0023_003DzCtl4R_E_003D(index, typeof(Operation)) as Operation;
			Operation operation;
			if (6u != 0)
			{
				operation = obj;
			}
			MachiningOperation obj2 = _projectInterface.Get(operation.ReferenceKey) as MachiningOperation;
			MachiningOperation operation2;
			if (true)
			{
				operation2 = obj2;
			}
			_projectInterface.DeleteOperation(operation2, this);
			Operations.Remove(operation);
			if (Operations.Count > 0)
			{
				_0023_003Dzdzv73cHjrWgk(Operations[Operations.Count - 1]);
			}
			else
			{
				_0023_003Dzdzv73cHjrWgk(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705295);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void SetJerk(double gain)
	{
		if (4u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.JerkEnabled = true;
		ActiveMachineFunctions.JerkGain = gain;
	}

	public void ResetJerk()
	{
		if (7u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.JerkEnabled = false;
		ActiveMachineFunctions.JerkGain = 0.0;
	}

	public void SetCNAutoSpeed()
	{
		if (true)
		{
			Flush();
		}
		ActiveMachineFunctions.CNAutoSpeedEnabled = true;
	}

	public void ResetCNAutoSpeed()
	{
		if (true)
		{
			Flush();
		}
		ActiveMachineFunctions.CNAutoSpeedEnabled = false;
	}

	public void SetJerk3D(double gain)
	{
		if (true)
		{
			Flush();
		}
		ActiveMachineFunctions.Jerk3DEnabled = true;
		ActiveMachineFunctions.Jerk3DCorrection = gain;
	}

	public void ResetJerk3D()
	{
		if (6u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.Jerk3DEnabled = false;
		ActiveMachineFunctions.Jerk3DCorrection = 0.0;
	}

	public void SetPneumaticHoodPosition(int? position)
	{
		if (position.HasValue && position.Value > -1)
		{
			if (7u != 0)
			{
				Flush();
			}
			ActiveMachineFunctions.HoodEnabled = true;
			ActiveMachineFunctions.HoodAutoEnabled = false;
			ActiveMachineFunctions.HoodPosition = position.Value;
		}
		else if (7u != 0)
		{
			_0023_003DzITQ71E6DXRK0f8WCxUV2wKHiOwVQ();
		}
	}

	private void _0023_003DzITQ71E6DXRK0f8WCxUV2wKHiOwVQ()
	{
		if (6u != 0)
		{
			Flush();
		}
		WorkPlaneCategory[] array = new WorkPlaneCategory[3];
		if (5u != 0)
		{
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		}
		if (_0023_003Dz880rhFYAL3Y_0024caR08EzofAM_003D(array))
		{
			ActiveMachineFunctions.HoodEnabled = true;
			ActiveMachineFunctions.HoodAutoEnabled = false;
			ActiveMachineFunctions.HoodPosition = 1;
		}
		else
		{
			ActiveMachineFunctions.HoodEnabled = true;
			ActiveMachineFunctions.HoodAutoEnabled = true;
			ActiveMachineFunctions.HoodPosition = 0;
		}
	}

	public void ResetPneumaticHood()
	{
		if (3u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.HoodEnabled = _0023_003Dz8XJ_0024Syd4qr9134wpQWRR5dHaqq8u(_0023_003DzIp0TZ8I_003D: true);
		ActiveMachineFunctions.HoodAutoEnabled = true;
		ActiveMachineFunctions.HoodPosition = 0;
		ActiveMachineFunctions.MotorizedHoodEnabled = _0023_003DzczLIUsGKEiTiMDFsrw56lmmMa_zO(_0023_003DzIp0TZ8I_003D: true);
		ActiveMachineFunctions.MotorizedHoodAutoEnabled = true;
		ActiveMachineFunctions.MotorizedHoodPosition = 0.0;
	}

	public void SetMotorizedHoodPosition(double? position)
	{
		if (position.HasValue && position.Value > -1.0)
		{
			if (5u != 0)
			{
				Flush();
			}
			ActiveMachineFunctions.MotorizedHoodEnabled = true;
			ActiveMachineFunctions.MotorizedHoodAutoEnabled = false;
			ActiveMachineFunctions.MotorizedHoodPosition = position.Value;
		}
		else if (2u != 0)
		{
			_0023_003DzlnUOg6ssOJXMHqczAbqg9xzTNy1a();
		}
	}

	private void _0023_003DzlnUOg6ssOJXMHqczAbqg9xzTNy1a()
	{
		if (true)
		{
			ResetMotorizedHood();
		}
	}

	public void ResetMotorizedHood()
	{
		if (3u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.MotorizedHoodEnabled = _0023_003DzczLIUsGKEiTiMDFsrw56lmmMa_zO(_0023_003DzIp0TZ8I_003D: true);
		ActiveMachineFunctions.MotorizedHoodAutoEnabled = true;
		ActiveMachineFunctions.MotorizedHoodPosition = 0.0;
		ActiveMachineFunctions.HoodEnabled = _0023_003Dz8XJ_0024Syd4qr9134wpQWRR5dHaqq8u(_0023_003DzIp0TZ8I_003D: true);
		ActiveMachineFunctions.HoodAutoEnabled = true;
		ActiveMachineFunctions.HoodPosition = 0;
	}

	public void SetOppositePneumaticHoodPosition(int? position)
	{
		if (position.HasValue && position.Value > -1)
		{
			if (8u != 0)
			{
				Flush();
			}
			ActiveMachineFunctions.OppositeHoodEnabled = true;
			ActiveMachineFunctions.OppositeHoodPosition = position.Value;
		}
	}

	public void ResetOppositePneumaticHood()
	{
		if (true)
		{
			Flush();
		}
		ActiveMachineFunctions.OppositeHoodEnabled = false;
		ActiveMachineFunctions.OppositeHoodPosition = 0;
	}

	public void SetAuxiliaryHoodPosition(int? position)
	{
		if (position.HasValue && position.Value > -1)
		{
			if (7u != 0)
			{
				Flush();
			}
			ActiveMachineFunctions.HoodAuxiliaryEnabled = true;
			ActiveMachineFunctions.HoodAuxiliaryPosition = position.Value;
		}
	}

	public void ResetAuxiliaryHood()
	{
		if (4u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.HoodAuxiliaryEnabled = false;
		ActiveMachineFunctions.HoodAuxiliaryPosition = 0;
	}

	public void SetCleaningMode()
	{
		if (4u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.CleaningModeEnabled = true;
	}

	public void ResetCleaningMode()
	{
		if (0 == 0)
		{
			Flush();
		}
		ActiveMachineFunctions.CleaningModeEnabled = false;
	}

	public void SetDustpanOffset(double offset, int? position = null, bool? isInOutEnable = null)
	{
		if (5u != 0)
		{
			Flush();
		}
		MachineFunctions activeMachineFunctions = ActiveMachineFunctions;
		int? num = position;
		int? num2;
		if (3u != 0)
		{
			num2 = num;
		}
		activeMachineFunctions.DustpanEnabled = !((num2.GetValueOrDefault() == 0) & num2.HasValue);
		ActiveMachineFunctions.DustpanOffset = offset;
		ActiveMachineFunctions.DustpanPosition = (position.HasValue ? position.Value : Convert.ToInt32(value: true));
		ActiveMachineFunctions.DustpanIsInOutEnable = !isInOutEnable.HasValue || isInOutEnable.Value;
	}

	public void SetDustpanOffset(double offset)
	{
		if (7u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.DustpanOffset = offset;
	}

	public void SetDustpanPosition(int? position = null, bool? isInOutEnable = null)
	{
		if (3u != 0)
		{
			Flush();
		}
		MachineFunctions activeMachineFunctions = ActiveMachineFunctions;
		int? num = position;
		int? num2;
		if (4u != 0)
		{
			num2 = num;
		}
		activeMachineFunctions.DustpanEnabled = !((num2.GetValueOrDefault() == 0) & num2.HasValue);
		ActiveMachineFunctions.DustpanPosition = (position.HasValue ? position.Value : Convert.ToInt32(value: true));
		ActiveMachineFunctions.DustpanIsInOutEnable = !isInOutEnable.HasValue || isInOutEnable.Value;
	}

	public void ResetDustpan()
	{
		if (3u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.DustpanEnabled = false;
		ActiveMachineFunctions.DustpanOffset = 0.0;
		ActiveMachineFunctions.DustpanPosition = 0;
		ActiveMachineFunctions.DustpanIsInOutEnable = true;
	}

	public void SetMotorizedDustpanPosition(double? position = null, bool? isInOutEnable = null)
	{
		if (position.HasValue && position.Value > -1.0)
		{
			if (2u != 0)
			{
				Flush();
			}
			ActiveMachineFunctions.MotorizedDustpanEnabled = true;
			ActiveMachineFunctions.MotorizedDustpanAutoEnabled = false;
			ActiveMachineFunctions.MotorizedDustpanPosition = (int)position.Value;
			ActiveMachineFunctions.MotorizedDustpanIsInOutEnable = !isInOutEnable.HasValue || isInOutEnable.Value;
		}
		else if (uint.MaxValue != 0)
		{
			_0023_003DzXnTCCe3fTmMyn3or1uK9pbsa56_0024q();
		}
	}

	public void SetMotorizedDustpanOffset(double offset)
	{
		if (0 == 0)
		{
			Flush();
		}
		ActiveMachineFunctions.MotorizedDustpanOffset = offset;
	}

	private void _0023_003DzXnTCCe3fTmMyn3or1uK9pbsa56_0024q()
	{
		if (4u != 0)
		{
			ResetMotorizedDustpan();
		}
	}

	public void ResetMotorizedDustpan()
	{
		if (5u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.MotorizedDustpanEnabled = true;
		ActiveMachineFunctions.MotorizedDustpanAutoEnabled = true;
		ActiveMachineFunctions.MotorizedDustpanPosition = 0;
		ActiveMachineFunctions.MotorizedDustpanIsInOutEnable = false;
	}

	public void SetRotationDirection(int direction = 0)
	{
		if (3u != 0)
		{
			_0023_003Dzs0BG1bNPGRdq(_0023_003Dz3keKASA_003D: true, (RotationDirections)direction);
		}
	}

	public void ResetRotationDirection()
	{
		if (0 == 0)
		{
			_0023_003Dzs0BG1bNPGRdq(_0023_003Dz3keKASA_003D: false, RotationDirections.Default);
		}
	}

	private void _0023_003Dzs0BG1bNPGRdq(bool _0023_003Dz3keKASA_003D, RotationDirections _0023_003Dz_00249Cj_0024SQ_003D)
	{
		if (0 == 0)
		{
			Flush();
		}
		ActiveMachineFunctions.RotationEnabled = _0023_003Dz3keKASA_003D;
		ActiveMachineFunctions.RotationDirection = _0023_003Dz_00249Cj_0024SQ_003D;
	}

	public void SetAutostart(bool status = true)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzeCcjz0daMT7MBGOaZw_003D_003D(_0023_003Dz3keKASA_003D: true, status);
		}
	}

	public void ResetAutostart()
	{
		if (5u != 0)
		{
			SetAutostart(status: false);
		}
	}

	private void _0023_003DzeCcjz0daMT7MBGOaZw_003D_003D(bool _0023_003Dz3keKASA_003D, bool _0023_003DzrrxXRc4_003D)
	{
		if (3u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.AutostartEnabled = true;
		ActiveMachineFunctions.AutostartStatus = _0023_003DzrrxXRc4_003D;
	}

	public void SetUnrollHeadMode(int mode = 0, double radiusMultiplier = 1.0)
	{
		if (8u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.UnrollHeadMode = mode;
		ActiveMachineFunctions.UnrollHeadModeRadiusMultiplier = radiusMultiplier;
	}

	public void SetUnrollHeadRadiusMultiplier(double radiusMultiplier = 1.0)
	{
		if (4u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.UnrollHeadModeRadiusMultiplier = radiusMultiplier;
	}

	public void SetToolCorrection(int correction, double overMaterial = 0.0)
	{
		if (6u != 0)
		{
			Flush();
		}
		ToolCorrection _0023_003Dz3keKASA_003D = new ToolCorrection();
		if (2u != 0)
		{
			_0023_003Dzwlal3EX7MKh692I9_0024iXByDBTjDBx(_0023_003Dz3keKASA_003D);
		}
		ActiveToolCorrection.CreateToolCorrection(correction, overMaterial);
	}

	public void SetBrakes(string activeBrakes)
	{
		if (0 == 0)
		{
			Flush();
		}
		if (activeBrakes.Contains('1') || activeBrakes.Contains('2') || activeBrakes.Contains('3'))
		{
			string empty = string.Empty;
			string text;
			if (true)
			{
				text = empty;
			}
			string obj = (activeBrakes.Contains('1') ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705247) : string.Empty);
			if (uint.MaxValue != 0)
			{
				text = obj;
			}
			text += (activeBrakes.Contains('2') ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705239) : string.Empty);
			text += (activeBrakes.Contains('3') ? _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705232) : string.Empty);
			if (text.Count() > 0 && text.ElementAt(0) == ',')
			{
				text = text.Substring(1);
			}
			activeBrakes = text;
		}
		ActiveMachineFunctions.ActiveBrakes = activeBrakes;
	}

	public void SetLateralShift(double lateralShift)
	{
		_ = -1;
		if (7 == 0)
		{
		}
		MachineFunctions activeMachineFunctions = ActiveMachineFunctions;
		_ = 7;
		if (3 == 0)
		{
		}
		activeMachineFunctions.LateralShift = lateralShift;
	}

	public void SetToolBlower(int toolBlowerMode)
	{
		if (Enum.IsDefined(typeof(ToolBlowerMode), toolBlowerMode))
		{
			ToolBlowerMode toolBlowerMode2;
			if (8u != 0)
			{
				toolBlowerMode2 = (ToolBlowerMode)toolBlowerMode;
			}
			ActiveMachineFunctions.IsToolBlowerEnabled = true;
			ActiveMachineFunctions.ToolBlowerMode = toolBlowerMode2;
		}
	}

	public void ResetToolBlower()
	{
		_ = 8;
		if (1 == 0)
		{
		}
		ActiveMachineFunctions.IsToolBlowerEnabled = false;
		_ = 0;
		if (false)
		{
		}
		ActiveMachineFunctions.ToolBlowerMode = ToolBlowerMode.Air;
	}

	public void SetChangeHiddenTool(bool status = true)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003DzA8Q_MAB_0024SJGK(_0023_003Dz3keKASA_003D: true, status);
		}
	}

	public void ResetChangeHiddenTool()
	{
		if (4u != 0)
		{
			SetChangeHiddenTool();
		}
	}

	private void _0023_003DzA8Q_MAB_0024SJGK(bool _0023_003Dz3keKASA_003D, bool _0023_003DzrrxXRc4_003D)
	{
		if (7u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.ChangeHiddenToolEnabled = true;
		ActiveMachineFunctions.ChangeHiddenToolStatus = _0023_003DzrrxXRc4_003D;
	}

	public void SetDisableAdvanceEdgeChange(bool status = true)
	{
		if (6u != 0)
		{
			_0023_003DzPh8_NeIrhVAXQ_nvVw_003D_003D(_0023_003Dz3keKASA_003D: true, status);
		}
	}

	public void ResetDisableAdvanceEdgeChange()
	{
		if (true)
		{
			SetDisableAdvanceEdgeChange();
		}
	}

	private void _0023_003DzPh8_NeIrhVAXQ_nvVw_003D_003D(bool _0023_003Dz3keKASA_003D, bool _0023_003DzrrxXRc4_003D)
	{
		if (7u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.DisableAdvanceEdgeChangeEnabled = true;
		ActiveMachineFunctions.DisableAdvanceEdgeChangeStatus = _0023_003DzrrxXRc4_003D;
	}

	public void SetElectronicZeroProber(double gain, double offset, double compression)
	{
		if (true)
		{
			Flush();
		}
		ActiveMachineFunctions.ElectronicZeroProberEnable = true;
		ActiveMachineFunctions.ElectronicZeroProberGain = gain;
		ActiveMachineFunctions.ElectronicZeroProberOffset = offset;
		ActiveMachineFunctions.ElectronicZeroProberCompression = compression;
	}

	public void ResetElectronicZeroProber()
	{
		if (4u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.ElectronicZeroProberEnable = false;
		ActiveMachineFunctions.ElectronicZeroProberGain = 0.0;
		ActiveMachineFunctions.ElectronicZeroProberOffset = 0.0;
		ActiveMachineFunctions.ElectronicZeroProberCompression = 0.0;
	}

	public void SetPressureRollers(double offset)
	{
		if (8u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.IsPressureRollersEnabled = true;
		ActiveMachineFunctions.PressureRollersOffset = offset;
	}

	public void ResetPressureRollers()
	{
		if (8u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.IsPressureRollersEnabled = false;
		ActiveMachineFunctions.PressureRollersOffset = 0.0;
	}

	public void SetMechanicalPresser()
	{
		if (3u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.IsMechanicalPresserEnabled = true;
	}

	public void ResetMechanicalPresser()
	{
		if (2u != 0)
		{
			Flush();
		}
		ActiveMachineFunctions.IsMechanicalPresserEnabled = false;
	}

	public void SetAttribute(string name, double value)
	{
		int num;
		if (6u != 0)
		{
			num = 0;
		}
		if (ActiveGeometry == null)
		{
			return;
		}
		if (ActiveGeometry.IsPolyline)
		{
			int num2 = Math.Max((ActiveGeometry as Polyline).Count - 1, 0);
			if (true)
			{
				num = num2;
			}
		}
		int elementIndex = num;
		if (8u != 0)
		{
			SetAttribute(elementIndex, name, value);
		}
	}

	public void SetParametricAttribute(string name, double value, double uPar)
	{
		int num;
		if (2u != 0)
		{
			num = 0;
		}
		if (ActiveGeometry == null)
		{
			return;
		}
		if (ActiveGeometry.IsPolyline)
		{
			int num2 = Math.Max((ActiveGeometry as Polyline).Count - 1, 0);
			if (0 == 0)
			{
				num = num2;
			}
		}
		int elementIndex = num;
		if (4u != 0)
		{
			SetAttribute(elementIndex, name, value, uPar);
		}
	}

	public void SetAttribute2(string name, double value1, double value2)
	{
		int num;
		if (uint.MaxValue != 0)
		{
			num = 0;
		}
		if (ActiveGeometry == null)
		{
			return;
		}
		if (ActiveGeometry.IsPolyline)
		{
			int num2 = Math.Max((ActiveGeometry as Polyline).Count - 1, 0);
			if (true)
			{
				num = num2;
			}
		}
		int elementIndex = num;
		if (5u != 0)
		{
			SetAttribute2(elementIndex, name, value1, value2);
		}
	}

	public void SetStartPointAttribute(int elementIndex, double value)
	{
		if (ActiveGeometry != null)
		{
			ExtremaMachiningAttribute obj = Attribute.Create(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703049), 0.0) as ExtremaMachiningAttribute;
			OperationAttribute operationAttribute;
			if (5u != 0)
			{
				operationAttribute = obj;
			}
			operationAttribute.UPar = value / 100.0;
			if (operationAttribute != null)
			{
				ActiveAttributes.Add(new StartPointAttribute(operationAttribute, elementIndex));
			}
		}
	}

	public void SetEndPointAttribute(int elementIndex, double value)
	{
		if (ActiveGeometry != null)
		{
			ExtremaMachiningAttribute obj = Attribute.Create(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917702778), 0.0) as ExtremaMachiningAttribute;
			OperationAttribute operationAttribute;
			if (5u != 0)
			{
				operationAttribute = obj;
			}
			operationAttribute.UPar = value / 100.0;
			if (operationAttribute != null)
			{
				ActiveAttributes.Add(new EndPointAttribute(operationAttribute, elementIndex));
			}
		}
	}

	public void SetParametricAttribute2(string name, double value1, double value2, double uPar)
	{
		int num = default(int);
		if (0 == 0)
		{
			num = 0;
		}
		if (ActiveGeometry == null)
		{
			return;
		}
		if (ActiveGeometry.IsPolyline)
		{
			int num2 = Math.Max((ActiveGeometry as Polyline).Count - 1, 0);
			if (8u != 0)
			{
				num = num2;
			}
		}
		int elementIndex = num;
		if (8u != 0)
		{
			SetAttribute2(elementIndex, name, value1, value2, uPar);
		}
	}

	public void SetToolpathAttribute(string name, double value)
	{
		_ = 7;
		if (1 == 0)
		{
		}
		if (ActiveToolpath != null)
		{
			_ = 7;
			if (8 == 0)
			{
			}
			ToolPath activeToolpath = ActiveToolpath;
			_ = 8;
			if (6 == 0)
			{
			}
			activeToolpath.SetAttribute(name, value);
		}
	}

	public ContourParallelStrategy CreateContourParallelStrategy(bool insideToOutSide = true, int rotationDirection = 1, bool allowMultiplePasses = false, double cuttingDepth = 0.0, double finishCuttingDepth = 0.0, int strokeConnectionType = 1, bool isHelicStrategy = false, bool isApproachRetractPassStrategy = false, double allowanceSide = 0.0)
	{
		int num = ((rotationDirection != 0) ? 1 : 0);
		RotDirection rotationDirection2;
		if (true)
		{
			rotationDirection2 = (RotDirection)num;
		}
		int num2 = ((strokeConnectionType != 0) ? 1 : 0);
		StrokeConnectionStrategy strokeConnectionStrategy;
		if (8u != 0)
		{
			strokeConnectionStrategy = (StrokeConnectionStrategy)num2;
		}
		ContourParallelStrategy activeStrategy = new ContourParallelStrategy(insideToOutSide, rotationDirection2, allowMultiplePasses, cuttingDepth, finishCuttingDepth, strokeConnectionStrategy, isHelicStrategy, isApproachRetractPassStrategy, allowanceSide);
		if (4u != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as ContourParallelStrategy;
	}

	public SingleStepDrillingStrategy CreateSingleStepDrillingStrategy()
	{
		SingleStepDrillingStrategy activeStrategy = new SingleStepDrillingStrategy();
		if (uint.MaxValue != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as SingleStepDrillingStrategy;
	}

	public MultiStepDrillingStrategy CreateMultiStepDrillingStrategy(bool isStepDepth, int stepNumber = 1, double stepDepth = 0.0)
	{
		MultiStepDrillingStrategy activeStrategy = new MultiStepDrillingStrategy(isStepDepth, stepNumber, stepDepth);
		if (2u != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as MultiStepDrillingStrategy;
	}

	public BidirectionalMillingStrategy CreateBidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth)
	{
		BidirectionalMillingStrategy activeStrategy = new BidirectionalMillingStrategy(allowMultiplePasses, cuttingDepth, finishCuttingDepth);
		if (2u != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as BidirectionalMillingStrategy;
	}

	public UnidirectionalMillingStrategy CreateUnidirectionalMillingStrategy(bool allowMultiplePasses, double cuttingDepth, double finishCuttingDepth, int strokeConnectionType = 1, bool isApproachRetractPassStrategy = false)
	{
		int num = ((strokeConnectionType != 0) ? 1 : 0);
		StrokeConnectionStrategy strokeConnectionStrategy;
		if (8u != 0)
		{
			strokeConnectionStrategy = (StrokeConnectionStrategy)num;
		}
		UnidirectionalMillingStrategy activeStrategy = new UnidirectionalMillingStrategy(allowMultiplePasses, cuttingDepth, finishCuttingDepth, strokeConnectionStrategy, isApproachRetractPassStrategy);
		if (4u != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as UnidirectionalMillingStrategy;
	}

	public SectioningMillingStrategy CreateSectioningMillingStrategy(double firstCutDepth, double outDistance, double sideMovingDistance = 0.0)
	{
		SectioningMillingStrategy activeStrategy = new SectioningMillingStrategy(firstCutDepth, outDistance, sideMovingDistance);
		if (6u != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as SectioningMillingStrategy;
	}

	public HelicMillingStrategy CreateHelicMillingStrategy(double cuttingDepth, bool allowsFinishCutting, double finishCuttingDepth)
	{
		HelicMillingStrategy activeStrategy = new HelicMillingStrategy(cuttingDepth, allowsFinishCutting, finishCuttingDepth);
		if (6u != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as HelicMillingStrategy;
	}

	public PlaneCutterLocationStrategy CreatePlaneCutterLocationStrategy(double zRotation, double xRotation)
	{
		PlaneCutterLocationStrategy activeStrategy = new PlaneCutterLocationStrategy(zRotation, xRotation);
		if (5u != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as PlaneCutterLocationStrategy;
	}

	public ZigZagMillingStrategy CreateZigZagMillingStrategy(double feedCuttingDepth, double returnCuttingDepth, double finishCuttingDepth)
	{
		ZigZagMillingStrategy activeStrategy = new ZigZagMillingStrategy(feedCuttingDepth, returnCuttingDepth, finishCuttingDepth);
		if (uint.MaxValue != 0)
		{
			_activeStrategy = activeStrategy;
		}
		return _activeStrategy as ZigZagMillingStrategy;
	}

	public EndTrimmingStrategy CreateEndTrimmingStrategy(WorkSide workside, CuttingMethod cuttingMethod, double overMaterial, object overCutLenght = null)
	{
		if (_activeStrategy == null)
		{
			EndTrimmingStrategy activeStrategy = new EndTrimmingStrategy();
			if (true)
			{
				_activeStrategy = activeStrategy;
			}
		}
		else
		{
			(_activeStrategy as EndTrimmingStrategy).Clear();
		}
		(_activeStrategy as EndTrimmingStrategy)._0023_003DzLs1Gkio_003D(workside, cuttingMethod, overMaterial, overCutLenght);
		return _activeStrategy as EndTrimmingStrategy;
	}

	public void SetCompensationMode(bool isCnc)
	{
		if (2u != 0)
		{
			_0023_003DznYqeEHrk04Im = isCnc;
		}
	}

	public void SetStartMachiningPosition(int position)
	{
		if (8u != 0)
		{
			_0023_003Dza01J2_0024_eD1UHFNzD7GMZCIgS2IAk = TypeOfExtremaMachiningAttributePosition.None;
		}
		if (Enum.IsDefined(typeof(TypeOfExtremaMachiningAttributePosition), position))
		{
			if (0 == 0)
			{
				_0023_003Dza01J2_0024_eD1UHFNzD7GMZCIgS2IAk = (TypeOfExtremaMachiningAttributePosition)position;
			}
		}
	}

	public void SetFeedrateProfile(string feedrateProfileName)
	{
		if (uint.MaxValue != 0)
		{
			_0023_003Dz5iq5gpuO12MFlZruNlpTZI0_003D = feedrateProfileName;
		}
	}

	public void ResetFeedrateProfile()
	{
		if (2u != 0)
		{
			_0023_003Dz5iq5gpuO12MFlZruNlpTZI0_003D = null;
		}
	}

	public ToolPath CreateToolpath(string name, double startX, double startY, double startZ)
	{
		try
		{
			if (2u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705221));
			if (5u != 0)
			{
				name = text;
			}
			ToolPath toolPath = new ToolPath(name, _projectInterface);
			ToolPath toolPath2;
			if (4u != 0)
			{
				toolPath2 = toolPath;
			}
			toolPath2.CreateToolpath(startX, startY, startZ, ActiveOperation);
			ToolPaths.Add(toolPath2);
			_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(toolPath2);
			RegisterForFlush(ActiveToolpath);
			return toolPath2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public ToolPath3D CreateToolpath3D(string name, double startX, double startY, double startZ)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			string text = _0023_003DzBzveABk_003D<FreeformOperation>(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705221));
			if (3u != 0)
			{
				name = text;
			}
			ToolPath3D toolPath3D = new ToolPath3D(name, _projectInterface);
			ToolPath3D toolPath3D2;
			if (true)
			{
				toolPath3D2 = toolPath3D;
			}
			toolPath3D2.CreateToolpath(startX, startY, startZ, ActiveOperation);
			ToolPaths.Add(toolPath3D2);
			FreeformOperation freeformOperation = new FreeformOperation();
			freeformOperation.Name = name;
			_projectInterface.AssignName(freeformOperation);
			_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(toolPath3D2);
			RegisterForFlush(ActiveToolpath);
			return toolPath3D2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public ToolPath AddSegmentToToolpath(double endX, double endY, double endZ)
	{
		try
		{
			ActiveToolpath.AddSegmentToToolpath(endX, endY, endZ);
			ToolPath activeToolpath = ActiveToolpath;
			if (uint.MaxValue != 0)
			{
				RegisterForFlush(activeToolpath);
			}
			ToolPath activeToolpath2 = ActiveToolpath;
			if (uint.MaxValue != 0)
			{
				return activeToolpath2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath result;
		return result;
	}

	public ToolPath3D AddSegmentToToolpath(double endX, double endY, double endZ, double? ZRotation = null, double? XRotation = null)
	{
		try
		{
			(ActiveToolpath as ToolPath3D).AddSegmentToToolpath(endX, endY, endZ, ZRotation, XRotation);
			ToolPath activeToolpath = ActiveToolpath;
			if (2u != 0)
			{
				RegisterForFlush(activeToolpath);
			}
			ToolPath3D result = ActiveToolpath as ToolPath3D;
			if (8u != 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (6u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath3D result2;
		return result2;
	}

	public ToolPath AddArc3PointsToToolpath(double p2X, double p2Y, double p3X, double p3Y, double p3Z)
	{
		try
		{
			ActiveToolpath.AddArc3PointsToToolpath(p2X, p2Y, p3X, p3Y, p3Z);
			ToolPath activeToolpath = ActiveToolpath;
			if (6u != 0)
			{
				RegisterForFlush(activeToolpath);
			}
			ToolPath activeToolpath2 = ActiveToolpath;
			if (6u != 0)
			{
				return activeToolpath2;
			}
		}
		catch (Exception ex)
		{
			Exception ex2 = default(Exception);
			if (0 == 0)
			{
				ex2 = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			Exception innerException = ex2;
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath result;
		return result;
	}

	public ToolPath AddArc2PointCenterToToolpath(double endX, double endY, double endZ, double centerX, double centerY, bool isClockwise)
	{
		try
		{
			ActiveToolpath.AddArc2PointCenterToToolpath(endX, endY, endZ, centerX, centerY, isClockwise);
			ToolPath activeToolpath = ActiveToolpath;
			if (5u != 0)
			{
				RegisterForFlush(activeToolpath);
			}
			ToolPath activeToolpath2 = ActiveToolpath;
			if (8u != 0)
			{
				return activeToolpath2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (uint.MaxValue != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath result;
		return result;
	}

	public ToolPath AddArc2PointRadiusToToolpath(double endX, double endY, double endZ, double radius, bool isClockwise, bool isOver180)
	{
		try
		{
			ActiveToolpath.AddArc2PointRadiusToToolpath(endX, endY, endZ, radius, isClockwise, isOver180);
			ToolPath activeToolpath = ActiveToolpath;
			if (5u != 0)
			{
				RegisterForFlush(activeToolpath);
			}
			ToolPath activeToolpath2 = ActiveToolpath;
			if (5u != 0)
			{
				return activeToolpath2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (3u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath result;
		return result;
	}

	public ToolPath AddArcCenterAngleToToolpath(double centerX, double centerY, double endZ, double angle)
	{
		try
		{
			ActiveToolpath.AddArcCenterAngleToToolpath(centerX, centerY, endZ, MathUtility.DegreeToRad(angle));
			ToolPath activeToolpath = ActiveToolpath;
			if (3u != 0)
			{
				RegisterForFlush(activeToolpath);
			}
			ToolPath activeToolpath2 = ActiveToolpath;
			if (4u != 0)
			{
				return activeToolpath2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705464);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				string.Empty,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707091)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath result;
		return result;
	}

	public ToolPath SelectToolpath(string name)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			ToolPath _0023_003Dz3keKASA_003D = Exist(name, exist: true) as ToolPath;
			if (0 == 0)
			{
				_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(_0023_003Dz3keKASA_003D);
			}
			ToolPath activeToolpath = ActiveToolpath;
			if (6u != 0)
			{
				return activeToolpath;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705423);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath result;
		return result;
	}

	public ToolPath SelectToolpath(int index)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			ToolPath _0023_003Dz3keKASA_003D = _0023_003DzCtl4R_E_003D(index, typeof(ToolPath)) as ToolPath;
			if (uint.MaxValue != 0)
			{
				_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(_0023_003Dz3keKASA_003D);
			}
			ToolPath activeToolpath = ActiveToolpath;
			if (5u != 0)
			{
				return activeToolpath;
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705377);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
		ToolPath result;
		return result;
	}

	public void DeleteToolpath(string name)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			ToolPath obj = Exist(name, exist: true) as ToolPath;
			ToolPath toolPath;
			if (7u != 0)
			{
				toolPath = obj;
			}
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation obj2 = _projectInterface.Get(toolPath.ReferenceKey) as ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation;
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (uint.MaxValue != 0)
			{
				operation = obj2;
			}
			operation.ToolpathList = new List<Toolpath>();
			_projectInterface.UpdateOperation(operation, this);
			ToolPaths.Remove(toolPath);
			if (ToolPaths.Count > 0)
			{
				_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(ToolPaths[ToolPaths.Count - 1]);
			}
			else
			{
				_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712244);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void DeleteToolpath(int index)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			ToolPath obj = _0023_003DzCtl4R_E_003D(index, typeof(ToolPath)) as ToolPath;
			ToolPath toolPath;
			if (7u != 0)
			{
				toolPath = obj;
			}
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation obj2 = _projectInterface.Get(toolPath.ReferenceKey) as ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation;
			ScmGroup.XCam.MachiningDataModel.ProjectModule.Operation operation;
			if (3u != 0)
			{
				operation = obj2;
			}
			operation.ToolpathList = new List<Toolpath>();
			_projectInterface.UpdateOperation(operation, this);
			ToolPaths.Remove(toolPath);
			if (ToolPaths.Count > 0)
			{
				_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(ToolPaths[ToolPaths.Count - 1]);
			}
			else
			{
				_0023_003DzOfLcA5AfPCXjnUXSbIZj1Xk_003D(null);
			}
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712198);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { index.ToString() };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Tool GetTool(string tool)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			Tool tool2 = new Tool(_toolInterface);
			tool2.CreateTool(tool);
			if (2u != 0)
			{
				return tool2;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (6u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712149), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		Tool result;
		return result;
	}

	public void Mirror(string name, bool mirrorX, bool mirrorY, bool reverseOperation = false, bool createNewCopy = false)
	{
		try
		{
			if (8u != 0)
			{
				Flush();
			}
			if (!mirrorX && !mirrorY)
			{
				return;
			}
			MirrorType mirrorType;
			if (true)
			{
				mirrorType = MirrorType.X;
			}
			if (mirrorX && !mirrorY)
			{
				if (2u != 0)
				{
					mirrorType = MirrorType.X;
				}
			}
			else if (!mirrorX && mirrorY)
			{
				mirrorType = MirrorType.Y;
			}
			else if (mirrorX && mirrorY)
			{
				mirrorType = MirrorType.XY;
			}
			BaseScripting baseScripting = Exist(name, exist: true);
			_projectInterface.Mirror(baseScripting.ReferenceKey, mirrorType, reverseOperation, createNewCopy: false);
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712372);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void Rotate(string name, double x, double y, double angle, bool createNewCopy = false)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			BaseScripting baseScripting = Exist(name, exist: true);
			BaseScripting baseScripting2;
			if (2u != 0)
			{
				baseScripting2 = baseScripting;
			}
			double num = MathUtility.ConvertToRadians(angle);
			double angle2;
			if (8u != 0)
			{
				angle2 = num;
			}
			_projectInterface.Rotate(baseScripting2.ReferenceKey, x, y, angle2, createNewCopy, this);
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712338);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Arc CreateFillet(string geom1, string geom2, double radius, int option)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			Geometry obj = Exist(geom1, exist: true) as Geometry;
			Geometry geometry;
			if (7u != 0)
			{
				geometry = obj;
			}
			Geometry obj2 = Exist(geom2, exist: true) as Geometry;
			Geometry geometry2;
			if (8u != 0)
			{
				geometry2 = obj2;
			}
			FilletType filletType = _0023_003DzsWJ3VRWpMkR_8_0024RvzQ_003D_003D(option);
			GeomTrimmedCurve geometry3 = FilletChamfer.Fillet(_projectInterface, new SelectionKey(geometry.ReferenceKey), new SelectionKey(geometry2.ReferenceKey), radius, filletType) as GeomTrimmedCurve;
			Arc arc = new Arc(_projectInterface, geometry3);
			Geometries.Add(arc);
			_0023_003DzgGGOgZJ8OzTN(arc);
			return arc;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712304);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2] { geom1, geom2 };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Polyline CreateFillet(string geom, string element1, string element2, double radius, int option)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			Polyline obj = Exist(geom, exist: true) as Polyline;
			Polyline polyline;
			if (true)
			{
				polyline = obj;
			}
			int num = polyline.ExistElement(element1, exist: true);
			int index;
			if (8u != 0)
			{
				index = num;
			}
			int index2 = polyline.ExistElement(element2, exist: true);
			FilletType filletType = _0023_003DzsWJ3VRWpMkR_8_0024RvzQ_003D_003D(option);
			GeomCompositeCurve geometry = FilletChamfer.Fillet(_projectInterface, new SelectionKey(polyline.ReferenceKey, index), new SelectionKey(polyline.ReferenceKey, index2), radius, filletType) as GeomCompositeCurve;
			Polyline polyline2 = new Polyline(_projectInterface, geometry);
			Geometries.Add(polyline2);
			_0023_003DzgGGOgZJ8OzTN(polyline2);
			return polyline2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707078);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[3] { element1, element2, geom };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Polyline CreateFillet(string geom, int element1, int element2, double radius, int option)
	{
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			Polyline obj = Exist(geom, exist: true) as Polyline;
			Polyline polyline;
			if (2u != 0)
			{
				polyline = obj;
			}
			FilletType num = _0023_003DzsWJ3VRWpMkR_8_0024RvzQ_003D_003D(option);
			FilletType filletType;
			if (4u != 0)
			{
				filletType = num;
			}
			GeomCompositeCurve geometry = FilletChamfer.Fillet(_projectInterface, new SelectionKey(polyline.ReferenceKey, element1), new SelectionKey(polyline.ReferenceKey, element2), radius, filletType) as GeomCompositeCurve;
			Polyline polyline2 = new Polyline(_projectInterface, geometry);
			Geometries.Add(polyline2);
			_0023_003DzgGGOgZJ8OzTN(polyline2);
			return polyline2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707078);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[3]
			{
				element1.ToString(),
				element2.ToString(),
				geom
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Segment CreateChamfer(string geom1, string geom2, double length1, double length2, int option)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			Geometry obj = Exist(geom1, exist: true) as Geometry;
			Geometry geometry;
			if (4u != 0)
			{
				geometry = obj;
			}
			Geometry obj2 = Exist(geom2, exist: true) as Geometry;
			Geometry geometry2;
			if (5u != 0)
			{
				geometry2 = obj2;
			}
			ChamferType chamferType = _0023_003DzMCzNT_00243X5n1ZW73_nw_003D_003D(option);
			GeomTrimmedCurve geometry3 = FilletChamfer.Chamfer(_projectInterface, new SelectionKey(geometry.ReferenceKey), new SelectionKey(geometry2.ReferenceKey), length1, length2, chamferType) as GeomTrimmedCurve;
			Segment segment = new Segment(_projectInterface, geometry3);
			Geometries.Add(segment);
			_0023_003DzgGGOgZJ8OzTN(segment);
			return segment;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712266);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2] { geom1, geom2 };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Polyline CreateChamfer(string geom, string element1, string element2, double length1, double length2, int option)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			Polyline obj = Exist(geom, exist: true) as Polyline;
			Polyline polyline;
			if (4u != 0)
			{
				polyline = obj;
			}
			int num = polyline.ExistElement(element1, exist: true);
			int index;
			if (4u != 0)
			{
				index = num;
			}
			int index2 = polyline.ExistElement(element2, exist: true);
			ChamferType chamferType = _0023_003DzMCzNT_00243X5n1ZW73_nw_003D_003D(option);
			GeomCompositeCurve geometry = FilletChamfer.Chamfer(_projectInterface, new SelectionKey(polyline.ReferenceKey, index), new SelectionKey(polyline.ReferenceKey, index2), length1, length2, chamferType) as GeomCompositeCurve;
			Polyline polyline2 = new Polyline(_projectInterface, geometry);
			Geometries.Add(polyline2);
			_0023_003DzgGGOgZJ8OzTN(polyline2);
			return polyline2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707036);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[3] { element1, element2, geom };
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Polyline CreateChamfer(string geom, int element1, int element2, double length1, double length2, int option)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			Polyline obj = Exist(geom, exist: true) as Polyline;
			Polyline polyline = default(Polyline);
			if (0 == 0)
			{
				polyline = obj;
			}
			ChamferType num = _0023_003DzMCzNT_00243X5n1ZW73_nw_003D_003D(option);
			ChamferType chamferType;
			if (4u != 0)
			{
				chamferType = num;
			}
			GeomCompositeCurve geometry = FilletChamfer.Chamfer(_projectInterface, new SelectionKey(polyline.ReferenceKey, element1), new SelectionKey(polyline.ReferenceKey, element2), length1, length2, chamferType) as GeomCompositeCurve;
			Polyline polyline2 = new Polyline(_projectInterface, geometry);
			Geometries.Add(polyline2);
			_0023_003DzgGGOgZJ8OzTN(polyline2);
			return polyline2;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917707036);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[3]
			{
				element1.ToString(),
				element2.ToString(),
				geom
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void SetIncrementalInput(string axis, bool enable)
	{
		if (7u != 0)
		{
			Flush();
		}
		if (_0023_003DzGQlGvX_qgE_0024b.TryGetValue(axis, out var _))
		{
			_0023_003DzGQlGvX_qgE_0024b[axis] = enable;
		}
	}

	public bool GetIncrementalInput(string axis)
	{
		_ = 8;
		if (5 == 0)
		{
		}
		Dictionary<string, bool> dictionary = _0023_003DzGQlGvX_qgE_0024b;
		_ = 4;
		if (3 == 0)
		{
		}
		if (dictionary.TryGetValue(axis, out var value))
		{
			bool result = value;
			_ = 0;
			if (4 == 0)
			{
			}
			return result;
		}
		return false;
	}

	public void SetRotation(double angle, double x, double y, double z)
	{
		if (0 == 0)
		{
			Flush();
		}
		ActiveTransformation.SetRotation(angle, x, y, z);
	}

	public void SetTranslation(double x, double y, double z, string planeName)
	{
		if (0 == 0)
		{
			Flush();
		}
		ActiveTransformation.SetTranslation(x, y, z, planeName);
	}

	public void SetMirror(bool mirrorX, bool mirrorY, bool arcInversion)
	{
		if (8u != 0)
		{
			Flush();
		}
		ActiveTransformation.SetMirror(mirrorX, mirrorY, arcInversion);
	}

	public void SetMirrorX(bool mirror, bool arcInversion)
	{
		if (6u != 0)
		{
			Flush();
		}
		ActiveTransformation.SetMirrorX(mirror, arcInversion);
	}

	public void SetMirrorY(bool mirror, bool arcInversion)
	{
		if (2u != 0)
		{
			Flush();
		}
		ActiveTransformation.SetMirrorY(mirror, arcInversion);
	}

	public void SetApproachSecurityDistance(double? value = null)
	{
		if (6u != 0)
		{
			_approachSecurityPlane = value;
		}
	}

	public void SetRetractSecurityDistance(double? value = null)
	{
		if (2u != 0)
		{
			_retractSecurityPlane = value;
		}
	}

	public void SetMachiningDirection(bool sameDirection)
	{
		if (3u != 0)
		{
			_0023_003DzYuaGHaZ5av3_0024E_00243Rf_U6U2c_003D = sameDirection;
		}
	}

	public MachineParameters SetMachiningParameters(string executionFields, int repetitions, long tableOptions, long mechanicalOptions, bool continuousCycle)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetMachiningParameters(executionFields, repetitions, tableOptions, mechanicalOptions, continuousCycle);
			if (3u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (6u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters GetMachiningParameters()
	{
		try
		{
			if (true)
			{
				Flush();
			}
			MachineParameters result = new MachineParameters(_projectInterface);
			if (0 == 0)
			{
				return result;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711919), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result2 = default(MachineParameters);
		return result2;
	}

	public MachineParameters SetSideStopPositionY(double positionY)
	{
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetSideStopPositionY(positionY);
			if (0 == 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result = default(MachineParameters);
		return result;
	}

	public MachineParameters SetRelatedToOppositeSideStop(bool isRelatedToOppositeSideStop)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetRelatedToOppositeSideStop(isRelatedToOppositeSideStop);
			if (8u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException = default(Exception);
			if (0 == 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetDefaultForTableOptions(bool useDefaultForTableOptions)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetDefaultForTableOptions(useDefaultForTableOptions);
			if (0 == 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (6u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result = default(MachineParameters);
		return result;
	}

	public MachineParameters SetTechnologicalMirror(bool isTechnologicalMirror)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetTechnologicalMirror(isTechnologicalMirror);
			if (3u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetAutoSetup(bool autoSetup)
	{
		try
		{
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetAutoSetup(autoSetup);
			if (true)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetOptimization(bool enableOptimization)
	{
		try
		{
			if (2u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetOptimization(enableOptimization);
			if (7u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (3u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetComment(string comment)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetComment(comment);
			if (0 == 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (6u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result = default(MachineParameters);
		return result;
	}

	public MachineParameters SetDescription(string description)
	{
		try
		{
			if (true)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetDescription(description);
			if (2u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (true)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetWorkPieceSidePresserDisabledOnStart(bool isWorkPieceSidePresserDisabledOnStart)
	{
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetWorkPieceSidePresserDisabledOnStart(isWorkPieceSidePresserDisabledOnStart);
			if (4u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (uint.MaxValue != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetPreserveWorkingSequence(bool preserveWorkingSequence)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetPreserveWorkingSequence(preserveWorkingSequence);
			if (5u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetMultipleDrillingsCanChangeWorkingSequence(bool multipleDrillingsCanChangeWorkingSequence)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetMultipleDrillingsCanChangeWorkingSequence(multipleDrillingsCanChangeWorkingSequence);
			if (7u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (7u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetWorkPieceFallPrevention(bool useWorkPieceFallPrevention)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetWorkPieceFallPrevention(useWorkPieceFallPrevention);
			if (true)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (5u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetToeKickWait(bool waitForLeftToeKick, bool waitForRightToeKick)
	{
		try
		{
			if (0 == 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetToeKickWait(waitForLeftToeKick, waitForRightToeKick);
			if (5u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (uint.MaxValue != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetEdgeBandingOptimization(bool isRotationOptimizationEnabled, bool isAutostartOptimizationEnabled, bool isClosingOptimizationEnabled, bool isLampOptimizationEnabled, bool isApproachOptimizationEnabled, bool isRetractOptimizationEnabled, bool isRollStopOptimizationEnabled, bool isSpeedOptimizationEnabled, bool isTrimmingOptimizationEnabled)
	{
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetEdgeBandingOptimization(isRotationOptimizationEnabled, isAutostartOptimizationEnabled, isClosingOptimizationEnabled, isLampOptimizationEnabled, isApproachOptimizationEnabled, isRetractOptimizationEnabled, isRollStopOptimizationEnabled, isSpeedOptimizationEnabled, isTrimmingOptimizationEnabled);
			if (6u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (4u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711969), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public MachineParameters SetEnableDynamicAreas(bool enableDynamicAreas)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			MachineParameters machineParameters = new MachineParameters(_projectInterface);
			machineParameters.SetEnableDynamicAreas(_configurationInterface, enableDynamicAreas);
			if (8u != 0)
			{
				return machineParameters;
			}
		}
		catch (Exception ex)
		{
			Exception innerException;
			if (8u != 0)
			{
				innerException = ex;
			}
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712125), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		MachineParameters result;
		return result;
	}

	public void ApplyTechnology(string name)
	{
		ProjectInterface value;
		if (true)
		{
			value = null;
		}
		try
		{
			if (ActiveGeometry == null)
			{
				return;
			}
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			if (!_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D.TryGetValue(name, out value))
			{
				string text = Path.Combine(AppInfo.TechnologiesDir, name + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712078));
				string text2;
				if (8u != 0)
				{
					text2 = text;
				}
				if (FileUtility.IsTchx(text2))
				{
					ProjectInterface projectInterface = new ProjectInterface(enableEventExecution: false, enableTransactions: false);
					if (5u != 0)
					{
						value = projectInterface;
					}
					TchxProjectIOModel tchxProjectIOModel = new TchxProjectIOModel();
					try
					{
						tchxProjectIOModel.Open(text2);
						tchxProjectIOModel.LoadProject(value);
					}
					finally
					{
						((IDisposable)tchxProjectIOModel).Dispose();
					}
					_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D.Add(name, value);
				}
			}
			if (value != null)
			{
				List<Executable> technologyEntities = value.GetTechnologyEntities();
				if (technologyEntities != null && technologyEntities.Count > 0 && ActiveGeometry.ReferenceKey.IsValid)
				{
					TechnologyProjectModel technologyProjectModel = new TechnologyProjectModel(new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface));
					List<TechnologyTargetEntity> technologyTargetEntities = new List<TechnologyTargetEntity>
					{
						new TechnologyTargetEntity
						{
							EntityKey = ActiveGeometry.ReferenceKey
						}
					};
					ReferenceKey referenceKey = ActiveWorkplan.ReferenceKey;
					technologyProjectModel.ApplyTechnology(index: _0023_003Dz0RCufrX8nq37(technologyEntities, referenceKey), sourceProjectInterface: value, sourceExecutables: technologyEntities, technologyTargetEntities: technologyTargetEntities, targetMainWorkplanKey: referenceKey);
				}
				return;
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712066);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				AppInfo.TechnologiesDir
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
		}
		catch (Exception innerException)
		{
			string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712025);
			string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, innerException, parameters);
		}
	}

	private int _0023_003Dz0RCufrX8nq37(List<Executable> _0023_003DzYUpb009IrwrGtAGtsctscxE_003D, ReferenceKey _0023_003DzTvGck7l1kbSJTgjAtg_003D_003D)
	{
		int result = default(int);
		if (0 == 0)
		{
			result = -1;
		}
		if (_0023_003DzYUpb009IrwrGtAGtsctscxE_003D != null && _0023_003DzYUpb009IrwrGtAGtsctscxE_003D.Count > 1)
		{
			if (_0023_003DzTvGck7l1kbSJTgjAtg_003D_003D == null || !_0023_003DzTvGck7l1kbSJTgjAtg_003D_003D.IsValid)
			{
				ReferenceKey workplanKey = _projectInterface.GetWorkplanKey();
				if (uint.MaxValue != 0)
				{
					_0023_003DzTvGck7l1kbSJTgjAtg_003D_003D = workplanKey;
				}
			}
			List<Executable> mainWorkplanExecutables = _projectInterface.GetMainWorkplanExecutables(_0023_003DzTvGck7l1kbSJTgjAtg_003D_003D);
			List<Executable> list = default(List<Executable>);
			if (0 == 0)
			{
				list = mainWorkplanExecutables;
			}
			if (list.Count > 0)
			{
				result = list.Count;
			}
		}
		return result;
	}

	public void SelectTechnology(string name, params string[] geometryNames)
	{
		ProjectInterface value;
		if (4u != 0)
		{
			value = null;
		}
		try
		{
			if (2u != 0)
			{
				Flush();
			}
			if (8u != 0)
			{
				_0023_003DzZOWKgSslqFdz2EEA8WcrVnA_003D = name;
			}
			if (!_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D.TryGetValue(name, out value))
			{
				string text = Path.Combine(AppInfo.TechnologiesDir, name + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712078));
				string text2;
				if (6u != 0)
				{
					text2 = text;
				}
				if (FileUtility.IsTchx(text2))
				{
					value = new ProjectInterface(enableEventExecution: false, enableTransactions: false);
					TechnologyConfig technologyConfig = new TechnologyConfig();
					TchxProjectIOModel tchxProjectIOModel = new TchxProjectIOModel();
					try
					{
						tchxProjectIOModel.Open(text2);
						tchxProjectIOModel.LoadProject(value);
						tchxProjectIOModel.LoadTechnologyConfig(value, technologyConfig);
					}
					finally
					{
						((IDisposable)tchxProjectIOModel).Dispose();
					}
					_0023_003Dzag4iMeQOAldNe80NovqNVZU_003D = technologyConfig.ExecutableInfos;
					_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D.Add(name, value);
				}
			}
			if (value != null)
			{
				if (geometryNames != null && geometryNames.Length != 0)
				{
					foreach (string text3 in geometryNames)
					{
						TechnologyTargetEntity technologyTargetEntity = new TechnologyTargetEntity();
						Geometry geometry = Exist(text3, exist: true) as Geometry;
						technologyTargetEntity.EntityKey = geometry.ReferenceKey;
						_0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D.Add(text3, geometry.ReferenceKey);
					}
					return;
				}
				throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712757), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
			}
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712066);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				AppInfo.TechnologiesDir
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
		}
		catch (Exception innerException)
		{
			string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712025);
			string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[1] { name };
			throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, innerException, parameters);
		}
	}

	public void SelectGeometryTechnology(string name, int r, int g, int b)
	{
		if (!StringUtility.IsValid(name))
		{
			return;
		}
		Color color = Color.FromRgb((byte)r, (byte)g, (byte)b);
		Color color2;
		if (3u != 0)
		{
			color2 = color;
		}
		_0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D.TryGetValue(name, out var value);
		if (value != null)
		{
			List<TechnologyExecutableInfo>.Enumerator enumerator = _0023_003Dzag4iMeQOAldNe80NovqNVZU_003D.GetEnumerator();
			List<TechnologyExecutableInfo>.Enumerator enumerator2;
			if (true)
			{
				enumerator2 = enumerator;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					TechnologyExecutableInfo current = enumerator2.Current;
					TechnologyExecutableInfo technologyExecutableInfo;
					if (true)
					{
						technologyExecutableInfo = current;
					}
					if (technologyExecutableInfo.Color == color2)
					{
						TechnologyTargetEntity technologyTargetEntity = new TechnologyTargetEntity();
						technologyTargetEntity.EntityKey = value;
						technologyTargetEntity.TechnologyKey = technologyExecutableInfo.Key;
						_0023_003DzULPFoR3ylpZ_0024GhXQfxwoABs_003D.Add(technologyTargetEntity);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
			_0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D.Remove(name);
			return;
		}
		throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712757), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
	}

	public void ApplyTechnology()
	{
		Dictionary<string, ReferenceKey>.Enumerator enumerator = _0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D.GetEnumerator();
		Dictionary<string, ReferenceKey>.Enumerator enumerator2;
		if (true)
		{
			enumerator2 = enumerator;
		}
		try
		{
			KeyValuePair<string, ReferenceKey> keyValuePair = default(KeyValuePair<string, ReferenceKey>);
			while (enumerator2.MoveNext())
			{
				KeyValuePair<string, ReferenceKey> current = enumerator2.Current;
				if (0 == 0)
				{
					keyValuePair = current;
				}
				TechnologyTargetEntity technologyTargetEntity = new TechnologyTargetEntity();
				TechnologyTargetEntity technologyTargetEntity2;
				if (8u != 0)
				{
					technologyTargetEntity2 = technologyTargetEntity;
				}
				technologyTargetEntity2.EntityKey = keyValuePair.Value;
				technologyTargetEntity2.TechnologyKey = null;
				_0023_003DzULPFoR3ylpZ_0024GhXQfxwoABs_003D.Add(technologyTargetEntity2);
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
		TechnologyProjectModel technologyProjectModel = new TechnologyProjectModel(new POMContext(_projectInterface, _toolInterface, _edgeInterface, _configurationInterface));
		_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D.TryGetValue(_0023_003DzZOWKgSslqFdz2EEA8WcrVnA_003D, out var value);
		if (value != null)
		{
			List<Executable> technologyEntities = value.GetTechnologyEntities();
			technologyProjectModel.ApplyTechnology(value, technologyEntities, _0023_003DzULPFoR3ylpZ_0024GhXQfxwoABs_003D, ActiveWorkplan.ReferenceKey, -1);
			_0023_003DzZOWKgSslqFdz2EEA8WcrVnA_003D = null;
			if (_0023_003Dzag4iMeQOAldNe80NovqNVZU_003D != null)
			{
				_0023_003Dzag4iMeQOAldNe80NovqNVZU_003D.Clear();
			}
			if (_0023_003DzULPFoR3ylpZ_0024GhXQfxwoABs_003D != null)
			{
				_0023_003DzULPFoR3ylpZ_0024GhXQfxwoABs_003D.Clear();
			}
			if (_0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D != null)
			{
				_0023_003Dz3TE6oyxAwKjcg_6_00249u9PqIw_003D.Clear();
			}
			return;
		}
		string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712025);
		string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
		object[] parameters = new string[1] { _0023_003DzZOWKgSslqFdz2EEA8WcrVnA_003D };
		throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
	}

	public double abs(double value)
	{
		_ = 3;
		if (6 == 0)
		{
		}
		return Math.Abs(value);
	}

	public double ABS(double value)
	{
		_ = 1;
		if (3 == 0)
		{
		}
		return Math.Abs(value);
	}

	public double acos(double value)
	{
		_ = 6;
		if (6 == 0)
		{
		}
		return MathUtility.RadToDegree(Math.Acos(value));
	}

	public double ACOS(double value)
	{
		_ = -1;
		if (2 == 0)
		{
		}
		return MathUtility.RadToDegree(Math.Acos(value));
	}

	public double asin(double value)
	{
		_ = 7;
		if (3 == 0)
		{
		}
		return MathUtility.RadToDegree(Math.Asin(value));
	}

	public double ASIN(double value)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		return MathUtility.RadToDegree(Math.Asin(value));
	}

	public double atan(double value)
	{
		_ = 8;
		if (8 == 0)
		{
		}
		return MathUtility.RadToDegree(Math.Atan(value));
	}

	public double ATAN(double value)
	{
		_ = 6;
		if (7 == 0)
		{
		}
		return MathUtility.RadToDegree(Math.Atan(value));
	}

	public double sin(double value)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		return Math.Sin(MathUtility.DegreeToRad(value));
	}

	public double SIN(double value)
	{
		_ = 4;
		if (3 == 0)
		{
		}
		return Math.Sin(MathUtility.DegreeToRad(value));
	}

	public double cos(double value)
	{
		_ = 6;
		if (4 == 0)
		{
		}
		return Math.Cos(MathUtility.DegreeToRad(value));
	}

	public double COS(double value)
	{
		_ = -1;
		if (3 == 0)
		{
		}
		return Math.Cos(MathUtility.DegreeToRad(value));
	}

	public double tan(double value)
	{
		_ = 7;
		if (5 == 0)
		{
		}
		return Math.Tan(MathUtility.DegreeToRad(value));
	}

	public double TAN(double value)
	{
		_ = 8;
		if (false)
		{
		}
		return Math.Tan(MathUtility.DegreeToRad(value));
	}

	public double ln(double value)
	{
		_ = 8;
		if (-1 == 0)
		{
		}
		return Math.Log(value);
	}

	public double LN(double value)
	{
		_ = 2;
		if (8 == 0)
		{
		}
		return Math.Log(value);
	}

	public double log10(double value)
	{
		_ = 3;
		if (false)
		{
		}
		return Math.Log10(value);
	}

	public double LOG10(double value)
	{
		_ = 1;
		if (2 == 0)
		{
		}
		return Math.Log10(value);
	}

	public double exp(double value)
	{
		_ = 2;
		if (1 == 0)
		{
		}
		return Math.Exp(value);
	}

	public double EXP(double value)
	{
		_ = 4;
		if (false)
		{
		}
		return Math.Exp(value);
	}

	public double sqrt(double value)
	{
		_ = 2;
		if (4 == 0)
		{
		}
		return Math.Sqrt(value);
	}

	public double SQRT(double value)
	{
		_ = 1;
		if (1 == 0)
		{
		}
		return Math.Sqrt(value);
	}

	public double pow(double x, double y)
	{
		_ = 7;
		if (2 == 0)
		{
		}
		_ = 0;
		if (3 == 0)
		{
		}
		return Math.Pow(x, y);
	}

	public double POW(double x, double y)
	{
		_ = 0;
		if (4 == 0)
		{
		}
		_ = 0;
		if (false)
		{
		}
		return Math.Pow(x, y);
	}

	public double rd(double value)
	{
		_ = 5;
		if (4 == 0)
		{
		}
		return Math.Floor(value);
	}

	public double RD(double value)
	{
		_ = 6;
		if (2 == 0)
		{
		}
		return Math.Floor(value);
	}

	public double ru(double value)
	{
		_ = -1;
		if (8 == 0)
		{
		}
		return Math.Ceiling(value);
	}

	public double RU(double value)
	{
		_ = 0;
		if (false)
		{
		}
		return Math.Ceiling(value);
	}

	public string GetVersion()
	{
		return AppInfo.Version.ToString();
	}

	public void Print(string message)
	{
		_ = 0;
		if (7 == 0)
		{
		}
		throw new Exception(message);
	}

	public static string GetString(string macroName, string key)
	{
		string result;
		if (8u != 0)
		{
			result = key;
		}
		List<string> list = new List<string>();
		List<string> list2;
		if (true)
		{
			list2 = list;
		}
		string currentUICulture = AppInfo.CurrentUICulture;
		string text;
		if (2u != 0)
		{
			text = currentUICulture;
		}
		ZipFile obj = ZipFile.Read(Path.Combine(AppInfo.RuntimeDir, macroName + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712709)));
		ZipFile val = default(ZipFile);
		if (0 == 0)
		{
			val = obj;
		}
		try
		{
			foreach (ZipEntry item2 in val)
			{
				FileInfo fileInfo = new FileInfo(item2.FileName);
				string item = fileInfo.DirectoryName.Replace(Environment.CurrentDirectory + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712700), string.Empty);
				if (!list2.Contains(item))
				{
					list2.Add(item);
				}
			}
			foreach (ZipEntry item3 in val)
			{
				FileInfo fileInfo = new FileInfo(item3.FileName);
				if (!(fileInfo.Extension == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712692)))
				{
					continue;
				}
				string text2 = (list2.Contains(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712680) + text) ? text : _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712661));
				if (!(fileInfo.DirectoryName.Replace(Environment.CurrentDirectory + _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712649), string.Empty) == text2))
				{
					continue;
				}
				Stream stream = new MemoryStream();
				try
				{
					item3.Extract(stream);
					stream.Position = 0L;
					ResourceDictionary resourceDictionary = (ResourceDictionary)XamlReader.Load(XmlReader.Create(stream));
					if (resourceDictionary != null && resourceDictionary.Contains(key))
					{
						result = resourceDictionary[key] as string;
						break;
					}
				}
				finally
				{
					((IDisposable)stream).Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return result;
	}

	public bool NDEF(double? value)
	{
		return !value.HasValue;
	}

	public bool DEF(double? value)
	{
		return value.HasValue;
	}

	public bool NDEF(string value)
	{
		_ = 0;
		if (1 == 0)
		{
		}
		return string.IsNullOrEmpty(value);
	}

	public bool DEF(string value)
	{
		_ = 5;
		if (5 == 0)
		{
		}
		return !string.IsNullOrEmpty(value);
	}

	public double V(double? par)
	{
		if (!par.HasValue)
		{
			return 0.0;
		}
		return par.Value;
	}

	public double VALUE(double? par)
	{
		_ = 6;
		if (4 == 0)
		{
		}
		_ = 6;
		if (2 == 0)
		{
		}
		return V(par);
	}

	public int GetProgrammingOrigine()
	{
		int result;
		if (7u != 0)
		{
			result = 0;
		}
		if (_options != null && !_options.PostOptions.IsAreaScm)
		{
			if (2u != 0)
			{
				result = 1;
			}
		}
		return result;
	}

	public void SetBarPosition(int id, double xPosition)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			if (!_0023_003DzpDEAL9o818dC || !_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712887), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), xPosition, id);
				string message;
				if (true)
				{
					message = text;
				}
				if (true)
				{
					AddToErrorFile(message);
				}
			}
			else if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetBarPosition(id, xPosition);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
				_0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D = id;
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712843), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, xPosition, id);
		}
	}

	public void SetMobileBarPosition(int id, int position)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			if (!_0023_003DzpDEAL9o818dC)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712801), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), position, id);
				string message;
				if (true)
				{
					message = text;
				}
				if (7u != 0)
				{
					AddToErrorFile(message);
				}
			}
			else if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetMobileBarPosition(id, position);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712495), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, position, id);
		}
	}

	public void SetSupportBasePosition(int id, double yPosition)
	{
		try
		{
			if (3u != 0)
			{
				Flush();
			}
			if (!_0023_003DzpDEAL9o818dC || !_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712447), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), yPosition, id);
				string message;
				if (true)
				{
					message = text;
				}
				if (uint.MaxValue != 0)
				{
					AddToErrorFile(message);
				}
			}
			else if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetSupportBasePosition(_0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D, id, yPosition);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712395), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, yPosition, id);
		}
	}

	public void SetClampPosition(int supportId, double yPosition, int status, string code)
	{
		try
		{
			if (!_0023_003DzpDEAL9o818dC || !_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712601), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), yPosition, code);
				string message;
				if (8u != 0)
				{
					message = text;
				}
				if (3u != 0)
				{
					AddToErrorFile(message);
				}
				return;
			}
			if (6u != 0)
			{
				Flush();
			}
			if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetClampPosition(_0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D, supportId, yPosition, status, code);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917712555), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, yPosition, code);
		}
	}

	public void SetHorizontalClampPosition(int supportId, double yPosition, int status, string code)
	{
		try
		{
			if (!_0023_003DzpDEAL9o818dC || !_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711231), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), yPosition, code);
				string message;
				if (2u != 0)
				{
					message = text;
				}
				if (2u != 0)
				{
					AddToErrorFile(message);
				}
				return;
			}
			if (true)
			{
				Flush();
			}
			if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetHorizontalClampPosition(_0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D, supportId, yPosition, status, code);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711175), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, yPosition, code);
		}
	}

	public void SetClampForJambPosition(int supportId, double yPosition, int status, string code)
	{
		try
		{
			if (!_0023_003DzpDEAL9o818dC || !_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711121), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), yPosition, code);
				string message;
				if (5u != 0)
				{
					message = text;
				}
				if (5u != 0)
				{
					AddToErrorFile(message);
				}
				return;
			}
			if (6u != 0)
			{
				Flush();
			}
			if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetClampForJambPosition(_0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D, supportId, yPosition, status, code);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711326), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, yPosition, code);
		}
	}

	public void SetSuctionCupPosition(int supportId, double yPosition, double angle, string code)
	{
		try
		{
			if (!_0023_003DzpDEAL9o818dC || !_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711273), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), yPosition, code);
				string message;
				if (true)
				{
					message = text;
				}
				if (uint.MaxValue != 0)
				{
					AddToErrorFile(message);
				}
				return;
			}
			if (6u != 0)
			{
				Flush();
			}
			if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetSuctionCupPosition(_0023_003Dzwqzu_002435IYQFrgKhrOQ_003D_003D, supportId, yPosition, angle, code);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710968), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, yPosition, code);
		}
	}

	public void SetMLTFSuctionCupPosition(double xPosition, double yPosition, double angle, string code)
	{
		try
		{
			if (!_0023_003DzpDEAL9o818dC || !_0023_003Dzp3YCgbYac_73Ou45Dw_003D_003D)
			{
				string text = string.Format(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710917), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)), xPosition, yPosition, code);
				string message;
				if (7u != 0)
				{
					message = text;
				}
				if (6u != 0)
				{
					AddToErrorFile(message);
				}
				return;
			}
			if (uint.MaxValue != 0)
			{
				Flush();
			}
			if (_projectInterface != null)
			{
				MainWorkplan mainWorkplan = _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D();
				WorkPiece workpiece = _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D();
				new FixtureScripting(_projectInterface, _configurationInterface, _supportInterface, mainWorkplan, workpiece).SetMLTFSuctionCupPosition(xPosition, yPosition, angle, code);
				_projectInterface.UpdateMainWorkplan(mainWorkplan, this, selectMainWorkplan: false);
			}
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710864), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException, xPosition, yPosition, code);
		}
	}

	public WorkingField GetWorkingField(string field)
	{
		try
		{
			if (7u != 0)
			{
				Flush();
			}
			WorkingField result;
			if (7u != 0)
			{
				result = null;
			}
			if (_configurationInterface != null)
			{
				WorkingField workingField = new WorkingField(_configurationInterface);
				WorkingField workingField2;
				if (4u != 0)
				{
					workingField2 = workingField;
				}
				workingField2.CreateWorkingField(field);
				if (workingField2.IsValidWorkingField())
				{
					result = workingField2;
				}
			}
			return result;
		}
		catch (Exception innerException)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711065), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
	}

	public void InitializeComplexProcess()
	{
		_ = 3;
		if (false)
		{
		}
		_0023_003DzwXhwAQVfEqz9.Enable();
	}

	public void CreateComplexProcess()
	{
		_ = 7;
		if (5 == 0)
		{
		}
		_0023_003DzwXhwAQVfEqz9.CreateProcess();
		if (7 == 0)
		{
		}
		_ = 3;
		if (7 == 0)
		{
		}
		_0023_003DzwXhwAQVfEqz9.Disable();
	}

	public void Flush()
	{
		List<BaseScripting>.Enumerator enumerator = _0023_003DzTX7wzNM0R89M.GetEnumerator();
		List<BaseScripting>.Enumerator enumerator2;
		if (4u != 0)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				enumerator2.Current._0023_003Dza07C_0024Lw_003D();
			}
		}
		finally
		{
			((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
		}
		_0023_003DzTX7wzNM0R89M.Clear();
	}

	public void ReleaseResources()
	{
		if (_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D != null)
		{
			Dictionary<string, ProjectInterface>.Enumerator enumerator = _0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D.GetEnumerator();
			Dictionary<string, ProjectInterface>.Enumerator enumerator2;
			if (3u != 0)
			{
				enumerator2 = enumerator;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, ProjectInterface> current = enumerator2.Current;
					KeyValuePair<string, ProjectInterface> keyValuePair;
					if (4u != 0)
					{
						keyValuePair = current;
					}
					ProjectInterface value = keyValuePair.Value;
					value.UnsubscribeEvents();
					value.DeleteProject();
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
			_0023_003Dz_0024GZ7jzVdrdYKaIP5xUjiRI8_003D.Clear();
		}
		if (_0023_003DzwXhwAQVfEqz9 != null)
		{
			_0023_003DzwXhwAQVfEqz9.Disable();
		}
	}

	private MainWorkplan _0023_003DzA5f_00242bDPx8BusNiEnMh1aqY_003D()
	{
		MainWorkplan mainWorkplan;
		if (6u != 0)
		{
			mainWorkplan = null;
		}
		if (_projectInterface != null && ActiveWorkplan != null)
		{
			MainWorkplan obj = _projectInterface.Get(ActiveWorkplan.ReferenceKey) as MainWorkplan;
			if (6u != 0)
			{
				mainWorkplan = obj;
			}
		}
		if (mainWorkplan == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711024), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		}
		return mainWorkplan;
	}

	private WorkPiece _0023_003DzlJ5VN59hRQPZaTjhg8dSFoE_003D()
	{
		WorkPiece workPiece;
		if (2u != 0)
		{
			workPiece = null;
		}
		if (_projectInterface != null && ActiveWorkpiece != null)
		{
			WorkPiece obj = _projectInterface.Get(ActiveWorkpiece.ReferenceKey) as WorkPiece;
			if (3u != 0)
			{
				workPiece = obj;
			}
		}
		if (workPiece == null)
		{
			throw ExceptionManager.CreateException(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711744), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, null);
		}
		return workPiece;
	}

	private FilletType _0023_003DzsWJ3VRWpMkR_8_0024RvzQ_003D_003D(int _0023_003DzN33Guo0_003D)
	{
		_ = 0;
		if (3 == 0)
		{
		}
		if (_0023_003DzN33Guo0_003D == 0)
		{
			return FilletType.Normal;
		}
		_ = 1;
		if (6 == 0)
		{
		}
		if (_0023_003DzN33Guo0_003D == 1)
		{
			return FilletType.Reverse;
		}
		_ = 1;
		if (6 == 0)
		{
		}
		if (_0023_003DzN33Guo0_003D == 2)
		{
			return FilletType.Clockwise;
		}
		if (_0023_003DzN33Guo0_003D == 3)
		{
			return FilletType.CounterClockwise;
		}
		return FilletType.Normal;
	}

	private ChamferType _0023_003DzMCzNT_00243X5n1ZW73_nw_003D_003D(int _0023_003DzN33Guo0_003D)
	{
		return ChamferType.Normal;
	}

	private bool _0023_003Dz8XJ_0024Syd4qr9134wpQWRR5dHaqq8u(bool _0023_003DzIp0TZ8I_003D)
	{
		bool result;
		if (7u != 0)
		{
			result = _0023_003DzIp0TZ8I_003D;
		}
		WorkPlaneCategory[] array = new WorkPlaneCategory[3];
		if (5u != 0)
		{
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		}
		if (_0023_003Dz880rhFYAL3Y_0024caR08EzofAM_003D(array))
		{
			if (uint.MaxValue != 0)
			{
				result = false;
			}
		}
		return result;
	}

	private bool _0023_003DzczLIUsGKEiTiMDFsrw56lmmMa_zO(bool _0023_003DzIp0TZ8I_003D)
	{
		bool result;
		if (5u != 0)
		{
			result = _0023_003DzIp0TZ8I_003D;
		}
		WorkPlaneCategory[] array = new WorkPlaneCategory[3];
		if (2u != 0)
		{
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		}
		if (_0023_003Dz880rhFYAL3Y_0024caR08EzofAM_003D(array))
		{
			if (4u != 0)
			{
				result = false;
			}
		}
		return result;
	}

	private string _0023_003DzklPYcu4Aj3ym(string _0023_003DzJ3hfjPs_003D, string _0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D)
	{
		_ = 3;
		if (1 == 0)
		{
		}
		_ = 3;
		if (6 == 0)
		{
		}
		_ = 6;
		if (8 == 0)
		{
		}
		return _0023_003DzBzveABk_003D<MachiningWorkingStep>(_0023_003DzJ3hfjPs_003D, _0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D);
	}

	private string _0023_003Dz9VAJQVxbExpH<T>(string _0023_003DzJ3hfjPs_003D, string _0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D)
	{
		_ = 8;
		if (6 == 0)
		{
		}
		_ = 5;
		if (2 == 0)
		{
		}
		_ = 6;
		if (2 == 0)
		{
		}
		return _0023_003DzBzveABk_003D<T>(_0023_003DzJ3hfjPs_003D, _0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D);
	}

	private string _0023_003DzJsN2wfwoTZJn<T>(string _0023_003DzJ3hfjPs_003D, string _0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D)
	{
		_ = 4;
		if (4 == 0)
		{
		}
		_ = 5;
		if (-1 == 0)
		{
		}
		_ = 8;
		if (3 == 0)
		{
		}
		return _0023_003DzBzveABk_003D<T>(_0023_003DzJ3hfjPs_003D, _0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D);
	}

	private string _0023_003DzrezAJ_Ob_pAQpKTl_0024A_003D_003D(string _0023_003DzJ3hfjPs_003D)
	{
		_ = 8;
		if (5 == 0)
		{
		}
		_ = 5;
		if (7 == 0)
		{
		}
		return _0023_003DzBzveABk_003D<WorkPiece>(_0023_003DzJ3hfjPs_003D, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711697));
	}

	private string _0023_003DzS_zNcwk3g_C3(string _0023_003DzJ3hfjPs_003D)
	{
		_ = 7;
		if (8 == 0)
		{
		}
		_ = 2;
		if (1 == 0)
		{
		}
		return _0023_003DzBzveABk_003D<Plane>(_0023_003DzJ3hfjPs_003D, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711671));
	}

	private string _0023_003DzBzveABk_003D<T>(string _0023_003DzJ3hfjPs_003D, string _0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D)
	{
		string text;
		if (uint.MaxValue != 0)
		{
			text = _0023_003DzJ3hfjPs_003D;
		}
		if (!StringUtility.IsValid(text))
		{
			string text2 = LocalizationManager.GetString(_0023_003Dzl3ccOu_UDErxC6ZmTpEdbqk_003D, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990));
			string name;
			if (2u != 0)
			{
				name = text2;
			}
			if (!StringUtility.IsValid(name))
			{
				string text3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711655);
				if (uint.MaxValue != 0)
				{
					name = text3;
				}
			}
			text = _projectInterface.GetUniqueName<T>(name);
		}
		Exist(text, exist: false);
		return text;
	}

	private bool _0023_003Dz880rhFYAL3Y_0024caR08EzofAM_003D(WorkPlaneCategory[] _0023_003Dzoc20pW4_003D)
	{
		bool result;
		if (8u != 0)
		{
			result = false;
		}
		if (_0023_003Dzoc20pW4_003D != null)
		{
			WorkPlaneCategory[] array;
			if (uint.MaxValue != 0)
			{
				array = _0023_003Dzoc20pW4_003D;
			}
			int i = default(int);
			if (0 == 0)
			{
				i = 0;
			}
			for (; i < array.Length; i++)
			{
				WorkPlaneCategory workPlaneCategory = array[i];
				if (_0023_003DzYX5LSNnkrXcH9fDAZbJxBRo_003D == workPlaneCategory)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	protected void AddToErrorFile(string message)
	{
		_ = -1;
		if (3 == 0)
		{
		}
		IScriptingReportServices reportServices = _reportServices;
		if (reportServices == null)
		{
			if (4u != 0)
			{
			}
			return;
		}
		_ = 5;
		if (2 == 0)
		{
		}
		reportServices.AddMessage(message);
	}

	protected void RegisterForFlush(BaseScripting baseScripting)
	{
		_0023_003Dz5d4CWihhmrSbAY4_0024S3xjdas_003D _0023_003Dz5d4CWihhmrSbAY4_0024S3xjdas_003D = new _0023_003Dz5d4CWihhmrSbAY4_0024S3xjdas_003D();
		_0023_003Dz5d4CWihhmrSbAY4_0024S3xjdas_003D CS_0024_003C_003E8__locals4;
		if (2u != 0)
		{
			CS_0024_003C_003E8__locals4 = _0023_003Dz5d4CWihhmrSbAY4_0024S3xjdas_003D;
		}
		if (2u != 0)
		{
			CS_0024_003C_003E8__locals4._0023_003DzEdU8_0024mdgfCA_0024 = baseScripting;
		}
		if (CS_0024_003C_003E8__locals4._0023_003DzEdU8_0024mdgfCA_0024 != null && _0023_003DzTX7wzNM0R89M.Find(delegate(BaseScripting _0023_003DzT2wOlf0_003D)
		{
			_ = 2;
			if (1 == 0)
			{
			}
			_ = 6;
			if (6 == 0)
			{
			}
			return _0023_003DzT2wOlf0_003D == CS_0024_003C_003E8__locals4._0023_003DzEdU8_0024mdgfCA_0024;
		}) == null)
		{
			_0023_003DzTX7wzNM0R89M.Add(CS_0024_003C_003E8__locals4._0023_003DzEdU8_0024mdgfCA_0024);
		}
	}

	protected void SetAttribute(int elementIndex, string name, double value)
	{
		if (ActiveGeometry != null)
		{
			OperationAttribute operationAttribute = Attribute.Create(name, value);
			OperationAttribute operationAttribute2;
			if (3u != 0)
			{
				operationAttribute2 = operationAttribute;
			}
			if (operationAttribute2 != null)
			{
				ActiveAttributes.Add(new Attribute(operationAttribute2, elementIndex));
			}
		}
	}

	protected void SetAttribute(int elementIndex, string name, double value, double uPar)
	{
		if (ActiveGeometry != null)
		{
			OperationAttribute operationAttribute = Attribute.Create(name, value, 0.0, uPar);
			OperationAttribute operationAttribute2;
			if (6u != 0)
			{
				operationAttribute2 = operationAttribute;
			}
			if (operationAttribute2 != null)
			{
				ActiveAttributes.Add(new Attribute(operationAttribute2, elementIndex));
			}
		}
	}

	protected void SetAttribute2(int elementIndex, string name, double value1, double value2)
	{
		if (ActiveGeometry != null)
		{
			OperationAttribute operationAttribute = Attribute.Create(name, value1, value2);
			OperationAttribute operationAttribute2;
			if (true)
			{
				operationAttribute2 = operationAttribute;
			}
			if (operationAttribute2 != null)
			{
				ActiveAttributes.Add(new Attribute(operationAttribute2, elementIndex));
			}
		}
	}

	protected void SetAttribute2(int elementIndex, string name, double value1, double value2, double uPar)
	{
		if (ActiveGeometry != null)
		{
			OperationAttribute operationAttribute = Attribute.Create(name, value1, value2, uPar);
			OperationAttribute operationAttribute2;
			if (2u != 0)
			{
				operationAttribute2 = operationAttribute;
			}
			if (operationAttribute2 != null)
			{
				ActiveAttributes.Add(new Attribute(operationAttribute2, elementIndex));
			}
		}
	}

	protected virtual void PostEvaluateStep()
	{
		if (8u != 0)
		{
			Flush();
		}
	}

	internal void _0023_003Dz2u156WrHMvZPFnzT5pSc_0024WevW3Mr(EdgeBandingSlotInOut _0023_003Dz3keKASA_003D)
	{
		if (7u != 0)
		{
			_0023_003DzsZjJJ2el2a6kh3BuxokefTIDJYiP7PbzpTWmxrQ_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003DzqVmFYIbh_p85UvljPG0qM5l_0024KwnV(EdgeBandingInOut _0023_003Dz3keKASA_003D)
	{
		if (4u != 0)
		{
			_0023_003Dz3hGoGj1lQBnmSo672FaVgOCR0lh0hHWR7A_003D_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dz35c_Ced4jRcK8RcWeJ3jk_jOlJBw(EdgeDispensingManager _0023_003Dz3keKASA_003D)
	{
		if (4u != 0)
		{
			_0023_003DzQt5tHPu_0024m5PCV4XqhbPq2UoWKfq_00247hsfPw_003D_003D = _0023_003Dz3keKASA_003D;
		}
	}

	internal void _0023_003Dzi_hKTYwDP2IAJdh3Iw_003D_003D(EdgeClosingManager _0023_003Dz3keKASA_003D)
	{
		if (3u != 0)
		{
			_0023_003DzlEoT01eghG1y1MmRdmH2bGw_003D = _0023_003Dz3keKASA_003D;
		}
	}

	public EdgeBandingInOut SetEdgeBandingApproachStrategy(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null)
	{
		if (3u != 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingInOut == null)
		{
			EdgeBandingInOut _0023_003Dz3keKASA_003D = new EdgeBandingInOut();
			if (8u != 0)
			{
				_0023_003DzqVmFYIbh_p85UvljPG0qM5l_0024KwnV(_0023_003Dz3keKASA_003D);
			}
		}
		else
		{
			ActiveEdgeBandingInOut.ResetEdgeBandingIn();
		}
		ActiveEdgeBandingInOut.CreateEdgeBandingIn(approachSpeed, approachMagazineSpeed, pointDistance, pointAngle, pointRotation, stopTime, isLampOn, lampPower);
		return ActiveEdgeBandingInOut;
	}

	public EdgeBandingInOut SetEdgeBandingRetractStrategy(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null)
	{
		if (3u != 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingInOut == null)
		{
			EdgeBandingInOut _0023_003Dz3keKASA_003D = new EdgeBandingInOut();
			if (4u != 0)
			{
				_0023_003DzqVmFYIbh_p85UvljPG0qM5l_0024KwnV(_0023_003Dz3keKASA_003D);
			}
		}
		else
		{
			ActiveEdgeBandingInOut.ResetEdgeBandingOut();
		}
		ActiveEdgeBandingInOut.CreateEdgeBandingOut(retractSpeed, stopTime, pointDistance, pointAngle, pointRotation);
		return ActiveEdgeBandingInOut;
	}

	public void ResetEdgeBandingStrategy()
	{
		if (0 == 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingInOut != null)
		{
			ActiveEdgeBandingInOut.ResetEdgeBandingIn();
			ActiveEdgeBandingInOut.ResetEdgeBandingOut();
		}
	}

	public void ResetEdgeBandingApproachStrategy()
	{
		if (uint.MaxValue != 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingInOut != null)
		{
			ActiveEdgeBandingInOut.ResetEdgeBandingIn();
		}
	}

	public void ResetEdgeBandingRetractStrategy()
	{
		if (true)
		{
			Flush();
		}
		if (ActiveEdgeBandingInOut != null)
		{
			ActiveEdgeBandingInOut.ResetEdgeBandingOut();
		}
	}

	public EdgeBandingSlotInOut SetEdgeBandingSlotApproachStrategy(double? approachSpeed = null, double? approachMagazineSpeed = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null, double? stopTime = null, bool? isLampOn = null, double? lampPower = null)
	{
		if (4u != 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingSlotInOut == null)
		{
			EdgeBandingSlotInOut _0023_003Dz3keKASA_003D = new EdgeBandingSlotInOut();
			if (5u != 0)
			{
				_0023_003Dz2u156WrHMvZPFnzT5pSc_0024WevW3Mr(_0023_003Dz3keKASA_003D);
			}
		}
		else
		{
			ActiveEdgeBandingSlotInOut.ResetEdgeBandingSlotIn();
		}
		ActiveEdgeBandingSlotInOut.CreateEdgeBandingSlotIn(approachSpeed, approachMagazineSpeed, pointDistance, pointAngle, pointRotation, stopTime, isLampOn, lampPower);
		return ActiveEdgeBandingSlotInOut;
	}

	public EdgeBandingSlotInOut SetEdgeBandingSlotRetractStrategy(double? retractSpeed = null, double? stopTime = null, double? pointDistance = null, double? pointAngle = null, double? pointRotation = null)
	{
		if (0 == 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingSlotInOut == null)
		{
			EdgeBandingSlotInOut _0023_003Dz3keKASA_003D = new EdgeBandingSlotInOut();
			if (2u != 0)
			{
				_0023_003Dz2u156WrHMvZPFnzT5pSc_0024WevW3Mr(_0023_003Dz3keKASA_003D);
			}
		}
		else
		{
			ActiveEdgeBandingSlotInOut.ResetEdgeBandingSlotOut();
		}
		ActiveEdgeBandingSlotInOut.CreateEdgeBandingSlotOut(retractSpeed, stopTime, pointDistance, pointAngle, pointRotation);
		return ActiveEdgeBandingSlotInOut;
	}

	public void ResetEdgeBandingSlotStrategy()
	{
		if (4u != 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingSlotInOut != null)
		{
			ActiveEdgeBandingSlotInOut.ResetEdgeBandingSlotIn();
			ActiveEdgeBandingSlotInOut.ResetEdgeBandingSlotOut();
		}
	}

	public void ResetEdgeBandingSlotApproachStrategy()
	{
		if (5u != 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingSlotInOut != null)
		{
			ActiveEdgeBandingSlotInOut.ResetEdgeBandingSlotIn();
		}
	}

	public void ResetEdgeBandingSlotRetractStrategy()
	{
		if (7u != 0)
		{
			Flush();
		}
		if (ActiveEdgeBandingSlotInOut != null)
		{
			ActiveEdgeBandingSlotInOut.ResetEdgeBandingSlotOut();
		}
	}

	public void ResetEdgeDispensing()
	{
		if (0 == 0)
		{
			Flush();
		}
		if (ActiveEdgeDispensing != null)
		{
			ActiveEdgeDispensing.Reset();
		}
	}

	public void SetEdgeDispensing(object startOffSet = null, object totalOffSet = null, object safeOffSet = null, bool? isMultiEdgeBandingEnabled = null)
	{
		if (ActiveEdgeDispensing == null)
		{
			EdgeDispensingManager _0023_003Dz3keKASA_003D = new EdgeDispensingManager();
			if (6u != 0)
			{
				_0023_003Dz35c_Ced4jRcK8RcWeJ3jk_jOlJBw(_0023_003Dz3keKASA_003D);
			}
		}
		else
		{
			ActiveEdgeDispensing.Reset();
		}
		double startOffSet2 = ActiveEdgeDispensing.EdgeDispensing.StartOffSet;
		double startOffSet3;
		if (5u != 0)
		{
			startOffSet3 = startOffSet2;
		}
		double totalOffSet2 = ActiveEdgeDispensing.EdgeDispensing.TotalOffSet;
		double totalOffSet3;
		if (uint.MaxValue != 0)
		{
			totalOffSet3 = totalOffSet2;
		}
		double safeOffSet2 = ActiveEdgeDispensing.EdgeDispensing.SafeOffSet;
		bool isMultiEdgeBandingEnabled2 = ActiveEdgeDispensing.EdgeDispensing.MultiEdgeBandingEnabled;
		if (startOffSet != null)
		{
			startOffSet3 = _projectInterface.EvaluateExpression<double>(startOffSet.ToString(), FisicalUnitType.Lenght);
		}
		if (totalOffSet != null)
		{
			totalOffSet3 = _projectInterface.EvaluateExpression<double>(totalOffSet.ToString(), FisicalUnitType.Lenght);
		}
		if (safeOffSet != null)
		{
			safeOffSet2 = _projectInterface.EvaluateExpression<double>(safeOffSet.ToString(), FisicalUnitType.Lenght);
		}
		if (isMultiEdgeBandingEnabled.HasValue)
		{
			isMultiEdgeBandingEnabled2 = isMultiEdgeBandingEnabled.Value;
		}
		ActiveEdgeDispensing.CreateEdgeDispensing(startOffSet3, totalOffSet3, safeOffSet2, isMultiEdgeBandingEnabled2);
	}

	public void SetEdgeSlotDispensing(object startOffSet = null, object totalOffSet = null, object safeOffSet = null, bool? isMultiEdgeBandingEnabled = null)
	{
		if (ActiveEdgeDispensing == null)
		{
			EdgeDispensingManager _0023_003Dz3keKASA_003D = new EdgeDispensingManager();
			if (uint.MaxValue != 0)
			{
				_0023_003Dz35c_Ced4jRcK8RcWeJ3jk_jOlJBw(_0023_003Dz3keKASA_003D);
			}
		}
		else
		{
			ActiveEdgeDispensing.Reset();
		}
		double startOffSet2 = ActiveEdgeDispensing.EdgeSlotDispensing.StartOffSet;
		double startOffSet3;
		if (5u != 0)
		{
			startOffSet3 = startOffSet2;
		}
		double totalOffSet2 = ActiveEdgeDispensing.EdgeSlotDispensing.TotalOffSet;
		double totalOffSet3;
		if (6u != 0)
		{
			totalOffSet3 = totalOffSet2;
		}
		double safeOffSet2 = ActiveEdgeDispensing.EdgeSlotDispensing.SafeOffSet;
		bool isMultiEdgeBandingEnabled2 = ActiveEdgeDispensing.EdgeSlotDispensing.MultiEdgeBandingEnabled;
		if (startOffSet != null)
		{
			startOffSet3 = _projectInterface.EvaluateExpression<double>(startOffSet.ToString(), FisicalUnitType.Lenght);
		}
		if (totalOffSet != null)
		{
			totalOffSet3 = _projectInterface.EvaluateExpression<double>(totalOffSet.ToString(), FisicalUnitType.Lenght);
		}
		if (safeOffSet != null)
		{
			safeOffSet2 = _projectInterface.EvaluateExpression<double>(safeOffSet.ToString(), FisicalUnitType.Lenght);
		}
		if (isMultiEdgeBandingEnabled.HasValue)
		{
			isMultiEdgeBandingEnabled2 = isMultiEdgeBandingEnabled.Value;
		}
		ActiveEdgeDispensing.CreateEdgeSlotDispensing(startOffSet3, totalOffSet3, safeOffSet2, isMultiEdgeBandingEnabled2);
	}

	public void ResetEdgeSlotDispensing()
	{
		if (7u != 0)
		{
			Flush();
		}
		if (ActiveEdgeDispensing != null)
		{
			ActiveEdgeDispensing.Reset();
		}
	}

	public void ResetEdgeClosing()
	{
		if (8u != 0)
		{
			Flush();
		}
		if (ActiveEdgeClosing != null)
		{
			ActiveEdgeClosing.Reset();
		}
	}

	public void SetEdgeClosing(object endOffSet = null, bool? enableCutter = null)
	{
		if (ActiveEdgeClosing == null)
		{
			EdgeClosingManager _0023_003Dz3keKASA_003D = new EdgeClosingManager();
			if (6u != 0)
			{
				_0023_003Dzi_hKTYwDP2IAJdh3Iw_003D_003D(_0023_003Dz3keKASA_003D);
			}
		}
		else
		{
			ActiveEdgeClosing.Reset();
		}
		double endOffSet2 = ActiveEdgeClosing.EdgeClosing.EndOffSet;
		double endOffSet3 = default(double);
		if (0 == 0)
		{
			endOffSet3 = endOffSet2;
		}
		bool cutter = ActiveEdgeClosing.Cutter;
		bool enableCutter2;
		if (uint.MaxValue != 0)
		{
			enableCutter2 = cutter;
		}
		if (endOffSet != null)
		{
			endOffSet3 = _projectInterface.EvaluateExpression<double>(endOffSet.ToString(), FisicalUnitType.Lenght);
		}
		if (enableCutter.HasValue)
		{
			enableCutter2 = enableCutter.Value;
		}
		ActiveEdgeClosing.CreateEdgeClosing(endOffSet3, enableCutter2);
	}

	public Operation CreateEdgeBanding(string name, string edge, object depth, bool edgeManualLoading = false, string pressureTool = "-1", bool pressureToolManualLoading = false, object speed = null)
	{
		if (true)
		{
			EdgeBandingProcessOperation edgeBandingProcessOperation = null;
		}
		try
		{
			if (4u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711640));
			if (8u != 0)
			{
				name = text;
			}
			object _0023_003Dz3keKASA_003D = ConvertExpressionValueToCurrentUnit(depth, FisicalUnitType.Lenght, null);
			object _0023_003Dz3keKASA_003D2 = ConvertExpressionValueToCurrentUnit(speed, FisicalUnitType.Speed, null);
			double depth2 = _0023_003Dzdn45LMQ_003D<double>(_0023_003Dz3keKASA_003D, FisicalUnitType.Lenght);
			double speed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			ActiveEdgeBandingProgramParameters activeParameters = _0023_003DzuQ8HR_w3DhO8BEQCRnxOzWksXGeF();
			OperationContext operationContext = _0023_003Dzv171kDksmsdD();
			EdgeBandingOperationParameters edgeBandingParameters = new EdgeBandingOperationParameters(edge, edgeManualLoading, pressureTool, pressureToolManualLoading, speed2, depth2);
			EdgeBandingProcessOperation edgeBandingProcessOperation = new EdgeBandingProcessOperation(operationContext, name, ActiveWorkplan.ReferenceKey);
			edgeBandingProcessOperation.CreateEdgeBanding(activeParameters, edgeBandingParameters);
			Operations.Add(edgeBandingProcessOperation);
			_0023_003Dz_0024IbzEN9jdWmF(edgeBandingProcessOperation);
			_0023_003Dzdzv73cHjrWgk(edgeBandingProcessOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetEdgeBandingStrategy();
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetMachine();
			SetCompensationMode(isCnc: true);
			return edgeBandingProcessOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711868)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateEdgeBandingSlotFeature(string name, string edge, object depth, object slotEdgeZ, object angle, bool edgeManualLoading = false, string pressureTool = "-1", bool pressureToolManualLoading = false, object speed = null)
	{
		if (true)
		{
			EdgeBandingProcessOperation edgeBandingProcessOperation = null;
		}
		try
		{
			if (true)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711850));
			if (3u != 0)
			{
				name = text;
			}
			object obj = ConvertExpressionValueToCurrentUnit(depth, FisicalUnitType.Lenght, null);
			object _0023_003Dz3keKASA_003D;
			if (6u != 0)
			{
				_0023_003Dz3keKASA_003D = obj;
			}
			object _0023_003Dz3keKASA_003D2 = ConvertExpressionValueToCurrentUnit(speed, FisicalUnitType.Speed, null);
			double depth2 = _0023_003Dzdn45LMQ_003D<double>(_0023_003Dz3keKASA_003D, FisicalUnitType.Lenght);
			double speed2 = _0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			object _0023_003Dz3keKASA_003D3 = ConvertExpressionValueToCurrentUnit(slotEdgeZ, FisicalUnitType.Lenght, null);
			ConvertExpressionValueToCurrentUnit(speed, FisicalUnitType.UnitLess, null);
			double slotEdgeZ2 = _0023_003Dzdn45LMQ_003D<double>(_0023_003Dz3keKASA_003D3, FisicalUnitType.Lenght);
			double angle2 = _0023_003Dzz65du2JhGB1t(angle, 0.0, FisicalUnitType.UnitLess);
			ActiveEdgeBandingSlotFeatureProgramParameters activeParameters = _0023_003DzEM6B__0024sES6Yd1WGoVskZhk6Ul7LAC2ztZg_003D_003D();
			EdgeBandingSlotOperationParameters edgeBandingParameters = new EdgeBandingSlotOperationParameters(edge, edgeManualLoading, pressureTool, pressureToolManualLoading, speed2, depth2, slotEdgeZ2, angle2);
			EdgeBandingProcessOperation edgeBandingProcessOperation = new EdgeBandingProcessOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			edgeBandingProcessOperation.CreateEdgeBandingSlotFeature(activeParameters, edgeBandingParameters);
			Operations.Add(edgeBandingProcessOperation);
			_0023_003Dz_0024IbzEN9jdWmF(edgeBandingProcessOperation);
			_0023_003Dzdzv73cHjrWgk(edgeBandingProcessOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetEdgeBandingStrategy();
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetMachine();
			SetCompensationMode(isCnc: true);
			return edgeBandingProcessOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711818)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateEndTrimming(string name, string edgeBandingName, string tool = "-1", string head = "-1", object inputSpeed = null, object rotSpeed = null, object speed = null, bool setCurrentPos = false, bool useEndTrimmerAggregateCopier = false)
	{
		if (7u != 0)
		{
			EdgeBandingProcessOperation edgeBandingProcessOperation = null;
		}
		try
		{
			if (6u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711796));
			if (6u != 0)
			{
				name = text;
			}
			EdgeBandingProcessOperation edgeBandingProcessOperation2 = new EdgeBandingProcessOperation(_0023_003Dzv171kDksmsdD(), name, ActiveWorkplan.ReferenceKey);
			EdgeBandingProcessOperation edgeBandingProcessOperation;
			if (uint.MaxValue != 0)
			{
				edgeBandingProcessOperation = edgeBandingProcessOperation2;
			}
			object obj = null;
			obj = ConvertExpressionValueToCurrentUnit(rotSpeed, FisicalUnitType.UnitLess, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D = null;
			obj = ConvertExpressionValueToCurrentUnit(inputSpeed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			object _0023_003Dz3keKASA_003D2 = ConvertExpressionValueToCurrentUnit(speed, FisicalUnitType.Speed, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703672));
			if (speed == null)
			{
				_0023_003Dz3keKASA_003D2 = _options.EndTrimmingOptions.EndTrimmingSpeed;
			}
			_0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D, -1.0, FisicalUnitType.Speed);
			_0023_003Dzz65du2JhGB1t(obj, -1.0, FisicalUnitType.UnitLess);
			_0023_003Dzz65du2JhGB1t(_0023_003Dz3keKASA_003D2, -1.0, FisicalUnitType.Speed);
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			edgeBandingProcessOperation.CreateEndTrimming(activeParameters, edgeBandingName, tool, head, inputSpeed, rotSpeed, speed, setCurrentPos, useEndTrimmerAggregateCopier);
			Operations.Add(edgeBandingProcessOperation);
			_0023_003Dz_0024IbzEN9jdWmF(edgeBandingProcessOperation);
			_0023_003Dzdzv73cHjrWgk(edgeBandingProcessOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			return edgeBandingProcessOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711768)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	public Operation CreateAirBlower(string name, double height, double distanceFromProfile, BlowType blowType, AirBlowerType airBlowerType, string description = "", string tool = "-1", string head = "-1", double inputSpeed = -1.0, double speed = -1.0)
	{
		try
		{
			if (5u != 0)
			{
				Flush();
			}
			string text = _0023_003DzklPYcu4Aj3ym(name, _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711750));
			if (0 == 0)
			{
				name = text;
			}
			int num = _0023_003DzKepshhGj3YBnyyDO5FIwm2vY7uryBDmFcw_003D_003D(airBlowerType);
			int toolCorrection;
			if (2u != 0)
			{
				toolCorrection = num;
			}
			ActiveProgramParameters activeParameters = _0023_003DzxAdcAaq1Zrbq();
			OperationContext operationContext = _0023_003Dzv171kDksmsdD();
			AirBlowerOperationParameters airBlowerParameters = new AirBlowerOperationParameters(height, distanceFromProfile, blowType, airBlowerType);
			AirBlowerOperation airBlowerOperation = new AirBlowerOperation(operationContext, name, ActiveWorkplan.ReferenceKey);
			airBlowerOperation.CreateAirBlower(airBlowerParameters, activeParameters, description, tool, head, toolCorrection, inputSpeed, speed, _approachSecurityPlane, _retractSecurityPlane, _0023_003DzYuaGHaZ5av3_0024E_00243Rf_U6U2c_003D, _0023_003DznYqeEHrk04Im);
			Operations.Add(airBlowerOperation);
			_0023_003Dz_0024IbzEN9jdWmF(airBlowerOperation);
			_0023_003Dzdzv73cHjrWgk(airBlowerOperation);
			_activeStrategy = null;
			ActiveAttributes.Clear();
			ResetApproachStrategy();
			ResetRetractStrategy();
			SetBrakes(string.Empty);
			SetMachiningDirection(sameDirection: true);
			ResetPriority();
			ResetProbingReferencePoint();
			ResetReferencePosition();
			ResetSpindles();
			ResetMachine();
			SetCompensationMode(isCnc: true);
			return airBlowerOperation;
		}
		catch (Exception innerException)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917705828);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = new string[2]
			{
				name,
				_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711468)
			};
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, innerException, parameters);
		}
	}

	private int _0023_003DzKepshhGj3YBnyyDO5FIwm2vY7uryBDmFcw_003D_003D(AirBlowerType _0023_003DzsSh48Z7RWxcYMM2Zhg_003D_003D)
	{
		int num;
		if (5u != 0)
		{
			num = 0;
		}
		if (_0023_003DzsSh48Z7RWxcYMM2Zhg_003D_003D == AirBlowerType.PreEdgeBanding || _0023_003DzsSh48Z7RWxcYMM2Zhg_003D_003D == AirBlowerType.PostEdgeBanding)
		{
			if (uint.MaxValue != 0)
			{
				num = 1;
			}
		}
		int correction = num;
		if (true)
		{
			SetToolCorrection(correction);
		}
		return num;
	}

	public void AddVariable(string name, object value, int type, int unitType, string description = "", bool isReadOnly = false, bool isExportable = true)
	{
		_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D = new _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D();
		_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2 = default(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D);
		if (0 == 0)
		{
			_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2 = _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D;
		}
		_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D3 = _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2;
		if (0 == 0)
		{
			_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D3._0023_003DzJ3hfjPs_003D = name;
		}
		if (3u != 0)
		{
			Flush();
		}
		if (!StringUtility.IsValid(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D))
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711452);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (3u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		if (_projectInterface.Exist<Variable>(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003Dz9MVr2mTS0sC_0024lJVpVg_003D_003D))
		{
			string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711409);
			string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			string[] obj = new string[1] { _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D };
			object[] parameters2;
			if (6u != 0)
			{
				parameters2 = obj;
			}
			throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, null, parameters2);
		}
		if (_0023_003Dzs3orMSNC03r5XD3_qw_003D_003D(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D))
		{
			string localizationKey3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711452);
			string localizationModuleName3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters2 = new string[1] { _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D };
			throw ExceptionManager.CreateException(localizationKey3, localizationModuleName3, ExceptionType.Exception, null, parameters2);
		}
		if (!_0023_003DzFN_0024GgGfJVsPQ(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D))
		{
			string localizationKey4 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711362);
			string localizationModuleName4 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters2 = new string[1] { _0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D };
			throw ExceptionManager.CreateException(localizationKey4, localizationModuleName4, ExceptionType.Exception, null, parameters2);
		}
		VariableType variableType = VariableType.Double;
		switch (type)
		{
		case 1:
			variableType = VariableType.Integer;
			break;
		case 2:
			variableType = VariableType.Boolean;
			break;
		}
		FisicalUnitType fisicalUnitType = FisicalUnitType.UnitLess;
		switch (unitType)
		{
		case 1:
			fisicalUnitType = FisicalUnitType.Lenght;
			break;
		case 2:
			fisicalUnitType = FisicalUnitType.Speed;
			break;
		}
		bool isNotExportable = !isExportable;
		object obj2 = _0023_003DzQaa2GMP4VzNe(value, variableType, fisicalUnitType);
		_0023_003DzgVASab2lEw3h(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D, obj2, variableType);
		object value2 = _0023_003DzDG_0024P_0024St5VLwj(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D, obj2, variableType, fisicalUnitType);
		Variable variable = new Variable(_0023_003DzPRAXpoxyW_0024Pk0vAsXX5iEt8_003D2._0023_003DzJ3hfjPs_003D, value2, description, variableType, fisicalUnitType);
		variable.IsReadOnly = isReadOnly;
		variable.IsNotExportable = isNotExportable;
		_projectInterface.AddVariable(ref variable, this);
		_projectInterface.CheckExpressions(variable.Key, new PropertyField(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917706514)), obj2);
	}

	private bool _0023_003Dzs3orMSNC03r5XD3_qw_003D_003D(string _0023_003DzJ3hfjPs_003D)
	{
		bool result;
		if (4u != 0)
		{
			result = false;
		}
		if (StringUtility.IsValid(_0023_003DzJ3hfjPs_003D))
		{
			int length = _0023_003DzJ3hfjPs_003D.Length;
			int num;
			if (uint.MaxValue != 0)
			{
				num = length;
			}
			if (num >= 2)
			{
				string text = _0023_003DzJ3hfjPs_003D.Substring(0, 2).ToLower();
				string text2;
				if (4u != 0)
				{
					text2 = text;
				}
				if (text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711573) || text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711566) || text2 == _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711555))
				{
					int result2;
					if (num == 2)
					{
						result = true;
					}
					else if (int.TryParse(_0023_003DzJ3hfjPs_003D.Substring(2, num - 2), out result2))
					{
						result = true;
					}
				}
			}
		}
		return result;
	}

	private bool _0023_003DzFN_0024GgGfJVsPQ(string _0023_003DzJ3hfjPs_003D)
	{
		bool result;
		if (6u != 0)
		{
			result = true;
		}
		if (_0023_003DzJ3hfjPs_003D.Length > 0)
		{
			int result2;
			if (5u != 0)
			{
				result2 = 0;
			}
			if (int.TryParse(_0023_003DzJ3hfjPs_003D.Substring(0, 1), out result2))
			{
				if (0 == 0)
				{
					result = false;
				}
			}
		}
		return result;
	}

	private object _0023_003DzQaa2GMP4VzNe(object _0023_003Dz3keKASA_003D, VariableType _0023_003Dz4lLktEk_003D, FisicalUnitType _0023_003DzgAGUqSOZhwt7BoPrqw_003D_003D)
	{
		object result;
		if (2u != 0)
		{
			result = _0023_003Dz3keKASA_003D;
		}
		bool num = !_isMillimeter && _0023_003DzgAGUqSOZhwt7BoPrqw_003D_003D != FisicalUnitType.UnitLess;
		bool flag;
		if (5u != 0)
		{
			flag = num;
		}
		if ((_0023_003Dz4lLktEk_003D == VariableType.Double || _0023_003Dz4lLktEk_003D == VariableType.NullableDouble) && _0023_003Dz3keKASA_003D != null)
		{
			string text = _0023_003Dz3keKASA_003D.ToString().ConvertToCurrentFormat();
			string text2;
			if (2u != 0)
			{
				text2 = text;
			}
			if (StringUtility.IsValid(text2))
			{
				if (flag)
				{
					if (double.TryParse(text2, out var result2))
					{
						double num2 = 1.0;
						double num3 = 0.3048;
						num2 = 25.4;
						if (_0023_003DzgAGUqSOZhwt7BoPrqw_003D_003D == FisicalUnitType.Speed)
						{
							num2 = num3;
						}
						result = result2 / num2;
					}
					else
					{
						result = ConvertExpressionValueToCurrentUnit(_0023_003Dz3keKASA_003D, _0023_003DzgAGUqSOZhwt7BoPrqw_003D_003D, null);
					}
				}
				else
				{
					result = text2;
				}
			}
		}
		return result;
	}

	private void _0023_003DzgVASab2lEw3h(string _0023_003DzJ3hfjPs_003D, object _0023_003Dz3keKASA_003D, VariableType _0023_003Dz4lLktEk_003D)
	{
		if (_0023_003Dz4lLktEk_003D != VariableType.Boolean && _0023_003Dz4lLktEk_003D != VariableType.Double && _0023_003Dz4lLktEk_003D != VariableType.Integer && _0023_003Dz4lLktEk_003D != VariableType.String && _0023_003Dz4lLktEk_003D != VariableType.StringVariable)
		{
			return;
		}
		if (_0023_003Dz3keKASA_003D == null)
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711548);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			string[] obj = new string[1] { _0023_003DzJ3hfjPs_003D };
			object[] parameters;
			if (5u != 0)
			{
				parameters = obj;
			}
			throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
		}
		if (!StringUtility.IsValid(_0023_003Dz3keKASA_003D.ToString()))
		{
			string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711548);
			string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			string[] obj2 = new string[1] { _0023_003DzJ3hfjPs_003D };
			object[] parameters = default(object[]);
			if (0 == 0)
			{
				parameters = obj2;
			}
			throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, null, parameters);
		}
	}

	private object _0023_003DzDG_0024P_0024St5VLwj(string _0023_003DzJ3hfjPs_003D, object _0023_003Dz3keKASA_003D, VariableType _0023_003Dz4lLktEk_003D, FisicalUnitType _0023_003DzgAGUqSOZhwt7BoPrqw_003D_003D)
	{
		object result;
		if (6u != 0)
		{
			result = _0023_003Dz3keKASA_003D;
		}
		if (_0023_003Dz3keKASA_003D != null)
		{
			string text = _0023_003Dz3keKASA_003D.ToString().ConvertToCurrentFormat();
			string text2;
			if (uint.MaxValue != 0)
			{
				text2 = text;
			}
			switch (_0023_003Dz4lLktEk_003D)
			{
			case VariableType.Double:
			{
				if (double.TryParse(text2, out var result4))
				{
					object obj3 = result4;
					if (4u != 0)
					{
						result = obj3;
					}
					break;
				}
				object obj4 = _projectInterface.EvaluateExpression(text2);
				object obj5;
				if (4u != 0)
				{
					obj5 = obj4;
				}
				if (!double.TryParse(obj5.ToString(), out result4))
				{
					string localizationKey3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711506);
					string localizationModuleName3 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
					object[] parameters = new string[2]
					{
						_0023_003DzJ3hfjPs_003D,
						_0023_003Dz4lLktEk_003D.ToString()
					};
					throw ExceptionManager.CreateException(localizationKey3, localizationModuleName3, ExceptionType.Exception, null, parameters);
				}
				result = Convert.ChangeType(obj5, typeof(double));
				break;
			}
			case VariableType.Integer:
			{
				if (int.TryParse(text2, out var result3))
				{
					result = result3;
					break;
				}
				object obj2 = _projectInterface.EvaluateExpression(text2);
				if (!int.TryParse(obj2.ToString(), out result3))
				{
					string localizationKey2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711506);
					string localizationModuleName2 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
					object[] parameters = new string[2]
					{
						_0023_003DzJ3hfjPs_003D,
						_0023_003Dz4lLktEk_003D.ToString()
					};
					throw ExceptionManager.CreateException(localizationKey2, localizationModuleName2, ExceptionType.Exception, null, parameters);
				}
				result = Convert.ChangeType(obj2, typeof(int));
				break;
			}
			case VariableType.Boolean:
			{
				if (bool.TryParse(text2, out var result2))
				{
					result = result2;
					break;
				}
				object obj = _projectInterface.EvaluateExpression(text2);
				if (!bool.TryParse(obj.ToString(), out result2))
				{
					string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917711506);
					string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
					object[] parameters = new string[2]
					{
						_0023_003DzJ3hfjPs_003D,
						_0023_003Dz4lLktEk_003D.ToString()
					};
					throw ExceptionManager.CreateException(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
				}
				result = Convert.ChangeType(obj, typeof(bool));
				break;
			}
			}
		}
		return result;
	}

	private T _0023_003Dzdn45LMQ_003D<T>(object _0023_003Dz3keKASA_003D, FisicalUnitType _0023_003DzQtvSaRs_003D)
	{
		if (_0023_003Dz3keKASA_003D == null || !StringUtility.IsValid(_0023_003Dz3keKASA_003D.ToString()))
		{
			string localizationKey = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710179);
			string localizationModuleName = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990);
			object[] parameters = Array.Empty<object>();
			if (6u != 0)
			{
				ExceptionManager.Throw(localizationKey, localizationModuleName, ExceptionType.Exception, null, parameters);
			}
		}
		Type typeFromHandle = typeof(T);
		Type type = default(Type);
		if (0 == 0)
		{
			type = typeFromHandle;
		}
		string text = _0023_003Dz3keKASA_003D.ToString().ConvertToCurrentFormat();
		string stringToEvaluate;
		if (true)
		{
			stringToEvaluate = text;
		}
		object obj = null;
		if (type == typeof(double))
		{
			obj = _projectInterface.EvaluateExpression<double>(stringToEvaluate, _0023_003DzQtvSaRs_003D);
		}
		else if (type == typeof(int))
		{
			obj = _projectInterface.EvaluateExpression<int>(stringToEvaluate, _0023_003DzQtvSaRs_003D);
		}
		else if (type == typeof(bool))
		{
			obj = _projectInterface.EvaluateExpression<bool>(stringToEvaluate, _0023_003DzQtvSaRs_003D);
		}
		return (T)obj;
	}

	private T _0023_003Dzz65du2JhGB1t<T>(object _0023_003Dz3keKASA_003D, T _0023_003DzfGu_HGo_003D, FisicalUnitType _0023_003DzQtvSaRs_003D)
	{
		T val = _0023_003DzfGu_HGo_003D;
		T result;
		if (2u != 0)
		{
			result = val;
		}
		if (_0023_003Dz3keKASA_003D != null)
		{
			string text = _0023_003Dz3keKASA_003D.ToString().ConvertToCurrentFormat();
			string text2;
			if (4u != 0)
			{
				text2 = text;
			}
			if (StringUtility.IsValid(text2))
			{
				bool flag;
				if (6u != 0)
				{
					flag = true;
				}
				string text3 = null;
				if (_0023_003DzfGu_HGo_003D != null)
				{
					text3 = _0023_003DzfGu_HGo_003D.ToString().ConvertToCurrentFormat();
					if (text2 == text3)
					{
						flag = false;
					}
				}
				if (flag)
				{
					result = _0023_003Dzdn45LMQ_003D<T>(text2, _0023_003DzQtvSaRs_003D);
				}
			}
		}
		return result;
	}

	protected object ConvertExpressionValueToCurrentUnit(object value, FisicalUnitType unitType, string defaultValue)
	{
		object result;
		if (2u != 0)
		{
			result = value;
		}
		if (value != null)
		{
			string text = value.ToString().ConvertToCurrentFormat();
			string text2;
			if (6u != 0)
			{
				text2 = text;
			}
			string text3 = text2;
			if (5u != 0)
			{
				result = text3;
			}
			if (!_isMillimeter && unitType != FisicalUnitType.UnitLess)
			{
				string text4 = null;
				if (StringUtility.IsValid(defaultValue))
				{
					text4 = defaultValue.ConvertToCurrentFormat();
				}
				if (text2 != text4)
				{
					string text5 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710151).ConvertToCurrentFormat();
					string text6 = _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710142).ConvertToCurrentFormat();
					string arg = text5;
					if (unitType == FisicalUnitType.Speed)
					{
						arg = text6;
					}
					List<string> expressionVariableNames = ScmGroup.XCam.MachiningDataModel.Parametrics.Expression.GetExpressionVariableNames(text2);
					if (expressionVariableNames.Count > 0)
					{
						foreach (string item in expressionVariableNames)
						{
							FisicalUnitType variableFisicalUnitType = _projectInterface.GetVariableFisicalUnitType(item);
							if (variableFisicalUnitType != FisicalUnitType.UnitLess)
							{
								string arg2 = text5;
								if (variableFisicalUnitType == FisicalUnitType.Speed)
								{
									arg2 = text6;
								}
								string newValue = string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710127), item, arg2);
								text2 = text2.Replace(item, newValue);
							}
						}
					}
					result = string.Format(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710111), text2, arg);
				}
			}
		}
		return result;
	}

	private ActiveProgramParameters _0023_003DzxAdcAaq1Zrbq()
	{
		ActiveProgramParameters activeProgramParameters = new ActiveProgramParameters();
		ActiveProgramParameters activeProgramParameters2;
		if (7u != 0)
		{
			activeProgramParameters2 = activeProgramParameters;
		}
		if (7u != 0)
		{
			_0023_003Dz4wPvQmKAVqXS(activeProgramParameters2);
		}
		return activeProgramParameters2;
	}

	private ActiveEdgeBandingProgramParameters _0023_003DzuQ8HR_w3DhO8BEQCRnxOzWksXGeF()
	{
		ActiveEdgeBandingProgramParameters activeEdgeBandingProgramParameters = new ActiveEdgeBandingProgramParameters();
		ActiveEdgeBandingProgramParameters activeEdgeBandingProgramParameters2;
		if (true)
		{
			activeEdgeBandingProgramParameters2 = activeEdgeBandingProgramParameters;
		}
		if (0 == 0)
		{
			_0023_003Dz4wPvQmKAVqXS(activeEdgeBandingProgramParameters2);
		}
		if (ActiveEdgeBandingInOut != null)
		{
			activeEdgeBandingProgramParameters2.EdgeBandingInOut = ActiveEdgeBandingInOut;
		}
		if (ActiveEdgeDispensing != null)
		{
			activeEdgeBandingProgramParameters2.EdgeDispensingManager = ActiveEdgeDispensing;
		}
		if (ActiveEdgeClosing != null)
		{
			activeEdgeBandingProgramParameters2.EdgeClosingManager = ActiveEdgeClosing;
		}
		return activeEdgeBandingProgramParameters2;
	}

	private ActiveEdgeBandingSlotFeatureProgramParameters _0023_003DzEM6B__0024sES6Yd1WGoVskZhk6Ul7LAC2ztZg_003D_003D()
	{
		ActiveEdgeBandingSlotFeatureProgramParameters activeEdgeBandingSlotFeatureProgramParameters = new ActiveEdgeBandingSlotFeatureProgramParameters();
		ActiveEdgeBandingSlotFeatureProgramParameters activeEdgeBandingSlotFeatureProgramParameters2;
		if (8u != 0)
		{
			activeEdgeBandingSlotFeatureProgramParameters2 = activeEdgeBandingSlotFeatureProgramParameters;
		}
		if (0 == 0)
		{
			_0023_003Dz4wPvQmKAVqXS(activeEdgeBandingSlotFeatureProgramParameters2);
		}
		activeEdgeBandingSlotFeatureProgramParameters2.EdgeBandingSlotInOut = ActiveEdgeBandingSlotInOut;
		activeEdgeBandingSlotFeatureProgramParameters2.EdgeDispensingManager = ActiveEdgeDispensing;
		return activeEdgeBandingSlotFeatureProgramParameters2;
	}

	private void _0023_003Dz4wPvQmKAVqXS(ActiveProgramParameters _0023_003DzI1kRXDc_003D)
	{
		_ = 4;
		if (7 == 0)
		{
		}
		_ = 5;
		if (-1 == 0)
		{
		}
		_0023_003DzI1kRXDc_003D.ApproachSecurityPlane = _approachSecurityPlane;
		_ = 5;
		if (6 == 0)
		{
		}
		_0023_003DzI1kRXDc_003D.Attributes = ActiveAttributes;
		_0023_003DzI1kRXDc_003D.BlockingProfile = ActiveBlockingProfile;
		_0023_003DzI1kRXDc_003D.Geometry = ActiveGeometry;
		_0023_003DzI1kRXDc_003D.IsCncCompensation = _0023_003DznYqeEHrk04Im;
		_0023_003DzI1kRXDc_003D.StartMachiningPosition = _0023_003Dza01J2_0024_eD1UHFNzD7GMZCIgS2IAk;
		_0023_003DzI1kRXDc_003D.IsMachiningSameDirection = _0023_003DzYuaGHaZ5av3_0024E_00243Rf_U6U2c_003D;
		_0023_003DzI1kRXDc_003D.LeadInOut = ActiveLeadInOut;
		_0023_003DzI1kRXDc_003D.Machine = _0023_003DzRE0vH8WCFzM6;
		_0023_003DzI1kRXDc_003D.WorkPlaneCategory = _0023_003DzYX5LSNnkrXcH9fDAZbJxBRo_003D;
		_0023_003DzI1kRXDc_003D.MachineFunctions = ActiveMachineFunctions;
		_0023_003DzI1kRXDc_003D.MachineID = _0023_003DztQZAXa1gd26n;
		_0023_003DzI1kRXDc_003D.Operation = ActiveOperation;
		_0023_003DzI1kRXDc_003D.Pattern = ActivePattern;
		_0023_003DzI1kRXDc_003D.Priority = _activePriority;
		_0023_003DzI1kRXDc_003D.ProbingReferencePoint = _activeProbingReferencePoint;
		_0023_003DzI1kRXDc_003D.ReferencePosition = _activeReferecePosition;
		_0023_003DzI1kRXDc_003D.RetractSecurityPlane = _retractSecurityPlane;
		_0023_003DzI1kRXDc_003D.Speed = ActiveSpeed;
		_0023_003DzI1kRXDc_003D.Spindles = _0023_003DzobjG82GyRO6N0HSR2g_003D_003D;
		_0023_003DzI1kRXDc_003D.Strategy = _activeStrategy;
		_0023_003DzI1kRXDc_003D.ToolCorrection = ActiveToolCorrection;
		_0023_003DzI1kRXDc_003D.Toolpath = ActiveToolpath;
		_0023_003DzI1kRXDc_003D.Transformation = ActiveTransformation;
		_0023_003DzI1kRXDc_003D.Workpiece = ActiveWorkpiece;
		_0023_003DzI1kRXDc_003D.Workplan = ActiveWorkplan;
		_0023_003DzI1kRXDc_003D.Workplane = ActiveWorkplane;
		_0023_003DzI1kRXDc_003D.X = ActiveX;
		_0023_003DzI1kRXDc_003D.Y = ActiveY;
		_0023_003DzI1kRXDc_003D.Z = ActiveZ;
		_0023_003DzI1kRXDc_003D.FeedrateProfileName = _0023_003Dz5iq5gpuO12MFlZruNlpTZI0_003D;
	}

	private OperationContext _0023_003Dzv171kDksmsdD()
	{
		OperationContext operationContext = new OperationContext();
		_ = 7;
		if (8 == 0)
		{
		}
		operationContext.Options = _options;
		_ = 6;
		if (8 == 0)
		{
		}
		operationContext.ReportServices = _reportServices;
		_ = -1;
		if (8 == 0)
		{
		}
		operationContext.ConfigurationInterface = _configurationInterface;
		operationContext.EdgeInterface = _edgeInterface;
		operationContext.ProjectInterface = _projectInterface;
		operationContext.SupportInterface = _supportInterface;
		operationContext.ToolInterface = _toolInterface;
		return operationContext;
	}

	internal void _0023_003DzlGXqoWtylf8B()
	{
		if (ActiveWorkplan != null)
		{
			SubProgram obj = _projectInterface.Get(ActiveWorkplan.ReferenceKey) as SubProgram;
			SubProgram subProgram;
			if (7u != 0)
			{
				subProgram = obj;
			}
			if (obj != null)
			{
				RotateWorkPieceObjectModel rotateWorkPieceObjectModel = new RotateWorkPieceObjectModel();
				rotateWorkPieceObjectModel.InitializeProject(_projectInterface);
				rotateWorkPieceObjectModel.InitializeTools(_toolInterface);
				rotateWorkPieceObjectModel.InitializeEdges(_edgeInterface);
				rotateWorkPieceObjectModel.InitializeOptions(_options);
				rotateWorkPieceObjectModel.InitializeConfiguration(_configurationInterface);
				rotateWorkPieceObjectModel.InitializeSubProgramExplosion(isSubProgramExplosionEnabled: false);
				rotateWorkPieceObjectModel.RotateSubProgram(subProgram, this);
				MirrorWorkPieceObjectModel mirrorWorkPieceObjectModel = new MirrorWorkPieceObjectModel();
				mirrorWorkPieceObjectModel.InitializeProject(_projectInterface);
				mirrorWorkPieceObjectModel.InitializeTools(_toolInterface);
				mirrorWorkPieceObjectModel.InitializeEdges(_edgeInterface);
				mirrorWorkPieceObjectModel.InitializeOptions(_options);
				mirrorWorkPieceObjectModel.InitializeConfiguration(_configurationInterface);
				mirrorWorkPieceObjectModel.InitializeSubProgramExplosion(isSubProgramExplosionEnabled: false);
				mirrorWorkPieceObjectModel.MirrorSubProgram(subProgram, this);
			}
		}
	}

	public DynamicWorkingAreaUsageStatus SetDynamicAreaLength(double dynamicWorkingAreaLength)
	{
		DynamicWorkingAreaUsageStatus dynamicWorkingAreaUsageStatus;
		if (3u != 0)
		{
			dynamicWorkingAreaUsageStatus = DynamicWorkingAreaUsageStatus.Success;
		}
		try
		{
			WorkStepProximity workStepProximity = new WorkStepProximity();
			IWorkStepProximity workStepProximity2;
			if (8u != 0)
			{
				workStepProximity2 = workStepProximity;
			}
			WorkPlaneInstaller workPlaneInstaller = new WorkPlaneInstaller();
			IWorkPlaneInstaller installer;
			if (8u != 0)
			{
				installer = workPlaneInstaller;
			}
			POMContext context = new POMContext(_projectInterface, _toolInterface, null, _edgeInterface, _configurationInterface, _supportInterface, null);
			WorkingSizeAnalyzer workingSizeAnalyzer = new WorkingSizeAnalyzer(context, workStepProximity2, installer);
			WorkingSizeAnalyzer workingSizeAnalyzer2;
			if (8u != 0)
			{
				workingSizeAnalyzer2 = workingSizeAnalyzer;
			}
			workingSizeAnalyzer2.Initialize(null);
			DynamicWorkingAreaService dynamicWorkingAreaService = new DynamicWorkingAreaService(context, workingSizeAnalyzer2);
			dynamicWorkingAreaUsageStatus = dynamicWorkingAreaService.HasDynamicWorkingArea(_projectInterface);
			if (dynamicWorkingAreaUsageStatus.Equals(DynamicWorkingAreaUsageStatus.Success))
			{
				_projectInterface.UpdateGlobalDynamicWorkingAreaLength(dynamicWorkingAreaLength);
				dynamicWorkingAreaService.UpdateWorkingAreasLength(_projectInterface, dynamicWorkingAreaLength);
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710095), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
				if ((dynamicWorkingAreaUsageStatus & DynamicWorkingAreaUsageStatus.MachineFlagDisabled) == DynamicWorkingAreaUsageStatus.MachineFlagDisabled)
				{
					stringBuilder.AppendLine(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710319), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
				}
				if ((dynamicWorkingAreaUsageStatus & DynamicWorkingAreaUsageStatus.MachiningParametersFlagDisabled) == DynamicWorkingAreaUsageStatus.MachiningParametersFlagDisabled)
				{
					stringBuilder.AppendLine(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710272), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
				}
				if ((dynamicWorkingAreaUsageStatus & DynamicWorkingAreaUsageStatus.ProjectNotInHalfPlane) == DynamicWorkingAreaUsageStatus.ProjectNotInHalfPlane)
				{
					stringBuilder.AppendLine(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917710209), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
				}
				if ((dynamicWorkingAreaUsageStatus & DynamicWorkingAreaUsageStatus.ProjectWithMobileBars) == DynamicWorkingAreaUsageStatus.ProjectWithMobileBars)
				{
					stringBuilder.AppendLine(LocalizationManager.GetString(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709904), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990)));
				}
				AddToErrorFile(stringBuilder.ToString());
			}
		}
		catch (Exception innerException)
		{
			ExceptionManager.Throw(_0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917709851), _0023_003Dqri_o2Cl2J_0024bkE8VwjaHj7DHfxEf_0024WQMfT9o2LyOM3fs_003D._0023_003Dz7CKhi0I_003D(-917703990), ExceptionType.Exception, innerException);
		}
		return dynamicWorkingAreaUsageStatus;
	}

	private bool _0023_003Dzb_002442lb_0024R_0024wDBNwsVy6t03uE_003D(Plane _0023_003DzuphY4HU_003D)
	{
		_ = 3;
		if (5 == 0)
		{
		}
		if (_0023_003DzuphY4HU_003D.Type == PlaneType.Top)
		{
			_ = 0;
			if (7 == 0)
			{
			}
			ReferenceKey workpieceID = _0023_003DzuphY4HU_003D.WorkpieceID;
			_ = 6;
			if (4 == 0)
			{
			}
			return workpieceID == ActiveWorkpiece.ReferenceKey;
		}
		return false;
	}

	private bool _0023_003Dz2K5PmgB4CvHR61nrIbOVEBjDEJds67jhzg_003D_003D(WorkpieceSetup _0023_003DzSJfYMT8_003D)
	{
		_ = 6;
		if (5 == 0)
		{
		}
		ReferenceKey workpieceID = _0023_003DzSJfYMT8_003D.WorkpieceID;
		_ = 4;
		if (-1 == 0)
		{
		}
		return workpieceID == ActiveWorkpiece.ReferenceKey;
	}

	private bool _0023_003Dz9xOEEgYdFZTykffy3egI_0TVVa7gh1idqQ_003D_003D(Workplan _0023_003DzwwE3LYY_003D)
	{
		_ = 5;
		if (8 == 0)
		{
		}
		ReferenceKey referenceKey = _0023_003DzwwE3LYY_003D.ReferenceKey;
		_ = 5;
		if (1 == 0)
		{
		}
		return referenceKey == ActiveWorkplan.ReferenceKey;
	}
}
