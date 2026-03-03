using ScmGroup.XCam.MachiningDataModel;

namespace ScmGroup.XCam.Scripting;

public class TpaUtility
{
	public TpaUtility()
	{
		_ = 2;
		if (-1 == 0)
		{
		}
		base._002Ector();
	}

	public static TypeOfHeadsGroup GetTypeOfHeadsGroup(int tpaGroupCode)
	{
		TypeOfHeadsGroup result;
		if (5u != 0)
		{
			result = TypeOfHeadsGroup.None;
		}
		if (tpaGroupCode > 10000)
		{
			int num = tpaGroupCode / 10000;
			int num2;
			if (3u != 0)
			{
				num2 = num;
			}
			int num3 = tpaGroupCode / 1000 % 10;
			int num4;
			if (4u != 0)
			{
				num4 = num3;
			}
			switch (num2)
			{
			case 1:
				result = TypeOfHeadsGroup.LowerVertical;
				break;
			case 2:
				result = TypeOfHeadsGroup.UpperVertical;
				break;
			case 3:
				switch (num4)
				{
				case 1:
					result = TypeOfHeadsGroup.LeftHorizontal;
					break;
				case 2:
					result = TypeOfHeadsGroup.RightHorizontal;
					break;
				}
				break;
			case 4:
				switch (num4)
				{
				case 1:
					result = TypeOfHeadsGroup.AdditionalLeftHorizontal;
					break;
				case 2:
					result = TypeOfHeadsGroup.AdditionalRightHorizontal;
					break;
				}
				break;
			}
		}
		return result;
	}
}
