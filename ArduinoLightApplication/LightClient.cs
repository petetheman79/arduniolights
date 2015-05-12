using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace ArduinoLightApplication
{
  public class LightClient
  {
    private string _host;
    private int _port;
    private int _timeout;
    private TcpClient _client;
    private Stream _stream;

    public bool Connect()
    {
      try
      {
        _host = "192.168.0.2";
        _port = 1234;
        _client = new TcpClient();
        _client.Connect(_host, _port);
        _stream = _client.GetStream();
        return true;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
        return false;
      }
    }

    public bool Disconnect()
    {
      try
      {
        _stream.Close();
        _client.Close();
        return true;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
        return false;
      }
    }

    public bool SendMessage(string colour, int state)
    {
      try
      {
        Connect();

        Command cmd = new Command(colour, state);
        byte[] bytes = ASCIIEncoding.ASCII.GetBytes(cmd.Cmd);

        _stream.Write(bytes, 0, bytes.Length);
        Disconnect();
        return true;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
        return false;
      }

    }

  }
}
