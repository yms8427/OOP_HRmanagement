namespace BilgeAdam.HR.Common.Abstractions
{
    public interface IManager
    {
        Department Department { get; set;}
        void SetEmployees(params Person[] employees);
    }
}