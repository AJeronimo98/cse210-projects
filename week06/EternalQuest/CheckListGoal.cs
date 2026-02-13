public class CheckListGoal : Goal
{
    private int _targetCount;
    private int _currentCount = 0;
    private int _bonus;

    public CheckListGoal (string name, string description, int points, int targetCount, int bonus)
    : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount == _targetCount)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
}
