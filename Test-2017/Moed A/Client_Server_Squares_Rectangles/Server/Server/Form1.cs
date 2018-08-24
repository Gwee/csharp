using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Collections;
using Common;
namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpChannel chnl = new HttpChannel(1234);
            ChannelServices.RegisterChannel(chnl, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ServerPart),
                "_Server_",
                WellKnownObjectMode.Singleton);
        }
    }

    class ServerPart : MarshalByRefObject, ICommon
    {
        private List<TypeSizeColor> TypeSizeColor_List_Square = new List<TypeSizeColor>();
        private List<TypeSizeColor> TypeSizeColor_List_Rectangle = new List<TypeSizeColor>();

        public void add_Client(TypeSizeColor[] arrTypeSizeColor)
        {
            for (int i = 0; i < arrTypeSizeColor.Length; i++)
                if (arrTypeSizeColor[i].mSize.Width == arrTypeSizeColor[i].mSize.Height)
                    TypeSizeColor_List_Square.Add(arrTypeSizeColor[i]);
                else
                    TypeSizeColor_List_Rectangle.Add(arrTypeSizeColor[i]);

            TypeSizeColor_List_Square.Sort((x, y) => x.mSize.Width * x.mSize.Height - y.mSize.Width *y.mSize.Height);
            TypeSizeColor_List_Rectangle.Sort((x, y) => x.mSize.Width * x.mSize.Height - y.mSize.Width * y.mSize.Height);
        }
        public TypeSizeColor[] getData(bool isSquare, int prevCounter)
        {
            if (isSquare == true && prevCounter == TypeSizeColor_List_Square.Count
                ||
                isSquare == false && prevCounter == TypeSizeColor_List_Rectangle.Count)
                return null;

                TypeSizeColor[] arrTypeSizeColor;
                if (isSquare == true)
                {
                    arrTypeSizeColor = new TypeSizeColor[TypeSizeColor_List_Square.Count];
                    for (int i = 0; i < TypeSizeColor_List_Square.Count; i++)
                        arrTypeSizeColor[i] = TypeSizeColor_List_Square[i];
                    return arrTypeSizeColor; 
                }
                arrTypeSizeColor = new TypeSizeColor[TypeSizeColor_List_Rectangle.Count];
                for (int i = 0; i < TypeSizeColor_List_Rectangle.Count; i++)
                    arrTypeSizeColor[i] = TypeSizeColor_List_Rectangle[i];
                return arrTypeSizeColor; 
      
        }
     }
}