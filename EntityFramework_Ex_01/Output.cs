using Microsoft.EntityFrameworkCore;
using Spectre.Console;
using Spectre.Console.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01
{
    public static class Output
    {
        [ModuleInitializer]
        public static void SetCulture()
        {
            CultureInfo.CurrentCulture =
                CultureInfo.CurrentUICulture =
                    CultureInfo.GetCultureInfo("en-US");
        }

        public static Table AddRows<T>(
           this Table table,
           IEnumerable<T> values,
           params Func<T, object>[] columnFunc)
        {
            foreach (var value in values)
            {
                var columns = new List<string>();
                foreach (var func in columnFunc)
                {
                    columns.Add(func(value)?.ToString());
                }
                table.AddRow((string[])columns.ToArray());
            }
            return table;
        }

        public static void Results(
            IQueryable query,
            string title,
            IRenderable results)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AnsiConsole.Write(
            new Panel(
                new Grid()
                .AddColumn()
                .AddRow($"{new string(query.ToQueryString().Replace("[", "").Replace("]", ""))}")
                .AddRow()
                .AddRow(results)
                )
            .Header(title)
            .BorderColor(Color.Red)
            .RoundedBorder());
        }
    }
}
