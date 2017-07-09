using System;
namespace Thermostat {
	public class TempreratureTooHigh : TempreratureOutofRange {
		public TempreratureTooHigh(string msg) : base(msg) { }
	}
}

