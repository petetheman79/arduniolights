using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoLightService
{
  public class RealCommand
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

    public RealCommand(string colour, int state)
    {
      Colour = colour;
      State = state;
    }
  }
}
