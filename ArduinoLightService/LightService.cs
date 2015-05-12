using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ArduinoLightService
{
  public class LightService
  {
    private LightController _controller;

    public LightService()
    {
      _controller = new LightController();

      IPAddress ipAddress = IPAddress.Parse("192.168.0.2");
      TcpListener _listener = new TcpListener(ipAddress, 1234);

      _listener.Start();

      while (true)
      {
        Console.WriteLine("The server is running on port: 1234");
        Console.WriteLine("Waiting for connection...");

        Socket _socket = _listener.AcceptSocket();
        Console.WriteLine("Connection Accepted from: " + _socket.RemoteEndPoint);

        byte[] bytes = new byte[10];
        int numberOfBytesRecieved = _socket.Receive(bytes);

        Console.WriteLine("Recieved....");

        string command = ASCIIEncoding.ASCII.GetString(bytes);
        Console.WriteLine(command);
        RealCommand realCommand = ParseCommand(command);
        ProcessCommand(realCommand);
        _socket.Close();
      }
    }


    private RealCommand ParseCommand(string command)
    {
      try
      {
        string[] commandPairs = command.Split(':');
        RealCommand cmd = new RealCommand(commandPairs[0], int.Parse(commandPairs[1]));
        return cmd;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return null;
      }
    }

    private void ProcessCommand(RealCommand command)
    {
      switch (command.Colour)
      {
        case "green":
          {
            _controller.SetGreen(command.State == 1 ? true : false);
            break;
          }
        case "yellow":
          {
            _controller.SetYellow(command.State == 1 ? true : false);
            break;
          }
        case "red":
          {
            _controller.SetRed(command.State == 1 ? true : false);
            break;
          }
        default:
          {
            Console.WriteLine("Invalid Command.");
            break;
          }
      }

    }
  }
}
