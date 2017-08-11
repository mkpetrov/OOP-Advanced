﻿using System;

public class WeeklyEntry:IComparable<WeeklyEntry>
{
    private WeekDay weekday;

    public WeeklyEntry(string weekday,string notes)
    {
        Enum.TryParse(weekday, out this.weekday);
        this.Notes = notes;
    }

    public WeekDay Weekday => this.weekday;
    public string Notes { get; protected set; }
    public override string ToString() => $"{this.Weekday} - {this.Notes}";


    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var weekDayComparison = weekday.CompareTo(other.weekday);
        if (weekDayComparison != 0) return weekDayComparison;
        return string.Compare(Notes,other.Notes,StringComparison.Ordinal);

    }
}