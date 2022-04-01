using System.Text;

namespace WinFormsApp_JustFields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string varToken = "<item>";
        const string varSeperator = "->";
        private void button1_Click(object sender, EventArgs e)
        {
            //Run through the input
            StringBuilder varInputString = new StringBuilder();
            string varInput = string.Empty;
            foreach (string line in RTBInput.Lines)
            {
                //Apply pre filter
                varInput = line;
                //Apply main filter
                if (RTBMainFilter.Text.Length > 0 && line.Length > 0)
                    varInput = RTBMainFilter.Text.Replace('\n', ' ').Trim().Replace(varToken, line);

                string[] separatingStrings = { "->" };

                if (RTBPreFilter.Text.Length > 0 && line.Length > 0)
                {
                    string[] words = RTBPreFilter.Text.Replace('\n',' ').Trim().Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                    if(words.Length == 2)
                    {
                        varInput = varInput.Replace(words[0], words[1]);
                    }
                }

                //put in output
                if (varInput.Length > 0)
                    varInputString.AppendLine(varInput);
            }
            RTBOutput.Text = varInputString.ToString();
            Clipboard.SetDataObject(varInputString.ToString());
            varInputString.Clear();
            
        }

        private void BTNDemo_Click(object sender, EventArgs e)
        {
            RTBInput.Clear();
            RTBMainFilter.Clear();
            RTBPreFilter.Clear();
            RTBOutput.Clear();

            if(RTBInput != null && RTBInput.Text != null)
            {
                RTBInput.Text += "Field1\n";
                RTBInput.Text += "Field2\n";
                RTBInput.Text += "Field3\n";
                RTBInput.Text += "Field4\n";
            }

            if (RTBPreFilter != null && RTBPreFilter.Text != null)
            {
                RTBPreFilter.Text += "Field->ProcessField\n";
            }

            if (RTBMainFilter != null && RTBMainFilter.Text != null)
            {
                RTBMainFilter.Text += "var<item> = 0;\n";
            }
        }
    }
}