using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Drawing;
using System.Collections;

namespace Common
{
    [Serializable]
    public class Counter_Client_Rectangle_Square_Data
    {
        public int Counter_Client, Counter_Data, Counter_Rectangles, Counter_Squares;
        public Counter_Client_Rectangle_Square_Data(int _Clients, int _Rectangles, int _Squares, int _Data)
        {
            Counter_Client = _Clients;
            Counter_Rectangles = _Rectangles;
            Counter_Squares = _Squares;
            Counter_Data = _Data;
        }
    }

    public interface ICommon 
    {
        void add_Client(Size[] arrSize);
        Counter_Client_Rectangle_Square_Data getData(int prevCounter_Data);
        void remove_Client(Size[] arrSize);
    }
}
