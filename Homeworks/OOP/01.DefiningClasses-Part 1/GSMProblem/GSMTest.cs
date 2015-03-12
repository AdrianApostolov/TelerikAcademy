namespace GSMProblem
{
    using System;
    using System.Text;

    class GSMTest
    {
        public static void TestedGSM()
        {
            GSM SONY = new GSM("XPERIA Z", "Sony Corp.", new Battery(BatteryType.Li_Ion, 500, 150), new Display(5, 16000000));
            GSM Samsung = new GSM("Galaxy S5", "Samsung Corp.", new Battery(BatteryType.Li_Poly, 600, 200), new Display(5, 16000000));
            GSM HTC = new GSM("One X8", "HTC Corp.", new Battery(BatteryType.NiCd, 450, 100), new Display(4.8, 16000000));

            GSM[] gsms = new GSM[] { SONY, Samsung, HTC };

            StringBuilder testedGSM = new StringBuilder();

            for (int i = 0; i < gsms.Length; i++)
            {
                testedGSM.AppendLine(gsms[i].ToString());
                testedGSM.AppendLine();
            }

            testedGSM.AppendLine(GSM.IPhone4S.ToString());
            Console.WriteLine(testedGSM.ToString());
        }
    }
}
