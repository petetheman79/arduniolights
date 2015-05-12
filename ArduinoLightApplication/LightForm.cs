using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoLightApplication
{
  public partial class LightForm : Form
  {
    private LightClient _controller;
    public LightForm()
    {
      InitializeComponent();
      _controller = new LightClient();
      //_controller.Connect();
    }

    private void btnGreen_Click(object sender, EventArgs e)
    {
      ChangeLightState((Button)sender);
    }


    private void ChangeLightState(Button button)
    {
      string colour = string.Empty;
      int state = 0;

      if (button.Text.Equals("OFF"))
      {
        button.Text = "ON";
        state = 1;
      }
      else
      {
        button.Text = "OFF";
        state = 0;
      }

      if (button == btnGreen)
      {
        colour = "green";
      }
      else if (button == btnYellow)
      {
        colour = "yellow";
      }
      else if (button == btnRed)
      {
        colour = "red";
      }
      else
      {
        colour = "none";
      }

      _controller.SendMessage(colour, state);

    }

    private void LightForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      //_controller.Disconnect();
    }
  }
}
