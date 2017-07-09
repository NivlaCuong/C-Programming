namespace Thermostat {
	public class ThermoStat {
		public int Initial { set; get; }
		public int Final { get; set; }
		public int Degree { get; set; }
		public ThermoStat(int initial, int final) {
			Initial = initial;
			Final = final;
		}
		public void setTemp(int degree)  {
			try {
				int testing = degree;
				if (testing > Final || testing < Initial) {
					throw new TempreratureOutofRange();
				}
				Degree = degree;
			}
			catch (TempreratureOutofRange) {
				if (degree > Final) {
					throw new TempreratureTooHigh("Temprerature is Too High!");
				}
				if (degree < Initial) {
					throw new TempreratureTooLow("Temprerature is Too Low!");
				}
			}
		}
	}
}
