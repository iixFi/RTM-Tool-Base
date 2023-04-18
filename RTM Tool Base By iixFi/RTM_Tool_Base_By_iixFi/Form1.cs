///////////////////////////////////////////////////////
//         --- RTM Tool Base By iixFi ---            //
// ************************************************* //
//            For: CCAPI/TMAPI/PS3MAPI               //
//                                                   //
// Features:                                         //
// - Three types of connections.                     //
// - internet info + refresh PS3 Connection status.  //
// - Read/Write Memory.                              //
// - Get/Set Memory.                                 //
//                                                   //
//                                                   //
// - Follow Me:                                      //
//                                                   //
//  * Instagram: 0xff_x                              //
//  * Snapchat: fa_2k                                //
//  * Discord: iixFi#7423                            //
//  * Youtube: iixFi                                 //
//                                                   //
// ************************************************* //
//   --- Copyright (c) 2023 | iixFi Creations  ---   //
// ************************************************* //
//                                                   //
///////////////////////////////////////////////////////
using PS3Lib;
using RTM_Tool_Base_By_iixFi.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;

namespace RTM_Tool_Base_By_iixFi
{
  public class Form1 : Form
  {
    public static PS3API PS3 = new PS3API();
    public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
    private byte[] dump = new byte[0];
    private uint offset = 0x00000000;
    private byte[] buffer = new byte[0];
    private string input = "";
    private Decimal dec;
    private int lenght;
    private string API = "";
    private string ContactID;
    private string WifiSS;
    private string HostName;
    private string username;
    private string usertime;
    private string userdate;
    private string countertime;
    private bool isConnectedOrAttached = false;
    private bool isDisconnected = false;
    private bool isAllowed = false;
    private string On = "[On]";
    private string Off = "[Off]";
    private string Notconnected = "Not Connected";
    private string Connected = "Connected";
    private string subTitle = "RTM Tool Base";
    private string program_developer = "iixFi";
    private string connection_status_success = "Connected";
    private string connection_status_failed = "Error";
    private string connection_status_timeout = "timedout";
    private string attach_status_success = "Attached";
    private string attach_status_failed = "Not Attached";
    private System.Timers.Timer t;
    private int h;
    private int m;
    private int s;
    private IContainer components;
    private CheckBox checkBox1;
    private ComboBox comboBox1;
    private System.Windows.Forms.NotifyIcon RTM_Tool_Base_By_iixFi;
    private NumericUpDown numericUpDown1;
    private TextBox textBox2;
    private GroupBox groupBoxMemory;
    private Label label12;
    private CheckBox checkBox3;
    private TextBox textBox3;
    private Label label11;
    private Button button6;
    private Label label9;
    private NumericUpDown numericUpDown2;
    private Label label10;
    private Button button5;
    private Button button7;
    private CheckBox checkBox6;
    private CheckBox checkBox5;
    private CheckBox checkBox4;
    private CheckBox checkBox2;
    private Label label16;
    private CheckBox checkBox8;
    private TextBox textBox5;
    private Button button9;
    private TextBox textBox4;
    private Label label15;
    private Label label14;
    private NumericUpDown numericUpDown4;
    private CheckBox checkBox7;
    private Label label13;
    private Button button8;
    private NumericUpDown numericUpDown3;
    private Button button12;
    private Button button11;
    private GroupBox groupBoxCredits;
    private Button button10;
    private Label label;
    private Button button1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private GroupBox groupBoxDetails;
    private Label RSX_Temperature;
    private Label CELL_Temperature;
    private Label Console_type;
    private Label Firmware;
    private Label label4;
    private Button Refresh;
    private Label label3;
    private Label label2;
    private Label label1;
    private GroupBox groupBoxConsoleShutdownMode;
    private RadioButton Shutdown;
    private Button Execute;
    private RadioButton HardReboot;
    private RadioButton SoftReboot;
    private TabPage tabPage2;
    private ToolStrip toolStrip1;
    private ToolStripLabel toolStripLabel1;
    private ToolStripLabel ConnectionStatusLable;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripLabel toolStripLabel3;
    private ToolStripLabel AttachStatusLable;
    private GroupBox groupBoxVSH_Notify;
    private GroupBox groupBoxSystem;
    private Button button4;
    private GroupBox groupBoxConnection2;
    private CheckBox ConnectToggle;
    private RadioButton CCAPI;
    private RadioButton TMAPI;
    private RadioButton PSMAPI;
    private GroupBox groupBoxConnection1;
    private Button Attach;
    private RadioButton CEX;
    private RadioButton HEN;
    private Button Connect;
    private TextBox InputIP;
    private RadioButton DEX;
    private GroupBox groupBoxConnection3;
    private Button button13;
    private ComboBox AttachMethod;
    private ComboBox comboBoxVSH;
    private TextBox textBoxVSH;
    private ProgressBar ConnectionStatusBar;
    private RadioButton QuickReboot;
    private GroupBox groupBoxConsoleLeds;
    private Button button14;
    private RadioButton RedOff;
    private RadioButton RedOn;
    private RadioButton RedBlink;
    private RadioButton GreenBlink;
    private RadioButton GreenOn;
    private RadioButton GreenOff;
    private GroupBox groupBoxConsoleBuzzerMode;
    private RadioButton Single;
    private RadioButton Double;
    private RadioButton Continuous;
    private Button button15;
    private GroupBox groupBoxConsole_Info;
    private PictureBox pictureBox1;
    private TextBox CreditstextBox;
    private RadioButton GreenBlink2;
    private GroupBox groupBox7;
    private RadioButton YellowOff;
    private RadioButton YellowOn;
    private RadioButton YellowBlink;
    private GroupBox groupBox13;
    private GroupBox groupBox12;
    private RadioButton YellowBlink2;
    private RadioButton RedBlink2;
    private System.Windows.Forms.Timer StatusBarLoader;
    private RadioButton Triple;
    private CheckBox checker4Btn;
    private Label ConnectionStatusBarValueLable;
    private System.Windows.Forms.Timer timer;
    private Button ReconnectBtn;
    private Label label8;
    private Label label7;
    private Label label6;
    private Button DisconnectBtn;
    private Label consoleName;
    private Label apiLabel;
    private ToolStripLabel toolStripLabel2;
    private ToolStripLabel SSID;
    private ToolStripLabel toolStripLabel5;
    private ToolStripLabel Signal;
    private Label label5;
    private HelpProvider helpProvider1;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem topMostToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem minimizeToolStripMenuItem;
    private ToolStripMenuItem maximizeToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private GroupBox groupBoxNonHost;
    private PictureBox pictureBoxStatusEdit;
    private PictureBox pictureBoxStatusVerified;
    private PictureBox pictureBoxStatusUnverified;
    private PictureBox pictureBoxStatusError;
    private ToolStripMenuItem restartAppToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem defaultPropertiesToolStripMenuItem;
    private ToolStripButton toolStripButton1;

    public Form1()
    {
        this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.showConnectedID();
      this.SetBalloonTip(1000, "Open");
      this.t = new System.Timers.Timer();
      this.t.Interval = 1000.0;
      this.t.Elapsed += new ElapsedEventHandler(this.OnTimeEvent);
      this.t.Start();
      this.FormText(this.countertime);
      this.timer.Start();
    }

    private void UnableGroupBoxes(bool unlock)
    {
        //if(unlock)
        //isAllowed = true;
        //if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
        //{
        //    groupBoxDetails.Enabled = unlock;
        //    groupBoxConsoleShutdownMode.Enabled = unlock;
        //    groupBoxSystem.Enabled = unlock;
        //    groupBoxVSH_Notify.Enabled = unlock;
        //    groupBoxMemory.Enabled = unlock;
        //    groupBoxNonHost.Enabled = unlock;
        //}
        //else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
        //{
        //    groupBoxDetails.Enabled = unlock;
        //    groupBoxConsoleShutdownMode.Enabled = unlock;
        //    groupBoxSystem.Enabled = !unlock;
        //    groupBoxVSH_Notify.Enabled = !unlock;
        //    groupBoxMemory.Enabled = unlock;
        //    groupBoxNonHost.Enabled = unlock;
        //}
        //else if (Form1.PS3.GetCurrentAPI() == SelectAPI.PS3Manager)
        //{
        //    groupBoxDetails.Enabled = unlock;
        //    groupBoxConsoleShutdownMode.Enabled = unlock;
        //    groupBoxSystem.Enabled = unlock;
        //    groupBoxVSH_Notify.Enabled = unlock;
        //    groupBoxMemory.Enabled = unlock;
        //    groupBoxNonHost.Enabled = unlock;
        //}
        //this.SelectedAPI_Properties();
          groupBoxDetails.Enabled = unlock;
          groupBoxCredits.Enabled = unlock;
          groupBoxSystem.Enabled = unlock;
          groupBoxVSH_Notify.Enabled = unlock;
          groupBoxMemory.Enabled = unlock;
          groupBoxNonHost.Enabled = unlock;
    }

    private void OnTimeEvent(object sender, ElapsedEventArgs e)
    {
        base.Invoke(new Action(delegate()
        {
            this.s++;
            if (this.s == 60)
            {
                this.s = 0;
                this.m++;
            }
            if (this.m == 60)
            {
                this.m = 0;
                this.h++;
            }
            this.countertime = string.Format("{0}:{1}:{2}", this.h.ToString().PadLeft(2, '0'), this.m.ToString().PadLeft(2, '0'), this.s.ToString().PadLeft(2, '0'));
        }));
    }

    void FormText(string InputText)
    {
      this.username = SystemInformation.UserName;
      this.usertime = DateTime.Now.ToLongTimeString();
      this.userdate = DateTime.Now.ToLongDateString();
      this.Text = this.subTitle + " |  Welcome: " + this.username + " [ Time: " + this.usertime + "  -  Date: " + this.userdate + " ] - Runtime: " + InputText;
    }

    private void showConnectedID()
    {
      try
      {
        this.HostName = Dns.GetHostName();
        string str1 = Dns.GetHostByName(this.HostName).AddressList[0].ToString();
        Process process = new Process();
        process.StartInfo.FileName = "netsh.exe";
        process.StartInfo.Arguments = "wlan show interfaces";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.Start();
        string end = process.StandardOutput.ReadToEnd();
        string str2 = end.Substring(end.IndexOf("SSID"));
        string str3 = str2.Substring(str2.IndexOf(":"));
        string str4 = str3.Substring(2, str3.IndexOf("\n")).Trim();
        string str5 = end.Substring(end.IndexOf("Signal"));
        string str6 = str5.Substring(str5.IndexOf(":"));
        string str7 = str6.Substring(2, str6.IndexOf("\n")).Trim();
        this.ContactID = str4;
        this.WifiSS = str7;
        this.SSID.Text = this.ContactID + " - " + str1;
        this.Signal.Text = this.WifiSS;
        process.WaitForExit();
      }
      catch
      {
        this.SSID.Text = "NotFound";
        this.Signal.Text = "NotFound";
        this.SSID.ForeColor = Color.Red;
        this.Signal.ForeColor = Color.Red;
      }
    }

    private void ShowPS3Info()
    {
      this.API = Form1.PS3.GetCurrentAPIName();
      this.apiLabel.Text = this.API;
      this.consoleName.Text = "Consloe: " + Form1.PS3.GetConsoleName() + " / " + this.InputIP.Text;
    }

    private void SetBalloonTip(int shown, string status)
    {
      this.RTM_Tool_Base_By_iixFi.BalloonTipIcon = ToolTipIcon.Info;
      this.RTM_Tool_Base_By_iixFi.BalloonTipText = "Application Status: " + status;
      this.RTM_Tool_Base_By_iixFi.BalloonTipTitle = this.RTM_Tool_Base_By_iixFi.BalloonTipTitle;
      this.RTM_Tool_Base_By_iixFi.ShowBalloonTip(shown);
      this.Click += new EventHandler(this.Form1_Load);
    }

    private void SelectedAPI_Properties()
    {
        if (isConnectedOrAttached)
            isAllowed = true;
        if (CEX.Checked || CCAPI.Checked || AttachMethod.SelectedIndex == 0)
        {
            this.SoftReboot.Enabled = true;
            this.HardReboot.Enabled = true;
            this.QuickReboot.Enabled = false;
            this.Shutdown.Enabled = true;
            this.groupBox12.Enabled = true;
            this.groupBox13.Enabled = true;
            this.groupBox7.Enabled = false;
            this.Continuous.Enabled = true;
            this.comboBoxVSH.Enabled = true;
            this.groupBoxSystem.Enabled = true;
            this.groupBoxVSH_Notify.Enabled = true;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.GreenBlink.Text = "Blink";
            this.RedBlink.Text = "Blink";
            this.YellowBlink.Text = "Blink";
            this.GreenBlink2.Visible = false;
            this.RedBlink2.Visible = false;
            this.YellowBlink2.Visible = false;
            groupBoxDetails.Enabled = true;
            Refresh.Enabled = true;
            Execute.Enabled = true;
        }
        else if (DEX.Checked || TMAPI.Checked || AttachMethod.SelectedIndex == 1)
        {
            this.SoftReboot.Enabled = false;
            this.HardReboot.Enabled = false;
            this.QuickReboot.Enabled = false;
            this.Shutdown.Enabled = true;
            this.groupBox12.Enabled = false;
            this.groupBox13.Enabled = false;
            this.groupBox7.Enabled = false;
            this.groupBoxSystem.Enabled = false;
            this.groupBoxVSH_Notify.Enabled = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.GreenBlink.Text = "Blink";
            this.RedBlink.Text = "Blink";
            this.YellowBlink.Text = "Blink";
            this.comboBoxVSH.Text = "";
            this.GreenBlink2.Visible = false;
            this.RedBlink2.Visible = false;
            this.YellowBlink2.Visible = false;
            groupBoxConsole_Info.Enabled = false;
            Refresh.Enabled = false;
            Execute.Enabled = true;
        }
        else if (HEN.Checked || PSMAPI.Checked || AttachMethod.SelectedIndex == 2)
        {
            this.SoftReboot.Enabled = true;
            this.HardReboot.Enabled = true;
            this.QuickReboot.Enabled = true;
            this.Shutdown.Enabled = true;
            this.groupBox12.Enabled = true;
            this.groupBox13.Enabled = true;
            this.groupBox7.Enabled = true;
            this.Continuous.Enabled = false;
            this.comboBoxVSH.Enabled = false;
            this.groupBoxSystem.Enabled = true;
            this.groupBoxVSH_Notify.Enabled = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.GreenBlink.Text = "Slow";
            this.RedBlink.Text = "Slow";
            this.YellowBlink.Text = "Slow";
            this.comboBoxVSH.Text = "";
            this.GreenBlink2.Visible = true;
            this.RedBlink2.Visible = true;
            this.YellowBlink2.Visible = true;
            groupBoxConsole_Info.Enabled = true;
            Refresh.Enabled = true;
            Execute.Enabled = true;
        }
    }
    private void CEX_CheckedChanged(object sender, EventArgs e)
    {
      Form1.PS3.ChangeAPI(SelectAPI.ControlConsole);
      this.SelectedAPI_Properties();
    }

    private void DEX_CheckedChanged(object sender, EventArgs e)
    {
      Form1.PS3.ChangeAPI(SelectAPI.TargetManager);
      this.SelectedAPI_Properties();
    }

    private void HEN_CheckedChanged(object sender, EventArgs e)
    {
      Form1.PS3.ChangeAPI(SelectAPI.PS3Manager);
      this.SelectedAPI_Properties();
    }

    private void ConnectionStatusSuccess()
    {
      this.ConnectionStatusLable.Text = this.connection_status_success;
      this.ConnectionStatusLable.ForeColor = Color.Green;
      int num = (int) MessageBox.Show((IWin32Window) this, "Connected Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void ConnectionStatusFailed()
    {
      this.ConnectionStatusLable.Text = this.connection_status_failed;
      this.ConnectionStatusLable.ForeColor = Color.Red;
      int num = (int)MessageBox.Show((IWin32Window)this, "Make sure you choose your right ip, or check your Internet connection", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void AttachStatusSuccess()
    {
      this.AttachStatusLable.Text = this.attach_status_success;
      this.AttachStatusLable.ForeColor = Color.Green;
      this.StatusIcon(Resources.RTM_Tool_Base_On);
      this.UnableGroupBoxes(true);
      isConnectedOrAttached = true;
    }

    private void AttachStatusFailed()
    {
      this.AttachStatusLable.Text = this.attach_status_failed;
      this.AttachStatusLable.ForeColor = Color.Red;
      this.StatusIcon(Resources.RTM_Tool_Base_Off);
      isConnectedOrAttached = false;
    }

    private void ConnectionAndAttachedStatusSuccess()
    {
      this.ConnectionStatusLable.Text = this.connection_status_success;
      this.ConnectionStatusLable.ForeColor = Color.Green;
      this.AttachStatusLable.Text = this.attach_status_success;
      this.AttachStatusLable.ForeColor = Color.Green;
      this.StatusIcon(Resources.RTM_Tool_Base_On);
      this.UnableGroupBoxes(true);
      isConnectedOrAttached = true;
    }

    private void ConnectionAndAttachedStatusFailed()
    {
      this.ConnectionStatusLable.Text = this.connection_status_failed;
      this.ConnectionStatusLable.ForeColor = Color.Red;
      this.AttachStatusLable.Text = this.attach_status_failed;
      this.AttachStatusLable.ForeColor = Color.Red;
      this.StatusIcon(Resources.RTM_Tool_Base_Off);
      isConnectedOrAttached = false;
    }

    private void StatusDisconnected()
    {
      this.ConnectionStatusLable.Text = "Disconnected";
      this.ConnectionStatusLable.ForeColor = Color.Red;
      this.AttachStatusLable.Text = "Disconnected";
      this.AttachStatusLable.ForeColor = Color.Red;
      this.StatusIcon(Resources.RTM_Tool_Base_Off);
      this.UnableGroupBoxes(false);
      this.groupBoxSystem.Enabled = false;
      this.comboBoxVSH.Enabled = false;
      isDisconnected = true;
      isConnectedOrAttached = false;
    }

    private void StatusIcon(Icon status)
    {
      this.Icon = status;
      this.RTM_Tool_Base_By_iixFi.Icon = status;
    }

    private void Reconnect()
    {
      if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
      {
        if (Form1.PS3.ConnectTarget(this.InputIP.Text))
        {
          Form1.PS3.AttachProcess();
          Form1.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.INFO, "Reconnected Successfully");
          Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Double);
          this.UnableGroupBoxes(true);
          this.StatusIcon(Resources.RTM_Tool_Base_On);
          int num = (int) MessageBox.Show((IWin32Window) this, "Reconnected Successfully", "Reconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          this.StatusIcon(Resources.RTM_Tool_Base_Off);
          int num = (int) MessageBox.Show((IWin32Window) this, "Failed To Reconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
      {
        if (Form1.PS3.ConnectTarget())
        {
          Form1.PS3.AttachProcess();
          this.UnableGroupBoxes(true);
          this.StatusIcon(Properties.Resources.RTM_Tool_Base_On);
          int num = (int) MessageBox.Show((IWin32Window) this, "Reconnected Successfully", "Reconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          this.StatusIcon(Resources.RTM_Tool_Base_Off);
          int num = (int) MessageBox.Show((IWin32Window) this, "Failed To Reconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        if (Form1.PS3.GetCurrentAPI() != SelectAPI.PS3Manager)
          return;
        Form1.PS3M_API.ConnectTarget(this.InputIP.Text, Convert.ToInt32(7887));
        try
        {
          this.AttachMethod.Items.Clear();
          foreach (uint pidProcess in Form1.PS3M_API.Process.GetPidProcesses())
          {
            if (pidProcess != 0U)
            {
              this.AttachMethod.Items.Add((object) Form1.PS3M_API.Process.GetName(pidProcess));
              if (!Form1.PS3M_API.AttachProcess(Form1.PS3M_API.Process.Processes_Pid[this.AttachMethod.SelectedIndex]))
              {
                this.StatusIcon(Resources.RTM_Tool_Base_Off);
                int num = (int) MessageBox.Show((IWin32Window) this, "Failed To Reconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Form1.PS3M_API.DisconnectTarget();
              }
            }
            else
              break;
          }
          this.AttachMethod.SelectedIndex = 0;
          this.StatusIcon(Resources.RTM_Tool_Base_On);
          this.UnableGroupBoxes(true);
          MessageBox.Show((IWin32Window)this, "Reconnected Successfully", "Reconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch
        {
          this.StatusIcon(Resources.RTM_Tool_Base_Off);
          int num = (int) MessageBox.Show((IWin32Window) this, "Failed To Reconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }

    private void Connect_Click(object sender, EventArgs e)
    {
      if (this.CEX.Checked || this.DEX.Checked)
      {
        if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
        {
          try
          {
            Form1.PS3.ConnectTarget();
            this.ConnectionStatusSuccess();
            this.Attach.Enabled = true;
          }
          catch
          {
            this.ConnectionStatusFailed();
          }
        }
        else if (Form1.PS3.ConnectTarget(this.InputIP.Text))
        {
          Form1.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.PROGRESS, "Connected Seccessfully");
          Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Single);
          this.ConnectionStatusSuccess();
          this.API = this.InputIP.Text;
          this.Attach.Enabled = true;
        }
        else
          this.ConnectionStatusFailed();
      }
      else
      {
        Form1.PS3.ChangeAPI(SelectAPI.PS3Manager);
        Form1.PS3M_API.ConnectTarget(this.InputIP.Text, Convert.ToInt32(7887));
        try
        {
          if (!Form1.PS3M_API.IsConnected)
            return;
          this.AttachMethod.Items.Clear();
          foreach (uint pidProcess in Form1.PS3M_API.Process.GetPidProcesses())
          {
            if (pidProcess != 0U)
            {
              this.AttachMethod.Items.Add((object) Form1.PS3M_API.Process.GetName(pidProcess));
              Form1.PS3M_API.PS3.Notify("Connected Seccessfully");
              Form1.PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Single);
              this.Attach.Enabled = true;
              this.ConnectionStatusSuccess();
            }
            else
              break;
          }
          this.AttachMethod.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
          this.ConnectionStatusLable.Text = this.connection_status_failed;
          this.ConnectionStatusLable.ForeColor = Color.Red;
          int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      this.ShowPS3Info();
      this.showConnectedID();
    }

    private void Attach_Click(object sender, EventArgs e)
    {
      if (this.CEX.Checked || this.DEX.Checked)
      {
        if (Form1.PS3.AttachProcess())
        {
          try
          {
            if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
            {
              Form1.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.INFO, "Attached Successfully");
              Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Double);
              this.ConnectionAndAttachedStatusSuccess();
              int num = (int) MessageBox.Show((IWin32Window) this, "Attached Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
            {
              this.ConnectionAndAttachedStatusSuccess();
              int num = (int)MessageBox.Show((IWin32Window)this, "Attached Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.DisconnectBtn.Visible = true;
            this.ReconnectBtn.Visible = true;
          }
          catch (Exception ex)
          {
            this.AttachStatusFailed();
            int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        else
        {
          this.AttachStatusFailed();
          int num = (int)MessageBox.Show((IWin32Window)this, "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else if (Form1.PS3.GetCurrentAPI() == SelectAPI.PS3Manager)
      {
        try
        {
          Form1.PS3M_API.AttachProcess(Form1.PS3M_API.Process.Processes_Pid[this.AttachMethod.SelectedIndex]);
          if (Form1.PS3M_API.IsAttached)
          {
            Form1.PS3M_API.PS3.Notify("Attached Seccessfully");
            Form1.PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Double);
            this.ConnectionAndAttachedStatusSuccess();
            int num = (int)MessageBox.Show((IWin32Window)this, "Attached Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DisconnectBtn.Visible = true;
            this.ReconnectBtn.Visible = true;
          }
          else if (!Form1.PS3M_API.IsAttached)
            this.AttachStatusFailed();
        }
        catch (Exception ex)
        {
          this.AttachStatusLable.Text = this.attach_status_failed;
          this.AttachStatusLable.ForeColor = Color.Red;
          int num = (int)MessageBox.Show((IWin32Window)this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void Refresh_Click(object sender, EventArgs e)
    {
      if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
      {
        Form1.PS3.CCAPI.ClearTargetInfo();
        this.CELL_Temperature.Text = Form1.PS3.CCAPI.GetTemperatureCELL();
        this.RSX_Temperature.Text = Form1.PS3.CCAPI.GetTemperatureRSX();
        this.Firmware.Text = Form1.PS3.CCAPI.GetFirmwareVersion();
        this.Console_type.Text = Form1.PS3.CCAPI.GetFirmwareType();
      }
      else
      {
        if (Form1.PS3.GetCurrentAPI() != SelectAPI.PS3Manager || !Form1.PS3M_API.IsConnected)
          return;
        uint cpu;
        uint rsx;
        Form1.PS3M_API.PS3.GetTemperature(out cpu, out rsx);
        this.CELL_Temperature.Text = Convert.ToString(cpu);
        this.RSX_Temperature.Text = Convert.ToString(rsx);
        this.Firmware.Text = Convert.ToString(Form1.PS3M_API.PS3.GetFirmwareVersion());
        this.Console_type.Text = Form1.PS3M_API.PS3.GetFirmwareType();
      }
    }

    private void Execute_Click(object sender, EventArgs e)
    {
      if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
      {
        if (this.Shutdown.Checked)
          Form1.PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.ShutDown);
        if (this.SoftReboot.Checked)
          Form1.PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.SoftReboot);
        if (!this.HardReboot.Checked)
          return;
        Form1.PS3.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.HardReboot);
      }
      else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
      {
        Form1.PS3.TMAPI.PowerOff(true);
      }
      else
      {
        if (Form1.PS3.GetCurrentAPI() != SelectAPI.PS3Manager)
          return;
        if (this.Shutdown.Checked)
          Form1.PS3.PS3MAPI.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.ShutDown);
        if (this.SoftReboot.Checked)
          Form1.PS3.PS3MAPI.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.SoftReboot);
        if (this.HardReboot.Checked)
          Form1.PS3.PS3MAPI.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.HardReboot);
        if (!this.QuickReboot.Checked)
          return;
        Form1.PS3.PS3MAPI.Power(PS3ManagerAPI.PS3MAPI.PS3_CMD.PowerFlags.QuickReboot);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        // ************* //
        //   Set Memory  //
        // ************* //
      if (this.numericUpDown1.Value == 0M)
      {
        byte[] buffer = new byte[1];
        Form1.PS3.SetMemory(this.offset, buffer);
      }
      else
      {
        byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown1.Value.ToString()));
        Form1.PS3.SetMemory(this.offset, bytes);
      }
    }

   private void button8_Click(object sender, EventArgs e) 
   {
       // ************* //
       //   Get Memory  //
       // ************* //
       byte[] bytes = Form1.PS3.GetBytes(0U, 0);
       this.numericUpDown3.Value = Convert.ToDecimal(BitConverter.ToInt32(bytes, 0));
   }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        // ********************* //
        //   Set Memory(On/Off)  //
        // ********************* //
      NumericUpDown numericUpDown2 = this.numericUpDown2;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      numericUpDown2.Value = num2;
      byte[] bytes = BitConverter.GetBytes((short) (byte) num1);
      if (this.checkBox1.Checked)
          Form1.PS3.SetMemory(this.offset, bytes);
      else
          Form1.PS3.SetMemory(this.offset, new byte[2]);
    }

    private void checkBox7_CheckedChanged(object sender, EventArgs e)
    {
        // ************************ //
        //   Get Memory(Set/Reset)  //
        // ************************ //
      if (this.checkBox7.Checked)
      {
          this.buffer = Form1.PS3.GetBytes(0U, 0);
        byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown4.Value.ToString()));
        Form1.PS3.SetMemory(this.offset, bytes);
      }
      else
      {
        this.numericUpDown4.Value = Convert.ToDecimal(BitConverter.ToInt32(this.buffer, 0).ToString());
        Form1.PS3.SetMemory(this.offset, BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown4.Value.ToString())));
      }
    }

    private void button6_Click(object sender, EventArgs e) 
    {
        // ********************* //
        //   Set Memory(string)  //
        // ********************* //
        Form1.PS3.Extension.WriteString(this.offset, this.textBox2.Text);
    }

    private void button9_Click(object sender, EventArgs e) 
    {
        // ********************* //
        //   Get Memory(string)  //
        // ********************* //
        this.textBox4.Text = Form1.PS3.Extension.ReadString(this.offset);
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
        // ************************* //
        //   Set Memory(string/byte) //
        // ************************* //
      if (this.checkBox3.Checked)
      {
          Form1.PS3.Extension.WriteString(this.offset, this.textBox3.Text);
      }
      else
      {
        this.buffer = Encoding.UTF8.GetBytes(this.textBox3.Text);
        Form1.PS3.SetMemory(this.offset, this.buffer);
      }
    }

    private void checkBox8_CheckedChanged(object sender, EventArgs e)
    {
        // ************************* //
        //   Get Memory(string/byte) //
        // ************************* //
      if (this.checkBox8.Checked)
          this.textBox5.Text = Form1.PS3.Extension.ReadString(this.offset);
      else
          this.textBox5.Text = Convert.ToString(Form1.PS3.Extension.ReadByte(Convert.ToUInt32(this.offset)));
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        // ********************* //
        //   Set Memory(On/Off)  //
        // ********************* //
      if (this.checkBox2.Checked)
      {
        byte[] buffer = new byte[2] { (byte) 1, (byte) 1 };
        Form1.PS3.SetMemory(0U, buffer);
      }
      else
      {
        byte[] buffer = new byte[2];
        Form1.PS3.SetMemory(0U, buffer);
      }
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
        // ********************* //
        //   Set Memory(On/Off)  //
        // ********************* //
      if (this.checkBox4.Checked)
          Form1.PS3.Extension.WriteString(this.offset, "any text here");
      if (this.checkBox4.Checked)
        return;
      Form1.PS3.Extension.WriteString(this.offset, "");
    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {
        // ********************* //
        //   Set Memory(On/Off)  //
        // ********************* //
      if (this.checkBox5.Checked)
          Form1.PS3.Extension.WriteString(this.offset, "any text here");
      else
          Form1.PS3.Extension.WriteString(this.offset, "");
    }

    private void checkBox6_CheckedChanged(object sender, EventArgs e)
    {
        // ********************* //
        //   Set Memory(On/Off)  //
        // ********************* //
      if (!this.checkBox6.Checked || !this.checkBox6.Checked)
        return;
      Form1.PS3.Extension.WriteString(this.offset, "any text here");
    }

    private void button11_Click(object sender, EventArgs e)
    {
        // ***************** //
        //   Set Memory(On)  //
        // ***************** //
        if (MessageBox.Show((IWin32Window)this, "Set To " + this.On + " Successfully", "Enabled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
        {
            Form1.PS3.SetMemory(this.offset, buffer);
        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        // ****************** //
        //   Set Memory(Off)  //
        // ****************** //
        if (MessageBox.Show((IWin32Window)this, "Set To " + this.Off + " Successfully", "Disabled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
        {
            Form1.PS3.SetMemory(this.offset, buffer);
        }
    }

    private void button12_Click(object sender, EventArgs e)
    {
        // ********************* //
        //   Set Memory(On/Off)  //
        // ********************* //
      if (!this.checker4Btn.Checked)
      {
        this.checker4Btn.Checked = true;
        this.button12.Text = "Set Changes " + this.On;
        Form1.PS3.SetMemory(this.offset, buffer);
      }
      else
      {
        this.checker4Btn.Checked = false;
        this.button12.Text = "Set Changes " + this.Off;
        Form1.PS3.SetMemory(this.offset, buffer);
      }
    }

    private void button10_Click(object sender, EventArgs e) 
    {
        // ********** //
        //   Example  //
        // ********** //
        Control control = this.label;
        string[] array = new string[6];
        array[0] = "Index: ";
        array[1] = this.comboBox1.SelectedIndex.ToString();
        array[2] = ", Item: ";
        int num = 3;
        object selectedItem = this.comboBox1.SelectedItem;
        array[num] = ((selectedItem != null) ? selectedItem.ToString() : null);
        array[4] = " ";
        array[5] = this.comboBox1.SelectedIndex.ToString();
        control.Text = string.Concat(array);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Disconnect();
      if (!isConnectedOrAttached)
      if (!isDisconnected)
          return;
      {
          this.button13.Text = "Reconnect";
          this.button1.ForeColor = Color.Red;
          this.SetBalloonTip(1000, "Disonnected");
          this.ConnectionStatusBar.SetState(ModifyProgressBarColor.ProgressBarStateEnum.Error);
          this.ConnectionStatusBar.Value = this.ConnectionStatusBar.Minimum;
          this.ConnectionStatusBarValueLable.Text = this.ConnectionStatusBar.Value.ToString() + "%";
          //MessageBox.Show("Disconnected Successfully", "Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void button13_Click(object sender, EventArgs e)
    {
        int selectedIndex = this.AttachMethod.SelectedIndex;
        if (selectedIndex == 0 | selectedIndex == 1 | selectedIndex == 2)
        {
            try
            {
                if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
                {
                    if (Form1.PS3.ConnectTarget() && Form1.PS3.AttachProcess())
                    {
                        this.ConnectionStatusBar.SetState(ModifyProgressBarColor.ProgressBarStateEnum.Normal);
                        this.StatusBarLoader.Start();
                    }
                    else
                    {
                        this.SetBalloonTip(1000, "Failed To Connect");
                        this.ConnectionAndAttachedStatusFailed();
                        this.button13.ForeColor = Color.Red;
                        //int num = (int) MessageBox.Show((IWin32Window) this, "Make sure you choose your right ip, or check your Internet connection", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
                {
                    if (Form1.PS3.ConnectTarget() && Form1.PS3.AttachProcess())
                    {
                        this.StatusBarLoader.Start();
                    }
                    else
                    {
                        this.SetBalloonTip(1000, "Failed To Connect");
                        this.button13.ForeColor = Color.Red;
                        this.ConnectionAndAttachedStatusFailed();
                        //int num = (int) MessageBox.Show((IWin32Window) this, "Make sure you choose your right ip, or check your internet connection", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else if (Form1.PS3.GetCurrentAPI() == SelectAPI.PS3Manager)
                {
                    Form1.PS3M_API.ConnectTarget();
                    {
                        if (Form1.PS3M_API.IsConnected)
                        {
                            try
                            {
                                Form1.PS3M_API.AttachProcess();
                                if (Form1.PS3M_API.IsAttached)
                                {
                                    this.StatusBarLoader.Start();
                                }
                                if (!Form1.PS3M_API.IsAttached)
                                {
                                    this.SetBalloonTip(1000, "Failed To Attach");
                                    this.ConnectionStatusFailed();
                                    this.button13.ForeColor = Color.Red;
                                    //MessageBox.Show(this, "Cannot Attach", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (!Form1.PS3M_API.IsConnected)
                        {
                            this.SetBalloonTip(1000, "Failed To Connect");
                            this.ConnectionStatusFailed();
                            this.button13.ForeColor = Color.Red;
                            //MessageBox.Show(this, "Cannot Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.button13.ForeColor = Color.Red;
                this.ConnectionAndAttachedStatusFailed();
                //int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        else
        {
            int num2 = (int)MessageBox.Show((IWin32Window)this, "Cannot Connected Without Selecting Your Api", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }

    private void button15_Click(object sender, EventArgs e)
    {
      if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
      {
        if (this.Single.Checked)
          Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Single);
        if (this.Double.Checked)
          Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Double);
        if (this.Triple.Checked)
          Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Triple);
        if (!this.Continuous.Checked)
          return;
        Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Continuous);
      }
      else
      {
        if (Form1.PS3.GetCurrentAPI() != SelectAPI.PS3Manager)
          return;
        if (this.Single.Checked)
          Form1.PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Single);
        if (this.Double.Checked)
          Form1.PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Double);
        if (!this.Continuous.Checked)
          return;
        Form1.PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Triple);
      }
    }

    private void button14_Click(object sender, EventArgs e)
    {
      if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
      {
        if (this.GreenOff.Checked)
          Form1.PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Green, PS3Lib.CCAPI.LedMode.Off);
        if (this.GreenOn.Checked)
          Form1.PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Green, PS3Lib.CCAPI.LedMode.On);
        if (this.GreenBlink.Checked)
          Form1.PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Green, PS3Lib.CCAPI.LedMode.Blink);
        if (this.RedOff.Checked)
          Form1.PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Red, PS3Lib.CCAPI.LedMode.Off);
        if (this.RedOn.Checked)
          Form1.PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Red, PS3Lib.CCAPI.LedMode.On);
        if (!this.RedBlink.Checked)
          return;
        Form1.PS3.CCAPI.SetConsoleLed(PS3Lib.CCAPI.LedColor.Red, PS3Lib.CCAPI.LedMode.Blink);
      }
      else
      {
        if (Form1.PS3.GetCurrentAPI() != SelectAPI.PS3Manager)
          return;
        if (this.GreenOff.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
        if (this.GreenOn.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
        if (this.GreenBlink.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
        if (this.GreenBlink2.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Green, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
        if (this.RedOff.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
        if (this.RedOn.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
        if (this.RedBlink.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
        if (this.RedBlink2.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Red, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
        if (this.YellowOff.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.Off);
        if (this.YellowOn.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.On);
        if (this.YellowBlink.Checked)
          Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkSlow);
        if (!this.YellowBlink2.Checked)
          return;
        Form1.PS3M_API.PS3.Led(PS3ManagerAPI.PS3MAPI.PS3_CMD.LedColor.Yellow, PS3ManagerAPI.PS3MAPI.PS3_CMD.LedMode.BlinkFast);
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      int selectedIndex = this.comboBoxVSH.SelectedIndex;
      string text = this.textBoxVSH.Text;
      if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
      {
        Form1.PS3.CCAPI.Notify(selectedIndex, text);
      }
      else
      {
        if (Form1.PS3.GetCurrentAPI() != SelectAPI.PS3Manager)
          return;
        Form1.PS3M_API.PS3.Notify(text);
      }
    }

    private void ConnectToggle_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ConnectToggle.Checked)
      {
        if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole || Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
        {
          try
          {
            if (Form1.PS3.ConnectTarget() && Form1.PS3.AttachProcess())
            {
              this.ConnectionAndAttachedStatusSuccess();
              this.ConnectToggle.ForeColor = Color.Green;
            }
            else
              this.ConnectionAndAttachedStatusFailed();
          }
          catch (Exception ex)
          {
            this.ConnectionAndAttachedStatusFailed();
            this.ConnectToggle.ForeColor = Color.Red;
            int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          Form1.PS3M_API.ConnectTarget();
          try
          {
            if (Form1.PS3M_API.IsConnected)
            {
              try
              {
                Form1.PS3M_API.AttachProcess();
                if (Form1.PS3M_API.IsAttached)
                  this.ConnectionAndAttachedStatusSuccess();
                this.ConnectToggle.ForeColor = Color.Green;
                if (!Form1.PS3M_API.IsAttached)
                  this.ConnectionAndAttachedStatusFailed();
              }
              catch (Exception ex)
              {
                this.AttachStatusFailed();
                this.ConnectToggle.ForeColor = Color.Red;
                int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
            }
            if (Form1.PS3M_API.IsConnected)
              return;
            this.ConnectionStatusFailed();
            this.ConnectToggle.ForeColor = Color.Red;
            int num1 = (int) MessageBox.Show((IWin32Window) this, "Cannot Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          catch (Exception ex)
          {
            this.ConnectionAndAttachedStatusFailed();
            this.ConnectToggle.ForeColor = Color.Red;
            int num = (int) MessageBox.Show((IWin32Window) this, ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
      }
      else
      {
        if (this.ConnectToggle.Checked)
          return;
        this.ConnectToggle.ForeColor = Color.Red;
        this.Disconnect();
      }
    }

    private void AttachMethod_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.AttachMethod.SelectedIndex == 0) {
          Form1.PS3.ChangeAPI(SelectAPI.ControlConsole); 
          this.SelectedAPI_Properties(); }
      else if (this.AttachMethod.SelectedIndex == 1)
      {
        Form1.PS3.ChangeAPI(SelectAPI.TargetManager);
        this.SelectedAPI_Properties();
      }
      else
      {
        if (this.AttachMethod.SelectedIndex != 2)
          return;
        Form1.PS3.ChangeAPI(SelectAPI.PS3Manager);
        this.SelectedAPI_Properties();
      }
    }

    private void CCAPI_CheckedChanged(object sender, EventArgs e) { Form1.PS3.ChangeAPI(SelectAPI.ControlConsole); ConnectToggle.Enabled = true; this.SelectedAPI_Properties(); }

    private void TMAPI_CheckedChanged(object sender, EventArgs e) { Form1.PS3.ChangeAPI(SelectAPI.TargetManager); ConnectToggle.Enabled = true; this.SelectedAPI_Properties(); }

    private void PSMAPI_CheckedChanged(object sender, EventArgs e) { Form1.PS3.ChangeAPI(SelectAPI.PS3Manager); ConnectToggle.Enabled = true; this.SelectedAPI_Properties(); }

    private void StatusBarLoader_Tick(object sender, EventArgs e)
    {
      try
      {
        this.ConnectionStatusBar.Value += 10;
        this.ConnectionStatusBarValueLable.Text = this.ConnectionStatusBar.Value.ToString() + "%";
      }
      catch
      {
        if (this.ConnectionStatusBar.Value != this.ConnectionStatusBar.Maximum)
          return;
        this.StatusBarLoader.Stop();
        this.ConnectionStatusBar.Value = 100;
        if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
        {
          Form1.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.INFO, "Connected And Attached Successfully");
          Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Double);
          this.ConnectionAndAttachedStatusSuccess();
          this.button1.Enabled = true;
          this.button13.ForeColor = Color.Green;
          this.SetBalloonTip(1000, "Connected");
          //int num = (int) MessageBox.Show((IWin32Window) this, "Connected And Attached Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
        {
          this.ConnectionAndAttachedStatusSuccess();
          this.button1.Enabled = true;
          this.button13.ForeColor = Color.Green;
          this.SetBalloonTip(1000, "Connected");
          //int num = (int) MessageBox.Show((IWin32Window) this, "Connected And Attached Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (Form1.PS3.GetCurrentAPI() == SelectAPI.PS3Manager && Form1.PS3M_API.IsConnected && Form1.PS3M_API.IsAttached)
        {
          Form1.PS3M_API.PS3.Notify("Connected And Attached Seccessfully");
          Form1.PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Double);
          this.ConnectionAndAttachedStatusSuccess();
          this.button1.Enabled = true;
          this.button13.ForeColor = Color.Green;
          this.SetBalloonTip(1000, "Connected");
          //int num = (int) MessageBox.Show((IWin32Window) this, "Connected And Attached Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }

    private void toolStripButton1_Click_1(object sender, EventArgs e)
    {
      if (isConnectedOrAttached)
      {
        try
        {
          if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
          {
            string str = Convert.ToString(Form1.PS3.CCAPI.GetConnectionStatus());
            if (str == "0")
            {
              this.ConnectionAndAttachedStatusFailed();
              int num = (int) MessageBox.Show((IWin32Window) this, "Connection Status: " + this.Notconnected, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              Form1.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.INFO, "Connection Status: " + this.Notconnected);
              Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Single);
            }
            else if (str == "1")
            {
              this.ConnectionAndAttachedStatusSuccess();
              int num = (int) MessageBox.Show((IWin32Window) this, "Connection Status: " + this.Connected, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              Form1.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.INFO, "Connection Status: " + this.Connected);
              Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Single);
            }
          }
          else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
          {
            string status = Form1.PS3.TMAPI.SCE.GetStatus();
            if (status == "NotConnected")
            {
              this.ConnectionStatusLable.Text = status;
              this.ConnectionAndAttachedStatusFailed();
              int num = (int) MessageBox.Show((IWin32Window) this, "Connection Status: " + this.Notconnected, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (status == "Connected")
            {
              this.ConnectionStatusLable.Text = status;
              this.ConnectionAndAttachedStatusSuccess();
              int num = (int) MessageBox.Show((IWin32Window) this, "Connection Status: " + this.Connected, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
          }
          else if (Form1.PS3.GetCurrentAPI() == SelectAPI.PS3Manager)
          {
            if (Form1.PS3M_API.IsConnected)
            {
              string str = string.Format("{0}", (object) Form1.PS3M_API.IsConnected);
              if (str == "True")
              {
                this.Connected = str;
                this.ConnectionAndAttachedStatusSuccess();
                int num = (int) MessageBox.Show((IWin32Window) this, "Connection Status: ", "Check Connection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              }
              else if (str == "False")
              {
                this.Notconnected = str;
                this.ConnectionAndAttachedStatusFailed();
                int num = (int) MessageBox.Show((IWin32Window) this, "Connection Status: " + this.Notconnected, "Check Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
            }
            else
            {
              int num1 = (int) MessageBox.Show((IWin32Window) this, "Connection Status: timedout!", "Check Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          }
        }
        catch
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Connection Status: timedout!", "Check Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
          if (isDisconnected)
          {
              int num = (int)MessageBox.Show((IWin32Window)this, "Connection Status: Disconnected!", "Check Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
          {
              int num = (int)MessageBox.Show((IWin32Window)this, "Connection Status: Not Connected!", "Check Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
      }
      this.showConnectedID();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        this.FormText(this.countertime);
    }

    private void button2_Click(object sender, EventArgs e) 
    {
        this.Reconnect();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.DoEvents();
      if (e.CloseReason != CloseReason.UserClosing)
        return;
      e.Cancel = true;
      this.Hide();
    }

    private void Form1_HelpButtonClicked(object sender, CancelEventArgs e) 
    {
        Process.Start("https://discord.com/users/980773708165701642");
    }

    private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
    {
    }

    private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.topMostToolStripMenuItem.Checked) {
          this.TopMost = true;
      }
      else
        this.TopMost = false;
    }

    private void minimizeToolStripMenuItem_Click(object sender, EventArgs e) 
    {
        this.SetBalloonTip(1000, "Minimized");
        base.WindowState = FormWindowState.Minimized;
    }

    private void maximizeToolStripMenuItem_Click(object sender, EventArgs e) 
    {
        this.SetBalloonTip(1000, "Maximized");
        base.WindowState = FormWindowState.Maximized;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.t.Stop();
      Application.DoEvents();
      Application.Exit();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Show();
      //this.FormText(this.countertime);
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {}

    private void RTM_Tool_Base_By_iixFi_DoubleClick(object sender, EventArgs e) 
    {
    
    }

    private void RTM_Tool_Base_By_iixFi_Click(object sender, EventArgs e)
    {

    }

    private void Disconnect()
    {
        if (Form1.PS3.GetCurrentAPI() == SelectAPI.ControlConsole)
      {
          Form1.PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.INFO, "Target Disconnected Successfully");
          Form1.PS3.CCAPI.RingBuzzer(PS3Lib.CCAPI.BuzzerMode.Single);
          Form1.PS3.CCAPI.DisconnectTarget();
        this.StatusDisconnected();
      }
        else if (Form1.PS3.GetCurrentAPI() == SelectAPI.TargetManager)
      {
          Form1.PS3.TMAPI.DisconnectTarget();
        this.StatusDisconnected();
      }
      else
      {
          if (Form1.PS3.GetCurrentAPI() == SelectAPI.PS3Manager)
          return;
          if (!Form1.PS3M_API.IsConnected)
        {
          int num = (int) MessageBox.Show((IWin32Window) this, "Connect first!");
        }
        else
        {
            Form1.PS3M_API.PS3.Notify("Target Disconnected Successfully");
            Form1.PS3M_API.PS3.RingBuzzer(PS3ManagerAPI.PS3MAPI.PS3_CMD.BuzzerMode.Single);
            Form1.PS3M_API.DisconnectTarget();
          this.StatusDisconnected();
        }
      }
    }

    private void DisconnectBtn_Click(object sender, EventArgs e) 
    {
        this.Disconnect();
        if (isDisconnected)
            MessageBox.Show("Disconnect Successfully", "Disconnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RTM_Tool_Base_By_iixFi = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxMemory = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBoxCredits = new System.Windows.Forms.GroupBox();
            this.CreditstextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.checker4Btn = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxSystem = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBoxConsoleLeds = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.YellowBlink2 = new System.Windows.Forms.RadioButton();
            this.YellowOff = new System.Windows.Forms.RadioButton();
            this.YellowOn = new System.Windows.Forms.RadioButton();
            this.YellowBlink = new System.Windows.Forms.RadioButton();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RedOff = new System.Windows.Forms.RadioButton();
            this.RedBlink2 = new System.Windows.Forms.RadioButton();
            this.RedOn = new System.Windows.Forms.RadioButton();
            this.RedBlink = new System.Windows.Forms.RadioButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GreenBlink = new System.Windows.Forms.RadioButton();
            this.GreenOn = new System.Windows.Forms.RadioButton();
            this.GreenBlink2 = new System.Windows.Forms.RadioButton();
            this.GreenOff = new System.Windows.Forms.RadioButton();
            this.groupBoxConsoleBuzzerMode = new System.Windows.Forms.GroupBox();
            this.Triple = new System.Windows.Forms.RadioButton();
            this.Single = new System.Windows.Forms.RadioButton();
            this.Double = new System.Windows.Forms.RadioButton();
            this.Continuous = new System.Windows.Forms.RadioButton();
            this.groupBoxVSH_Notify = new System.Windows.Forms.GroupBox();
            this.comboBoxVSH = new System.Windows.Forms.ComboBox();
            this.textBoxVSH = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxConnection2 = new System.Windows.Forms.GroupBox();
            this.ConnectToggle = new System.Windows.Forms.CheckBox();
            this.CCAPI = new System.Windows.Forms.RadioButton();
            this.TMAPI = new System.Windows.Forms.RadioButton();
            this.PSMAPI = new System.Windows.Forms.RadioButton();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.groupBoxConsole_Info = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RSX_Temperature = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Firmware = new System.Windows.Forms.Label();
            this.CELL_Temperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Console_type = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.groupBoxConsoleShutdownMode = new System.Windows.Forms.GroupBox();
            this.QuickReboot = new System.Windows.Forms.RadioButton();
            this.Shutdown = new System.Windows.Forms.RadioButton();
            this.HardReboot = new System.Windows.Forms.RadioButton();
            this.SoftReboot = new System.Windows.Forms.RadioButton();
            this.groupBoxConnection1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStatusError = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatusVerified = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatusUnverified = new System.Windows.Forms.PictureBox();
            this.pictureBoxStatusEdit = new System.Windows.Forms.PictureBox();
            this.ReconnectBtn = new System.Windows.Forms.Button();
            this.apiLabel = new System.Windows.Forms.Label();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.consoleName = new System.Windows.Forms.Label();
            this.Attach = new System.Windows.Forms.Button();
            this.CEX = new System.Windows.Forms.RadioButton();
            this.HEN = new System.Windows.Forms.RadioButton();
            this.Connect = new System.Windows.Forms.Button();
            this.InputIP = new System.Windows.Forms.TextBox();
            this.DEX = new System.Windows.Forms.RadioButton();
            this.groupBoxConnection3 = new System.Windows.Forms.GroupBox();
            this.ConnectionStatusBarValueLable = new System.Windows.Forms.Label();
            this.ConnectionStatusBar = new System.Windows.Forms.ProgressBar();
            this.button13 = new System.Windows.Forms.Button();
            this.AttachMethod = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxNonHost = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ConnectionStatusLable = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.AttachStatusLable = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.SSID = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Signal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.StatusBarLoader = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBoxCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSystem.SuspendLayout();
            this.groupBoxConsoleLeds.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBoxConsoleBuzzerMode.SuspendLayout();
            this.groupBoxVSH_Notify.SuspendLayout();
            this.groupBoxConnection2.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxConsole_Info.SuspendLayout();
            this.groupBoxConsoleShutdownMode.SuspendLayout();
            this.groupBoxConnection1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusVerified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusUnverified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusEdit)).BeginInit();
            this.groupBoxConnection3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxNonHost.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(140, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Set";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Option",
            "Option",
            "Option",
            "Option"});
            this.comboBox1.Location = new System.Drawing.Point(141, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // RTM_Tool_Base_By_iixFi
            // 
            this.RTM_Tool_Base_By_iixFi.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.RTM_Tool_Base_By_iixFi.BalloonTipText = "Application Status: Open";
            this.RTM_Tool_Base_By_iixFi.BalloonTipTitle = "RTM Tool Base By iixFi";
            this.RTM_Tool_Base_By_iixFi.ContextMenuStrip = this.contextMenuStrip1;
            this.RTM_Tool_Base_By_iixFi.Icon = ((System.Drawing.Icon)(resources.GetObject("RTM_Tool_Base_By_iixFi.Icon")));
            this.RTM_Tool_Base_By_iixFi.Text = "RTM Tool Base By iixFi";
            this.RTM_Tool_Base_By_iixFi.Visible = true;
            this.RTM_Tool_Base_By_iixFi.Click += new System.EventHandler(this.RTM_Tool_Base_By_iixFi_Click);
            this.RTM_Tool_Base_By_iixFi.DoubleClick += new System.EventHandler(this.RTM_Tool_Base_By_iixFi_DoubleClick);
            this.RTM_Tool_Base_By_iixFi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RTM_Tool_Base_By_iixFi_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostToolStripMenuItem,
            this.toolStripSeparator4,
            this.openToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.defaultPropertiesToolStripMenuItem,
            this.restartAppToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 170);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.topMostToolStripMenuItem.Text = "TopMost";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // defaultPropertiesToolStripMenuItem
            // 
            this.defaultPropertiesToolStripMenuItem.Name = "defaultPropertiesToolStripMenuItem";
            this.defaultPropertiesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.defaultPropertiesToolStripMenuItem.Text = "Default Properties";
            this.defaultPropertiesToolStripMenuItem.Click += new System.EventHandler(this.defaultPropertiesToolStripMenuItem_Click);
            // 
            // restartAppToolStripMenuItem
            // 
            this.restartAppToolStripMenuItem.Name = "restartAppToolStripMenuItem";
            this.restartAppToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.restartAppToolStripMenuItem.Text = "Restart App";
            this.restartAppToolStripMenuItem.Click += new System.EventHandler(this.restartAppToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 66);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 12;
            // 
            // groupBoxMemory
            // 
            this.groupBoxMemory.Controls.Add(this.label5);
            this.groupBoxMemory.Controls.Add(this.label16);
            this.groupBoxMemory.Controls.Add(this.checkBox8);
            this.groupBoxMemory.Controls.Add(this.textBox5);
            this.groupBoxMemory.Controls.Add(this.button9);
            this.groupBoxMemory.Controls.Add(this.textBox4);
            this.groupBoxMemory.Controls.Add(this.label15);
            this.groupBoxMemory.Controls.Add(this.label14);
            this.groupBoxMemory.Controls.Add(this.button6);
            this.groupBoxMemory.Controls.Add(this.numericUpDown4);
            this.groupBoxMemory.Controls.Add(this.textBox2);
            this.groupBoxMemory.Controls.Add(this.checkBox7);
            this.groupBoxMemory.Controls.Add(this.label11);
            this.groupBoxMemory.Controls.Add(this.label13);
            this.groupBoxMemory.Controls.Add(this.button8);
            this.groupBoxMemory.Controls.Add(this.numericUpDown3);
            this.groupBoxMemory.Controls.Add(this.label12);
            this.groupBoxMemory.Controls.Add(this.checkBox3);
            this.groupBoxMemory.Controls.Add(this.textBox3);
            this.groupBoxMemory.Controls.Add(this.label9);
            this.groupBoxMemory.Controls.Add(this.numericUpDown2);
            this.groupBoxMemory.Controls.Add(this.label10);
            this.groupBoxMemory.Controls.Add(this.button5);
            this.groupBoxMemory.Controls.Add(this.numericUpDown1);
            this.groupBoxMemory.Controls.Add(this.checkBox1);
            this.groupBoxMemory.Enabled = false;
            this.groupBoxMemory.Location = new System.Drawing.Point(8, 6);
            this.groupBoxMemory.Name = "groupBoxMemory";
            this.groupBoxMemory.Size = new System.Drawing.Size(382, 384);
            this.groupBoxMemory.TabIndex = 5;
            this.groupBoxMemory.TabStop = false;
            this.groupBoxMemory.Text = "Strings/Values Editor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Set/Get Memory";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "String Editor 2";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(201, 345);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(100, 17);
            this.checkBox8.TabIndex = 38;
            this.checkBox8.Text = "Get String/Byte";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(201, 319);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(160, 20);
            this.textBox5.TabIndex = 37;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(200, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 23);
            this.button9.TabIndex = 35;
            this.button9.Text = "Get String";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 20);
            this.textBox4.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(197, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "String Editor 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Values Editor 2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Set String";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(200, 160);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown4.TabIndex = 32;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(317, 162);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(43, 17);
            this.checkBox7.TabIndex = 31;
            this.checkBox7.Text = "Get";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "String Editor 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Values Editor 1";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(200, 92);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Get Value";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(200, 66);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown3.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "String Editor 2";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(24, 345);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(99, 17);
            this.checkBox3.TabIndex = 26;
            this.checkBox3.Text = "Set String/Byte";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 319);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Values Editor 2";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(22, 160);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Values Editor 1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Set Value";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(22, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(178, 143);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(188, 52);
            this.button12.TabIndex = 26;
            this.button12.Text = "Set Change [???]";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(22, 143);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 23);
            this.button11.TabIndex = 25;
            this.button11.Text = "On";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(22, 172);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "Off";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBoxCredits
            // 
            this.groupBoxCredits.Controls.Add(this.CreditstextBox);
            this.groupBoxCredits.Controls.Add(this.pictureBox1);
            this.groupBoxCredits.Enabled = false;
            this.groupBoxCredits.Location = new System.Drawing.Point(396, 229);
            this.groupBoxCredits.Name = "groupBoxCredits";
            this.groupBoxCredits.Size = new System.Drawing.Size(390, 161);
            this.groupBoxCredits.TabIndex = 21;
            this.groupBoxCredits.TabStop = false;
            this.groupBoxCredits.Text = "Credit";
            // 
            // CreditstextBox
            // 
            this.CreditstextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreditstextBox.Location = new System.Drawing.Point(171, 35);
            this.CreditstextBox.Multiline = true;
            this.CreditstextBox.Name = "CreditstextBox";
            this.CreditstextBox.ReadOnly = true;
            this.CreditstextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CreditstextBox.Size = new System.Drawing.Size(200, 100);
            this.CreditstextBox.TabIndex = 42;
            this.CreditstextBox.Text = resources.GetString("CreditstextBox.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(138, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 13);
            this.label.TabIndex = 42;
            this.label.Text = "Index: ??, Item: ??";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(141, 75);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(225, 23);
            this.button10.TabIndex = 42;
            this.button10.Text = "Set Change";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // checker4Btn
            // 
            this.checker4Btn.AutoSize = true;
            this.checker4Btn.Location = new System.Drawing.Point(347, 152);
            this.checker4Btn.Name = "checker4Btn";
            this.checker4Btn.Size = new System.Drawing.Size(15, 14);
            this.checker4Btn.TabIndex = 43;
            this.checker4Btn.UseVisualStyleBackColor = true;
            this.checker4Btn.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(22, 104);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(55, 17);
            this.checkBox6.TabIndex = 20;
            this.checkBox6.Text = "Mod 4";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(22, 81);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(55, 17);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "Mod 3";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(22, 58);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(55, 17);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Mod 2";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Mod 1";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 422);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxSystem);
            this.tabPage1.Controls.Add(this.groupBoxVSH_Notify);
            this.tabPage1.Controls.Add(this.groupBoxConnection2);
            this.tabPage1.Controls.Add(this.groupBoxDetails);
            this.tabPage1.Controls.Add(this.groupBoxConnection1);
            this.tabPage1.Controls.Add(this.groupBoxConnection3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSystem
            // 
            this.groupBoxSystem.Controls.Add(this.button15);
            this.groupBoxSystem.Controls.Add(this.groupBoxConsoleLeds);
            this.groupBoxSystem.Controls.Add(this.groupBoxConsoleBuzzerMode);
            this.groupBoxSystem.Enabled = false;
            this.groupBoxSystem.Location = new System.Drawing.Point(283, 167);
            this.groupBoxSystem.Name = "groupBoxSystem";
            this.groupBoxSystem.Size = new System.Drawing.Size(501, 171);
            this.groupBoxSystem.TabIndex = 18;
            this.groupBoxSystem.TabStop = false;
            this.groupBoxSystem.Text = "System";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(372, 136);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(123, 23);
            this.button15.TabIndex = 23;
            this.button15.Text = "Set Ring Buzzer";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // groupBoxConsoleLeds
            // 
            this.groupBoxConsoleLeds.Controls.Add(this.groupBox7);
            this.groupBoxConsoleLeds.Controls.Add(this.button14);
            this.groupBoxConsoleLeds.Controls.Add(this.groupBox13);
            this.groupBoxConsoleLeds.Controls.Add(this.groupBox12);
            this.groupBoxConsoleLeds.Location = new System.Drawing.Point(6, 19);
            this.groupBoxConsoleLeds.Name = "groupBoxConsoleLeds";
            this.groupBoxConsoleLeds.Size = new System.Drawing.Size(360, 146);
            this.groupBoxConsoleLeds.TabIndex = 24;
            this.groupBoxConsoleLeds.TabStop = false;
            this.groupBoxConsoleLeds.Text = "Console Leds";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.YellowBlink2);
            this.groupBox7.Controls.Add(this.YellowOff);
            this.groupBox7.Controls.Add(this.YellowOn);
            this.groupBox7.Controls.Add(this.YellowBlink);
            this.groupBox7.Location = new System.Drawing.Point(242, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(112, 92);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Yellow";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Blink";
            this.label8.Visible = false;
            // 
            // YellowBlink2
            // 
            this.YellowBlink2.AutoSize = true;
            this.YellowBlink2.Location = new System.Drawing.Point(59, 69);
            this.YellowBlink2.Name = "YellowBlink2";
            this.YellowBlink2.Size = new System.Drawing.Size(46, 17);
            this.YellowBlink2.TabIndex = 24;
            this.YellowBlink2.Text = "Fast";
            this.YellowBlink2.UseVisualStyleBackColor = true;
            this.YellowBlink2.Visible = false;
            // 
            // YellowOff
            // 
            this.YellowOff.AutoSize = true;
            this.YellowOff.Checked = true;
            this.YellowOff.Location = new System.Drawing.Point(6, 23);
            this.YellowOff.Name = "YellowOff";
            this.YellowOff.Size = new System.Drawing.Size(41, 17);
            this.YellowOff.TabIndex = 20;
            this.YellowOff.TabStop = true;
            this.YellowOff.Text = "Off";
            this.YellowOff.UseVisualStyleBackColor = true;
            // 
            // YellowOn
            // 
            this.YellowOn.AutoSize = true;
            this.YellowOn.Location = new System.Drawing.Point(6, 46);
            this.YellowOn.Name = "YellowOn";
            this.YellowOn.Size = new System.Drawing.Size(39, 17);
            this.YellowOn.TabIndex = 21;
            this.YellowOn.Text = "On";
            this.YellowOn.UseVisualStyleBackColor = true;
            // 
            // YellowBlink
            // 
            this.YellowBlink.AutoSize = true;
            this.YellowBlink.Location = new System.Drawing.Point(6, 69);
            this.YellowBlink.Name = "YellowBlink";
            this.YellowBlink.Size = new System.Drawing.Size(46, 17);
            this.YellowBlink.TabIndex = 20;
            this.YellowBlink.Text = "Blink";
            this.YellowBlink.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 117);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(348, 23);
            this.button14.TabIndex = 20;
            this.button14.Text = "Set Leds";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label7);
            this.groupBox13.Controls.Add(this.RedOff);
            this.groupBox13.Controls.Add(this.RedBlink2);
            this.groupBox13.Controls.Add(this.RedOn);
            this.groupBox13.Controls.Add(this.RedBlink);
            this.groupBox13.Location = new System.Drawing.Point(124, 19);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(112, 92);
            this.groupBox13.TabIndex = 22;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Red";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Blink";
            this.label7.Visible = false;
            // 
            // RedOff
            // 
            this.RedOff.AutoSize = true;
            this.RedOff.Checked = true;
            this.RedOff.Location = new System.Drawing.Point(6, 23);
            this.RedOff.Name = "RedOff";
            this.RedOff.Size = new System.Drawing.Size(41, 17);
            this.RedOff.TabIndex = 20;
            this.RedOff.TabStop = true;
            this.RedOff.Text = "Off";
            this.RedOff.UseVisualStyleBackColor = true;
            // 
            // RedBlink2
            // 
            this.RedBlink2.AutoSize = true;
            this.RedBlink2.Location = new System.Drawing.Point(59, 69);
            this.RedBlink2.Name = "RedBlink2";
            this.RedBlink2.Size = new System.Drawing.Size(46, 17);
            this.RedBlink2.TabIndex = 23;
            this.RedBlink2.Text = "Fast";
            this.RedBlink2.UseVisualStyleBackColor = true;
            this.RedBlink2.Visible = false;
            // 
            // RedOn
            // 
            this.RedOn.AutoSize = true;
            this.RedOn.Location = new System.Drawing.Point(6, 46);
            this.RedOn.Name = "RedOn";
            this.RedOn.Size = new System.Drawing.Size(39, 17);
            this.RedOn.TabIndex = 21;
            this.RedOn.Text = "On";
            this.RedOn.UseVisualStyleBackColor = true;
            // 
            // RedBlink
            // 
            this.RedBlink.AutoSize = true;
            this.RedBlink.Location = new System.Drawing.Point(6, 69);
            this.RedBlink.Name = "RedBlink";
            this.RedBlink.Size = new System.Drawing.Size(46, 17);
            this.RedBlink.TabIndex = 20;
            this.RedBlink.Text = "Blink";
            this.RedBlink.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label6);
            this.groupBox12.Controls.Add(this.GreenBlink);
            this.groupBox12.Controls.Add(this.GreenOn);
            this.groupBox12.Controls.Add(this.GreenBlink2);
            this.groupBox12.Controls.Add(this.GreenOff);
            this.groupBox12.Location = new System.Drawing.Point(6, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(112, 92);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Blink";
            this.label6.Visible = false;
            // 
            // GreenBlink
            // 
            this.GreenBlink.AutoSize = true;
            this.GreenBlink.Location = new System.Drawing.Point(6, 69);
            this.GreenBlink.Name = "GreenBlink";
            this.GreenBlink.Size = new System.Drawing.Size(46, 17);
            this.GreenBlink.TabIndex = 20;
            this.GreenBlink.Text = "Blink";
            this.GreenBlink.UseVisualStyleBackColor = true;
            // 
            // GreenOn
            // 
            this.GreenOn.AutoSize = true;
            this.GreenOn.Checked = true;
            this.GreenOn.Location = new System.Drawing.Point(6, 46);
            this.GreenOn.Name = "GreenOn";
            this.GreenOn.Size = new System.Drawing.Size(39, 17);
            this.GreenOn.TabIndex = 21;
            this.GreenOn.TabStop = true;
            this.GreenOn.Text = "On";
            this.GreenOn.UseVisualStyleBackColor = true;
            // 
            // GreenBlink2
            // 
            this.GreenBlink2.AutoSize = true;
            this.GreenBlink2.Location = new System.Drawing.Point(59, 69);
            this.GreenBlink2.Name = "GreenBlink2";
            this.GreenBlink2.Size = new System.Drawing.Size(46, 17);
            this.GreenBlink2.TabIndex = 22;
            this.GreenBlink2.Text = "Fast";
            this.GreenBlink2.UseVisualStyleBackColor = true;
            this.GreenBlink2.Visible = false;
            // 
            // GreenOff
            // 
            this.GreenOff.AutoSize = true;
            this.GreenOff.Location = new System.Drawing.Point(6, 23);
            this.GreenOff.Name = "GreenOff";
            this.GreenOff.Size = new System.Drawing.Size(41, 17);
            this.GreenOff.TabIndex = 20;
            this.GreenOff.Text = "Off";
            this.GreenOff.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsoleBuzzerMode
            // 
            this.groupBoxConsoleBuzzerMode.Controls.Add(this.Triple);
            this.groupBoxConsoleBuzzerMode.Controls.Add(this.Single);
            this.groupBoxConsoleBuzzerMode.Controls.Add(this.Double);
            this.groupBoxConsoleBuzzerMode.Controls.Add(this.Continuous);
            this.groupBoxConsoleBuzzerMode.Location = new System.Drawing.Point(372, 19);
            this.groupBoxConsoleBuzzerMode.Name = "groupBoxConsoleBuzzerMode";
            this.groupBoxConsoleBuzzerMode.Size = new System.Drawing.Size(123, 117);
            this.groupBoxConsoleBuzzerMode.TabIndex = 23;
            this.groupBoxConsoleBuzzerMode.TabStop = false;
            this.groupBoxConsoleBuzzerMode.Text = "Console Buzzer Mode";
            // 
            // Triple
            // 
            this.Triple.AutoSize = true;
            this.Triple.Location = new System.Drawing.Point(6, 65);
            this.Triple.Name = "Triple";
            this.Triple.Size = new System.Drawing.Size(51, 17);
            this.Triple.TabIndex = 22;
            this.Triple.Text = "Triple";
            this.Triple.UseVisualStyleBackColor = true;
            // 
            // Single
            // 
            this.Single.AutoSize = true;
            this.Single.Checked = true;
            this.Single.Location = new System.Drawing.Point(6, 19);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(53, 17);
            this.Single.TabIndex = 20;
            this.Single.TabStop = true;
            this.Single.Text = "Single";
            this.Single.UseVisualStyleBackColor = true;
            // 
            // Double
            // 
            this.Double.AutoSize = true;
            this.Double.Location = new System.Drawing.Point(6, 42);
            this.Double.Name = "Double";
            this.Double.Size = new System.Drawing.Size(58, 17);
            this.Double.TabIndex = 21;
            this.Double.Text = "Double";
            this.Double.UseVisualStyleBackColor = true;
            // 
            // Continuous
            // 
            this.Continuous.AutoSize = true;
            this.Continuous.Location = new System.Drawing.Point(6, 88);
            this.Continuous.Name = "Continuous";
            this.Continuous.Size = new System.Drawing.Size(79, 17);
            this.Continuous.TabIndex = 20;
            this.Continuous.Text = "Continuous";
            this.Continuous.UseVisualStyleBackColor = true;
            // 
            // groupBoxVSH_Notify
            // 
            this.groupBoxVSH_Notify.Controls.Add(this.comboBoxVSH);
            this.groupBoxVSH_Notify.Controls.Add(this.textBoxVSH);
            this.groupBoxVSH_Notify.Controls.Add(this.button4);
            this.groupBoxVSH_Notify.Enabled = false;
            this.groupBoxVSH_Notify.Location = new System.Drawing.Point(283, 344);
            this.groupBoxVSH_Notify.Name = "groupBoxVSH_Notify";
            this.groupBoxVSH_Notify.Size = new System.Drawing.Size(501, 46);
            this.groupBoxVSH_Notify.TabIndex = 19;
            this.groupBoxVSH_Notify.TabStop = false;
            this.groupBoxVSH_Notify.Text = "VSH Notify";
            // 
            // comboBoxVSH
            // 
            this.comboBoxVSH.FormattingEnabled = true;
            this.comboBoxVSH.IntegralHeight = false;
            this.comboBoxVSH.ItemHeight = 13;
            this.comboBoxVSH.Items.AddRange(new object[] {
            "Info",
            "Caution",
            "Friend",
            "Slider",
            "Wrong Way",
            "Dialog",
            "Dialog Shadow",
            "Text",
            "Pointer",
            "Grab",
            "Hand",
            "Pen",
            "Finger",
            "Arrow",
            "Arrow Right",
            "Progress",
            "Trophy1",
            "Trophy2",
            "Trophy3",
            "Trophy4"});
            this.comboBoxVSH.Location = new System.Drawing.Point(6, 19);
            this.comboBoxVSH.Name = "comboBoxVSH";
            this.comboBoxVSH.Size = new System.Drawing.Size(105, 21);
            this.comboBoxVSH.TabIndex = 44;
            // 
            // textBoxVSH
            // 
            this.textBoxVSH.Location = new System.Drawing.Point(117, 19);
            this.textBoxVSH.MaxLength = 168;
            this.textBoxVSH.Multiline = true;
            this.textBoxVSH.Name = "textBoxVSH";
            this.textBoxVSH.Size = new System.Drawing.Size(288, 21);
            this.textBoxVSH.TabIndex = 43;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 21);
            this.button4.TabIndex = 21;
            this.button4.Text = "Send Notify";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBoxConnection2
            // 
            this.groupBoxConnection2.Controls.Add(this.ConnectToggle);
            this.groupBoxConnection2.Controls.Add(this.CCAPI);
            this.groupBoxConnection2.Controls.Add(this.TMAPI);
            this.groupBoxConnection2.Controls.Add(this.PSMAPI);
            this.groupBoxConnection2.Location = new System.Drawing.Point(8, 170);
            this.groupBoxConnection2.Name = "groupBoxConnection2";
            this.groupBoxConnection2.Size = new System.Drawing.Size(269, 74);
            this.groupBoxConnection2.TabIndex = 44;
            this.groupBoxConnection2.TabStop = false;
            this.groupBoxConnection2.Text = "02: Connection";
            // 
            // ConnectToggle
            // 
            this.ConnectToggle.AutoSize = true;
            this.ConnectToggle.Enabled = false;
            this.ConnectToggle.Location = new System.Drawing.Point(203, 35);
            this.ConnectToggle.Name = "ConnectToggle";
            this.ConnectToggle.Size = new System.Drawing.Size(66, 17);
            this.ConnectToggle.TabIndex = 21;
            this.ConnectToggle.Text = "Connect";
            this.ConnectToggle.UseVisualStyleBackColor = true;
            this.ConnectToggle.CheckedChanged += new System.EventHandler(this.ConnectToggle_CheckedChanged);
            // 
            // CCAPI
            // 
            this.CCAPI.AutoSize = true;
            this.CCAPI.Location = new System.Drawing.Point(6, 35);
            this.CCAPI.Name = "CCAPI";
            this.CCAPI.Size = new System.Drawing.Size(56, 17);
            this.CCAPI.TabIndex = 43;
            this.CCAPI.Text = "CCAPI";
            this.CCAPI.UseVisualStyleBackColor = true;
            this.CCAPI.CheckedChanged += new System.EventHandler(this.CCAPI_CheckedChanged);
            // 
            // TMAPI
            // 
            this.TMAPI.AutoSize = true;
            this.TMAPI.Location = new System.Drawing.Point(68, 35);
            this.TMAPI.Name = "TMAPI";
            this.TMAPI.Size = new System.Drawing.Size(56, 17);
            this.TMAPI.TabIndex = 44;
            this.TMAPI.Text = "TMAPI";
            this.TMAPI.UseVisualStyleBackColor = true;
            this.TMAPI.CheckedChanged += new System.EventHandler(this.TMAPI_CheckedChanged);
            // 
            // PSMAPI
            // 
            this.PSMAPI.AutoSize = true;
            this.PSMAPI.Location = new System.Drawing.Point(130, 35);
            this.PSMAPI.Name = "PSMAPI";
            this.PSMAPI.Size = new System.Drawing.Size(68, 17);
            this.PSMAPI.TabIndex = 45;
            this.PSMAPI.Text = "PS3MAPI";
            this.PSMAPI.UseVisualStyleBackColor = true;
            this.PSMAPI.CheckedChanged += new System.EventHandler(this.PSMAPI_CheckedChanged);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.Refresh);
            this.groupBoxDetails.Controls.Add(this.groupBoxConsole_Info);
            this.groupBoxDetails.Controls.Add(this.Execute);
            this.groupBoxDetails.Controls.Add(this.groupBoxConsoleShutdownMode);
            this.groupBoxDetails.Enabled = false;
            this.groupBoxDetails.Location = new System.Drawing.Point(283, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(501, 155);
            this.groupBoxDetails.TabIndex = 16;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(6, 126);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(241, 23);
            this.Refresh.TabIndex = 13;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // groupBoxConsole_Info
            // 
            this.groupBoxConsole_Info.Controls.Add(this.label1);
            this.groupBoxConsole_Info.Controls.Add(this.RSX_Temperature);
            this.groupBoxConsole_Info.Controls.Add(this.label4);
            this.groupBoxConsole_Info.Controls.Add(this.Firmware);
            this.groupBoxConsole_Info.Controls.Add(this.CELL_Temperature);
            this.groupBoxConsole_Info.Controls.Add(this.label3);
            this.groupBoxConsole_Info.Controls.Add(this.label2);
            this.groupBoxConsole_Info.Controls.Add(this.Console_type);
            this.groupBoxConsole_Info.Location = new System.Drawing.Point(6, 19);
            this.groupBoxConsole_Info.Name = "groupBoxConsole_Info";
            this.groupBoxConsole_Info.Size = new System.Drawing.Size(241, 101);
            this.groupBoxConsole_Info.TabIndex = 20;
            this.groupBoxConsole_Info.TabStop = false;
            this.groupBoxConsole_Info.Text = "Console Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firmware:";
            // 
            // RSX_Temperature
            // 
            this.RSX_Temperature.AutoSize = true;
            this.RSX_Temperature.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSX_Temperature.Location = new System.Drawing.Point(121, 77);
            this.RSX_Temperature.Name = "RSX_Temperature";
            this.RSX_Temperature.Size = new System.Drawing.Size(17, 13);
            this.RSX_Temperature.TabIndex = 17;
            this.RSX_Temperature.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RSX temperature:";
            // 
            // Firmware
            // 
            this.Firmware.AutoSize = true;
            this.Firmware.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firmware.Location = new System.Drawing.Point(83, 19);
            this.Firmware.Name = "Firmware";
            this.Firmware.Size = new System.Drawing.Size(22, 13);
            this.Firmware.TabIndex = 14;
            this.Firmware.Text = "???";
            // 
            // CELL_Temperature
            // 
            this.CELL_Temperature.AutoSize = true;
            this.CELL_Temperature.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CELL_Temperature.Location = new System.Drawing.Point(125, 58);
            this.CELL_Temperature.Name = "CELL_Temperature";
            this.CELL_Temperature.Size = new System.Drawing.Size(17, 13);
            this.CELL_Temperature.TabIndex = 16;
            this.CELL_Temperature.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CELL temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Console Type:";
            // 
            // Console_type
            // 
            this.Console_type.AutoSize = true;
            this.Console_type.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console_type.Location = new System.Drawing.Point(104, 38);
            this.Console_type.Name = "Console_type";
            this.Console_type.Size = new System.Drawing.Size(22, 13);
            this.Console_type.TabIndex = 15;
            this.Console_type.Text = "???";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(254, 126);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(241, 23);
            this.Execute.TabIndex = 14;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // groupBoxConsoleShutdownMode
            // 
            this.groupBoxConsoleShutdownMode.Controls.Add(this.QuickReboot);
            this.groupBoxConsoleShutdownMode.Controls.Add(this.Shutdown);
            this.groupBoxConsoleShutdownMode.Controls.Add(this.HardReboot);
            this.groupBoxConsoleShutdownMode.Controls.Add(this.SoftReboot);
            this.groupBoxConsoleShutdownMode.Location = new System.Drawing.Point(254, 19);
            this.groupBoxConsoleShutdownMode.Name = "groupBoxConsoleShutdownMode";
            this.groupBoxConsoleShutdownMode.Size = new System.Drawing.Size(241, 101);
            this.groupBoxConsoleShutdownMode.TabIndex = 4;
            this.groupBoxConsoleShutdownMode.TabStop = false;
            this.groupBoxConsoleShutdownMode.Text = "Console Shutdown Mode";
            // 
            // QuickReboot
            // 
            this.QuickReboot.AutoSize = true;
            this.QuickReboot.Location = new System.Drawing.Point(127, 58);
            this.QuickReboot.Name = "QuickReboot";
            this.QuickReboot.Size = new System.Drawing.Size(89, 17);
            this.QuickReboot.TabIndex = 19;
            this.QuickReboot.Text = "Quick Reboot";
            this.QuickReboot.UseVisualStyleBackColor = true;
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.Checked = true;
            this.Shutdown.Location = new System.Drawing.Point(22, 35);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(73, 17);
            this.Shutdown.TabIndex = 16;
            this.Shutdown.TabStop = true;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = true;
            // 
            // HardReboot
            // 
            this.HardReboot.AutoSize = true;
            this.HardReboot.Location = new System.Drawing.Point(127, 35);
            this.HardReboot.Name = "HardReboot";
            this.HardReboot.Size = new System.Drawing.Size(86, 17);
            this.HardReboot.TabIndex = 18;
            this.HardReboot.Text = "Hard Reboot";
            this.HardReboot.UseVisualStyleBackColor = true;
            // 
            // SoftReboot
            // 
            this.SoftReboot.AutoSize = true;
            this.SoftReboot.Location = new System.Drawing.Point(22, 58);
            this.SoftReboot.Name = "SoftReboot";
            this.SoftReboot.Size = new System.Drawing.Size(83, 17);
            this.SoftReboot.TabIndex = 17;
            this.SoftReboot.Text = "Soft Reboot";
            this.SoftReboot.UseVisualStyleBackColor = true;
            // 
            // groupBoxConnection1
            // 
            this.groupBoxConnection1.Controls.Add(this.pictureBoxStatusError);
            this.groupBoxConnection1.Controls.Add(this.pictureBoxStatusVerified);
            this.groupBoxConnection1.Controls.Add(this.pictureBoxStatusUnverified);
            this.groupBoxConnection1.Controls.Add(this.pictureBoxStatusEdit);
            this.groupBoxConnection1.Controls.Add(this.ReconnectBtn);
            this.groupBoxConnection1.Controls.Add(this.apiLabel);
            this.groupBoxConnection1.Controls.Add(this.DisconnectBtn);
            this.groupBoxConnection1.Controls.Add(this.consoleName);
            this.groupBoxConnection1.Controls.Add(this.Attach);
            this.groupBoxConnection1.Controls.Add(this.CEX);
            this.groupBoxConnection1.Controls.Add(this.HEN);
            this.groupBoxConnection1.Controls.Add(this.Connect);
            this.groupBoxConnection1.Controls.Add(this.InputIP);
            this.groupBoxConnection1.Controls.Add(this.DEX);
            this.groupBoxConnection1.Location = new System.Drawing.Point(8, 6);
            this.groupBoxConnection1.Name = "groupBoxConnection1";
            this.groupBoxConnection1.Size = new System.Drawing.Size(269, 158);
            this.groupBoxConnection1.TabIndex = 3;
            this.groupBoxConnection1.TabStop = false;
            this.groupBoxConnection1.Text = "01: Connection";
            // 
            // pictureBoxStatusError
            // 
            this.pictureBoxStatusError.Image = global::Properties.Resources.box_important_96px;
            this.pictureBoxStatusError.Location = new System.Drawing.Point(227, 59);
            this.pictureBoxStatusError.Name = "pictureBoxStatusError";
            this.pictureBoxStatusError.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxStatusError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatusError.TabIndex = 48;
            this.pictureBoxStatusError.TabStop = false;
            this.pictureBoxStatusError.Visible = false;
            // 
            // pictureBoxStatusVerified
            // 
            this.pictureBoxStatusVerified.Image = global::Properties.Resources.verified_badge_96px;
            this.pictureBoxStatusVerified.Location = new System.Drawing.Point(227, 59);
            this.pictureBoxStatusVerified.Name = "pictureBoxStatusVerified";
            this.pictureBoxStatusVerified.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxStatusVerified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatusVerified.TabIndex = 47;
            this.pictureBoxStatusVerified.TabStop = false;
            this.pictureBoxStatusVerified.Visible = false;
            // 
            // pictureBoxStatusUnverified
            // 
            this.pictureBoxStatusUnverified.Image = global::Properties.Resources.unverified_account_96px;
            this.pictureBoxStatusUnverified.Location = new System.Drawing.Point(227, 59);
            this.pictureBoxStatusUnverified.Name = "pictureBoxStatusUnverified";
            this.pictureBoxStatusUnverified.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxStatusUnverified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatusUnverified.TabIndex = 46;
            this.pictureBoxStatusUnverified.TabStop = false;
            this.pictureBoxStatusUnverified.Visible = false;
            // 
            // pictureBoxStatusEdit
            // 
            this.pictureBoxStatusEdit.Image = global::Properties.Resources.edit_96px;
            this.pictureBoxStatusEdit.Location = new System.Drawing.Point(227, 59);
            this.pictureBoxStatusEdit.Name = "pictureBoxStatusEdit";
            this.pictureBoxStatusEdit.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxStatusEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatusEdit.TabIndex = 45;
            this.pictureBoxStatusEdit.TabStop = false;
            // 
            // ReconnectBtn
            // 
            this.ReconnectBtn.Location = new System.Drawing.Point(22, 113);
            this.ReconnectBtn.Name = "ReconnectBtn";
            this.ReconnectBtn.Size = new System.Drawing.Size(225, 23);
            this.ReconnectBtn.TabIndex = 43;
            this.ReconnectBtn.Text = "Reconnect";
            this.ReconnectBtn.UseVisualStyleBackColor = true;
            this.ReconnectBtn.Visible = false;
            this.ReconnectBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // apiLabel
            // 
            this.apiLabel.AutoSize = true;
            this.apiLabel.Location = new System.Drawing.Point(164, 42);
            this.apiLabel.Name = "apiLabel";
            this.apiLabel.Size = new System.Drawing.Size(85, 13);
            this.apiLabel.TabIndex = 44;
            this.apiLabel.Text = "                      ...";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(22, 84);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(225, 23);
            this.DisconnectBtn.TabIndex = 44;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Visible = false;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // consoleName
            // 
            this.consoleName.AutoSize = true;
            this.consoleName.Location = new System.Drawing.Point(19, 139);
            this.consoleName.Name = "consoleName";
            this.consoleName.Size = new System.Drawing.Size(96, 13);
            this.consoleName.TabIndex = 43;
            this.consoleName.Text = "Consloe: Unknown";
            // 
            // Attach
            // 
            this.Attach.Enabled = false;
            this.Attach.Location = new System.Drawing.Point(22, 113);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(225, 23);
            this.Attach.TabIndex = 15;
            this.Attach.Text = "Attach";
            this.Attach.UseVisualStyleBackColor = true;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // CEX
            // 
            this.CEX.AutoSize = true;
            this.CEX.Location = new System.Drawing.Point(22, 35);
            this.CEX.Name = "CEX";
            this.CEX.Size = new System.Drawing.Size(44, 17);
            this.CEX.TabIndex = 6;
            this.CEX.Text = "CEX";
            this.CEX.UseVisualStyleBackColor = true;
            this.CEX.CheckedChanged += new System.EventHandler(this.CEX_CheckedChanged);
            // 
            // HEN
            // 
            this.HEN.AutoSize = true;
            this.HEN.Location = new System.Drawing.Point(122, 35);
            this.HEN.Name = "HEN";
            this.HEN.Size = new System.Drawing.Size(45, 17);
            this.HEN.TabIndex = 14;
            this.HEN.Text = "HEN";
            this.HEN.UseVisualStyleBackColor = true;
            this.HEN.CheckedChanged += new System.EventHandler(this.HEN_CheckedChanged);
            // 
            // Connect
            // 
            this.Connect.Enabled = false;
            this.Connect.Location = new System.Drawing.Point(22, 84);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(225, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // InputIP
            // 
            this.InputIP.Location = new System.Drawing.Point(22, 58);
            this.InputIP.MaxLength = 15;
            this.InputIP.Name = "InputIP";
            this.InputIP.Size = new System.Drawing.Size(225, 20);
            this.InputIP.TabIndex = 8;
            this.InputIP.TextChanged += new System.EventHandler(this.InputIP_TextChanged);
            // 
            // DEX
            // 
            this.DEX.AutoSize = true;
            this.DEX.Location = new System.Drawing.Point(72, 35);
            this.DEX.Name = "DEX";
            this.DEX.Size = new System.Drawing.Size(44, 17);
            this.DEX.TabIndex = 13;
            this.DEX.Text = "DEX";
            this.DEX.UseVisualStyleBackColor = true;
            this.DEX.CheckedChanged += new System.EventHandler(this.DEX_CheckedChanged);
            // 
            // groupBoxConnection3
            // 
            this.groupBoxConnection3.Controls.Add(this.ConnectionStatusBarValueLable);
            this.groupBoxConnection3.Controls.Add(this.ConnectionStatusBar);
            this.groupBoxConnection3.Controls.Add(this.button13);
            this.groupBoxConnection3.Controls.Add(this.button1);
            this.groupBoxConnection3.Controls.Add(this.AttachMethod);
            this.groupBoxConnection3.Location = new System.Drawing.Point(8, 250);
            this.groupBoxConnection3.Name = "groupBoxConnection3";
            this.groupBoxConnection3.Size = new System.Drawing.Size(269, 140);
            this.groupBoxConnection3.TabIndex = 17;
            this.groupBoxConnection3.TabStop = false;
            this.groupBoxConnection3.Text = "03: Connection";
            // 
            // ConnectionStatusBarValueLable
            // 
            this.ConnectionStatusBarValueLable.AutoSize = true;
            this.ConnectionStatusBarValueLable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusBarValueLable.Location = new System.Drawing.Point(211, 19);
            this.ConnectionStatusBarValueLable.Name = "ConnectionStatusBarValueLable";
            this.ConnectionStatusBarValueLable.Size = new System.Drawing.Size(24, 13);
            this.ConnectionStatusBarValueLable.TabIndex = 18;
            this.ConnectionStatusBarValueLable.Text = "0%";
            // 
            // ConnectionStatusBar
            // 
            this.ConnectionStatusBar.Location = new System.Drawing.Point(22, 62);
            this.ConnectionStatusBar.Name = "ConnectionStatusBar";
            this.ConnectionStatusBar.Size = new System.Drawing.Size(225, 23);
            this.ConnectionStatusBar.Step = 1;
            this.ConnectionStatusBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ConnectionStatusBar.TabIndex = 46;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(163, 35);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 21);
            this.button13.TabIndex = 43;
            this.button13.Text = "Connect";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // AttachMethod
            // 
            this.AttachMethod.FormattingEnabled = true;
            this.AttachMethod.Items.AddRange(new object[] {
            "ControlConsole",
            "TargetManager",
            "PS3Manager"});
            this.AttachMethod.Location = new System.Drawing.Point(22, 35);
            this.AttachMethod.Name = "AttachMethod";
            this.AttachMethod.Size = new System.Drawing.Size(135, 21);
            this.AttachMethod.TabIndex = 43;
            this.AttachMethod.SelectedIndexChanged += new System.EventHandler(this.AttachMethod_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxCredits);
            this.tabPage2.Controls.Add(this.groupBoxMemory);
            this.tabPage2.Controls.Add(this.groupBoxNonHost);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main Mods Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxNonHost
            // 
            this.groupBoxNonHost.Controls.Add(this.checker4Btn);
            this.groupBoxNonHost.Controls.Add(this.button12);
            this.groupBoxNonHost.Controls.Add(this.label);
            this.groupBoxNonHost.Controls.Add(this.comboBox1);
            this.groupBoxNonHost.Controls.Add(this.button10);
            this.groupBoxNonHost.Controls.Add(this.checkBox6);
            this.groupBoxNonHost.Controls.Add(this.button11);
            this.groupBoxNonHost.Controls.Add(this.button7);
            this.groupBoxNonHost.Controls.Add(this.checkBox5);
            this.groupBoxNonHost.Controls.Add(this.checkBox4);
            this.groupBoxNonHost.Controls.Add(this.checkBox2);
            this.groupBoxNonHost.Enabled = false;
            this.groupBoxNonHost.Location = new System.Drawing.Point(396, 6);
            this.groupBoxNonHost.Name = "groupBoxNonHost";
            this.groupBoxNonHost.Size = new System.Drawing.Size(388, 217);
            this.groupBoxNonHost.TabIndex = 16;
            this.groupBoxNonHost.TabStop = false;
            this.groupBoxNonHost.Text = "01: Non-Host Mods";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ConnectionStatusLable,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.AttachStatusLable,
            this.toolStripButton1,
            this.SSID,
            this.toolStripLabel2,
            this.Signal,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel1.Text = "Connection Status:";
            // 
            // ConnectionStatusLable
            // 
            this.ConnectionStatusLable.Name = "ConnectionStatusLable";
            this.ConnectionStatusLable.Size = new System.Drawing.Size(88, 22);
            this.ConnectionStatusLable.Text = "Not Connected";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel3.Text = "Attach Status:";
            // 
            // AttachStatusLable
            // 
            this.AttachStatusLable.Name = "AttachStatusLable";
            this.AttachStatusLable.Size = new System.Drawing.Size(78, 22);
            this.AttachStatusLable.Text = "Not Attached";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = global::Properties.Resources.refresh_192px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(145, 22);
            this.toolStripButton1.Text = "Refresh Status (Check)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // SSID
            // 
            this.SSID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SSID.Name = "SSID";
            this.SSID.Size = new System.Drawing.Size(22, 22);
            this.SSID.Text = "???";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel2.Text = "SSID:";
            // 
            // Signal
            // 
            this.Signal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Signal.Name = "Signal";
            this.Signal.Size = new System.Drawing.Size(22, 22);
            this.Signal.Text = "???";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel5.Text = "Signal:";
            // 
            // StatusBarLoader
            // 
            this.StatusBarLoader.Tick += new System.EventHandler(this.StatusBarLoader_Tick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTM Tool Base";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxMemory.ResumeLayout(false);
            this.groupBoxMemory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBoxCredits.ResumeLayout(false);
            this.groupBoxCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxSystem.ResumeLayout(false);
            this.groupBoxConsoleLeds.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBoxConsoleBuzzerMode.ResumeLayout(false);
            this.groupBoxConsoleBuzzerMode.PerformLayout();
            this.groupBoxVSH_Notify.ResumeLayout(false);
            this.groupBoxVSH_Notify.PerformLayout();
            this.groupBoxConnection2.ResumeLayout(false);
            this.groupBoxConnection2.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxConsole_Info.ResumeLayout(false);
            this.groupBoxConsole_Info.PerformLayout();
            this.groupBoxConsoleShutdownMode.ResumeLayout(false);
            this.groupBoxConsoleShutdownMode.PerformLayout();
            this.groupBoxConnection1.ResumeLayout(false);
            this.groupBoxConnection1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusVerified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusUnverified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusEdit)).EndInit();
            this.groupBoxConnection3.ResumeLayout(false);
            this.groupBoxConnection3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxNonHost.ResumeLayout(false);
            this.groupBoxNonHost.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public bool IsValidIP(string input)
    {
        bool reg = Regex.IsMatch(input, @"^([0-9]{1,3}\.){3}[0-9]{1,3}$");
        if (reg)
        {
            if (input.Length > 8 || input.Length < 15)
            {
                input.Substring(0, input.Length);
            }
        }
        return reg;
    }

    private void PicStatus(bool enable1, bool enable2, bool enable3, bool enable4)
    {
        pictureBoxStatusEdit.Visible = enable1;
        pictureBoxStatusUnverified.Visible = enable2;
        pictureBoxStatusVerified.Visible = enable3;
        pictureBoxStatusError.Visible = enable4;
    }

    private void InputIP_TextChanged(object sender, EventArgs e)
    {
        if (IsValidIP(InputIP.Text))
        {
            if (InputIP.Text == string.Empty)
            {
                PicStatus(true, false, false, false);
                this.Connect.Enabled = false;
            }
            else
            {
                if (InputIP.Text.Length < 8)
                {
                    this.Connect.Enabled = false;
                    PicStatus(false, true, false, false);
                }
                else if (InputIP.Text.Length >= 8)
                {
                    this.Connect.Enabled = true;
                    PicStatus(false, false, true, false);
                }
            }
        }
        else if (!IsValidIP(InputIP.Text))
        {
            this.Connect.Enabled = false;
            PicStatus(false, false, false, true);
        }
    }

    private void restartAppToolStripMenuItem_Click(object sender, EventArgs e)
    {
        base.Hide();
        new Form1().Show();
        RTM_Tool_Base_By_iixFi.Visible = false;
    }

    private void defaultPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.SetBalloonTip(1000, "Default Properties");
        this.Size = new Size(816, 488);
        this.Location = new Point(275, 120);
        base.WindowState = FormWindowState.Normal;
    }

    private void RTM_Tool_Base_By_iixFi_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        this.Show();
    }
  }
}
