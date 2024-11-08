using DesignPatternsFantasyRPG.Quests.Models;

namespace DesignPatternsFantasyRPG.Quests
{
    public class QuestManager  //: ISubject
    {
        private List<Quest> _quests = new List<Quest>();

        public void CreateNewQuest(string questTitle, List<IObserver> characters)
        {
            var quest = new Quest(questTitle, characters);
            _quests.Add(quest);
        }

        public List<Quest> GetQuests() { return _quests; }

        /*
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string questStatus)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(questStatus);
            }
        }

        public void UpdateQuestStatus(string status)
        {
            _questStatus = status;
            NotifyObservers(_questStatus);
        }*/
    }
}
