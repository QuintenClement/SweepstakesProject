using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SelectDataType
    {
        public static void ChooseDataType()
        {
            ISweepstakesManager sweepstakesManager;
            SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
            SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
            MarketingFirm marketingFirm;
            UI.SelectDataStorageType();
            string dataType = Console.ReadLine();
            dataType = dataType.ToLower();
            
            if (dataType == "stack")
            {
                sweepstakesManager = sweepstakesStackManager;
                marketingFirm = new MarketingFirm(sweepstakesManager);
                marketingFirm.RunProgram();
            }
            else if (dataType == "queue")
            {
                sweepstakesManager = sweepstakesQueueManager;
                marketingFirm = new MarketingFirm(sweepstakesManager);
                marketingFirm.RunProgram();
            }
            else if (dataType != "stack" || dataType != "queue")
            {
                ChooseDataType();
            }
        }        
    }
}
