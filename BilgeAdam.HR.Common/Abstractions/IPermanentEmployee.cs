namespace BilgeAdam.HR.Common.Abstractions
{
    public interface IPermanentEmployee
    {
        Person ReportsTo { get; }

        decimal Salary { get; set; }

        void SetManager(IManager manager);
    }
}