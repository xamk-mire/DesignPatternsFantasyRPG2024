using System;

namespace DesignPatternsFantasyRPG.Quests.Models
{
    public interface IObserver
    {
        void Update(string questStatus);
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string questStatus);
    }

    public class Quest : ISubject
    {
        private string QuestStatus;
        private List<IObserver> Characters { get; set; }

        public string QuestTitle { get; set; } = string.Empty;

        public Quest(string questTitle, List<IObserver> characters)
        {
            Characters = characters;
            QuestStatus = questTitle;
        }

        // Other info

        public void RegisterObserver(IObserver observer)
        {
            Characters.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Characters.Remove(observer);
        }

        public void NotifyObservers(string questStatus)
        {
            foreach (IObserver observer in Characters)
            {
                observer.Update(QuestStatus);
            }
        }

        public void UpdateQuestStatus(string status)
        {
            QuestStatus = status;
            NotifyObservers(QuestStatus);
        }

        public void QuestCompleted()
        {
            UpdateQuestStatus("Quest has been completed");
        }
    }
}
