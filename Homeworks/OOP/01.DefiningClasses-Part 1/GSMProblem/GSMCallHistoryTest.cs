namespace GSMProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMCallHistoryTest
    {

        private static Call FindLongestCall(GSM gsm)
        {
            double longest = uint.MinValue;
            foreach (var call in gsm.CallHistory)
            {
                if (call.Duration > longest)
                {
                    longest = call.Duration;
                }
            }

            Call longestCall = gsm.CallHistory.FirstOrDefault(c => c.Duration == longest);

            return longestCall;
        }

        public static void TestHistoryCalls()
        {
            GSM gsm = new GSM("XPERIA", "Sony Corp.", new Battery(BatteryType.Li_Ion, 1000, 500), new Display(5, 16000000));

            List<Call> fewCalls = new List<Call>();

            fewCalls.Add(new Call("0888123456", 300));
            fewCalls.Add(new Call("0888654321", 100));
            fewCalls.Add(new Call("0888888888", 200));

            foreach (var call in fewCalls)
            {
                gsm.AddCall(call);
            }

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
