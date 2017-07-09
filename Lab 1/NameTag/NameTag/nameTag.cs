using System;
namespace NameTag
{
	public class NameTag
	{
		public NameTag(string name, string organization)
		{
			this.Name = name;
			this.Organization = organization;
		}

		public string Name
		{
			get;
			set;
		}

		public string Organization
		{
			get;
			set;
		}

		public void clear()
		{
			Name = "";
			Organization = "";
		}

		public void printBlankTag() {
			Console.WriteLine(
				"##################################################" + Environment.NewLine +
				"###             ANNUAL CONFERENCE              ###" + Environment.NewLine +
				"##################################################" + Environment.NewLine +
				"### NAME: {0, -35}  ###" + Environment.NewLine +
				"###                                            ###" + Environment.NewLine +
				"##################################################" + Environment.NewLine +
				"### ORGANIZATION: {1, -26}   ###" + Environment.NewLine +
				"###                                            ###" + Environment.NewLine +
				"##################################################", "", "");
		}

		public override string ToString()
		{
			return String.Format(
				"##################################################" + Environment.NewLine +
				"###             ANNUAL CONFERENCE              ###" + Environment.NewLine +
				"##################################################" + Environment.NewLine +
				"### NAME: {0, -35}  ###" + Environment.NewLine +
				"###                                            ###" + Environment.NewLine +
				"##################################################" + Environment.NewLine +
				"### ORGANIZATION: {1, -26}   ###" + Environment.NewLine +
				"###                                            ###" + Environment.NewLine +
				"##################################################", Name, Organization);
		}
	}
}

