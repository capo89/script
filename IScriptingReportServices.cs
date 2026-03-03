namespace ScmGroup.XCam.Scripting;

public interface IScriptingReportServices
{
	bool IsSuccess();

	void AddMessage(string message);

	string GetMessage();
}
