namespace BilgeAdam.HR.Common.Abstractions
{
    public interface IManager
    {
        void SetEmployees(params Person[] employees);
    }
}