using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearBox
{
    public partial class EasyGearBox : Form
    {
        float[] GearRPS;
        bool[,] GearB;
        int NumGB = 0, n = 0, nGear = 0;
        float MinDif;
        string str = "";
        public EasyGearBox()
        {
            InitializeComponent();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).ForeColor == Color.DimGray)
            {
                (sender as TextBox).Text = null;
                (sender as TextBox).ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.DimGray;
                (sender as TextBox).Text = "0-100";
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127) e.Handled = true;
            else if (e.KeyChar != 8)
            {
                str = textBox1.Text;
                if (e.KeyChar > 47 && e.KeyChar < 58)
                {
                    if (textBox1.SelectionStart == str.Length) str += e.KeyChar;
                    else str = str.Replace(str.Substring(textBox1.SelectionStart, textBox1.SelectionLength), e.KeyChar.ToString());
                    if (float.Parse(str) > 100) e.Handled = true;
                }
                str = null;
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (NumGB < 11)
            {
                TextBox tb = new TextBox();
                NumericUpDown[] nUD = new NumericUpDown[4];
                Button b = new Button();
                tb.Name = "tB" + NumGB.ToString();
                tb.Text = "GB" + NumGB.ToString();
                tb.Enabled = false;
                tb.Size = new Size(36, 20);
                tb.Margin = new Padding(0, 0, 3, 0);
                fLPanel.Controls.Add(tb);
                for (int i = 0; i < 4; i++)
                {
                    nUD[i] = new NumericUpDown();
                    nUD[i].Value = 1;
                    nUD[i].Margin = new Padding(3, 0, 3, 0);
                    nUD[i].Minimum = 1;
                    nUD[i].Maximum = 9;
                    nUD[i].Size = new Size(32, 20);
                    nUD[i].Name = "nUD" + NumGB.ToString() + i.ToString();
                    fLPanel.Controls.Add(nUD[i]);
                }
                b.Text = "-";
                b.Name = "b" + NumGB.ToString();
                b.Margin = new Padding(3, 0, 0, 0);
                b.Size = new Size(20, 20);
                b.Click += new System.EventHandler(this.buttonMin_Click);
                fLPanel.Controls.Add(b);
                NumGB++;
            }
        }
        private void buttonMin_Click(object sender, EventArgs e)
        {
            NumGB--;
            for (int i = int.Parse((sender as Button).Name.Substring(1)); i < NumGB; i++) for (int j = 0; j < 4; j++) (fLPanel.Controls["nUD" + i.ToString() + j.ToString()] as NumericUpDown).Value = (fLPanel.Controls["nUD" + (i + 1).ToString() + j.ToString()] as NumericUpDown).Value;
            fLPanel.Controls.Remove(fLPanel.Controls["tB" + NumGB.ToString()]);
            fLPanel.Controls.Remove(fLPanel.Controls["b" + NumGB.ToString()]);
            for (int i = 0; i < 4; i++) fLPanel.Controls.Remove(fLPanel.Controls["nUD" + NumGB.ToString() + i.ToString()]);
        }
        void buttonMin_Click1(object sender, EventArgs e)
        {
            int k = int.Parse((sender as Button).Name.Substring(2));
            str = (fLPanel1.Controls["tBr" + k.ToString()] as TextBox).Text.Replace('.', ',');
            MinDif = float.Parse(str);
            for (int i = 0; i < n; i++) if (MinDif == GearRPS[i]) GearRPS[i] = -1;
            fLPanel1.Controls.Remove(fLPanel1.Controls["tBg" + k.ToString()]);
            fLPanel1.Controls.Remove(fLPanel1.Controls["tBr" + k.ToString()]);
            fLPanel1.Controls.Remove(fLPanel1.Controls["bg" + k.ToString()]);
            for (int i = k + 1; i < nGear; i++)
            {
                (fLPanel1.Controls["tBg" + i.ToString()] as TextBox).Name = "tBg" + (i - 1).ToString();
                (fLPanel1.Controls["tBr" + i.ToString()] as TextBox).Name = "tBr" + (i - 1).ToString();
                (fLPanel1.Controls["bg" + i.ToString()] as Button).Name = "bg" + (i - 1).ToString();
            }
            nGear--;
            textBox2.Text = nGear.ToString();
            str = null;
        }
        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (NumGB == 0) button0.Focus();
            else
            {
                if (textBox1.ForeColor == Color.DimGray) MinDif = 0;
                else MinDif = float.Parse(textBox1.Text);
                n = (int)Math.Pow(2, NumGB);
                GearRPS = new float[n];
                GearB = new bool[n, NumGB];
                for (int i = 0; i < n; i++)
                {
                    GearRPS[i] = 10000;
                    int ResGearBox = i;
                    for (int j = 0; j < NumGB; j++, ResGearBox /= 2)
                    {
                        GearB[i, j] = (ResGearBox % 2) == 1;
                        if (GearB[i, j])
                        {
                            GearRPS[i] *= (float)(fLPanel.Controls["nUD" + j.ToString() + "1"] as NumericUpDown).Value;
                            GearRPS[i] /= (float)(fLPanel.Controls["nUD" + j.ToString() + "0"] as NumericUpDown).Value;
                        }
                        else
                        {
                            GearRPS[i] *= (float)(fLPanel.Controls["nUD" + j.ToString() + "3"] as NumericUpDown).Value;
                            GearRPS[i] /= (float)(fLPanel.Controls["nUD" + j.ToString() + "2"] as NumericUpDown).Value;
                        }
                    }
                }
                for (int i = 0; i < n; i++) if (GearRPS[i] != -1) GearRPS[i] = (float)(Math.Round(GearRPS[i] * 10) / 1000);
                for (int i = 0; i < n; i++)
                {
                    if (GearRPS[i] == -1) continue;
                    nGear = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (GearRPS[nGear] > GearRPS[j] && GearRPS[j] != -1) nGear = j;
                        else if (GearRPS[nGear] == GearRPS[j] && GearRPS[j] != -1) GearRPS[j] = -1;
                    }
                    if (nGear == i) continue;
                    (GearRPS[i], GearRPS[nGear]) = (GearRPS[nGear], GearRPS[i]);
                    for (int k = 0; k < NumGB; k++) (GearB[i, k], GearB[nGear, k]) = (GearB[nGear, k], GearB[i, k]);
                }
                nGear = 0;
                if (MinDif != 0)
                {
                    for (int i = 0; i < (n - 1); i++)
                    {
                        if (GearRPS[i] == -1) continue;
                        for (int j = i + 1; j < n; j++)
                        {
                            if (GearRPS[j] == -1) continue;
                            if ((100 * (1 - (GearRPS[i] / GearRPS[j]))) < MinDif)
                            {
                                GearRPS[j] = -1;
                                i = -1;
                            }
                            break;
                        }
                    }
                }
                fLPanel1.Controls.Clear();
                for (int i = 0; i < n; i++)
                {
                    if (GearRPS[i] != -1)
                    {
                        str = "";
                        for (int j = 0; j < NumGB; j++) str += GearB[i, j] ? "1" : "0";
                        TextBox tBg = new TextBox();
                        tBg.Text = str;
                        tBg.Name = "tBg" + nGear.ToString();
                        tBg.Size = new Size(72, 20);
                        tBg.Margin = new Padding(0, 0, 3, 0);
                        tBg.Enabled = false;
                        fLPanel1.Controls.Add(tBg);
                        str = GearRPS[i].ToString().Replace(',', '.');
                        if (str.IndexOf('.') == -1) str += ".00";
                        else if (str.Substring(str.IndexOf('.')).Length == 2) str += "0";
                        tBg = new TextBox();
                        tBg.Text = str;
                        tBg.Name = "tBr" + nGear.ToString();
                        tBg.Size = new Size(57, 20);
                        tBg.Margin = new Padding(3, 0, 3, 0);
                        tBg.Enabled = false;
                        tBg.TextAlign = HorizontalAlignment.Center;
                        fLPanel1.Controls.Add(tBg);
                        Button bg = new Button();
                        bg.Text = "-";
                        bg.Margin = new Padding(3, 0, 0, 0);
                        bg.Size = new Size(20, 20);
                        bg.Name = "bg" + nGear.ToString();
                        bg.Click += new System.EventHandler(this.buttonMin_Click1);
                        fLPanel1.Controls.Add(bg);
                        nGear++;
                    }
                }
                textBox2.Text = nGear.ToString();
                str = null;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            str = "{";
            for (int i = 0; i < NumGB; i++)
            {
                str += "{";
                for (int j = 0, k = 0; j < n; j++) if (GearRPS[j] != -1)
                    {
                        str += (GearB[j, i] ? "1" : "0") + ((k == (nGear - 1)) ? "" : ",");
                        k++;
                    }
                str += "}" + (i == (NumGB - 1) ? "}" : ",\n");
            }
            Clipboard.SetDataObject(str);
            str = null;
        }
    }
}