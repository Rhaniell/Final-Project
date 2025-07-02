using ConverterCommon;

namespace DataLayer
{
    public class InMemoryDataService : IConverterDataService
    {
        
            List<History> history = new List<History>();
        public InMemoryDataService()
        {
            CreateDummyHistory();
        }

        private void CreateDummyHistory()
        {
            History history1 = new History();
            history1.Type = "M to Cm";
            history1.AmountToConvert = 1;
            history1.ConvertedAmount = 100;

            history.Add(history1);

            History history2 = new History();
            history2.Type = "Km to Cm";
            history2.AmountToConvert = 1;
            history2.ConvertedAmount = 1000;

            history.Add(history2);

            History history3 = new History();
            history3.Type = "Hour to Second";
            history3.AmountToConvert = 1;
            history3.ConvertedAmount = 60;

            history.Add(history3);
        }

        public bool CreateAccount(History bankAccount)
        {
            return true;
        }



        public List<History> GetHistory()
        {
            return history;
        }

        public void RemoveHistory(History bankAccount)
        {
            history.Clear();
        }

        public void UpdateAccount(History bankAccount)
        {
            throw new NotImplementedException();
        }

        public List<History> GetHistory()
        {
            throw new NotImplementedException();
        }

        public bool RemoveAccount(History bankAccount)
        {
            throw new NotImplementedException();
        }
    }
}
