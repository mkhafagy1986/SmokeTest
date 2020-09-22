using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Excel = Microsoft.Office.Interop.Excel;


class VideoDataDriver
{
    private string _filename;
    //---------------------------------------------------Excel File ----------------------------------------------------------------------
    private Hashtable _VideoFileContent;
    public Hashtable VideoFileContent
    {
        get
        {
            return _VideoFileContent;
        }
        set { _VideoFileContent = value; }
    }
    public VideoDataDriver()
    {
        _VideoFileContent = new Hashtable();
        _filename = Environment.CurrentDirectory + "\\Data\\" + @"VideosFile.xlsx";
        readVideosFromFiles(_filename);
    }

    private void readVideosFromFiles(string filename)
    {
        _Excel.Application StudentsExcel = new _Excel.Application();
        _Excel.Workbook wb = StudentsExcel.Workbooks.Open(_filename);
        _Excel.Worksheet ws = wb.Sheets[1];
        _Excel.Range xr = ws.UsedRange;

        int rowCount = xr.Rows.Count;

        for (int i = 1; i <= rowCount; i++)
        {
            VideoData VideoDataObject = new VideoData();

            VideoDataObject.URL = xr.Cells[i, 1].Value;
            VideoDataObject.WaitTime= (int)xr.Cells[i, 2].Value;
            _VideoFileContent.Add(i, VideoDataObject);
        }
        wb.Close();
    }
}

