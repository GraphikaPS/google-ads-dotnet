﻿using Microsoft.Data.Analysis;
using System;
using System.Text;

/// <summary>
/// The Main class for this application.
/// https://gist.github.com/zHaytam/f2a30eeb91b92981e9020dda91ea2697
/// </summary>
public static class DataFrameUtils
{
    /// <summary>
    /// Runs the examples from command line arguments.
    /// </summary>
    /// <param name="df">Input dataframe for printing.</param>
    public static void PrettyPrint(this DataFrame df)
    {
        var sb = new StringBuilder();
        int width = GetLongestValueLength(df) + 4;

        for (int i = 0; i < df.Columns.Count; i++)
        {
            // Left align by 10
            sb.Append(string.Format(df.Columns[i].Name.PadRight(width)));
        }

        sb.AppendLine();

        long numberOfRows = Math.Min(df.Rows.Count, 25);
        for (int i = 0; i < numberOfRows; i++)
        {
            foreach (object obj in df.Rows[i])
            {
                sb.Append((obj ?? "null").ToString().PadRight(width));
            }

            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }

    private static int GetLongestValueLength(DataFrame df)
    {
        long numberOfRows = Math.Min(df.Rows.Count, 25);
        int longestValueLength = 0;

        for (int i = 0; i < numberOfRows; i++)
        {
            foreach (var value in df.Rows[i])
                longestValueLength = Math.Max(longestValueLength, value?.ToString().Length ?? 0);
        }

        return longestValueLength;
    }

    /*
    public static PrimitiveDataFrameColumn<TResult> Apply<T, TResult>(this PrimitiveDataFrameColumn<T> column,
        Func<T, TResult> func)
        where T : unmanaged
        where TResult : unmanaged
    {
        var resultColumn = new PrimitiveDataFrameColumn<TResult>(string.Empty, 0);

        foreach (var row in column)
            resultColumn.Append(func(row.Value));

        return resultColumn;
    }
    */

}
