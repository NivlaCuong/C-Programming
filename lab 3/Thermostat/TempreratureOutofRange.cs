using System;
namespace Thermostat {
	public class TempreratureOutofRange : Exception {
		public TempreratureOutofRange() {
		}
		public TempreratureOutofRange(String msg) : base(msg) { }
	}

}
