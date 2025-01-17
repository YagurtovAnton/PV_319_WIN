﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;

namespace Clock
{
	public class Alarm:IComparable<Alarm>
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Weekdays { get; set; }
		public string Filename { get; set; }
		public string Message { get; set; }
		public Alarm()
		{
			Weekdays = new Week();
		}

		public Alarm(DateTime date, TimeSpan time, Week weekdays, string filename, string message)
		{
			this.Date = date;
			this.Time = time;
			this.Weekdays = weekdays;
			this.Filename = filename;
			this.Message = message;
		Console.WriteLine($"Costractor:{this.GetHashCode()}");
		}
		
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.Weekdays = other.Weekdays;
			this.Filename = other.Filename;
			this.Message = other.Message;
			Console.WriteLine($"Costractor:{this.GetHashCode()}");
		}

		public override string ToString()
		{
			string info = "";
			if (Date != DateTime.MinValue) info += $"{Date}\t";
			info += DateTime.Today.Add(Time).ToString("hh:mm:ss tt");//.ToString(@"hh\:mm\:ss tt");
																	 //info += Time;//.ToString(@"hh\:mm\:ss tt");
			info += "\t";
			info += $"{Weekdays}\t";
			info += $"{Filename}\t";
			info += $"{Message}\t";
			return info;
		}
		//public static bool operator >(Alarm left, Alarm right)
		//{
		//	if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
		//	{
		//		return 
		//			(left.Date  == DateTime.MinValue ? DateTime.Today : left.Date)	>= 
		//			(right.Date == DateTime.MinValue ? DateTime.Today : right.Date)	&& 
		//			left.Time > right.Time;
		//	}
		//	else return left.Time > right.Time;
		//}
		//public static bool operator <(Alarm left, Alarm right)
		//{
		//	if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
		//	{
		//		return
		//			(left.Date == DateTime.MinValue ? DateTime.Today : left.Date) <=
		//			(right.Date == DateTime.MinValue ? DateTime.Today : right.Date) && 
		//			left.Time < right.Time;
		//	}
		//	else return left.Time < right.Time;
		//}
		public int CompareTo(Alarm other)
		{
			Console.WriteLine("Alarm comparison");
			return this.Time.CompareTo(other.Time);
		}
	}
}
