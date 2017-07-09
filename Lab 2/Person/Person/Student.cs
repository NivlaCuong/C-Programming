using System;
using System.Collections.Generic;
namespace Person {
	public class Student : Person {
		Dictionary<string, string> list;
		Dictionary<string, int> credit;
		public Student(string firstname, string lastname) : base(firstname, lastname) {
			list = new Dictionary<string, string>();
			credit = new Dictionary<string, int>();
		}
		public void addClass(string className, string grade, int unit) {
			if (!list.ContainsKey(className)) {
				list.Add(className, grade);
				credit.Add(className, unit);
			}
		}

		public void dropClass(string className) {
			if (list.ContainsKey(className)) {
				list.Remove(className);
				credit.Remove(className);
			}
		}

		public string getLetterGrade(string className) {
			if (list.ContainsKey(className)) {
				return list[className];
			}
			throw new Exception("There is no " + className + " in this student's schedule.");
		}

		public double getGPA(string lettergrade) {
			if (lettergrade == "A") 
				return 4.0;
			if (lettergrade == "B")
				return 3.0;
			if (lettergrade == "C")
				return 2.0;
			if (lettergrade == "D")
				return 1.0;
			return 0.0;
		}

		public double calculateGPA() {
			int sumCredit = 0;
			double totalScore = 0;
			foreach (string key in credit.Keys) {
				sumCredit += credit[key];
				totalScore += credit[key] * getGPA(list[key]);
			}
			return totalScore/sumCredit;
		}

		public string printTranscript() {
			String s = String.Format("{0,10} {1, 16} {2, 10} {3, 10}\n\n", "Class Taken", "Letter grade", "Credit", "GPA");
			foreach (string key in list.Keys) {
				s += String.Format("{0, -12} {1,10} {2, 13} {3, 12:0.0}\n", key, list[key], credit[key], getGPA(list[key]));
			}
			s += String.Format("\nTotal GPA Cumulative: {0:0.0} ", calculateGPA());
			return s;
		}


	}		
}
