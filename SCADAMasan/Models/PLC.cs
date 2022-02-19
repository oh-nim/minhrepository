
using S7.Net;
using SCADAMasan.Models;

namespace SCADAMasan
{
    public class PLC
    {
        Plc _plc = new Plc(CpuType.S71200, "192.168.1.50", 0, 0);
        public bool PLC_Connected = false;

        protected PLC()
        {

        }
        private static PLC _instance;
        public static PLC Instance()
        {
            if(_instance == null)
            {
                _instance = new PLC();
            }
            return _instance;
        }


        public bool Open()
        {
            if (!PLC_Connected)
            {
                if (_plc.Open() == ErrorCode.NoError)
                {
                    PLC_Connected = true;
                    return true;
                }
                else
                {
                    PLC_Connected = false;
                    return false;
                }
            }
            else return true;
        }

        public void Close()
        {
            if(PLC_Connected)
            {
                PLC_Connected = false;
                _plc.Close();
            }    
        }             


        public void ReadClass(object cl, int DB)
        {
            if (PLC_Connected)
            {
                _plc.ReadClass(cl, DB);
            }
        }
       
        public void WriteClass(object cl, int DB)
        {
            if (PLC_Connected)
            {
                _plc.WriteClass(cl, DB);
            }
        }

        public void ReadData()
        {
            int NumberDB = 10;

            ReadClass(PLCReadV2.Ins, NumberDB);
        }

    }
}
