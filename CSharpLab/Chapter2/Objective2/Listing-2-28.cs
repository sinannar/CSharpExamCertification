using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace CSharpLab.Chapter2.Objective2
{
    public static class Listing_2_28
    {
        public static void RunMain()
        {

        }

        class MyClass
        {
            private void DisplayInExcel(IEnumerable<dynamic> entities)
            {
                //var excelApp = new Excel.Application();
                //excelApp.Visible = true;

                //excelApp.Workbooks.Add();

                //dynamic workSheet = excelApp.ActiveSheet;

                //workSheet.Cells[1, "A"] = "Header A";
                //workSheet.Cells[1, "B"] = "Header B";

                //var row = 1;
                //foreach (var entity in entities)
                //{
                //    row++;
                //    workSheet.Cells[row, "A"] = entity.ColumnA;
                //    workSheet.Cells[row, "B"] = entity.ColumnB;
                //}

                //workSheet.Columns[1].AutoFit();
                //workSheet.Columns[2].AutoFit();
            }

            public void foo()
            {
                // USING DYNAMIC
                var entities = new List<dynamic>
                {
                    new
                    {
                        ColumnA = 1,
                        ColumnB = "Foo"
                    },
                    new
                    {
                        ColumnA = 2,
                        ColumnB = "Bar"
                    },
                };
                this.DisplayInExcel(entities);
            }

        }
    }
}
