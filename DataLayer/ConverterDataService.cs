using ConverterCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ConverterDataService
    {
        IConverterDataService converterDataService;

        public ConverterDataService()
        {
            //converterDataService = new TextFileDataService();
            converterDataService = new InMemoryDataService();
            //converterDataService = new JsonFileDataService();
            //converterDataService = new DBDataService();

        }
        public List<History> GetHistory()
        {
            return converterDataService.GetAllHistory();
        }

        public bool AddAccount(History history)
        {
            return converterDataService.CreateAccount(history);
        }

        public void UpdateAccount(History history)
        {
            converterDataService.UpdateAccount(history);
        }

        public void RemoveHistory(History history)
        {
            
        }

    }
}

