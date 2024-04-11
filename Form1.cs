using System.Runtime.InteropServices;

namespace CS_Shortcuts;

public partial class Form1 : Form
{
    
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
    
    
    public Form1()
    {
        InitializeComponent();
        this.KeyPreview = true;
        RegisterHotKey(this.Handle, 0, 1, Keys.Q.GetHashCode());
        RegisterHotKey(this.Handle, 1, 1, Keys.W.GetHashCode());
        RegisterHotKey(this.Handle, 2, 1, Keys.E.GetHashCode());
        RegisterHotKey(this.Handle, 3, 1, Keys.R.GetHashCode());
        RegisterHotKey(this.Handle, 4, 1, Keys.T.GetHashCode());
        RegisterHotKey(this.Handle, 5, 1, Keys.Z.GetHashCode());
    }

    /// <summary>
    /// Windows override to capture keybind
    /// </summary>
    /// <param name="m">The message from os</param>
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == 0x0312)
        {
            Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
            int modifier = ((int)m.LParam & 0xFFFF);
            if (modifier == 1)
            {
                Console.WriteLine(key);
                WriteBuyShortcut(key);
            }
        }
    }

    /// <summary>
    /// Writes a shortcut to keyboard by converting it
    /// into the CSGO sequence 
    /// </summary>
    /// <param name="key">The key that is pressed for shortcut</param>
    private void WriteBuyShortcut(Keys key)
    {
        switch (key)
        {
            case Keys.Q:
                // Sends M4A1-S and Kevlar
                this.SendAsThread("b1242b");
                break;
            case Keys.W:
                // Sends AWP and Kevlar
                this.SendAsThread("b1245b");
                break;
            case Keys.E:
                // Send XM and Kevlar
                this.SendAsThread("b1232b");
                break;
            case Keys.R:
                // Sends kevlar
                this.SendAsThread("b12b");
                break;
            case Keys.T:
                // Sends grenades
                this.SendAsThread("b1143b");
                break;
            case Keys.Z:
                // Sends tec and kevlar
                this.SendAsThread("b1224b");
                break;
        }
    }

    private void SendAsThread(string key)
    {
        new Thread(() =>
        {
            SendKeys.SendWait(key);
        }).Start();
    }
}