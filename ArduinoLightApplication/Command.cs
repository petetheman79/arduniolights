using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoLightApplication
{
  public class Command
  {
    public string Colour
    {
      get;
      set;
    }

    public int State
    {
      get;
      set;
    }

    public string Cmd
    {
      get
      {
        return Colour + ":" + State;
      }
    }

    public Command(string colour, int state)
    {
      Colour = colour;
      State = state;
    }
  }
}
