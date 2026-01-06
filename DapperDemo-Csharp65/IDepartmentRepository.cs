namespace DapperDemo_Csharp65;

public interface IDepartmentRepository
{
    public IEnumerable<Department> GetAllDepartments();
    public void InsertDepartment(string newDepartmentName);
}