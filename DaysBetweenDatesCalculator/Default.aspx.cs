using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaysBetweenDatesCalculator
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void calculateButton_Click(object sender, EventArgs e)
		{
			if (firstCalendar.SelectedDate == default(DateTime) || secondCalendar.SelectedDate == default(DateTime))
				resultLabel.Text = "Please select two valid dates.";
			else if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
			{
				TimeSpan daysElapsed = firstCalendar.SelectedDate - secondCalendar.SelectedDate;
				resultLabel.Text = String.Format("There are {0} days between {1} and {2}",
					daysElapsed.TotalDays.ToString(),
					secondCalendar.SelectedDate.ToLongDateString(),
					firstCalendar.SelectedDate.ToLongDateString());
			}
			else
			{
				TimeSpan daysElapsed = secondCalendar.SelectedDate - firstCalendar.SelectedDate;
				resultLabel.Text = String.Format("There are {0} days between {1} and {2}",
					daysElapsed.TotalDays.ToString(),
					firstCalendar.SelectedDate.ToLongDateString(),
					secondCalendar.SelectedDate.ToLongDateString());
			}
		}
	}
}