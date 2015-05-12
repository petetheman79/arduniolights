using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandMessenger.TransportLayer;
using CommandMessenger;
using System.Threading;

namespace ArduinoLights
{
  enum Command
  {
    SetRed,
    SetYellow,
    SetGreen,
  };

  public class LightController
  {
    private SerialTransport _serialTransport;
    private CmdMessenger _cmdMessanger;

    public LightController()
    {
      Setup();
    }
     
    public void Setup()
    {

      //Create Serial Port Object
      _serialTransport = new SerialTransport();
      _serialTransport.CurrentSerialSettings.PortName = "COM3";
      _serialTransport.CurrentSerialSettings.BaudRate = 115200;
      _serialTransport.CurrentSerialSettings.DtrEnable = false;

      //Initialize the command messanger
      _cmdMessanger = new CmdMessenger(_serialTransport);
      _cmdMessanger.BoardType = BoardType.Bit16;

      //AttachCommandCallBacks();

      //Start Listening
      _cmdMessanger.StartListening();

      SetRed(false);
      SetYellow(false);
      SetGreen(false);
    }

    public void Close()
    {
      SetRed(false);
      SetYellow(false);
      SetGreen(false);
      Thread.Sleep(10);
      _cmdMessanger.ClearSendQueue();
      _serialTransport.StopListening();
      _serialTransport.Close();
      _serialTransport.Dispose();
      _cmdMessanger.Dispose();
    }

    public void SetRed(bool state)
    {
     SetLed(Command.SetRed, state);
    }
    public void SetYellow(bool state)
    {
      SetLed(Command.SetYellow, state);
    }
    public void SetGreen(bool state)
    {
      SetLed(Command.SetGreen, state);
    }
    
    private void SetLed(Command cmd, bool state)
    {
      var command = new SendCommand((int)cmd, state);
      _cmdMessanger.SendCommand(command);
    }
  }

}
