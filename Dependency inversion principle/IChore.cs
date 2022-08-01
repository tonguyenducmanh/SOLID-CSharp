namespace Dependency_inversion_principle
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }
}