using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoLights
{
  public partial class LightForm : Form
  {
    LightController _lightController;
    public LightForm()
    {
      InitializeComponent();
      _lightController = new LightController();    
    }

    private void btnRed_Click(object sender, EventArgs e)
    {
      ChangeLight((Button)sender);
    }


    private void ChangeLight(Button button)
    {
      bool lightOn = false;
      if (button.Text.Equals("ON"))
      {
        button.Text = "OFF";
        lightOn = false;
      }
      else
      {
        button.Text = "ON";
        lightOn = true;
      }

      if (button == btnRed)
      {
        _lightController.SetRed(lightOn);
      }
      else if (button == btnGreen)
      {
        _lightController.SetGreen(lightOn);
      }
      else if (button == btnYellow)
      {
        _lightController.SetYellow(lightOn);
      }
      else
      {
        // no match
      }
      


      
    }

    private void btnYellow_Click(object sender, EventArgs e)
    {
      ChangeLight((Button)sender);
    }

    private void btnGreen_Click(object sender, EventArgs e)
    {
      ChangeLight((Button)sender);
    }

    private void LightForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      _lightController.Close();
    }
  }
}
