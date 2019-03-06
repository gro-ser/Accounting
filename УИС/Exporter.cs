using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace УИС
{
    abstract class Exporter
    {
        public enum Bool : byte { Нет, Да }
        public enum What : byte { Выбранные, Все }

        public virtual void Export(DataGridView grid, string name, string path)
        { Export(grid, Columns(grid), Rows(grid), name, path); }
        public abstract void Export(DataGridView grid, int[] columns, int[] rows, string name, string path);

        static Bool openAfter = Bool.Да; static What allColumns = What.Все, allRows = What.Все;

        [DisplayName("Открыть после экспортирования")]
        [Description("Будет ли открыт файл после эспортирования.")]
        public Bool OpenAfter
        {
            get { return openAfter; }
            set { openAfter = value; }
        }

        [DisplayName("Выбрать столбцы")]
        [Description("Указывает, будут ли экспортированы все или только выбранные столбцы.")]
        public What AllColumns
        {
            get { return allColumns; }
            set { allColumns = value; }
        }

        [DisplayName("Выбрать строки")]
        [Description("Указывает, будут ли экспортированы все или только выбранные строки.")]
        public What AllRows
        {
            get { return allRows; }
            set { allRows = value; }
        }

        public int[] Columns(DataGridView dgv)
        {
            int length = dgv.ColumnCount, count;
            int[] indexes = new int[length];
            if (AllColumns == What.Все)
                for (int i = 0; i < length; i++) indexes[i] = i;
            else
            {
                count = 0;
                for (int i = 0; i < length; i++)
                    if (dgv.Columns[i].Visible)
                    {
                        indexes[count] = i;
                        count += 1;
                    }
                Array.Resize(ref indexes, count);
            }
            return indexes;
        }
        public int[] Rows(DataGridView dgv)
        {
            int length = dgv.RowCount, count;
            if (dgv.AllowUserToAddRows) length--;
            int[] indexes = new int[length];
            if (AllRows == What.Все)
                for (int i = 0; i < length; i++) indexes[i] = i;
            else
            {
                count = 0;
                for (int i = 0; i < length; i++)
                    if (dgv.Rows[i].Selected)
                    {
                        indexes[count] = i;
                        count += 1;
                    }
                Array.Resize(ref indexes, count);
            }
            return indexes;
        }
        public virtual string FileFilter()
        {
            return "All Files|*.*";
        }
    }

    class CSVExport : Exporter
    {
        static char separator = ';';

        [DisplayName("Разделять точкой с запятой")]
        [Description("Разделение значений точкой с запятой (;) или запятой (,).")]
        public Bool CommaSeparated
        {
            get { return (separator == ';') ? Bool.Да : Bool.Нет; }
            set { separator = value == Bool.Да ? ';' : ','; }
        }
        string eval(object obj)
        {
            if (obj == null || obj is DBNull) return @"""""";
            string s = obj.ToString().Replace(@"""", @"""""");
            if (s.IndexOf(separator) == -1) return s;
            else return '"' + s + '"';
        }
        public override void Export(DataGridView grid, int[] columns, int[] rows, string name, string path)
        {
            var write = new StreamWriter(path, false, Encoding.GetEncoding("windows-1251"));
            for (int row = 0; row < rows.Length; row++)
            {
                write.Write(eval(grid[columns[0], rows[row]].Value));
                for (int column = 1; column < columns.Length; column++)
                {
                    write.Write(separator);
                    write.Write(eval(grid[columns[column], rows[row]].Value));
                }
                write.WriteLine();
            }
            write.Close();
            if (OpenAfter == Bool.Да) try { Process.Start(path); } catch { }
        }
        public override string ToString() { return "CSV"; }
        public override string FileFilter() { return "CSV|*.csv"; }
    }

    class TextExport : Exporter
    {
        string eval(object obj)
        {
            if (obj == null || obj is DBNull) return @"""""";
            string s = obj.ToString().Replace(@"""", @"""""");
            if (s.IndexOf('\t') == -1) return s;
            else return '"' + s + '"';
        }
        public override void Export(DataGridView grid, int[] columns, int[] rows, string name, string path)
        {
            var write = new StreamWriter(path);
            for (int row = 0; row < rows.Length; row++)
            {
                write.Write(eval(grid[columns[0], rows[row]].Value));
                for (int column = 1; column < columns.Length; column++)
                {
                    write.Write('\t');
                    write.Write(eval(grid[columns[column], rows[row]].Value));
                }
                write.WriteLine();
            }
            write.Close();
            if (OpenAfter == Bool.Да) try { Process.Start(path); } catch { }
        }
        public override string ToString() { return "Text"; }
        public override string FileFilter() { return "Text File|*.txt"; }
    }
}
