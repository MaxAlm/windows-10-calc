using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        //! METHODS !//

        private void SetButtonColors()
        {
            foreach (Label button in this.Controls.OfType<Label>())
            {
                if (button.Name.Contains("button_"))
                {
                    switch (button.Tag.ToString())
                    {
                        case "gray1":
                            button.BackColor = Color.FromArgb(255, 49, 48, 47);
                            break;

                        case "gray2":
                            button.BackColor = Color.FromArgb(255, 35, 35, 35);
                            break;

                        case "gray3":
                            button.BackColor = Color.FromArgb(255, 19, 19, 19);
                            break;

                        case "gray4":
                            button.BackColor = Color.FromArgb(255, 6, 6, 6);
                            break;
                    }
                }
            }
        }

        private void SetNumberLabelSize()
        {
            // Set number size
            if (label_number.Text.Length > 13)
            {
                label_number.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                label_number.TextAlign = ContentAlignment.BottomLeft;
                label_comma.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                label_comma.TextAlign = ContentAlignment.BottomLeft;
            }
            else
            {
                label_number.Font = new Font("Segoe UI", 25, FontStyle.Bold);
                label_number.TextAlign = ContentAlignment.MiddleLeft;
                label_comma.Font = new Font("Segoe UI", 25, FontStyle.Bold);
                label_comma.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void CalculateEquation()
        {
            try
            {
                for (int k = 0; k < 4; k++)
                {
                    for (int i = operators.Count - 1; i >= 0; i--)
                    {
                        if (operators.Count != 0)
                        {
                            switch (k)
                            {
                                case (int)OPERATORS.MULTIPLY:
                                    if (operators[i] == "×")
                                    {
                                        numbers[i] = numbers[i] * numbers[i + 1];
                                        numbers.RemoveAt(i + 1);
                                        operators.RemoveAt(i);
                                    }
                                    break;

                                case (int)OPERATORS.DIVIDE:
                                    if (operators[i] == "÷")
                                    {
                                        if (numbers[i + 1] != 0)
                                        {
                                            numbers[i] = numbers[i] / numbers[i + 1];
                                            numbers.RemoveAt(i + 1);
                                            operators.RemoveAt(i);
                                        }
                                        else
                                        {
                                            label_number.Text = "!Error";
                                            return;
                                        }
                                    }
                                    break;

                                case (int)OPERATORS.ADD:
                                    if (operators[i] == "+")
                                    {
                                        numbers[i] = numbers[i] + numbers[i + 1];
                                        numbers.RemoveAt(i + 1);
                                        operators.RemoveAt(i);
                                    }
                                    break;

                                case (int)OPERATORS.SUBTRACT:
                                    if (operators[i] == "−")
                                    {
                                        numbers[i] = numbers[i] - numbers[i + 1];
                                        numbers.RemoveAt(i + 1);
                                        operators.RemoveAt(i);
                                    }
                                    break;
                            }
                        }
                    }
                }

                label_number.Text = numbers[0].ToString("N");

                // Check if comma is needed in result
                int commaPosition = -1;
                bool nonZeroValueFound = false;

                for (int i = 0; i < label_number.Text.Length; i++)
                {
                    if (commaPosition != -1)
                    {
                        if (label_number.Text[i].ToString() != "0") nonZeroValueFound = true;
                        break;
                    }
                    else
                    {
                        if (label_number.Text[i].ToString() == ",") commaPosition = i;
                    }
                }

                if (!nonZeroValueFound)
                    label_number.Text = label_number.Text.Remove(commaPosition);

                // If comma is needed, check if last digit is zero. If so remove it
                if (nonZeroValueFound && label_number.Text[label_number.Text.Length - 1].ToString() == "0")
                    label_number.Text = label_number.Text.Remove(label_number.Text.Length - 1);
            } catch { }
        }

        private void RemoveCommaFromLabel()
        {
            // Check if comma is needed in number
            int commaPosition = -1;
            bool nonZeroValueFound = false;

            for (int i = 0; i < label_number.Text.Length; i++)
            {
                if (!nonZeroValueFound)
                {
                    if (commaPosition != -1)
                    {
                        if (label_number.Text[i].ToString() != "0") nonZeroValueFound = true;
                    }
                    else
                    {
                        if (label_number.Text[i].ToString() == ",") commaPosition = i;
                    }
                }
            }

            // If comma was found, but no number above zero
            if (!nonZeroValueFound && commaPosition != -1)
                label_number.Text = label_number.Text.Remove(commaPosition);

            // If comma is needed, check if last digit is zero. If so remove it
            if (nonZeroValueFound)
            {
                while (label_number.Text[label_number.Text.Length - 1].ToString() == "0")
                {
                    label_number.Text = label_number.Text.Remove(label_number.Text.Length - 1);
                }
            }
        }

        private void RemoveCommaFromNumber(ref string num)
        {
            // Check if comma is needed in number
            int commaPosition = -1;
            bool nonZeroValueFound = false;

            for (int i = 0; i < num.Length; i++)
            {
                if (!nonZeroValueFound)
                {
                    if (commaPosition != -1)
                    {
                        if (num[i].ToString() != "0") nonZeroValueFound = true;
                    }
                    else
                    {
                        if (num[i].ToString() == ",") commaPosition = i;
                    }
                }
            }

            // If comma was found, but no number above zero
            if (!nonZeroValueFound && commaPosition != -1)
                num = num.Remove(commaPosition);

            // If comma is needed, check if last digit is zero. If so remove it
            if (nonZeroValueFound)
            {
                while (num[num.Length - 1].ToString() == "0")
                {
                    num = num.Remove(num.Length - 1);
                }
            }
        }

        //! VARIABLES !//

        bool comma = false;             // Check if comma has been added to the number.
        bool drag = false;              // Controls if the title bar is being dragged or not.
        Point startPoint = new Point(); // Stores the mouse coordinates in realtion to the title_bar control.

        enum OPERATORS { MULTIPLY = 0, DIVIDE = 1, ADD = 2, SUBTRACT = 3 } // Used to easier find what does what in the "CalculateEquation" method.

        List<double> numbers = new List<double>();      // Stores all the numbers in the current equation.
        List<string> operators = new List<string>();    // Stores all the operators in the current equation.

        //! CODE START !//

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set button colors
            SetButtonColors();

            // Reset labels
            label_input.Text = String.Empty;
            label_number.Text = String.Empty;

            // Create title bar
            Label title_bar = new Label() { BackColor = Color.FromArgb(255, 35, 35, 35), ForeColor = Color.White, Text = "   Calculator", TextAlign = ContentAlignment.MiddleLeft, Left = 0, Top = 0, Width = this.Width, Height = button_quit.Height + button_quit.Top };
            title_bar.MouseDown += MouseTitleDown;
            title_bar.MouseUp += MouseTitleUp;
            title_bar.MouseMove += MouseTitleMove;
            this.Controls.Add(title_bar);
            
        }



        //! MOUSE EVENTS !//

        // Mouse click
        private void MouseClickEvent(object sender, MouseEventArgs e)
        {
            var obj = (sender as Label);
            
            // Left click
            if (e.Button == MouseButtons.Left)
            {
                if (obj.Name == "button_quit") // Quit
                {
                    Application.Exit();
                }
                else if (obj.Name == "button_minimize") // Minimize
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                else if (obj.Name == "button_c") // Reset calc
                {
                    label_input.Text = String.Empty;
                    label_number.Text = String.Empty;
                    numbers.Clear();
                    operators.Clear();
                    comma = false;
                    label_comma.Visible = false;
                }
                else if (obj.Name == "button_ce") // Clear number
                {
                    if (label_input.Text != String.Empty && label_input.Text[label_input.Text.Length - 1].ToString() == "=")
                    {
                        label_input.Text = String.Empty;
                        label_number.Text = String.Empty;
                        operators.Clear();
                        numbers.Clear();
                        comma = false;
                        label_comma.Visible = false;
                    }
                    else
                    {
                        label_number.Text = String.Empty;
                        comma = false;
                        label_comma.Visible = false;
                    }
                }
                else if (obj.Name == "button_delete") // Delete
                {
                    // If invalid format
                    if (label_number.Text == "Invalid Format")
                    {
                        label_number.Text = String.Empty;
                    }
                    
                    // If equals has been pressed
                    if (label_input.Text != String.Empty && label_input.Text[label_input.Text.Length - 1].ToString() == "=")
                    {
                        label_input.Text = String.Empty;
                        label_number.Text = String.Empty;
                        operators.Clear();
                        numbers.Clear();
                        comma = false;
                    }

                    if (label_number.Text.Length == 1)
                    {
                        label_number.Text = String.Empty;
                    }
                    else if (label_number.Text.Length > 1)
                    {
                        label_number.Text = label_number.Text.Remove(label_number.Text.Length - 1, 1);

                        // Check if last character is a comma
                        if (label_number.Text[label_number.Text.Length - 1].ToString() == ",")
                        {
                            label_comma.Visible = true;
                        }
                        else
                        {
                            label_comma.Visible = false;
                        }
                    }

                    comma = false;

                    // Check for comma
                    for (int i = 0; i < label_number.Text.Length; i++)
                    {
                        if (label_number.Text[i].ToString() == ",") comma = true;
                    }

                    SetNumberLabelSize();
                }
                else if (obj.Name == "button_divide" || obj.Name == "button_multiply" || obj.Name == "button_subtract" || obj.Name == "button_add") // / * - +
                {
                    if (label_number.Text != String.Empty && label_number.Text != "Invalid Format")
                    {
                        if (label_number.Text != "!Error" && (label_input.Text.Length + label_number.Text.Length) < 80)
                        {
                            // If last character in number is a comma, remove it
                            if (label_number.Text[label_number.Text.Length - 1].ToString() == ",")
                                label_number.Text = label_number.Text.Remove(label_number.Text.Length - 1);

                            // If equals has been pressed
                            if (label_input.Text != String.Empty && label_input.Text[label_input.Text.Length - 1].ToString() == "=")
                            {
                                label_input.Text = String.Empty;
                                operators.Clear();
                                numbers.Clear();
                            }

                            switch (obj.Name)
                            {
                                case "button_divide":
                                    RemoveCommaFromLabel();
                                    numbers.Add(Convert.ToDouble(label_number.Text));
                                    operators.Add("÷");
                                    label_input.Text += " " + label_number.Text + " ÷";
                                    label_comma.Visible = false;
                                    break;

                                case "button_multiply":
                                    RemoveCommaFromLabel();
                                    numbers.Add(Convert.ToDouble(label_number.Text));
                                    operators.Add("×");
                                    label_input.Text += " " + label_number.Text + " ×";
                                    label_comma.Visible = false;
                                    break;

                                case "button_subtract":
                                    RemoveCommaFromLabel();
                                    numbers.Add(Convert.ToDouble(label_number.Text));
                                    operators.Add("−");
                                    label_input.Text += " " + label_number.Text + " −";
                                    label_comma.Visible = false;
                                    break;

                                case "button_add":
                                    RemoveCommaFromLabel();
                                    numbers.Add(Convert.ToDouble(label_number.Text));
                                    operators.Add("+");
                                    label_input.Text += " " + label_number.Text + " +";
                                    label_comma.Visible = false;
                                    break;
                            }

                            label_number.Text = String.Empty;
                            comma = false;
                        }
                    }
                    else if (label_number.Text == String.Empty && label_input.Text != String.Empty && label_input.Text[label_input.Text.Length - 1].ToString() != "=")
                    {
                        switch (obj.Name)
                        {
                            case "button_divide":
                                operators.RemoveAt(operators.Count - 1);
                                operators.Add("÷");
                                label_input.Text = label_input.Text.Remove(label_input.Text.Length - 1);
                                label_input.Text += "÷";
                                break;

                            case "button_multiply":
                                operators.RemoveAt(operators.Count - 1);
                                operators.Add("×");
                                label_input.Text = label_input.Text.Remove(label_input.Text.Length - 1);
                                label_input.Text += "×";
                                break;

                            case "button_subtract":
                                operators.RemoveAt(operators.Count - 1);
                                operators.Add("−");
                                label_input.Text = label_input.Text.Remove(label_input.Text.Length - 1);
                                label_input.Text += "−";
                                break;

                            case "button_add":
                                operators.RemoveAt(operators.Count - 1);
                                operators.Add("+");
                                label_input.Text = label_input.Text.Remove(label_input.Text.Length - 1);
                                label_input.Text += "+";
                                break;
                        }
                    }
                }
                else if (obj.Name == "button_comma") // Comma
                {
                    if (label_number.Text.Length < 23)
                    {
                        // If invalid format
                        if (label_number.Text == "Invalid Format")
                        {
                            label_number.Text = String.Empty;
                        }

                        // If equals has been pressed
                        if (label_input.Text != String.Empty && label_input.Text[label_input.Text.Length - 1].ToString() == "=")
                        {
                            label_input.Text = String.Empty;
                            label_number.Text = String.Empty;
                            operators.Clear();
                            numbers.Clear();
                            comma = false;
                        }

                        if (!comma)
                        {
                            if (label_number.Text != String.Empty)
                            {
                                label_comma.Text = label_number.Text.Insert(0, ",");
                                label_number.Text += ",";
                                label_comma.Visible = true;
                            }
                            else
                            {
                                label_number.Text = "0,";
                                label_comma.Text = ",0";
                                label_comma.Visible = true;
                            }
                        }

                        comma = true;

                        SetNumberLabelSize();
                    }
                }
                else if (obj.Name == "button_equals") // Calculate equation
                {
                    if (operators.Count != 0 && numbers.Count != 0 && label_number.Text != "Invalid Format")
                    {
                        // Make sure operators list is not same size as numbers list AND number is not empty
                        if (operators.Count == numbers.Count && label_number.Text == String.Empty)
                        {
                            operators.RemoveAt(operators.Count - 1);
                            label_input.Text = label_input.Text.Remove(label_input.Text.Length - 2);
                            label_input.Text += " " + label_number.Text + " =";
                        }
                        else
                        {
                            numbers.Add(Convert.ToDouble(label_number.Text));
                            label_input.Text += " " + label_number.Text + " =";
                        }

                        label_comma.Visible = false;
                        
                        CalculateEquation();
                        SetNumberLabelSize();
                    }
                }
                else // Number input
                {
                    // If invalid format
                    if (label_number.Text == "Invalid Format")
                    {
                        label_number.Text = String.Empty;
                    }

                    // If equals has been pressed
                    if (label_input.Text != String.Empty)
                    {
                        if (label_input.Text[label_input.Text.Length - 1].ToString() == "=")
                        {
                            label_input.Text = String.Empty;
                            label_number.Text = String.Empty;
                            operators.Clear();
                            numbers.Clear();
                            comma = false;
                        }
                    }
                    
                    if (label_number.Text.Length < 23)
                    {
                        if (obj.Name != "button_0")
                        {
                            if (label_number.Text.Length == 1 && label_number.Text == "0")
                            {
                                label_number.Text = obj.Name[obj.Name.Length - 1].ToString();
                            }
                            else
                            {
                                label_number.Text += obj.Name[obj.Name.Length - 1].ToString();
                            }
                        }
                        else
                        {
                            if (label_number.Text != "0") label_number.Text += "0";
                        }

                        label_comma.Visible = false;
                        SetNumberLabelSize();
                    }
                }
            }
        }

        private void ContextMenuLeftClick(object sender, EventArgs e)
        {
            var tab = sender as ToolStripMenuItem;

            if (tab.Name == "copyToolStripMenuItem") // Copy
            {
                double clipboardNumber = Convert.ToDouble(label_number.Text);

                Clipboard.SetText(clipboardNumber.ToString());
            }
            else if (tab.Name ==  "pasteToolStripMenuItem") // Paste
            {
                string clipboardText = Clipboard.GetText();
                clipboardText = clipboardText.Replace(" ", "").Replace(".", ",").Trim(',');
                RemoveCommaFromNumber(ref clipboardText);

                bool containsNonDigitValue = false;
                bool commaFound = false;

                // Check if clipboard contains non digit value
                for (int i = 0; i < clipboardText.Length; i++)
                {
                    if (!Char.IsDigit(clipboardText[i]) && clipboardText[i].ToString() != ",")
                        containsNonDigitValue = true;

                    if (commaFound)
                    {
                        if (clipboardText[i].ToString() == ",")
                        {
                            containsNonDigitValue = true;
                        }
                    }
                    else
                    {
                        if (clipboardText[i].ToString() == ",")
                        {
                            commaFound = true;
                        }
                    }
                }

                // If non digit value was not found, paste clipboard to calculator. Otherwise return Invalid Format
                if (!containsNonDigitValue)
                {
                    if (clipboardText[clipboardText.Length - 1].ToString() == ",")
                        clipboardText = clipboardText.Remove(clipboardText.Length - 1);

                    label_number.Text = clipboardText;
                    SetNumberLabelSize();

                    if (label_input.Text != String.Empty && label_input.Text[label_input.Text.Length - 1].ToString() == "=")
                    {
                        label_input.Text = String.Empty;
                        operators.Clear();
                        numbers.Clear();
                    }
                }
                else
                {
                    label_number.Text = "Invalid Format";

                    if (label_input.Text != String.Empty && label_input.Text[label_input.Text.Length - 1].ToString() == "=")
                    {
                        label_input.Text = String.Empty;
                        operators.Clear();
                        numbers.Clear();
                    }
                }
            }
        }

        private void MouseTitleDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            drag = true;
        }

        private void MouseTitleUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        // Mouse move
        private void MouseTitleMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p1 = PointToScreen(e.Location);   // Get mouse coordinates in relation to the current monitor.
                this.Location = new Point(p1.X - startPoint.X, p1.Y - startPoint.Y);    // Apply coordinates.
            }
        }

        // Mouse enter/leave
        private void MouseOver(object sender, EventArgs e)
        {
            var button = (sender as Label);

            if (button.Name.Contains("button_"))
            {
                if (button.Name != "button_quit")
                {
                    button.BackColor = Color.FromArgb(255, 71, 69, 67);
                }
                else
                {
                    button.BackColor = Color.Brown;
                }
            }
        }

        private void MouseExit(object sender, EventArgs e)
        {
            foreach (Label label in this.Controls.OfType<Label>())
            {
                if (label.BackColor == Color.FromArgb(255, 71, 69, 67) || label.BackColor == Color.Brown)
                {
                    switch (label.Tag.ToString())
                    {
                        case "gray1":
                            label.BackColor = Color.FromArgb(255, 49, 48, 47);
                            break;

                        case "gray2":
                            label.BackColor = Color.FromArgb(255, 35, 35, 35);
                            break;

                        case "gray3":
                            label.BackColor = Color.FromArgb(255, 19, 19, 19);
                            break;

                        case "gray4":
                            label.BackColor = Color.FromArgb(255, 6, 6, 6);
                            break;
                    }
                }
            }
        }

        
    }
}
