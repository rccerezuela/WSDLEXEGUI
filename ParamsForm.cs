using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSDLEXEGUI
{
    public partial class ParamsForm : Form
    {
        private WSDLCommandBuildHelper wsdlCommandBuildHelper;
        public ParamsForm()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        private void generate_click(object sender, EventArgs e)
        {
            OutputText.Text = "Generating...";

            string wsdlPath = wsdlExePath.Text;
            

            wsdlCommandBuildHelper = new WSDLCommandBuildHelper();
            wsdlCommandBuildHelper.generateWsdlExeBinPath(wsdlExePath.Text);
            wsdlCommandBuildHelper.generateWsdlClassFileWithPath(classOutputPath.Text, ClassOutputName.Text);
            wsdlCommandBuildHelper.generateAuth(wsdlURIUser.Text, wsdlURIPassword.Text);
            wsdlCommandBuildHelper.generateNameSpace(classOutputNamespace.Text);
            wsdlCommandBuildHelper.generateWsdlURI(wsdlURI.Text);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WorkingDirectory = classOutputPath.Text;
            process.StartInfo.UseShellExecute = false;
            //process.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v10.0A\\bin\\NETFX 4.8 Tools\\wsdl";
            process.StartInfo.FileName = wsdlCommandBuildHelper.getCommandPath();
            process.StartInfo.Arguments = wsdlCommandBuildHelper.getCommandArguments();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.Close();

            OutputText.Text = output;

         
        }

    }
}
