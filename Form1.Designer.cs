namespace CS_Shortcuts;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "CS Chortcuts";

        Label lbl_1 = new Label();
        lbl_1.Width = 300;
        lbl_1.Text = "ALT + Q => M4A1-S / AK-47 + Kevlar";
        this.Controls.Add(lbl_1);
        
        Label lbl_2 = new Label();
        lbl_2.Width = 300;
        lbl_2.Top = 20;
        lbl_2.Text = "ALT + W => AWP + Kevlar";
        this.Controls.Add(lbl_2);
        
        Label lbl_3 = new Label();
        lbl_3.Width = 300;
        lbl_3.Top = 40;
        lbl_3.Text = "ALT + E => XM + Kevlar";
        this.Controls.Add(lbl_3);
        
        Label lbl_4 = new Label();
        lbl_4.Width = 300;
        lbl_4.Top = 60;
        lbl_4.Text = "ALT + R => Kevlar";
        this.Controls.Add(lbl_4);
        
        Label lbl_5 = new Label();
        lbl_5.Width = 300;
        lbl_5.Top = 80;
        lbl_5.Text = "ALT + T => Grenades";
        this.Controls.Add(lbl_5);
        
        Label lbl_6 = new Label();
        lbl_6.Width = 300;
        lbl_6.Top = 100;
        lbl_6.Text = "ALT + Z => TEC + Kevlar";
        this.Controls.Add(lbl_6);
    }
    
}