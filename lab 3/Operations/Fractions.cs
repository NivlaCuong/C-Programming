using System;
namespace Operations {
	public struct Fractions : IComparable<Fractions> {
		public long Denominator { get; set; }
		public long Numerator { get; set; }
		bool Initialized { get; set; }
		public Fractions(long numerator, long denom) {
			Denominator = denom;
			Numerator = numerator;
			if (denom == 0) Initialized = false;
			else { Initialized = true; }
		}
		public static Fractions operator +(Fractions a, Fractions b) {
			Fractions result;
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			if (a.Denominator.Equals(b.Denominator)) {
				result = new Fractions(a.Numerator + b.Numerator, a.Denominator);
			}
			else {
				result = new Fractions(a.Numerator * b.Denominator + b.Numerator * a.Denominator,
								a.Denominator * b.Denominator);
			}
			result.simplifyFraction(GCD(result.Numerator, result.Denominator));
			return result;
		}
		public static Fractions operator -(Fractions a, Fractions b) {
			Fractions result;
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			if (a.Denominator.Equals(b.Denominator)) {
				result = new Fractions(a.Numerator - b.Numerator, a.Denominator);
			}
			else {
				result = new Fractions(a.Numerator * b.Denominator - b.Numerator * a.Denominator,
								a.Denominator * b.Denominator);
			}
			result.simplifyFraction(GCD(result.Numerator, result.Denominator));
			return result;
		}
		public static Fractions operator -(Fractions a) {
			Fractions result = a;
			if (result.Initialized == false) throw new Exception();
			result.Numerator *= -1;
			return result;
		}
		public static Fractions operator *(Fractions a, Fractions b) {
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			Fractions result = new Fractions(a.Numerator * b.Numerator, b.Denominator * a.Denominator);
			result.simplifyFraction(GCD(result.Numerator, result.Denominator));
			return result;
		}
		public static Fractions operator /(Fractions a, Fractions b) {
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			Fractions result = new Fractions(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
			result.simplifyFraction(GCD(result.Numerator, result.Denominator));
			return result;
		}
		public static bool operator >(Fractions a, Fractions b) { 
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			Fractions newA = new Fractions(a.Numerator * b.Denominator, a.Denominator * b.Denominator);
			Fractions newB = new Fractions(b.Numerator * a.Denominator, b.Denominator * a.Denominator);
			if (newA.Denominator == newB.Denominator && newA.Numerator > newB.Numerator) {
				return true;
			}
			return false;
		}
		public static bool operator <(Fractions a, Fractions b) {
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			Fractions newA = new Fractions(a.Numerator * b.Denominator, a.Denominator * b.Denominator);
			Fractions newB = new Fractions(b.Numerator * a.Denominator, b.Denominator * a.Denominator);
			if (newA.Denominator == newB.Denominator && newA.Numerator < newB.Numerator)
			{
				return true;
			}
			return false;
		}
		public static bool operator <=(Fractions a, Fractions b) {
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			Fractions newA = new Fractions(a.Numerator * b.Denominator, a.Denominator * b.Denominator);
			Fractions newB = new Fractions(b.Numerator * a.Denominator, b.Denominator * a.Denominator);
			if (newA.Denominator == newB.Denominator && newA.Numerator <= newB.Numerator)
			{
				return true;
			}
			return false;
		}
		public static bool operator >=(Fractions a, Fractions b) {
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			Fractions newA = new Fractions(a.Numerator * b.Denominator, a.Denominator * b.Denominator);
			Fractions newB = new Fractions(b.Numerator * a.Denominator, b.Denominator * a.Denominator);
			if (newA.Denominator == newB.Denominator && newA.Numerator >= newB.Numerator) {
				return true;
			}
			return false;
		}
		public static bool operator ==(Fractions a, Fractions b) {
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			if (a.CompareTo(b) == 0) return true;
			return false;
		}
		public static bool operator !=(Fractions a, Fractions b) {
			if (a.Initialized == false || b.Initialized == false) throw new Exception();
			if (a.CompareTo(b) != 0) return true;
			return false;
		}

		public void simplifyFraction(long gcd) {
			Denominator /= gcd;
			Numerator /= gcd;
			if (Denominator < 0) {
				Numerator *= -1;
				Denominator *= -1;
			}
		}
		static long GCD(long top, long bot) {
			while (bot != 0) {
				long temp = bot;
				bot = top % bot;
				top = temp;
			}
			return top;
		}

		public int CompareTo(Fractions other) {
			if (this > other) return 1;
			if (this < other) return -1;
			return 0;
		}
		public override bool Equals(object obj) {
			if (obj == null) return false;
			if (obj.GetType() == GetType()) {
				Fractions other = (Fractions)obj;
				if (other.Initialized == false || Initialized == false) throw new Exception();
				simplifyFraction(GCD(Numerator, Denominator));
				simplifyFraction(GCD(other.Numerator, other.Denominator));
				return Denominator == other.Denominator && Numerator == other.Numerator;
			}
			return false;
		}
		public override int GetHashCode() {
			if (Initialized == false) throw new Exception();
			return Denominator.GetHashCode();
		}

		public static implicit operator int(Fractions frac) {
			return (int)(frac.Numerator / frac.Denominator);
		}
		public static explicit operator Fractions(int frac) {
			return new Fractions(frac, 1);
		}


		public static implicit operator float(Fractions frac) {
			return (float) frac.Numerator / frac.Denominator;
		}
		public static explicit operator Fractions(float frac) {
			return new Fractions((long)frac, 1);
		}
		public string printFraction() {
			return string.Format("{0}/{1}", Numerator, Denominator);
		}
	}
}
