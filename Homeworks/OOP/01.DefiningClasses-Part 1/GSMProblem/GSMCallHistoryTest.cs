namespace GSMProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMCallHistoryTest
    {

        private static Call FindLongestCall(GSM gsm)
        {
            Call longestCall = gsm.CallHistory.OrderBy(c => c.Duration).Last();

            return longestCall;
        }

        public static void TestHistoryCalls()
        {
            GSM gsm = new GSM("XPERIA", "Sony Corp.", new Battery(BatteryType.Li_Ion, 1000, 500), new Display(5, 16000000));

            gsm.AddCall(new Call("0888123456", 300));
            gsm.AddCall(new Call("0888654321", 100));
            gsm.AddCall(new Call("0888888888", 200));

            decimal totalPriceOfCalls = gsm.CalculateTotalCallPrice((decimal)0.37);

            Console.WriteLine("Total price of the calls is: {0} BGN", totalPriceOfCalls);

            Call longestCall = FindLongestCall(gsm);

            gsm.DeleteCall(longestCall);

            totalPriceOfCalls = gsm.CalculateTotalCallPrice((decimal)0.37);

            Console.WriteLine("Total price after remove longest call is: {0} BGN", totalPriceOfCalls);

            gsm.ClearCallHistory();
        }
    }
}
