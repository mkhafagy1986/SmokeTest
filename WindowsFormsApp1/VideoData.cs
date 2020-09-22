using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VideoData
{

    private string _URL;
    private int _WaitTime;
    
    public VideoData()
    {
        _URL = "";
        _WaitTime = 0;
    }

    public VideoData(string URL,int WaitTime)
    {
        _URL = URL;
        _WaitTime = WaitTime;
    }

    public string URL
    {
        get
        {
            return _URL;
        }
        set
        {
            _URL = value;
        }
    }

    public int WaitTime
    {
        get
        {
            return _WaitTime;
        }
        set
        {
            _WaitTime = value;
        }
    }
}

